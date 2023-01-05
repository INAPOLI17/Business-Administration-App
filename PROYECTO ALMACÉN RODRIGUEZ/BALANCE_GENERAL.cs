using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROYECTO_ALMACÉN_RODRIGUEZ
{
    public partial class BALANCE_GENERAL : Form
    {
        public BALANCE_GENERAL()
        {
            InitializeComponent();
        }

        CONEXION cn = new CONEXION();

        private void btnATRASBALANCEGENERAL_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnPRESENTARBALANCE_Click(object sender, EventArgs e)
        {
            int indice_fila = dgvBALANCEGENERAL.Rows.Add();
            DataGridViewRow rw = dgvBALANCEGENERAL.Rows[indice_fila];
            rw.Cells["FECHA"].Value = dateTimePicker1.Value.ToString("yyyy - MM - dd");
            rw.Cells["EFECTIVO"].Value =BALANCE(@$"SELECT ID.SUM_FACTURA AS [SUMA], CONVERT(date,FEC_FACTURA) AS FECHA FROM [FACTURA ID] AS ID 
INNER JOIN FACTURA_ESTADO AS FE ON ID.ID_FACTURA = FE.ID_FACTURA WHERE FE.TIP_FACTURA = 'EFECTIVO' AND  ID.FEC_FACTURA = '"+ dateTimePicker1.Value.ToString("yyyy-MM-dd") +"'");
            rw.Cells["CREDITO"].Value = BALANCE(@$"SELECT ID.SUM_FACTURA AS [SUMA], CONVERT(date,FEC_FACTURA) AS FECHA FROM [FACTURA ID] AS ID INNER JOIN FACTURA_ESTADO AS FE ON ID.ID_FACTURA = 
FE.ID_FACTURA WHERE FE.TIP_FACTURA = 'CREDITO' AND  ID.FEC_FACTURA = ' {dateTimePicker1.Value.ToString("yyyy-MM-dd")} ';");
            rw.Cells["TOTAL"].Value = int.Parse(rw.Cells["EFECTIVO"].Value.ToString())+ int.Parse(rw.Cells["CREDITO"].Value.ToString()) ;
            

        }

        private void BALANCE_GENERAL_Load(object sender, EventArgs e)
        {
            dgvBALANCEGENERAL.Columns.Add("FECHA", "FECHA");
            dgvBALANCEGENERAL.Columns.Add("EFECTIVO", "VENTAS EN EFECTIVO");
            dgvBALANCEGENERAL.Columns.Add("CREDITO", "VENTAS A CREDITO");
            dgvBALANCEGENERAL.Columns.Add("TOTAL", "TOTAL VENDIDO");
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        public UInt64 BALANCE(string str)
        {

            DataTable dtBalance = new DataTable();
            dtBalance = cn.consulta(str);
            UInt64 total = 0;
            foreach (DataRow dr in dtBalance.Rows)
            {
                total = total +  Convert.ToUInt64(dr["SUMA"].ToString());
            }
            return total;

        }
    }
}
