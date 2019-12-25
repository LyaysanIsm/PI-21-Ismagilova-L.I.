using System;
using System.Drawing;

namespace WindowsFormsAirplane
{
    public class Fighter : Airplane, IComparable<Fighter>, IEquatable<Fighter>
    {
        /// <summary> 
        /// Дополнительный цвет          
        /// </summary> 
        public Color DopColor { private set; get; }

        /// <summary> 
        /// Пули        
        /// </summary> 
        public bool Bullets { private set; get; }

        /// <summary> 
        /// Бомбы       
        /// </summary>
        public bool Bombs { private set; get; }

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
            Bullets = bullets;
            Bombs = bombs;
        }

        public Fighter(string info) : base(info)
        {
            string[] strs = info.Split(';');
            if (strs.Length == 8)
            {
                MaxSpeed = Convert.ToInt32(strs[0]);
                Weight = Convert.ToInt32(strs[1]);
                MainColor = Color.FromName(strs[2]);
                Cabin = Convert.ToBoolean(strs[3]);
                Keel = Convert.ToBoolean(strs[4]);
                DopColor = Color.FromName(strs[5]);
                Bullets = Convert.ToBoolean(strs[6]);
                Bombs = Convert.ToBoolean(strs[7]);
            }
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

        public override string ToString()
        {
            return base.ToString() + ";" + DopColor.Name + ";" + Bullets + ";" + Bombs;
        }

        /// <summary>      
        /// /// Метод интерфейса IComparable для класса SportCar     
        /// /// </summary>    
        /// /// <param name="other"></param>      
        /// /// <returns></returns>    
        public int CompareTo(Fighter other)
        {
            var res = (this is Airplane).CompareTo(other is Airplane);
            if (res != 0)
            {
                return res;
            }
            if (DopColor != other.DopColor)
            {
                DopColor.Name.CompareTo(other.DopColor.Name);
            }
            if (Bullets != other.Bullets)
            {
                return Bullets.CompareTo(other.Bullets);
            }
            if (Bombs != other.Bombs)
            {
                return Bombs.CompareTo(other.Bombs);
            }

            return 0;
        }

        /// <summary>      
        /// /// Метод интерфейса IEquatable для класса SportCar     
        /// /// </summary>         
        /// /// <param name="other"></param>         
        /// /// <returns></returns>    
        public bool Equals(Fighter other)
        {
            var res = (this as Airplane).Equals(other as Airplane);
            if (!res)
            {
                return res;
            }
            if (GetType().Name != other.GetType().Name)
            {
                return false;
            }
            if (DopColor != other.DopColor)
            {
                return false;
            }
            if (Bullets != other.Bullets)
            {
                return false;
            }
            if (Bombs != other.Bombs)
            {
                return false;
            }
            return true;
        }

        /// <summary>  
        /// Перегрузка метода от object    
        /// </summary>       
        /// <param name="obj"></param>       
        /// <returns></returns>     
        public override bool Equals(Object obj)
        {
            if (obj == null) { return false; }

            if (!(obj is Fighter planeObj))
            {
                return false;
            }
            else
            {
                return Equals(planeObj);
            }
        }

        /// <summary>   
        /// Перегрузка метода от object    
        /// </summary>        
        /// <returns></returns>     
        public override int GetHashCode() { return base.GetHashCode(); }
    }
}

