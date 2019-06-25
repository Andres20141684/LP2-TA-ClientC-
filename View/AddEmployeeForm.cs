using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
            if (txtEmployeeDNI.Text == "" || txtEmployeeDNI.Text.Length<8)
            {
                MessageBox.Show("Ingrese un DNI válido");
                return false;
            }
            if (txtEmployeeDNI.Text.Length == 8)
            {
                int result = 0;
                if (!int.TryParse(txtEmployeeDNI.Text, out result))
                {
                    MessageBox.Show("Ha ingresado caracteres no numericos en el campo DNI, porfavor ingresar 8 dígitos ");
                    return false;
                }
            }
             if (txtEmployeeName.Text == "" || txtEmployeeName.Text.Length<2)
            {
                MessageBox.Show("Ingrese un nombre válido");
                return false;
            }
             if (txtEmployeeFirstLastName.Text == "" || txtEmployeeFirstLastName.Text.Length<2)
            {
                MessageBox.Show("Ingrese un apellido paterno válido");
                return false;
            }
             if (txtEmployeeSecondLastName.Text == "" || txtEmployeeSecondLastName.Text.Length<2)
            {
                MessageBox.Show("Ingrese un apellido materno válido");
                return false;
            }
             if (txtEmployeePhone.Text == "" || txtEmployeePhone.Text.Length<3)
            {
                MessageBox.Show("Ingrese un teléfono válido");
                return false;
            }
             if (txtEmployeePhone.Text.Length >= 3)
            {
                int result = 0;
                if (!Regex.Match(txtEmployeePhone.Text, @"([0-9]{3,})").Success)
                {
                    MessageBox.Show("Ha ingresado caracteres no numericos en el campo Telefono, ingrese de 3 a 15 digitos");
                    return false;
                }
            }
             if (txtEmployeeEmail.Text == "" || !txtEmployeeEmail.Text.Contains("@"))
            {
                MessageBox.Show("Ingrese un correo válido");
                return false;
            }
             if (dtpEmployeeBorn.Value.Date > DateTime.Now)
            {
                MessageBox.Show("Ingrese una fecha válida");
                return false;
            }
             if (dtpEmployeeStartDate.Value.Date > dtpEmployeeEndDate.Value.Date)
            {
                MessageBox.Show("Ingrese fechas de contratos válidas");
                return false;
            }
             if (cbArea.Text == "")
            {
                MessageBox.Show("Ingrese el área del empleado");
                return false;
            }
             if (cbRole.Text == "") 
            {
                MessageBox.Show("Ingrese el cargo del empleado");
                return false;
            }
            

            return true;
        }
    }
}
