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
    public partial class ASoftware : Form
    {
        public ASoftware()
        {
            InitializeComponent();
        }

        private void ASoftware_Load(object sender, EventArgs e)
        {
            //dataGridView1.DataSource = Class1.Relacion._E_Software;
            E_software ESoftware = new E_software();
            ESoftware.TipoSoftware = "hola";
            ESoftware.NombreSoftware = "Perro";
            Class1.Relacion._E_Software.Add(ESoftware);
            dataGridView1.DataSource = null;
            //dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = Class1.Relacion._E_Software;
            dataGridView1.ReadOnly = true;
            //dataGridView1.Enabled = false;
        }
    }
}
