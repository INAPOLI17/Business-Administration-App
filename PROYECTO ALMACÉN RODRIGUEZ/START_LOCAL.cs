using LOGIC;

namespace INTERFACE {
    public partial class INICIO : Form {

        public INICIO ( ) {
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

            function = new LOGICA(ListTextBox, 
                                    ListRadio);
            }

        private LOGICA function;

        private void INICIO_Load ( object sender, EventArgs e ) {
            function.Bill.ShowData();
            
            }

        private void btnBuscarproducto_Click ( object sender, EventArgs e ) {
            BUSCAR(@"SELECT PRID.ID_PRODUCTO AS [ID],PRID.NOM_PRODUCTO AS [PRODUCTO],PRID.MED_PRODUCTO AS [MEDIDA], PRCA.CAN_PRODUCTO AS [CANTIDAD], 
PRPR.PVEN_PRODUCTO AS [PRECIO] FROM PRODUCTO_ID AS PRID INNER JOIN PRODUCTO_CANTIDAD AS PRCA ON PRID.ID_PRODUCTO= PRCA.ID_PRODUCTO  INNER JOIN 
PRODUCTO_PRECIO AS PRPR ON PRID.ID_PRODUCTO= PRPR.ID_PRODUCTO WHERE PRCA.CAN_PRODUCTO > '0' AND WHERE PRID.NOM_PRODUCTO LIKE 
'%" + txtProductos + "%'");
            }

        private void BUSCAR ( string STRSQL ) {
            dgvADDPRODUCTOS.DataSource = inicio.consulta(STRSQL);
            }

        private void comboBox1_SelectedIndexChanged ( object sender, EventArgs e ) {
            }

        private void comboBox2_SelectedIndexChanged ( object sender, EventArgs e ) {
            }

        private void dgvADDPRODUCTOS_DoubleClick ( object sender, EventArgs e ) { 
            }

        private void dgvDETALLEFACTURA_DoubleClick ( object sender, EventArgs e ) {
            }

        private void button1_Click ( object sender, EventArgs e ) {


            if (int.Parse(txtCANTIDADDETALLE.Text) > int.Parse(dgvADDPRODUCTOS.SelectedCells[3].Value.ToString())) {
                MessageBox.Show("La cantidad indicada sobrepasa el valor de existenia");
                } else {
                List<string> detalles = new List<string>;
                detalles.Add(dgvADDPRODUCTOS.SelectedCells[0].Value.ToString());
                detalles.Add(dgvADDPRODUCTOS.SelectedCells[1].Value.ToString());
                detalles.Add(dgvADDPRODUCTOS.SelectedCells[3].Value.ToString());
                detalles.Add(dgvADDPRODUCTOS.SelectedCells[2].Value.ToString());
                detalles.Add(dgvADDPRODUCTOS.SelectedCells[4].Value.ToString());

                function.Bill.RowFill(detalles);
                function.Bill.ShowData();

                txtTOTALNETO.Text = Convert.ToString(int.Parse(txtTOTALNETO.Text) + int.Parse(dgvADDPRODUCTOS.SelectedCells[3].Value.ToString());
                txtCANTIDADDETALLE.Clear();
                }

            BUSCAR(@"SELECT PRID.ID_PRODUCTO AS [ID],PRID.NOM_PRODUCTO AS [PRODUCTO],PRID.MED_PRODUCTO AS [MEDIDA], PRCA.CAN_PRODUCTO AS [CANTIDAD], PRPR.PVEN_PRODUCTO AS [PRECIO]
FROM PRODUCTO_ID AS PRID INNER JOIN PRODUCTO_CANTIDAD AS PRCA ON PRID.ID_PRODUCTO= PRCA.ID_PRODUCTO  INNER JOIN PRODUCTO_PRECIO AS PRPR ON PRID.ID_PRODUCTO= PRPR.ID_PRODUCTO WHERE PRCA.CAN_PRODUCTO > '0'");

            }

        private void btnGenerar_Click ( object sender, EventArgs e ) {
            List<object> listDataBill = new List<object>();
            listDataBill.Add(int.Parse(cmbNAMECLIENT.ValueMember.ToString()));
            listDataBill.Add(StatusFactura);
            listDataBill.Add (TypeFactura);
            listDataBill.Add(txtDESCUENTO);


            function.Bill.GenerateBill( listDataBill, dgvDETALLEFACTURA );
      
            }

        private void btnLimpiar_Click ( object sender, EventArgs e ) {
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

        private void btnEliminarRegistro_Click ( object sender, EventArgs e ) {
            dgvDETALLEFACTURA.Rows.RemoveAt(dgvDETALLEFACTURA.CurrentRow.Index);
            }

        private void btnCarga_Click ( object sender, EventArgs e ) {
            BUSCAR(@"SELECT PRID.ID_PRODUCTO AS [ID],PRID.NOM_PRODUCTO AS [PRODUCTO],PRID.MED_PRODUCTO AS [MEDIDA], PRCA.CAN_PRODUCTO AS [CANTIDAD], 
PRPR.PVEN_PRODUCTO AS [PRECIO] FROM PRODUCTO_ID AS PRID INNER JOIN PRODUCTO_CANTIDAD AS PRCA ON PRID.ID_PRODUCTO= PRCA.ID_PRODUCTO  INNER JOIN 
PRODUCTO_PRECIO AS PRPR ON PRID.ID_PRODUCTO= PRPR.ID_PRODUCTO WHERE PRCA.CAN_PRODUCTO > '0'");
            }

        private void txtName_TextChanged ( object sender, EventArgs e ) {
            }


        private string TypeFactura ( ) {
            if (rdbCREDITO.Checked) {
                return "CREDITO";
                }else {
                return "EFECTIVO";
                }
            }

        private string StatusFactura ( ) {
            if (rdbNOENTREGADO.Checked) {
                return "NO ENTREGADO";
                } else {
                return "ENTREGADO";
                }
            }

        private void cmbNAMECLIENT_TextChanged ( object sender, EventArgs e ) {
            rdbCREDITO.Enabled = function.Bill.SearchClientName(ref cmbNAMECLIENT, ref cmbDIRECTIONCLEINT);
            }
        }
    }