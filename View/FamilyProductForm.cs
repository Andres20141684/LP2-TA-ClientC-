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
                family e1 = new family();
                serviceDAA = new DBControllerWSClient();
                e1 = serviceDAA.queryFamilyByCode(dgvFamilies.Rows[i].Cells[0].Value.ToString());
                updateFamily.currentFamily = e1;
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
            if (!filledValues())
            {
                //MessageBox.Show("Complete la información");
            }
            else
            {
                Cursor.Current = Cursors.WaitCursor;
               // dgvFamilies.Rows.Clear();
                serviceDAA = new DBControllerWSClient();
                familia = (serviceDAA.queryFamilyByCode(txtFamily.Text));
                if (familia.idFamily != null)
                {
                    //     dgvFamilies.Rows.Add(new String[] {
                    // familia.idFamily, familia.name, ""+familia.description
                    // });
                    UpdateFamilyForm updateFamily = new UpdateFamilyForm();
                    updateFamily.currentFamily = new family();
                    //family e1 = new family();
                    //e1 = serviceDAA.queryFamilyByCode(dgvFamilies.Rows[i].Cells[0].Value.ToString());
                    updateFamily.currentFamily = familia;
                    updateFamily.SetParent(this);
                    updateFamily.ShowDialog();
                    updateDataGridView();
                }
                else
                {
                    MessageBox.Show("Familia de Producto no Encontrada");
                }
                Cursor.Current = Cursors.Arrow;
            }
        }
        private bool filledValues()
        {
            if (txtFamily.Text.Length != 5)
            {
                MessageBox.Show("Ingrese un codigo de Familia de 5 caracteres");
                return false;
            }
            

            return true;
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
