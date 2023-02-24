using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace DATABASE.LIBRARY.CLADATOS
{
    public class DATOSFACTURA
    {
        public int ID { get; set; }
        public string NAMECLIENTE { get; set; }
        public int IDCLIENTE { get; set; }
        public int PAGONETO { get; set; }

        public string DIRECCION { get; set; }
        public string ESTADO { get; set; }
        public int TOTAL { get; set; }
        public int DESCUENTO { get; set; }
        public string TIPOFACTURA { get; set; }
        public int IDPRODUCTO { get; set; }
        public string NAMEPRODUCTO { get; set; }
        public int CANTIDAD { get; set; }
        public string MEDIDA { get; set; }
        public int PRECIOCOMPRA { get; set; }
        public int PRECIOVENTA { get; set; }
        public string DISTRIBUIDOR { get; set; }
        }
}
