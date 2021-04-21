using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Clase1904;

namespace Clase1904Test
{
    [TestClass]
    public class CuentaTest
    {
        [TestMethod]
        public void SiSeRealizaLaTransferenciaSeActualizaLaFecha()
        {
            Cuenta origen = new Cuenta(new Mocks.MockDateTimeProvider()) { Saldo = 2000, UltimaTransaccionRealizada = DateTime.Now };
            Cuenta destino = new Cuenta(new Mocks.MockDateTimeProvider()) { Saldo = 0 };

            origen.Transferir(1000, destino);


            Assert.AreEqual(1000, origen.Saldo);
            Assert.AreEqual(1000, destino.Saldo);
            Assert.AreEqual(new DateTime(2021, 04, 19), origen.UltimaTransaccionRealizada);
        }
    }
}
