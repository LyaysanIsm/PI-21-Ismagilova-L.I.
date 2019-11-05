using System.Drawing;


namespace WindowsFormsAirplane
{
    public class Fighter : Airplane
    {
        /// <summary> 
        /// Дополнительный цвет          
        /// </summary> 
        public Color DopColor { private set; get; }

        /// <summary> 
        /// Киль        
        /// </summary> 
        public new bool Keel { private set; get; }

        /// <summary> 
        /// Пули        
        /// </summary> 
        public bool Bullets { private set; get; }

        public bool Bombs { private set; get; }

        /// <summary> 
        /// Кабина        
        /// </summary> 
        public new bool Cabin { private set; get; }

        /// <summary>         
        /// Конструктор        
        /// </summary>         
        /// <param name="maxSpeed">Максимальная скорость</param>         
        /// <param name="weight">Вес самолета</param>         
        /// <param name="mainColor">Основной цвет кузова</param> 


        public Fighter(int maxSpeed, float weight, Color mainColor, Color dopColor, bool keel, bool bullets, bool cabin, bool bombs) :

         base(maxSpeed, weight, mainColor, cabin, keel)

        {

            DopColor = dopColor;
            Keel = keel;
            Bullets = bullets;
            Cabin = cabin;
            Bombs = bombs;
        }
        /// <summary>         
        /// Отрисовка самолета      
        /// </summary>         
        /// <param name="g"></param> 
        public override void DrawAirplane(Graphics g)
        {

            Pen pen = new Pen(Color.Black);

            Brush bul = new SolidBrush(DopColor);

            if (Bombs)
            {
                g.DrawLine(pen, _startPosX + 95, _startPosY - 20, _startPosX + 95, _startPosY);
                g.DrawLine(pen, _startPosX + 105, _startPosY - 20, _startPosX + 105, _startPosY);
            }

            base.DrawAirplane(g);

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
