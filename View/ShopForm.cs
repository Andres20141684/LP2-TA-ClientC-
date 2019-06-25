using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using View;
using View.MateWSLocal;

namespace ShopsForm
{
    public partial class ShopForm : Form
    {
        private BindingList<View.MateWSLocal.premises> shopsData;
        private View.MateWSLocal.DBControllerWSClient serviceDA;
        private View.MateWSLocal.DBControllerWSClient serviceDAA;
        public ShopForm()
        {
            InitializeComponent();
            updateDataGridView();
        }
        View.MainWindow refParent;
        void updateDataGridView()
        {
            Cursor.Current = Cursors.WaitCursor;
            dgvLocal.Rows.Clear();
            serviceDA = new View.MateWSLocal.DBControllerWSClient();
            shopsData = new BindingList<View.MateWSLocal.premises>(serviceDA.queryAllPremises());
            for (int i=0;i<shopsData.Count;i++)
            {
                dgvLocal.Rows.Add(new String[]{
                    shopsData[i].id.ToString(), shopsData[i].description, shopsData[i].creationDate.ToString(), shopsData[i].address
                });
            }
            Cursor.Current = Cursors.Arrow;
        }
        public void SetParent(View.MainWindow form)
        {
            refParent = form;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAddLocal_Click(object sender, EventArgs e)
        {
            Agregar_Local addLocal = new Agregar_Local();
            if (addLocal.ShowDialog() == DialogResult.OK)
            {
                //addLocal.SetParent(this);
                addLocal.ShowDialog();
                updateDataGridView();
            }
            updateDataGridView();
        }

        private void btnModLocal_Click(object sender, EventArgs e)
        {
            Modificar_Local modLocal = new Modificar_Local();
            modLocal.SetParent(this);
            modLocal.ShowDialog();
            int i = dgvLocal.CurrentCell.RowIndex;
            if (i >= 0)
            {
                /*UpdateShopForm updateShop = new View.UpdateShopForm();
                updateShop.currentPremise = new premises();
                updateShop.currentPremise = shopsData[i];
                updateShop.ShowDialog();
                updateDataGridView();*/

            }
            else
            {
                MessageBox.Show("Seleccione un producto");
            }
        }

        private void btnDelLocal_Click(object sender, EventArgs e)
        {
            int i = dgvLocal.CurrentCell.RowIndex;
            if (i >= 0)
            {
                premises premise_aux = new premises();
                premise_aux = shopsData[i];
                premise_aux.state = 0;
                serviceDA.updatePremises(premise_aux);
                updateDataGridView();
                MessageBox.Show("Se ha eliminado el producto seleccionado");
            }
            else
            {
                MessageBox.Show("Seleccione un producto");
            }
            //MessageBox.Show("Se ha eliminado al local seleccionado");
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            

            if (textBox1.Text == "")
            {
                MessageBox.Show("Inserte un código válido");
            }
        }

        private void ShopForm_Load(object sender, EventArgs e)
        {
            //Load, cargamos el grid
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }
    }
}
