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
    public partial class FormCrud : Form
    {
        public FormCrud()
        {
            InitializeComponent();
        }

        private void btnCerrarForm_Click(object sender, EventArgs e)
        {
            
            this.Close();


        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            FormAgregar formAgregar = new FormAgregar();
            formAgregar.Show();
        }

        private void CargarUsuariosEnDataGridView()
        {
            this.DataGridViewUsuarios.DataSource = BL_Usuario.MostrarU();
        }
        private void FormCrud_Load(object sender, EventArgs e)
        {
            CargarUsuariosEnDataGridView();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (DataGridViewUsuarios.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = DataGridViewUsuarios.SelectedRows[0];

                // Asignar los valores de las celdas a los TextBoxes
                FormEditar formEditar = new FormEditar();
                formEditar.ID_Usuario = Convert.ToInt32(DataGridViewUsuarios.CurrentRow.Cells[0].Value.ToString());
                formEditar.txtNombres.Text = DataGridViewUsuarios.CurrentRow.Cells[1].Value.ToString();
                formEditar.txtApellidos.Text = DataGridViewUsuarios.CurrentRow.Cells[2].Value.ToString();
                formEditar.txtUsuarioA.Text = DataGridViewUsuarios.CurrentRow.Cells[3].Value.ToString();
                formEditar.DDLROL.Text = DataGridViewUsuarios.CurrentRow.Cells[5].Value.ToString();
                formEditar.Show();


            }
            else
            {
                MessageBox.Show("Selecciona una fila en el DataGridView primero.");
            }
        }

        private void DataGridViewUsuarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
        private void DataGridViewUsuarios_DoubleClick(object sender, EventArgs e)
        {
            FormEditar formEditar = new FormEditar();
            formEditar.ID_Usuario = Convert.ToInt32(DataGridViewUsuarios.CurrentRow.Cells[0].Value.ToString());
            formEditar.txtNombres.Text = DataGridViewUsuarios.CurrentRow.Cells[1].Value.ToString();
            formEditar.txtApellidos.Text = DataGridViewUsuarios.CurrentRow.Cells[2].Value.ToString();
            formEditar.txtUsuarioA.Text = DataGridViewUsuarios.CurrentRow.Cells[3].Value.ToString();
            formEditar.DDLROL.Text = DataGridViewUsuarios.CurrentRow.Cells[5].Value.ToString();
            formEditar.Show();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            CargarUsuariosEnDataGridView();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (DataGridViewUsuarios.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = DataGridViewUsuarios.SelectedRows[0];

                Usuario usuario = new Usuario();
                usuario.ID_Usuario = Convert.ToInt32(DataGridViewUsuarios.CurrentRow.Cells[0].Value.ToString());
                if (BL_Usuario.Anular(usuario) == true)
                {
                    MessageBox.Show("Usuario eliminado correctamente");
                    CargarUsuariosEnDataGridView();
                }
                else
                {
                    MessageBox.Show("Error al eliminar usuario");
                }
                


            }
            else
            {
                MessageBox.Show("Selecciona una fila en el DataGridView primero.");
            }
        }
    }
}
