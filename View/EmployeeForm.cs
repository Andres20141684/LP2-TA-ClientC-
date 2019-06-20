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
            ModifyEmployeeForm modifyEmployeeForm = new ModifyEmployeeForm();
            modifyEmployeeForm.SetParent(this);
            modifyEmployeeForm.ShowDialog();
        }

        private void btnDeleteEmployee_Click(object sender, EventArgs e)
        {
            MessageBox.Show("El empleado se eliminó satisfactoriamente");
        }

        private void btnSearchEmployee_Click(object sender, EventArgs e)
        {
            if (txtDNI.Text == "")
            {
                MessageBox.Show("Inserte un DNI");
            }
            else
            {
                for (int i = 0; i < dgvEmployee.RowCount; i++)
                {
                    if (dgvEmployee.Rows[i].Cells[0].Value.ToString() != txtDNI.ToString())
                    {
                        dgvEmployee.Rows.RemoveAt(i);
                    }
                }
            }
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
            if (txtDNI.Text == "")
            {
                dgvEmployee.Rows.Clear();
                dgvEmployee.Rows.Add(new String[]
                {
                "15348265","Jorge","Diaz","Suarez","52347895","micorreo@gmail.com","Jefe"
                    });
                dgvEmployee.Rows.Add(new String[]
                {
                "46523576","José","Perez","Campos","4123578","uncorreo@gmail.com","Vendedor"
                });
                dgvEmployee.Rows.Add(new String[]
                {
                "53214786","Roberto","Gomez","Ramos","632514","rgomez@gmail.com","Gerente"
                });
            }
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
