namespace Vista
{
    partial class Frm_MenuPrincipal
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
            this.dgv_Salas = new System.Windows.Forms.DataGridView();
            this.btn_AbirSala = new System.Windows.Forms.Button();
            this.btn_AgregarSala = new System.Windows.Forms.Button();
            this.btn_Estadistica = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Salas)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_Salas
            // 
            this.dgv_Salas.AllowUserToAddRows = false;
            this.dgv_Salas.AllowUserToDeleteRows = false;
            this.dgv_Salas.AllowUserToResizeRows = false;
            this.dgv_Salas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Salas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Salas.Location = new System.Drawing.Point(487, 55);
            this.dgv_Salas.Name = "dgv_Salas";
            this.dgv_Salas.ReadOnly = true;
            this.dgv_Salas.RowTemplate.Height = 25;
            this.dgv_Salas.Size = new System.Drawing.Size(279, 340);
            this.dgv_Salas.TabIndex = 0;
            // 
            // btn_AbirSala
            // 
            this.btn_AbirSala.Location = new System.Drawing.Point(140, 72);
            this.btn_AbirSala.Name = "btn_AbirSala";
            this.btn_AbirSala.Size = new System.Drawing.Size(99, 23);
            this.btn_AbirSala.TabIndex = 1;
            this.btn_AbirSala.Text = "Abrir Sala";
            this.btn_AbirSala.UseVisualStyleBackColor = true;
            this.btn_AbirSala.Click += new System.EventHandler(this.btn_AbirSala_Click);
            // 
            // btn_AgregarSala
            // 
            this.btn_AgregarSala.Location = new System.Drawing.Point(140, 144);
            this.btn_AgregarSala.Name = "btn_AgregarSala";
            this.btn_AgregarSala.Size = new System.Drawing.Size(99, 23);
            this.btn_AgregarSala.TabIndex = 2;
            this.btn_AgregarSala.Text = "Agregar Sala";
            this.btn_AgregarSala.UseVisualStyleBackColor = true;
            // 
            // btn_Estadistica
            // 
            this.btn_Estadistica.Location = new System.Drawing.Point(140, 215);
            this.btn_Estadistica.Name = "btn_Estadistica";
            this.btn_Estadistica.Size = new System.Drawing.Size(99, 23);
            this.btn_Estadistica.TabIndex = 3;
            this.btn_Estadistica.Text = "Estadistica";
            this.btn_Estadistica.UseVisualStyleBackColor = true;
            // 
            // Frm_MenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_Estadistica);
            this.Controls.Add(this.btn_AgregarSala);
            this.Controls.Add(this.btn_AbirSala);
            this.Controls.Add(this.dgv_Salas);
            this.Name = "Frm_MenuPrincipal";
            this.Text = "Frm_MenuPrincipal";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Salas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView dgv_Salas;
        private Button btn_AbirSala;
        private Button btn_AgregarSala;
        private Button btn_Estadistica;
    }
}