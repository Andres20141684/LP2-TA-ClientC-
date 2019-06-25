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
    
    public partial class UserForm : Form
    {
        View.MainWindow refParent;
        private DBControllerWSClient serviceDA;
        private DBControllerWSClient serviceDAA;
        private BindingList<user> users;
        private user usuario = new user();
        public UserForm()
        {
            InitializeComponent();
            //updateDataGridView();
        }
        public void SetParent(View.MainWindow form)
        {
            refParent = form;
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            AddUserForm addUserForm = new AddUserForm();
            if (addUserForm.ShowDialog() == DialogResult.OK)
            {
                addUserForm.SetParent(this);
                addUserForm.ShowDialog();
            }
            updateDataGridView();
        }

        private void bntModifyUser_Click(object sender, EventArgs e)
        {
            int i = dgvUser.CurrentCell.RowIndex;
            if (i >= 0)
            {
                ModifyUserForm modifyUserForm = new ModifyUserForm();
                modifyUserForm.usuario1 = new user();
                modifyUserForm.usuario1 = users[i];
                modifyUserForm.SetParent(this);
                modifyUserForm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Seleccione un usuario");
            }
            
        }

        private void UserForm_Load(object sender, EventArgs e)
        {
            updateDataGridView();
            
        }
        void updateDataGridView()
        {
            Cursor.Current = Cursors.WaitCursor;
            dgvUser.Rows.Clear();
            serviceDA = new DBControllerWSClient();
            users = new BindingList<user> (serviceDA.queryAllUser());
            for (int i = 0; i < users.Count; i++)
            {
                dgvUser.Rows.Add(new String[] {
                ""+users[i].id, users[i].user1 ,users[i].expirationDate.ToString()
                });
            }
            Cursor.Current = Cursors.Arrow;

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            dgvUser.Rows.Clear();
            serviceDAA = new DBControllerWSClient();
            usuario = (serviceDAA.queryUserByUserName(txtUsername.Text));

            dgvUser.Rows.Add(new String[] {
                ""+usuario.id, ""+usuario.user1, ""+usuario.expirationDate
                });

            Cursor.Current = Cursors.Arrow;
        }
    }
}
