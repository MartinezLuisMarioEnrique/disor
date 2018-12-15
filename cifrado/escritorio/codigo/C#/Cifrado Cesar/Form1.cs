using Cifrado_Cesar.alfabeto;
using Cifrado_Cesar.cifrado;
using Cifrado_Cesar.texto;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cifrado_Cesar
{
    public partial class Form1 : Form
    {
        private CifradoCesar cifrado;
        public Form1()
        {
            InitializeComponent();
            cifrado = new CifradoCesar(new EspanolLatino());
        }

        private void txtTextoPlano_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != 8)
            {
                txtCifrado.Text += cifrado.cifrarLetra((int)numDesplazamiento.Value, e.KeyChar);
                txtTI.Text = txtTI.Text.Insert(0, e.KeyChar.ToString());
            }
        }

        private void numDesplazamiento_ValueChanged(object sender, EventArgs e)
        {
            txtCifrado.Text = cifrado.cifrarCadena((int)numDesplazamiento.Value, txtTextoPlano.Text);
        }

        private void txtTextoPlano_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 8)
            {
                txtCifrado.Text = (txtCifrado.Text.Length>0) ? txtCifrado.Text.Substring(0, txtCifrado.Text.Length - 1) : "";
                txtTI.Text = (txtTI.Text.Length > 0) ? txtTI.Text.Substring(0, txtTI.Text.Length - 1) : "";
            }
        }
    }
}
