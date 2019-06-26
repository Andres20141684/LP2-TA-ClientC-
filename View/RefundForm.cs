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
    public partial class RefundForm : Form
    {
        private sale currentSale;
        public RefundForm()
        {
            InitializeComponent();
        }

        public sale CurrentSale { get => currentSale; set => currentSale = value; }

        private void RefundForm_Load(object sender, EventArgs e)
        {
            setInformationForm();
        }
        private void setInformationForm()
        {
            userLabelContent.Text = currentSale.employee.name +" "+ currentSale.employee.lastName;
            txtSerialCode.Text = currentSale.serialCode.ToString();
            boletaRadioButton.Checked = true;
            txtDniRuc.Text = currentSale.customer.idCustomer.ToString();
            txtDescripcion.Text = currentSale.customer.descriptionCustomer;
            foreach (saleLane s in currentSale.saleLanes){
                dgvRefundDetail.Rows.Add(new String[] { s.product.id.ToString(), s.product.name, s.quantity.ToString(), "0", s.subtotal.ToString() });
            }
        }
    }
}
