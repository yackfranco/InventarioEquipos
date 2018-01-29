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
using Microsoft.VisualBasic;

namespace Presentacion
{
    public partial class Personal : Form
    {
        public Personal()
        {
            InitializeComponent();
        }

        public string accion1 = string.Empty;
        private void Personal_Load(object sender, EventArgs e)
        {
            this.Location = new Point(200, 50);
            personalBindingSource.DataSource = Class1.devolverTabla("Select * from Personal");
            idCargoComboBox.Text = traerCargoPorId();
            JuegoBotones();
            Diseño();
        }






        private void BtnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            NewOrUpdate("nuevo");
            TraerTodosLosCargos();
        }

        //Se utiliza este metodo para crear espacio en memoria y limpiar los campos
        public void NewOrUpdate(string accion)
        {
            panelDatos.Enabled = true;
            BtnNuevo.Enabled = false;
            BtnGuardar.Enabled = true;
            BtnCancelar.Enabled = true;
            BtnEditar.Enabled = false;
            BtnEliminar.Enabled = false;
            BtnBuscar.Enabled = false;
            if (accion == "nuevo")
            {
                //Se activa el campo cedula para crear un nuevo usuario
                cedulaTextBox.Enabled = true;
                cedulaTextBox.Focus();

                //Se limpian todos los campos y se crea espacio en memoria
                personalBindingSource.AddNew();
                //Se le indica al programa que la accion que va realizar es hacer un insert para poder guardarlo
                accion1 = "BtnNuevo";
                estadoComboBox.Text = "Habilitado";
            }
            else
            {
                //La cedula no se puede editar asi que se inhabilita
                cedulaTextBox.Enabled = false;
                //Se le indica al programa que la accion que va realizar es hacer un insert para poder guardarlo
                accion1 = "BtnEditar";
            }
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            panelDatos.Enabled = false;
            personalBindingSource.CancelEdit();
            JuegoBotones();
            idCargoComboBox.Text = traerCargoPorId();
        }


        public Boolean validarCampos()
        {
            if (cedulaTextBox.Text == "")
            {
                cedulaTextBox.Focus();
                return false;
            }
            if (primerNombreTextBox.Text == "")
            {
                primerNombreTextBox.Focus();
                return false;
            }
            if (primerApellidoTextBox.Text == "")
            {
                primerApellidoTextBox.Focus();
                return false;
            }
            if (idCargoComboBox.Text == "")
            {
                idCargoComboBox.Focus();
                return false;
            }
            if (estadoComboBox.Text == "")
            {
                estadoComboBox.Focus();
                return false;
            }
            return true;
        }

        public void JuegoBotones()
        {
            if (personalBindingSource.Count > 0)
            {
                BtnNuevo.Enabled = true;
                BtnGuardar.Enabled = false;
                BtnCancelar.Enabled = false;
                BtnEditar.Enabled = true;
                BtnEliminar.Enabled = true;
                BtnBuscar.Enabled = true;
            }
            else
            {
                BtnNuevo.Enabled = true;
                BtnGuardar.Enabled = false;
                BtnCancelar.Enabled = false;
                BtnEditar.Enabled = false;
                BtnEliminar.Enabled = false;
                BtnBuscar.Enabled = false;
            }
        }

        public void Diseño()
        {
            panel1.Left = (this.Width - panel1.Width) / 2;
            panel1.Top = (this.Height - panel1.Height) / 2;

        }

        private void bindingNavigatorMoveNextItem_Click(object sender, EventArgs e)
        {

        }

