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
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using DataAccessService.Consultorio.Models;

namespace DataAccessService.Consultorio
{
    public partial class Service
    {

        /// <summary>
        /// Builds the command object for ContactoEmergenciaInsert method.
        /// </summary>
        /// <param name="cnn">The connection that will execute the procedure.</param>
        /// <param name="input">ContactoEmergenciaInsertInput instance for loading parameter values.</param>
        /// <returns>SqlCommand ready for execution.</returns>
        private SqlCommand GetContactoEmergenciaInsertCommand(SqlConnection cnn, IContactoEmergenciaInsertInput input)
        {
            SqlCommand result = new SqlCommand()
            {
                CommandType = CommandType.StoredProcedure,
                CommandText = "dbo.ContactoEmergenciaInsert",
                Connection = cnn
            };

            result.Parameters.Add(new SqlParameter()
            {
                ParameterName = "@IdContactoEmergencia",
                Direction = ParameterDirection.Output,
                SqlDbType = SqlDbType.Int,
                Scale = 0,
                Precision = 10,
                Value = DBNull.Value
            });

            result.Parameters.Add(new SqlParameter()
            {
                ParameterName = "@IdPaciente",
                Direction = ParameterDirection.Input,
                SqlDbType = SqlDbType.Int,
                Scale = 0,
                Precision = 10,
				Value = (object)input.IdPaciente ?? DBNull.Value
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
        private void SetContactoEmergenciaInsertCommandOutputs(SqlCommand cmd, ContactoEmergenciaInsertOutput output)
        {
            if(cmd.Parameters[0].Value != DBNull.Value)
            {
                output.IdContactoEmergencia = (int?)cmd.Parameters[0].Value;
            }
            if(cmd.Parameters[5].Value != DBNull.Value)
            {
                output.ReturnValue = (ContactoEmergenciaInsertOutput.Returns)cmd.Parameters[5].Value;
            }
        }
        private void ContactoEmergenciaInsertCommand(SqlCommand cmd, ContactoEmergenciaInsertOutput output)
        {
            cmd.ExecuteNonQuery();
		
            SetContactoEmergenciaInsertCommandOutputs(cmd, output);
		}

        /// <summary>
        /// Inserts a new record into the dbo.ContactoEmergencia table.
        /// SQL+ Routine: dbo.ContactoEmergenciaInsert - Authored by Ivo Strficek
        /// </summary>
        public ContactoEmergenciaInsertOutput ContactoEmergenciaInsert(IContactoEmergenciaInsertInput input)
        {
            if (!input.IsValid())
            {
		        throw new ArgumentException("ContactoEmergenciaInsertInput fails validation - use the ContactoEmergenciaInsertInput.IsValid() method prior to passing the input argument to the ContactoEmergenciaInsert method.", "input");
            }
			
            ContactoEmergenciaInsertOutput output = new ContactoEmergenciaInsertOutput();
			if(sqlConnection != null)
            {
                using (SqlCommand cmd = GetContactoEmergenciaInsertCommand(sqlConnection, input))
                {
                    cmd.Transaction = sqlTransaction;
                    ContactoEmergenciaInsertCommand(cmd, output);
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
                    using (SqlCommand cmd = GetContactoEmergenciaInsertCommand(cnn, input))
                    {
                        cnn.Open();
						ContactoEmergenciaInsertCommand(cmd, output);
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