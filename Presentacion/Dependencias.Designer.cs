namespace Presentacion
{
    partial class Dependencias
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
            System.Windows.Forms.Label idIndependenciaLabel;
            System.Windows.Forms.Label nombreIndependenciaLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dependencias));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel5 = new System.Windows.Forms.Panel();
            this.idIndependenciaTextBox = new System.Windows.Forms.TextBox();
            this.indenpendenciaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new Datos.DataSet1();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.BtnBuscar2 = new Bunifu.Framework.UI.BunifuImageButton();
            this.BtnEliminar2 = new Bunifu.Framework.UI.BunifuImageButton();
            this.BtnEditar2 = new Bunifu.Framework.UI.BunifuImageButton();
            this.BtnCancelar2 = new Bunifu.Framework.UI.BunifuImageButton();
            this.BtnGuardar2 = new Bunifu.Framework.UI.BunifuImageButton();
            this.BtnNuevo2 = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuCustomDataGrid1 = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.nombreIndependenciaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelDatos2 = new System.Windows.Forms.Panel();
            this.nombreIndependenciaTextBox = new System.Windows.Forms.TextBox();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.SalirButton = new Bunifu.Framework.UI.BunifuImageButton();
            idIndependenciaLabel = new System.Windows.Forms.Label();
            nombreIndependenciaLabel = new System.Windows.Forms.Label();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.indenpendenciaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BtnBuscar2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnEliminar2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnEditar2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnCancelar2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnGuardar2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnNuevo2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuCustomDataGrid1)).BeginInit();
            this.panelDatos2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SalirButton)).BeginInit();
            this.SuspendLayout();
            // 
            // idIndependenciaLabel
            // 
            idIndependenciaLabel.AutoSize = true;
            idIndependenciaLabel.Location = new System.Drawing.Point(16, 12);
            idIndependenciaLabel.Name = "idIndependenciaLabel";
            idIndependenciaLabel.Size = new System.Drawing.Size(93, 13);
            idIndependenciaLabel.TabIndex = 0;
            idIndependenciaLabel.Text = "Id Independencia:";
            // 
            // nombreIndependenciaLabel
            // 
            nombreIndependenciaLabel.AutoSize = true;
            nombreIndependenciaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            nombreIndependenciaLabel.ForeColor = System.Drawing.Color.White;
            nombreIndependenciaLabel.Location = new System.Drawing.Point(55, 75);
            nombreIndependenciaLabel.Name = "nombreIndependenciaLabel";
            nombreIndependenciaLabel.Size = new System.Drawing.Size(222, 24);
            nombreIndependenciaLabel.TabIndex = 2;
            nombreIndependenciaLabel.Text = "Nombre Dependencia:";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(idIndependenciaLabel);
            this.panel5.Controls.Add(this.idIndependenciaTextBox);
            this.panel5.Enabled = false;
            this.panel5.Location = new System.Drawing.Point(58, 18);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(10, 10);
            this.panel5.TabIndex = 26;
            // 
            // idIndependenciaTextBox
            // 
            this.idIndependenciaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.indenpendenciaBindingSource, "IdIndependencia", true));
            this.idIndependenciaTextBox.Location = new System.Drawing.Point(115, 9);
            this.idIndependenciaTextBox.Name = "idIndependenciaTextBox";
            this.idIndependenciaTextBox.Size = new System.Drawing.Size(48, 20);
            this.idIndependenciaTextBox.TabIndex = 1;
            // 
            // indenpendenciaBindingSource
            // 
            this.indenpendenciaBindingSource.DataMember = "Indenpendencia1";
            this.indenpendenciaBindingSource.DataSource = this.dataSet1;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(nombreIndependenciaLabel);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.bunifuCustomDataGrid1);
            this.panel1.Controls.Add(this.panelDatos2);
            this.panel1.Location = new System.Drawing.Point(94, 28);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(676, 595);
            this.panel1.TabIndex = 27;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.BtnBuscar2);
            this.panel4.Controls.Add(this.BtnEliminar2);
            this.panel4.Controls.Add(this.BtnEditar2);
            this.panel4.Controls.Add(this.BtnCancelar2);
            this.panel4.Controls.Add(this.BtnGuardar2);
            this.panel4.Controls.Add(this.BtnNuevo2);
            this.panel4.Location = new System.Drawing.Point(18, 145);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(640, 132);
            this.panel4.TabIndex = 1010;
            // 
            // BtnBuscar2
            // 
            this.BtnBuscar2.BackColor = System.Drawing.Color.Transparent;
            this.BtnBuscar2.Image = ((System.Drawing.Image)(resources.GetObject("BtnBuscar2.Image")));
            this.BtnBuscar2.ImageActive = null;
            this.BtnBuscar2.Location = new System.Drawing.Point(500, 20);
            this.BtnBuscar2.Name = "BtnBuscar2";
            this.BtnBuscar2.Size = new System.Drawing.Size(80, 80);
            this.BtnBuscar2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BtnBuscar2.TabIndex = 57;
            this.BtnBuscar2.TabStop = false;
            this.BtnBuscar2.Zoom = 20;
            this.BtnBuscar2.Click += new System.EventHandler(this.BtnBuscar2_Click);
            // 
            // BtnEliminar2
            // 
            this.BtnEliminar2.BackColor = System.Drawing.Color.Transparent;
            this.BtnEliminar2.Image = ((System.Drawing.Image)(resources.GetObject("BtnEliminar2.Image")));
            this.BtnEliminar2.ImageActive = null;
            this.BtnEliminar2.Location = new System.Drawing.Point(414, 20);
            this.BtnEliminar2.Name = "BtnEliminar2";
            this.BtnEliminar2.Size = new System.Drawing.Size(80, 80);
            this.BtnEliminar2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BtnEliminar2.TabIndex = 56;
            this.BtnEliminar2.TabStop = false;
            this.BtnEliminar2.Zoom = 20;
            this.BtnEliminar2.Click += new System.EventHandler(this.BtnEliminar2_Click);
            // 
            // BtnEditar2
            // 
            this.BtnEditar2.BackColor = System.Drawing.Color.Transparent;
            this.BtnEditar2.Image = ((System.Drawing.Image)(resources.GetObject("BtnEditar2.Image")));
            this.BtnEditar2.ImageActive = null;
            this.BtnEditar2.Location = new System.Drawing.Point(328, 20);
            this.BtnEditar2.Name = "BtnEditar2";
            this.BtnEditar2.Size = new System.Drawing.Size(80, 80);
            this.BtnEditar2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BtnEditar2.TabIndex = 55;
            this.BtnEditar2.TabStop = false;
            this.BtnEditar2.Zoom = 20;
            this.BtnEditar2.Click += new System.EventHandler(this.BtnEditar2_Click);
            // 
            // BtnCancelar2
            // 
            this.BtnCancelar2.BackColor = System.Drawing.Color.Transparent;
            this.BtnCancelar2.Image = ((System.Drawing.Image)(resources.GetObject("BtnCancelar2.Image")));
            this.BtnCancelar2.ImageActive = null;
            this.BtnCancelar2.Location = new System.Drawing.Point(242, 20);
            this.BtnCancelar2.Name = "BtnCancelar2";
            this.BtnCancelar2.Size = new System.Drawing.Size(80, 80);
            this.BtnCancelar2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BtnCancelar2.TabIndex = 54;
            this.BtnCancelar2.TabStop = false;
            this.BtnCancelar2.Zoom = 20;
            this.BtnCancelar2.Click += new System.EventHandler(this.BtnCancelar2_Click);
            // 
            // BtnGuardar2
            // 
            this.BtnGuardar2.BackColor = System.Drawing.Color.Transparent;
            this.BtnGuardar2.Image = ((System.Drawing.Image)(resources.GetObject("BtnGuardar2.Image")));
            this.BtnGuardar2.ImageActive = null;
            this.BtnGuardar2.Location = new System.Drawing.Point(152, 20);
            this.BtnGuardar2.Name = "BtnGuardar2";
            this.BtnGuardar2.Size = new System.Drawing.Size(80, 80);
            this.BtnGuardar2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BtnGuardar2.TabIndex = 53;
            this.BtnGuardar2.TabStop = false;
            this.BtnGuardar2.Zoom = 20;
            this.BtnGuardar2.Click += new System.EventHandler(this.BtnGuardar2_Click);
            // 
            // BtnNuevo2
            // 
            this.BtnNuevo2.BackColor = System.Drawing.Color.Transparent;
            this.BtnNuevo2.Image = ((System.Drawing.Image)(resources.GetObject("BtnNuevo2.Image")));
            this.BtnNuevo2.ImageActive = null;
            this.BtnNuevo2.Location = new System.Drawing.Point(61, 20);
            this.BtnNuevo2.Name = "BtnNuevo2";
            this.BtnNuevo2.Size = new System.Drawing.Size(80, 80);
            this.BtnNuevo2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BtnNuevo2.TabIndex = 52;
            this.BtnNuevo2.TabStop = false;
            this.BtnNuevo2.Zoom = 20;
            this.BtnNuevo2.Click += new System.EventHandler(this.BtnNuevo2_Click);
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
            this.nombreIndependenciaDataGridViewTextBoxColumn});
            this.bunifuCustomDataGrid1.DataSource = this.indenpendenciaBindingSource;
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
            // nombreIndependenciaDataGridViewTextBoxColumn
            // 
            this.nombreIndependenciaDataGridViewTextBoxColumn.DataPropertyName = "NombreIndependencia";
            this.nombreIndependenciaDataGridViewTextBoxColumn.HeaderText = "NombreIndependencia";
            this.nombreIndependenciaDataGridViewTextBoxColumn.Name = "nombreIndependenciaDataGridViewTextBoxColumn";
            this.nombreIndependenciaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // panelDatos2
            // 
            this.panelDatos2.Controls.Add(this.nombreIndependenciaTextBox);
            this.panelDatos2.Enabled = false;
            this.panelDatos2.Location = new System.Drawing.Point(284, 48);
            this.panelDatos2.Name = "panelDatos2";
            this.panelDatos2.Size = new System.Drawing.Size(337, 72);
            this.panelDatos2.TabIndex = 25;
            // 
            // nombreIndependenciaTextBox
            // 
            this.nombreIndependenciaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.indenpendenciaBindingSource, "NombreIndependencia", true));
            this.nombreIndependenciaTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nombreIndependenciaTextBox.Location = new System.Drawing.Point(23, 24);
            this.nombreIndependenciaTextBox.Name = "nombreIndependenciaTextBox";
            this.nombreIndependenciaTextBox.Size = new System.Drawing.Size(274, 29);
            this.nombreIndependenciaTextBox.TabIndex = 3;
            this.nombreIndependenciaTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.nombreIndependenciaTextBox_KeyPress);
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
            this.SalirButton.Location = new System.Drawing.Point(1012, 14);
            this.SalirButton.Name = "SalirButton";
            this.SalirButton.Size = new System.Drawing.Size(40, 40);
            this.SalirButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.SalirButton.TabIndex = 1005;
            this.SalirButton.TabStop = false;
            this.SalirButton.Zoom = 20;
            this.SalirButton.Click += new System.EventHandler(this.SalirButton_Click);
            // 
            // Dependencias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(45)))), ((int)(((byte)(60)))));
            this.ClientSize = new System.Drawing.Size(1064, 632);
            this.Controls.Add(this.SalirButton);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Dependencias";
            this.Text = "Dependencias";
            this.Load += new System.EventHandler(this.Dependencias_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Dependencias_KeyDown);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.indenpendenciaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.BtnBuscar2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnEliminar2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnEditar2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnCancelar2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnGuardar2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnNuevo2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuCustomDataGrid1)).EndInit();
            this.panelDatos2.ResumeLayout(false);
            this.panelDatos2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SalirButton)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox idIndependenciaTextBox;
        private System.Windows.Forms.BindingSource indenpendenciaBindingSource;
        private Datos.DataSet1 dataSet1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelDatos2;
        private System.Windows.Forms.TextBox nombreIndependenciaTextBox;
        private Bunifu.Framework.UI.BunifuCustomDataGrid bunifuCustomDataGrid1;
        private System.Windows.Forms.Panel panel4;
        private Bunifu.Framework.UI.BunifuImageButton BtnBuscar2;
        private Bunifu.Framework.UI.BunifuImageButton BtnEliminar2;
        private Bunifu.Framework.UI.BunifuImageButton BtnEditar2;
        private Bunifu.Framework.UI.BunifuImageButton BtnCancelar2;
        private Bunifu.Framework.UI.BunifuImageButton BtnGuardar2;
        private Bunifu.Framework.UI.BunifuImageButton BtnNuevo2;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreIndependenciaDataGridViewTextBoxColumn;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuImageButton SalirButton;
    }
}