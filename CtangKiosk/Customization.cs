﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CtangKiosk
{
    public partial class Customization : Form
    {
        public Customization()
        {
            InitializeComponent();
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void ViewObtn_Click(object sender, EventArgs e)
        {
            OrderingForm orderingForm = new OrderingForm();
            orderingForm.Show();
            this.Hide();
        }
    }
}
