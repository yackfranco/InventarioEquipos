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
    public partial class RelacionarAdicionalDependencia : Form
    {
        public RelacionarAdicionalDependencia()
        {
            InitializeComponent();
        }

        private void RelacionarAdicionalDependencia_Load(object sender, EventArgs e)
        {
            LlenarTablas();
            this.Location = new Point(200, 50);
        }

        public void LlenarTablas()
        {
            AdicionalDataGridView.DataSource = null;
            DependenciasDataGridView.DataSource = null;
            RelacionesDataGridView.DataSource = null;
            //Traer Personas que no estan relacionadas
            //SELECT dbo.Personal.Cedula, dbo.Personal.PrimerNombre, dbo.Personal.SegundoNombre, dbo.Personal.PrimerApellido, dbo.Personal.SegundoApellido,  dbo.Cargo.NombreCargo FROM  dbo.Cargo INNER JOIN dbo.Personal ON dbo.Cargo.IdCargo = dbo.Personal.IdCargo INNER JOIN dbo.Relacion_Dependencias ON dbo.Personal.IdPersonal = dbo.Relacion_Dependencias.IdPersonal where not exists (select idEquipo from Relacion_Dependencias as t2 where t2.IdEquipo = t1.IdEquipo)
            AdicionalDataGridView.DataSource = Class1.devolverTabla("SELECT dbo.Articulo.NombreArticulo as Nombre, dbo.Adicional.Placa, dbo.Adicional.Marca, dbo.Adicional.Modelo, dbo.Adicional.Serial FROM dbo.Adicional INNER JOIN dbo.Articulo ON dbo.Adicional.IdArticulo = dbo.Articulo.IdArticulo where not exists (select IdAdicional from Relacion_Dependencias as t2 where t2.IdAdicional = dbo.Adicional.IdAdicional) and dbo.Adicional.Estado is null");
            //Traer Dependencia que no esten relacionados
            DependenciasDataGridView.DataSource = Class1.devolverTabla("select * from Indenpendencia ");
            //Traer relacion de Personal con la Dependencia
            RelacionesDataGridView.DataSource = Class1.devolverTabla("SELECT dbo.Articulo.NombreArticulo, dbo.Adicional.Placa, dbo.Adicional.Marca, dbo.Adicional.Modelo, dbo.Adicional.Serial, dbo.Indenpendencia.NombreIndependencia as Independencia FROM dbo.Adicional INNER JOIN dbo.Articulo ON dbo.Adicional.IdArticulo = dbo.Articulo.IdArticulo INNER JOIN dbo.Relacion_Dependencias ON dbo.Adicional.IdAdicional = dbo.Relacion_Dependencias.IdAdicional INNER JOIN                          dbo.Indenpendencia ON dbo.Relacion_Dependencias.IdDependencia = dbo.Indenpendencia.IdIndependencia WHERE (dbo.Relacion_Dependencias.IdAdicional IS NOT NULL)  and dbo.Adicional.Estado is null");
        }

        private void GuardarButton_Click(object sender, EventArgs e)
        {
            if (AdicionalDataGridView.Rows.Count <= 0)
            {
                MessageBox.Show("No existen Adicionales Disponibles para realizar la Relacion", "¡ CUIDADO !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            if (DependenciasDataGridView.Rows.Count <= 0)
            {
                MessageBox.Show("No existen Dependencias Disponibles para realizar la Relacion", "¡ CUIDADO !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (AdicionalDataGridView.CurrentRow.Index == -1)
            {
                MessageBox.Show("Debe seleccionar un Adicional para crear la Relacion", "¡ CUIDADO !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (DependenciasDataGridView.CurrentRow.Index == -1)
            {
                MessageBox.Show("Debe seleccionar una Dependencia para crear la Relacion", "¡ CUIDADO !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (validarRelacionAdicional(AdicionalDataGridView.CurrentRow.Cells[0].Value.ToString(), Convert.ToInt32(DependenciasDataGridView.CurrentRow.Cells[0].Value.ToString())))
            {
                MessageBox.Show("El Adicional de tipo " + AdicionalDataGridView.CurrentRow.Cells[0].Value.ToString() + "\nya se encuentra relacionado con la Dependencia " + DependenciasDataGridView.CurrentRow.Cells[1].Value.ToString() + "","ATENCION!!",MessageBoxButtons.OK,MessageBoxIcon.Information);
                return;
            }

            if (MessageBox.Show("Desea crear la relacion entre: \nAdicional de placa = " + AdicionalDataGridView.CurrentRow.Cells[0].Value.ToString() + "\nDependencia = " + DependenciasDataGridView.CurrentRow.Cells[1].Value.ToString(), "Confirmar Relacion", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                try
                {
                    Class1.HacerConsulta("insert into Relacion_Dependencias (IdAdicional,IdDependencia, FechaAgregado) values (" + Class1.devolverId("select IdAdicional as n from Adicional where Placa = '" + AdicionalDataGridView.CurrentRow.Cells[1].Value.ToString() + "';") + "," + DependenciasDataGridView.CurrentRow.Cells[0].Value.ToString() + ", '"+DateTime.Now.ToString("yyyy-MM-dd")+"');");
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

        public Boolean validarRelacionAdicional(string NombreArticulo, int idDependencia)
        {
            Class1.HacerConsulta("SELECT dbo.Relacion_Dependencias.IdRelacion, dbo.Relacion_Dependencias.IdDependencia, dbo.Relacion_Dependencias.IdEquipo,  dbo.Relacion_Dependencias.IdAdicional, dbo.Relacion_Dependencias.IdPersonal FROM dbo.Adicional INNER JOIN dbo.Articulo ON dbo.Adicional.IdArticulo = dbo.Articulo.IdArticulo INNER JOIN dbo.Relacion_Dependencias ON dbo.Adicional.IdAdicional = dbo.Relacion_Dependencias.IdAdicional INNER JOIN dbo.Indenpendencia ON dbo.Relacion_Dependencias.IdDependencia = dbo.Indenpendencia.IdIndependencia WHERE (dbo.Articulo.NombreArticulo = '" + NombreArticulo + "') AND (dbo.Relacion_Dependencias.IdDependencia = " + idDependencia + ")");
            Class1.lector = Class1.comando.ExecuteReader();
            if (Class1.lector.HasRows)
                return true;
            else
                return false;
        }

        private void EliminarButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Desea Eliminar La relacion de la Dependencia " + RelacionesDataGridView.CurrentRow.Cells[4].Value.ToString() + " y del Adicional tipo "+RelacionesDataGridView.CurrentRow.Cells[1].Value.ToString() + "", "Eliminar Relacion", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                //para controlar los retiros que se hacen de cada Dependencia
                Class1.HacerConsulta("insert into Retiro (IdIndependencia,IdAdicional, FechaRetiro) values (" + Class1.devolverId("select IdIndependencia as n from Indenpendencia where NombreIndependencia = '" + RelacionesDataGridView.CurrentRow.Cells[5].Value.ToString() + "'") + "," + Class1.devolverId("select IdAdicional as n from Adicional where Placa = " + RelacionesDataGridView.CurrentRow.Cells[1].Value.ToString() + "") + ", '" + DateTime.Now.ToString("yyyy-MM-dd") + "')");
                Class1.comando.ExecuteNonQuery();


                Class1.HacerConsulta("delete from Relacion_Dependencias where IdAdicional = " + Class1.devolverId("select IdAdicional as n from Adicional where Placa = '" + RelacionesDataGridView.CurrentRow.Cells[1].Value.ToString() + "'") + "");
                Class1.comando.ExecuteNonQuery();
                LlenarTablas();
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void SalirButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void RelacionarAdicionalDependencia_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.ToString() == "Escape")
                this.Close();
        }
    }
}
