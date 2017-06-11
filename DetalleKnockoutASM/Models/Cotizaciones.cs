using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace DetalleKnockoutASM.Models
{
    public class Cotizaciones
    {
        [Key]
        public int CotizacionId { get; set; }

        
        public string  ClienteId { get; set; }

        [DataType(DataType.DateTime)]
        public DateTime Fecha { get; set; }
        
        [DataType(DataType.Currency)]
        public double Monto { get; set; }

        
    }
}