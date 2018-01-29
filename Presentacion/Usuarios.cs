using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Datos;
using Microsoft.VisualBasic;
using System.Security.Cryptography;
//using OfficeOpenXml.FormulaParsing.Excel.Functions.RefAndLookup;
using System.Globalization;
using System.Text.RegularExpressions;

namespace Presentacion
{
    public partial class Usuarios : Form
    {
        public Usuarios()
        {
            InitializeComponent();
        }


        public string accion1 = string.Empty;
        public bool invalid = false;
        //Esta Funcion maneja los botones los cuales segun la condicion si hay usuarios registrados o no los hay
        public void JuegoBotones()
        {
            if (usuarioBindingSource.Count > 0)
            {
                BtnNuevo.Enabled = true;
                BtnGuardar.Enabled = false;
                BtnCancelar.Enabled = false;
                BtnEditar.Enabled = true;
                BtnEliminar.Enabled = true;
                BtnBuscar.Enabled = true;
            }
            else
            {
                BtnNuevo.Enabled = true;
                BtnGuardar.Enabled = false;
                BtnCancelar.Enabled = false;
                BtnEditar.Enabled = false;
                BtnEliminar.Enabled = false;
                BtnBuscar.Enabled = false;
            }
        }

        private void Usuarios_Load(object sender, EventArgs e)
        {
            this.Location = new Point(200, 50);
            //con esta funcion del DataSet se carga en memoria todos los registros
            usuarioBindingSource.DataSource = Class1.devolverTabla("Select * from Usuario");
            //se llama la funcion para controlar los botones 
            JuegoBotones();
            Diseño();
        }

        public void Diseño()
        {
            panel1.Left = (this.Width - panel1.Width) / 2;
            panel1.Top = (this.Height - panel1.Height) / 2;
        }

        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            NewOrUpdate("nuevo");
        }


        //Se utiliza este metodo para crear espacio en memoria y limpiar los campos
        public void NewOrUpdate(string accion)
        {
            panelDatos.Enabled = true;
            panelDatos2.Enabled = true;
            BtnNuevo.Enabled = false;
            BtnGuardar.Enabled = true;
            BtnCancelar.Enabled = true;
            BtnEditar.Enabled = false;
            BtnEliminar.Enabled = false;
            BtnBuscar.Enabled = false;
            if (accion == "nuevo")
            {
                //Se activa el campo cedula para crear un nuevo usuario
                cedulaTextBox.Enabled = true;
                cedulaTextBox.Focus();

                //Se limpian todos los campos y se crea espacio en memoria
                usuarioBindingSource.AddNew();
                //Se le indica al programa que la accion que va realizar es hacer un insert para poder guardarlo
                accion1 = "BtnNuevo";
                rolComboBox.Text = "Administrador";
                estadoComboBox.Text = "Habilitado";
            }
            else
            {
                //La cedula no se puede editar asi que se inhabilita
                cedulaTextBox.Enabled = false;
                //Se le indica al programa que la accion que va realizar es hacer un insert para poder guardarlo
                accion1 = "BtnEditar";
            }
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            panelDatos.Enabled = false;
            panelDatos2.Enabled = false;
            usuarioBindingSource.CancelEdit();
            JuegoBotones();
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            NewOrUpdate("Editar");
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public string hash = "";
        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            //Se valida de que los campos no esten vacios
            if (validarCampos())
            {


                if (ConfirmarContraseñaTextBox.Text == contraseñaTextBox.Text)
                {
                    string source = contraseñaTextBox.Text;
                    using (MD5 md5Hash = MD5.Create())
                    {
                        hash = GetMd5Hash(md5Hash, source);
                    }
                    //MessageBox.Show(hash);
                    try
                    {
                        if (accion1 == "BtnNuevo")
                        {
                            //Datos.Class1.TAUsuario.Insert(cedulaTextBox.Text, primerNombreTextBox.Text, segundoNombreTextBox.Text, primerApellidoTextBox.Text, segundoApellidoTextBox.Text, rolComboBox.Text, correoElectronicoTextBox.Text,usuarioTextBox.Text, hash, estadoComboBox.Text);
                            Class1.HacerConsulta("INSERT INTO usuario (Cedula, PrimerNombre, SegundoNombre, PrimerApellido, SegundoApellido, Rol, CorreoElectronico, Usuario, Contraseña, Estado) VALUES        ('" + cedulaTextBox.Text + "', '" + primerNombreTextBox.Text + "', '" + segundoNombreTextBox.Text + "', '" + primerApellidoTextBox.Text + "', '" + segundoApellidoTextBox.Text + "', '" + rolComboBox.Text + "', '" + correoElectronicoTextBox.Text + "','" + usuarioTextBox.Text + "', '" + hash + "', '" + estadoComboBox.Text + "')");
                            Class1.comando.ExecuteNonQuery();
                            usuarioBindingSource.EndEdit();
                            MessageBox.Show("Usuario Guardado Correctamente");
                        }
                        else
                        {
                            //Datos.Class1.TAUsuario.Update(cedulaTextBox.Text, primerNombreTextBox.Text, segundoNombreTextBox.Text, primerApellidoTextBox.Text, segundoApellidoTextBox.Text, rolComboBox.Text, correoElectronicoTextBox.Text, usuarioTextBox.Text, hash, estadoComboBox.Text, Convert.ToInt32(idUsuarioTextBox.Text));
                            Class1.HacerConsulta("UPDATE       usuario SET Cedula ='" + cedulaTextBox.Text + "', PrimerNombre = '" + primerNombreTextBox.Text + "', SegundoNombre = '" + segundoNombreTextBox.Text + "', PrimerApellido = '" + primerApellidoTextBox.Text + "',  SegundoApellido = '" + segundoApellidoTextBox.Text + "', Rol = '" + rolComboBox.Text + "', CorreoElectronico = '" + correoElectronicoTextBox.Text + "', Usuario = '" + usuarioTextBox.Text + "', Contraseña = '" + hash + "',  Estado = '" + estadoComboBox.Text + "' WHERE        (IdUsuario = " + idUsuarioTextBox.Text + ")");
                            Class1.comando.ExecuteNonQuery();
                            MessageBox.Show("Usuario Editado Correctamente");
                        }
                        panelDatos.Enabled = false;
                        panelDatos2.Enabled = false;
                        JuegoBotones();
                        usuarioBindingSource.DataSource = Class1.devolverTabla("Select * from Usuario");
                    }
                    catch (Exception)
                    {
                    }
                }
                else
                {
                    MessageBox.Show("Las contraseñas no coinciden");
                }


            }
            else
            {
                MessageBox.Show("LLene por favor todos los campos");
            }
        }

