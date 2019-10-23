using System.Drawing;

namespace WindowsFormsAirplane
{
    public abstract class Vehicle : ITransport
    {
        /// <summary>         
        /// Левая координата отрисовки самолета       
        /// </summary>         
        protected float _startPosX;

        /// <summary>         
        /// Правая координата отрисовки самолета        
        /// </summary>  
        protected float _startPosY;

        /// <summary>         
        /// Ширина окна отрисовки         
        /// </summary> 
        protected int _pictureWidth;

        //Высота окна отрисовки       
        protected int _pictureHeight;

        /// <summary>         
        /// /// Максимальная скорость        
        /// /// </summary>         
        public int MaxSpeed { protected set; get; }

        /// <summary>         
        /// Вес самолета        
        /// </summary>         
        public float Weight { protected set; get; }

        /// <summary> 
        /// Основной цвет кузова         
        /// </summary>         
        public Color MainColor { protected set; get; }

        public void SetPosition(int x, int y, int width, int height)
        {
            _startPosX = x;
            _startPosY = y;
            _pictureWidth = width;
            _pictureHeight = height;
        }

        public abstract void DrawAirplane(Graphics g);

        public abstract void MoveTransport(Direction direction);
    }
}
