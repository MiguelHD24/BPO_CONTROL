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
        private void verificarFormularioSecundario()
        {
            // Crear una instancia del formulario secundario FormCrud
            FormCrud formCrud = new FormCrud();

            // Verificar si el formulario FormCrud está abierto en el panel PanelForm
            bool isFormOpen = IsFormOpenInPanel(formCrud, PanelForm);

            if (!isFormOpen)
            {
                PictureBox1.Visible = true;
            }
        }
        private void FormAdministrador_Load(object sender, EventArgs e)
        {
            RegistroUsuario();
            verificarFormularioSecundario();
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
        private void RecargarFormulario()
        {
            this.Controls.Clear(); // Limpia los controles del formulario
            InitializeComponent(); // Vuelve a inicializar los componentes
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

        // Verificar si el formulario está abierto en el panel
        bool IsFormOpenInPanel(Form form, Panel panel)
        {
            foreach (Control control in panel.Controls)
            {
                if (control is Form formulario && formulario.GetType() == form.GetType())
                {
                    return true; // El formulario está abierto en el panel
                }
            }
            return false; // El formulario no está abierto en el panel
        }
        private void AbrirFormularioCrud()
        {
            // Verifica si el formulario CRUD ya está abierto
            FormCrud formCrud = Application.OpenForms.OfType<FormCrud>().FirstOrDefault();

            if (formCrud == null)
            {
                formCrud = new FormCrud();
                formCrud.TopLevel = false; // Indica que no es un formulario de nivel superior
                formCrud.FormBorderStyle = FormBorderStyle.None; // Quita los bordes del formulario
                formCrud.Dock = DockStyle.Fill; // Rellena el panel con el formulario

                PanelForm.Controls.Add(formCrud); // Agrega el formulario al panel
                PanelForm.Tag = formCrud; // Almacena una referencia al formulario en el Tag del panel

                formCrud.Show(); // Muestra el formulario
            }
            else
            {
                // Si el formulario ya está abierto, que lo cierre y deje el panel vacío 
                formCrud.Close();
                PanelForm.Controls.RemoveByKey("FormCrud");
                PictureBox1.Visible = true;
                
            }
        }

        private void btnUsuario_Click(object sender, EventArgs e)
        {
            AbrirFormularioCrud();
            PictureBox1.Visible = false;

        }

        private void PanelForm_Paint(object sender, PaintEventArgs e)
        {
            //verificar si el formulario FormCrud esta abierto en el panel PanelForm
            bool isFormOpen = IsFormOpenInPanel(new FormCrud(), PanelForm);
            if (isFormOpen)
            {
                PictureBox1.Visible = false;
            }
            else
            {
                PictureBox1.Visible = true;



            }
        }
    }
    
}
