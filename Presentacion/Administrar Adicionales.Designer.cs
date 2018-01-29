namespace Presentacion
{
    partial class Administrar_Adicionales
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
            System.Windows.Forms.Label marcaLabel;
            System.Windows.Forms.Label modeloLabel;
            System.Windows.Forms.Label serialLabel;
            System.Windows.Forms.Label placaLabel;
            System.Windows.Forms.Label nombreProveedorLabel;
            System.Windows.Forms.Label nitLabel;
            System.Windows.Forms.Label valorCompraLabel;
            System.Windows.Forms.Label fechaCompraLabel;
            System.Windows.Forms.Label label1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Administrar_Adicionales));
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label label3;
            this.dataSet1 = new Datos.DataSet1();
            this.adicionalBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.marcaTextBox = new System.Windows.Forms.TextBox();
            this.modeloTextBox = new System.Windows.Forms.TextBox();
            this.serialTextBox = new System.Windows.Forms.TextBox();
            this.placaTextBox = new System.Windows.Forms.TextBox();
            this.compraBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nombreProveedorTextBox = new System.Windows.Forms.TextBox();
            this.nitTextBox = new System.Windows.Forms.TextBox();
            this.valorCompraTextBox = new System.Windows.Forms.TextBox();
            this.fechaCompraDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.panelDatos = new System.Windows.Forms.Panel();
            this.leasingCheckBox = new System.Windows.Forms.CheckBox();
            this.ArticuloComboBox = new System.Windows.Forms.ComboBox();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.EditarButton = new Bunifu.Framework.UI.BunifuImageButton();
            this.BuscarButton = new Bunifu.Framework.UI.BunifuImageButton();
            this.EliminarButton = new Bunifu.Framework.UI.BunifuImageButton();
            this.CancelarButton = new Bunifu.Framework.UI.BunifuImageButton();
            this.GuardarButton = new Bunifu.Framework.UI.BunifuImageButton();
            this.NuevoButton = new Bunifu.Framework.UI.BunifuImageButton();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.SalirButton = new Bunifu.Framework.UI.BunifuImageButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.IdCompraTextBox = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.textBox2 = new System.Windows.Forms.TextBox();
            marcaLabel = new System.Windows.Forms.Label();
            modeloLabel = new System.Windows.Forms.Label();
            serialLabel = new System.Windows.Forms.Label();
            placaLabel = new System.Windows.Forms.Label();
            nombreProveedorLabel = new System.Windows.Forms.Label();
            nitLabel = new System.Windows.Forms.Label();
            valorCompraLabel = new System.Windows.Forms.Label();
            fechaCompraLabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.adicionalBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.compraBindingSource)).BeginInit();
            this.panelDatos.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EditarButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BuscarButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EliminarButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CancelarButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GuardarButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NuevoButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SalirButton)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // marcaLabel
            // 
            marcaLabel.AutoSize = true;
            marcaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            marcaLabel.ForeColor = System.Drawing.Color.White;
            marcaLabel.Location = new System.Drawing.Point(36, 61);
            marcaLabel.Name = "marcaLabel";
            marcaLabel.Size = new System.Drawing.Size(67, 24);
            marcaLabel.TabIndex = 7;
            marcaLabel.Text = "Marca:";
            // 
            // modeloLabel
            // 
            modeloLabel.AutoSize = true;
            modeloLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            modeloLabel.ForeColor = System.Drawing.Color.White;
            modeloLabel.Location = new System.Drawing.Point(24, 99);
            modeloLabel.Name = "modeloLabel";
            modeloLabel.Size = new System.Drawing.Size(79, 24);
            modeloLabel.TabIndex = 9;
            modeloLabel.Text = "Modelo:";
            // 
            // serialLabel
            // 
            serialLabel.AutoSize = true;
            serialLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            serialLabel.ForeColor = System.Drawing.Color.White;
            serialLabel.Location = new System.Drawing.Point(41, 137);
            serialLabel.Name = "serialLabel";
            serialLabel.Size = new System.Drawing.Size(62, 24);
            serialLabel.TabIndex = 11;
            serialLabel.Text = "Serial:";
            // 
            // placaLabel
            // 
            placaLabel.AutoSize = true;
            placaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            placaLabel.ForeColor = System.Drawing.Color.White;
            placaLabel.Location = new System.Drawing.Point(42, 176);
            placaLabel.Name = "placaLabel";
            placaLabel.Size = new System.Drawing.Size(61, 24);
            placaLabel.TabIndex = 13;
            placaLabel.Text = "Placa:";
            // 
            // nombreProveedorLabel
            // 
            nombreProveedorLabel.AutoSize = true;
            nombreProveedorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nombreProveedorLabel.ForeColor = System.Drawing.Color.White;
            nombreProveedorLabel.Location = new System.Drawing.Point(392, 24);
            nombreProveedorLabel.Name = "nombreProveedorLabel";
            nombreProveedorLabel.Size = new System.Drawing.Size(177, 24);
            nombreProveedorLabel.TabIndex = 19;
            nombreProveedorLabel.Text = "Nombre Proveedor:";
            // 
            // nitLabel
            // 
            nitLabel.AutoSize = true;
            nitLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nitLabel.ForeColor = System.Drawing.Color.White;
            nitLabel.Location = new System.Drawing.Point(532, 61);
            nitLabel.Name = "nitLabel";
            nitLabel.Size = new System.Drawing.Size(37, 24);
            nitLabel.TabIndex = 21;
            nitLabel.Text = "Nit:";
            // 
            // valorCompraLabel
            // 
            valorCompraLabel.AutoSize = true;
            valorCompraLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            valorCompraLabel.ForeColor = System.Drawing.Color.White;
            valorCompraLabel.Location = new System.Drawing.Point(438, 98);
            valorCompraLabel.Name = "valorCompraLabel";
            valorCompraLabel.Size = new System.Drawing.Size(131, 24);
            valorCompraLabel.TabIndex = 23;
            valorCompraLabel.Text = "Valor Compra:";
            // 
            // fechaCompraLabel
            // 
            fechaCompraLabel.AutoSize = true;
            fechaCompraLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            fechaCompraLabel.ForeColor = System.Drawing.Color.White;
            fechaCompraLabel.Location = new System.Drawing.Point(428, 136);
            fechaCompraLabel.Name = "fechaCompraLabel";
            fechaCompraLabel.Size = new System.Drawing.Size(141, 24);
            fechaCompraLabel.TabIndex = 25;
            fechaCompraLabel.Text = "Fecha Compra:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label1.ForeColor = System.Drawing.Color.White;
            label1.Location = new System.Drawing.Point(25, 24);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(78, 24);
            label1.TabIndex = 27;
            label1.Text = "Articulo:";
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // adicionalBindingSource
            // 
            this.adicionalBindingSource.DataMember = "Adicional1";
            this.adicionalBindingSource.DataSource = this.dataSet1;
            // 
            // marcaTextBox
            // 
            this.marcaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.adicionalBindingSource, "Marca", true));
            this.marcaTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.marcaTextBox.Location = new System.Drawing.Point(123, 58);
            this.marcaTextBox.Name = "marcaTextBox";
            this.marcaTextBox.Size = new System.Drawing.Size(252, 29);
            this.marcaTextBox.TabIndex = 8;
            // 
            // modeloTextBox
            // 
            this.modeloTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.adicionalBindingSource, "Modelo", true));
            this.modeloTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modeloTextBox.Location = new System.Drawing.Point(123, 96);
            this.modeloTextBox.Name = "modeloTextBox";
            this.modeloTextBox.Size = new System.Drawing.Size(252, 29);
            this.modeloTextBox.TabIndex = 10;
            // 
            // serialTextBox
            // 
            this.serialTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.adicionalBindingSource, "Serial", true));
            this.serialTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.serialTextBox.Location = new System.Drawing.Point(123, 134);
            this.serialTextBox.Name = "serialTextBox";
            this.serialTextBox.Size = new System.Drawing.Size(252, 29);
            this.serialTextBox.TabIndex = 12;
            // 
            // placaTextBox
            // 
            this.placaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.adicionalBindingSource, "Placa", true));
            this.placaTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.placaTextBox.Location = new System.Drawing.Point(123, 173);
            this.placaTextBox.Name = "placaTextBox";
            this.placaTextBox.Size = new System.Drawing.Size(252, 29);
            this.placaTextBox.TabIndex = 14;
            this.placaTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.marcaTextBox_KeyPress);
            this.placaTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.placaTextBox_Validating);
            // 
            // compraBindingSource
            // 
            this.compraBindingSource.DataMember = "Compra1";
            this.compraBindingSource.DataSource = this.dataSet1;
            // 
            // nombreProveedorTextBox
            // 
            this.nombreProveedorTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.compraBindingSource, "NombreProveedor", true));
            this.nombreProveedorTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombreProveedorTextBox.Location = new System.Drawing.Point(575, 21);
            this.nombreProveedorTextBox.Name = "nombreProveedorTextBox";
            this.nombreProveedorTextBox.Size = new System.Drawing.Size(394, 29);
            this.nombreProveedorTextBox.TabIndex = 20;
            this.nombreProveedorTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.nombreProveedorTextBox_KeyPress);
            // 
            // nitTextBox
            // 
            this.nitTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.compraBindingSource, "Nit", true));
            this.nitTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nitTextBox.Location = new System.Drawing.Point(575, 59);
            this.nitTextBox.Name = "nitTextBox";
            this.nitTextBox.Size = new System.Drawing.Size(394, 29);
            this.nitTextBox.TabIndex = 22;
            this.nitTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.nitTextBox_KeyPress);
            // 
            // valorCompraTextBox
            // 
            this.valorCompraTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.compraBindingSource, "ValorCompra", true));
            this.valorCompraTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.valorCompraTextBox.Location = new System.Drawing.Point(575, 96);
            this.valorCompraTextBox.Name = "valorCompraTextBox";
            this.valorCompraTextBox.Size = new System.Drawing.Size(394, 29);
            this.valorCompraTextBox.TabIndex = 24;
            this.valorCompraTextBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.valorCompraTextBox_KeyUp);
            // 
            // fechaCompraDateTimePicker
            // 
            this.fechaCompraDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.compraBindingSource, "FechaCompra", true));
            this.fechaCompraDateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fechaCompraDateTimePicker.Location = new System.Drawing.Point(575, 134);
            this.fechaCompraDateTimePicker.Name = "fechaCompraDateTimePicker";
            this.fechaCompraDateTimePicker.Size = new System.Drawing.Size(394, 29);
            this.fechaCompraDateTimePicker.TabIndex = 26;
            // 
            // panelDatos
            // 
            this.panelDatos.BackColor = System.Drawing.Color.Transparent;
            this.panelDatos.Controls.Add(this.panel4);
            this.panelDatos.Controls.Add(this.panel3);
            this.panelDatos.Controls.Add(this.leasingCheckBox);
            this.panelDatos.Controls.Add(this.ArticuloComboBox);
            this.panelDatos.Controls.Add(label1);
            this.panelDatos.Controls.Add(nombreProveedorLabel);
            this.panelDatos.Controls.Add(this.nombreProveedorTextBox);
            this.panelDatos.Controls.Add(nitLabel);
            this.panelDatos.Controls.Add(this.nitTextBox);
            this.panelDatos.Controls.Add(valorCompraLabel);
            this.panelDatos.Controls.Add(this.valorCompraTextBox);
            this.panelDatos.Controls.Add(fechaCompraLabel);
            this.panelDatos.Controls.Add(this.fechaCompraDateTimePicker);
            this.panelDatos.Controls.Add(marcaLabel);
            this.panelDatos.Controls.Add(this.marcaTextBox);
            this.panelDatos.Controls.Add(modeloLabel);
            this.panelDatos.Controls.Add(this.modeloTextBox);
            this.panelDatos.Controls.Add(serialLabel);
            this.panelDatos.Controls.Add(this.serialTextBox);
            this.panelDatos.Controls.Add(placaLabel);
            this.panelDatos.Controls.Add(this.placaTextBox);
            this.panelDatos.Enabled = false;
            this.panelDatos.ForeColor = System.Drawing.Color.White;
            this.panelDatos.Location = new System.Drawing.Point(12, 11);
            this.panelDatos.Name = "panelDatos";
            this.panelDatos.Size = new System.Drawing.Size(998, 251);
            this.panelDatos.TabIndex = 30;
            // 
            // leasingCheckBox
            // 
            this.leasingCheckBox.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.leasingCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.adicionalBindingSource, "Leasing", true));
            this.leasingCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.leasingCheckBox.ForeColor = System.Drawing.Color.White;
            this.leasingCheckBox.Location = new System.Drawing.Point(16, 208);
            this.leasingCheckBox.Name = "leasingCheckBox";
            this.leasingCheckBox.Size = new System.Drawing.Size(123, 34);
            this.leasingCheckBox.TabIndex = 29;
            this.leasingCheckBox.Text = " Leasing:";
            this.leasingCheckBox.UseVisualStyleBackColor = true;
            // 
            // ArticuloComboBox
            // 
            this.ArticuloComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ArticuloComboBox.FormattingEnabled = true;
            this.ArticuloComboBox.Location = new System.Drawing.Point(123, 20);
            this.ArticuloComboBox.Name = "ArticuloComboBox";
            this.ArticuloComboBox.Size = new System.Drawing.Size(252, 32);
            this.ArticuloComboBox.TabIndex = 28;
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.EditarButton);
            this.panel2.Controls.Add(this.BuscarButton);
            this.panel2.Controls.Add(this.EliminarButton);
            this.panel2.Controls.Add(this.CancelarButton);
            this.panel2.Controls.Add(this.GuardarButton);
            this.panel2.Controls.Add(this.NuevoButton);
            this.panel2.Location = new System.Drawing.Point(240, 268);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(547, 132);
            this.panel2.TabIndex = 31;
            // 
            // EditarButton
            // 
            this.EditarButton.BackColor = System.Drawing.Color.Transparent;
            this.EditarButton.Image = ((System.Drawing.Image)(resources.GetObject("EditarButton.Image")));
            this.EditarButton.ImageActive = null;
            this.EditarButton.Location = new System.Drawing.Point(275, 25);
            this.EditarButton.Name = "EditarButton";
            this.EditarButton.Size = new System.Drawing.Size(80, 80);
            this.EditarButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.EditarButton.TabIndex = 58;
            this.EditarButton.TabStop = false;
            this.toolTip1.SetToolTip(this.EditarButton, "Cancelar");
            this.EditarButton.Zoom = 20;
            this.EditarButton.Click += new System.EventHandler(this.EditarButton_Click);
            // 
            // BuscarButton
            // 
            this.BuscarButton.BackColor = System.Drawing.Color.Transparent;
            this.BuscarButton.Image = ((System.Drawing.Image)(resources.GetObject("BuscarButton.Image")));
            this.BuscarButton.ImageActive = null;
            this.BuscarButton.Location = new System.Drawing.Point(448, 25);
            this.BuscarButton.Name = "BuscarButton";
            this.BuscarButton.Size = new System.Drawing.Size(80, 80);
            this.BuscarButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BuscarButton.TabIndex = 57;
            this.BuscarButton.TabStop = false;
            this.toolTip1.SetToolTip(this.BuscarButton, "Buscar");
            this.BuscarButton.Zoom = 20;
            this.BuscarButton.Click += new System.EventHandler(this.BuscarButton_Click);
            // 
            // EliminarButton
            // 
            this.EliminarButton.BackColor = System.Drawing.Color.Transparent;
            this.EliminarButton.Image = ((System.Drawing.Image)(resources.GetObject("EliminarButton.Image")));
            this.EliminarButton.ImageActive = null;
            this.EliminarButton.Location = new System.Drawing.Point(362, 25);
            this.EliminarButton.Name = "EliminarButton";
            this.EliminarButton.Size = new System.Drawing.Size(80, 80);
            this.EliminarButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.EliminarButton.TabIndex = 56;
            this.EliminarButton.TabStop = false;
            this.toolTip1.SetToolTip(this.EliminarButton, "Dar de Baja");
            this.EliminarButton.Zoom = 20;
            this.EliminarButton.Click += new System.EventHandler(this.EliminarButton_Click);
            // 
            // CancelarButton
            // 
            this.CancelarButton.BackColor = System.Drawing.Color.Transparent;
            this.CancelarButton.Image = ((System.Drawing.Image)(resources.GetObject("CancelarButton.Image")));
            this.CancelarButton.ImageActive = null;
            this.CancelarButton.Location = new System.Drawing.Point(189, 25);
            this.CancelarButton.Name = "CancelarButton";
            this.CancelarButton.Size = new System.Drawing.Size(80, 80);
            this.CancelarButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.CancelarButton.TabIndex = 54;
            this.CancelarButton.TabStop = false;
            this.toolTip1.SetToolTip(this.CancelarButton, "Cancelar");
            this.CancelarButton.Zoom = 20;
            this.CancelarButton.Click += new System.EventHandler(this.CancelarButton_Click);
            // 
            // GuardarButton
            // 
            this.GuardarButton.BackColor = System.Drawing.Color.Transparent;
            this.GuardarButton.Image = ((System.Drawing.Image)(resources.GetObject("GuardarButton.Image")));
            this.GuardarButton.ImageActive = null;
            this.GuardarButton.Location = new System.Drawing.Point(99, 25);
            this.GuardarButton.Name = "GuardarButton";
            this.GuardarButton.Size = new System.Drawing.Size(80, 80);
            this.GuardarButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.GuardarButton.TabIndex = 53;
            this.GuardarButton.TabStop = false;
            this.toolTip1.SetToolTip(this.GuardarButton, "Guardar");
            this.GuardarButton.Zoom = 20;
            this.GuardarButton.Click += new System.EventHandler(this.GuardarButton_Click);
            // 
            // NuevoButton
            // 
            this.NuevoButton.BackColor = System.Drawing.Color.Transparent;
            this.NuevoButton.Image = ((System.Drawing.Image)(resources.GetObject("NuevoButton.Image")));
            this.NuevoButton.ImageActive = null;
            this.NuevoButton.Location = new System.Drawing.Point(8, 25);
            this.NuevoButton.Name = "NuevoButton";
            this.NuevoButton.Size = new System.Drawing.Size(80, 80);
            this.NuevoButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.NuevoButton.TabIndex = 52;
            this.NuevoButton.TabStop = false;
            this.toolTip1.SetToolTip(this.NuevoButton, "Nuevo");
            this.NuevoButton.Zoom = 20;
            this.NuevoButton.Click += new System.EventHandler(this.NuevoButton_Click);
            // 
            // SalirButton
            // 
            this.SalirButton.BackColor = System.Drawing.Color.Transparent;
            this.SalirButton.Image = ((System.Drawing.Image)(resources.GetObject("SalirButton.Image")));
            this.SalirButton.ImageActive = null;
            this.SalirButton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.SalirButton.Location = new System.Drawing.Point(997, 12);
            this.SalirButton.Name = "SalirButton";
            this.SalirButton.Size = new System.Drawing.Size(40, 40);
            this.SalirButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.SalirButton.TabIndex = 1004;
            this.SalirButton.TabStop = false;
            this.toolTip1.SetToolTip(this.SalirButton, "Cerrar");
            this.SalirButton.Zoom = 20;
            this.SalirButton.Click += new System.EventHandler(this.SalirButton_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.panelDatos);
            this.panel1.Location = new System.Drawing.Point(13, 59);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1024, 409);
            this.panel1.TabIndex = 32;
            // 
            // IdCompraTextBox
            // 
            this.IdCompraTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.compraBindingSource, "IdCompra", true));
            this.IdCompraTextBox.Location = new System.Drawing.Point(120, 24);
            this.IdCompraTextBox.Name = "IdCompraTextBox";
            this.IdCompraTextBox.Size = new System.Drawing.Size(100, 20);
            this.IdCompraTextBox.TabIndex = 1005;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label2.ForeColor = System.Drawing.Color.White;
            label2.Location = new System.Drawing.Point(22, 19);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(92, 24);
            label2.TabIndex = 1006;
            label2.Text = "IdCompra";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(label2);
            this.panel3.Controls.Add(this.IdCompraTextBox);
            this.panel3.Location = new System.Drawing.Point(575, 192);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(10, 10);
            this.panel3.TabIndex = 1007;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(label3);
            this.panel4.Controls.Add(this.textBox2);
            this.panel4.Location = new System.Drawing.Point(215, 211);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(10, 10);
            this.panel4.TabIndex = 1008;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label3.ForeColor = System.Drawing.Color.White;
            label3.Location = new System.Drawing.Point(4, 6);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(53, 24);
            label3.TabIndex = 1006;
            label3.Text = "IdAdi";
            // 
            // textBox2
            // 
            this.textBox2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.adicionalBindingSource, "IdAdicional", true));
            this.textBox2.Location = new System.Drawing.Point(62, 11);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(58, 20);
            this.textBox2.TabIndex = 1005;
            // 
            // Administrar_Adicionales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(45)))), ((int)(((byte)(60)))));
            this.ClientSize = new System.Drawing.Size(1048, 594);
            this.Controls.Add(this.SalirButton);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Administrar_Adicionales";
            this.Text = "Administrar_Adicionales";
            this.Load += new System.EventHandler(this.Administrar_Adicionales_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Administrar_Adicionales_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.adicionalBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.compraBindingSource)).EndInit();
            this.panelDatos.ResumeLayout(false);
            this.panelDatos.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.EditarButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BuscarButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EliminarButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CancelarButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GuardarButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NuevoButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SalirButton)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Datos.DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource adicionalBindingSource;
        private System.Windows.Forms.TextBox marcaTextBox;
        private System.Windows.Forms.TextBox modeloTextBox;
        private System.Windows.Forms.TextBox serialTextBox;
        private System.Windows.Forms.TextBox placaTextBox;
        private System.Windows.Forms.BindingSource compraBindingSource;
        private System.Windows.Forms.TextBox nombreProveedorTextBox;
        private System.Windows.Forms.TextBox nitTextBox;
        private System.Windows.Forms.TextBox valorCompraTextBox;
        private System.Windows.Forms.DateTimePicker fechaCompraDateTimePicker;
        private System.Windows.Forms.Panel panelDatos;
        private System.Windows.Forms.ComboBox ArticuloComboBox;
        private System.Windows.Forms.CheckBox leasingCheckBox;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel panel2;
        private Bunifu.Framework.UI.BunifuImageButton BuscarButton;
        private Bunifu.Framework.UI.BunifuImageButton EliminarButton;
        private Bunifu.Framework.UI.BunifuImageButton CancelarButton;
        private Bunifu.Framework.UI.BunifuImageButton GuardarButton;
        private Bunifu.Framework.UI.BunifuImageButton NuevoButton;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuImageButton SalirButton;
        private Bunifu.Framework.UI.BunifuImageButton EditarButton;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox IdCompraTextBox;

    }
}