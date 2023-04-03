using Lógica.LIBRARY;
using System.Reflection.Metadata.Ecma335;

namespace PROYECTO_ALMACÉN_RODRIGUEZ {
    public partial class CLIENTE : Form {
        public CLIENTE ( ) {
            InitializeComponent();
            Data = new List<TextBox>();
            Data.Add(TXTID);
            Data.Add(txtNOMBRECLIENTE);
            Data.Add(txtApellido);
            Data.Add(txtDIRECCION);
            Data.Add(txtTELEFONO);

            function = new ClassClient();
            }

        private ClassClient function;
        private List<TextBox> Data;


        private void btnATRASCLIENTE_Click ( object sender, EventArgs e ) {
            this.Close();
            }

        private void btnBUSCARCLIENTES_Click ( object sender, EventArgs e ) {
            function.DataView(ref dgvCLIENTES, txtCLIENTESSEARCH.Text);
            }

        private void CLIENTE_Load ( object sender, EventArgs e ) {
            function.DataView(ref dgvCLIENTES, "");
            }

        private void dgvCLIENTES_DoubleClick ( object sender, EventArgs e ) {
            TXTID.Text = dgvCLIENTES.SelectedCells[0].Value.ToString();
            txtNOMBRECLIENTE.Text = dgvCLIENTES.SelectedCells[1].Value.ToString();
            txtApellido.Text = dgvCLIENTES.SelectedCells[2].Value.ToString();
            txtDIRECCION.Text = dgvCLIENTES.SelectedCells[3].Value.ToString();
            txtTELEFONO.Text = dgvCLIENTES.SelectedCells[4].Value.ToString();

            }

        private void btnLIMPIARCLIENTE_Click ( object sender, EventArgs e ) {
            foreach (Control i in Data) {
                i.Text = String.Empty;
                }
            }



        private void Save ( ) {
            function.SaveDataClient(Data);
            function.DataView(ref dgvCLIENTES, "");
            }

        private void Update ( ){
            function.UpdateDataClient(Data);
            function.DataView(ref dgvCLIENTES, "");
            }

        private void btnGUARDARCLIENTE_Click ( object sender, EventArgs e ) {
            if (TXTID.Text != string.Empty)
                Update();

            Save ( );
            }

        private void btnBORRARCLIENTE_Click ( object sender, EventArgs e ) {

            function.DeleteDataClient(int.Parse(dgvCLIENTES.SelectedCells[0].Value.ToString()));
            function.DataView(ref dgvCLIENTES, "");
            }
        }
    }
