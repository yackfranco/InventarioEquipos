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
using System.Collections;

namespace Presentacion
{
    public partial class CMantenimiento : Form
    {
        //Si el equipo no esta relacionado con una Dependencia, no aparecera en los listados
        public CMantenimiento()
        {
            InitializeComponent();
        }

        private void CMantenimiento_Load(object sender, EventArgs e)
        {
            this.Location = new Point(200, 50);
            llenarTablas();
        }

        public void llenarTablas()
        {
            LlenarMantenimientosVigentes();
            LlenarListaMantenimiento();
            LlenarMantenimientoAtrasado();
        }

       
        public void LlenarMantenimientosVigentes()
        {
           //se seleccionan los equipos que estan registrados en revision con la condicion que sea los ultimos en su grupo y que tengan la fecha actual
            MantenimientoMensualDataGridView.DataSource = Class1.devolverTabla("SELECT dbo.Equipo.IdEquipo,dbo.Equipo.Placa, dbo.Equipo.Marca, dbo.Equipo.Modelo, dbo.Equipo.Serial, dbo.Indenpendencia.NombreIndependencia as Dependencia, dbo.Revision.ProximaRevision FROM dbo.Equipo INNER JOIN dbo.Relacion_Dependencias ON dbo.Equipo.IdEquipo = dbo.Relacion_Dependencias.IdEquipo INNER JOIN dbo.Revision ON dbo.Equipo.IdEquipo = dbo.Revision.IdEquipo INNER JOIN dbo.Indenpendencia ON dbo.Relacion_Dependencias.IdDependencia = dbo.Indenpendencia.IdIndependencia WHERE MONTH( dbo.Revision.ProximaRevision)=" + DateTime.Now.Month + " and YEAR(dbo.Revision.ProximaRevision)=" + DateTime.Now.Year + " and dbo.Revision.IdRevision = (select MAX(IdRevision) from Revision where IdEquipo = dbo.Revision.IdEquipo)  AND (dbo.Equipo.Estado = 'Habilitado')");
            //MantenimientoMensualDataGridView.Columns[0].Visible = false;
            MantenimientoMensualDataGridView.Columns[6].DefaultCellStyle.Format = "dd-MMMM-yyyy";
        }

        public void LlenarMantenimientoAtrasado()
        {
            MantenimientoAtrasadoDataGridView.DataSource = Class1.devolverTabla("SELECT dbo.Equipo.IdEquipo,dbo.Equipo.Placa, dbo.Equipo.Marca, dbo.Equipo.Modelo, dbo.Equipo.Serial, dbo.Indenpendencia.NombreIndependencia as Dependencia, dbo.Revision.ProximaRevision FROM dbo.Equipo INNER JOIN dbo.Relacion_Dependencias ON dbo.Equipo.IdEquipo = dbo.Relacion_Dependencias.IdEquipo INNER JOIN dbo.Revision ON dbo.Equipo.IdEquipo = dbo.Revision.IdEquipo INNER JOIN dbo.Indenpendencia ON dbo.Relacion_Dependencias.IdDependencia = dbo.Indenpendencia.IdIndependencia WHERE ProximaRevision < '01-" + DateTime.Now.Month + "-" + DateTime.Now.Year + "' and dbo.Revision.IdRevision = (select MAX(IdRevision) from Revision where IdEquipo = dbo.Revision.IdEquipo) AND (dbo.Equipo.Estado = 'Habilitado')");
           // MantenimientoAtrasadoDataGridView.Columns[0].Visible = false;
            MantenimientoAtrasadoDataGridView.Columns[6].DefaultCellStyle.Format = "dd-MMMM-yyyy";
        }

        public void LlenarListaMantenimiento()
        {
            Relacion_H_S mante = new Relacion_H_S();
            DataTable t = new DataTable();
            t = Class1.devolverTabla("SELECT        TOP (100) PERCENT dbo.Revision.IdEquipo FROM            dbo.Revision INNER JOIN                          dbo.Equipo ON dbo.Revision.IdEquipo = dbo.Equipo.IdEquipo WHERE        (dbo.Equipo.Estado = 'Habilitado') GROUP BY dbo.Revision.IdEquipo ORDER BY dbo.Revision.IdEquipo DESC");
            //DataRow r = null;
            foreach (DataRow row in t.Rows)
            {
                MantenimientoEquipos m = new MantenimientoEquipos();
                m.IdEquipo = Convert.ToInt32(row["idEquipo"].ToString());

                Class1.HacerConsulta("select max(ProximaRevision) as fechaProxima from Revision where IdEquipo = " + m.IdEquipo + "");

                Class1.lector = Class1.comando.ExecuteReader();
                while (Class1.lector.Read())
                {
                    DateTime fecha = Convert.ToDateTime(Class1.lector["fechaProxima"]);
                    m.FechaProxima = fecha.ToString("dd-MM-yyyy");
                }
                Class1.HacerConsulta("select * from Equipo where IdEquipo = " + m.IdEquipo + "");
                Class1.lector = Class1.comando.ExecuteReader();
                while (Class1.lector.Read())
                {
                    m.Marca = Class1.lector["Marca"].ToString();
                    m.Modelo = Class1.lector["Modelo"].ToString();
                    m.Placa = Class1.lector["Placa"].ToString();
                }
                mante.agregarMantenimiento(m);
            }
            ListaMantenimientoDataGridView.DataSource = mante.MEquipos1;

            ListaMantenimientoDataGridView.Columns[0].Visible = false;
            //ListaMantenimientoDataGridView.Sort(ListaMantenimientoDataGridView.Columns[3], System.ComponentModel.ListSortDirection.Ascending);
        }

