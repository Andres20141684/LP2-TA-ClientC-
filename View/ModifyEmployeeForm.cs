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
            //serviceDA.updateEmployee(currentEmployee);
            Cursor.Current = Cursors.Arrow;
            MessageBox.Show("El empleado se modificó satisfactoriamente.");
            this.Close();
        }
    }
}
