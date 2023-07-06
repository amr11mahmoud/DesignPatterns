using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    /// <summary>
    /// Director
    /// </summary>
    public class SmartFactory
    {
        private SmartProductBuilder? _builder;

        public SmartFactory() { }

        public void Construct(SmartProductBuilder smartProductBuilder)
        {
            _builder = smartProductBuilder;
            _builder.AddButton();
            _builder.AddLed();
        }

        public void ShowProduct()
        {
            Console.WriteLine(_builder?.smartProduct.ToString());
        }
    }

    /// <summary>
    /// Builder abstract class
    /// </summary>
    public abstract class SmartProductBuilder
    {
        public SmartProduct smartProduct { get; private set; }

        public SmartProductBuilder(string deviceType)
        {
            smartProduct = new SmartProduct(deviceType);
        }

        public abstract void AddButton();
        public abstract void AddLed();

    }

    /// <summary>
    /// ConcreteBuilder1 class
    /// </summary>
    public class SmartSwitch : SmartProductBuilder
    {
        public SmartSwitch():base("SmartSwitch")
        {
            
        }

        public override void AddButton()
        {
            smartProduct.AddEntity("SwitchButton");
        }

        public override void AddLed()
        {
            smartProduct.AddEntity("SwitchLed");
        }
    }

    /// <summary>
    /// ConcreteBuilder2 class
    /// </summary>
    public class SmartPlug: SmartProductBuilder
    {
        public SmartPlug() : base("SmartPlug")
        {

        }

        public override void AddButton()
        {
            smartProduct.AddEntity("PlugButton");
        }

        public override void AddLed()
        {
            smartProduct.AddEntity("PlugLed");
        }
    }

    /// <summary>
    /// Product class
    /// </summary>
    public class SmartProduct
    {
        private readonly List<string> _lines = new List<string>();
        private readonly string _deviceType;

        public SmartProduct(string deviceType)
        {
            _deviceType = deviceType;
        }

        public void AddEntity(string line)
        {
            _lines.Add(line);
        }

        public override string ToString()
        {
            var sb = new StringBuilder();

            foreach (string line in _lines)
            {
                sb.Append($"Smart product of type {_deviceType} has line {line}. ");
            }

            return sb.ToString();
        }
    }
}
