using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LO.Uninter.SistemaBancario3
{
    internal class Program
    {
        static void Main(string[] args)
        {

            cliente cliente1 = new cliente(
                1,
                "Lizbeth Diaz",
                "CDMX",
                "OSKDLSÑP2",
                "7623748919",
                "lizy@gmail.com");

            cliente cliente2 = new cliente(
                2,
                "Jezreele Rivera",
                "Av. Morelos",
                "LOwPM8540245",
                "776892292",
                "jezbt@gmail.com");

            cliente cliente3 = new cliente(
                3,
                "Julia Castrejon",
                "Av. Uninter",
                "GARC4r593DEdsF",
                "78768929",
                "julss@gmail.com");



            cliente1.CambiarNombre("Lizbeth Diaz");
            cliente2.CambiarTelefono("7771234567");
            cliente3.CambiarCorreo("julia@gmail.com");


            cuenta cuenta1 = new cuenta(
                "100001",
                "Ahorro",
                5000.00m,
                new DateTime(2026, 8, 1));


            Console.WriteLine("Saldo inicial: $" + cuenta1.Saldo);


            cuenta1.Depositar(2000);
            Console.WriteLine("Depósito: $" + cuenta1.Saldo);


            cuenta1.Retirar(1500);
            Console.WriteLine("Retiro: $" + cuenta1.Saldo);


            cuenta1.Retirar(10000);

            cuenta1.Depositar(-500);


            cuenta1.BloquearCuenta();


            cuenta1.Depositar(1000);


            cuenta cuenta2 = new cuenta(
                "100002",
                "Ahorro",
                new DateTime(2026, 8, 5));


            cuenta cuenta3 = new cuenta(
                "Corriente");


            banco banco1 = new banco(
                1,
                "Banco Uninter",
                "BUNI010101ABC",
                "Cuernavaca, Morelos",
                "7770000000",
                "contacto@bancouninter.com",
                "www.bancouninter.com",
                true,
                new DateTime(2026, 1, 15));


            movimiento movimiento1 = new movimiento(
                1,
                "100001",
                "Depósito",
                1000.00m,
                5000.00m,
                6000.00m,
                DateTime.Now,
                "Depósito en efectivo",
                "",
                true);


            tarjeta tarjeta1 = new tarjeta(
                1,
                "1234567890123456",
                "Débito",
                "100001",
                "Fatima Castrejon",
                new DateTime(2026, 8, 1),
                new DateTime(2030, 8, 1),
                true,
                0.00m);


            MostrarCliente(cliente1);
            MostrarCliente(cliente2);
            MostrarCliente(cliente3);


            MostrarCuenta(cuenta1);
            MostrarCuenta(cuenta2);
            MostrarCuenta(cuenta3);


            Console.WriteLine();
            Console.WriteLine("Banco");

            Console.WriteLine("ID: " + banco1.IdBanco);
            Console.WriteLine("Nombre: " + banco1.Nombre);
            Console.WriteLine("RFC: " + banco1.RFC);
            Console.WriteLine("Dirección: " + banco1.Direccion);
            Console.WriteLine("Teléfono: " + banco1.Telefono);
            Console.WriteLine("Correo: " + banco1.Correo);
            Console.WriteLine("Sitio web: " + banco1.SitioWeb);
            Console.WriteLine("Estado: " + (banco1.Estado ? "Activo" : "Inactivo"));
            Console.WriteLine("Fecha de registro: " +
                banco1.FechaRegistro.ToShortDateString());


            Console.WriteLine();
            Console.WriteLine("Movimiento");

            Console.WriteLine("ID: " + movimiento1.IdMovimiento);
            Console.WriteLine("Número de cuenta: " + movimiento1.NumeroCuenta);
            Console.WriteLine("Tipo: " + movimiento1.TipoMovimiento);
            Console.WriteLine("Monto: $" + movimiento1.Monto);
            Console.WriteLine("Saldo anterior: $" + movimiento1.SaldoAnterior);
            Console.WriteLine("Saldo posterior: $" + movimiento1.SaldoPosterior);
            Console.WriteLine("Fecha: " + movimiento1.FechaMovimiento);
            Console.WriteLine("Concepto: " + movimiento1.Concepto);
            Console.WriteLine("Cuenta destino: " + movimiento1.NumeroCuentaDestino);
            Console.WriteLine("Estado: " +
                (movimiento1.Estado ? "Procesado" : "No procesado"));


            Console.WriteLine();
            Console.WriteLine("Tarjeta");

            Console.WriteLine("ID: " + tarjeta1.IdTarjeta);
            Console.WriteLine("Número: " + tarjeta1.NumeroTarjeta);
            Console.WriteLine("Tipo: " + tarjeta1.TipoTarjeta);
            Console.WriteLine("Número de cuenta: " + tarjeta1.NumeroCuenta);
            Console.WriteLine("Titular: " + tarjeta1.NombreTitular);
            Console.WriteLine("Fecha de emisión: " +
                tarjeta1.FechaEmision.ToShortDateString());
            Console.WriteLine("Fecha de vencimiento: " +
                tarjeta1.FechaVencimiento.ToShortDateString());
            Console.WriteLine("Estado: " +
                (tarjeta1.Estado ? "Activa" : "Inactiva"));
            Console.WriteLine("Límite de crédito: $" + tarjeta1.LimiteCredito);


            Console.WriteLine();
            Console.WriteLine("Presiona cualquier tecla para salir...");
            Console.ReadKey();
        }


        static void MostrarCliente(cliente cliente)
        {
            Console.WriteLine();
            Console.WriteLine("Cliente");

            Console.WriteLine("ID: " + cliente.IdCliente);
            Console.WriteLine("Nombre: " + cliente.Nombre);
            Console.WriteLine("Dirección: " + cliente.Direccion);
            Console.WriteLine("RFC: " + cliente.RFC);
            Console.WriteLine("Teléfono: " + cliente.Telefono);
            Console.WriteLine("Correo: " + cliente.Correo);
        }


        static void MostrarCuenta(cuenta cuenta)
        {
            Console.WriteLine();
            Console.WriteLine("Cuenta");

            Console.WriteLine("Número de cuenta: " + cuenta.NumeroCuenta);
            Console.WriteLine("Tipo de cuenta: " + cuenta.TipoCuenta);
            Console.WriteLine("Saldo: $" + cuenta.Saldo);
            Console.WriteLine("Fecha de apertura: " +
                cuenta.FechaApertura.ToShortDateString());
        }
    }
}