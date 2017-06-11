using DetalleKnockoutASM.Models;
using Microsoft.Ajax.Utilities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace DetalleKnockoutASM.DAL
{
    public class CotizacionesDb : DbContext
    {
        public CotizacionesDb() : base("ConStr")
        {

        }

        public DbSet<Cotizaciones> Cotizaciones { get; set; }
        public DbSet<DetalleCotizaciones>DetalleCotizaciones { get; set; }
    }
}