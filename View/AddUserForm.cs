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

namespace User
{
    public partial class AddUserForm : Form
    {
        private DBControllerWSClient serviceDA;
        employee emplo = new employee();
        UserForm refParent;

        public AddUserForm()
        {
            InitializeComponent();
            cbActive.Checked = true;
            userGroupBox.Enabled = false;
        }

        public void SetParent(UserForm form)
        {
            refParent = form;
        }

        private void btnSaveUser_Click(object sender, EventArgs e)
        {
            if (filledValues())
            {
                serviceDA = new DBControllerWSClient();
                user u = new user();
                u.creationDate = DateTime.Now;
                u.expirationDate = dtpUserExpirationDate.Value.Date;
                u.user1 = txtUserName.Text;
                u.password = txtUserPassword.Text;
                u.state = 1;
                u.employee = emplo;
                if (emplo.role == "Vendedor") u.userType = 3;
                else if (emplo.role == "Supervisor") u.userType = 2;
                else u.userType = 1;
                serviceDA.insertUser(u);
                MessageBox.Show("El usuario se agregó satisfactoriamente");
                this.Close();
            }
            
        }
        private bool filledValues()
        {
            //Los datos de empleados se llenan y validad?
            //Borrable, pa abajo
            if(txtEmpDNI.Text == "")
            {
                MessageBox.Show("Ingrese el DNI ");
                return false;
            }
            if(txtEmpDNI.Text.Length != 8)
            {
                MessageBox.Show("Ingrese un DNI válido de 8 digitos numericos");
            }
            if (txtEmpDNI.Text.Length == 8)
            {
                int result = 0;
                if (!int.TryParse(txtEmpDNI.Text, out result))
                {
                    MessageBox.Show("Ha ingresado caracteres no númericos en el campo DNI, ingrese 8 dígitos númericos ");
                    return false;
                }
                //MessageBox.Show("Ingrese un DNI válido");
            }
            if(txtEmpName.Text =="")
            {
                MessageBox.Show("Ingrese un nombre válido");
            }
            //Falta verificar que el permiso me habilite agregar un usuario
            //Hasta aquí, se puede borrar
            if (txtUserName.Text == "")
            {
                MessageBox.Show("Ingrese el nombre del usuario");
                return false;
            } else if (txtUserPassword.Text == "")
            {
                MessageBox.Show("Ingrese una contraseña");
                return false;
            }
            else if (txtPasswordConfirm.Text != txtUserPassword.Text)
            {
                MessageBox.Show("Las contraseñas deben coincidir");
                return false;
            }
            else if (dtpUserExpirationDate.Value.Date < DateTime.Now)
            {
                MessageBox.Show("Ingrese una fecha válida");
                return false;
            }
            //Falta validar que las dos contraseñas coincidan. Por verificar si funciona
            //if (txtUserPassword.Text != textBox1.Text)
            //    return false;
            return true;
        }

        private void PictureSearch_Click(object sender, EventArgs e)
        {
            if (txtEmpDNI.Text.Length != 8)
            {
                MessageBox.Show("Ingrese un DNI válido", "Aviso");
            }
            else
            {
                serviceDA = new DBControllerWSClient();
                emplo = serviceDA.queryEmployee(txtEmpDNI.Text);
                if (emplo.name != null)
                {
                    txtEmpName.Text = emplo.name + " " + emplo.lastName;
                    cboEmpUserType.Text = emplo.role;
                    userGroupBox.Enabled = true;
                    //falta validar si el empleado ya tiene un usuario
                }
                else
                {
                    MessageBox.Show("Ingrese un empleado existente");
                }
                
            }
        }
    }
}
