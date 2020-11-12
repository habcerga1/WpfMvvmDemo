using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;

namespace WpfMvvmDemo.Services
{
    public class ObservableObject : INotifyPropertyChanged
    {
        //Событие изменения свойства
        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        /// <summary>
        /// Метод сравнивает значения свойств, переданные в параметрах, и если они отличаются тогда
        /// свойство с ref получает новое значение и вызывается метод OnPropertyChanged.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="backingFiels">Свойство передаваемой по ссылке</param>
        /// <param name="value">Новое значение</param>
        /// <param name="propertyName">Свойство зависимости</param>
        /// <returns></returns>
        protected virtual bool OnPropertyChanged<T>(ref T backingFiels, T value, [CallerMemberName] string propertyName = "")
        {
            if (EqualityComparer<T>.Default.Equals(backingFiels, value)) return false;
            backingFiels = value;
            OnPropertyChanged(propertyName);
            return true;
        }
    }
}
