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
    public partial class Reportes : Form
    {
        public Reportes()
        {
            InitializeComponent();
        }

        public ReportesClass r = new ReportesClass();

        private void button1_Click(object sender, EventArgs e)
        {
            r.ReporteGeneral(this);
        }

        public void CargarObejtosEntrega()
        {
            //cargar datos en Objetos en Entrega
            ObjetosComboBox.Items.Clear();
            if (Class1.devolverId("SELECT        COUNT(dbo.Relacion_Dependencias.IdEquipo) AS n FROM            dbo.Indenpendencia INNER JOIN                          dbo.Relacion_Dependencias ON dbo.Indenpendencia.IdIndependencia = dbo.Relacion_Dependencias.IdDependencia INNER JOIN                          dbo.Equipo ON dbo.Relacion_Dependencias.IdEquipo = dbo.Equipo.IdEquipo WHERE        (dbo.Indenpendencia.NombreIndependencia = '"+DependenciaComboBox.Text+"') AND (dbo.Relacion_Dependencias.IdEquipo IS NOT NULL) AND (dbo.Equipo.Estado = 'Habilitado')") > 0)
                ObjetosComboBox.Items.Add("Equipo");

            Class1.HacerConsulta("SELECT dbo.Articulo.NombreArticulo, dbo.Relacion_Dependencias.IdAdicional FROM dbo.Adicional INNER JOIN dbo.Articulo ON dbo.Adicional.IdArticulo = dbo.Articulo.IdArticulo INNER JOIN dbo.Relacion_Dependencias ON dbo.Adicional.IdAdicional = dbo.Relacion_Dependencias.IdAdicional INNER JOIN dbo.Indenpendencia ON dbo.Relacion_Dependencias.IdDependencia = dbo.Indenpendencia.IdIndependencia WHERE (dbo.Relacion_Dependencias.IdAdicional IS NOT NULL) AND (dbo.Indenpendencia.NombreIndependencia = '" + DependenciaComboBox.Text + "') AND (dbo.Adicional.Estado IS NULL)");
            Class1.lector = Class1.comando.ExecuteReader();
            while (Class1.lector.Read())
            {
                ObjetosComboBox.Items.Add(Class1.lector["NombreArticulo"]);
            }
            ObjetosComboBox.Text = (ObjetosComboBox.Items.Count > 0) ? ObjetosComboBox.Items[0].ToString() : "";

        }

        public void CargarObjetosRetira()
        {
            //cargar datos en Objetos en Retira
            ObjetosReComboBox.Items.Clear();
            if (Class1.devolverId("SELECT COUNT(dbo.Retiro.IdEquipo) AS n FROM dbo.Indenpendencia INNER JOIN dbo.Retiro ON dbo.Indenpendencia.IdIndependencia = dbo.Retiro.IdIndependencia INNER JOIN dbo.Equipo ON dbo.Retiro.IdEquipo = dbo.Equipo.IdEquipo WHERE (dbo.Indenpendencia.NombreIndependencia = '" + DependenciaComboBox.Text + "') AND (dbo.Retiro.IdEquipo IS NOT NULL)  AND (dbo.Equipo.Estado = 'Habilitado')") > 0)
                ObjetosReComboBox.Items.Add("Equipo");

            Class1.HacerConsulta("SELECT        dbo.Articulo.NombreArticulo FROM            dbo.Adicional INNER JOIN                          dbo.Articulo ON dbo.Adicional.IdArticulo = dbo.Articulo.IdArticulo INNER JOIN                          dbo.Retiro ON dbo.Adicional.IdAdicional = dbo.Retiro.IdAdicional INNER JOIN                          dbo.Indenpendencia ON dbo.Retiro.IdIndependencia = dbo.Indenpendencia.IdIndependencia WHERE        (dbo.Indenpendencia.NombreIndependencia = '" + DependenciaComboBox.Text + "') AND (dbo.Retiro.IdAdicional IS NOT NULL) AND (dbo.Adicional.Estado IS NULL) GROUP BY dbo.Articulo.NombreArticulo");
            Class1.lector = Class1.comando.ExecuteReader();
            while (Class1.lector.Read())
            {
                ObjetosReComboBox.Items.Add(Class1.lector["NombreArticulo"]);
            }
            ObjetosReComboBox.Text = (ObjetosReComboBox.Items.Count > 0) ? ObjetosReComboBox.Items[0].ToString() : "";
        }

        private void Reportes_Load(object sender, EventArgs e)
        {
            this.Location = new Point(200, 50);
            Class1.HacerConsulta("select * from Indenpendencia");
            Class1.lector = Class1.comando.ExecuteReader();
            while (Class1.lector.Read())
            {
                DependenciaComboBox.Items.Add(Class1.lector["NombreIndependencia"].ToString());
            }
            if(DependenciaComboBox.Items.Count>0)
            DependenciaComboBox.Text = DependenciaComboBox.Items[0].ToString();

            CargarObejtosEntrega();
            CargarObjetosRetira();
        }

      

        private void button2_Click(object sender, EventArgs e)
        {
            r.ReporteMantenimiento(DependenciaComboBox.Text);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (ObjetosComboBox.Text == "")
            {
                MessageBox.Show("No hay elementos para Reporte de Entrega a una dependencia");
                return;
            }
            r.Entra(DependenciaComboBox.Text, ObjetosComboBox.Text);
        }

        private void SalirButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DependenciaComboBox_SelectedValueChanged(object sender, EventArgs e)
        {
            CargarObejtosEntrega();
            CargarObjetosRetira();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (ObjetosReComboBox.Text == "")
            {
                MessageBox.Show("No hay elementos para Reporte de Retiro a una dependencia");
                return;
            }
            r.Retira(DependenciaComboBox.Text, ObjetosReComboBox.Text);
        }

        private void DependenciaComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // CargarObejtosEntrega();
            //CargarObjetosRetira();
        
        }

        private void Reportes_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.ToString() == "Escape")
                this.Close();
        }

        private void ReporteTodo_Click(object sender, EventArgs e)
        {
            r.ReporteTodo();
        }

    }
}
