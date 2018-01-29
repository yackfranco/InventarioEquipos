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
    public partial class Dependencias : Form
    {
        public Dependencias()
        {
            InitializeComponent();
        }
        public string accion2 = "";
        private void Dependencias_Load(object sender, EventArgs e)
        {
            this.Location = new Point(200, 50);
            indenpendenciaBindingSource.DataSource = Class1.devolverTabla("select * from Indenpendencia");
            JuegoBotones2();
            Diseño();
        }

        public void Diseño()
        {
            panel1.Left = (this.Width - panel1.Width) / 2;
            panel1.Top = (this.Height - panel1.Height) / 2;
        }

        public void JuegoBotones2()
        {
            if (indenpendenciaBindingSource.Count > 0)
            {
                BtnNuevo2.Enabled = true;
                BtnGuardar2.Enabled = false;
                BtnCancelar2.Enabled = false;
                BtnEditar2.Enabled = true;
                BtnEliminar2.Enabled = true;
                BtnBuscar2.Enabled = true;
            }
            else
            {
                BtnNuevo2.Enabled = true;
                BtnGuardar2.Enabled = false;
                BtnCancelar2.Enabled = false;
                BtnEditar2.Enabled = false;
                BtnEliminar2.Enabled = false;
                BtnBuscar2.Enabled = false;
            }
        }

        public void NewOrUpdate2(string accion)
        {
            panelDatos2.Enabled = true;
            BtnNuevo2.Enabled = false;
            BtnGuardar2.Enabled = true;
            BtnCancelar2.Enabled = true;
            BtnEditar2.Enabled = false;
            BtnEliminar2.Enabled = false;
            BtnBuscar2.Enabled = false;
            if (accion == "nuevo")
            {

                //Se limpian todos los campos y se crea espacio en memoria
                indenpendenciaBindingSource.AddNew();
                //Se le indica al programa que la accion que va realizar es hacer un insert para poder guardarlo
                accion2 = "BtnNuevo";
                nombreIndependenciaTextBox.Focus();
            }
            else
            {
                //Se le indica al programa que la accion que va realizar es hacer un insert para poder guardarlo
                accion2 = "BtnEditar";
                nombreIndependenciaTextBox.Focus();
            }
        }

        private void BtnNuevo2_Click(object sender, EventArgs e)
        {
            NewOrUpdate2("nuevo");
        }

        private void BtnGuardar2_Click(object sender, EventArgs e)
        {
            if (nombreIndependenciaTextBox.Text != string.Empty)
            {
                try
                {
                    if (accion2 == "BtnNuevo")
                    {
                        //Datos.Class1.TAIndependencia.Insert(nombreIndependenciaTextBox.Text);  
                        Class1.HacerConsulta("INSERT INTO Indenpendencia (NombreIndependencia) VALUES ('" + nombreIndependenciaTextBox.Text + "')");
                        Class1.comando.ExecuteNonQuery();
                        
                        //Datos.Class1.TArestriccion.Insert(Class1.devolverId("Select IdIndependencia as n from Indenpendencia where NombreIndependencia = '" + nombreIndependenciaTextBox.Text + "'"), "True", "True", "True", "True", "", "True", "True", "True", "True", "True", "True", "True", "True");
                        Class1.HacerConsulta("INSERT INTO Restriccion (IdIndependencia, Google, Youtube, Hotmail, Facebook, Otro, InicioSesion, IClubSQL, ICajaSQL, IRecepcionSQL, IContabilidadLIFE, IParqueadero, ICorreoI, INomina) VALUES        (" + Class1.devolverId("Select IdIndependencia as n from Indenpendencia where NombreIndependencia = '" + nombreIndependenciaTextBox.Text + "'") + ", 'True', 'True', 'True', 'True', '', 'False', 'False', 'False', 'False', 'False', 'False', 'False', 'False')");
                        Class1.comando.ExecuteNonQuery();

                        indenpendenciaBindingSource.EndEdit();
                        MessageBox.Show("Independencia Guardada Correctamente");
                    }
                    else
                    {
                        //Datos.Class1.TAIndependencia.Update(nombreIndependenciaTextBox.Text, Convert.ToInt32(idIndependenciaTextBox.Text));
                        Class1.HacerConsulta("UPDATE       Indenpendencia SET                NombreIndependencia = '"+nombreIndependenciaTextBox.Text+"' WHERE        (IdIndependencia = "+idIndependenciaTextBox.Text+")");
                        Class1.comando.ExecuteNonQuery();
                        MessageBox.Show("Independencia Editada Correctamente");
                    }
                    panelDatos2.Enabled = false;
                    JuegoBotones2();
                    indenpendenciaBindingSource.DataSource = Class1.devolverTabla("select * from Indenpendencia");
                }
                catch (Exception)
                {
                }
            }
            else
            {
                MessageBox.Show("Llene los campos requeridos");
            }
        }

        private void BtnCancelar2_Click(object sender, EventArgs e)
        {
            panelDatos2.Enabled = false;
            indenpendenciaBindingSource.CancelEdit();
            JuegoBotones2();
        }

        private void BtnEditar2_Click(object sender, EventArgs e)
        {
            NewOrUpdate2("Editar");
        }

        private void BtnEliminar2_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show(" Desea Eliminar La Independencia " + nombreIndependenciaTextBox.Text + " ?", "Eliminar Cargo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    //Datos.Class1.TAIndependencia.Delete(Convert.ToInt32(idIndependenciaTextBox.Text));
                    Class1.HacerConsulta("DELETE FROM Indenpendencia WHERE        (IdIndependencia = "+idIndependenciaTextBox.Text+")");
                    Class1.comando.ExecuteNonQuery();
                    indenpendenciaBindingSource.DataSource = Class1.devolverTabla("select * from Indenpendencia");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("No se puede eliminar la Independencia porque hay una o mas Personas asignada a esta");
            }
        }

        private void BtnBuscar2_Click(object sender, EventArgs e)
        {
            int fila = 0;
            string texto = "";
            texto = Interaction.InputBox("Buscar por Nombre de Dependencia", "Busar", "", -1, -1);
            if (texto != "")
            {
                fila = indenpendenciaBindingSource.Find("NombreIndependencia", texto);
                if (fila != -1)
                {
                    indenpendenciaBindingSource.Position = fila;
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

        private void nombreIndependenciaTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                BtnGuardar2_Click(sender, e);
            }
        }

        private void Dependencias_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.ToString() == "Escape")
                this.Close();
        }
    }
}
