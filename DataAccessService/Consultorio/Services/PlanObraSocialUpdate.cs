// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by SqlPlus.net
//     Generated DateTime: 05-Nov-19 10:28:59 PM
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
        /// Builds the command object for PlanObraSocialUpdate method.
        /// </summary>
        /// <param name="cnn">The connection that will execute the procedure.</param>
        /// <param name="input">PlanObraSocialUpdateInput instance for loading parameter values.</param>
        /// <returns>SqlCommand ready for execution.</returns>
        private SqlCommand GetPlanObraSocialUpdateCommand(SqlConnection cnn, IPlanObraSocialUpdateInput input)
        {
            SqlCommand result = new SqlCommand()
            {
                CommandType = CommandType.StoredProcedure,
                CommandText = "dbo.PlanObraSocialUpdate",
                Connection = cnn
            };

            result.Parameters.Add(new SqlParameter()
            {
                ParameterName = "@IdPlanObraSocial",
                Direction = ParameterDirection.Input,
                SqlDbType = SqlDbType.Int,
                Scale = 0,
                Precision = 10,
				Value = input.IdPlanObraSocial
            });

            result.Parameters.Add(new SqlParameter()
            {
                ParameterName = "@IdObraSocial",
                Direction = ParameterDirection.Input,
                SqlDbType = SqlDbType.Int,
                Scale = 0,
                Precision = 10,
				Value = (object)input.IdObraSocial ?? DBNull.Value
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
                ParameterName = "@Habilitado",
                Direction = ParameterDirection.Input,
                SqlDbType = SqlDbType.Bit,
				Value = (object)input.Habilitado ?? DBNull.Value
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
        private void SetPlanObraSocialUpdateCommandOutputs(SqlCommand cmd, PlanObraSocialUpdateOutput output)
        {
            if(cmd.Parameters[4].Value != DBNull.Value)
            {
                output.ReturnValue = (PlanObraSocialUpdateOutput.Returns)cmd.Parameters[4].Value;
            }
        }
        private void PlanObraSocialUpdateCommand(SqlCommand cmd, PlanObraSocialUpdateOutput output)
        {
            cmd.ExecuteNonQuery();
		
            SetPlanObraSocialUpdateCommandOutputs(cmd, output);
		}

        /// <summary>
        /// Updates record for the dbo.PlanObraSocial table.
        /// SQL+ Routine: dbo.PlanObraSocialUpdate - Authored by Ivo Strficek
        /// </summary>
        public PlanObraSocialUpdateOutput PlanObraSocialUpdate(IPlanObraSocialUpdateInput input)
        {
            if (!input.IsValid())
            {
		        throw new ArgumentException("PlanObraSocialUpdateInput fails validation - use the PlanObraSocialUpdateInput.IsValid() method prior to passing the input argument to the PlanObraSocialUpdate method.", "input");
            }
			
            PlanObraSocialUpdateOutput output = new PlanObraSocialUpdateOutput();
			if(sqlConnection != null)
            {
                using (SqlCommand cmd = GetPlanObraSocialUpdateCommand(sqlConnection, input))
                {
                    cmd.Transaction = sqlTransaction;
                    PlanObraSocialUpdateCommand(cmd, output);
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
                    using (SqlCommand cmd = GetPlanObraSocialUpdateCommand(cnn, input))
                    {
                        cnn.Open();
						PlanObraSocialUpdateCommand(cmd, output);
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