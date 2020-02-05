using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Almacenes.BusinessEntities;
using System.Data.SqlClient;

namespace Almacenes.Interfaces
{
    public interface iProducto
    {
        int insertar(SqlConnection con, beProducto obeProducto);
    }
}
