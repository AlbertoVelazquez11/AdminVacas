namespace AdminGanado
{
    partial class frmRegistroGanado
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
            this.cbbSalud = new System.Windows.Forms.ComboBox();
            this.cbbEstatus = new System.Windows.Forms.ComboBox();
            this.cbbRaza = new System.Windows.Forms.ComboBox();
            this.txtObservaciones = new System.Windows.Forms.TextBox();
            this.label32 = new System.Windows.Forms.Label();
            this.label31 = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.txtPeso = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label24 = new System.Windows.Forms.Label();
            this.cbbDueño = new System.Windows.Forms.ComboBox();
            this.label18 = new System.Windows.Forms.Label();
            this.rbtnOrganizacion = new System.Windows.Forms.RadioButton();
            this.rbtnGanadero = new System.Windows.Forms.RadioButton();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.cbbSexo = new System.Windows.Forms.ComboBox();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.btnVolver = new System.Windows.Forms.Button();
            this.txtCrias = new System.Windows.Forms.NumericUpDown();
            this.txtEdad = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.txtCrias)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEdad)).BeginInit();
            this.SuspendLayout();
            // 
            // cbbSalud
            // 
            this.cbbSalud.FormattingEnabled = true;
            this.cbbSalud.Items.AddRange(new object[] {
            "Buena",
            "Enferma",
            "Tratamiento",
            "Desahuciada"});
            this.cbbSalud.Location = new System.Drawing.Point(393, 260);
            this.cbbSalud.Margin = new System.Windows.Forms.Padding(4);
            this.cbbSalud.Name = "cbbSalud";
            this.cbbSalud.Size = new System.Drawing.Size(150, 27);
            this.cbbSalud.TabIndex = 49;
            // 
            // cbbEstatus
            // 
            this.cbbEstatus.FormattingEnabled = true;
            this.cbbEstatus.Items.AddRange(new object[] {
            "En venta",
            "No disponible"});
            this.cbbEstatus.Location = new System.Drawing.Point(122, 257);
            this.cbbEstatus.Margin = new System.Windows.Forms.Padding(4);
            this.cbbEstatus.Name = "cbbEstatus";
            this.cbbEstatus.Size = new System.Drawing.Size(150, 27);
            this.cbbEstatus.TabIndex = 48;
            // 
            // cbbRaza
            // 
            this.cbbRaza.FormattingEnabled = true;
            this.cbbRaza.Items.AddRange(new object[] {
            "Europea",
            "Pinta",
            "Fina"});
            this.cbbRaza.Location = new System.Drawing.Point(122, 218);
            this.cbbRaza.Margin = new System.Windows.Forms.Padding(4);
            this.cbbRaza.Name = "cbbRaza";
            this.cbbRaza.Size = new System.Drawing.Size(150, 27);
            this.cbbRaza.TabIndex = 47;
            // 
            // txtObservaciones
            // 
            this.txtObservaciones.Location = new System.Drawing.Point(64, 323);
            this.txtObservaciones.Margin = new System.Windows.Forms.Padding(4);
            this.txtObservaciones.Multiline = true;
            this.txtObservaciones.Name = "txtObservaciones";
            this.txtObservaciones.Size = new System.Drawing.Size(428, 81);
            this.txtObservaciones.TabIndex = 46;
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Location = new System.Drawing.Point(59, 300);
            this.label32.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(117, 19);
            this.label32.TabIndex = 45;
            this.label32.Text = "Observaciones:";
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Location = new System.Drawing.Point(329, 265);
            this.label31.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(54, 19);
            this.label31.TabIndex = 44;
            this.label31.Text = "Salud:";
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Location = new System.Drawing.Point(56, 262);
            this.label30.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(56, 19);
            this.label30.TabIndex = 43;
            this.label30.Text = "status:";
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(335, 183);
            this.label29.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(50, 19);
            this.label29.TabIndex = 42;
            this.label29.Text = "Crias:";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(333, 145);
            this.label28.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(48, 19);
            this.label28.TabIndex = 41;
            this.label28.Text = "Peso:";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(60, 224);
            this.label27.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(48, 19);
            this.label27.TabIndex = 40;
            this.label27.Text = "Raza:";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(59, 183);
            this.label26.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(50, 19);
            this.label26.TabIndex = 39;
            this.label26.Text = "Edad:";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(337, 225);
            this.label25.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(49, 19);
            this.label25.TabIndex = 38;
            this.label25.Text = "Sexo:";
            // 
            // txtPeso
            // 
            this.txtPeso.Location = new System.Drawing.Point(393, 140);
            this.txtPeso.Margin = new System.Windows.Forms.Padding(4);
            this.txtPeso.Name = "txtPeso";
            this.txtPeso.Size = new System.Drawing.Size(72, 27);
            this.txtPeso.TabIndex = 36;
            this.txtPeso.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPeso_KeyPress);
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(122, 143);
            this.txtID.Margin = new System.Windows.Forms.Padding(4);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(72, 27);
            this.txtID.TabIndex = 33;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(82, 148);
            this.label24.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(32, 19);
            this.label24.TabIndex = 32;
            this.label24.Text = "ID:";
            // 
            // cbbDueño
            // 
            this.cbbDueño.DisplayMember = "Nombre";
            this.cbbDueño.FormattingEnabled = true;
            this.cbbDueño.Location = new System.Drawing.Point(122, 108);
            this.cbbDueño.Margin = new System.Windows.Forms.Padding(4);
            this.cbbDueño.Name = "cbbDueño";
            this.cbbDueño.Size = new System.Drawing.Size(180, 27);
            this.cbbDueño.TabIndex = 31;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(50, 112);
            this.label18.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(61, 19);
            this.label18.TabIndex = 30;
            this.label18.Text = "Dueño:";
            // 
            // rbtnOrganizacion
            // 
            this.rbtnOrganizacion.AutoSize = true;
            this.rbtnOrganizacion.Location = new System.Drawing.Point(173, 74);
            this.rbtnOrganizacion.Margin = new System.Windows.Forms.Padding(4);
            this.rbtnOrganizacion.Name = "rbtnOrganizacion";
            this.rbtnOrganizacion.Size = new System.Drawing.Size(119, 23);
            this.rbtnOrganizacion.TabIndex = 29;
            this.rbtnOrganizacion.TabStop = true;
            this.rbtnOrganizacion.Tag = "animal";
            this.rbtnOrganizacion.Text = "Organización";
            this.rbtnOrganizacion.UseVisualStyleBackColor = true;
            this.rbtnOrganizacion.CheckedChanged += new System.EventHandler(this.rbtnOrganizacion_CheckedChanged);
            // 
            // rbtnGanadero
            // 
            this.rbtnGanadero.AutoSize = true;
            this.rbtnGanadero.Location = new System.Drawing.Point(50, 73);
            this.rbtnGanadero.Margin = new System.Windows.Forms.Padding(4);
            this.rbtnGanadero.Name = "rbtnGanadero";
            this.rbtnGanadero.Size = new System.Drawing.Size(95, 23);
            this.rbtnGanadero.TabIndex = 28;
            this.rbtnGanadero.TabStop = true;
            this.rbtnGanadero.Tag = "animal";
            this.rbtnGanadero.Text = "Ganadero";
            this.rbtnGanadero.UseVisualStyleBackColor = true;
            this.rbtnGanadero.CheckedChanged += new System.EventHandler(this.rbtnGanadero_CheckedChanged);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(382, 415);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(4);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(112, 34);
            this.btnGuardar.TabIndex = 50;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(260, 415);
            this.btnLimpiar.Margin = new System.Windows.Forms.Padding(4);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(112, 34);
            this.btnLimpiar.TabIndex = 51;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // cbbSexo
            // 
            this.cbbSexo.FormattingEnabled = true;
            this.cbbSexo.Items.AddRange(new object[] {
            "M",
            "H"});
            this.cbbSexo.Location = new System.Drawing.Point(393, 221);
            this.cbbSexo.Margin = new System.Windows.Forms.Padding(4);
            this.cbbSexo.Name = "cbbSexo";
            this.cbbSexo.Size = new System.Drawing.Size(150, 27);
            this.cbbSexo.TabIndex = 52;
            // 
            // btnCerrar
            // 
            this.btnCerrar.BackColor = System.Drawing.Color.Red;
            this.btnCerrar.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnCerrar.Location = new System.Drawing.Point(564, 13);
            this.btnCerrar.Margin = new System.Windows.Forms.Padding(4);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(33, 32);
            this.btnCerrar.TabIndex = 54;
            this.btnCerrar.Text = "X";
            this.btnCerrar.UseVisualStyleBackColor = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // btnVolver
            // 
            this.btnVolver.BackColor = System.Drawing.SystemColors.Menu;
            this.btnVolver.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolver.Location = new System.Drawing.Point(466, 13);
            this.btnVolver.Margin = new System.Windows.Forms.Padding(4);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(90, 30);
            this.btnVolver.TabIndex = 53;
            this.btnVolver.Text = "←";
            this.btnVolver.UseVisualStyleBackColor = false;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // txtCrias
            // 
            this.txtCrias.Location = new System.Drawing.Point(393, 178);
            this.txtCrias.Margin = new System.Windows.Forms.Padding(4);
            this.txtCrias.Name = "txtCrias";
            this.txtCrias.Size = new System.Drawing.Size(74, 27);
            this.txtCrias.TabIndex = 55;
            // 
            // txtEdad
            // 
            this.txtEdad.Location = new System.Drawing.Point(122, 180);
            this.txtEdad.Margin = new System.Windows.Forms.Padding(4);
            this.txtEdad.Name = "txtEdad";
            this.txtEdad.Size = new System.Drawing.Size(74, 27);
            this.txtEdad.TabIndex = 56;
            // 
            // frmRegistroGanado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::AdminGanado.Properties.Resources.fondovaca;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(610, 463);
            this.ControlBox = false;
            this.Controls.Add(this.txtEdad);
            this.Controls.Add(this.txtCrias);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.cbbSexo);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.cbbSalud);
            this.Controls.Add(this.cbbEstatus);
            this.Controls.Add(this.cbbRaza);
            this.Controls.Add(this.txtObservaciones);
            this.Controls.Add(this.label32);
            this.Controls.Add(this.label31);
            this.Controls.Add(this.label30);
            this.Controls.Add(this.label29);
            this.Controls.Add(this.label28);
            this.Controls.Add(this.label27);
            this.Controls.Add(this.label26);
            this.Controls.Add(this.label25);
            this.Controls.Add(this.txtPeso);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.label24);
            this.Controls.Add(this.cbbDueño);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.rbtnOrganizacion);
            this.Controls.Add(this.rbtnGanadero);
            this.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmRegistroGanado";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registro de ganado";
            ((System.ComponentModel.ISupportInitialize)(this.txtCrias)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEdad)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbbSalud;
        private System.Windows.Forms.ComboBox cbbEstatus;
        private System.Windows.Forms.ComboBox cbbRaza;
        private System.Windows.Forms.TextBox txtObservaciones;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.TextBox txtPeso;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.ComboBox cbbDueño;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.RadioButton rbtnOrganizacion;
        private System.Windows.Forms.RadioButton rbtnGanadero;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.ComboBox cbbSexo;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.NumericUpDown txtCrias;
        private System.Windows.Forms.NumericUpDown txtEdad;
    }
}