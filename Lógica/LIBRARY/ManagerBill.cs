using DATABASE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lógica.LIBRARY {
    public class ManagerBill {

        CONNETION manager = new CONNETION();  
        Report ticket = new Report();

        public void FillData(DataGridView managerData ) {
            managerData.DataSource = manager.consulta("SELECT * FROM ManagerBill where ")
            }
        }
    }
