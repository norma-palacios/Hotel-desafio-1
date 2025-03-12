using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_desafio_1
{
    class Reservacion
    {
        public string numeroDeHabitacion { set; get; }
        public   int cantidadDeNoches { set; get; }
        public  double montoTotal { set; get; }
        public Cliente cliente { set; get;  }
    }
}
