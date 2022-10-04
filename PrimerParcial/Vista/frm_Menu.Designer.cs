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
            this.pic_Logo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pic_VisualizarVuelos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Vender)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Estadisticas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Logo)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_CerrarSesion
            // 
            this.btn_CerrarSesion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_CerrarSesion.Location = new System.Drawing.Point(262, 317);
            this.btn_CerrarSesion.Name = "btn_CerrarSesion";
            this.btn_CerrarSesion.Size = new System.Drawing.Size(132, 23);
            this.btn_CerrarSesion.TabIndex = 0;
            this.btn_CerrarSesion.Text = "Cerrar Sesion";
            this.btn_CerrarSesion.UseVisualStyleBackColor = true;
            this.btn_CerrarSesion.Click += new System.EventHandler(this.btn_CerrarSesion_Click);
            // 
            // lbl_Bienvenido
            // 
            this.lbl_Bienvenido.AutoSize = true;
            this.lbl_Bienvenido.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Bienvenido.Location = new System.Drawing.Point(55, 317);
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
            this.lbl_HoraActual.Location = new System.Drawing.Point(698, 320);
            this.lbl_HoraActual.Name = "lbl_HoraActual";
            this.lbl_HoraActual.Size = new System.Drawing.Size(0, 15);
            this.lbl_HoraActual.TabIndex = 2;
            // 
            // pic_VisualizarVuelos
            // 
            this.pic_VisualizarVuelos.BackColor = System.Drawing.Color.Transparent;
            this.pic_VisualizarVuelos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pic_VisualizarVuelos.Image = ((System.Drawing.Image)(resources.GetObject("pic_VisualizarVuelos.Image")));
            this.pic_VisualizarVuelos.Location = new System.Drawing.Point(205, 165);
            this.pic_VisualizarVuelos.Name = "pic_VisualizarVuelos";
            this.pic_VisualizarVuelos.Size = new System.Drawing.Size(98, 96);
            this.pic_VisualizarVuelos.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_VisualizarVuelos.TabIndex = 3;
            this.pic_VisualizarVuelos.TabStop = false;
            this.tip_Ayuda.SetToolTip(this.pic_VisualizarVuelos, "Accedes a la lista de todos los \r\nvuelos disponibles y podes agregar un \r\nnuevo v" +
        "uelo");
            this.pic_VisualizarVuelos.Click += new System.EventHandler(this.pic_VisualizarVuelos_Click);
            // 
            // lbl_VisualizarVuelos
            // 
            this.lbl_VisualizarVuelos.AutoSize = true;
            this.lbl_VisualizarVuelos.BackColor = System.Drawing.Color.Transparent;
            this.lbl_VisualizarVuelos.Location = new System.Drawing.Point(195, 165);
            this.lbl_VisualizarVuelos.Name = "lbl_VisualizarVuelos";
            this.lbl_VisualizarVuelos.Size = new System.Drawing.Size(92, 15);
            this.lbl_VisualizarVuelos.TabIndex = 4;
            this.lbl_VisualizarVuelos.Text = "visualizar vuelos";
            // 
            // pic_Vender
            // 
            this.pic_Vender.BackColor = System.Drawing.Color.Transparent;
            this.pic_Vender.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pic_Vender.Image = ((System.Drawing.Image)(resources.GetObject("pic_Vender.Image")));
            this.pic_Vender.Location = new System.Drawing.Point(360, 174);
            this.pic_Vender.Name = "pic_Vender";
            this.pic_Vender.Size = new System.Drawing.Size(84, 75);
            this.pic_Vender.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_Vender.TabIndex = 5;
            this.pic_Vender.TabStop = false;
            this.tip_Ayuda.SetToolTip(this.pic_Vender, "Podes vender pasajes a un grupo familiar y \r\nagregar un vuelo en caso de que el d" +
        "estino \r\ny el origen que deseen no tenga un vuelo \r\ndisponible");
            this.pic_Vender.Click += new System.EventHandler(this.pic_Vender_Click);
            // 
            // lbl_VenderVuelos
            // 
            this.lbl_VenderVuelos.AutoSize = true;
            this.lbl_VenderVuelos.BackColor = System.Drawing.Color.Transparent;
            this.lbl_VenderVuelos.Location = new System.Drawing.Point(357, 165);
            this.lbl_VenderVuelos.Name = "lbl_VenderVuelos";
            this.lbl_VenderVuelos.Size = new System.Drawing.Size(80, 15);
            this.lbl_VenderVuelos.TabIndex = 6;
            this.lbl_VenderVuelos.Text = "vender vuelos";
            // 
            // pic_Estadisticas
            // 
            this.pic_Estadisticas.BackColor = System.Drawing.Color.Transparent;
            this.pic_Estadisticas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pic_Estadisticas.Image = ((System.Drawing.Image)(resources.GetObject("pic_Estadisticas.Image")));
            this.pic_Estadisticas.Location = new System.Drawing.Point(497, 165);
            this.pic_Estadisticas.Name = "pic_Estadisticas";
            this.pic_Estadisticas.Size = new System.Drawing.Size(108, 96);
            this.pic_Estadisticas.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_Estadisticas.TabIndex = 7;
            this.pic_Estadisticas.TabStop = false;
            this.tip_Ayuda.SetToolTip(this.pic_Estadisticas, "Podes visualizar los vuelos finalizados, \r\nlas recaudaciones totales de la aeroli" +
        "nea, \r\nlos datos de los aviones, etc");
            this.pic_Estadisticas.Click += new System.EventHandler(this.pic_Estadisticas_Click);
            // 
            // lbl_Estadisticas
            // 
            this.lbl_Estadisticas.AutoSize = true;
            this.lbl_Estadisticas.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Estadisticas.Location = new System.Drawing.Point(473, 165);
            this.lbl_Estadisticas.Name = "lbl_Estadisticas";
            this.lbl_Estadisticas.Size = new System.Drawing.Size(120, 15);
            this.lbl_Estadisticas.TabIndex = 8;
            this.lbl_Estadisticas.Text = "estadisticas historicas";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::Vista.Properties.Resources.profile_avatar;
            this.pictureBox1.Location = new System.Drawing.Point(12, 304);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(37, 35);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // btn_Salir
            // 
            this.btn_Salir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Salir.Location = new System.Drawing.Point(414, 317);
            this.btn_Salir.Name = "btn_Salir";
            this.btn_Salir.Size = new System.Drawing.Size(132, 23);
            this.btn_Salir.TabIndex = 10;
            this.btn_Salir.Text = "Salir";
            this.btn_Salir.UseVisualStyleBackColor = true;
            this.btn_Salir.Click += new System.EventHandler(this.btn_Salir_Click);
            // 
            // pic_Logo
            // 
            this.pic_Logo.BackColor = System.Drawing.Color.Transparent;
            this.pic_Logo.Image = ((System.Drawing.Image)(resources.GetObject("pic_Logo.Image")));
            this.pic_Logo.Location = new System.Drawing.Point(205, 12);
            this.pic_Logo.Name = "pic_Logo";
            this.pic_Logo.Size = new System.Drawing.Size(375, 121);
            this.pic_Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_Logo.TabIndex = 11;
            this.pic_Logo.TabStop = false;
            // 
            // frm_Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(804, 363);
            this.ControlBox = false;
            this.Controls.Add(this.pic_Logo);
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
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.Load += new System.EventHandler(this.frm_Menu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pic_VisualizarVuelos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Vender)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Estadisticas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Logo)).EndInit();
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
        private PictureBox pic_Logo;
    }
}