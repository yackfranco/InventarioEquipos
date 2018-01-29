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

namespace Presentacion
{
    public partial class Administrar_Articulos : Form
    {
        public Administrar_Articulos()
        {
            InitializeComponent();
        }

        public string accion = string.Empty;
        public string accion1 = string.Empty;

        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            NewOrUpdate("nuevo");

        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            panelDatos.Enabled = false;
            articuloBindingSource.CancelEdit();
            JuegoBotones();
        }


        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show(" Desea Eliminar El Articulo " + nombreArticuloTextBox.Text + "", "Eliminar Articulo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    Class1.HacerConsulta("DELETE FROM Articulo WHERE        (IdArticulo = " + Convert.ToInt32(idArticuloTextBox.Text) + ")");
                    Class1.comando.ExecuteNonQuery();
                    articuloBindingSource.EndEdit();
                    articuloBindingSource.DataSource = Class1.devolverTabla("Select * from Articulo");
                    JuegoBotones();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Prohibido Eliminar un Articulo que ya ha sido relacionado con Adicionales", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            NewOrUpdate("Editar");
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            //Se valida de que los campos no esten vacios
            if (nombreArticuloTextBox.Text != string.Empty)
            {
                try
                {
                    if (accion1 == "BtnNuevo")
                    {
                        Class1.HacerConsulta("INSERT INTO Articulo (NombreArticulo) VALUES ('" + nombreArticuloTextBox.Text + "')");
                        Class1.comando.ExecuteNonQuery();
                        articuloBindingSource.EndEdit();
                        MessageBox.Show("Articulo Guardado Correctamente");
                    }
                    else
                    {
                        Class1.HacerConsulta("UPDATE       Articulo SET                NombreArticulo = '" + nombreArticuloTextBox.Text + "' WHERE        (IdArticulo = " + Convert.ToInt32(idArticuloTextBox.Text) + ")");
                        Class1.comando.ExecuteNonQuery();
                        MessageBox.Show("Articulo Editado Correctamente");
                    }
                    panelDatos.Enabled = false;
                    articuloBindingSource.DataSource = Class1.devolverTabla("Select * from Articulo");
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
                articuloBindingSource.AddNew();
                //Se le indica al programa que la accion que va realizar es hacer un insert para poder guardarlo
                accion1 = "BtnNuevo";
                nombreArticuloTextBox.Focus();
            }
            else
            {
                //Se le indica al programa que la accion que va realizar es hacer un insert para poder guardarlo
                accion1 = "BtnEditar";
                nombreArticuloTextBox.Focus();
            }
        }

        public void JuegoBotones()
        {
            if (articuloBindingSource.Count > 0)
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

        private void Administrar_Articulos_Load(object sender, EventArgs e)
        {
            this.Location = new Point(200, 50);
            articuloBindingSource.DataSource = Class1.devolverTabla("Select * from Articulo");
            JuegoBotones();
            Diseño();
        }

        public void Diseño()
        {
            panel1.Left = (this.Width - panel1.Width) / 2;
            panel1.Top = (this.Height - panel1.Height) / 2;

        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            int fila = 0;
            string texto = "";
            texto = Interaction.InputBox("Buscar por Nombre de Articulo", "Busar", "", -1, -1);
            if (texto != "")
            {
                fila = articuloBindingSource.Find("NombreArticulo", texto);
                if (fila != -1)
                {
                    articuloBindingSource.Position = fila;
                }
                else
                {
                    MessageBox.Show("Registro no encontrado");
                }
            }
        }

        private void SalirButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void nombreArticuloTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                BtnGuardar_Click(sender, e);
            }

        }

        private void Administrar_Articulos_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.ToString() == "Escape")
                this.Close();
        }
    }
}
