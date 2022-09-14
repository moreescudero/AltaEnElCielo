namespace Vista
{
    partial class frm_Menu
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
            this.btn_Salir = new System.Windows.Forms.Button();
            this.lbl_Bienvenido = new System.Windows.Forms.Label();
            this.tmr_Fondo = new System.Windows.Forms.Timer(this.components);
            this.lbl_HoraActual = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_Salir
            // 
            this.btn_Salir.Location = new System.Drawing.Point(359, 316);
            this.btn_Salir.Name = "btn_Salir";
            this.btn_Salir.Size = new System.Drawing.Size(75, 23);
            this.btn_Salir.TabIndex = 0;
            this.btn_Salir.Text = "Salir";
            this.btn_Salir.UseVisualStyleBackColor = true;
            this.btn_Salir.Click += new System.EventHandler(this.btn_Salir_Click);
            // 
            // lbl_Bienvenido
            // 
            this.lbl_Bienvenido.AutoSize = true;
            this.lbl_Bienvenido.Location = new System.Drawing.Point(359, 39);
            this.lbl_Bienvenido.Name = "lbl_Bienvenido";
            this.lbl_Bienvenido.Size = new System.Drawing.Size(0, 15);
            this.lbl_Bienvenido.TabIndex = 1;
            // 
            // tmr_Fondo
            // 
            this.tmr_Fondo.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lbl_HoraActual
            // 
            this.lbl_HoraActual.AutoSize = true;
            this.lbl_HoraActual.Location = new System.Drawing.Point(731, 320);
            this.lbl_HoraActual.Name = "lbl_HoraActual";
            this.lbl_HoraActual.Size = new System.Drawing.Size(0, 15);
            this.lbl_HoraActual.TabIndex = 2;
            // 
            // frm_Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 363);
            this.Controls.Add(this.lbl_HoraActual);
            this.Controls.Add(this.lbl_Bienvenido);
            this.Controls.Add(this.btn_Salir);
            this.Name = "frm_Menu";
            this.Text = "FrmMenu";
            this.Load += new System.EventHandler(this.frm_Menu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btn_Salir;
        private Label lbl_Bienvenido;
        private System.Windows.Forms.Timer tmr_Fondo;
        private Label lbl_HoraActual;
    }
}