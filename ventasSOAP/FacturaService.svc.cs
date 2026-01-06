using System;
using System.Collections.Generic;

namespace ventasSOAP
{
    // Implementamos la interfaz IFACTURA
    public class FacturaService : IFACTURA
    {
        // PASO 6: Lista estática para simular una base de datos en memoria
        // "static" asegura que los datos no se borren entre llamadas mientras el servidor corra
        private static List<Factura> baseDeDatosFacturas = new List<Factura>();

        public string GuardarFacturacion(Factura nuevaFactura, List<Detalle> nuevosDetalles)
        {
            try
            {
                // Asignamos los detalles a la factura
                nuevaFactura.Detalles = nuevosDetalles;

                // Calculamos el total automáticamente (opcional, pero buena práctica)
                double totalCalculado = 0;
                foreach (var item in nuevosDetalles)
                {
                    totalCalculado += (item.Cantidad * item.PrecioUnitario);
                }
                nuevaFactura.Total = totalCalculado;

                // Agregamos a la lista global
                baseDeDatosFacturas.Add(nuevaFactura);

                return $"Factura {nuevaFactura.NumeroFactura} guardada correctamente con {nuevosDetalles.Count} detalles.";
            }
            catch (Exception ex)
            {
                return "Error al guardar: " + ex.Message;
            }
        }

        // PASO 7: Visualizar (retornar) las facturas
        public List<Factura> ObtenerTodasLasFacturas()
        {
            return baseDeDatosFacturas;
        }
    }
}