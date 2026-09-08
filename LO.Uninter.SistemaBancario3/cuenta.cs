using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LO.Uninter.SistemaBancario3
{
    public class cuenta
    {
        public string NumeroCuenta { get; private set; }
        public string TipoCuenta { get; set; }
        public decimal Saldo { get; private set; }
        public DateTime FechaApertura { get; set; }
        public bool Activa { get; private set; }

        public cuenta(
            string numeroCuenta,
            string tipoCuenta,
            decimal saldo,
            DateTime fechaApertura)
        {
            NumeroCuenta = numeroCuenta;
            TipoCuenta = tipoCuenta;
            Saldo = saldo;
            FechaApertura = fechaApertura;
            Activa = true;
        }

        public cuenta(
            string numeroCuenta,
            string tipoCuenta,
            DateTime fechaApertura)
        {
            NumeroCuenta = numeroCuenta;
            TipoCuenta = tipoCuenta;
            Saldo = 0.00m;
            FechaApertura = fechaApertura;
            Activa = true;
        }

        public cuenta(string tipoCuenta)
        {
            NumeroCuenta = "No dado";
            TipoCuenta = tipoCuenta;
            Saldo = 0.00m;
            FechaApertura = DateTime.Now;
            Activa = true;
        }

        public bool Depositar(decimal cantidad)
        {
            if (cantidad <= 0)
            {
                return false;
            }

            if (Activa == false)
            {
                return false;
            }

            Saldo += cantidad;
            return true;
        }

        public bool Retirar(decimal cantidad)
        {
            if (cantidad <= 0)
            {
                return false;
            }

            if (Activa == false)
            {
                return false;
            }

            if (cantidad > Saldo)
            {
                return false;
            }

            Saldo -= cantidad;
            return true;
        }

        public void BloquearCuenta()
        {
            Activa = false;
        }

        public void ActivarCuenta()
        {
            Activa = true;
        }
    }
}