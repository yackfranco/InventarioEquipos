
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
    public partial class Accesos : Form
    {
        public Accesos()
        {
            InitializeComponent();
        }

        private void Accesos_Load(object sender, EventArgs e)
        {
            try
            {
                Diseño();
                this.Location = new Point(200, 50);
                Class1.HacerConsulta("select NombreIndependencia from Indenpendencia");
                Class1.lector = Class1.comando.ExecuteReader();
                while (Class1.lector.Read())
                {
                    DependenciaComboBox.Items.Add(Class1.lector["NombreIndependencia"].ToString());
                }
                DependenciaComboBox.Text = DependenciaComboBox.Items[0].ToString();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error......"+ex);
            }
            
        }

        public void Diseño()
        {
            panel2.Left = (this.Width - panel2.Width) / 2;
            panel2.Top = (this.Height - panel2.Height) / 2;

        }

        private void AceptarButton_Click(object sender, EventArgs e)
        {
            limpiarCampos();
            panel1.Enabled = true;
            AceptarButton.Enabled = false;
            Class1.HacerConsulta("select * from Restriccion where IdIndependencia = (select IdIndependencia from Indenpendencia where NombreIndependencia = '" + DependenciaComboBox.Text + "');");
            Class1.lector = Class1.comando.ExecuteReader();
            while (Class1.lector.Read())
            {
                GoogleCheckBox.Checked = Convert.ToBoolean(Class1.lector["Google"].ToString());
                YoutubeCheckBox.Checked = Convert.ToBoolean(Class1.lector["Youtube"].ToString());
                HotmailCheckBox.Checked = Convert.ToBoolean(Class1.lector["Hotmail"].ToString());
                FacebookCheckBox.Checked = Convert.ToBoolean(Class1.lector["Facebook"].ToString());
                OtrosTextBox.Text = Class1.lector["Otro"].ToString();
                InicioSesionCheckBox.Checked = Convert.ToBoolean(Class1.lector["InicioSesion"].ToString());
                IClubSQLCheckBox.Checked = Convert.ToBoolean(Class1.lector["IClubSQL"].ToString());
                ICajaSQLCheckBox.Checked = Convert.ToBoolean(Class1.lector["ICajaSQL"].ToString());
                IRecepcionSQLCheckBox.Checked = Convert.ToBoolean(Class1.lector["IRecepcionSQL"].ToString());
                IContabilidadFIVECheckBox.Checked = Convert.ToBoolean(Class1.lector["IContabilidadLIFE"].ToString());
                IParqueaderoCheckBox.Checked = Convert.ToBoolean(Class1.lector["IParqueadero"].ToString());
                ICorreoInstitucionalCheckBox.Checked = Convert.ToBoolean(Class1.lector["ICorreoI"].ToString());
                INominaCheckBox.Checked = Convert.ToBoolean(Class1.lector["INomina"].ToString());
            }
            DependenciaComboBox.Enabled = false;
        }

        public void limpiarCampos()
        {
            foreach (Control item in panel1.Controls)
            {
                if (item is CheckBox)
                    ((CheckBox)item).Checked = false;
                if (item is TextBox)
                    ((TextBox)item).Text = "";
            }

        }

        private void GuardarButton_Click(object sender, EventArgs e)
        {
            //Class1.TArestriccion.Update(GoogleCheckBox.Checked.ToString(),YoutubeCheckBox.Checked.ToString(),HotmailCheckBox.Checked.ToString(),FacebookCheckBox.Checked.ToString(),OtrosTextBox.Text,InicioSesionCheckBox.Checked.ToString(),IClubSQLCheckBox.Checked.ToString(),ICajaSQLCheckBox.Checked.ToString(),IRecepcionSQLCheckBox.Checked.ToString(),IContabilidadFIVECheckBox.Checked.ToString(),IParqueaderoCheckBox.Checked.ToString(),ICorreoInstitucionalCheckBox.Checked.ToString(),INominaCheckBox.Checked.ToString(),Class1.devolverId("select IdIndependencia as n from Indenpendencia where NombreIndependencia = '"+DependenciaComboBox.Text+"'"));
//            Class1.TArestriccion.UpdateQuery(GoogleCheckBox.Checked.ToString(), YoutubeCheckBox.Checked.ToString(), HotmailCheckBox.Checked.ToString(), FacebookCheckBox.Checked.ToString(), OtrosTextBox.Text, InicioSesionCheckBox.Checked.ToString(), IClubSQLCheckBox.Checked.ToString(), ICajaSQLCheckBox.Checked.ToString(), IRecepcionSQLCheckBox.Checked.ToString(), IContabilidadFIVECheckBox.Checked.ToString(), IParqueaderoCheckBox.Checked.ToString(), ICorreoInstitucionalCheckBox.Checked.ToString(), INominaCheckBox.Checked.ToString(), Class1.devolverId("select IdIndependencia as n from Indenpendencia where NombreIndependencia = '" + DependenciaComboBox.Text + "'"));
            Class1.HacerConsulta("UPDATE       Restriccion SET Google = '" + GoogleCheckBox.Checked.ToString() + "', Youtube = '" + YoutubeCheckBox.Checked.ToString() + "', Hotmail = '" + HotmailCheckBox.Checked.ToString() + "', Facebook = '" + FacebookCheckBox.Checked.ToString() + "', Otro = '" + OtrosTextBox.Text + "', InicioSesion = '" + InicioSesionCheckBox.Checked.ToString() + "', IClubSQL ='" + IClubSQLCheckBox.Checked.ToString() + "',  ICajaSQL ='" + ICajaSQLCheckBox.Checked.ToString() + "', IRecepcionSQL = '" + IRecepcionSQLCheckBox.Checked.ToString() + "', IContabilidadLIFE = '" + IContabilidadFIVECheckBox.Checked.ToString() + "', IParqueadero = '" + IParqueaderoCheckBox.Checked.ToString() + "', ICorreoI = '" + ICorreoInstitucionalCheckBox.Checked.ToString() + "',  INomina = '" + INominaCheckBox.Checked.ToString() + "' WHERE        (IdIndependencia = " + Class1.devolverId("select IdIndependencia as n from Indenpendencia where NombreIndependencia = '" + DependenciaComboBox.Text + "'") + ")");
            Class1.lector = Class1.comando.ExecuteReader();
            
            panel1.Enabled = false;
            AceptarButton.Enabled = true;
            DependenciaComboBox.Enabled = true;
        }

        private void SalirButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Accesos_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }
    }
}
