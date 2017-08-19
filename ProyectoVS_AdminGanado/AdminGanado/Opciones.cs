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
    public partial class frmOpciones : Form
    {
        public frmOpciones()
        {
            InitializeComponent();
        }

        #region btnOrganizacion
        private void btnOrganizacion_Click(object sender, EventArgs e)
        {
            frmOrganizacion form = new frmOrganizacion();
            form.Show();
            this.Close();
        }
        #endregion

        #region btnGanadero
        private void btnGanadero_Click(object sender, EventArgs e)
        {
            frmGanadero form = new frmGanadero();
            form.Show();
            this.Close();
        }
        #endregion

        #region btnGanado
        private void btnGanado_Click(object sender, EventArgs e)
        {
            frmRegistroGanado form = new frmRegistroGanado();
            form.Show();
            this.Close();
        }
        #endregion

        #region btnConsultarGanado
        private void btnConsultar_Click(object sender, EventArgs e)
        {
            frmConsultaGanado form = new frmConsultaGanado();
            form.Show();
            this.Close();
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
