using iTextSharp.text;
using iTextSharp.text.pdf;
using iTextSharp.tool.xml;
using System;
using System.IO;
using System.Linq;
using System.util;
using System.Windows.Forms;

namespace Lógica.LIBRARY
{
    public class Report
    {
        private DataGridView dgvDETALLEFACTURA;


        public Report(DataGridView sTAR_LOCAL)
        {
            this.dgvDETALLEFACTURA = sTAR_LOCAL;

        }

        private void Imprimir(SaveFileDialog impReporte)
        {
            if (impReporte.ShowDialog() == DialogResult.OK)
            {
                using (FileStream fileStream = new FileStream(impReporte.FileName, FileMode.Create))
                {
                    Document doc = new Document(PageSize.A4, 25, 25, 25, 25);

                    PdfWriter writer = PdfWriter.GetInstance(doc, fileStream);

                    doc.Open();
                    doc.Add(new Phrase(""));

                    using (StringReader reader = new StringReader(paginaTexto))
                    {
                        XMLWorkerHelper.GetInstance().ParseXHtml(writer, doc, reader);
                    }

                    doc.Close();
                    fileStream.Close();

                    MessageBox.Show("Factura generada");
                }
            }
        }

        private bool reportFactura(dgvDETALLEFACTURA)
        {
            SaveFileDialog rpFactura = new SaveFileDialog();
            rpFactura.FileName = fa.NAMECLIENTE + DateTime.Now.ToString("dd-mm-yyyyHHmmss") + ".pdf";

            string paginaTexto = Properties.Resources.reporteFACTURA.ToString();
            paginaTexto = paginaTexto.Replace("@CLIENTE", fa.NAMECLIENTE);
            paginaTexto = paginaTexto.Replace("@DIRECCION", fa.DIRECCION);
            paginaTexto = paginaTexto.Replace("@ESTADO", fa.ESTADO);
            paginaTexto = paginaTexto.Replace("@TIPO", fa.TIPOFACTURA);
            paginaTexto = paginaTexto.Replace("@DESCUENTO", fa.DESCUENTO.ToString());
            paginaTexto = paginaTexto.Replace("@Fecha", DateTime.Now.ToString("dd-mm-yyyy"));

            string filas = string.Empty;


            for (int i = 0; i < dgvDETALLEFACTURA.Rows.Count - 1; i++)
            {
                filas += "<tr>";
                filas += "<td>" + dgvDETALLEFACTURA.Rows[i].Cells["PRODUCTO"].Value.ToString() + "</td>";
                filas += "<td>" + dgvDETALLEFACTURA.Rows[i].Cells["MEDIDA"].Value.ToString() + "</td>";
                filas += "<td>" + dgvDETALLEFACTURA.Rows[i].Cells["CANTIDAD"].Value.ToString() + "</td>";
                filas += "<td>" + dgvDETALLEFACTURA.Rows[i].Cells["PRECIO"].Value.ToString() + "</td>";
                filas += "</tr>";

            }


            paginaTexto = paginaTexto.Replace("@FILAS", filas);
            paginaTexto = paginaTexto.Replace("@TOTAL", fa.TOTAL.ToString());
            paginaTexto = paginaTexto.Replace("@Pagar", fa.PAGONETO.ToString());

            try
            {
                Imprimir(rpFactura);
                return true;
            }
            catch
            {
                MessageBox.Show("Error: No se pudo imprimir");
                return false;
            }
        }

