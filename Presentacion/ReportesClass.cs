using Datos;
using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.Collections;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
namespace Presentacion
{
    public class ReportesClass
    {

        public string path = Application.StartupPath;

        public int idEquipo = 0;
        public int idPersonal = 0;
        public string fecha = "";
        public string nombrePersonal = "";
        public string observaciones = "";
        public string archivoFinal = "";


        //Reporte General de Dependencia
        public void ReporteGeneral(Reportes r)
        {
            try
            {
                // CopiarArchivo("ReporteGeneral.xlsx");
                string idEquipo = "";
                string rutaCopia = path + @"\ReporteGeneral.xlsx";

                //Se realiza el reporte
                using (ExcelPackage package = new ExcelPackage(new FileInfo(rutaCopia)))
                {
                    var worksheet = package.Workbook.Worksheets["Hoja1"];

                    //Datos Persona
                    Class1.HacerConsulta("SELECT dbo.Personal.Cedula, dbo.Personal.PrimerNombre, dbo.Personal.SegundoNombre, dbo.Personal.PrimerApellido, dbo.Personal.SegundoApellido,  dbo.Cargo.NombreCargo, dbo.Indenpendencia.NombreIndependencia FROM dbo.Cargo INNER JOIN dbo.Personal ON dbo.Cargo.IdCargo = dbo.Personal.IdCargo INNER JOIN dbo.Relacion_Dependencias ON dbo.Personal.IdPersonal = dbo.Relacion_Dependencias.IdPersonal INNER JOIN dbo.Indenpendencia ON dbo.Relacion_Dependencias.IdDependencia = dbo.Indenpendencia.IdIndependencia WHERE (dbo.Indenpendencia.NombreIndependencia = '" + r.DependenciaComboBox.Text + "') AND (dbo.Personal.Estado = 'Habilitado')");
                    //Class1.Class1
                    Class1.lector = Class1.comando.ExecuteReader();
                    while (Class1.lector.Read())
                    {
                        worksheet.Cells["p65"].Value = Class1.lector["Cedula"].ToString();
                        worksheet.Cells["B9"].Value = Class1.lector["primerNombre"].ToString() + " " + Class1.lector["SegundoNombre"].ToString() + " " + Class1.lector["PrimerApellido"].ToString() + " " + Class1.lector["SegundoApellido"].ToString();
                        worksheet.Cells["K65"].Value = Class1.lector["NombreCargo"].ToString();
                        worksheet.Cells["B10"].Value = Class1.lector["NombreCargo"].ToString();
                        worksheet.Cells["B11"].Value = Class1.lector["NombreIndependencia"].ToString();
                    }

                    //datos Equipo

                    Class1.HacerConsulta("SELECT dbo.Equipo.IdEquipo, dbo.Equipo.Marca, dbo.Equipo.Modelo, dbo.Equipo.Serial, dbo.Equipo.Placa, dbo.Equipo.Leasing, dbo.Indenpendencia.NombreIndependencia FROM dbo.Relacion_Dependencias INNER JOIN dbo.Equipo ON dbo.Relacion_Dependencias.IdEquipo = dbo.Equipo.IdEquipo INNER JOIN dbo.Indenpendencia ON dbo.Relacion_Dependencias.IdDependencia = dbo.Indenpendencia.IdIndependencia WHERE (dbo.Indenpendencia.NombreIndependencia = '" + r.DependenciaComboBox.Text + "') AND (dbo.Relacion_Dependencias.IdEquipo IS NOT NULL)");
                    Class1.lector = Class1.comando.ExecuteReader();
                    if (!Class1.lector.HasRows)
                    {
                        MessageBox.Show("No se puede hacer el Reporte de " + r.DependenciaComboBox.Text + " Por motivo de que no tiene equipo la dicha dependencia");
                        return;
                    }
                    while (Class1.lector.Read())
                    {
                        idEquipo = Class1.lector["IdEquipo"].ToString();
                        worksheet.Cells["B19"].Value = "PC";
                        worksheet.Cells["F19"].Value = Class1.lector["Marca"].ToString();
                        worksheet.Cells["K19"].Value = Class1.lector["Modelo"].ToString();
                        worksheet.Cells["N19"].Value = Class1.lector["Serial"].ToString();
                        worksheet.Cells["Q19"].Value = Class1.lector["Placa"].ToString();
                        worksheet.Cells["R19"].Value = Class1.lector["Leasing"].ToString();

                    }

                    //Datos Adicionales
                    Class1.HacerConsulta("SELECT dbo.Articulo.NombreArticulo,dbo.Adicional.Marca, dbo.Adicional.Modelo, dbo.Adicional.Serial, dbo.Adicional.Placa, dbo.Adicional.Leasing FROM dbo.Adicional INNER JOIN dbo.Articulo ON dbo.Adicional.IdArticulo = dbo.Articulo.IdArticulo INNER JOIN dbo.Relacion_Dependencias ON dbo.Adicional.IdAdicional = dbo.Relacion_Dependencias.IdAdicional INNER JOIN dbo.Indenpendencia ON dbo.Relacion_Dependencias.IdDependencia = dbo.Indenpendencia.IdIndependencia WHERE (dbo.Indenpendencia.NombreIndependencia = '" + r.DependenciaComboBox.Text + "') AND (dbo.Adicional.Estado IS NULL)");
                    Class1.lector = Class1.comando.ExecuteReader();
                    int num = 20;
                    while (Class1.lector.Read())
                    {
                        worksheet.Cells["B" + num.ToString() + ""].Value = Class1.lector["NombreArticulo"].ToString();
                        worksheet.Cells["F" + num.ToString() + ""].Value = Class1.lector["Marca"].ToString();
                        worksheet.Cells["K" + num.ToString() + ""].Value = Class1.lector["Modelo"].ToString();
                        worksheet.Cells["N" + num.ToString() + ""].Value = Class1.lector["Serial"].ToString();
                        worksheet.Cells["Q" + num.ToString() + ""].Value = Class1.lector["Placa"].ToString();
                        worksheet.Cells["R" + num.ToString() + ""].Value = Class1.lector["Leasing"].ToString();
                        num++;
                    }



                    //Datos Software

                    Class1.HacerConsulta("SELECT dbo.TipoSoftware.NombreTipo, dbo.Software.NombreSoftware FROM dbo.Software INNER JOIN dbo.TipoSoftware ON dbo.Software.IdTipoSoftware = dbo.TipoSoftware.IdTipoSoftware WHERE (dbo.Software.IdEquipo = " + idEquipo + ")");
                    Class1.lector = Class1.comando.ExecuteReader();
                    string cadena = "";
                    while (Class1.lector.Read())
                    {
                        cadena = cadena + Class1.lector["NombreTipo"].ToString() + ": " + Class1.lector["NombreSoftware"].ToString() + ", ";
                    }
                    worksheet.Cells["B34"].Value = cadena;
                    worksheet.Cells["C6"].Value = DateTime.Now.ToString("dd-MMMM-yyyy");
                    worksheet.Cells["C71"].Value = DateTime.Now.ToString("dd");
                    worksheet.Cells["D71"].Value = DateTime.Now.ToString("MM");
                    worksheet.Cells["E71"].Value = DateTime.Now.ToString("yyyy");

                    //Datos Restricciones
                    Class1.HacerConsulta("SELECT dbo.Restriccion.Google, dbo.Restriccion.Youtube, dbo.Restriccion.Hotmail, dbo.Restriccion.Facebook, dbo.Restriccion.Otro, dbo.Restriccion.InicioSesion, dbo.Restriccion.IClubSQL, dbo.Restriccion.ICajaSQL, dbo.Restriccion.IRecepcionSQL, dbo.Restriccion.IContabilidadLIFE, dbo.Restriccion.IParqueadero, dbo.Restriccion.ICorreoI, dbo.Restriccion.INomina FROM dbo.Indenpendencia INNER JOIN dbo.Restriccion ON dbo.Indenpendencia.IdIndependencia = dbo.Restriccion.IdIndependencia WHERE (dbo.Indenpendencia.NombreIndependencia = '" + r.DependenciaComboBox.Text + "')");
                    Class1.lector = Class1.comando.ExecuteReader();
                    string cadenaAcceso = "";
                    while (Class1.lector.Read())
                    {
                        worksheet.Cells["C43"].Value = (Class1.lector["Google"].ToString() == "True") ? "P" : "O";
                        worksheet.Cells["I43"].Value = (Class1.lector["Youtube"].ToString() == "True") ? "P" : "O";
                        worksheet.Cells["F43"].Value = (Class1.lector["Hotmail"].ToString() == "True") ? "P" : "O";
                        worksheet.Cells["L43"].Value = (Class1.lector["Facebook"].ToString() == "True") ? "P" : "O";
                        worksheet.Cells["O43"].Value = Class1.lector["Otro"].ToString();

                        cadenaAcceso = cadenaAcceso + ((Class1.lector["InicioSesion"].ToString() == "True") ? "Inicio Sesion, " : "");
                        cadenaAcceso = cadenaAcceso + ((Class1.lector["IClubSQL"].ToString() == "True") ? "Ingreso ClubSQL, " : "");
                        cadenaAcceso = cadenaAcceso + ((Class1.lector["ICajaSQL"].ToString() == "True") ? "Ingreso CajaSQL, " : "");
                        worksheet.Cells["E45"].Value = (cadenaAcceso.Length > 0) ? cadenaAcceso.Remove(cadenaAcceso.Length - 2) : cadenaAcceso;
                        cadenaAcceso = "";
                        cadenaAcceso = cadenaAcceso + ((Class1.lector["IRecepcionSQL"].ToString() == "True") ? "Ingreso RecepcionSQL, " : "");
                        cadenaAcceso = cadenaAcceso + ((Class1.lector["IContabilidadLIFE"].ToString() == "True") ? "Ingreso ContabilidadLIFE, " : "");
                        cadenaAcceso = cadenaAcceso + ((Class1.lector["IParqueadero"].ToString() == "True") ? "Ingreso Parqueadero, " : "");
                        worksheet.Cells["E46"].Value = (cadenaAcceso.Length > 0) ? cadenaAcceso.Remove(cadenaAcceso.Length - 2) : cadenaAcceso;
                        cadenaAcceso = "";
                        cadenaAcceso = cadenaAcceso + ((Class1.lector["ICorreoI"].ToString() == "True") ? "Ingreso Correo Institucional, " : "");
                        cadenaAcceso = cadenaAcceso + ((Class1.lector["INomina"].ToString() == "True") ? "Ingreso Nomina, " : "");
                        worksheet.Cells["E47"].Value = (cadenaAcceso.Length > 0) ? cadenaAcceso.Remove(cadenaAcceso.Length - 2) : cadenaAcceso;
                        cadenaAcceso = "";
                    }

                    Class1.HacerConsulta("SELECT dbo.Equipo.LanMessenger, dbo.Equipo.CorreoCorporativo FROM dbo.Equipo INNER JOIN dbo.Relacion_Dependencias ON dbo.Equipo.IdEquipo = dbo.Relacion_Dependencias.IdEquipo INNER JOIN dbo.Indenpendencia ON dbo.Relacion_Dependencias.IdDependencia = dbo.Indenpendencia.IdIndependencia WHERE (dbo.Indenpendencia.NombreIndependencia = '" + r.DependenciaComboBox.Text + "')");
                    Class1.lector = Class1.comando.ExecuteReader();
                    while (Class1.lector.Read())
                    {
                        worksheet.Cells["E41"].Value = Class1.lector["LanMessenger"].ToString();
                        worksheet.Cells["H40"].Value = Class1.lector["CorreoCorporativo"].ToString();
                    }

                    string filename = string.Format(@"ReporteGeneral.xlsx");
                    archivoFinal = Path.Combine(path + @"\reportes\", filename);
                    var file = new FileInfo(archivoFinal);
                    package.SaveAs(file);
                }
                System.Diagnostics.Process.Start(archivoFinal);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al crear Reporte General......" + ex);
                return;
            }

        }

        //acta de Entrada de un equipo a Dependencia
        public void Entra(string dependencia, string objeto)
        {
            try
            {


                // CopiarArchivo(@"INEntrega.xlsx");
                string rutaCopia = path + @"\INEntrega.xlsx";
                int idEquipo = 0;

                using (ExcelPackage package = new ExcelPackage(new FileInfo(rutaCopia)))
                {
                    string Elemento = "";
                    string Marca = "";
                    string Modelo = "";
                    string Serie = "";
                    string fecha = "";
                    string Observaciones = "";
                    var worksheet = package.Workbook.Worksheets["Hoja1"];

                    //Sacar el Nombre del Usuario
                    Class1.HacerConsulta("select CONCAT(dbo.Personal.PrimerNombre, ' ',dbo.Personal.SegundoNombre, ' ', dbo.Personal.PrimerApellido,' ', dbo.Personal.SegundoApellido) as NombreCompleto from Personal where IdPersonal = " + Class1.devolverId("SELECT dbo.Relacion_Dependencias.IdPersonal as n FROM dbo.Indenpendencia INNER JOIN dbo.Relacion_Dependencias ON dbo.Indenpendencia.IdIndependencia = dbo.Relacion_Dependencias.IdDependencia WHERE (dbo.Indenpendencia.NombreIndependencia = '" + dependencia + "') AND (dbo.Relacion_Dependencias.IdPersonal IS NOT NULL)") + "");
                    Class1.lector = Class1.comando.ExecuteReader();
                    while (Class1.lector.Read())
                    {
                        nombrePersonal = Class1.lector["NombreCompleto"].ToString();
                    }

                    //Validar si hay equipos en una dependencia
                    if (objeto == "Equipo")
                    {
                        Class1.HacerConsulta("SELECT dbo.Equipo.Marca, dbo.Equipo.Modelo, dbo.Equipo.Serial,  dbo.Relacion_Dependencias.FechaAgregado, dbo.Equipo.IdEquipo FROM            dbo.Equipo INNER JOIN                          dbo.Relacion_Dependencias ON dbo.Equipo.IdEquipo = dbo.Relacion_Dependencias.IdEquipo INNER JOIN                          dbo.Indenpendencia ON dbo.Relacion_Dependencias.IdDependencia = dbo.Indenpendencia.IdIndependencia WHERE        (dbo.Indenpendencia.NombreIndependencia = '" + dependencia + "') AND (dbo.Relacion_Dependencias.IdEquipo IS NOT NULL) AND (dbo.Equipo.Estado = 'Habilitado')");
                        Class1.lector = Class1.comando.ExecuteReader();
                        while (Class1.lector.Read())
                        {
                            Elemento = "Equipo";
                            Marca = Class1.lector["Marca"].ToString();
                            Modelo = Class1.lector["Modelo"].ToString();
                            Serie = Class1.lector["Serial"].ToString();
                            fecha = Convert.ToDateTime(Class1.lector["FechaAgregado"]).ToString("dd / MMMM / yyyy");
                            idEquipo = Convert.ToInt32(Class1.lector["IdEquipo"].ToString());
                        }

                        //Traer las observaciones de Mantenimiento
                        Class1.HacerConsulta("select Observaciones from Revision where IdEquipo = " + idEquipo + "");
                        Class1.lector = Class1.comando.ExecuteReader();
                        while (Class1.lector.Read())
                            Observaciones = Class1.lector["Observaciones"].ToString();

                    }
                    else
                    {
                        Class1.HacerConsulta("SELECT dbo.Articulo.NombreArticulo, dbo.Adicional.Marca, dbo.Adicional.Modelo, dbo.Adicional.Serial, dbo.Relacion_Dependencias.FechaAgregado, dbo.Adicional.IdAdicional FROM    dbo.Adicional INNER JOIN                          dbo.Articulo ON dbo.Adicional.IdArticulo = dbo.Articulo.IdArticulo INNER JOIN                          dbo.Relacion_Dependencias ON dbo.Adicional.IdAdicional = dbo.Relacion_Dependencias.IdAdicional INNER JOIN                          dbo.Indenpendencia ON dbo.Relacion_Dependencias.IdDependencia = dbo.Indenpendencia.IdIndependencia WHERE        (dbo.Relacion_Dependencias.IdAdicional IS NOT NULL) AND (dbo.Indenpendencia.NombreIndependencia = '" + dependencia + "') AND (dbo.Articulo.NombreArticulo = '" + objeto + "') AND (dbo.Adicional.Estado IS NULL)");
                        Class1.lector = Class1.comando.ExecuteReader();
                        while (Class1.lector.Read())
                        {
                            Elemento = Class1.lector["NombreArticulo"].ToString();
                            Marca = Class1.lector["Marca"].ToString();
                            Modelo = Class1.lector["Modelo"].ToString();
                            Serie = Class1.lector["Serial"].ToString();
                            fecha = Convert.ToDateTime(Class1.lector["FechaAgregado"]).ToString("dd / MMMM / yyyy");
                            idEquipo = Convert.ToInt32(Class1.lector["IdAdicional"].ToString());
                        }
                    }

                    worksheet.Cells["D8"].Value = dependencia;
                    worksheet.Cells["D9"].Value = nombrePersonal;
                    worksheet.Cells["B8"].Value = fecha;
                    worksheet.Cells["A12"].Value = "X";
                    worksheet.Cells["B12"].Value = Elemento;
                    worksheet.Cells["C12"].Value = Marca;
                    worksheet.Cells["D12"].Value = Modelo;
                    worksheet.Cells["E12"].Value = Serie;
                    worksheet.Cells["B20"].Value = Observaciones;

                    string filename = string.Format(@"INEntrega.xlsx");
                    archivoFinal = Path.Combine(path + @"\reportes\", filename);
                    var file = new FileInfo(archivoFinal);
                    package.SaveAs(file);
                }
                System.Diagnostics.Process.Start(archivoFinal);

            }
            catch (Exception)
            {

            }

        }

        //Reporte Mantenimiento
        public void ReporteMantenimiento(string dependencia)
        {
            //CopiarArchivo(@"Mant Equipos.xlsx");
            string rutaCopia = path + @"\Mant Equipos.xlsx";

            using (ExcelPackage package = new ExcelPackage(new FileInfo(rutaCopia)))
            {
                var worksheet = package.Workbook.Worksheets["Hoja1"];


                //_________________________________________SEGUIR AQUI REVISANDO_____________________________________
                //Tira el idEquipo de la Dependencia
                idEquipo = Class1.devolverId("SELECT dbo.Relacion_Dependencias.IdEquipo as n FROM dbo.Indenpendencia INNER JOIN dbo.Relacion_Dependencias ON dbo.Indenpendencia.IdIndependencia = dbo.Relacion_Dependencias.IdDependencia WHERE (dbo.Indenpendencia.NombreIndependencia = '" + dependencia + "') AND (dbo.Relacion_Dependencias.IdEquipo IS NOT NULL)");

                //Tira el idpersonal de la Dependencia
                idPersonal = Class1.devolverId("SELECT dbo.Relacion_Dependencias.IdPersonal as n FROM dbo.Indenpendencia INNER JOIN dbo.Relacion_Dependencias ON dbo.Indenpendencia.IdIndependencia = dbo.Relacion_Dependencias.IdDependencia WHERE (dbo.Indenpendencia.NombreIndependencia = '" + dependencia + "') AND (dbo.Relacion_Dependencias.IdPersonal IS NOT NULL)");

                //Sacar Fecha del ultimo mantenimiento
                Class1.HacerConsulta("SELECT dbo.Revision.IdRevision, dbo.Revision.IdEquipo, dbo.Revision.FechaRevision, dbo.Revision.ProximaRevision, dbo.Revision.Observaciones FROM            dbo.Revision INNER JOIN                          dbo.Equipo ON dbo.Revision.IdEquipo = dbo.Equipo.IdEquipo WHERE        (dbo.Revision.FechaRevision = (SELECT MAX(FechaRevision) AS Expr1 FROM dbo.Revision AS Revision_1 WHERE (IdEquipo = " + idEquipo + "))) AND (dbo.Equipo.Estado = 'Habilitado')");
                Class1.lector = Class1.comando.ExecuteReader();
                while (Class1.lector.Read())
                {
                    fecha = Class1.lector["FechaRevision"].ToString();
                }
                try
                {
                    fecha = Convert.ToDateTime(fecha).ToString("dd / MMMM / yyyy");
                }
                catch (Exception)
                {
                    MessageBox.Show("No has hecho ningun Mantenimiento de esta dependencia");
                    return;
                }

                //Sacar el Nombre del Usuario
                Class1.HacerConsulta("select CONCAT(dbo.Personal.PrimerNombre, ' ',dbo.Personal.SegundoNombre, ' ', dbo.Personal.PrimerApellido,' ', dbo.Personal.SegundoApellido) as NombreCompleto from Personal where IdPersonal = " + idPersonal + "");
                Class1.lector = Class1.comando.ExecuteReader();
                while (Class1.lector.Read())
                {
                    nombrePersonal = Class1.lector["NombreCompleto"].ToString();
                }

                //Sacar el numero de Placa del pc
                Class1.HacerConsulta("select * from equipo where idEquipo = " + idEquipo + " ");
                string placa = "";
                Class1.lector = Class1.comando.ExecuteReader();
                while (Class1.lector.Read())
                {
                    placa = Class1.lector["Placa"].ToString();
                }

                //Sacar la observacion del Mantenimiento
                Class1.HacerConsulta("select * from revision where FechaRevision = (select max(FechaRevision) from revision) and idequipo = " + idEquipo + "");
                Class1.lector = Class1.comando.ExecuteReader();
                while (Class1.lector.Read())
                {
                    observaciones = Class1.lector["Observaciones"].ToString();
                }

                worksheet.Cells["B6"].Value = fecha;
                worksheet.Cells["B7"].Value = dependencia;
                worksheet.Cells["B8"].Value = nombrePersonal;
                worksheet.Cells["F6"].Value = placa;
                worksheet.Cells["B16"].Value = observaciones;

                string filename = string.Format(@"Mant Equipos.xlsx");
                archivoFinal = Path.Combine(path + @"\reportes\", filename);
                var file = new FileInfo(archivoFinal);
                package.SaveAs(file);
            }
            System.Diagnostics.Process.Start(archivoFinal);
        }


        public void Retira(string dependencia, string objeto)
        {
            try
            {
                //CopiarArchivo(@"INEntrega.xlsx");
                string rutaCopia = path + @"\INRetira.xlsx";
                int idEquipo = 0;
                int idRetiro = 0;


                using (ExcelPackage package = new ExcelPackage(new FileInfo(rutaCopia)))
                {
                    //string Elemento = "";
                    nombrePersonal = "";
                    string Marca = "";
                    string Modelo = "";
                    string Serie = "";
                    var worksheet = package.Workbook.Worksheets["Hoja1"];

                    //Sacar el Nombre del Usuario
                    Class1.HacerConsulta("select CONCAT(dbo.Personal.PrimerNombre, ' ',dbo.Personal.SegundoNombre, ' ', dbo.Personal.PrimerApellido,' ', dbo.Personal.SegundoApellido) as NombreCompleto from Personal where IdPersonal = " + Class1.devolverId("SELECT dbo.Relacion_Dependencias.IdPersonal as n FROM dbo.Indenpendencia INNER JOIN dbo.Relacion_Dependencias ON dbo.Indenpendencia.IdIndependencia = dbo.Relacion_Dependencias.IdDependencia WHERE (dbo.Indenpendencia.NombreIndependencia = '" + dependencia + "') AND (dbo.Relacion_Dependencias.IdPersonal IS NOT NULL)") + "");
                    Class1.lector = Class1.comando.ExecuteReader();
                    while (Class1.lector.Read())
                    {
                        nombrePersonal = Class1.lector["NombreCompleto"].ToString();
                    }

                    if (nombrePersonal == string.Empty)
                    {
                        if (MessageBox.Show("La Dependencia no tiene relacionada un Usuario, quieres Seguir el Reporte?", "Importante", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.Cancel)
                            return;
                    }


                    //Validar si hay equipos en una dependencia
                    if (objeto == "Equipo")
                    {
                        //Se selecciona la fecha de retiro y el id del equipo para obtener la info del mismo
                        int idDependencia = Class1.devolverId("select IdIndependencia as n from Indenpendencia where NombreIndependencia = '" + dependencia + "'");
                        Class1.HacerConsulta("select top (1) * from Retiro where IdIndependencia = " + idDependencia + " order by FechaRetiro DESC;");
                        Class1.lector = Class1.comando.ExecuteReader();
                        while (Class1.lector.Read())
                        {
                            fecha = Convert.ToDateTime(Class1.lector["FechaRetiro"]).ToString("dd / MMMM / yyyy");
                            idEquipo = Convert.ToInt32(Class1.lector["IdEquipo"].ToString());
                            idRetiro = Convert.ToInt32(Class1.lector["IdRetiro"].ToString());
                        }

                        //Con el id se optiene la info
                        Class1.HacerConsulta("SELECT Marca, Modelo, Serial FROM            dbo.Equipo WHERE        (IdEquipo = " + idEquipo + ")");
                        Class1.lector = Class1.comando.ExecuteReader();
                        while (Class1.lector.Read())
                        {
                            Serie = Class1.lector["Serial"].ToString();
                            Marca = Class1.lector["Marca"].ToString();
                            Modelo = Class1.lector["Modelo"].ToString();
                        }

                        //Se obtiene las observaciones que se han hecho en la ulima revision de un equipo
                        Class1.HacerConsulta("SELECT        Observaciones FROM            dbo.Revision WHERE        (FechaRevision =                              (SELECT        MAX(FechaRevision) AS Expr1                                FROM            dbo.Revision AS Revision_1)) AND (IdEquipo = " + idEquipo + ")");
                        Class1.lector = Class1.comando.ExecuteReader();
                        while (Class1.lector.Read())
                        {
                            observaciones = Class1.lector["observaciones"].ToString();
                        }
                    }
                    else
                    {

                        Class1.HacerConsulta("SELECT        (SELECT        MAX(dbo.Retiro.FechaRetiro) AS Fecha) AS Fecha FROM            dbo.Retiro INNER JOIN                          dbo.Adicional ON dbo.Retiro.IdAdicional = dbo.Adicional.IdAdicional INNER JOIN                          dbo.Articulo ON dbo.Adicional.IdArticulo = dbo.Articulo.IdArticulo INNER JOIN                          dbo.Indenpendencia ON dbo.Retiro.IdIndependencia = dbo.Indenpendencia.IdIndependencia WHERE        (dbo.Articulo.NombreArticulo = '" + objeto + "') AND (dbo.Indenpendencia.NombreIndependencia = '" + dependencia + "')");
                        Class1.lector = Class1.comando.ExecuteReader();
                        while (Class1.lector.Read())
                        {
                            fecha = Convert.ToDateTime(Class1.lector["Fecha"]).ToString("dd / MMMM / yyyy");
                        }

                        Class1.HacerConsulta("SELECT        dbo.Adicional.Marca, dbo.Adicional.Modelo, dbo.Adicional.Serial, dbo.Adicional.Placa FROM            dbo.Adicional INNER JOIN                          dbo.Articulo ON dbo.Adicional.IdArticulo = dbo.Articulo.IdArticulo WHERE        (dbo.Articulo.NombreArticulo = '" + objeto + "')");
                        Class1.lector = Class1.comando.ExecuteReader();
                        while (Class1.lector.Read())
                        {
                            Serie = Class1.lector["Serial"].ToString();
                            Marca = Class1.lector["Marca"].ToString();
                            Modelo = Class1.lector["Modelo"].ToString();
                        }
                    }

                    worksheet.Cells["D8"].Value = dependencia;
                    worksheet.Cells["D9"].Value = nombrePersonal;
                    worksheet.Cells["B8"].Value = fecha;
                    worksheet.Cells["A12"].Value = "X";
                    worksheet.Cells["B12"].Value = objeto;
                    worksheet.Cells["C12"].Value = Marca;
                    worksheet.Cells["D12"].Value = Modelo;
                    worksheet.Cells["E12"].Value = Serie;
                    worksheet.Cells["C19"].Value = observaciones;

                    string filename = string.Format(@"INRetira.xlsx");
                    archivoFinal = Path.Combine(path + @"\reportes\", filename);
                    var file = new FileInfo(archivoFinal);
                    package.SaveAs(file);
                }
                System.Diagnostics.Process.Start(archivoFinal);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al abrir reporte de retiro de un equipo a una Dependencia....." + ex);
            }
        }


        public void ReporteTodo()
        {
            try
            {
                string rutaCopia = path + @"\ReporteTodo.xlsx";

                int contador = 10;

                ArrayList lista = new ArrayList();

                using (ExcelPackage package = new ExcelPackage(new FileInfo(rutaCopia)))
                {
                    var worksheet = package.Workbook.Worksheets["Hoja1"];

                    //Se traen todas las dependencias
                    Class1.HacerConsulta("select * from Indenpendencia");
                    Class1.lector = Class1.comando.ExecuteReader();
                    while (Class1.lector.Read())
                    {
                        lista.Add(Class1.lector["NombreIndependencia"].ToString());
                    }

                    worksheet.Cells["C6"].Value = DateTime.Now.ToString("dd-MMMM-yyyy");

                    //se tienen las dependencias
                    foreach (string Dependencia in lista)
                    {
                        worksheet.Cells["B" + contador].Value = "Dependencia";
                        worksheet.Cells["B" + contador].Style.Font.Bold = true;
                        worksheet.Cells["F" + contador].Value = Dependencia;
                       

                        worksheet.Cells["N" + contador].Value = "Persona Encargado";
                        worksheet.Cells["N" + contador].Style.Font.Bold = true;
                        worksheet.Cells["Q" + contador].Value = Class1.DevolverDato("SELECT CONCAT(     dbo.Personal.PrimerNombre,' ', dbo.Personal.SegundoNombre,' ', dbo.Personal.PrimerApellido,' ', dbo.Personal.SegundoApellido) as n  FROM            dbo.Indenpendencia INNER JOIN                          dbo.Relacion_Dependencias ON dbo.Indenpendencia.IdIndependencia = dbo.Relacion_Dependencias.IdDependencia INNER JOIN                          dbo.Personal ON dbo.Relacion_Dependencias.IdPersonal = dbo.Personal.IdPersonal WHERE        (dbo.Indenpendencia.NombreIndependencia = '" + Dependencia + "')");

                        //Otro renglon
                        contador++;

                        worksheet.Cells["B" + contador].Value = "Equipo";
                        worksheet.Cells["B" + contador].Style.Font.Bold = true;
                        Class1.HacerConsulta("SELECT        dbo.Equipo.Placa, dbo.Equipo.Modelo, dbo.Equipo.Marca, dbo.Equipo.Serial FROM            dbo.Equipo INNER JOIN                          dbo.Relacion_Dependencias ON dbo.Equipo.IdEquipo = dbo.Relacion_Dependencias.IdEquipo INNER JOIN                          dbo.Indenpendencia ON dbo.Relacion_Dependencias.IdDependencia = dbo.Indenpendencia.IdIndependencia WHERE        (dbo.Indenpendencia.NombreIndependencia = '" + Dependencia + "') AND (dbo.Equipo.Baja IS NULL)");
                        Class1.lector = Class1.comando.ExecuteReader();
                        while (Class1.lector.Read())
                        {
                            worksheet.Cells["F" + contador].Value = "Placa:  " + Class1.lector["Placa"].ToString();
                            worksheet.Cells["K" + contador].Value = "Marca:  " + Class1.lector["Marca"].ToString();
                            worksheet.Cells["N" + contador].Value = "Modelo:  " + Class1.lector["Modelo"].ToString();
                            worksheet.Cells["Q" + contador].Value = "Serial:  " + Class1.lector["Serial"].ToString();
                        }

                        //Otro renglon
                        contador++;

                        worksheet.Cells["B" + contador].Value = "Software del Equipo";
                        worksheet.Cells["B" + contador].Style.Font.Bold = true;
                        worksheet.Cells["F" + contador + ":T" + contador + ""].Merge = true;

                        Class1.HacerConsulta("SELECT        dbo.Software.NombreSoftware, dbo.TipoSoftware.NombreTipo FROM            dbo.Equipo INNER JOIN                          dbo.Relacion_Dependencias ON dbo.Equipo.IdEquipo = dbo.Relacion_Dependencias.IdEquipo INNER JOIN                          dbo.Indenpendencia ON dbo.Relacion_Dependencias.IdDependencia = dbo.Indenpendencia.IdIndependencia INNER JOIN                          dbo.Software ON dbo.Equipo.IdEquipo = dbo.Software.IdEquipo INNER JOIN                          dbo.TipoSoftware ON dbo.Software.IdTipoSoftware = dbo.TipoSoftware.IdTipoSoftware WHERE        (dbo.Indenpendencia.NombreIndependencia = '" + Dependencia + "')");
                        Class1.lector = Class1.comando.ExecuteReader();
                        string cadena = "";
                        while (Class1.lector.Read())
                        {
                            cadena = cadena + Class1.lector["NombreTipo"].ToString() + ": " + Class1.lector["NombreSoftware"].ToString() + ", ";
                        }
                        worksheet.Cells["F" + contador].Value = cadena;

                        //Adicionales
                        Class1.HacerConsulta("SELECT        dbo.Adicional.Placa, dbo.Adicional.Serial, dbo.Adicional.Modelo, dbo.Adicional.Marca, dbo.Articulo.NombreArticulo FROM            dbo.Adicional INNER JOIN                          dbo.Articulo ON dbo.Adicional.IdArticulo = dbo.Articulo.IdArticulo INNER JOIN                          dbo.Relacion_Dependencias ON dbo.Adicional.IdAdicional = dbo.Relacion_Dependencias.IdAdicional INNER JOIN                          dbo.Indenpendencia ON dbo.Relacion_Dependencias.IdDependencia = dbo.Indenpendencia.IdIndependencia WHERE        (dbo.Indenpendencia.NombreIndependencia = '" + Dependencia + "') AND (dbo.Adicional.Estado IS NULL)");
                        Class1.lector = Class1.comando.ExecuteReader();
                        while (Class1.lector.Read())
                        {
                            contador++;
                            worksheet.Cells["B" + contador].Value = Class1.lector["NombreArticulo"].ToString();
                            worksheet.Cells["B" + contador].Style.Font.Bold = true;
                            worksheet.Cells["F" + contador].Value = "Placa:  " + Class1.lector["Placa"].ToString();
                            worksheet.Cells["K" + contador].Value = "Marca:  " + Class1.lector["Marca"].ToString();
                            worksheet.Cells["N" + contador].Value = "Modelo:  " + Class1.lector["Modelo"].ToString();
                            worksheet.Cells["Q" + contador].Value = "Serial:  " + Class1.lector["Serial"].ToString();
                        }

                        contador = contador + 3;
                    }

                    string filename = string.Format(@"ReporteTodo.xlsx");
                    archivoFinal = Path.Combine(path + @"\reportes\", filename);
                    var file = new FileInfo(archivoFinal);
                    package.SaveAs(file);
                }
                System.Diagnostics.Process.Start(archivoFinal);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al Realizar el Reporte, por favor verifique si hay un Archivo de la misma extencion xlsx....." + ex);
            }

        }
    }
}
