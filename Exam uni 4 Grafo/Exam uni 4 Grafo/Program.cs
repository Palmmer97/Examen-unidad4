using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam_uni_4_Grafo
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine(" Pulse teclas para ver las rutas cortas");
                Gratito Obes = new Gratito(5); 
                Obes.Anexar(0, 1); 
                Obes.Anexar(1, 2);
                Obes.Anexar(2, 3); 
                Obes.DFS(0,1);
                Console.WriteLine("\nTeclee cualquier tecla...");
                Console.ReadKey();
           
                Gratito Leon = new Gratito(7); 
                Leon.Anexar(0, 1); 
                Leon.Anexar(1, 2);
                Leon.Anexar(2, 3);
                Leon.Anexar(4, 5);
                Leon.DFS(4,2);
                Console.WriteLine("\nTeclee cualquier tecla...");
                Console.ReadKey();
   
                Gratito Hol = new Gratito(4);
                Hol.Anexar(0, 1);
                Hol.Anexar(1,2);
                Hol.DFS(0, 3);
                Console.WriteLine("\nTeclee cualquier tecla...");
                Console.ReadKey();
  
                Gratito es = new Gratito(4);
                es.Anexar(0, 1);
                es.Anexar(1, 2);
                es.DFS(0,4);
                Console.WriteLine("\nTeclee cualquier tecla...");
                Console.ReadKey();
           
                
                Console.ReadKey();
                          
        }                   
        
    }
}
