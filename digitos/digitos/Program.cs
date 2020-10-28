

using System;

namespace digitos
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            int valor;
            do
            {
                Console.WriteLine("ingresa un valor entre 0 y 999 (0 finaliza");
                valor = int.Parse(Console.ReadLine());
                if (valor >= 100)
                {
                    Console.WriteLine("Tiene 3 digitos");
                }
                else
                {
                    if (valor >= 10)
                    {
                        Console.WriteLine("Tiene 2 digitos");
                    }
                    else
                    {
                        if (valor >= 1)
                        {
                            Console.WriteLine("Tiene 1 digito");
                        }
                    }
                }

            } while (valor != 0);*/
            ConsoleKeyInfo op;
            string opc;
            do
            {
                Console.Clear();//se supone que limpia la pantalla
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("menu de opciones ");
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("[A] Agregar ");
                Console.WriteLine("[B] Buscar ");
                Console.WriteLine("[C] Eliminar");
                Console.WriteLine("[D] Salir");
                opc = Console.ReadLine();

                switch (opc)
                {
                    case "A":
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("has ingresado la opcion de Agregar");
                        break;
                    case "B":
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.WriteLine("has ingresado la opcion de Buscar");
                        break;
                    case "C":
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("has ingresado la opcion de Eliminar");
                        break;
                    case "D":
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.WriteLine("has ingresado la opcion de Salir");
                        break;
                }
            } while (opc ="0");
        }
    }
}
