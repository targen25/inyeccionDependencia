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
        iProducto oiProducto;
        public blProducto(iProducto _oiProducto)
        {
            oiProducto = _oiProducto;
        }
        public int insertar(beProducto obeProducto)
        {
            int id = -1;

            using (SqlConnection con = new SqlConnection(CadenaConexion))
            {
                con.Open();
                id = oiProducto.insertar(con, obeProducto);

            }
            return id;

        }
    }
}
