using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace constructor4
{
    class Operaciones
    {
  
        
            //inplementar una clase llamada operaciones   se deben cargar  2 valore int en el constructor , calcular su suma ,resta,multiplicacion y division
            //cada una en un metodo e imprimir dicho resultado

        int x, y;

        public Operaciones()
        {

           
            Console.WriteLine("INGRESE UN NUMERO");
            x = int.Parse(Console.ReadLine());

            Console.WriteLine("INGRESE UN NUMERO");
            y = int.Parse(Console.ReadLine());

        }

        public void suma()
        {

            Console.WriteLine("la sume de x and y  es :"+ (x+y));

        }
        public void resta()
        {

            Console.WriteLine("la resta de x and y  es :" +( x - y));

        }
        public void multi()
        {

            Console.WriteLine("la multiplicacion de x and y  es :" + (x * y));

        }
        public void div()
        {

            Console.WriteLine("la division de x and y  es :" +( x / y));

           

        }
        public void OperacionTotal()
        {
            suma();
            resta();
            multi();
            div();

            Console.ReadKey();

        }

        static void Main(string[] args)
        {

            Operaciones oper = new Operaciones();
            oper.OperacionTotal();
        }
       

        }
    }

