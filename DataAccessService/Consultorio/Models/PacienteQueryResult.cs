// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by SqlPlus.net
//     Generated DateTime: 01-Nov-19 11:58:04 PM
//     For more information on SqlPlus.net visit http://www.SqlPlus.net
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
namespace DataAccessService.Consultorio.Models
{
    /// <summary>
    /// Result object for PacienteQuery routine.
    /// </summary>
    public class PacienteQueryResult
	{
        public int IdPaciente { set; get; }
        public string DNI { set; get; }
        public string Nombre { set; get; }
        public string Apellido { set; get; }
        public string Telefono { set; get; }
        public string FechaNacimientoS { set; get; }
        public DateTime? FechaNacimiento { set; get; }
        public string Domicilio { set; get; }
        public string Sexo { set; get; }
        public string Localidad { set; get; }
    }
}