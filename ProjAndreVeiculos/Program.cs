using Controllers;
using Models;
using Service;

InsertDataTest();

void InsertDataTest()
{
    //Tipos de pagamento
    PixType pixType = new()
    {
        Description = "CPF"
    };

    //int pixTypeId = new PixTypeController().InsertPixType(pixType);
    //pixType.Id = pixTypeId;

    Pix pix = new()
    {
        PixKey = "111.222.333.44",
        PixType = new PixType { Id = pixType.Id }
    };

    //int pixId = new PixController().InsertPix(pix);
    //pix.Id = pixId;

    Ticket ticket = new()
    {
        ExpirationDate = new DateTime(2024, 05, 10),
        Number = 123321
    };

    //int ticketId = new TicketController().InsertTicket(ticket);
    //ticket.Id = ticketId;

    //CreditCard card = new()
    //{
    //    CardNumber = "1234 5678 9012 3456",
    //    SecurityCode = "023",
    //    ExpirationDate = "08/30",
    //    CardHolderName = "GABRIEL V SOARES"
    //};

    //new CreditCardController().InsertCreditCard(card);

    ////Pagamento
    //Payment payment = new()
    //{
    //    Ticket = new Ticket { Id = 1 },
    //    CreditCard = new CreditCard { Id = 1 },
    //    Pix = new Pix { Id = 1 },
    //    PaymentDate = new DateTime(2024, 05, 06)
    //};

    //new PaymentController().InsertPayment(payment);

    ////Cargo
    //Role role = new() { Description = "Vendedor" };
    //new RoleController().InsertRole(role);

    ////Endereco
    //Adress adress = new()
    //{
    //    PublicPlace = "Zero",
    //    ZipCode = "14801555",
    //    District = "Jardim Bairro",
    //    PublicPlateType = "Avenida",
    //    Complement = "N/A",
    //    Number = 534,
    //    UF = "SP",
    //    City = "Araraquara"
    //};

    //new AdressController().InsertAdress(adress);

    ////Cliente
    //Client client = new()
    //{
    //    CPF = "123.456.789.00",
    //    Name = "Gabriel Soares",
    //    DateOfBirth = new DateTime(2001, 03, 11),
    //    Adress = new Adress { Id = 1 },
    //    Phone = "16912344321",
    //    Email = "gabriel@5by5.com",
    //    Income = 1300.00m,
    //    PDFDocument = "documento.pdf",
    //};

    //new ClientController().InsertClient(client);

    ////Funcionario
    //Employee employee = new()
    //{
    //    CPF = "132.231.432.05",
    //    Name = "Jose da Silva",
    //    DateOfBirth = new DateTime(2000, 01, 15),
    //    Adress = new Adress { Id = 2 },
    //    Phone = "11982321234",
    //    Email = "jose@5by5.com",
    //    Comission = 35.0m,
    //    ComissionValue = 210.50m,
    //    Role = new Role { Id = 1 },
    //};

    //new EmployeeController().InsertEmployee(employee);

    ////Carro
    //Car car = new()
    //{
    //    CarPlate = new CarService().GenerateCarPlate(),
    //    CarName = "Marea Turbo 2.0",
    //    ModelYear = 2000,
    //    FabricationYear = 1999,
    //    CarColor = "Preto",
    //    IsSold = false
    //};

    //new CarController().InsertCar(car);

    ////Servico
    //Job job = new() { Description = "Lava-tudo" };
    //new JobController().InsertJob(job);

    ////Carro-Servico
    //CarJob carJob = new()
    //{
    //    Car = car,
    //    Job = new Job { Id = 1 },
    //    Status = true
    //};

    //new CarJobController().InsertCarJob(carJob);


    ////Venda
    //Sale sale = new()
    //{
    //    Client = client,
    //    Employee = employee,
    //    Payment = new Payment { Id = 1 },
    //    SaleDate = new DateTime(2024, 03, 05),
    //    SaleValue = 100000.00m,
    //    Car = car
    //};

    //new SaleController().InsertSale(sale);

    //Purchase purchase = new()
    //{
    //    Car = car,
    //    Price = 150000.00m,
    //    PurchaseDate = new DateTime(2024, 02, 28)
    //};

    //new PurchaseController().InsertPurchase(purchase);
}

int Menu()
{
    Console.Clear();
    Console.WriteLine("<<<<<<<<<<ANDRE VEICULOS>>>>>>>>>>");
    Console.WriteLine("[ 1 ]  Funcionario");
    Console.WriteLine("[ 2 ]  Cliente");
    Console.WriteLine("[ 3 ]  Veiculo");
    Console.WriteLine("[ 0 ]  Sair do programa");
    Console.Write("Insira uma das opcoes validas [ 0 - 9 ]:< > \b\b\b");

    int option = ReturnInt();
    return option;
}

void ChamarMenu()
{
    bool terminouMenu = false;
    do
    {
        switch (Menu())
        {
            case 1:

                break;
            case 2:

                break;
            case 3:

                break;
            case 0:
                Console.WriteLine("Encerrando o programa.");
                terminouMenu = true;
                break;
            default:
                Console.WriteLine("Opção inválida.");
                break;
        }
    } while (!terminouMenu);
}

int ReturnInt()
{
    int intNumber = 0;
    bool ex = false;

    while (!ex)
    {
        if (int.TryParse(Console.ReadLine(), out int varint))
        {
            intNumber = varint;
            ex = true;
        }
        else
        {
            Console.WriteLine("Formato inválido. Informe números inteiros apenas.");
        }
    }
    return intNumber;
}