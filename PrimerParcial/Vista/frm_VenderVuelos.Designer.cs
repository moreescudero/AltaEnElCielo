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
            this.vueloBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btn_AgregarVuelo = new System.Windows.Forms.Button();
            this.lbl_NoHayVuelos = new System.Windows.Forms.Label();
            this.btn_Continuar = new System.Windows.Forms.Button();
            this.vueloBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dgv_HayVuelo = new System.Windows.Forms.DataGridView();
            this.Colum1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.origenDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.destinoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salidaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.llegadaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.duracionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.recaudadoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.asientosDisponiblesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hayComidaDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.lbl_DenegarAgregarVuelo = new System.Windows.Forms.Label();
            this.tip_Ayuda = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.nud_CantidadPasajeros)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vueloBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vueloBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_HayVuelo)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Cancelar
            // 
            this.btn_Cancelar.Location = new System.Drawing.Point(276, 379);
            this.btn_Cancelar.Name = "btn_Cancelar";
            this.btn_Cancelar.Size = new System.Drawing.Size(75, 23);
            this.btn_Cancelar.TabIndex = 29;
            this.btn_Cancelar.Text = "Cancelar";
            this.btn_Cancelar.UseVisualStyleBackColor = true;
            // 
            // btn_Aceptar
            // 
            this.btn_Aceptar.Enabled = false;
            this.btn_Aceptar.Location = new System.Drawing.Point(455, 379);
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
            this.tip_Ayuda.SetToolTip(this.nud_CantidadPasajeros, "Se puede agregar un grupo \r\nfamiliar de hasta 4 personas");
            this.nud_CantidadPasajeros.ValueChanged += new System.EventHandler(this.nud_CantidadPasajeros_ValueChanged);
            // 
            // cdr_Salida
            // 
            this.cdr_Salida.BackColor = System.Drawing.SystemColors.Window;
            this.cdr_Salida.Location = new System.Drawing.Point(289, 200);
            this.cdr_Salida.MaxDate = new System.DateTime(2024, 9, 30, 0, 0, 0, 0);
            this.cdr_Salida.MaxSelectionCount = 1;
            this.cdr_Salida.MinDate = new System.DateTime(2022, 9, 15, 0, 0, 0, 0);
            this.cdr_Salida.Name = "cdr_Salida";
            this.cdr_Salida.ShowTodayCircle = false;
            this.cdr_Salida.TabIndex = 19;
            this.tip_Ayuda.SetToolTip(this.cdr_Salida, "Selecciona la fecha en que desee el pasajero");
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
            this.tip_Ayuda.SetToolTip(this.btn_AgregarVuelo, "Agrega un vuelo, excepto si la fecha elegida\r\nes menor a dentro de una semana a p" +
        "artir de hoy");
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
            // btn_Continuar
            // 
            this.btn_Continuar.Enabled = false;
            this.btn_Continuar.Location = new System.Drawing.Point(365, 379);
            this.btn_Continuar.Name = "btn_Continuar";
            this.btn_Continuar.Size = new System.Drawing.Size(75, 23);
            this.btn_Continuar.TabIndex = 33;
            this.btn_Continuar.Text = "Continuar";
            this.tip_Ayuda.SetToolTip(this.btn_Continuar, "Continua para asignar un vuelo al \r\npasajero/grupo familiar ");
            this.btn_Continuar.UseVisualStyleBackColor = true;
            this.btn_Continuar.Click += new System.EventHandler(this.btn_Continuar_Click);
            // 
            // vueloBindingSource1
            // 
            this.vueloBindingSource1.DataSource = typeof(Biblioteca.Vuelo);
            // 
            // dgv_HayVuelo
            // 
            this.dgv_HayVuelo.AllowUserToAddRows = false;
            this.dgv_HayVuelo.AllowUserToDeleteRows = false;
            this.dgv_HayVuelo.AllowUserToResizeRows = false;
            this.dgv_HayVuelo.AutoGenerateColumns = false;
            this.dgv_HayVuelo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_HayVuelo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_HayVuelo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Colum1,
            this.origenDataGridViewTextBoxColumn,
            this.destinoDataGridViewTextBoxColumn,
            this.salidaDataGridViewTextBoxColumn,
            this.llegadaDataGridViewTextBoxColumn,
            this.duracionDataGridViewTextBoxColumn,
            this.recaudadoDataGridViewTextBoxColumn,
            this.asientosDisponiblesDataGridViewTextBoxColumn,
            this.hayComidaDataGridViewCheckBoxColumn});
            this.dgv_HayVuelo.DataSource = this.vueloBindingSource;
            this.dgv_HayVuelo.Location = new System.Drawing.Point(30, 30);
            this.dgv_HayVuelo.Name = "dgv_HayVuelo";
            this.dgv_HayVuelo.ReadOnly = true;
            this.dgv_HayVuelo.RowTemplate.Height = 25;
            this.dgv_HayVuelo.Size = new System.Drawing.Size(741, 228);
            this.dgv_HayVuelo.TabIndex = 34;
            this.tip_Ayuda.SetToolTip(this.dgv_HayVuelo, "Se realiza un filtro de los vuelos disponibles segun\r\nel origen y destino selecci" +
        "onados, y además segun \r\nla disponibilidad en bodega (mayor a 0) y en la \r\ncanti" +
        "dad de asientos. \r\n");
            this.dgv_HayVuelo.Visible = false;
            this.dgv_HayVuelo.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgv_HayVuelo_RowHeaderMouseClick);
            this.dgv_HayVuelo.VisibleChanged += new System.EventHandler(this.dgv_HayVuelo_VisibleChanged);
            // 
            // Colum1
            // 
            this.Colum1.DataPropertyName = "CodigoVuelo";
            this.Colum1.HeaderText = "Codigo Vuelo";
            this.Colum1.Name = "Colum1";
            this.Colum1.ReadOnly = true;
            // 
            // origenDataGridViewTextBoxColumn
            // 
            this.origenDataGridViewTextBoxColumn.DataPropertyName = "Origen";
            this.origenDataGridViewTextBoxColumn.HeaderText = "Origen";
            this.origenDataGridViewTextBoxColumn.Name = "origenDataGridViewTextBoxColumn";
            this.origenDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // destinoDataGridViewTextBoxColumn
            // 
            this.destinoDataGridViewTextBoxColumn.DataPropertyName = "Destino";
            this.destinoDataGridViewTextBoxColumn.HeaderText = "Destino";
            this.destinoDataGridViewTextBoxColumn.Name = "destinoDataGridViewTextBoxColumn";
            this.destinoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // salidaDataGridViewTextBoxColumn
            // 
            this.salidaDataGridViewTextBoxColumn.DataPropertyName = "Salida";
            this.salidaDataGridViewTextBoxColumn.HeaderText = "Salida";
            this.salidaDataGridViewTextBoxColumn.Name = "salidaDataGridViewTextBoxColumn";
            this.salidaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // llegadaDataGridViewTextBoxColumn
            // 
            this.llegadaDataGridViewTextBoxColumn.DataPropertyName = "Llegada";
            this.llegadaDataGridViewTextBoxColumn.HeaderText = "Llegada";
            this.llegadaDataGridViewTextBoxColumn.Name = "llegadaDataGridViewTextBoxColumn";
            this.llegadaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // duracionDataGridViewTextBoxColumn
            // 
            this.duracionDataGridViewTextBoxColumn.DataPropertyName = "Duracion";
            this.duracionDataGridViewTextBoxColumn.HeaderText = "Duracion";
            this.duracionDataGridViewTextBoxColumn.Name = "duracionDataGridViewTextBoxColumn";
            this.duracionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // recaudadoDataGridViewTextBoxColumn
            // 
            this.recaudadoDataGridViewTextBoxColumn.DataPropertyName = "Recaudado";
            this.recaudadoDataGridViewTextBoxColumn.HeaderText = "Recaudado";
            this.recaudadoDataGridViewTextBoxColumn.Name = "recaudadoDataGridViewTextBoxColumn";
            this.recaudadoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // asientosDisponiblesDataGridViewTextBoxColumn
            // 
            this.asientosDisponiblesDataGridViewTextBoxColumn.DataPropertyName = "AsientosDisponibles";
            this.asientosDisponiblesDataGridViewTextBoxColumn.HeaderText = "Asientos Disponibles";
            this.asientosDisponiblesDataGridViewTextBoxColumn.Name = "asientosDisponiblesDataGridViewTextBoxColumn";
            this.asientosDisponiblesDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // hayComidaDataGridViewCheckBoxColumn
            // 
            this.hayComidaDataGridViewCheckBoxColumn.DataPropertyName = "HayComida";
            this.hayComidaDataGridViewCheckBoxColumn.HeaderText = "Hay Comida";
            this.hayComidaDataGridViewCheckBoxColumn.Name = "hayComidaDataGridViewCheckBoxColumn";
            this.hayComidaDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // lbl_DenegarAgregarVuelo
            // 
            this.lbl_DenegarAgregarVuelo.AutoSize = true;
            this.lbl_DenegarAgregarVuelo.Location = new System.Drawing.Point(609, 303);
            this.lbl_DenegarAgregarVuelo.Name = "lbl_DenegarAgregarVuelo";
            this.lbl_DenegarAgregarVuelo.Size = new System.Drawing.Size(0, 15);
            this.lbl_DenegarAgregarVuelo.TabIndex = 35;
            // 
            // frm_VenderVuelos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.CancelButton = this.btn_Cancelar;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.lbl_DenegarAgregarVuelo);
            this.Controls.Add(this.btn_Continuar);
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
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "frm_VenderVuelos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_VenderVuelo";
            this.Load += new System.EventHandler(this.frm_VenderVuelos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nud_CantidadPasajeros)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vueloBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vueloBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_HayVuelo)).EndInit();
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
        private BindingSource vueloBindingSource;
        //private DataGridViewTextBoxColumn unAvionDataGridViewTextBoxColumn;
        private Button btn_AgregarVuelo;
        private Label lbl_NoHayVuelos;
        private Button btn_Continuar;
        private BindingSource vueloBindingSource1;
        private DataGridView dgv_HayVuelo;
        private DataGridViewTextBoxColumn Colum1;
        private DataGridViewTextBoxColumn origenDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn destinoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn salidaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn llegadaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn duracionDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn recaudadoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn asientosDisponiblesDataGridViewTextBoxColumn;
        private DataGridViewCheckBoxColumn hayComidaDataGridViewCheckBoxColumn;
        private Label lbl_DenegarAgregarVuelo;
        private ToolTip tip_Ayuda;
    }
}