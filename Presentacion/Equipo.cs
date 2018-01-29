using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Datos;
using System.Text.RegularExpressions;
using System.Globalization;
using Microsoft.VisualBasic;

namespace Presentacion
{
    public partial class Equipo : Form
    {
        public Equipo()
        {
            InitializeComponent();
        }
        public Relacion_H_S relacion;
        public string accion1 = string.Empty;
        public int idEquipo = 0;
        public string PlacaEquipo = "";
        public int idcompra = 0;
        public int idarticulo = 0;
        public int idTipoSoftware = 0;
        public int idSoftware = 0;
        public int idadicional = 0;
        bool invalid = false;

        private void Equipo_Load(object sender, EventArgs e)
        {
            this.Location = new Point(200, 50);
            Diseño();
            //dataGridView1.DataSource = cargarTabla();
            //JuegoBotones();
            //TraerDependencia();
        }



        public void Diseño()
        {
            panel2.Left = (this.Width - panel2.Width) / 2;
            panel2.Top = (this.Height - panel2.Height) / 2;
        }


        private void BtnNUevo_Click(object sender, EventArgs e)
        {
            NewOrUpdate("nuevo");
            PlacaTextBox.Focus();
            AgregarHardwareButton.Enabled = true;
            Class1.idEquipoEditar = 0;
            BtnNuevo.Enabled = false;
            BtnGuardar.Enabled = true;
            BtnCancelar.Enabled = true;
            BtnEliminar.Enabled = false;
            BtnBuscar.Enabled = false;
            BtnEditar.Enabled = false;
        }

