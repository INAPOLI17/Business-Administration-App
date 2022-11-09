using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DATA.LIBRARY.CLADATOS
{
    public class DATOSDETALLE
    {
        public int IDDETALLE;

        public int IDFACTURA {get; set;}
        
        public int IDPRODUCTO {get; set;}

        public int CANTIDAD {get; set;}

        public int PRECIO { get; set;}

        public string MEDIDA { get; set;}
    }
}
