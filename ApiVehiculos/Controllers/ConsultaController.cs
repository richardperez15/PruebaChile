using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Web.Http;
using ApiVehiculos.Models;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace ApiVehiculos.Controllers
{

    [RoutePrefix("Api")]
    public class ConsultaController : ApiController
    {


        [Route("IngresoVehiculo")]

        public RespuestaIV PostIngresoVh(RequestIngresoVehiculo param)
        {
         
            var respuesta = new RespuestaIV();
            var ms = "Vehiculo Ingresado Correctamente";

            try
            {

                RevisionVehiculosEntities obj = new RevisionVehiculosEntities();
                Vehiculo vh = new Vehiculo();
                vh.Marca = param.MarcaVh;
                vh.Modelo = param.ModeloVh;
                vh.Patente = param.PatenteVh;
                vh.Año = param.AnioVh;
                vh.IdPersona = param.IdDueño;

                obj.Vehiculo.Add(vh);
                obj.SaveChanges();
                obj.Dispose();
            }
            catch (Exception e)
            {

                 ms = e.Message;
            }

            respuesta.RespuestaIngresoVehiculo = ms;


            return respuesta;
        }


        [Route("IngresoRevision")]

        public RespuestaIRev PostIngresoRev(RequestIngresoRevision param)
        {

            var respuesta = new RespuestaIRev();
            var ms = "Revisión Registrada Correctamente";

            try
            {

                RevisionVehiculosEntities obj = new RevisionVehiculosEntities();
                Revision rev = new Revision();
                rev.IdVehiculo = param.IdVehiculo;
                rev.Observaciones = param.Observaciones;
                rev.FechaRevision = DateTime.Now;
                rev.IdPersona = param.IdPersonal;
                rev.Aprobado = param.Aprovado;

                obj.Revision.Add(rev);
                obj.SaveChanges();
                obj.Dispose();
            }
            catch (Exception e)
            {

                ms = e.Message;
            }

            respuesta.RespuestaIngresoRevision = ms;


            return respuesta;
        }

        [Route("IngresoInspeccion")]

        public RespuestaIngInspeccion PostIngresoInspeccion(RequestIngresoInspeccion param)
        {

            var respuesta = new RespuestaIngInspeccion();
            var ms = "Inspección Registrada Correctamente";

            try
            {

                RevisionVehiculosEntities obj = new RevisionVehiculosEntities();
                Inspeccion ins = new Inspeccion();
                ins.IdRevision = param.IdRevision;
                ins.IdTipoRevision = param.TipoInspeccion;
                ins.Observaciones = param.Observaciones;
                ins.Estado = param.Estado;
                ins.IdPersona = param.IdPersonal;


                obj.Inspeccion.Add(ins);
                obj.SaveChanges();
                obj.Dispose();
            }
            catch (Exception e)
            {

                ms = e.Message;
            }

            respuesta.RespuestaIngresoInspeccion = ms;


            return respuesta;
        }

        [Route("Hisroial")]

        public RespuestaHistorial GetHistorial(RequestHistorial param)
        {

            var respuesta = new RespuestaHistorial();
            
            
            var ms = "";

            try
            {

                RevisionVehiculosEntities obj = new RevisionVehiculosEntities();

                Vehiculo vh = obj.Vehiculo.Where(x => x.Patente == param.PatenteVehiculo).FirstOrDefault();

                if (vh != null)
                {
                    Persona pr = obj.Persona.Where(x => x.IdPersona == vh.IdPersona).FirstOrDefault();
                    Revision rev = obj.Revision.Where(x => x.IdVehiculo == vh.IdVehiculo).FirstOrDefault();

                    respuesta.MarcaVehiculo = vh.Marca;
                    respuesta.ModeloVehiculo = vh.Modelo;
                    respuesta.PatenteVehiculo = vh.Patente;
                    respuesta.AnioVehiculo = Convert.ToInt32(vh.Año);
                    respuesta.NombreDuenio = pr.Nombre;
                    respuesta.ApellidoDuenio = pr.Apellido;
                    respuesta.Aprobada = Convert.ToBoolean(rev.Aprobado);
                    respuesta.Observacion = rev.Observaciones;
                    respuesta.fechaRev = Convert.ToDateTime(rev.FechaRevision);


                }


            }
            catch (Exception e)
            {

                ms = e.Message;
            }

           


            return respuesta;
        }

        [Route("BorrarInspeccion")]

        public RespuestaBorrarInsp DeleteInspeccion(RequestBorrarInsp param)
        {

            var respuesta = new RespuestaBorrarInsp();


            var ms = "Inspeccion Borrada Correctamente";

            try
            {

                RevisionVehiculosEntities obj = new RevisionVehiculosEntities();

                Inspeccion ins = obj.Inspeccion.Where(x => x.IdInspeccion == param.idInspeccion).FirstOrDefault();

                obj.Inspeccion.Remove(ins);
                obj.SaveChanges();
                obj.Dispose();

            }
            catch (Exception e)
            {

                ms = e.Message;
            }

            respuesta.RespuestaBorrarInspeccion = ms;


            return respuesta;
        }

    }
}