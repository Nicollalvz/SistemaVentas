using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaVentas
{
    public partial class Form1 : Form
    {
        // Modificación realizada por el Equipo A
        public Form1()
        {
            InitializeComponent();
        }

        private void txtCantidad_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrWhiteSpace(txtPrecio.Text) &&
                    !string.IsNullOrWhiteSpace(txtCantidad.Text))
                {
                    double precio = Convert.ToDouble(txtPrecio.Text);
                    int cantidad = Convert.ToInt32(txtCantidad.Text);
                    double total = precio * cantidad;
                    txtTotal.Text = total.ToString("F2");
                }
                else
                {
                    txtTotal.Clear();
                }
            }
            catch
            {
                txtTotal.Text = "Error";
            }
        }
    }
}
