namespace PROYECTO_ALMACÉN_RODRIGUEZ {
    public partial class AJUSTEINIICIO : Form {
        public AJUSTEINIICIO ( ) {
            InitializeComponent();
            }




        private void AJUSTEINIICIO_Load ( object sender, EventArgs e ) {
            txtNAMEUSER.Text = DATOSUSER.NAMEUSER;
            }

        private void btnAPLICAR_Click ( object sender, EventArgs e ) {
            if (txtPASSNEW.Text == txtPASSNEWCONFIRM.Text && txtPASSACTUALLY.Text == DATOSUSER.PASSWORDUSER) {
                cn.DATOSUSUARIO(DATOSUSER.IDUSER, txtNAMEUSER.Text, txtPASSNEWCONFIRM.Text);
                MessageBox.Show("Los cambios se han aplicado correctamente");
                } else {
                MessageBox.Show("Los Datos no correspondieron, por favor verifique");
                }
            }
        }
    }
