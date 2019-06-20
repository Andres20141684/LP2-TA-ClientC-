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
    public partial class UpdateShopForm : Form
    {
        private DBControllerWSClient serviceDA;
        private DBControllerWSClient serviceDAA;
        public premises currentPremise;
        //private BindingList<brand> brands;
        //private BindingList<family> families;
        //private BindingList<discount> discounts;

        public UpdateShopForm()
        {
            InitializeComponent();
        }

        private void lblState_Click(object sender, EventArgs e)
        {

        }

        private void gbGeneralInformation_Enter(object sender, EventArgs e)
        {

        }
    }
}
