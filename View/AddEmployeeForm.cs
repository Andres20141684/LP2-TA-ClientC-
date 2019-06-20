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
    public partial class AddEmployeeForm : Form
    {
        EmployeeForm refParent;
        private DBControllerWSClient serviceDA;
        private BindingList<area> areas;
        public AddEmployeeForm()
        {
            InitializeComponent();
            cbActive.Checked = true;
        }

        public void SetParent(EmployeeForm form)
        {
            refParent = form;
        }

        private void btnSaveEmployee_Click(object sender, EventArgs e)
        {
            if (filledValues())
            {
                Cursor.Current = Cursors.WaitCursor;
                serviceDA = new DBControllerWSClient();
                employee emp = new employee();
                emp.dni = txtEmployeeDNI.Text;
                emp.name = txtEmployeeName.Text;
                emp.lastName = txtEmployeeFirstLastName.Text;
                emp.secondLastName = txtEmployeeSecondLastName.Text;
                emp.phone = txtEmployeePhone.Text;
                emp.email = txtEmployeeEmail.Text;
                emp.birthdate = dtpEmployeeBorn.Value.Date;
                emp.contractStarDate = dtpEmployeeStartDate.Value.Date;
                emp.contractEndDate = dtpEmployeeEndDate.Value.Date;
                emp.area = areas[cbArea.SelectedIndex];
                emp.role = cbRole.Text;
                serviceDA.insertEmployee(emp);
                Cursor.Current = Cursors.Arrow;
                MessageBox.Show("El empleado se agregó satisfactoriamente.");
                this.Close();
            }
        }

        private void AddEmployeeForm_Load(object sender, EventArgs e)
        {
            serviceDA = new DBControllerWSClient();
            areas = new BindingList<area>( serviceDA.queryAllArea());
            for (int i=0; i<areas.Count; i++)
            {
                cbArea.Items.Add(areas[i].description);
            }
        }
        private bool filledValues()
        {
            if (txtEmployeeDNI.Text == "")
            {
                MessageBox.Show("Ingrese el DNI del empleado");
                return false;
            }
            else if (txtEmployeeName.Text == "")
            {
                MessageBox.Show("Ingrese el nombre del empleado");
                return false;
            }
            else if (txtEmployeeFirstLastName.Text == "")
            {
                MessageBox.Show("Ingrese el apellido paterno del empleado");
                return false;
            }
            else if (txtEmployeeSecondLastName.Text == "")
            {
                MessageBox.Show("Ingrese el apellido materno del empleado");
                return false;
            }
            else if (txtEmployeePhone.Text == "")
            {
                MessageBox.Show("Ingrese el teléfono del empleado");
                return false;
            }
            else if (txtEmployeeEmail.Text == "")
            {
                MessageBox.Show("Ingrese el correo del empleado");
                return false;
            }
            else if (dtpEmployeeBorn.Value.Date > DateTime.Now)
            {
                MessageBox.Show("Ingrese una fecha válida");
                return false;
            }
            else if (dtpEmployeeStartDate.Value.Date > dtpEmployeeEndDate.Value.Date)
            {
                MessageBox.Show("Ingrese fechas de contratos válidas");
                return false;
            }
            else if (cbArea.Text == "--Seleccione--")
            {
                MessageBox.Show("Ingrese el área del empleado");
                return false;
            }
            else if (cbRole.Text == "--Seleccione--") 
            {
                MessageBox.Show("Ingrese el cargo del empleado");
                return false;
            }
            

            return true;
        }
    }
}
