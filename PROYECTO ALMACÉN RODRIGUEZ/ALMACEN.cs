using Lógica.LIBRARY;

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

            function = new ClassWareHouse();
            }

        private ClassWareHouse function;
        private List<object> products = new List<object>();

        private void btnATRASALMACEN_Click ( object sender, EventArgs e ) {
            this.Close();
            }

        private void ALMACEN_Load ( object sender, EventArgs e ) {
            function.DataView(ref dvgALMACEN, "");
            }

        private void txtBUSCARPRODUCTO_Click ( object sender, EventArgs e ) {
            function.DataView(ref dvgALMACEN , txtWAREHOUSESEARCH.Text);
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

            function.SaveDataProducts(products);
            function.DataView(ref dvgALMACEN, "");
            }

        private void btnELIMINARREGISTROALMACEN_Click ( object sender, EventArgs e ) {

            function.DeleteDataProducts(int.Parse(dvgALMACEN.SelectedCells[0].Value.ToString()));
            function.DataView(ref dvgALMACEN, "");

            }
        }
    }
