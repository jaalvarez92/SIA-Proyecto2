using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using iTextSharp.text;
using iTextSharp.text.pdf;

namespace PruebaPDF
{
    public partial class Form1 : Form
    {
        CapaDatos CD = new CapaDatos();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEstadoResultados_Click(object sender, EventArgs e)
        {
            SaveFileDialog dialogoGuardar = new SaveFileDialog();

            dialogoGuardar.Filter = "PDF files (*.pdf)|*.pdf|All files (*.*)|*.*";
            dialogoGuardar.FilterIndex = 1;//mostrar primero *.pdf
            dialogoGuardar.RestoreDirectory = true;

            if (dialogoGuardar.ShowDialog() == DialogResult.OK)            
                generarEstadoResultadosPDF(dialogoGuardar.FileName);               
            
            //generarEstadoResultadosPDF("D:/Prueba.pdf");            
            Application.Exit();
        }
        private void btnBalanceGeneral_Click(object sender, EventArgs e)
        {
            SaveFileDialog dialogoGuardar = new SaveFileDialog();

            dialogoGuardar.Filter = "PDF files (*.pdf)|*.pdf|All files (*.*)|*.*";
            dialogoGuardar.FilterIndex = 1;//mostrar primero *.pdf
            dialogoGuardar.RestoreDirectory = true;

            if (dialogoGuardar.ShowDialog() == DialogResult.OK)                           
               generarBalanceGeneralPDF(dialogoGuardar.FileName);
            
            //generarBalanceGeneralPDF("D:/BalanceGeneral.pdf");
            Application.Exit();
        }
        private void btnBalanceComprobacion_Click(object sender, EventArgs e)
        {
            SaveFileDialog dialogoGuardar = new SaveFileDialog();

            dialogoGuardar.Filter = "PDF files (*.pdf)|*.pdf|All files (*.*)|*.*";
            dialogoGuardar.FilterIndex = 1;//mostrar primero *.pdf
            dialogoGuardar.RestoreDirectory = true;

            if (dialogoGuardar.ShowDialog() == DialogResult.OK)
                generarBalanceComprobacionPDF(dialogoGuardar.FileName);

          //  generarBalanceComprobacionPDF("D:/BalanceComprobacion.pdf");
            Application.Exit();

        }
        private void generarEstadoResultadosPDF(string ruta)
        {
            DataSet tablaEstadoResultados = CD.getDataSet("SP_getData", null);
            string nombreEmpresa = "\nCompañia PAMODI";
            string fecha = "Al 30 de Septiembre del 2012\n\n";
            decimal totalIngresos = 0;
            decimal totalGastos = 0;
            decimal totalPartidasExtraordinarias = 0;

            Document document = new Document();
            PdfWriter.GetInstance(document, new FileStream(ruta, FileMode.OpenOrCreate));

            //editar documento
            document.Open();

            //dos columnas (Cuenta, saldo)
            PdfPTable table = new PdfPTable(2);
            float[] anchoColumnas = new float[2];
            anchoColumnas[0] = 200;
            anchoColumnas[1] = 100;
            table.SetWidths(anchoColumnas);

            insertarTituloReporte(table,"\nEstado de resultados\n\n");
            insertarNombreEmpresa(table,nombreEmpresa);
            insertarFechaReporte(table,fecha);

            insertarTitulo(table,"Ingresos Operativos");
            totalIngresos = insertarCuentas(table,tablaEstadoResultados,"5");//5 representa ingresos
            insertarTotal(table,"\nTotal Ingresos Operativos: ",totalIngresos);

            insertarTitulo(table, "Egresos Operativos");
            totalGastos = insertarCuentas(table,tablaEstadoResultados,"6");//6 respresenta gastos
            insertarTotal(table,"\nTotal Gastos Operativos: ",totalGastos);            

            decimal utilidadOperativa = totalIngresos - totalGastos;
            string titulo = "Utilidad Operativa: " + utilidadOperativa;
            insertarTitulo(table,titulo);

            insertarTitulo(table, "Partidas Extraordinarias");
            totalPartidasExtraordinarias = insertarCuentas(table, tablaEstadoResultados, "7");//7 respresenta partidas extraordinarias
            insertarTotal(table, "\nTotal Partidas Extraordinarias: ", totalPartidasExtraordinarias);

            insertarCuentas(table,tablaEstadoResultados,"9");

            //agregar tabla
            document.Add(table);
            //cerrar el documento
            document.Close();
        }
        private void generarBalanceGeneralPDF(string ruta)
        {
            DataSet tablaBalanceGeneral = CD.getDataSet("SP_getData", null);
            string nombreEmpresa = "\nCompañia PAMODI";
            string fecha = "Al 30 de Septiembre del 2012\n\n";
            decimal totalActivosFijos = 0;
            decimal totalActivosCirculantes = 0;
            decimal totalActivosOtros = 0;
            decimal totalActivos = 0;
            decimal totalPasivos = 0;
            decimal totalPasivosFijos = 0;
            decimal totalPasivosCirculantes = 0;
            decimal totalPasivosOtros = 0;
            decimal totalCapital = 0;

            Document document = new Document();
            PdfWriter.GetInstance(document, new FileStream(ruta, FileMode.OpenOrCreate));

            //editar documento
            document.Open();

            //dos columnas (Cuenta, saldo)
            PdfPTable table = new PdfPTable(2);
            float[] anchoColumnas = new float[2];
            anchoColumnas[0] = 200;
            anchoColumnas[1] = 100;
            table.SetWidths(anchoColumnas);

            insertarTituloReporte(table, "\nBalance General\n\n");
            insertarNombreEmpresa(table, nombreEmpresa);
            insertarFechaReporte(table, fecha);
            //--------------ACTIVOS-------------------------
            insertarTituloReporte(table, "Activos");
            insertarTitulo(table, "Activos Fijos: ");
            totalActivosFijos = insertarCuentas(table, tablaBalanceGeneral, "11");
            insertarTotal(table, "\nTotal Activos Fijos: ", totalActivosFijos);

            insertarTitulo(table, "Activos Circulantes: ");
            totalActivosCirculantes = insertarCuentas(table, tablaBalanceGeneral, "12");
            insertarTotal(table, "\nTotal Activos Circulantes: ", totalActivosCirculantes);

            insertarTitulo(table, "Activos Otros: ");
            totalActivosOtros = insertarCuentas(table, tablaBalanceGeneral, "13");
            insertarTotal(table, "\nTotal Activos Otros: ", totalActivosOtros);
            totalActivos = totalActivosFijos + totalActivosCirculantes + totalActivosOtros;
            insertarTotal(table, "\nTotal ACtivos: ", totalActivos);

            //--------------PASIVOS-------------------------
            insertarTituloReporte(table, "Pasivos");
            insertarTitulo(table, "Pasivos Fijos: ");
            totalPasivosFijos = insertarCuentas(table, tablaBalanceGeneral, "21");
            insertarTotal(table, "\nTotal Pasivos Fijos: ", totalPasivosFijos);

            insertarTitulo(table, "Pasivos Circulantes: ");
            totalPasivosCirculantes = insertarCuentas(table, tablaBalanceGeneral, "22");
            insertarTotal(table, "\nTotal Pasivos Circulantes: ", totalPasivosCirculantes);

            insertarTitulo(table, "Pasivos Otros: ");
            totalPasivosOtros = insertarCuentas(table, tablaBalanceGeneral, "23");
            insertarTotal(table, "\nTotal Pasivos Otros: ", totalPasivosOtros);
            totalPasivos = totalPasivosCirculantes + totalPasivosFijos + totalPasivosOtros;
            insertarTotal(table, "\nTotal Pasivos: ", totalPasivos);

            //-----------------------CAPITAL-----------------------------------
            insertarTituloReporte(table, "Capital");
            totalCapital = insertarCuentas(table, tablaBalanceGeneral, "31");
            insertarTotal(table, "\nTotal Capital: ", totalCapital);

            //agregar tabla
            document.Add(table);
            //cerrar el documento
            document.Close();

        }
        private void generarBalanceComprobacionPDF(string ruta)
        {
            DataSet tablaBalanceComprobacion = CD.getDataSet("SP_getData2", null);
            string nombreEmpresa = "\nCompañia PAMODI";
            string fecha = "Al 30 de Septiembre del 2012\n\n";            

            Document document = new Document();
            PdfWriter.GetInstance(document, new FileStream(ruta, FileMode.OpenOrCreate));

            //editar documento
            document.Open();
            
            //tres columnas 
            PdfPTable table = new PdfPTable(3);
            float[] anchoColumnas = new float[3];
            anchoColumnas[0] = 150;
            anchoColumnas[1] = 75;
            anchoColumnas[2] = 75;
            table.SetWidths(anchoColumnas);

            insertarTituloReporte(table, "\nBalance de Comprobación\n\n");
            insertarNombreEmpresa(table, nombreEmpresa);
            insertarFechaReporte(table, fecha);

            decimal[] totales = insertarCuentas(table, tablaBalanceComprobacion);
            PdfPCell celdaTotalDebe = new PdfPCell(new Phrase(new Chunk("" + totales[0], FontFactory.GetFont("ARIAL", 13, iTextSharp.text.Font.BOLD, BaseColor.BLACK))));
            PdfPCell celdaTotalHaber = new PdfPCell(new Phrase(new Chunk("" + totales[1], FontFactory.GetFont("ARIAL", 13, iTextSharp.text.Font.BOLD, BaseColor.BLACK))));
            insertarLinea(table);
            table.AddCell("");
            celdaTotalDebe.BorderColor = BaseColor.WHITE;
            celdaTotalHaber.BorderColor = BaseColor.WHITE;
            table.AddCell(celdaTotalDebe);
            table.AddCell(celdaTotalHaber);

            //agregar tabla
            document.Add(table);
            //cerrar el documento
            document.Close();

        }

       
        #region Metodos Auxiliares
        private void insertarLinea(PdfPTable table)
        {
            string linea = "";
            int largo = 45;

            for (int i = 0; i < largo; i++)
                linea += '_';

            PdfPCell celdaLinea = new PdfPCell(new Phrase(new Chunk(linea, FontFactory.GetFont("ARIAL", 15, iTextSharp.text.Font.BOLD, BaseColor.BLACK))));          
            float[] abWidth = table.AbsoluteWidths;
            celdaLinea.Colspan = abWidth.Length;//numero de columnas
            celdaLinea.HorizontalAlignment = 0; //0=Left, 1=Centre, 2=Right  
            celdaLinea.BorderColor = BaseColor.WHITE;
            table.AddCell(celdaLinea);
        }
        private void insertarTituloReporte(PdfPTable table,string nombreReporte)
        {
            //titulo
            PdfPCell celdaTitulo = new PdfPCell(new Phrase(new Chunk(nombreReporte, FontFactory.GetFont("ARIAL", 15, iTextSharp.text.Font.BOLD, BaseColor.WHITE))));
            celdaTitulo.BackgroundColor = MIAZUL;
            float[] abWidth = table.AbsoluteWidths;
            celdaTitulo.Colspan = abWidth.Length;//numero de columnas
            celdaTitulo.HorizontalAlignment = 1; //0=Left, 1=Centre, 2=Right  
            celdaTitulo.BorderColor = MIAZUL;
            table.AddCell(celdaTitulo);
        }
        private void insertarNombreEmpresa(PdfPTable table, string nombreEmpresa)
        {
            //Nombre de la empresa
            PdfPCell celdaEmpresa = new PdfPCell(new Phrase(new Chunk(nombreEmpresa, FontFactory.GetFont("ARIAL", 15, iTextSharp.text.Font.BOLD, BaseColor.BLACK))));
            float[] abWidth = table.AbsoluteWidths;
            celdaEmpresa.Colspan = abWidth.Length;//numero de columnas
            celdaEmpresa.HorizontalAlignment = 1; //0=Left, 1=Centre, 2=Right  
            celdaEmpresa.BorderColor = BaseColor.WHITE;
            table.AddCell(celdaEmpresa);
        }
        private void insertarFechaReporte(PdfPTable table, string fechaReporte)
        {
            //fecha del reporte
            PdfPCell celdaFecha = new PdfPCell(new Phrase(new Chunk(fechaReporte, FontFactory.GetFont("ARIAL", 15, iTextSharp.text.Font.BOLD, BaseColor.BLACK))));
            float[] abWidth = table.AbsoluteWidths;
            celdaFecha.Colspan = abWidth.Length;//numero de columnas
            celdaFecha.HorizontalAlignment = 1; //0=Left, 1=Centre, 2=Right  
            celdaFecha.BorderColor = BaseColor.WHITE;
            table.AddCell(celdaFecha);
        }
        private void insertarTitulo(PdfPTable table, string titulo)
        {
            PdfPCell celdaIngresosOperativos = new PdfPCell(new Phrase(new Chunk(titulo + "\n\n", FontFactory.GetFont("ARIAL", 13, iTextSharp.text.Font.BOLD, MIAZUL))));
            float[] abWidth = table.AbsoluteWidths;
            celdaIngresosOperativos.Colspan = abWidth.Length;//numero de columnas
            celdaIngresosOperativos.HorizontalAlignment = 0; //0=Left, 1=Centre, 2=Right  
            celdaIngresosOperativos.BorderColor = BaseColor.WHITE;
            table.AddCell(celdaIngresosOperativos);
        }
        private decimal insertarCuentas(PdfPTable table,DataSet pDataSet, string condicion)
        {
            decimal resp = 0;

            if (condicion.Equals("8"))//8 tambien representa las partidas extraordinarias
                condicion = "7";

            for (int i = 0; i < pDataSet.Tables[0].Rows.Count; i++)
            {
                // 0 = ID, 1 = NombreCuenta, 2 = Saldo y 3 = idTipoCuenta
                string idTipoCuenta = pDataSet.Tables[0].Rows[i].ItemArray[3].ToString();

                if (idTipoCuenta.Length > 2)
                {
                    idTipoCuenta = idTipoCuenta.Substring(0, 2);
                }

                if (idTipoCuenta.Equals(condicion))
                {                    
                    string nombreCuenta = pDataSet.Tables[0].Rows[i].ItemArray[1].ToString();
                    string saldo = pDataSet.Tables[0].Rows[i].ItemArray[2].ToString();

                    table.DefaultCell.BorderColor = BaseColor.WHITE;
                    table.AddCell(nombreCuenta);
                    table.AddCell(saldo);
                    resp += decimal.Parse(saldo);
                }
            }
            return resp;
        }
        private decimal[] insertarCuentas(PdfPTable table, DataSet ptablaBalanceComprobacion)
        {
            decimal[] resp = new decimal[2];
            for (int i = 0; i < ptablaBalanceComprobacion.Tables[0].Rows.Count; i++)
            {
                table.DefaultCell.BorderColor = BaseColor.WHITE;
                string nombreCuenta = ptablaBalanceComprobacion.Tables[0].Rows[i].ItemArray[3].ToString();
                string saldo = ptablaBalanceComprobacion.Tables[0].Rows[i].ItemArray[4].ToString();
                
                decimal saldoLocal = decimal.Parse(saldo);

                table.AddCell(nombreCuenta);

                if (saldoLocal < 0)//al debe
                {
                    table.AddCell(""+Math.Abs(saldoLocal));
                    table.AddCell("");
                    resp[0] += Math.Abs(saldoLocal);
                }
                else//al haber
                {                    
                    table.AddCell("");
                    table.AddCell(saldo);
                    resp[1] += Math.Abs(saldoLocal);
                } 
            }
            return resp;
        }
        private void insertarTotal(PdfPTable table,string nombre, decimal total)
        {           
            PdfPCell celdaTotalIngresosOperativos = new PdfPCell(new Phrase(new Chunk(nombre + total + "\n\n", FontFactory.GetFont("ARIAL", 13, iTextSharp.text.Font.BOLD, BaseColor.BLACK))));
            float[] abWidth = table.AbsoluteWidths;
            celdaTotalIngresosOperativos.Colspan = abWidth.Length;//numero de columnas
            celdaTotalIngresosOperativos.HorizontalAlignment = 0; //0=Left, 1=Centre, 2=Right  
            celdaTotalIngresosOperativos.BorderColor = BaseColor.WHITE;
            table.AddCell(celdaTotalIngresosOperativos);
        }
        #endregion de Apoyo

        #region Atributos
        private readonly BaseColor MIAZUL = new BaseColor(19, 87, 170);
        #endregion
        
    }
}
