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
    public partial class RelacionarEquipoDependencia : Form
    {
        public RelacionarEquipoDependencia()
        {
            InitializeComponent();
        }

        private void RelacionarPersonaDependencia_Load(object sender, EventArgs e)
        {
            this.Location = new Point(200, 50);
            LlenarTablas();
        }

        public void LlenarTablas()
        {
            EquiposDataGridView.DataSource = null;
            DependenciasDataGridView.DataSource = null;
            RelacionesDataGridView.DataSource = null;
            //Traer equipos que no esten relacionados
            EquiposDataGridView.DataSource = Class1.devolverTabla("Select Placa,Serial,Marca,Modelo from Equipo as t1 where not exists (select idEquipo from Relacion_Dependencias as t2 where t2.IdEquipo = t1.IdEquipo) and Estado = 'Habilitado'");
            //Traer Dependencia que no esten relacionados
            DependenciasDataGridView.DataSource = Class1.devolverTabla("select * from Indenpendencia where not exists (select IdRelacion from Relacion_Dependencias where Indenpendencia.IdIndependencia = Relacion_Dependencias.IdDependencia and Relacion_Dependencias.IdEquipo is not null)");
            //Traer relacion de Equipo con la Dependencia
            RelacionesDataGridView.DataSource = Class1.devolverTabla("SELECT dbo.Equipo.Placa, dbo.Equipo.Marca, dbo.Equipo.Modelo, dbo.Equipo.Serial, dbo.Indenpendencia.NombreIndependencia FROM dbo.Equipo INNER JOIN dbo.Relacion_Dependencias ON dbo.Equipo.IdEquipo = dbo.Relacion_Dependencias.IdEquipo INNER JOIN dbo.Indenpendencia ON dbo.Relacion_Dependencias.IdDependencia = dbo.Indenpendencia.IdIndependencia  where Relacion_Dependencias.IdEquipo is not null ");
        }

        private void GuardarButton_Click(object sender, EventArgs e)
        {
            if (EquiposDataGridView.Rows.Count <= 0)
            {
                MessageBox.Show("No existen Equipos Disponibles para realizar la Relacion", "¡ CUIDADO !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            if (DependenciasDataGridView.Rows.Count <= 0)
            {
                MessageBox.Show("No existen Dependencias Disponibles para realizar la Relacion", "¡ CUIDADO !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (EquiposDataGridView.CurrentRow.Index == -1)
            {
                MessageBox.Show("Debe seleccionar un equipo para crear la Relacion", "¡ CUIDADO !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (DependenciasDataGridView.CurrentRow.Index == -1)
            {
                MessageBox.Show("Debe seleccionar una Dependencia para crear la Relacion", "¡ CUIDADO !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (MessageBox.Show("Desea crear la relacion entre: \nEquipo de placa = " + EquiposDataGridView.CurrentRow.Cells[0].Value.ToString()+"\nDependencia = "+DependenciasDataGridView.CurrentRow.Cells[1].Value.ToString(), "Confirmar Relacion", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                try
                {
                    Class1.HacerConsulta("insert into Relacion_Dependencias (IdEquipo,IdDependencia, FechaAgregado) values (" + Class1.devolverId("select IdEquipo as n from Equipo where Placa = '" + EquiposDataGridView.CurrentRow.Cells[0].Value.ToString() + "';") + "," + DependenciasDataGridView.CurrentRow.Cells[0].Value.ToString() + ", '" + DateTime.Now.ToString("yyyy/MM/dd") + "')");
                    Class1.comando.ExecuteNonQuery();
                    LlenarTablas();
                }
                catch (Exception)
                {
                    MessageBox.Show("Error Al crear La relacion, posiblemente error en Base de Datos");
                    throw;
                }
            }
        }

        private void EliminarButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Desea Eliminar La relacion de la Dependencia " + RelacionesDataGridView.CurrentRow.Cells[4].Value.ToString(), "Eliminar Relacion", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                //para controlar los retiros que se hacen de cada Dependencia
                Class1.HacerConsulta("insert into Retiro (IdInDependencia,IdEquipo, FechaRetiro) values (" + Class1.devolverId("select IdIndependencia as n from Indenpendencia where NombreIndependencia = '" + RelacionesDataGridView.CurrentRow.Cells[4].Value.ToString() + "'") + "," + Class1.devolverId("select idEquipo as n from Equipo where Placa = " + RelacionesDataGridView.CurrentRow.Cells[0].Value.ToString() + "") + ", '" + DateTime.Now.ToString("yyyy-MM-dd") + "')");
                Class1.comando.ExecuteNonQuery();

                Class1.HacerConsulta("delete from Relacion_Dependencias where IdEquipo = " + Class1.devolverId("select IdEquipo as n from Equipo where Placa = '" + RelacionesDataGridView.CurrentRow.Cells[0].Value.ToString() + "';") + "");
                Class1.comando.ExecuteNonQuery();
                LlenarTablas();
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void SalirButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void RelacionarEquipoDependencia_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.ToString() == "Escape")
                this.Close();
        }
    }
}
