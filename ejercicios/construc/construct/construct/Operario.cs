using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace construct
{
    class Operario
    {
      
        
            //SE DESEA GUARDAR LOS SIELDOS DE 5 OPERArios en un vector . Realizar la creacion y carga dl vector en el constructor 

        private  int[] Sueldos;

        public Operario()
        {
            Sueldos = new int[5];
            for (int f = 0; f < Sueldos.Length ; f++)
			{
			 Console.WriteLine("INGRESE SU SUELDO :");
                Sueldos[f]=int.Parse(Console.ReadLine());
            }


        }
        public void Imprimir ()
        {

            for (int f = 0; f < Sueldos.Length; f++)
			{
			 Console.WriteLine(Sueldos[f]+"\n");
			}
            Console.ReadKey();
        }

          static void Main(string[] args)
          {

              Operario  Oper = new Operario();
              Oper.Imprimir();
          }

        }
    }

