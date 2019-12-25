using NLog;
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

        /// <summary>   
        /// Логгер      
        /// </summary>    
        private Logger logger;


        public FormParking()
        {
            InitializeComponent();
            logger = LogManager.GetCurrentClassLogger();
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
                    try
                    {
                        var plane = parking[listBoxLevels.SelectedIndex] - Convert.ToInt32(maskedTextBox.Text);

                        Bitmap bmp = new Bitmap(pictureBoxTakePlane.Width, pictureBoxTakePlane.Height);
                        Graphics gr = Graphics.FromImage(bmp);
                        plane.SetPosition(5, 5, pictureBoxTakePlane.Width, pictureBoxTakePlane.Height);
                        plane.DrawAirplane(gr);
                        pictureBoxTakePlane.Image = bmp;
                        logger.Info("Изъят автомобиль " + plane.ToString() + " с места " + maskedTextBox.Text);
                        Draw();

                    }
                    catch (ParkingNotFoundException ex)
                    {
                        MessageBox.Show(ex.Message, "Не найдено", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        Bitmap bmp = new Bitmap(pictureBoxTakePlane.Width, pictureBoxTakePlane.Height);
                        pictureBoxTakePlane.Image = bmp;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Неизвестная ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
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
                try
                {
                    int place = parking[listBoxLevels.SelectedIndex] + plane;
                    logger.Info("Добавлен автомобиль " + plane.ToString() + " на место " + place);
                    Draw();
                }
                catch (ParkingOverflowException ex)
                {
                    logger.Error("Переполнение данным объектом");
                    MessageBox.Show(ex.Message, "Переполнение", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (ParkingAlreadyHaveException ex)
                {
                    MessageBox.Show(ex.Message, "Дублирование", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    logger.Error("Дублирование");
                }
                catch (Exception ex)
                {
                    logger.Error("Неизвестная ошибка");
                    MessageBox.Show(ex.Message, "Неизвестная ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    parking.SaveData(saveFileDialog.FileName);
                    MessageBox.Show("Сохранение прошло успешно", "Результат",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    logger.Info("Сохранено в файл " + saveFileDialog.FileName);
                }
                catch (Exception ex)
                {
                    logger.Error("Неизвестная ошибка при сохранении");
                    MessageBox.Show(ex.Message, "Неизвестная ошибка при сохранении",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    parking.LoadData(openFileDialog.FileName);
                    MessageBox.Show("Загрузили", "Результат", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    logger.Info("Загружено из файла " + openFileDialog.FileName);
                }
                catch (ParkingOccupiedPlaceException ex)
                {
                    logger.Error("Место занято");
                    MessageBox.Show(ex.Message, "Занятое место", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    logger.Error("Неизвестная ошибка при сохранении");
                    MessageBox.Show(ex.Message, "Неизвестная ошибка при сохранении", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                Draw();
            }
        }

        /// <summary>     
        /// Обработка нажатия кнопки "Сортировка"         
        /// </summary>     
        /// <param name="sender"></param>      
        /// <param name="e"></param>   
        private void button_Sort_Click(object sender, EventArgs e)
        {
            parking.Sort();
            Draw();
            logger.Info("Сортировка уровней");
        }
    }
}