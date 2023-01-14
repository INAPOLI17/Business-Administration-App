using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DATABASE;
using DATABASE.LIBRARY.CLADATOS;


namespace Lógica.LIBRARY {
    public class ClassAgenda {

        private CONNETION bridgetodb = new CONNETION();
        public DATOAGENDA da = new DATOAGENDA();

        public ClassAgenda ( ) { 
            }

        public void SaveDataSchedule ( List<object> schedule ) {
            da.IDAGENDA = int.Parse(schedule[0].ToString());
            da.NOMBREAGENDA = schedule[1].ToString();
            da.APELLIDOAGENDA = schedule[2].ToString();
            da.DIRECCIONAGENDA = schedule[3].ToString();
            da.TELEFONO = schedule[4].ToString();

            bridgetodb.AGENDA(da, "AÑADIR");
            }

        public void DeleteDataSchedule ( int id ) {
            da.IDAGENDA = id;

            bridgetodb.AGENDA(da, "BORRAR");
            }

        }
    }
