using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace ApiVehiculos.Models
{
    [DataContract]
    public class RespuestaIV
    {

        public string ResultadoIV { get; set; }


        [DataMember]
        public string RespuestaIngresoVehiculo
        {
            get { return ResultadoIV; }
            set { ResultadoIV = value; }

        }
    
    }

    [DataContract]
    public class RespuestaIRev
    {

        public string ResultadoIR { get; set; }


        [DataMember]
        public string RespuestaIngresoRevision
        {
            get { return ResultadoIR; }
            set { ResultadoIR = value; }

        }

    }

    [DataContract]
    public class RespuestaIngInspeccion
    {

        public string ResultadoIInspeccion { get; set; }


        [DataMember]
        public string RespuestaIngresoInspeccion
        {
            get { return ResultadoIInspeccion; }
            set { ResultadoIInspeccion = value; }

        }

    }

    [DataContract]
    public class RespuestaBorrarInsp
    {

        public string ResultadoIInspeccion { get; set; }


        [DataMember]
        public string RespuestaBorrarInspeccion
        {
            get { return ResultadoIInspeccion; }
            set { ResultadoIInspeccion = value; }

        }

    }

    public class RespuestaHistorial
    {

        public string MarcaVehiculo { get; set; }
        public string ModeloVehiculo { get; set; }
        public string PatenteVehiculo { get; set; }
        public int AnioVehiculo { get; set; }
        public string NombreDuenio { get; set; }
        public string ApellidoDuenio { get; set; }
        public bool Aprobada { get; set; }
        public string Observaciones { get; set; }
        public DateTime fechaRev { get; set; }

        [DataMember]
        public string MarcaVh
        {
            get { return MarcaVehiculo; }
            set { MarcaVehiculo = value; }

        }

        [DataMember]
        public string ModeloVh
        {
            get { return ModeloVehiculo; }
            set { ModeloVehiculo = value; }

        }
        [DataMember]
        public string PatenteVh
        {
            get { return PatenteVehiculo; }
            set { PatenteVehiculo = value; }

        }
        [DataMember]
        public int AnioVh
        {
            get { return AnioVehiculo; }
            set { AnioVehiculo = value; }

        }
        [DataMember]
        public string Nombre
        {
            get { return NombreDuenio; }
            set { NombreDuenio = value; }

        }
        [DataMember]
        public string Apellido
        {
            get { return ApellidoDuenio; }
            set { ApellidoDuenio = value; }

        }
        [DataMember]
        public bool Aprov
        {
            get { return Aprobada; }
            set { Aprobada = value; }

        }
        [DataMember]
        public string Observacion
        {
            get { return Observaciones; }
            set { Observaciones = value; }

        }
        [DataMember]
        public DateTime FechaRevision
        {
            get { return fechaRev; }
            set { fechaRev = value; }

        }
    }


    public class RequestIngresoVehiculo
    {


        public string MarcaVh { get; set; }
        public string ModeloVh { get; set; }
        public string PatenteVh { get; set; }
        public int AnioVh { get; set; }
        public int IdDueño { get; set; }


    }
    public class RequestIngresoRevision
    {


        public int IdVehiculo { get; set; }
        public string Observaciones { get; set; }
        public int IdPersonal { get; set; }
        public bool Aprovado { get; set; }

    }

    public class RequestIngresoInspeccion
    {


        public int IdRevision { get; set; }
        public int TipoInspeccion { get; set; }
        public string Observaciones { get; set; }
        public string Estado { get; set; }
        public int IdPersonal { get; set; }

    }

    public class RequestHistorial
    {

        public string PatenteVehiculo { get; set; }


    }

    public class RequestBorrarInsp
    {

        public int idInspeccion { get; set; }


    }
}
