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
            this.dgv_VisualizarVuelos = new System.Windows.Forms.DataGridView();
            this.MatriculaAvion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.origenDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.destinoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salidaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.llegadaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.duracionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.recaudadoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hayComidaDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.esNacionalDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.vueloBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_VisualizarVuelos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vueloBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Salir
            // 
            this.btn_Salir.Location = new System.Drawing.Point(271, 395);
            this.btn_Salir.Name = "btn_Salir";
            this.btn_Salir.Size = new System.Drawing.Size(113, 23);
            this.btn_Salir.TabIndex = 0;
            this.btn_Salir.Text = "Salir";
            this.btn_Salir.UseVisualStyleBackColor = true;
            this.btn_Salir.Click += new System.EventHandler(this.btn_Salir_Click);
            // 
            // btn_AgregarVuelo
            // 
            this.btn_AgregarVuelo.Location = new System.Drawing.Point(410, 395);
            this.btn_AgregarVuelo.Name = "btn_AgregarVuelo";
            this.btn_AgregarVuelo.Size = new System.Drawing.Size(113, 23);
            this.btn_AgregarVuelo.TabIndex = 2;
            this.btn_AgregarVuelo.Text = "Agregar Vuelo";
            this.btn_AgregarVuelo.UseVisualStyleBackColor = true;
            this.btn_AgregarVuelo.Click += new System.EventHandler(this.btn_AgregarVuelo_Click);
            // 
            // dgv_VisualizarVuelos
            // 
            this.dgv_VisualizarVuelos.AllowUserToAddRows = false;
            this.dgv_VisualizarVuelos.AllowUserToDeleteRows = false;
            this.dgv_VisualizarVuelos.AllowUserToResizeRows = false;
            this.dgv_VisualizarVuelos.AutoGenerateColumns = false;
            this.dgv_VisualizarVuelos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgv_VisualizarVuelos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_VisualizarVuelos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MatriculaAvion,
            this.origenDataGridViewTextBoxColumn,
            this.destinoDataGridViewTextBoxColumn,
            this.salidaDataGridViewTextBoxColumn,
            this.llegadaDataGridViewTextBoxColumn,
            this.duracionDataGridViewTextBoxColumn,
            this.recaudadoDataGridViewTextBoxColumn,
            this.hayComidaDataGridViewCheckBoxColumn,
            this.esNacionalDataGridViewCheckBoxColumn});
            this.dgv_VisualizarVuelos.DataSource = this.vueloBindingSource;
            this.dgv_VisualizarVuelos.Location = new System.Drawing.Point(43, 66);
            this.dgv_VisualizarVuelos.Name = "dgv_VisualizarVuelos";
            this.dgv_VisualizarVuelos.ReadOnly = true;
            this.dgv_VisualizarVuelos.RowTemplate.Height = 25;
            this.dgv_VisualizarVuelos.Size = new System.Drawing.Size(716, 232);
            this.dgv_VisualizarVuelos.TabIndex = 3;
            // 
            // MatriculaAvion
            // 
            this.MatriculaAvion.DataPropertyName = "MatriculaAvion";
            this.MatriculaAvion.HeaderText = "Matricula Avion";
            this.MatriculaAvion.Name = "MatriculaAvion";
            this.MatriculaAvion.ReadOnly = true;
            this.MatriculaAvion.Width = 106;
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
            // recaudadoDataGridViewTextBoxColumn
            // 
            this.recaudadoDataGridViewTextBoxColumn.DataPropertyName = "Recaudado";
            this.recaudadoDataGridViewTextBoxColumn.HeaderText = "Recaudado";
            this.recaudadoDataGridViewTextBoxColumn.Name = "recaudadoDataGridViewTextBoxColumn";
            this.recaudadoDataGridViewTextBoxColumn.ReadOnly = true;
            this.recaudadoDataGridViewTextBoxColumn.Width = 91;
            // 
            // hayComidaDataGridViewCheckBoxColumn
            // 
            this.hayComidaDataGridViewCheckBoxColumn.DataPropertyName = "HayComida";
            this.hayComidaDataGridViewCheckBoxColumn.HeaderText = "Hay Comida";
            this.hayComidaDataGridViewCheckBoxColumn.Name = "hayComidaDataGridViewCheckBoxColumn";
            this.hayComidaDataGridViewCheckBoxColumn.ReadOnly = true;
            this.hayComidaDataGridViewCheckBoxColumn.Width = 71;
            // 
            // esNacionalDataGridViewCheckBoxColumn
            // 
            this.esNacionalDataGridViewCheckBoxColumn.DataPropertyName = "EsNacional";
            this.esNacionalDataGridViewCheckBoxColumn.HeaderText = "Es Nacional";
            this.esNacionalDataGridViewCheckBoxColumn.Name = "esNacionalDataGridViewCheckBoxColumn";
            this.esNacionalDataGridViewCheckBoxColumn.ReadOnly = true;
            this.esNacionalDataGridViewCheckBoxColumn.Width = 67;
            // 
            // vueloBindingSource
            // 
            this.vueloBindingSource.DataSource = typeof(Biblioteca.Vuelo);
            // 
            // frm_VisualizarVuelos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgv_VisualizarVuelos);
            this.Controls.Add(this.btn_AgregarVuelo);
            this.Controls.Add(this.btn_Salir);
            this.Name = "frm_VisualizarVuelos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_VisualizarVuelos";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_VisualizarVuelos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vueloBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Button btn_Salir;
        private Button btn_AgregarVuelo;
        private DataGridView dgv_VisualizarVuelos;
        private DataGridViewTextBoxColumn unAvionDataGridViewTextBoxColumn;
        private BindingSource vueloBindingSource;
        private DataGridViewTextBoxColumn MatriculaAvion;
        private DataGridViewTextBoxColumn origenDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn destinoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn salidaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn llegadaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn duracionDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn recaudadoDataGridViewTextBoxColumn;
        private DataGridViewCheckBoxColumn hayComidaDataGridViewCheckBoxColumn;
        private DataGridViewCheckBoxColumn esNacionalDataGridViewCheckBoxColumn;
    }
}