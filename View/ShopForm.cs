using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using View;
using View.MateWSLocal;

namespace ShopsForm
{
    public partial class ShopForm : Form
    {
        private BindingList<View.MateWSLocal.premises> shopsData;
        private View.MateWSLocal.DBControllerWSClient serviceDA;
        private View.MateWSLocal.DBControllerWSClient serviceDAA;
        private BindingList<View.MateWSLocal.premises> locales;
        public ShopForm()
        {
            InitializeComponent();
            updateDataGridView();
        }
        View.MainWindow refParent;
        void updateDataGridView()
        {
            Cursor.Current = Cursors.WaitCursor;
            dgvLocal.Rows.Clear();
            serviceDA = new View.MateWSLocal.DBControllerWSClient();
            shopsData = new BindingList<View.MateWSLocal.premises>(serviceDA.queryAllPremises());
            for (int i = 0; i < shopsData.Count; i++)
            {
                dgvLocal.Rows.Add(new String[]{
                    shopsData[i].id.ToString(), shopsData[i].description, shopsData[i].address
                });
            }
            locales = new BindingList<premises>(serviceDA.queryAllPremises());
            cboLocal.Items.Clear();
            for (int i = 0; i < locales.Count; i++)
            {
                cboLocal.Items.Add("" + locales[i].description);
            }
            Cursor.Current = Cursors.Arrow;
        }
        public void SetParent(View.MainWindow form)
        {
            refParent = form;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAddLocal_Click(object sender, EventArgs e)
        {
            Agregar_Local addLocal = new Agregar_Local();
            if (addLocal.ShowDialog() == DialogResult.OK)
            {
                //addLocal.SetParent(this);
                addLocal.ShowDialog();
                //updateDataGridView();
            }
            updateDataGridView();

        }

        private void btnModLocal_Click(object sender, EventArgs e)
        {
            int i = dgvLocal.CurrentCell.RowIndex;
            if (i >= 0)
            {
                Modificar_Local modLocal = new Modificar_Local();
                modLocal.currentLocal = new premises();
                premises l1 = new premises();
                serviceDAA = new View.MateWSLocal.DBControllerWSClient();
                l1 = serviceDAA.queryPremisesByDescription(dgvLocal.Rows[i].Cells[1].Value.ToString());
                modLocal.currentLocal = l1;
                modLocal.ShowDialog();
                updateDataGridView();
            }
            else
            {
                MessageBox.Show("Seleccione un local");
            }
        }


        private void ShopForm_Load(object sender, EventArgs e)
        {
            //Load, cargamos el grid
            /*
            serviceDA = new DBControllerWSClient();
            locales = new BindingList<premises>(serviceDA.queryAllPremises());
            cboLocal.ResetText();
            for (int i = 0; i < locales.Count; i++)
            {
                cboLocal.Items.Add("" + locales[i].description);
            }*/

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void cboLocal_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            String desc = cboLocal.Text;
            premises loc = new premises();
            loc = serviceDA.queryPremisesByDescription(desc);

            dgvLocal.Rows.Clear();

            dgvLocal.Rows.Add(new String[] {
                ""+loc.id,loc.description,loc.address
                });

            Cursor.Current = Cursors.Arrow;
        }
    }
}