namespace SQL_ROTARY
{
    partial class FrmBienvenida
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.menuproyecto = new FontAwesome.Sharp.IconMenuItem();
            this.menueventos = new FontAwesome.Sharp.IconMenuItem();
            this.menurecursos = new FontAwesome.Sharp.IconMenuItem();
            this.menufinanzas = new FontAwesome.Sharp.IconMenuItem();
            this.menuvoluntarios = new FontAwesome.Sharp.IconMenuItem();
            this.menusocios = new FontAwesome.Sharp.IconMenuItem();
            this.menubeneficiarios = new FontAwesome.Sharp.IconMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.SteelBlue;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(318, 39);
            this.label1.TabIndex = 4;
            this.label1.Text = "-Rotary Santa Cruz-";
            // 
            // menuStrip2
            // 
            this.menuStrip2.AutoSize = false;
            this.menuStrip2.BackColor = System.Drawing.Color.SteelBlue;
            this.menuStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.menuStrip2.Size = new System.Drawing.Size(928, 68);
            this.menuStrip2.TabIndex = 3;
            this.menuStrip2.Text = "menutitulo";
            // 
            // menuproyecto
            // 
            this.menuproyecto.AutoSize = false;
            this.menuproyecto.IconChar = FontAwesome.Sharp.IconChar.Inbox;
            this.menuproyecto.IconColor = System.Drawing.Color.Black;
            this.menuproyecto.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menuproyecto.IconSize = 50;
            this.menuproyecto.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menuproyecto.Name = "menuproyecto";
            this.menuproyecto.Size = new System.Drawing.Size(152, 69);
            this.menuproyecto.Text = "Proyectos";
            this.menuproyecto.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.menuproyecto.Click += new System.EventHandler(this.menuproyecto_Click);
            // 
            // menueventos
            // 
            this.menueventos.AutoSize = false;
            this.menueventos.IconChar = FontAwesome.Sharp.IconChar.HouseCircleExclamation;
            this.menueventos.IconColor = System.Drawing.Color.Black;
            this.menueventos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menueventos.IconSize = 50;
            this.menueventos.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menueventos.Name = "menueventos";
            this.menueventos.Size = new System.Drawing.Size(110, 69);
            this.menueventos.Text = "Eventos";
            this.menueventos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.menueventos.Click += new System.EventHandler(this.menueventos_Click);
            // 
            // menurecursos
            // 
            this.menurecursos.AutoSize = false;
            this.menurecursos.IconChar = FontAwesome.Sharp.IconChar.ChartBar;
            this.menurecursos.IconColor = System.Drawing.Color.Black;
            this.menurecursos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menurecursos.IconSize = 50;
            this.menurecursos.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menurecursos.Name = "menurecursos";
            this.menurecursos.Size = new System.Drawing.Size(110, 69);
            this.menurecursos.Text = "Recursos";
            this.menurecursos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.menurecursos.Click += new System.EventHandler(this.menurecursos_Click);
            // 
            // menufinanzas
            // 
            this.menufinanzas.AutoSize = false;
            this.menufinanzas.IconChar = FontAwesome.Sharp.IconChar.MoneyBillTransfer;
            this.menufinanzas.IconColor = System.Drawing.Color.Black;
            this.menufinanzas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menufinanzas.IconSize = 50;
            this.menufinanzas.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menufinanzas.Name = "menufinanzas";
            this.menufinanzas.Size = new System.Drawing.Size(152, 69);
            this.menufinanzas.Text = "Finanzas ";
            this.menufinanzas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.menufinanzas.Click += new System.EventHandler(this.menufinanzas_Click);
            // 
            // menuvoluntarios
            // 
            this.menuvoluntarios.AutoSize = false;
            this.menuvoluntarios.IconChar = FontAwesome.Sharp.IconChar.ScrewdriverWrench;
            this.menuvoluntarios.IconColor = System.Drawing.Color.Black;
            this.menuvoluntarios.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menuvoluntarios.IconSize = 50;
            this.menuvoluntarios.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menuvoluntarios.Name = "menuvoluntarios";
            this.menuvoluntarios.Size = new System.Drawing.Size(110, 69);
            this.menuvoluntarios.Text = "Voluntarios";
            this.menuvoluntarios.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.menuvoluntarios.Click += new System.EventHandler(this.menuvoluntarios_Click);
            // 
            // menusocios
            // 
            this.menusocios.AutoSize = false;
            this.menusocios.IconChar = FontAwesome.Sharp.IconChar.AddressCard;
            this.menusocios.IconColor = System.Drawing.Color.Black;
            this.menusocios.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menusocios.IconSize = 50;
            this.menusocios.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menusocios.Name = "menusocios";
            this.menusocios.Size = new System.Drawing.Size(110, 69);
            this.menusocios.Text = "Socios";
            this.menusocios.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.menusocios.Click += new System.EventHandler(this.menusocios_Click);
            // 
            // menubeneficiarios
            // 
            this.menubeneficiarios.AutoSize = false;
            this.menubeneficiarios.IconChar = FontAwesome.Sharp.IconChar.Users;
            this.menubeneficiarios.IconColor = System.Drawing.Color.Black;
            this.menubeneficiarios.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menubeneficiarios.IconSize = 50;
            this.menubeneficiarios.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menubeneficiarios.Name = "menubeneficiarios";
            this.menubeneficiarios.Size = new System.Drawing.Size(152, 69);
            this.menubeneficiarios.Text = "Beneficiarios";
            this.menubeneficiarios.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.menubeneficiarios.Click += new System.EventHandler(this.menubeneficiarios_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuproyecto,
            this.menueventos,
            this.menurecursos,
            this.menufinanzas,
            this.menuvoluntarios,
            this.menusocios,
            this.menubeneficiarios});
            this.menuStrip1.Location = new System.Drawing.Point(0, 68);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(928, 73);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menu";
            // 
            // FrmBienvenida
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(928, 604);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip2);
            this.Name = "FrmBienvenida";
            this.Text = "FrmBienvenida";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private FontAwesome.Sharp.IconMenuItem menuproyecto;
        private FontAwesome.Sharp.IconMenuItem menueventos;
        private FontAwesome.Sharp.IconMenuItem menurecursos;
        private FontAwesome.Sharp.IconMenuItem menufinanzas;
        private FontAwesome.Sharp.IconMenuItem menuvoluntarios;
        private FontAwesome.Sharp.IconMenuItem menusocios;
        private FontAwesome.Sharp.IconMenuItem menubeneficiarios;
        private System.Windows.Forms.MenuStrip menuStrip1;
    }
}