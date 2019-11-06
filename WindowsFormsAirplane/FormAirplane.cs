using System;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsAirplane
{
    public partial class FormAirplane : Form
    {
        private ITransport fighter;

        /// <summary>
        /// Конструктор
        /// </summary>  
        /// 
        public FormAirplane()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Метод отрисовки машины
        /// </summary>         
        private void Draw()
        {
            Bitmap bmp = new Bitmap(pictureBoxAirplane.Width, pictureBoxAirplane.Height);
            Graphics gr = Graphics.FromImage(bmp);
            fighter.DrawAirplane(gr);
            pictureBoxAirplane.Image = bmp;
        }

        /// <summary> 
        /// Обработка нажатия кнопки "Создать"     
        /// </summary>       
        /// <param name="sender"></param>    
        /// <param name="e"></param>   

        private void buttonCreate_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            fighter = new Fighter(rnd.Next(100, 300), rnd.Next(1000, 2000), Color.Orange, Color.Brown, true, true, true, true);
            fighter.SetPosition(rnd.Next(10, 100), rnd.Next(10, 100), pictureBoxAirplane.Width, pictureBoxAirplane.Height);
            Draw();
        }
        private void buttonF_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            fighter = new Airplane(rnd.Next(100, 300), rnd.Next(1000, 2000), Color.Blue, true, true);
            fighter.SetPosition(rnd.Next(10, 100), rnd.Next(10, 100), pictureBoxAirplane.Width, pictureBoxAirplane.Height);
            Draw();
        }
        /// <summary>        
        /// Обработка нажатия кнопок управления        
        /// </summary>         
        /// <param name="sender"></param>    
        /// <param name="e"></param>       
        private void buttonMove_Click(object sender, EventArgs e)
        {
            /// получаем имя кнопки            
            string name = (sender as Button).Name;
            switch (name)
            {
                case "buttonUp":
                    fighter.MoveTransport(Direction.Up);
                    break;
                case "buttonDown":
                    fighter.MoveTransport(Direction.Down);
                    break;
                case "buttonLeft":
                    fighter.MoveTransport(Direction.Left);
                    break;
                case "buttonRight":
                    fighter.MoveTransport(Direction.Right);
                    break;
            }
            Draw();
        }    
    }
}
