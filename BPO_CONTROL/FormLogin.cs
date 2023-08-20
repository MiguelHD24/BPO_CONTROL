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
    public partial class FormLogin : Form
    {
        public static int ID_Usuario;
        public static int ID_Registro;
        public static int ID_Tareas;
        public static int Descanso;
        public FormLogin()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void ButtonLogin_Click(object sender, EventArgs e)
        {

            if (BL_Usuario.ObtenerIDUsuarioSiCredencialesValidas(txtUsuario.Text, txtContraseña.Text) > 0)
            {
                //si se cumple el if, se asigna el valor de la variable publica
                ID_Usuario = BL_Usuario.ObtenerIDUsuarioSiCredencialesValidas(txtUsuario.Text, txtContraseña.Text);
                if (BL_Registro.ObtenerIDRegistroSiExiste(ID_Usuario) > 0)
                {
                    ID_Registro = BL_Registro.ObtenerIDRegistroSiExiste(ID_Usuario);

                    if (BL_Usuario.ObtenerIDRol(ID_Usuario) == 1)
                    {
                        FormAdministrador formAdministrador = new FormAdministrador();
                        formAdministrador.ID_Usuario = ID_Usuario; // Asignar a la propiedad del formulario
                        formAdministrador.ID_Registro = ID_Registro; // Asignar a la propiedad del formulario
                        formAdministrador.Show();

                        this.Hide();
                    }
                    else if (BL_Usuario.ObtenerIDRol(ID_Usuario) == 2)
                    {
                        Registro registro = new Registro();
                        registro.ID_Registro = ID_Registro;
                        if (BL_Registro.VerificarTarea(registro) == true)
                        {
                            FormTareas formTareas = new FormTareas();
                            formTareas.ID_Usuario = ID_Usuario; // Asignar a la propiedad del formulario
                            formTareas.ID_Registro = ID_Registro; // Asignar a la propiedad del formulario
                            formTareas.Show();

                            this.Hide();
                        }
                        else
                        {
                            Descanso = BL_Registro.VerificarRegistro(registro);
                            FormUsuario formUsuario = new FormUsuario();
                            formUsuario.Descanso = Descanso;
                            formUsuario.ID_Usuario = ID_Usuario; // Asignar a la propiedad del formulario
                            formUsuario.ID_Registro = ID_Registro; // Asignar a la propiedad del formulario
                            formUsuario.Show();
                            this.Hide();
                        }
                        
                    }
                    else if (BL_Usuario.ObtenerIDRol(ID_Usuario) == -1)
                    {
                        MessageBox.Show("Usuario o contraseña incorrectos");
                    }







                }
                else
                {
                    Registro registro = new Registro();
                    registro.ID_Usuario = ID_Usuario;
                    BL_Registro.Insert(registro);
                    ID_Registro = BL_Registro.ObtenerIDRegistroSiExiste(ID_Usuario);

                    if (BL_Usuario.ObtenerIDRol(ID_Usuario) == 1)
                    {
                        FormAdministrador formAdministrador = new FormAdministrador();
                        formAdministrador.ID_Usuario = ID_Usuario; // Asignar a la propiedad del formulario
                        formAdministrador.ID_Registro = ID_Registro; // Asignar a la propiedad del formulario
                        formAdministrador.Show();

                        this.Hide();
                    }
                    else if (BL_Usuario.ObtenerIDRol(ID_Usuario) == 2)
                    {
                        FormTareas formTareas = new FormTareas();
                        formTareas.ID_Usuario = ID_Usuario; // Asignar a la propiedad del formulario
                        formTareas.ID_Registro = ID_Registro; // Asignar a la propiedad del formulario
                        formTareas.Show();

                        this.Hide();
                    }
                    else if (BL_Usuario.ObtenerIDRol(ID_Usuario) == -1)
                    {
                        MessageBox.Show("Usuario o contraseña incorrectos");
                    }

                }

            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrectos");
            }
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
            LabelFecha.Text = "Fecha: " + DateTime.Now.ToString("dd/MM/yyyy");

            // Iniciar el Timer para actualizar la hora cada segundo
            Timer1.Interval = 1000; // Intervalo de actualización en milisegundos (1000 ms = 1 segundo)
            Timer1.Start();

        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            LabelHora.Text = "Hora: " + DateTime.Now.ToString("hh:mm:ss");
        }

        private void txtUsuario_Enter(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "USUARIO")
            {
                txtUsuario.Text = "";
                txtUsuario.ForeColor = Color.LightGray;
            }


        }

        private void txtUsuario_Leave(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "")
            {
                txtUsuario.Text = "USUARIO";
                txtUsuario.ForeColor = Color.LightGray;
            }


        }

        private void txtContraseña_Enter(object sender, EventArgs e)
        {
            if (txtContraseña.Text == "CONTRASEÑA")
            {
                txtContraseña.Text = "";
                txtContraseña.ForeColor = Color.LightGray;
                txtContraseña.UseSystemPasswordChar = true; // Ocultar caracteres de contraseña
            }
        }

        private void txtContraseña_Leave(object sender, EventArgs e)
        {
            if (txtContraseña.Text == "")
            {
                txtContraseña.Text = "CONTRASEÑA";
                txtContraseña.ForeColor = Color.DimGray;
                txtContraseña.UseSystemPasswordChar = false; // Mostrar caracteres de contraseña
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
            //cerra toda la aplicacion
            Application.Exit();
        }
    }
}
