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
    public partial class frmRegistroGanado : Form
    {
        public frmRegistroGanado()
        {
            InitializeComponent();
            LimpiarFormularioGanado();
            ValidarRadialButton();
            txtID.MaxLength = 3;
            txtPeso.MaxLength = 4;
        }

        #region Guardar
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            //Inicializamos los objetos necesarios
            Animal Item = new Animal();
            CrudAnimal Acciones = new CrudAnimal();

            //Validar el dueño
            Item._idGanado = ElegirGanado();

            //Se llena el objeto Item con sus respectivos datos
            Item.identificador = txtID.Text;
            Item.peso = double.Parse(txtPeso.Text);
            Item.edad = int.Parse(txtEdad.Text);
            Item.crias = int.Parse(txtCrias.Text);
            Item.raza = cbbRaza.Text;
            Item.salud = cbbSalud.Text;
            Item.sexo = char.Parse(cbbSexo.Text);
            Item.status = cbbEstatus.Text;
            Item.observaciones = txtObservaciones.Text;

            //Se registra la información en la BD
            Acciones.RegistrarAnimal(Item);

            //Mensaje de confirmación
            MessageBox.Show("Registrado", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

            //Limpiar formulario
            LimpiarFormularioGanado();
        }
        #endregion

        #region btnLimpiar
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarFormularioGanado();
        }
        #endregion

        #region Limpiar Formulario
        private void LimpiarFormularioGanado()
        {
            txtID.Clear();
            txtPeso.Text = "0";
            txtEdad.Value = 0;
            txtCrias.Value = 0;
            cbbEstatus.SelectedIndex = 0;
            cbbRaza.SelectedIndex = 0;
            cbbSalud.SelectedIndex = 0;
            cbbSexo.SelectedIndex = 0;
            txtObservaciones.Clear();
        }
        #endregion

        #region Validar radial button
        private void rbtnOrganizacion_CheckedChanged(object sender, EventArgs e)
        {
            ValidarRadialButton();
        }

        private void rbtnGanadero_CheckedChanged(object sender, EventArgs e)
        {
            ValidarRadialButton();
        }

        private void ValidarRadialButton()
        {
            if (rbtnOrganizacion.Checked == true)
            {
                cbbDueño.DataSource = CrudOrganizacion.ObtenerOrganizaciones();
            }
            else if (rbtnGanadero.Checked == true)
            {
                cbbDueño.DataSource = CrudGanadero.ObtenerGanaderos();
            }
        }
        #endregion

        #region Elegir Ganado
        private ObjectId ElegirGanado()
        {
            //Declaramos variables a utilizar
            List<Ganado> ListaGanado = CrudGanado.ObtenerGanados();
            ObjectId Dueño = new ObjectId();

            //Identificamos al dueño y extraemos el ID
            if (rbtnGanadero.Checked)
            {
                Ganadero aux = cbbDueño.SelectedItem as Ganadero;
                Dueño = aux._id;
            }
            else
            {
                Organizacion aux = cbbDueño.SelectedItem as Organizacion;
                Dueño = aux._id;
            }

            //Hacemos un recorrigo en la lista de Ganados a ver si existe ya un ganado vinculado
            foreach (Ganado g in ListaGanado)
            {
                if (g.fechaRegistro.ToString("dd/MM/yyyy") == DateTime.Today.ToString("dd/MM/yyyy") && g._idPropietario == Dueño)
                {
                    //Se actualiza el ganado ya existente
                    g.totalCabezas += 1;
                    if (cbbSexo.SelectedIndex == 0)
                    {
                        g.machos += 1;
                    }
                    else
                    {
                        g.hembras += 1;
                    }
                    if (int.Parse(txtEdad.Text) <= 3)
                    {
                        g.terneras += 1;
                    }
                    return CrudGanado.RegistrarGanado(g);
                }
            }

            //Si no existe uno, se crea un nuevo registro de ganado
            Ganado Item = new Ganado();
            Item._idPropietario = Dueño;
            Item.totalCabezas = 1;
            if (cbbSexo.SelectedIndex == 0)
            {
                Item.machos = 1;
            }
            else
            {
                Item.hembras = 1;
            }
            if (int.Parse(txtEdad.Text) <= 3)
            {
                Item.terneras = 1;
            }
            Item.fechaRegistro = DateTime.Today;

            //Regresamos el id del ganado
            return CrudGanado.RegistrarGanado(Item);
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

        private void txtPeso_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }
    }
}
