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
    public partial class frmConsultaGanado : Form
    {
        public frmConsultaGanado()
        {
            InitializeComponent();
            ValidarRadialButton();
        }

        #region Seleccion de una fecha y mostrar datos
        private void lstFechas_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Inicializamos variables
            Ganado Item = lstFechas.SelectedItem as Ganado;
            List<Animal> ListaAnimales = new List<Animal>();
            List<Animal> Lista = CrudAnimal.ObtenerAnimales();

            //Asignamos valores a los textbox
            txtTotalCabezas.Text = Item.totalCabezas.ToString();
            txtTotalTerneras.Text = Item.terneras.ToString();
            txtTotalMachos.Text = Item.machos.ToString();
            txtTotalHembras.Text = Item.hembras.ToString();
            txtObservaciones.Text = Item.observaciones;

            //Mostramos lista de animales registrados
            foreach (Animal a in Lista)
            {
                if (a._idGanado == Item._id)
                {
                    //Se agrega a la lista
                    ListaAnimales.Add(a);
                }
            }

            //Se muestra la lista animales en el campo
            lstVacas.DataSource = ListaAnimales;
        }
        #endregion

        #region Actualizar lista de fecha
        private void cbbDueño_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Inicializamos variables
            List<Ganado> ListaGanado = CrudGanado.ObtenerGanados();
            List<Ganado> ListaFechas = new List<Ganado>();
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

            //Hacemos un recorrigo en la lista de Ganados y mostrar todos los registros por fecha
            foreach (Ganado g in ListaGanado)
            {
                if (g._idPropietario == Dueño)
                {
                    //Se agrega a la lista
                    ListaFechas.Add(g);
                }
            }

            //Se le asigna la lista al campo para mostrar
            lstFechas.DataSource = ListaFechas;
        }
        #endregion

        #region GuardarComentario
        private void btnGuardarComentario_Click(object sender, EventArgs e)
        {
            Ganado Item = lstFechas.SelectedItem as Ganado;
            Item.observaciones = txtObservaciones.Text;
            CrudGanado.RegistrarGanado(Item);
            //Mensaje de confirmación
            MessageBox.Show("Comentario guardado", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        #endregion

        #region Validar radialbutton
        private void rbtnGanadero_CheckedChanged(object sender, EventArgs e)
        {
            ValidarRadialButton();
        }

        private void rbtnOrganizacion_CheckedChanged(object sender, EventArgs e)
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

    }
}
