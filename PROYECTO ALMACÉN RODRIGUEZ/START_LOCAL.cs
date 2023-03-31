using LOGIC;
using Lógica.LIBRARY;

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

             ini = new ClassBill();
            }

        private ClassBill ini;

        private void INICIO_Load ( object sender, EventArgs e ) {
            BUSCAR();                          
            }

        private void btnBuscarproducto_Click ( object sender, EventArgs e ) {
            BUSCAR(txtProductos.Text);
            }

        private void BUSCAR () {

            ini.FillData(ref dgvADDPRODUCTOS);

            }

        private void BUSCAR ( string STRSQL ) {
            ini.FillData(ref dgvADDPRODUCTOS, STRSQL);
            }

        private void button1_Click ( object sender, EventArgs e ) {


            if (int.Parse(txtCANTIDADDETALLE.Text) > int.Parse(dgvADDPRODUCTOS.SelectedCells[3].Value.ToString())) {
                MessageBox.Show("La cantidad indicada sobrepasa el valor de existenia");
                } else {
                List<string> detalles = new List<string>();
                detalles.Add(dgvADDPRODUCTOS.SelectedCells[0].Value.ToString());
                detalles.Add(dgvADDPRODUCTOS.SelectedCells[1].Value.ToString());
                detalles.Add(dgvADDPRODUCTOS.SelectedCells[3].Value.ToString());
                detalles.Add(dgvADDPRODUCTOS.SelectedCells[2].Value.ToString());
                detalles.Add(dgvADDPRODUCTOS.SelectedCells[4].Value.ToString());

                ini.RowFill(detalles);
                BUSCAR();

                txtTOTALNETO.Text = Convert.ToString(int.Parse(txtTOTALNETO.Text) + int.Parse(dgvADDPRODUCTOS.SelectedCells[3].Value.ToString()));
                txtCANTIDADDETALLE.Clear();
                }

            BUSCAR();

            }

        private void btnGenerar_Click ( object sender, EventArgs e ) {
            List<object> listDataBill = new List<object>();
            listDataBill.Add(int.Parse(cmbNAMECLIENT.ValueMember.ToString()));
            listDataBill.Add(StatusFactura);
            listDataBill.Add(TypeFactura);
            listDataBill.Add(txtDESCUENTO);


            ini.GenerateBill(listDataBill, ref dgvDETALLEFACTURA);

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
            BUSCAR();
            }

        private void txtName_TextChanged ( object sender, EventArgs e ) {
            }


        private string TypeFactura ( ) {
            if (rdbCREDITO.Checked) {
                return "CREDITO";
                } else {
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
            rdbCREDITO.Enabled = ini.SearchClientName(ref cmbNAMECLIENT, ref cmbDIRECTIONCLEINT);
            }
        }
    }