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

namespace SalesClient
{
    public partial class ClientesForms : Form
    {
        private DBControllerWSClient serviceDA;
        private BindingList<customer> customers;
        public ClientesForms()
        {
            InitializeComponent();
        }
        View.MainWindow refParent;
        public void SetParent(View.MainWindow form)
        {
            refParent = form;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAddClient_Click(object sender, EventArgs e)
        {
            AgregarClienteForm addClient = new AgregarClienteForm();

            //addClient.SetParent(this);

            addClient.ShowDialog();
            updateDataGridView();
        }

        private void btnEditClient_Click(object sender, EventArgs e)
        {
            int i = dgvClients.CurrentCell.RowIndex;
            if (i >= 0)
            {
                ModificarClienteForm modClient = new ModificarClienteForm();
                modClient.currentCustomer = new customer();
                modClient.currentCustomer = customers[i];
                modClient.ShowDialog();
                updateDataGridView();
            }
            else
            {
                MessageBox.Show("Seleccione un cliente");
            }
            
        }

        private void btnDelClient_Click(object sender, EventArgs e)
        {
            int i = dgvClients.CurrentCell.RowIndex;
            if (i >= 0)
            {
                DialogResult dialog = MessageBox.Show("¿Está seguro de eliminar a este cliente?", "Aviso", MessageBoxButtons.YesNo);
                if (dialog == DialogResult.Yes)
                {
                    serviceDA = new DBControllerWSClient();
                    //serviceDA.deleteCustomer(customers[i]);
                    MessageBox.Show("El cliente seleccionado fue eliminado satisfactoriamente");
                    updateDataGridView();
                }
                else
                {
                    //no eliminas ps sanaso
                }
            }
            else
            {
                MessageBox.Show("Seleccione el cliente a eliminar");
            }
            
            //Con base de datos, actualiza el grid
        }

        private void ClientesForms_Load(object sender, EventArgs e)
        {
            updateDataGridView();
            //Load, cargamos el grid
            /*dgvClients.Rows.Add(new String[]
            {
                "1","Grupo Shanooc","admin@gruposhanooc.com","233 1889","Empresa"
            });
            dgvClients.Rows.Add(new String[]
            {
                "2","Omar Correa Alva","ocoral@gmail.com","963 789 234","Persona"
            });
            dgvClients.Rows.Add(new String[]
            {
                "3","TelcomServ SRL","correo_ventas@telcomservsrl.com","234 9878","Empresa"
            });
            dgvClients.Rows.Add(new String[]
            {
                "4","Carlos Perez Sosa","cperez@hotmail.com","998 944 333","Persona"
            });*/
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (textDniRuc.Text == "")
            {
                MessageBox.Show("Inserte un DNI / RUC válido");
            }

        }
        private void updateDataGridView()
        {
            Cursor.Current = Cursors.WaitCursor;
            dgvClients.Rows.Clear();
            serviceDA = new DBControllerWSClient();
            customers = new BindingList<customer>(serviceDA.queryAllCustomer());
            for (int i = 0; i < customers.Count; i++)
            {
                dgvClients.Rows.Add(new String[] {
                ""+customers[i].id, customers[i].descriptionCustomer,customers[i].email,customers[i].phone,""+customers[i].kindOfCustomer
                });
            }
            Cursor.Current = Cursors.Arrow;
        }
    }
}
