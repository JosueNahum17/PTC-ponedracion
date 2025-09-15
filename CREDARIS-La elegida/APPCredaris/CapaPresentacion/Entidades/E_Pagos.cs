using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaPresentacion.Entidades
{
    public class E_Pagos
    {
        public string NombreCliente { get; set; }
        public string ApellidoCliente { get; set; }
        public string MetodoPago { get; set; }
        public decimal montoPago { get; set; }
        public DateTime fechaPago { get; set; }
        public int idPrestamo { get; set; }

        public int IdPago = 0;

    }
}
