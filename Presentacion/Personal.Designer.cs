namespace Presentacion
{
    partial class Personal
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
            System.Windows.Forms.Label idPersonalLabel;
            System.Windows.Forms.Label primerNombreLabel;
            System.Windows.Forms.Label segundoNombreLabel;
            System.Windows.Forms.Label primerApellidoLabel;
            System.Windows.Forms.Label segundoApellidoLabel;
            System.Windows.Forms.Label cedulaLabel;
            System.Windows.Forms.Label idCargoLabel;
            System.Windows.Forms.Label estadoLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Personal));
            this.personalBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new Datos.DataSet1();
            this.idPersonalTextBox = new System.Windows.Forms.TextBox();
            this.primerNombreTextBox = new System.Windows.Forms.TextBox();
            this.segundoNombreTextBox = new System.Windows.Forms.TextBox();
            this.primerApellidoTextBox = new System.Windows.Forms.TextBox();
            this.segundoApellidoTextBox = new System.Windows.Forms.TextBox();
            this.cedulaTextBox = new System.Windows.Forms.TextBox();
            this.idCargoComboBox = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelDatos = new System.Windows.Forms.Panel();
            this.estadoComboBox = new System.Windows.Forms.ComboBox();
            this.panelBotones = new System.Windows.Forms.Panel();
            this.BtnBuscar = new Bunifu.Framework.UI.BunifuImageButton();
            this.BtnEliminar = new Bunifu.Framework.UI.BunifuImageButton();
            this.BtnEditar = new Bunifu.Framework.UI.BunifuImageButton();
            this.BtnCancelar = new Bunifu.Framework.UI.BunifuImageButton();
            this.BtnGuardar = new Bunifu.Framework.UI.BunifuImageButton();
            this.BtnNuevo = new Bunifu.Framework.UI.BunifuImageButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.SalirButton = new Bunifu.Framework.UI.BunifuImageButton();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            idPersonalLabel = new System.Windows.Forms.Label();
            primerNombreLabel = new System.Windows.Forms.Label();
            segundoNombreLabel = new System.Windows.Forms.Label();
            primerApellidoLabel = new System.Windows.Forms.Label();
            segundoApellidoLabel = new System.Windows.Forms.Label();
            cedulaLabel = new System.Windows.Forms.Label();
            idCargoLabel = new System.Windows.Forms.Label();
            estadoLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.personalBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panelDatos.SuspendLayout();
            this.panelBotones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BtnBuscar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnEliminar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnEditar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnCancelar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnGuardar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnNuevo)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SalirButton)).BeginInit();
            this.SuspendLayout();
            // 
            // idPersonalLabel
            // 
            idPersonalLabel.AutoSize = true;
            idPersonalLabel.Location = new System.Drawing.Point(8, 11);
            idPersonalLabel.Name = "idPersonalLabel";
            idPersonalLabel.Size = new System.Drawing.Size(16, 13);
            idPersonalLabel.TabIndex = 28;
            idPersonalLabel.Text = "Id";
            // 
            // primerNombreLabel
            // 
            primerNombreLabel.AutoSize = true;
            primerNombreLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            primerNombreLabel.ForeColor = System.Drawing.Color.White;
            primerNombreLabel.Location = new System.Drawing.Point(153, 124);
            primerNombreLabel.Name = "primerNombreLabel";
            primerNombreLabel.Size = new System.Drawing.Size(158, 24);
            primerNombreLabel.TabIndex = 30;
            primerNombreLabel.Text = "Primer Nombre:";
            // 
            // segundoNombreLabel
            // 
            segundoNombreLabel.AutoSize = true;
            segundoNombreLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            segundoNombreLabel.ForeColor = System.Drawing.Color.White;
            segundoNombreLabel.Location = new System.Drawing.Point(129, 166);
            segundoNombreLabel.Name = "segundoNombreLabel";
            segundoNombreLabel.Size = new System.Drawing.Size(182, 24);
            segundoNombreLabel.TabIndex = 32;
            segundoNombreLabel.Text = "Segundo Nombre:";
            // 
            // primerApellidoLabel
            // 
            primerApellidoLabel.AutoSize = true;
            primerApellidoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            primerApellidoLabel.ForeColor = System.Drawing.Color.White;
            primerApellidoLabel.Location = new System.Drawing.Point(151, 212);
            primerApellidoLabel.Name = "primerApellidoLabel";
            primerApellidoLabel.Size = new System.Drawing.Size(160, 24);
            primerApellidoLabel.TabIndex = 34;
            primerApellidoLabel.Text = "Primer Apellido:";
            // 
            // segundoApellidoLabel
            // 
            segundoApellidoLabel.AutoSize = true;
            segundoApellidoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            segundoApellidoLabel.ForeColor = System.Drawing.Color.White;
            segundoApellidoLabel.Location = new System.Drawing.Point(127, 253);
            segundoApellidoLabel.Name = "segundoApellidoLabel";
            segundoApellidoLabel.Size = new System.Drawing.Size(184, 24);
            segundoApellidoLabel.TabIndex = 36;
            segundoApellidoLabel.Text = "Segundo Apellido:";
            // 
            // cedulaLabel
            // 
            cedulaLabel.AutoSize = true;
            cedulaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            cedulaLabel.ForeColor = System.Drawing.Color.White;
            cedulaLabel.Location = new System.Drawing.Point(229, 84);
            cedulaLabel.Name = "cedulaLabel";
            cedulaLabel.Size = new System.Drawing.Size(82, 24);
            cedulaLabel.TabIndex = 38;
            cedulaLabel.Text = "Cedula:";
            // 
            // idCargoLabel
            // 
            idCargoLabel.AutoSize = true;
            idCargoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            idCargoLabel.ForeColor = System.Drawing.Color.White;
            idCargoLabel.Location = new System.Drawing.Point(239, 297);
            idCargoLabel.Name = "idCargoLabel";
            idCargoLabel.Size = new System.Drawing.Size(72, 24);
            idCargoLabel.TabIndex = 40;
            idCargoLabel.Text = "Cargo:";
            // 
            // estadoLabel
            // 
            estadoLabel.AutoSize = true;
            estadoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            estadoLabel.ForeColor = System.Drawing.Color.White;
            estadoLabel.Location = new System.Drawing.Point(231, 347);
            estadoLabel.Name = "estadoLabel";
            estadoLabel.Size = new System.Drawing.Size(80, 24);
            estadoLabel.TabIndex = 42;
            estadoLabel.Text = "Estado:";
            // 
            // personalBindingSource
            // 
            this.personalBindingSource.DataMember = "Personal1";
            this.personalBindingSource.DataSource = this.dataSet1;
            this.personalBindingSource.CurrentChanged += new System.EventHandler(this.personalBindingSource_CurrentChanged);
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // idPersonalTextBox
            // 
            this.idPersonalTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.personalBindingSource, "IdPersonal", true));
            this.idPersonalTextBox.Enabled = false;
            this.idPersonalTextBox.Location = new System.Drawing.Point(30, 8);
            this.idPersonalTextBox.Name = "idPersonalTextBox";
            this.idPersonalTextBox.Size = new System.Drawing.Size(32, 20);
            this.idPersonalTextBox.TabIndex = 29;
            // 
            // primerNombreTextBox
            // 
            this.primerNombreTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(45)))), ((int)(((byte)(60)))));
            this.primerNombreTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.personalBindingSource, "PrimerNombre", true));
            this.primerNombreTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.primerNombreTextBox.ForeColor = System.Drawing.Color.White;
            this.primerNombreTextBox.Location = new System.Drawing.Point(9, 71);
            this.primerNombreTextBox.Name = "primerNombreTextBox";
            this.primerNombreTextBox.Size = new System.Drawing.Size(272, 29);
            this.primerNombreTextBox.TabIndex = 2;
            this.primerNombreTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.primerNombreTextBox_KeyPress);
            // 
            // segundoNombreTextBox
            // 
            this.segundoNombreTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(45)))), ((int)(((byte)(60)))));
            this.segundoNombreTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.personalBindingSource, "SegundoNombre", true));
            this.segundoNombreTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.segundoNombreTextBox.ForeColor = System.Drawing.Color.White;
            this.segundoNombreTextBox.Location = new System.Drawing.Point(9, 113);
            this.segundoNombreTextBox.Name = "segundoNombreTextBox";
            this.segundoNombreTextBox.Size = new System.Drawing.Size(272, 29);
            this.segundoNombreTextBox.TabIndex = 3;
            this.segundoNombreTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.primerNombreTextBox_KeyPress);
            // 
            // primerApellidoTextBox
            // 
            this.primerApellidoTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(45)))), ((int)(((byte)(60)))));
            this.primerApellidoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.personalBindingSource, "PrimerApellido", true));
            this.primerApellidoTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.primerApellidoTextBox.ForeColor = System.Drawing.Color.White;
            this.primerApellidoTextBox.Location = new System.Drawing.Point(9, 159);
            this.primerApellidoTextBox.Name = "primerApellidoTextBox";
            this.primerApellidoTextBox.Size = new System.Drawing.Size(272, 29);
            this.primerApellidoTextBox.TabIndex = 4;
            this.primerApellidoTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.primerNombreTextBox_KeyPress);
            // 
            // segundoApellidoTextBox
            // 
            this.segundoApellidoTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(45)))), ((int)(((byte)(60)))));
            this.segundoApellidoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.personalBindingSource, "SegundoApellido", true));
            this.segundoApellidoTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.segundoApellidoTextBox.ForeColor = System.Drawing.Color.White;
            this.segundoApellidoTextBox.Location = new System.Drawing.Point(9, 200);
            this.segundoApellidoTextBox.Name = "segundoApellidoTextBox";
            this.segundoApellidoTextBox.Size = new System.Drawing.Size(272, 29);
            this.segundoApellidoTextBox.TabIndex = 5;
            this.segundoApellidoTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.primerNombreTextBox_KeyPress);
            // 
            // cedulaTextBox
            // 
            this.cedulaTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(45)))), ((int)(((byte)(60)))));
            this.cedulaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.personalBindingSource, "Cedula", true));
            this.cedulaTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cedulaTextBox.ForeColor = System.Drawing.Color.White;
            this.cedulaTextBox.Location = new System.Drawing.Point(9, 31);
            this.cedulaTextBox.Name = "cedulaTextBox";
            this.cedulaTextBox.Size = new System.Drawing.Size(272, 29);
            this.cedulaTextBox.TabIndex = 1;
            this.cedulaTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cedulaTextBox_KeyPress);
            // 
            // idCargoComboBox
            // 
            this.idCargoComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.idCargoComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.idCargoComboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(45)))), ((int)(((byte)(60)))));
            this.idCargoComboBox.CausesValidation = false;
            this.idCargoComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.idCargoComboBox.ForeColor = System.Drawing.Color.White;
            this.idCargoComboBox.FormattingEnabled = true;
            this.idCargoComboBox.Location = new System.Drawing.Point(9, 244);
            this.idCargoComboBox.Name = "idCargoComboBox";
            this.idCargoComboBox.Size = new System.Drawing.Size(272, 32);
            this.idCargoComboBox.TabIndex = 6;
            this.idCargoComboBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.idCargoComboBox_KeyPress);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panelDatos);
            this.panel1.Controls.Add(this.panelBotones);
            this.panel1.Controls.Add(primerNombreLabel);
            this.panel1.Controls.Add(segundoNombreLabel);
            this.panel1.Controls.Add(primerApellidoLabel);
            this.panel1.Controls.Add(segundoApellidoLabel);
            this.panel1.Controls.Add(cedulaLabel);
            this.panel1.Controls.Add(idCargoLabel);
            this.panel1.Controls.Add(estadoLabel);
            this.panel1.Location = new System.Drawing.Point(127, 34);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(770, 586);
            this.panel1.TabIndex = 44;
            // 
            // panelDatos
            // 
            this.panelDatos.Controls.Add(this.estadoComboBox);
            this.panelDatos.Controls.Add(this.primerNombreTextBox);
            this.panelDatos.Controls.Add(this.segundoNombreTextBox);
            this.panelDatos.Controls.Add(this.primerApellidoTextBox);
            this.panelDatos.Controls.Add(this.segundoApellidoTextBox);
            this.panelDatos.Controls.Add(this.cedulaTextBox);
            this.panelDatos.Controls.Add(this.idCargoComboBox);
            this.panelDatos.Enabled = false;
            this.panelDatos.Location = new System.Drawing.Point(316, 50);
            this.panelDatos.Name = "panelDatos";
            this.panelDatos.Size = new System.Drawing.Size(296, 350);
            this.panelDatos.TabIndex = 45;
            // 
            // estadoComboBox
            // 
            this.estadoComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.estadoComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.estadoComboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(45)))), ((int)(((byte)(60)))));
            this.estadoComboBox.CausesValidation = false;
            this.estadoComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.personalBindingSource, "Estado", true));
            this.estadoComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.estadoComboBox.ForeColor = System.Drawing.Color.White;
            this.estadoComboBox.FormattingEnabled = true;
            this.estadoComboBox.Items.AddRange(new object[] {
            "Habilitado",
            "Deshabilitado"});
            this.estadoComboBox.Location = new System.Drawing.Point(9, 294);
            this.estadoComboBox.Name = "estadoComboBox";
            this.estadoComboBox.Size = new System.Drawing.Size(272, 32);
            this.estadoComboBox.TabIndex = 7;
            this.estadoComboBox.Text = "Habilitado";
            this.estadoComboBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.idCargoComboBox_KeyPress);
            // 
            // panelBotones
            // 
            this.panelBotones.Controls.Add(this.BtnBuscar);
            this.panelBotones.Controls.Add(this.BtnEliminar);
            this.panelBotones.Controls.Add(this.BtnEditar);
            this.panelBotones.Controls.Add(this.BtnCancelar);
            this.panelBotones.Controls.Add(this.BtnGuardar);
            this.panelBotones.Controls.Add(this.BtnNuevo);
            this.panelBotones.Location = new System.Drawing.Point(106, 450);
            this.panelBotones.Name = "panelBotones";
            this.panelBotones.Size = new System.Drawing.Size(558, 131);
            this.panelBotones.TabIndex = 8;
            // 
            // BtnBuscar
            // 
            this.BtnBuscar.BackColor = System.Drawing.Color.Transparent;
            this.BtnBuscar.Image = ((System.Drawing.Image)(resources.GetObject("BtnBuscar.Image")));
            this.BtnBuscar.ImageActive = null;
            this.BtnBuscar.Location = new System.Drawing.Point(456, 21);
            this.BtnBuscar.Name = "BtnBuscar";
            this.BtnBuscar.Size = new System.Drawing.Size(80, 80);
            this.BtnBuscar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BtnBuscar.TabIndex = 51;
            this.BtnBuscar.TabStop = false;
            this.toolTip1.SetToolTip(this.BtnBuscar, "Buscar");
            this.BtnBuscar.Zoom = 20;
            this.BtnBuscar.Click += new System.EventHandler(this.BtnBuscar_Click);
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.BackColor = System.Drawing.Color.Transparent;
            this.BtnEliminar.Image = ((System.Drawing.Image)(resources.GetObject("BtnEliminar.Image")));
            this.BtnEliminar.ImageActive = null;
            this.BtnEliminar.Location = new System.Drawing.Point(370, 21);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(80, 80);
            this.BtnEliminar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BtnEliminar.TabIndex = 50;
            this.BtnEliminar.TabStop = false;
            this.toolTip1.SetToolTip(this.BtnEliminar, "Eliminar");
            this.BtnEliminar.Zoom = 20;
            this.BtnEliminar.Click += new System.EventHandler(this.BtnEliminar_Click);
            // 
            // BtnEditar
            // 
            this.BtnEditar.BackColor = System.Drawing.Color.Transparent;
            this.BtnEditar.Image = ((System.Drawing.Image)(resources.GetObject("BtnEditar.Image")));
            this.BtnEditar.ImageActive = null;
            this.BtnEditar.Location = new System.Drawing.Point(284, 21);
            this.BtnEditar.Name = "BtnEditar";
            this.BtnEditar.Size = new System.Drawing.Size(80, 80);
            this.BtnEditar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BtnEditar.TabIndex = 49;
            this.BtnEditar.TabStop = false;
            this.toolTip1.SetToolTip(this.BtnEditar, "Editar");
            this.BtnEditar.Zoom = 20;
            this.BtnEditar.Click += new System.EventHandler(this.BtnEditar_Click);
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.BackColor = System.Drawing.Color.Transparent;
            this.BtnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("BtnCancelar.Image")));
            this.BtnCancelar.ImageActive = null;
            this.BtnCancelar.Location = new System.Drawing.Point(198, 21);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(80, 80);
            this.BtnCancelar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BtnCancelar.TabIndex = 48;
            this.BtnCancelar.TabStop = false;
            this.toolTip1.SetToolTip(this.BtnCancelar, "Cancelar");
            this.BtnCancelar.Zoom = 20;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // BtnGuardar
            // 
            this.BtnGuardar.BackColor = System.Drawing.Color.Transparent;
            this.BtnGuardar.Image = ((System.Drawing.Image)(resources.GetObject("BtnGuardar.Image")));
            this.BtnGuardar.ImageActive = null;
            this.BtnGuardar.Location = new System.Drawing.Point(108, 21);
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.Size = new System.Drawing.Size(80, 80);
            this.BtnGuardar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BtnGuardar.TabIndex = 47;
            this.BtnGuardar.TabStop = false;
            this.toolTip1.SetToolTip(this.BtnGuardar, "Guardar");
            this.BtnGuardar.Zoom = 20;
            this.BtnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click);
            // 
            // BtnNuevo
            // 
            this.BtnNuevo.BackColor = System.Drawing.Color.Transparent;
            this.BtnNuevo.Image = ((System.Drawing.Image)(resources.GetObject("BtnNuevo.Image")));
            this.BtnNuevo.ImageActive = null;
            this.BtnNuevo.Location = new System.Drawing.Point(17, 21);
            this.BtnNuevo.Name = "BtnNuevo";
            this.BtnNuevo.Size = new System.Drawing.Size(80, 80);
            this.BtnNuevo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BtnNuevo.TabIndex = 46;
            this.BtnNuevo.TabStop = false;
            this.toolTip1.SetToolTip(this.BtnNuevo, "Nueva Persona");
            this.BtnNuevo.Zoom = 20;
            this.BtnNuevo.Click += new System.EventHandler(this.BtnNuevo_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.idPersonalTextBox);
            this.panel2.Controls.Add(idPersonalLabel);
            this.panel2.Enabled = false;
            this.panel2.Location = new System.Drawing.Point(28, 34);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(10, 12);
            this.panel2.TabIndex = 45;
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // SalirButton
            // 
            this.SalirButton.BackColor = System.Drawing.Color.Transparent;
            this.SalirButton.Image = ((System.Drawing.Image)(resources.GetObject("SalirButton.Image")));
            this.SalirButton.ImageActive = null;
            this.SalirButton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.SalirButton.Location = new System.Drawing.Point(1012, 12);
            this.SalirButton.Name = "SalirButton";
            this.SalirButton.Size = new System.Drawing.Size(40, 40);
            this.SalirButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.SalirButton.TabIndex = 1002;
            this.SalirButton.TabStop = false;
            this.SalirButton.Zoom = 20;
            this.SalirButton.Click += new System.EventHandler(this.SalirButton_Click);
            // 
            // Personal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(45)))), ((int)(((byte)(60)))));
            this.ClientSize = new System.Drawing.Size(1064, 632);
            this.ControlBox = false;
            this.Controls.Add(this.SalirButton);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(0, 80);
            this.Name = "Personal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Tag = "1";
            this.Text = "Personal";
            this.Load += new System.EventHandler(this.Personal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.personalBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelDatos.ResumeLayout(false);
            this.panelDatos.PerformLayout();
            this.panelBotones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.BtnBuscar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnEliminar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnEditar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnCancelar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnGuardar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnNuevo)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SalirButton)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Datos.DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource personalBindingSource;
        private System.Windows.Forms.TextBox idPersonalTextBox;
        private System.Windows.Forms.TextBox primerNombreTextBox;
        private System.Windows.Forms.TextBox segundoNombreTextBox;
        private System.Windows.Forms.TextBox primerApellidoTextBox;
        private System.Windows.Forms.TextBox segundoApellidoTextBox;
        private System.Windows.Forms.TextBox cedulaTextBox;
        private System.Windows.Forms.ComboBox idCargoComboBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelBotones;
        private System.Windows.Forms.Panel panelDatos;
        private System.Windows.Forms.ComboBox estadoComboBox;
        private System.Windows.Forms.Panel panel2;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuImageButton SalirButton;
        private Bunifu.Framework.UI.BunifuImageButton BtnNuevo;
        private System.Windows.Forms.ToolTip toolTip1;
        private Bunifu.Framework.UI.BunifuImageButton BtnGuardar;
        private Bunifu.Framework.UI.BunifuImageButton BtnCancelar;
        private Bunifu.Framework.UI.BunifuImageButton BtnEditar;
        private Bunifu.Framework.UI.BunifuImageButton BtnEliminar;
        private Bunifu.Framework.UI.BunifuImageButton BtnBuscar;
    }
}