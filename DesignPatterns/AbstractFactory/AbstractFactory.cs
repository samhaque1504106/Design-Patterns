using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace AbstractFactory
{
    // Step 1: Abstract Product A
    public interface IButton
    {
        void Paint();
    }

    // Step 2: Abstract Product B
    public interface ICheckBox
    {
        void Paint();
    }

    // Step 3: Concrete Product A1
    public class WinButton : IButton
    {
        public void Paint()
        {
            Console.WriteLine("rendering windows button");
        }
    }

    //step 4: Concrete Product B1
    public class WinCheckBox : ICheckBox
    {
        public void Paint()
        {
            Console.WriteLine("rendering windows checkbox");
        }
    }
    // Step 5: Concrete Product A2
    public class MacButton : IButton
    {
        public void Paint()
        {
            Console.WriteLine("rendering mac button");
        }
    }

    //step 6: Concrete Product B2
    public class MacCheckBox : ICheckBox
    {
        public void Paint()
        {
            Console.WriteLine("rendering mac checkbox");
        }
    }

    // Step 7: Abstract Factory
    public interface IGUIFactory
    {
        IButton CreateButton();
        ICheckBox CreateCheckBox();
    }

    // Step 8: Concrete Factory 1
    public class WinFactory : IGUIFactory
    {
        public IButton CreateButton()
        {
            return new WinButton();
        }

        public ICheckBox CreateCheckBox()
        {
            return new WinCheckBox();
        }
    }

    // Step 9: Concrete Factory 2
    public class MacFactory : IGUIFactory
    {
        public IButton CreateButton()
        {
            return new MacButton();
        }

        public ICheckBox CreateCheckBox()
        {
            return new MacCheckBox();
        }
    }

    //step 10: client
    public class Application
    {
        private readonly IButton _button;
        private readonly ICheckBox _checkBox;

        public Application(IGUIFactory factory)
        {
            // Use factory to create compatible button and checkbox
            _button = factory.CreateButton();
            _checkBox = factory.CreateCheckBox();
        }

        public void RenderUI()
        {
            _button.Paint();
            _checkBox.Paint();
        }
    }



    public class AbstractFactory
    {
    }

    public class Program
    {
        public static void Main(string[] args)
        {

            // Example usage of Abstract Factory
            IGUIFactory factory;

            // In a real-world scenario, this could be decided by OS check or config
            factory = new WinFactory();  // Swap with MacFactory() for Mac components

            Application app = new Application(factory);
            app.RenderUI();

            // Output:
            // Rendering Windows Button
            // Rendering Windows Checkbox
        }

    }

    
}
