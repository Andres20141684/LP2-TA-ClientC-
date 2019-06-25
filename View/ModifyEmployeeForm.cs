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
    public partial class ModifyEmployeeForm : Form
    {
        EmployeeForm refParent;
        public employee currentEmployee;
        private DBControllerWSClient serviceDA;
        private BindingList<area> areas;

        public ModifyEmployeeForm()
        {
            InitializeComponent();
            
        }

        public void SetParent(EmployeeForm form)
        {
            refParent = form;
        }

        private void btnSaveChanges_Click(object sender, EventArgs e)
        {
            MessageBox.Show("El empleado se modificó satisfactoriamente");
            this.Close();
        }
        private void setEmployeeInformation()
        {
            txtEmployeeDNI.Text = currentEmployee.dni;
            txtEmployeeName.Text = currentEmployee.name;
            txtEmployeeFirstLastName.Text = currentEmployee.lastName;
            txtEmployeeSecondLastName.Text = currentEmployee.secondLastName;
            txtEmployeePhone.Text = currentEmployee.phone;
            txtEmployeeEmail.Text = currentEmployee.email;
            cbArea.Text = currentEmployee.area.abbreviation;
            cbRole.Text = currentEmployee.role;
            dtpEmployeeBorn.Value = currentEmployee.birthdate.Date;
            dtpEmployeeStartDate.Value = currentEmployee.contractStarDate.Date;
            dtpEmployeeEndDate.Value = currentEmployee.contractEndDate.Date;
            if (currentEmployee.state == 1) cbActive.Checked = true;
            else cbActive.Checked = false;
        }

        private void ModifyEmployeeForm_Load(object sender, EventArgs e)
        {
            setEmployeeInformation();
            serviceDA = new DBControllerWSClient();
            areas = new BindingList<area>(serviceDA.queryAllArea());
            for (int i = 0; i < areas.Count; i++)
            {
                cbArea.Items.Add(areas[i].description);
            }
        }

        private void btnSaveEmployee_Click(object sender, EventArgs e)
        {
            if (!filledValues())
            {
                //MessageBox.Show("Complete la información");
            }
            else
            {
                Cursor.Current = Cursors.WaitCursor;
                serviceDA = new DBControllerWSClient();
                currentEmployee.dni = txtEmployeeDNI.Text;
                currentEmployee.name = txtEmployeeName.Text;
                currentEmployee.lastName = txtEmployeeFirstLastName.Text;
                currentEmployee.secondLastName = txtEmployeeSecondLastName.Text;
                currentEmployee.phone = txtEmployeePhone.Text;
                currentEmployee.email = txtEmployeeEmail.Text;
                currentEmployee.birthdate = dtpEmployeeBorn.Value.Date;
                currentEmployee.contractStarDate = dtpEmployeeStartDate.Value.Date;
                currentEmployee.contractEndDate = dtpEmployeeEndDate.Value.Date;
                //emp.area = cbArea.Text
                currentEmployee.role = cbRole.Text;
                serviceDA.updateEmployee(currentEmployee);
                Cursor.Current = Cursors.Arrow;
                MessageBox.Show("El empleado se modificó satisfactoriamente.");
                this.Close();
            }
        }
        private bool filledValues()
        {
            if (txtEmployeeDNI.Text.Length != 8)
            {
                MessageBox.Show("Ingrese 8 digitos numericos en el campo DNI");
                return false;
            }
            if (txtEmployeeDNI.Text.Length == 8)
            {
                int result = 0;
                if (!int.TryParse(txtEmployeeDNI.Text, out result))
                {
                    MessageBox.Show("Ha ingresado caracteres no numericos en el campo DNI, ingrese 8 caracteres numericos");
                    return false;
                }
            }
            if (txtEmployeeName.Text == "")
            {
                MessageBox.Show("Ingrese un nombre de Empleado");
                return false;
            }
            if (txtEmployeeFirstLastName.Text =="")
            {
                MessageBox.Show("Ingrese un apellido paterno del Empleado");
                return false;
            }
            if (txtEmployeeSecondLastName.Text == "")
            {
                MessageBox.Show("Ingrese un apellido materno del Empleado");
                return false;
            }
            if (txtEmployeePhone.Text.Length <3)
            {
                MessageBox.Show("Ingrese un telefono del Empleado mayor o igual a digitos");
                return false;
            }
            if (txtEmployeePhone.Text.Length >= 3)
            {
                int result = 0;
                if (!int.TryParse(txtEmployeePhone.Text, out result))
                {
                    MessageBox.Show("Ha ingresado caracteres no numericos en el campo Telefono, ingrese un telefono de 3 a más digitos ");
                    return false;
                }
            }
            if (dtpEmployeeBorn.Value.Date > DateTime.Now)
            {
                MessageBox.Show("Ingrese una fecha válida de Namiento");
                return false;
            }
            
            if (dtpEmployeeStartDate.Value.Date > dtpEmployeeEndDate.Value.Date)
            {
                MessageBox.Show("Ingrese fechas de contratos válidas");
                return false;
            }




            return true;
        }
    }
}
