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
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using DataAccessService.Consultorio.Models;

namespace DataAccessService.Consultorio
{
    public partial class Service
    {

        /// <summary>
        /// Builds the command object for ContactoEmergenciaUpdate method.
        /// </summary>
        /// <param name="cnn">The connection that will execute the procedure.</param>
        /// <param name="input">ContactoEmergenciaUpdateInput instance for loading parameter values.</param>
        /// <returns>SqlCommand ready for execution.</returns>
        private SqlCommand GetContactoEmergenciaUpdateCommand(SqlConnection cnn, IContactoEmergenciaUpdateInput input)
        {
            SqlCommand result = new SqlCommand()
            {
                CommandType = CommandType.StoredProcedure,
                CommandText = "dbo.ContactoEmergenciaUpdate",
                Connection = cnn
            };

            result.Parameters.Add(new SqlParameter()
            {
                ParameterName = "@IdContactoEmergencia",
                Direction = ParameterDirection.Input,
                SqlDbType = SqlDbType.Int,
                Scale = 0,
                Precision = 10,
				Value = input.IdContactoEmergencia
            });

            result.Parameters.Add(new SqlParameter()
            {
                ParameterName = "@Nombre",
                Direction = ParameterDirection.Input,
                SqlDbType = SqlDbType.VarChar,
                Size = 100,
				Value = (object)input.Nombre ?? DBNull.Value
            });

            result.Parameters.Add(new SqlParameter()
            {
                ParameterName = "@Telefono",
                Direction = ParameterDirection.Input,
                SqlDbType = SqlDbType.VarChar,
                Size = 50,
				Value = (object)input.Telefono ?? DBNull.Value
            });

            result.Parameters.Add(new SqlParameter()
            {
                ParameterName = "@Parentesco",
                Direction = ParameterDirection.Input,
                SqlDbType = SqlDbType.VarChar,
                Size = 50,
				Value = (object)input.Parentesco ?? DBNull.Value
            });

            result.Parameters.Add(new SqlParameter()
            {
                ParameterName = "@ReturnValue",
                Direction = ParameterDirection.ReturnValue,
                SqlDbType = SqlDbType.Int,
                Scale = 0,
                Precision = 10,
                Value = DBNull.Value
            });

            return result;
        }
        private void SetContactoEmergenciaUpdateCommandOutputs(SqlCommand cmd, ContactoEmergenciaUpdateOutput output)
        {
            if(cmd.Parameters[4].Value != DBNull.Value)
            {
                output.ReturnValue = (ContactoEmergenciaUpdateOutput.Returns)cmd.Parameters[4].Value;
            }
        }
        private void ContactoEmergenciaUpdateCommand(SqlCommand cmd, ContactoEmergenciaUpdateOutput output)
        {
            cmd.ExecuteNonQuery();
		
            SetContactoEmergenciaUpdateCommandOutputs(cmd, output);
		}

        /// <summary>
        /// Updates record for the dbo.ContactoEmergencia table.
        /// SQL+ Routine: dbo.ContactoEmergenciaUpdate - Authored by IvoStrficek
        /// </summary>
        public ContactoEmergenciaUpdateOutput ContactoEmergenciaUpdate(IContactoEmergenciaUpdateInput input)
        {
            if (!input.IsValid())
            {
		        throw new ArgumentException("ContactoEmergenciaUpdateInput fails validation - use the ContactoEmergenciaUpdateInput.IsValid() method prior to passing the input argument to the ContactoEmergenciaUpdate method.", "input");
            }
			
            ContactoEmergenciaUpdateOutput output = new ContactoEmergenciaUpdateOutput();
			if(sqlConnection != null)
            {
                using (SqlCommand cmd = GetContactoEmergenciaUpdateCommand(sqlConnection, input))
                {
                    cmd.Transaction = sqlTransaction;
                    ContactoEmergenciaUpdateCommand(cmd, output);
                }
                return output;
            }
            for(int idx=0; idx <= retryOptions.RetryIntervals.Count; idx++)
            {
                if(idx > 0)
                {
                    System.Threading.Thread.Sleep(retryOptions.RetryIntervals[idx-1]);
                }
                try
                {
                    using (SqlConnection cnn = new SqlConnection(connectionString))
                    using (SqlCommand cmd = GetContactoEmergenciaUpdateCommand(cnn, input))
                    {
                        cnn.Open();
						ContactoEmergenciaUpdateCommand(cmd, output);
                        cnn.Close();
                    }
					break;
                }
                catch(SqlException sqlException)
                {
                    bool throwException = true;

                    if(retryOptions.TransientErrorNumbers.Contains(sqlException.Number))
                    {
                        throwException = (idx == retryOptions.RetryIntervals.Count);

                        if (retryOptions.Logger != null)
                        {
                            retryOptions.Logger.Log(sqlException);
                        }
                    }
                    if(throwException)
                    {
                        throw;
                    }
                }
            }
            return output;
        }
    }
}