using System;
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
    public partial class FrmProyecto : Form
    {
        public FrmProyecto()
        {
            InitializeComponent();
        }
        CAcceso obj = new CAcceso();

        private void Form1_Load(object sender, EventArgs e)
        {
            GnvProyecto.DataSource = obj.TraerDataTable("SPMOSTRARPROYECTO");

        }
    }
    }

