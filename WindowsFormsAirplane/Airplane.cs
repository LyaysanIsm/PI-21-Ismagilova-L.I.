using System.Drawing;


namespace WindowsFormsAirplane
{
    public class Airplane
    {
        /// <summary>         
        /// Левая координата отрисовки самолета       
        /// </summary>         
        private float _startPosX;

        /// <summary>         
        /// Правая координата отрисовки самолета        
        /// </summary>  
        private float _startPosY;

        /// <summary>         
        /// Ширина окна отрисовки         
        /// </summary> 
        private int _pictureWidth;

        //Высота окна отрисовки       
        private int _pictureHeight;

        /// <summary>         
        /// Ширина отрисовки самолета       
        /// </summary> 
        private const int planeWidth = 90;

        /// <summary>         
        /// Высота отрисовки самолета      
        /// </summary>         
        private const int planeHeight = 50;

        /// <summary>         
        /// /// Максимальная скорость        
        /// /// </summary>         
        public int MaxSpeed { private set; get; }

        /// <summary>         
        /// Вес самолета        
        /// </summary>         
        public float Weight { private set; get; }

        /// <summary> 
        /// Основной цвет кузова         
        /// </summary>         
        public Color MainColor { private set; get; }

        /// <summary> 
        /// Дополнительный цвет          
        /// </summary> 
        public Color DopColor { private set; get; }

        /// <summary> 
        /// Киль        
        /// </summary> 
        public bool Keel { private set; get; }

        /// <summary> 
        /// Пули        
        /// </summary> 
        public bool Bullets { private set; get; }

        /// <summary> 
        /// Кабина        
        /// </summary> 
        public bool Cabin { private set; get; }

        /// <summary>         
        /// Конструктор        
        /// </summary>         
        /// <param name="maxSpeed">Максимальная скорость</param>         
        /// <param name="weight">Вес самолета</param>         
        /// <param name="mainColor">Основной цвет кузова</param>        

        public Airplane(int maxSpeed, float weight, Color mainColor, Color dopColor, bool keel, bool bullets, bool cabin)
        {
            MaxSpeed = maxSpeed;
            Weight = weight;
            MainColor = mainColor;
            DopColor = dopColor;
            Keel = keel;
            Bullets = bullets;
            Cabin = cabin;
        }

        /// <summary>        
        /// Установка позиции самолета        
        /// </summary>         
        /// <param name="x">Координата X</param>         
        /// <param name="y">Координата Y</param>         
        /// <param name="width">Ширина картинки</param>         
        /// <param name="height">Высота картинки</param>        
        public void SetPosition(int x, int y, int width, int height)
        {
            _startPosX = x;
            _startPosY = y;
            _pictureWidth = width;
            _pictureHeight = height;
        }

        /// <summary>         
        /// Изменение направления пермещения         
        /// </summary>         
        /// <param name="direction">Направление</param>

        public void MoveTransport(Direction direction)
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
                    if (_startPosY - step > 3)
                    {

                        _startPosY -= step;
                    }
                    break;
                //вниз                
                case Direction.Down:
                    if (_startPosY + step < _pictureHeight - planeHeight - 100)
                    {
                        _startPosY += step;
                    }
                    break;
            }
        }

        /// <summary>         
        /// Отрисовка самолета      
        /// </summary>         
        /// <param name="g"></param> 
        public void DrawAirplane(Graphics g)
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

            Brush bul = new SolidBrush(DopColor);

            if (Bullets)
            {
                g.FillEllipse(bul, _startPosX + 48, _startPosY + 40, 5, 25);
                g.FillEllipse(bul, _startPosX + 59, _startPosY + 35, 5, 25);
                g.FillEllipse(bul, _startPosX + 70, _startPosY + 32, 5, 25);

                g.FillEllipse(bul, _startPosX + 145, _startPosY + 40, 5, 25);
                g.FillEllipse(bul, _startPosX + 134, _startPosY + 35, 5, 25);
                g.FillEllipse(bul, _startPosX + 122, _startPosY + 32, 5, 25);

            }

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