        private bool reportCliente(dgvDETALLEFACTURA)
        {
            SaveFileDialog rpCliente = new SaveFileDialog();
            rpCliente.FileName = fa.NAMECLIENTE + DateTime.Now.ToString("dd-mm-yyyyHHmmss") + ".pdf";

            string paginaTexto = Properties.Resources.reporteFACTURA.ToString();
            paginaTexto = paginaTexto.Replace("@CLIENTE", fa.NAMECLIENTE);
            paginaTexto = paginaTexto.Replace("@DIRECCION", fa.DIRECCION);
            paginaTexto = paginaTexto.Replace("@ESTADO", fa.ESTADO);
            paginaTexto = paginaTexto.Replace("@TIPO", fa.TIPOFACTURA);
            paginaTexto = paginaTexto.Replace("@DESCUENTO", fa.DESCUENTO.ToString());
            paginaTexto = paginaTexto.Replace("@Fecha", DateTime.Now.ToString("dd-mm-yyyy"));

            string filas = string.Empty;


            for (int i = 0; i < dgvDETALLEFACTURA.Rows.Count - 1; i++)
            {
                filas += "<tr>";
                filas += "<td>" + dgvDETALLEFACTURA.Rows[i].Cells["PRODUCTO"].Value.ToString() + "</td>";
                filas += "<td>" + dgvDETALLEFACTURA.Rows[i].Cells["MEDIDA"].Value.ToString() + "</td>";
                filas += "<td>" + dgvDETALLEFACTURA.Rows[i].Cells["CANTIDAD"].Value.ToString() + "</td>";
                filas += "<td>" + dgvDETALLEFACTURA.Rows[i].Cells["PRECIO"].Value.ToString() + "</td>";
                filas += "</tr>";

            }


            paginaTexto = paginaTexto.Replace("@FILAS", filas);
            paginaTexto = paginaTexto.Replace("@TOTAL", fa.TOTAL.ToString());
            paginaTexto = paginaTexto.Replace("@Pagar", fa.PAGONETO.ToString());

            try
            {
                Imprimir(rpCliente);
                return true;
            }
            catch
            {
                MessageBox.Show("Error: No se pudo imprimir");
                return false;
            }
        }


        private bool reportProducto(dgvDETALLEFACTURA)
        {

            SaveFileDialog rpProducto = new SaveFileDialog();
            rpProducto.FileName = fa.NAMECLIENTE + DateTime.Now.ToString("dd-mm-yyyyHHmmss") + ".pdf";

            string paginaTexto = Properties.Resources.reporteFACTURA.ToString();
            paginaTexto = paginaTexto.Replace("@CLIENTE", fa.NAMECLIENTE);
            paginaTexto = paginaTexto.Replace("@DIRECCION", fa.DIRECCION);
            paginaTexto = paginaTexto.Replace("@ESTADO", fa.ESTADO);
            paginaTexto = paginaTexto.Replace("@TIPO", fa.TIPOFACTURA);
            paginaTexto = paginaTexto.Replace("@DESCUENTO", fa.DESCUENTO.ToString());
            paginaTexto = paginaTexto.Replace("@Fecha", DateTime.Now.ToString("dd-mm-yyyy"));

            string filas = string.Empty;


            for (int i = 0; i < dgvDETALLEFACTURA.Rows.Count - 1; i++)
            {
                filas += "<tr>";
                filas += "<td>" + dgvDETALLEFACTURA.Rows[i].Cells["PRODUCTO"].Value.ToString() + "</td>";
                filas += "<td>" + dgvDETALLEFACTURA.Rows[i].Cells["MEDIDA"].Value.ToString() + "</td>";
                filas += "<td>" + dgvDETALLEFACTURA.Rows[i].Cells["CANTIDAD"].Value.ToString() + "</td>";
                filas += "<td>" + dgvDETALLEFACTURA.Rows[i].Cells["PRECIO"].Value.ToString() + "</td>";
                filas += "</tr>";

            }


            paginaTexto = paginaTexto.Replace("@FILAS", filas);
            paginaTexto = paginaTexto.Replace("@TOTAL", fa.TOTAL.ToString());
            paginaTexto = paginaTexto.Replace("@Pagar", fa.PAGONETO.ToString());

            try
            {
                Imprimir(rpProducto);
                return true;
            }
            catch
            {
                MessageBox.Show("Error: No se pudo imprimir");
                return false;
            }
        }

    }
}

