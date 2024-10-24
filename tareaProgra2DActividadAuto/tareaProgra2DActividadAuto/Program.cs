namespace tareaProgra2DActividadAuto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SistemaReserva lsReser= new SistemaReserva();
            int cicloUs = 1;

            while (cicloUs == 1)
            {
                Console.WriteLine("-----------------------------------------------------");
                Console.WriteLine("Seleccione el tipo de transporte para su reserva:");
                Console.WriteLine("-----------------------------------------------------");
                Console.WriteLine("1)Vuelo/2)Tren/3)Autobus");
                int elecUs = int.Parse(Console.ReadLine());
                Transporte transporte = null;

                if (elecUs == 1)
                {
                    transporte = new Vuelo();
                }
                else if (elecUs == 2)
                {
                    transporte = new Tren();
                }
                else if (elecUs == 3)
                {
                    transporte = new Autobus();
                }
                else
                {
                    Console.WriteLine("ERROR!!!!!!!!.");
                     
                }
                --transporte;
                lsReser.agreR(transporte);

                int auxiliar = 1;
                while (auxiliar != 3) 
                {
                    Console.WriteLine("-----------------------------------------------------");                
                    Console.WriteLine("1 Agregar un trasporte");
                    Console.WriteLine("2 Confirmar o Cancelar su reserva");
                    Console.WriteLine("3 Finalizar");
                    Console.WriteLine("-----------------------------------------------------");

                    auxiliar = int.Parse(Console.ReadLine());

                    if (auxiliar == 1)
                    {                    
                        break; 
                    }
                    else if (auxiliar == 2)
                    {
                        Console.WriteLine("-----------------------------------------------------------------");
                        Console.WriteLine("Ingrese el ID del transporte para Cancelar o Confirmar su reserva");
                        Console.WriteLine("-----------------------------------------------------------------");
                        int id = int.Parse(Console.ReadLine());
                        lsReser.estR(id); 

                    }
                    else if (auxiliar == 3)
                    {
                        cicloUs = 0;
                    }
                    else
                    {
                        Console.WriteLine("ERROR!!!!!!!!!!");
                    }
                }
            }
            lsReser.verReser();
        }

           
    }
    
}
