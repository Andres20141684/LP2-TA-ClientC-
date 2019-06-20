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

namespace entregable
{
    public partial class EmployeeForm : Form
    {
        View.MainWindow refParent;
        private DBControllerWSClient serviceDA;
        private BindingList<employee> employees;
        public EmployeeForm()
        {
            InitializeComponent();
        }

        private void btnAddEmployee_Click(object sender, EventArgs e)
        {
            AddEmployeeForm addEmployeeForm = new AddEmployeeForm();
            addEmployeeForm.SetParent(this);
            addEmployeeForm.ShowDialog();
            updateDataGridView();
        }

        private void btnModifyEmployee_Click(object sender, EventArgs e)
        {
            int i = dgvEmployee.CurrentCell.RowIndex;
            if (i >= 0)
            {
                ModifyEmployeeForm modifyEmployeeForm = new ModifyEmployeeForm();
                modifyEmployeeForm.currentEmployee = new employee();
                modifyEmployeeForm.currentEmployee = employees[i];
                modifyEmployeeForm.SetParent(this);
                modifyEmployeeForm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Seleccione un empleado para modificar");
            }
            
        }

        private void btnDeleteEmployee_Click(object sender, EventArgs e)
        {
            MessageBox.Show("El empleado se eliminó satisfactoriamente");
        }

        private void btnSearchEmployee_Click(object sender, EventArgs e)
        {
            MessageBox.Show("SEARCH NOT IMPLEMENTED");
        }

        private void EmployeeForm_Load(object sender, EventArgs e)
        {
            updateDataGridView();
        }
        public void SetParent(View.MainWindow form)
        {
            refParent = form;
        }
        private void txtDNI_TextChanged(object sender, EventArgs e)
        {
            
        }
        private void updateDataGridView()
        {
            Cursor.Current = Cursors.WaitCursor;
            serviceDA = new DBControllerWSClient();
            employees = new BindingList<employee>(serviceDA.queryAllEmployee());
            dgvEmployee.Rows.Clear();
            for (int i = 0; i < employees.Count; i++)
            {
                dgvEmployee.Rows.Add(new String[] {
                ""+employees[i].dni, employees[i].name,employees[i].lastName,employees[i].secondLastName,""+employees[i].phone, employees[i].email,employees[i].role
                });
            }
            Cursor.Current = Cursors.Arrow;
        }
    }
}
