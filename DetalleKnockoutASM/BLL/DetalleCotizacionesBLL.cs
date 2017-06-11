using DetalleKnockoutASM.DAL;
using DetalleKnockoutASM.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace DetalleKnockoutASM.BLL
{
    public class DetalleCotizacionesBLL
    {
        public static bool Insertar(DetalleCotizaciones detalle)
        {
            bool resultado = false;
            using (var db= new CotizacionesDb())
            {
                try
                {
                    db.DetalleCotizaciones.Add(detalle);
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
        public static DetalleCotizaciones Buscar(int? detalleCotizacionId)
        {
            DetalleCotizaciones detalle = null;
            using (var db = new CotizacionesDb())
            {
                try
                {
                    detalle = db.DetalleCotizaciones.Find(detalleCotizacionId);
                }
                catch (Exception)
                {

                    throw;
                }
            }
            return detalle;
        }
        public static bool Modificar(DetalleCotizaciones detalle)
        {
            bool resultado = false;
            using (var db = new CotizacionesDb())
            {
                try
                {
                    db.Entry(detalle).State = EntityState.Modified;
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
        public static bool Eliminar(DetalleCotizaciones detalle)
        {
            bool resultado = false;
            using (var db = new CotizacionesDb())
            {
                try
                {
                    db.Entry(detalle).State = EntityState.Deleted;
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
        public static List<DetalleCotizaciones> Listar()
        {
            List<DetalleCotizaciones> listado = null;
            using (var db = new CotizacionesDb())
            {
                try
                {
                    listado = db.DetalleCotizaciones.ToList();
                }
                catch (Exception)
                {

                    throw;
                }
            }
            return listado;
        }
        public static bool Save(List<DetalleCotizaciones> detalles)
        {
            bool resultado = false;
            foreach (DetalleCotizaciones detail in detalles)
            {
                resultado = Insertar(detail);
            }
            return resultado;
        }
    }
}
