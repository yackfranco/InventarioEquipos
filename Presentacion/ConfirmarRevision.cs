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
    public partial class ConfirmarRevision : Form
    {
        public ConfirmarRevision()
        {
            InitializeComponent();
        }

        public string idPc = "";
        public string fechaProximaRevision = "";

        private void ConfirmarRevision_Load(object sender, EventArgs e)
        {
            idPc = Class1.MantenimientoPc[0].ToString();
            PlacaLabel.Text = Class1.MantenimientoPc[1].ToString();
            MarcaLabel.Text = Class1.MantenimientoPc[2].ToString();
            ModeloLabel.Text = Class1.MantenimientoPc[3].ToString();
            SerialLabel.Text = Class1.MantenimientoPc[4].ToString();
            DependenciaLabel.Text = Class1.MantenimientoPc[5].ToString();
        }

        private void Aceptarbutton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("El mantenimiento para el Equipo de Placa " + PlacaLabel.Text + "\nEn la Dependencia " + DependenciaLabel.Text + " quedará programada para la fecha " + sumarmes(), "CONFIRMAR REVISIÓN", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
            {
                //Aqui se hace el insert
                Class1.HacerConsulta("insert into Revision values (" + idPc + ",'" + FechaRevisionDateTimePicker.Value.ToString("yyyy-MM-dd") + "','" + fechaProximaRevision + "','" + ObservacionesTextbox.Text + "');");
                Class1.comando.ExecuteNonQuery();
                Class1.confirmarMante = true;
                this.Hide();
            }
        }

        public string sumarmes()
        {
            DateTime mesSumado;
            mesSumado = FechaRevisionDateTimePicker.Value.AddMonths(Convert.ToInt32(MesComboBox.Text));
            fechaProximaRevision = mesSumado.ToString("yyyy-MM-dd");
            return mesSumado.ToString("dd-MMMM-yyyy");
        }
    }
}
