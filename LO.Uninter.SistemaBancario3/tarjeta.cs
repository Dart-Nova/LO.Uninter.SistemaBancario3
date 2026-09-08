using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LO.Uninter.SistemaBancario3
{
    public class tarjeta
    {
        public int IdTarjeta { get; set; }
        public string NumeroTarjeta { get; set; }
        public string TipoTarjeta { get; set; }
        public string NumeroCuenta { get; set; }
        public string NombreTitular { get; set; }
        public DateTime FechaEmision { get; set; }
        public DateTime FechaVencimiento { get; set; }
        public bool Estado { get; set; }
        public decimal LimiteCredito { get; set; }

        public tarjeta(
            int idTarjeta,
            string numeroTarjeta,
            string tipoTarjeta,
            string numeroCuenta,
            string nombreTitular,
            DateTime fechaEmision,
            DateTime fechaVencimiento,
            bool estado,
            decimal limiteCredito)
        {
            IdTarjeta = idTarjeta;
            NumeroTarjeta = numeroTarjeta;
            TipoTarjeta = tipoTarjeta;
            NumeroCuenta = numeroCuenta;
            NombreTitular = nombreTitular;
            FechaEmision = fechaEmision;
            FechaVencimiento = fechaVencimiento;
            Estado = estado;
            LimiteCredito = limiteCredito;
        }
    }
}