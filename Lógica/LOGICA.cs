using Lógica.LIBRARY;
using System.Collections.Generic;
using System.Windows.Forms;


namespace LOGIC.LIBRARY {
    public class LOGICA {

        private List<object> listTextBox1;
        private List<object> listRadio1;
        private DataGridView DGVPRINTER;


        public LOGICA ( List<object> listTextBox1, List<object> listRadio1, DataGridView RW ) {
            this.listTextBox1 = listTextBox1;
            this.listRadio1 = listRadio1;
            this.DGVPRINTER = RW;
            }

        private void Printer ( ) {
            Report ticket = new Report(DGVPRINTER);
        }

    }
}









