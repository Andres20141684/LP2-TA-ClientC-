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
    public partial class Modificar_Local : Form
    {
        ShopForm refParent;
        public Modificar_Local()
        {
            InitializeComponent();
        }
        public void SetParent(ShopForm form)
        {
            refParent = form;
        }

        private void btnSaveChanges_Click(object sender, EventArgs e)
        {
            if (!filledValues())
            {
                //MessageBox.Show("Complete la información");
            }
            else
            {
                MessageBox.Show("Los cambios han sido realizados satisfactoriamente");
                this.Close();
            }
        }
        private bool filledValues()
        {


            return true;
        }
    }
}
