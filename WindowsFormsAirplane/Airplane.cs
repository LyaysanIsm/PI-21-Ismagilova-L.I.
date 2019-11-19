using System;
using System.Drawing;

namespace WindowsFormsAirplane
{
    public class Airplane : Vehicle
    {
        /// <summary>         
        /// Ширина отрисовки самолета       
        /// </summary> 
        private const int planeWidth = 90;

        /// <summary>         
        /// Высота отрисовки самолета      
        /// </summary>         
        private const int planeHeight = 50;

        public bool Cabin { protected set; get; }

        public bool Keel { protected set; get; }

        /// <summary>         
        /// Конструктор        
        /// </summary>         
        /// <param name="maxSpeed">Максимальная скорость</param>         
        /// <param name="weight">Вес самолета</param>         
        /// <param name="mainColor">Основной цвет кузова</param>  
        public Airplane(int maxSpeed, float weight, Color mainColor, bool cabin, bool keel)
        {
            MaxSpeed = maxSpeed;
            Weight = weight;
            MainColor = mainColor;
            Cabin = cabin;
            Keel = keel;
        }

        /// <summary>
        /// Конструктор 
        /// </summary>   
        /// <param name="info">Информация по объекту</param>        
        public Airplane(string info)
        {
            string[] strs = info.Split(';');
            if (strs.Length == 5)
            {
                MaxSpeed = Convert.ToInt32(strs[0]);
                Weight = Convert.ToInt32(strs[1]);
                MainColor = Color.FromName(strs[2]);
                Cabin = Convert.ToBoolean(strs[3]);
                Keel = Convert.ToBoolean(strs[4]);
            }
        }

        public override void MoveTransport(Direction direction)
        {
            float step = MaxSpeed * 100 / Weight;
            switch (direction)
            {
                //вправо                 
                case Direction.Right:
                    if (_startPosX + step < _pictureWidth - planeWidth - 85)
                    {
                        _startPosX += step;
                    }
                    break;
                //влево                
                case Direction.Left:
                    if (_startPosX - step > 0)
                    {
                        _startPosX -= step;
                    }
                    break;
                //вверх                 
                case Direction.Up:
                    if (_startPosY - step > 4)
                    {

                        _startPosY -= step;
                    }
                    break;
                //вниз                
                case Direction.Down:
                    if (_startPosY + step < _pictureHeight - planeHeight - 105)
                    {
                        _startPosY += step;
                    }
                    break;
            }
        }

        public override void DrawAirplane(Graphics g)
        {

            Pen pen = new Pen(Color.Black);

            Brush fir = new SolidBrush(MainColor);
            g.FillEllipse(fir, _startPosX + 28 / 3, _startPosY + 40 / 3, 140 / 3, 30 / 3);
            g.DrawEllipse(pen, _startPosX + 28 / 3, _startPosY + 40 / 3, 140 / 3, 30 / 3);

            g.FillEllipse(fir, _startPosX + 60 / 3, _startPosY + 130 / 3, 80 / 3, 15 / 3);
            g.DrawEllipse(pen, _startPosX + 60 / 3, _startPosY + 130 / 3, 80 / 3, 15 / 3);

            Brush sec = new SolidBrush(MainColor);
            g.FillEllipse(sec, _startPosX + 80 / 3, _startPosY - 6 / 3, 40 / 3, 160 / 3);
            g.DrawEllipse(pen, _startPosX + 80 / 3, _startPosY - 6 / 3, 40 / 3, 160 / 3);

            if (Cabin)
            {
                Brush win = new SolidBrush(Color.Yellow);
                g.FillRectangle(win, _startPosX + 87 / 3, _startPosY + 26 / 3, 25 / 3, 15 / 3);
                g.DrawRectangle(pen, _startPosX + 87 / 3, _startPosY + 26 / 3, 25 / 3, 15 / 3);
            }

            if (Keel)
            {
                Brush kl = new SolidBrush(Color.Black);

                g.FillEllipse(kl, _startPosX + 98 / 3, _startPosY + 120 / 3, 5 / 3, 30 / 3);
                g.DrawEllipse(pen, _startPosX + 98 / 3, _startPosY + 120 / 3, 5 / 3, 30 / 3);
            }
        }

        public override string ToString()
        {
            return MaxSpeed + ";" + Weight + ";" + MainColor.Name + ";" + Cabin + ";" + Keel;
        }
    }
}
