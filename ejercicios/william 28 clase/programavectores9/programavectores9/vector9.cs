using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//
namespace programavectores9
{
    class vector9
    {
        private string[] paises;

        public void cargar() {
            paises = new string[5];

            for (int f = 0; f < paises.Length; f++) {
                Console.WriteLine("ingrese el nombre del pais");
                paises[f] = Console.ReadLine();
            
            }
        
        }


        public void ordenar() {
            for (int k = 0; k < 4; k++) {
                for (int f = 0; f < 4 - k;f++ )
                {
                    if(paises[f].CompareTo(paises[f+1])>0){
                        string aux;
                        aux = paises[f];
                        paises[f] = paises[f + 1];
                        paises[f + 1] = aux;
                    
                    }

                }
            
            }
        
        }

        public void imprimir() {
            Console.WriteLine("paises ordenados de forma alfabetica:");
            for (int f = 0; f < paises.Length;f++ )
            {
                Console.WriteLine(paises[f]);

            }
            Console.ReadKey();
        }



        static void Main(string[] args)
        {
            vector9 vect = new vector9();
            vect.cargar();
            vect.ordenar();
            vect.imprimir();
        }
    }
}
