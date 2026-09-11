using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LO.Uninter.SistemaBancario3
{
    public class cuenta
    {
        public string NumeroCuenta { get; protected set; }

        public string TipoCuenta { get; set; }

        public string Titular { get; protected set; }

        public decimal Saldo { get; protected set; }

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
            Titular = "No dado";
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
            Titular = "No dado";
            Saldo = 0.00m;
            FechaApertura = fechaApertura;
            Activa = true;
        }

        public cuenta(string tipoCuenta)
        {
            NumeroCuenta = "No dado";
            TipoCuenta = tipoCuenta;
            Titular = "No dado";
            Saldo = 0.00m;
            FechaApertura = DateTime.Now;
            Activa = true;
        }

        public virtual void Depositar(decimal cantidad)
        {
            if (cantidad > 0 && Activa)
            {
                Saldo += cantidad;
            }
        }

        public virtual bool Retirar(decimal cantidad)
        {
            if (cantidad > 0 &&
                cantidad <= Saldo &&
                Activa)
            {
                Saldo -= cantidad;
                return true;
            }

            return false;
        }

        public virtual void MostrarInformacion()
        {
            Console.WriteLine("Cuenta: " + NumeroCuenta);
            Console.WriteLine("Titular: " + Titular);
            Console.WriteLine("Saldo: " + Saldo);
            Console.WriteLine("Tipo: " + TipoCuenta);
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

    public class CuentaAhorro : cuenta
    {
        public decimal TasaInteres { get; set; }

        public CuentaAhorro(
            string numeroCuenta,
            string titular,
            decimal saldoInicial,
            decimal tasaInteres)
            : base(
                numeroCuenta,
                "Ahorro",
                saldoInicial,
                DateTime.Now)
        {
            Titular = titular;
            TasaInteres = tasaInteres;
        }

        public void AplicarInteres()
        {
            Saldo += Saldo * TasaInteres / 100;
        }

        public override void MostrarInformacion()
        {
            base.MostrarInformacion();
            Console.WriteLine("Tipo: Cuenta de ahorro");
            Console.WriteLine("Tasa de interes: " + TasaInteres + "%");
        }
    }

    public class CuentaCheques : cuenta
    {
        public decimal ComisionRetiro { get; set; }

        public CuentaCheques(
            string numeroCuenta,
            string titular,
            decimal saldoInicial,
            decimal comisionRetiro)
            : base(
                numeroCuenta,
                "Cheques",
                saldoInicial,
                DateTime.Now)
        {
            Titular = titular;
            ComisionRetiro = comisionRetiro;
        }

        public override bool Retirar(decimal cantidad)
        {
            decimal total = cantidad + ComisionRetiro;

            if (cantidad > 0 &&
                total <= Saldo &&
                Activa)
            {
                Saldo -= total;
                return true;
            }

            return false;
        }

        public override void MostrarInformacion()
        {
            base.MostrarInformacion();
            Console.WriteLine("Tipo: Cuenta de cheques");
            Console.WriteLine(
                "Comision por retiro: " + ComisionRetiro);
        }
    }

    public class CuentaNomina : cuenta
    {
        public decimal LimiteRetiro { get; set; }

        public CuentaNomina(
            string numeroCuenta,
            string titular,
            decimal saldoInicial,
            decimal limiteRetiro)
            : base(
                numeroCuenta,
                "Nomina",
                saldoInicial,
                DateTime.Now)
        {
            Titular = titular;
            LimiteRetiro = limiteRetiro;
        }

        public override bool Retirar(decimal cantidad)
        {
            if (cantidad > 0 &&
                cantidad <= LimiteRetiro &&
                cantidad <= Saldo &&
                Activa)
            {
                Saldo -= cantidad;
                return true;
            }

            return false;
        }

        public override void MostrarInformacion()
        {
            base.MostrarInformacion();
            Console.WriteLine("Tipo: Cuenta de nomina");
            Console.WriteLine(
                "Limite de retiro: " + LimiteRetiro);
        }
    }

    public class CuentaCredito : cuenta
    {
        public decimal LimiteCredito { get; set; }

        public CuentaCredito(
            string numeroCuenta,
            string titular,
            decimal saldoInicial,
            decimal limiteCredito)
            : base(
                numeroCuenta,
                "Credito",
                saldoInicial,
                DateTime.Now)
        {
            Titular = titular;
            LimiteCredito = limiteCredito;
        }

        public override bool Retirar(decimal cantidad)
        {
            if (cantidad > 0 &&
                cantidad <= Saldo + LimiteCredito &&
                Activa)
            {
                Saldo -= cantidad;
                return true;
            }

            return false;
        }

        public override void MostrarInformacion()
        {
            base.MostrarInformacion();
            Console.WriteLine("Tipo: Cuenta de credito");
            Console.WriteLine(
                "Limite de credito: " + LimiteCredito);
        }
    }
}

