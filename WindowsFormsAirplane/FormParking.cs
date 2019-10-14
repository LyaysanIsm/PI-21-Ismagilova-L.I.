using System;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsAirplane
{
    public partial class FormParking : Form
    {

        /// <summary> 
        /// Объект от класса-парковки
        /// </summary>  
        Parking<ITransport> parking;

        public FormParking()
        {
            InitializeComponent();
            parking = new Parking<ITransport>(20, pictureBoxParking.Width, pictureBoxParking.Height);
            Draw();
        }

        /// <summary> 
        /// Метод отрисовки парковки      
        /// </summary>        
        private void Draw()
        {

            Bitmap bmp = new Bitmap(pictureBoxParking.Width, pictureBoxParking.Height);
            Graphics gr = Graphics.FromImage(bmp);
            parking.Draw(gr);
            pictureBoxParking.Image = bmp;
        }

        /// <summary> 
        /// Обработка нажатия кнопки "Припарковать самолет"    
        /// </summary>        
        /// <param name="sender"></param>    
        /// <param name="e"></param>        
        private void button_Airplane_Click(object sender, EventArgs e)
        {

            ColorDialog dialog = new ColorDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                var plane = new Airplane(100, 1000, dialog.Color, true, true);
                int place = parking + plane;
                Draw();
            }

        }

        /// <summary>
        /// Обработка нажатия кнопки "Припарковать истребитель"    
        /// </summary>      
        /// <param name="sender"></param>       
        /// <param name="e"></param>       
        private void button_Fighter_Click(object sender, EventArgs e)
        {
            ColorDialog dialog = new ColorDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                ColorDialog dialogDop = new ColorDialog();
                if (dialogDop.ShowDialog() == DialogResult.OK)
                {
                    var plane = new Fighter(100, 1000, dialog.Color, dialogDop.Color, true, true, true, true);
                    int place = parking + plane;
                    Draw();
                }
            }
        }

        /// <summary> 
        /// Обработка нажатия кнопки "Забрать"   
        /// </summary>       
        /// <param name="sender"></param>         
        /// <param name="e"></param>    

        private void buttonTakeAirplane_Click_(object sender, EventArgs e)
        {
            if (maskedTextBox.Text != "")
            {
                var plane = parking - Convert.ToInt32(maskedTextBox.Text);
                if (plane != null)
                {
                    Bitmap bmp = new Bitmap(pictureBoxTakePlane.Width, pictureBoxTakePlane.Height);
                    Graphics gr = Graphics.FromImage(bmp);
                    plane.SetPosition(5, 5, pictureBoxTakePlane.Width, pictureBoxTakePlane.Height);
                    plane.DrawAirplane(gr);
                    pictureBoxTakePlane.Image = bmp;
                }
                else
                {
                    Bitmap bmp = new Bitmap(pictureBoxTakePlane.Width, pictureBoxTakePlane.Height);
                    pictureBoxTakePlane.Image = bmp;
                }
                Draw();
            }
        }
    }
}
