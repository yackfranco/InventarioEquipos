namespace Presentacion
{
    partial class AsignarHardware
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AsignarHardware));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.DatosGroupBox = new System.Windows.Forms.GroupBox();
            this.BtnAñadir = new System.Windows.Forms.Button();
            this.LeasingCheckBox = new System.Windows.Forms.CheckBox();
            this.EstadoComboBox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ArticuloComboBox = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.PlacaTextBox = new System.Windows.Forms.TextBox();
            this.SerialTextBox = new System.Windows.Forms.TextBox();
            this.ModeloTextBox = new System.Windows.Forms.TextBox();
            this.MarcaTextBox = new System.Windows.Forms.TextBox();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.dataGridView1 = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.BtnEliminarRegistro = new System.Windows.Forms.Button();
            this.BtnTerminar = new System.Windows.Forms.Button();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.DatosGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // DatosGroupBox
            // 
            this.DatosGroupBox.Controls.Add(this.BtnAñadir);
            this.DatosGroupBox.Controls.Add(this.LeasingCheckBox);
            this.DatosGroupBox.Controls.Add(this.EstadoComboBox);
            this.DatosGroupBox.Controls.Add(this.label4);
            this.DatosGroupBox.Controls.Add(this.ArticuloComboBox);
            this.DatosGroupBox.Controls.Add(this.label13);
            this.DatosGroupBox.Controls.Add(this.label2);
            this.DatosGroupBox.Controls.Add(this.lbl2);
            this.DatosGroupBox.Controls.Add(this.label1);
            this.DatosGroupBox.Controls.Add(this.label14);
            this.DatosGroupBox.Controls.Add(this.PlacaTextBox);
            this.DatosGroupBox.Controls.Add(this.SerialTextBox);
            this.DatosGroupBox.Controls.Add(this.ModeloTextBox);
            this.DatosGroupBox.Controls.Add(this.MarcaTextBox);
            this.DatosGroupBox.ForeColor = System.Drawing.Color.White;
            this.DatosGroupBox.Location = new System.Drawing.Point(11, 22);
            this.DatosGroupBox.Name = "DatosGroupBox";
            this.DatosGroupBox.Size = new System.Drawing.Size(608, 225);
            this.DatosGroupBox.TabIndex = 5;
            this.DatosGroupBox.TabStop = false;
            this.DatosGroupBox.Text = "Software";
            // 
            // BtnAñadir
            // 
            this.BtnAñadir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAñadir.Image = ((System.Drawing.Image)(resources.GetObject("BtnAñadir.Image")));
            this.BtnAñadir.Location = new System.Drawing.Point(406, 146);
            this.BtnAñadir.Name = "BtnAñadir";
            this.BtnAñadir.Size = new System.Drawing.Size(60, 60);
            this.BtnAñadir.TabIndex = 6;
            this.toolTip1.SetToolTip(this.BtnAñadir, "Añadir");
            this.BtnAñadir.UseVisualStyleBackColor = true;
            this.BtnAñadir.Click += new System.EventHandler(this.BtnAñadir_Click);
            // 
            // LeasingCheckBox
            // 
            this.LeasingCheckBox.AutoSize = true;
            this.LeasingCheckBox.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.LeasingCheckBox.Location = new System.Drawing.Point(22, 106);
            this.LeasingCheckBox.Name = "LeasingCheckBox";
            this.LeasingCheckBox.Size = new System.Drawing.Size(63, 17);
            this.LeasingCheckBox.TabIndex = 5;
            this.LeasingCheckBox.Text = "Leasing";
            this.LeasingCheckBox.UseVisualStyleBackColor = true;
            // 
            // EstadoComboBox
            // 
            this.EstadoComboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(45)))), ((int)(((byte)(60)))));
            this.EstadoComboBox.ForeColor = System.Drawing.Color.White;
            this.EstadoComboBox.FormattingEnabled = true;
            this.EstadoComboBox.Items.AddRange(new object[] {
            "Habilitado",
            "Deshabilitado"});
            this.EstadoComboBox.Location = new System.Drawing.Point(71, 138);
            this.EstadoComboBox.Name = "EstadoComboBox";
            this.EstadoComboBox.Size = new System.Drawing.Size(216, 21);
            this.EstadoComboBox.TabIndex = 1;
            this.EstadoComboBox.Text = "Habilitado";
            this.EstadoComboBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.EstadoComboBox_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 141);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Estado";
            // 
            // ArticuloComboBox
            // 
            this.ArticuloComboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(45)))), ((int)(((byte)(60)))));
            this.ArticuloComboBox.ForeColor = System.Drawing.Color.White;
            this.ArticuloComboBox.FormattingEnabled = true;
            this.ArticuloComboBox.Items.AddRange(new object[] {
            ""});
            this.ArticuloComboBox.Location = new System.Drawing.Point(71, 38);
            this.ArticuloComboBox.Name = "ArticuloComboBox";
            this.ArticuloComboBox.Size = new System.Drawing.Size(216, 21);
            this.ArticuloComboBox.TabIndex = 1;
            this.ArticuloComboBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.EstadoComboBox_KeyPress);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(18, 41);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(47, 13);
            this.label13.TabIndex = 0;
            this.label13.Text = "Articulos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Placa";
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Location = new System.Drawing.Point(338, 114);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(33, 13);
            this.lbl2.TabIndex = 0;
            this.lbl2.Text = "Serial";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(329, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Modelo";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(334, 43);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(37, 13);
            this.label14.TabIndex = 0;
            this.label14.Text = "Marca";
            // 
            // PlacaTextBox
            // 
            this.PlacaTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(45)))), ((int)(((byte)(60)))));
            this.PlacaTextBox.ForeColor = System.Drawing.Color.White;
            this.PlacaTextBox.Location = new System.Drawing.Point(71, 74);
            this.PlacaTextBox.Name = "PlacaTextBox";
            this.PlacaTextBox.Size = new System.Drawing.Size(216, 20);
            this.PlacaTextBox.TabIndex = 3;
            this.PlacaTextBox.TextChanged += new System.EventHandler(this.PlacaTextBox_TextChanged);
            this.PlacaTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PlacaTextBox_KeyPress);
            this.PlacaTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.PlacaTextBox_Validating);
            // 
            // SerialTextBox
            // 
            this.SerialTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(45)))), ((int)(((byte)(60)))));
            this.SerialTextBox.ForeColor = System.Drawing.Color.White;
            this.SerialTextBox.Location = new System.Drawing.Point(377, 111);
            this.SerialTextBox.Name = "SerialTextBox";
            this.SerialTextBox.Size = new System.Drawing.Size(216, 20);
            this.SerialTextBox.TabIndex = 3;
            // 
            // ModeloTextBox
            // 
            this.ModeloTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(45)))), ((int)(((byte)(60)))));
            this.ModeloTextBox.ForeColor = System.Drawing.Color.White;
            this.ModeloTextBox.Location = new System.Drawing.Point(377, 75);
            this.ModeloTextBox.Name = "ModeloTextBox";
            this.ModeloTextBox.Size = new System.Drawing.Size(216, 20);
            this.ModeloTextBox.TabIndex = 3;
            // 
            // MarcaTextBox
            // 
            this.MarcaTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(45)))), ((int)(((byte)(60)))));
            this.MarcaTextBox.ForeColor = System.Drawing.Color.White;
            this.MarcaTextBox.Location = new System.Drawing.Point(377, 39);
            this.MarcaTextBox.Name = "MarcaTextBox";
            this.MarcaTextBox.Size = new System.Drawing.Size(216, 20);
            this.MarcaTextBox.TabIndex = 3;
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(45)))), ((int)(((byte)(60)))));
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(97)))), ((int)(((byte)(216)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(0, 3, 0, 3);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.DoubleBuffered = true;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(97)))), ((int)(((byte)(216)))));
            this.dataGridView1.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(97)))), ((int)(((byte)(216)))));
            this.dataGridView1.HeaderForeColor = System.Drawing.Color.White;
            this.dataGridView1.Location = new System.Drawing.Point(24, 269);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.Padding = new System.Windows.Forms.Padding(0, 2, 0, 2);
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView1.RowHeadersWidth = 10;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(607, 136);
            this.dataGridView1.TabIndex = 1012;
            this.dataGridView1.VirtualMode = true;
            // 
            // BtnEliminarRegistro
            // 
            this.BtnEliminarRegistro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEliminarRegistro.Image = ((System.Drawing.Image)(resources.GetObject("BtnEliminarRegistro.Image")));
            this.BtnEliminarRegistro.Location = new System.Drawing.Point(654, 267);
            this.BtnEliminarRegistro.Name = "BtnEliminarRegistro";
            this.BtnEliminarRegistro.Size = new System.Drawing.Size(65, 65);
            this.BtnEliminarRegistro.TabIndex = 1013;
            this.BtnEliminarRegistro.UseVisualStyleBackColor = true;
            this.BtnEliminarRegistro.Click += new System.EventHandler(this.BtnEliminarRegistro_Click);
            // 
            // BtnTerminar
            // 
            this.BtnTerminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnTerminar.Image = ((System.Drawing.Image)(resources.GetObject("BtnTerminar.Image")));
            this.BtnTerminar.Location = new System.Drawing.Point(654, 29);
            this.BtnTerminar.Name = "BtnTerminar";
            this.BtnTerminar.Size = new System.Drawing.Size(60, 60);
            this.BtnTerminar.TabIndex = 1014;
            this.BtnTerminar.UseVisualStyleBackColor = true;
            this.BtnTerminar.Click += new System.EventHandler(this.BtnTerminar_Click);
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("BtnCancelar.Image")));
            this.BtnCancelar.Location = new System.Drawing.Point(654, 105);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(60, 60);
            this.BtnCancelar.TabIndex = 1015;
            this.BtnCancelar.UseVisualStyleBackColor = true;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.BtnCancelar);
            this.panel1.Controls.Add(this.BtnTerminar);
            this.panel1.Controls.Add(this.BtnEliminarRegistro);
            this.panel1.Controls.Add(this.DatosGroupBox);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(792, 430);
            this.panel1.TabIndex = 1016;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // AsignarHardware
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(45)))), ((int)(((byte)(60)))));
            this.ClientSize = new System.Drawing.Size(792, 430);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AsignarHardware";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AsignarHardware";
            this.Load += new System.EventHandler(this.AsignarHardware_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.AsignarHardware_KeyDown);
            this.DatosGroupBox.ResumeLayout(false);
            this.DatosGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox DatosGroupBox;
        private System.Windows.Forms.CheckBox LeasingCheckBox;
        private System.Windows.Forms.ComboBox EstadoComboBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox ArticuloComboBox;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox PlacaTextBox;
        private System.Windows.Forms.TextBox SerialTextBox;
        private System.Windows.Forms.TextBox ModeloTextBox;
        private System.Windows.Forms.TextBox MarcaTextBox;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuCustomDataGrid dataGridView1;
        private System.Windows.Forms.Button BtnEliminarRegistro;
        private System.Windows.Forms.Button BtnTerminar;
        private System.Windows.Forms.Button BtnCancelar;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button BtnAñadir;
        private System.Windows.Forms.Panel panel1;
    }
}