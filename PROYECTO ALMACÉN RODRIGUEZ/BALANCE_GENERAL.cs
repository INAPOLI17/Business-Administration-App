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
    public partial class BALANCE_GENERAL : Form
    {
        public BALANCE_GENERAL()
        {
            InitializeComponent();
            balance = new LOGICA();
        }

        private LOGICA balance;

        private void btnATRASBALANCEGENERAL_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnPRESENTARBALANCE_Click(object sender, EventArgs e)
        {
            balance.GeneralBalance.DataView(ref dgvBALANCEGENERAL, ref dateTimePicker1);
        }

        private void BALANCE_GENERAL_Load(object sender, EventArgs e)
        {
        
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

      
    }
}
