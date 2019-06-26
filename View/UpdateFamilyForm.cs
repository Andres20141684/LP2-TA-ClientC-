using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using View.MateWSLocal;
namespace Producto
{
    public partial class UpdateFamilyForm : Form
    {
        private DBControllerWSClient serviceDAA;
        public family currentFamily;
        FamilyProductForm refParent;

        public UpdateFamilyForm()
        {
            InitializeComponent();
        }

        public void SetParent(FamilyProductForm form)
        {
            refParent = form;
        }

        private void UpdateFamilyForm_Shown(object sender, EventArgs e)
        {
            
        }

        private void setFamilyInformation()
        {
            txtFamilyCode.Text = currentFamily.idFamily;
            txtName.Text = currentFamily.name;
            txtDescription.Text = currentFamily.description;
            if (currentFamily.state == 1) cbActive.Checked = true;
            else cbActive.Checked = false;

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            serviceDAA = new DBControllerWSClient();
            currentFamily.idFamily = txtFamilyCode.Text;
            currentFamily.name = txtName.Text;
            currentFamily.description = txtDescription.Text;
            currentFamily.state = cbActive.Checked ? 1 : 0;
            serviceDAA.updateFamily(currentFamily);
            MessageBox.Show("La familia se modificó satisfactoriamente");
            this.Close();

        }

        private void UpdateFamilyForm_Load(object sender, EventArgs e)
        {
            setFamilyInformation();
        }
    }
}
