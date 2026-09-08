using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LO.Uninter.SistemaBancario3
{
    using System;


    public class movimiento
    {
        public int IdMovimiento { get; set; }
        public string NumeroCuenta { get; set; }
        public string TipoMovimiento { get; set; }
        public decimal Monto { get; set; }
        public decimal SaldoAnterior { get; set; }
        public decimal SaldoPosterior { get; set; }
        public DateTime FechaMovimiento { get; set; }
        public string Concepto { get; set; }
        public string NumeroCuentaDestino { get; set; }
        public bool Estado { get; set; }

        public movimiento(
            int idMovimiento,
            string numeroCuenta,
            string tipoMovimiento,
            decimal monto,
            decimal saldoAnterior,
            decimal saldoPosterior,
            DateTime fechaMovimiento,
            string concepto,
            string numeroCuentaDestino,
            bool estado)
        {
            IdMovimiento = idMovimiento;
            NumeroCuenta = numeroCuenta;
            TipoMovimiento = tipoMovimiento;
            Monto = monto;
            SaldoAnterior = saldoAnterior;
            SaldoPosterior = saldoPosterior;
            FechaMovimiento = fechaMovimiento;
            Concepto = concepto;
            NumeroCuentaDestino = numeroCuentaDestino;
            Estado = estado;
        }
    }
}

