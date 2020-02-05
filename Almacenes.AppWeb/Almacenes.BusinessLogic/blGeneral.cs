using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace Almacenes.BusinessLogic
{
    public class blGeneral
    {
        protected string CadenaConexion { get; set; }
        protected blGeneral()
        {
            CadenaConexion = ConfigurationManager.ConnectionStrings["almacenes"].ConnectionString;
        }

    }
}
