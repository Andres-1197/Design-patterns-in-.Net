using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_patterns_in_C_.AbstractFactory.ConcreteClasses.Mac
{
    public class MacTextBox : ITextBox
    {
        public void Render()
        {
            Console.WriteLine("Rendering Mac Textbox");
        }
    }
}
