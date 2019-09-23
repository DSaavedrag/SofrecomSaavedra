using System;

namespace EjercicioCaracteres
{
    class Boton
    {
        private char[] caracteres;
        private int numero;

        public Boton(char[] caracteres, int numero)
        {
            this.caracteres = caracteres;
            this.numero = numero;
        }

        public void setCaracteres(char[] caracteres)
        {
            this.caracteres = caracteres;
        }

        public char[] getCaracteres()
        {
            return this.caracteres;
        }

        public void setNumero(int numero)
        {
            this.numero = numero;
        }

        public int getNumero()
        {
            return this.numero;
        }

        public bool buscarChar(char c)
        {
            bool encontrado = false;
            int i = 0;

            while (encontrado == false && i < this.getCaracteres().Length)
            {
                if (this.getCaracteres()[i] == c)
                {
                    Console.WriteLine(this.getNumero());
                    encontrado = true;
                }
                else
                {
                    i++;
                }
            }
            return false;
        }
    }
}

