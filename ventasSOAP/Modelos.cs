using System;
using System.Collections.Generic;
using System.Runtime.Serialization; // Necesario para SOAP

namespace ventasSOAP
{
    // PASO 2: Modelo Factura
    [DataContract]
    public class Factura
    {
        [DataMember]
        public int NumeroFactura { get; set; }

        [DataMember]
        public string NombreCliente { get; set; }

        [DataMember]
        public DateTime Fecha { get; set; }

        [DataMember]
        public double Total { get; set; }

        // Relación: Una factura tiene una lista de detalles
        [DataMember]
        public List<Detalle> Detalles { get; set; } = new List<Detalle>();
    }

    // PASO 3: Modelo Detalle
    [DataContract]
    public class Detalle
    {
        [DataMember]
        public string Producto { get; set; }

        [DataMember]
        public int Cantidad { get; set; }

        [DataMember]
        public double PrecioUnitario { get; set; }
    }
}