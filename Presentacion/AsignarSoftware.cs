using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Datos;
using System.Collections;

namespace Presentacion
{
    public partial class AsignarSoftware : Form
    {
        public AsignarSoftware()
        {
            InitializeComponent();
        }
        public E_software ESoftware;
        private void button1_Click(object sender, EventArgs e)
        {
            if (TipoDeSoftwareComboBox.Text == string.Empty || NombreDelSoftwareTextBox.Text == string.Empty)
            {
                MessageBox.Show("Llene los campos requeridos");
                return;
            }

            if (!ValidarDGV(TipoDeSoftwareComboBox.Text))
            {
                MessageBox.Show("El tipo de software ya esta registrado");
                return;
            }
            if (Class1.EditarEquipo == "Editar")
            {
                int idTipoSoftware = Class1.devolverId("Select IdTipoSoftware as n from TipoSoftware Where NombreTipo = '" + TipoDeSoftwareComboBox.Text + "'");
                Class1.HacerConsulta("insert into Software (IdEquipo,IdTipoSoftware,NombreSoftware) values (" + Class1.idEquipoEditar + "," + idTipoSoftware + ",'" + NombreDelSoftwareTextBox.Text + "')");
                Class1.comando.ExecuteNonQuery();
            }

            ESoftware = new E_software();
            ESoftware.TipoSoftware = TipoDeSoftwareComboBox.Text;
            ESoftware.NombreSoftware = NombreDelSoftwareTextBox.Text;
            Class1.Relacion.agregarSoftware(ESoftware);
            cargarTabla();
            LimpiarDatos();
        }

        public void LimpiarDatos()
        {
            NombreDelSoftwareTextBox.Text = string.Empty;
            TipoDeSoftwareComboBox.Focus();
        }

        public void cargarTabla()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = Class1.Relacion._E_Software;
        }

        public Boolean ValidarDGV(string texto)
        {
            int a = 0;
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                string b = dataGridView1.Rows[i].Cells[0].Value.ToString();
                if (b == texto)
                {
                    a++;
                }
            }
            if (a > 0)
                return false;
            else
                return true;
        }

        private void BtnEliminarRegistro_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null)
                MessageBox.Show("no ha seleccionado nada");
            else
            {
                //int a = dataGridView1.CurrentRow.Index;
                //MessageBox.Show(a.ToString());

                if (Class1.EditarEquipo == "Editar")
                {
                    Class1.HacerConsulta("DELETE FROM Software WHERE (IdEquipo = " + Class1.idEquipoEditar + ") AND (IdTipoSoftware = " + Class1.devolverId("select IdTipoSoftware as n from TipoSoftware where NombreTipo = '" + dataGridView1.CurrentRow.Cells[0].Value.ToString() + "'") + ")");
                    Class1.lector = Class1.comando.ExecuteReader();
                }
                    

                Class1.Relacion._E_Software.RemoveAt(dataGridView1.CurrentRow.Index);
                cargarTabla();
            }

            //ESoftware  
            //dataGridView1.Rows.Remove(dataGridView1.CurrentRow);
        }

        private void AsignarSoftware_Load(object sender, EventArgs e)
        {
            TipoDeSoftwareComboBox.Items.Clear();
            Class1.HacerConsulta("select NombreTipo as n from TipoSoftware");
            Class1.lector = Class1.comando.ExecuteReader();
            while (Class1.lector.Read())
            {
                TipoDeSoftwareComboBox.Items.Add(Class1.lector["n"].ToString());
            }
            TipoDeSoftwareComboBox.Text = TipoDeSoftwareComboBox.Items[0].ToString();
            Class1.conexion.Close();

            if (Class1.Relacion._E_Software.Count > 0)
                dataGridView1.DataSource = Class1.Relacion._E_Software;   
        }

        private void TipoDeSoftwareComboBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void BtnTerminar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_MouseClick(object sender, MouseEventArgs e)
        {
            if (Class1.EditarEquipo != "Editar")
                return;

            TipoDeSoftwareComboBox.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            NombreDelSoftwareTextBox.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
        }

        private void AsignarSoftware_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.ToString() == "Escape")
                this.Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
