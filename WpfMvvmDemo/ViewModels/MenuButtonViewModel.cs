using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using WpfMvvmDemo.Models.Button;
using WpfMvvmDemo.Services;

namespace WpfMvvmDemo.ViewModels
{
    public class MenuButtonViewModel
    {
        public AButton MenuButton { get; set; }

        public MenuButtonViewModel(AButton menuButton)
        {
            MenuButton = menuButton;
        }
    }
}
