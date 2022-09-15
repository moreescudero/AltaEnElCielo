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
            this.btn_Salir = new System.Windows.Forms.Button();
            this.dgv_VuelosDisponibles = new System.Windows.Forms.DataGridView();
            this.btn_AgregarVuelo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_VuelosDisponibles)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Salir
            // 
            this.btn_Salir.Location = new System.Drawing.Point(392, 398);
            this.btn_Salir.Name = "btn_Salir";
            this.btn_Salir.Size = new System.Drawing.Size(113, 23);
            this.btn_Salir.TabIndex = 0;
            this.btn_Salir.Text = "Salir";
            this.btn_Salir.UseVisualStyleBackColor = true;
            this.btn_Salir.Click += new System.EventHandler(this.btn_Salir_Click);
            // 
            // dgv_VuelosDisponibles
            // 
            this.dgv_VuelosDisponibles.AllowUserToAddRows = false;
            this.dgv_VuelosDisponibles.AllowUserToDeleteRows = false;
            this.dgv_VuelosDisponibles.AllowUserToOrderColumns = true;
            this.dgv_VuelosDisponibles.AllowUserToResizeColumns = false;
            this.dgv_VuelosDisponibles.AllowUserToResizeRows = false;
            this.dgv_VuelosDisponibles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_VuelosDisponibles.Location = new System.Drawing.Point(265, 123);
            this.dgv_VuelosDisponibles.Name = "dgv_VuelosDisponibles";
            this.dgv_VuelosDisponibles.RowTemplate.Height = 25;
            this.dgv_VuelosDisponibles.Size = new System.Drawing.Size(240, 150);
            this.dgv_VuelosDisponibles.TabIndex = 1;
            // 
            // btn_AgregarVuelo
            // 
            this.btn_AgregarVuelo.Location = new System.Drawing.Point(265, 398);
            this.btn_AgregarVuelo.Name = "btn_AgregarVuelo";
            this.btn_AgregarVuelo.Size = new System.Drawing.Size(113, 23);
            this.btn_AgregarVuelo.TabIndex = 2;
            this.btn_AgregarVuelo.Text = "Agregar Vuelo";
            this.btn_AgregarVuelo.UseVisualStyleBackColor = true;
            this.btn_AgregarVuelo.Click += new System.EventHandler(this.btn_AgregarVuelo_Click);
            // 
            // frm_VisualizarVuelos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_AgregarVuelo);
            this.Controls.Add(this.dgv_VuelosDisponibles);
            this.Controls.Add(this.btn_Salir);
            this.Name = "frm_VisualizarVuelos";
            this.Text = "frm_VisualizarVuelos";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_VuelosDisponibles)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Button btn_Salir;
        private DataGridView dgv_VuelosDisponibles;
        private Button btn_AgregarVuelo;
    }
}