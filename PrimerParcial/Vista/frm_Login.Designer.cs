namespace Vista
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Login));
            this.btn_Cancelar = new System.Windows.Forms.Button();
            this.btn_Aceptar = new System.Windows.Forms.Button();
            this.txt_Usuario = new System.Windows.Forms.TextBox();
            this.txt_Contraseña = new System.Windows.Forms.TextBox();
            this.btn_Autocompletar = new System.Windows.Forms.Button();
            this.lbl_Hora = new System.Windows.Forms.Label();
            this.tmr_HoraActual = new System.Windows.Forms.Timer(this.components);
            this.tip_Ayuda = new System.Windows.Forms.ToolTip(this.components);
            this.lbl_Incorrecto = new System.Windows.Forms.Label();
            this.pic_Nube2 = new System.Windows.Forms.PictureBox();
            this.pic_Nube1 = new System.Windows.Forms.PictureBox();
            this.pic_Nube3 = new System.Windows.Forms.PictureBox();
            this.pic_Nube4 = new System.Windows.Forms.PictureBox();
            this.pic_Nube5 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Nube2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Nube1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Nube3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Nube4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Nube5)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Cancelar
            // 
            this.btn_Cancelar.Location = new System.Drawing.Point(115, 260);
            this.btn_Cancelar.Name = "btn_Cancelar";
            this.btn_Cancelar.Size = new System.Drawing.Size(97, 23);
            this.btn_Cancelar.TabIndex = 0;
            this.btn_Cancelar.Text = "Cerrar";
            this.tip_Ayuda.SetToolTip(this.btn_Cancelar, "Cierra el programa");
            this.btn_Cancelar.UseVisualStyleBackColor = true;
            this.btn_Cancelar.Click += new System.EventHandler(this.btn_Cancelar_Click);
            // 
            // btn_Aceptar
            // 
            this.btn_Aceptar.Location = new System.Drawing.Point(352, 260);
            this.btn_Aceptar.Name = "btn_Aceptar";
            this.btn_Aceptar.Size = new System.Drawing.Size(97, 23);
            this.btn_Aceptar.TabIndex = 1;
            this.btn_Aceptar.Text = "Aceptar";
            this.tip_Ayuda.SetToolTip(this.btn_Aceptar, "Ingresa si el usuario y la contraseña \r\nson correctos");
            this.btn_Aceptar.UseVisualStyleBackColor = true;
            this.btn_Aceptar.Click += new System.EventHandler(this.btn_Aceptar_Click);
            // 
            // txt_Usuario
            // 
            this.txt_Usuario.Location = new System.Drawing.Point(207, 73);
            this.txt_Usuario.Name = "txt_Usuario";
            this.txt_Usuario.PlaceholderText = "Ingrese usuario";
            this.txt_Usuario.Size = new System.Drawing.Size(146, 23);
            this.txt_Usuario.TabIndex = 2;
            this.txt_Usuario.TextChanged += new System.EventHandler(this.txt_Usuario_TextChanged);
            // 
            // txt_Contraseña
            // 
            this.txt_Contraseña.Location = new System.Drawing.Point(207, 167);
            this.txt_Contraseña.Name = "txt_Contraseña";
            this.txt_Contraseña.PasswordChar = '*';
            this.txt_Contraseña.PlaceholderText = "Ingrese contraseña";
            this.txt_Contraseña.Size = new System.Drawing.Size(146, 23);
            this.txt_Contraseña.TabIndex = 3;
            // 
            // btn_Autocompletar
            // 
            this.btn_Autocompletar.Location = new System.Drawing.Point(207, 329);
            this.btn_Autocompletar.Name = "btn_Autocompletar";
            this.btn_Autocompletar.Size = new System.Drawing.Size(146, 23);
            this.btn_Autocompletar.TabIndex = 4;
            this.btn_Autocompletar.Text = "Autocompletar";
            this.tip_Ayuda.SetToolTip(this.btn_Autocompletar, "Carga el usuario con un empleado \r\naleatorio para poder ingresar al programa");
            this.btn_Autocompletar.UseVisualStyleBackColor = true;
            this.btn_Autocompletar.Click += new System.EventHandler(this.btn_Autocompletar_Click);
            // 
            // lbl_Hora
            // 
            this.lbl_Hora.AutoSize = true;
            this.lbl_Hora.Location = new System.Drawing.Point(443, 387);
            this.lbl_Hora.Name = "lbl_Hora";
            this.lbl_Hora.Size = new System.Drawing.Size(0, 15);
            this.lbl_Hora.TabIndex = 5;
            // 
            // tmr_HoraActual
            // 
            this.tmr_HoraActual.Tick += new System.EventHandler(this.tmr_HoraActual_Tick);
            // 
            // lbl_Incorrecto
            // 
            this.lbl_Incorrecto.AutoSize = true;
            this.lbl_Incorrecto.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Incorrecto.ForeColor = System.Drawing.Color.Brown;
            this.lbl_Incorrecto.Location = new System.Drawing.Point(169, 227);
            this.lbl_Incorrecto.Name = "lbl_Incorrecto";
            this.lbl_Incorrecto.Size = new System.Drawing.Size(174, 15);
            this.lbl_Incorrecto.TabIndex = 10;
            this.lbl_Incorrecto.Text = "usuario o contraseña incorrecto";
            this.lbl_Incorrecto.Visible = false;
            // 
            // pic_Nube2
            // 
            this.pic_Nube2.BackColor = System.Drawing.Color.Transparent;
            this.pic_Nube2.Image = global::Vista.Properties.Resources.nube;
            this.pic_Nube2.Location = new System.Drawing.Point(12, 40);
            this.pic_Nube2.Name = "pic_Nube2";
            this.pic_Nube2.Size = new System.Drawing.Size(239, 136);
            this.pic_Nube2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_Nube2.TabIndex = 11;
            this.pic_Nube2.TabStop = false;
            // 
            // pic_Nube1
            // 
            this.pic_Nube1.BackColor = System.Drawing.Color.Transparent;
            this.pic_Nube1.Image = global::Vista.Properties.Resources.nube;
            this.pic_Nube1.Location = new System.Drawing.Point(313, 167);
            this.pic_Nube1.Name = "pic_Nube1";
            this.pic_Nube1.Size = new System.Drawing.Size(223, 113);
            this.pic_Nube1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_Nube1.TabIndex = 12;
            this.pic_Nube1.TabStop = false;
            // 
            // pic_Nube3
            // 
            this.pic_Nube3.BackColor = System.Drawing.Color.Transparent;
            this.pic_Nube3.Image = global::Vista.Properties.Resources.nube;
            this.pic_Nube3.Location = new System.Drawing.Point(221, 311);
            this.pic_Nube3.Name = "pic_Nube3";
            this.pic_Nube3.Size = new System.Drawing.Size(182, 91);
            this.pic_Nube3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_Nube3.TabIndex = 13;
            this.pic_Nube3.TabStop = false;
            // 
            // pic_Nube4
            // 
            this.pic_Nube4.BackColor = System.Drawing.Color.Transparent;
            this.pic_Nube4.ErrorImage = null;
            this.pic_Nube4.Image = global::Vista.Properties.Resources.nube;
            this.pic_Nube4.InitialImage = null;
            this.pic_Nube4.Location = new System.Drawing.Point(331, -13);
            this.pic_Nube4.Name = "pic_Nube4";
            this.pic_Nube4.Size = new System.Drawing.Size(196, 94);
            this.pic_Nube4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_Nube4.TabIndex = 14;
            this.pic_Nube4.TabStop = false;
            // 
            // pic_Nube5
            // 
            this.pic_Nube5.BackColor = System.Drawing.Color.Transparent;
            this.pic_Nube5.Image = ((System.Drawing.Image)(resources.GetObject("pic_Nube5.Image")));
            this.pic_Nube5.Location = new System.Drawing.Point(-46, 274);
            this.pic_Nube5.Name = "pic_Nube5";
            this.pic_Nube5.Size = new System.Drawing.Size(200, 97);
            this.pic_Nube5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_Nube5.TabIndex = 15;
            this.pic_Nube5.TabStop = false;
            // 
            // frm_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(564, 429);
            this.ControlBox = false;
            this.Controls.Add(this.txt_Usuario);
            this.Controls.Add(this.lbl_Incorrecto);
            this.Controls.Add(this.lbl_Hora);
            this.Controls.Add(this.btn_Autocompletar);
            this.Controls.Add(this.txt_Contraseña);
            this.Controls.Add(this.btn_Aceptar);
            this.Controls.Add(this.btn_Cancelar);
            this.Controls.Add(this.pic_Nube1);
            this.Controls.Add(this.pic_Nube3);
            this.Controls.Add(this.pic_Nube2);
            this.Controls.Add(this.pic_Nube4);
            this.Controls.Add(this.pic_Nube5);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.Load += new System.EventHandler(this.FrmLogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pic_Nube2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Nube1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Nube3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Nube4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Nube5)).EndInit();
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
        private ToolTip tip_Ayuda;
        private Label lbl_Incorrecto;
        private PictureBox pic_Nube2;
        private PictureBox pic_Nube1;
        private PictureBox pic_Nube3;
        private PictureBox pic_Nube4;
        private PictureBox pic_Nube5;
    }
}