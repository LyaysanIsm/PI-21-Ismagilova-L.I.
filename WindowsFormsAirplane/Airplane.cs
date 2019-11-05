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

        public bool Cabin { private set; get; }

        public bool Keel { private set; get; }

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
            g.FillEllipse(fir, _startPosX + 28, _startPosY + 40, 140, 30);
            g.DrawEllipse(pen, _startPosX + 28, _startPosY + 40, 140, 30);

            g.FillEllipse(fir, _startPosX + 60, _startPosY + 130, 80, 15);
            g.DrawEllipse(pen, _startPosX + 60, _startPosY + 130, 80, 15);

            Brush sec = new SolidBrush(MainColor);
            g.FillEllipse(sec, _startPosX + 80, _startPosY - 6, 40, 160);
            g.DrawEllipse(pen, _startPosX + 80, _startPosY - 6, 40, 160);

            if (Cabin)
            {
                Brush win = new SolidBrush(Color.Yellow);
                g.FillRectangle(win, _startPosX + 87, _startPosY + 26, 25, 15);
                g.DrawRectangle(pen, _startPosX + 87, _startPosY + 26, 25, 15);
            }
            if (Keel)
            {
                Brush kl = new SolidBrush(Color.Black);

                g.FillEllipse(kl, _startPosX + 98, _startPosY + 120, 5, 30);
                g.DrawEllipse(pen, _startPosX + 98, _startPosY + 120, 5, 30);
            }
        }
    }
}
