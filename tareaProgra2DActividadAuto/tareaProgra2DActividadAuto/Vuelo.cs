using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tareaProgra2DActividadAuto
{

        class Vuelo : Transporte
        {
        //PROPIEDADES
            public string Aerolinea { get; set; }
            public string TipoBoleto { get; set; }
        //CONSTRUCTORES
        public Vuelo():base()
        {
            Aerolinea = " NO DEFINIDO";
            TipoBoleto = " NO DEFINIDO";
        }
        public Vuelo(string aero,string tipB, int id, string fech) :base(id,fech)
        {
            Aerolinea = aero;
            TipoBoleto= tipB;
        }
        //FUNCIONALIDAD
        public override void verDatos()
        {
            base.verDatos();
            Console.WriteLine("{0,-20}{1,-25}",Aerolinea,TipoBoleto);
        }

        public override void leerDatos()
            {
                base.leerDatos();
                Console.WriteLine("Ingrese aerolínea:");
                Aerolinea = Console.ReadLine();
                Console.WriteLine("Ingrese el tipo de voleto:");
                Console.WriteLine("Puede elegir entre: COMUN/VIP/SUPER VIP");
                TipoBoleto = Console.ReadLine();
            }          
        }
}

