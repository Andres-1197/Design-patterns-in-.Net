using Design_patterns_in_C_.AbstractFactory.ConcreteClasses.Windows;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_patterns_in_C_.AbstractFactory.Factories
{
    public class WinFactory : IThemeFactory
    {
        public IButton CreateButtom()
        {
            return new WinButton();
        }

        public IDropDown CreateDropDown()
        {
            return new WinDropDown();
        }

        public ITextBox CreateTextBox()
        {
            return new WinTextBox();
        }
    }
}
