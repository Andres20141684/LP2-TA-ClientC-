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
    public partial class PurchaseForm : Form
    {
        private DBControllerWSClient serviceDA;
        public PurchaseForm()
        {
            InitializeComponent();
        }

        private void modificarToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void SalirToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ModificarToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            SearchPurchaseForm searcher = new SearchPurchaseForm();
            searcher.Show();
        }

        private void AddProductSale_Click(object sender, EventArgs e)
        {
            AddProductPurchase compraForm = new AddProductPurchase();
            compraForm.SetParent(this);
            compraForm.ShowDialog();


        }
        internal void RefreshTotal()
        {
            double total = 0;
            for (int i = 0; i < dgvPurchaseDetails.RowCount - 1; i++)
            {
                total += Double.Parse(dgvPurchaseDetails.Rows[i].Cells[4].Value.ToString());
            }
            txtTotal.Text = "" + total;

        }
        internal void AddProductToPurchase(DataGridViewRow row)
        {
            if (row != null)
            {
                dgvPurchaseDetails.Rows.Add(new String[]
                {
                    ""+row.Cells[0].Value.ToString(),""+row.Cells[1].Value.ToString(), ""+row.Cells[2].Value.ToString(), ""+1,""+(1*Double.Parse(row.Cells[2].Value.ToString()))
                });
            }
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (!filledValues())
            {
                //MessageBox.Show("Complete la información");
            }
            else
            {
                //getCustomerData
                purchase s = new purchase();
                s.totalPurchase = float.Parse(txtTotal.Text);
                supplier c = new supplier();
                c = serviceDA.querySupplierByCode(txtRucDni.Text);
                s.supplier = c;
                purchaseLane[] salelanes;
                salelanes = new purchaseLane[dgvPurchaseDetails.RowCount];
                for (int i = 0; i < dgvPurchaseDetails.RowCount - 1; i++)
                {
                    purchaseLane salelane = new purchaseLane();
                    salelane.subtotal = float.Parse(dgvPurchaseDetails.Rows[i].Cells[4].Value.ToString());
                    salelane.quantity = int.Parse(dgvPurchaseDetails.Rows[i].Cells[3].Value.ToString());
                    salelane.purchase = s;
                    product p = new product();
                    p = serviceDA.queryProductBySKUCode(dgvPurchaseDetails.Rows[i].Cells[0].Value.ToString());
                    salelane.product = p;
                    salelanes[i] = salelane;
                    //serviceDA.insertSaleLane();

                }

                s.purchaseLanes = salelanes;

                serviceDA = new DBControllerWSClient();
                Cursor.Current = Cursors.WaitCursor;
                //serviceDA.insertPurchase(s); //NO INSERTAMOS VENTA PORQUE AÚN NO CONTAMOS CON INSERT_SALE_LANE()
                Cursor.Current = Cursors.Arrow;
                MessageBox.Show("Insert_Sale_lane not implemented");
                this.Close();
            }
            MessageBox.Show("Se ha generado correctamente");
            this.Close();
        }
        private bool filledValues()
        {
            if (txtRucDni.Text == "")
            {
                MessageBox.Show("Complete el DNI o RUC del cliente");
                return false;
            }
            else if (txtDescripcion.Text == "")
            {
                MessageBox.Show("Descripción!");
                return false;
            }

            else if (dgvPurchaseDetails.RowCount < 1)
            {
                MessageBox.Show("No hay productos suficientes");
                return false;
            }
            else return true;


        }
    }
}
