using Design_patterns_in_C_.AbstractFactory.ConcreteClasses.Linux;
using Design_patterns_in_C_.AbstractFactory.ConcreteClasses.Windows;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_patterns_in_C_.AbstractFactory.Factories
{
    public class LinuxFactory : IThemeFactory
    {
        public IButton CreateButtom()
        {
            return new LinuxButton();
        }

        public IDropDown CreateDropDown()
        {
            return new LinuxDropDown();
        }

        public ITextBox CreateTextBox()
        {
            return new LinuxTextBox();
        }
    }
}
