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
            //Captura de datos por pantalla y ejecución del programa.
            p.Ejecutar(botones);
        }

    }
}
