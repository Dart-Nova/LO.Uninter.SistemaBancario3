using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LO.Uninter.SistemaBancario3
{
    public class cliente
    {
        public int IdCliente { get; set; }
        public string Nombre { get; private set; }
        public string Direccion { get; set; }
        public string RFC { get; set; }
        public string Telefono { get; private set; }
        public string Correo { get; private set; }

        public cliente(
            int idCliente,
            string nombre,
            string direccion,
            string rfc,
            string telefono,
            string correo)
        {
            IdCliente = idCliente;
            Nombre = nombre;
            Direccion = direccion;
            RFC = rfc;
            Telefono = telefono;
            Correo = correo;
        }

        public void CambiarNombre(string nuevoNombre)
        {
            if (!string.IsNullOrWhiteSpace(nuevoNombre))
            {
                Nombre = nuevoNombre;
            }
        }

        public void CambiarTelefono(string nuevoTelefono)
        {
            if (!string.IsNullOrWhiteSpace(nuevoTelefono))
            {
                Telefono = nuevoTelefono;
            }
        }

        public void CambiarCorreo(string nuevoCorreo)
        {
            if (!string.IsNullOrWhiteSpace(nuevoCorreo))
            {
                Correo = nuevoCorreo;
            }
        }
    }
}