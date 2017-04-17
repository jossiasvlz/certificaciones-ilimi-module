using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Collections;
using System.Threading;

namespace WindowsFormsApplication1
{
    public partial class ImpresionSabana : UserControl
    {
        int cantidad = 0;

        SqlConnection conexion;
        SqlCommand comando;
        SqlDataAdapter adapter;
        DataSet loteCertificados;
        string Query;
        Printing pw;

        public ImpresionSabana()
        {
            InitializeComponent();
         
            DataBase db = new DataBase();
            conexion = db.obtenerConexion();
             
        }

        public void recorreCertFromDS() {
            string nombre;
            WordDocument documento = new WordDocument();
            ArrayList loteDocumentos = new ArrayList();
            pw = new Printing();
            pw.Show();
            pw.progress.Maximum = cantidad;
            int count = 1;
            pw.all.Text = cantidad.ToString();
            foreach (DataRow region in loteCertificados.Tables[0].Rows)
            {
                
                nombre = region["nombres"].ToString() + " " + region["apellidos"].ToString();
                pw.progress.Value = count;
                pw.current.Text = count.ToString();
            
                
                loteDocumentos.Add(documento.generarDocumento(nombre,

                                          region["seccion"].ToString(),
                                          region["numeroOrden"].ToString(),
                                          region["añoAcademico"].ToString(),
                                          region["convocatoria"].ToString(),
                                          region["rne"].ToString())
                               );

                count++;
            }
            Thread.Sleep(1000);
            //pw.progress.Maximum = 0;
            //pw.progress.Value = 0;
            pw.Hide();
            
        }
        public void go() {
            if (InvokeRequired)
            {
                Invoke(new Action(() => recorreCertFromDS()));

            }

        }

        private void r() {
           // Printing p = new Printing();
            pw.Show();
        }

        public void p() {
            if (InvokeRequired)
            {
                Invoke(new Action(() => r()));

            }
            

        }
        public void getCertFromDB() {
            Thread t = new Thread(go);
            Thread printingLog = new Thread(p);
            if (cantidad == 0)
                MessageBox.Show("No se ha encontrado ningun registros con esos datos", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);   
            else if (cantidad > 1)
            {
                Query = "Select rne, nombres, apellidos, numeroOrden, Sabanas.seccion as seccion, Sabanas.convocatoria as convocatoria, Sabanas.añoAcademico as añoAcademico FROM Certificados JOIN Sabanas ON Certificados.idSabana = Sabanas.idSabana WHERE '"+codigoSabana.Text+"'"; ///AQUII
                try
                {
                    
                    comando = new SqlCommand(Query, conexion);
                    loteCertificados = new DataSet();
                    adapter = new SqlDataAdapter(comando);
                    adapter.Fill(loteCertificados,"Certificados");

                    
                    //printingLog.Start();
                    t.Start();
                    
                    //printingLog.Suspend();
                    //pw.Visible = false ;
                 
                }
                catch (Exception ex) {
                    MessageBox.Show(ex.Message);
                }
                
            }
            else
            {
                MessageBox.Show("No existe la cantidad de certificados requerida"
                    +"para generar lote. Imprima mediante impresion única",
                    "Aviso",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            conexion.Close();
            
        }

        private void bunifuFlatButton6_Click(object sender, EventArgs e)
        {
           
            if (codigoSabana.Text != "")
            {

                try
                {
                    conexion.Open();
                    comando = new SqlCommand("SELECT COUNT(*) FROM Sabanas WHERE codigoSabana = '" + codigoSabana.Text + "'", conexion);
                    cantidad = Convert.ToInt32(comando.ExecuteScalar());
                    getCertFromDB();

                }
                catch (Exception ex) { MessageBox.Show(ex.Message); }

                finally
                {
                    conexion.Close();
                }
                OperacionesCertificados grupo = new OperacionesCertificados();

            }
            else 
                MessageBox.Show("Completa todos los campos");
        }

        public bool formatoAnio(String anio)
        {
            bool reslt = false;
            string[] yearString;
            int[] years = new int[2];
            try
            {
                yearString = anio.Split('-');
                years[0] = Convert.ToInt32(yearString[0]);
                years[1] = Convert.ToInt32(yearString[1]);
            if (years[1] - years[0] == 1)
                    reslt = true;
                else
                    reslt = false;
            }
            catch (Exception ex) {
                MessageBox.Show("Error: " + ex.Message);
            }

            return reslt;   
           
        }

        private void rneTb_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((char.IsNumber(e.KeyChar)))
            {
                MessageBox.Show("No se permite caracteres numéricos",
                    "Advertencia", MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void ImpresionSabana_Load(object sender, EventArgs e)
        {
          
        }

        private void codigoSabana_Click(object sender, EventArgs e)
        {
            codigoSabana.Text = "";
        }
    }
}
