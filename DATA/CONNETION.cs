using DATABASE.LIBRARY.CLADATOS;

namespace DATABASE  {
    public class CONNETION : CheckSession {

        private DATOAGENDA datoAgenda;
        
        private DATOSCLIENTE datoCLIENTE;
        
        private DATOSDETALLE datoDETALLE;
        
        private DATOSFACTURA datoFACTURA ;
        
        private DATOSPRODUCTOS datOPRODUCTOS;
        
        private DATOSUSER datoUSER;

        public CONNETION ( ) { 

            this.datoAgenda = new DATOAGENDA();
            this.datoCLIENTE = new DATOSCLIENTE();
            this.datoDETALLE = new DATOSDETALLE();
            this.datoFACTURA = new DATOSFACTURA();
            this.datOPRODUCTOS = new DATOSPRODUCTOS ();
            this.datoUSER = new DATOSUSER();
            
            }

     



    }
}
