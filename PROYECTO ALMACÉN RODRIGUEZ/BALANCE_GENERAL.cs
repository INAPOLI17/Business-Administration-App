using Lógica.LIBRARY;

namespace PROYECTO_ALMACÉN_RODRIGUEZ {
    public partial class BALANCE_GENERAL : Form {
        public BALANCE_GENERAL ( ) {
            InitializeComponent();
            balance = new BillAdmin();
            }

        private BillAdmin balance;

        private void btnATRASBALANCEGENERAL_Click ( object sender, EventArgs e ) {
            this.Close();
            }

        private void btnPRESENTARBALANCE_Click ( object sender, EventArgs e ) {
            balance.DataView(ref dgvBALANCEGENERAL, ref dateTimePicker1);
            }

        private void BALANCE_GENERAL_Load ( object sender, EventArgs e ) {

            }

        private void dateTimePicker1_ValueChanged ( object sender, EventArgs e ) {

            }


        }
    }
