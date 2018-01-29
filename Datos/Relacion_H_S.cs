using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace Datos
{
    public class Relacion_H_S
    {
        // private int placaEquipo;
        private List<E_Hardware> E_Hardware;
        private List<E_software> E_Software;
        private List<MantenimientoEquipos> MEquipos;

        public List<MantenimientoEquipos> MEquipos1
        {
            get { return MEquipos; }
            set { MEquipos = value; }
        }
    
        public List<E_Hardware> _E_Hardware
        {
            get { return E_Hardware; }
            set { E_Hardware = value; }
        }

        public List<E_software> _E_Software
        {
            get { return E_Software; }
            set { E_Software = value; }
        }

        public Relacion_H_S()
        {
            this.E_Hardware = new List<E_Hardware>();
            this.E_Software = new List<E_software>();
            this.MEquipos = new List<MantenimientoEquipos>();
        }

        public void agregarSoftware(E_software software)
        {
            this.E_Software.Add(software);
        }

        public void EditarSoftware()
        {
            while (Class1.lector.Read())
            {
                E_software s = new E_software();
                s.NombreSoftware = Class1.lector["NombreSoftware"].ToString();
                s.TipoSoftware = Class1.lector["TipoDeSoftware"].ToString();
                this._E_Software.Add(s);
            }
        }

        public void EditarHardware()
        {
            while (Class1.lector.Read())
            {
                E_Hardware h = new E_Hardware();
                h.articulo = Class1.lector["NombreArticulo"].ToString();
                h.Estado = Class1.lector["Estado"].ToString();
                h.leasing = Class1.lector["Leasing"].ToString();
                h.Marca = Class1.lector["Marca"].ToString();
                h.Modelo = Class1.lector["Modelo"].ToString();
                h.Placa = Convert.ToInt32(Class1.lector["Placa"].ToString());
                h.Serial = Class1.lector["Serial"].ToString();
                this.E_Hardware.Add(h);
            }
        }

        public void agregarMantenimiento(MantenimientoEquipos mante)
        {
            string f = Convert.ToDateTime(mante.FechaProxima).ToString("MMMM");
            mante.mes = f;
            this.MEquipos1.Add(mante);
        }
    }
}
