// See https://aka.ms/new-console-template for more information
using ConceptosPOO;

Console.WriteLine("Hello, World!");
Console.WriteLine("POO, Concepts");
Console.WriteLine("==============");

Employee employee1 = new SalaryEmployee
{
    Id=3016,
    FirstName="Carlos",
    LastName="Lucrecio",
    BirthDate= new Date(1988,04,12),
    HiringDate= new Date(2022,04,13),
    IsActive= true,
    Salary=18000
};

Employee employee2 = new CommissionEmployee
{
    Id = 2020,
    FirstName = "Patricia",
    LastName = "Gutierrez",
    BirthDate = new Date(1990, 04, 10),
    HiringDate = new Date(2022, 05, 15),
    IsActive = true,
    //Salary = 18000 -> no tiene salario
    Sales = 320000000M,
    CommissionPercentaje=0.03f

};

//Console.WriteLine(employee1);
Console.WriteLine(employee2);

//Date date1 = new Date(2022,05,17);
//try
//{
//    Console.WriteLine(new Date(2024, 06, 31));

//}
//catch (Exception error)
//{

//    Console.WriteLine(error.Message);
//}





