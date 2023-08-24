using BL;
using EL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BPO_CONTROL
{
    public partial class FormAdministrador : Form
    {
        public int ID_Usuario { get; set; }
        public int ID_Registro { get; set; }
        public FormAdministrador()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void PanelBarraTitulo_Paint(object sender, PaintEventArgs e)
        {

        }
        private void RegistroUsuario()
        {

            Usuario usuario = new Usuario();
            usuario.ID_Usuario = ID_Usuario;

            Usuario Mostrar = BL_Usuario.Registro(usuario);


            if (Mostrar != null)
            {

                LabelUsuario.Text = Mostrar.NumeroCedula;
                Labelnombres.Text = Mostrar.Nombres;
                Labelapellidos.Text = Mostrar.Apellidos;
            }
            else
            {
                LabelUsuario.Text = "No se encontro Usuario";
            }
        }
        private void FormAdministrador_Load(object sender, EventArgs e)
        {
            RegistroUsuario();
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("¿Deseas registrar Salida laboral?", "Mensaje de Alerta", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

            if (resultado == DialogResult.OK)
            {
                Registro registro = new Registro();
                registro.ID_Registro = ID_Registro;
                if (BL_Registro.Salida(registro))
                {
                    MessageBox.Show("Salida registrada.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    FormLogin formLogin = new FormLogin();
                    formLogin.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Error al registrar Salida.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else if (resultado == DialogResult.Cancel)
            {
                FormLogin formLogin = new FormLogin();
                formLogin.Show();
                this.Hide();
            }
        }
        private void MinimizarFormulario()
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            MinimizarFormulario();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnUsuario_Click(object sender, EventArgs e)
        {
            FormAgregar formAgregar = new FormAgregar();
            formAgregar.Show();

        }
    }
}
