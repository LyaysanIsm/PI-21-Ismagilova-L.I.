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
        /// Форма для добавления
        /// </summary>       
        FormAirplaneConfig form;

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

        /// <summary>  
        /// Обработка нажатия кнопки "Добавить самолет"    
        /// </summary>        
        /// <param name="sender"></param>       
        /// <param name="e"></param>        

        private void buttonSetAirplane_Click(object sender, EventArgs e)
        {
            form = new FormAirplaneConfig();
            form.AddEvent(AddPlane);
            form.Show();
        }

        /// <summary>      
        /// Метод добавления самолета
        /// </summary>       
        /// <param name="plane"></param>    
        private void AddPlane(ITransport plane)
        {
            if (plane != null && listBoxLevels.SelectedIndex > -1)
            {
                int place = parking[listBoxLevels.SelectedIndex] + plane;
                if (place > -1)
                {
                    Draw();
                }
                else
                {
                    MessageBox.Show("Самолет не удалось поставить");
                }
            }
        }

        /// <summary>      
        /// Обработка нажатия пункта меню "Сохранить"
        /// </summary>         
        /// <param name="sender"></param>    
        /// <param name="e"></param> 
        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                if (parking.SaveData(saveFileDialog.FileName))
                {
                    MessageBox.Show("Сохранение прошло успешно", "Результат", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Не сохранилось", "Результат", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        /// <summary>      
        /// Обработка нажатия пункта меню "Загрузить"
        /// </summary>         
        /// <param name="sender"></param>    
        /// <param name="e"></param>
        private void загрузитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                if (parking.LoadData(openFileDialog.FileName))
                {
                    MessageBox.Show("Загрузили", "Результат", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Не загрузили", "Результат", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                Draw();
            }
        }
    }
}
