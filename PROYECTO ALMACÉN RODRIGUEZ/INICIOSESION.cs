using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace PROYECTO_ALMACÉN_RODRIGUEZ
{
    public partial class INICIOSESION : Form
    {
        public INICIOSESION()
        {
            InitializeComponent();
            
        }

        CONEXION LOGIN = new CONEXION();
       HOME hm = new HOME();

        private void btnINICIARSESSION_Click(object sender, EventArgs e)
        {
            
            if(LOGIN.checkinicio(txtUSUARIOINICIOSESION.Text, txtCONTRASEÑAINICIOSESSION.Text))
            {
                hm.Show();
                //hm.TurnoFormulario(new INICIO());
                this.Visible = false;
            }
            else
            {
                MessageBox.Show("Los datos proporcionados son incorrectos");
            }


        }
    }
    }

