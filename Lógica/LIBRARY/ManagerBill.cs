using DATABASE;
using System.Data;
using DATABASE.LIBRARY;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DATABASE.LIBRARY.CLADATOS;

namespace Lógica.LIBRARY {
    public class ManagerBill {

        CONNETION manager = new CONNETION();
        Report ticket = new Report();
        DATOSFACTURA bill = new DATOSFACTURA();

        public void FillData ( ref DataGridView managerData) {
            managerData.DataSource = manager.consulta(@"SELECT * FROM ManagerBill ORDER BY FACTURA_DETAIL.FEC_FACTURA DESC ");
            managerData.Columns["CLID"].Visible = false;
            managerData.Columns["IDFAC"].Visible = false;
            }

        public void FillData( ref DataGridView managerData, ref TextBox name, string date ) {
            managerData.DataSource = manager.consulta(@"SELECT * FROM ManagerBill WHERE CLIENTE_ID LIKE %"+name.Text+"%" +
                "AND FACTURA_DETAIL.FEC_FACTURA BETWEEN "+date+" ORDER BY FACTURA_DETAIL.FEC_FACTURA DESC ");
            managerData.Columns["CLID"].Visible = false;
            managerData.Columns["IDFAC"].Visible = false;
            }

        public void ChangeStatus ( string status ) {

            Func<string, string> funs = e =>status == "ENTREGADO" ? "NO ENTREGADO" : "ENTREGADO";
            bill.ESTADO = funs(status);

            manager.DATOSFACTURA(bill);
            }

        public void Pay ( int cli, int bill ) {
            manager.PAGO(cli, bill);

            }

        public void DeleteRegister( int id ) {
            manager.DeleteRegisterBill(id);
            }
        }
    }
