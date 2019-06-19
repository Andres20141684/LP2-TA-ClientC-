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
        private BindingList<user> users;
        
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
            addUserForm.SetParent(this);
            addUserForm.ShowDialog();
            updateDataGridView();
        }

        private void bntModifyUser_Click(object sender, EventArgs e)
        {
            ModifyUserForm modifyUserForm = new ModifyUserForm();
            modifyUserForm.SetParent(this);
            modifyUserForm.ShowDialog();
        }

        private void btnDeleteUser_Click(object sender, EventArgs e)
        {
            
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
    }
}
