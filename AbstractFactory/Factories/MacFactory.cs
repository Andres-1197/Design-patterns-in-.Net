using Design_patterns_in_C_.AbstractFactory.ConcreteClasses.Mac;
using Design_patterns_in_C_.AbstractFactory.ConcreteClasses.Windows;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_patterns_in_C_.AbstractFactory.Factories
{
    public class MacFactory : IThemeFactory
    {
        public IButton CreateButtom()
        {
            return new MacButton();
        }

        public IDropDown CreateDropDown()
        {
            return new MacDropDown();
        }

        public ITextBox CreateTextBox()
        {
            return new MacTextBox();
        }
    }
}
