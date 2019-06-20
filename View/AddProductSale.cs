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
        private product productos = new product();
        SaleForm parent;
        public AddProductSale()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
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
            /*
            for (int i = 0; i < 5; i++)
            {
                dgvProducts.Rows.Add(new String[] {
                                    "" +(i+1), "Producto "+(i+1), ""+i*10, ""+i*5
                                    });
            }*/
        }

        public void SetParent(SaleForm form)
        {
            parent = form;
        }

        private void dgvProducts_CellContentClick(object sender, DataGridViewCellEventArgs e)
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
