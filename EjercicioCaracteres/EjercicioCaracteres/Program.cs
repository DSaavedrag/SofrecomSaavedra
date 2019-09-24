using System;
using System.Collections.Generic;

namespace EjercicioCaracteres
{
    class Program
    {
        
        static void Main(string[] args)
        {
            //Inicialización de instancias de clase y variables.


            Procesador p = new Procesador();
            List<Boton> botones = p.Iniciar();
            
            //-------------------------------------------------
            Console.WriteLine("Ingrese una oración");
            string oracion =  Console.ReadLine();
            Console.WriteLine("Su oración fue: " +oracion);
            p.RecorrerString(oracion, botones);
            Console.ReadKey();
        }

    }
}