        public void limpiarCampos()
        {
            PlacaTextBox.Text = "Placa";
            CorreoCorporativoTextBox.Text = "Correo Corporativo";
            LanMessengerTextBox.Text = "Lan Messenger";
            EstadoComboBox.Text = "- Seleccione Estado -";
            SerialTextBox.Text = "Serial";
            MarcaTextBox.Text = "Marca";
            ModeloTextBox.Text = "Modelo";
            LeasingCheckBox.Checked = false;
            NombreProveedortextBox.Text = "Nombre del Proveedor";
            NitCompraTextbox.Text = "NIT";
            ValorCompraTextBox.Text = "Valor de Compra";

            AdicionalesDataGridView.DataSource = null;

            SoftwareDataGridView.DataSource = null;

        }

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
                //Se le pone el focus al correo Corporativo
                CorreoCorporativoTextBox.Focus();
                panelDatos.Enabled = true;
                limpiarCampos();
                Class1.Relacion = new Relacion_H_S();
                //Se le indica al programa que la accion que va realizar es hacer un insert para poder guardarlo
                accion1 = "BtnNuevo";
                Class1.EditarEquipo = "Nuevo";
                if (EstadoComboBox.Items.Count > 0)
                    EstadoComboBox.Text = EstadoComboBox.Items[0].ToString();
            }
            else
            {
                //Se le pone el focus al correo Corporativo
                CorreoCorporativoTextBox.Focus();
                panelDatos.Enabled = true;
                AgregarHardwareButton.Enabled = false;
                //Se le indica al programa que la accion que va realizar es hacer un insert para poder guardarlo
                accion1 = "BtnEditar";
                Class1.EditarEquipo = "Editar";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            //Se cre una instancia de la Presentacion AsignarSoftware
            AsignarSoftware asignarSoftware = new AsignarSoftware();
            asignarSoftware.ShowDialog();
            SoftwareDataGridView.DataSource = null;
            SoftwareDataGridView.DataSource = Class1.Relacion._E_Software;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var ashad = new AsignarHardware();
            ashad.ShowDialog();
            AdicionalesDataGridView.DataSource = null;
            AdicionalesDataGridView.DataSource = Class1.Relacion._E_Hardware;
        }
        //3215280279

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿ Desea Cancelar el registro ?", "Cancelar", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                Cancelar();
            }
            Class1.idEquipoEditar = idEquipo;
        }

        public void Cancelar()
        {
            limpiarCampos();
            BtnNuevo.Enabled = true;
            BtnGuardar.Enabled = false;
            BtnCancelar.Enabled = false;
            BtnEditar.Enabled = false;
            BtnEliminar.Enabled = false;
            BtnBuscar.Enabled = true;
            panelDatos.Enabled = false;
            AgregarHardwareButton.Enabled = true;
        }


        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            var be = new BuscarEquipo();
            be.ShowDialog();
            if (Class1.tablaBuscarEquipo.Rows.Count > 0)
            {

                foreach (DataRow fila in Class1.tablaBuscarEquipo.Rows)
                {
                    idEquipo = Convert.ToInt32(fila["IdEquipo"].ToString());
                    PlacaTextBox.Text = fila["Placa"].ToString();
                    CorreoCorporativoTextBox.Text = fila["CorreoCorporativo"].ToString();
                    LanMessengerTextBox.Text = fila["LanMessenger"].ToString();
                    SerialTextBox.Text = fila["Serial"].ToString();
                    MarcaTextBox.Text = fila["Marca"].ToString();
                    ModeloTextBox.Text = fila["Modelo"].ToString();
                    if (fila["Leasing"].ToString() == "Si")
                        LeasingCheckBox.Checked = true;
                    else
                        LeasingCheckBox.Checked = false;
                    EstadoComboBox.Text = fila["Estado"].ToString();
                }
                Class1.Relacion = new Relacion_H_S();
                //Llena la tabla Software con respecto al Equipo que se seleccione al buscar
                Class1.HacerConsulta("SELECT dbo.TipoSoftware.NombreTipo AS TipoDeSoftware, dbo.Software.NombreSoftware FROM dbo.Equipo INNER JOIN dbo.Software ON dbo.Equipo.IdEquipo = dbo.Software.IdEquipo INNER JOIN dbo.TipoSoftware ON dbo.Software.IdTipoSoftware = dbo.TipoSoftware.IdTipoSoftware WHERE (dbo.Equipo.IdEquipo = " + idEquipo + ")");
                Class1.lector = Class1.comando.ExecuteReader();
                Class1.Relacion.EditarSoftware();
                if (Class1.lector.HasRows)
                {
                    Class1.HacerConsulta("SELECT dbo.Articulo.NombreArticulo, dbo.Adicional.Placa, dbo.Adicional.Marca, dbo.Adicional.Modelo, dbo.Adicional.Serial, dbo.Adicional.Leasing,   dbo.Relacion_Equipo_Adicional.Estado FROM            dbo.Adicional INNER JOIN dbo.Relacion_Equipo_Adicional ON dbo.Adicional.IdAdicional = dbo.Relacion_Equipo_Adicional.IdAdicional INNER JOIN dbo.Equipo ON dbo.Relacion_Equipo_Adicional.IdEquipo = dbo.Equipo.IdEquipo INNER JOIN dbo.Articulo ON dbo.Adicional.IdArticulo = dbo.Articulo.IdArticulo WHERE (dbo.Equipo.IdEquipo = " + idEquipo + ")");
                    Class1.lector = Class1.comando.ExecuteReader();
                }
                if (Class1.lector.HasRows)
                    Class1.Relacion.EditarHardware();

                SoftwareDataGridView.DataSource = Class1.Relacion._E_Software;
                AdicionalesDataGridView.DataSource = Class1.Relacion._E_Hardware;

                Class1.HacerConsulta("SELECT        dbo.Compra.NombreProveedor, dbo.Compra.Nit, dbo.Compra.ValorCompra FROM            dbo.Compra INNER JOIN dbo.Equipo ON dbo.Compra.IdCompra = dbo.Equipo.IdCompra WHERE        (dbo.Equipo.IdEquipo = " + idEquipo + ")");
                Class1.lector = Class1.comando.ExecuteReader();
                while (Class1.lector.Read())
                {
                    NombreProveedortextBox.Text = Class1.lector["NombreProveedor"].ToString();
                    NitCompraTextbox.Text = Class1.lector["Nit"].ToString();
                    ValorCompraTextBox.Text = Class1.lector["ValorCompra"].ToString();
                }

                BtnNuevo.Enabled = true;
                BtnCancelar.Enabled = false;
                BtnEditar.Enabled = true;
                BtnEliminar.Enabled = true;
                BtnBuscar.Enabled = true;
                BtnGuardar.Enabled = false;
            }

        }

        private void PlacaTextBox_Validating(object sender, CancelEventArgs e)
        {
            Class1.HacerConsulta("Select * From Equipo where Placa = '" + PlacaTextBox.Text + "'");
            Class1.lector = Class1.comando.ExecuteReader();
            if (Class1.lector.HasRows)
            {
                MessageBox.Show("La Placa Ya Esta Asignada a un Equipo");
                PlacaTextBox.Focus();
            }
        }

        private void PlacaTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar))
                e.Handled = false;
            else
                e.Handled = true;
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar) || e.KeyChar.ToString() == "e" || e.KeyChar.ToString() == "-")
                e.Handled = false;
            else
                e.Handled = true;
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            NewOrUpdate("editar");
            Class1.idEquipoEditar = idEquipo;
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            if (!validarCampos())
            {
                MessageBox.Show("Llene todos los campos requeridos");
                return;
            }
            try
            {
                if (!IsValidEmail(CorreoCorporativoTextBox.Text))
                {
                    MessageBox.Show("Por favor escribe un formato correcto de correo electronico");
                    CorreoCorporativoTextBox.Focus();
                    return;
                }

                if (accion1 == "BtnEditar")
                {
                    EditarEquipo();
                    return;
                }
                if (SoftwareDataGridView.RowCount <= 0)
                {
                    MessageBox.Show("Va a Guardar el equipo sin software, Por favor llene el campo de software", "Cuidado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }


                //Se hace el insert de Comprador
                Class1.HacerConsulta("INSERT INTO Compra (NombreProveedor, Nit, ValorCompra,FechaCompra) values ('" + NombreProveedortextBox.Text + "', '" + NitCompraTextbox.Text + "', " + Convert.ToInt32(ValorCompraTextBox.Text) + ", '" + DateTime.Now.ToString("yyyy-MM-dd") + "')");
                Class1.comando.ExecuteNonQuery();
                //Se obtiene el id de la compra la cual recientemente se registro
                idcompra = Class1.devolverId("Select max(IdCompra) as n from Compra");
                //Se inserta el equipo comprado
                Class1.HacerConsulta("INSERT INTO Equipo (IdCompra, CorreoCorporativo, LanMessenger, Estado, Serial, Marca, Modelo, Placa, Leasing) VALUES (" + idcompra + ", '" + CorreoCorporativoTextBox.Text + "', '" + LanMessengerTextBox.Text + "','" + EstadoComboBox.Text + "', '" + SerialTextBox.Text + "','" + MarcaTextBox.Text + "','" + ModeloTextBox.Text + "', '" + PlacaTextBox.Text + "', '" + LeasingCheckBox.Checked.ToString() + "')");
                Class1.comando.ExecuteNonQuery();

                //se obtiene el id del Equipo para poder insertar
                idEquipo = Class1.devolverId("select IdEquipo as n from Equipo where Placa = '" + PlacaTextBox.Text + "'");

                //Guardar con los datagrid
                if (AdicionalesDataGridView.RowCount != 0)
                {
                    foreach (DataGridViewRow item in AdicionalesDataGridView.Rows)
                    {
                        idarticulo = Class1.devolverId("Select IdArticulo as n from Articulo Where NombreArticulo = '" + item.Cells[0].Value.ToString() + "'");
                        Class1.HacerConsulta("INSERT INTO Adicional (IdArticulo, IdCompra, Marca, Modelo, Serial, Placa, Leasing) VALUES        (" + idarticulo + "," + idcompra + ", '" + item.Cells[4].Value.ToString() + "', '" + item.Cells[5].Value.ToString() + "','" + item.Cells[5].Value.ToString() + "','" + item.Cells[1].Value.ToString() + "','" + item.Cells[2].Value.ToString() + "')");
                        Class1.comando.ExecuteNonQuery();

                        idadicional = Class1.devolverId("Select IdAdicional as n from Adicional Where Placa = '" + item.Cells[1].Value.ToString() + "'");

                        //Se inserta en la tabla relacion para saber que adicional va con que equipo
                        //Class1.TAREquipoAdicional.Insert(idEquipo, idadicional, "Habilitado");
                    }
                }
                if (SoftwareDataGridView.RowCount != 0)
                {
                    foreach (DataGridViewRow item in SoftwareDataGridView.Rows)
                    {
                        //se obtiene el id del tipo del software para poder insertar
                        idTipoSoftware = Class1.devolverId("Select IdTipoSoftware as n from TipoSoftware Where NombreTipo = '" + item.Cells[0].Value.ToString() + "'");

                        //se inserta el registro del software con relacion al id del equipo
                        idSoftware = Class1.InsertDevovliendoId("INSERT INTO Software (IdEquipo, IdTipoSoftware, NombreSoftware) VALUES  (" + idEquipo + ", " + idTipoSoftware + ", '" + item.Cells[1].Value.ToString() + "') Select @@Identity as id");
                    }
                }
                //--------------------------------------Aqui va la ventana ------------------------------------
                Class1.idEquipoRevision = idEquipo;
                AsignarMantenimiento a = new AsignarMantenimiento();
                a.ShowDialog();

                MessageBox.Show("Compra Registrada Correctamente");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hubo un error en el guardar....." + ex);
                throw;
            }
            Class1.idEquipoEditar = idEquipo;
            Cancelar();
        }

        public void EditarEquipo()
        {
            //Se editan Los campos del Equipo
            try
            {
                Class1.HacerConsulta("UPDATE       Equipo SET                CorreoCorporativo = '" + CorreoCorporativoTextBox.Text + "', LanMessenger = '" + LanMessengerTextBox.Text + "', Estado = '" + EstadoComboBox.Text + "', Serial = '" + SerialTextBox.Text + "', Marca = '" + MarcaTextBox.Text + "', Modelo = '" + ModeloTextBox.Text + "',Placa = '" + PlacaTextBox.Text + "', Leasing = '" + LeasingCheckBox.Checked.ToString() + "' WHERE        (IdEquipo = " + idEquipo + ")");
                Class1.comando.ExecuteNonQuery();

                Class1.HacerConsulta("UPDATE Compra SET NombreProveedor = '" + NombreProveedortextBox.Text + "', Nit = '" + NitCompraTextbox.Text + "', ValorCompra = " + Convert.ToDouble(ValorCompraTextBox.Text) + " WHERE        (IdCompra = " + idcompra + ")");
                Class1.comando.ExecuteNonQuery();

                //Class1.TAEquipo.Update(CorreoCorporativoTextBox.Text, LanMessengerTextBox.Text, EstadoComboBox.Text, SerialTextBox.Text, MarcaTextBox.Text, ModeloTextBox.Text, PlacaTextBox.Text, LeasingCheckBox.Checked.ToString(), idEquipo);
                //Class1.TACompra.Update(NombreProveedortextBox.Text, NitCompraTextbox.Text, Convert.ToDouble(ValorCompraTextBox.Text), idcompra);
                limpiarCampos();
                BtnNuevo.Enabled = true;
                BtnGuardar.Enabled = false;
                BtnCancelar.Enabled = false;
                BtnEditar.Enabled = false;
                BtnEliminar.Enabled = false;
                BtnBuscar.Enabled = true;
                panelDatos.Enabled = false;
                AgregarHardwareButton.Enabled = true;
                MessageBox.Show("Registro Actualizado Correctamente");
            }
            catch (Exception)
            {

                throw;
            }

        }

        public Boolean validarCampos()
        {
            if (PlacaTextBox.Text == "Placa" || PlacaTextBox.Text == "")
            {
                PlacaTextBox.Focus();
                return false;
            }
            //-----Este campo no es obligatorio
            if (CorreoCorporativoTextBox.Text != "Correo Corporativo")
            {
                if (!IsValidEmail(CorreoCorporativoTextBox.Text))
                {
                    MessageBox.Show("El correo tiene un Formato email incorrecto");
                    return false;
                }
            }

            //-----Este campo no es obligatorio
            //if (LanMessengerTextBox.Text == "Lan Messenger" || LanMessengerTextBox.Text == "")
            //{
            //    LanMessengerTextBox.Focus();
            //    return false;
            //}

            if (EstadoComboBox.Text == "- Seleccionar Estado -")
            {
                EstadoComboBox.Focus();
                return false;
            }

            if (SerialTextBox.Text == "Serial" || SerialTextBox.Text == "")
            {
                SerialTextBox.Focus();
                return false;
            }
            if (MarcaTextBox.Text == "Marca" || MarcaTextBox.Text == "")
            {
                MarcaTextBox.Focus();
                return false;
            }

            if (ModeloTextBox.Text == "Modelo" || ModeloTextBox.Text == "")
            {
                ModeloTextBox.Focus();
                return false;
            }

            if (NombreProveedortextBox.Text == "Nombre del Proveedor" || NombreProveedortextBox.Text == "")
            {
                NombreProveedortextBox.Focus();
                return false;
            }

            if (NitCompraTextbox.Text == "NIT" || NitCompraTextbox.Text == "")
            {
                NitCompraTextbox.Focus();
                return false;
            }

            if (ValorCompraTextBox.Text == "Valor de Compra" || ValorCompraTextBox.Text == "")
            {
                ValorCompraTextBox.Focus();
                return false;
            }
            return true;
            //if (PlacaTextBox.Text == "Placa" || CorreoCorporativoTextBox.Text == "Correo Corporativo" ||
            //    LanMessengerTextBox.Text == "Lan Messenger" || EstadoComboBox.Text == "- Seleccionar Estado -" || 
            //    SerialTextBox.Text == "Serial" || MarcaTextBox.Text == "Marca" ||
            //    ModeloTextBox.Text == "Modelo" || NombreProveedortextBox.Text == "Nombre Proveedor")
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Deseas Eliminar El Equipo de placa " + PlacaTextBox.Text, "Eliminar", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                if (validarEiliminadoLogico() == "")
                {
                    MessageBox.Show("Debes de Escribir el Porque vas a Eliminar el Adicional", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                //Se elimina logicamente el equipo, asi que queda deshabilitado
                //Class1.TAEquipo.EliminadoLogico(idEquipo);

                Class1.HacerConsulta("update Equipo Set Estado = 'Inhabilitado' where IdEquipo = " + idEquipo + "");
                Class1.comando.ExecuteNonQuery();

                Class1.HacerConsulta("update Equipo set Baja = '" + texto + "' where IdEquipo = " + idEquipo + "");
                Class1.comando.ExecuteNonQuery();

                //Eliminar todas las relaciones que tiene el equipo con la dependencia
                Class1.HacerConsulta("delete from Relacion_Dependencias where IdEquipo = " + idEquipo + "");
                Class1.comando.ExecuteNonQuery();
                Cancelar();
            }

        }
        public string texto = "";
        public string validarEiliminadoLogico()
        {
            return texto = Interaction.InputBox("Escribe El Proque Vas A Eliminar El Adicional", "Eliminar", "", -1, -1);
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelDatos_Paint(object sender, PaintEventArgs e)
        {

        }


        #region Eventos Enter y Leave
        private void PlacaTextBox_Enter(object sender, EventArgs e)
        {
            if (PlacaTextBox.Text == "Placa")
            {
                PlacaTextBox.Text = "";
                PlacaTextBox.ForeColor = Color.White;
            }
        }

        private void PlacaTextBox_Leave(object sender, EventArgs e)
        {
            if (PlacaTextBox.Text == "")
            {
                PlacaTextBox.ForeColor = Color.Silver;
                PlacaTextBox.Text = "Placa";
            }
        }

        private void CorreoCorporativoTextBox_Enter(object sender, EventArgs e)
        {
            if (CorreoCorporativoTextBox.Text == "Correo Corporativo")
            {
                CorreoCorporativoTextBox.Text = "";
                CorreoCorporativoTextBox.ForeColor = Color.White;
            }
        }



        private void CorreoCorporativoTextBox_Leave(object sender, EventArgs e)
        {
            if (CorreoCorporativoTextBox.Text == "")
            {
                CorreoCorporativoTextBox.ForeColor = Color.Silver;
                CorreoCorporativoTextBox.Text = "Correo Corporativo";
            }
        }


        private void LanMessengerTextBox_Leave(object sender, EventArgs e)
        {
            if (LanMessengerTextBox.Text == "")
            {
                LanMessengerTextBox.ForeColor = Color.Silver;
                LanMessengerTextBox.Text = "Lan Messenger";
            }
        }

        private void LanMessengerTextBox_Enter(object sender, EventArgs e)
        {
            if (LanMessengerTextBox.Text == "Lan Messenger")
            {
                LanMessengerTextBox.Text = "";
                LanMessengerTextBox.ForeColor = Color.White;
            }
        }
        #endregion

        private void SerialTextBox_Enter(object sender, EventArgs e)
        {
            if (SerialTextBox.Text == "Serial")
            {
                SerialTextBox.Text = "";
                SerialTextBox.ForeColor = Color.White;
            }
        }

        private void SerialTextBox_Leave(object sender, EventArgs e)
        {
            if (SerialTextBox.Text == "")
            {
                SerialTextBox.ForeColor = Color.Silver;
                SerialTextBox.Text = "Serial";
            }
        }

        private void MarcaTextBox_Leave(object sender, EventArgs e)
        {
            if (MarcaTextBox.Text == "")
            {
                MarcaTextBox.ForeColor = Color.Silver;
                MarcaTextBox.Text = "Marca";
            }
        }

        private void MarcaTextBox_Enter(object sender, EventArgs e)
        {
            if (MarcaTextBox.Text == "Marca")
            {
                MarcaTextBox.Text = "";
                MarcaTextBox.ForeColor = Color.White;
            }
        }

        private void ModeloTextBox_Leave(object sender, EventArgs e)
        {
            if (ModeloTextBox.Text == "")
            {
                ModeloTextBox.ForeColor = Color.Silver;
                ModeloTextBox.Text = "Modelo";
            }
        }

        private void ModeloTextBox_Enter(object sender, EventArgs e)
        {
            if (ModeloTextBox.Text == "Modelo")
            {
                ModeloTextBox.Text = "";
                ModeloTextBox.ForeColor = Color.White;
            }
        }

        private void NombreProveedortextBox_Enter(object sender, EventArgs e)
        {
            if (NombreProveedortextBox.Text == "Nombre del Proveedor")
            {
                NombreProveedortextBox.Text = "";
                NombreProveedortextBox.ForeColor = Color.White;
            }
        }

        private void NombreProveedortextBox_Leave(object sender, EventArgs e)
        {
            if (NombreProveedortextBox.Text == "")
            {
                NombreProveedortextBox.ForeColor = Color.Silver;
                NombreProveedortextBox.Text = "Nombre del Proveedor";
            }
        }

        private void NitCompraTextbox_Leave(object sender, EventArgs e)
        {
            if (NitCompraTextbox.Text == "")
            {
                NitCompraTextbox.ForeColor = Color.Silver;
                NitCompraTextbox.Text = "NIT";
            }
        }

        private void NitCompraTextbox_Enter(object sender, EventArgs e)
        {
            if (NitCompraTextbox.Text == "NIT")
            {
                NitCompraTextbox.Text = "";
                NitCompraTextbox.ForeColor = Color.White;
            }
        }

        private void ValorCompraTextBox_Leave(object sender, EventArgs e)
        {
            if (ValorCompraTextBox.Text == "")
            {
                ValorCompraTextBox.ForeColor = Color.Silver;
                ValorCompraTextBox.Text = "Valor de Compra";
            }
        }

        private void ValorCompraTextBox_Enter(object sender, EventArgs e)
        {
            if (ValorCompraTextBox.Text == "Valor de Compra")
            {
                ValorCompraTextBox.Text = "";
                ValorCompraTextBox.ForeColor = Color.White;
            }
        }

        private void SalirButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void NombreProveedorTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
                e.Handled = true;
            else
                e.Handled = false;
        }

        private void ValorCompraTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar))
                e.Handled = false;
            else
                e.Handled = true;
        }

        private void CorreoCorporativoTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void CorreoCorporativoTextBox_Validating(object sender, CancelEventArgs e)
        {

        }


        public bool IsValidEmail(string strIn)
        {
            invalid = false;
            if (String.IsNullOrEmpty(strIn))
                return false;

            // Use IdnMapping class to convert Unicode domain names.
            try
            {
                strIn = Regex.Replace(strIn, @"(@)(.+)$", this.DomainMapper,
                                      RegexOptions.None, TimeSpan.FromMilliseconds(200));
            }
            catch (RegexMatchTimeoutException)
            {
                return false;
            }

            if (invalid)
                return false;

            // Return true if strIn is in valid e-mail format.
            try
            {
                return Regex.IsMatch(strIn,
                      @"^(?("")("".+?(?<!\\)""@)|(([0-9a-z]((\.(?!\.))|[-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*)(?<=[0-9a-z])@))" +
                      @"(?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([0-9a-z][-\w]*[0-9a-z]*\.)+[a-z0-9][\-a-z0-9]{0,22}[a-z0-9]))$",
                      RegexOptions.IgnoreCase, TimeSpan.FromMilliseconds(250));
            }
            catch (RegexMatchTimeoutException)
            {
                return false;
            }
        }

        private string DomainMapper(Match match)
        {
            // IdnMapping class with default property values.
            IdnMapping idn = new IdnMapping();

            string domainName = match.Groups[2].Value;
            try
            {
                domainName = idn.GetAscii(domainName);
            }
            catch (ArgumentException)
            {
                invalid = true;
            }
            return match.Groups[1].Value + domainName;
        }

        private void Equipo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.ToString() == "Escape")
                this.Close();
        }


    }
}
