using iTextSharp.text;
using iTextSharp.text.pdf;
using iTextSharp.tool.xml;
using System;
using System.IO;
using System.Windows.Forms;
using System.Collections.Generic;

namespace Lógica.LIBRARY {
    public class Report {


        private void Imprimir ( SaveFileDialog impReporte, string paginaTexto ) {
            if (impReporte.ShowDialog() == DialogResult.OK) {
                using (FileStream fileStream = new FileStream(impReporte.FileName, FileMode.Create)) {
                    Document doc = new Document(PageSize.A4, 25, 25, 25, 25);

                    PdfWriter writer = PdfWriter.GetInstance(doc, fileStream);

                    doc.Open();
                    doc.Add(new Phrase(""));

                    using (StringReader reader = new StringReader(paginaTexto)) {
                        XMLWorkerHelper.GetInstance().ParseXHtml(writer, doc, reader);
                        }

                    doc.Close();
                    fileStream.Close();

                    MessageBox.Show("Factura generada");
                    }
                }
            }

        public bool reportFactura (DataGridView report,List<object> DataForReport ) {
            using (SaveFileDialog rpFactura = new SaveFileDialog()) {
                string paginaTexto = Properties.Resources.reporteFACTURA.ToString();
                string filas = string.Empty;
                int total = 0;
                rpFactura.FileName = report.SelectedCells[0].Value.ToString() + DateTime.Now.ToString("dd-mm-yyyyHHmmss") + ".pdf";


                paginaTexto = paginaTexto.Replace("@CLIENTE", DataForReport[0].ToString());
                paginaTexto = paginaTexto.Replace("@DIRECCION", DataForReport[1].ToString());
                paginaTexto = paginaTexto.Replace("@ESTADO", DataForReport[2].ToString());
                paginaTexto = paginaTexto.Replace("@TIPO", DataForReport[3].ToString());
                paginaTexto = paginaTexto.Replace("@DESCUENTO", DataForReport[4].ToString());
                paginaTexto = paginaTexto.Replace("@Fecha", DateTime.Now.ToString("dd-mm-yyyy"));




                for (int i = 0; i < report.Rows.Count - 1; i++) {
                    filas += "<tr>";
                    filas += "<td>" + report.Rows[i].Cells["PRODUCTO"].Value.ToString() + "</td>";
                    filas += "<td>" + report.Rows[i].Cells["MEDIDA"].Value.ToString() + "</td>";
                    filas += "<td>" + report.Rows[i].Cells["CANTIDAD"].Value.ToString() + "</td>";
                    filas += "<td>" + report.Rows[i].Cells["PRECIO"].Value.ToString() + "</td>";
                    filas += "</tr>";

                    }


                paginaTexto = paginaTexto.Replace("@FILAS", filas);
                paginaTexto = paginaTexto.Replace("@TOTAL", DataForReport[5].ToString());
                paginaTexto = paginaTexto.Replace("@Pagar", DataForReport[6].ToString());

                try {
                    Imprimir(rpFactura, paginaTexto);
                    return true;
                    }

                catch {
                    MessageBox.Show("Error: No se pudo imprimir");
                    return false;
                    }
                }
            }

        public bool reportCliente (DataGridView report ) {
            using (SaveFileDialog rpCliente = new SaveFileDialog()) {

                rpCliente.FileName = "REPORTE DE CLIENTE--" + DateTime.Now.ToString("dd-mm-yyyyHHmmss") + ".pdf";

                string paginaTexto = Properties.Resources.reporteCLIENTE.ToString();

                string filas = string.Empty;


                for (int i = 0; i < report.Rows.Count - 1; i++) {
                    filas += "<tr>";
                    filas += "<td>" + report.Rows[i].Cells["PRODUCTO"].Value.ToString() + "</td>";
                    filas += "<td>" + report.Rows[i].Cells["MEDIDA"].Value.ToString() + "</td>";
                    filas += "<td>" + report.Rows[i].Cells["CANTIDAD"].Value.ToString() + "</td>";
                    filas += "<td>" + report.Rows[i].Cells["PRECIO"].Value.ToString() + "</td>";
                    filas += "<td>" + report.Rows[i].Cells["CANTIDAD"].Value.ToString() + "</td>";
                    filas += "<td>" + report.Rows[i].Cells["PRECIO"].Value.ToString() + "</td>";
                    filas += "</tr>";

                    }


                paginaTexto = paginaTexto.Replace("@FILAS", filas);

                try {
                    Imprimir(rpCliente, paginaTexto);
                    return true;
                    }
                catch {
                    MessageBox.Show("Error: No se pudo imprimir");
                    return false;
                    }
                }
            }


        public bool reportProducto (DataGridView report ) {
            using (SaveFileDialog rpProducto = new SaveFileDialog()) {
                rpProducto.FileName = "REPORTE DE INVENTARIO--" + DateTime.Now.ToString("dd-mm-yyyyHHmmss") + ".pdf";

                string paginaTexto = Properties.Resources.reportePRODUCTO.ToString();

                string filas = string.Empty;


                for (int i = 0; i < report.Rows.Count - 1; i++) {
                    filas += "<tr>";
                    filas += "<td>" + report.Rows[i].Cells["PRODUCTO"].Value.ToString() + "</td>";
                    filas += "<td>" + report.Rows[i].Cells["MEDIDA"].Value.ToString() + "</td>";
                    filas += "<td>" + report.Rows[i].Cells["CANTIDAD"].Value.ToString() + "</td>";
                    filas += "<td>" + report.Rows[i].Cells["PRECIO"].Value.ToString() + "</td>";
                    filas += "<td>" + report.Rows[i].Cells["CANTIDAD"].Value.ToString() + "</td>";
                    filas += "<td>" + report.Rows[i].Cells["PRECIO"].Value.ToString() + "</td>";
                    filas += "</tr>";

                    }


                paginaTexto = paginaTexto.Replace("@FILAS", filas);


                try {
                    Imprimir(rpProducto, paginaTexto);
                    return true;
                    }
                catch {
                    MessageBox.Show("Error: No se pudo imprimir");
                    return false;
                    }
                }
            }

        }
    }

