﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class CustomerRepFrom : Form
    {
        public CustomerRepFrom()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Reporte fue exportado satisfactoriamente.");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Reporte fue exportado satisfactoriamente.");
        }
    }
}