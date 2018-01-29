using Datos;
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
    public partial class AsignarHardware : Form
    {
        public AsignarHardware()
        {
            InitializeComponent();
        }
        public E_Hardware EHardware;

        private void BtnAñadir_Click(object sender, EventArgs e)
        {
            
            if (!validarCampos())
            {
                MessageBox.Show("Llene los campos requeridos");
                return;
            }

            if (!ValidarDGV(ArticuloComboBox.Text))
            {
                MessageBox.Show("El Adicional ya esta registrado");
                return;
            }

            //dataGridView1.Rows.Add(ArticuloComboBox.Text, PlacaTextBox.Text, MarcaTextBox.Text, ModeloTextBox.Text, SerialTextBox.Text, DesicionLeasing(LeasingCheckBox.Checked), EstadoComboBox.Text);
            E_Hardware EHardware = new E_Hardware();
            EHardware.articulo = ArticuloComboBox.Text;
            EHardware.Estado = EstadoComboBox.Text;
            EHardware.leasing = DesicionLeasing(LeasingCheckBox.Checked);
            EHardware.Marca = MarcaTextBox.Text;
            EHardware.Modelo = ModeloTextBox.Text;
            EHardware.Placa = Convert.ToInt32(PlacaTextBox.Text);
            EHardware.Serial = SerialTextBox.Text;
            Class1.Relacion._E_Hardware.Add(EHardware);
            limpiarcampos();
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = Class1.Relacion._E_Hardware;
        }

        public string DesicionLeasing(Boolean a)
        {
            if (a)
                return "Si";
            else
                return "No";
        }

        public Boolean validarCampos()
        {
            int contador = 0;
            foreach (Control item in DatosGroupBox.Controls)
            {
                if (item is TextBox || item is ComboBox)
                {
                    if (item.Text != "")
                    {
                        contador++;
                    }
                }
            }
            if (contador == 6)
                return true;
            else
                return false;
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

        private void BtnTerminar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.RowCount > 0)
            {
                DataTable dt1 = new DataTable();
                foreach (DataGridViewColumn columna in this.dataGridView1.Columns)
                {
                    DataColumn col = new DataColumn(columna.Name);
                    dt1.Columns.Add(col);
                }
                //Recorrer filas
                foreach (DataGridViewRow fila in this.dataGridView1.Rows)
                {
                    DataRow dr = dt1.NewRow();
                    for (int i = 0; i <= dt1.Columns.Count - 1; i++)
                    {
                        dr[i] = fila.Cells[i].Value.ToString();
                    }
                    dt1.Rows.Add(dr);
                }
                Class1.tabla = dt1;
            }
            this.Close();
        }

        private void limpiarcampos()
        {
            foreach (Control item in DatosGroupBox.Controls)
            {
                if (item is TextBox)
                    item.Text = string.Empty;
                if(item is CheckBox)
                    LeasingCheckBox.Checked = false;
            }
        }

        private void AsignarHardware_Load(object sender, EventArgs e)
        {
            
            traerArticulos();
            if (Class1.Relacion._E_Hardware.Count > 0)
                dataGridView1.DataSource = Class1.Relacion._E_Hardware;
        }

        private void traerArticulos()
        {
            ArticuloComboBox.Items.Clear();
            Class1.HacerConsulta("select NombreArticulo as n from Articulo");
            Class1.lector = Class1.comando.ExecuteReader();
            while (Class1.lector.Read())
            {
                ArticuloComboBox.Items.Add(Class1.lector["n"].ToString());
            }
            ArticuloComboBox.Text = ArticuloComboBox.Items[0].ToString();
            Class1.conexion.Close();

            if (Class1.Relacion._E_Hardware.Count <= 0)
            {
                EHardware = new E_Hardware();
            }
            else
            {
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = Class1.Relacion._E_Hardware;
            }
        }

        private void EstadoComboBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void BtnEliminarRegistro_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null)
                MessageBox.Show("no ha seleccionado nada");
            else
            {
                int a = dataGridView1.CurrentRow.Index;
                Class1.Relacion._E_Hardware.RemoveAt(a);
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = Class1.Relacion._E_Hardware;
            }
                
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            Class1.tabla = null;
            this.Close();
        }

        private void PlacaTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar))
                e.Handled = false;
            else
                e.Handled = true;
        }

        private void PlacaTextBox_Validating(object sender, CancelEventArgs e)
        {
            Class1.HacerConsulta("Select * from Adicional where Placa = '"+PlacaTextBox.Text+"'");
            Class1.lector = Class1.comando.ExecuteReader();
            if (Class1.lector.HasRows)
            {
                MessageBox.Show("La Placa ya esta registrada en otro Adicional");
                PlacaTextBox.Focus();
                return;
            }
        }

        private void PlacaTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void AsignarHardware_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.ToString() == "Escape")
                this.Close();
        }
    }
}
