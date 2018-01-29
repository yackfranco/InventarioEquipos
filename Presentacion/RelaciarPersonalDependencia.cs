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
    public partial class RelaciarPersonalDependencia : Form
    {
        public RelaciarPersonalDependencia()
        {
            InitializeComponent();
        }

        private void RelaciarPersonalDependencia_Load(object sender, EventArgs e)
        {
            this.Location = new Point(200, 50);
            LlenarTablas();
        }

        public void LlenarTablas()
        {
            PersonalDataGridView.DataSource = null;
            DependenciasDataGridView.DataSource = null;
            RelacionesDataGridView.DataSource = null;
            //Traer Personas que no estan relacionadas
            //SELECT dbo.Personal.Cedula, dbo.Personal.PrimerNombre, dbo.Personal.SegundoNombre, dbo.Personal.PrimerApellido, dbo.Personal.SegundoApellido,  dbo.Cargo.NombreCargo FROM  dbo.Cargo INNER JOIN dbo.Personal ON dbo.Cargo.IdCargo = dbo.Personal.IdCargo INNER JOIN dbo.Relacion_Dependencias ON dbo.Personal.IdPersonal = dbo.Relacion_Dependencias.IdPersonal where not exists (select idEquipo from Relacion_Dependencias as t2 where t2.IdEquipo = t1.IdEquipo)
            //PersonalDataGridView.DataSource = Class1.devolverTabla("SELECT dbo.Personal.Cedula, dbo.Personal.PrimerNombre, dbo.Personal.SegundoNombre, dbo.Personal.PrimerApellido, dbo.Personal.SegundoApellido,  dbo.Cargo.NombreCargo FROM  dbo.Cargo INNER JOIN dbo.Personal ON dbo.Cargo.IdCargo = dbo.Personal.IdCargo where not exists (select IdPersonal from dbo.Relacion_Dependencias where dbo.Relacion_Dependencias.IdPersonal = dbo.Personal.IdPersonal) And Estado = 'Habilitado'");
            
            PersonalDataGridView.DataSource = Class1.devolverTabla("SELECT dbo.Personal.Cedula, CONCAT(dbo.Personal.PrimerNombre, ' ',dbo.Personal.SegundoNombre, ' ', dbo.Personal.PrimerApellido,' ', dbo.Personal.SegundoApellido) as NombreCompleto,  dbo.Cargo.NombreCargo FROM  dbo.Cargo INNER JOIN dbo.Personal  ON dbo.Cargo.IdCargo = dbo.Personal.IdCargo where not exists (select IdPersonal from dbo.Relacion_Dependencias where dbo.Relacion_Dependencias.IdPersonal = dbo.Personal.IdPersonal) And Estado = 'Habilitado'");
            PersonalDataGridView.AutoResizeColumns();
            //Traer Dependencia que no esten relacionados
            DependenciasDataGridView.DataSource = Class1.devolverTabla("SELECT IdIndependencia,NombreIndependencia as Nombre from Indenpendencia where not exists (select IdRelacion from Relacion_Dependencias where Indenpendencia.IdIndependencia = Relacion_Dependencias.IdDependencia and Relacion_Dependencias.IdPersonal is not null)");
            DependenciasDataGridView.Columns[0].Visible = false;
            
            //Traer relacion de Personal con la Dependencia
            //RelacionesDataGridView.DataSource = Class1.devolverTabla("SELECT dbo.Personal.Cedula, dbo.Personal.PrimerNombre, dbo.Personal.SegundoNombre, dbo.Personal.PrimerApellido, dbo.Personal.SegundoApellido,  dbo.Cargo.NombreCargo, dbo.Indenpendencia.NombreIndependencia FROM            dbo.Personal INNER JOIN dbo.Relacion_Dependencias ON dbo.Personal.IdPersonal = dbo.Relacion_Dependencias.IdPersonal INNER JOIN dbo.Cargo ON dbo.Personal.IdCargo = dbo.Cargo.IdCargo INNER JOIN dbo.Indenpendencia ON dbo.Relacion_Dependencias.IdDependencia = dbo.Indenpendencia.IdIndependencia where Relacion_Dependencias.IdPersonal is not null ");
            RelacionesDataGridView.DataSource = Class1.devolverTabla("SELECT dbo.Personal.Cedula,CONCAT(dbo.Personal.PrimerNombre, ' ',dbo.Personal.SegundoNombre, ' ', dbo.Personal.PrimerApellido,' ', dbo.Personal.SegundoApellido) as NombreCompleto,  dbo.Cargo.NombreCargo as Cargo, dbo.Indenpendencia.NombreIndependencia as Dependencia FROM            dbo.Personal INNER JOIN dbo.Relacion_Dependencias ON dbo.Personal.IdPersonal = dbo.Relacion_Dependencias.IdPersonal INNER JOIN dbo.Cargo ON dbo.Personal.IdCargo = dbo.Cargo.IdCargo INNER JOIN dbo.Indenpendencia ON dbo.Relacion_Dependencias.IdDependencia = dbo.Indenpendencia.IdIndependencia where Relacion_Dependencias.IdPersonal is not null ");
        }

        private void GuardarButton_Click(object sender, EventArgs e)
        {
            if (PersonalDataGridView.Rows.Count <= 0)
            {
                MessageBox.Show("No existe Personal Disponible para realizar la Relacion", "¡ CUIDADO !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            if (DependenciasDataGridView.Rows.Count <= 0)
            {
                MessageBox.Show("No existen Dependencias Disponibles para realizar la Relacion", "¡ CUIDADO !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (PersonalDataGridView.CurrentRow.Index == -1)
            {
                MessageBox.Show("Debe seleccionar un Personal para crear la Relacion", "¡ CUIDADO !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                if (DependenciasDataGridView.CurrentRow.Index == -1)
                {
                    MessageBox.Show("Debe seleccionar una Dependencia para crear la Relacion", "¡ CUIDADO !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Debe seleccionar una Dependencia para crear la Relacion", "¡ CUIDADO !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
                throw;
            }
            

            if (MessageBox.Show("Desea crear la relacion entre: \nPersona de Cedula = " + PersonalDataGridView.CurrentRow.Cells[0].Value.ToString() + "\nDependencia = " + DependenciasDataGridView.CurrentRow.Cells[1].Value.ToString(), "Confirmar Relacion", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                try
                {
                    Class1.HacerConsulta("insert into Relacion_Dependencias (IdPersonal,IdDependencia) values (" + Class1.devolverId("select IdPersonal as n from Personal where Cedula = '" + PersonalDataGridView.CurrentRow.Cells[0].Value.ToString() + "';") + "," + DependenciasDataGridView.CurrentRow.Cells[0].Value.ToString() + ")");
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
            if (MessageBox.Show("Desea Eliminar La relacion de la Dependencia " + RelacionesDataGridView.CurrentRow.Cells[2].Value.ToString(), "Eliminar Relacion", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                Class1.HacerConsulta("delete from Relacion_Dependencias where IdPersonal = " + Class1.devolverId("select IdPersonal as n from Personal where Cedula = '" + RelacionesDataGridView.CurrentRow.Cells[0].Value.ToString() + "';") + "");
                Class1.comando.ExecuteNonQuery();
                LlenarTablas();
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void SalirButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void RelaciarPersonalDependencia_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.ToString() == "Escape")
                this.Close();
        }
    }
}
