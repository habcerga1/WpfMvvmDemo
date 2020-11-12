using System;
using System.Collections.Generic;
using System.Text;

namespace WpfMvvmDemo.Models.Button
{
    class ButtonStyleB : AButton
    {
        public ButtonStyleB(string _content) : base()
        {
            content = _content;
            fontColor = "#33B5FF";
            fontColorNormal = "#33B5FF";
            fontColorMouseEnter = "#E933FF";
            fontSize = 12;
        }
    }
}
