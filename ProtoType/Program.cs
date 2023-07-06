using ProtoType;



Person employeePrototype = new Employee
{
    Name = "Ahmed",
    Age = 30,
    Address = new Address
    {
        BuildingNo = 5,
        City = "Cairo"
    }
};

Console.WriteLine("--------------- Shallow Cloning ----------------");
Employee shallowClonedEmployee = (Employee)employeePrototype.ShallowClone();

Console.WriteLine("--------------- before changes -----------------");
Console.WriteLine($"Original: {employeePrototype.ToString()}");
Console.WriteLine($"Clone: {shallowClonedEmployee.ToString()}");

shallowClonedEmployee.Address.City = "Alexandria";

Console.WriteLine("--------------- after changes -----------------");
Console.WriteLine($"Original: {employeePrototype.ToString()}");
Console.WriteLine($"Clone: {shallowClonedEmployee.ToString()}");


Console.WriteLine("--------------- Deep Cloning -----------------");
Employee deepClonedEmployee = (Employee)employeePrototype.DeepClone();

Console.WriteLine("--------------- before changes -----------------");
Console.WriteLine($"Original: {employeePrototype.ToString()}");
Console.WriteLine($"Clone: {deepClonedEmployee.ToString()}");

shallowClonedEmployee.Address.City = "Dahab";

Console.WriteLine("--------------- after changes -----------------");
Console.WriteLine($"Original: {employeePrototype.ToString()}");
Console.WriteLine($"Clone: {deepClonedEmployee.ToString()}");
