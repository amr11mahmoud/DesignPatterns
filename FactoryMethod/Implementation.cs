using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    /// <summary>
    /// 
    /// IFactory -> 
    /// Factory
    /// 
    /// Iproduct
    /// ProudctA -> get created by factory 
    /// ProductB -> get created by factory 
    /// 
    /// </summary>
    /// 
    public interface IVehicleFactory
    {

        // Method to return object of type Product

        IVehicle getVehicle(string name, string model, int type);
    }

    public class VechileFactory : IVehicleFactory
    {
        public VechileFactory()
        {
        }

        public IVehicle getVehicle(string name, string model, int type)
        {
            IVehicle vehicle = new Car
            {
                Name = name,
                Type = model
            };

            if (type == 2)
            {
                vehicle = new MotorCycle
                {
                    Name = name,
                    Type = model
                };
            }

            return vehicle;
        }
    }



    public interface IVehicle
    {
        string Name { get; set; }
        string Type { get; set; }

        void StartEngine();
        void Drive();

    }

    public class Car : IVehicle
    {
        public string Name { get; set; }
        public string Type { get; set; }

        public void Drive()
        {
            Console.WriteLine($"Drive from Car {Name}");
        }

        public void StartEngine()
        {
            Console.WriteLine($"Start Engine from Car {Name}");
        }
    }

    public class MotorCycle : IVehicle
    {
        public string Name { get; set; }
        public string Type { get; set; }

        public void Drive()
        {
            Console.WriteLine($"Drive from MotorCycle {Name}");
        }

        public void StartEngine()
        {
            Console.WriteLine($"Start Engine from MotorCycle{Name}");
        }
    }
}