        ReportesClass r = new ReportesClass();
        private void button1_Click(object sender, EventArgs e)
        {
            int idEquipo = 0;
            string Dependencia = "";

            if (MantenimientoMensualDataGridView.Rows.Count <= 0)
            {
                MessageBox.Show("No hay equipos del mes para hacer Mantenimiento");
                return;
            }
            
            int a = MantenimientoMensualDataGridView.SelectedRows.Count;
            if (!(a <= 0))
            {
                ArrayList pcMante = new ArrayList();
                //id
                idEquipo = Convert.ToInt32(MantenimientoMensualDataGridView.CurrentRow.Cells[0].Value.ToString());
                pcMante.Add(MantenimientoMensualDataGridView.CurrentRow.Cells[0].Value.ToString());
                //placa
                pcMante.Add(MantenimientoMensualDataGridView.CurrentRow.Cells[1].Value.ToString());
                //marca
                pcMante.Add(MantenimientoMensualDataGridView.CurrentRow.Cells[2].Value.ToString());
                //modelo
                pcMante.Add(MantenimientoMensualDataGridView.CurrentRow.Cells[3].Value.ToString());
                //serial
                pcMante.Add(MantenimientoMensualDataGridView.CurrentRow.Cells[4].Value.ToString());
                //Dependencia
                Dependencia = MantenimientoMensualDataGridView.CurrentRow.Cells[5].Value.ToString();
                pcMante.Add(MantenimientoMensualDataGridView.CurrentRow.Cells[5].Value.ToString());
                //FechaProxima
                pcMante.Add(MantenimientoMensualDataGridView.CurrentRow.Cells[6].Value.ToString());

                Class1.MantenimientoPc = pcMante;
                Class1.confirmarMante = false;
                var q = new ConfirmarRevision();
                q.ShowDialog();
                if (Class1.confirmarMante)
                    llenarTablas();
                
            }
            //r.ReporteMantenimiento(idEquipo,Dependencia);

        }

        private void ListaMantenimientoDataGridView_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridViewColumn newColumn = ListaMantenimientoDataGridView.Columns[e.ColumnIndex];
            DataGridViewColumn oldColumn = ListaMantenimientoDataGridView.SortedColumn;
            ListSortDirection direction;

            // If oldColumn is null, then the DataGridView is not sorted.
            if (oldColumn != null)
            {
                // Sort the same column again, reversing the SortOrder.
                if (oldColumn == newColumn &&
                    ListaMantenimientoDataGridView.SortOrder == SortOrder.Ascending)
                {
                    direction = ListSortDirection.Descending;
                }
                else
                {
                    // Sort a new column and remove the old SortGlyph.
                    direction = ListSortDirection.Ascending;
                    oldColumn.HeaderCell.SortGlyphDirection = SortOrder.None;
                }
            }
            else
            {
                direction = ListSortDirection.Ascending;
            }

            // Sort the selected column.
            ListaMantenimientoDataGridView.Sort(newColumn, direction);
            newColumn.HeaderCell.SortGlyphDirection =
                direction == ListSortDirection.Ascending ?
                SortOrder.Ascending : SortOrder.Descending;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (MantenimientoAtrasadoDataGridView.Rows.Count <= 0)
            {
                MessageBox.Show("No hay equipos del mes para hacer Mantenimiento");
                return;
            }

            int a = MantenimientoAtrasadoDataGridView.SelectedRows.Count;
            if (!(a <= 0))
            {
                ArrayList pcMante = new ArrayList();
                //id
                pcMante.Add(MantenimientoAtrasadoDataGridView.CurrentRow.Cells[0].Value.ToString());
                //placa
                pcMante.Add(MantenimientoAtrasadoDataGridView.CurrentRow.Cells[1].Value.ToString());
                //marca
                pcMante.Add(MantenimientoAtrasadoDataGridView.CurrentRow.Cells[2].Value.ToString());
                //modelo
                pcMante.Add(MantenimientoAtrasadoDataGridView.CurrentRow.Cells[3].Value.ToString());
                //serial
                pcMante.Add(MantenimientoAtrasadoDataGridView.CurrentRow.Cells[4].Value.ToString());
                //Dependencia
                pcMante.Add(MantenimientoAtrasadoDataGridView.CurrentRow.Cells[5].Value.ToString());
                //FechaProxima
                pcMante.Add(MantenimientoAtrasadoDataGridView.CurrentRow.Cells[6].Value.ToString());

                Class1.MantenimientoPc = pcMante;
                Class1.confirmarMante = false;
                var q = new ConfirmarRevision();
                q.ShowDialog();
                if (Class1.confirmarMante)
                    llenarTablas();

            }
        }

        private void SalirButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CMantenimiento_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.ToString() == "Escape")
                this.Close();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

    }
}
