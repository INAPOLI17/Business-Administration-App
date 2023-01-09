using System.Collections.Generic;
using System.Windows.Forms;
using DATABASE;
using DATABASE.LIBRARY.CLADATOS;
using Lógica.LIBRARY;


namespace LOGIC {
    public class LOGICA:Report {

        private List<object> listTextBox1;
        private List<object> listRadio1;
        private CONNETION brigdetodata = new CONNETION();
        

        public LOGICA ( List<object> listTextBox1, List<object> listRadio1) {
            this.listTextBox1 = listTextBox1;
            this.listRadio1 = listRadio1;

        }

        public void GenerateBill ( List<object> DataForBill, DataGridView dgvDETALLEFACTURA ) {
            DATOSFACTURA fa = new DATOSFACTURA();
            DATOSDETALLE de = new DATOSDETALLE();

            fa.NAMECLIENTE = DataForBill[0].ToString();
            fa.DIRECCION = DataForBill[1].ToString();
            fa.ESTADO = DataForBill[2].ToString();
            fa.TIPOFACTURA = DataForBill[3].ToString();


            for (int i = 0; i < dgvDETALLEFACTURA.Rows.Count; i++) {


                de.IDFACTURA = fa.ID;
                de.IDPRODUCTO = int.Parse(dgvDETALLEFACTURA.Rows[i].Cells["ID"].Value.ToString());
                de.CANTIDAD = int.Parse(dgvDETALLEFACTURA.Rows[i].Cells["CANTIDAD"].Value.ToString());
                de.MEDIDA = dgvDETALLEFACTURA.Rows[i].Cells["MEDIDA"].Value.ToString();
                de.PRECIO = int.Parse(dgvDETALLEFACTURA.Rows[i].Cells["PRECIO"].Value.ToString());

                brigdetodata.DATOSDETALLE(de, "AÑADIRDETALLE");
                brigdetodata.ControlCantidadProductos (de.IDPRODUCTO, de.CANTIDAD);
                }

            reportFactura(dgvDETALLEFACTURA, );
            }



    }
}









