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
    public partial class HistoryPurchasesForm : Form
    {
        private DBControllerWSClient serviceDA;
        private BindingList<purchase> purchases;
        public HistoryPurchasesForm()
        {
            InitializeComponent();
        }

        private void HistoryPurchasesForm_Load(object sender, EventArgs e)
        {
            updateDataGridView();
        }
        private void updateDataGridView()
        {
            
                Cursor.Current = Cursors.WaitCursor;
                dgvPurchases.Rows.Clear();
                serviceDA = new DBControllerWSClient();
                purchases = new BindingList<purchase>(serviceDA.queryAllPurchase());
                for (int i = 0; i < purchases.Count; i++)
                {
                    dgvPurchases.Rows.Add(new String[] {
                ""+purchases[i].serialCode,""+purchases[i].totalPurchase,""+purchases[i].supplier.name,""+purchases[i].creationDate
                });
                }
                Cursor.Current = Cursors.Arrow;
            
                
        }
        private bool filledValues()
        {
            if (txtSerialCode.Text == "")
            {
                MessageBox.Show("Ingrese el Codigo Serial de un Producto");
                return false;
            } 
            

            return true;
        }

        private void dgvPurchases_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtRUC_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnSearchEmployee_Click(object sender, EventArgs e)
        {

        }
    }
}
