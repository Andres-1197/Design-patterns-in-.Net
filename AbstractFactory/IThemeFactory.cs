using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_patterns_in_C_.AbstractFactory
{
    public interface IThemeFactory
    {
        IButton CreateButtom();
        IDropDown CreateDropDown();
        ITextBox CreateTextBox();
    }
}
