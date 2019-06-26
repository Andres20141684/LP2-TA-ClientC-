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

namespace WindowsFormsApp1
{
    public partial class AddProductSale : Form
    {
        private DBControllerWSClient serviceDA;
        private product producto = new product();
        private warehouseDetail detalleProducto = new warehouseDetail();
        SaleForm parent;
        public AddProductSale()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
<<<<<<< HEAD
            if (txtProductName.Text == "")
            {
                MessageBox.Show("Ingrese un código");
=======
            Cursor.Current = Cursors.WaitCursor;
            dgvProducts.Rows.Clear();
            serviceDA = new DBControllerWSClient();
            String skucodee = txtProductName.Text;
            int idAlmacenn = int.Parse(txtWarehouseId.Text);
            detalleProducto = (serviceDA.queryWarehousedetailBySKUandWarehouseID(skucodee, idAlmacenn));
            producto = serviceDA.queryProductBySKUCode(skucodee);
          
            dgvProducts.Rows.Add(new String[] {
                ""+producto.SKUcode, producto.name,""+producto.salePrice,""+detalleProducto.quantity
                });
            //parent._stock = detalleProducto.quantity;
>>>>>>> 41e49c88108089832ead2ed603f8683e50c86187

            }
            else
            {
                Cursor.Current = Cursors.WaitCursor;
                dgvProducts.Rows.Clear();
                serviceDA = new DBControllerWSClient();
                String skucodee = txtProductName.Text;
                int idAlmacenn = int.Parse(txtWarehouseId.Text);
                detalleProducto = (serviceDA.queryWarehousedetailBySKUandWarehouseID(skucodee, idAlmacenn));
                producto = serviceDA.queryProductBySKUCode(skucodee);
                dgvProducts.Rows.Add(new String[] {
                ""+producto.SKUcode, producto.name,""+producto.salePrice,""+detalleProducto.quantity
                });
                parent._stock = detalleProducto.quantity;
                Cursor.Current = Cursors.Arrow;
            }
            
        }

        public void SetParent(SaleForm form)
        {
            parent = form;
        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void DgvProducts_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            int selectedRow = e.RowIndex;
            if (selectedRow >= 0)
            {
                //int productId = Int32.Parse(dgvProducts.Rows[selectedRow]
                //.Cells[0].Value.ToString());
                //Product product = SalesController.QueryProductById(productId);

                parent.AddProductToSale(dgvProducts.Rows[selectedRow]);
                parent.RefreshTotal();

                this.Close();
            }
        }
    }
}
