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

        // asignar precio a habitacion por piso
        // del piso 1 y 2 valen 100.00
        // del piso 2 y 3 valen 200.00
        // el piso 5 vale 300.00
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

        // asignar tipo a habitacion por piso
        // del piso 1 y 2 son Sencilla
        // del piso 2 y 3 son Doble
        // el piso 5 es Suit
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
        
