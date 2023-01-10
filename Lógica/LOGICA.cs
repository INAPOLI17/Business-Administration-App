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
        private DataGridView dgvDETALLEFACTURA = new DataGridView();
        private DATOSFACTURA fa = new DATOSFACTURA();
        private int indice_fila = 0;



        public LOGICA ( List<object> listTextBox1, List<object> listRadio1) {
            this.listTextBox1 = listTextBox1;
            this.listRadio1 = listRadio1;
            ColumnForDGV();
        }

        public DataGridView ShowData () {

            return dgvDETALLEFACTURA;
            }

        public void ColumnForDGV ( ) {
            dgvDETALLEFACTURA.Columns.Add("ID", "ID");
            dgvDETALLEFACTURA.Columns.Add("PRODUCTO", "PRODUCTO");
            dgvDETALLEFACTURA.Columns.Add("CANTIDAD", "CANTIDAD");
            dgvDETALLEFACTURA.Columns.Add("MEDIDA", "MEDIDA");
            dgvDETALLEFACTURA.Columns.Add("PRECIO", "PRECIO");

            }

        public void RowFill (List<string> Data ) {
            indice_fila = dgvDETALLEFACTURA.Rows.Add();
            DataGridViewRow rw = dgvDETALLEFACTURA.Rows[indice_fila];
            rw.Cells["ID"].Value =  Data[0].ToString();
            rw.Cells["PRODUCTO"].Value = Data[1].ToString();
            rw.Cells["CANTIDAD"].Value = Data[2].ToString();
            rw.Cells["MEDIDA"].Value = Data[3].ToString();
            rw.Cells["PRECIO"].Value = Data[4].ToString();

            PlusTotal(int.Parse(Data[4].ToString()));
            }

        public void GenerateBill ( List<object> DataForBill, DataGridView dgvDETALLEFACTURA ) {
            
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
        
        public void PlusTotal ( int precio) {
            fa.TOTAL += precio;
            }



    }
}









