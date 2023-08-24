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
    public partial class FormEditar : Form
    {
        public int ID_Usuario { get; set; }
      
        public FormEditar()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            verificarUpdate();
        }
        
        private void cargarCombobox()
        {
            List<Roles> listaRoles = BL_Roles.ListarRoles();

            DDLROL.DisplayMember = "Rol_Nombres"; // Mostrará el nombre del rol
            DDLROL.ValueMember = "ID_Rol"; // El valor asociado será el ID del rol
            DDLROL.DataSource = listaRoles;

        }

        private void verificarUpdate()
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
                //Editar en la base de datos 
                EL.Usuario Entidad = new EL.Usuario();
                Entidad.ID_Usuario = ID_Usuario;
                Entidad.Nombres = txtNombres.Text;
                Entidad.Apellidos = txtApellidos.Text;
                Entidad.NumeroCedula = txtUsuarioA.Text;
                Entidad.Password = txtPassword.Text;
                Entidad.ID_Rol = Convert.ToInt32(DDLROL.SelectedValue);
                if (BL_Usuario.Update(Entidad) == true)
                {
                    MessageBox.Show("Usuario actualizado correctamente");

                }
                else
                {
                    MessageBox.Show("Error al actualizar usuario");
                }



            }

        }
        private void DDLROL_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            if (DDLROL.SelectedValue != null)
            {
                int selectedRoleId = Convert.ToInt32(DDLROL.SelectedValue);


            }
        }

        private void FormEditar_Load(object sender, EventArgs e)
        {
            cargarCombobox();
            
        }
    }
}
