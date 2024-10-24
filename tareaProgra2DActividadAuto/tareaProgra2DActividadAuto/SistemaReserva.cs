using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;
using System.Collections.Generic;

namespace tareaProgra2DActividadAuto
{
    internal class SistemaReserva
    {
        private List<Transporte> lstReservas = new List<Transporte>(); 

        public void agreR(Transporte trans)
        {
            lstReservas.Add(trans);
        }
        public void estR(int id)
        {
            for (int i = 0; i < lstReservas.Count; i++)
            {
                if (lstReservas[i].Id == id)
                {
                    Console.WriteLine("1)Confirmar/2)Cancelar");
                    int accion = int.Parse(Console.ReadLine());

                    if (accion == 1)
                    {
                        lstReservas[i].confirmar();
                        Console.WriteLine("Reserva confirmada.", id);
                    }
                    else if (accion == 2)
                    {
                        lstReservas[i].cancelar();
                        Console.WriteLine("Reserva cancelada.", id);
                    }
                    else
                    {
                        Console.WriteLine("Opción no válida.");
                    }
                    return;
                }
            }

            Console.WriteLine("La reserva no existe!!!!.");
        }
        public void verReser()
        {
            Console.WriteLine("-----------------------------------------------------");
            Console.WriteLine("* * * Listado de reservas* * * * * ");
            Console.WriteLine("-----------------------------------------------------");
            foreach (var res in lstReservas)
            {
                res.verDatos(); 
            }
        }
    }
}
