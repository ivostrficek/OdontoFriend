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
using System.Data.SqlClient;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DataAccessService.Consultorio.Models
{
    /// <summary>
    /// Output object for ContactoEmergenciaById method.
    /// </summary>
    public class ContactoEmergenciaByIdOutput
    {
        public enum Returns
        {
             NotFound = 0,
             Ok = 1
        }

		public Returns ReturnValue { set; get; }

        /// <summary>
        /// ContactoEmergenciaByIdResult result.
        /// </summary>
        public ContactoEmergenciaByIdResult ResultData { set; get; }
    }
}