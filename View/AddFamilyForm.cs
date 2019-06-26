using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using View.MateWSLocal;
namespace Producto
{
    public enum StateP
    {
        Start, Save, New
    }
    public partial class AddFamilyForm : Form
    {
        private DBControllerWSClient serviceDA;
        private BindingList<family> familias;

        public class Family
        {
            
        }
        private Family f;

        public Family F { get => f; set => f = value; }

 

        public void cleanForm()
        {
            txtFamilyCode.Text = "";
            txtFamilyCode.Text = "";
            txtDescription.Text = "";
            txtName.Text = "";
            cbActive.Checked = false;
         }

        public AddFamilyForm()
        {
            InitializeComponent();
            //f = new Family();
            serviceDA = serviceDA = new View.MateWSLocal.DBControllerWSClient();
            familias = new BindingList<family>(serviceDA.queryAllFamily());
            String ultimoSerialCode = familias[familias.Count() - 1].idFamily;
            String nuevoSerialCode = "F" + (int.Parse(ultimoSerialCode.Substring(1)) + 1).ToString("0000");
            txtFamilyCode.Text = nuevoSerialCode;

            cbActive.Checked = true;
            //componentsState(StateP.Start);
        }


        private void btnSave_Click(object sender, EventArgs e)
        {

            if (!filledValues())
            {
                //MessageBox.Show("Complete la información");
            }
            else
            {
                //getCustomerData
                family f = new family();
                f.idFamily = txtFamilyCode.Text;
                f.name = txtName.Text;
                f.description = txtDescription.Text;
                f.state = 1;
                serviceDA = new DBControllerWSClient();
                Cursor.Current = Cursors.WaitCursor;
                serviceDA.insertFamily(f);
                Cursor.Current = Cursors.Arrow;
                MessageBox.Show("La familia se agregó satisfactoriamente");
                this.Close();
            }
        }
        private bool filledValues()
        {
            if (txtName.Text.Length<10 || !Regex.Match(txtName.Text,@"[a-zA-Z]").Success)
            {
                MessageBox.Show("Ingrese un nombre de familia válido (10 caracteres )");
                return false;
            }
            else if (txtDescription.Text.Length < 20)
            {
                MessageBox.Show("Ingrese una descripción válida (20 caracteres)");
                return false;
            }
            else return true;
        }
    }
}
