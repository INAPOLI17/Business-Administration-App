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
        private DATOSPRODUCTOS dp = new DATOSPRODUCTOS();

        public void SaveDataProducts ( List<object> products ) { 
            
            if (VerifyDataProducts(products)) {
                dp.NAMEPRODUCTO = products[0].ToString();
                dp.CANTIDAD = int.Parse(products[1].ToString());
                dp.DISTRIBUIDOR = products[2].ToString();
                dp.MEDIDA = products[3].ToString();
                dp.PRECIOCOMPRA = int.Parse(products[4].ToString());
                dp.PRECIOVENTA = int.Parse(products[5].ToString());

                bridgetobd.DATOSALMACEN(dp, "AÑADIR");

                }

            }

        private bool VerifyDataProducts ( List<object> products ) {

            for (int i = 0; i < products.Count; i++) {

                if (products[i] != null) {
                    return false;
                    } 
                
            }
            return true;
            }

        public void DeleteDataProducts ( int id) {
            dp.ID = id;
            bridgetobd.DATOSALMACEN(dp, "BORRAR");
            }
    }
}
