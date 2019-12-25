using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsAirplane
{
    /// <summary>  
    /// Класс-ошибка "Если место, на которое хотим поставить самолет уже занято"    
    /// </summary>    
    public class ParkingOccupiedPlaceException : Exception
    {
        public ParkingOccupiedPlaceException(int i) : base("На месте " + i + " уже стоит самолет") { }
    }
}
