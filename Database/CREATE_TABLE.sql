CREATE TABLE TB_CAR
(
    CAR_PLATE CHAR(7),
    CAR_NAME VARCHAR(20),
    CAR_COLOR VARCHAR(20),
    MODEL_YEAR INT,
    FABRICATION_YEAR INT
    CONSTRAINT PK_CAR PRIMARY KEY(CAR_PLATE)
)

CREATE TABLE TB_SERVICE
(
    ID INT IDENTITY(1,1),
    DESCRIPTION_SERVICE VARCHAR(50),
    CONSTRAINT PK_SERVICE PRIMARY KEY(ID)
)

CREATE TABLE TB_CAR_SERVICE
(
    ID INT IDENTITY(1,1),
    CAR_ID CHAR(7),
    SERVICE_ID INT,
    STATUS_SERVICE BIT
    CONSTRAINT PK_CAR_SERVICE PRIMARY KEY(ID)
    CONSTRAINT FK_CAR FOREIGN KEY(CAR_ID) REFERENCES TB_CAR(CAR_PLATE),
    CONSTRAINT FK_SERVICE FOREIGN KEY (SERVICE_ID) REFERENCES TB_SERVICE(ID)
)

CREATE TABLE TB_ADRESS
(
    ID INT IDENTITY(1,1),
    PUBLIC_PLACE VARCHAR(50),
    ZIP_CODE VARCHAR(10),
    DISTRICT VARCHAR(50),
    PUBLIC_PLACE_TYPE VARCHAR(20),
    COMPLEMENT VARCHAR(50),
    NUMBER_ADRESS INT,
    UF CHAR(2),
    CITY VARCHAR(50)
    CONSTRAINT PK_ADRESS PRIMARY KEY(ID),
)

CREATE TABLE TB_PERSON
(
    CPF VARCHAR(14),
    PERSON_NAME VARCHAR(50),
    DATE_OF_BIRTH DATETIME,
    ID_ADRESS INT,
    PHONE VARCHAR(20),
    EMAIL VARCHAR(20)
    CONSTRAINT PK_PERSON PRIMARY KEY(CPF),
    CONSTRAINT FK_PERSON_ADRESS FOREIGN KEY (ID_ADRESS) REFERENCES TB_ADRESS(ID)
)

CREATE TABLE TB_CLIENT
(
    CPF VARCHAR(14),
    INCOME NUMERIC(10,2),
    PDF_DOCUMENT VARCHAR(100),
    CONSTRAINT PK_CLIENT PRIMARY KEY(CPF),
    CONSTRAINT FK_PERSON_CLIENT FOREIGN KEY (CPF) REFERENCES TB_PERSON(CPF)
)

CREATE TABLE TB_ROLE
(
    ID INT IDENTITY(1,1),
    DESCRIPTION_ROLE VARCHAR(50),
    CONSTRAINT PK_ROLE PRIMARY KEY(ID)
)

CREATE TABLE TB_EMPLOYEE
(
    CPF VARCHAR(14),
    INCOME NUMERIC(10,2),
    INCOME_VALUE NUMERIC(10,2),
    ID_ROLE INT,
    CONSTRAINT PK_EMPLOYEE PRIMARY KEY(CPF),
    CONSTRAINT FK_PERSON_EMPLOYEE FOREIGN KEY (CPF) REFERENCES TB_PERSON(CPF),
    CONSTRAINT FK_ROLE_EMPLOYEE FOREIGN KEY (ID_ROLE) REFERENCES TB_ROLE(ID)
)

CREATE TABLE TB_CREDIT_CARD
(
    ID INT IDENTITY(1,1),
    CARD_NUMBER VARCHAR(50),
    SECURITY_CODE CHAR(3),
    EXPIRATION_DATE VARCHAR(10),
    CARD_HOLDER_NAME VARCHAR(50),
    CONSTRAINT PK_CREDIT_CARD PRIMARY KEY(ID)
)

CREATE TABLE TB_TICKET
(
    ID INT IDENTITY(1,1),
    TICKET_NUMBER INT,
    EXPIRATION_DATE VARCHAR(10),
    CONSTRAINT PK_TICKET PRIMARY KEY(ID)
)

CREATE TABLE TB_TYPE_PIX
(
    ID INT IDENTITY(1,1),
    DESCRIPTION_PIX VARCHAR(50),
    CONSTRAINT PK_TYPE_PIX PRIMARY KEY (ID)
)

CREATE TABLE TB_PIX
(
    ID INT IDENTITY(1,1),
    TYPE_PIX_ID INT,
    PIX_KEY VARCHAR(50),
    CONSTRAINT PK_PIX PRIMARY KEY(ID),
    CONSTRAINT FK_PIX_TYPE_PIX FOREIGN KEY (ID) REFERENCES TB_TYPE_PIX(ID)
)

CREATE TABLE TB_PAYMENT
(
    ID INT IDENTITY(1,1),
    CREDIT_CARD_ID INT,
    TICKET_ID INT,
    PIX_ID INT,
    PAYMENT_DATE DATETIME,
    CONSTRAINT PK_PAYMENT PRIMARY KEY (ID),
    CONSTRAINT FK_PAYMENT_CREDIT_CARD FOREIGN KEY (CREDIT_CARD_ID) REFERENCES TB_CREDIT_CARD(ID),
    CONSTRAINT FK_PAYMENT_TICKET FOREIGN KEY (CREDIT_CARD_ID) REFERENCES TB_TICKET(ID),
    CONSTRAINT FK_PAYMENT_PIX FOREIGN KEY (CREDIT_CARD_ID) REFERENCES TB_PIX(ID),
)

CREATE TABLE TB_SALE
(
    ID INT IDENTITY(1,1),
    CAR_ID CHAR(7),
    SALE_DATE DATETIME,
    SALE_VALUE NUMERIC(10,2),
    CLIENT_ID VARCHAR(14),
    EMPLOYEE_ID VARCHAR(14),
    PAYMENT_ID INT,
    CONSTRAINT FK_SALE_CAR FOREIGN KEY(CAR_ID) REFERENCES TB_CAR(CAR_PLATE),
    CONSTRAINT FK_SALE_CLIENT FOREIGN KEY(CLIENT_ID) REFERENCES TB_CLIENT(CPF),
    CONSTRAINT FK_SALE_EMPLOYEE FOREIGN KEY(EMPLOYEE_ID) REFERENCES TB_EMPLOYEE(CPF),
    CONSTRAINT FK_SALE_PAYMENT FOREIGN KEY(PAYMENT_ID) REFERENCES TB_PAYMENT(ID),
)

CREATE TABLE TB_PURCHASE
(
    ID INT IDENTITY(1,1),
    CAR_ID CHAR(7),
    PURCHASE_VALUE NUMERIC(10,2),
    PURCHASE_DATE DATETIME,
    CONSTRAINT FK_PURCHASE_CAR FOREIGN KEY(CAR_ID) REFERENCES TB_CAR(CAR_PLATE)
)