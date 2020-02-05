using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Almacenes.BusinessEntities;
using Almacenes.Services;

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
            obeProducto.ProductoId =  Convert.ToInt32(txProductoId.Text);
            obeProducto.Nombre = txNombre.Text;
            var osProducto = new sProducto();
            int i = osProducto.insertar(obeProducto);
            if (i>0)
            {
                laResultado.Text = "Se registro correctamente";
            }
            else
            {
                laResultado.Text = "No Se registro correctamente";
            }


        }
    }
}