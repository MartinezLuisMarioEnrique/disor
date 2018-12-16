using Cifrado_Cesar.alfabeto;
using Cifrado_Cesar.cifrado;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Cifrados
{
    public partial class metodosDeCifrados : System.Web.UI.Page
    {
        private CifradoCesar cifradoCesar;

        protected void Page_Load(object sender, EventArgs e)
        {
            cifradoCesar = new CifradoCesar(new EspanolLatino());
        }

        protected void txtPlano_TextChanged(object sender, EventArgs e)
        {
            txtCifradoCesar.Text += cifradoCesar.cifrarCadena(Int32.Parse(numDesplazamiento.Text), txtCifradoCesar.Text);
            //txtCifradoTI.Text = txtCifradoTI.Text.Insert(0, e.KeyChar.ToString());
        }
    }
}