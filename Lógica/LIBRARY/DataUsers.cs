using DATABASE;
using DATABASE.LIBRARY.CLADATOS;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Lógica.LIBRARY {
    public class DataUsers {

        private CONNETION db = new CONNETION();
        private DataUsers user = new DataUsers();

        public void aplicar(List<TextBox> TXT ) {
            if (TXT[2].Text == TXT[3].Text && TXT[2].Text != DATOSUSER.PASSWORDUSER) {
                db.DATOSUSUARIO(DATOSUSER.IDUSER, TXT[0].Text, TXT[3].Text);
                MessageBox.Show("Los cambios se han aplicado correctamente");
                } else {
                MessageBox.Show("Los Datos no correspondieron, por favor verifique");
                }
            }
        public void complete (List<TextBox> TXT ) {
            TXT[0].Text = DATOSUSER.NAMEUSER;
            TXT[1].Text = DATOSUSER.PASSWORDUSER;
            }
        }
    }
