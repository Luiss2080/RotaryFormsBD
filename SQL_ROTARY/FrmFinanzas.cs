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
    public partial class FrmFinanzas : Form
    {
        public FrmFinanzas()
        {
            InitializeComponent();
        }
        CAcceso obj = new CAcceso();

        private void FrmFinanzas_Load(object sender, EventArgs e)
        {
            GnvFinanza.DataSource = obj.TraerDataTable("SPMOSTRARFINANZASS");
        }
    }
}

