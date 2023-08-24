namespace BPO_CONTROL
{
    partial class FormEditar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEditar));
            this.Label4 = new System.Windows.Forms.Label();
            this.txtApellidos = new System.Windows.Forms.TextBox();
            this.PictureBox1 = new System.Windows.Forms.PictureBox();
            this.Label3 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.DDLROL = new System.Windows.Forms.ComboBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUsuarioA = new System.Windows.Forms.TextBox();
            this.txtNombres = new System.Windows.Forms.TextBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnEditarU = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.BackColor = System.Drawing.Color.Transparent;
            this.Label4.ForeColor = System.Drawing.Color.DimGray;
            this.Label4.Location = new System.Drawing.Point(345, 73);
            this.Label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(231, 16);
            this.Label4.TabIndex = 48;
            this.Label4.Text = "________________________________";
            // 
            // txtApellidos
            // 
            this.txtApellidos.BackColor = System.Drawing.Color.White;
            this.txtApellidos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtApellidos.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApellidos.ForeColor = System.Drawing.Color.Black;
            this.txtApellidos.Location = new System.Drawing.Point(349, 44);
            this.txtApellidos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtApellidos.Name = "txtApellidos";
            this.txtApellidos.Size = new System.Drawing.Size(261, 25);
            this.txtApellidos.TabIndex = 47;
            this.txtApellidos.Text = "Apellidos";
            // 
            // PictureBox1
            // 
            this.PictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("PictureBox1.Image")));
            this.PictureBox1.Location = new System.Drawing.Point(629, 15);
            this.PictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.PictureBox1.Name = "PictureBox1";
            this.PictureBox1.Size = new System.Drawing.Size(125, 95);
            this.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBox1.TabIndex = 46;
            this.PictureBox1.TabStop = false;
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.BackColor = System.Drawing.Color.Transparent;
            this.Label3.ForeColor = System.Drawing.Color.DimGray;
            this.Label3.Location = new System.Drawing.Point(13, 73);
            this.Label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(259, 16);
            this.Label3.TabIndex = 45;
            this.Label3.Text = "____________________________________";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.BackColor = System.Drawing.Color.Transparent;
            this.Label2.ForeColor = System.Drawing.Color.DimGray;
            this.Label2.Location = new System.Drawing.Point(13, 196);
            this.Label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(336, 16);
            this.Label2.TabIndex = 44;
            this.Label2.Text = "_______________________________________________";
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.BackColor = System.Drawing.Color.Transparent;
            this.Label1.ForeColor = System.Drawing.Color.DimGray;
            this.Label1.Location = new System.Drawing.Point(13, 135);
            this.Label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(336, 16);
            this.Label1.TabIndex = 43;
            this.Label1.Text = "_______________________________________________";
            // 
            // DDLROL
            // 
            this.DDLROL.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.DDLROL.FormattingEnabled = true;
            this.DDLROL.Location = new System.Drawing.Point(424, 126);
            this.DDLROL.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DDLROL.Name = "DDLROL";
            this.DDLROL.Size = new System.Drawing.Size(329, 31);
            this.DDLROL.TabIndex = 41;
            this.DDLROL.SelectedIndexChanged += new System.EventHandler(this.DDLROL_SelectedIndexChanged);
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.Color.White;
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPassword.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.ForeColor = System.Drawing.Color.Black;
            this.txtPassword.Location = new System.Drawing.Point(17, 167);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(381, 25);
            this.txtPassword.TabIndex = 40;
            this.txtPassword.Text = "Contraseña de Acceso";
            // 
            // txtUsuarioA
            // 
            this.txtUsuarioA.BackColor = System.Drawing.Color.White;
            this.txtUsuarioA.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUsuarioA.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsuarioA.ForeColor = System.Drawing.Color.Black;
            this.txtUsuarioA.Location = new System.Drawing.Point(17, 107);
            this.txtUsuarioA.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtUsuarioA.Name = "txtUsuarioA";
            this.txtUsuarioA.Size = new System.Drawing.Size(381, 25);
            this.txtUsuarioA.TabIndex = 39;
            this.txtUsuarioA.Text = "Usuario de Acceso (cedula)";
            // 
            // txtNombres
            // 
            this.txtNombres.BackColor = System.Drawing.Color.White;
            this.txtNombres.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNombres.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombres.ForeColor = System.Drawing.Color.Black;
            this.txtNombres.Location = new System.Drawing.Point(17, 44);
            this.txtNombres.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNombres.Name = "txtNombres";
            this.txtNombres.Size = new System.Drawing.Size(293, 25);
            this.txtNombres.TabIndex = 38;
            this.txtNombres.Text = "Nombres";
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
            this.btnGuardar.Location = new System.Drawing.Point(211, 229);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(312, 47);
            this.btnGuardar.TabIndex = 37;
            this.btnGuardar.Text = "Guardar Nuevo Usuario";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnEditarU
            // 
            this.btnEditarU.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnEditarU.FlatAppearance.BorderSize = 0;
            this.btnEditarU.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnEditarU.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.btnEditarU.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditarU.ForeColor = System.Drawing.Color.Black;
            this.btnEditarU.Image = ((System.Drawing.Image)(resources.GetObject("btnEditarU.Image")));
            this.btnEditarU.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditarU.Location = new System.Drawing.Point(209, 229);
            this.btnEditarU.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnEditarU.Name = "btnEditarU";
            this.btnEditarU.Size = new System.Drawing.Size(312, 47);
            this.btnEditarU.TabIndex = 36;
            this.btnEditarU.Text = "Guardar Cambios";
            this.btnEditarU.UseVisualStyleBackColor = true;
            // 
            // FormEditar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(769, 290);
            this.Controls.Add(this.Label4);
            this.Controls.Add(this.txtApellidos);
            this.Controls.Add(this.PictureBox1);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.DDLROL);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUsuarioA);
            this.Controls.Add(this.txtNombres);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnEditarU);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormEditar";
            this.Text = "FormEditar";
            this.Load += new System.EventHandler(this.FormEditar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.TextBox txtApellidos;
        internal System.Windows.Forms.PictureBox PictureBox1;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.ComboBox DDLROL;
        internal System.Windows.Forms.TextBox txtPassword;
        internal System.Windows.Forms.TextBox txtUsuarioA;
        internal System.Windows.Forms.TextBox txtNombres;
        internal System.Windows.Forms.Button btnGuardar;
        internal System.Windows.Forms.Button btnEditarU;
    }
}