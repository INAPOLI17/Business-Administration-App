using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LOGIC;

namespace PROYECTO_ALMACÉN_RODRIGUEZ
{
    public partial class CLIENTE : Form
    {
        public CLIENTE()
        {
            InitializeComponent();
            Data = new List<object>();
            Data.Add(TXTID);
            Data.Add(txtNOMBRECLIENTE);
            Data.Add(txtApellido);
            Data.Add(txtDIRECCION);
            Data.Add(txtTELEFONO);

            function = new LOGICA();
        }

        private LOGICA function;
        private List<object> Data; 

        private void btnATRASCLIENTE_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBUSCARCLIENTES_Click(object sender, EventArgs e)
        {
            function.client.DataView(ref dgvCLIENTES, txtCLIENTESSEARCH.Text);
            }

        private void CLIENTE_Load(object sender, EventArgs e)
        {
            function.client.DataView(ref dgvCLIENTES, "");
        }

        private void dgvCLIENTES_DoubleClick(object sender, EventArgs e)
        {
            TXTID.Text = dgvCLIENTES.SelectedCells[0].Value.ToString();
            txtNOMBRECLIENTE.Text = dgvCLIENTES.SelectedCells[1].Value.ToString();
            txtApellido.Text = dgvCLIENTES.SelectedCells[2].Value.ToString();
            txtDIRECCION.Text = dgvCLIENTES.SelectedCells[3].Value.ToString();
            txtTELEFONO.Text = dgvCLIENTES.SelectedCells[4].Value.ToString();

        }

        private void btnLIMPIARCLIENTE_Click(object sender, EventArgs e)
        {
            foreach(Control i in Data) {
                i.Text = String.Empty;
                }
        }

        private void btnGUARDARCLIENTE_Click(object sender, EventArgs e)
        {
            function.client.SaveDataClient(Data);
            function.client.DataView(ref dgvCLIENTES, "");
            }

        private void btnBORRARCLIENTE_Click(object sender, EventArgs e)
        {

            function.client.DeleteDataClient(int.Parse(dgvCLIENTES.SelectedCells[0].Value.ToString()));
            function.client.DataView(ref dgvCLIENTES, "");
            }
    }
}
