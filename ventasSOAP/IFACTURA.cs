using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace ventasSOAP
{
    // PASO 4: Definimos la interfaz
    [ServiceContract]
    public interface IFACTURA
    {
        // PASO 5: Contrato para guardar (Recibe Factura y lista de Detalles)
        [OperationContract]
        string GuardarFacturacion(Factura nuevaFactura, List<Detalle> nuevosDetalles);

        // PASO 7: Contrato para visualizar (Devuelve una lista de facturas)
        [OperationContract]
        List<Factura> ObtenerTodasLasFacturas();
    }
}