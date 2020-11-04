using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pharmafast
{
    
    public partial class ModuloProducto : Form
    {
        ModuloRegistroproducto registro = new ModuloRegistroproducto();
        public ModuloProducto()
        {
        InitializeComponent();
        }

    
        private void buttonNuevo_Click(object sender, EventArgs e)
        {

            registro.Show();
        }

        private void ModuloProducto_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
