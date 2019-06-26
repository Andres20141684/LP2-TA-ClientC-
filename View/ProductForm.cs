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
        private product p;
        private BindingList<View.MateWSLocal.product> productsData;
        private View.MateWSLocal.DBControllerWSClient serviceDA = new View.MateWSLocal.DBControllerWSClient();
        private DBControllerWSClient serviceDAA = new DBControllerWSClient();
        public FrmProduct()
        {
            InitializeComponent();
            updateDataGridView();
            
            //serviceDAA = new DBControllerWSClient();
        }

        void updateDataGridView()
        {
            Cursor.Current = Cursors.WaitCursor;
            dgvProducts.Rows.Clear();
            //serviceDA = new View.MateWSLocal.DBControllerWSClient();
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
            int i = dgvProducts.CurrentCell.RowIndex;
            if (i >= 0)
            {
                UpdateProductForm updateForm1 = new UpdateProductForm();
                updateForm1.currentProduct = new product();
                product e1 = new product();
                e1 = serviceDAA.queryProductBySKUCode(dgvProducts.Rows[i].Cells[0].Value.ToString());
                updateForm1.currentProduct = e1;
                updateForm1.ShowDialog();
                updateDataGridView();
            }
            else
            {
                MessageBox.Show("Seleccione un producto");
            }
        }

        private void btnDeleteProduct_Click(object sender, EventArgs e)
        {
            int i = dgvProducts.CurrentCell.RowIndex;
            if (i >= 0)
            {
                product product_aux = new product();
                product_aux = productsData[i];
                product_aux.state = 0;
                serviceDA.updateProduct(product_aux);
                updateDataGridView();
                MessageBox.Show("Se ha eliminado el producto seleccionado");
            }
            else
            {
                MessageBox.Show("Seleccione un producto");
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                serviceDAA = new DBControllerWSClient();
                p = serviceDAA.queryProductBySKUCode(txtProduct.Text);

                if (p.name != null)
                {
                    UpdateProductForm updateForm1 = new UpdateProductForm();
                    updateForm1.currentProduct = new product();

                    updateForm1.currentProduct = p;
                    updateForm1.SetParent(this);
                    updateForm1.ShowDialog();
                    updateDataGridView();

                }
                else
                {
                    MessageBox.Show("No existe el producto");
                }
            }
            catch
            {
                MessageBox.Show("No existe producto con ese elemento SKU no es correcta");
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
                p = (product)dgvProducts.CurrentRow.DataBoundItem;
            }

        }

        private void txtProduct_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
