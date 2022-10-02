namespace Vista
{
    partial class frm_EstadisticasHistoricas
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
            this.dgv_VuelosHistoricos = new System.Windows.Forms.DataGridView();
            this.codigoVueloDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.matriculaAvionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.origenDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.destinoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salidaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.llegadaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.duracionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.recaudadoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hayComidaDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.esNacionalDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.vueloBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btn_Volver = new System.Windows.Forms.Button();
            this.btn_VerEstadisticas = new System.Windows.Forms.Button();
            this.pasajeroBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tip_Ayuda = new System.Windows.Forms.ToolTip(this.components);
            this.cmb_Opciones = new System.Windows.Forms.ComboBox();
            this.btn_VerPasajeros = new System.Windows.Forms.Button();
            this.lbl_Debito = new System.Windows.Forms.Label();
            this.txt_Debito = new System.Windows.Forms.TextBox();
            this.lbl_Credito = new System.Windows.Forms.Label();
            this.lbl_Efectivo = new System.Windows.Forms.Label();
            this.txt_Credito = new System.Windows.Forms.TextBox();
            this.txt_Efectivo = new System.Windows.Forms.TextBox();
            this.btn_CerrarPanel = new System.Windows.Forms.Button();
            this.lbl_Visualizar = new System.Windows.Forms.Label();
            this.lbl_RecaudacionTotal = new System.Windows.Forms.Label();
            this.lbl_GananciasNacionales = new System.Windows.Forms.Label();
            this.lbl_GananciasInternacionales = new System.Windows.Forms.Label();
            this.txt_RecaudacionTotal = new System.Windows.Forms.TextBox();
            this.txt_GananciasInternacionales = new System.Windows.Forms.TextBox();
            this.txt_GananciasNacionales = new System.Windows.Forms.TextBox();
            this.lbl_DestinoMasElegido = new System.Windows.Forms.Label();
            this.txt_DestinoMasElegido = new System.Windows.Forms.TextBox();
            this.dgv_SegunOpcionElegida = new System.Windows.Forms.DataGridView();
            this.pnl_Informacion = new System.Windows.Forms.Panel();
            this.rtx_Info = new System.Windows.Forms.RichTextBox();
            this.pnl_VerEstadisticas = new System.Windows.Forms.Panel();
            this.pnl_VerPasajeros = new System.Windows.Forms.Panel();
            this.btn_CerrarVerPasajeros = new System.Windows.Forms.Button();
            this.dgv_VerPasajeros = new System.Windows.Forms.DataGridView();
            this.claseDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.edadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dniDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuElegidoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.equipajeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precioBoletoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bolsoManoDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.cantidadDeVuelosDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellidoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_VuelosHistoricos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vueloBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pasajeroBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_SegunOpcionElegida)).BeginInit();
            this.pnl_Informacion.SuspendLayout();
            this.pnl_VerEstadisticas.SuspendLayout();
            this.pnl_VerPasajeros.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_VerPasajeros)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_VuelosHistoricos
            // 
            this.dgv_VuelosHistoricos.AllowUserToAddRows = false;
            this.dgv_VuelosHistoricos.AllowUserToDeleteRows = false;
            this.dgv_VuelosHistoricos.AllowUserToResizeRows = false;
            this.dgv_VuelosHistoricos.AutoGenerateColumns = false;
            this.dgv_VuelosHistoricos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_VuelosHistoricos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_VuelosHistoricos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigoVueloDataGridViewTextBoxColumn,
            this.matriculaAvionDataGridViewTextBoxColumn,
            this.origenDataGridViewTextBoxColumn,
            this.destinoDataGridViewTextBoxColumn,
            this.salidaDataGridViewTextBoxColumn,
            this.llegadaDataGridViewTextBoxColumn,
            this.duracionDataGridViewTextBoxColumn,
            this.recaudadoDataGridViewTextBoxColumn,
            this.hayComidaDataGridViewCheckBoxColumn,
            this.esNacionalDataGridViewCheckBoxColumn});
            this.dgv_VuelosHistoricos.DataSource = this.vueloBindingSource;
            this.dgv_VuelosHistoricos.Location = new System.Drawing.Point(37, 36);
            this.dgv_VuelosHistoricos.Name = "dgv_VuelosHistoricos";
            this.dgv_VuelosHistoricos.ReadOnly = true;
            this.dgv_VuelosHistoricos.RowTemplate.Height = 25;
            this.dgv_VuelosHistoricos.Size = new System.Drawing.Size(726, 309);
            this.dgv_VuelosHistoricos.TabIndex = 0;
            this.dgv_VuelosHistoricos.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgv_VuelosHistoricos_RowHeaderMouseClick);
            // 
            // codigoVueloDataGridViewTextBoxColumn
            // 
            this.codigoVueloDataGridViewTextBoxColumn.DataPropertyName = "CodigoVuelo";
            this.codigoVueloDataGridViewTextBoxColumn.HeaderText = "Codigo Vuelo";
            this.codigoVueloDataGridViewTextBoxColumn.Name = "codigoVueloDataGridViewTextBoxColumn";
            this.codigoVueloDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // matriculaAvionDataGridViewTextBoxColumn
            // 
            this.matriculaAvionDataGridViewTextBoxColumn.DataPropertyName = "MatriculaAvion";
            this.matriculaAvionDataGridViewTextBoxColumn.HeaderText = "Matricula Avion";
            this.matriculaAvionDataGridViewTextBoxColumn.Name = "matriculaAvionDataGridViewTextBoxColumn";
            this.matriculaAvionDataGridViewTextBoxColumn.ReadOnly = true;
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
            // hayComidaDataGridViewCheckBoxColumn
            // 
            this.hayComidaDataGridViewCheckBoxColumn.DataPropertyName = "HayComida";
            this.hayComidaDataGridViewCheckBoxColumn.HeaderText = "Hay Comida";
            this.hayComidaDataGridViewCheckBoxColumn.Name = "hayComidaDataGridViewCheckBoxColumn";
            this.hayComidaDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // esNacionalDataGridViewCheckBoxColumn
            // 
            this.esNacionalDataGridViewCheckBoxColumn.DataPropertyName = "EsNacional";
            this.esNacionalDataGridViewCheckBoxColumn.HeaderText = "Es Nacional";
            this.esNacionalDataGridViewCheckBoxColumn.Name = "esNacionalDataGridViewCheckBoxColumn";
            this.esNacionalDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // vueloBindingSource
            // 
            this.vueloBindingSource.DataSource = typeof(Biblioteca.Vuelo);
            // 
            // btn_Volver
            // 
            this.btn_Volver.Location = new System.Drawing.Point(219, 355);
            this.btn_Volver.Name = "btn_Volver";
            this.btn_Volver.Size = new System.Drawing.Size(117, 23);
            this.btn_Volver.TabIndex = 1;
            this.btn_Volver.Text = "Volver";
            this.btn_Volver.UseVisualStyleBackColor = true;
            this.btn_Volver.Click += new System.EventHandler(this.btn_Volver_Click);
            // 
            // btn_VerEstadisticas
            // 
            this.btn_VerEstadisticas.Location = new System.Drawing.Point(342, 355);
            this.btn_VerEstadisticas.Name = "btn_VerEstadisticas";
            this.btn_VerEstadisticas.Size = new System.Drawing.Size(117, 23);
            this.btn_VerEstadisticas.TabIndex = 2;
            this.btn_VerEstadisticas.Text = "Ver estadísticas";
            this.btn_VerEstadisticas.UseVisualStyleBackColor = true;
            this.btn_VerEstadisticas.Click += new System.EventHandler(this.btn_VerEstadisticas_Click);
            // 
            // pasajeroBindingSource
            // 
            this.pasajeroBindingSource.DataSource = typeof(Biblioteca.Pasajero);
            // 
            // cmb_Opciones
            // 
            this.cmb_Opciones.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Opciones.FormattingEnabled = true;
            this.cmb_Opciones.Location = new System.Drawing.Point(214, 33);
            this.cmb_Opciones.Name = "cmb_Opciones";
            this.cmb_Opciones.Size = new System.Drawing.Size(377, 23);
            this.cmb_Opciones.TabIndex = 1;
            this.tip_Ayuda.SetToolTip(this.cmb_Opciones, "Seleccione los datos que desea visualizar en pantalla");
            this.cmb_Opciones.SelectedIndexChanged += new System.EventHandler(this.cmb_Opciones_SelectedIndexChanged);
            // 
            // btn_VerPasajeros
            // 
            this.btn_VerPasajeros.Location = new System.Drawing.Point(465, 355);
            this.btn_VerPasajeros.Name = "btn_VerPasajeros";
            this.btn_VerPasajeros.Size = new System.Drawing.Size(117, 23);
            this.btn_VerPasajeros.TabIndex = 4;
            this.btn_VerPasajeros.Text = "Ver Pasajeros";
            this.btn_VerPasajeros.UseVisualStyleBackColor = true;
            this.btn_VerPasajeros.Click += new System.EventHandler(this.btn_VerPasajeros_Click);
            // 
            // lbl_Debito
            // 
            this.lbl_Debito.AutoSize = true;
            this.lbl_Debito.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Debito.Location = new System.Drawing.Point(129, 284);
            this.lbl_Debito.Name = "lbl_Debito";
            this.lbl_Debito.Size = new System.Drawing.Size(164, 15);
            this.lbl_Debito.TabIndex = 13;
            this.lbl_Debito.Text = "Recaudación tarjeta de débito";
            this.lbl_Debito.Visible = false;
            // 
            // txt_Debito
            // 
            this.txt_Debito.Enabled = false;
            this.txt_Debito.Location = new System.Drawing.Point(138, 302);
            this.txt_Debito.Name = "txt_Debito";
            this.txt_Debito.Size = new System.Drawing.Size(142, 23);
            this.txt_Debito.TabIndex = 14;
            this.txt_Debito.Visible = false;
            // 
            // lbl_Credito
            // 
            this.lbl_Credito.AutoSize = true;
            this.lbl_Credito.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Credito.Location = new System.Drawing.Point(323, 284);
            this.lbl_Credito.Name = "lbl_Credito";
            this.lbl_Credito.Size = new System.Drawing.Size(167, 15);
            this.lbl_Credito.TabIndex = 15;
            this.lbl_Credito.Text = "Recaudación tarjeta de crédito";
            this.lbl_Credito.Visible = false;
            // 
            // lbl_Efectivo
            // 
            this.lbl_Efectivo.AutoSize = true;
            this.lbl_Efectivo.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Efectivo.Location = new System.Drawing.Point(525, 284);
            this.lbl_Efectivo.Name = "lbl_Efectivo";
            this.lbl_Efectivo.Size = new System.Drawing.Size(143, 15);
            this.lbl_Efectivo.TabIndex = 16;
            this.lbl_Efectivo.Text = "Recaudación con efectivo";
            this.lbl_Efectivo.Visible = false;
            // 
            // txt_Credito
            // 
            this.txt_Credito.Enabled = false;
            this.txt_Credito.Location = new System.Drawing.Point(333, 302);
            this.txt_Credito.Name = "txt_Credito";
            this.txt_Credito.Size = new System.Drawing.Size(142, 23);
            this.txt_Credito.TabIndex = 17;
            this.txt_Credito.Visible = false;
            // 
            // txt_Efectivo
            // 
            this.txt_Efectivo.Enabled = false;
            this.txt_Efectivo.Location = new System.Drawing.Point(525, 302);
            this.txt_Efectivo.Name = "txt_Efectivo";
            this.txt_Efectivo.Size = new System.Drawing.Size(142, 23);
            this.txt_Efectivo.TabIndex = 18;
            this.txt_Efectivo.Visible = false;
            // 
            // btn_CerrarPanel
            // 
            this.btn_CerrarPanel.Location = new System.Drawing.Point(342, 355);
            this.btn_CerrarPanel.Name = "btn_CerrarPanel";
            this.btn_CerrarPanel.Size = new System.Drawing.Size(117, 23);
            this.btn_CerrarPanel.TabIndex = 0;
            this.btn_CerrarPanel.Text = "Volver";
            this.btn_CerrarPanel.UseVisualStyleBackColor = true;
            this.btn_CerrarPanel.Click += new System.EventHandler(this.btn_CerrarPanel_Click);
            // 
            // lbl_Visualizar
            // 
            this.lbl_Visualizar.AutoSize = true;
            this.lbl_Visualizar.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Visualizar.Location = new System.Drawing.Point(37, 36);
            this.lbl_Visualizar.Name = "lbl_Visualizar";
            this.lbl_Visualizar.Size = new System.Drawing.Size(138, 15);
            this.lbl_Visualizar.TabIndex = 2;
            this.lbl_Visualizar.Text = "Elija que desea visualizar:";
            // 
            // lbl_RecaudacionTotal
            // 
            this.lbl_RecaudacionTotal.AutoSize = true;
            this.lbl_RecaudacionTotal.BackColor = System.Drawing.Color.Transparent;
            this.lbl_RecaudacionTotal.Location = new System.Drawing.Point(37, 102);
            this.lbl_RecaudacionTotal.Name = "lbl_RecaudacionTotal";
            this.lbl_RecaudacionTotal.Size = new System.Drawing.Size(108, 15);
            this.lbl_RecaudacionTotal.TabIndex = 3;
            this.lbl_RecaudacionTotal.Text = "Recaudación total: ";
            this.lbl_RecaudacionTotal.Visible = false;
            // 
            // lbl_GananciasNacionales
            // 
            this.lbl_GananciasNacionales.AutoSize = true;
            this.lbl_GananciasNacionales.BackColor = System.Drawing.Color.Transparent;
            this.lbl_GananciasNacionales.Location = new System.Drawing.Point(37, 143);
            this.lbl_GananciasNacionales.Name = "lbl_GananciasNacionales";
            this.lbl_GananciasNacionales.Size = new System.Drawing.Size(219, 15);
            this.lbl_GananciasNacionales.TabIndex = 4;
            this.lbl_GananciasNacionales.Text = "Ganancias totales por vuelos nacionales:";
            this.lbl_GananciasNacionales.Visible = false;
            // 
            // lbl_GananciasInternacionales
            // 
            this.lbl_GananciasInternacionales.AutoSize = true;
            this.lbl_GananciasInternacionales.BackColor = System.Drawing.Color.Transparent;
            this.lbl_GananciasInternacionales.Location = new System.Drawing.Point(37, 190);
            this.lbl_GananciasInternacionales.Name = "lbl_GananciasInternacionales";
            this.lbl_GananciasInternacionales.Size = new System.Drawing.Size(243, 15);
            this.lbl_GananciasInternacionales.TabIndex = 5;
            this.lbl_GananciasInternacionales.Text = "Ganancias totales por vuelos internacionales:";
            this.lbl_GananciasInternacionales.Visible = false;
            // 
            // txt_RecaudacionTotal
            // 
            this.txt_RecaudacionTotal.Enabled = false;
            this.txt_RecaudacionTotal.Location = new System.Drawing.Point(360, 99);
            this.txt_RecaudacionTotal.Name = "txt_RecaudacionTotal";
            this.txt_RecaudacionTotal.Size = new System.Drawing.Size(307, 23);
            this.txt_RecaudacionTotal.TabIndex = 6;
            this.txt_RecaudacionTotal.Visible = false;
            // 
            // txt_GananciasInternacionales
            // 
            this.txt_GananciasInternacionales.Enabled = false;
            this.txt_GananciasInternacionales.Location = new System.Drawing.Point(360, 187);
            this.txt_GananciasInternacionales.Name = "txt_GananciasInternacionales";
            this.txt_GananciasInternacionales.Size = new System.Drawing.Size(307, 23);
            this.txt_GananciasInternacionales.TabIndex = 7;
            this.txt_GananciasInternacionales.Visible = false;
            // 
            // txt_GananciasNacionales
            // 
            this.txt_GananciasNacionales.Enabled = false;
            this.txt_GananciasNacionales.Location = new System.Drawing.Point(360, 143);
            this.txt_GananciasNacionales.Name = "txt_GananciasNacionales";
            this.txt_GananciasNacionales.Size = new System.Drawing.Size(307, 23);
            this.txt_GananciasNacionales.TabIndex = 8;
            this.txt_GananciasNacionales.Visible = false;
            // 
            // lbl_DestinoMasElegido
            // 
            this.lbl_DestinoMasElegido.AutoSize = true;
            this.lbl_DestinoMasElegido.BackColor = System.Drawing.Color.Transparent;
            this.lbl_DestinoMasElegido.Location = new System.Drawing.Point(40, 236);
            this.lbl_DestinoMasElegido.Name = "lbl_DestinoMasElegido";
            this.lbl_DestinoMasElegido.Size = new System.Drawing.Size(199, 15);
            this.lbl_DestinoMasElegido.TabIndex = 10;
            this.lbl_DestinoMasElegido.Text = "Destino más elegido por los clientes:";
            this.lbl_DestinoMasElegido.Visible = false;
            // 
            // txt_DestinoMasElegido
            // 
            this.txt_DestinoMasElegido.Enabled = false;
            this.txt_DestinoMasElegido.Location = new System.Drawing.Point(360, 233);
            this.txt_DestinoMasElegido.Name = "txt_DestinoMasElegido";
            this.txt_DestinoMasElegido.Size = new System.Drawing.Size(307, 23);
            this.txt_DestinoMasElegido.TabIndex = 11;
            this.txt_DestinoMasElegido.Visible = false;
            // 
            // dgv_SegunOpcionElegida
            // 
            this.dgv_SegunOpcionElegida.AllowUserToAddRows = false;
            this.dgv_SegunOpcionElegida.AllowUserToDeleteRows = false;
            this.dgv_SegunOpcionElegida.AllowUserToResizeRows = false;
            this.dgv_SegunOpcionElegida.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_SegunOpcionElegida.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_SegunOpcionElegida.Location = new System.Drawing.Point(40, 75);
            this.dgv_SegunOpcionElegida.Name = "dgv_SegunOpcionElegida";
            this.dgv_SegunOpcionElegida.ReadOnly = true;
            this.dgv_SegunOpcionElegida.RowTemplate.Height = 25;
            this.dgv_SegunOpcionElegida.Size = new System.Drawing.Size(723, 270);
            this.dgv_SegunOpcionElegida.TabIndex = 9;
            this.dgv_SegunOpcionElegida.Visible = false;
            // 
            // pnl_Informacion
            // 
            this.pnl_Informacion.Controls.Add(this.rtx_Info);
            this.pnl_Informacion.Location = new System.Drawing.Point(0, 75);
            this.pnl_Informacion.Name = "pnl_Informacion";
            this.pnl_Informacion.Size = new System.Drawing.Size(800, 274);
            this.pnl_Informacion.TabIndex = 12;
            // 
            // rtx_Info
            // 
            this.rtx_Info.BackColor = System.Drawing.Color.Silver;
            this.rtx_Info.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rtx_Info.Location = new System.Drawing.Point(40, 3);
            this.rtx_Info.Name = "rtx_Info";
            this.rtx_Info.ReadOnly = true;
            this.rtx_Info.Size = new System.Drawing.Size(726, 267);
            this.rtx_Info.TabIndex = 0;
            this.rtx_Info.Text = "";
            // 
            // pnl_VerEstadisticas
            // 
            this.pnl_VerEstadisticas.Controls.Add(this.pnl_Informacion);
            this.pnl_VerEstadisticas.Controls.Add(this.dgv_SegunOpcionElegida);
            this.pnl_VerEstadisticas.Controls.Add(this.txt_DestinoMasElegido);
            this.pnl_VerEstadisticas.Controls.Add(this.lbl_DestinoMasElegido);
            this.pnl_VerEstadisticas.Controls.Add(this.txt_GananciasNacionales);
            this.pnl_VerEstadisticas.Controls.Add(this.txt_GananciasInternacionales);
            this.pnl_VerEstadisticas.Controls.Add(this.txt_RecaudacionTotal);
            this.pnl_VerEstadisticas.Controls.Add(this.lbl_GananciasInternacionales);
            this.pnl_VerEstadisticas.Controls.Add(this.lbl_GananciasNacionales);
            this.pnl_VerEstadisticas.Controls.Add(this.lbl_RecaudacionTotal);
            this.pnl_VerEstadisticas.Controls.Add(this.lbl_Visualizar);
            this.pnl_VerEstadisticas.Controls.Add(this.cmb_Opciones);
            this.pnl_VerEstadisticas.Controls.Add(this.btn_CerrarPanel);
            this.pnl_VerEstadisticas.Controls.Add(this.txt_Efectivo);
            this.pnl_VerEstadisticas.Controls.Add(this.txt_Credito);
            this.pnl_VerEstadisticas.Controls.Add(this.lbl_Efectivo);
            this.pnl_VerEstadisticas.Controls.Add(this.lbl_Credito);
            this.pnl_VerEstadisticas.Controls.Add(this.txt_Debito);
            this.pnl_VerEstadisticas.Controls.Add(this.lbl_Debito);
            this.pnl_VerEstadisticas.Location = new System.Drawing.Point(0, 0);
            this.pnl_VerEstadisticas.Name = "pnl_VerEstadisticas";
            this.pnl_VerEstadisticas.Size = new System.Drawing.Size(803, 390);
            this.pnl_VerEstadisticas.TabIndex = 3;
            this.pnl_VerEstadisticas.Visible = false;
            this.pnl_VerEstadisticas.VisibleChanged += new System.EventHandler(this.pnl_VerEstadisticas_VisibleChanged);
            // 
            // pnl_VerPasajeros
            // 
            this.pnl_VerPasajeros.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl_VerPasajeros.Controls.Add(this.btn_CerrarVerPasajeros);
            this.pnl_VerPasajeros.Controls.Add(this.dgv_VerPasajeros);
            this.pnl_VerPasajeros.Location = new System.Drawing.Point(0, 0);
            this.pnl_VerPasajeros.Name = "pnl_VerPasajeros";
            this.pnl_VerPasajeros.Size = new System.Drawing.Size(803, 72);
            this.pnl_VerPasajeros.TabIndex = 5;
            this.pnl_VerPasajeros.Visible = false;
            this.pnl_VerPasajeros.VisibleChanged += new System.EventHandler(this.pnl_VerPasajeros_VisibleChanged);
            // 
            // btn_CerrarVerPasajeros
            // 
            this.btn_CerrarVerPasajeros.Location = new System.Drawing.Point(359, 414);
            this.btn_CerrarVerPasajeros.Name = "btn_CerrarVerPasajeros";
            this.btn_CerrarVerPasajeros.Size = new System.Drawing.Size(115, 23);
            this.btn_CerrarVerPasajeros.TabIndex = 1;
            this.btn_CerrarVerPasajeros.Text = "Volver";
            this.btn_CerrarVerPasajeros.UseVisualStyleBackColor = true;
            this.btn_CerrarVerPasajeros.Click += new System.EventHandler(this.btn_CerrarVerPasajeros_Click_1);
            // 
            // dgv_VerPasajeros
            // 
            this.dgv_VerPasajeros.AllowUserToAddRows = false;
            this.dgv_VerPasajeros.AllowUserToDeleteRows = false;
            this.dgv_VerPasajeros.AllowUserToResizeRows = false;
            this.dgv_VerPasajeros.AutoGenerateColumns = false;
            this.dgv_VerPasajeros.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_VerPasajeros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_VerPasajeros.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.claseDataGridViewTextBoxColumn,
            this.edadDataGridViewTextBoxColumn,
            this.dniDataGridViewTextBoxColumn,
            this.menuElegidoDataGridViewTextBoxColumn,
            this.equipajeDataGridViewTextBoxColumn,
            this.precioBoletoDataGridViewTextBoxColumn,
            this.bolsoManoDataGridViewCheckBoxColumn,
            this.cantidadDeVuelosDataGridViewTextBoxColumn,
            this.nombreDataGridViewTextBoxColumn,
            this.apellidoDataGridViewTextBoxColumn});
            this.dgv_VerPasajeros.DataSource = this.pasajeroBindingSource;
            this.dgv_VerPasajeros.Location = new System.Drawing.Point(37, 75);
            this.dgv_VerPasajeros.Name = "dgv_VerPasajeros";
            this.dgv_VerPasajeros.ReadOnly = true;
            this.dgv_VerPasajeros.RowTemplate.Height = 25;
            this.dgv_VerPasajeros.Size = new System.Drawing.Size(729, 29);
            this.dgv_VerPasajeros.TabIndex = 0;
            // 
            // claseDataGridViewTextBoxColumn
            // 
            this.claseDataGridViewTextBoxColumn.DataPropertyName = "Clase";
            this.claseDataGridViewTextBoxColumn.HeaderText = "Clase";
            this.claseDataGridViewTextBoxColumn.Name = "claseDataGridViewTextBoxColumn";
            this.claseDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // edadDataGridViewTextBoxColumn
            // 
            this.edadDataGridViewTextBoxColumn.DataPropertyName = "Edad";
            this.edadDataGridViewTextBoxColumn.HeaderText = "Edad";
            this.edadDataGridViewTextBoxColumn.Name = "edadDataGridViewTextBoxColumn";
            this.edadDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dniDataGridViewTextBoxColumn
            // 
            this.dniDataGridViewTextBoxColumn.DataPropertyName = "Dni";
            this.dniDataGridViewTextBoxColumn.HeaderText = "Dni";
            this.dniDataGridViewTextBoxColumn.Name = "dniDataGridViewTextBoxColumn";
            this.dniDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // menuElegidoDataGridViewTextBoxColumn
            // 
            this.menuElegidoDataGridViewTextBoxColumn.DataPropertyName = "MenuElegido";
            this.menuElegidoDataGridViewTextBoxColumn.HeaderText = "MenuElegido";
            this.menuElegidoDataGridViewTextBoxColumn.Name = "menuElegidoDataGridViewTextBoxColumn";
            this.menuElegidoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // equipajeDataGridViewTextBoxColumn
            // 
            this.equipajeDataGridViewTextBoxColumn.DataPropertyName = "Equipaje";
            this.equipajeDataGridViewTextBoxColumn.HeaderText = "Equipaje";
            this.equipajeDataGridViewTextBoxColumn.Name = "equipajeDataGridViewTextBoxColumn";
            this.equipajeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // precioBoletoDataGridViewTextBoxColumn
            // 
            this.precioBoletoDataGridViewTextBoxColumn.DataPropertyName = "PrecioBoleto";
            this.precioBoletoDataGridViewTextBoxColumn.HeaderText = "PrecioBoleto";
            this.precioBoletoDataGridViewTextBoxColumn.Name = "precioBoletoDataGridViewTextBoxColumn";
            this.precioBoletoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bolsoManoDataGridViewCheckBoxColumn
            // 
            this.bolsoManoDataGridViewCheckBoxColumn.DataPropertyName = "BolsoMano";
            this.bolsoManoDataGridViewCheckBoxColumn.HeaderText = "BolsoMano";
            this.bolsoManoDataGridViewCheckBoxColumn.Name = "bolsoManoDataGridViewCheckBoxColumn";
            this.bolsoManoDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // cantidadDeVuelosDataGridViewTextBoxColumn
            // 
            this.cantidadDeVuelosDataGridViewTextBoxColumn.DataPropertyName = "CantidadDeVuelos";
            this.cantidadDeVuelosDataGridViewTextBoxColumn.HeaderText = "CantidadDeVuelos";
            this.cantidadDeVuelosDataGridViewTextBoxColumn.Name = "cantidadDeVuelosDataGridViewTextBoxColumn";
            this.cantidadDeVuelosDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            this.nombreDataGridViewTextBoxColumn.DataPropertyName = "Nombre";
            this.nombreDataGridViewTextBoxColumn.HeaderText = "Nombre";
            this.nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            this.nombreDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // apellidoDataGridViewTextBoxColumn
            // 
            this.apellidoDataGridViewTextBoxColumn.DataPropertyName = "Apellido";
            this.apellidoDataGridViewTextBoxColumn.HeaderText = "Apellido";
            this.apellidoDataGridViewTextBoxColumn.Name = "apellidoDataGridViewTextBoxColumn";
            this.apellidoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // frm_EstadisticasHistoricas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(803, 390);
            this.ControlBox = false;
            this.Controls.Add(this.pnl_VerPasajeros);
            this.Controls.Add(this.pnl_VerEstadisticas);
            this.Controls.Add(this.btn_VerEstadisticas);
            this.Controls.Add(this.btn_Volver);
            this.Controls.Add(this.dgv_VuelosHistoricos);
            this.Controls.Add(this.btn_VerPasajeros);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "frm_EstadisticasHistoricas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_EstadisticasHistoricas";
            this.Load += new System.EventHandler(this.frm_EstadisticasHistoricas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_VuelosHistoricos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vueloBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pasajeroBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_SegunOpcionElegida)).EndInit();
            this.pnl_Informacion.ResumeLayout(false);
            this.pnl_VerEstadisticas.ResumeLayout(false);
            this.pnl_VerEstadisticas.PerformLayout();
            this.pnl_VerPasajeros.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_VerPasajeros)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView dgv_VuelosHistoricos;
        private DataGridViewTextBoxColumn codigoVueloDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn matriculaAvionDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn origenDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn destinoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn salidaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn llegadaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn duracionDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn recaudadoDataGridViewTextBoxColumn;
        private DataGridViewCheckBoxColumn hayComidaDataGridViewCheckBoxColumn;
        private DataGridViewCheckBoxColumn esNacionalDataGridViewCheckBoxColumn;
        private BindingSource vueloBindingSource;
        private Button btn_Volver;
        private Button btn_VerEstadisticas;
        private ToolTip tip_Ayuda;
        private BindingSource pasajeroBindingSource;
        private Button btn_VerPasajeros;
        private Label lbl_Debito;
        private TextBox txt_Debito;
        private Label lbl_Credito;
        private Label lbl_Efectivo;
        private TextBox txt_Credito;
        private TextBox txt_Efectivo;
        private Button btn_CerrarPanel;
        private ComboBox cmb_Opciones;
        private Label lbl_Visualizar;
        private Label lbl_RecaudacionTotal;
        private Label lbl_GananciasNacionales;
        private Label lbl_GananciasInternacionales;
        private TextBox txt_RecaudacionTotal;
        private TextBox txt_GananciasInternacionales;
        private TextBox txt_GananciasNacionales;
        private Label lbl_DestinoMasElegido;
        private TextBox txt_DestinoMasElegido;
        private DataGridView dgv_SegunOpcionElegida;
        private Panel pnl_Informacion;
        private RichTextBox rtx_Info;
        private Panel pnl_VerEstadisticas;
        private Panel pnl_VerPasajeros;
        private DataGridView dgv_VerPasajeros;
        private DataGridViewTextBoxColumn claseDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn edadDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dniDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn menuElegidoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn equipajeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn precioBoletoDataGridViewTextBoxColumn;
        private DataGridViewCheckBoxColumn bolsoManoDataGridViewCheckBoxColumn;
        private DataGridViewTextBoxColumn cantidadDeVuelosDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn apellidoDataGridViewTextBoxColumn;
        private Button btn_CerrarVerPasajeros;
    }
}