        private void personalBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            idCargoComboBox.Text = traerCargoPorId();
        }

        #region Manejo de Cargos
        private string traerCargoPorId()
        {
            try
            {
                int idCargo = 0;
                string nombreCargo = string.Empty;
                Class1.HacerConsulta("select IdCargo from Personal where IdPersonal = " + Convert.ToInt32(idPersonalTextBox.Text) + "");
                Class1.lector = Class1.comando.ExecuteReader();
                while (Class1.lector.Read())
                {
                    idCargo = Convert.ToInt32(Class1.lector["IdCargo"].ToString());
                }
                Datos.Class1.HacerConsulta("select NombreCargo from Cargo where IdCargo = " + idCargo + "");
                Class1.lector = Class1.comando.ExecuteReader();
                while (Class1.lector.Read())
                {
                    nombreCargo = Class1.lector["NombreCargo"].ToString();
                }
                return nombreCargo;
            }
            catch (Exception)
            {
                return string.Empty;
            }

        }

        public void TraerTodosLosCargos()
        {
            try
            {
                idCargoComboBox.Items.Clear();
                Datos.Class1.HacerConsulta("select NombreCargo from Cargo");
                Class1.lector = Class1.comando.ExecuteReader();
                while (Class1.lector.Read())
                {
                    idCargoComboBox.Items.Add(Class1.lector["NombreCargo"].ToString());
                }
                idCargoComboBox.Text = idCargoComboBox.Items[0].ToString();
            }
            catch (Exception)
            {

            }
        }
        #endregion

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            NewOrUpdate("Editar");
            TraerTodosLosCargos();
            idCargoComboBox.Text = traerCargoPorId();
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show(" Desea Eliminar El Personal con cedula " + cedulaTextBox.Text + " de forma permanente?", "Eliminar", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    if (0 < Convert.ToInt32(Class1.devolverId("SELECT        COUNT(dbo.Relacion_Dependencias.IdRelacion) AS n FROM            dbo.Personal INNER JOIN                          dbo.Relacion_Dependencias ON dbo.Personal.IdPersonal = dbo.Relacion_Dependencias.IdPersonal WHERE        (dbo.Personal.IdPersonal = '" + idPersonalTextBox.Text + "')")))
                    {
                        MessageBox.Show("no se puede Eliminar Un Personal donde se encuentra relacionado con una dependencia en este momento");
                        return;
                    }
                    Class1.HacerConsulta("DELETE FROM Personal WHERE        (IdPersonal = "+idPersonalTextBox.Text+")");
                    Class1.comando.ExecuteNonQuery();
                    personalBindingSource.DataSource = Class1.devolverTabla("Select * from Personal");
                }
            }
            catch (Exception)
            {
            }
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            BuscarPersonal bp = new BuscarPersonal();
            bp.ShowDialog();
            personalBindingSource.DataSource = Class1.devolverTabla("select * from Personal where Cedula = " + Class1.cedulapersonal + "");
            idCargoComboBox.Text = Class1.DevolverDato("SELECT        dbo.Cargo.NombreCargo as n FROM            dbo.Cargo INNER JOIN                          dbo.Personal ON dbo.Cargo.IdCargo = dbo.Personal.IdCargo WHERE        (dbo.Personal.Cedula = '"+Class1.cedulapersonal+"')");

        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (validarCampos())
                {
                    if (accion1 == "BtnNuevo")
                    {
                        Class1.HacerConsulta("INSERT INTO Personal (PrimerNombre, SegundoNombre, PrimerApellido, SegundoApellido, Cedula, IdCargo, Estado) VALUES        ('"+primerNombreTextBox.Text+"','"+primerApellidoTextBox.Text+"','"+segundoNombreTextBox.Text+"','"+segundoApellidoTextBox.Text+"','"+cedulaTextBox.Text+"','"+traerIdCargoPorNombre(idCargoComboBox.Text)+"','"+estadoComboBox.Text+"')");
                        Class1.comando.ExecuteNonQuery();
                        personalBindingSource.EndEdit();
                        MessageBox.Show("Personal Guardado Correctamente");
                    }
                    else
                    {
                        //Datos.Class1.TAPersonal.Update(primerNombreTextBox.Text, segundoNombreTextBox.Text, primerApellidoTextBox.Text, segundoApellidoTextBox.Text, cedulaTextBox.Text, traerIdCargoPorNombre(idCargoComboBox.Text), estadoComboBox.Text, Convert.ToInt32(idPersonalTextBox.Text));
                        Class1.HacerConsulta("UPDATE       Personal SET                PrimerNombre = '" + primerNombreTextBox.Text + "', SegundoNombre = '"+segundoNombreTextBox.Text+"', PrimerApellido = '"+primerApellidoTextBox.Text+"', SegundoApellido = '"+segundoApellidoTextBox.Text+"', Cedula = '"+cedulaTextBox.Text+"', IdCargo = "+traerIdCargoPorNombre(idCargoComboBox.Text)+", Estado = '"+estadoComboBox.Text+"' WHERE        (IdPersonal = "+idPersonalTextBox.Text+")");
                        Class1.comando.ExecuteNonQuery();
                        MessageBox.Show("Personal Editado Correctamente");
                    }
                    panelDatos.Enabled = false;
                    JuegoBotones();
                    personalBindingSource.DataSource = Class1.devolverTabla("Select * from Personal");
                    idCargoComboBox.Text = traerCargoPorId();
                }
                else
                    MessageBox.Show("Llene los campos requeridos");
            }
            catch (Exception)
            {
            }
        }

        public int traerIdCargoPorNombre(string nombreCargo)
        {
            int idCargo = 0;
            try
            {
                Class1.HacerConsulta("select IdCargo from Cargo where NombreCargo = '" + nombreCargo + "'");
                Class1.lector = Class1.comando.ExecuteReader();
                while (Class1.lector.Read())
                {
                    idCargo = Convert.ToInt32(Class1.lector["IdCargo"].ToString());
                }
                return idCargo;
            }
            catch (Exception)
            {
                return idCargo;
            }
        }

        private void cedulaTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) || char.IsControl(e.KeyChar))
                e.Handled = false;
            else
                e.Handled = true;
        }

        private void idCargoComboBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void primerNombreTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) || char.IsControl(e.KeyChar))
                e.Handled = false;
            else
                e.Handled = true;
        }

        private void SalirButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
