﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Entidades;

namespace UnitTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void lstPaquetesInstanciada()
        {
            Correo correo = new Correo();
            Assert.IsNotNull(correo.Paquetes);
        }

        [TestMethod]
        public void TrackingIdRepetido()
        {
            Correo correo = new Correo();
            Paquete paquete1 = new Paquete("Calle 123", "123-123-123");
            Paquete paquete2 = new Paquete("Calle 123", "123-123-123");

            correo += paquete1;
            try
            {
                correo += paquete2;
            }
            catch (Exception e)
            {
                Assert.IsInstanceOfType(e, typeof(TrakingIdRepetidoException));
                return;
            }
            Assert.Fail("Sin excepción trackingID repetido: {0}.", paquete2.TrackingID);
        }
    }
}
