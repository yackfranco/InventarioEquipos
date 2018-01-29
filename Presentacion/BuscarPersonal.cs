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
    public partial class BuscarPersonal : Form
    {
        public BuscarPersonal()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void BuscarPersonal_Load(object sender, EventArgs e)
        {
            Class1.placaAdicional = "";
            dataGridView1.DataSource = Class1.devolverTabla("SELECT Cedula,CONCAT( PrimerNombre,' ', SegundoNombre,' ', PrimerApellido,' ', SegundoApellido) as NombreCompleto FROM dbo.Personal where dbo.Personal.Estado = 'Habilitado'");
        }

        private void BuscarTextBox_TextChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = Class1.devolverTabla("SELECT        Cedula,CONCAT( PrimerNombre,' ', SegundoNombre,' ', PrimerApellido,' ', SegundoApellido) as NombreCompleto FROM            dbo.Personal where dbo.Personal.Cedula =  '" + BuscarTextBox.Text + "%' and dbo.Personal.Estado = 'Habilitado' ");
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            Datos.Class1.cedulapersonal = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            this.Close();
        }
    }
}
