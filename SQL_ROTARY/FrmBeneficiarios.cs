﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SQL_ROTARY
{
    public partial class FrmBeneficiarios : Form
    {
        public FrmBeneficiarios()
        {
            InitializeComponent();
        }
        CAcceso obj = new CAcceso();

        private void FrmBeneficiarios_Load(object sender, EventArgs e)
        {
            GnvBeneficiarios.DataSource = obj.TraerDataTable("SPMOSTRARBENEFICIARIOS");

        }
    }
}