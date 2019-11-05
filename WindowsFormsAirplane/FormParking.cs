using System;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsAirplane
{
    public partial class FormParking : Form
    {
        /// <summary> 
        /// Объект от класса многоуровневой парковки      
        /// </summary>   
        MultiLevelParking parking;

        /// <summary> 
        /// Количество уровней-парковок  
        /// </summary>  
        private const int countLevel = 5;


        public FormParking()
        {
            InitializeComponent();
            parking = new MultiLevelParking(countLevel, pictureBoxParking.Width, pictureBoxParking.Height);
            //заполнение listBox  
            for (int i = 0; i < countLevel; i++)
            {
                listBoxLevels.Items.Add("Уровень " + (i + 1));
            }
            listBoxLevels.SelectedIndex = 0;
        }

        /// <summary> 
        /// Метод отрисовки парковки      
        /// </summary>        
        private void Draw()
        {
            if (listBoxLevels.SelectedIndex > -1)
            {
                //если выбран один из пуктов в listBox (при старте программы ни один пункт не будет выбран 
                //и может возникнуть ошибка, если мы попытаемся обратиться к элементу listBox)   
                Bitmap bmp = new Bitmap(pictureBoxParking.Width, pictureBoxParking.Height);
                Graphics gr = Graphics.FromImage(bmp);
                parking[listBoxLevels.SelectedIndex].Draw(gr);
                pictureBoxParking.Image = bmp;
            }
        }

        /// <summary> 
        /// Обработка нажатия кнопки "Припарковать самолет"    
        /// </summary>        
        /// <param name="sender"></param>    
        /// <param name="e"></param>        
        private void button_Airplane_Click(object sender, EventArgs e)
        {
            if (listBoxLevels.SelectedIndex > -1)
            {
                ColorDialog dialog = new ColorDialog();
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    var plane = new Airplane(100, 1000, dialog.Color, true, true);
                    int place = parking[listBoxLevels.SelectedIndex] + plane;
                    if (place == -1)
                    {
                        MessageBox.Show("Нет свободных мест", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    Draw();
                }
            }
        }

        /// <summary>
        /// Обработка нажатия кнопки "Припарковать истребитель"    
        /// </summary>      
        /// <param name="sender"></param>       
        /// <param name="e"></param>       
        private void button_Fighter_Click(object sender, EventArgs e)
        {
            if (listBoxLevels.SelectedIndex > -1)
            {
                ColorDialog dialog = new ColorDialog();
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    ColorDialog dialogDop = new ColorDialog();
                    if (dialogDop.ShowDialog() == DialogResult.OK)
                    {
                        var plane = new Fighter(100, 1000, dialog.Color, dialogDop.Color, true, true, true, true);
                        int place = parking[listBoxLevels.SelectedIndex] + plane;
                        if (place == -1)
                        {
                            MessageBox.Show("Нет свободных мест", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        Draw();
                    }
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
            if (listBoxLevels.SelectedIndex > -1)
            {
                if (maskedTextBox.Text != "")
                {
                    var plane = parking[listBoxLevels.SelectedIndex] - Convert.ToInt32(maskedTextBox.Text);
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
        /// <summary>  
        /// Метод обработки выбора элемента на listBoxLevels   
        /// </summary>      
        /// <param name="sender"></param>         
        /// <param name="e"></param>      
        private void listBoxLevels_SelectedIndexChanged(object sender, EventArgs e)
        {
            Draw();
        }        
    }
}