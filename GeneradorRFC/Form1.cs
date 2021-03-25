using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GeneradorRFC
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                MessageBox.Show("Solo números");
                e.Handled = true;
            }
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            try
            {
                lstBxContenedor.Items.Clear();

                RFC r1 = new RFC();
                int cant = int.Parse(txtCantidad.Text);

                for (int i = 0; i < cant; i++)
                {
                    lstBxContenedor.Items.Add(r1.GenerarRFCs());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Porfavor ingrese un número");
            }
        }

        private void btnBlock_Click(object sender, EventArgs e)
        {
            if (this.TopMost == true)
                this.TopMost = false;
            else
                this.TopMost = true;
        }

        private void lstBxContenedor_DoubleClick(object sender, EventArgs e)
        {
            Clipboard.SetText(this.lstBxContenedor.SelectedItem.ToString());
        }
    }
}
