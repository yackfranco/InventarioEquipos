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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

       

        private void Menu_Load(object sender, EventArgs e)
        {

            Diseño();
            reiniciarMenu();

        }

        //funcion para no cerrar la ventana con alt + f4
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            return keyData == (Keys.Alt | Keys.F4);
        }

        public void Diseño()
        {
            ImagenPictureBox.Left = (panel3.Width - ImagenPictureBox.Width) / 2;
            ImagenPictureBox.Top = (panel3.Height - ImagenPictureBox.Height) / 2;

        }

        public void reiniciarMenu()
        {
            //Configuraciones
            ConfigButton.selected = false;
            panelConfig.Size = new Size(200, 50);

            //Equipos
            EquipoButton.selected = false;
            panelEquipos.Size = new Size(200, 50);

            //Seguridad
            SeguridadButton.selected = false;
            panelSeguridad.Size = new Size(200, 50);

            //Relaciones
            SeguridadButton.selected = false;
            panelRelaciones.Size = new Size(200, 50);
        }

        private void EquipoButton_Click(object sender, EventArgs e)
        {
            reiniciarMenu();
            panelEquipos.Size = new Size(200, 250);
        }

        private void ConfigButton_Click(object sender, EventArgs e)
        {
            reiniciarMenu();
            panelConfig.Size = new Size(200, 250);
        }

          private void SeguridadButton_Click(object sender, EventArgs e)
        {
            reiniciarMenu();
            panelSeguridad.Size = new Size(200, 200);
        }

        private void NuevoEquipoButton_Click(object sender, EventArgs e)
        {
            reiniciarSelect();
            NuevoEquipoButton.selected = true;
            var NuevoEquipo = new Equipo();
            NuevoEquipo.ShowDialog();
        }

        private void SalirButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            var login = new Login();
            login.ShowDialog(); 
        }

        private void ArticulosButton_Click(object sender, EventArgs e)
        {
            reiniciarSelect();
            ArticulosButton.selected = true;
            var articulos = new Administrar_Articulos();
            articulos.ShowDialog();
        }

        private void CargosButton_Click(object sender, EventArgs e)
        {
            reiniciarSelect();
            CargosButton.selected = true;
            var Cargos = new Cargos();
            Cargos.ShowDialog();
        }

        private void AdicionalesButton_Click(object sender, EventArgs e)
        {
            AdicionalesButton.selected = true;
            var Adicionales = new Administrar_Adicionales();
            Adicionales.ShowDialog();
        }

        private void ReportesButton_Click(object sender, EventArgs e)
        {
            reiniciarSelect();
            ReportesButton.selected = true;
            var Reportes = new Reportes();
            Reportes.ShowDialog();
        }

        private void MantenimientoButton_Click(object sender, EventArgs e)
        {
            reiniciarSelect();
            MantenimientoButton.selected = true;
            var Mantenimiento = new CMantenimiento();
            Mantenimiento.ShowDialog();
        }

        private void panel2_Click(object sender, EventArgs e)
        {
            reiniciarMenu();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            reiniciarMenu();
        }

        private void PersonalButton_Click(object sender, EventArgs e)
        {
            reiniciarSelect();
            PersonalButton.selected = true;
            var Personal = new Personal();
            Personal.ShowDialog();
        }

        private void DependenciasButton_Click(object sender, EventArgs e)
        {
            reiniciarSelect();
            DependenciasButton.selected = true;
            var Dependencias = new Dependencias();
            Dependencias.ShowDialog();
        }

        private void SoftwareButton_Click(object sender, EventArgs e)
        {
            reiniciarSelect();
            SoftwareButton.selected = true;
            var Software = new ConfigurarTipoSoftware();
            Software.ShowDialog();
        }

        public void reiniciarSelect()
        {
            ConfigButton.selected = false;
            CargosButton.selected = false;
            DependenciasButton.selected = false;
            SoftwareButton.selected = false;
            ArticulosButton.selected = false;

            EquipoButton.selected = false;
            NuevoEquipoButton.selected = false;
            MantenimientoButton.selected = false;
            AdicionalesButton.selected = false;

            SeguridadButton.selected = false;
            NuevoEquipoButton.selected = false;
            AccesosYRenstriccionesButton.selected = false;
            PersonalButton.selected = false;
        }

        private void AccesosYRenstriccionesButton_Click(object sender, EventArgs e)
        {
            reiniciarSelect();
            AccesosYRenstriccionesButton.selected = true;
            var ac = new Accesos();
            ac.ShowDialog();
        }

        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {
            reiniciarSelect();
            bunifuFlatButton3.selected = true;
            var usu = new Usuarios();
            usu.ShowDialog();
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            var relacion = new RelacionarAdicionalDependencia();
            relacion.ShowDialog();
        }

        private void RelacionesButton_Click(object sender, EventArgs e)
        {
            reiniciarMenu();
            panelRelaciones.Size = new Size(200, 200);
        }

        private void R_PersonalButton_Click(object sender, EventArgs e)
        {
            reiniciarSelect();
            R_PersonalButton.selected = true;
            var R_Perosonal = new RelaciarPersonalDependencia();
            R_Perosonal.ShowDialog();
        }

        private void R_AdicionalButton_Click(object sender, EventArgs e)
        {
            reiniciarSelect();
            R_AdicionalButton.selected = true;
            var R_Adicional = new RelacionarAdicionalDependencia();
            R_Adicional.ShowDialog();

        }

        private void R_EquipoButton_Click(object sender, EventArgs e)
        {
            reiniciarSelect();
            R_EquipoButton.selected = true;
            var R_Equipo = new RelacionarEquipoDependencia();
            R_Equipo.ShowDialog();
        }

        private void MinimizarButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void bunifuFlatButton1_Click_1(object sender, EventArgs e)
        {
            AcercaDe a = new AcercaDe();
            a.ShowDialog();
        }
    }
}

