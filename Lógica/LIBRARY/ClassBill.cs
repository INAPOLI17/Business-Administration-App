using System.Windows.Forms;
using System;
using DATABASE.LIBRARY.CLADATOS;
using System.Collections.Generic;
using DATABASE;

namespace Lógica.LIBRARY {
    public class ClassBill : Report {

        private DataGridView dgvDETALLEFACTURA = new DataGridView();
        private DATOSFACTURA fa = new DATOSFACTURA();
        private List<object> listRadio1;
        private CONNETION brigdetodata = new CONNETION();
        private int indice_fila = 0;

        public ClassBill ( ) {
            ColumnForDGV();
            }
        public DataGridView ShowData ( ) {

            return dgvDETALLEFACTURA;
            }

        public void ColumnForDGV ( ) {
            dgvDETALLEFACTURA.Columns.Add("ID", "ID");
            dgvDETALLEFACTURA.Columns.Add("PRODUCTO", "PRODUCTO");
            dgvDETALLEFACTURA.Columns.Add("CANTIDAD", "CANTIDAD");
            dgvDETALLEFACTURA.Columns.Add("MEDIDA", "MEDIDA");
            dgvDETALLEFACTURA.Columns.Add("PRECIO", "PRECIO");

            }

        public void RowFill ( List<string> Data ) {
            indice_fila = dgvDETALLEFACTURA.Rows.Add();
            DataGridViewRow rw = dgvDETALLEFACTURA.Rows[indice_fila];
            rw.Cells["ID"].Value = Data[0].ToString();
            rw.Cells["PRODUCTO"].Value = Data[1].ToString();
            rw.Cells["CANTIDAD"].Value = Data[2].ToString();
            rw.Cells["MEDIDA"].Value = Data[3].ToString();
            rw.Cells["PRECIO"].Value = Data[4].ToString();

            fa.TOTAL += (int.Parse(Data[4].ToString()));
            }

        public void GenerateBill ( List<object> DataForBill, DataGridView dgvDETALLEFACTURA ) {

            DATOSDETALLE de = new DATOSDETALLE();

            fa.IDCLIENTE = int.Parse(DataForBill[0].ToString());
            fa.ESTADO = DataForBill[2].ToString();
            fa.TIPOFACTURA = DataForBill[3].ToString();
            fa.DESCUENTO = int.Parse(DataForBill[4].ToString());

            if (brigdetodata.DATOSFACTURA(dgvDETALLEFACTURA, fa)) {
                reportFactura(dgvDETALLEFACTURA, DataForBill);
                } else {
                MessageBox.Show("Ocurrio un error al aÑadir la factura");
                }
            }

     

        public bool SearchClientName ( ref ComboBox Name, ref ComboBox Direction ) {
            try {
                if (brigdetodata.LlenadoCombo(Name, @"SELECT ID_CLIENTE, NOM_CLIENTE
                    FROM CLIENTE_ID WHERE NOM_CLIENTE LIKE '%" + Name.Text + "%'", "ID_CLIENTE", "NOM_CLIENTE") && Name.Text != " ") {
                    brigdetodata.LlenadoCombo(Direction, @"SELECT *
                    FROM CLIENTE_DIRECCION WHERE ID_CLIENTE LIKE'" + Name.SelectedValue.ToString() + "'", "ID_CLIENTE", "DIR_CLIENTE");
                    fa.IDCLIENTE = int.Parse(Name.SelectedValue.ToString());
                    Name.Text = Name.SelectedText.ToString();
                    SearchClientDirection(Name.Text, ref Direction);

                    return true;
                    } else {
                    fa.IDCLIENTE = 0;
                    Name.ValueMember = "0";
                    throw new ArgumentNullException(nameof(Name));

                    }
                }
            catch (ArgumentNullException) {
                MessageBox.Show("Cliente no encontrado");
                return false;
                }

            }

        private void SearchClientDirection ( String NameClient, ref ComboBox Direction ) {

            try {
                if (NameClient != null) {

                    brigdetodata.LlenadoCombo(Direction, @"SELECT *
                    FROM CLIENTE_DIRECCION WHERE ID_CLIENTE LIKE'" + NameClient + "'", "ID_CLIENTE", "DIR_CLIENTE");
                    } else {
                    throw new ArgumentNullException(nameof(NameClient));
                    }
                }
            catch (ArgumentNullException) {
                MessageBox.Show("Cliente no cuenta con una dirección");
                }

            }
        }
    }
