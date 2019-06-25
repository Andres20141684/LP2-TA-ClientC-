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
        //private View.MateWSLocal.DBControllerWSClient serviceDAA;
        private BindingList<customer> customers;
        private customer cliente = new customer();
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
                customer e1 = new customer();
                serviceDA = new DBControllerWSClient();
                e1 = serviceDA.queryByIdCustomer(dgvClients.Rows[i].Cells[0].Value.ToString());
                modClient.currentCustomer = e1;
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
                    serviceDA.deleteCustomer(customers[i]);
                    MessageBox.Show("El cliente seleccionado fue eliminado satisfactoriamente");
                    updateDataGridView();
                }
                else
                {
                   
                }
            }
            else
            {
                MessageBox.Show("Seleccione el cliente a eliminar");
            }
            updateDataGridView();
        }

        private void ClientesForms_Load(object sender, EventArgs e)
        {
            updateDataGridView();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (!filledValues())
            {
                //MessageBox.Show("Complete la información");
            }
            else
            {
                Cursor.Current = Cursors.WaitCursor;
                dgvClients.Rows.Clear();
                serviceDA = new DBControllerWSClient();
                cliente = (serviceDA.queryByIdCustomer(txtDniRuc.Text));
                Cursor.Current = Cursors.Arrow;
                if (cliente.id != null)
                {
                    dgvClients.Rows.Add(new String[] {
                    cliente.id, cliente.descriptionCustomer,cliente.email,cliente.phone
                    });
                }
                else
                {
                    MessageBox.Show("Cliente no encontrado");
                }
                
            }

        }
        private bool filledValues()
        {
            if (txtDniRuc.Text.Length != 8 && txtDniRuc.Text.Length != 11)
            {
                MessageBox.Show("Ingrese 8 digitos numericos para DNI o 11 digitos numericos para RUC");
                return false;
            }
            if (txtDniRuc.Text.Length == 8)
            {
                int result = 0;
                if (!int.TryParse(txtDniRuc.Text, out result))
                {
                    MessageBox.Show("Ha ingresado caracteres no numericos en el campo del DNI, ingrese 8 caracteres numericos para DNI");
                    return false;
                }
            }
            if (txtDniRuc.Text.Length == 11)
            {
                int result = 0;
                if (!int.TryParse(txtDniRuc.Text, out result))
                {
                    MessageBox.Show("Ha ingresado caracteres no numericos en el campo del DNI, ingrese 11 caracteres numericos para RUC");
                    return false;
                }
            }
            return true;

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
