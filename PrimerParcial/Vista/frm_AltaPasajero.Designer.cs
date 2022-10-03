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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_AltaPasajero));
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
            this.lbl_CantEquipaje = new System.Windows.Forms.Label();
            this.nud_CantEquipaje = new System.Windows.Forms.NumericUpDown();
            this.lbl_Clase = new System.Windows.Forms.Label();
            this.lbl_Menu = new System.Windows.Forms.Label();
            this.btn_Aceptar = new System.Windows.Forms.Button();
            this.btn_Cancelar = new System.Windows.Forms.Button();
            this.lbl_Subtotal = new System.Windows.Forms.Label();
            this.lbl_Total = new System.Windows.Forms.Label();
            this.nud_Equipaje = new System.Windows.Forms.NumericUpDown();
            this.pic_PasajeroUno = new System.Windows.Forms.PictureBox();
            this.pic_PasajeroCuatro = new System.Windows.Forms.PictureBox();
            this.pic_PasajeroTres = new System.Windows.Forms.PictureBox();
            this.pic_PasajeroDos = new System.Windows.Forms.PictureBox();
            this.lbl_BonificacionPorEdad = new System.Windows.Forms.Label();
            this.lbl_ComoGuardar = new System.Windows.Forms.Label();
            this.pic_ElegirUno = new System.Windows.Forms.PictureBox();
            this.pic_ElegirDos = new System.Windows.Forms.PictureBox();
            this.pic_ElegirTres = new System.Windows.Forms.PictureBox();
            this.pic_ElegirCuatro = new System.Windows.Forms.PictureBox();
            this.btn_CargarPasajero = new System.Windows.Forms.Button();
            this.lbl_EstadoCargaPasajero = new System.Windows.Forms.Label();
            this.lbl_ErrorAlAceptar = new System.Windows.Forms.Label();
            this.cmb_Menu = new System.Windows.Forms.ComboBox();
            this.chk_BolsoMano = new System.Windows.Forms.CheckBox();
            this.lbl_Iva = new System.Windows.Forms.Label();
            this.lbl_EquipajeBodega = new System.Windows.Forms.Label();
            this.tip_Ayuda = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.nud_CantEquipaje)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Equipaje)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_PasajeroUno)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_PasajeroCuatro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_PasajeroTres)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_PasajeroDos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_ElegirUno)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_ElegirDos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_ElegirTres)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_ElegirCuatro)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_Nombre
            // 
            this.lbl_Nombre.AutoSize = true;
            this.lbl_Nombre.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Nombre.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_Nombre.Location = new System.Drawing.Point(236, 114);
            this.lbl_Nombre.Name = "lbl_Nombre";
            this.lbl_Nombre.Size = new System.Drawing.Size(54, 15);
            this.lbl_Nombre.TabIndex = 0;
            this.lbl_Nombre.Text = "Nombre:";
            // 
            // lbl_Equipaje
            // 
            this.lbl_Equipaje.AutoSize = true;
            this.lbl_Equipaje.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Equipaje.Location = new System.Drawing.Point(488, 118);
            this.lbl_Equipaje.Name = "lbl_Equipaje";
            this.lbl_Equipaje.Size = new System.Drawing.Size(55, 15);
            this.lbl_Equipaje.TabIndex = 1;
            this.lbl_Equipaje.Text = "Equipaje:";
            // 
            // lbl_Edad
            // 
            this.lbl_Edad.AutoSize = true;
            this.lbl_Edad.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Edad.Location = new System.Drawing.Point(236, 203);
            this.lbl_Edad.Name = "lbl_Edad";
            this.lbl_Edad.Size = new System.Drawing.Size(36, 15);
            this.lbl_Edad.TabIndex = 2;
            this.lbl_Edad.Text = "Edad:";
            // 
            // lbl_Apellido
            // 
            this.lbl_Apellido.AutoSize = true;
            this.lbl_Apellido.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Apellido.Location = new System.Drawing.Point(236, 158);
            this.lbl_Apellido.Name = "lbl_Apellido";
            this.lbl_Apellido.Size = new System.Drawing.Size(54, 15);
            this.lbl_Apellido.TabIndex = 3;
            this.lbl_Apellido.Text = "Apellido:";
            // 
            // lbl_Kilos
            // 
            this.lbl_Kilos.AutoSize = true;
            this.lbl_Kilos.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Kilos.Location = new System.Drawing.Point(735, 118);
            this.lbl_Kilos.Name = "lbl_Kilos";
            this.lbl_Kilos.Size = new System.Drawing.Size(20, 15);
            this.lbl_Kilos.TabIndex = 4;
            this.lbl_Kilos.Text = "kg";
            // 
            // lbl_Dni
            // 
            this.lbl_Dni.AutoSize = true;
            this.lbl_Dni.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Dni.Location = new System.Drawing.Point(236, 73);
            this.lbl_Dni.Name = "lbl_Dni";
            this.lbl_Dni.Size = new System.Drawing.Size(33, 15);
            this.lbl_Dni.TabIndex = 5;
            this.lbl_Dni.Text = "DNI: ";
            // 
            // txt_Nombre
            // 
            this.txt_Nombre.Location = new System.Drawing.Point(349, 111);
            this.txt_Nombre.Name = "txt_Nombre";
            this.txt_Nombre.Size = new System.Drawing.Size(100, 23);
            this.txt_Nombre.TabIndex = 6;
            this.txt_Nombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Nombre_KeyPress);
            // 
            // txt_Apellido
            // 
            this.txt_Apellido.Location = new System.Drawing.Point(349, 155);
            this.txt_Apellido.Name = "txt_Apellido";
            this.txt_Apellido.Size = new System.Drawing.Size(100, 23);
            this.txt_Apellido.TabIndex = 7;
            this.txt_Apellido.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Apellido_KeyPress);
            // 
            // txt_Dni
            // 
            this.txt_Dni.Location = new System.Drawing.Point(349, 70);
            this.txt_Dni.Name = "txt_Dni";
            this.txt_Dni.Size = new System.Drawing.Size(100, 23);
            this.txt_Dni.TabIndex = 8;
            this.tip_Ayuda.SetToolTip(this.txt_Dni, "Si el pasajero ya viajó antes, al ingresar el DNI se \r\nvan a completar sus datos " +
        "automáticamente");
            this.txt_Dni.TextChanged += new System.EventHandler(this.txt_Dni_TextChanged);
            this.txt_Dni.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Dni_KeyPress);
            // 
            // txt_Edad
            // 
            this.txt_Edad.Location = new System.Drawing.Point(349, 200);
            this.txt_Edad.MaxLength = 3;
            this.txt_Edad.Name = "txt_Edad";
            this.txt_Edad.Size = new System.Drawing.Size(100, 23);
            this.txt_Edad.TabIndex = 9;
            this.tip_Ayuda.SetToolTip(this.txt_Edad, "Si el pasajero tiene entre 3 y 12 años viajará con un\r\ndescuento del 50%, si tien" +
        "e entre 0 y 2 años el \r\ndescuento será del 100%");
            this.txt_Edad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Edad_KeyPress);
            // 
            // lbl_CantEquipaje
            // 
            this.lbl_CantEquipaje.AutoSize = true;
            this.lbl_CantEquipaje.BackColor = System.Drawing.Color.Transparent;
            this.lbl_CantEquipaje.Location = new System.Drawing.Point(488, 74);
            this.lbl_CantEquipaje.Name = "lbl_CantEquipaje";
            this.lbl_CantEquipaje.Size = new System.Drawing.Size(106, 15);
            this.lbl_CantEquipaje.TabIndex = 11;
            this.lbl_CantEquipaje.Text = "Cantidad equipaje:";
            // 
            // nud_CantEquipaje
            // 
            this.nud_CantEquipaje.Location = new System.Drawing.Point(628, 72);
            this.nud_CantEquipaje.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nud_CantEquipaje.Name = "nud_CantEquipaje";
            this.nud_CantEquipaje.ReadOnly = true;
            this.nud_CantEquipaje.Size = new System.Drawing.Size(100, 23);
            this.nud_CantEquipaje.TabIndex = 12;
            this.tip_Ayuda.SetToolTip(this.nud_CantEquipaje, "Si el pasajero es clase turista la cantidad de equipaje máximo será 1, en clase p" +
        "remium será 2");
            this.nud_CantEquipaje.ValueChanged += new System.EventHandler(this.nud_CantEquipaje_ValueChanged);
            // 
            // lbl_Clase
            // 
            this.lbl_Clase.AutoSize = true;
            this.lbl_Clase.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Clase.Location = new System.Drawing.Point(12, 355);
            this.lbl_Clase.Name = "lbl_Clase";
            this.lbl_Clase.Size = new System.Drawing.Size(109, 15);
            this.lbl_Clase.TabIndex = 13;
            this.lbl_Clase.Text = "Clase seleccionada:";
            // 
            // lbl_Menu
            // 
            this.lbl_Menu.AutoSize = true;
            this.lbl_Menu.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Menu.Location = new System.Drawing.Point(488, 203);
            this.lbl_Menu.Name = "lbl_Menu";
            this.lbl_Menu.Size = new System.Drawing.Size(99, 15);
            this.lbl_Menu.TabIndex = 18;
            this.lbl_Menu.Text = "Opcion de menu:";
            // 
            // btn_Aceptar
            // 
            this.btn_Aceptar.Location = new System.Drawing.Point(657, 355);
            this.btn_Aceptar.Name = "btn_Aceptar";
            this.btn_Aceptar.Size = new System.Drawing.Size(75, 23);
            this.btn_Aceptar.TabIndex = 20;
            this.btn_Aceptar.Text = "Aceptar";
            this.btn_Aceptar.UseVisualStyleBackColor = true;
            this.btn_Aceptar.Click += new System.EventHandler(this.btn_Aceptar_Click);
            // 
            // btn_Cancelar
            // 
            this.btn_Cancelar.Location = new System.Drawing.Point(533, 355);
            this.btn_Cancelar.Name = "btn_Cancelar";
            this.btn_Cancelar.Size = new System.Drawing.Size(75, 23);
            this.btn_Cancelar.TabIndex = 21;
            this.btn_Cancelar.Text = "Cancelar";
            this.btn_Cancelar.UseVisualStyleBackColor = true;
            this.btn_Cancelar.Click += new System.EventHandler(this.btn_Cancelar_Click);
            // 
            // lbl_Subtotal
            // 
            this.lbl_Subtotal.AutoSize = true;
            this.lbl_Subtotal.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Subtotal.Location = new System.Drawing.Point(234, 257);
            this.lbl_Subtotal.Name = "lbl_Subtotal";
            this.lbl_Subtotal.Size = new System.Drawing.Size(0, 15);
            this.lbl_Subtotal.TabIndex = 22;
            // 
            // lbl_Total
            // 
            this.lbl_Total.AutoSize = true;
            this.lbl_Total.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Total.Location = new System.Drawing.Point(236, 363);
            this.lbl_Total.Name = "lbl_Total";
            this.lbl_Total.Size = new System.Drawing.Size(0, 15);
            this.lbl_Total.TabIndex = 23;
            // 
            // nud_Equipaje
            // 
            this.nud_Equipaje.Enabled = false;
            this.nud_Equipaje.Location = new System.Drawing.Point(628, 118);
            this.nud_Equipaje.Maximum = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.nud_Equipaje.Name = "nud_Equipaje";
            this.nud_Equipaje.Size = new System.Drawing.Size(101, 23);
            this.nud_Equipaje.TabIndex = 24;
            this.tip_Ayuda.SetToolTip(this.nud_Equipaje, "Si se ingresa 1 en cantidad de equipaje el máximo será 25 (Turista) \r\ny 21 (Premi" +
        "um), si es premium y se ingresa 2 en cantidad el máximo \r\nserá 42");
            this.nud_Equipaje.ValueChanged += new System.EventHandler(this.nud_Equipaje_ValueChanged);
            // 
            // pic_PasajeroUno
            // 
            this.pic_PasajeroUno.BackColor = System.Drawing.Color.Transparent;
            this.pic_PasajeroUno.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pic_PasajeroUno.Image = ((System.Drawing.Image)(resources.GetObject("pic_PasajeroUno.Image")));
            this.pic_PasajeroUno.InitialImage = null;
            this.pic_PasajeroUno.Location = new System.Drawing.Point(30, 38);
            this.pic_PasajeroUno.Name = "pic_PasajeroUno";
            this.pic_PasajeroUno.Size = new System.Drawing.Size(61, 57);
            this.pic_PasajeroUno.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_PasajeroUno.TabIndex = 25;
            this.pic_PasajeroUno.TabStop = false;
            this.tip_Ayuda.SetToolTip(this.pic_PasajeroUno, "Pasajero 1");
            this.pic_PasajeroUno.Click += new System.EventHandler(this.pic_PasajeroUno_Click);
            // 
            // pic_PasajeroCuatro
            // 
            this.pic_PasajeroCuatro.BackColor = System.Drawing.Color.Transparent;
            this.pic_PasajeroCuatro.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pic_PasajeroCuatro.Enabled = false;
            this.pic_PasajeroCuatro.Image = ((System.Drawing.Image)(resources.GetObject("pic_PasajeroCuatro.Image")));
            this.pic_PasajeroCuatro.InitialImage = null;
            this.pic_PasajeroCuatro.Location = new System.Drawing.Point(30, 294);
            this.pic_PasajeroCuatro.Name = "pic_PasajeroCuatro";
            this.pic_PasajeroCuatro.Size = new System.Drawing.Size(61, 57);
            this.pic_PasajeroCuatro.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_PasajeroCuatro.TabIndex = 26;
            this.pic_PasajeroCuatro.TabStop = false;
            this.tip_Ayuda.SetToolTip(this.pic_PasajeroCuatro, "Pasajero 4");
            this.pic_PasajeroCuatro.Visible = false;
            this.pic_PasajeroCuatro.Click += new System.EventHandler(this.pic_PasajeroCuatro_Click);
            // 
            // pic_PasajeroTres
            // 
            this.pic_PasajeroTres.BackColor = System.Drawing.Color.Transparent;
            this.pic_PasajeroTres.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pic_PasajeroTres.Enabled = false;
            this.pic_PasajeroTres.Image = ((System.Drawing.Image)(resources.GetObject("pic_PasajeroTres.Image")));
            this.pic_PasajeroTres.InitialImage = null;
            this.pic_PasajeroTres.Location = new System.Drawing.Point(30, 209);
            this.pic_PasajeroTres.Name = "pic_PasajeroTres";
            this.pic_PasajeroTres.Size = new System.Drawing.Size(61, 57);
            this.pic_PasajeroTres.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_PasajeroTres.TabIndex = 27;
            this.pic_PasajeroTres.TabStop = false;
            this.tip_Ayuda.SetToolTip(this.pic_PasajeroTres, "Pasajero 3");
            this.pic_PasajeroTres.Visible = false;
            this.pic_PasajeroTres.VisibleChanged += new System.EventHandler(this.pic_PasasjeroTres_VisibleChanged);
            this.pic_PasajeroTres.Click += new System.EventHandler(this.pic_PasajeroTres_Click);
            // 
            // pic_PasajeroDos
            // 
            this.pic_PasajeroDos.BackColor = System.Drawing.Color.Transparent;
            this.pic_PasajeroDos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pic_PasajeroDos.Enabled = false;
            this.pic_PasajeroDos.Image = ((System.Drawing.Image)(resources.GetObject("pic_PasajeroDos.Image")));
            this.pic_PasajeroDos.InitialImage = null;
            this.pic_PasajeroDos.Location = new System.Drawing.Point(30, 124);
            this.pic_PasajeroDos.Name = "pic_PasajeroDos";
            this.pic_PasajeroDos.Size = new System.Drawing.Size(61, 57);
            this.pic_PasajeroDos.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_PasajeroDos.TabIndex = 28;
            this.pic_PasajeroDos.TabStop = false;
            this.tip_Ayuda.SetToolTip(this.pic_PasajeroDos, "Pasajero 2");
            this.pic_PasajeroDos.Visible = false;
            this.pic_PasajeroDos.VisibleChanged += new System.EventHandler(this.pic_PasajeroDos_VisibleChanged);
            this.pic_PasajeroDos.Click += new System.EventHandler(this.pic_PasajeroDos_Click);
            // 
            // lbl_BonificacionPorEdad
            // 
            this.lbl_BonificacionPorEdad.AutoSize = true;
            this.lbl_BonificacionPorEdad.BackColor = System.Drawing.Color.Transparent;
            this.lbl_BonificacionPorEdad.Location = new System.Drawing.Point(236, 320);
            this.lbl_BonificacionPorEdad.Name = "lbl_BonificacionPorEdad";
            this.lbl_BonificacionPorEdad.Size = new System.Drawing.Size(0, 15);
            this.lbl_BonificacionPorEdad.TabIndex = 29;
            // 
            // lbl_ComoGuardar
            // 
            this.lbl_ComoGuardar.AutoSize = true;
            this.lbl_ComoGuardar.BackColor = System.Drawing.Color.Transparent;
            this.lbl_ComoGuardar.Location = new System.Drawing.Point(12, 9);
            this.lbl_ComoGuardar.Name = "lbl_ComoGuardar";
            this.lbl_ComoGuardar.Size = new System.Drawing.Size(0, 15);
            this.lbl_ComoGuardar.TabIndex = 30;
            // 
            // pic_ElegirUno
            // 
            this.pic_ElegirUno.BackColor = System.Drawing.Color.Transparent;
            this.pic_ElegirUno.Image = ((System.Drawing.Image)(resources.GetObject("pic_ElegirUno.Image")));
            this.pic_ElegirUno.Location = new System.Drawing.Point(110, 57);
            this.pic_ElegirUno.Name = "pic_ElegirUno";
            this.pic_ElegirUno.Size = new System.Drawing.Size(20, 24);
            this.pic_ElegirUno.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_ElegirUno.TabIndex = 31;
            this.pic_ElegirUno.TabStop = false;
            // 
            // pic_ElegirDos
            // 
            this.pic_ElegirDos.BackColor = System.Drawing.Color.Transparent;
            this.pic_ElegirDos.Image = ((System.Drawing.Image)(resources.GetObject("pic_ElegirDos.Image")));
            this.pic_ElegirDos.Location = new System.Drawing.Point(110, 142);
            this.pic_ElegirDos.Name = "pic_ElegirDos";
            this.pic_ElegirDos.Size = new System.Drawing.Size(20, 24);
            this.pic_ElegirDos.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_ElegirDos.TabIndex = 32;
            this.pic_ElegirDos.TabStop = false;
            this.pic_ElegirDos.Visible = false;
            // 
            // pic_ElegirTres
            // 
            this.pic_ElegirTres.BackColor = System.Drawing.Color.Transparent;
            this.pic_ElegirTres.Image = ((System.Drawing.Image)(resources.GetObject("pic_ElegirTres.Image")));
            this.pic_ElegirTres.Location = new System.Drawing.Point(110, 222);
            this.pic_ElegirTres.Name = "pic_ElegirTres";
            this.pic_ElegirTres.Size = new System.Drawing.Size(20, 24);
            this.pic_ElegirTres.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_ElegirTres.TabIndex = 33;
            this.pic_ElegirTres.TabStop = false;
            this.pic_ElegirTres.Visible = false;
            // 
            // pic_ElegirCuatro
            // 
            this.pic_ElegirCuatro.BackColor = System.Drawing.Color.Transparent;
            this.pic_ElegirCuatro.Image = ((System.Drawing.Image)(resources.GetObject("pic_ElegirCuatro.Image")));
            this.pic_ElegirCuatro.Location = new System.Drawing.Point(110, 312);
            this.pic_ElegirCuatro.Name = "pic_ElegirCuatro";
            this.pic_ElegirCuatro.Size = new System.Drawing.Size(20, 24);
            this.pic_ElegirCuatro.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_ElegirCuatro.TabIndex = 34;
            this.pic_ElegirCuatro.TabStop = false;
            this.pic_ElegirCuatro.Visible = false;
            // 
            // btn_CargarPasajero
            // 
            this.btn_CargarPasajero.Location = new System.Drawing.Point(578, 326);
            this.btn_CargarPasajero.Name = "btn_CargarPasajero";
            this.btn_CargarPasajero.Size = new System.Drawing.Size(116, 23);
            this.btn_CargarPasajero.TabIndex = 35;
            this.btn_CargarPasajero.Text = "Cargar Pasajero 1";
            this.btn_CargarPasajero.UseVisualStyleBackColor = true;
            this.btn_CargarPasajero.Click += new System.EventHandler(this.btn_CargarPasajero_Click);
            // 
            // lbl_EstadoCargaPasajero
            // 
            this.lbl_EstadoCargaPasajero.AutoSize = true;
            this.lbl_EstadoCargaPasajero.BackColor = System.Drawing.Color.Transparent;
            this.lbl_EstadoCargaPasajero.Location = new System.Drawing.Point(512, 285);
            this.lbl_EstadoCargaPasajero.Name = "lbl_EstadoCargaPasajero";
            this.lbl_EstadoCargaPasajero.Size = new System.Drawing.Size(0, 15);
            this.lbl_EstadoCargaPasajero.TabIndex = 36;
            // 
            // lbl_ErrorAlAceptar
            // 
            this.lbl_ErrorAlAceptar.AutoSize = true;
            this.lbl_ErrorAlAceptar.Location = new System.Drawing.Point(533, 383);
            this.lbl_ErrorAlAceptar.Name = "lbl_ErrorAlAceptar";
            this.lbl_ErrorAlAceptar.Size = new System.Drawing.Size(0, 15);
            this.lbl_ErrorAlAceptar.TabIndex = 37;
            // 
            // cmb_Menu
            // 
            this.cmb_Menu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Menu.FormattingEnabled = true;
            this.cmb_Menu.Location = new System.Drawing.Point(627, 200);
            this.cmb_Menu.Name = "cmb_Menu";
            this.cmb_Menu.Size = new System.Drawing.Size(113, 23);
            this.cmb_Menu.TabIndex = 38;
            // 
            // chk_BolsoMano
            // 
            this.chk_BolsoMano.AutoSize = true;
            this.chk_BolsoMano.BackColor = System.Drawing.Color.Transparent;
            this.chk_BolsoMano.Location = new System.Drawing.Point(628, 155);
            this.chk_BolsoMano.Name = "chk_BolsoMano";
            this.chk_BolsoMano.Size = new System.Drawing.Size(105, 19);
            this.chk_BolsoMano.TabIndex = 39;
            this.chk_BolsoMano.Text = "Bolso de mano";
            this.chk_BolsoMano.UseVisualStyleBackColor = false;
            // 
            // lbl_Iva
            // 
            this.lbl_Iva.AutoSize = true;
            this.lbl_Iva.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Iva.Location = new System.Drawing.Point(235, 285);
            this.lbl_Iva.Name = "lbl_Iva";
            this.lbl_Iva.Size = new System.Drawing.Size(0, 15);
            this.lbl_Iva.TabIndex = 40;
            // 
            // lbl_EquipajeBodega
            // 
            this.lbl_EquipajeBodega.AutoSize = true;
            this.lbl_EquipajeBodega.BackColor = System.Drawing.Color.Transparent;
            this.lbl_EquipajeBodega.Location = new System.Drawing.Point(494, 103);
            this.lbl_EquipajeBodega.Name = "lbl_EquipajeBodega";
            this.lbl_EquipajeBodega.Size = new System.Drawing.Size(209, 15);
            this.lbl_EquipajeBodega.TabIndex = 42;
            this.lbl_EquipajeBodega.Text = "Se excede de la capacidad en bodega!!";
            this.lbl_EquipajeBodega.Visible = false;
            // 
            // tip_Ayuda
            // 
            this.tip_Ayuda.BackColor = System.Drawing.SystemColors.InfoText;
            this.tip_Ayuda.ForeColor = System.Drawing.SystemColors.Info;
            // 
            // frm_AltaPasajero
            // 
            this.AcceptButton = this.btn_Aceptar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.CancelButton = this.btn_Cancelar;
            this.ClientSize = new System.Drawing.Size(800, 390);
            this.ControlBox = false;
            this.Controls.Add(this.lbl_EquipajeBodega);
            this.Controls.Add(this.lbl_Iva);
            this.Controls.Add(this.chk_BolsoMano);
            this.Controls.Add(this.cmb_Menu);
            this.Controls.Add(this.lbl_ErrorAlAceptar);
            this.Controls.Add(this.lbl_EstadoCargaPasajero);
            this.Controls.Add(this.btn_CargarPasajero);
            this.Controls.Add(this.pic_ElegirCuatro);
            this.Controls.Add(this.pic_ElegirTres);
            this.Controls.Add(this.pic_ElegirDos);
            this.Controls.Add(this.pic_ElegirUno);
            this.Controls.Add(this.lbl_ComoGuardar);
            this.Controls.Add(this.lbl_BonificacionPorEdad);
            this.Controls.Add(this.pic_PasajeroDos);
            this.Controls.Add(this.pic_PasajeroTres);
            this.Controls.Add(this.pic_PasajeroCuatro);
            this.Controls.Add(this.pic_PasajeroUno);
            this.Controls.Add(this.nud_Equipaje);
            this.Controls.Add(this.lbl_Total);
            this.Controls.Add(this.lbl_Subtotal);
            this.Controls.Add(this.btn_Cancelar);
            this.Controls.Add(this.btn_Aceptar);
            this.Controls.Add(this.lbl_Menu);
            this.Controls.Add(this.lbl_Clase);
            this.Controls.Add(this.nud_CantEquipaje);
            this.Controls.Add(this.lbl_CantEquipaje);
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
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_AltaPasajero";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alta Pasajero";
            this.Load += new System.EventHandler(this.frm_AltaPasajero_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nud_CantEquipaje)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Equipaje)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_PasajeroUno)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_PasajeroCuatro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_PasajeroTres)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_PasajeroDos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_ElegirUno)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_ElegirDos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_ElegirTres)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_ElegirCuatro)).EndInit();
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
        private Label lbl_CantEquipaje;
        private NumericUpDown nud_CantEquipaje;
        private Label lbl_Clase;
        private Label lbl_Menu;
        private Button btn_Aceptar;
        private Button btn_Cancelar;
        private Label lbl_Subtotal;
        private Label lbl_Total;
        private NumericUpDown nud_Equipaje;
        private PictureBox pic_PasajeroUno;
        private PictureBox pic_PasajeroCuatro;
        private PictureBox pic_PasajeroTres;
        private PictureBox pic_PasajeroDos;
        private Label lbl_BonificacionPorEdad;
        private Label lbl_ComoGuardar;
        private PictureBox pic_ElegirUno;
        private PictureBox pic_ElegirDos;
        private PictureBox pic_ElegirTres;
        private PictureBox pic_ElegirCuatro;
        private Button btn_CargarPasajero;
        private Label lbl_EstadoCargaPasajero;
        private Label lbl_ErrorAlAceptar;
        private ComboBox cmb_Menu;
        private CheckBox chk_BolsoMano;
        private Label lbl_Iva;
        private Label lbl_EquipajeBodega;
        private ToolTip tip_Ayuda;
    }
}