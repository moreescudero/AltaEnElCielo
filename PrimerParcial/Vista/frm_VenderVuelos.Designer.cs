namespace Vista
{
    partial class frm_VenderVuelos
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
            this.lbl_Fechas = new System.Windows.Forms.Label();
            this.lbl_Clase = new System.Windows.Forms.Label();
            this.cmb_Clase = new System.Windows.Forms.ComboBox();
            this.lbl_CantPasajeros = new System.Windows.Forms.Label();
            this.nud_CantidadPasajeros = new System.Windows.Forms.NumericUpDown();
            this.lbl_HoraActual = new System.Windows.Forms.Label();
            this.cdr_Salida = new System.Windows.Forms.MonthCalendar();
            this.lbl_Destino = new System.Windows.Forms.Label();
            this.cmb_Destino = new System.Windows.Forms.ComboBox();
            this.lbl_Origen = new System.Windows.Forms.Label();
            this.cmb_Origen = new System.Windows.Forms.ComboBox();
            this.tmr_HoraActual = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.nud_CantidadPasajeros)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Cancelar
            // 
            this.btn_Cancelar.Location = new System.Drawing.Point(317, 379);
            this.btn_Cancelar.Name = "btn_Cancelar";
            this.btn_Cancelar.Size = new System.Drawing.Size(75, 23);
            this.btn_Cancelar.TabIndex = 29;
            this.btn_Cancelar.Text = "Cancelar";
            this.btn_Cancelar.UseVisualStyleBackColor = true;
            this.btn_Cancelar.Click += new System.EventHandler(this.btn_Cancelar_Click);
            // 
            // btn_Aceptar
            // 
            this.btn_Aceptar.Enabled = false;
            this.btn_Aceptar.Location = new System.Drawing.Point(413, 379);
            this.btn_Aceptar.Name = "btn_Aceptar";
            this.btn_Aceptar.Size = new System.Drawing.Size(75, 23);
            this.btn_Aceptar.TabIndex = 28;
            this.btn_Aceptar.Text = "Aceptar";
            this.btn_Aceptar.UseVisualStyleBackColor = true;
            this.btn_Aceptar.Click += new System.EventHandler(this.btn_Aceptar_Click);
            // 
            // lbl_Fechas
            // 
            this.lbl_Fechas.AutoSize = true;
            this.lbl_Fechas.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Fechas.Location = new System.Drawing.Point(211, 200);
            this.lbl_Fechas.Name = "lbl_Fechas";
            this.lbl_Fechas.Size = new System.Drawing.Size(66, 15);
            this.lbl_Fechas.TabIndex = 26;
            this.lbl_Fechas.Text = "Seleccione:";
            // 
            // lbl_Clase
            // 
            this.lbl_Clase.AutoSize = true;
            this.lbl_Clase.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Clase.Location = new System.Drawing.Point(475, 130);
            this.lbl_Clase.Name = "lbl_Clase";
            this.lbl_Clase.Size = new System.Drawing.Size(41, 15);
            this.lbl_Clase.TabIndex = 24;
            this.lbl_Clase.Text = "Clase: ";
            // 
            // cmb_Clase
            // 
            this.cmb_Clase.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Clase.FormattingEnabled = true;
            this.cmb_Clase.Location = new System.Drawing.Point(609, 127);
            this.cmb_Clase.Name = "cmb_Clase";
            this.cmb_Clase.Size = new System.Drawing.Size(121, 23);
            this.cmb_Clase.TabIndex = 23;
            // 
            // lbl_CantPasajeros
            // 
            this.lbl_CantPasajeros.AutoSize = true;
            this.lbl_CantPasajeros.BackColor = System.Drawing.Color.Transparent;
            this.lbl_CantPasajeros.Location = new System.Drawing.Point(475, 73);
            this.lbl_CantPasajeros.Name = "lbl_CantPasajeros";
            this.lbl_CantPasajeros.Size = new System.Drawing.Size(110, 15);
            this.lbl_CantPasajeros.TabIndex = 22;
            this.lbl_CantPasajeros.Text = "Cantidad Pasajeros:";
            // 
            // nud_CantidadPasajeros
            // 
            this.nud_CantidadPasajeros.Location = new System.Drawing.Point(609, 70);
            this.nud_CantidadPasajeros.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.nud_CantidadPasajeros.Name = "nud_CantidadPasajeros";
            this.nud_CantidadPasajeros.ReadOnly = true;
            this.nud_CantidadPasajeros.Size = new System.Drawing.Size(120, 23);
            this.nud_CantidadPasajeros.TabIndex = 21;
            this.nud_CantidadPasajeros.ValueChanged += new System.EventHandler(this.nud_CantidadPasajeros_ValueChanged);
            // 
            // lbl_HoraActual
            // 
            this.lbl_HoraActual.AutoSize = true;
            this.lbl_HoraActual.BackColor = System.Drawing.Color.Transparent;
            this.lbl_HoraActual.Location = new System.Drawing.Point(717, 415);
            this.lbl_HoraActual.Name = "lbl_HoraActual";
            this.lbl_HoraActual.Size = new System.Drawing.Size(0, 15);
            this.lbl_HoraActual.TabIndex = 20;
            // 
            // cdr_Salida
            // 
            this.cdr_Salida.BackColor = System.Drawing.SystemColors.Window;
            this.cdr_Salida.Location = new System.Drawing.Point(289, 200);
            this.cdr_Salida.MaxDate = new System.DateTime(2024, 9, 30, 0, 0, 0, 0);
            this.cdr_Salida.MinDate = new System.DateTime(2022, 9, 15, 0, 0, 0, 0);
            this.cdr_Salida.Name = "cdr_Salida";
            this.cdr_Salida.ShowTodayCircle = false;
            this.cdr_Salida.TabIndex = 19;
            this.cdr_Salida.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.cdr_Salida_DateSelected);
            // 
            // lbl_Destino
            // 
            this.lbl_Destino.AutoSize = true;
            this.lbl_Destino.Location = new System.Drawing.Point(60, 135);
            this.lbl_Destino.Name = "lbl_Destino";
            this.lbl_Destino.Size = new System.Drawing.Size(50, 15);
            this.lbl_Destino.TabIndex = 18;
            this.lbl_Destino.Text = "Destino:";
            // 
            // cmb_Destino
            // 
            this.cmb_Destino.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Destino.Enabled = false;
            this.cmb_Destino.FormattingEnabled = true;
            this.cmb_Destino.Location = new System.Drawing.Point(166, 127);
            this.cmb_Destino.Name = "cmb_Destino";
            this.cmb_Destino.Size = new System.Drawing.Size(121, 23);
            this.cmb_Destino.TabIndex = 17;
            this.cmb_Destino.SelectedIndexChanged += new System.EventHandler(this.cmb_Destino_SelectedIndexChanged);
            // 
            // lbl_Origen
            // 
            this.lbl_Origen.AutoSize = true;
            this.lbl_Origen.Location = new System.Drawing.Point(60, 73);
            this.lbl_Origen.Name = "lbl_Origen";
            this.lbl_Origen.Size = new System.Drawing.Size(46, 15);
            this.lbl_Origen.TabIndex = 16;
            this.lbl_Origen.Text = "Origen:";
            // 
            // cmb_Origen
            // 
            this.cmb_Origen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Origen.FormattingEnabled = true;
            this.cmb_Origen.Location = new System.Drawing.Point(166, 70);
            this.cmb_Origen.Name = "cmb_Origen";
            this.cmb_Origen.Size = new System.Drawing.Size(121, 23);
            this.cmb_Origen.TabIndex = 15;
            this.cmb_Origen.SelectedIndexChanged += new System.EventHandler(this.cmb_Origen_SelectedIndexChanged);
            // 
            // tmr_HoraActual
            // 
            this.tmr_HoraActual.Interval = 60000;
            this.tmr_HoraActual.Tick += new System.EventHandler(this.tmr_HoraActual_Tick);
            // 
            // frm_VenderVuelos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_Cancelar);
            this.Controls.Add(this.btn_Aceptar);
            this.Controls.Add(this.lbl_Fechas);
            this.Controls.Add(this.lbl_Clase);
            this.Controls.Add(this.cmb_Clase);
            this.Controls.Add(this.lbl_CantPasajeros);
            this.Controls.Add(this.nud_CantidadPasajeros);
            this.Controls.Add(this.lbl_HoraActual);
            this.Controls.Add(this.cdr_Salida);
            this.Controls.Add(this.lbl_Destino);
            this.Controls.Add(this.cmb_Destino);
            this.Controls.Add(this.lbl_Origen);
            this.Controls.Add(this.cmb_Origen);
            this.Name = "frm_VenderVuelos";
            this.Text = "frm_VenderVuelo";
            this.Load += new System.EventHandler(this.frm_VenderVuelos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nud_CantidadPasajeros)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btn_Cancelar;
        private Button btn_Aceptar;
        private Label lbl_Fechas;
        private Label lbl_Clase;
        private ComboBox cmb_Clase;
        private Label lbl_CantPasajeros;
        private NumericUpDown nud_CantidadPasajeros;
        private Label lbl_HoraActual;
        private MonthCalendar cdr_Salida;
        private Label lbl_Destino;
        private ComboBox cmb_Destino;
        private Label lbl_Origen;
        private ComboBox cmb_Origen;
        private System.Windows.Forms.Timer tmr_HoraActual;
    }
}