using LOGIC;

namespace PROYECTO_ALMACÉN_RODRIGUEZ {
    public partial class ALMACEN : Form {
        public ALMACEN ( ) {
            InitializeComponent();

            products.Add(txtNOMBREPRODUCTO);
            products.Add(txtCANTIDAD);
            products.Add(txtDISTRIBUIDOR);
            products.Add(cmbUNIDADMEDIDA);
            products.Add(txtPRECIOCOMPRA);
            products.Add(txtPRECIOVENTA);
            products.Add(txtID);

            function = new LOGICA();
            }

        private LOGICA function;
        private List<object> products = new List<object>();

        private void btnATRASALMACEN_Click ( object sender, EventArgs e ) {
            this.Close();
            }

        public void BUSCAR ( string STRSQL ) {
            dvgALMACEN.DataSource = cn.consulta(STRSQL);
            }

        private void ALMACEN_Load ( object sender, EventArgs e ) {
            BUSCAR(@"SELECT PRID.ID_PRODUCTO AS [ID],PRID.NOM_PRODUCTO AS [PRODUCTO], PRCA.CAN_PRODUCTO AS [CANTIDAD], PRID.MED_PRODUCTO AS [MEDIDA], PRPR.PVEN_PRODUCTO AS [PRECIO VENTA],
PRDI.DIST_PRODUCTO AS [DISTRIBUIDOR], PRPR.PCOM_PRODUCTO AS [PRECIO COMPRA] FROM PRODUCTO_ID AS PRID INNER JOIN PRODUCTO_CANTIDAD AS PRCA ON 
PRID.ID_PRODUCTO= PRCA.ID_PRODUCTO INNER JOIN PRODUCTO_PRECIO AS PRPR ON PRID.ID_PRODUCTO= PRPR.ID_PRODUCTO INNER JOIN PRODUCTO_DISTRIBUIDOR 
AS PRDI ON PRID.ID_PRODUCTO = PRDI.ID_PRODUCTO ;");
            }

        private void txtBUSCARPRODUCTO_Click ( object sender, EventArgs e ) {
            BUSCAR(@"SELECT PRID.ID_PRODUCTO AS [ID],PRID.NOM_PRODUCTO AS [PRODUCTO], PRCA.CAN_PRODUCTO AS [CANTIDAD], PRID.MED_PRODUCTO AS [MEDIDA], PRPR.PVEN_PRODUCTO AS [PRECIO VENTA],
PRDI.DIST_PRODUCTO AS [DISTRIBUIDOR], PRPR.PCOM_PRODUCTO AS [PRECIO COMPRA] FROM PRODUCTO_ID AS PRID INNER JOIN PRODUCTO_CANTIDAD AS PRCA ON 
PRID.ID_PRODUCTO= PRCA.ID_PRODUCTO INNER JOIN PRODUCTO_PRECIO AS PRPR ON PRID.ID_PRODUCTO= PRPR.ID_PRODUCTO INNER JOIN PRODUCTO_DISTRIBUIDOR 
AS PRDI ON PRID.ID_PRODUCTO = PRDI.ID_PRODUCTO WHERE PRID.ID_PRODUCTO LIKE '%" + txtBUSCARPRODUCTO.Text + "%'");
            }

        private void dvgALMACEN_DoubleClick ( object sender, EventArgs e ) {

            txtID.Text = dvgALMACEN.SelectedCells[0].Value.ToString();
            txtNOMBREPRODUCTO.Text = dvgALMACEN.SelectedCells[1].Value.ToString();
            txtCANTIDAD.Text = dvgALMACEN.SelectedCells[2].Value.ToString();
            cmbUNIDADMEDIDA.Text = dvgALMACEN.SelectedCells[3].Value.ToString();
            txtPRECIOVENTA.Text = dvgALMACEN.SelectedCells[4].Value.ToString();
            txtDISTRIBUIDOR.Text = dvgALMACEN.SelectedCells[5].Value.ToString();
            txtPRECIOCOMPRA.Text = dvgALMACEN.SelectedCells[6].Value.ToString();

            }

        private void btnLIMPIARALMACEN_Click ( object sender, EventArgs e ) {

            txtID.Text = string.Empty;
            txtNOMBREPRODUCTO.Text = string.Empty;
            txtCANTIDAD.Text = string.Empty;
            txtDISTRIBUIDOR.Text = string.Empty;
            txtPRECIOCOMPRA.Text = string.Empty;
            txtPRECIOVENTA.Text = string.Empty;
            cmbUNIDADMEDIDA.SelectedIndex.ToString(" ");

            }

        private void btnGUARDARALMACEN_Click ( object sender, EventArgs e ) {

            function.wareHouse.SaveDataProducts(products);

            }

        private void btnELIMINARREGISTROALMACEN_Click ( object sender, EventArgs e ) {

            function.wareHouse.DeleteDataProducts(int.Parse(dvgALMACEN.SelectedCells[0].Value.ToString()));
            BUSCAR(@"SELECT PRID.ID_PRODUCTO AS [ID],PRID.NOM_PRODUCTO AS [PRODUCTO], PRCA.CAN_PRODUCTO AS [CANTIDAD], PRID.MED_PRODUCTO AS [MEDIDA], PRPR.PVEN_PRODUCTO AS [PRECIO VENTA],
PRDI.DIST_PRODUCTO AS [DISTRIBUIDOR], PRPR.PCOM_PRODUCTO AS [PRECIO COMPRA] FROM PRODUCTO_ID AS PRID INNER JOIN PRODUCTO_CANTIDAD AS PRCA ON 
PRID.ID_PRODUCTO= PRCA.ID_PRODUCTO INNER JOIN PRODUCTO_PRECIO AS PRPR ON PRID.ID_PRODUCTO= PRPR.ID_PRODUCTO INNER JOIN PRODUCTO_DISTRIBUIDOR 
AS PRDI ON PRID.ID_PRODUCTO = PRDI.ID_PRODUCTO ;");

            }
        }
    }
