﻿namespace BPO_CONTROL
{
    partial class FormBreak1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormBreak1));
            this.SissaLogo = new System.Windows.Forms.PictureBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.btnRestaurarTimer = new System.Windows.Forms.Button();
            this.btnDetenerCronometro = new System.Windows.Forms.PictureBox();
            this.btnIniciarCronometro = new System.Windows.Forms.PictureBox();
            this.LabelCronometro = new System.Windows.Forms.Label();
            this.timer_Cronometro = new System.Windows.Forms.Timer(this.components);
            this.btn_Regresar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.SissaLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDetenerCronometro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnIniciarCronometro)).BeginInit();
            this.SuspendLayout();
            // 
            // SissaLogo
            // 
            this.SissaLogo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SissaLogo.Image = ((System.Drawing.Image)(resources.GetObject("SissaLogo.Image")));
            this.SissaLogo.Location = new System.Drawing.Point(145, 118);
            this.SissaLogo.Margin = new System.Windows.Forms.Padding(4);
            this.SissaLogo.Name = "SissaLogo";
            this.SissaLogo.Size = new System.Drawing.Size(484, 158);
            this.SissaLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.SissaLogo.TabIndex = 47;
            this.SissaLogo.TabStop = false;
            this.SissaLogo.Visible = false;
            // 
            // Label1
            // 
            this.Label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.Location = new System.Drawing.Point(169, 37);
            this.Label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(416, 32);
            this.Label1.TabIndex = 46;
            this.Label1.Text = "Tiempo estimado en el Break 1";
            // 
            // btnRestaurarTimer
            // 
            this.btnRestaurarTimer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRestaurarTimer.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRestaurarTimer.Location = new System.Drawing.Point(308, 374);
            this.btnRestaurarTimer.Margin = new System.Windows.Forms.Padding(4);
            this.btnRestaurarTimer.Name = "btnRestaurarTimer";
            this.btnRestaurarTimer.Size = new System.Drawing.Size(171, 46);
            this.btnRestaurarTimer.TabIndex = 45;
            this.btnRestaurarTimer.Text = "Restaurar Tiempo";
            this.btnRestaurarTimer.UseVisualStyleBackColor = true;
            this.btnRestaurarTimer.Click += new System.EventHandler(this.btnRestaurarTimer_Click);
            // 
            // btnDetenerCronometro
            // 
            this.btnDetenerCronometro.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDetenerCronometro.Image = ((System.Drawing.Image)(resources.GetObject("btnDetenerCronometro.Image")));
            this.btnDetenerCronometro.Location = new System.Drawing.Point(308, 118);
            this.btnDetenerCronometro.Margin = new System.Windows.Forms.Padding(4);
            this.btnDetenerCronometro.Name = "btnDetenerCronometro";
            this.btnDetenerCronometro.Size = new System.Drawing.Size(128, 128);
            this.btnDetenerCronometro.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.btnDetenerCronometro.TabIndex = 44;
            this.btnDetenerCronometro.TabStop = false;
            this.btnDetenerCronometro.Click += new System.EventHandler(this.btnDetenerCronometro_Click);
            // 
            // btnIniciarCronometro
            // 
            this.btnIniciarCronometro.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnIniciarCronometro.Image = ((System.Drawing.Image)(resources.GetObject("btnIniciarCronometro.Image")));
            this.btnIniciarCronometro.Location = new System.Drawing.Point(308, 118);
            this.btnIniciarCronometro.Margin = new System.Windows.Forms.Padding(4);
            this.btnIniciarCronometro.Name = "btnIniciarCronometro";
            this.btnIniciarCronometro.Size = new System.Drawing.Size(128, 128);
            this.btnIniciarCronometro.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.btnIniciarCronometro.TabIndex = 43;
            this.btnIniciarCronometro.TabStop = false;
            this.btnIniciarCronometro.Click += new System.EventHandler(this.btnIniciarCronometro_Click);
            // 
            // LabelCronometro
            // 
            this.LabelCronometro.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.LabelCronometro.AutoSize = true;
            this.LabelCronometro.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelCronometro.ForeColor = System.Drawing.Color.Black;
            this.LabelCronometro.Location = new System.Drawing.Point(287, 300);
            this.LabelCronometro.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelCronometro.Name = "LabelCronometro";
            this.LabelCronometro.Size = new System.Drawing.Size(199, 40);
            this.LabelCronometro.TabIndex = 42;
            this.LabelCronometro.Text = "00:00:00.00";
            this.LabelCronometro.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer_Cronometro
            // 
            this.timer_Cronometro.Tick += new System.EventHandler(this.timer_Cronometro_Tick);
            // 
            // btn_Regresar
            // 
            this.btn_Regresar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Regresar.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Regresar.Location = new System.Drawing.Point(308, 374);
            this.btn_Regresar.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Regresar.Name = "btn_Regresar";
            this.btn_Regresar.Size = new System.Drawing.Size(171, 46);
            this.btn_Regresar.TabIndex = 48;
            this.btn_Regresar.Text = "Regresar";
            this.btn_Regresar.UseVisualStyleBackColor = true;
            this.btn_Regresar.Click += new System.EventHandler(this.btn_Regresar_Click);
            // 
            // FormBreak1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(775, 457);
            this.Controls.Add(this.btn_Regresar);
            this.Controls.Add(this.SissaLogo);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.btnRestaurarTimer);
            this.Controls.Add(this.btnDetenerCronometro);
            this.Controls.Add(this.btnIniciarCronometro);
            this.Controls.Add(this.LabelCronometro);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormBreak1";
            this.Text = "FormBreak1";
            this.Load += new System.EventHandler(this.FormBreak1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.SissaLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDetenerCronometro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnIniciarCronometro)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.PictureBox SissaLogo;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.Button btnRestaurarTimer;
        internal System.Windows.Forms.PictureBox btnDetenerCronometro;
        internal System.Windows.Forms.PictureBox btnIniciarCronometro;
        internal System.Windows.Forms.Label LabelCronometro;
        private System.Windows.Forms.Timer timer_Cronometro;
        internal System.Windows.Forms.Button btn_Regresar;
    }
}