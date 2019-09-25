using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioCaracteres
{
    class NUnitTest
    {
        Procesador p = new Procesador();

        [TestCase]
        public void Hi()
        {
            List<Boton> botones = p.Iniciar();
            p.RecorrerString("hi", botones);
        }
        [TestCase]
        public void Yes()
        {
            List<Boton> botones = p.Iniciar();
            p.RecorrerString("yes", botones);
        }
        [TestCase]
        public void FooBar()
        {
            List<Boton> botones = p.Iniciar();
            p.RecorrerString("foo bar", botones);
        }
        [TestCase]
        public void HelloWorld()
        {
            List<Boton> botones = p.Iniciar();
            p.RecorrerString("hello world", botones);
        }
    }
}
