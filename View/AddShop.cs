using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShopsForm
{
    public partial class Agregar_Local : Form
    {
        ShopForm refParent;
        public Agregar_Local()
        {
            InitializeComponent();
        }

        private void btnSaveLocal_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Se ha agregado un nuevo local satisfactoriamente");
            this.Close();
        }
        public void SetParent(ShopForm form)
        {
            refParent = form;
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
