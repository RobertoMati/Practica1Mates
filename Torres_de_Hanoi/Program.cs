using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Torres_de_Hanoi
{
    class Program
    {
        
        static void Main(string[] args)
        {
            
            Console.WriteLine("Escribe el número de discos que quieres que hayan y pulsa Enter.\n");

            
            //Guardo lo escrito por el usuario en un Strings
            String YaEscrito = Console.ReadLine().ToString();
            int valorEscrito;


            //En el caso de que el número que introduzca sea menor o igual a 0, o no sea un número, pide volver a introducir un número
            while (!Int32.TryParse(YaEscrito.ToString(), out valorEscrito) || valorEscrito <=0)
            {
                Console.WriteLine("Debes escribir un número mayor de 0 para continuar");
                Console.WriteLine("\nEscribe el número de discos que quieres que hayan");
                YaEscrito = Console.ReadLine().ToString();
            }
           
            //Definimos las pilas
            Pila inicio = new Pila();
            Pila auxiliar = new Pila();
            Pila final = new Pila();


            //Creamos los discos con los valores correspondientes según el número escrito
            for (int i = valorEscrito; i > 0; i--)
            {
                Disco disco = new Disco();
                disco.Valor = i;
                inicio.push(disco);
            }

            //Creamos hanoi para poder operar 
            Hanoi hanoi = new Hanoi();

            //Preguntamos al usuario el método que quiere utilizar
            Console.WriteLine("\n¿De qué forma quieres resolver el problema?");
            Console.WriteLine("\nEscribe 'a' para elegir el método iterativo o 'b' para el método recursivo.");
            ConsoleKey tecla = Console.ReadKey().Key;

            //Si las teclas presionadas no son ni la "a" ni la "b", pide volver a introducir una tecla
            while (tecla != ConsoleKey.A && tecla != ConsoleKey.B)
            {
                Console.WriteLine("\nLa tecla seleccionada no hace ninguna acción, elige una de las ofrecidas anteriormente.");
                tecla = Console.ReadKey().Key;
            }

            //Si el usuario escribe "a",  se ha elegido el método iterativo
            if (tecla == ConsoleKey.A)
            {
                Console.WriteLine("\n");
                Console.WriteLine("¡HAS ELEGIDO EL MÉTODO ITERATIVO!\n");
                Console.WriteLine("---------------------------------");
                Console.WriteLine("Al empezar, la pila inicial tiene " + inicio.Size + " discos; " + "la pila auxiliar " + auxiliar.Size + " y la pila final " + final.Size +".");
                Console.WriteLine("---------------------------------");
               
                //Guardamos los valores de los movimientos realizados
                double hanoiResultado = hanoi.iterativo(valorEscrito, inicio, final, auxiliar);
                
                //Guardamos el valor del número minimo de movimientos
                double valorMinimo = (Math.Pow(2, valorEscrito) - 1);

                Console.WriteLine("---------------------------------");
                Console.WriteLine("Ahora, la pila inicial tiene " + inicio.Size + " discos; " + "la pila auxiliar " + auxiliar.Size + " y la pila final " + final.Size + ".");
                Console.WriteLine("---------------------------------\n" + "\nSe han realizado " + hanoiResultado + " movimientos" + ", y el número mínimo de movimientos es " + valorMinimo + "\n");
                
                //Si son iguales muestra un mensaje, sino, muestra otro
                if ((Math.Pow(2, valorEscrito) - 1) == hanoiResultado)
                {
                    Console.WriteLine("¡El número de movimientos realizados coincide con el mínimo posible!");
                }
                else
                {
                    Console.WriteLine("Algo va mal, los valores no son iguales");
                }
            }

            //Si el usuario escribe "b",  se ha elegido el método recursivo
            else if (tecla == ConsoleKey.B)
            {
                Console.WriteLine("\n");
                Console.WriteLine("¡HAS ELEGIDO EL MÉTODO RECURSIVO!\n");
                Console.WriteLine("---------------------------------");
                Console.WriteLine("Al empezar, la pila inicial tiene " + inicio.Size + " discos; " + "la pila auxiliar " + auxiliar.Size + " y la pila final " + final.Size + ".");
                Console.WriteLine("---------------------------------");

                //Guardamos los valores de los movimientos realizados
                double hanoiResultadoRecursivo = hanoi.UsoRecursivo(valorEscrito, inicio, final, auxiliar);
                

                //Guardamos el valor del número minimo de movimientos
                double valorMinimo = (Math.Pow(2, valorEscrito) - 1);

                Console.WriteLine("---------------------------------");
                Console.WriteLine("Ahora, la pila inicial tiene " + inicio.Size + " discos; " + "la pila auxiliar " + auxiliar.Size + " y la pila final " + final.Size + ".");
                Console.WriteLine("---------------------------------\n" + "\nSe han realizado " + hanoiResultadoRecursivo + " movimientos" + ", y el número mínimo de movimientos es " + valorMinimo + "\n");

                //Si son iguales muestra un mensaje, sino, muestra otro
                if ((Math.Pow(2, valorEscrito) - 1) == hanoiResultadoRecursivo)
                {
                    Console.WriteLine("¡El número de movimientos realizados coincide con el mínimo posible!");
                }
                else
                {
                    Console.WriteLine("Algo va mal, los valores no son iguales.");
                }

            }

            Console.WriteLine("\nPulsa cualquier tecla para acabar");

            Console.ReadKey();

        }
    }
}
