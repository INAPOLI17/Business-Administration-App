
using Lógica.LIBRARY;

namespace PROYECTO_ALMACÉN_RODRIGUEZ {
    public partial class GESTOR_FACTURA : Form {
        public GESTOR_FACTURA ( ) {
            InitializeComponent();

            }
        private ManagerBill bill = new ManagerBill ();

        private void btnATRASGESTOR_Click ( object sender, EventArgs e ) {
            this.Close();
            }

        private void GESTOR_FACTURA_Load ( object sender, EventArgs e ) {
            txtCLIENTEGESTOR.Enabled = false;
            dateTimePicker1.Enabled = false;
            btnBUCARFACTURA.Enabled = false;
            btnCAMBIARESTADO.Enabled = false;
            btnPAGARFACTURA.Enabled = false;
            bill.FillData(ref dgvGESTORFACTURA);
            }

        private void btnBUCARFACTURA_Click ( object sender, EventArgs e, string cmd ) {
            bill.FillData(ref dgvGESTORFACTURA, ref txtCLIENTEGESTOR, dateTimePicker1.Value.ToString() + "AND " + dateTimePicker1.Value.ToString() + "");

            }


        private void dgvGESTORFACTURA_DoubleClick ( object sender, EventArgs e ) {
            btnCAMBIARESTADO.Enabled = true;
            btnPAGARFACTURA.Enabled = true;
            }

        private void btnPAGARFACTURA_Click ( object sender, EventArgs e ) {
            bill.Pay(int.Parse(dgvGESTORFACTURA.SelectedCells[0].Value.ToString()), int.Parse(dgvGESTORFACTURA.SelectedCells[3].Value.ToString()));
            }

        private void btnCAMBIARESTADO_Click ( object sender, EventArgs e ) {
            bill.ChangeStatus(dgvGESTORFACTURA.SelectedCells[8].Value.ToString());
            }

        private void button1_Click ( object sender, EventArgs e ) {
            btnBUCARFACTURA.Focus();
            }

        private void ActiveText ( object sender, EventArgs e ) {
            btnBUCARFACTURA.Enabled = true;
            dateTimePicker1.Enabled = true;
            dateTimePicker2.Enabled = true;
            }

        private void btnSeeAllBill_Click ( object sender, EventArgs e ) {
            bill.FillData(ref dgvGESTORFACTURA);
            }

        private void DeleteRegister ( object sender, EventArgs e ) {
            bill.DeleteRegister(int.Parse(dgvGESTORFACTURA.SelectedCells[3].Value.ToString()));
            }
        }
    }
