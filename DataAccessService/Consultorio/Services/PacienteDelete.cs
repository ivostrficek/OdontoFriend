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
        /// Builds the command object for PacienteDelete method.
        /// </summary>
        /// <param name="cnn">The connection that will execute the procedure.</param>
        /// <param name="input">PacienteDeleteInput instance for loading parameter values.</param>
        /// <returns>SqlCommand ready for execution.</returns>
        private SqlCommand GetPacienteDeleteCommand(SqlConnection cnn, IPacienteDeleteInput input)
        {
            SqlCommand result = new SqlCommand()
            {
                CommandType = CommandType.StoredProcedure,
                CommandText = "dbo.PacienteDelete",
                Connection = cnn
            };

            result.Parameters.Add(new SqlParameter()
            {
                ParameterName = "@IdPaciente",
                Direction = ParameterDirection.Input,
                SqlDbType = SqlDbType.Int,
                Scale = 0,
                Precision = 10,
				Value = input.IdPaciente
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
        private void SetPacienteDeleteCommandOutputs(SqlCommand cmd, PacienteDeleteOutput output)
        {
            if(cmd.Parameters[1].Value != DBNull.Value)
            {
                output.ReturnValue = (PacienteDeleteOutput.Returns)cmd.Parameters[1].Value;
            }
        }
        private void PacienteDeleteCommand(SqlCommand cmd, PacienteDeleteOutput output)
        {
            cmd.ExecuteNonQuery();
		
            SetPacienteDeleteCommandOutputs(cmd, output);
		}

        /// <summary>
        /// Deletes single row from dbo.Paciente table by identity column.
        /// SQL+ Routine: dbo.PacienteDelete - Authored by IStrficek
        /// </summary>
        public PacienteDeleteOutput PacienteDelete(IPacienteDeleteInput input)
        {
            if (!input.IsValid())
            {
		        throw new ArgumentException("PacienteDeleteInput fails validation - use the PacienteDeleteInput.IsValid() method prior to passing the input argument to the PacienteDelete method.", "input");
            }
			
            PacienteDeleteOutput output = new PacienteDeleteOutput();
			if(sqlConnection != null)
            {
                using (SqlCommand cmd = GetPacienteDeleteCommand(sqlConnection, input))
                {
                    cmd.Transaction = sqlTransaction;
                    PacienteDeleteCommand(cmd, output);
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
                    using (SqlCommand cmd = GetPacienteDeleteCommand(cnn, input))
                    {
                        cnn.Open();
						PacienteDeleteCommand(cmd, output);
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