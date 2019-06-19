using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Producto
{
    public enum State3
    {
        Start, Save, Update
    }
    public partial class UpdateProductForm : Form
    {
        //private DBControllerWSClient serviceDA;
        //public product currentProduct;

        public UpdateProductForm()
        {
            InitializeComponent();
            //componentsState(State3.Start);
        }

        private void UpdateProductForm_Load(object sender, EventArgs e)
        {

        }

        public void componentsState(State3 s)
        {
            switch (s)
            {
                case State3.Start:
                    gbGeneralInformation.Enabled = false;
                    gbTransactionInformation.Enabled = false;
                    txtStock.Enabled = false;
                    btnSave.Enabled = false;
                    break;
                case State3.Save:
                    gbGeneralInformation.Enabled = false;
                    gbTransactionInformation.Enabled = false;
                    txtStock.Enabled = false;
                    btnSave.Enabled = false;
                    break;
                case State3.Update:
                    gbGeneralInformation.Enabled = true;
                    gbTransactionInformation.Enabled = true;
                    txtStock.Enabled = false;
                    btnSave.Enabled = true;
                    break;

            }
        }

        public void CompleteForm()
        {
            //se llena la infromación de los recuadros con la infromación del producto seleccionado
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            //componentsState(State3.Update);

        }

        private void BtnSave_Click_1(object sender, EventArgs e)
        {
            //componentsState(State3.Save);
            try
            {
                String name = txtName.Text;
                String codeSKU = txtSKUCode.Text;
                String description = txtDescription.Text;
                String caredescription = txtCareDescription.Text;

                //se cambian los atributos producto y se modifica en la tabla

                MessageBox.Show("Se modificó satisfactoriamente el producto.");
                this.Close();
            }
            catch
            {
                MessageBox.Show("No se pudo modificar el producto.");
            }
        }
    }
}
