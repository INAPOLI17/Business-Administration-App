using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LOGIC
{
    public class LOGICA
    {
        private List<object> listTextBox;
        private List<object> listRadio;
        private List<object> listTextBox1;
        private List<object> listRadio1;
        private DataGridView sTAR_LOCAL;

        public LOGICA(List<object> listTextBox, List<object> listRadio)
        {
            this.listTextBox = listTextBox;
            this.listRadio = listRadio;
        }

        public LOGICA(List<object> listTextBox1, List<object> listRadio1, DataGridView sTAR_LOCAL)
        {
            this.listTextBox1 = listTextBox1;
            this.listRadio1 = listRadio1;
            this.sTAR_LOCAL = sTAR_LOCAL;
        }

        public void BUSCAR (String strsql)
        {

        }
    }
}
