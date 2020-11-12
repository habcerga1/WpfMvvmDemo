using System;
using System.Collections.Generic;
using System.Text;

namespace WpfMvvmDemo.Models.Button
{
    /// <summary>
    /// Интерфейс описывает текст и стиль шрифта у кнопки
    /// </summary>
    interface IButtonStyle
    {
        /// <summary>
        /// Текст кнопки
        /// </summary>
        string content { get; set; }
        /// <summary>
        /// Размер шрифта
        /// </summary>
        int fontSize { get; set; }
        /// <summary>
        /// Текущий цвет текста
        /// </summary>
        string fontColor { get; set; }
        /// <summary>
        /// Обычный цвет текста
        /// </summary>
        public string fontColorNormal { get; }
        /// <summary>
        /// Цвет текста при наведении курсора
        /// </summary>
        public string fontColorMouseEnter { get; }
    }
}
