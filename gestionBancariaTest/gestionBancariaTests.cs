using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace gestionBancariaTest
{
    [TestClass]
    public class gestionBancariaTests
    {
        [TestMethod]
        // unit test code [TestMethod]
        public void validarMetodoIngreso()
        {
            // preparación del caso de prueba
            double saldoInicial = 1000;
            double ingreso = 500;
            double saldoActual = 0;
            double saldoEsperado = 1500;
            gestionBancaria cuenta = new gestionBancaria(saldoInicial);
            // Método a probar
            cuenta.realizarIngreso(ingreso);
            // afirmación de la prueba (valor esperado Vs. Valor obtenido)
            saldoActual = cuenta.obtenerSaldo();
            Assert.AreEqual(saldoEsperado, saldoActual, 0.001, "El saldo de la cuenta no es correcto");


        }
        [TestMethod]
        // unit test code [TestMethod]
        public void validarMetodoIngresoReintegro()
        {
            // preparación del caso de prueba
            double saldoInicial = 1000;
            double ingreso = 500;
            double saldoEsperado = 500;
      
            gestionBancaria cuenta = new gestionBancaria(saldoInicial);
            // Método a probar
            cuenta.realizarReintegro(ingreso);

            Assert.AreEqual(saldoEsperado, cuenta.obtenerSaldo(), 0.001, "El saldo de la cuenta no es correcto");


        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]

        // unit test code [TestMethod]
        public void validarMetodoIngresoMenorACero()
        {
            // preparación del caso de prueba
            double saldoInicial = 1000;
            double ingreso = -1;
            gestionBancaria cuenta = new gestionBancaria(saldoInicial);
            // Método a probar
            cuenta.realizarIngreso(ingreso);
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]

        // unit test code [TestMethod]
        public void validarMetodoReintegroMenorACero()
        {
            // preparación del caso de prueba
            double saldoInicial = 1000;
            double ingreso = -200;
            gestionBancaria cuenta = new gestionBancaria(saldoInicial);
            // Método a probar
            cuenta.realizarReintegro(ingreso);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        // unit test code [TestMethod]
        public void validarMetodoReingresoMaSalExcep()
        {
            // preparación del caso de prueba
            double saldoInicial = 1000;
            double ingreso = 1001;
            gestionBancaria cuenta = new gestionBancaria(saldoInicial);
            // Método a probar
            cuenta.realizarReintegro(ingreso);
            // afirmación de la prueba (valor esperado Vs. Valor obtenido)



        }

    }
}

