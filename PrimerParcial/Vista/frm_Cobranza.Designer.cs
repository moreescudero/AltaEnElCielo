namespace Vista
{
    partial class frm_Cobranza
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
            this.lbl_MedioDePago = new System.Windows.Forms.Label();
            this.cmb_MedioDePago = new System.Windows.Forms.ComboBox();
            this.lbl_Numero = new System.Windows.Forms.Label();
            this.txt_DocumentoOCiudad = new System.Windows.Forms.TextBox();
            this.lbl_DocumentoOCiudad = new System.Windows.Forms.Label();
            this.lbl_VencimientoONumero = new System.Windows.Forms.Label();
            this.lbl_Titular = new System.Windows.Forms.Label();
            this.txt_VencimientoMesONumero = new System.Windows.Forms.TextBox();
            this.txt_Titular = new System.Windows.Forms.TextBox();
            this.txt_Numero = new System.Windows.Forms.TextBox();
            this.lbl_CodSeguridadODepto = new System.Windows.Forms.Label();
            this.txt_CodSeguridadODepto = new System.Windows.Forms.TextBox();
            this.lbl_Cuotas = new System.Windows.Forms.Label();
            this.cmb_Cuotas = new System.Windows.Forms.ComboBox();
            this.cmb_SituacionFiscal = new System.Windows.Forms.ComboBox();
            this.btn_Cancelar = new System.Windows.Forms.Button();
            this.btn_Aceptar = new System.Windows.Forms.Button();
            this.lbl_SituacionFiscal = new System.Windows.Forms.Label();
            this.cmb_Provincias = new System.Windows.Forms.ComboBox();
            this.lbl_Provincias = new System.Windows.Forms.Label();
            this.lbl_Barra = new System.Windows.Forms.Label();
            this.txt_VencimientoAñoOPiso = new System.Windows.Forms.TextBox();
            this.lbl_Piso = new System.Windows.Forms.Label();
            this.txt_Calle = new System.Windows.Forms.TextBox();
            this.lbl_Calle = new System.Windows.Forms.Label();
            this.tip_Ayuda = new System.Windows.Forms.ToolTip(this.components);
            this.lbl_Acavaunaimagenowo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_MedioDePago
            // 
            this.lbl_MedioDePago.AutoSize = true;
            this.lbl_MedioDePago.BackColor = System.Drawing.Color.Transparent;
            this.lbl_MedioDePago.Location = new System.Drawing.Point(152, 50);
            this.lbl_MedioDePago.Name = "lbl_MedioDePago";
            this.lbl_MedioDePago.Size = new System.Drawing.Size(90, 15);
            this.lbl_MedioDePago.TabIndex = 0;
            this.lbl_MedioDePago.Text = "Medio de pago:";
            // 
            // cmb_MedioDePago
            // 
            this.cmb_MedioDePago.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_MedioDePago.FormattingEnabled = true;
            this.cmb_MedioDePago.Location = new System.Drawing.Point(259, 47);
            this.cmb_MedioDePago.Name = "cmb_MedioDePago";
            this.cmb_MedioDePago.Size = new System.Drawing.Size(236, 23);
            this.cmb_MedioDePago.TabIndex = 1;
            this.tip_Ayuda.SetToolTip(this.cmb_MedioDePago, "Seleccione el medio de pago que \r\ndesea el cliente");
            this.cmb_MedioDePago.SelectedIndexChanged += new System.EventHandler(this.cmb_MedioDePago_SelectedIndexChanged);
            // 
            // lbl_Numero
            // 
            this.lbl_Numero.AutoSize = true;
            this.lbl_Numero.Location = new System.Drawing.Point(47, 158);
            this.lbl_Numero.Name = "lbl_Numero";
            this.lbl_Numero.Size = new System.Drawing.Size(0, 15);
            this.lbl_Numero.TabIndex = 2;
            // 
            // txt_DocumentoOCiudad
            // 
            this.txt_DocumentoOCiudad.Location = new System.Drawing.Point(420, 176);
            this.txt_DocumentoOCiudad.Name = "txt_DocumentoOCiudad";
            this.txt_DocumentoOCiudad.Size = new System.Drawing.Size(214, 23);
            this.txt_DocumentoOCiudad.TabIndex = 3;
            this.txt_DocumentoOCiudad.Visible = false;
            this.txt_DocumentoOCiudad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_DocumentoOCiudad_KeyPress);
            // 
            // lbl_DocumentoOCiudad
            // 
            this.lbl_DocumentoOCiudad.AutoSize = true;
            this.lbl_DocumentoOCiudad.BackColor = System.Drawing.Color.Transparent;
            this.lbl_DocumentoOCiudad.Location = new System.Drawing.Point(420, 158);
            this.lbl_DocumentoOCiudad.Name = "lbl_DocumentoOCiudad";
            this.lbl_DocumentoOCiudad.Size = new System.Drawing.Size(0, 15);
            this.lbl_DocumentoOCiudad.TabIndex = 4;
            // 
            // lbl_VencimientoONumero
            // 
            this.lbl_VencimientoONumero.AutoSize = true;
            this.lbl_VencimientoONumero.Location = new System.Drawing.Point(420, 222);
            this.lbl_VencimientoONumero.Name = "lbl_VencimientoONumero";
            this.lbl_VencimientoONumero.Size = new System.Drawing.Size(0, 15);
            this.lbl_VencimientoONumero.TabIndex = 5;
            // 
            // lbl_Titular
            // 
            this.lbl_Titular.AutoSize = true;
            this.lbl_Titular.Location = new System.Drawing.Point(47, 222);
            this.lbl_Titular.Name = "lbl_Titular";
            this.lbl_Titular.Size = new System.Drawing.Size(0, 15);
            this.lbl_Titular.TabIndex = 6;
            // 
            // txt_VencimientoMesONumero
            // 
            this.txt_VencimientoMesONumero.Location = new System.Drawing.Point(430, 240);
            this.txt_VencimientoMesONumero.Name = "txt_VencimientoMesONumero";
            this.txt_VencimientoMesONumero.PlaceholderText = "mm";
            this.txt_VencimientoMesONumero.Size = new System.Drawing.Size(43, 23);
            this.txt_VencimientoMesONumero.TabIndex = 8;
            this.txt_VencimientoMesONumero.Visible = false;
            this.txt_VencimientoMesONumero.TextChanged += new System.EventHandler(this.txt_VencimientoMesONumero_TextChanged);
            this.txt_VencimientoMesONumero.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_VencimientoMesONumero_KeyPress);
            // 
            // txt_Titular
            // 
            this.txt_Titular.Location = new System.Drawing.Point(47, 240);
            this.txt_Titular.Name = "txt_Titular";
            this.txt_Titular.Size = new System.Drawing.Size(214, 23);
            this.txt_Titular.TabIndex = 9;
            this.txt_Titular.Visible = false;
            this.txt_Titular.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Titular_KeyPress);
            // 
            // txt_Numero
            // 
            this.txt_Numero.Location = new System.Drawing.Point(47, 176);
            this.txt_Numero.Name = "txt_Numero";
            this.txt_Numero.Size = new System.Drawing.Size(214, 23);
            this.txt_Numero.TabIndex = 10;
            this.txt_Numero.Visible = false;
            this.txt_Numero.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Numero_KeyPress);
            // 
            // lbl_CodSeguridadODepto
            // 
            this.lbl_CodSeguridadODepto.AutoSize = true;
            this.lbl_CodSeguridadODepto.Location = new System.Drawing.Point(591, 222);
            this.lbl_CodSeguridadODepto.Name = "lbl_CodSeguridadODepto";
            this.lbl_CodSeguridadODepto.Size = new System.Drawing.Size(0, 15);
            this.lbl_CodSeguridadODepto.TabIndex = 12;
            // 
            // txt_CodSeguridadODepto
            // 
            this.txt_CodSeguridadODepto.Location = new System.Drawing.Point(591, 240);
            this.txt_CodSeguridadODepto.Name = "txt_CodSeguridadODepto";
            this.txt_CodSeguridadODepto.Size = new System.Drawing.Size(43, 23);
            this.txt_CodSeguridadODepto.TabIndex = 13;
            this.tip_Ayuda.SetToolTip(this.txt_CodSeguridadODepto, "Los 3 dígitos del dorso de la tarjeta o los \r\n4 dígitos enfrente de la tarjeta en" +
        " amex");
            this.txt_CodSeguridadODepto.Visible = false;
            this.txt_CodSeguridadODepto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_CodSeguridadODepto_KeyPress);
            // 
            // lbl_Cuotas
            // 
            this.lbl_Cuotas.AutoSize = true;
            this.lbl_Cuotas.Location = new System.Drawing.Point(47, 324);
            this.lbl_Cuotas.Name = "lbl_Cuotas";
            this.lbl_Cuotas.Size = new System.Drawing.Size(181, 15);
            this.lbl_Cuotas.TabIndex = 14;
            this.lbl_Cuotas.Text = "Seleccione la cantidad de cuotas:";
            this.lbl_Cuotas.Visible = false;
            // 
            // cmb_Cuotas
            // 
            this.cmb_Cuotas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Cuotas.FormattingEnabled = true;
            this.cmb_Cuotas.Location = new System.Drawing.Point(234, 321);
            this.cmb_Cuotas.Name = "cmb_Cuotas";
            this.cmb_Cuotas.Size = new System.Drawing.Size(325, 23);
            this.cmb_Cuotas.TabIndex = 15;
            this.tip_Ayuda.SetToolTip(this.cmb_Cuotas, "Financiación según la tarjeta del cliente");
            this.cmb_Cuotas.Visible = false;
            // 
            // cmb_SituacionFiscal
            // 
            this.cmb_SituacionFiscal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_SituacionFiscal.FormattingEnabled = true;
            this.cmb_SituacionFiscal.Location = new System.Drawing.Point(28, 119);
            this.cmb_SituacionFiscal.Name = "cmb_SituacionFiscal";
            this.cmb_SituacionFiscal.Size = new System.Drawing.Size(214, 23);
            this.cmb_SituacionFiscal.TabIndex = 16;
            this.cmb_SituacionFiscal.Visible = false;
            this.cmb_SituacionFiscal.SelectedIndexChanged += new System.EventHandler(this.cmb_SituacionFiscal_SelectedIndexChanged);
            // 
            // btn_Cancelar
            // 
            this.btn_Cancelar.Location = new System.Drawing.Point(276, 376);
            this.btn_Cancelar.Name = "btn_Cancelar";
            this.btn_Cancelar.Size = new System.Drawing.Size(75, 23);
            this.btn_Cancelar.TabIndex = 17;
            this.btn_Cancelar.Text = "Cancelar";
            this.btn_Cancelar.UseVisualStyleBackColor = true;
            this.btn_Cancelar.Click += new System.EventHandler(this.btn_Cancelar_Click);
            // 
            // btn_Aceptar
            // 
            this.btn_Aceptar.Location = new System.Drawing.Point(357, 376);
            this.btn_Aceptar.Name = "btn_Aceptar";
            this.btn_Aceptar.Size = new System.Drawing.Size(75, 23);
            this.btn_Aceptar.TabIndex = 18;
            this.btn_Aceptar.Text = "Aceptar";
            this.btn_Aceptar.UseVisualStyleBackColor = true;
            this.btn_Aceptar.Click += new System.EventHandler(this.btn_Aceptar_Click);
            // 
            // lbl_SituacionFiscal
            // 
            this.lbl_SituacionFiscal.AutoSize = true;
            this.lbl_SituacionFiscal.BackColor = System.Drawing.Color.Transparent;
            this.lbl_SituacionFiscal.Location = new System.Drawing.Point(28, 101);
            this.lbl_SituacionFiscal.Name = "lbl_SituacionFiscal";
            this.lbl_SituacionFiscal.Size = new System.Drawing.Size(89, 15);
            this.lbl_SituacionFiscal.TabIndex = 19;
            this.lbl_SituacionFiscal.Text = "Situación fiscal:";
            this.lbl_SituacionFiscal.Visible = false;
            // 
            // cmb_Provincias
            // 
            this.cmb_Provincias.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Provincias.FormattingEnabled = true;
            this.cmb_Provincias.Location = new System.Drawing.Point(259, 119);
            this.cmb_Provincias.Name = "cmb_Provincias";
            this.cmb_Provincias.Size = new System.Drawing.Size(214, 23);
            this.cmb_Provincias.TabIndex = 20;
            this.cmb_Provincias.Visible = false;
            this.cmb_Provincias.SelectedIndexChanged += new System.EventHandler(this.cmb_Provincias_SelectedIndexChanged);
            // 
            // lbl_Provincias
            // 
            this.lbl_Provincias.AutoSize = true;
            this.lbl_Provincias.Location = new System.Drawing.Point(259, 101);
            this.lbl_Provincias.Name = "lbl_Provincias";
            this.lbl_Provincias.Size = new System.Drawing.Size(64, 15);
            this.lbl_Provincias.TabIndex = 21;
            this.lbl_Provincias.Text = "Provincias:";
            this.lbl_Provincias.Visible = false;
            // 
            // lbl_Barra
            // 
            this.lbl_Barra.AutoSize = true;
            this.lbl_Barra.Location = new System.Drawing.Point(489, 243);
            this.lbl_Barra.Name = "lbl_Barra";
            this.lbl_Barra.Size = new System.Drawing.Size(12, 15);
            this.lbl_Barra.TabIndex = 7;
            this.lbl_Barra.Text = "/";
            this.lbl_Barra.Visible = false;
            // 
            // txt_VencimientoAñoOPiso
            // 
            this.txt_VencimientoAñoOPiso.Location = new System.Drawing.Point(516, 240);
            this.txt_VencimientoAñoOPiso.Name = "txt_VencimientoAñoOPiso";
            this.txt_VencimientoAñoOPiso.PlaceholderText = "aa";
            this.txt_VencimientoAñoOPiso.Size = new System.Drawing.Size(43, 23);
            this.txt_VencimientoAñoOPiso.TabIndex = 11;
            this.txt_VencimientoAñoOPiso.Visible = false;
            this.txt_VencimientoAñoOPiso.TextChanged += new System.EventHandler(this.txt_VencimientoAñoOPiso_TextChanged);
            this.txt_VencimientoAñoOPiso.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_VencimientoAñoOPiso_KeyPress);
            // 
            // lbl_Piso
            // 
            this.lbl_Piso.AutoSize = true;
            this.lbl_Piso.Location = new System.Drawing.Point(516, 222);
            this.lbl_Piso.Name = "lbl_Piso";
            this.lbl_Piso.Size = new System.Drawing.Size(32, 15);
            this.lbl_Piso.TabIndex = 22;
            this.lbl_Piso.Text = "Piso:";
            this.lbl_Piso.Visible = false;
            // 
            // txt_Calle
            // 
            this.txt_Calle.Location = new System.Drawing.Point(489, 119);
            this.txt_Calle.Name = "txt_Calle";
            this.txt_Calle.Size = new System.Drawing.Size(214, 23);
            this.txt_Calle.TabIndex = 23;
            this.txt_Calle.Visible = false;
            // 
            // lbl_Calle
            // 
            this.lbl_Calle.AutoSize = true;
            this.lbl_Calle.Location = new System.Drawing.Point(489, 101);
            this.lbl_Calle.Name = "lbl_Calle";
            this.lbl_Calle.Size = new System.Drawing.Size(36, 15);
            this.lbl_Calle.TabIndex = 24;
            this.lbl_Calle.Text = "Calle:";
            this.lbl_Calle.Visible = false;
            // 
            // lbl_Acavaunaimagenowo
            // 
            this.lbl_Acavaunaimagenowo.AutoSize = true;
            this.lbl_Acavaunaimagenowo.Location = new System.Drawing.Point(580, 47);
            this.lbl_Acavaunaimagenowo.Name = "lbl_Acavaunaimagenowo";
            this.lbl_Acavaunaimagenowo.Size = new System.Drawing.Size(38, 15);
            this.lbl_Acavaunaimagenowo.TabIndex = 25;
            this.lbl_Acavaunaimagenowo.Text = "label1";
            this.tip_Ayuda.SetToolTip(this.lbl_Acavaunaimagenowo, "Tipo de tarjeta");
            this.lbl_Acavaunaimagenowo.TextChanged += new System.EventHandler(this.lbl_Acavaunaimagenowo_TextChanged);
            // 
            // frm_Cobranza
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(715, 411);
            this.ControlBox = false;
            this.Controls.Add(this.lbl_Acavaunaimagenowo);
            this.Controls.Add(this.lbl_Calle);
            this.Controls.Add(this.txt_Calle);
            this.Controls.Add(this.lbl_Piso);
            this.Controls.Add(this.lbl_Provincias);
            this.Controls.Add(this.cmb_Provincias);
            this.Controls.Add(this.lbl_SituacionFiscal);
            this.Controls.Add(this.btn_Aceptar);
            this.Controls.Add(this.btn_Cancelar);
            this.Controls.Add(this.cmb_SituacionFiscal);
            this.Controls.Add(this.cmb_Cuotas);
            this.Controls.Add(this.lbl_Cuotas);
            this.Controls.Add(this.txt_CodSeguridadODepto);
            this.Controls.Add(this.lbl_CodSeguridadODepto);
            this.Controls.Add(this.txt_VencimientoAñoOPiso);
            this.Controls.Add(this.txt_Numero);
            this.Controls.Add(this.txt_Titular);
            this.Controls.Add(this.txt_VencimientoMesONumero);
            this.Controls.Add(this.lbl_Barra);
            this.Controls.Add(this.lbl_Titular);
            this.Controls.Add(this.lbl_VencimientoONumero);
            this.Controls.Add(this.lbl_DocumentoOCiudad);
            this.Controls.Add(this.txt_DocumentoOCiudad);
            this.Controls.Add(this.lbl_Numero);
            this.Controls.Add(this.cmb_MedioDePago);
            this.Controls.Add(this.lbl_MedioDePago);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "frm_Cobranza";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_Cobranza";
            this.Load += new System.EventHandler(this.frm_Cobranza_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lbl_MedioDePago;
        private ComboBox cmb_MedioDePago;
        private Label lbl_Numero;
        private TextBox txt_DocumentoOCiudad;
        private Label lbl_DocumentoOCiudad;
        private Label lbl_VencimientoONumero;
        private Label lbl_Titular;
        private TextBox txt_VencimientoMesONumero;
        private TextBox txt_Titular;
        private TextBox txt_Numero;
        private Label lbl_CodSeguridadODepto;
        private TextBox txt_CodSeguridadODepto;
        private Label lbl_Cuotas;
        private ComboBox cmb_Cuotas;
        private ComboBox cmb_SituacionFiscal;
        private Button btn_Cancelar;
        private Button btn_Aceptar;
        private Label lbl_SituacionFiscal;
        private ComboBox cmb_Provincias;
        private Label lbl_Provincias;
        private Label lbl_Barra;
        private TextBox txt_VencimientoAñoOPiso;
        private Label lbl_Piso;
        private TextBox txt_Calle;
        private Label lbl_Calle;
        private ToolTip tip_Ayuda;
        private Label lbl_Acavaunaimagenowo;
    }
}