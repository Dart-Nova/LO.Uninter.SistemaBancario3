using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LO.Uninter.SistemaBancario3
{
    public class banco
    {
        public int IdBanco { get; set; }
        public string Nombre { get; set; }
        public string RFC { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public string Correo { get; set; }
        public string SitioWeb { get; set; }
        public bool Estado { get; set; }
        public DateTime FechaRegistro { get; set; }

        public banco(
            int idBanco,
            string nombre,
            string rfc,
            string direccion,
            string telefono,
            string correo,
            string sitioWeb,
            bool estado,
            DateTime fechaRegistro)
        {
            IdBanco = idBanco;
            Nombre = nombre;
            RFC = rfc;
            Direccion = direccion;
            Telefono = telefono;
            Correo = correo;
            SitioWeb = sitioWeb;
            Estado = estado;
            FechaRegistro = fechaRegistro;
        }
    }
}