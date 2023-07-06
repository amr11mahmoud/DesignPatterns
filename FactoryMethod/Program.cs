using FactoryMethod;

VechileFactory vechileFactory = new VechileFactory();

Console.WriteLine("Enter name:");
string name = Console.ReadLine();

Console.WriteLine("Enter Model:");
string model = Console.ReadLine();

Console.WriteLine("Enter type:");
int type = Int32.Parse(Console.ReadLine());

IVehicle vechile = vechileFactory.getVehicle(name, model, type);

vechile.StartEngine();
vechile.Drive();
