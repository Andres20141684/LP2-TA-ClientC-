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
    public enum State
    {
        Start, ProductSelected
    }

    
    public partial class FrmProduct : Form

    {
        public class Product{}
        private Product p;
        private BindingList<View.MateWSLocal.product> productsData;
        private View.MateWSLocal.DBControllerWSClient serviceDA;
        public FrmProduct()
        {
            InitializeComponent();
            updateDataGridView();
        }

        void updateDataGridView()
        {
            Cursor.Current = Cursors.WaitCursor;
            dgvProducts.Rows.Clear();
            serviceDA = new View.MateWSLocal.DBControllerWSClient();
            productsData = new BindingList<View.MateWSLocal.product>(serviceDA.queryAllProducts());
            for (int i = 0; i < productsData.Count; i++)
            {
                dgvProducts.Rows.Add(new String[] {
                ""+productsData[i].SKUcode, productsData[i].name,productsData[i].brand.name,productsData[i].family.name,""+productsData[i].stock,"" + productsData[i].availability.ToString()
                });
            }
            Cursor.Current = Cursors.Arrow;
        }
       
        private void btnAddProduct_Click(object sender, EventArgs e)
        {

            AddProductForm addProduct = new AddProductForm();
            if (addProduct.ShowDialog() == DialogResult.OK)
            {
                addProduct.ShowDialog();
                updateDataGridView();
            }
            updateDataGridView();

        }

        private void btnUpdateProduct_Click(object sender, EventArgs e)
        {
            UpdateProductForm updateForm = new UpdateProductForm();
            if (updateForm.ShowDialog()== DialogResult.OK)
            {
                

            }
            updateDataGridView();
        }

        public void componentsState(State s)
        {
            /*switch (s)
            {
                case State.Start:
                    txtProduct.Enabled = true;
                    btnSearch.Enabled = true;
                    btnAddProduct.Enabled = true;
                    btnUpdateProduct.Enabled = false;
                    btnDeleteProduct.Enabled = false;
                    dgvProducts.Enabled = true;
                    cleanForm();
                    break;
                case State.ProductSelected:
                    txtProduct.Enabled = true;
                    btnSearch.Enabled = true;
                    btnAddProduct.Enabled = true;
                    btnUpdateProduct.Enabled = true;
                    btnDeleteProduct.Enabled = true;
                    dgvProducts.Enabled = true;
                    break;
              
            }*/
        }

        public void cleanForm()
        {
            txtProduct.Text = "";
        }

        private void btnDeleteProduct_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Se ha eliminado el producto seleccionado");
            updateDataGridView();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                String skucodeP = txtProduct.Text;
                //Selecciona la fila del dgv donde se encuentra el producto
            }
            catch
            {
                MessageBox.Show("La información no es correcta");
            }

        }
        View.MainWindow refParent;
        public void SetParent(View.MainWindow form)
        {
            refParent = form;
        }

        private void dgvProducts_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView dgv = sender as DataGridView;
            if (dgv == null)
                return;

            if (dgv.CurrentRow.Selected)
            {
                //componentsState(State.ProductSelected);
                p = (Product)dgvProducts.CurrentRow.DataBoundItem;
            }

        }
    }
}
