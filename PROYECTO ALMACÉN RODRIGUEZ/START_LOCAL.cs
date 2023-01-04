using System.Data;
using iTextSharp.text;
using iTextSharp.text.pdf;
using iTextSharp.tool.xml;
using System.IO;
using LOGIC;
using LOGIC.LIBRARY;

namespace INTERFACE
{
    public partial class INICIO : Form
    {
        public INICIO()
        {
            InitializeComponent();
            List<Object> ListTextBox = new List<Object>();
            List<Object> ListRadio = new List<Object>();

            ListTextBox.Add(txtProductos);
            ListTextBox.Add(txtCANTIDADDETALLE);
            ListTextBox.Add(cmbNAMECLIENT);
            ListTextBox.Add(cmbDIRECTIONCLEINT);
            ListTextBox.Add(txtDESCUENTO);
            ListTextBox.Add(txtTotal);
            ListTextBox.Add(txtTOTALNETO);

            ListRadio.Add(rdbCREDITO);
            ListRadio.Add(rdbEFECTIVO);
            ListRadio.Add(rdbENTREGADO);
            ListRadio.Add(rdbNOENTREGADO);

            
            function = new LOGICA(ListTextBox, ListRadio, dgvDETALLEFACTURA );
        }

        
      
        private LOGICA function;
        

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
                if (cmbNAMECLIENT.SelectedIndex != null)
                {

                    inicio.LlenadoCombo(cmbDIRECTIONCLEINT, @"SELECT *
FROM CLIENTE_DIRECCION WHERE ID_CLIENTE LIKE'" + cmbNAMECLIENT.SelectedValue.ToString() + "'", "ID_CLIENTE", "DIR_CLIENTE");
                }
                else
                {
                    throw new ArgumentNullException(nameof(cmbNAMECLIENT));
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
            fa.NAMECLIENTE = cmbNAMECLIENT.Text;
            if(cmbNAMECLIENT.ValueMember == null)
            {
                fa.IDCLIENTE = 0000;
            }
            else
            {
                //fa.IDCLIENTE = int.Parse(comboBox1.ValueMember.ToString());
            }
            
            fa.DIRECCION = cmbDIRECTIONCLEINT.Text;
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
            cmbNAMECLIENT.Text = null;
            cmbDIRECTIONCLEINT.Text = null;
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
                if (inicio.LlenadoCombo(cmbNAMECLIENT, @"SELECT ID_CLIENTE, NOM_CLIENTE
FROM CLIENTE_ID WHERE NOM_CLIENTE LIKE '%" + cmbNAMECLIENT.Text + "%'", "ID_CLIENTE", "NOM_CLIENTE") && cmbNAMECLIENT.Text != " ")
                {

                    rdbCREDITO.Enabled = true;
                    ;
                    fa.IDCLIENTE = int.Parse(cmbNAMECLIENT.SelectedValue.ToString());
                    cmbNAMECLIENT.Text = cmbNAMECLIENT.SelectedText.ToString();

                    inicio.LlenadoCombo(cmbDIRECTIONCLEINT, @"SELECT *
FROM CLIENTE_DIRECCION WHERE ID_CLIENTE LIKE'" + cmbNAMECLIENT.SelectedValue.ToString() + "'", "ID_CLIENTE", "DIR_CLIENTE");
                }
                else
                {
                    fa.IDCLIENTE = 0;
                    cmbNAMECLIENT.ValueMember = "0";
                    throw new ArgumentNullException(nameof(cmbNAMECLIENT));

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