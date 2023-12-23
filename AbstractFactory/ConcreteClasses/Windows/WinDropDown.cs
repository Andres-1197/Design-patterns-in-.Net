using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_patterns_in_C_.AbstractFactory.ConcreteClasses.Windows
{
    public class WinDropDown : IDropDown
    {
        public void Render()
        {
            Console.WriteLine("Rendering Windows DropDown");
        }
    }
}
