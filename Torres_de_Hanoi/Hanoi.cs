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
            //Si la pila b está vacía, se mueve el disco a la pila a
            if (b.isEmpty() == true)
            {
                movimientoDisco(a, b);
            }
            else if (a.isEmpty() == false)
            {
                movimientoDisco(b, a);
            }
            else
            {
                Disco discoA = b.Elementos[b.Top];
                Disco discoB = a.Elementos[a.Top];
            }

        }

        public void movimientoDisco(Pila a, Pila b)
        {
            Disco disco = a.pop();
            Console.WriteLine("El disco se ha movido" + disco.Valor);
            b.push(disco);

        }

        public int iterativo(int n, Pila ini, Pila fin, Pila aux)
        {
            return 0;
        }

    }
}
