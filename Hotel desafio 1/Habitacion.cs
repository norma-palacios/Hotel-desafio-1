using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_desafio_1
{
    class Habitacion
    {
        string numeroDeHabitacion { get; set; }
        string tipoDeHabitacion { get; set; }
        string precioPorNoche { get; set; }
        bool estadoDeHabitacion { get; set; }

        public Habitacion() 
        {
            estadoDeHabitacion = true;
        }
    }
}
        
