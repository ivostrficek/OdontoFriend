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
        /// Builds the command object for PacienteInsert method.
        /// </summary>
        /// <param name="cnn">The connection that will execute the procedure.</param>
        /// <param name="input">PacienteInsertInput instance for loading parameter values.</param>
        /// <returns>SqlCommand ready for execution.</returns>
        private SqlCommand GetPacienteInsertCommand(SqlConnection cnn, IPacienteInsertInput input)
        {
            SqlCommand result = new SqlCommand()
            {
                CommandType = CommandType.StoredProcedure,
                CommandText = "dbo.PacienteInsert",
                Connection = cnn
            };

            result.Parameters.Add(new SqlParameter()
            {
                ParameterName = "@IdPaciente",
                Direction = ParameterDirection.Output,
                SqlDbType = SqlDbType.Int,
                Scale = 0,
                Precision = 10,
                Value = DBNull.Value
            });

            result.Parameters.Add(new SqlParameter()
            {
                ParameterName = "@DNI",
                Direction = ParameterDirection.Input,
                SqlDbType = SqlDbType.VarChar,
                Size = 50,
				Value = (object)input.DNI ?? DBNull.Value
            });

            result.Parameters.Add(new SqlParameter()
            {
                ParameterName = "@Nombre",
                Direction = ParameterDirection.Input,
                SqlDbType = SqlDbType.VarChar,
                Size = 50,
				Value = (object)input.Nombre ?? DBNull.Value
            });

            result.Parameters.Add(new SqlParameter()
            {
                ParameterName = "@Apellido",
                Direction = ParameterDirection.Input,
                SqlDbType = SqlDbType.VarChar,
                Size = 50,
				Value = (object)input.Apellido ?? DBNull.Value
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
                ParameterName = "@FechaNacimiento",
                Direction = ParameterDirection.Input,
                SqlDbType = SqlDbType.Date,
                Precision = 0,
				Value = (object)input.FechaNacimiento ?? DBNull.Value
            });

            result.Parameters.Add(new SqlParameter()
            {
                ParameterName = "@Domicilio",
                Direction = ParameterDirection.Input,
                SqlDbType = SqlDbType.VarChar,
                Size = 200,
				Value = (object)input.Domicilio ?? DBNull.Value
            });

            result.Parameters.Add(new SqlParameter()
            {
                ParameterName = "@Sexo",
                Direction = ParameterDirection.Input,
                SqlDbType = SqlDbType.Char,
                Size = 1,
				Value = (object)input.Sexo ?? DBNull.Value
            });

            result.Parameters.Add(new SqlParameter()
            {
                ParameterName = "@Localidad",
                Direction = ParameterDirection.Input,
                SqlDbType = SqlDbType.VarChar,
                Size = 50,
				Value = (object)input.Localidad ?? DBNull.Value
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
        private void SetPacienteInsertCommandOutputs(SqlCommand cmd, PacienteInsertOutput output)
        {
            if(cmd.Parameters[0].Value != DBNull.Value)
            {
                output.IdPaciente = (int?)cmd.Parameters[0].Value;
            }
            if(cmd.Parameters[9].Value != DBNull.Value)
            {
                output.ReturnValue = (PacienteInsertOutput.Returns)cmd.Parameters[9].Value;
            }
        }
        private void PacienteInsertCommand(SqlCommand cmd, PacienteInsertOutput output)
        {
            cmd.ExecuteNonQuery();
		
            SetPacienteInsertCommandOutputs(cmd, output);
		}

        /// <summary>
        /// Inserts a new record into the dbo.Paciente table.
        /// SQL+ Routine: dbo.PacienteInsert - Authored by IStrficek
        /// </summary>
        public PacienteInsertOutput PacienteInsert(IPacienteInsertInput input)
        {
            if (!input.IsValid())
            {
		        throw new ArgumentException("PacienteInsertInput fails validation - use the PacienteInsertInput.IsValid() method prior to passing the input argument to the PacienteInsert method.", "input");
            }
			
            PacienteInsertOutput output = new PacienteInsertOutput();
			if(sqlConnection != null)
            {
                using (SqlCommand cmd = GetPacienteInsertCommand(sqlConnection, input))
                {
                    cmd.Transaction = sqlTransaction;
                    PacienteInsertCommand(cmd, output);
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
                    using (SqlCommand cmd = GetPacienteInsertCommand(cnn, input))
                    {
                        cnn.Open();
						PacienteInsertCommand(cmd, output);
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