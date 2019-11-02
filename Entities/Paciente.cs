using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Paciente
    {
        private string _dni;
        private string _nombre;
        private string _apellido;
        private string _telefono;
        private string _domicilio;
        private string _sexo;
        private string _localidad;
        

        public int IdPaciente { get; set; }
        public DateTime? FechaNacimiento { get; set; }

        public string FechaNacimientoString
        {
            get {

                if (FechaNacimiento.HasValue)
                    if (FechaNacimiento.Value.Year == 1800)
                        return "";
                    else
                        return FechaNacimiento.Value.ToString("dd/MM/yyyy");
                else
                    return "";  
            }
        }
        public string DNI
        {
            get { return string.IsNullOrEmpty(_dni)? "":_dni.Trim(); }
            set { _dni = value; }
        }
        public string Nombre
        {
            get { return string.IsNullOrEmpty(_nombre) ? "" : _nombre.Trim(); }
            set { _nombre = value; }
        }
        public string Apellido
        {
            get { return string.IsNullOrEmpty(_apellido) ? "" : _apellido.Trim(); }
            set { _apellido = value; }
        }
        public string Telefono
        {
            get { return string.IsNullOrEmpty(_telefono) ? "" : _telefono.Trim(); }
            set { _telefono = value; }
        }
        public string Domicilio
        {
            get { return string.IsNullOrEmpty(_domicilio) ? "" : _domicilio.Trim(); }
            set { _domicilio = value; }
        }
        public string Sexo
        {
            get { return string.IsNullOrEmpty(_sexo) ? "" : _sexo.Trim().ToUpper(); }
            set { _sexo = value; }
        }
        public string Localidad
        {
            get { return string.IsNullOrEmpty(_localidad) ? "" : _localidad.Trim(); }
            set { _localidad = value; }
        }



        public bool MissingData()
        {
            return DNI == null
                || string.IsNullOrEmpty(Nombre)
                || string.IsNullOrEmpty(Apellido)
                || string.IsNullOrEmpty(Telefono)
                || !FechaNacimiento.HasValue
                || string.IsNullOrEmpty(Domicilio)
                || string.IsNullOrEmpty(Sexo)
                || string.IsNullOrEmpty(Localidad);
        }
    }
}
