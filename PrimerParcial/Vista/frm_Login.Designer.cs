﻿namespace Vista
{
    partial class frm_Login
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
            this.btn_Cancelar = new System.Windows.Forms.Button();
            this.btn_Aceptar = new System.Windows.Forms.Button();
            this.txt_Usuario = new System.Windows.Forms.TextBox();
            this.txt_Contraseña = new System.Windows.Forms.TextBox();
            this.btn_Autocompletar = new System.Windows.Forms.Button();
            this.lbl_Hora = new System.Windows.Forms.Label();
            this.tmr_HoraActual = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // btn_Cancelar
            // 
            this.btn_Cancelar.Location = new System.Drawing.Point(123, 255);
            this.btn_Cancelar.Name = "btn_Cancelar";
            this.btn_Cancelar.Size = new System.Drawing.Size(75, 23);
            this.btn_Cancelar.TabIndex = 0;
            this.btn_Cancelar.Text = "Cancelar";
            this.btn_Cancelar.UseVisualStyleBackColor = true;
            this.btn_Cancelar.Click += new System.EventHandler(this.btn_Cancelar_Click);
            // 
            // btn_Aceptar
            // 
            this.btn_Aceptar.Location = new System.Drawing.Point(338, 255);
            this.btn_Aceptar.Name = "btn_Aceptar";
            this.btn_Aceptar.Size = new System.Drawing.Size(75, 23);
            this.btn_Aceptar.TabIndex = 1;
            this.btn_Aceptar.Text = "Aceptar";
            this.btn_Aceptar.UseVisualStyleBackColor = true;
            this.btn_Aceptar.Click += new System.EventHandler(this.btn_Aceptar_Click);
            // 
            // txt_Usuario
            // 
            this.txt_Usuario.Location = new System.Drawing.Point(196, 68);
            this.txt_Usuario.Name = "txt_Usuario";
            this.txt_Usuario.PlaceholderText = "Ingrese usuario";
            this.txt_Usuario.Size = new System.Drawing.Size(146, 23);
            this.txt_Usuario.TabIndex = 2;
            // 
            // txt_Contraseña
            // 
            this.txt_Contraseña.Location = new System.Drawing.Point(196, 162);
            this.txt_Contraseña.Name = "txt_Contraseña";
            this.txt_Contraseña.PasswordChar = '*';
            this.txt_Contraseña.PlaceholderText = "Ingrese contraseña";
            this.txt_Contraseña.Size = new System.Drawing.Size(146, 23);
            this.txt_Contraseña.TabIndex = 3;
            // 
            // btn_Autocompletar
            // 
            this.btn_Autocompletar.Location = new System.Drawing.Point(196, 324);
            this.btn_Autocompletar.Name = "btn_Autocompletar";
            this.btn_Autocompletar.Size = new System.Drawing.Size(146, 23);
            this.btn_Autocompletar.TabIndex = 4;
            this.btn_Autocompletar.Text = "Autocompletar";
            this.btn_Autocompletar.UseVisualStyleBackColor = true;
            this.btn_Autocompletar.Click += new System.EventHandler(this.btn_Autocompletar_Click);
            // 
            // lbl_Hora
            // 
            this.lbl_Hora.AutoSize = true;
            this.lbl_Hora.Location = new System.Drawing.Point(472, 386);
            this.lbl_Hora.Name = "lbl_Hora";
            this.lbl_Hora.Size = new System.Drawing.Size(0, 15);
            this.lbl_Hora.TabIndex = 5;
            // 
            // tmr_HoraActual
            // 
            this.tmr_HoraActual.Tick += new System.EventHandler(this.tmr_HoraActual_Tick);
            // 
            // frm_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(564, 429);
            this.Controls.Add(this.lbl_Hora);
            this.Controls.Add(this.btn_Autocompletar);
            this.Controls.Add(this.txt_Contraseña);
            this.Controls.Add(this.txt_Usuario);
            this.Controls.Add(this.btn_Aceptar);
            this.Controls.Add(this.btn_Cancelar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "frm_Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmLogin";
            this.Load += new System.EventHandler(this.FrmLogin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btn_Cancelar;
        private Button btn_Aceptar;
        private TextBox txt_Usuario;
        private TextBox txt_Contraseña;
        private Button btn_Autocompletar;
        private Label lbl_Hora;
        private System.Windows.Forms.Timer tmr_HoraActual;
    }
}