using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;
using Microsoft.Office.Core;
using Word = Microsoft.Office.Interop.Word;
using System.Reflection;

namespace WindowsFormsApplication1
{
  
    public partial class ImpresionUnica : UserControl
    {

        public string currentNombrecCompleto;
        public string currentSeccion;
        public string currentNumero;
        public string currentCovocatoria;
        public string currentAnio;
        public string currentRne;
        public string currentApell;
        public string currentNombre;

        //variables para conexion base de datos
        SqlConnection conexion;
        SqlCommand comando;
        SqlDataReader dataReader;
       
        DataSet datos;

        public ImpresionUnica()
        {
           
            InitializeComponent();
            rneTb.MaxLength = 13;
            rneTb.CharacterCasing = CharacterCasing.Upper;
            datos = new DataSet();
            DataBase db = new DataBase();
            conexion = db.obtenerConexion();
             
        }

        public string comprobarDatos(string rne)
        {
            string estudiante = string.Empty;
            try
            {
                conexion.Open();
                comando = new SqlCommand("Select rne, nombres, apellidos, numeroOrden, Sabanas.seccion as seccion, "+
                                         "Sabanas.convocatoria as convocatoria, Sabanas.añoAcademico as añoAcademico "+
                                         " FROM Certificados  JOIN Sabanas ON Certificados.idSabana = Sabanas.idSabana "+
                                         "where rne = '" + rneTb.Text + "'", conexion);
                dataReader = comando.ExecuteReader();

            }

            catch (Exception ex) { MessageBox.Show("Error: " + ex.Message); }
            if (dataReader.Read() == true)
            {

                currentNombre = Convert.ToString(dataReader["nombres"]);
                Console.WriteLine(estudiante + " encontrado");

                currentApell = Convert.ToString(dataReader["apellidos"]);
                currentNombrecCompleto = Convert.ToString(dataReader["nombres"]) + " " + currentApell;
                currentSeccion = Convert.ToString(dataReader["seccion"]);
                currentNumero = Convert.ToString(dataReader["numeroOrden"]);
                currentAnio = Convert.ToString(dataReader["añoAcademico"]);
                currentCovocatoria = Convert.ToString(dataReader["convocatoria"]);
                currentRne = Convert.ToString(dataReader["rne"]);

                estudiante = currentNombre + " " + currentApell;

            }

            else {
                MessageBox.Show("Estudiante con rne " + rne + " no encontrado");
                rneTb.Text = "";
            }
               

            

            conexion.Close();
            dataReader.Close();
            return estudiante;



        }

        public void call() {

            if (rneTb.Text.Length < 13)
                MessageBox.Show("Rne incompleto", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            else
            {

                string estudiante = comprobarDatos(rneTb.Text);
                if (estudiante != "")
                {

                    estudentFound.Text = estudiante;
                    printBtn.Visible = true;
                    editBtn.Visible = true;

                }
            }
        }
        private void bunifuFlatButton6_Click(object sender, EventArgs e)
        {
            call();
        }
        public void imprimirDocumento(Word.Document document)
        {

            object copies = "1";
            object pages = "";
            object range = Word.WdPrintOutRange.wdPrintAllDocument;
            object items = Word.WdPrintOutItem.wdPrintDocumentContent;
            object pageType = Word.WdPrintOutPages.wdPrintAllPages;
            object oTrue = true;
            object oFalse = false;
            Object missing = Missing.Value;

            document.PrintOut(
                ref oTrue, ref oFalse, ref range, ref missing, ref missing, ref missing,
                ref items, ref copies, ref pages, ref pageType, ref oFalse, ref oTrue,
                ref missing, ref oFalse, ref missing, ref missing, ref missing, ref missing);

        }
        private void printBtn_Click(object sender, EventArgs e)
        {
            Printing pw;
            pw = new Printing();
            pw.Show();
            pw.progress.Maximum = 1;
           
            pw.all.Text = "1";
            pw.current.Text = "1";
            WordDocument document = new WordDocument();
            document.generarDocumento(currentNombrecCompleto, currentSeccion, currentNumero, currentAnio, currentCovocatoria, currentRne);

            pw.progress.Value = 1;
            pw.Hide();
        }

        private void editBtn_Click(object sender, EventArgs e)
        {
            Modificacion ModUnica = new Modificacion(1);
            ModUnica.BringToFront();
            ModUnica.Visible = true;
            ModUnica.rneTb.Text = currentRne;
            ModUnica.nombreTb.Text = currentNombre;
            //ModUnica.seccionTb.Text = currentSeccion;
            ModUnica.apellidosTb.Text = currentApell;
            ModUnica.numeroTb.Text = currentNumero;
           // ModUnica.anioAcaTb.Text = currentAnio;
           // ModUnica.ConvocatoriaComboBox.Text = currentCovocatoria;
            ModUnica.Visible = true;
        }

        private void rneTb_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar == (char)Keys.Enter))
            {
                call();
            }
        }

        private void ImpresionUnica_Load(object sender, EventArgs e)
        {
            rneTb.Focus();
        }
    }
}
