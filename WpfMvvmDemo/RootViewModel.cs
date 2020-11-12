using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Channels;
using System.Threading.Tasks;
using WpfMvvmDemo.Models.Button;
using WpfMvvmDemo.Services;
using WpfMvvmDemo.ViewModels;

namespace WpfMvvmDemo
{
    public class RootViewModel : ObservableObject
    {
        public MenuButtonViewModel MainPageButton { get; set; }
        public MenuButtonViewModel SecondPageButton { get; set; }

        public RootViewModel()
        {
            MainPageButton = new MenuButtonViewModel(new ButtonStyleA("Главная"));
            SecondPageButton = new MenuButtonViewModel(new ButtonStyleB("Вторая"));
        }

        private void ChangeToMainPage()
        {

        }


        private void ChangeToSecondPage()
        {

        }
    }
}
