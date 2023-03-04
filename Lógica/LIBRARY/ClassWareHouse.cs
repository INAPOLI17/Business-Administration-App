using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DATABASE.LIBRARY.CLADATOS;
using DATABASE;

namespace Lógica.LIBRARY {
    public class ClassWareHouse : Report {

        private CONNETION bridgetobd = new CONNETION();
        private DATOSFACTURA dp = new DATOSFACTURA();

        public void DataView ( ref DataGridView dt, String key ) {

            if (key != String.Empty) {
                dt.DataSource = bridgetobd.consulta("SELECT * FROM PRODUCTOS  WHERE NOMBRE LIKE '%" + key + "%'");
                }
            dt.DataSource = bridgetobd.consulta("SELECT * FROM PRODUCTOS");
            }

        public void SaveDataProducts ( List<object> products ) { 
            
                dp.NAMEPRODUCTO = products[0].ToString();
                dp.CANTIDAD = int.Parse(products[1].ToString());
                dp.DISTRIBUIDOR = products[2].ToString();
                dp.MEDIDA = products[3].ToString();
                dp.PRECIOCOMPRA = int.Parse(products[4].ToString());
                dp.PRECIOVENTA = int.Parse(products[5].ToString());

                bridgetobd.DATOSALMACEN(dp, "AÑADIR");
            }

        public void DeleteDataProducts ( int id) {
            dp.ID = id;
            bridgetobd.DATOSALMACEN(dp, "BORRAR");
            }
    }
}
