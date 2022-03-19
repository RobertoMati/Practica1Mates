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
                //Definimos los valore de los discos para compararlos
                //Se podría ahacer directamente sin asignarlos ahora
                Disco discoA = b.Elementos[b.Top];
                Disco discoB = a.Elementos[a.Top];

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
            Console.WriteLine("El disco se ha movido" + disco.Valor);

            //Añadimos a la segunda pila el disco que hemos movido
            dos.push(disco);

        }

        //Funcion del metodo iterativo
        public int iterativo(int n, Pila inicio, Pila final, Pila auxiliar)
        {
            return 0;
        }

    }
}
