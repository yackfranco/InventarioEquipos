using Datos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class BuscarEquipo : Form
    {
        public BuscarEquipo()
        {
            InitializeComponent();
        }

        private void TBuscarTextBox_TextChanged(object sender, EventArgs e)
        {
            traerEquipo();
        }

        public void traerEquipo()
        {
            if (TBuscarTextBox.Text == "")
            {
                TraerTodosLosEquipos();
            }
            else
            {
                DataTable tabla = new DataTable();
                Class1.HacerConsulta("select Placa,Marca,Serial,CorreoCorporativo from Equipo where " + BuscarTomboBox.Text + " LIKE '%" + TBuscarTextBox.Text + "%' and Estado = 'Habilitado'");
                Class1.comando.ExecuteNonQuery();
                SqlDataAdapter adaptador = new SqlDataAdapter(Class1.comando);
                tabla.Clear();
                adaptador.Fill(tabla);
                dataGridView1.DataSource = tabla;
            }
        }

        public void TraerTodosLosEquipos()
        {
            DataTable tabla = new DataTable();
            Class1.HacerConsulta("select Placa,Marca,Serial,CorreoCorporativo,Estado from Equipo WHERE Estado = 'Habilitado'");
            Class1.comando.ExecuteNonQuery();
            SqlDataAdapter adaptador = new SqlDataAdapter(Class1.comando);
            tabla.Clear();
            adaptador.Fill(tabla);
            dataGridView1.DataSource = tabla;
        }

        private void BuscarEquipo_Load(object sender, EventArgs e)
        {
            TraerTodosLosEquipos();
            TBuscarTextBox.Focus();
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            DataTable tabla = new DataTable();
            Class1.HacerConsulta("select * from Equipo where Placa = '" + dataGridView1.CurrentRow.Cells[0].Value.ToString() + "'");
            SqlDataAdapter adaptador = new SqlDataAdapter(Class1.comando);
            tabla.Clear();
            adaptador.Fill(tabla);
            Class1.conexion.Close();
            Class1.tablaBuscarEquipo = tabla;
            Class1.devolverBusqueda = true;
            this.Close();
        }

        private void BuscarTomboBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
    }
}
