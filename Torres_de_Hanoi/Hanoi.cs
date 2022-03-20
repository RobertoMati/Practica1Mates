using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Torres_de_Hanoi
{
    class Hanoi
    {
        //Creación variables
        private int movimientos;
        private int discos;


        //Métodos
        public void mover_disco(Pila a, Pila b)
        {
            //Si la pila b está vacía, se mueve el disco a la pila "a"
            if (b.isEmpty() == true)
            {
                movimientoDisco(a, b);
            }
            //Si la pila a está vacía, se mueve el disco a la pila "a"
            else if (a.isEmpty() == true)
            {
                movimientoDisco(b, a);
            }
            //Si las pilas no están vacías
            else
            {
                //Definimos los valores de los discos para compararlos
                //Se podría ahacer directamente sin asignarlos ahora
                Disco discoA = a.Elementos[a.Top];
                Disco discoB = b.Elementos[b.Top];
                
                //Si el valor de discoA es más grande que el valor de discoB
                if (discoA.Valor > discoB.Valor)
                {
                    //Movemos el disco de "b" a "a"
                    movimientoDisco(b, a);
                }
                //Si el valor de discoB es más grande que el valor de discoA
                else
                {
                    //Movemos el disco de "a" a "b"
                    movimientoDisco(a, b);
                }
            }

        }


        //Funcion para mover los discos cuando se da alguno de los casos de mover_disco
        public void movimientoDisco(Pila uno, Pila dos)
        {
            //Extraemos en disco de la pila uno
            Disco disco = uno.pop();

            //Mostramos el movimiento y el valor del disco movido
            Console.WriteLine("Se ha movido el disco con valor: " + disco.Valor);

            //Añadimos a la segunda pila el disco que hemos movido
            dos.push(disco);

        }

        //Funcion para comprobar el movimiento de los discos entre pilas
        public void mirarMovimientos(Pila uno, Pila dos, Pila fin)
        {
            //Si el tamaño de la pila final es menor a los discos, podemos mover
            if (fin.Size < discos)
            {
                mover_disco(uno, dos);
                movimientos++;
            }
        }

        //Funcion del metodo iterativo
        public int iterativo(int num, Pila inicio, Pila final, Pila auxiliar)
        {
            //Definicion de valores
            discos = num;
            bool condicion = false;
            movimientos = 0;

            //Si el numero de discos es impar
            if (num % 2 != 0)
            {
                //Mientras que la condicion sea falsa (no haya solucion)
                while(condicion == false)
                {
                    mirarMovimientos(inicio, final, final);
                    mirarMovimientos(inicio, auxiliar, final);
                    mirarMovimientos(auxiliar,final,final);

                    if(final.Size == num)
                    {
                        condicion = true;
                    }
                }
            }

            //Si el numero de discos es par
            else
            {
                //Mientras la condicion sea falsa (no haya solucion)
                while (condicion == false)
                {
                    mirarMovimientos(inicio, auxiliar, final);
                    mirarMovimientos(inicio, final, final);
                    mirarMovimientos(auxiliar, final, final);

                    if (final.Size == num)
                    {
                        condicion = true;
                    }
                }
            }
            //Devolver el numero de movimientos realizados (Se incrementa por mirarMovimientos)
            return movimientos;
        }

        //Funcion del método recursivo
        public int recursivo(int num, Pila inicio, Pila final, Pila auxiliar)
        {
            //Si el número de discos es 1. Esto es el caso base necesario en la recursividad
            if (num == 1)
            {
                mirarMovimientos(inicio, final, final);
            }
            //Algoritmo PDF, fuera del caso base de la recursividad
            else
            {
                recursivo(num-1,inicio, auxiliar, final);
                mirarMovimientos(inicio, final, final);
                recursivo(num-1,auxiliar,final, inicio);
            }
            return movimientos;
        }

        //Llamamos a la funcion recursiva para poder utilizar el algoritmo
        public int UsoRecursivo(int num, Pila inicio, Pila final, Pila auxiliar)
        {
            discos = num;
            movimientos = recursivo(num, inicio, final, auxiliar);
            return movimientos;
        }


    }
}
