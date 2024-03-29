﻿using System;
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

namespace ShopsForm
{
    public partial class Agregar_Local : Form
    {
        private DBControllerWSClient serviceDA;
        ShopForm refParent;
        public Agregar_Local()
        {
            InitializeComponent();
            cbActive.Checked = true;
        }

        private void btnSaveLocal_Click(object sender, EventArgs e)
        {
            if (!filledValues())
            {
                //MessageBox.Show("Complete la información");
            }
            else
            {
                premises l = new premises();

                //p.brand = brands[cboBrand.SelectedIndex];
                l.description = txtNombre.Text;
                //p.discount = discounts[cboDiscount.SelectedIndex];
                l.address = txtAddress.Text;
                //p.SKUcode = txtSKUCode.Text;
                //p.name = txtName.Text;
                //p.productDescription = txtDescription.Text;
                //p.productCareDescription = txtCareDescription.Text;
                l.state = 1;
                //p.salePrice = float.Parse(txtSalePrice.Text);
                //p.purchasePrice = float.Parse(txtPurchasePrice.Text);
                //p.igv = float.Parse(txtIGV.Text);
                //p.stock = int.Parse(txtStock.Text);
                l.creationDate = DateTime.Today;
                l.modificationDate = DateTime.Today;

                serviceDA = new DBControllerWSClient();
                Cursor.Current = Cursors.WaitCursor;
                serviceDA.insertPremises(l);
                Cursor.Current = Cursors.Arrow;
                MessageBox.Show("El local se guardó satisfactoriamente");
                this.Close();

            }
            //MessageBox.Show("Se ha agregado un nuevo local satisfactoriamente");
            //this.Close();
        }
        private bool filledValues()
        {
            if (Regex.Match(txtNombre.Text, @"[0-9]").Success || txtNombre.Text.Length < 3)
            {
                MessageBox.Show("Ingrese un nombre válido mayor a 3 caracteres y sin numeros.");
                return false;
            }
            if (txtAddress.Text == "")
            {
                MessageBox.Show("Ingrese el direccion del local mayor a 0 caracteres");
                return false;
            }
            /*if (txtDesc.Text == "")
            {
                MessageBox.Show("Ingrese el nombre del local");
                return false;
            }*/
            return true;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

    }
}
