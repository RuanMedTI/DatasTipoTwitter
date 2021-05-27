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
            DateTime dateTime = DateTime.MinValue;
            DateTime dataAgora = DateTime.Now;
            DateTime.TryParse("21/10/2016", out dateTime);
            DateTime Fim = DateTime.Now;
            string Segundos = Fim.Subtract(dataAgora).TotalSeconds.ToString();
            DateTime Inicio2 = DateTime.Now;

            try
            {
                dateTime = DateTime.Parse("21/10/2016");
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
            DateTime dateTime = DateTime.MinValue;
            DateTime dataAgora = DateTime.Now;
            DateTime.TryParse("10/10/2011", out dateTime);
            DateTime Fim = DateTime.Now;
            string Segundos = Fim.Subtract(dataAgora).TotalSeconds.ToString();
            DateTime Inicio2 = DateTime.Now;

            try
            {
                dateTime = DateTime.Parse("10/10/2011");
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
            DateTime dateTime = DateTime.MinValue;
            DateTime dataAgora = DateTime.Now;
            DateTime.TryParse("11/03/2018", out dateTime);
            DateTime Fim = DateTime.Now;
            string Segundos = Fim.Subtract(dataAgora).TotalSeconds.ToString();
            DateTime Inicio2 = DateTime.Now;

            try
            {
                dateTime = DateTime.Parse("03/03/2018");
            }
            catch
            {

            }
            DateTime Fim2 = DateTime.Now;
            string Segundos2 = Fim2.Subtract(Inicio2).TotalSeconds.ToString();
        }

        [TestMethod]
        public void Teste4()
        {
            DateTime dateTime = DateTime.MinValue;
            DateTime dataAgora = DateTime.Now;
            DateTime.TryParse("20/05/2020", out dateTime);
            DateTime Fim = DateTime.Now;
            string Segundos = Fim.Subtract(dataAgora).TotalSeconds.ToString();
            DateTime Inicio2 = DateTime.Now;

            try
            {
                dateTime = DateTime.Parse("20/05/2020");
            }
            catch
            {

            }
            DateTime Fim2 = DateTime.Now;
            string Segundos2 = Fim2.Subtract(Inicio2).TotalSeconds.ToString();
        }

        [TestMethod]
        public void Teste5()
        {
            DateTime dateTime = DateTime.MinValue;
            DateTime dataAgora = DateTime.Now;
            DateTime.TryParse("18/04/2019", out dateTime);
            DateTime Fim = DateTime.Now;
            string Segundos = Fim.Subtract(dataAgora).TotalSeconds.ToString();
            DateTime Inicio2 = DateTime.Now;

            try
            {
                dateTime = DateTime.Parse("18/04/2019");
            }
            catch
            {

            }
            DateTime Fim2 = DateTime.Now;
            string Segundos2 = Fim2.Subtract(Inicio2).TotalSeconds.ToString();
        }

        [TestMethod]
        public void Teste6()
        {
            DateTime dateTime = DateTime.MinValue;
            DateTime dataAgora = DateTime.Now;
            DateTime.TryParse("13/07/2013", out dateTime);
            DateTime Fim = DateTime.Now;
            string Segundos = Fim.Subtract(dataAgora).TotalSeconds.ToString();
            DateTime Inicio2 = DateTime.Now;

            try
            {
                dateTime = DateTime.Parse("13/07/2013");
            }
            catch
            {

            }
            DateTime Fim2 = DateTime.Now;
            string Segundos2 = Fim2.Subtract(Inicio2).TotalSeconds.ToString();
        }

        [TestMethod]
        public void Teste7()
        {
            DateTime dateTime = DateTime.MinValue;
            DateTime dataAgora = DateTime.Now;
            DateTime.TryParse("22/10/2010", out dateTime);
            DateTime Fim = DateTime.Now;
            string Segundos = Fim.Subtract(dataAgora).TotalSeconds.ToString();
            DateTime Inicio2 = DateTime.Now;

            try
            {
                dateTime = DateTime.Parse("22/10/2010");
            }
            catch
            {

            }
            DateTime Fim2 = DateTime.Now;
            string Segundos2 = Fim2.Subtract(Inicio2).TotalSeconds.ToString();
        }

        [TestMethod]
        public void Teste8()
        {
            DateTime dateTime = DateTime.MinValue;
            DateTime dataAgora = DateTime.Now;
            DateTime.TryParse("26/11/2012", out dateTime);
            DateTime Fim = DateTime.Now;
            string Segundos = Fim.Subtract(dataAgora).TotalSeconds.ToString();
            DateTime Inicio2 = DateTime.Now;

            try
            {
                dateTime = DateTime.Parse("26/11/2012");
            }
            catch
            {

            }
            DateTime Fim2 = DateTime.Now;
            string Segundos2 = Fim2.Subtract(Inicio2).TotalSeconds.ToString();
        }

        [TestMethod]
        public void Teste9()
        {
            DateTime dateTime = DateTime.MinValue;
            DateTime dataAgora = DateTime.Now;
            DateTime.TryParse("20/1/2017", out dateTime);
            DateTime Fim = DateTime.Now;
            string Segundos = Fim.Subtract(dataAgora).TotalSeconds.ToString();
            DateTime Inicio2 = DateTime.Now;

            try
            {
                dateTime = DateTime.Parse("20/1/2017");
            }
            catch
            {

            }
            DateTime Fim2 = DateTime.Now;
            string Segundos2 = Fim2.Subtract(Inicio2).TotalSeconds.ToString();
        }

        [TestMethod]
        public void Teste10()
        {
            DateTime dateTime = DateTime.MinValue;
            DateTime dataAgora = DateTime.Now;
            DateTime.TryParse("1/1/2018", out dateTime);
            DateTime Fim = DateTime.Now;
            string Segundos = Fim.Subtract(dataAgora).TotalSeconds.ToString();
            DateTime Inicio2 = DateTime.Now;

            try
            {
                dateTime = DateTime.Parse("1/1/2018");
            }
            catch
            {

            }
            DateTime Fim2 = DateTime.Now;
            string Segundos2 = Fim2.Subtract(Inicio2).TotalSeconds.ToString();
        }
    }
}
