using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdminGanado
{
    public partial class frmInicio : Form
    {
        public frmInicio()
        {
            InitializeComponent();
            //LIMITAMOS LA LONGITUD DE LOS TEXTBOX
            txtUsuario.MaxLength = 15;
            txtContraseña.MaxLength = 15;
            BuscarUsuarioRecordado();
        }

        #region Aceptar
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            //INICIALIZAMOS VARIABLES
            string Usuario = txtUsuario.Text;
            string Password = txtContraseña.Text;
            Usuario Credencial = new Usuario();
            bool Bandera = true;

            //VALIDAMOS QUE NO ESTEN LOS CAMPOS VACIOS
            if (Usuario == "")
            {
                MessageBox.Show("Favor de introducir el nombre del Usuario", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                Bandera = false;
            }

            if (Password == "")
            {
                MessageBox.Show("Favor de introducir la Contraseña", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                Bandera = false;
            }

            if (Bandera == true)
            {
                //CARGAMOS LA LISTA DE USUARIOS Y VERIFICAMOS QUE EXISTA
                List<Usuario> ListaUsuarios = CrudUsuario.ObtenerUsuarios();
                foreach (Usuario u in ListaUsuarios)
                {
                    if (Usuario == u.nombre)
                    {
                        Credencial = u;
                        Bandera = false;
                        break;
                    }
                }

                //MENSAJE EN CASO DE NO EXISTIR EL USUARIO
                if (Bandera == true)
                {
                    MessageBox.Show("Usuario no existe", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                if (Bandera == false)
                {
                    //VALIDACION SI LA CONTRASEÑA COINCIDE CON LA DEL USUARIO
                    if (Credencial.contraseña == Password)
                    {
                        frmOpciones Catalogo = new frmOpciones();
                        MessageBox.Show("Bienvenido de nuevo " + Usuario, "Acceso autorizado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Catalogo.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Contraseña incorrecta", "Acceso denegado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }//FIN BOTN ACEPTAR
        #endregion

        #region Cancelar
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.txtUsuario.Clear();
            this.txtContraseña.Clear();
        }
        #endregion

        #region Pruebas
        private void btnPruebas_Click(object sender, EventArgs e)
        {
            frmPruebas Catalogo = new frmPruebas();
            Catalogo.Show();
        }
        #endregion

        #region Control de recordar usuario
        private void BuscarUsuarioRecordado()
        {
            if (File.Exists(@"C:\Users\Alberto\Documents\usuario.txt"))
            {
                StreamReader Usuario = new StreamReader(@"C:\Users\Alberto\Documents\usuario.txt");
                txtUsuario.Text = Usuario.ReadLine();
                Usuario.Close();
                cbRecordar.Checked = true;
            }
        }

        private void cbRecordar_CheckedChanged(object sender, EventArgs e)
        {
            if (this.cbRecordar.Checked == true)
            {
                StreamWriter Usuario = new StreamWriter(@"C:\Users\Alberto\Documents\usuario.txt");
                Usuario.WriteLine(this.txtUsuario.Text);
                Usuario.Close();
            }
            else
            {
                if (File.Exists(@"C:\Users\Alberto\Documents\usuario.txt"))
                {
                    System.IO.File.Delete(@"C:\Users\Alberto\Documents\usuario.txt");
                }
            }
        }//Fin del metodo Recordar Usuario

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {
            cbRecordar.Checked = false;
        }
        #endregion

    }
}
