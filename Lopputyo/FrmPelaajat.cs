﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lopputyo
{
    public partial class FrmPelaajat : Form
    {
        public FrmPelaajat()
        {
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            FrmLopputyo frmLopputyo = new FrmLopputyo();
            frmLopputyo.Aloitapeli(sender, e);
        }
    }
}