// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by SqlPlus.net
//     Generated DateTime: 01-Nov-19 11:58:04 PM
//     For more information on SqlPlus.net visit http://www.SqlPlus.net
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------
using System.Collections.Generic;
namespace DataAccessService.Consultorio.Models
{
    /// <summary>
    /// Result object for GetObraSocialComplete routine.
    /// </summary>
    public class GetObraSocialCompleteResult
	{
        public int IdPaciente { set; get; }
        public int? IdObraSocial { set; get; }
        public string Nombre { set; get; }
        public string Codigo { set; get; }
        public string Empresa { set; get; }
        public string Plan { set; get; }
        public string AsociadoTitular { set; get; }
        public string Afiliado { set; get; }
        public bool? Gravado { set; get; }
    }
}