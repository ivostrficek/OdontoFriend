using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessService.Consultorio;
using DataAccessService.Consultorio.Models;

namespace DataAccessService
{
    public class ConsultorioDataAccessService
    {
        public List<Paciente> GetAllPacientes()
        {
            Service service = GetService();
            PacienteQueryOutput listaPacientes = service.PacienteQuery();

            if (listaPacientes.ReturnValue == PacienteQueryOutput.Returns.Ok)
                return (from paciente in listaPacientes.ResultData
                        select new Paciente()
                        {                            
                            Apellido = paciente.Apellido,
                            DNI = paciente.DNI,
                            Domicilio = paciente.Domicilio,
                            FechaNacimiento = paciente.FechaNacimiento == null ? new DateTime(1800,1,1) : paciente.FechaNacimiento,
                            IdPaciente = paciente.IdPaciente,
                            Localidad = paciente.Localidad,
                            Nombre = paciente.Nombre,
                            Sexo = paciente.Sexo,
                            Telefono = paciente.Telefono,
                        }).ToList();
            else
                return new List<Paciente>();
        }

        public List<ObraSocial> GetObraSocial(int idPaciente)
        {
            Service service = GetService();
            GetObraSocialCompleteInput input = new GetObraSocialCompleteInput() { idPaciente = idPaciente };
            GetObraSocialCompleteOutput listaObrasSociales = service.GetObraSocialComplete(input);

            if (listaObrasSociales.ReturnValue == GetObraSocialCompleteOutput.Returns.Ok)
                return (from obraSocial in listaObrasSociales.ResultData
                        select new ObraSocial()
                        {
                            IdObraSocial = obraSocial.IdObraSocial.Value,
                            Nombre = obraSocial.Nombre,
                            Codigo = obraSocial.Codigo,
                            Afiliado = obraSocial.Afiliado,
                            AsociadoTitular = obraSocial.AsociadoTitular,
                            Empresa = obraSocial.Empresa,
                            Plan = obraSocial.Plan,
                            Gravado = obraSocial.Gravado.HasValue? false : obraSocial.Gravado.Value
                        }).ToList();
            else
                return new List<ObraSocial>();
        }

        public List<Plan> GetPlanes(int idObraSocial)
        {
            var service = GetService();

            var input = new PlanSocialGetInput() { IdObraSocial = idObraSocial };
            var lista = service.PlanSocialGet(input);

            if (lista.ReturnValue == PlanSocialGetOutput.Returns.Ok)
                return (from obraSocial in lista.ResultData
                        select new Plan()
                        {
                            IdObraSocial = obraSocial.IdObraSocial.Value,
                            Nombre = obraSocial.Nombre,
                            Habilitado = obraSocial.Habilitado.Value,
                            IdPlan = obraSocial.IdPlanObraSocial
                        }).ToList();
            else
                return new List<Plan>();
        }

        public ContactoEmergencia ObtenerContactoEmergencia(int idPaciente)
        {
            Service service = GetService();
            ContactoEmergenciaByPacienteIdInput input = new ContactoEmergenciaByPacienteIdInput() { IdPaciente = idPaciente };
            ContactoEmergenciaByPacienteIdOutput contacto = service.ContactoEmergenciaByPacienteId(input);

            if (contacto.ReturnValue == ContactoEmergenciaByPacienteIdOutput.Returns.Ok)
                return new ContactoEmergencia() { IdPaciente = idPaciente, Nombre = contacto.ResultData.Nombre, Parentesco = contacto.ResultData.Parentesco, Telefono = contacto.ResultData.Telefono };
            else
                return new ContactoEmergencia();
        }

        public List<Paciente> GetAllPacientes(string filtro)
        {
            Service service = GetService();
            SearchPacienteInput input = new SearchPacienteInput() { Searchtext = filtro };
            SearchPacienteOutput listaPacientes = service.SearchPaciente(input);

            if (listaPacientes.ReturnValue == SearchPacienteOutput.Returns.Ok)
                return (from paciente in listaPacientes.ResultData
                        select new Paciente()
                        {
                            Apellido = paciente.Apellido,
                            DNI = paciente.DNI,
                            Domicilio = paciente.Domicilio,
                            FechaNacimiento = paciente.FechaNacimiento == null ? new DateTime(1800, 1, 1) : paciente.FechaNacimiento,
                            IdPaciente = paciente.IdPaciente,
                            Localidad = paciente.Localidad,
                            Nombre = paciente.Nombre,
                            Sexo = paciente.Sexo,
                            Telefono = paciente.Telefono
                        }).ToList();
            else
                return new List<Paciente>();
        }

        public List<Paciente> GetPaciente(string query)
        {
            Service service = new Service("");

            SearchPacienteInput input = new SearchPacienteInput()
            {
                Searchtext = query
            };

            SearchPacienteOutput listaPacientes = service.SearchPaciente(input);

            if(listaPacientes.ReturnValue == SearchPacienteOutput.Returns.Ok)
                return (from paciente in listaPacientes.ResultData
                        select new Paciente()
                        {
                            Apellido = paciente.Apellido,
                            DNI = paciente.DNI,
                            Domicilio = paciente.Domicilio,
                            FechaNacimiento = paciente.FechaNacimiento.Value,
                            IdPaciente = paciente.IdPaciente,
                            Localidad = paciente.Localidad,
                            Nombre = paciente.Nombre,
                            Sexo = paciente.Sexo,
                            Telefono = paciente.Telefono
                        }).ToList();
            else
                return new List<Paciente>();
        }

        public List<ObraSocial> GetAllObraSocial()
        {
            Service service = GetService();
            GetAllObraSocialOutput listaIbrasSociales = service.GetAllObraSocial();

            if (listaIbrasSociales.ReturnValue == GetAllObraSocialOutput.Returns.Ok)
                return (from obraSocial in listaIbrasSociales.ResultData
                        select new ObraSocial()
                        {
                            IdObraSocial = obraSocial.IdObraSocial,
                            Nombre = obraSocial.Nombre,
                            Codigo = obraSocial.Codigo
                        }).ToList();
            else
                return new List<ObraSocial>();
        }

        public int DeletePaciente(Paciente paciente)
        {
            Service service = GetService();
            PacienteDeleteInput input = new PacienteDeleteInput() { IdPaciente = paciente.IdPaciente };
            PacienteDeleteOutput resultado = service.PacienteDelete(input);

            if (resultado.ReturnValue == PacienteDeleteOutput.Returns.Ok)
                return 0;
            else
                return 1;
        }

        private Service GetService()
        {
            return new Context().GetService();
        }
    }
}
