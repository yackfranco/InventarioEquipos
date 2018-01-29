namespace Presentacion
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panelTitulo = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.bunifuGradientPanel1 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.UsuarioCombobox = new System.Windows.Forms.ComboBox();
            this.Entrarbutton = new Bunifu.Framework.UI.BunifuFlatButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ContraseñaTextBox = new System.Windows.Forms.TextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.panelTitulo.SuspendLayout();
            this.bunifuGradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 70;
            this.bunifuElipse1.TargetControl = this;
            // 
            // panelTitulo
            // 
            this.panelTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(64)))), ((int)(((byte)(128)))));
            this.panelTitulo.Controls.Add(this.label1);
            resources.ApplyResources(this.panelTitulo, "panelTitulo");
            this.panelTitulo.Name = "panelTitulo";
            this.panelTitulo.Paint += new System.Windows.Forms.PaintEventHandler(this.panelTitulo_Paint);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Name = "label1";
            // 
            // bunifuGradientPanel1
            // 
            resources.ApplyResources(this.bunifuGradientPanel1, "bunifuGradientPanel1");
            this.bunifuGradientPanel1.Controls.Add(this.UsuarioCombobox);
            this.bunifuGradientPanel1.Controls.Add(this.Entrarbutton);
            this.bunifuGradientPanel1.Controls.Add(this.label3);
            this.bunifuGradientPanel1.Controls.Add(this.label2);
            this.bunifuGradientPanel1.Controls.Add(this.pictureBox1);
            this.bunifuGradientPanel1.Controls.Add(this.ContraseñaTextBox);
            this.bunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(48)))));
            this.bunifuGradientPanel1.GradientBottomRight = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(48)))));
            this.bunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(48)))));
            this.bunifuGradientPanel1.GradientTopRight = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(48)))));
            this.bunifuGradientPanel1.Name = "bunifuGradientPanel1";
            this.bunifuGradientPanel1.Quality = 10;
            this.bunifuGradientPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.bunifuGradientPanel1_Paint);
            // 
            // UsuarioCombobox
            // 
            this.UsuarioCombobox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.UsuarioCombobox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.UsuarioCombobox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(48)))));
            resources.ApplyResources(this.UsuarioCombobox, "UsuarioCombobox");
            this.UsuarioCombobox.ForeColor = System.Drawing.Color.White;
            this.UsuarioCombobox.FormattingEnabled = true;
            this.UsuarioCombobox.Name = "UsuarioCombobox";
            this.UsuarioCombobox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.UsuarioCombobox_KeyDown);
            // 
            // Entrarbutton
            // 
            this.Entrarbutton.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(64)))), ((int)(((byte)(128)))));
            this.Entrarbutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(64)))), ((int)(((byte)(128)))));
            resources.ApplyResources(this.Entrarbutton, "Entrarbutton");
            this.Entrarbutton.BorderRadius = -35;
            this.Entrarbutton.ButtonText = "";
            this.Entrarbutton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Entrarbutton.DisabledColor = System.Drawing.Color.Gray;
            this.Entrarbutton.Iconcolor = System.Drawing.Color.Transparent;
            this.Entrarbutton.Iconimage = ((System.Drawing.Image)(resources.GetObject("Entrarbutton.Iconimage")));
            this.Entrarbutton.Iconimage_right = null;
            this.Entrarbutton.Iconimage_right_Selected = null;
            this.Entrarbutton.Iconimage_Selected = null;
            this.Entrarbutton.IconMarginLeft = 50;
            this.Entrarbutton.IconMarginRight = 0;
            this.Entrarbutton.IconRightVisible = true;
            this.Entrarbutton.IconRightZoom = 0D;
            this.Entrarbutton.IconVisible = true;
            this.Entrarbutton.IconZoom = 120D;
            this.Entrarbutton.IsTab = false;
            this.Entrarbutton.Name = "Entrarbutton";
            this.Entrarbutton.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(64)))), ((int)(((byte)(128)))));
            this.Entrarbutton.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(23)))), ((int)(((byte)(73)))));
            this.Entrarbutton.OnHoverTextColor = System.Drawing.Color.White;
            this.Entrarbutton.selected = false;
            this.Entrarbutton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Entrarbutton.Textcolor = System.Drawing.Color.White;
            this.Entrarbutton.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.toolTip1.SetToolTip(this.Entrarbutton, resources.GetString("Entrarbutton.ToolTip"));
            this.Entrarbutton.Click += new System.EventHandler(this.Entrarbutton_Click);
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Name = "label3";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Name = "label2";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            // 
            // ContraseñaTextBox
            // 
            this.ContraseñaTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(48)))));
            resources.ApplyResources(this.ContraseñaTextBox, "ContraseñaTextBox");
            this.ContraseñaTextBox.ForeColor = System.Drawing.Color.White;
            this.ContraseñaTextBox.Name = "ContraseñaTextBox";
            this.ContraseñaTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ContraseñaTextBox_KeyPress);
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.panelTitulo;
            this.bunifuDragControl1.Vertical = true;
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            resources.ApplyResources(this.button1, "button1");
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(23)))), ((int)(((byte)(73)))));
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(23)))), ((int)(((byte)(73)))));
            this.button1.Name = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Login
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(64)))), ((int)(((byte)(128)))));
            this.CancelButton = this.button1;
            this.ControlBox = false;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.bunifuGradientPanel1);
            this.Controls.Add(this.panelTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Login_KeyDown);
            this.panelTitulo.ResumeLayout(false);
            this.panelTitulo.PerformLayout();
            this.bunifuGradientPanel1.ResumeLayout(false);
            this.bunifuGradientPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel panelTitulo;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel1;
        private Bunifu.Framework.UI.BunifuFlatButton Entrarbutton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox ContraseñaTextBox;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ComboBox UsuarioCombobox;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private System.Windows.Forms.Button button1;

    }
}