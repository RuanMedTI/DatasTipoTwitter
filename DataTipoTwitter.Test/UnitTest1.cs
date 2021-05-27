using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace DataTipoTwitter.Test
{
    [TestClass]
    public class UnitTest1
    {

        [TestMethod]
        public void Teste1()
        {
            DateTime resultado = DateTime.MinValue;
            DateTime Inicio = DateTime.Now;
            DateTime.TryParse("21/10/2016", out resultado);
            DateTime Fim = DateTime.Now;
            string Segundos = Fim.Subtract(Inicio).TotalSeconds.ToString();
            DateTime Inicio2 = DateTime.Now;

            try
            {
                resultado = DateTime.Parse("21/10/2016");
            }
            catch
            {

            }
            DateTime Fim2 = DateTime.Now;
            string Segundos2 = Fim2.Subtract(Inicio2).TotalSeconds.ToString();
        }

        [TestMethod]
        public void Teste2()
        {
            DateTime resultado = DateTime.MinValue;
            DateTime Inicio = DateTime.Now;
            DateTime.TryParse("10/10/2011", out resultado);
            DateTime Fim = DateTime.Now;
            string Segundos = Fim.Subtract(Inicio).TotalSeconds.ToString();
            DateTime Inicio2 = DateTime.Now;

            try
            {
                resultado = DateTime.Parse("10/10/2011");
            }
            catch
            {

            }
            DateTime Fim2 = DateTime.Now;
            string Segundos2 = Fim2.Subtract(Inicio2).TotalSeconds.ToString();
        }

        [TestMethod]
        public void Teste3()
        {
            DateTime resultado = DateTime.MinValue;
            DateTime Inicio = DateTime.Now;
            DateTime.TryParse("11/03/2018", out resultado);
            DateTime Fim = DateTime.Now;
            string Segundos = Fim.Subtract(Inicio).TotalSeconds.ToString();
            DateTime Inicio2 = DateTime.Now;

            try
            {
                resultado = DateTime.Parse("03/03/2018");
            }
            catch
            {

            }
            DateTime Fim2 = DateTime.Now;
            string Segundos2 = Fim2.Subtract(Inicio2).TotalSeconds.ToString();
        }
    }
}
