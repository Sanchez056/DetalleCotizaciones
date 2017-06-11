using DetalleKnockoutASM.DAL;
using DetalleKnockoutASM.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace DetalleKnockoutASM.BLL
{
    public class CotizacionesBLL
    {
        public static bool Guardar(Cotizaciones cotizacion)
        {
            bool resultado = false;
            using (var db = new CotizacionesDb())
            {
                try
                {
                    db.Cotizaciones.Add(cotizacion);
                    db.SaveChanges();
                    resultado = true;
                }
                catch (Exception)
                {

                    throw;
                }
            }
            return resultado;
        }
       
        public static bool Modificar(Cotizaciones cotizacion)
        {
            bool resultado = false;
            using (var db = new CotizacionesDb())
            {
                try
                {
                    db.Entry(cotizacion).State = EntityState.Modified;
                    db.SaveChanges();
                    resultado = true;
                }
                catch (Exception)
                {

                    throw;
                }
            }
            return resultado;
        }
        public static bool Eliminar(Cotizaciones cotizacion)
        {
            bool resultado = false;
            using (var db = new CotizacionesDb())
            {
                try
                {
                    db.Entry(cotizacion).State = EntityState.Deleted;
                    db.SaveChanges();
                    resultado = true;
                }
                catch (Exception)
                {

                    throw;
                }
            }
            return resultado;
        }
        public static List<Cotizaciones> Listar()
        {
            List<Cotizaciones> listado = null;
            using (var db = new CotizacionesDb())
            {
                try
                {
                    listado = db.Cotizaciones.ToList();
                }
                catch (Exception)
                {

                    throw;
                }
            }
            return listado;
        }
    }
}
