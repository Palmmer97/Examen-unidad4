using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam_uni_4_Grafo
{
    class Gratito
    {
        public int Vertice { get; set; } 
        List<int>[] LocaList; 
        public Gratito(int V) 
        {
            Vertice = V;  
            LocaList = new List<int>[V]; 
            for (int i = 0; i < V; i++) 
            {
                LocaList[i] = new List<int>();
            }
        }

        public void Anexar(int Indice, int V) 
        {
            LocaList[Indice].Add(V); 
        }



        public void DFS(int V, int Datos) 
        {
            List<string> Ciudad = new List<string>();
            if (Datos == 1 || Datos == 2)
            {
                Ciudad.Add("Boston");
                Ciudad.Add("Chicago");
                Ciudad.Add("Denver");
                Ciudad.Add("LA");
                Ciudad.Add("New York");
                Ciudad.Add("San Francisco");
                Ciudad.Add("Miami");
                Ciudad.Add("Atlanta");
            }
            if (Datos == 3)
            {
                Ciudad.Add("Atlanta");
                Ciudad.Add("Chicago");
                Ciudad.Add("San Francisco");
                Ciudad.Add("Boston");
                Ciudad.Add("Denver");
                Ciudad.Add("LA");
                Ciudad.Add("New York");
                Ciudad.Add("Miami");
            }
            if (Datos == 4)
            {
                Ciudad.Add("Denver");
                Ciudad.Add("Chicago");
                Ciudad.Add("New York");
                Ciudad.Add("Atlanta");
                Ciudad.Add("San Francisco");
                Ciudad.Add("Boston");
                Ciudad.Add("LA");
                Ciudad.Add("Miami");
            }

            bool[] Vuelo = new bool[Vertice]; 
            Stack<int> Energia = new Stack<int>();  
            Vuelo[V] = true; 
            Energia.Push(V); 
            Console.SetCursorPosition(0, 8);            
            while (Energia.Count != 0) 
            {
                V = Energia.Pop(); 
                Console.Write("{0}=> ", Ciudad[V]);                 
                foreach (int item in LocaList[V]) 
                {
                    if (!Vuelo[item]) 
                    {
                        Vuelo[item] = true; 
                        Energia.Push(item); 
                    }
                }
            }
            Console.Write("Game Over de la ruta");
        }

        public int V { get; set; }
    }
}
