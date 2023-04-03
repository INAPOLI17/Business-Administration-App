using Lógica;
using Lógica.LIBRARY;

namespace PROYECTO_ALMACÉN_RODRIGUEZ {
    public partial class AJUSTEINIICIO : Form {
        public AJUSTEINIICIO ( ) {
            InitializeComponent();
            text = new List<TextBox>();
            text.Add(txtNAMEUSER);
            text.Add(txtPASSACTUALLY);
            text.Add(txtPASSNEW);
            text.Add(txtPASSNEWCONFIRM);

            user1 = new DataUsers();
            }

        List<TextBox> text ;
        DataUsers user1;
        private void AJUSTEINIICIO_Load ( object sender, EventArgs e ) {
            user1.complete(text);
            }

        private void btnAPLICAR_Click ( object sender, EventArgs e ) {
            user1.aplicar(text);
            }
        }
    }
