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
        private DBControllerWSClient serviceDAA;
        private BindingList<employee> employees = new BindingList<employee>();
        private employee empleado = new employee();
        private int nEmployee;
        public EmployeeForm()
        {
            InitializeComponent();
            updateDataGridView();
            dgvEmployee.AutoGenerateColumns = false;
            
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
                employee e1 = new employee();
                serviceDAA = new DBControllerWSClient();
                e1 =serviceDAA.queryEmployeeByDNI(dgvEmployee.Rows[i].Cells[0].Value.ToString());
                modifyEmployeeForm.currentEmployee = e1;
                modifyEmployeeForm.SetParent(this);
                modifyEmployeeForm.ShowDialog();
                updateDataGridView();
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
            if (!filledValues())
            {
                //MessageBox.Show("Complete la información");
            }
            else
            {
                Cursor.Current = Cursors.WaitCursor;
                //dgvEmployee.Rows.Clear();   
                serviceDAA = new DBControllerWSClient();
                empleado = (serviceDAA.queryEmployeeByDNI(txtDNI.Text));
                Cursor.Current = Cursors.Arrow;
                if (empleado.idEmployee != null)
                {

                ModifyEmployeeForm modifyEmployeeForm = new ModifyEmployeeForm();
                modifyEmployeeForm.currentEmployee = new employee();
                //employee e1 = new employee();
                serviceDAA = new DBControllerWSClient();
                //e1 = serviceDAA.queryEmployeeByDNI(dgvEmployee.Rows[i].Cells[0].Value.ToString());
                modifyEmployeeForm.currentEmployee = empleado;
                modifyEmployeeForm.SetParent(this);
                modifyEmployeeForm.ShowDialog();
                updateDataGridView();
                }
                else
                {
                    MessageBox.Show("Empleado no encontrado");
                }


                //dgvEmployee.Rows.Add(new String[] {   
                //empleado.dni,empleado.name,empleado.lastName,empleado.phone,empleado.email,empleado.role });



                

            }
            


            

        }
        private bool filledValues()
        {
            if (txtDNI.Text.Length != 8)
            {
                MessageBox.Show("Ingrese un DNI de 8 digitos numericos");
                return false;
            }
            if (txtDNI.Text.Length == 8)
            {
                int result = 0;
                if (!int.TryParse(txtDNI.Text, out result))
                {
                    MessageBox.Show("Ha ingresado caracteres no numericos en el campo DNI, ingrese 8 digitos numericos");
                    return false;
                }
            }
            return true;
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
            dgvEmployee.Rows.Clear();
            serviceDA = new DBControllerWSClient();
            employees = new BindingList<employee>(serviceDA.queryAllEmployee());
            
            for (int i = 0; i < employees.Count; i++)
            {
                dgvEmployee.Rows.Add(new String[] {
                ""+employees[i].dni, employees[i].name,employees[i].lastName,employees[i].phone, employees[i].email,employees[i].role
                });
            }
            Cursor.Current = Cursors.Arrow;
        }
    }
}
