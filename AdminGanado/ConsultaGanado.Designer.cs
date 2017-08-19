namespace AdminGanado
{
    partial class frmConsultaGanado
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
            this.btnCerrar = new System.Windows.Forms.Button();
            this.btnVolver = new System.Windows.Forms.Button();
            this.label36 = new System.Windows.Forms.Label();
            this.lstVacas = new System.Windows.Forms.ListBox();
            this.txtObservaciones = new System.Windows.Forms.TextBox();
            this.txtTotalHembras = new System.Windows.Forms.TextBox();
            this.txtTotalMachos = new System.Windows.Forms.TextBox();
            this.txtTotalTerneras = new System.Windows.Forms.TextBox();
            this.txtTotalCabezas = new System.Windows.Forms.TextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.lstFechas = new System.Windows.Forms.ListBox();
            this.cbbDueño = new System.Windows.Forms.ComboBox();
            this.rbtnOrganizacion = new System.Windows.Forms.RadioButton();
            this.rbtnGanadero = new System.Windows.Forms.RadioButton();
            this.btnGuardarComentario = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCerrar
            // 
            this.btnCerrar.BackColor = System.Drawing.Color.Red;
            this.btnCerrar.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnCerrar.Location = new System.Drawing.Point(747, 13);
            this.btnCerrar.Margin = new System.Windows.Forms.Padding(4);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(29, 30);
            this.btnCerrar.TabIndex = 46;
            this.btnCerrar.Text = "X";
            this.btnCerrar.UseVisualStyleBackColor = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // btnVolver
            // 
            this.btnVolver.BackColor = System.Drawing.SystemColors.Menu;
            this.btnVolver.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolver.Location = new System.Drawing.Point(649, 13);
            this.btnVolver.Margin = new System.Windows.Forms.Padding(4);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(90, 30);
            this.btnVolver.TabIndex = 45;
            this.btnVolver.Text = "←";
            this.btnVolver.UseVisualStyleBackColor = false;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.Location = new System.Drawing.Point(610, 101);
            this.label36.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(70, 18);
            this.label36.TabIndex = 62;
            this.label36.Text = "Id vacas:";
            // 
            // lstVacas
            // 
            this.lstVacas.DisplayMember = "Identificador";
            this.lstVacas.FormattingEnabled = true;
            this.lstVacas.ItemHeight = 18;
            this.lstVacas.Location = new System.Drawing.Point(612, 127);
            this.lstVacas.Margin = new System.Windows.Forms.Padding(4);
            this.lstVacas.Name = "lstVacas";
            this.lstVacas.Size = new System.Drawing.Size(120, 256);
            this.lstVacas.TabIndex = 61;
            // 
            // txtObservaciones
            // 
            this.txtObservaciones.Location = new System.Drawing.Point(281, 265);
            this.txtObservaciones.Margin = new System.Windows.Forms.Padding(4);
            this.txtObservaciones.Multiline = true;
            this.txtObservaciones.Name = "txtObservaciones";
            this.txtObservaciones.Size = new System.Drawing.Size(313, 133);
            this.txtObservaciones.TabIndex = 60;
            // 
            // txtTotalHembras
            // 
            this.txtTotalHembras.Enabled = false;
            this.txtTotalHembras.Location = new System.Drawing.Point(514, 181);
            this.txtTotalHembras.Margin = new System.Windows.Forms.Padding(4);
            this.txtTotalHembras.Name = "txtTotalHembras";
            this.txtTotalHembras.Size = new System.Drawing.Size(80, 26);
            this.txtTotalHembras.TabIndex = 59;
            // 
            // txtTotalMachos
            // 
            this.txtTotalMachos.Enabled = false;
            this.txtTotalMachos.Location = new System.Drawing.Point(514, 127);
            this.txtTotalMachos.Margin = new System.Windows.Forms.Padding(4);
            this.txtTotalMachos.Name = "txtTotalMachos";
            this.txtTotalMachos.Size = new System.Drawing.Size(80, 26);
            this.txtTotalMachos.TabIndex = 58;
            // 
            // txtTotalTerneras
            // 
            this.txtTotalTerneras.Enabled = false;
            this.txtTotalTerneras.Location = new System.Drawing.Point(342, 181);
            this.txtTotalTerneras.Margin = new System.Windows.Forms.Padding(4);
            this.txtTotalTerneras.Name = "txtTotalTerneras";
            this.txtTotalTerneras.Size = new System.Drawing.Size(80, 26);
            this.txtTotalTerneras.TabIndex = 57;
            // 
            // txtTotalCabezas
            // 
            this.txtTotalCabezas.Enabled = false;
            this.txtTotalCabezas.Location = new System.Drawing.Point(342, 127);
            this.txtTotalCabezas.Margin = new System.Windows.Forms.Padding(4);
            this.txtTotalCabezas.Name = "txtTotalCabezas";
            this.txtTotalCabezas.Size = new System.Drawing.Size(80, 26);
            this.txtTotalCabezas.TabIndex = 56;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(277, 243);
            this.label23.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(108, 18);
            this.label23.TabIndex = 55;
            this.label23.Text = "Observaciones:";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(265, 185);
            this.label22.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(72, 18);
            this.label22.TabIndex = 54;
            this.label22.Text = "Terneras:";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(442, 131);
            this.label21.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(63, 18);
            this.label21.TabIndex = 53;
            this.label21.Text = "Machos:";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(437, 185);
            this.label20.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(72, 18);
            this.label20.TabIndex = 52;
            this.label20.Text = "Hembras:";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(210, 131);
            this.label19.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(127, 18);
            this.label19.TabIndex = 51;
            this.label19.Text = "Total de Cabezas:";
            // 
            // lstFechas
            // 
            this.lstFechas.DisplayMember = "fechaRegistro";
            this.lstFechas.FormattingEnabled = true;
            this.lstFechas.ItemHeight = 18;
            this.lstFechas.Location = new System.Drawing.Point(16, 127);
            this.lstFechas.Margin = new System.Windows.Forms.Padding(4);
            this.lstFechas.Name = "lstFechas";
            this.lstFechas.Size = new System.Drawing.Size(120, 256);
            this.lstFechas.TabIndex = 50;
            this.lstFechas.SelectedIndexChanged += new System.EventHandler(this.lstFechas_SelectedIndexChanged);
            // 
            // cbbDueño
            // 
            this.cbbDueño.DisplayMember = "Nombre";
            this.cbbDueño.FormattingEnabled = true;
            this.cbbDueño.Location = new System.Drawing.Point(16, 90);
            this.cbbDueño.Margin = new System.Windows.Forms.Padding(4);
            this.cbbDueño.Name = "cbbDueño";
            this.cbbDueño.Size = new System.Drawing.Size(160, 26);
            this.cbbDueño.TabIndex = 49;
            this.cbbDueño.SelectedIndexChanged += new System.EventHandler(this.cbbDueño_SelectedIndexChanged);
            // 
            // rbtnOrganizacion
            // 
            this.rbtnOrganizacion.AutoSize = true;
            this.rbtnOrganizacion.Location = new System.Drawing.Point(125, 57);
            this.rbtnOrganizacion.Margin = new System.Windows.Forms.Padding(4);
            this.rbtnOrganizacion.Name = "rbtnOrganizacion";
            this.rbtnOrganizacion.Size = new System.Drawing.Size(108, 22);
            this.rbtnOrganizacion.TabIndex = 48;
            this.rbtnOrganizacion.TabStop = true;
            this.rbtnOrganizacion.Tag = "ganado";
            this.rbtnOrganizacion.Text = "Organización";
            this.rbtnOrganizacion.UseVisualStyleBackColor = true;
            this.rbtnOrganizacion.CheckedChanged += new System.EventHandler(this.rbtnOrganizacion_CheckedChanged);
            // 
            // rbtnGanadero
            // 
            this.rbtnGanadero.AutoSize = true;
            this.rbtnGanadero.Location = new System.Drawing.Point(16, 57);
            this.rbtnGanadero.Margin = new System.Windows.Forms.Padding(4);
            this.rbtnGanadero.Name = "rbtnGanadero";
            this.rbtnGanadero.Size = new System.Drawing.Size(89, 22);
            this.rbtnGanadero.TabIndex = 47;
            this.rbtnGanadero.TabStop = true;
            this.rbtnGanadero.Tag = "ganado";
            this.rbtnGanadero.Text = "Ganadero";
            this.rbtnGanadero.UseVisualStyleBackColor = true;
            this.rbtnGanadero.CheckedChanged += new System.EventHandler(this.rbtnGanadero_CheckedChanged);
            // 
            // btnGuardarComentario
            // 
            this.btnGuardarComentario.Location = new System.Drawing.Point(359, 406);
            this.btnGuardarComentario.Margin = new System.Windows.Forms.Padding(4);
            this.btnGuardarComentario.Name = "btnGuardarComentario";
            this.btnGuardarComentario.Size = new System.Drawing.Size(168, 32);
            this.btnGuardarComentario.TabIndex = 63;
            this.btnGuardarComentario.Text = "Guardar comentario";
            this.btnGuardarComentario.UseVisualStyleBackColor = true;
            this.btnGuardarComentario.Click += new System.EventHandler(this.btnGuardarComentario_Click);
            // 
            // frmConsultaGanado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::AdminGanado.Properties.Resources.fondovaca2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(789, 470);
            this.ControlBox = false;
            this.Controls.Add(this.btnGuardarComentario);
            this.Controls.Add(this.label36);
            this.Controls.Add(this.lstVacas);
            this.Controls.Add(this.txtObservaciones);
            this.Controls.Add(this.txtTotalHembras);
            this.Controls.Add(this.txtTotalMachos);
            this.Controls.Add(this.txtTotalTerneras);
            this.Controls.Add(this.txtTotalCabezas);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.lstFechas);
            this.Controls.Add(this.cbbDueño);
            this.Controls.Add(this.rbtnOrganizacion);
            this.Controls.Add(this.rbtnGanadero);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.btnVolver);
            this.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmConsultaGanado";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consulta de Ganado";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Label label36;
        private System.Windows.Forms.ListBox lstVacas;
        private System.Windows.Forms.TextBox txtObservaciones;
        private System.Windows.Forms.TextBox txtTotalHembras;
        private System.Windows.Forms.TextBox txtTotalMachos;
        private System.Windows.Forms.TextBox txtTotalTerneras;
        private System.Windows.Forms.TextBox txtTotalCabezas;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.ListBox lstFechas;
        private System.Windows.Forms.ComboBox cbbDueño;
        private System.Windows.Forms.RadioButton rbtnOrganizacion;
        private System.Windows.Forms.RadioButton rbtnGanadero;
        private System.Windows.Forms.Button btnGuardarComentario;
    }
}