namespace BPO_CONTROL
{
    partial class FormCrud
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCrud));
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.PictureBox1 = new System.Windows.Forms.PictureBox();
            this.TextBoxBusqueda = new System.Windows.Forms.TextBox();
            this.DataGridViewUsuarios = new System.Windows.Forms.DataGridView();
            this.btnCerrarForm = new System.Windows.Forms.PictureBox();
            this.bLUsuarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewUsuarios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrarForm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bLUsuarioBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnActualizar
            // 
            this.btnActualizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnActualizar.Image = ((System.Drawing.Image)(resources.GetObject("btnActualizar.Image")));
            this.btnActualizar.Location = new System.Drawing.Point(870, 489);
            this.btnActualizar.Margin = new System.Windows.Forms.Padding(4);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(184, 50);
            this.btnActualizar.TabIndex = 21;
            this.btnActualizar.Text = "Actualizar Datos";
            this.btnActualizar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEliminar.Image = ((System.Drawing.Image)(resources.GetObject("btnEliminar.Image")));
            this.btnEliminar.Location = new System.Drawing.Point(870, 263);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(4);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(184, 50);
            this.btnEliminar.TabIndex = 20;
            this.btnEliminar.Text = "Eliminar Usuario";
            this.btnEliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEditar.Image = ((System.Drawing.Image)(resources.GetObject("btnEditar.Image")));
            this.btnEditar.Location = new System.Drawing.Point(870, 178);
            this.btnEditar.Margin = new System.Windows.Forms.Padding(4);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(184, 50);
            this.btnEditar.TabIndex = 19;
            this.btnEditar.Text = "Editar Usuario";
            this.btnEditar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAgregar.Image = ((System.Drawing.Image)(resources.GetObject("btnAgregar.Image")));
            this.btnAgregar.Location = new System.Drawing.Point(870, 84);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(4);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(184, 50);
            this.btnAgregar.TabIndex = 18;
            this.btnAgregar.Text = "Agregar Usuario";
            this.btnAgregar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // PictureBox1
            // 
            this.PictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("PictureBox1.Image")));
            this.PictureBox1.Location = new System.Drawing.Point(737, 15);
            this.PictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.PictureBox1.Name = "PictureBox1";
            this.PictureBox1.Size = new System.Drawing.Size(53, 33);
            this.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PictureBox1.TabIndex = 17;
            this.PictureBox1.TabStop = false;
            // 
            // TextBoxBusqueda
            // 
            this.TextBoxBusqueda.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TextBoxBusqueda.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TextBoxBusqueda.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxBusqueda.Location = new System.Drawing.Point(16, 15);
            this.TextBoxBusqueda.Margin = new System.Windows.Forms.Padding(4);
            this.TextBoxBusqueda.Name = "TextBoxBusqueda";
            this.TextBoxBusqueda.Size = new System.Drawing.Size(713, 32);
            this.TextBoxBusqueda.TabIndex = 16;
            // 
            // DataGridViewUsuarios
            // 
            this.DataGridViewUsuarios.AllowUserToAddRows = false;
            this.DataGridViewUsuarios.AllowUserToDeleteRows = false;
            this.DataGridViewUsuarios.AllowUserToOrderColumns = true;
            this.DataGridViewUsuarios.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.DataGridViewUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridViewUsuarios.Location = new System.Drawing.Point(16, 68);
            this.DataGridViewUsuarios.Margin = new System.Windows.Forms.Padding(4);
            this.DataGridViewUsuarios.Name = "DataGridViewUsuarios";
            this.DataGridViewUsuarios.ReadOnly = true;
            this.DataGridViewUsuarios.RowHeadersWidth = 51;
            this.DataGridViewUsuarios.Size = new System.Drawing.Size(833, 471);
            this.DataGridViewUsuarios.TabIndex = 15;
            this.DataGridViewUsuarios.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridViewUsuarios_CellContentClick);
            this.DataGridViewUsuarios.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridViewUsuarios_CellContentClick);
            this.DataGridViewUsuarios.DoubleClick += new System.EventHandler(this.DataGridViewUsuarios_DoubleClick);
            // 
            // btnCerrarForm
            // 
            this.btnCerrarForm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrarForm.Image = ((System.Drawing.Image)(resources.GetObject("btnCerrarForm.Image")));
            this.btnCerrarForm.Location = new System.Drawing.Point(1020, 15);
            this.btnCerrarForm.Margin = new System.Windows.Forms.Padding(4);
            this.btnCerrarForm.Name = "btnCerrarForm";
            this.btnCerrarForm.Size = new System.Drawing.Size(16, 16);
            this.btnCerrarForm.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.btnCerrarForm.TabIndex = 22;
            this.btnCerrarForm.TabStop = false;
            this.btnCerrarForm.Click += new System.EventHandler(this.btnCerrarForm_Click);
            // 
            // bLUsuarioBindingSource
            // 
            this.bLUsuarioBindingSource.DataSource = typeof(BL.BL_Usuario);
            // 
            // FormCrud
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.btnCerrarForm);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.PictureBox1);
            this.Controls.Add(this.TextBoxBusqueda);
            this.Controls.Add(this.DataGridViewUsuarios);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormCrud";
            this.Text = "FormCrud";
            this.Load += new System.EventHandler(this.FormCrud_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewUsuarios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrarForm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bLUsuarioBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Button btnActualizar;
        internal System.Windows.Forms.Button btnEliminar;
        internal System.Windows.Forms.Button btnEditar;
        internal System.Windows.Forms.Button btnAgregar;
        internal System.Windows.Forms.PictureBox PictureBox1;
        internal System.Windows.Forms.TextBox TextBoxBusqueda;
        internal System.Windows.Forms.DataGridView DataGridViewUsuarios;
        internal System.Windows.Forms.PictureBox btnCerrarForm;
        private System.Windows.Forms.BindingSource bLUsuarioBindingSource;
    }
}