// See https://aka.ms/new-console-template for more information
using ConceptosPOO;

Console.WriteLine("Hello, World!");
Console.WriteLine("POO, Concepts");
Console.WriteLine("==============");

Employee employee1 = new SalaryEmployee
{
    Id = 3016,
    FirstName = "Carlos",
    LastName = "Lucrecio",
    BirthDate = new Date(1988, 04, 12),
    HiringDate = new Date(2022, 04, 13),
    IsActive = true,
    Salary = 18000
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
    CommissionPercentaje = 0.03f

};
//Console.WriteLine(employee2);

Employee employee3 = new HourlyEmployee
{
    Id = 2021,
    FirstName = "Roger",
    LastName = "Davila",
    BirthDate = new Date(1988, 04, 12),
    HiringDate = new Date(2022, 04, 07),
    IsActive = true,
    //Salary = 18000 -> no tiene salario
    //Sales = 320000000M->ya no tiene ventas
    //CommissionPercentaje->no gana comision
    HourValue = 12356.56M,
    Hours = 123.5F

};
//Console.WriteLine(employee3);

Employee employee4 = new BaseCommissionEmployee
{
    Id = 2021,
    FirstName = "Jonatan",
    LastName = "Davila",
    BirthDate = new Date(2017, 01, 12),
    HiringDate = new Date(2022, 01, 010),
    IsActive = true,
    Base = 860678.45M,
    Sales = 320000000M,
    CommissionPercentaje = 0.015f
};

//Console.WriteLine(employee4);

//Console.WriteLine(employee1);


//Date date1 = new Date(2022,05,17);
//try
//{
//    Console.WriteLine(new Date(2024, 06, 31));

//}
//catch (Exception error)
//{

//    Console.WriteLine(error.Message);
//}

ICollection<Employee> employees = new List<Employee>()
{
   //a mi lista de empleados adicione los siguientes impleados
    employee1, employee2, employee3, employee4
};

decimal payroll = 0;

//x cada Empleado, cada elemento empleado en mi coleccion de empleados
foreach (Employee employee in employees)
{
    Console.WriteLine(employee);
    payroll += employee.GetValueToPay();
}


Console.WriteLine("                  ===============");
Console.WriteLine($"TOTAL           {$"{payroll:C2}",15}");

Invoice invoice1 = new()
{
    Description = "Iphone 13",
    Id = 1,
    Price = 27000M,
    Quantity = 6
};
Invoice invoice2 = new()
{
    Description = "Posta Premium",
    Id = 2,
    Price = 10000M,
    Quantity = 17.5F
};

Console.WriteLine(invoice1);
Console.WriteLine(invoice2);

