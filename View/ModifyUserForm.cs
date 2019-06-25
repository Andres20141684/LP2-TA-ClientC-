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
        public ModifyUserForm()
        {
            InitializeComponent();
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
            serviceDA = new DBControllerWSClient();
            usuario1.password = txtModifyUserPassword.Text;
            usuario1.expirationDate = dtpModifyUserExpirationDate.Value.Date;
            usuario1.modificationDate = DateTime.Now;
            if (cbActive.Checked == true) usuario1.state = 1;
            else usuario1.state = 0;

            serviceDA.updateUser(usuario1);
            MessageBox.Show("El usuario se modificó satisfactoriamente");
            this.Close();
        }

        private void ModifyUserForm_Load(object sender, EventArgs e)
        {

        }
    }
}
