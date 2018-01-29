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
using System.Data.SqlClient;

namespace Presentacion
{
    public partial class Cargos : Form
    {
        public Cargos()
        {
            InitializeComponent();
        }

        public string accion1 = string.Empty;
        public string accion2 = string.Empty;

        #region CRUDCargo

        private void ConfigurarCargos_Independencias_Load(object sender, EventArgs e)
        {
            this.Location = new Point(200, 50);
            cargoBindingSource.DataSource = Class1.devolverTabla("Select * from Cargo");
            JuegoBotones();
            Diseño();
        }

        public void Diseño()
        {
            panel2.Left = (this.Width - panel2.Width) / 2;
            panel2.Top = (this.Height - panel2.Height) / 2;
        }

        //Esta Funcion maneja los botones los cuales segun la condicion si hay usuarios registrados o no los hay
        public void JuegoBotones()
        {
            if (cargoBindingSource.Count > 0)
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
                cargoBindingSource.AddNew();
                //Se le indica al programa que la accion que va realizar es hacer un insert para poder guardarlo
                accion1 = "BtnNuevo";
                nombreCargoTextBox.Focus();
            }
            else
            {
                //Se le indica al programa que la accion que va realizar es hacer un insert para poder guardarlo
                accion1 = "BtnEditar";
                nombreCargoTextBox.Focus();
            }
        }

        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            NewOrUpdate("nuevo");
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            panelDatos.Enabled = false;
            cargoBindingSource.CancelEdit();
            JuegoBotones();
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            //Se valida de que los campos no esten vacios
            if (nombreCargoTextBox.Text != string.Empty)
            {
                try
                {
                    if (accion1 == "BtnNuevo")
                    {
                        Class1.HacerConsulta("INSERT INTO Cargo   (NombreCargo) VALUES        ('" + nombreCargoTextBox.Text + "')");
                        Class1.comando.ExecuteNonQuery();
                        cargoBindingSource.EndEdit();
                        MessageBox.Show("Cargo Guardado Correctamente");
                    }
                    else
                    {

                        Class1.HacerConsulta("UPDATE Cargo SET NombreCargo = '" + nombreCargoTextBox.Text + "' WHERE (IdCargo = " + Convert.ToInt32(idCargoTextBox.Text) + ")");
                        Class1.comando.ExecuteNonQuery();
                        cargoBindingSource.EndEdit();
                        MessageBox.Show("Cargo Editado Correctamente");
                    }
                    panelDatos.Enabled = false;
                    JuegoBotones();
                    cargoBindingSource.DataSource = Class1.devolverTabla("Select * from Cargo");
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

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            try
            {

                if (MessageBox.Show(" Desea Eliminar El Cargo " + nombreCargoTextBox.Text + "", "Eliminar Cargo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {

                    if (0 < Convert.ToInt32(Class1.devolverId("SELECT        COUNT(dbo.Personal.IdPersonal) AS n FROM            dbo.Cargo INNER JOIN                         dbo.Personal ON dbo.Cargo.IdCargo = dbo.Personal.IdCargo WHERE  (dbo.Cargo.idCargo = '" + idCargoTextBox.Text + "')")))
                    {
                        MessageBox.Show("no se puede Eliminar Un Cargo que esta ocupando en el momento un Personal");
                        return;
                    }

                    Class1.HacerConsulta("DELETE FROM Cargo WHERE        (IdCargo = " + Convert.ToInt32(idCargoTextBox.Text) + ")");
                    Class1.comando.ExecuteNonQuery();
                    cargoBindingSource.DataSource = Class1.devolverTabla("Select * from Cargo");
                }
            }
            catch (Exception)
            {
            }
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            NewOrUpdate("Editar");
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            int fila = 0;
            string texto = "";
            texto = Interaction.InputBox("Buscar por Nombre de Cargo", "Busar", "", -1, -1);
            if (texto != "")
            {
                fila = cargoBindingSource.Find("NombreCargo", texto);
                if (fila != -1)
                {
                    cargoBindingSource.Position = fila;
                }
                else
                {
                    MessageBox.Show("Registro no encontrado");
                }
            }
        }
        #endregion

        private void SalirButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void nombreCargoTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                BtnGuardar_Click(sender, e);
            }

        }

        private void Cargos_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.ToString() == "Escape")
                this.Close();
        }
    }
}
