using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tareaProgra2DActividadAuto
{

    class Autobus : Transporte
    {
        //PROPIEDADES
        public string Empresa { get; set; }
        public string NumeroVoleto { get; set; }
        public string ColorAutobus { get; set; }
        //CONSTRUCTORES
        public Autobus():base()
        {
            Empresa = "NO DEFINIDO";
            NumeroVoleto = " NO DEFINIDO";
            ColorAutobus = " NO DEFENIDO";
        }
        public Autobus(string emp,string nroV,string colA, int id, string fech) :base(id,fech)
        {
            Empresa=emp;
            NumeroVoleto = nroV;
            ColorAutobus=colA;
        }
        //FUNCIONALIDAD
        public override void verDatos()
        {
            base.verDatos();
            Console.WriteLine("{0,-20}{1,-15}{2,-25}", Empresa,NumeroVoleto,ColorAutobus);
        }
        public override void leerDatos()
        {
            base.leerDatos();
            Console.WriteLine("Ingrese empresa de autobús:");
            Empresa = Console.ReadLine();
            Console.WriteLine("Ingrese número del voleto:");
            NumeroVoleto = Console.ReadLine();
            Console.WriteLine("Ingrese el color del autobus");
            ColorAutobus = Console.ReadLine();
        }

      
    }

}

