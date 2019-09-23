using System;
using System.Collections.Generic;

namespace EjercicioCaracteres
{
    class Program
    {

        static void Main(string[] args)
        {
            //Inicialización de instancias de clase y variables.
            char[] char2 = new char[3];
            char2[0] = 'a';
            char2[1] = 'b';
            char2[2] = 'c';
            Boton boton2 = new Boton(char2, 2);
            char[] char3 = new char[3];
            char3[0] = 'd';
            char3[1] = 'e';
            char3[2] = 'f';
            Boton boton3 = new Boton(char3, 3);
            char[] char4 = new char[3];
            char4[0] = 'g';
            char4[1] = 'h';
            char4[2] = 'i';
            Boton boton4 = new Boton(char4, 4);
            char[] char5 = new char[3];
            char5[0] = 'j';
            char5[1] = 'k';
            char5[2] = 'l';
            Boton boton5 = new Boton(char5, 5);
            char[] char6 = new char[3];
            char6[0] = 'm';
            char6[1] = 'n';
            char6[2] = 'o';
            Boton boton6 = new Boton(char6, 6);
            char[] char7 = new char[4];
            char7[0] = 'p';
            char7[1] = 'q';
            char7[2] = 'r';
            char7[3] = 's';
            Boton boton7 = new Boton(char7, 7);
            char[] char8 = new char[3];
            char8[0] = 't';
            char8[1] = 'u';
            char8[2] = 'v';
            Boton boton8 = new Boton(char8, 8);
            char[] char9 = new char[4];
            char9[0] = 'w';
            char9[1] = 'x';
            char9[2] = 'y';
            char9[3] = 'z';
            Boton boton9 = new Boton(char9, 9);
            char[] char0 = new char[1];
            char0[0] = ' ';
            Boton boton0 = new Boton(char0, 0);

            List<Boton> lista = new List<Boton>();
            lista.Add(boton2);
            lista.Add(boton3);
            lista.Add(boton4);
            lista.Add(boton5);
            lista.Add(boton6);
            lista.Add(boton7);
            lista.Add(boton8);
            lista.Add(boton9);
            lista.Add(boton0);

            /* Console.WriteLine(boton2.getCaracteres().GetValue(1) + "   " + boton2.getNumero());
             Console.WriteLine(boton3.getCaracteres().GetValue(1) + "   " + boton3.getNumero());
             Console.WriteLine(boton4.getCaracteres().GetValue(1) + "   " + boton4.getNumero());
             Console.WriteLine(boton5.getCaracteres().GetValue(1) + "   " + boton5.getNumero());
             Console.WriteLine(boton6.getCaracteres().GetValue(1) + "   " + boton6.getNumero());
             Console.WriteLine(boton7.getCaracteres().GetValue(1) + "   " + boton7.getNumero());

             Console.WriteLine("Ingrese una oración");
             String oracion =  Console.ReadLine();
             Console.WriteLine("Su oración fue: "+oracion);
             Console.ReadKey();*/

            boton2.buscarChar('c');
            Console.ReadKey();
        }
    }
}
