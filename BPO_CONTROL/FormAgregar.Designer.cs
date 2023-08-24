using System;

namespace BPO_CONTROL
{
    partial class FormAgregar
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAgregar));
            this.Label4 = new System.Windows.Forms.Label();
            this.txtApellidos = new System.Windows.Forms.TextBox();
            this.Label3 = new System.Windows.Forms.Label();
            this.txtNombres = new System.Windows.Forms.TextBox();
            this.PictureBox1 = new System.Windows.Forms.PictureBox();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.DDLROL = new System.Windows.Forms.ComboBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUsuarioA = new System.Windows.Forms.TextBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.BackColor = System.Drawing.Color.Transparent;
            this.Label4.ForeColor = System.Drawing.Color.DimGray;
            this.Label4.Location = new System.Drawing.Point(345, 70);
            this.Label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(231, 16);
            this.Label4.TabIndex = 51;
            this.Label4.Text = "________________________________";
            // 
            // txtApellidos
            // 
            this.txtApellidos.BackColor = System.Drawing.Color.White;
            this.txtApellidos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtApellidos.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApellidos.ForeColor = System.Drawing.Color.Black;
            this.txtApellidos.Location = new System.Drawing.Point(349, 42);
            this.txtApellidos.Margin = new System.Windows.Forms.Padding(4);
            this.txtApellidos.Name = "txtApellidos";
            this.txtApellidos.Size = new System.Drawing.Size(261, 25);
            this.txtApellidos.TabIndex = 50;
            this.txtApellidos.Text = "Apellidos";
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.BackColor = System.Drawing.Color.Transparent;
            this.Label3.ForeColor = System.Drawing.Color.DimGray;
            this.Label3.Location = new System.Drawing.Point(13, 70);
            this.Label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(259, 16);
            this.Label3.TabIndex = 49;
            this.Label3.Text = "____________________________________";
            // 
            // txtNombres
            // 
            this.txtNombres.BackColor = System.Drawing.Color.White;
            this.txtNombres.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNombres.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombres.ForeColor = System.Drawing.Color.Black;
            this.txtNombres.Location = new System.Drawing.Point(17, 42);
            this.txtNombres.Margin = new System.Windows.Forms.Padding(4);
            this.txtNombres.Name = "txtNombres";
            this.txtNombres.Size = new System.Drawing.Size(293, 25);
            this.txtNombres.TabIndex = 48;
            this.txtNombres.Text = "Nombres";
            // 
            // PictureBox1
            // 
            this.PictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("PictureBox1.Image")));
            this.PictureBox1.Location = new System.Drawing.Point(625, 15);
            this.PictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.PictureBox1.Name = "PictureBox1";
            this.PictureBox1.Size = new System.Drawing.Size(125, 95);
            this.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBox1.TabIndex = 47;
            this.PictureBox1.TabStop = false;
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.BackColor = System.Drawing.Color.Transparent;
            this.Label2.ForeColor = System.Drawing.Color.DimGray;
            this.Label2.Location = new System.Drawing.Point(13, 187);
            this.Label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(336, 16);
            this.Label2.TabIndex = 46;
            this.Label2.Text = "_______________________________________________";
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.BackColor = System.Drawing.Color.Transparent;
            this.Label1.ForeColor = System.Drawing.Color.DimGray;
            this.Label1.Location = new System.Drawing.Point(13, 127);
            this.Label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(336, 16);
            this.Label1.TabIndex = 45;
            this.Label1.Text = "_______________________________________________";
            // 
            // DDLROL
            // 
            this.DDLROL.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DDLROL.FormattingEnabled = true;
            this.DDLROL.Location = new System.Drawing.Point(424, 117);
            this.DDLROL.Margin = new System.Windows.Forms.Padding(4);
            this.DDLROL.Name = "DDLROL";
            this.DDLROL.Size = new System.Drawing.Size(329, 31);
            this.DDLROL.TabIndex = 43;
            this.DDLROL.SelectedIndexChanged += new System.EventHandler(this.DDLROL_SelectedIndexChanged);
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.Color.White;
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPassword.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.ForeColor = System.Drawing.Color.Black;
            this.txtPassword.Location = new System.Drawing.Point(17, 159);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(4);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(381, 25);
            this.txtPassword.TabIndex = 42;
            this.txtPassword.Text = "Contraseña de Acceso";
            // 
            // txtUsuarioA
            // 
            this.txtUsuarioA.BackColor = System.Drawing.Color.White;
            this.txtUsuarioA.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUsuarioA.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsuarioA.ForeColor = System.Drawing.Color.Black;
            this.txtUsuarioA.Location = new System.Drawing.Point(17, 98);
            this.txtUsuarioA.Margin = new System.Windows.Forms.Padding(4);
            this.txtUsuarioA.Name = "txtUsuarioA";
            this.txtUsuarioA.Size = new System.Drawing.Size(381, 25);
            this.txtUsuarioA.TabIndex = 41;
            this.txtUsuarioA.Text = "Usuario de Acceso (cedula)";
            // 
            // btnGuardar
            // 
            this.btnGuardar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnGuardar.FlatAppearance.BorderSize = 0;
            this.btnGuardar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnGuardar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.btnGuardar.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ForeColor = System.Drawing.Color.Black;
            this.btnGuardar.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardar.Image")));
            this.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuardar.Location = new System.Drawing.Point(205, 229);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(4);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(312, 47);
            this.btnGuardar.TabIndex = 40;
            this.btnGuardar.Text = "Guardar Nuevo Usuario";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // FormAgregar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(769, 290);
            this.Controls.Add(this.Label4);
            this.Controls.Add(this.txtApellidos);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.txtNombres);
            this.Controls.Add(this.PictureBox1);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.DDLROL);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUsuarioA);
            this.Controls.Add(this.btnGuardar);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormAgregar";
            this.Text = "FormAgregar";
            this.Load += new System.EventHandler(this.FormAgregar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        

        #endregion

        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.TextBox txtApellidos;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.TextBox txtNombres;
        internal System.Windows.Forms.PictureBox PictureBox1;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.ComboBox DDLROL;
        internal System.Windows.Forms.TextBox txtPassword;
        internal System.Windows.Forms.TextBox txtUsuarioA;
        internal System.Windows.Forms.Button btnGuardar;
    }
}