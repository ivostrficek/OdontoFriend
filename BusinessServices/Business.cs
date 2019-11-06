using DataAccessService;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessServices
{
    public class Business
    {
        public List<Paciente> GetPacientes()
        {
            ConsultorioDataAccessService dataAccess = new ConsultorioDataAccessService();
            var pacientes = dataAccess.GetAllPacientes();

            return pacientes;
        }

        public List<Paciente> GetPacientes(string filtro)
        {
            ConsultorioDataAccessService dataAccess = new ConsultorioDataAccessService();
            var pacientes = dataAccess.GetAllPacientes(filtro);

            return pacientes;
        }

        public List<ObraSocial> GetObraSocial(int idPaciente)
        {
            ConsultorioDataAccessService dataAccess = new ConsultorioDataAccessService();
            var obrasSociales = dataAccess.GetObraSocial(idPaciente);

            return obrasSociales;
        }

        public List<ObraSocial> GetAllObraSocial()
        {
            ConsultorioDataAccessService dataAccess = new ConsultorioDataAccessService();
            var obrasSociales = dataAccess.GetAllObraSocial();

            return obrasSociales;
        }

        public int DeletePaciente(Paciente paciente)
        {
            ConsultorioDataAccessService dataAccess = new ConsultorioDataAccessService();
            var resultado = dataAccess.DeletePaciente(paciente);

            return resultado;
        }

        public ContactoEmergencia ObtenerContactoEmergencia(int idPaciente)
        {
            ConsultorioDataAccessService dataAccess = new ConsultorioDataAccessService();

            return dataAccess.ObtenerContactoEmergencia(idPaciente);
        }

        public List<Plan> GetPlanes(int idObraSocial)
        {
            ConsultorioDataAccessService dataAccess = new ConsultorioDataAccessService();

            return dataAccess.GetPlanes(idObraSocial);
        }
    }
}
