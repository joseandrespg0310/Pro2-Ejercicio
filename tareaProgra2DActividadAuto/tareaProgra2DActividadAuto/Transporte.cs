using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tareaProgra2DActividadAuto
{

    abstract class Transporte : IReserva
    {
        //PROPIEDADES
        public int Id { get; set; }
        public string FechaReserva { get; set; }
        //CONSTRUCTORES
        protected Transporte()
        {
            Id = 0;
            FechaReserva = "NO DEFENIDO";
        }
        protected Transporte(int id,string fech)
        {
            Id =id;
            FechaReserva = fech;
        }
        //FUNCIONALIDAD
        public virtual void verDatos()
        {
            Console.WriteLine("{0,-20}{1,-25}",Id,FechaReserva);
        }
        public virtual void leerDatos()
        {
            Console.WriteLine("Ingrese el Id del transporte");
            Id = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la fecha que desea hacer la reserva");
            FechaReserva = Console.ReadLine();
        }
        public void confirmar()
        {
      
            Console.WriteLine("Reserva confirmada.");
        }

        public void cancelar()
        {

            Console.WriteLine("Reserva cancelada.");
        }

        public void verR() 
        {
            Console.WriteLine("{0,-20}{1,-25}",Id,FechaReserva);
        }

        public static Transporte operator --(Transporte t)
        {
            t.leerDatos();
            return t;
        }

        public static Transporte operator ++(Transporte t)
        {
            t.verDatos();
            return t;
        }
    }

}
