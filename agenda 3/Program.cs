using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace agenda_3
{
    class Program
    {
        static string[,] agenda; 

        static int Contactos = 0;

        static int Contador = 0;



        static void Main(string[] args)
        {
            char menu = 'n';
            string linea = " ";
            string buscar = " ";
            int op = 0;

            while (menu! = 's')
            {

                Console.WriteLine(" 1.-crear contacto ");
                Console.WriteLine(" 2.-mostrar contactos ");
                Console.WriteLine(" 3.-buscar contactos ");
                Console.WriteLine(" 4.-modificar contacto ");
                Console.WriteLine(" 5.-eliminar contacto ");
                Console.WriteLine(" 6.-salir ");

                linea = Console.ReadLine();
                op = int.Parse(linea);

                if (op == 1)
                {
                    GuardarContacto();
                }
                Contactos = PedirNoContactos();

                agenda = new string[4, Contactos];

                Console.WriteLine("\n");

                GuardarContacto();

                GuardarContacto();

                MostrarContactos();



                BuscarModificarEliminar('b');

                BuscarModificarEliminar('m');

                MostrarContactos();

                BuscarModificarEliminar('e');

                MostrarContactos();





                Console.ReadKey();

            }
        }


        static int PedirNoContactos()

        {

            Console.Write("Cuantos contactos desea agregar: ");

            return int.Parse(Console.ReadLine());

        }



        static string PedirDatos(string linea)

        {

            string dato = "";

            dato = "Ingrese " + linea + " : ";

            return dato;

        }



        static void GuardarContacto()

        {

            if (Contador < Contactos)

            {

                Console.Write(PedirDatos("Nombre"));

                agenda[0, Contador] = Console.ReadLine();

                Console.Write(PedirDatos("Apellido"));

                agenda[1, Contador] = Console.ReadLine();

                Console.Write(PedirDatos("Direccion"));

                agenda[2, Contador] = Console.ReadLine();

                Console.Write(PedirDatos("Telefono"));

                agenda[3, Contador] = Console.ReadLine();

                Contador++;

                Console.WriteLine("\n");

            }

            else

            {

                Console.WriteLine("Agenda llena\n");

            }

        }



        static void MostrarContactos()

        {

            for (int f = 0; f < Contador; f++)

            {

                Console.WriteLine(agenda[0, f] + "--" + agenda[1, f] + "--" + agenda[2, f] + "--" + agenda[3, f] + "\n");

            }

        }

        static void BuscarModificarEliminar2(char tipo)
        {
            string buscar = "";
            Console.Write("ingrese el nombre del contacto : ");
            buscar = Console.ReadLine();

        }

        static void BuscarModificarEliminar(char tipo)

        {

            string buscar = "";
            Console.Write("ingrese el nombre del contacto : ");
            buscar = Console.ReadLine();

            for (int f = 0; f < Contactos; f++)

            {

                if (tipo == 'b')

                {


                    buscar = Console.ReadLine();

                    if (buscar == agenda[0, f])

                    {

                        Console.WriteLine(agenda[0, f] + "--" + agenda[1, f] + "--" + agenda[2, f] + "--" + agenda[3, f]);

                    }

                }

                else if (tipo == 'm')

                {

                    buscar = Console.ReadLine();

                    if (buscar == agenda[0, f])

                    {

                        Console.Write(PedirDatos("Nombre"));

                        agenda[0, f] = Console.ReadLine();

                        Console.Write(PedirDatos("Apellido"));

                        agenda[1, f] = Console.ReadLine();

                        Console.Write(PedirDatos("Direccion"));

                        agenda[2, f] = Console.ReadLine();

                        Console.Write(PedirDatos("Telefono"));

                        agenda[3, f] = Console.ReadLine();

                    }

                }

                else

                {

                    buscar = Console.ReadLine();

                    if (buscar == agenda[0, f])

                    {

                        agenda[0, f] = " ";

                        agenda[1, f] = " ";

                        agenda[2, f] = " ";

                        agenda[3, f] = " ";

                    }

                }

            }

        }
    }
}
