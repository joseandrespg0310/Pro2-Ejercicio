using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tareaProgra2DActividadAuto
{

    class Tren : Transporte
    {
        public string Estacion { get; set; }
        public string NumeroAsientos { get; set; }
        public string EstacionLlegada { get; set; }
        //CONSTRUCTORES
        public Tren() : base()
        {
            Estacion = "NO DEFINIDO";
            NumeroAsientos = " NO DEFINIDO";
            EstacionLlegada = "NO DEFINIDO";
        }
        public Tren(string est, string nroA,string estL, int id, string fech) : base(id,fech)
        {
            Estacion = est;
            NumeroAsientos = nroA;
            EstacionLlegada = estL;
        }
        //FUNCIONALIDAD
        public override void verDatos()
        {
            base.verDatos();
            Console.WriteLine("{0,-20}{1,-15}{2,-15}", Estacion, NumeroAsientos,EstacionLlegada);
        }
        public override void leerDatos()
        {

            base.leerDatos();
            Console.WriteLine("Ingrese estación de salida:");
            Estacion = Console.ReadLine();
            Console.WriteLine("Ingrese la cantidad de asientos:");
            NumeroAsientos = Console.ReadLine();
            Console.WriteLine("Ingrese cual es su Estacion de llegada");
            EstacionLlegada = Console.ReadLine();
        }


    }

}
