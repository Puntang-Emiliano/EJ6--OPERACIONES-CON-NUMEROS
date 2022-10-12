using System;

namespace EJ6_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;

            float a = 0.0f;
            float b = 0.0f;
            float total = 0.0f;
            string valor;
            int opcion = 0;

            Console.WriteLine("Si quiere realizar una Suma ingrese 1");
            Console.WriteLine("Si quiere realizar una Resta ingrese 2");
            Console.WriteLine("Si quiere realizar una División ingrese 3");
            Console.WriteLine("Si quiere realizar una Multiplicación ingrese 4");
            Console.WriteLine("Ingrese la operacion que quiere realizar");
            valor = Console.ReadLine();
            opcion = Convert.ToInt32(valor);
            Console.WriteLine("Ingrese el primer numero");
            valor = Console.ReadLine();
            a = Convert.ToSingle(valor);
            Console.WriteLine("Ingrese el segundo numero");
            valor = Console.ReadLine();
            b = Convert.ToSingle(valor);

            switch (opcion)
            {
                case 1:
                    total = a + b;
                    Console.WriteLine("La suma es " + total);
                    break;
                case 2:
                    total = a - b;
                    Console.WriteLine("La resta es " + total);
                    break;
                case 3:
                    if (b==0)
                    {
                        Console.WriteLine("La division es infinita");
                    }
                    else
                    {
                        total = a / b;
                        Console.WriteLine("La division es " + total);
                    }
                    break;
                case 4:
                    total = a * b;
                    Console.WriteLine("El Producto es " + total);
                    break;

                default:
                    Console.WriteLine("La opcion no es correcta");
                    break;




            }
        }
    }
}