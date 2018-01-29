using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos.DataSet1TableAdapters;
using System.Data.SqlClient;
using System.Data;
using System.Collections;
using System.Windows.Forms;

namespace Datos
{
    public class Class1
    {
        //Adaptadores del dataset
        public static usuarioTableAdapter TAUsuario = new usuarioTableAdapter();
        public static Personal1TableAdapter TAPersonal = new Personal1TableAdapter();
        public static Cargo1TableAdapter TACargo = new Cargo1TableAdapter();
        public static Indenpendencia1TableAdapter TAIndependencia = new Indenpendencia1TableAdapter();
        public static Articulo1TableAdapter TAArticulo = new Articulo1TableAdapter();
        public static TipoSoftware1TableAdapter TATipoSoftware = new TipoSoftware1TableAdapter();
        public static Adicional1TableAdapter TAAdicional= new Adicional1TableAdapter();
        public static Equipo1TableAdapter TAEquipo = new Equipo1TableAdapter();
        public static Compra1TableAdapter TACompra= new Compra1TableAdapter();
        public static Software1TableAdapter TASoftware = new Software1TableAdapter();
        //public static Relacion_Equipo_AdicionalTableAdapter TAREquipoAdicional = new Relacion_Equipo_AdicionalTableAdapter();
        public static Restriccion1TableAdapter TArestriccion = new Restriccion1TableAdapter();

        //Objetos de conexion
        public static SqlCommand comando = new SqlCommand();
        public static SqlCommand comando2 = new SqlCommand();
        //public static SqlConnection conexion = new SqlConnection(Properties.Settings.Default.InventarioEquiposConnectionString);
        //public static SqlConnection conexion = new SqlConnection(Properties.Settings.Default.CadenaLocalDb);
        public static SqlConnection conexion = new SqlConnection(@"Server=(localdb)\MSSQLLocalDB;Integrated Security=true;AttachDbFileName=" + Application.StartupPath.ToString() + @"\InventarioEquipos.mdf");
        public static SqlDataReader lector = null;  


        //Metodos en Logica
        public static void HacerConsulta(string texto)
        {
            try
            {
                comando.CommandText = texto;
                comando.Connection = conexion;
                if (conexion.State == ConnectionState.Open)
                    conexion.Close();
                conexion.Open();
            }
            catch (Exception)
            {
                
                throw;
            }
            
        }

        public static int devolverId(string texto)
        {
            try
            {
                int id = 0;
                HacerConsulta(texto);
                lector = comando.ExecuteReader();
                while (lector.Read())
                {
                    id = Convert.ToInt32(lector["n"].ToString());
                }
                return id;
            }
            catch (Exception)
            {
                return 0;
            }
           
        }

        public static int InsertDevovliendoId(string texto)
        {
            try
            {
                int iddevuelve = 0;
                HacerConsulta(texto);
                lector = comando.ExecuteReader();
                while (lector.Read())
                {
                    iddevuelve = Convert.ToInt32(lector["id"]);
                }
                return iddevuelve;
            }
            catch (Exception)
            {
                return 0;
            }
        }

        public static DataTable devolverTabla(string consulta)
        {
            DataTable tabla = new DataTable();
            //SqlDataAdapter adaptador = new SqlDataAdapter();
            try
            {
                HacerConsulta(consulta);
                comando.ExecuteNonQuery();
                SqlDataAdapter adaptador = new SqlDataAdapter(comando);
                tabla.Clear();
                adaptador.Fill(tabla);
                return tabla;
            }
            catch (Exception ex)
            {
                string exs = ex.ToString();
                throw;
            }
        }


        public static string DevolverDato(string texto)
        {
            string dato="";
            HacerConsulta(texto);
            lector = comando.ExecuteReader();
            while (lector.Read())
            {
                 dato = lector["n"].ToString();
            }
            return dato;
            
        }


        //objetos en logica
        public static Relacion_H_S Relacion;
        public static DataTable tabla = new DataTable();
        public static DataTable tablaS = new DataTable();
        public static DataTable tablaBuscarEquipo = new DataTable();


        //---------------------------------Variables en Logica---------------------------------
        public static string ValidarSoftwareTabla = string.Empty;
        public static string ValidarHardwareTabla = string.Empty;
        public static Boolean devolverBusqueda;
        public static string EditarEquipo = "";
        //Esta variable sirve para llevar la informacion del adicional del buscar al principal
        public static string placaAdicional = "";
        //esta variable es para saber el id del equipo cuando se va a editar
        public static int idEquipoEditar = 0;
        public static ArrayList MantenimientoPc;
        public static Boolean confirmarMante = false;
        public static int idEquipoRevision = 0;

        //Esta variable sirve para llevar la informacion del Personal del buscar al principal
        public static string cedulapersonal = "";

    }
}
