using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Office.Core;
using Word = Microsoft.Office.Interop.Word;
using System.Reflection;
using System.Collections;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    class WordDocument
    {

        public WordDocument()
        {




        }



        public Word.Document generarDocumento(string nombre, string seccion, string numero, string anio, string convocatoria, string rne) {

            String path = @"C:\Users\joshua\Documents\Visual Studio 2015\Projects\WindowsFormsApplication1\WindowsFormsApplication1\Saved\Plantilla Certificacion.dotx";
            Object ObjMiss = Missing.Value;
            Word.Application ObjWord = new Word.Application();
            Object parametro = path;

            Object nombre_ = "nombre";
            Object seccion_ = "seccion";
            Object numero_ = "numero";
            Object anio_ = "anio";
            Object convocatoria_ = "convocatoria";
            Object rne_ = "rne";
            Word.Document ObjDoc = ObjWord.Documents.Open(parametro, ObjMiss);
            try
            {

                Word.Range nom = ObjDoc.Bookmarks.get_Item(ref nombre_).Range;
                nom.Text = nombre;

                Word.Range secc = ObjDoc.Bookmarks.get_Item(ref seccion_).Range;
                secc.Text = seccion;

                Word.Range num = ObjDoc.Bookmarks.get_Item(ref numero_).Range;
                num.Text = numero;

                Word.Range ani = ObjDoc.Bookmarks.get_Item(ref anio_).Range;
                ani.Text = anio;

                Word.Range conv = ObjDoc.Bookmarks.get_Item(ref convocatoria_).Range;
                conv.Text = convocatoria;

                Word.Range rn = ObjDoc.Bookmarks.get_Item(ref rne_).Range;
                rn.Text = rne;

                Object rango1 = nom;
                Object rango2 = secc;
                Object rango3 = num;
                Object rango4 = ani;
                Object rango5 = conv;
                Object rango6 = rn;
                ObjDoc.Bookmarks.Add("nombre", ref rango1);
                ObjDoc.Bookmarks.Add("seccion", ref rango2);
                ObjDoc.Bookmarks.Add("numero", ref rango3);
                ObjDoc.Bookmarks.Add("anio", ref rango4);
                ObjDoc.Bookmarks.Add("convocatoria", ref rango5);
                ObjDoc.Bookmarks.Add("rne", ref rango6);
                object doNotSaveChanges = Word.WdSaveOptions.wdDoNotSaveChanges;

                imprimirDocumento(ObjDoc);

                //ObjWord.Visible = true;
                ObjWord.ActiveDocument.Close(Word.WdSaveOptions.wdDoNotSaveChanges);

                //ObjWord.Documents.Close(doNotSaveChanges);

                ObjWord.Quit();
                //ObjWord.ActiveDocument.Close(Word.WdSaveOptions.wdDoNotSaveChanges);


            }

            catch (Exception ex) {
                MessageBox.Show("No se ha podido imprimir/nError: "+ex.Message,"Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            return ObjDoc;

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

       
        

    }



        
}
