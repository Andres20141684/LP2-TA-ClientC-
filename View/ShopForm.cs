using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShopsForm
{
    public partial class ShopForm : Form
    {
        private BindingList<View.MateWSLocal.premises> shopsData;
        private View.MateWSLocal.DBControllerWSClient serviceDA;
        public ShopForm()
        {
            InitializeComponent();
            updateDataGridView();
        }
        View.MainWindow refParent;
        void updateDataGridView()
        {
            Cursor.Current = Cursors.WaitCursor;
            dgvLocal.Rows.Clear();
            serviceDA = new View.MateWSLocal.DBControllerWSClient();
            shopsData = new BindingList<View.MateWSLocal.premises>(serviceDA.queryAllPremises());
            for (int i=0;i<shopsData.Count;i++)
            {
                dgvLocal.Rows.Add(new String[]{
                    shopsData[i].id.ToString(), shopsData[i].description, shopsData[i].creationDate.ToString(), shopsData[i].address
                });
                Cursor.Current = Cursors.Arrow;

            }
        }
        public void SetParent(View.MainWindow form)
        {
            refParent = form;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAddLocal_Click(object sender, EventArgs e)
        {
            Agregar_Local addLocal = new Agregar_Local();
            if (addLocal.ShowDialog() == DialogResult.OK)
            {
                //addLocal.SetParent(this);
                addLocal.ShowDialog();
                updateDataGridView();
            }
            updateDataGridView();
        }

        private void btnModLocal_Click(object sender, EventArgs e)
        {
            Modificar_Local modLocal = new Modificar_Local();
            modLocal.SetParent(this);
            modLocal.ShowDialog();
            int i = dgvLocal.CurrentCell.RowIndex;
            if(i >=0 )
            {
                //UpdateShopForm updateShop = new UpdateShopForm();
                //updateShop.currentShop = 
            }
        }

        private void btnDelLocal_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Se ha eliminado al local seleccionado");
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("Inserte un código válido");
            }
        }

        private void ShopForm_Load(object sender, EventArgs e)
        {
            //Load, cargamos el grid
            dgvLocal.Rows.Add(new String[]
            {
                "1","Local San Miguel","23-09-2014","Av. Riva Aguero #990"
            });
            dgvLocal.Rows.Add(new String[]
            {
                "2","Local Santa Anita","12-04-2012","Av. Ruiseñores #453"
            });
            dgvLocal.Rows.Add(new String[]
            {
                "3","Local Surco","23-05-2017","Av. Primavera #443"
            });
            dgvLocal.Rows.Add(new String[]
            {
                "4","Local La Molina","14-03-2018","Av. Rinconada del Lago #773"
            });
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }
    }
}
