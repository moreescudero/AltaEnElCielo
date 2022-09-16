namespace Vista
{
    partial class frm_AltaPasajero
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
            this.lbl_Nombre = new System.Windows.Forms.Label();
            this.lbl_Equipaje = new System.Windows.Forms.Label();
            this.lbl_Edad = new System.Windows.Forms.Label();
            this.lbl_Apellido = new System.Windows.Forms.Label();
            this.lbl_Kilos = new System.Windows.Forms.Label();
            this.lbl_Dni = new System.Windows.Forms.Label();
            this.txt_Nombre = new System.Windows.Forms.TextBox();
            this.txt_Apellido = new System.Windows.Forms.TextBox();
            this.txt_Dni = new System.Windows.Forms.TextBox();
            this.txt_Edad = new System.Windows.Forms.TextBox();
            this.txt_Equipaje = new System.Windows.Forms.TextBox();
            this.lbl_CantEquipaje = new System.Windows.Forms.Label();
            this.nud_CantEquipaje = new System.Windows.Forms.NumericUpDown();
            this.lbl_Clase = new System.Windows.Forms.Label();
            this.chk_MenuComun = new System.Windows.Forms.CheckBox();
            this.chk_MenuVegano = new System.Windows.Forms.CheckBox();
            this.chk_MenuCeliaco = new System.Windows.Forms.CheckBox();
            this.chk_MenuVegetariano = new System.Windows.Forms.CheckBox();
            this.lbl_Menu = new System.Windows.Forms.Label();
            this.lbl_SinMenu = new System.Windows.Forms.Label();
            this.btn_Aceptar = new System.Windows.Forms.Button();
            this.btn_Cancelar = new System.Windows.Forms.Button();
            this.lbl_Subtotal = new System.Windows.Forms.Label();
            this.lbl_Total = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nud_CantEquipaje)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_Nombre
            // 
            this.lbl_Nombre.AutoSize = true;
            this.lbl_Nombre.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Nombre.Location = new System.Drawing.Point(237, 93);
            this.lbl_Nombre.Name = "lbl_Nombre";
            this.lbl_Nombre.Size = new System.Drawing.Size(54, 15);
            this.lbl_Nombre.TabIndex = 0;
            this.lbl_Nombre.Text = "Nombre:";
            // 
            // lbl_Equipaje
            // 
            this.lbl_Equipaje.AutoSize = true;
            this.lbl_Equipaje.Location = new System.Drawing.Point(516, 137);
            this.lbl_Equipaje.Name = "lbl_Equipaje";
            this.lbl_Equipaje.Size = new System.Drawing.Size(55, 15);
            this.lbl_Equipaje.TabIndex = 1;
            this.lbl_Equipaje.Text = "Equipaje:";
            // 
            // lbl_Edad
            // 
            this.lbl_Edad.AutoSize = true;
            this.lbl_Edad.Location = new System.Drawing.Point(237, 222);
            this.lbl_Edad.Name = "lbl_Edad";
            this.lbl_Edad.Size = new System.Drawing.Size(36, 15);
            this.lbl_Edad.TabIndex = 2;
            this.lbl_Edad.Text = "Edad:";
            // 
            // lbl_Apellido
            // 
            this.lbl_Apellido.AutoSize = true;
            this.lbl_Apellido.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Apellido.Location = new System.Drawing.Point(237, 137);
            this.lbl_Apellido.Name = "lbl_Apellido";
            this.lbl_Apellido.Size = new System.Drawing.Size(54, 15);
            this.lbl_Apellido.TabIndex = 3;
            this.lbl_Apellido.Text = "Apellido:";
            // 
            // lbl_Kilos
            // 
            this.lbl_Kilos.AutoSize = true;
            this.lbl_Kilos.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Kilos.Location = new System.Drawing.Point(736, 137);
            this.lbl_Kilos.Name = "lbl_Kilos";
            this.lbl_Kilos.Size = new System.Drawing.Size(20, 15);
            this.lbl_Kilos.TabIndex = 4;
            this.lbl_Kilos.Text = "kg";
            // 
            // lbl_Dni
            // 
            this.lbl_Dni.AutoSize = true;
            this.lbl_Dni.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Dni.Location = new System.Drawing.Point(237, 178);
            this.lbl_Dni.Name = "lbl_Dni";
            this.lbl_Dni.Size = new System.Drawing.Size(33, 15);
            this.lbl_Dni.TabIndex = 5;
            this.lbl_Dni.Text = "DNI: ";
            // 
            // txt_Nombre
            // 
            this.txt_Nombre.Location = new System.Drawing.Point(350, 90);
            this.txt_Nombre.Name = "txt_Nombre";
            this.txt_Nombre.Size = new System.Drawing.Size(100, 23);
            this.txt_Nombre.TabIndex = 6;
            // 
            // txt_Apellido
            // 
            this.txt_Apellido.Location = new System.Drawing.Point(350, 134);
            this.txt_Apellido.Name = "txt_Apellido";
            this.txt_Apellido.Size = new System.Drawing.Size(100, 23);
            this.txt_Apellido.TabIndex = 7;
            // 
            // txt_Dni
            // 
            this.txt_Dni.Location = new System.Drawing.Point(350, 175);
            this.txt_Dni.Name = "txt_Dni";
            this.txt_Dni.Size = new System.Drawing.Size(100, 23);
            this.txt_Dni.TabIndex = 8;
            // 
            // txt_Edad
            // 
            this.txt_Edad.Location = new System.Drawing.Point(350, 219);
            this.txt_Edad.Name = "txt_Edad";
            this.txt_Edad.Size = new System.Drawing.Size(100, 23);
            this.txt_Edad.TabIndex = 9;
            // 
            // txt_Equipaje
            // 
            this.txt_Equipaje.Enabled = false;
            this.txt_Equipaje.Location = new System.Drawing.Point(629, 134);
            this.txt_Equipaje.Name = "txt_Equipaje";
            this.txt_Equipaje.Size = new System.Drawing.Size(100, 23);
            this.txt_Equipaje.TabIndex = 10;
            // 
            // lbl_CantEquipaje
            // 
            this.lbl_CantEquipaje.AutoSize = true;
            this.lbl_CantEquipaje.Location = new System.Drawing.Point(516, 93);
            this.lbl_CantEquipaje.Name = "lbl_CantEquipaje";
            this.lbl_CantEquipaje.Size = new System.Drawing.Size(106, 15);
            this.lbl_CantEquipaje.TabIndex = 11;
            this.lbl_CantEquipaje.Text = "Cantidad equipaje:";
            // 
            // nud_CantEquipaje
            // 
            this.nud_CantEquipaje.Location = new System.Drawing.Point(629, 91);
            this.nud_CantEquipaje.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nud_CantEquipaje.Name = "nud_CantEquipaje";
            this.nud_CantEquipaje.ReadOnly = true;
            this.nud_CantEquipaje.Size = new System.Drawing.Size(100, 23);
            this.nud_CantEquipaje.TabIndex = 12;
            this.nud_CantEquipaje.ValueChanged += new System.EventHandler(this.nud_CantEquipaje_ValueChanged);
            // 
            // lbl_Clase
            // 
            this.lbl_Clase.AutoSize = true;
            this.lbl_Clase.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Clase.Location = new System.Drawing.Point(12, 402);
            this.lbl_Clase.Name = "lbl_Clase";
            this.lbl_Clase.Size = new System.Drawing.Size(109, 15);
            this.lbl_Clase.TabIndex = 13;
            this.lbl_Clase.Text = "Clase seleccionada:";
            // 
            // chk_MenuComun
            // 
            this.chk_MenuComun.AutoSize = true;
            this.chk_MenuComun.Location = new System.Drawing.Point(237, 316);
            this.chk_MenuComun.Name = "chk_MenuComun";
            this.chk_MenuComun.Size = new System.Drawing.Size(66, 19);
            this.chk_MenuComun.TabIndex = 14;
            this.chk_MenuComun.Text = "Comun";
            this.chk_MenuComun.UseVisualStyleBackColor = true;
            // 
            // chk_MenuVegano
            // 
            this.chk_MenuVegano.AutoSize = true;
            this.chk_MenuVegano.Location = new System.Drawing.Point(386, 316);
            this.chk_MenuVegano.Name = "chk_MenuVegano";
            this.chk_MenuVegano.Size = new System.Drawing.Size(65, 19);
            this.chk_MenuVegano.TabIndex = 15;
            this.chk_MenuVegano.Text = "Vegano";
            this.chk_MenuVegano.UseVisualStyleBackColor = true;
            // 
            // chk_MenuCeliaco
            // 
            this.chk_MenuCeliaco.AutoSize = true;
            this.chk_MenuCeliaco.Location = new System.Drawing.Point(516, 316);
            this.chk_MenuCeliaco.Name = "chk_MenuCeliaco";
            this.chk_MenuCeliaco.Size = new System.Drawing.Size(65, 19);
            this.chk_MenuCeliaco.TabIndex = 16;
            this.chk_MenuCeliaco.Text = "Celíaco";
            this.chk_MenuCeliaco.UseVisualStyleBackColor = true;
            // 
            // chk_MenuVegetariano
            // 
            this.chk_MenuVegetariano.AutoSize = true;
            this.chk_MenuVegetariano.Location = new System.Drawing.Point(641, 316);
            this.chk_MenuVegetariano.Name = "chk_MenuVegetariano";
            this.chk_MenuVegetariano.Size = new System.Drawing.Size(88, 19);
            this.chk_MenuVegetariano.TabIndex = 17;
            this.chk_MenuVegetariano.Text = "Vegetariano";
            this.chk_MenuVegetariano.UseVisualStyleBackColor = true;
            // 
            // lbl_Menu
            // 
            this.lbl_Menu.AutoSize = true;
            this.lbl_Menu.Location = new System.Drawing.Point(237, 281);
            this.lbl_Menu.Name = "lbl_Menu";
            this.lbl_Menu.Size = new System.Drawing.Size(99, 15);
            this.lbl_Menu.TabIndex = 18;
            this.lbl_Menu.Text = "Opcion de menu:";
            // 
            // lbl_SinMenu
            // 
            this.lbl_SinMenu.AutoSize = true;
            this.lbl_SinMenu.Location = new System.Drawing.Point(350, 281);
            this.lbl_SinMenu.Name = "lbl_SinMenu";
            this.lbl_SinMenu.Size = new System.Drawing.Size(88, 15);
            this.lbl_SinMenu.TabIndex = 19;
            this.lbl_SinMenu.Text = "vuelo sin menu";
            this.lbl_SinMenu.Visible = false;
            this.lbl_SinMenu.VisibleChanged += new System.EventHandler(this.label1_VisibleChanged);
            // 
            // btn_Aceptar
            // 
            this.btn_Aceptar.Location = new System.Drawing.Point(654, 398);
            this.btn_Aceptar.Name = "btn_Aceptar";
            this.btn_Aceptar.Size = new System.Drawing.Size(75, 23);
            this.btn_Aceptar.TabIndex = 20;
            this.btn_Aceptar.Text = "Aceptar";
            this.btn_Aceptar.UseVisualStyleBackColor = true;
            // 
            // btn_Cancelar
            // 
            this.btn_Cancelar.Location = new System.Drawing.Point(530, 398);
            this.btn_Cancelar.Name = "btn_Cancelar";
            this.btn_Cancelar.Size = new System.Drawing.Size(75, 23);
            this.btn_Cancelar.TabIndex = 21;
            this.btn_Cancelar.Text = "Cancelar";
            this.btn_Cancelar.UseVisualStyleBackColor = true;
            // 
            // lbl_Subtotal
            // 
            this.lbl_Subtotal.AutoSize = true;
            this.lbl_Subtotal.Location = new System.Drawing.Point(237, 389);
            this.lbl_Subtotal.Name = "lbl_Subtotal";
            this.lbl_Subtotal.Size = new System.Drawing.Size(54, 15);
            this.lbl_Subtotal.TabIndex = 22;
            this.lbl_Subtotal.Text = "Subtotal:";
            // 
            // lbl_Total
            // 
            this.lbl_Total.AutoSize = true;
            this.lbl_Total.Location = new System.Drawing.Point(237, 413);
            this.lbl_Total.Name = "lbl_Total";
            this.lbl_Total.Size = new System.Drawing.Size(35, 15);
            this.lbl_Total.TabIndex = 23;
            this.lbl_Total.Text = "Total:";
            // 
            // frm_AltaPasajero
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl_Total);
            this.Controls.Add(this.lbl_Subtotal);
            this.Controls.Add(this.btn_Cancelar);
            this.Controls.Add(this.btn_Aceptar);
            this.Controls.Add(this.lbl_SinMenu);
            this.Controls.Add(this.lbl_Menu);
            this.Controls.Add(this.chk_MenuVegetariano);
            this.Controls.Add(this.chk_MenuCeliaco);
            this.Controls.Add(this.chk_MenuVegano);
            this.Controls.Add(this.chk_MenuComun);
            this.Controls.Add(this.lbl_Clase);
            this.Controls.Add(this.nud_CantEquipaje);
            this.Controls.Add(this.lbl_CantEquipaje);
            this.Controls.Add(this.txt_Equipaje);
            this.Controls.Add(this.txt_Edad);
            this.Controls.Add(this.txt_Dni);
            this.Controls.Add(this.txt_Apellido);
            this.Controls.Add(this.txt_Nombre);
            this.Controls.Add(this.lbl_Dni);
            this.Controls.Add(this.lbl_Kilos);
            this.Controls.Add(this.lbl_Apellido);
            this.Controls.Add(this.lbl_Edad);
            this.Controls.Add(this.lbl_Equipaje);
            this.Controls.Add(this.lbl_Nombre);
            this.Name = "frm_AltaPasajero";
            this.Text = "Alta Pasajero";
            this.Load += new System.EventHandler(this.frm_AltaPasajero_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nud_CantEquipaje)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lbl_Nombre;
        private Label lbl_Equipaje;
        private Label lbl_Edad;
        private Label lbl_Apellido;
        private Label lbl_Kilos;
        private Label lbl_Dni;
        private TextBox txt_Nombre;
        private TextBox txt_Apellido;
        private TextBox txt_Dni;
        private TextBox txt_Edad;
        private TextBox txt_Equipaje;
        private Label lbl_CantEquipaje;
        private NumericUpDown nud_CantEquipaje;
        private Label lbl_Clase;
        private CheckBox chk_MenuComun;
        private CheckBox chk_MenuVegano;
        private CheckBox chk_MenuCeliaco;
        private CheckBox chk_MenuVegetariano;
        private Label lbl_Menu;
        private Label lbl_SinMenu;
        private Button btn_Aceptar;
        private Button btn_Cancelar;
        private Label lbl_Subtotal;
        private Label lbl_Total;
    }
}