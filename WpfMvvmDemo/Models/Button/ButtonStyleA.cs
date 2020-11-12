using System;
using System.Collections.Generic;
using System.Text;

namespace WpfMvvmDemo.Models.Button
{
    class ButtonStyleA : AButton
    {
       public ButtonStyleA(string _content) : base()
        {
            content = _content;
            base.fontColor = "#FF5733";
            base.fontColorNormal = "#FF5733";
            base.fontColorMouseEnter = "#61FF33";
            fontSize = 16;
        }
    }
}
