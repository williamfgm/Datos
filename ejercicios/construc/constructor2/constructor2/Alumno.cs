using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace constructor2
{
    class Alumno
    {
       
     
        //{
            // generar una clase alumnpo y definir como atributos  su nombre y su edad  en el constructor 
            //realizar la carga de datos y definir  otros dos metodos , para imprimir los datos ingresados y un msm   si es mayor o no , de edad.



        String name;
        int Edad;

        public Alumno()
        {

           

            Console.WriteLine("ingrese su nombre");
            name = Convert.ToString(Console.ReadLine());

            Console.WriteLine("ongrese su edad"); 
            Edad = int.Parse(Console.ReadLine());


        }
        public void Condicion()
        {
            if ( Edad  > 18)
            {
                Console.WriteLine("usted es mayor de edad"); 
            }
            else
            {
                Console.WriteLine("usted es menor de edad");
            }
        }
        public void Imprimir()
        {
            Console.WriteLine("su nombre es "+ name);
            Console.WriteLine("se edad es " + Edad);

            Console.ReadKey();
        }
        

        static void Main(string[] args)
        {
            Alumno Alum = new Alumno();
            Alum.Condicion();
            Alum.Imprimir();

        }
        }
    }

