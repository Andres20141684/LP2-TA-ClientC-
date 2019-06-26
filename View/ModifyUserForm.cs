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
    public partial class ModifyUserForm : Form
    {
        private DBControllerWSClient serviceDA;
        public user usuario1;
        UserForm refParent;
        public user currentUser;
        public ModifyUserForm(user u)
        {
            InitializeComponent();
            txtUserName.Text = u.user1;
        }

        private void btnModifySearchUser_Click(object sender, EventArgs e)
        {

        }

        public void SetParent(UserForm form)
        {
            refParent = form;
        }

        private void btnModifySaveUser_Click(object sender, EventArgs e)
        {
            if (!filledValues())
            {
                //MessageBox.Show("Complete la información");
            }
            else
            {
                serviceDA = new DBControllerWSClient();
                usuario1.password = txtModifyUserPassword.Text;
                usuario1.expirationDate = (DateTime) dtpModifyUserExpirationDate.Value.Date;
                usuario1.modificationDate = DateTime.Now;
                if (cbActive.Checked == true) usuario1.state = 1;
                else usuario1.state = 0;

                serviceDA.updateUser(usuario1);
                MessageBox.Show("El usuario se modificó satisfactoriamente");
                this.Close();
            }
        }
        private bool filledValues()
        {
            if ( txtModifyUserPassword.Text != txtModifyConfirmPassword.Text)
            {
                MessageBox.Show("La confirmación de contraseña no coincide");
                return false;
            }
            if (dtpModifyUserExpirationDate.Value.Date  <= DateTime.Now)
            {
                MessageBox.Show("Ingrese Fecha de expiracion posterior al día de hoy");
                return false;
            }
            return true;
        }

        private void ModifyUserForm_Load(object sender, EventArgs e)
        {

        }
    }
}
