using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using View;
using View.MateWSLocal;
namespace WindowsFormsApp1
{
    public partial class SaleForm : Form
    {
        //public static int numero_estatico = 0;
        private BindingList<sale> sales;
        public View.MateWSLocal.user currentUser;
        public BindingList<int> lista_stock;
        int type;
        private DBControllerWSClient serviceDA;
        public int Type { get => type; set => type = value; }

        public SaleForm()
        {
            InitializeComponent();
            boletaRadioButton.Checked = true;
        }


        private void Form2_Load(object sender, EventArgs e)
        {
            txtDniRuc.Text = "Ingrese DNI o RUC";
            txtDniRuc.ForeColor = Color.Gray;

            Cursor.Current = Cursors.WaitCursor;
            serviceDA = new View.MateWSLocal.DBControllerWSClient();
            employee emp = new employee();
            emp = serviceDA.queryEmployeeByUsername(currentUser.user1);
            userLabelContent.Text = emp.name + " "+ emp.lastName + " "+emp.secondLastName;
            sales = new BindingList<sale>(serviceDA.queryAllSale());
            String ultimoSerialCode = sales[sales.Count() - 1].serialCode;
            String nuevoSerialCode = "V"+(int.Parse(ultimoSerialCode.Substring(1))+1).ToString("000000");
            txtSerialCode.Text = nuevoSerialCode;
            Cursor.Current = Cursors.Arrow;
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

        internal void AddProductToSale(product producto)
        {
            if (producto != null) {
                dgvSaleDetails.Rows.Add(new String[]
                {producto.SKUcode,producto.productDescription, producto.salePrice.ToString(), ""+1,""+(1*producto.salePrice)});
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
                
                View.MateWSLocal.sale s = new View.MateWSLocal.sale();
                s.state = 1;
                s.serialCode = txtSerialCode.Text;
                s.totalSale = float.Parse(txtTotal.Text);
                //getCustomerData
                customer c = new customer();
                //serviceDA = new DBControllerWSClient();
                c = serviceDA.queryByIdCustomer(txtDniRuc.Text);
                s.customer = c;
                //getEmployeeData
                employee empp = new employee();
                empp = serviceDA.queryByIdEmployee(currentUser.id);
                s.employee = empp;

                //para los salelanes
                saleLane[] salelanes;
                salelanes = new saleLane[dgvSaleDetails.RowCount -1];
                for (int i = 0; i < dgvSaleDetails.RowCount - 1; i++)
                {
                    saleLane salelane = new saleLane();
                    salelane.subtotal = float.Parse(dgvSaleDetails.Rows[i].Cells[4].Value.ToString());
                    salelane.quantity = int.Parse(dgvSaleDetails.Rows[i].Cells[3].Value.ToString());
                    //salelane.sale = s;
                    product p = new product();
                    p = serviceDA.queryProductBySKUCode(dgvSaleDetails.Rows[i].Cells[0].Value.ToString());
                    salelane.product = p;
                    salelanes[i] = salelane;
                    
                }
                s.saleLanes = salelanes ; 
                ////Cursor.Current = Cursors.WaitCursor;
                int salio = serviceDA.insertSale(s);
                if (salio == 1)
                {
                    MessageBox.Show("Se ingresó la venta correctamente");
                }
                else
                {
                    MessageBox.Show("¡Hubo un problema!");
                }
                ////Cursor.Current = Cursors.Arrow;
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

        private void historialToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HistorySaleForm history = new HistorySaleForm();
            history.ShowDialog();
        }

        private void pictureSearch_Click(object sender, EventArgs e)
        {
            if (txtDniRuc.Text.Length < 8)
            {
                MessageBox.Show("Ingrese un DNI o RUC válido", "Aviso");
            }
            else
            {
                serviceDA = new DBControllerWSClient();
                customer cliente = new customer();
                cliente = serviceDA.queryByIdCustomer(txtDniRuc.Text);
                if (cliente.email != null)
                {
                    txtDescripcion.Text = cliente.descriptionCustomer;
                }
                else
                {
                    MessageBox.Show("Ingrese un clinete existente");
                }

            }
        }



        /*
        private void dgvSaleDetails_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            if (_stock < int.Parse(dgvSaleDetails.Rows[0].Cells[3].Value.ToString()))
            {
                MessageBox.Show("No hay suficiente stock para ese producto");
                e.Cancel = true;
            }
            /*
             for (int i = 0; i < dgvSaleDetails.RowCount - 1; i++)
            {
                int cant = int.Parse(dgvSaleDetails.Rows[i].Cells[3].Value.ToString());
                if (_stock >= )

                int cant = int.Parse(dgvSaleDetails.Rows[i].Cells[3].Value.ToString());
                float pu = float.Parse(dgvSaleDetails.Rows[i].Cells[2].Value.ToString());
                dgvSaleDetails.Rows[i].Cells[4].Value.ToString() = cant * pu;
                
                //salelane.sale = s;
                product p = new product();
                p = serviceDA.queryProductBySKUCode(dgvSaleDetails.Rows[i].Cells[0].Value.ToString());
                salelane.product = p;
                salelanes[i] = salelane;

            }
             
        }*/

        private void dgvSaleDetails_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvSaleDetails.Columns[e.ColumnIndex].Name == "quantity")
            {
                if (dgvSaleDetails.CurrentCell != null &&
                    dgvSaleDetails.CurrentCell.Value != null &&
                    dgvSaleDetails.CurrentCell.Value.ToString().Trim() != "")
                {
                    /*
                     if 
                     */
                    dgvSaleDetails.Rows[e.RowIndex].Cells[4].Value =
                        Int32.Parse(dgvSaleDetails.CurrentCell.Value.ToString()) *
                        Double.Parse(dgvSaleDetails.Rows[e.RowIndex].Cells[2].Value.ToString());

                    RefreshTotal();
                }
            }
        }


        private void txtDniRuc_Enter(object sender, EventArgs e)
        {
            txtDniRuc.Text = "";
            txtDniRuc.ForeColor = Color.Black;

        }
    }
}
