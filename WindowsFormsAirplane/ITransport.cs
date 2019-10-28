﻿using System.Drawing;

namespace WindowsFormsAirplane
{
    public interface ITransport
    {
        /// <summary>        
        /// Установка позиции самолета        
        /// </summary>         
        /// <param name="x">Координата X</param>         
        /// <param name="y">Координата Y</param>         
        /// <param name="width">Ширина картинки</param>         
        /// <param name="height">Высота картинки</param>        
        void SetPosition(int x, int y, int width, int height);
        /// <summary>         
        /// Изменение направления пермещения         
        /// </summary>         
        /// <param name="direction">Направление</param>

        void MoveTransport(Direction direction);

        void DrawAirplane(Graphics g);

        /// <summary> 
        /// Смена основного цвета автомобиля 
        /// </summary>
        /// <param name="color"></param> 
        void SetMainColor(Color color);
    }
}
