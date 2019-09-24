using System;
using System.Collections.Generic;

namespace EjercicioCaracteres
{
    public class Procesador
    {

        public List<Boton> Iniciar() //devuelve la lista de botones, con su correspondiente cadena de caracteres y número.
        {
            // Constructor de todos los botones, con su correspondiente valor númerico.
            int cantidad = 9;
            List<Boton> botones = new List<Boton>();
            Boton boton;
            for (int i = 0; i < cantidad; i++)
            {
                if (i + 1 == cantidad)
                {
                    boton = new Boton(null, 0);
                }
                else
                {
                    boton = new Boton(null, i + 2);
                }

                botones.Add(boton);
            }

            //--------------------------------------------------------------------------

            //Set de los caracteres en su correspondiente boton.

            string alfabeto = "abcdefghijklmnopqrstuvwxyz ";

            foreach (var item in botones)
            {
                char[] chars;
                if (item.GetNumero() == 7 || item.GetNumero() == 9)
                {
                    chars = new char[4];
                }
                else if (item.GetNumero() == 0)
                {
                    chars = new char[1];
                }
                else
                {
                    chars = new char[3];
                }

                for (int i = 0; i < chars.Length; i++)
                {
                    chars[i] = alfabeto[i];

                }
                item.SetCaracteres(chars);
                alfabeto = alfabeto.Remove(0, chars.Length);
            }
            return botones;
        }
        public string RecorrerString(string input,List<Boton> botones)
        {
            string result = "";
            for (int i = 0; i < input.Length; i++)
            {
                int j = 0;
                bool encontrado = false;
                while (j != botones.Count && encontrado == false)
                {
                    result += botones[j].BuscarChar(input[i]);
                    if (!string.IsNullOrEmpty(result))
                    {
                        encontrado = true;
                        Console.Write(result);
                        result = "";
                    }
                    j++;
                }

            }
            return result;
        }//Recorre cada caracter del input y lo va buscando en cada boton hasta encontrarlo, luego imprime.
    }
}