        public Boolean validarCampos()
        {
            if (cedulaTextBox.Text == string.Empty)
            {
                cedulaTextBox.Focus();
                return false;
            }

            if (primerNombreTextBox.Text == string.Empty)
            {
                primerNombreTextBox.Focus();
                return false;
            }
            if (primerApellidoTextBox.Text == string.Empty)
            {
                primerApellidoTextBox.Focus();
                return false;
            }
            if (rolComboBox.Text == string.Empty)
            {
                rolComboBox.Focus();
                return false;
            }
            if (correoElectronicoTextBox.Text == string.Empty)
            {
                correoElectronicoTextBox.Focus();
                return false;
            }
            if (usuarioTextBox.Text == string.Empty)
            {
                usuarioTextBox.Focus();
                return false;
            }
            if (contraseñaTextBox.Text == string.Empty)
            {
                contraseñaTextBox.Focus();
                return false;
            }
            if (ConfirmarContraseñaTextBox.Text == string.Empty)
            {
                ConfirmarContraseñaTextBox.Focus();
                return false;
            }
            if (estadoComboBox.Text == string.Empty)
            {
                estadoComboBox.Focus();
                return false;
            }
            return true;
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show(" Desea Eliminar El usuario con cedula " + cedulaTextBox.Text + " de forma permanente?", "Eliminar", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    Class1.HacerConsulta("DELETE FROM usuario WHERE        (IdUsuario =" + Convert.ToInt32(idUsuarioTextBox.Text) + " )");
                    Class1.comando.ExecuteNonQuery();
                    usuarioBindingSource.DataSource = Class1.devolverTabla("Select * from Usuario");
                }
            }
            catch (Exception)
            {
            }

        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            int fila = 0;
            string texto = "";
            texto = Interaction.InputBox("Buscar por Usuario", "Busar", "", -1, -1);
            if (texto != "")
            {
                fila = usuarioBindingSource.Find("usuario", texto);
                if (fila != -1)
                {
                    usuarioBindingSource.Position = fila;
                }
                else
                {
                    MessageBox.Show("Registro no encontrado");
                }
            }
        }

        private void primerNombreTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) || char.IsSeparator(e.KeyChar) || char.IsControl(e.KeyChar))
                e.Handled = false;
            else
                e.Handled = true;
        }

        private void cedulaTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) || char.IsControl(e.KeyChar))
                e.Handled = false;
            else
                e.Handled = true;
        }

        private void rolComboBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
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

        private void SalirButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Usuarios_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.ToString() == "Escape")
                this.Close();
        }
    }
}
