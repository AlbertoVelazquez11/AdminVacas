using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;


namespace AdminGanado
{
    public partial class frmGanadero : Form
    {
        public frmGanadero()
        {
            InitializeComponent();
            ActualizarListaGanadero();
            LimpiarFormularioGanadero();
            txtNombreGanadero.MaxLength = 50;
            txtTelefonoGanadero.MaxLength = 10;
            txtDireccionGanadero.MaxLength = 50;
        }

        #region btnGuardar
        private void btnRegistrarGanadero_Click(object sender, EventArgs e)
        {
            //Inicializamos los objetos necesarios
            Ganadero Item = new Ganadero();
            CrudGanadero Acciones = new CrudGanadero();
            bool bandera = false;
            //Validamos el correo
            String expresion = "\\w+([-+.']\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*";
            bool verificado = false;

            if (Regex.IsMatch(txtCorreoGanadero.Text, expresion))
            {
                if (Regex.Replace(txtCorreoGanadero.Text, expresion, String.Empty).Length == 0)
                {
                    verificado = true;
                }
            }

            if (verificado == true)
            {
                //Verificar si es una modificación
                if (btnEliminarGanadero.Visible == true)
                {
                    Ganadero I = lstGanadero.SelectedItem as Ganadero;
                    Item._id = I._id;
                    bandera = true;
                }

                //Se llena el objeto Item con sus respectivos datos
                Item.nombre = txtNombreGanadero.Text;
                Item.correo = txtCorreoGanadero.Text;
                Item.telefono = txtTelefonoGanadero.Text;
                Item.direccion = txtDireccionGanadero.Text;
                Item.claveUPP = txtClaveUPPGanadero.Text;
                Item.RFC = txtRFCGanadero.Text;
                Item.estatus = cbbEstatusGanadero.Text;

                //Se registra la información en la BD
                Acciones.RegistrarGanadero(Item);

                //Mensaje de confirmación
                if (bandera == false)
                {
                    MessageBox.Show("Registrado", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Modificado", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                //Actualizar lista
                ActualizarListaGanadero();

                //Limpiar formulario
                LimpiarFormularioGanadero();
            }
            else
            {
                MessageBox.Show("Correo no válido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        #endregion

        #region btnNuevo
        private void btnNuevo_Click(object sender, EventArgs e)
        {
            LimpiarFormularioGanadero();
        }
        #endregion

        #region btnEliminar
        private void btnEliminarGanadero_Click(object sender, EventArgs e)
        {
            //Inicializamos los objetos necesarios
            Ganadero Item = lstGanadero.SelectedItem as Ganadero;

            //Eliminamos
            CrudGanadero.EliminarGanadero(Item._id);

            //Mensaje de confirmación
            MessageBox.Show("Eliminado", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            //Actualizar lista
            ActualizarListaGanadero();

            //Limpiar formulario
            LimpiarFormularioGanadero();
        }
        #endregion

        #region Limpiar Formulario
        private void btnLimpiarFormularioGanadero_Click(object sender, EventArgs e)
        {
            LimpiarFormularioGanadero();
        }
        public void LimpiarFormularioGanadero()
        {
            txtNombreGanadero.Clear();
            txtCorreoGanadero.Clear();
            txtTelefonoGanadero.Clear();
            txtDireccionGanadero.Clear();
            txtRFCGanadero.Clear();
            txtClaveUPPGanadero.Clear();
            cbbEstatusGanadero.SelectedIndex = 0;
            this.btnEliminarGanadero.Visible = false;
        }
        #endregion

        #region Selección de la lista
        private void lstGanadero_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Inicializamos los objetos necesarios
            Ganadero Item = lstGanadero.SelectedItem as Ganadero;

            //Llenar campos
            txtNombreGanadero.Text = Item.nombre;
            txtCorreoGanadero.Text = Item.correo;
            txtTelefonoGanadero.Text = Item.telefono;
            txtRFCGanadero.Text = Item.RFC;
            txtClaveUPPGanadero.Text = Item.claveUPP;
            txtDireccionGanadero.Text = Item.direccion;
            cbbEstatusGanadero.Text = Item.estatus;
            this.btnEliminarGanadero.Visible = true;
        }
        #endregion

        #region Actualizar lista
        public void ActualizarListaGanadero()
        {
            lstGanadero.DataSource = CrudGanadero.ObtenerGanaderos();
        }
        #endregion

        #region Cerrar y volver
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            frmOpciones Opc = new frmOpciones();
            Opc.Show();
            this.Close();
        }
        #endregion

        //VALIDAMOS QUE LOS CAMPOS SEAN LLENADOS CON LOS CARACTERES CORRECTOS
        private void txtTelefonoGanadero_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }

        private void txtNombreGanadero_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
                base.OnKeyPress(e);
            }
        }
    }
}
