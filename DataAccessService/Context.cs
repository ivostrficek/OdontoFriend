using DataAccessService.Consultorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessService
{
    public class Context : IDisposable
    {
        public void Dispose()
        {
            //holi holi
        }

        public Service GetService()
        {
            return new Service("Server = 127.0.0.1; Initial Catalog = Consultorio; User ID = sa; Password = !Coresec123;");
        }
    }
}
