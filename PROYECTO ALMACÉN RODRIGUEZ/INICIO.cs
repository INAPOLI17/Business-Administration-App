using System.Data;
using PROYECTO_ALMACÉN_RODRIGUEZ.CLADATOS;
using iTextSharp.text;
using iTextSharp.text.pdf;
using iTextSharp.tool.xml;
using System.IO;


namespace PROYECTO_ALMACÉN_RODRIGUEZ
{
    public partial class INICIO : Form
    {
        public INICIO()
        {
            InitializeComponent();

        }

        CONEXION inicio = new CONEXION();
        DATOSPRODUCTOS prdetalle = new DATOSPRODUCTOS();
        DATOSFACTURA fa = new DATOSFACTURA();
        


        private void INICIO_Load(object sender, EventArgs e)
        {
            BUSCAR(@"SELECT PRID.ID_PRODUCTO AS [ID],PRID.NOM_PRODUCTO AS [PRODUCTO],PRID.MED_PRODUCTO AS [MEDIDA], PRCA.CAN_PRODUCTO AS [CANTIDAD],
PRPR.PVEN_PRODUCTO AS [PRECIO] FROM PRODUCTO_ID AS PRID INNER JOIN PRODUCTO_CANTIDAD AS PRCA ON PRID.ID_PRODUCTO= PRCA.ID_PRODUCTO  INNER JOIN 
PRODUCTO_PRECIO AS PRPR ON PRID.ID_PRODUCTO= PRPR.ID_PRODUCTO WHERE PRCA.CAN_PRODUCTO > '0';");

            dgvDETALLEFACTURA.Columns.Add("ID", "ID");
            dgvDETALLEFACTURA.Columns.Add("PRODUCTO", "PRODUCTO");
            dgvDETALLEFACTURA.Columns.Add("CANTIDAD", "CANTIDAD");
            dgvDETALLEFACTURA.Columns.Add("MEDIDA", "MEDIDA");
            dgvDETALLEFACTURA.Columns.Add("PRECIO", "PRECIO");

            

            rdbCREDITO.Enabled = false;
            rdbEFECTIVO.Checked = true;
            rdbENTREGADO.Checked = true;

        }

        private void panelCLIENTE_Click(object sender, EventArgs e)
        {
            
        }

        private void btnBuscarproducto_Click(object sender, EventArgs e)
        {
            BUSCAR(@"SELECT PRID.ID_PRODUCTO AS [ID],PRID.NOM_PRODUCTO AS [PRODUCTO],PRID.MED_PRODUCTO AS [MEDIDA], PRCA.CAN_PRODUCTO AS [CANTIDAD], 
PRPR.PVEN_PRODUCTO AS [PRECIO] FROM PRODUCTO_ID AS PRID INNER JOIN PRODUCTO_CANTIDAD AS PRCA ON PRID.ID_PRODUCTO= PRCA.ID_PRODUCTO  INNER JOIN 
PRODUCTO_PRECIO AS PRPR ON PRID.ID_PRODUCTO= PRPR.ID_PRODUCTO WHERE PRCA.CAN_PRODUCTO > '0' AND WHERE PRID.NOM_PRODUCTO LIKE 
'%" + txtProductos + "%'");
        }

        private void BUSCAR (string STRSQL)
        {
            dgvADDPRODUCTOS.DataSource = inicio.consulta(STRSQL);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (comboBox1.SelectedIndex != null)
                {

                    inicio.LlenadoCombo(comboBox2, @"SELECT *
FROM CLIENTE_DIRECCION WHERE ID_CLIENTE LIKE'" + comboBox1.SelectedValue.ToString() + "'", "ID_CLIENTE", "DIR_CLIENTE");
                }
                else
                {
                    throw new ArgumentNullException(nameof(comboBox1));
                }
            }
            catch (ArgumentNullException)
            {
                MessageBox.Show("Cliente no cuenta con una dirección");
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dgvADDPRODUCTOS_DoubleClick(object sender, EventArgs e)
        {
            prdetalle.ID = Convert.ToInt32(dgvADDPRODUCTOS.SelectedCells[0].Value.ToString());
            prdetalle.NAMEPRODUCTO = dgvADDPRODUCTOS.SelectedCells[1].Value.ToString();
            prdetalle.CANTIDAD = int.Parse(dgvADDPRODUCTOS.SelectedCells[3].Value.ToString());
            prdetalle.MEDIDA = dgvADDPRODUCTOS.SelectedCells[2].Value.ToString();
            prdetalle.PRECIOVENTA = int.Parse(dgvADDPRODUCTOS.SelectedCells[4].Value.ToString());

        }

        private void dgvDETALLEFACTURA_DoubleClick(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            if (int.Parse(txtCANTIDADDETALLE.Text) > int.Parse(dgvADDPRODUCTOS.SelectedCells[3].Value.ToString()))
            {
                MessageBox.Show("La cantidad indicada sobrepasa el valor de existenia");
            }
            else
            {
                int indice_fila = dgvDETALLEFACTURA.Rows.Add();
                DataGridViewRow rw = dgvDETALLEFACTURA.Rows[indice_fila];
                rw.Cells["ID"].Value = prdetalle.ID.ToString();
                rw.Cells["PRODUCTO"].Value = prdetalle.NAMEPRODUCTO.ToString();
                rw.Cells["CANTIDAD"].Value = txtCANTIDADDETALLE.Text;
                rw.Cells["MEDIDA"].Value = prdetalle.MEDIDA.ToString();
                rw.Cells["PRECIO"].Value = prdetalle.PRECIOVENTA.ToString();
                SumaTotal(prdetalle.PRECIOVENTA, txtCANTIDADDETALLE.Text);

                txtTotal.Text = fa.TOTAL.ToString();
                txtTOTALNETO.Text = Convert.ToString(fa.TOTAL - int.Parse(txtDESCUENTO.Text)); 
                txtCANTIDADDETALLE.Clear();
            }

            BUSCAR(@"SELECT PRID.ID_PRODUCTO AS [ID],PRID.NOM_PRODUCTO AS [PRODUCTO],PRID.MED_PRODUCTO AS [MEDIDA], PRCA.CAN_PRODUCTO AS [CANTIDAD], PRPR.PVEN_PRODUCTO AS [PRECIO]
FROM PRODUCTO_ID AS PRID INNER JOIN PRODUCTO_CANTIDAD AS PRCA ON PRID.ID_PRODUCTO= PRCA.ID_PRODUCTO  INNER JOIN PRODUCTO_PRECIO AS PRPR ON PRID.ID_PRODUCTO= PRPR.ID_PRODUCTO WHERE PRCA.CAN_PRODUCTO > '0'");

        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            fa.ID = inicio.GENERARID("FACTURA");
            fa.NAMECLIENTE = comboBox1.Text;
            if(comboBox1.ValueMember == null)
            {
                fa.IDCLIENTE = 0000;
            }
            else
            {
                //fa.IDCLIENTE = int.Parse(comboBox1.ValueMember.ToString());
            }
            
            fa.DIRECCION = comboBox2.Text;
            if (rdbNOENTREGADO.Checked)
            {
                fa.ESTADO = "NO ENTREGADA";
            }
            else
            {
                fa.ESTADO = "ENTREGADA";
            }

            if (rdbCREDITO.Checked)
            {
                fa.TIPOFACTURA = "CREDITO";
            }
            else
            {
                fa.TIPOFACTURA = "EFECTIVO";
            }
            fa.DESCUENTO = int.Parse(txtDESCUENTO.Text);
            fa.PAGONETO = fa.DESCUENTO - fa.TOTAL;

            DATOSDETALLE de = new DATOSDETALLE();

            for (int iterador = 0; iterador < dgvDETALLEFACTURA.Rows.Count - 1; iterador++)
            {
                

                de.IDFACTURA = fa.ID;
                de.IDPRODUCTO = int.Parse(dgvDETALLEFACTURA.Rows[iterador].Cells["ID"].Value.ToString());
                de.CANTIDAD = int.Parse(dgvDETALLEFACTURA.Rows[iterador].Cells["CANTIDAD"].Value.ToString());
                de.MEDIDA = dgvDETALLEFACTURA.Rows[iterador].Cells["MEDIDA"].Value.ToString();
                de.PRECIO = int.Parse(dgvDETALLEFACTURA.Rows[iterador].Cells["PRECIO"].Value.ToString());

                inicio.DATOSDETALLE(de, "AÑADIRDETALLE");
                inicio.ControlCantidadProductos(de.IDPRODUCTO, de.CANTIDAD);

            }

            inicio.DATOSFACTURA(fa, "AÑADIRFACTURA");
            ImpriumirFacura();

        }

        public void ActualizarCantidadProductos()
        {

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            dgvDETALLEFACTURA.Rows.Clear();
            comboBox1.Text = null;
            comboBox2.Text = null;
            rdbCREDITO.Checked = false;
            rdbNOENTREGADO.Checked = false;
            txtDESCUENTO.Text = null;
            txtTotal.Text = null;
            txtTOTALNETO.Text = null;   
            txtCANTIDADDETALLE.Text = null;
        }

        private void btnEliminarRegistro_Click(object sender, EventArgs e)
        {
            dgvDETALLEFACTURA.Rows.RemoveAt(dgvDETALLEFACTURA.CurrentRow.Index);
        }

        private void ImpriumirFacura()
        {

            SaveFileDialog impReporte = new SaveFileDialog();
            impReporte.FileName = fa.NAMECLIENTE + DateTime.Now.ToString("dd-mm-yyyyHHmmss") + ".pdf";

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

        private void btnCarga_Click(object sender, EventArgs e)
        {
            BUSCAR(@"SELECT PRID.ID_PRODUCTO AS [ID],PRID.NOM_PRODUCTO AS [PRODUCTO],PRID.MED_PRODUCTO AS [MEDIDA], PRCA.CAN_PRODUCTO AS [CANTIDAD], 
PRPR.PVEN_PRODUCTO AS [PRECIO] FROM PRODUCTO_ID AS PRID INNER JOIN PRODUCTO_CANTIDAD AS PRCA ON PRID.ID_PRODUCTO= PRCA.ID_PRODUCTO  INNER JOIN 
PRODUCTO_PRECIO AS PRPR ON PRID.ID_PRODUCTO= PRPR.ID_PRODUCTO WHERE PRCA.CAN_PRODUCTO > '0'");
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }

        private void BTNBUSCAR_Click(object sender, EventArgs e)
        {
            try
            {
                if (inicio.LlenadoCombo(comboBox1, @"SELECT ID_CLIENTE, NOM_CLIENTE
FROM CLIENTE_ID WHERE NOM_CLIENTE LIKE '%" + comboBox1.Text + "%'", "ID_CLIENTE", "NOM_CLIENTE") && comboBox1.Text != " ")
                {

                    rdbCREDITO.Enabled = true;
                    ;
                    fa.IDCLIENTE = int.Parse(comboBox1.SelectedValue.ToString());
                    comboBox1.Text = comboBox1.SelectedText.ToString();

                    inicio.LlenadoCombo(comboBox2, @"SELECT *
FROM CLIENTE_DIRECCION WHERE ID_CLIENTE LIKE'" + comboBox1.SelectedValue.ToString() + "'", "ID_CLIENTE", "DIR_CLIENTE");
                }
                else
                {
                    fa.IDCLIENTE = 0;
                    comboBox1.ValueMember = "0";
                    throw new ArgumentNullException(nameof(comboBox1));

                }
            }
            catch (ArgumentNullException)
            {
                MessageBox.Show("Cliente no encontrado");
            }
        }

        private void SumaTotal(params object[] valores)
        {
            fa.TOTAL += int.Parse(valores[0].ToString()) * int.Parse(valores[1].ToString());
        }
    }
}