﻿using System;
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
        //public user usuario1;
        UserForm refParent;
        public user currentUser;
        public ModifyUserForm(user u)
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
            if (!filledValues())
            {
                //MessageBox.Show("Complete la información");
            }
            else
            {
                serviceDA = new DBControllerWSClient();
                currentUser.password = txtModifyUserPassword.Text;
                currentUser.expirationDate = (DateTime) dtpModifyUserExpirationDate.Value.Date;
                currentUser.modificationDate = DateTime.Now;
                currentUser.user1 = txtUserName.Text;
                
                //usuario1.employee.role = "Vendedor";
                if (cbActive.Checked == true) currentUser.state = 1;
                else currentUser.state = 0;

                try
                {
                    int salio = serviceDA.updateUser(currentUser);
                    if (salio == 1)
                    {
                        MessageBox.Show("El usuario se modificó satisfactoriamente");
                    }
                }
                catch
                {
                    MessageBox.Show("Sistema en mantenimiento :(");
                }
                
                this.Close();
            }
        }
        private bool filledValues()
        {
            if (txtModifyUserPassword.Text.Length < 8)
            {
                MessageBox.Show("La contraseña debe tener al menos 8 caracteres");
                return false;
            }
            else if ( txtModifyUserPassword.Text != txtModifyConfirmPassword.Text)
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
            txtEmpDNI.Text = currentUser.employee.dni;
            txtEmpName.Text = currentUser.employee.name;
            cboEmpUserType.Text = currentUser.employee.role;
            txtUserName.Text = currentUser.user1;
        }
    }
}
