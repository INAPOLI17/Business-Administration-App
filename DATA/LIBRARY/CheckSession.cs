using System;
using System.Data;
using System.Windows.Forms;
using DATABASE.LIBRARY.CLADATOS;


namespace DATABASE {
    public class CheckSession : ClassSearch {

        public bool checkinicio ( string nombre, string pass ) {

            DataTable dt = new DataTable();
            dt = consulta("SELECT * FROM INICIO WHERE NAME_USER = '" + nombre + "' AND PASS_USER = '" + pass + "'");


            if (dt.Rows.Count > 0) {
                DATOSUSER.IDUSER = int.Parse(dt.Rows[0]["ID_USER"].ToString());
                DATOSUSER.NAMEUSER = dt.Rows[0]["NAME_USER"].ToString();
                DATOSUSER.PASSWORDUSER = dt.Rows[0]["PASS_USER"].ToString();
                return true;
                } else {
                return false;
                }
            }

        public bool LlenadoCombo ( ComboBox combobox, string strsql, string codigos, string nombre ) {
            DataTable dt = new DataTable();
            dt = consulta(strsql);

            if (dt.Rows.Count > 0) {
                combobox.ValueMember = codigos;
                combobox.DisplayMember = nombre;
                ;
                combobox.DataSource = dt;
                return true;
                } else {
                return false;
                }
            }

        public bool CHECKEDID ( int ID, string ley ) {
            string strCliente = @"SELECT ID_CLIENTE AS [ID] FROM CLIENTE_DIRECCION WHERE ID_CLIENTE = '" + ID + "'";
            string strFACTURA = @"SELECT ID_FACTURA FROM [FACTURA ID] WHERE ID_FACTURA = '" + ID + "'";
            string strALMACEN = @"SELECT ID_PRODUCTO AS [ID] FROM PRODUCTO_ID WHERE ID_PRODUCTO = '" + ID + "'";

            DataTable dt = new DataTable();

            switch (ley) {
                case "CLIENTE":
                    dt = consulta(strCliente);
                    break;
                case "FACTURA":
                    dt = consulta(strFACTURA);
                    break;
                case "ALMACEN":
                    dt = consulta(strALMACEN);
                    break;
                }

            if (dt.Rows.Count > 0) {
                return true;
                } else {
                return false;
                }
            }

        public int GENERARID ( string LEY ) {
            int min = 1;
            int max = 1000000;
            int ID = 0;
            Random rand = new Random();
            ID = rand.Next(min, max);


            if (CHECKEDID(ID, LEY)) {
                return GENERARID(LEY);
                } else {
                return ID;
             }
        }
    }
}
