using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Almacenes.Interfaces;
using Almacenes.BusinessLogic;
using Almacenes.BusinessEntities;
using Almacenes.DataAccess;

namespace Almacenes.AppWeb
{
    public partial class frmProducto : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void buSave_Click(object sender, EventArgs e)
        {
            beProducto obeProducto = new beProducto();
            obeProducto.ProductoId = 1;
            obeProducto.Nombre = "Producto 1";

            iProducto oiProducto = null;
            oiProducto = new daProducto();
            // Inyectamos la dependencia a través del constructor
            var oblproducto = new blProducto(oiProducto);
            // Producto usa el metodo de insertar
            int i = oblproducto.insertar(obeProducto);

        }
    }
}