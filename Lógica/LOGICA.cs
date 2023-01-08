using System.Collections.Generic;
using System.Windows.Forms;
using DATABASE;
using DATABASE.LIBRARY.CLADATOS;
using Lógica.LIBRARY;
using System.Reflection;
using System;

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

        public void GenerateBill ( List<object> DataForBill) {
            DATOSFACTURA fa = new DATOSFACTURA();
            DATOSDETALLE de = new DATOSDETALLE();

            fa.NAMECLIENTE = DataForBill[0].ToString();
            fa.DIRECCION = DataForBill[1].ToString();
            if (DataForBill[2].Equals(true)) {
                fa.ESTADO = "NO ENTREGADA";
                } else {
                fa.ESTADO = "ENTREGADO";
                }
            if (DataForBill[4].Equals(true)) {
                fa.TIPOFACTURA = "CREDITO";
                } else {
                fa.TIPOFACTURA = "EFECTIVO";
                }
        }




    }
}









