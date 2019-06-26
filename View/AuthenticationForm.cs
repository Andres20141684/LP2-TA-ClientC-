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

namespace View
{
    public partial class AuthenticationForm : Form
    {
        private DBControllerWSClient serviceDA;
        int usuarioPermiso;
        MainWindow mainWindow;
        public AuthenticationForm(MainWindow owner)
        {
            InitializeComponent();
            mainWindow = owner;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            MainWindow menu = new MainWindow();
            if (filledValues())
            {
                //user u = new user(serviceDA.validateUser());
                Cursor.Current = Cursors.WaitCursor;
                serviceDA = new DBControllerWSClient();//Error 00:14
                user u = serviceDA.validateUser(txtUsername.Text,txtPassword.Text);
                Cursor.Current = Cursors.Arrow;
                if (u.password != null)
                {
                    if (txtUsername.Text == u.user1)
                    {
                        if (u.userType == 1) menu.darPermiso(MainWindow.Permiso.Gerente);
                        else if (u.userType == 2) menu.darPermiso(MainWindow.Permiso.Supervisor);
                        else if (u.userType == 3) menu.darPermiso(MainWindow.Permiso.Vendedor);
                        menu.currentUser = u;
                        menu.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Usuario o contraseña incorrectos");
                    }

                   
                }
                else
                {
                    writePassword.Visible = true;
                    writeUser.Visible = true;
                    MessageBox.Show("Usuario o contraseña incorrectos");
                    return;
                }
                
                
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }
        private bool filledValues()
        {
            if (txtUsername.Text == "" && txtPassword.Text != "")
            {
                MessageBox.Show("Ingrese un nombre de usuario", "Error");
                return false;
            }
            else if (txtPassword.Text == "" && txtUsername.Text != "")
            {
                MessageBox.Show("Ingrese la contraseña", "Error");
                return false;
            }
            else if (txtPassword.Text == "" && txtUsername.Text == "")
            {
                MessageBox.Show("Ingrese Usuario y Contraseña");
                return false;
            }                
            return true;
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            writePassword.SendToBack();
            writePassword.Visible = false;
        }

        private void txtUsername_TextChanged_1(object sender, EventArgs e)
        {
            writeUser.Visible = false;
            writeUser.SendToBack();

        }

        private void writeUser_Click(object sender, EventArgs e)
        {
            writeUser.SendToBack();
        }

        private void writePassword_Click(object sender, EventArgs e)
        {
            writePassword.SendToBack();
        }

        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                this.btnOK_Click(sender,e);
            }
        }

        private void AuthenticationForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
