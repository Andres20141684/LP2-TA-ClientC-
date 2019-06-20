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
    public partial class SupplierForm : Form
    {
        private View.MateWSLocal.DBControllerWSClient serviceDA;
        private BindingList<supplier> suppliers;
        public SupplierForm()
        {
            InitializeComponent();
            updateDataGridView();
            
        }
        void updateDataGridView()
        {
            Cursor.Current = Cursors.WaitCursor;
            dgvSupplier.Rows.Clear();
            serviceDA = new DBControllerWSClient();
            suppliers = new BindingList<supplier>(serviceDA.queryAllSupplier());
            for (int i = 0; i < suppliers.Count; i++)
            {
                dgvSupplier.Rows.Add(new String[] {
                ""+suppliers[i].RUC, suppliers[i].name,suppliers[i].address,suppliers[i].bankData,""+suppliers[i].contactPhone,"" + suppliers[i].contactEmail
                });
            }
            Cursor.Current = Cursors.Arrow;
        }
        private void BtnAddEmployee_Click(object sender, EventArgs e)
        {
            AddSupplierForm addSupForm = new AddSupplierForm();
            addSupForm.ShowDialog();
            updateDataGridView();
        }

        private void BtnModifyEmployee_Click(object sender, EventArgs e)
        {
            int i = dgvSupplier.CurrentCell.RowIndex;
            if (i >= 0)
            {
                
                ModifySupplierForm modifySup = new ModifySupplierForm();
                modifySup.currentSupplier = new supplier();
                modifySup.currentSupplier = suppliers[i];
                modifySup.ShowDialog();
                updateDataGridView();
            }
            else
            {
                MessageBox.Show("Seleccione un cliente");
            }

            /*
            ModifySupplierForm modifySupForm = new ModifySupplierForm();
            modifySupForm.ShowDialog();*/
        }

        View.MainWindow refParent;
        public void SetParent(View.MainWindow form)
        {
            refParent = form;
        }
        private void BtnDeleteEmployee_Click(object sender, EventArgs e)
        {
            int i = dgvSupplier.CurrentCell.RowIndex;
            if (i >= 0)
            {
                supplier sup_aux = new supplier();
                sup_aux = suppliers[i];
                sup_aux.state = 0;
                serviceDA.updateSupplier(sup_aux);
                updateDataGridView();
                MessageBox.Show("Se ha eliminado el proveedor seleccionado");
            }
            else
            {
                MessageBox.Show("Seleccione un proveedor");
            }
        }

        private void BtnSearchEmployee_Click(object sender, EventArgs e)
        {
            string searchValue = txtRUC.Text;
            dgvSupplier.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            try
            {
                foreach (DataGridViewRow row in dgvSupplier.Rows)
                {
                    if (row.Cells[0].Value.ToString().Equals(searchValue))
                    {

                        string nombre, direccion, cuenta, telefono, email, estado;
                        nombre = row.Cells[1].Value.ToString();
                        direccion = row.Cells[2].Value.ToString();
                        cuenta = row.Cells[3].Value.ToString();
                        telefono = row.Cells[4].Value.ToString();
                        email = row.Cells[5].Value.ToString();
                        estado = row.Cells[6].Value.ToString();
                        dgvSupplier.Rows.Clear();
                        dgvSupplier.Rows.Add(searchValue, nombre, direccion, cuenta, telefono, email, estado);
                        break;
                    }
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show("No se encontró el proveedor.\nEscriba un RUC apropiado.");
            }        
        }
    }
}
