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
                serviceDA = new DBControllerWSClient();
                user u = serviceDA.validateUser(txtUsername.Text,txtPassword.Text);
                Cursor.Current = Cursors.Arrow;
                if (u.password != null)
                {
                    if (u.userType == 1) menu.darPermiso(MainWindow.Permiso.Gerente);
                    else if (u.userType == 2) menu.darPermiso(MainWindow.Permiso.Supervisor);
                    else if (u.userType == 3) menu.darPermiso(MainWindow.Permiso.Vendedor);
                    menu.currentUser = u;
                }
                else
                {
                    txtUsername.Text = "";
                    txtPassword.Text = "";
                    MessageBox.Show("Usuario incorrecto");
                    return;
                }
                this.Hide();
                menu.Show();
            }
            else
            {
                MessageBox.Show("Ingrese su usuario y contraseña");
            }
            /*
            if (user == "gerente" || password == "gerente") usuarioPermiso = 1;
            else if (user == "supervisor" || password == "supervisor") usuarioPermiso = 2;
            else if (user == "vendedor" || password == "vendedor") usuarioPermiso = 3;
            else
            {
                MessageBox.Show("Usuario incorrecto");
                return;
            }
            */
            

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
            if (txtUsername.Text == "")
            {
                MessageBox.Show("Ingrese un nombre de usuario","Error");
                return false;
            }
            else if (txtPassword.Text=="")
            {
                MessageBox.Show("Ingrese la contraseña","Error");
                return false;
            }
            return true;
        }
    }
}
