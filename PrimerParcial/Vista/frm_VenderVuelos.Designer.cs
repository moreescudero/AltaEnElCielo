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
            this.cdr_Salida = new System.Windows.Forms.MonthCalendar();
            this.lbl_Destino = new System.Windows.Forms.Label();
            this.cmb_Destino = new System.Windows.Forms.ComboBox();
            this.lbl_Origen = new System.Windows.Forms.Label();
            this.cmb_Origen = new System.Windows.Forms.ComboBox();
            this.dgv_HayVuelo = new System.Windows.Forms.DataGridView();
            this.origenDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.destinoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salidaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.llegadaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.duracionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AsientosDisponibles = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hayComidaDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.vueloBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btn_AgregarVuelo = new System.Windows.Forms.Button();
            this.lbl_NoHayVuelos = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nud_CantidadPasajeros)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_HayVuelo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vueloBindingSource)).BeginInit();
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
            this.lbl_Destino.BackColor = System.Drawing.Color.Transparent;
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
            this.lbl_Origen.BackColor = System.Drawing.Color.Transparent;
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
            // dgv_HayVuelo
            // 
            this.dgv_HayVuelo.AllowUserToAddRows = false;
            this.dgv_HayVuelo.AllowUserToDeleteRows = false;
            this.dgv_HayVuelo.AllowUserToResizeRows = false;
            this.dgv_HayVuelo.AutoGenerateColumns = false;
            this.dgv_HayVuelo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgv_HayVuelo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_HayVuelo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.origenDataGridViewTextBoxColumn,
            this.destinoDataGridViewTextBoxColumn,
            this.salidaDataGridViewTextBoxColumn,
            this.llegadaDataGridViewTextBoxColumn,
            this.duracionDataGridViewTextBoxColumn,
            this.AsientosDisponibles,
            this.hayComidaDataGridViewCheckBoxColumn});
            this.dgv_HayVuelo.DataSource = this.vueloBindingSource;
            this.dgv_HayVuelo.Location = new System.Drawing.Point(44, 38);
            this.dgv_HayVuelo.Name = "dgv_HayVuelo";
            this.dgv_HayVuelo.ReadOnly = true;
            this.dgv_HayVuelo.RowTemplate.Height = 25;
            this.dgv_HayVuelo.Size = new System.Drawing.Size(718, 225);
            this.dgv_HayVuelo.TabIndex = 30;
            this.dgv_HayVuelo.Visible = false;
            this.dgv_HayVuelo.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgv_HayVuelo_RowHeaderMouseClick);
            this.dgv_HayVuelo.VisibleChanged += new System.EventHandler(this.dgv_HayVuelo_VisibleChanged);
            // 
            // origenDataGridViewTextBoxColumn
            // 
            this.origenDataGridViewTextBoxColumn.DataPropertyName = "Origen";
            this.origenDataGridViewTextBoxColumn.HeaderText = "Origen";
            this.origenDataGridViewTextBoxColumn.Name = "origenDataGridViewTextBoxColumn";
            this.origenDataGridViewTextBoxColumn.ReadOnly = true;
            this.origenDataGridViewTextBoxColumn.Width = 68;
            // 
            // destinoDataGridViewTextBoxColumn
            // 
            this.destinoDataGridViewTextBoxColumn.DataPropertyName = "Destino";
            this.destinoDataGridViewTextBoxColumn.HeaderText = "Destino";
            this.destinoDataGridViewTextBoxColumn.Name = "destinoDataGridViewTextBoxColumn";
            this.destinoDataGridViewTextBoxColumn.ReadOnly = true;
            this.destinoDataGridViewTextBoxColumn.Width = 72;
            // 
            // salidaDataGridViewTextBoxColumn
            // 
            this.salidaDataGridViewTextBoxColumn.DataPropertyName = "Salida";
            this.salidaDataGridViewTextBoxColumn.HeaderText = "Salida";
            this.salidaDataGridViewTextBoxColumn.Name = "salidaDataGridViewTextBoxColumn";
            this.salidaDataGridViewTextBoxColumn.ReadOnly = true;
            this.salidaDataGridViewTextBoxColumn.Width = 63;
            // 
            // llegadaDataGridViewTextBoxColumn
            // 
            this.llegadaDataGridViewTextBoxColumn.DataPropertyName = "Llegada";
            this.llegadaDataGridViewTextBoxColumn.HeaderText = "Llegada";
            this.llegadaDataGridViewTextBoxColumn.Name = "llegadaDataGridViewTextBoxColumn";
            this.llegadaDataGridViewTextBoxColumn.ReadOnly = true;
            this.llegadaDataGridViewTextBoxColumn.Width = 73;
            // 
            // duracionDataGridViewTextBoxColumn
            // 
            this.duracionDataGridViewTextBoxColumn.DataPropertyName = "Duracion";
            this.duracionDataGridViewTextBoxColumn.HeaderText = "Duracion";
            this.duracionDataGridViewTextBoxColumn.Name = "duracionDataGridViewTextBoxColumn";
            this.duracionDataGridViewTextBoxColumn.ReadOnly = true;
            this.duracionDataGridViewTextBoxColumn.Width = 80;
            // 
            // AsientosDisponibles
            // 
            this.AsientosDisponibles.DataPropertyName = "AsientosDisponibles";
            this.AsientosDisponibles.HeaderText = "AsientosDisponibles";
            this.AsientosDisponibles.Name = "AsientosDisponibles";
            this.AsientosDisponibles.ReadOnly = true;
            this.AsientosDisponibles.Width = 138;
            // 
            // hayComidaDataGridViewCheckBoxColumn
            // 
            this.hayComidaDataGridViewCheckBoxColumn.DataPropertyName = "HayComida";
            this.hayComidaDataGridViewCheckBoxColumn.HeaderText = "HayComida";
            this.hayComidaDataGridViewCheckBoxColumn.Name = "hayComidaDataGridViewCheckBoxColumn";
            this.hayComidaDataGridViewCheckBoxColumn.ReadOnly = true;
            this.hayComidaDataGridViewCheckBoxColumn.Width = 76;
            // 
            // vueloBindingSource
            // 
            this.vueloBindingSource.DataSource = typeof(Biblioteca.Vuelo);
            // 
            // btn_AgregarVuelo
            // 
            this.btn_AgregarVuelo.Location = new System.Drawing.Point(642, 269);
            this.btn_AgregarVuelo.Name = "btn_AgregarVuelo";
            this.btn_AgregarVuelo.Size = new System.Drawing.Size(120, 23);
            this.btn_AgregarVuelo.TabIndex = 31;
            this.btn_AgregarVuelo.Text = "Agregar Vuelo";
            this.btn_AgregarVuelo.UseVisualStyleBackColor = true;
            this.btn_AgregarVuelo.Visible = false;
            this.btn_AgregarVuelo.Click += new System.EventHandler(this.btn_AgregarVuelo_Click);
            // 
            // lbl_NoHayVuelos
            // 
            this.lbl_NoHayVuelos.AutoSize = true;
            this.lbl_NoHayVuelos.BackColor = System.Drawing.Color.Transparent;
            this.lbl_NoHayVuelos.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.lbl_NoHayVuelos.Location = new System.Drawing.Point(44, 273);
            this.lbl_NoHayVuelos.Name = "lbl_NoHayVuelos";
            this.lbl_NoHayVuelos.Size = new System.Drawing.Size(0, 15);
            this.lbl_NoHayVuelos.TabIndex = 32;
            // 
            // frm_VenderVuelos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl_NoHayVuelos);
            this.Controls.Add(this.btn_AgregarVuelo);
            this.Controls.Add(this.btn_Cancelar);
            this.Controls.Add(this.btn_Aceptar);
            this.Controls.Add(this.lbl_Fechas);
            this.Controls.Add(this.lbl_Clase);
            this.Controls.Add(this.cmb_Clase);
            this.Controls.Add(this.lbl_CantPasajeros);
            this.Controls.Add(this.nud_CantidadPasajeros);
            this.Controls.Add(this.cdr_Salida);
            this.Controls.Add(this.lbl_Destino);
            this.Controls.Add(this.cmb_Destino);
            this.Controls.Add(this.lbl_Origen);
            this.Controls.Add(this.cmb_Origen);
            this.Controls.Add(this.dgv_HayVuelo);
            this.Name = "frm_VenderVuelos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_VenderVuelo";
            this.Load += new System.EventHandler(this.frm_VenderVuelos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nud_CantidadPasajeros)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_HayVuelo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vueloBindingSource)).EndInit();
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
        private MonthCalendar cdr_Salida;
        private Label lbl_Destino;
        private ComboBox cmb_Destino;
        private Label lbl_Origen;
        private ComboBox cmb_Origen;
        private DataGridView dgv_HayVuelo;
        private BindingSource vueloBindingSource;
        private DataGridViewTextBoxColumn unAvionDataGridViewTextBoxColumn;
        private Button btn_AgregarVuelo;
        private Label lbl_NoHayVuelos;
        private DataGridViewTextBoxColumn origenDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn destinoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn salidaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn llegadaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn duracionDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn AsientosDisponibles;
        private DataGridViewCheckBoxColumn hayComidaDataGridViewCheckBoxColumn;
    }
}