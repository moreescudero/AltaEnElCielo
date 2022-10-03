namespace Vista
{
    partial class frm_AgregarVuelo
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
            this.btn_AgregarVuelo = new System.Windows.Forms.Button();
            this.btn_Cancelar = new System.Windows.Forms.Button();
            this.lbl_Destino = new System.Windows.Forms.Label();
            this.lbl_Origen = new System.Windows.Forms.Label();
            this.cmb_Origen = new System.Windows.Forms.ComboBox();
            this.cmb_Destino = new System.Windows.Forms.ComboBox();
            this.cdr_Salida = new System.Windows.Forms.MonthCalendar();
            this.cmb_Avion = new System.Windows.Forms.ComboBox();
            this.lbl_Avion = new System.Windows.Forms.Label();
            this.lbl_AyudaAviones = new System.Windows.Forms.Label();
            this.lbl_CodigoVuelo = new System.Windows.Forms.Label();
            this.txt_CodigoVuelo = new System.Windows.Forms.TextBox();
            this.lbl_Catering = new System.Windows.Forms.Label();
            this.chk_SiHay = new System.Windows.Forms.CheckBox();
            this.lbl_HoraDespegue = new System.Windows.Forms.Label();
            this.cmb_Hora = new System.Windows.Forms.ComboBox();
            this.tip_Ayuda = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // btn_AgregarVuelo
            // 
            this.btn_AgregarVuelo.Enabled = false;
            this.btn_AgregarVuelo.Location = new System.Drawing.Point(420, 352);
            this.btn_AgregarVuelo.Name = "btn_AgregarVuelo";
            this.btn_AgregarVuelo.Size = new System.Drawing.Size(95, 23);
            this.btn_AgregarVuelo.TabIndex = 0;
            this.btn_AgregarVuelo.Text = "Agregar vuelo";
            this.btn_AgregarVuelo.UseVisualStyleBackColor = true;
            this.btn_AgregarVuelo.Click += new System.EventHandler(this.btn_AgregarVuelo_Click);
            // 
            // btn_Cancelar
            // 
            this.btn_Cancelar.Location = new System.Drawing.Point(302, 352);
            this.btn_Cancelar.Name = "btn_Cancelar";
            this.btn_Cancelar.Size = new System.Drawing.Size(95, 23);
            this.btn_Cancelar.TabIndex = 1;
            this.btn_Cancelar.Text = "Cancelar";
            this.btn_Cancelar.UseVisualStyleBackColor = true;
            this.btn_Cancelar.Click += new System.EventHandler(this.btn_Cancelar_Click);
            // 
            // lbl_Destino
            // 
            this.lbl_Destino.AutoSize = true;
            this.lbl_Destino.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Destino.Location = new System.Drawing.Point(74, 138);
            this.lbl_Destino.Name = "lbl_Destino";
            this.lbl_Destino.Size = new System.Drawing.Size(50, 15);
            this.lbl_Destino.TabIndex = 4;
            this.lbl_Destino.Text = "Destino:";
            // 
            // lbl_Origen
            // 
            this.lbl_Origen.AutoSize = true;
            this.lbl_Origen.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Origen.Location = new System.Drawing.Point(74, 65);
            this.lbl_Origen.Name = "lbl_Origen";
            this.lbl_Origen.Size = new System.Drawing.Size(46, 15);
            this.lbl_Origen.TabIndex = 5;
            this.lbl_Origen.Text = "Origen:";
            // 
            // cmb_Origen
            // 
            this.cmb_Origen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Origen.FormattingEnabled = true;
            this.cmb_Origen.Location = new System.Drawing.Point(177, 62);
            this.cmb_Origen.Name = "cmb_Origen";
            this.cmb_Origen.Size = new System.Drawing.Size(121, 23);
            this.cmb_Origen.TabIndex = 6;
            this.cmb_Origen.SelectedIndexChanged += new System.EventHandler(this.cmb_Origen_SelectedIndexChanged);
            // 
            // cmb_Destino
            // 
            this.cmb_Destino.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Destino.Enabled = false;
            this.cmb_Destino.FormattingEnabled = true;
            this.cmb_Destino.Location = new System.Drawing.Point(177, 135);
            this.cmb_Destino.Name = "cmb_Destino";
            this.cmb_Destino.Size = new System.Drawing.Size(121, 23);
            this.cmb_Destino.TabIndex = 7;
            this.cmb_Destino.SelectedIndexChanged += new System.EventHandler(this.cmb_Destino_SelectedIndexChanged);
            // 
            // cdr_Salida
            // 
            this.cdr_Salida.Location = new System.Drawing.Point(494, 41);
            this.cdr_Salida.MaxDate = new System.DateTime(2024, 10, 31, 0, 0, 0, 0);
            this.cdr_Salida.MaxSelectionCount = 1;
            this.cdr_Salida.MinDate = new System.DateTime(2022, 9, 20, 0, 0, 0, 0);
            this.cdr_Salida.Name = "cdr_Salida";
            this.cdr_Salida.ShowTodayCircle = false;
            this.cdr_Salida.TabIndex = 8;
            this.tip_Ayuda.SetToolTip(this.cdr_Salida, "Selecciona una fecha superior a una semana");
            this.cdr_Salida.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.cdr_Salida_DateSelected);
            // 
            // cmb_Avion
            // 
            this.cmb_Avion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Avion.Enabled = false;
            this.cmb_Avion.FormattingEnabled = true;
            this.cmb_Avion.Location = new System.Drawing.Point(177, 200);
            this.cmb_Avion.Name = "cmb_Avion";
            this.cmb_Avion.Size = new System.Drawing.Size(121, 23);
            this.cmb_Avion.TabIndex = 9;
            this.tip_Ayuda.SetToolTip(this.cmb_Avion, "Selecciona entre los aviones disponibles en \r\nla fecha y horarios elegidos");
            this.cmb_Avion.SelectedIndexChanged += new System.EventHandler(this.cmb_Avion_SelectedIndexChanged);
            // 
            // lbl_Avion
            // 
            this.lbl_Avion.AutoSize = true;
            this.lbl_Avion.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Avion.Location = new System.Drawing.Point(74, 208);
            this.lbl_Avion.Name = "lbl_Avion";
            this.lbl_Avion.Size = new System.Drawing.Size(41, 15);
            this.lbl_Avion.TabIndex = 10;
            this.lbl_Avion.Text = "Avion:";
            // 
            // lbl_AyudaAviones
            // 
            this.lbl_AyudaAviones.AutoSize = true;
            this.lbl_AyudaAviones.BackColor = System.Drawing.Color.Transparent;
            this.lbl_AyudaAviones.Location = new System.Drawing.Point(39, 230);
            this.lbl_AyudaAviones.Name = "lbl_AyudaAviones";
            this.lbl_AyudaAviones.Size = new System.Drawing.Size(385, 15);
            this.lbl_AyudaAviones.TabIndex = 11;
            this.lbl_AyudaAviones.Text = "Para que se habiliten los aviones disponibles primero elegir fecha y hora";
            // 
            // lbl_CodigoVuelo
            // 
            this.lbl_CodigoVuelo.AutoSize = true;
            this.lbl_CodigoVuelo.BackColor = System.Drawing.Color.Transparent;
            this.lbl_CodigoVuelo.Location = new System.Drawing.Point(74, 274);
            this.lbl_CodigoVuelo.Name = "lbl_CodigoVuelo";
            this.lbl_CodigoVuelo.Size = new System.Drawing.Size(97, 15);
            this.lbl_CodigoVuelo.TabIndex = 12;
            this.lbl_CodigoVuelo.Text = "Codigo de vuelo:";
            // 
            // txt_CodigoVuelo
            // 
            this.txt_CodigoVuelo.Enabled = false;
            this.txt_CodigoVuelo.Location = new System.Drawing.Point(177, 271);
            this.txt_CodigoVuelo.Name = "txt_CodigoVuelo";
            this.txt_CodigoVuelo.Size = new System.Drawing.Size(121, 23);
            this.txt_CodigoVuelo.TabIndex = 13;
            this.tip_Ayuda.SetToolTip(this.txt_CodigoVuelo, "Se genera automáticamente un código \r\nalfanumérico de 6 dígitos");
            // 
            // lbl_Catering
            // 
            this.lbl_Catering.AutoSize = true;
            this.lbl_Catering.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Catering.Location = new System.Drawing.Point(480, 275);
            this.lbl_Catering.Name = "lbl_Catering";
            this.lbl_Catering.Size = new System.Drawing.Size(113, 15);
            this.lbl_Catering.TabIndex = 14;
            this.lbl_Catering.Text = "Servicio de catering:";
            // 
            // chk_SiHay
            // 
            this.chk_SiHay.AutoSize = true;
            this.chk_SiHay.BackColor = System.Drawing.Color.Transparent;
            this.chk_SiHay.Location = new System.Drawing.Point(608, 275);
            this.chk_SiHay.Name = "chk_SiHay";
            this.chk_SiHay.Size = new System.Drawing.Size(133, 19);
            this.chk_SiHay.TabIndex = 16;
            this.chk_SiHay.Text = "Cuenta con catering";
            this.chk_SiHay.UseVisualStyleBackColor = false;
            this.chk_SiHay.CheckedChanged += new System.EventHandler(this.chk_SiHay_CheckedChanged);
            // 
            // lbl_HoraDespegue
            // 
            this.lbl_HoraDespegue.AutoSize = true;
            this.lbl_HoraDespegue.BackColor = System.Drawing.Color.Transparent;
            this.lbl_HoraDespegue.Location = new System.Drawing.Point(494, 225);
            this.lbl_HoraDespegue.Name = "lbl_HoraDespegue";
            this.lbl_HoraDespegue.Size = new System.Drawing.Size(90, 15);
            this.lbl_HoraDespegue.TabIndex = 17;
            this.lbl_HoraDespegue.Text = "Hora despegue:";
            // 
            // cmb_Hora
            // 
            this.cmb_Hora.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Hora.Enabled = false;
            this.cmb_Hora.FormattingEnabled = true;
            this.cmb_Hora.Location = new System.Drawing.Point(597, 222);
            this.cmb_Hora.Name = "cmb_Hora";
            this.cmb_Hora.Size = new System.Drawing.Size(121, 23);
            this.cmb_Hora.TabIndex = 18;
            this.tip_Ayuda.SetToolTip(this.cmb_Hora, "Selecciona la hora en la que desees que \r\ndespegue el avión");
            this.cmb_Hora.SelectedIndexChanged += new System.EventHandler(this.cmb_Hora_SelectedIndexChanged);
            // 
            // frm_AgregarVuelo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(800, 390);
            this.ControlBox = false;
            this.Controls.Add(this.cmb_Hora);
            this.Controls.Add(this.lbl_HoraDespegue);
            this.Controls.Add(this.chk_SiHay);
            this.Controls.Add(this.lbl_Catering);
            this.Controls.Add(this.txt_CodigoVuelo);
            this.Controls.Add(this.lbl_CodigoVuelo);
            this.Controls.Add(this.lbl_AyudaAviones);
            this.Controls.Add(this.lbl_Avion);
            this.Controls.Add(this.cmb_Avion);
            this.Controls.Add(this.cdr_Salida);
            this.Controls.Add(this.cmb_Destino);
            this.Controls.Add(this.cmb_Origen);
            this.Controls.Add(this.lbl_Origen);
            this.Controls.Add(this.lbl_Destino);
            this.Controls.Add(this.btn_Cancelar);
            this.Controls.Add(this.btn_AgregarVuelo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "frm_AgregarVuelo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AgregarVuelo";
            this.Load += new System.EventHandler(this.frm_AgregarVuelo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btn_AgregarVuelo;
        private Button btn_Cancelar;
        private Label lbl_Destino;
        private Label lbl_Origen;
        private ComboBox cmb_Origen;
        private ComboBox cmb_Destino;
        private MonthCalendar cdr_Salida;
        private ComboBox cmb_Avion;
        private Label lbl_Avion;
        private Label lbl_AyudaAviones;
        private Label lbl_CodigoVuelo;
        private TextBox txt_CodigoVuelo;
        private Label lbl_Catering;
        private CheckBox chk_SiHay;
        private Label lbl_HoraDespegue;
        private ComboBox cmb_Hora;
        private ToolTip tip_Ayuda;
    }
}