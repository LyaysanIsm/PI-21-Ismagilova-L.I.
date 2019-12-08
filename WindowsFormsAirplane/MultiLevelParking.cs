using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace WindowsFormsAirplane
{
    /// <summary> 
    /// Класс-хранилище парковок 
    /// </summary> 
    class MultiLevelParking
    {
        /// <summary>        
        /// Список с уровнями парковки 
        /// </summary>       
        List<Parking<ITransport>> parkingStages;

        /// <summary>    
        /// Сколько мест на каждом уровне    
        /// </summary> 
        private const int countPlaces = 15;

        /// <summary> 
        /// Ширина окна отрисовки 
        /// </summary>        
        private int pictureWidth;

        /// <summary> 
        /// Высота окна отрисовки    
        /// </summary>        
        private int pictureHeight;

        /// <summary>       
        ///  Конструктор    
        ///  </summary>    
        ///  <param name="countStages">Количество уровенй парковки</param>       
        /// <param name="pictureWidth"></param>  
        /// <param name="pictureHeight"></param>    
        public MultiLevelParking(int countStages, int pictureWidth, int pictureHeight)
        {
            parkingStages = new List<Parking<ITransport>>();
            for (int i = 0; i < countStages; ++i)
            {
                parkingStages.Add(new Parking<ITransport>(countPlaces, pictureWidth, pictureHeight));
            }
        }

        /// <summary>      
        /// Индексатор       
        /// </summary>       
        /// <param name="ind"></param>         
        /// <returns></returns>        
        public Parking<ITransport> this[int ind]
        {
            get
            {
                if (ind > -1 && ind < parkingStages.Count)
                {
                    return parkingStages[ind];
                }
                return null;
            }
        }

        /// <summary> 
        /// Сохранение информации по самолетам на парковках в файл 
        /// </summary>         
        /// <param name="filename">Путь и имя файла</param>   
        /// <returns></returns>   
        public void SaveData(string filename)
        {
            if (File.Exists(filename))
            {
                File.Delete(filename);
            }
            using (StreamWriter sw = new StreamWriter(filename))
            {
                sw.WriteLine("CountLeveles:" + parkingStages.Count);
                foreach (var level in parkingStages)
                {
                    sw.WriteLine("Level");
                    for (int i = 0; i < countPlaces; i++)
                    {
                        try
                        {
                            var plane = level[i];

                            if (plane != null)
                            {
                                if (plane.GetType().Name == "Airplane")
                                {
                                    sw.Write(i + ":Airplane:");
                                }
                                if (plane.GetType().Name == "Fighter")
                                {
                                    sw.Write(i + ":Fighter:");
                                }
                                sw.WriteLine(plane);
                            }
                        }
                        finally { }
                    }
                }
            }
        }

        /// <summary>         
        /// Загрузка информации по самолетам на парковках из файла        
        /// </summary>       
        /// <param name="filename"></param>   
        /// <returns></returns> 
        public void LoadData(string filename)
        {
            if (!File.Exists(filename))
            {
                throw new FileNotFoundException();
            }
            string buffer = "";
            using (StreamReader sr = new StreamReader(filename))
            {
                if ((buffer = sr.ReadLine()).Contains("CountLeveles"))
                {
                    int count = Convert.ToInt32(buffer.Split(':')[1]);
                    if (parkingStages != null)
                    {
                        parkingStages.Clear();
                    }
                    parkingStages = new List<Parking<ITransport>>(count);
                }
                else
                {
                    //если нет такой записи, то это не те данные 
                    throw new Exception("Неверный формат файла");
                }
                int counter = -1;
                ITransport plane = null;
                while ((buffer = sr.ReadLine()) != null)
                {
                    if (buffer == "Level")
                    {
                        counter++;
                        parkingStages.Add(new Parking<ITransport>(countPlaces, pictureWidth, pictureHeight));
                        continue;
                    }
                    if (string.IsNullOrEmpty(buffer))
                    {
                        continue;
                    }
                    if (buffer.Split(':')[1] == "Airplane")
                    {
                        Console.WriteLine(buffer.Split(':')[2]);
                        plane = new Airplane(buffer.Split(':')[2]);
                    }
                    else if (buffer.Split(':')[1] == "Fighter")
                    {
                        plane = new Fighter(buffer.Split(':')[2]);
                    }
                    parkingStages[counter][Convert.ToInt32(buffer.Split(':')[0])] = plane;
                }
            }
        }
    }
}



