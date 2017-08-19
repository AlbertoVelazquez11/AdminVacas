namespace AdminGanado
{
    partial class frmGanadero
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
            this.label35 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.txtRFCGanadero = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txtClaveUPPGanadero = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtDireccionGanadero = new System.Windows.Forms.TextBox();
            this.lstGanadero = new System.Windows.Forms.ListBox();
            this.btnEliminarGanadero = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.cbbEstatusGanadero = new System.Windows.Forms.ComboBox();
            this.txtTelefonoGanadero = new System.Windows.Forms.TextBox();
            this.txtCorreoGanadero = new System.Windows.Forms.TextBox();
            this.txtNombreGanadero = new System.Windows.Forms.TextBox();
            this.btnRegistrarGanadero = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.btnVolver = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label35.Location = new System.Drawing.Point(22, 69);
            this.label35.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(118, 25);
            this.label35.TabIndex = 51;
            this.label35.Text = "Ganaderos:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(258, 311);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(37, 19);
            this.label15.TabIndex = 48;
            this.label15.Text = "RFC";
            // 
            // txtRFCGanadero
            // 
            this.txtRFCGanadero.Location = new System.Drawing.Point(310, 307);
            this.txtRFCGanadero.Margin = new System.Windows.Forms.Padding(4);
            this.txtRFCGanadero.Name = "txtRFCGanadero";
            this.txtRFCGanadero.Size = new System.Drawing.Size(180, 27);
            this.txtRFCGanadero.TabIndex = 41;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(216, 273);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(76, 19);
            this.label16.TabIndex = 45;
            this.label16.Text = "ClaveUPP";
            // 
            // txtClaveUPPGanadero
            // 
            this.txtClaveUPPGanadero.Location = new System.Drawing.Point(310, 269);
            this.txtClaveUPPGanadero.Margin = new System.Windows.Forms.Padding(4);
            this.txtClaveUPPGanadero.Name = "txtClaveUPPGanadero";
            this.txtClaveUPPGanadero.Size = new System.Drawing.Size(180, 27);
            this.txtClaveUPPGanadero.TabIndex = 40;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(222, 235);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(74, 19);
            this.label10.TabIndex = 42;
            this.label10.Text = "Dirección";
            // 
            // txtDireccionGanadero
            // 
            this.txtDireccionGanadero.Location = new System.Drawing.Point(310, 231);
            this.txtDireccionGanadero.Margin = new System.Windows.Forms.Padding(4);
            this.txtDireccionGanadero.Name = "txtDireccionGanadero";
            this.txtDireccionGanadero.Size = new System.Drawing.Size(180, 27);
            this.txtDireccionGanadero.TabIndex = 39;
            // 
            // lstGanadero
            // 
            this.lstGanadero.DisplayMember = "Nombre";
            this.lstGanadero.FormattingEnabled = true;
            this.lstGanadero.ItemHeight = 19;
            this.lstGanadero.Location = new System.Drawing.Point(22, 102);
            this.lstGanadero.Margin = new System.Windows.Forms.Padding(4);
            this.lstGanadero.Name = "lstGanadero";
            this.lstGanadero.Size = new System.Drawing.Size(148, 289);
            this.lstGanadero.TabIndex = 50;
            this.lstGanadero.ValueMember = "_id";
            this.lstGanadero.SelectedIndexChanged += new System.EventHandler(this.lstGanadero_SelectedIndexChanged);
            // 
            // btnEliminarGanadero
            // 
            this.btnEliminarGanadero.Location = new System.Drawing.Point(263, 406);
            this.btnEliminarGanadero.Margin = new System.Windows.Forms.Padding(4);
            this.btnEliminarGanadero.Name = "btnEliminarGanadero";
            this.btnEliminarGanadero.Size = new System.Drawing.Size(112, 34);
            this.btnEliminarGanadero.TabIndex = 47;
            this.btnEliminarGanadero.Text = "Eliminar";
            this.btnEliminarGanadero.UseVisualStyleBackColor = true;
            this.btnEliminarGanadero.Click += new System.EventHandler(this.btnEliminarGanadero_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.Location = new System.Drawing.Point(378, 69);
            this.btnNuevo.Margin = new System.Windows.Forms.Padding(4);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(112, 34);
            this.btnNuevo.TabIndex = 49;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(238, 349);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(59, 19);
            this.label11.TabIndex = 36;
            this.label11.Text = "Estatus";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(227, 197);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(71, 19);
            this.label12.TabIndex = 34;
            this.label12.Text = "Teléfono";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(244, 158);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(57, 19);
            this.label13.TabIndex = 33;
            this.label13.Text = "Correo";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(234, 118);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(66, 19);
            this.label14.TabIndex = 32;
            this.label14.Text = "Nombre";
            // 
            // cbbEstatusGanadero
            // 
            this.cbbEstatusGanadero.AutoCompleteCustomSource.AddRange(new string[] {
            "Administrador",
            "Turista"});
            this.cbbEstatusGanadero.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbEstatusGanadero.FormattingEnabled = true;
            this.cbbEstatusGanadero.Items.AddRange(new object[] {
            "Activo",
            "Baja"});
            this.cbbEstatusGanadero.Location = new System.Drawing.Point(310, 345);
            this.cbbEstatusGanadero.Margin = new System.Windows.Forms.Padding(4);
            this.cbbEstatusGanadero.Name = "cbbEstatusGanadero";
            this.cbbEstatusGanadero.Size = new System.Drawing.Size(180, 27);
            this.cbbEstatusGanadero.TabIndex = 43;
            // 
            // txtTelefonoGanadero
            // 
            this.txtTelefonoGanadero.Location = new System.Drawing.Point(310, 193);
            this.txtTelefonoGanadero.Margin = new System.Windows.Forms.Padding(4);
            this.txtTelefonoGanadero.Name = "txtTelefonoGanadero";
            this.txtTelefonoGanadero.Size = new System.Drawing.Size(180, 27);
            this.txtTelefonoGanadero.TabIndex = 38;
            this.txtTelefonoGanadero.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTelefonoGanadero_KeyPress);
            // 
            // txtCorreoGanadero
            // 
            this.txtCorreoGanadero.Location = new System.Drawing.Point(310, 153);
            this.txtCorreoGanadero.Margin = new System.Windows.Forms.Padding(4);
            this.txtCorreoGanadero.Name = "txtCorreoGanadero";
            this.txtCorreoGanadero.Size = new System.Drawing.Size(180, 27);
            this.txtCorreoGanadero.TabIndex = 37;
            // 
            // txtNombreGanadero
            // 
            this.txtNombreGanadero.Location = new System.Drawing.Point(310, 114);
            this.txtNombreGanadero.Margin = new System.Windows.Forms.Padding(4);
            this.txtNombreGanadero.Name = "txtNombreGanadero";
            this.txtNombreGanadero.Size = new System.Drawing.Size(180, 27);
            this.txtNombreGanadero.TabIndex = 35;
            this.txtNombreGanadero.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombreGanadero_KeyPress);
            // 
            // btnRegistrarGanadero
            // 
            this.btnRegistrarGanadero.Location = new System.Drawing.Point(384, 406);
            this.btnRegistrarGanadero.Margin = new System.Windows.Forms.Padding(4);
            this.btnRegistrarGanadero.Name = "btnRegistrarGanadero";
            this.btnRegistrarGanadero.Size = new System.Drawing.Size(112, 34);
            this.btnRegistrarGanadero.TabIndex = 44;
            this.btnRegistrarGanadero.Text = "Guardar";
            this.btnRegistrarGanadero.UseVisualStyleBackColor = true;
            this.btnRegistrarGanadero.Click += new System.EventHandler(this.btnRegistrarGanadero_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.BackColor = System.Drawing.Color.Red;
            this.btnCerrar.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnCerrar.Location = new System.Drawing.Point(513, 13);
            this.btnCerrar.Margin = new System.Windows.Forms.Padding(4);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(33, 32);
            this.btnCerrar.TabIndex = 53;
            this.btnCerrar.Text = "X";
            this.btnCerrar.UseVisualStyleBackColor = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // btnVolver
            // 
            this.btnVolver.BackColor = System.Drawing.SystemColors.Menu;
            this.btnVolver.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolver.Location = new System.Drawing.Point(415, 13);
            this.btnVolver.Margin = new System.Windows.Forms.Padding(4);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(90, 30);
            this.btnVolver.TabIndex = 52;
            this.btnVolver.Text = "←";
            this.btnVolver.UseVisualStyleBackColor = false;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // frmGanadero
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::AdminGanado.Properties.Resources.caravaca;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(559, 474);
            this.ControlBox = false;
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.label35);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.txtRFCGanadero);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.txtClaveUPPGanadero);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtDireccionGanadero);
            this.Controls.Add(this.lstGanadero);
            this.Controls.Add(this.btnEliminarGanadero);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.cbbEstatusGanadero);
            this.Controls.Add(this.txtTelefonoGanadero);
            this.Controls.Add(this.txtCorreoGanadero);
            this.Controls.Add(this.txtNombreGanadero);
            this.Controls.Add(this.btnRegistrarGanadero);
            this.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmGanadero";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ganadero";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtRFCGanadero;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtClaveUPPGanadero;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtDireccionGanadero;
        private System.Windows.Forms.ListBox lstGanadero;
        private System.Windows.Forms.Button btnEliminarGanadero;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox cbbEstatusGanadero;
        private System.Windows.Forms.TextBox txtTelefonoGanadero;
        private System.Windows.Forms.TextBox txtCorreoGanadero;
        private System.Windows.Forms.TextBox txtNombreGanadero;
        private System.Windows.Forms.Button btnRegistrarGanadero;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Button btnVolver;
    }
}