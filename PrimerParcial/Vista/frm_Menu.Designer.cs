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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Menu));
            this.btn_CerrarSesion = new System.Windows.Forms.Button();
            this.lbl_Bienvenido = new System.Windows.Forms.Label();
            this.tmr_Fondo = new System.Windows.Forms.Timer(this.components);
            this.lbl_HoraActual = new System.Windows.Forms.Label();
            this.pic_VisualizarVuelos = new System.Windows.Forms.PictureBox();
            this.lbl_VisualizarVuelos = new System.Windows.Forms.Label();
            this.pic_Vender = new System.Windows.Forms.PictureBox();
            this.lbl_VenderVuelos = new System.Windows.Forms.Label();
            this.pic_Estadisticas = new System.Windows.Forms.PictureBox();
            this.lbl_Estadisticas = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_Salir = new System.Windows.Forms.Button();
            this.tip_Ayuda = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pic_VisualizarVuelos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Vender)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Estadisticas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_CerrarSesion
            // 
            this.btn_CerrarSesion.Location = new System.Drawing.Point(278, 316);
            this.btn_CerrarSesion.Name = "btn_CerrarSesion";
            this.btn_CerrarSesion.Size = new System.Drawing.Size(109, 23);
            this.btn_CerrarSesion.TabIndex = 0;
            this.btn_CerrarSesion.Text = "Cerrar Sesion";
            this.btn_CerrarSesion.UseVisualStyleBackColor = true;
            this.btn_CerrarSesion.Click += new System.EventHandler(this.btn_CerrarSesion_Click);
            // 
            // lbl_Bienvenido
            // 
            this.lbl_Bienvenido.AutoSize = true;
            this.lbl_Bienvenido.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Bienvenido.Location = new System.Drawing.Point(368, 42);
            this.lbl_Bienvenido.Name = "lbl_Bienvenido";
            this.lbl_Bienvenido.Size = new System.Drawing.Size(0, 15);
            this.lbl_Bienvenido.TabIndex = 1;
            // 
            // tmr_Fondo
            // 
            this.tmr_Fondo.Interval = 60000;
            this.tmr_Fondo.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lbl_HoraActual
            // 
            this.lbl_HoraActual.AutoSize = true;
            this.lbl_HoraActual.BackColor = System.Drawing.Color.Transparent;
            this.lbl_HoraActual.Location = new System.Drawing.Point(731, 320);
            this.lbl_HoraActual.Name = "lbl_HoraActual";
            this.lbl_HoraActual.Size = new System.Drawing.Size(0, 15);
            this.lbl_HoraActual.TabIndex = 2;
            // 
            // pic_VisualizarVuelos
            // 
            this.pic_VisualizarVuelos.Image = ((System.Drawing.Image)(resources.GetObject("pic_VisualizarVuelos.Image")));
            this.pic_VisualizarVuelos.Location = new System.Drawing.Point(204, 183);
            this.pic_VisualizarVuelos.Name = "pic_VisualizarVuelos";
            this.pic_VisualizarVuelos.Size = new System.Drawing.Size(67, 67);
            this.pic_VisualizarVuelos.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_VisualizarVuelos.TabIndex = 3;
            this.pic_VisualizarVuelos.TabStop = false;
            this.tip_Ayuda.SetToolTip(this.pic_VisualizarVuelos, "Accedes a la lista de todos los vuelos disponibles y podes agregar un nuevo vuelo" +
        "");
            this.pic_VisualizarVuelos.Click += new System.EventHandler(this.pic_VisualizarVuelos_Click);
            // 
            // lbl_VisualizarVuelos
            // 
            this.lbl_VisualizarVuelos.AutoSize = true;
            this.lbl_VisualizarVuelos.BackColor = System.Drawing.Color.Transparent;
            this.lbl_VisualizarVuelos.Location = new System.Drawing.Point(194, 165);
            this.lbl_VisualizarVuelos.Name = "lbl_VisualizarVuelos";
            this.lbl_VisualizarVuelos.Size = new System.Drawing.Size(92, 15);
            this.lbl_VisualizarVuelos.TabIndex = 4;
            this.lbl_VisualizarVuelos.Text = "visualizar vuelos";
            // 
            // pic_Vender
            // 
            this.pic_Vender.Image = ((System.Drawing.Image)(resources.GetObject("pic_Vender.Image")));
            this.pic_Vender.Location = new System.Drawing.Point(350, 183);
            this.pic_Vender.Name = "pic_Vender";
            this.pic_Vender.Size = new System.Drawing.Size(80, 67);
            this.pic_Vender.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_Vender.TabIndex = 5;
            this.pic_Vender.TabStop = false;
            this.tip_Ayuda.SetToolTip(this.pic_Vender, "Podes vender pasajes a un grupo familiar y agregar un vuelo en caso de que el des" +
        "tino y el origen que deseen no tenga un vuelo disponible");
            this.pic_Vender.Click += new System.EventHandler(this.pic_Vender_Click);
            // 
            // lbl_VenderVuelos
            // 
            this.lbl_VenderVuelos.AutoSize = true;
            this.lbl_VenderVuelos.BackColor = System.Drawing.Color.Transparent;
            this.lbl_VenderVuelos.Location = new System.Drawing.Point(350, 165);
            this.lbl_VenderVuelos.Name = "lbl_VenderVuelos";
            this.lbl_VenderVuelos.Size = new System.Drawing.Size(80, 15);
            this.lbl_VenderVuelos.TabIndex = 6;
            this.lbl_VenderVuelos.Text = "vender vuelos";
            // 
            // pic_Estadisticas
            // 
            this.pic_Estadisticas.Image = ((System.Drawing.Image)(resources.GetObject("pic_Estadisticas.Image")));
            this.pic_Estadisticas.Location = new System.Drawing.Point(508, 183);
            this.pic_Estadisticas.Name = "pic_Estadisticas";
            this.pic_Estadisticas.Size = new System.Drawing.Size(90, 67);
            this.pic_Estadisticas.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_Estadisticas.TabIndex = 7;
            this.pic_Estadisticas.TabStop = false;
            this.tip_Ayuda.SetToolTip(this.pic_Estadisticas, "Podes visualizar los vuelos finalizados, las recaudaciones totales de la aeroline" +
        "a, los datos de los aviones, etc");
            this.pic_Estadisticas.Click += new System.EventHandler(this.pic_Estadisticas_Click);
            // 
            // lbl_Estadisticas
            // 
            this.lbl_Estadisticas.AutoSize = true;
            this.lbl_Estadisticas.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Estadisticas.Location = new System.Drawing.Point(495, 165);
            this.lbl_Estadisticas.Name = "lbl_Estadisticas";
            this.lbl_Estadisticas.Size = new System.Drawing.Size(120, 15);
            this.lbl_Estadisticas.TabIndex = 8;
            this.lbl_Estadisticas.Text = "estadisticas historicas";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(325, 29);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(37, 35);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // btn_Salir
            // 
            this.btn_Salir.Location = new System.Drawing.Point(403, 316);
            this.btn_Salir.Name = "btn_Salir";
            this.btn_Salir.Size = new System.Drawing.Size(109, 23);
            this.btn_Salir.TabIndex = 10;
            this.btn_Salir.Text = "Salir";
            this.btn_Salir.UseVisualStyleBackColor = true;
            this.btn_Salir.Click += new System.EventHandler(this.btn_Salir_Click);
            // 
            // frm_Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(804, 363);
            this.ControlBox = false;
            this.Controls.Add(this.btn_Salir);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lbl_Estadisticas);
            this.Controls.Add(this.pic_Estadisticas);
            this.Controls.Add(this.lbl_VenderVuelos);
            this.Controls.Add(this.pic_Vender);
            this.Controls.Add(this.lbl_VisualizarVuelos);
            this.Controls.Add(this.pic_VisualizarVuelos);
            this.Controls.Add(this.lbl_HoraActual);
            this.Controls.Add(this.lbl_Bienvenido);
            this.Controls.Add(this.btn_CerrarSesion);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu Principal";
            this.Load += new System.EventHandler(this.frm_Menu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pic_VisualizarVuelos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Vender)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Estadisticas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btn_CerrarSesion;
        private Label lbl_Bienvenido;
        private System.Windows.Forms.Timer tmr_Fondo;
        private Label lbl_HoraActual;
        private PictureBox pic_VisualizarVuelos;
        private Label lbl_VisualizarVuelos;
        private PictureBox pic_Vender;
        private Label lbl_VenderVuelos;
        private PictureBox pic_Estadisticas;
        private Label lbl_Estadisticas;
        private PictureBox pictureBox1;
        private Button btn_Salir;
        private ToolTip tip_Ayuda;
    }
}