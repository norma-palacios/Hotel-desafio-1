using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_desafio_1
{
    class Habitacion
    {
        public string numeroDeHabitacion { get; set; }
        public string tipoDeHabitacion { get; set; }
        public double precioPorNoche { get; set; }
        public bool estadoDeHabitacion { get; set; }

        public Habitacion(bool estado) 
        {
            estadoDeHabitacion = estado;
        }

        public double calcularCostoDeHabitacion(int numeroHabitacion)
        {
            if (numeroHabitacion <= 1 && numeroHabitacion >= 20)
            {
                return 100.00;
            }
            else if (numeroHabitacion <= 21 && numeroHabitacion >= 40)
            {
                return 200.00;
            }
            else
            {
                return 300.00;
            }
        }

        public string obtenerTipoDeHabitacion(int numeroHabitacion)
        {
            if (numeroHabitacion <= 1 && numeroHabitacion >= 20)
            {
                return "Sencilla";
            }
            else if (numeroHabitacion <= 21 && numeroHabitacion >= 40)
            {
                return "Doble";
            }
            else
            {
                return "Suite";
            }
        }
    }
}
        
