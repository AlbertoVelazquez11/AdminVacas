using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdminGanado
{
    public partial class frmOrganizacion : Form
    {
        public frmOrganizacion()
        {
            InitializeComponent();
            ActualizarListaOrganizacion();
            LimpiarFormularioOrganizacion();
            txtNombreOrganizacion.MaxLength = 50;
            txtTelefonoOrganizacion.MaxLength = 10;
            txtDireccionOrganizacion.MaxLength = 50;
        }

        #region btnGuardar

        private void btnRegistrarOrganizacion_Click(object sender, EventArgs e)
        {
            //VALIDAR CORREO ELECTRÓNICO

            //Inicializamos los objetos necesarios
            Organizacion Item = new Organizacion();
            CrudOrganizacion Acciones = new CrudOrganizacion();
            bool bandera = false;
            String expresion = "\\w+([-+.']\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*";
            bool verificado = false;

            if (Regex.IsMatch(txtCorreoOrganizacion.Text, expresion))
            {
                if (Regex.Replace(txtCorreoOrganizacion.Text, expresion, String.Empty).Length == 0)
                {
                    verificado = true;
                }
            }

            //Confirmar correo valido
            if (verificado == true)
            {

                //Verificar si es una modificación
                if (btnEliminarOrganizacion.Visible == true)
                {
                    Organizacion I = lstOrganizacion.SelectedItem as Organizacion;
                    Item._id = I._id;
                    bandera = true;
                }

                //Se llena el objeto Item con sus respectivos datos
                Item.nombre = txtNombreOrganizacion.Text;
                Item.correo = txtCorreoOrganizacion.Text;
                Item.telefono = txtTelefonoOrganizacion.Text;
                Item.direccion = txtDireccionOrganizacion.Text;
                Item.estatus = cbbEstatusOrganizacion.Text;

                //Se registra la información en la BD
                Acciones.RegistrarOrganizacion(Item);

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
                ActualizarListaOrganizacion();

                //Limpiar formulario
                LimpiarFormularioOrganizacion();
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
            LimpiarFormularioOrganizacion();
        }
        #endregion

        #region btnEliminar
        private void btnEliminarOrganizacion_Click(object sender, EventArgs e)
        {
            //Inicializamos los objetos necesarios
            Organizacion Item = lstOrganizacion.SelectedItem as Organizacion;

            //Eliminamos
            CrudOrganizacion.EliminarOrganizacion(Item._id);

            //Mensaje de confirmación
            MessageBox.Show("Eliminado", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            //Actualizar lista
            ActualizarListaOrganizacion();

            //Limpiar formulario
            LimpiarFormularioOrganizacion();
        }
        #endregion

        #region Limpiar formulario
        public void LimpiarFormularioOrganizacion()
        {
            txtNombreOrganizacion.Clear();
            txtCorreoOrganizacion.Clear();
            txtDireccionOrganizacion.Clear();
            txtTelefonoOrganizacion.Clear();
            cbbEstatusOrganizacion.SelectedIndex = 0;
            //Esconder el boton de eliminar
            this.btnEliminarOrganizacion.Visible = false;
        }
        #endregion

        #region Selección de la lista
        private void lstOrganizacion_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Inicializamos los objetos necesarios
            Organizacion Item = lstOrganizacion.SelectedItem as Organizacion;

            //Llenar campos
            txtNombreOrganizacion.Text = Item.nombre;
            txtCorreoOrganizacion.Text = Item.correo;
            txtTelefonoOrganizacion.Text = Item.telefono;
            txtDireccionOrganizacion.Text = Item.direccion;
            cbbEstatusOrganizacion.Text = Item.estatus;
            this.btnEliminarOrganizacion.Visible = true;
        }
        #endregion

        #region Actualizar lista
        public void ActualizarListaOrganizacion()
        {
            lstOrganizacion.DataSource = CrudOrganizacion.ObtenerOrganizaciones();
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
        private void txtTelefonoOrganizacion_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }

        private void txtNombreOrganizacion_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
                base.OnKeyPress(e);
            }
        }
    }
}
