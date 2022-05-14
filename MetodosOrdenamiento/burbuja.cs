using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodosOrdenamiento
{
    internal class burbuja
    {
        private int[] vector;
        public void cargar()
        {
            Console.WriteLine("Metodo de ordenamiento burbuja");
            Console.WriteLine("Ingrese la cantidad de valores a ordenar");
            string longitud;
            longitud = Console.ReadLine();
            int cant;
            cant= int.Parse(longitud);
            vector = new int[cant];
            for(int i = 0; i < vector.Length; i++)
            {
                Console.WriteLine("Ingrese el valor de la posicion "+(i+1)+": "); 
                longitud= Console.ReadLine();
                vector[i] = int.Parse(longitud);
            }
        }
        public void metodo()
        {
            int t;
            for(int a=1; a<vector.Length; a++)
            {
                for(int b = vector.Length-1; b>=a; b--)
                {
                    if (vector[b - 1] > vector[b])
                    {
                        t = vector[b - 1];
                        vector[b - 1] = vector[b];
                        vector[b] = t;
                    }
                }
            }
        }
        public void mostrar()
        {
            string NombreArchivo = "temp.txt";
            //abro el archivo
            StreamWriter writer = File.AppendText(NombreArchivo);
            Console.WriteLine("Numeros en el arreglo");
            for(int i = 0; i < vector.Length; i++)
            {
                Console.WriteLine(vector[i]+" ");
                //ingreso infromacion al archivo
                writer.WriteLine(vector[i] + "");
            }
            //cierro el archivo
            writer.Close();
            Console.ReadKey();
        }
    }
}
