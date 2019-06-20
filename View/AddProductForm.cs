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
namespace Producto
{

    public partial class AddProductForm : Form
    {
        private DBControllerWSClient serviceDA;
        private BindingList<brand> brands;
        private BindingList<family> families;
        private BindingList<discount> discounts;



        public class Product { }
        private Product p;

        

        public AddProductForm()
        {
            InitializeComponent();

            cbActive.Checked = true;



        }
        //public Product P { get => p; set => p = value; }

        private void AddProductForm_Load(object sender, EventArgs e)
        {
            serviceDA = new DBControllerWSClient();
            brands = new BindingList<brand>(serviceDA.queryAllBrand());
            for(int i=0 ; i<brands.Count; i++)
            {
                cboBrand.Items.Add("" + brands[i].name);
            }
            
            //cboBrand.DataSource = brands;
            families = new BindingList<family>(serviceDA.queryAllFamily());
            for (int i = 0; i < families.Count; i++)
            {
                cboFamily.Items.Add("" + families[i].name);
            }

            discounts = new BindingList<discount>(serviceDA.queryAllDiscount());
            for (int i = 0; i < discounts.Count; i++)
            {
                cboDiscount.Items.Add("" + discounts[i].description);
            }

            //cboFamily.DataSource = families;
        }

        public void cleanForm()
        {

            txtCareDescription.Text = "";
            txtDescription.Text = "";
            txtIGV.Text = " ";
            txtName.Text = "";
            txtPurchasePrice.Text = "";
            txtSalePrice.Text = "";
            txtSKUCode.Text = "";

            cboBrand.SelectedIndex = -1;
            cboFamily.SelectedIndex = -1;
            cbActive.Checked = false;
            cboDiscount.SelectedIndex = -1;
        }


        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!filledValues())
            {
                //MessageBox.Show("Complete la información");
            }
            else
            {
                product p = new product();

                p.brand = brands[cboBrand.SelectedIndex];
                p.family = families[cboFamily.SelectedIndex];
                p.discount = discounts[cboDiscount.SelectedIndex];

                p.SKUcode = txtSKUCode.Text;
                p.name = txtName.Text;
                p.productDescription = txtDescription.Text;
                p.productCareDescription = txtCareDescription.Text;
                p.state = 1;
                p.salePrice = float.Parse(txtSalePrice.Text);
                p.purchasePrice = float.Parse(txtPurchasePrice.Text);
                p.igv = float.Parse(txtIGV.Text);
                p.stock = int.Parse(txtStock.Text);
                
                serviceDA = new DBControllerWSClient();
                Cursor.Current = Cursors.WaitCursor;
                serviceDA.insertProduct(p);
                Cursor.Current = Cursors.Arrow;
                MessageBox.Show("El producto se guardó satisfactoriamente");
                this.Close();
            
            }
        }
        private bool filledValues()
        {
            if (txtSKUCode.Text == "")
            {
                MessageBox.Show("Ingrese el código SKU del producto");
                return false;
            }
            else if (txtName.Text =="")
            {
                MessageBox.Show("Ingrese el nombre del producto");
                return false;
            }
            else if (txtDescription.Text == "")
            {
                MessageBox.Show("Ingrese la descripción del producto");
                return false;
            }
            else if (txtCareDescription.Text == "")
            {
                MessageBox.Show("Ingrese la descripción del cuidado del producto");
                return false;
            }
            else if (txtSalePrice.Text == "")
            {
                MessageBox.Show("Ingrese el precio de venta");
                return false;
            }
            else if (txtPurchasePrice.Text == "")
            {
                MessageBox.Show("Ingrese el precio de compra");
                return false;
            }
            else if (txtIGV.Text == "")
            {
                MessageBox.Show("Ingrese el IGV");
                return false;
            }
            else if (txtStock.Text == "")
            {
                MessageBox.Show("Ingrese el stock");
                return false;
            }
            else if (cboBrand.Text == "--Seleccione--")
            {
                MessageBox.Show("Seleccione la marca");
                return false;
            }
            else if (cboFamily.Text == "--Seleccione--")
            {
                MessageBox.Show("Seleccione la familia");
                return false;
            }
            else if (cboDiscount.Text == "--Seleccione--")
            {
                MessageBox.Show("Seleccione el descuento");
                return false;
            }
            return true;
        }

        private void gbGeneralInformation_Enter(object sender, EventArgs e)
        {

        }
    }
}
