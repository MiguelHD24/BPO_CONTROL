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
    public partial class FormAgregar : Form
    {
        
        public FormAgregar()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void FormAgregar_Load(object sender, EventArgs e)
        {
            cargarCombobox();
        }
        private void cargarCombobox()
        {
            List<Roles> listaRoles = BL_Roles.ListarRoles();

            DDLROL.DisplayMember = "Rol_Nombres"; // Mostrará el nombre del rol
            DDLROL.ValueMember = "ID_Rol"; // El valor asociado será el ID del rol
            DDLROL.DataSource = listaRoles;

        }
        private void LimpiarControles()
        {
            txtNombres.Text = string.Empty;
            txtApellidos.Text = string.Empty;
            txtUsuarioA.Text = string.Empty;
            txtPassword.Text = string.Empty;
            DDLROL.Text = string.Empty;
        }

        private void verificarInsert()
        {
            if (txtNombres.Text == string.Empty)
            {
                MessageBox.Show("Debe ingresar un nombre");
                txtNombres.Focus();
                return;
            }
            else if (txtApellidos.Text == string.Empty)
            {
                MessageBox.Show("Debe ingresar un apellido");
                txtApellidos.Focus();
                return;
            }
            else if (txtUsuarioA.Text == string.Empty)
            {
                MessageBox.Show("Debe ingresar un usuario");
                txtUsuarioA.Focus();
                return;
            }
            else if (txtPassword.Text == string.Empty)
            {
                MessageBox.Show("Debe ingresar una contraseña");
                txtPassword.Focus();
                return;
            }
            else if (DDLROL.Text == string.Empty)
            {
                MessageBox.Show("Debe ingresar un rol");
                DDLROL.Focus();
                return;
            }
            else
            {
                //Insertar en la base de datos 
                EL.Usuario Entidad = new EL.Usuario();
                Entidad.Nombres = txtNombres.Text;
                Entidad.Apellidos = txtApellidos.Text;
                Entidad.NumeroCedula = txtUsuarioA.Text;
                Entidad.Password = txtPassword.Text;
                Entidad.ID_Rol = Convert.ToInt32(DDLROL.SelectedValue);
                if (BL_Usuario.Insert(Entidad) != null)
                {
                    MessageBox.Show("Usuario agregado correctamente");
                    
                }
                else
                {
                    MessageBox.Show("Error al agregar usuario");
                }
                


            }

        }
        
        


        private void btnGuardar_Click(object sender, EventArgs e)
        {
            verificarInsert();
        }

        private void DDLROL_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (DDLROL.SelectedValue != null)
            {
                int selectedRoleId = Convert.ToInt32(DDLROL.SelectedValue);

                
            }
        }
    }
}
