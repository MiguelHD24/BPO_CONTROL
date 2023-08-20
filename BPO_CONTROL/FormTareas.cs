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
    public partial class FormTareas : Form
    {
        public int ID_Usuario { get; set; }
        public int ID_Registro { get; set; }
        public string Tareas_Nombres { get; set; }
        public int ID_Tareas { get; set; }
        public FormTareas()
        {
            InitializeComponent();
        }

        private void FormTareas_Load(object sender, EventArgs e)
        {
            Button btnQA = new Button();
            btnQA.Text = "QA";
            btnQA.Click += Btn_QA_Click;

            Button btnQA10 = new Button();
            btnQA10.Text = "QA10";
            btnQA10.Click += Btn_QA10_Click;

            Button btnAD = new Button();
            btnAD.Text = "AD";
            btnAD.Click += Btn_AD_Click;


            Button btnZC = new Button();
            btnZC.Text = "ZC";
            btnZC.Click += Btn_ZC_Click;

            Button btnPublishing = new Button();
            btnPublishing.Text = "PUBLISHING";
            btnPublishing.Click += Btn_PUBLISHING_Click;

            Button btnConfig = new Button();
            btnConfig.Text = "CONFIG";
            btnConfig.Click += Btn_CONFIG_Click;

            Button btnL4 = new Button();
            btnL4.Text = "L4";
            btnL4.Click += Btn_L4_Click;

            Button btnQAP = new Button();
            btnQAP.Text = "QAP";
            btnQAP.Click += Btn_QAP_Click;

            // Agregar los botones al formulario
            Controls.Add(btnQA);
            Controls.Add(btnQA10);
            Controls.Add(btnAD);
            Controls.Add(btnZC);
            Controls.Add(btnPublishing);
            Controls.Add(btnConfig);
            Controls.Add(btnL4);
            Controls.Add(btnQAP);
            



        }

        private void Btn_QAP_Click(object sender, EventArgs e)
        {
            Button boton = (Button)sender;
            Tareas_Nombres = boton.Text;
            if (BL.BL_Tareas.ExisteTarea(Tareas_Nombres) > 0)
            {
                ID_Tareas = BL.BL_Tareas.ExisteTarea(Tareas_Nombres);
                Registro registro = new Registro();
                registro.ID_Registro = ID_Registro;
                registro.ID_Tareas = ID_Tareas;
                if (BL.BL_Registro.InsertarTarea(registro) == true)
                {
                    FormUsuario formUsuario = new FormUsuario();
                    formUsuario.ID_Usuario = ID_Usuario; // Asignar a la propiedad del formulario
                    formUsuario.ID_Registro = ID_Registro; // Asignar a la propiedad del formulario
                    formUsuario.Show();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Error al insertar la tarea");
                }
            }
        }

        private void Btn_L4_Click(object sender, EventArgs e)
        {
            Button boton = (Button)sender;
            Tareas_Nombres = boton.Text;
            if (BL.BL_Tareas.ExisteTarea(Tareas_Nombres) > 0)
            {
                ID_Tareas = BL.BL_Tareas.ExisteTarea(Tareas_Nombres);
                Registro registro = new Registro();
                registro.ID_Registro = ID_Registro;
                registro.ID_Tareas = ID_Tareas;
                if (BL.BL_Registro.InsertarTarea(registro) == true)
                {
                    FormUsuario formUsuario = new FormUsuario();
                    formUsuario.ID_Usuario = ID_Usuario; // Asignar a la propiedad del formulario
                    formUsuario.ID_Registro = ID_Registro; // Asignar a la propiedad del formulario
                    formUsuario.Show();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Error al insertar la tarea");
                }
            }
        }

        private void Btn_CONFIG_Click(object sender, EventArgs e)
        {
            Button boton = (Button)sender;
            Tareas_Nombres = boton.Text;
            if (BL.BL_Tareas.ExisteTarea(Tareas_Nombres) > 0)
            {
                ID_Tareas = BL.BL_Tareas.ExisteTarea(Tareas_Nombres);
                Registro registro = new Registro();
                registro.ID_Registro = ID_Registro;
                registro.ID_Tareas = ID_Tareas;
                if (BL.BL_Registro.InsertarTarea(registro) == true)
                {
                    FormUsuario formUsuario = new FormUsuario();
                    formUsuario.ID_Usuario = ID_Usuario; // Asignar a la propiedad del formulario
                    formUsuario.ID_Registro = ID_Registro; // Asignar a la propiedad del formulario
                    formUsuario.Show();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Error al insertar la tarea");
                }
            }
        }

        private void Btn_QA_Click(object sender, EventArgs e)
        {
            Button boton = (Button)sender;
            Tareas_Nombres = boton.Text;
            if (BL.BL_Tareas.ExisteTarea(Tareas_Nombres) > 0)
            {
                ID_Tareas = BL.BL_Tareas.ExisteTarea(Tareas_Nombres);
                Registro registro = new Registro();
                registro.ID_Registro = ID_Registro;
                registro.ID_Tareas = ID_Tareas;
                if (BL.BL_Registro.InsertarTarea(registro) == true)
                {
                    FormUsuario formUsuario = new FormUsuario();
                    formUsuario.ID_Usuario = ID_Usuario; // Asignar a la propiedad del formulario
                    formUsuario.ID_Registro = ID_Registro; // Asignar a la propiedad del formulario
                    formUsuario.Show();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Error al insertar la tarea");
                }
            }
        }

        private void Btn_PUBLISHING_Click(object sender, EventArgs e)
        {
            Button boton = (Button)sender;
            Tareas_Nombres = boton.Text;
            if (BL.BL_Tareas.ExisteTarea(Tareas_Nombres) > 0)
            {
                ID_Tareas = BL.BL_Tareas.ExisteTarea(Tareas_Nombres);
                Registro registro = new Registro();
                registro.ID_Registro = ID_Registro;
                registro.ID_Tareas = ID_Tareas;
                if (BL.BL_Registro.InsertarTarea(registro) == true)
                {
                    FormUsuario formUsuario = new FormUsuario();
                    formUsuario.ID_Usuario = ID_Usuario; // Asignar a la propiedad del formulario
                    formUsuario.ID_Registro = ID_Registro; // Asignar a la propiedad del formulario
                    formUsuario.Show();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Error al insertar la tarea");
                }
            }
        }

        private void Btn_ZC_Click(object sender, EventArgs e)
        {
            Button boton = (Button)sender;
            Tareas_Nombres = boton.Text;
            if (BL.BL_Tareas.ExisteTarea(Tareas_Nombres) > 0)
            {
                ID_Tareas = BL.BL_Tareas.ExisteTarea(Tareas_Nombres);
                Registro registro = new Registro();
                registro.ID_Registro = ID_Registro;
                registro.ID_Tareas = ID_Tareas;
                if (BL.BL_Registro.InsertarTarea(registro) == true)
                {
                    FormUsuario formUsuario = new FormUsuario();
                    formUsuario.ID_Usuario = ID_Usuario; // Asignar a la propiedad del formulario
                    formUsuario.ID_Registro = ID_Registro; // Asignar a la propiedad del formulario
                    formUsuario.Show();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Error al insertar la tarea");
                }
            }
        }

        private void Btn_QA10_Click(object sender, EventArgs e)
        {
            Button boton = (Button)sender;
            Tareas_Nombres = boton.Text;
            if (BL.BL_Tareas.ExisteTarea(Tareas_Nombres) > 0)
            {
                ID_Tareas = BL.BL_Tareas.ExisteTarea(Tareas_Nombres);
                Registro registro = new Registro();
                registro.ID_Registro = ID_Registro;
                registro.ID_Tareas = ID_Tareas;
                if (BL.BL_Registro.InsertarTarea(registro) == true)
                {
                    FormUsuario formUsuario = new FormUsuario();
                    formUsuario.ID_Usuario = ID_Usuario; // Asignar a la propiedad del formulario
                    formUsuario.ID_Registro = ID_Registro; // Asignar a la propiedad del formulario
                    formUsuario.Show();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Error al insertar la tarea");
                }
            }
        }

        private void Btn_AD_Click(object sender, EventArgs e)
        {
            Button boton = (Button)sender;
            Tareas_Nombres = boton.Text;
            if (BL.BL_Tareas.ExisteTarea(Tareas_Nombres) > 0)
            {
                ID_Tareas = BL.BL_Tareas.ExisteTarea(Tareas_Nombres);
                Registro registro = new Registro();
                registro.ID_Registro = ID_Registro;
                registro.ID_Tareas = ID_Tareas;
                if (BL.BL_Registro.InsertarTarea(registro) == true)
                {
                    FormUsuario formUsuario = new FormUsuario();
                    formUsuario.ID_Usuario = ID_Usuario; // Asignar a la propiedad del formulario
                    formUsuario.ID_Registro = ID_Registro; // Asignar a la propiedad del formulario
                    formUsuario.Show();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Error al insertar la tarea");
                }
            }
        }
    }
}
