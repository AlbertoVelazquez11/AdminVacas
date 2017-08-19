using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdminGanado
{
    public partial class frmPruebas : Form
    {
        public frmPruebas()
        {
            InitializeComponent();
            //Inicializadores por modulos
            #region Usuario
            cbbTipoUsuario.SelectedIndex = 0;
            ActualizarListaUsuario();
            LimpiarFormularioUsuario();
            #endregion

            #region Organizacion
            ActualizarListaOrganizacion();
            LimpiarFormularioOrganizacion();
            #endregion

        }
        //MODULOS
        //Usuarios
        #region Usuarios

        #region Registrar
        private void btnRegistrarUsuario_Click(object sender, EventArgs e)
        {
            //Inicializamos los objetos necesarios
            Usuario Item = new Usuario();
            CrudUsuario Acciones = new CrudUsuario();

            //Se llena el objeto Item con sus respectivos datos
            Item.nombre = txtNombreUsuario.Text;
            Item.correo = txtCorreoUsuario.Text;
            Item.contraseña = txtContraseña.Text;
            Item.tipo = cbbTipoUsuario.Text;

            //Se registra la información en la BD
            Acciones.RegistrarUsuario(Item);

            //Mensaje de confirmación
            MessageBox.Show("Registrado", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

            //Actualizar lista
            ActualizarListaUsuario();

            //Limpiar formulario
            LimpiarFormularioUsuario();
        }
        #endregion

        #region Modificar
        private void btnModificarUsuario_Click(object sender, EventArgs e)
        {
            //Inicializamos los objetos necesarios
            Usuario Item = lstUsuario.SelectedItem as Usuario;
            CrudUsuario Acciones = new CrudUsuario();

            //Se llena el objeto Item con sus respectivos datos
            Item.nombre = txtNombreUsuario.Text;
            Item.correo = txtCorreoUsuario.Text;
            Item.contraseña = txtContraseña.Text;
            Item.tipo = cbbTipoUsuario.Text;

            //Se registra la información en la BD
            Acciones.RegistrarUsuario(Item);

            //Mensaje de confirmación
            MessageBox.Show("Modificado", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

            //Actualizar lista
            ActualizarListaUsuario();

            //Limpiar formulario
            LimpiarFormularioUsuario();
        }
        #endregion

        #region Eliminar
        private void btnEliminarUsuario_Click(object sender, EventArgs e)
        {
            //Inicializamos los objetos necesarios
            Usuario Item = lstUsuario.SelectedItem as Usuario;

            //Eliminamos
            CrudUsuario.EliminarUsuario(Item._id);

            //Mensaje de confirmación
            MessageBox.Show("Eliminado", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            //Actualizar lista
            ActualizarListaUsuario();

            //Limpiar formulario
            LimpiarFormularioUsuario();
        }
        #endregion

        #region Limpiar formulario
        private void btnLimpiarFormularioUsuario_Click(object sender, EventArgs e)
        {
            LimpiarFormularioUsuario();
        }
        public void LimpiarFormularioUsuario()
        {
            txtNombreUsuario.Clear();
            txtCorreoUsuario.Clear();
            txtContraseña.Clear();
            cbbTipoUsuario.SelectedIndex = 0;
        }
        #endregion

        #region Selección de la lista
        private void lstUsuario_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Inicializamos los objetos necesarios
            Usuario Item = lstUsuario.SelectedItem as Usuario;

            //Llenar campos
            txtNombreUsuario.Text = Item.nombre;
            txtCorreoUsuario.Text = Item.correo;
            txtContraseña.Text = Item.contraseña;
            cbbTipoUsuario.Text = Item.tipo;
        }
        #endregion

        #region Actualizar lista
        public void ActualizarListaUsuario()
        {
            lstUsuario.DataSource = CrudUsuario.ObtenerUsuarios();
        }
        #endregion

        #endregion

        //Organización
        #region Organizacion

        #region Registrar
        private void btnRegistrarOrganizacion_Click(object sender, EventArgs e)
        {
            //Inicializamos los objetos necesarios
            Organizacion Item = new Organizacion();
            CrudOrganizacion Acciones = new CrudOrganizacion();

            //Se llena el objeto Item con sus respectivos datos
            Item.nombre = txtNombreOrganizacion.Text;
            Item.correo = txtCorreoOrganizacion.Text;
            Item.telefono = txtTelefonoOrganizacion.Text;
            Item.direccion = txtDireccionOrganizacion.Text;
            Item.estatus = cbbEstatusOrganizacion.Text;

            //Se registra la información en la BD
            Acciones.RegistrarOrganizacion(Item);

            //Mensaje de confirmación
            MessageBox.Show("Registrado", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

            //Actualizar lista
            ActualizarListaOrganizacion();

            //Limpiar formulario
            LimpiarFormularioOrganizacion();
        }
        #endregion

        #region Modificar
        private void btnModificarOrganizacion_Click(object sender, EventArgs e)
        {
            //Inicializamos los objetos necesarios
            Organizacion Item = lstOrganizacion.SelectedItem as Organizacion;
            CrudOrganizacion Acciones = new CrudOrganizacion();

            //Se llena el objeto Item con sus respectivos datos
            Item.nombre = txtNombreOrganizacion.Text;
            Item.correo = txtCorreoOrganizacion.Text;
            Item.telefono = txtTelefonoOrganizacion.Text;
            Item.direccion = txtDireccionOrganizacion.Text;
            Item.estatus = cbbEstatusOrganizacion.Text;

            //Se registra la información en la BD
            Acciones.RegistrarOrganizacion(Item);

            //Mensaje de confirmación
            MessageBox.Show("Modificado", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

            //Actualizar lista
            ActualizarListaOrganizacion();

            //Limpiar formulario
            LimpiarFormularioOrganizacion();
        }
        #endregion

        #region Eliminar
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
        private void btnLimpiarFormularioOrganizacion_Click(object sender, EventArgs e)
        {
            LimpiarFormularioOrganizacion();
        }

        public void LimpiarFormularioOrganizacion()
        {
            txtNombreOrganizacion.Clear();
            txtCorreoOrganizacion.Clear();
            txtDireccionOrganizacion.Clear();
            txtTelefonoOrganizacion.Clear();
            cbbEstatusOrganizacion.SelectedIndex = 0;
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
        }
        #endregion

        #region Actualizar lista
        public void ActualizarListaOrganizacion()
        {
            lstOrganizacion.DataSource = CrudOrganizacion.ObtenerOrganizaciones();
        }
        #endregion

        #endregion

        //Ganadero
        #region Ganadero

        #region Registrar
        private void btnRegistrarGanadero_Click(object sender, EventArgs e)
        {
            //Inicializamos los objetos necesarios
            Ganadero Item = new Ganadero();
            CrudGanadero Acciones = new CrudGanadero();

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
            MessageBox.Show("Registrado", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

            //Actualizar lista
            ActualizarListaGanadero();

            //Limpiar formulario
            LimpiarFormularioGanadero();
        }
        #endregion

        #region Modificar
        private void btnModificarGanadero_Click(object sender, EventArgs e)
        {
            //Inicializamos los objetos necesarios
            Ganadero Item = lstGanadero.SelectedItem as Ganadero;
            CrudGanadero Acciones = new CrudGanadero();

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
            MessageBox.Show("Modificado", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

            //Actualizar lista
            ActualizarListaGanadero();

            //Limpiar formulario
            LimpiarFormularioGanadero();
        }
        #endregion

        #region Eliminar
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
        }
        #endregion

        #region Actualizar lista
        public void ActualizarListaGanadero()
        {
            lstGanadero.DataSource = CrudGanadero.ObtenerGanaderos();
        }
        #endregion

        #endregion

        //Ganado
        #region Ganado

        #region Registrar
        #endregion

        #region Modificar
        #endregion

        #region Eliminar
        #endregion

        #region Limpiar Formulario
        #endregion

        #region Selección de la lista
        #endregion

        #region Actualizar lista
        #endregion

        #endregion

        //Animal
        #region Animal

        #region Registrar
        #endregion

        #region Modificar
        #endregion

        #region Eliminar
        #endregion

        #region Limpiar Formulario
        #endregion

        #region Selección de la lista
        #endregion

        #region Actualizar lista
        #endregion

        #endregion
    }
}
