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
namespace View
{
    public partial class AddProductPurchase : Form
    {
        private DBControllerWSClient serviceDA;
        private product productos = new product();
        PurchaseForm parent;
        public AddProductPurchase()
        {
            InitializeComponent();
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            dgvProducts.Rows.Clear();
            serviceDA = new DBControllerWSClient();
            String skucodee = txtProductName.Text;
            productos = (serviceDA.queryProductBySKUCode(skucodee));

            dgvProducts.Rows.Add(new String[] {
                ""+productos.SKUcode, productos.name,""+productos.salePrice,""+productos.stock
                });

            Cursor.Current = Cursors.Arrow;

        }
        public void SetParent(PurchaseForm form)
        {
            parent = form;
        }

        private void DgvProducts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int selectedRow = e.RowIndex;
            if (selectedRow >= 0)
            {
                //int productId = Int32.Parse(dgvProducts.Rows[selectedRow]
                //.Cells[0].Value.ToString());
                //Product product = SalesController.QueryProductById(productId);

                parent.AddProductToPurchase(dgvProducts.Rows[selectedRow]);
                parent.RefreshTotal();
                this.Close();
            }
        }
    }
}
