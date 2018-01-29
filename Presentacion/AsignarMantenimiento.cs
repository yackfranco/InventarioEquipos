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
    public partial class AsignarMantenimiento : Form
    {
        public AsignarMantenimiento()
        {
            InitializeComponent();
        }

        private void BtnTerminar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿ Estas seguro de programar el mantenimiento en " + MesComboBox.Text + " meses?", "¿ Seguro ?", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)==DialogResult.OK)
            {
                //int idEquipo = 0;
               
                //Guardar manenimiento
                //Class1.HacerConsulta("insert into Revision (IdEquipo, FechaRevision, ProximaRevision, Observaciones) values (" + Class1.idEquipoRevision + ", '" + DateTime.Now + "','" +  sumarmes() + "','"+ObservacionTextBox.Text+"')");
                Class1.HacerConsulta("insert into Revision (IdEquipo, FechaRevision, ProximaRevision, Observaciones) values (" + Class1.idEquipoRevision + ", '" + DateTime.Now.ToString("yyyy-MM-dd") + "','" + sumarmes() + "','" + ObservacionTextBox.Text + "')");
                Class1.comando.ExecuteNonQuery();
                this.Close();
            }
            return;
        }
        public string fechaProximaRevision = "";

        public string sumarmes()
        {
            int NumeroMes = 0;
            //DateTime mesSumado;
            string fecha = "";
            NumeroMes = Convert.ToInt32(MesComboBox.Text);
            fecha = DateTime.Now.AddMonths(NumeroMes).ToString("yyyy-MM-dd");
           return fecha;
        }

        private void comboBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            return keyData == (Keys.Alt | Keys.F4);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
