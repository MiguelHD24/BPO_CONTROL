namespace BPO_CONTROL
{
    partial class FormAdministrador
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAdministrador));
            this.PanelBarraTitulo = new System.Windows.Forms.Panel();
            this.btnRestaurar = new System.Windows.Forms.PictureBox();
            this.btnMaximizar = new System.Windows.Forms.PictureBox();
            this.btnMinimizar = new System.Windows.Forms.PictureBox();
            this.btnCerrar = new System.Windows.Forms.PictureBox();
            this.PanelMenu = new System.Windows.Forms.Panel();
            this.PanelReporteSubmenu = new System.Windows.Forms.Panel();
            this.btnReporteHorasConsumidas = new System.Windows.Forms.Button();
            this.btnReporteEntradaSalida = new System.Windows.Forms.Button();
            this.btnReporteConsolidado = new System.Windows.Forms.Button();
            this.Panel1 = new System.Windows.Forms.Panel();
            this.Labelapellidos = new System.Windows.Forms.Label();
            this.Labelnombres = new System.Windows.Forms.Label();
            this.LabelUsuario = new System.Windows.Forms.Label();
            this.PictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnCerrarSesion = new System.Windows.Forms.Button();
            this.btnReporte = new System.Windows.Forms.Button();
            this.btnUsuario = new System.Windows.Forms.Button();
            this.PictureBox1 = new System.Windows.Forms.PictureBox();
            this.PanelForm = new System.Windows.Forms.Panel();
            this.PanelBarraTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnRestaurar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMaximizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).BeginInit();
            this.PanelMenu.SuspendLayout();
            this.PanelReporteSubmenu.SuspendLayout();
            this.Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).BeginInit();
            this.PanelForm.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelBarraTitulo
            // 
            this.PanelBarraTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(182)))));
            this.PanelBarraTitulo.Controls.Add(this.btnRestaurar);
            this.PanelBarraTitulo.Controls.Add(this.btnMaximizar);
            this.PanelBarraTitulo.Controls.Add(this.btnMinimizar);
            this.PanelBarraTitulo.Controls.Add(this.btnCerrar);
            this.PanelBarraTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelBarraTitulo.Location = new System.Drawing.Point(0, 0);
            this.PanelBarraTitulo.Margin = new System.Windows.Forms.Padding(4);
            this.PanelBarraTitulo.Name = "PanelBarraTitulo";
            this.PanelBarraTitulo.Size = new System.Drawing.Size(1365, 49);
            this.PanelBarraTitulo.TabIndex = 1;
            this.PanelBarraTitulo.Paint += new System.Windows.Forms.PaintEventHandler(this.PanelBarraTitulo_Paint);
            // 
            // btnRestaurar
            // 
            this.btnRestaurar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRestaurar.Image = ((System.Drawing.Image)(resources.GetObject("btnRestaurar.Image")));
            this.btnRestaurar.Location = new System.Drawing.Point(1299, 15);
            this.btnRestaurar.Margin = new System.Windows.Forms.Padding(4);
            this.btnRestaurar.Name = "btnRestaurar";
            this.btnRestaurar.Size = new System.Drawing.Size(16, 16);
            this.btnRestaurar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.btnRestaurar.TabIndex = 3;
            this.btnRestaurar.TabStop = false;
            this.btnRestaurar.Visible = false;
            // 
            // btnMaximizar
            // 
            this.btnMaximizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMaximizar.Image = ((System.Drawing.Image)(resources.GetObject("btnMaximizar.Image")));
            this.btnMaximizar.Location = new System.Drawing.Point(1299, 15);
            this.btnMaximizar.Margin = new System.Windows.Forms.Padding(4);
            this.btnMaximizar.Name = "btnMaximizar";
            this.btnMaximizar.Size = new System.Drawing.Size(16, 16);
            this.btnMaximizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.btnMaximizar.TabIndex = 2;
            this.btnMaximizar.TabStop = false;
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimizar.Image = ((System.Drawing.Image)(resources.GetObject("btnMinimizar.Image")));
            this.btnMinimizar.Location = new System.Drawing.Point(1269, 15);
            this.btnMinimizar.Margin = new System.Windows.Forms.Padding(4);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(16, 16);
            this.btnMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.btnMinimizar.TabIndex = 1;
            this.btnMinimizar.TabStop = false;
            this.btnMinimizar.Click += new System.EventHandler(this.btnMinimizar_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrar.Image = ((System.Drawing.Image)(resources.GetObject("btnCerrar.Image")));
            this.btnCerrar.Location = new System.Drawing.Point(1328, 15);
            this.btnCerrar.Margin = new System.Windows.Forms.Padding(4);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(16, 16);
            this.btnCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.btnCerrar.TabIndex = 0;
            this.btnCerrar.TabStop = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // PanelMenu
            // 
            this.PanelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(54)))), ((int)(((byte)(75)))));
            this.PanelMenu.Controls.Add(this.PanelReporteSubmenu);
            this.PanelMenu.Controls.Add(this.Panel1);
            this.PanelMenu.Controls.Add(this.btnCerrarSesion);
            this.PanelMenu.Controls.Add(this.btnReporte);
            this.PanelMenu.Controls.Add(this.btnUsuario);
            this.PanelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.PanelMenu.Location = new System.Drawing.Point(0, 49);
            this.PanelMenu.Margin = new System.Windows.Forms.Padding(4);
            this.PanelMenu.Name = "PanelMenu";
            this.PanelMenu.Size = new System.Drawing.Size(320, 582);
            this.PanelMenu.TabIndex = 2;
            // 
            // PanelReporteSubmenu
            // 
            this.PanelReporteSubmenu.BackColor = System.Drawing.Color.White;
            this.PanelReporteSubmenu.Controls.Add(this.btnReporteHorasConsumidas);
            this.PanelReporteSubmenu.Controls.Add(this.btnReporteEntradaSalida);
            this.PanelReporteSubmenu.Controls.Add(this.btnReporteConsolidado);
            this.PanelReporteSubmenu.Location = new System.Drawing.Point(5, 233);
            this.PanelReporteSubmenu.Margin = new System.Windows.Forms.Padding(4);
            this.PanelReporteSubmenu.Name = "PanelReporteSubmenu";
            this.PanelReporteSubmenu.Size = new System.Drawing.Size(311, 148);
            this.PanelReporteSubmenu.TabIndex = 5;
            // 
            // btnReporteHorasConsumidas
            // 
            this.btnReporteHorasConsumidas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.btnReporteHorasConsumidas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReporteHorasConsumidas.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnReporteHorasConsumidas.FlatAppearance.BorderSize = 0;
            this.btnReporteHorasConsumidas.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.btnReporteHorasConsumidas.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control;
            this.btnReporteHorasConsumidas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReporteHorasConsumidas.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReporteHorasConsumidas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(182)))));
            this.btnReporteHorasConsumidas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReporteHorasConsumidas.Location = new System.Drawing.Point(0, 98);
            this.btnReporteHorasConsumidas.Margin = new System.Windows.Forms.Padding(4);
            this.btnReporteHorasConsumidas.Name = "btnReporteHorasConsumidas";
            this.btnReporteHorasConsumidas.Padding = new System.Windows.Forms.Padding(47, 0, 0, 0);
            this.btnReporteHorasConsumidas.Size = new System.Drawing.Size(311, 49);
            this.btnReporteHorasConsumidas.TabIndex = 2;
            this.btnReporteHorasConsumidas.Text = "Reporte Horas Consumidas";
            this.btnReporteHorasConsumidas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReporteHorasConsumidas.UseVisualStyleBackColor = false;
            // 
            // btnReporteEntradaSalida
            // 
            this.btnReporteEntradaSalida.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.btnReporteEntradaSalida.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReporteEntradaSalida.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnReporteEntradaSalida.FlatAppearance.BorderSize = 0;
            this.btnReporteEntradaSalida.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.btnReporteEntradaSalida.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control;
            this.btnReporteEntradaSalida.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReporteEntradaSalida.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReporteEntradaSalida.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(182)))));
            this.btnReporteEntradaSalida.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReporteEntradaSalida.Location = new System.Drawing.Point(0, 49);
            this.btnReporteEntradaSalida.Margin = new System.Windows.Forms.Padding(4);
            this.btnReporteEntradaSalida.Name = "btnReporteEntradaSalida";
            this.btnReporteEntradaSalida.Padding = new System.Windows.Forms.Padding(47, 0, 0, 0);
            this.btnReporteEntradaSalida.Size = new System.Drawing.Size(311, 49);
            this.btnReporteEntradaSalida.TabIndex = 1;
            this.btnReporteEntradaSalida.Text = "Reporte Entrada Salida";
            this.btnReporteEntradaSalida.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReporteEntradaSalida.UseVisualStyleBackColor = false;
            // 
            // btnReporteConsolidado
            // 
            this.btnReporteConsolidado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.btnReporteConsolidado.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReporteConsolidado.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnReporteConsolidado.FlatAppearance.BorderSize = 0;
            this.btnReporteConsolidado.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.btnReporteConsolidado.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control;
            this.btnReporteConsolidado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReporteConsolidado.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReporteConsolidado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(182)))));
            this.btnReporteConsolidado.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReporteConsolidado.Location = new System.Drawing.Point(0, 0);
            this.btnReporteConsolidado.Margin = new System.Windows.Forms.Padding(4);
            this.btnReporteConsolidado.Name = "btnReporteConsolidado";
            this.btnReporteConsolidado.Padding = new System.Windows.Forms.Padding(47, 0, 0, 0);
            this.btnReporteConsolidado.Size = new System.Drawing.Size(311, 49);
            this.btnReporteConsolidado.TabIndex = 0;
            this.btnReporteConsolidado.Text = "Reporte Consolidado";
            this.btnReporteConsolidado.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReporteConsolidado.UseVisualStyleBackColor = false;
            // 
            // Panel1
            // 
            this.Panel1.Controls.Add(this.Labelapellidos);
            this.Panel1.Controls.Add(this.Labelnombres);
            this.Panel1.Controls.Add(this.LabelUsuario);
            this.Panel1.Controls.Add(this.PictureBox2);
            this.Panel1.Location = new System.Drawing.Point(0, 0);
            this.Panel1.Margin = new System.Windows.Forms.Padding(4);
            this.Panel1.Name = "Panel1";
            this.Panel1.Size = new System.Drawing.Size(320, 123);
            this.Panel1.TabIndex = 4;
            // 
            // Labelapellidos
            // 
            this.Labelapellidos.AutoSize = true;
            this.Labelapellidos.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Labelapellidos.ForeColor = System.Drawing.SystemColors.Control;
            this.Labelapellidos.Location = new System.Drawing.Point(109, 79);
            this.Labelapellidos.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Labelapellidos.Name = "Labelapellidos";
            this.Labelapellidos.Size = new System.Drawing.Size(57, 18);
            this.Labelapellidos.TabIndex = 4;
            this.Labelapellidos.Text = "Label1";
            // 
            // Labelnombres
            // 
            this.Labelnombres.AutoSize = true;
            this.Labelnombres.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Labelnombres.ForeColor = System.Drawing.SystemColors.Control;
            this.Labelnombres.Location = new System.Drawing.Point(109, 59);
            this.Labelnombres.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Labelnombres.Name = "Labelnombres";
            this.Labelnombres.Size = new System.Drawing.Size(57, 18);
            this.Labelnombres.TabIndex = 3;
            this.Labelnombres.Text = "Label1";
            // 
            // LabelUsuario
            // 
            this.LabelUsuario.AutoSize = true;
            this.LabelUsuario.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelUsuario.ForeColor = System.Drawing.SystemColors.Control;
            this.LabelUsuario.Location = new System.Drawing.Point(109, 20);
            this.LabelUsuario.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelUsuario.Name = "LabelUsuario";
            this.LabelUsuario.Size = new System.Drawing.Size(72, 23);
            this.LabelUsuario.TabIndex = 2;
            this.LabelUsuario.Text = "Label1";
            // 
            // PictureBox2
            // 
            this.PictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("PictureBox2.Image")));
            this.PictureBox2.Location = new System.Drawing.Point(16, 20);
            this.PictureBox2.Margin = new System.Windows.Forms.Padding(4);
            this.PictureBox2.Name = "PictureBox2";
            this.PictureBox2.Size = new System.Drawing.Size(64, 64);
            this.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.PictureBox2.TabIndex = 1;
            this.PictureBox2.TabStop = false;
            // 
            // btnCerrarSesion
            // 
            this.btnCerrarSesion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCerrarSesion.FlatAppearance.BorderSize = 0;
            this.btnCerrarSesion.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(50)))), ((int)(((byte)(70)))));
            this.btnCerrarSesion.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnCerrarSesion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrarSesion.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrarSesion.ForeColor = System.Drawing.SystemColors.Control;
            this.btnCerrarSesion.Image = ((System.Drawing.Image)(resources.GetObject("btnCerrarSesion.Image")));
            this.btnCerrarSesion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCerrarSesion.Location = new System.Drawing.Point(4, 521);
            this.btnCerrarSesion.Margin = new System.Windows.Forms.Padding(4);
            this.btnCerrarSesion.Name = "btnCerrarSesion";
            this.btnCerrarSesion.Size = new System.Drawing.Size(312, 47);
            this.btnCerrarSesion.TabIndex = 3;
            this.btnCerrarSesion.Text = "Cerrar Sesión";
            this.btnCerrarSesion.UseVisualStyleBackColor = true;
            this.btnCerrarSesion.Click += new System.EventHandler(this.btnCerrarSesion_Click);
            // 
            // btnReporte
            // 
            this.btnReporte.FlatAppearance.BorderSize = 0;
            this.btnReporte.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(50)))), ((int)(((byte)(70)))));
            this.btnReporte.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.btnReporte.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReporte.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReporte.ForeColor = System.Drawing.SystemColors.Control;
            this.btnReporte.Image = ((System.Drawing.Image)(resources.GetObject("btnReporte.Image")));
            this.btnReporte.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReporte.Location = new System.Drawing.Point(4, 178);
            this.btnReporte.Margin = new System.Windows.Forms.Padding(4);
            this.btnReporte.Name = "btnReporte";
            this.btnReporte.Size = new System.Drawing.Size(312, 47);
            this.btnReporte.TabIndex = 1;
            this.btnReporte.Text = "Reportes";
            this.btnReporte.UseVisualStyleBackColor = true;
            // 
            // btnUsuario
            // 
            this.btnUsuario.FlatAppearance.BorderSize = 0;
            this.btnUsuario.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(50)))), ((int)(((byte)(70)))));
            this.btnUsuario.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.btnUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUsuario.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUsuario.ForeColor = System.Drawing.SystemColors.Control;
            this.btnUsuario.Image = ((System.Drawing.Image)(resources.GetObject("btnUsuario.Image")));
            this.btnUsuario.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUsuario.Location = new System.Drawing.Point(4, 124);
            this.btnUsuario.Margin = new System.Windows.Forms.Padding(4);
            this.btnUsuario.Name = "btnUsuario";
            this.btnUsuario.Size = new System.Drawing.Size(312, 47);
            this.btnUsuario.TabIndex = 0;
            this.btnUsuario.Text = "Agregar Usuarios";
            this.btnUsuario.UseVisualStyleBackColor = true;
            this.btnUsuario.Click += new System.EventHandler(this.btnUsuario_Click);
            // 
            // PictureBox1
            // 
            this.PictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("PictureBox1.Image")));
            this.PictureBox1.Location = new System.Drawing.Point(4, 89);
            this.PictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.PictureBox1.Name = "PictureBox1";
            this.PictureBox1.Size = new System.Drawing.Size(1037, 389);
            this.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PictureBox1.TabIndex = 0;
            this.PictureBox1.TabStop = false;
            // 
            // PanelForm
            // 
            this.PanelForm.BackColor = System.Drawing.SystemColors.Control;
            this.PanelForm.Controls.Add(this.PictureBox1);
            this.PanelForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelForm.Location = new System.Drawing.Point(320, 49);
            this.PanelForm.Margin = new System.Windows.Forms.Padding(4);
            this.PanelForm.Name = "PanelForm";
            this.PanelForm.Size = new System.Drawing.Size(1045, 582);
            this.PanelForm.TabIndex = 3;
            this.PanelForm.Paint += new System.Windows.Forms.PaintEventHandler(this.PanelForm_Paint);
            // 
            // FormAdministrador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1365, 631);
            this.Controls.Add(this.PanelForm);
            this.Controls.Add(this.PanelMenu);
            this.Controls.Add(this.PanelBarraTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormAdministrador";
            this.Text = "FormAdministrador";
            this.Load += new System.EventHandler(this.FormAdministrador_Load);
            this.PanelBarraTitulo.ResumeLayout(false);
            this.PanelBarraTitulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnRestaurar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMaximizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).EndInit();
            this.PanelMenu.ResumeLayout(false);
            this.PanelReporteSubmenu.ResumeLayout(false);
            this.Panel1.ResumeLayout(false);
            this.Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).EndInit();
            this.PanelForm.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.Panel PanelBarraTitulo;
        internal System.Windows.Forms.PictureBox btnRestaurar;
        internal System.Windows.Forms.PictureBox btnMaximizar;
        internal System.Windows.Forms.PictureBox btnMinimizar;
        internal System.Windows.Forms.PictureBox btnCerrar;
        internal System.Windows.Forms.Panel PanelMenu;
        private System.Windows.Forms.Panel PanelReporteSubmenu;
        private System.Windows.Forms.Button btnReporteHorasConsumidas;
        private System.Windows.Forms.Button btnReporteEntradaSalida;
        private System.Windows.Forms.Button btnReporteConsolidado;
        internal System.Windows.Forms.Panel Panel1;
        internal System.Windows.Forms.Label Labelapellidos;
        internal System.Windows.Forms.Label Labelnombres;
        internal System.Windows.Forms.Label LabelUsuario;
        internal System.Windows.Forms.PictureBox PictureBox2;
        internal System.Windows.Forms.Button btnCerrarSesion;
        internal System.Windows.Forms.Button btnReporte;
        internal System.Windows.Forms.Button btnUsuario;
        internal System.Windows.Forms.PictureBox PictureBox1;
        internal System.Windows.Forms.Panel PanelForm;
    }
}