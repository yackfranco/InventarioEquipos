using Datos;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class ConfigurarTipoSoftware : Form
    {
        public ConfigurarTipoSoftware()
        {
            InitializeComponent();
        }

        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            NewOrUpdate("nuevo");
        }

        public string accion1 = string.Empty;


        public void NewOrUpdate(string accion)
        {
            panelDatos.Enabled = true;
            BtnNuevo.Enabled = false;
            BtnGuardar.Enabled = true;
            BtnCancelar.Enabled = true;
            BtnEditar.Enabled = false;
            BtnEliminar.Enabled = false;
            BtnBuscar.Enabled = false;
            if (accion == "nuevo")
            {

                //Se limpian todos los campos y se crea espacio en memoria
                tipoSoftwareBindingSource.AddNew();
                //Se le indica al programa que la accion que va realizar es hacer un insert para poder guardarlo
                accion1 = "BtnNuevo";
                nombreTipoTextBox.Focus();
            }
            else
            {
                //Se le indica al programa que la accion que va realizar es hacer un insert para poder guardarlo
                accion1 = "BtnEditar";
                nombreTipoTextBox.Focus();
            }
        }

        public void JuegoBotones()
        {
            if (tipoSoftwareBindingSource.Count > 0)
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

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            //Se valida de que los campos no esten vacios
            if (nombreTipoTextBox.Text != string.Empty)
            {
                try
                {
                    if (accion1 == "BtnNuevo")
                    {
                        Class1.HacerConsulta("INSERT INTO TipoSoftware                          (NombreTipo) VALUES        ('" + nombreTipoTextBox.Text + "')");
                        Class1.comando.ExecuteNonQuery();

                        tipoSoftwareBindingSource.EndEdit();
                        MessageBox.Show("Tipo de software Guardado Correctamente");
                    }
                    else
                    {
                        Datos.Class1.TATipoSoftware.Update(nombreTipoTextBox.Text, Convert.ToInt32(idTipoSoftwareTextBox.Text));
                        Class1.HacerConsulta("UPDATE       TipoSoftware SET                NombreTipo = '"+nombreTipoTextBox.Text+"' WHERE        (IdTipoSoftware = "+idTipoSoftwareTextBox.Text+")");
                        Class1.comando.ExecuteNonQuery();
                        MessageBox.Show("Tipo de software Editado Correctamente");
                    }
                    panelDatos.Enabled = false;
                    tipoSoftwareBindingSource.DataSource = Class1.devolverTabla("select * from TipoSoftware");            
                    JuegoBotones();
                }
                catch (Exception)
                {
                    MessageBox.Show("Error al Guardar");
                }
            }
            else
            {
                MessageBox.Show("Llene los campos requeridos");
            }
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            panelDatos.Enabled = false;
            tipoSoftwareBindingSource.CancelEdit();
            JuegoBotones();
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            NewOrUpdate("Editar");
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show(" Desea Eliminar El Tipo de Software " + nombreTipoTextBox.Text + "", "Eliminar Tipo de Software", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                  //  Datos.Class1.TATipoSoftware.Delete(Convert.ToInt32(idTipoSoftwareTextBox.Text));
                    Class1.HacerConsulta("DELETE FROM TipoSoftware WHERE        (IdTipoSoftware = "+idTipoSoftwareTextBox.Text+")");
                    Class1.comando.ExecuteNonQuery();
                    tipoSoftwareBindingSource.DataSource = Class1.devolverTabla("select * from TipoSoftware");            
                    JuegoBotones();
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
            texto = Interaction.InputBox("Buscar por Nombre del Tipo de Software", "Busar", "", -1, -1);
            if (texto != "")
            {
                fila = tipoSoftwareBindingSource.Find("NombreTipo", texto);
                if (fila != -1)
                {
                    tipoSoftwareBindingSource.Position = fila;
                }
                else
                {
                    MessageBox.Show("Registro no encontrado");
                }
            }
        }

        private void ConfigurarTipoSoftware_Load(object sender, EventArgs e)
        {
            this.Location = new Point(200, 50);
            Diseño();
            tipoSoftwareBindingSource.DataSource = Class1.devolverTabla("select * from TipoSoftware");            
            JuegoBotones();
        }

        public void Diseño()
        {
            panel1.Left = (this.Width - panel1.Width) / 2;
            panel1.Top = (this.Height - panel1.Height) / 2;
        }

        private void SalirButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void nombreTipoTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                BtnGuardar_Click(sender,e);
            }

        }

        private void ConfigurarTipoSoftware_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.ToString() == "Escape")
                this.Close();
        }
    }
}
