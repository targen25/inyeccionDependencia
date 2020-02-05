using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Almacenes.BusinessEntities;
using System.Data;
using System.Data.SqlClient;
using Almacenes.Interfaces;


namespace Almacenes.BusinessLogic
{
    public class blProducto :blGeneral
    {
        idaProducto _oidaProducto;
        public blProducto(idaProducto oidaProducto)
        {
            _oidaProducto = oidaProducto;
        }
        public int insertar(beProducto obeProducto)
        {
            int id = 0;

            using (SqlConnection con = new SqlConnection(CadenaConexion))
            {
                try
                {
                    con.Open();
                    id = _oidaProducto.insertar(con, obeProducto);

                }
                catch (Exception ex)
                {
                    id = -1;

                }
            }
            return id;

        }
    }
}
