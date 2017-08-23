using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace constructor3
{
    class Socio
    {
      
        
            //plantear una clase club y otra socio , La clase socio debe tener los  siguientes atributos privados NAME,y la antiguedad en el club en año.En el constructor   pedir la caga de nombre 
            //y su antiguedad.La  clase club debe tener como atributos 3 onbjetos de la clase Definir una responsabilidad  para imprimir el nombre del socio  con mayor antiguedad en el club

        private String Name;
        private int Antiguedad;

        public Socio()
        {
            Console.WriteLine("ingrese su nombre :");
            Name = Convert.ToString(Console.ReadLine());

            Console.WriteLine(" INGRESE LA ANTIGUEDAD  QUE LLEVA EN EL CLUB");
            Antiguedad = int.Parse(Console.ReadLine());
        }

        public void Imprimir()
        {
            Console.WriteLine("su nombre es "+ Name);
            Console.WriteLine("su antiguedad es "+ Antiguedad);

        }
        public int   RetornarAntiguedad()
        {
            return Antiguedad;
        }


        class club
        {
            private  Socio  Socio1, Socio2, Socio3;

            public club(){
              Socio1 = new Socio();
              Socio2 = new Socio();
              Socio3 = new Socio();


        }
            public void MayorAntiguedad()
            {
                Console.WriteLine("el socio con mayor antiguedad");

                if (Socio1.RetornarAntiguedad() > Socio2.RetornarAntiguedad() &&  Socio1.RetornarAntiguedad() > Socio3.RetornarAntiguedad())
                {
                    Socio1.Imprimir();
                }
           
                else
                
	            {
                    if  (Socio2.RetornarAntiguedad() > Socio1.RetornarAntiguedad() &&  Socio2.RetornarAntiguedad() > Socio3.RetornarAntiguedad())
	            {
		            Socio2.Imprimir();
	            }
                    else
	            {
                    Socio3.Imprimir();     
	            }
	            }
                Console.ReadKey();

             
               }
            static void Main(string[] args)
            {

                club Cb = new club();
                Cb.MayorAntiguedad();
            }
           }

       }
    }

