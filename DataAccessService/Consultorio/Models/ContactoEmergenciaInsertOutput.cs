// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by SqlPlus.net
//     Generated DateTime: 05-Nov-19 10:28:58 PM
//     For more information on SqlPlus.net visit http://www.SqlPlus.net
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using System;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DataAccessService.Consultorio.Models
{
    /// <summary>
    /// Output object for ContactoEmergenciaInsert method.
    /// </summary>
    public class ContactoEmergenciaInsertOutput
    {
        public enum Returns
        {
             Ok = 1
        }

		public int? IdContactoEmergencia { set; get; }

		public Returns ReturnValue { set; get; }

    }
}