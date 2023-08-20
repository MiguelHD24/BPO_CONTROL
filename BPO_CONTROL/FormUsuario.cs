using BL;
using EL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BPO_CONTROL
{
    public partial class FormUsuario : Form
    {
        public int ID_Usuario { get; set; }
        public int ID_Registro { get; set; }
        public int Descanso { get; set; }
        public Usuario Mostrar { get; set; }
        public FormUsuario()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            
        }

        private void btnBreak1_Click(object sender, EventArgs e)
        {
            FormBreak1 formBreak1 = new FormBreak1();
            formBreak1.Show();
            
        }

        private void btnAlmuerzo_Click(object sender, EventArgs e)
        {
            FormAlmuerzo formAlmuerzo = new FormAlmuerzo();
            formAlmuerzo.Show();
            
        }

        private void btnBreak2_Click(object sender, EventArgs e)
        {
            FormBreak2 formBreak2 = new FormBreak2();
            formBreak2.Show();
            
        }

        private void btnCena_Click(object sender, EventArgs e)
        {
            FormCena formCena = new FormCena();
            formCena.Show();
            
        }

        //metodo para desactivar los botones desde la variable descanso
        public void DesactivarBotones()
        {
            if (Descanso == 1)
            {
                btnBreak1.Enabled = false;
            }
            else if (Descanso == 2)
            {
                btnBreak1.Enabled = false;
                btnAlmuerzo.Enabled = false;
            }
            else if (Descanso == 3)
            {
                btnBreak1.Enabled = false;
                btnAlmuerzo.Enabled = false;
                btnBreak2.Enabled = false;
            }
            else if (Descanso == 4)
            {
                btnBreak1.Enabled = false;
                btnAlmuerzo.Enabled = false;
                btnBreak2.Enabled = false;
                btnCena.Enabled = false;
            }
            else if (Descanso == 5)
            {
                btnBreak1.Enabled = false;
                btnAlmuerzo.Enabled = false;
                btnBreak2.Enabled = false;
                btnCena.Enabled = false;
                btnCerrarSesion.Enabled = false;
            }
        }

        private void FormUsuario_Load(object sender, EventArgs e)
        {
            DesactivarBotones();
            RegistroUsuario();
            MostrarHora();
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
        //metodo para mostrar la hora en el label con un timer
        public void MostrarHora()
        {
            timer1.Enabled = true;
            timer1.Interval = 1000;
            timer1.Start();
            timer1.Tick += new EventHandler(timer1_Tick);
        }
        private void MinimizarFormulario()
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            // Obtener la hora actual
            DateTime horaActual = DateTime.Now;

            // Actualizar el texto del Label con el formato deseado
            LabelHora.Text = horaActual.ToString("HH:mm:ss");
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            MinimizarFormulario();
        }
    }
}
