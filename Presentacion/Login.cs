using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.Data.SqlClient;
using Datos;


namespace Presentacion
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        //funcion para no cerrar la ventana con alt + f4
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            return keyData == (Keys.Alt | Keys.F4);
        }

        private void CedulaTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) || char.IsControl(e.KeyChar))
            {
                e.Handled = false;
                if (e.KeyChar == Convert.ToChar(Keys.Enter))
                    ContraseñaTextBox.Focus();
            }

            else
                e.Handled = true;
        }

        private void Login_Load(object sender, EventArgs e)
        {
            Class1.HacerConsulta("select Usuario from Usuario");
            Class1.lector =  Class1.comando.ExecuteReader();
            while(Class1.lector.Read())
            {
                UsuarioCombobox.Items.Add(Class1.lector["Usuario"].ToString());
            }
        }


        public string hash = "";
        private void Entrarbutton_Click(object sender, EventArgs e)
        {
            if (UsuarioCombobox.Text != string.Empty && ContraseñaTextBox.Text != string.Empty)
            {
                string source = ContraseñaTextBox.Text;
                using (MD5 md5Hash = MD5.Create())
                {
                    hash = GetMd5Hash(md5Hash, source);
                }
                Datos.Class1.HacerConsulta("select * from Usuario where Usuario = '" + UsuarioCombobox.Text + "' and Contraseña = '" + hash + "'");
                SqlDataReader adaptador = null;
                adaptador = Datos.Class1.comando.ExecuteReader();
                if (adaptador.HasRows)
                {
                    this.Hide();
                    var m = new Menu();
                    m.ShowDialog();
                }
                else
                    MessageBox.Show("La contraseña del Usuario "+UsuarioCombobox.Text+" es incorrecta","ATENCION",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Llene los campos requeridos");
            }

        }

        static string GetMd5Hash(MD5 md5Hash, string input)
        {

            // Convert the input string to a byte array and compute the hash.
            byte[] data = md5Hash.ComputeHash(Encoding.UTF8.GetBytes(input));

            // Create a new Stringbuilder to collect the bytes
            // and create a string.
            StringBuilder sBuilder = new StringBuilder();

            // Loop through each byte of the hashed data 
            // and format each one as a hexadecimal string.
            for (int i = 0; i < data.Length; i++)
            {
                sBuilder.Append(data[i].ToString("x2"));
            }

            // Return the hexadecimal string.
            return sBuilder.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }



        private void ContraseñaTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                Entrarbutton_Click(sender, e);
            }
        }

        private void UsuarioCombobox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ContraseñaTextBox.Focus();
            }
        }

        private void bunifuGradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelTitulo_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Login_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.ToString() == "Escape")
                Application.Exit();
        }


    }
}
