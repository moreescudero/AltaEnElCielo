namespace Vista
{
    partial class frm_VisualizarVuelos
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
            this.btn_AgregarVuelo = new System.Windows.Forms.Button();
            this.vueloBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dgv_VisualizarVuelos = new System.Windows.Forms.DataGridView();
            this.codigoVueloDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.matriculaAvionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.origenDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.destinoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salidaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.llegadaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.duracionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.recaudadoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BodegaDisponible = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.asientosDisponiblesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Disponible = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hayComidaDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.esNacionalDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.btn_VerPasajeros = new System.Windows.Forms.Button();
            this.pnl_VerPasajeros = new System.Windows.Forms.Panel();
            this.lbl_TituloPasajeros = new System.Windows.Forms.Label();
            this.btn_Volver = new System.Windows.Forms.Button();
            this.dgv_Pasajeros = new System.Windows.Forms.DataGridView();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellidoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dniDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.edadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.claseDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.equipajeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precioBoletoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuElegidoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pasajeroBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lbl_AgregarVueloCancelado = new System.Windows.Forms.Label();
            this.tip_Ayuda = new System.Windows.Forms.ToolTip(this.components);
            this.lbl_Titulo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.vueloBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_VisualizarVuelos)).BeginInit();
            this.pnl_VerPasajeros.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Pasajeros)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pasajeroBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Salir
            // 
            this.btn_Salir.Location = new System.Drawing.Point(223, 355);
            this.btn_Salir.Name = "btn_Salir";
            this.btn_Salir.Size = new System.Drawing.Size(147, 23);
            this.btn_Salir.TabIndex = 0;
            this.btn_Salir.Text = "Salir";
            this.btn_Salir.UseVisualStyleBackColor = true;
            this.btn_Salir.Click += new System.EventHandler(this.btn_Salir_Click);
            // 
            // btn_AgregarVuelo
            // 
            this.btn_AgregarVuelo.Location = new System.Drawing.Point(376, 355);
            this.btn_AgregarVuelo.Name = "btn_AgregarVuelo";
            this.btn_AgregarVuelo.Size = new System.Drawing.Size(147, 23);
            this.btn_AgregarVuelo.TabIndex = 2;
            this.btn_AgregarVuelo.Text = "Agregar Vuelo";
            this.btn_AgregarVuelo.UseVisualStyleBackColor = true;
            this.btn_AgregarVuelo.Click += new System.EventHandler(this.btn_AgregarVuelo_Click);
            // 
            // vueloBindingSource
            // 
            this.vueloBindingSource.DataSource = typeof(Biblioteca.Vuelo);
            // 
            // dgv_VisualizarVuelos
            // 
            this.dgv_VisualizarVuelos.AllowUserToAddRows = false;
            this.dgv_VisualizarVuelos.AllowUserToDeleteRows = false;
            this.dgv_VisualizarVuelos.AllowUserToResizeRows = false;
            this.dgv_VisualizarVuelos.AutoGenerateColumns = false;
            this.dgv_VisualizarVuelos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_VisualizarVuelos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_VisualizarVuelos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigoVueloDataGridViewTextBoxColumn,
            this.matriculaAvionDataGridViewTextBoxColumn,
            this.origenDataGridViewTextBoxColumn,
            this.destinoDataGridViewTextBoxColumn,
            this.salidaDataGridViewTextBoxColumn,
            this.llegadaDataGridViewTextBoxColumn,
            this.duracionDataGridViewTextBoxColumn,
            this.recaudadoDataGridViewTextBoxColumn,
            this.BodegaDisponible,
            this.asientosDisponiblesDataGridViewTextBoxColumn,
            this.Disponible,
            this.hayComidaDataGridViewCheckBoxColumn,
            this.esNacionalDataGridViewCheckBoxColumn});
            this.dgv_VisualizarVuelos.DataSource = this.vueloBindingSource;
            this.dgv_VisualizarVuelos.Location = new System.Drawing.Point(12, 68);
            this.dgv_VisualizarVuelos.Name = "dgv_VisualizarVuelos";
            this.dgv_VisualizarVuelos.ReadOnly = true;
            this.dgv_VisualizarVuelos.RowTemplate.Height = 25;
            this.dgv_VisualizarVuelos.Size = new System.Drawing.Size(872, 262);
            this.dgv_VisualizarVuelos.TabIndex = 4;
            this.dgv_VisualizarVuelos.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgv_VisualizarVuelos_RowHeaderMouseClick);
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
            // BodegaDisponible
            // 
            this.BodegaDisponible.DataPropertyName = "BodegaDisponible";
            this.BodegaDisponible.HeaderText = "BodegaDisponible";
            this.BodegaDisponible.Name = "BodegaDisponible";
            this.BodegaDisponible.ReadOnly = true;
            // 
            // asientosDisponiblesDataGridViewTextBoxColumn
            // 
            this.asientosDisponiblesDataGridViewTextBoxColumn.DataPropertyName = "AsientosDisponibles";
            this.asientosDisponiblesDataGridViewTextBoxColumn.HeaderText = "Asientos Disponibles";
            this.asientosDisponiblesDataGridViewTextBoxColumn.Name = "asientosDisponiblesDataGridViewTextBoxColumn";
            this.asientosDisponiblesDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Disponible
            // 
            this.Disponible.DataPropertyName = "Disponible";
            this.Disponible.HeaderText = "Disponible";
            this.Disponible.Name = "Disponible";
            this.Disponible.ReadOnly = true;
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
            // btn_VerPasajeros
            // 
            this.btn_VerPasajeros.Enabled = false;
            this.btn_VerPasajeros.Location = new System.Drawing.Point(529, 355);
            this.btn_VerPasajeros.Name = "btn_VerPasajeros";
            this.btn_VerPasajeros.Size = new System.Drawing.Size(157, 23);
            this.btn_VerPasajeros.TabIndex = 5;
            this.btn_VerPasajeros.Text = "Ver Pasajeros";
            this.btn_VerPasajeros.UseVisualStyleBackColor = true;
            this.btn_VerPasajeros.Click += new System.EventHandler(this.btn_VerPasajeros_Click);
            // 
            // pnl_VerPasajeros
            // 
            this.pnl_VerPasajeros.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pnl_VerPasajeros.BackColor = System.Drawing.Color.Transparent;
            this.pnl_VerPasajeros.Controls.Add(this.lbl_TituloPasajeros);
            this.pnl_VerPasajeros.Controls.Add(this.btn_Volver);
            this.pnl_VerPasajeros.Controls.Add(this.dgv_Pasajeros);
            this.pnl_VerPasajeros.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_VerPasajeros.Location = new System.Drawing.Point(0, 0);
            this.pnl_VerPasajeros.Name = "pnl_VerPasajeros";
            this.pnl_VerPasajeros.Size = new System.Drawing.Size(896, 390);
            this.pnl_VerPasajeros.TabIndex = 6;
            this.pnl_VerPasajeros.Visible = false;
            this.pnl_VerPasajeros.VisibleChanged += new System.EventHandler(this.pnl_VerPasajeros_VisibleChanged);
            // 
            // lbl_TituloPasajeros
            // 
            this.lbl_TituloPasajeros.AutoSize = true;
            this.lbl_TituloPasajeros.Location = new System.Drawing.Point(12, 30);
            this.lbl_TituloPasajeros.Name = "lbl_TituloPasajeros";
            this.lbl_TituloPasajeros.Size = new System.Drawing.Size(177, 15);
            this.lbl_TituloPasajeros.TabIndex = 2;
            this.lbl_TituloPasajeros.Text = "Pasajeros según el vuelo elegido";
            // 
            // btn_Volver
            // 
            this.btn_Volver.Location = new System.Drawing.Point(390, 355);
            this.btn_Volver.Name = "btn_Volver";
            this.btn_Volver.Size = new System.Drawing.Size(133, 23);
            this.btn_Volver.TabIndex = 1;
            this.btn_Volver.Text = "Volver";
            this.tip_Ayuda.SetToolTip(this.btn_Volver, "Agrega un nuevo vuelo");
            this.btn_Volver.UseVisualStyleBackColor = true;
            this.btn_Volver.Click += new System.EventHandler(this.btn_Volver_Click);
            // 
            // dgv_Pasajeros
            // 
            this.dgv_Pasajeros.AllowUserToAddRows = false;
            this.dgv_Pasajeros.AllowUserToDeleteRows = false;
            this.dgv_Pasajeros.AllowUserToResizeRows = false;
            this.dgv_Pasajeros.AutoGenerateColumns = false;
            this.dgv_Pasajeros.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Pasajeros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Pasajeros.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nombreDataGridViewTextBoxColumn,
            this.apellidoDataGridViewTextBoxColumn,
            this.dniDataGridViewTextBoxColumn,
            this.edadDataGridViewTextBoxColumn,
            this.claseDataGridViewTextBoxColumn,
            this.equipajeDataGridViewTextBoxColumn,
            this.precioBoletoDataGridViewTextBoxColumn,
            this.menuElegidoDataGridViewTextBoxColumn});
            this.dgv_Pasajeros.DataSource = this.pasajeroBindingSource;
            this.dgv_Pasajeros.Location = new System.Drawing.Point(12, 68);
            this.dgv_Pasajeros.Name = "dgv_Pasajeros";
            this.dgv_Pasajeros.ReadOnly = true;
            this.dgv_Pasajeros.RowTemplate.Height = 25;
            this.dgv_Pasajeros.Size = new System.Drawing.Size(872, 262);
            this.dgv_Pasajeros.TabIndex = 0;
            this.tip_Ayuda.SetToolTip(this.dgv_Pasajeros, "Pasajeros del vuelo");
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
            // dniDataGridViewTextBoxColumn
            // 
            this.dniDataGridViewTextBoxColumn.DataPropertyName = "Dni";
            this.dniDataGridViewTextBoxColumn.HeaderText = "Dni";
            this.dniDataGridViewTextBoxColumn.Name = "dniDataGridViewTextBoxColumn";
            this.dniDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // edadDataGridViewTextBoxColumn
            // 
            this.edadDataGridViewTextBoxColumn.DataPropertyName = "Edad";
            this.edadDataGridViewTextBoxColumn.HeaderText = "Edad";
            this.edadDataGridViewTextBoxColumn.Name = "edadDataGridViewTextBoxColumn";
            this.edadDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // claseDataGridViewTextBoxColumn
            // 
            this.claseDataGridViewTextBoxColumn.DataPropertyName = "Clase";
            this.claseDataGridViewTextBoxColumn.HeaderText = "Clase";
            this.claseDataGridViewTextBoxColumn.Name = "claseDataGridViewTextBoxColumn";
            this.claseDataGridViewTextBoxColumn.ReadOnly = true;
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
            // menuElegidoDataGridViewTextBoxColumn
            // 
            this.menuElegidoDataGridViewTextBoxColumn.DataPropertyName = "MenuElegido";
            this.menuElegidoDataGridViewTextBoxColumn.HeaderText = "MenuElegido";
            this.menuElegidoDataGridViewTextBoxColumn.Name = "menuElegidoDataGridViewTextBoxColumn";
            this.menuElegidoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // pasajeroBindingSource
            // 
            this.pasajeroBindingSource.DataSource = typeof(Biblioteca.Pasajero);
            // 
            // lbl_AgregarVueloCancelado
            // 
            this.lbl_AgregarVueloCancelado.AutoSize = true;
            this.lbl_AgregarVueloCancelado.BackColor = System.Drawing.Color.Transparent;
            this.lbl_AgregarVueloCancelado.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbl_AgregarVueloCancelado.Location = new System.Drawing.Point(746, 333);
            this.lbl_AgregarVueloCancelado.Name = "lbl_AgregarVueloCancelado";
            this.lbl_AgregarVueloCancelado.Size = new System.Drawing.Size(109, 15);
            this.lbl_AgregarVueloCancelado.TabIndex = 7;
            this.lbl_AgregarVueloCancelado.Text = "No se agregó vuelo";
            this.lbl_AgregarVueloCancelado.Visible = false;
            // 
            // lbl_Titulo
            // 
            this.lbl_Titulo.AutoSize = true;
            this.lbl_Titulo.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Titulo.Location = new System.Drawing.Point(12, 29);
            this.lbl_Titulo.Name = "lbl_Titulo";
            this.lbl_Titulo.Size = new System.Drawing.Size(82, 15);
            this.lbl_Titulo.TabIndex = 8;
            this.lbl_Titulo.Text = "Vuelos activos";
            // 
            // frm_VisualizarVuelos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btn_Salir;
            this.ClientSize = new System.Drawing.Size(896, 390);
            this.ControlBox = false;
            this.Controls.Add(this.pnl_VerPasajeros);
            this.Controls.Add(this.btn_VerPasajeros);
            this.Controls.Add(this.dgv_VisualizarVuelos);
            this.Controls.Add(this.btn_AgregarVuelo);
            this.Controls.Add(this.btn_Salir);
            this.Controls.Add(this.lbl_AgregarVueloCancelado);
            this.Controls.Add(this.lbl_Titulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "frm_VisualizarVuelos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.Load += new System.EventHandler(this.frm_VisualizarVuelos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.vueloBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_VisualizarVuelos)).EndInit();
            this.pnl_VerPasajeros.ResumeLayout(false);
            this.pnl_VerPasajeros.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Pasajeros)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pasajeroBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btn_Salir;
        private Button btn_AgregarVuelo;
        //private DataGridViewTextBoxColumn unAvionDataGridViewTextBoxColumn;
        private BindingSource vueloBindingSource;
        private DataGridView dgv_VisualizarVuelos;
        private Button btn_VerPasajeros;
        private Panel pnl_VerPasajeros;
        private Button btn_Volver;
        private DataGridView dgv_Pasajeros;
        private BindingSource pasajeroBindingSource;
        private Label lbl_AgregarVueloCancelado;
        private DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn apellidoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dniDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn edadDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn claseDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn equipajeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn precioBoletoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn menuElegidoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn codigoVueloDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn matriculaAvionDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn origenDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn destinoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn salidaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn llegadaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn duracionDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn recaudadoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn BodegaDisponible;
        private DataGridViewTextBoxColumn asientosDisponiblesDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn Disponible;
        private DataGridViewCheckBoxColumn hayComidaDataGridViewCheckBoxColumn;
        private DataGridViewCheckBoxColumn esNacionalDataGridViewCheckBoxColumn;
        private ToolTip tip_Ayuda;
        private Label lbl_TituloPasajeros;
        private Label lbl_Titulo;
    }
}