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

        public void DataView (ref DataGridView dt , String key ) {

            if ( key != String.Empty ) {
                dt.DataSource = brigdetobd.consulta("SELECT * FROM FACTURA_ID WHERE FECHA BETWEEN "+key.ToString("yyyy-MM-dd")+ " AND (SELECT CONVERT (date, GETDATE())) ")
            }
        }
    }
