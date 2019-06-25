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
        UserForm refParent;

        public AddUserForm()
        {
            InitializeComponent();
            cbActive.Checked = true;
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
                serviceDA.insertUser(u);
                MessageBox.Show("El usuario se agregó satisfactoriamente");
                this.Close();
            }
            
        }
        private bool filledValues()
        {
            if (txtUserName.Text == "")
            {
                MessageBox.Show("Ingrese el nombre del usuario");
                return false;
            }else if (txtUserPassword.Text==""){
                MessageBox.Show("Ingrese una contraseña");
                return false;
            }else if (dtpUserExpirationDate.Value.Date < DateTime.Now)
            {
                MessageBox.Show("Ingrese una fecha válida");
                return false;
            }
            return true;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
