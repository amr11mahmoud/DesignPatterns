using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProtoType
{
    /// <summary>
    /// ProtoType
    /// </summary>
    public abstract class Person
    {
        public string? Name { get; set; }
        public int Age { get; set; }
        public Address? Address { get; set; }

        public abstract Person ShallowClone();
        public abstract Person DeepClone();

        public override string ToString()
        {
            return $@"Name:{Name} Age:{Age} Address {Address?.BuildingNo.ToString()} {Address?.City} ";
        }

    }

    public class Employee : Person
    {
        public override Person DeepClone()
        {
            Employee emp = (Employee)this.MemberwiseClone();

            emp.Address = new Address
            {
                BuildingNo = Address.BuildingNo,
                City = Address.City
            };

            return emp;
        }

        public override Person ShallowClone()
        {
            return (Employee)this.MemberwiseClone();
        }
    }

    public class Address
    {
        public int BuildingNo { get; set; }
        public string? City { get; set; }
    }
}
