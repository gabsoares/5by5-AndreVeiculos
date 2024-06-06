using Controllers;
using Models;
using Service;

Car car = new()
{
    CarPlate = new CarService().GenerateCarPlate(),
    CarName = "Marea Turbo 2.0",
    ModelYear = 2000,
    FabricationYear = 1999,
    CarColor = "Preto",
    IsSold = false
};

Job job = new()
{
    Description = "Manutencao geral"
};

CarJob carJob = new()
{
    Car = new Car { CarPlate = "KMS7341" },
    Job = new Job { Id = 1 },
    Status = true
};

Adress adress = new()
{
    PublicPlace = "Zero Meia",
    ZipCode = "14801000",
    District = "Jardim Bairro",
    PublicPlateType = "Rua",
    Complement = "N/A",
    Number = 1030,
    UF = "SP",
    City = "Araraquara"
};

Client client = new()
{
    CPF = "123.456.789.00",
    Name = "Gabriel Soares",
    DateOfBirth = DateTime.Parse("11/03/2001"),
    Adress = new Adress() { Id = 1 },
    Phone = "1181012932",
    Email = "soaresgabriel68@gmail.com",
    Income = 2500.00m,
    PDFDocument = "Documento1.pdf"
};

Role role = new()
{
    Description = "Vendedor"
};

Employee employee = new()
{
    CPF = "132.231.432.05",
    Name = "Jose da Silva",
    DateOfBirth = DateTime.Parse("11/01/2000"),
    Adress = new Adress() { Id = 1 },
    Phone = "11982321234",
    Email = "jose@5by5.com",
    Comission = 35.0m,
    ComissionValue = 210.50m,
    Role = new Role() { Id = 1 },
};

//Console.WriteLine(new CarController().InsertCar(car) ? "Sucesso ao inserir carro!" : "Erro ao inserir carro!");
//Console.WriteLine(new CarJobController().InsertCarJob(carJob) ? "Sucesso ao inserir carro-servico" : "Erro ao inserir carro-servico");
//Console.WriteLine(new JobController().InsertJob(job) ? "Sucesso ao inserir servico!" : "Erro ao inserir servico!");
//Console.WriteLine(new AdressController().InsertAdress(adress) ? "Sucesso ao inserir endereco!" : "Erro ao inserir endereco!");
//Console.WriteLine(new ClientController().InsertClient(client) ? "Sucesso ao inserir cliente!" : "Erro ao inserir cliente!");
//Console.WriteLine(new EmployeeController().InsertEmployee(employee) ? "Sucesso ao inserir funcionario!" : "Erro ao inserir funcionario!");
//Console.WriteLine(new RoleController().InsertRole(role) ? "Sucesso ao inserir cargo!" : "Erro ao inserir cargo!");