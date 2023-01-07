using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace DATABASE.LIBRARY.CLADATOS
{
    public class DATOSPRODUCTOS
    {
        public int ID { get; set; }
        public string NAMEPRODUCTO { get; set; }
        public int CANTIDAD { get; set; }
        public string MEDIDA { get; set; }
        public int PRECIOCOMPRA { get; set; }
        public int PRECIOVENTA { get; set; }
        public string DISTRIBUIDOR { get; set; }


    }
}
