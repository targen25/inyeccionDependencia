using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Almacenes.BusinessEntities;
using System.Data;
using System.Data.SqlClient;
using Almacenes.Interfaces;


namespace Almacenes.DataAccess
{
    public class daProducto: iProducto
    {
        public int insertar(SqlConnection con, beProducto obeProducto)
        {
            int id = -1;
            SqlCommand cmd = new SqlCommand("spProductoInsertar", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@ProductoId",obeProducto.ProductoId));
            cmd.Parameters.Add(new SqlParameter("@Nombre", obeProducto.Nombre));

            id = cmd.ExecuteNonQuery();
            return id;
        }
    }
}
