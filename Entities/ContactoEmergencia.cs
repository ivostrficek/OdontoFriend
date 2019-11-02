using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class ContactoEmergencia
    {
        private string _nombre;
        private string _paretesco;
        private string _telefono;
        public int IdPaciente { get; set; }
        public string Nombre {
            get
            {
                if (string.IsNullOrEmpty(_nombre))
                    return string.Empty;
                else
                    return _nombre.Trim();
            }
            set
            {
                _nombre = value;
            }
        }
        public string Parentesco
        {
            get
            {
                if (string.IsNullOrEmpty(_paretesco))
                    return string.Empty;
                else
                    return _paretesco.Trim();
            }
            set
            {
                _paretesco = value;
            }
        }
        public string Telefono
        {
            get
            {
                if (string.IsNullOrEmpty(_telefono))
                    return string.Empty;
                else
                    return _telefono.Trim();
            }
            set
            {
                _telefono = value;
            }
        }
    }
}
