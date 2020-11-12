using System;
using System.Collections.Generic;
using System.Text;
using WpfMvvmDemo.Services;

namespace WpfMvvmDemo.Models.Button
{
    abstract public class AButton : ObservableObject,IButtonStyle
    {
        private string _content;
        public string content
        {
            get => _content;
            set { OnPropertyChanged(ref _content, value); }
        }
        public int fontSize { get; set; }

        private string _fontColor;
        public string fontColor
        {
            get => _fontColor;
            set { OnPropertyChanged(ref _fontColor, value); }
        }
        public string fontColorNormal { get; set; }
        public string fontColorMouseEnter { get; set; }

        #region RELAYCOMMAND

        private RelayCommand _mouseEnterCommand;
        /// <summary>
        /// Команда входа мышки в поле контролера
        /// </summary>
        public RelayCommand MouseEnterCommand
        {
            get { return _mouseEnterCommand; }
            set
            {
                OnPropertyChanged(ref _mouseEnterCommand, value);
            }
        }

        private RelayCommand _mouseLeaveCommand;
        /// <summary>
        /// Команда покидания мышки поля контролера
        /// </summary>
        public RelayCommand MouseLeaveCommand
        {
            get { return _mouseLeaveCommand; }
        }

        private RelayCommand _mouseDownCommand;
        /// <summary>
        /// Команда щелчка мышки
        /// </summary>
        public RelayCommand MouseDownCommand
        {
            get { return _mouseDownCommand; }
        }

        #endregion

        public AButton()
        {
            _mouseEnter += this.MouseEnterEventMethod;
            _mouseLeave += this.MouseLeaveEventMethod;

            this._mouseEnterCommand = new RelayCommand(MouseEnter);
            this._mouseLeaveCommand = new RelayCommand(MouseLeave);
        }

        public AButton(string _content)
        {
            content = _content;
            _mouseEnter += this.MouseEnterEventMethod;
            _mouseLeave += this.MouseLeaveEventMethod;

            this._mouseEnterCommand = new RelayCommand(MouseEnter);
            this._mouseLeaveCommand = new RelayCommand(MouseLeave);
        }

        event Action _mouseEnter;
        event Action _mouseLeave;

        void MouseEnterEventMethod()
        {
            fontColor = fontColorMouseEnter;
        }
         void MouseLeaveEventMethod()
        {
            fontColor = fontColorNormal;
        }

        private void MouseEnter()
        {
            this._mouseEnter.Invoke();
        }

        private void MouseLeave()
        {
            this._mouseLeave.Invoke();
        }

        public void MouseEnter(object param)
        {
            MouseEnter();
        }

        public void MouseLeave(object param)
        {
            MouseLeave();
        }
    }
}
