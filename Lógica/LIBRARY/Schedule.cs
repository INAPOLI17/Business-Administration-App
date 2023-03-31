using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DATABASE;
using DATABASE.LIBRARY.CLADATOS;


namespace Lógica.LIBRARY {
    public class Schedule {

        private CONNETION db = new CONNETION();
        private DATOAGENDA DataSchedule = new DATOAGENDA();

        public void Filldata ( ref DataGridView schedule ) {
            schedule.DataSource = db.consulta("SELECT * FROM ViewSchedule");

            }


        public void SaveDataSchedule ( List<object> schedule ) {
            DataSchedule.IDAGENDA = int.Parse(schedule[0].ToString());
            DataSchedule.NOMBREAGENDA = schedule[1].ToString();
            DataSchedule.APELLIDOAGENDA = schedule[2].ToString();
            DataSchedule.DIRECCIONAGENDA = schedule[3].ToString();
            DataSchedule.TELEFONO = schedule[4].ToString();

            db.AGENDA(DataSchedule);
            }

        public void DeleteDataSchedule ( int id ) {
            DataSchedule.IDAGENDA = id;

            db.AGENDA(DataSchedule);
            }

        }
    }