
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;


namespace WindowsFormsApplication1
{
    class OperacionesCertificados
    {
        SqlConnection conexion;
        SqlCommand comando;
        SqlDataReader dataReader;
     


        public OperacionesCertificados() {
            DataBase db = new DataBase();
            conexion = db.obtenerConexion();

        }

        public bool numeroOcupadoEnSeccion(string rne,string numero, string seccion, string convocatoria)
        {
            int contador = 0;
            try
            {
                conexion.Open();
                comando = new SqlCommand("SELECT COUNT(*) FROM Certificados WHERE numeroOrden = '" +
                               numero + "' and seccion = '" +
                               seccion + "' and convocatoria = '" +
                               convocatoria+ "' and rne != '"+rne+"'", conexion);
                contador = Convert.ToInt32(comando.ExecuteScalar());
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
              
                conexion.Close();
            }
            if (contador > 0)
                return false;
            else
                return true;
        }

        public bool numeroOcupadoEnSeccion( string idSabana, string numero)
        {
            int contador = 0;
            try
            {
                conexion.Open();
                comando = new SqlCommand("SELECT COUNT(*) FROM Sabanas WHERE numeroOrden = '"+numero+"' and idSabana ='"+idSabana+"'",   conexion);
                contador = Convert.ToInt32(comando.ExecuteScalar());
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {

                conexion.Close();
            }
            if (contador > 0)
                return false;
            else
                return true;
        }

        public object[] consultarSabana(string codigoSabana)
        {
           
            
            object[] resultados = new object[3];
            
            try
            {
                
                conexion.Open();
                comando = new SqlCommand("Select * from Sabanas where codigoSabana = '" + codigoSabana + "'", conexion);
                dataReader = comando.ExecuteReader();

            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }

          
            if (dataReader.Read())
            {
                resultados[0] = Convert.ToString(dataReader["seccion"]); //seccion
                resultados[1] = Convert.ToString(dataReader["convocatoria"]); //convocatoria
                resultados[2] = Convert.ToString(dataReader["añoAcademico"]); //ano academico

                try
                {
                    byte[] imgData = System.IO.File.ReadAllBytes(dataReader["imagenSabana"].ToString());
                    Image newImage;
                    using (MemoryStream ms = new MemoryStream(imgData, 0, imgData.Length))
                    {

                        ms.Write(imgData, 0, imgData.Length);
                        newImage = Image.FromStream(ms, true);
                        resultados[3] = newImage;
                    }
                }
                catch (Exception ex) { MessageBox.Show(ex.Message); }


               

            }

            conexion.Close();
           

            return resultados;
        }

        public void insertarPalabraAutocomplete(string identificador, string palabra) {

            try
            {
                comando = new SqlCommand("INSERT INTO[dbo].[palabrasAutocomplete] (['"+ identificador +"'])  VALUES ('"+ palabra +"')", conexion);
                comando.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        public int updateCertificado(string rne, string nombres, string apellidos, 
                                      string numeroOrden, string idSabana)
        {
            int inseted = 0;
            try
            {
                conexion.Open();
                comando = new SqlCommand("UPDATE [dbo].[Certificados] SET[rne] = '" + rne + "'" +
                                        ",[nombres] = '" + nombres + "'" +
                                         ",[apellidos] = '" + apellidos + "'" +
                                         ",[numeroOrden] = '" + numeroOrden + "'" +
                                         ",[idSabana] = '"+ idSabana +"'"+
                                        "WHERE rne = '" + rne + "' ",conexion);

                comando.ExecuteNonQuery();
                MessageBox.Show("El estudiante " + nombres + " " + apellidos + " ha sido modificado correctamente", 
                                "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                inseted = 1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conexion.Close();
            }
            return inseted;
        }


        public  int insertarCertficado(string rne, string nombres, string apellidos, string numeroOrden, string idSabana)
        {
            int res = 0;
            try
            {
                conexion.Open();
                comando = new SqlCommand("insert into [dbo].[Certificados]([rne],[nombres],[apellidos],"+
                                        "[numeroOrden],[idSabana]" +
                                        ",[convocatoria]) values('" + rne + "','" +
                                        nombres + "','" + apellidos + "','" + numeroOrden + 
                                        "','" + idSabana + "' );", conexion);

                comando.ExecuteNonQuery();
                res = 1;

                //insertarPalabraAutocomplete("rne_palabra",rne);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conexion.Close();
            }

            return res;

        }


        

        public int comprobarRedundancia(string rne)
        {

            int contador = 0;
            try
            {
                conexion.Open();
                comando = new SqlCommand("select * from certificados where rne ='" + rne + "'", conexion);
                dataReader = comando.ExecuteReader();

                while (dataReader.Read())
                {
                    contador++;
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
               dataReader.Close();
                conexion.Close();
            }
            return contador;
        }
    }


}
