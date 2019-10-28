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

        /// <summary> 
        /// Бомбы       
        /// </summary>
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
                g.DrawLine(pen, _startPosX + 94 / 3, _startPosY - 20 / 3, _startPosX + 94 / 3, _startPosY + 100 / 3);
                g.DrawLine(pen, _startPosX + 104 / 3, _startPosY - 20 / 3, _startPosX + 104 / 3, _startPosY + 100 / 3);
            }

            base.DrawAirplane(g);

            if (Bullets)
            {
                g.FillEllipse(bul, _startPosX + 15 / 2, _startPosY + 40 / 2, 5 / 2, 25 / 2);
                g.FillEllipse(bul, _startPosX + 111 / 2, _startPosY + 40 / 2, 5 / 2, 25 / 2);

                g.FillEllipse(bul, _startPosX + 29 / 2, _startPosY + 35 / 2, 5 / 2, 25 / 2);
                g.FillEllipse(bul, _startPosX + 40 / 2, _startPosY + 32 / 3, 5 / 2, 25 / 2);


                g.FillEllipse(bul, _startPosX + 99 / 2, _startPosY + 35 / 2, 5 / 2, 25 / 2);
                g.FillEllipse(bul, _startPosX + 87 / 2, _startPosY + 32 / 3, 5 / 2, 25 / 2);

            }

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

        /// Смена дополнительного цвета  
        /// </summary>   
        /// <param name="color"></param>    
        public void SetDopColor(Color color)
        {
            DopColor = color;
        }
    }
}
