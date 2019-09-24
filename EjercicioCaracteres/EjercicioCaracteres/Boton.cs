namespace EjercicioCaracteres
{
    public class Boton
    {
        private char[] caracteres;
        private int numero;
        private bool espacio = false;


        public Boton(char[] caracteres, int numero)
        {
            this.caracteres = caracteres;
            this.numero = numero;
        }

        public void SetCaracteres(char[] caracteres)
        {
            this.caracteres = caracteres;
        }

        public char[] GetCaracteres()
        {
            return this.caracteres;
        }

        public void SetNumero(int numero)
        {
            this.numero = numero;
        }

        public int GetNumero()
        {
            return this.numero;
        }

        public void SetEspacio(bool espacio)
        {
            this.espacio = espacio;
        }

        public bool GetEspacio()
        {
            return this.espacio;
        }
        public string BuscarChar(char c)
        {
            bool encontrado = false;
            int i = 0;
            string mostrar = "";

            while (encontrado == false && i < this.GetCaracteres().Length)
            {
                if (this.GetCaracteres()[i] == c)
                {
                    encontrado = true;
                }
                else
                {
                    i++;
                }
                if (this.GetEspacio() == true)
                {
                    mostrar += " " + GetNumero();
                    this.SetEspacio(false);
                }
                else
                    mostrar += GetNumero();
            }
            if (encontrado == true)
            {
                this.SetEspacio(true);
                return mostrar;
            }
            {

            }
            return null;
        }


    }

}

