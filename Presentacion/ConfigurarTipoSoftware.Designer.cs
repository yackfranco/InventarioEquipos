namespace Presentacion
{
    partial class ConfigurarTipoSoftware
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
            System.Windows.Forms.Label idTipoSoftwareLabel;
            System.Windows.Forms.Label nombreCargoLabel;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConfigurarTipoSoftware));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelDatos = new System.Windows.Forms.Panel();
            this.nombreTipoTextBox = new System.Windows.Forms.TextBox();
            this.tipoSoftwareBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new Datos.DataSet1();
            this.bunifuCustomDataGrid1 = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.nombreTipoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.BtnBuscar = new Bunifu.Framework.UI.BunifuImageButton();
            this.BtnEliminar = new Bunifu.Framework.UI.BunifuImageButton();
            this.BtnEditar = new Bunifu.Framework.UI.BunifuImageButton();
            this.BtnCancelar = new Bunifu.Framework.UI.BunifuImageButton();
            this.BtnGuardar = new Bunifu.Framework.UI.BunifuImageButton();
            this.BtnNuevo = new Bunifu.Framework.UI.BunifuImageButton();
            this.idTipoSoftwareTextBox = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.SalirButton = new Bunifu.Framework.UI.BunifuImageButton();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            idTipoSoftwareLabel = new System.Windows.Forms.Label();
            nombreCargoLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panelDatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tipoSoftwareBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuCustomDataGrid1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BtnBuscar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnEliminar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnEditar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnCancelar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnGuardar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnNuevo)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SalirButton)).BeginInit();
            this.SuspendLayout();
            // 
            // idTipoSoftwareLabel
            // 
            idTipoSoftwareLabel.AutoSize = true;
            idTipoSoftwareLabel.Location = new System.Drawing.Point(12, 14);
            idTipoSoftwareLabel.Name = "idTipoSoftwareLabel";
            idTipoSoftwareLabel.Size = new System.Drawing.Size(88, 13);
            idTipoSoftwareLabel.TabIndex = 3;
            idTipoSoftwareLabel.Text = "Id Tipo Software:";
            // 
            // nombreCargoLabel
            // 
            nombreCargoLabel.AutoSize = true;
            nombreCargoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            nombreCargoLabel.ForeColor = System.Drawing.Color.White;
            nombreCargoLabel.Location = new System.Drawing.Point(39, 48);
            nombreCargoLabel.Name = "nombreCargoLabel";
            nombreCargoLabel.Size = new System.Drawing.Size(255, 24);
            nombreCargoLabel.TabIndex = 1011;
            nombreCargoLabel.Text = "Nombre Tipo de Software:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(nombreCargoLabel);
            this.panel1.Controls.Add(this.panelDatos);
            this.panel1.Controls.Add(this.bunifuCustomDataGrid1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(90, 97);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(676, 595);
            this.panel1.TabIndex = 2;
            // 
            // panelDatos
            // 
            this.panelDatos.Controls.Add(this.nombreTipoTextBox);
            this.panelDatos.Enabled = false;
            this.panelDatos.Location = new System.Drawing.Point(300, 24);
            this.panelDatos.Name = "panelDatos";
            this.panelDatos.Size = new System.Drawing.Size(337, 72);
            this.panelDatos.TabIndex = 1012;
            // 
            // nombreTipoTextBox
            // 
            this.nombreTipoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tipoSoftwareBindingSource, "NombreTipo", true));
            this.nombreTipoTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nombreTipoTextBox.Location = new System.Drawing.Point(23, 24);
            this.nombreTipoTextBox.Name = "nombreTipoTextBox";
            this.nombreTipoTextBox.Size = new System.Drawing.Size(274, 29);
            this.nombreTipoTextBox.TabIndex = 3;
            this.nombreTipoTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.nombreTipoTextBox_KeyPress);
            // 
            // tipoSoftwareBindingSource
            // 
            this.tipoSoftwareBindingSource.DataMember = "TipoSoftware1";
            this.tipoSoftwareBindingSource.DataSource = this.dataSet1;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bunifuCustomDataGrid1
            // 
            this.bunifuCustomDataGrid1.AllowUserToAddRows = false;
            this.bunifuCustomDataGrid1.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.bunifuCustomDataGrid1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.bunifuCustomDataGrid1.AutoGenerateColumns = false;
            this.bunifuCustomDataGrid1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.bunifuCustomDataGrid1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(45)))), ((int)(((byte)(60)))));
            this.bunifuCustomDataGrid1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.bunifuCustomDataGrid1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(97)))), ((int)(((byte)(216)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(0, 3, 0, 3);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.bunifuCustomDataGrid1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.bunifuCustomDataGrid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bunifuCustomDataGrid1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nombreTipoDataGridViewTextBoxColumn});
            this.bunifuCustomDataGrid1.DataSource = this.tipoSoftwareBindingSource;
            this.bunifuCustomDataGrid1.DoubleBuffered = true;
            this.bunifuCustomDataGrid1.EnableHeadersVisualStyles = false;
            this.bunifuCustomDataGrid1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(97)))), ((int)(((byte)(216)))));
            this.bunifuCustomDataGrid1.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(97)))), ((int)(((byte)(216)))));
            this.bunifuCustomDataGrid1.HeaderForeColor = System.Drawing.Color.White;
            this.bunifuCustomDataGrid1.Location = new System.Drawing.Point(13, 301);
            this.bunifuCustomDataGrid1.Name = "bunifuCustomDataGrid1";
            this.bunifuCustomDataGrid1.ReadOnly = true;
            this.bunifuCustomDataGrid1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(0, 2, 0, 2);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.bunifuCustomDataGrid1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.bunifuCustomDataGrid1.RowHeadersWidth = 10;
            this.bunifuCustomDataGrid1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.bunifuCustomDataGrid1.Size = new System.Drawing.Size(640, 263);
            this.bunifuCustomDataGrid1.TabIndex = 1009;
            this.bunifuCustomDataGrid1.VirtualMode = true;
            // 
            // nombreTipoDataGridViewTextBoxColumn
            // 
            this.nombreTipoDataGridViewTextBoxColumn.DataPropertyName = "NombreTipo";
            this.nombreTipoDataGridViewTextBoxColumn.HeaderText = "NombreTipo";
            this.nombreTipoDataGridViewTextBoxColumn.Name = "nombreTipoDataGridViewTextBoxColumn";
            this.nombreTipoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.BtnBuscar);
            this.panel2.Controls.Add(this.BtnEliminar);
            this.panel2.Controls.Add(this.BtnEditar);
            this.panel2.Controls.Add(this.BtnCancelar);
            this.panel2.Controls.Add(this.BtnGuardar);
            this.panel2.Controls.Add(this.BtnNuevo);
            this.panel2.Location = new System.Drawing.Point(18, 145);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(640, 132);
            this.panel2.TabIndex = 1010;
            // 
            // BtnBuscar
            // 
            this.BtnBuscar.BackColor = System.Drawing.Color.Transparent;
            this.BtnBuscar.Image = ((System.Drawing.Image)(resources.GetObject("BtnBuscar.Image")));
            this.BtnBuscar.ImageActive = null;
            this.BtnBuscar.Location = new System.Drawing.Point(500, 20);
            this.BtnBuscar.Name = "BtnBuscar";
            this.BtnBuscar.Size = new System.Drawing.Size(80, 80);
            this.BtnBuscar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BtnBuscar.TabIndex = 57;
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
            this.BtnEliminar.Location = new System.Drawing.Point(414, 20);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(80, 80);
            this.BtnEliminar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BtnEliminar.TabIndex = 56;
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
            this.BtnEditar.Location = new System.Drawing.Point(328, 20);
            this.BtnEditar.Name = "BtnEditar";
            this.BtnEditar.Size = new System.Drawing.Size(80, 80);
            this.BtnEditar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BtnEditar.TabIndex = 55;
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
            this.BtnCancelar.Location = new System.Drawing.Point(242, 20);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(80, 80);
            this.BtnCancelar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BtnCancelar.TabIndex = 54;
            this.BtnCancelar.TabStop = false;
            this.toolTip1.SetToolTip(this.BtnCancelar, "Eliminar");
            this.BtnCancelar.Zoom = 20;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // BtnGuardar
            // 
            this.BtnGuardar.BackColor = System.Drawing.Color.Transparent;
            this.BtnGuardar.Image = ((System.Drawing.Image)(resources.GetObject("BtnGuardar.Image")));
            this.BtnGuardar.ImageActive = null;
            this.BtnGuardar.Location = new System.Drawing.Point(152, 20);
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.Size = new System.Drawing.Size(80, 80);
            this.BtnGuardar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BtnGuardar.TabIndex = 53;
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
            this.BtnNuevo.Location = new System.Drawing.Point(61, 20);
            this.BtnNuevo.Name = "BtnNuevo";
            this.BtnNuevo.Size = new System.Drawing.Size(80, 80);
            this.BtnNuevo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BtnNuevo.TabIndex = 52;
            this.BtnNuevo.TabStop = false;
            this.toolTip1.SetToolTip(this.BtnNuevo, "Nuevo Software");
            this.BtnNuevo.Zoom = 20;
            this.BtnNuevo.Click += new System.EventHandler(this.BtnNuevo_Click);
            // 
            // idTipoSoftwareTextBox
            // 
            this.idTipoSoftwareTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tipoSoftwareBindingSource, "IdTipoSoftware", true));
            this.idTipoSoftwareTextBox.Location = new System.Drawing.Point(106, 11);
            this.idTipoSoftwareTextBox.Name = "idTipoSoftwareTextBox";
            this.idTipoSoftwareTextBox.Size = new System.Drawing.Size(100, 20);
            this.idTipoSoftwareTextBox.TabIndex = 4;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(idTipoSoftwareLabel);
            this.panel3.Controls.Add(this.idTipoSoftwareTextBox);
            this.panel3.Location = new System.Drawing.Point(87, 32);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(10, 15);
            this.panel3.TabIndex = 5;
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
            this.SalirButton.TabIndex = 1005;
            this.SalirButton.TabStop = false;
            this.SalirButton.Zoom = 20;
            this.SalirButton.Click += new System.EventHandler(this.SalirButton_Click);
            // 
            // ConfigurarTipoSoftware
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(45)))), ((int)(((byte)(60)))));
            this.ClientSize = new System.Drawing.Size(1064, 632);
            this.Controls.Add(this.SalirButton);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ConfigurarTipoSoftware";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "ConfigurarTipoSoftware";
            this.Load += new System.EventHandler(this.ConfigurarTipoSoftware_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ConfigurarTipoSoftware_KeyDown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelDatos.ResumeLayout(false);
            this.panelDatos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tipoSoftwareBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuCustomDataGrid1)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.BtnBuscar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnEliminar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnEditar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnCancelar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnGuardar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnNuevo)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SalirButton)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.BindingSource tipoSoftwareBindingSource;
        private Datos.DataSet1 dataSet1;
        private System.Windows.Forms.TextBox idTipoSoftwareTextBox;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private Bunifu.Framework.UI.BunifuImageButton BtnBuscar;
        private Bunifu.Framework.UI.BunifuImageButton BtnEliminar;
        private Bunifu.Framework.UI.BunifuImageButton BtnEditar;
        private Bunifu.Framework.UI.BunifuImageButton BtnCancelar;
        private Bunifu.Framework.UI.BunifuImageButton BtnGuardar;
        private Bunifu.Framework.UI.BunifuImageButton BtnNuevo;
        private Bunifu.Framework.UI.BunifuCustomDataGrid bunifuCustomDataGrid1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel panelDatos;
        private System.Windows.Forms.TextBox nombreTipoTextBox;
        private Bunifu.Framework.UI.BunifuImageButton SalirButton;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreTipoDataGridViewTextBoxColumn;

    }
}