using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using View.MateWSLocal;
namespace View
{
    public partial class RefundForm : Form
    {
        HistorySaleForm refParent;
        private DBControllerWSClient serviceDA;
        private BindingList<refund> devoluciones;
        private sale currentSale;
        public RefundForm()
        {
            InitializeComponent();
            txtTotal.Text = "0";
        }

        internal void RefreshTotal()
        {
            double total = 0;
            for (int i = 0; i < dgvRefundDetail.RowCount - 1; i++)
            {
                total += Double.Parse(dgvRefundDetail.Rows[i].Cells[6].Value.ToString());
            }
            txtTotal.Text = "" + total;

        }
        public void SetParent(HistorySaleForm form)
        {
            refParent = form;
        }


        public sale CurrentSale { get => currentSale; set => currentSale = value; }

        private void RefundForm_Load(object sender, EventArgs e)
        {
            setInformationForm();
        }
        private void setInformationForm()
        {
            userLabelContent.Text = currentSale.employee.name + " " + currentSale.employee.lastName;
            txtSerialCode.Text = currentSale.serialCode.ToString();
            boletaRadioButton.Checked = true;
            txtDniRuc.Text = currentSale.customer.id;
            txtDescripcion.Text = currentSale.customer.descriptionCustomer;
            foreach (saleLane s in currentSale.saleLanes)
            {
                dgvRefundDetail.Rows.Add(new String[] { s.product.SKUcode.ToString(), s.product.name, s.quantity.ToString(), "", "0", s.product.salePrice.ToString(), "0" });
            }
        }

        private void dgvRefundDetail_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvRefundDetail.Columns[e.ColumnIndex].Name == "quantity")
            {              
                if (dgvRefundDetail.CurrentCell != null &&
                    dgvRefundDetail.CurrentCell.Value != null &&
                    Regex.Match(dgvRefundDetail.CurrentCell.Value.ToString(), @"^\d*$").Success)
                {
                    if (Int32.Parse(dgvRefundDetail.CurrentCell.Value.ToString()) > int.Parse(dgvRefundDetail.Rows[e.RowIndex].Cells[2].Value.ToString()))
                    {
                        MessageBox.Show("Insuficiente stock");
                        dgvRefundDetail.CurrentCell.Value = "0";
                    }
                    else
                    {
                        dgvRefundDetail.Rows[e.RowIndex].Cells[6].Value =
                        Int32.Parse(dgvRefundDetail.CurrentCell.Value.ToString()) *
                        Double.Parse(dgvRefundDetail.Rows[e.RowIndex].Cells[5].Value.ToString());

                        RefreshTotal();
                    }             
                }
                else
                {
                    MessageBox.Show("Ingrese una cantidad válida");
                    dgvRefundDetail.CurrentCell.Value = "0";
                }
            }
            
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (txtTotal.Text == "0")
            {
                MessageBox.Show("No hay productos a devolver");
            }
            else
            {
                View.MateWSLocal.refund r = new View.MateWSLocal.refund();
                serviceDA = new View.MateWSLocal.DBControllerWSClient();
                r.state = 1;
                r.totalReturned = float.Parse(txtTotal.Text);
                r.modificationDate = DateTime.Now;
                r.creationDate = DateTime.Now;
                //para el codigo unico 
                devoluciones = new BindingList<refund>(serviceDA.queryAllRefunds());
                String ultimoSerialCode = devoluciones[devoluciones.Count() - 1].idRefound;
                String nuevoSerialCode = "DEV" + (int.Parse(ultimoSerialCode.Substring(3)) + 1).ToString("000");
                r.idRefound = nuevoSerialCode;
                //getSaleData
                sale s = new sale();
                s = serviceDA.querySaleBySerialCode(txtSerialCode.Text);
                r.sale = s;
                //getCustomerData
                customer c = new customer();
                c = serviceDA.queryByIdCustomer(txtDniRuc.Text);
                r.customer = c;
                //para los refoundlanes
                refundLane[] refundlanes;
                int cantDev = 0;
                for (int j = 0; j < dgvRefundDetail.RowCount - 1; j++)
                {
                    if (dgvRefundDetail.Rows[j].Cells[4].Value.ToString() == "0")
                    {
                        continue;
                    }
                    else
                    {
                        cantDev = cantDev + 1;
                    }
                }
                refundlanes = new refundLane[cantDev];
                int indice = 0;
                for (int i = 0; i < dgvRefundDetail.RowCount - 1; i++)
                {
                    if (dgvRefundDetail.Rows[i].Cells[4].Value.ToString() == "0")
                    {
                        continue;
                    }
                    else
                    {

                        refundLane refundlane = new refundLane();
                        refundlane.reason = dgvRefundDetail.Rows[i].Cells[3].Value.ToString();
                        refundlane.quantity = int.Parse(dgvRefundDetail.Rows[i].Cells[4].Value.ToString());
                        product p = new product();
                        p = serviceDA.queryProductBySKUCode(dgvRefundDetail.Rows[i].Cells[0].Value.ToString());
                        refundlane.product = p;
                        refundlane.creationDate = DateTime.Now;
                        refundlane.modificationDate = DateTime.Now;
                        refundlane.subtotal = float.Parse(dgvRefundDetail.Rows[i].Cells[6].Value.ToString());
                        //refundlane.refund = r;
                        //refundlane.idRefundLane = "equis";
                        refundlanes[indice] = refundlane;
                        indice++;
                    }
                }
                r.refundLanes = refundlanes;
                int salio = serviceDA.insertRefund(r);
                if (salio == 1)
                {
                    MessageBox.Show("Se ingresó la devolución correctamentee");
                }
                else
                {
                    MessageBox.Show("Hubo un error");
                }
                ////Cursor.Current = Cursors.Arrow;
                this.Close();
            }           
        }
    }
}