using System.Collections.Generic;
using System.Windows.Forms;
using DATABASE;
using DATABASE.LIBRARY.CLADATOS;
using Lógica.LIBRARY;


namespace LOGIC {
    public class LOGICA:Report {

        private List<object> listTextBox1;
        private List<object> listRadio1;
        private DataGridView DGVPRINTER;
        private CONNETION brigdetodata = new CONNETION();
        

        public LOGICA ( List<object> listTextBox1, List<object> listRadio1, DataGridView RW ) {
            this.listTextBox1 = listTextBox1;
            this.listRadio1 = listRadio1;
            this.DGVPRINTER = RW;
        }

        private void Printer ( ) {

        }

        private void GenerateBill ( List<object> DataForBill) {
            DATOSFACTURA fa = new DATOSFACTURA();

        }

    }
}









