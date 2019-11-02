using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class ObraSocial
    {
        private string _nombre;
        private string _codigo;
        private string _empresa;
        private string _plan;
        private string _asociadoTitular;
        private string _afiliado;

        public int IdObraSocial { get; set; }
        public bool Gravado { get; set; }

        public string Nombre   
        {
            get { return string.IsNullOrEmpty(_nombre)? "":_nombre.Trim(); }
            set { _nombre = value; }
        }
        public string Codigo
        {
            get { return string.IsNullOrEmpty(_codigo) ? "" : _codigo.Trim(); }
            set { _codigo = value; }
        }
        public string Empresa
        {
            get { return string.IsNullOrEmpty(_empresa) ? "" : _empresa.Trim(); }
            set { _empresa = value; }
        }
        public string Plan
        {
            get { return string.IsNullOrEmpty(_plan) ? "" : _plan.Trim(); }
            set { _plan = value; }
        }
        public string AsociadoTitular
        {
            get { return string.IsNullOrEmpty(_asociadoTitular) ? "" : _asociadoTitular.Trim(); }
            set { _asociadoTitular = value; }
        }
        public string Afiliado
        {
            get { return string.IsNullOrEmpty(_afiliado) ? "" : _afiliado.Trim(); }
            set { _afiliado = value; }
        }


    }
}
