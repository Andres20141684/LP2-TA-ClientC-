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

namespace Producto
{
    public enum StateF
    {
        Start, SelectedRow
    }
    public partial class FamilyProductForm : Form
    {

        public class Family { }
        private Family f;
        private View.MateWSLocal.DBControllerWSClient serviceDA;
        private View.MateWSLocal.DBControllerWSClient serviceDAA;
        private BindingList<View.MateWSLocal.family> families;
        private family familia = new family();

        public FamilyProductForm()
        {
            InitializeComponent();
            updateDataGridView();
            f = new Family();            
            dgvFamilies.AutoGenerateColumns = false;
        }
        View.MainWindow refParent;
        void updateDataGridView()
        {
            Cursor.Current = Cursors.WaitCursor;
            dgvFamilies.Rows.Clear();
            serviceDA = new View.MateWSLocal.DBControllerWSClient();
            families = new BindingList<View.MateWSLocal.family>(serviceDA.queryAllFamily());
            for (int i = 0; i < families.Count; i++)
            {
                dgvFamilies.Rows.Add(new String[] {
                ""+families[i].idFamily, families[i].name,families[i].description
                });
            }
            Cursor.Current = Cursors.Arrow;
        }
        public void SetParent(View.MainWindow form)
        {
            refParent = form;
        }
        
        public void cleanForm()
        {
            txtFamily.Text = "";
        }


        private void btnAddFamily_Click(object sender, EventArgs e)
        {
            AddFamilyForm addFamily = new AddFamilyForm();
            addFamily.ShowDialog();
            updateDataGridView();

        }

        private void btnUpdateFamily_Click(object sender, EventArgs e)
        {
            int i = dgvFamilies.CurrentCell.RowIndex;
            if (i >= 0)
            {
                UpdateFamilyForm updateFamily = new UpdateFamilyForm();
                updateFamily.currentFamily = new family();
                updateFamily.currentFamily = families[i];
                updateFamily.ShowDialog();
                updateDataGridView();
            }
            else
            {
                MessageBox.Show("Seleccione una familia");
            }


        }

        private void btnDeleteFamily_Click(object sender, EventArgs e)
        {
            int i = dgvFamilies.CurrentCell.RowIndex;
            if (i >= 0)
            {
                family familia_aux = new family();
                familia_aux = families[i];
                familia_aux.state = 0;
                serviceDA.updateFamily(familia_aux);
                updateDataGridView();
                MessageBox.Show("Se ha eliminado la familia seleccionada");
            }
            else
            {
                MessageBox.Show("Seleccione una familia");
            }
            
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            dgvFamilies.Rows.Clear();
            serviceDAA = new DBControllerWSClient();
            familia = (serviceDAA.queryFamilyByCode(txtFamily.Text));

            dgvFamilies.Rows.Add(new String[] {
                familia.idFamily, familia.name, ""+familia.description
                });

            Cursor.Current = Cursors.Arrow;
        }

        private void doubleClickDgvFamilies(object sender, EventArgs e)
        {
            DataGridView dgv = sender as DataGridView;
            if (dgv == null)
                return;

            if (dgv.CurrentRow.Selected)
            {
                f = (Family)dgvFamilies.CurrentRow.DataBoundItem;
            }
        }
    }
}
