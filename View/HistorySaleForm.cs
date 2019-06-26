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

        }

        private void dgvSales_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView dgv = sender as DataGridView;
            if (dgv == null)
                return;

            if (dgv.CurrentRow.Selected)
            {
                //componentsState(State.ProductSelected);
                //RefundForm refund = new RefundForm();
                //refund.CurrentSale = sales[dgv.CurrentRow.Index];
                //refund.ShowDialog();
            }
        }
    }
}
