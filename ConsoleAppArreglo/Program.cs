using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppArreglo
{
    class Program
    {
        static void Main(string[] args)
        {




            //Datos[] a = new Datos[5];

            //Console.WriteLine(" Ingresa el nombre: ");
            //a.Nombre = Console.ReadLine();


            //for (int i = 0; i < a.Length; i++)
            //{
            //  a[i] = "";
            //}
            //for (int i = 0; i < a.Length; i++)
            //{
            // Console.WriteLine(a[i]);
            //}
            //Console.ReadKey()
            Datos[] a = new Datos[5];
            for (int i = 0; i < a.Length; i++)
            {
                a[i] = new Datos();
                a[i].Nombre = "";
                Console.WriteLine("Ingresa el Nombre");
                a[i].Nombre = Console.ReadLine();
                a[i].Apellidos = "";
                Console.WriteLine("Ingresa los Apellidos");
                a[i].Apellidos = Console.ReadLine();
                a[i].Carrera = "";
                Console.WriteLine("Ingresa la carrera");
                a[i].Carrera = Console.ReadLine();
            }
            for (int i = 0; i < a.Length; i++)
            {
                Console.WriteLine(a[i].ToString());
            }
            Console.ReadKey();

     




            // for (int i = 0; i < a.Length; i++)
            //{
            //a[0] = ("Maria, ingenieria informatica");
            //a[1] = ("Jose, ingenieria metalurgica");
            //a[2] = ("Mario, licenciatura en educacion");
            // a[3] = ("Carlos, licenciatura en enfermeria");
            //a[4] = ("Azael, contaduria");
            //}
            //for (int i = 0; i < a.Length; i++)
            // {
            // Console.WriteLine(a[i]);

            // }
            //Console.ReadKey();



        }
     
    }
}
