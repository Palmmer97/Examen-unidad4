using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen_Uni_4
{
    class Program
    {
        public class Nodo
        {
            public string Magia;
            public Nodo Izquierda, Derecha;

            public Nodo(string item)
            {
                Magia = item;
                Izquierda = Derecha = null;
            }
        }

        public class Arbolito
        {            
            public Nodo raiz;

            public Arbolito()
            {
                raiz = null;
            }
           
            public void recorridoPostorder(Nodo nodo)
            {    
                if (nodo == null)
                    return;
               
                recorridoPostorder(nodo.Izquierda);                
                recorridoPostorder(nodo.Derecha);              
                Console.Write(nodo.Magia + " ");
            }
           
            public void recorridoPreorder(Nodo nodo)
            {   
                if (nodo == null)
                    return;
             
                Console.Write(nodo.Magia + " ");                
                recorridoPreorder(nodo.Izquierda);
                recorridoPreorder(nodo.Derecha);
            }

            public void recorridoPostorder() { recorridoPostorder(raiz); }
            public void recorridoPreorder() { recorridoPreorder(raiz); }
        }
        static void Main(string[] args)
        {
              Arbolito Arbolitoo = new Arbolito(); 

            Arbolitoo.raiz = new Nodo("=A=");
            Arbolitoo.raiz.Izquierda = new Nodo("=B=");
            Arbolitoo.raiz.Derecha = new Nodo("=E=");
            Arbolitoo.raiz.Izquierda.Izquierda = new Nodo("=C=");
            Arbolitoo.raiz.Izquierda.Derecha = new Nodo("=D=");
            Arbolitoo.raiz.Derecha.Derecha = new Nodo("=F=");
            Arbolitoo.raiz.Derecha.Derecha.Izquierda = new Nodo("=G=");
            Arbolitoo.raiz.Derecha.Derecha.Derecha = new Nodo("=H=");

            Console.WriteLine("\nRecorrido preorden " );
            Arbolitoo.recorridoPreorder();
            Console.WriteLine();
            Console.WriteLine("\nRecorrido posorden " );
            Arbolitoo.recorridoPostorder();
            Console.WriteLine();
            Console.Write("\nteclee cualquier tecla :) ");
            Console.ReadKey();
        }
        
    }
}
