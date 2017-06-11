using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DetalleKnockoutASM.Models
{
    public class DetalleCotizaciones
    {
        [Key]
        public int CotizacionDetalleId { get; set; }

        public int CotizacionId { get; set; }

        public int ArticuloId { get; set; }

        public string Articulo { get; set; }

        public int Cantidad { get; set; }

        public double SubTotal { get; set; }
    }
}
