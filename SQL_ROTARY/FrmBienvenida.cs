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
    public partial class FrmBienvenida : Form
    {
        public FrmBienvenida()
        {
            InitializeComponent();
        }

        private void menuproyecto_Click(object sender, EventArgs e)
        {
            FrmProyecto obj = new FrmProyecto();
            obj.ShowDialog();
        }

        private void menueventos_Click(object sender, EventArgs e)
        {
            FrmEventos obj = new FrmEventos();
            obj.ShowDialog();
        }

        private void menurecursos_Click(object sender, EventArgs e)
        {
            FrmRecursos obj = new FrmRecursos();
            obj.ShowDialog();
        }

        private void menufinanzas_Click(object sender, EventArgs e)
        {
            FrmFinanzas obj = new FrmFinanzas();
            obj.ShowDialog();
        }

        private void menuvoluntarios_Click(object sender, EventArgs e)
        {
            FrmVoluntarios obj = new FrmVoluntarios();
            obj.ShowDialog();
        }

        private void menusocios_Click(object sender, EventArgs e)
        {
            FrmSocios obj = new FrmSocios();
            obj.ShowDialog();
        }

        private void menubeneficiarios_Click(object sender, EventArgs e)
        {
            FrmBeneficiarios obj = new FrmBeneficiarios();
            obj.ShowDialog();
        }

        

        }
    }

