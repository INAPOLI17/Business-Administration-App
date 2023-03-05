using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DATABASE.LIBRARY.CLADATOS;
using DATABASE;
using System.Windows.Forms;

namespace Lógica.LIBRARY {
    public class BillAdmin {

        private CONNETION brigdetobd = new CONNETION();
        private DATOSFACTURA bill = new DATOSFACTURA();

        public void DataView ( ref DataGridView dt, ref DateTimePicker fecha) {

            int indice_fila = dt.Rows.Add();
            DataGridViewRow rw = dt.Rows[indice_fila];
            dt.DataSource = brigdetobd.consulta("SELECT * FROM BALANCEGENERAL WHERE DETAIL.FEC_FACTURA = " + fecha.Value.ToString("yyyy-MM-dd") + ";");
            rw.Cells["TOTAL"].Value = int.Parse(rw.Cells["EFECTIVO"].Value.ToString()) + int.Parse(rw.Cells["CREDITO"].Value.ToString());
                  
         }



        }
    }
