using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodosOrdenamiento
{
    internal class seleccion
    {
        private int[] vector;
        public void Cargar()
        {
            Console.WriteLine("Metodo de ordenamiento seleccion");
            Console.WriteLine("Ingrese la cantidad de valores a ordenar");
            string longitud;
            longitud = Console.ReadLine();
            int cant;
            cant = int.Parse(longitud);
            vector = new int[cant];
            for (int i = 0; i < vector.Length; i++)
            {
                Console.WriteLine("Ingrese el valor de la posicion " + (i + 1) + ": ");
                longitud = Console.ReadLine();
                vector[i] = int.Parse(longitud);
            }
        }
        public void Metodo()
        {
            int auxiliar;
            int q;
            int izqui;
            int dere;
            int j;
            for (int i = 0; i < vector.Length; i++)
            {
                auxiliar = vector[i];
                izqui = 0;
                dere = i - 1;
                while (izqui <= dere)
                {
                    q = ((izqui + dere) / 2);
                    if (auxiliar < vector[q])
                    {
                        dere = q - 1;
                    }
                    else
                    {
                        izqui = q + 1;
                    }
                    j = i - 1;
                    while (j >= izqui)
                    {
                        vector[j + 1] = vector[j];
                        j = j - 1;
                    }
                    vector[izqui] = auxiliar;
                }
            }
            for (int i = 0; i < vector.Length; i++)
                Console.WriteLine(" " + vector[i]);
        }
        public void Imprimir()
        {
            Console.WriteLine("Vector ordenados en forma ascendente");
            for (int f = 0; f < vector.Length; f++)
            {
                Console.Write(vector[f] + "  ");
            }
            Console.ReadKey();
        }
    }
}
