namespace AdminGanado
{
    partial class frmOrganizacion
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
            this.label34 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtDireccionOrganizacion = new System.Windows.Forms.TextBox();
            this.lstOrganizacion = new System.Windows.Forms.ListBox();
            this.btnEliminarOrganizacion = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cbbEstatusOrganizacion = new System.Windows.Forms.ComboBox();
            this.txtTelefonoOrganizacion = new System.Windows.Forms.TextBox();
            this.txtCorreoOrganizacion = new System.Windows.Forms.TextBox();
            this.txtNombreOrganizacion = new System.Windows.Forms.TextBox();
            this.btnRegistrarOrganizacion = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnVolver = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label34.Location = new System.Drawing.Point(10, 54);
            this.label34.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(160, 25);
            this.label34.TabIndex = 41;
            this.label34.Text = "Organizaciones:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(241, 238);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(74, 19);
            this.label9.TabIndex = 40;
            this.label9.Text = "Dirección";
            // 
            // txtDireccionOrganizacion
            // 
            this.txtDireccionOrganizacion.Location = new System.Drawing.Point(328, 233);
            this.txtDireccionOrganizacion.Margin = new System.Windows.Forms.Padding(4);
            this.txtDireccionOrganizacion.Name = "txtDireccionOrganizacion";
            this.txtDireccionOrganizacion.Size = new System.Drawing.Size(180, 27);
            this.txtDireccionOrganizacion.TabIndex = 29;
            // 
            // lstOrganizacion
            // 
            this.lstOrganizacion.DisplayMember = "Nombre";
            this.lstOrganizacion.FormattingEnabled = true;
            this.lstOrganizacion.ItemHeight = 19;
            this.lstOrganizacion.Location = new System.Drawing.Point(18, 95);
            this.lstOrganizacion.Margin = new System.Windows.Forms.Padding(4);
            this.lstOrganizacion.Name = "lstOrganizacion";
            this.lstOrganizacion.Size = new System.Drawing.Size(148, 232);
            this.lstOrganizacion.TabIndex = 39;
            this.lstOrganizacion.ValueMember = "_id";
            this.lstOrganizacion.SelectedIndexChanged += new System.EventHandler(this.lstOrganizacion_SelectedIndexChanged);
            // 
            // btnEliminarOrganizacion
            // 
            this.btnEliminarOrganizacion.Location = new System.Drawing.Point(276, 333);
            this.btnEliminarOrganizacion.Margin = new System.Windows.Forms.Padding(4);
            this.btnEliminarOrganizacion.Name = "btnEliminarOrganizacion";
            this.btnEliminarOrganizacion.Size = new System.Drawing.Size(112, 34);
            this.btnEliminarOrganizacion.TabIndex = 34;
            this.btnEliminarOrganizacion.Text = "Eliminar";
            this.btnEliminarOrganizacion.UseVisualStyleBackColor = true;
            this.btnEliminarOrganizacion.Visible = false;
            this.btnEliminarOrganizacion.Click += new System.EventHandler(this.btnEliminarOrganizacion_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(256, 281);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 19);
            this.label5.TabIndex = 38;
            this.label5.Text = "Estatus";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(246, 200);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 19);
            this.label6.TabIndex = 37;
            this.label6.Text = "Teléfono";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(262, 160);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 19);
            this.label7.TabIndex = 35;
            this.label7.Text = "Correo";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(253, 121);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(66, 19);
            this.label8.TabIndex = 33;
            this.label8.Text = "Nombre";
            // 
            // cbbEstatusOrganizacion
            // 
            this.cbbEstatusOrganizacion.AutoCompleteCustomSource.AddRange(new string[] {
            "Administrador",
            "Turista"});
            this.cbbEstatusOrganizacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbEstatusOrganizacion.FormattingEnabled = true;
            this.cbbEstatusOrganizacion.Items.AddRange(new object[] {
            "Activo",
            "Baja"});
            this.cbbEstatusOrganizacion.Location = new System.Drawing.Point(328, 271);
            this.cbbEstatusOrganizacion.Margin = new System.Windows.Forms.Padding(4);
            this.cbbEstatusOrganizacion.Name = "cbbEstatusOrganizacion";
            this.cbbEstatusOrganizacion.Size = new System.Drawing.Size(180, 27);
            this.cbbEstatusOrganizacion.TabIndex = 30;
            // 
            // txtTelefonoOrganizacion
            // 
            this.txtTelefonoOrganizacion.Location = new System.Drawing.Point(328, 195);
            this.txtTelefonoOrganizacion.Margin = new System.Windows.Forms.Padding(4);
            this.txtTelefonoOrganizacion.Name = "txtTelefonoOrganizacion";
            this.txtTelefonoOrganizacion.Size = new System.Drawing.Size(180, 27);
            this.txtTelefonoOrganizacion.TabIndex = 28;
            this.txtTelefonoOrganizacion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTelefonoOrganizacion_KeyPress);
            // 
            // txtCorreoOrganizacion
            // 
            this.txtCorreoOrganizacion.Location = new System.Drawing.Point(328, 156);
            this.txtCorreoOrganizacion.Margin = new System.Windows.Forms.Padding(4);
            this.txtCorreoOrganizacion.Name = "txtCorreoOrganizacion";
            this.txtCorreoOrganizacion.Size = new System.Drawing.Size(180, 27);
            this.txtCorreoOrganizacion.TabIndex = 27;
            // 
            // txtNombreOrganizacion
            // 
            this.txtNombreOrganizacion.Location = new System.Drawing.Point(328, 116);
            this.txtNombreOrganizacion.Margin = new System.Windows.Forms.Padding(4);
            this.txtNombreOrganizacion.Name = "txtNombreOrganizacion";
            this.txtNombreOrganizacion.Size = new System.Drawing.Size(180, 27);
            this.txtNombreOrganizacion.TabIndex = 26;
            this.txtNombreOrganizacion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombreOrganizacion_KeyPress);
            // 
            // btnRegistrarOrganizacion
            // 
            this.btnRegistrarOrganizacion.Location = new System.Drawing.Point(397, 333);
            this.btnRegistrarOrganizacion.Margin = new System.Windows.Forms.Padding(4);
            this.btnRegistrarOrganizacion.Name = "btnRegistrarOrganizacion";
            this.btnRegistrarOrganizacion.Size = new System.Drawing.Size(112, 34);
            this.btnRegistrarOrganizacion.TabIndex = 31;
            this.btnRegistrarOrganizacion.Text = "Guardar";
            this.btnRegistrarOrganizacion.UseVisualStyleBackColor = true;
            this.btnRegistrarOrganizacion.Click += new System.EventHandler(this.btnRegistrarOrganizacion_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.Location = new System.Drawing.Point(397, 74);
            this.btnNuevo.Margin = new System.Windows.Forms.Padding(4);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(112, 34);
            this.btnNuevo.TabIndex = 42;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnVolver
            // 
            this.btnVolver.BackColor = System.Drawing.SystemColors.Menu;
            this.btnVolver.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolver.Location = new System.Drawing.Point(397, 15);
            this.btnVolver.Margin = new System.Windows.Forms.Padding(4);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(90, 30);
            this.btnVolver.TabIndex = 43;
            this.btnVolver.Text = "←";
            this.btnVolver.UseVisualStyleBackColor = false;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.BackColor = System.Drawing.Color.Red;
            this.btnCerrar.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnCerrar.Location = new System.Drawing.Point(495, 13);
            this.btnCerrar.Margin = new System.Windows.Forms.Padding(4);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(33, 32);
            this.btnCerrar.TabIndex = 44;
            this.btnCerrar.Text = "X";
            this.btnCerrar.UseVisualStyleBackColor = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // frmOrganizacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::AdminGanado.Properties.Resources._31;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(541, 390);
            this.ControlBox = false;
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.label34);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtDireccionOrganizacion);
            this.Controls.Add(this.lstOrganizacion);
            this.Controls.Add(this.btnEliminarOrganizacion);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cbbEstatusOrganizacion);
            this.Controls.Add(this.txtTelefonoOrganizacion);
            this.Controls.Add(this.txtCorreoOrganizacion);
            this.Controls.Add(this.txtNombreOrganizacion);
            this.Controls.Add(this.btnRegistrarOrganizacion);
            this.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmOrganizacion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Organización";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtDireccionOrganizacion;
        private System.Windows.Forms.ListBox lstOrganizacion;
        private System.Windows.Forms.Button btnEliminarOrganizacion;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbbEstatusOrganizacion;
        private System.Windows.Forms.TextBox txtTelefonoOrganizacion;
        private System.Windows.Forms.TextBox txtCorreoOrganizacion;
        private System.Windows.Forms.TextBox txtNombreOrganizacion;
        private System.Windows.Forms.Button btnRegistrarOrganizacion;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Button btnCerrar;
    }
}