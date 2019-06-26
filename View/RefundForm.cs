﻿using System;
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
    public partial class RefundForm : Form
    {
        private DBControllerWSClient serviceDA;
        private BindingList<sale> sales;
        private sale currentSale;
        public RefundForm()
        {
            InitializeComponent();
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
            txtDniRuc.Text = currentSale.customer.idCustomer.ToString();
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
                    dgvRefundDetail.CurrentCell.Value.ToString().Trim() != "")
                {
                    dgvRefundDetail.Rows[e.RowIndex].Cells[6].Value =
                        Int32.Parse(dgvRefundDetail.CurrentCell.Value.ToString()) *
                        Double.Parse(dgvRefundDetail.Rows[e.RowIndex].Cells[5].Value.ToString());

                    RefreshTotal();
                }
            }
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {

            View.MateWSLocal.refund r = new View.MateWSLocal.refund();
            serviceDA = new View.MateWSLocal.DBControllerWSClient();
            r.state = 1;
            r.totalReturned = float.Parse(txtTotal.Text);
            r.modificationDate = DateTime.Now;
            r.creationDate = DateTime.Now;
            //para el codigo unico 
            sales = new BindingList<sale>(serviceDA.queryAllSale());
            String ultimoSerialCode = sales[sales.Count() - 1].serialCode;
            String nuevoSerialCode = "D" + (int.Parse(ultimoSerialCode.Substring(1)) + 1).ToString("00000");
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

                refundlanes = new refundLane[cantDev];
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
                        refundlanes[i] = refundlane;
                    }



                }
                r.refundLanes = refundlanes;
                ////Cursor.Current = Cursors.WaitCursor;
                int salio = serviceDA.insertRefund(r);
                if (salio == 1)
                {
                    MessageBox.Show("Se ingresó la devolución correctamentee");
                }
                else
                {
                    MessageBox.Show("Se ingresó la devolución correctamente");
                }
                ////Cursor.Current = Cursors.Arrow;
                this.Close();
            }
        }
    }
}
