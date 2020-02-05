using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Almacenes.BusinessLogic;
using Almacenes.BusinessEntities;
using Almacenes.DataAccess;
using Almacenes.Interfaces;


namespace Almacenes.Services
{
    public class sProducto
    {
        blProducto _oblProducto;

        public sProducto()
        {
            idaProducto oidaProducto = new daProducto();
            // Inyectamos la dependencia a través del constructor
            _oblProducto = new blProducto(oidaProducto);
        }
        public int insertar(beProducto obeProducto)
        {
            int id = 0;
            id = _oblProducto.insertar(obeProducto);
            return id;
        }

    }
}
