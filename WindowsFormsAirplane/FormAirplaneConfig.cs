using System;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsAirplane
{
    public partial class FormAirplaneConfig : Form
    {
        /// <summary>      
        /// Переменная-выбранный самолет   
        /// </summary>   
        ITransport plane = null;

        /// <summary> 
        /// Событие 
        /// </summary> 
        private event planeDelegate eventAddPlane;

        public FormAirplaneConfig()
        {
            InitializeComponent();
            panelBlack.MouseDown += panelColor_MouseDown;
            panelOrange.MouseDown += panelColor_MouseDown;
            panelGray.MouseDown += panelColor_MouseDown;
            panelGreen.MouseDown += panelColor_MouseDown;
            panelRed.MouseDown += panelColor_MouseDown;
            panelWhite.MouseDown += panelColor_MouseDown;
            panelYellow.MouseDown += panelColor_MouseDown;
            panelBlue.MouseDown += panelColor_MouseDown;
            buttonCancel.Click += (object sender, EventArgs e) => { Close(); };
        }

        /// <summary> 
        /// Отрисовать самолет  
        /// </summary>       
        private void DrawAirplane()
        {
            if (plane != null)
            {
                Bitmap bmp = new Bitmap(pictureBoxAirplane.Width, pictureBoxAirplane.Height);
                Graphics gr = Graphics.FromImage(bmp);
                plane.SetPosition(5, 5, pictureBoxAirplane.Width, pictureBoxAirplane.Height);
                plane.DrawAirplane(gr);
                pictureBoxAirplane.Image = bmp;
            }
        }

        /// <summary>
        /// Добавление события  
        /// </summary>    
        /// <param name="ev"></param>  
        public void AddEvent(planeDelegate ev)
        {
            if (eventAddPlane == null)
            {
                eventAddPlane = new planeDelegate(ev);
            }
            else
            {
                eventAddPlane += ev;
            }
        }

        /// <summary>       
        /// Передаем информацию при нажатии на Label 
        /// </summary>       
        /// <param name="sender"></param>
        /// <param name="e"></param> 
        private void labelAirplane_MouseDown(object sender, MouseEventArgs e)
        {
            labelAirplane.DoDragDrop(labelAirplane.Text, DragDropEffects.Move | DragDropEffects.Copy);
        }

        /// <summary> 
        /// /// Передаем информацию при нажатии на Label 
        /// /// </summary>  
        /// /// <param name="sender"></param> 
        /// /// <param name="e"></param>      
        private void labelFighter_MouseDown(object sender, MouseEventArgs e)
        {
            labelFighter.DoDragDrop(labelFighter.Text, DragDropEffects.Move | DragDropEffects.Copy);
        }

        /// <summary> 
        /// /// Проверка получаемой информации (ее типа на соответствие требуемому)  
        /// /// </summary>      
        /// /// <param name="sender"></param>        
        /// /// <param name="e"></param>   
        private void panelAirplane_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Text))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        /// <summary>    
        /// Действия при приеме перетаскиваемой информации       
        /// </summary>     
        /// <param name="sender"></param>   
        /// <param name="e"></param>       
        private void panelAirplane_DragDrop(object sender, DragEventArgs e)
        {
            switch (e.Data.GetData(DataFormats.Text).ToString())
            {
                case "Самолет":
                    plane = new Airplane(100, 500, Color.White, true, true);
                    break;
                case "Истребитель":
                    plane = new Fighter(100, 500, Color.Blue, Color.Green, true, true, true, true);
                    break;
            }
            DrawAirplane();
        }

        /// <summary>  
        /// Отправляем цвет с панели         
        /// </summary>         
        /// <param name="sender"></param>         
        /// <param name="e"></param> 
        private void panelColor_MouseDown(object sender, MouseEventArgs e)
        {
            (sender as Control).DoDragDrop((sender as Control).BackColor, DragDropEffects.Move | DragDropEffects.Copy);
        }

        /// <summary>         
        /// Проверка получаемой информации (ее типа на соответствие требуемому)
        /// </summary>         
        /// <param name="sender"></param>         
        /// <param name="e"></param>   
        private void labelBaseColor_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(Color)))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        /// <summary>         
        /// Принимаем основной цвет         
        /// </summary>         
        /// <param name="sender"></param>         
        /// <param name="e"></param>   
        private void labelBaseColor_DragDrop(object sender, DragEventArgs e)
        {
            if (plane != null)
            {
                plane.SetMainColor((Color)e.Data.GetData(typeof(Color)));
                DrawAirplane();
            }
        }

        /// <summary> 
        /// Принимаем дополнительный цвет  
        /// </summary>      
        /// <param name="sender"></param>     
        /// <param name="e"></param> 
        private void labelDopColor_DragDrop(object sender, DragEventArgs e)
        {
            if (plane != null)
            {
                if (plane is Fighter)
                {
                    (plane as Fighter).SetDopColor((Color)e.Data.GetData(typeof(Color)));
                    DrawAirplane();
                }
            }
        }

        /// <summary> 
        /// Добавление самолета 
        /// </summary>       
        /// <param name="sender"></param>      
        /// <param name="e"></param>  
        private void buttonOk_Click(object sender, EventArgs e)
        {
            eventAddPlane?.Invoke(plane);
            Close();
        }
    }
}


