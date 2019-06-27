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
    public partial class HistorySaleForm : Form
    {
        private DBControllerWSClient serviceDA;
        private BindingList<sale> sales;
        private sale s;
        private sale venta = new sale();

        public HistorySaleForm()
        {
            InitializeComponent();
        }

        private void HistorySaleForm_Load(object sender, EventArgs e)
        {
            updateDataGridView();
        }
        private void updateDataGridView()
        {
            Cursor.Current = Cursors.WaitCursor;
            dgvSales.Rows.Clear();
            serviceDA = new DBControllerWSClient();
            sales = new BindingList<sale>(serviceDA.queryAllSale());
            for (int i = 0; i < sales.Count; i++)
            {
                dgvSales.Rows.Add(new String[] {
            ""+sales[i].serialCode,""+sales[i].totalSale,""+sales[i].customer.descriptionCustomer,""+sales[i].creationDate
            });
            }
            Cursor.Current = Cursors.Arrow;
        }

        private void BtnSearchEmployee_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            serviceDA = new DBControllerWSClient();
            venta = (serviceDA.querySaleBySerialCode(txtSerialCode.Text));
            Cursor.Current = Cursors.Arrow;
            if (venta.serialCode != null)
            {
                RefundForm modClient = new RefundForm();
                modClient.CurrentSale = new sale();
                serviceDA = new DBControllerWSClient();
                modClient.CurrentSale = venta;
                modClient.SetParent(this);
                modClient.ShowDialog();
                updateDataGridView();

            }
            else
            {
                MessageBox.Show("Cliente no encontrado");
            }



            /*

            if (!filledValues())
            {
                //MessageBox.Show("Complete la información");
            }
            else
            {
                Cursor.Current = Cursors.WaitCursor;
                serviceDA = new DBControllerWSClient();
                sale sale = (serviceDA.querySaleBySerialCode(txtSerialCode.Text));
                Cursor.Current = Cursors.Arrow;
                if (sale.totalSale != null)
                {
                    RefundForm refForm = new RefundForm();
                    refForm.CurrentSale = new sale();
                    serviceDA = new DBControllerWSClient();
                    refForm.CurrentSale = sale;
                    refForm.SetParent(this);
                    refForm.ShowDialog();
                    updateDataGridView();
                }
                else
                {
                    MessageBox.Show("Cliente no encontrado");
                }

            }*/
        }

        private bool filledValues()
        {
            if (txtSerialCode.Text == "")
            {
                MessageBox.Show("Ingrese el Codigo Serial de una venta");
                return false;
            }
            else
            {
                if (txtSerialCode.TextLength != 7){
                    MessageBox.Show("Ingrese el Codigo Serial de 7 digitos de longitud");
                    return false;
                }
            }
            return true;
        }


        private void dgvSales_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView dgv = sender as DataGridView;
            if (dgv == null)
                return;

            if (dgv.CurrentRow.Selected)
            {
                //componentsState(State.ProductSelected);
                RefundForm refund = new RefundForm();
                refund.CurrentSale = sales[dgv.CurrentRow.Index];
                refund.ShowDialog();
            }
        }
    }
}
