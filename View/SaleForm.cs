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
    public partial class SaleForm : Form
    {
        int type;
        private DBControllerWSClient serviceDA;
        public int Type { get => type; set => type = value; }

        public SaleForm()
        {
            InitializeComponent();
        }
        
        private void Form2_Load(object sender, EventArgs e)
        {

        }
        View.MainWindow refParent;
        public void SetParent(View.MainWindow form)
        {
            refParent = form;
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddProductSale_Click(object sender, EventArgs e)
        {
            AddProductSale agregarProducto = new AddProductSale();
            agregarProducto.SetParent(this);
            agregarProducto.Show();
        }

        internal void AddProductToSale(DataGridViewRow row)
        {
            if (row != null) {
                dgvSaleDetails.Rows.Add(new String[]
                {
                    ""+row.Cells[0].Value.ToString(),""+row.Cells[1].Value.ToString(), ""+row.Cells[2].Value.ToString(), ""+1,""+(1*Double.Parse(row.Cells[2].Value.ToString()))
                });
                    }
        }

        internal void RefreshTotal()
        {
            double total = 0;
            for (int i = 0; i < dgvSaleDetails.RowCount - 1; i++)
            {
                total += Double.Parse(dgvSaleDetails.Rows[i].Cells[4].Value.ToString());
            }
            txtTotal.Text = "" + total;
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!filledValues())
            {
                //MessageBox.Show("Complete la información");
            }
            else
            {
                //getCustomerData
                sale s = new sale();
                s.totalSale = float.Parse(txtTotal.Text);
                customer c = new customer();
                c = serviceDA.queryByIdCustomer(txtDniRuc.Text);
                s.customer = c;
                saleLane[] salelanes;
                salelanes = new saleLane[dgvSaleDetails.RowCount];
                for (int i = 0; i < dgvSaleDetails.RowCount - 1; i++)
                {
                    saleLane salelane = new saleLane();
                    salelane.subtotal = float.Parse(dgvSaleDetails.Rows[i].Cells[4].Value.ToString());
                    salelane.quantity = int.Parse(dgvSaleDetails.Rows[i].Cells[3].Value.ToString());
                    salelane.sale = s;
                    product p = new product();
                    p = serviceDA.queryProductBySKUCode(dgvSaleDetails.Rows[i].Cells[0].Value.ToString());
                    salelane.product = p;
                    salelanes[i]=salelane;
                    //serviceDA.insertSaleLane();
                }
                s.saleLanes = salelanes ; 
                serviceDA = new DBControllerWSClient();
                Cursor.Current = Cursors.WaitCursor;
                serviceDA.insertSale(s); 
                Cursor.Current = Cursors.Arrow;
                MessageBox.Show("Se ingresó la venta correctamente");
                this.Close();
            }
        }

        private void modificarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //look for transaction
            SearchSaleTransaction searchTransaction = new SearchSaleTransaction();
            if (this.Type == 1)//compras
            {
                searchTransaction.IsRefund = false;
                searchTransaction.Text = "Buscar compra";
            }
            else
            {
                searchTransaction.IsRefund = true;
                searchTransaction.Text = "Buscar venta";
            }
            //searchTransaction.Parent = this;
            searchTransaction.Show();
        }

       
        private void DevolucionToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            SearchSaleTransaction searchTransaction = new SearchSaleTransaction();
            searchTransaction.Text = "Buscar venta";
            searchTransaction.IsRefund = true;
            searchTransaction.Show();
        }
        private bool filledValues()
        {
            if (txtDniRuc.Text == "")
            {
                MessageBox.Show("Complete el DNI o RUC del cliente");
                return false;
            }
            else if (txtDescripcion.Text == "")
            {
                MessageBox.Show("Descripción!");
                return false;
            }

            else if (dgvSaleDetails.RowCount < 1)
            {
                MessageBox.Show("No hay productos suficientes");
                return false;
            }
            else return true;
            

        }
    }
}
