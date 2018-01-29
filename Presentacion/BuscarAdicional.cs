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

namespace Presentacion
{
    public partial class BuscarAdicional : Form
    {
        public BuscarAdicional()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void BuscarAdicional_Load(object sender, EventArgs e)
        {
            Class1.placaAdicional = "";
            dataGridView1.DataSource = Class1.devolverTabla("SELECT dbo.Adicional.Placa, dbo.Articulo.NombreArticulo, dbo.Adicional.Marca, dbo.Adicional.Modelo, dbo.Adicional.Serial FROM dbo.Adicional INNER JOIN  dbo.Articulo ON dbo.Adicional.IdArticulo = dbo.Articulo.IdArticulo WHERE dbo.Adicional.Estado IS NULL");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //dataGridView1.DataSource = Class1.devolverTabla("SELECT dbo.Adicional.Placa, dbo.Articulo.NombreArticulo, dbo.Adicional.Marca, dbo.Adicional.Modelo, dbo.Adicional.Serial FROM dbo.Adicional INNER JOIN  dbo.Articulo ON dbo.Adicional.IdArticulo = dbo.Articulo.IdArticulo where dbo.Adicional.Placa like '%"+BuscarTextBox.Text+"%'");
        }

        private void BuscarTextBox_TextChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = Class1.devolverTabla("SELECT dbo.Adicional.Placa, dbo.Articulo.NombreArticulo, dbo.Adicional.Marca, dbo.Adicional.Modelo, dbo.Adicional.Serial FROM dbo.Adicional INNER JOIN  dbo.Articulo ON dbo.Adicional.IdArticulo = dbo.Articulo.IdArticulo where dbo.Adicional.Placa like '" + BuscarTextBox.Text + "%' And dbo.Adicional.Estado IS NULL");
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            Datos.Class1.placaAdicional = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            this.Close();
        }
    }
}
