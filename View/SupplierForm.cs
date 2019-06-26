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
        private View.MateWSLocal.DBControllerWSClient serviceDAA;
        private supplier proveedor = new supplier();
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
                ""+suppliers[i].RUC, suppliers[i].name,suppliers[i].address,suppliers[i].bankData,""+suppliers[i].contactEmail,"" + suppliers[i].contactPhone
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
                supplier e1 = new supplier();
                serviceDAA = new DBControllerWSClient();
                e1 = serviceDAA.querySupplierByCode(dgvSupplier.Rows[i].Cells[0].Value.ToString());
                modifySup.currentSupplier = e1;
                modifySup.ShowDialog();
                updateDataGridView();
            }
            else
            {
                MessageBox.Show("Seleccione un proveedor");
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

           
                Cursor.Current = Cursors.WaitCursor;
                //dgvSupplier.Rows.Clear();
                serviceDAA = new DBControllerWSClient();
                proveedor = (serviceDAA.querySupplierByCode(txtRUC.Text));
                Cursor.Current = Cursors.Arrow;

                if (proveedor.name != null)
                {
                    ModifySupplierForm modifySup = new ModifySupplierForm();
                    modifySup.currentSupplier = new supplier();
                    //supplier e1 = new supplier();
                    serviceDAA = new DBControllerWSClient();
                    //e1 = serviceDAA.querySupplierByCode(dgvSupplier.Rows[i].Cells[0].Value.ToString());
                    modifySup.currentSupplier = proveedor;
                    modifySup.SetParent(this);
                    modifySup.ShowDialog();
                    updateDataGridView();
                }
                else
                {
                    MessageBox.Show("Proveedor no encontrado");
                }
                //dgvSupplier.Rows.Add(new String[] {
                //    proveedor.RUC, proveedor.name,proveedor.address,proveedor.bankData,proveedor.contactEmail,""+proveedor.contactPhone
                //    });



            
        }
    }
}
