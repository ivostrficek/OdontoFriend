using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Plan
    {
        private string _nombre;

        public string Nombre
        {
            get { return _nombre.Trim(); }
            set { _nombre = value; }
        }
        public int IdPlan { get; set; }
        public int IdObraSocial { get; set; }
        public bool Habilitado { get; set; }
    }
}
