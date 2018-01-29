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
    public partial class Administrar_Adicionales : Form
    {
        public Administrar_Adicionales()
        {
            InitializeComponent();
        }

        public int IdAdicional = 0;
        public string accion = "";
        public string accion1 = "";
        private void NuevoButton_Click(object sender, EventArgs e)
        {
            NewOrUpdate("nuevo");
        }

        private void Administrar_Adicionales_Load(object sender, EventArgs e)
        {
            this.Location = new Point(200, 50);
            adicionalBindingSource.DataSource = Class1.devolverTabla("SELECT        Adicional.* FROM            Adicional where Estado is null");
            compraBindingSource.DataSource = Class1.devolverTabla("SELECT       dbo.Compra.IdCompra, dbo.Compra.NombreProveedor, dbo.Compra.Nit, dbo.Compra.ValorCompra, dbo.Compra.FechaCompra FROM            dbo.Adicional INNER JOIN                          dbo.Compra ON dbo.Adicional.IdCompra = dbo.Compra.IdCompra WHERE        (dbo.Adicional.Placa = '" + placaTextBox.Text + "')");
            Diseño();
            JuegoBotones();
            Articulos();
        }

        public void Diseño()
        {
            panel1.Left = (this.Width - panel1.Width) / 2;
            panel1.Top = (this.Height - panel1.Height) / 2;

        }

        public void JuegoBotones()
        {
            if (adicionalBindingSource.Count > 0)
            {
                NuevoButton.Enabled = true;
                GuardarButton.Enabled = false;
                CancelarButton.Enabled = false;
                EliminarButton.Enabled = true;
                BuscarButton.Enabled = true;
                EditarButton.Enabled = true;
            }
            else
            {
                NuevoButton.Enabled = true;
                GuardarButton.Enabled = false;
                CancelarButton.Enabled = false;
                EliminarButton.Enabled = false;
                BuscarButton.Enabled = false;
                EditarButton.Enabled = false;
            }
        }

        public void Articulos()
        {
            Class1.HacerConsulta("select NombreArticulo as n from Articulo");
            Class1.lector = Class1.comando.ExecuteReader();
            while (Class1.lector.Read())
            {
                ArticuloComboBox.Items.Add(Class1.lector["n"].ToString());
            }
            if (ArticuloComboBox.Items.Count > 0)
                ArticuloComboBox.Text = ArticuloComboBox.Items[0].ToString();
            Class1.conexion.Close();
        }

        private void CancelarButton_Click(object sender, EventArgs e)
        {
            foreach (Control item in this.Controls)
            {
                foreach (Control item2 in item.Controls)
                {
                    if (item2 is TextBox)
                    {
                        item2.Text = string.Empty;
                    }
                }
            }
            panelDatos.Enabled = false;
            NuevoButton.Enabled = true;
            CancelarButton.Enabled = false;
            GuardarButton.Enabled = false;
            EliminarButton.Enabled = false;
            BuscarButton.Enabled = true;
            Class1.placaAdicional = "";
            adicionalBindingSource.DataSource = Class1.devolverTabla("SELECT        Adicional.* FROM            Adicional where Estado is null");
            compraBindingSource.DataSource = Class1.devolverTabla("SELECT       dbo.Compra.IdCompra, dbo.Compra.NombreProveedor, dbo.Compra.Nit, dbo.Compra.ValorCompra, dbo.Compra.FechaCompra FROM            dbo.Adicional INNER JOIN                          dbo.Compra ON dbo.Adicional.IdCompra = dbo.Compra.IdCompra WHERE        (dbo.Adicional.Placa = '" + placaTextBox.Text + "')");
        }

        private void GuardarButton_Click(object sender, EventArgs e)
        {
            if (!validarCampos())
            {
                MessageBox.Show("Llene los campos");
                return;
            }
            int idCompra = 0;
            int idArticulo = 0;
            // MessageBox.Show(fechaCompraDateTimePicker.Value.ToString("yy-MM-dd"));
            try
            {
                if (accion1 == "nuevo")
                {
                    DateTime fecha;
                    fecha = fechaCompraDateTimePicker.Value.Date;
                    idCompra = Class1.InsertDevovliendoId("INSERT INTO Compra (NombreProveedor,Nit, ValorCompra,FechaCompra) values ('" + nombreProveedorTextBox.Text + "','" + nitTextBox.Text + "'," + Convert.ToDouble(valorCompraTextBox.Text) + ",'" + fecha.ToString("yyyy-MM-dd") + "') Select @@Identity as id");
                    idArticulo = Class1.devolverId("select IdArticulo as n from Articulo where NombreArticulo = '" + ArticuloComboBox.Text + "';");
                    Class1.HacerConsulta("INSERT INTO Adicional (IdArticulo, IdCompra, Marca, Modelo, Serial, Placa, Leasing) VALUES        (" + idArticulo + "," + idCompra + ",'" + marcaTextBox.Text + "','" + modeloTextBox.Text + "','" + serialTextBox.Text + "','" + placaTextBox.Text + "','" + leasingCheckBox.Checked.ToString() + "')");
                    Class1.comando.ExecuteNonQuery();
                    adicionalBindingSource.EndEdit();
                    MessageBox.Show("Adicional Agregado Correctamente");
                    CancelarButton_Click(sender, e);
                    adicionalBindingSource.DataSource = Class1.devolverTabla("SELECT        Adicional.* FROM            Adicional where Estado is null");
                    compraBindingSource.DataSource = Class1.devolverTabla("SELECT       dbo.Compra.IdCompra, dbo.Compra.NombreProveedor, dbo.Compra.Nit, dbo.Compra.ValorCompra, dbo.Compra.FechaCompra FROM            dbo.Adicional INNER JOIN                          dbo.Compra ON dbo.Adicional.IdCompra = dbo.Compra.IdCompra WHERE        (dbo.Adicional.Placa = '" + placaTextBox.Text + "')");
                }
                else
                {
                    Class1.HacerConsulta("update Adicional set Marca = '" + marcaTextBox.Text + "', Modelo = '" + modeloTextBox.Text + "', Serial = '" + serialTextBox.Text + "', Placa = '" + placaTextBox.Text + "', Leasing = '" + leasingCheckBox.Checked.ToString() + "' where IdAdicional = " + IdAdicional + "");
                    Class1.comando.ExecuteNonQuery();
                    Class1.HacerConsulta("update Compra set NombreProveedor = '" + nombreProveedorTextBox.Text + "', Nit = '" + nitTextBox.Text + "', ValorCompra = " + Convert.ToInt32(valorCompraTextBox.Text) + ", FechaCompra = '" + fechaCompraDateTimePicker.Value.ToString("yyyy-MM-dd") + "' where IdCompra = " + Convert.ToInt32(IdCompraTextBox.Text) + "");
                    Class1.comando.ExecuteNonQuery();
                    adicionalBindingSource.EndEdit();
                    MessageBox.Show("Adicional Editado Correctamente");
                    CancelarButton_Click(sender, e);
                    adicionalBindingSource.DataSource = Class1.devolverTabla("SELECT        Adicional.* FROM            Adicional where Estado is null");
                    compraBindingSource.DataSource = Class1.devolverTabla("SELECT       dbo.Compra.IdCompra, dbo.Compra.NombreProveedor, dbo.Compra.Nit, dbo.Compra.ValorCompra, dbo.Compra.FechaCompra FROM            dbo.Adicional INNER JOIN                          dbo.Compra ON dbo.Adicional.IdCompra = dbo.Compra.IdCompra WHERE        (dbo.Adicional.Placa = '" + placaTextBox.Text + "')");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al insertar un Adicional...." + ex);
            }
            JuegoBotones();


        }


        public Boolean validarCampos()
        {
            int contador = 0;
            foreach (Control item in panelDatos.Controls)
            {
                if (item is TextBox)
                {
                    if (item.Text != string.Empty)
                        contador++;
                }
            }
            if (contador == 7)
                return true;
            else
                return false;
        }

        private void BuscarButton_Click(object sender, EventArgs e)
        {
            var bad = new BuscarAdicional();
            bad.ShowDialog();
            if (Class1.placaAdicional != "")
            {
                NuevoButton.Enabled = false;
                CancelarButton.Enabled = true;
                EliminarButton.Enabled = true;
                BuscarButton.Enabled = false;
                EditarButton.Enabled = true;
                Class1.HacerConsulta("select * from Adicional where Placa = '" + Class1.placaAdicional + "' ");
                Class1.lector = Class1.comando.ExecuteReader();
                int idCompra = 0;
                while (Class1.lector.Read())
                {
                    marcaTextBox.Text = Class1.lector["Marca"].ToString();
                    modeloTextBox.Text = Class1.lector["modelo"].ToString();
                    serialTextBox.Text = Class1.lector["Serial"].ToString();
                    placaTextBox.Text = Class1.lector["Placa"].ToString();
                    if (Class1.lector["Leasing"].ToString() == "True")
                        leasingCheckBox.Checked = true;
                    else
                        leasingCheckBox.Checked = false;
                    idCompra = Convert.ToInt32(Class1.lector["IdCompra"].ToString());
                    IdAdicional = Convert.ToInt32(Class1.lector["IdAdicional"].ToString());
                    //leasingCheckBox.Checked = Class1.lector["Leasing"];
                }

                Class1.HacerConsulta("select * from Compra where IdCompra = " + idCompra + " ");
                Class1.lector = Class1.comando.ExecuteReader();
                while (Class1.lector.Read())
                {
                    nombreProveedorTextBox.Text = Class1.lector["NombreProveedor"].ToString();
                    nitTextBox.Text = Class1.lector["Nit"].ToString();
                    valorCompraTextBox.Text = Class1.lector["ValorCompra"].ToString();
                    fechaCompraDateTimePicker.Value = Convert.ToDateTime(Class1.lector["FechaCompra"]);
                }
            }
        }

        public string texto = "";

        private void EliminarButton_Click(object sender, EventArgs e)
        {

            if (validarEiliminadoLogico() == "")
            {
                MessageBox.Show("Debes de Escribir el Porque vas a Eliminar el Adicional", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                IdAdicional = Class1.devolverId("select IdAdicional as n From Adicional where Placa = " + placaTextBox.Text + "");
                Class1.HacerConsulta("update Adicional set Estado = '" + texto + "' where IdAdicional = " + IdAdicional + "");
                Class1.comando.ExecuteNonQuery();
                adicionalBindingSource.DataSource = Class1.devolverTabla("SELECT        Adicional.* FROM            Adicional where Estado is null");
                compraBindingSource.DataSource = Class1.devolverTabla("SELECT       dbo.Compra.IdCompra, dbo.Compra.NombreProveedor, dbo.Compra.Nit, dbo.Compra.ValorCompra, dbo.Compra.FechaCompra FROM            dbo.Adicional INNER JOIN                          dbo.Compra ON dbo.Adicional.IdCompra = dbo.Compra.IdCompra WHERE        (dbo.Adicional.Placa = '" + placaTextBox.Text + "')");
            }


            JuegoBotones();

        }

        public void NewOrUpdate(string accion)
        {
            panelDatos.Enabled = true;
            NuevoButton.Enabled = false;
            GuardarButton.Enabled = true;
            CancelarButton.Enabled = true;
            EditarButton.Enabled = false;
            EliminarButton.Enabled = false;
            BuscarButton.Enabled = false;
            if (accion == "nuevo")
            {
                marcaTextBox.Text = "";
                modeloTextBox.Text = "";
                serialTextBox.Text = "";
                placaTextBox.Text = "";
                leasingCheckBox.Checked = false;
                nombreProveedorTextBox.Text = "";
                nitTextBox.Text = "";
                valorCompraTextBox.Text = "";
                //Se limpian todos los campos y se crea espacio en memoria
                adicionalBindingSource.AddNew();
                //Se le indica al programa que la accion que va realizar es hacer un insert para poder guardarlo
                accion1 = "nuevo";
                marcaTextBox.Focus();
            }
            else
            {
                placaTextBox.Enabled = false;
                ArticuloComboBox.Enabled = false;
                //Se le indica al programa que la accion que va realizar es hacer un insert para poder guardarlo
                accion1 = "Editar";
                marcaTextBox.Focus();
            }
        }


        public string validarEiliminadoLogico()
        {
            return texto = Interaction.InputBox("Escribe El Proque Vas A Eliminar El Adicional", "Eliminar", "", -1, -1);
        }

        private void placaTextBox_Validating(object sender, CancelEventArgs e)
        {
            Class1.HacerConsulta("Select * from Adicional where Placa = '" + placaTextBox.Text + "'");
            Class1.lector = Class1.comando.ExecuteReader();
            if (Class1.lector.HasRows)
            {
                MessageBox.Show("La Placa ya esta registrada en otro Adicional");
                placaTextBox.Focus();
                return;
            }
        }

        private void SalirButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void marcaTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
        
            
            if (char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar))
                e.Handled = false;
            else
                e.Handled = true;
        
        }

        private void nombreProveedorTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) || char.IsControl(e.KeyChar) || char.IsSeparator(e.KeyChar))
                e.Handled = false;
            else
                e.Handled = true;
        }

        private void nitTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar) || e.KeyChar.ToString() == "-")
                e.Handled = false;
            else
                e.Handled = true;
        }

        private void valorCompraTextBox_KeyUp(object sender, KeyEventArgs e)
        {

        }

        private void Administrar_Adicionales_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void EditarButton_Click(object sender, EventArgs e)
        {
            NewOrUpdate("editar");
        }
    }
}
