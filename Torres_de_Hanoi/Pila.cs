using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Torres_de_Hanoi
{
    class Pila
    {
        //PROPIEDADES
        //------------------------------------------
        //Propiedad Size
        public int Size { get; set; }
        
        //Propiedad Top
        public int Top { get { return Elementos.Count; } set { } }

       //Propiedad Elementos (Lista)
        public List<Disco> Elementos { get; set; }
        //------------------------------------------
        

        //MÉTODOS
        //------------------------------------------

        //---------------------------
        //Constructor de la clase
        public Pila()
        {
            //Creamos nueva lista
            Elementos = new List<Disco>();
            //Inicializamos Size a 0
            Size = 0;
        }
        //---------------------------

        //---------------------------
        //Colocar disco en la pila
        public void push(Disco d)
        {
            //Añadimos a la lista el Disco d (Añadimos un disco a la pila)
            Elementos.Add(d);
            //Incrementamos el valor de Size (El disco añadido)
            Size++;
        }
        //---------------------------

        //---------------------------
        //Extraer disco de la pila
        public Disco pop()
        {
            //Extraemos el disco de la pila
            //El -1 Debe estar porque el Elementos.Count devuelve 3, y como se registran las posiciones (0,1,2), se saldría y da error
            Disco d = Elementos[Elementos.Count - 1];
            Elementos.RemoveAt(Elementos.Count - 1);
            Size--;
            return d;
        }
        //---------------------------

        //---------------------------
        //Informa si la pila está vacía o no
        public bool isEmpty()
        {
            //Si el tamaño es 0, está vacío, por lo que devuelve true
            if(Size == 0)
            {
                return true;
            }

            //Si no, devuelve falso.
            else
            {
                return false;
            }
        }
        //---------------------------

    }
}
