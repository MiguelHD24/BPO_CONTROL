using BL;
using EL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BPO_CONTROL
{
    public partial class FormBreak1 : Form
    {
        private Stopwatch cronometro = new Stopwatch();
        public static TimeSpan Break_1;
        public static int Descanso;
        public FormBreak1()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void btnRestaurarTimer_Click(object sender, EventArgs e)
        {
            // Detener el cronómetro y restablecer el tiempo a cero
            Registro Registro = new Registro();
            Registro.ID_Registro = FormLogin.ID_Registro;
            Registro.Break_1 = Break_1;
            if (BL_Registro.Break1(Registro)==true)
            {
                
                MessageBox.Show("Tiempo de Break 1 guardado correctamente");
            }
            else
            {
                MessageBox.Show("Error al guardar");
            }
            cronometro.Reset();
            LabelCronometro.Text = "00:00:00.00";

            // Ocultar el PictureBox SissaLogo
            SissaLogo.Visible = false;

            // Configurar la visibilidad de los botones
            btnIniciarCronometro.Visible = false;
            btnDetenerCronometro.Visible = false;
            btnRestaurarTimer.Enabled = false;
            btn_Regresar.Enabled = true;
            btn_Regresar.Visible = true;


        }
       
        
        private void FormBreak1_Load(object sender, EventArgs e)
        {
            // Inicializar el cronómetro
            cronometro = new Stopwatch();

            // Configurar el Label del cronómetro con el formato inicial "00:00:00.00"
            LabelCronometro.Text = "00:00:00.00";

            // Configurar la visibilidad de los botones
            btnDetenerCronometro.Visible = false;
            btnRestaurarTimer.Enabled = false;
            btn_Regresar.Enabled = false;
            btn_Regresar.Visible = false;

        }

        private void timer_Cronometro_Tick(object sender, EventArgs e)
        {
            // Actualizar el Label con el tiempo transcurrido del cronómetro, incluyendo los microsegundos
            LabelCronometro.Text = cronometro.Elapsed.ToString("hh\\:mm\\:ss\\.ff");
        }

        private void btnDetenerCronometro_Click(object sender, EventArgs e)
        {
            // Detener el cronómetro solo si está en marcha
            if (cronometro.IsRunning)
            {
                cronometro.Stop();
                timer_Cronometro.Stop();
                //guardar el tiempo en la variable
                Break_1 = cronometro.Elapsed;


                // Configurar la visibilidad de los botones
                btnDetenerCronometro.Visible = false;
                btnIniciarCronometro.Visible = false;
                btnRestaurarTimer.Enabled = true;
                btn_Regresar.Enabled = false;
                btn_Regresar.Visible = false;

                // Mostrar el PictureBox SissaLogo
                SissaLogo.Visible = true;
                
            }
        }

        private void btnIniciarCronometro_Click(object sender, EventArgs e)
        {
            // Iniciar el cronómetro solo si no está en marcha
            if (!cronometro.IsRunning)
            {
                cronometro.Start();
                timer_Cronometro.Start();

                // Configurar la visibilidad de los botones
                btnIniciarCronometro.Visible = false;
                btnDetenerCronometro.Visible = true;
                btnRestaurarTimer.Enabled = false;
                btn_Regresar.Enabled = false;
                btn_Regresar.Visible = false;

                // Ocultar el PictureBox SissaLogo
                SissaLogo.Visible = false;
            }
        }

        private void btn_Regresar_Click(object sender, EventArgs e)
        {
            Descanso = 1;
            FormUsuario formUsuario = new FormUsuario();
            formUsuario.Descanso = Descanso;
            formUsuario.Show();
            this.Close();
        }
    }
}
