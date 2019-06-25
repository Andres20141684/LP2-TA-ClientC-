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
        public View.MateWSLocal.user currentUser;
        private DBControllerWSClient serviceDA;
        private BindingList<purchase> purchases;
        public PurchaseForm()
        {
            InitializeComponent();
            boletaRadioButton.Checked = true;
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
                //serviceDA = new DBControllerWSClient();
                purchase p = new purchase();
                p.state = 1;
                p.serialCode = txtSerialCode.Text;
                p.totalPurchase = float.Parse(txtTotal.Text);
                //para el supplier
                supplier c = new supplier();
                serviceDA = new DBControllerWSClient();
                c = serviceDA.querySupplierByCode(txtIdProv.Text);
                p.supplier = c;
                //para los purchase lanes
                purchaseLane[] salelanes;
                salelanes = new purchaseLane[dgvPurchaseDetails.RowCount -1];
                for (int i = 0; i < dgvPurchaseDetails.RowCount - 1; i++)
                {
                    purchaseLane purchaselane = new purchaseLane();
                    purchaselane.subtotal = float.Parse(dgvPurchaseDetails.Rows[i].Cells[4].Value.ToString());
                    purchaselane.quantity = int.Parse(dgvPurchaseDetails.Rows[i].Cells[3].Value.ToString());
                    //purchaselane.purchase = p;
                    product pr = new product();
                    pr = serviceDA.queryProductBySKUCode(dgvPurchaseDetails.Rows[i].Cells[0].Value.ToString());
                    purchaselane.product = pr;
                    salelanes[i] = purchaselane;
                }
                p.currency = "Soles";
                p.purchaseLanes = salelanes;
                //Cursor.Current = Cursors.WaitCursor;
                int salio = serviceDA.insertPurchase(p); 
                if (salio == 1)
                {
                    MessageBox.Show("Se ingresó la compra correctamente");
                }
                else
                {
                    MessageBox.Show("¡Hubo un problema!");
                }
                //Cursor.Current = Cursors.Arrow;
                
                this.Close();
            }
            
        }
        private bool filledValues()
        {
            if (txtIdProv.Text == "")
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

        private void UserLabel_Click(object sender, EventArgs e)
        {

        }

        private void historialToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HistoryPurchasesForm history = new HistoryPurchasesForm();
            history.ShowDialog();
        }

        private void PurchaseForm_Load(object sender, EventArgs e)
        {
            serviceDA = new View.MateWSLocal.DBControllerWSClient();
            employee emp = new employee();
            emp = serviceDA.queryEmployeeByUsername(currentUser.user1);
            userLabelContent.Text = emp.name + " " + emp.lastName + " " + emp.secondLastName;
            purchases = new BindingList<purchase>(serviceDA.queryAllPurchase());
            String ultimoSerialCode = purchases[purchases.Count() - 1].serialCode;
            String nuevoSerialCode = "C" + (int.Parse(ultimoSerialCode.Substring(1)) + 1).ToString("000000");
            txtSerialCode.Text = nuevoSerialCode;
        }

        private void pictureSearch_Click(object sender, EventArgs e)
        {
            if (txtIdProv.Text.Length < 8)
            {
                MessageBox.Show("Ingrese un ID de proveedor válido", "Aviso");
            }
            else
            {
                serviceDA = new DBControllerWSClient();
                supplier sup = new supplier();
                sup = serviceDA.querySupplierByCode(txtIdProv.Text);
                if (sup.bankData != null)
                {
                    txtDescripcion.Text = sup.name;
                }
                else
                {
                    MessageBox.Show("Ingrese un proveedor existente");
                }

            }
        }
    }
}
