using System;
using System.Collections.Generic;
using DATABASE;
using DATABASE.LIBRARY.CLADATOS;


namespace PROYECTO_ALMACÉN_RODRIGUEZ
{
    public partial class INICIOSESION : Form
    {
        public INICIOSESION()
        {
            InitializeComponent();
            hm = new HOME();
        }
        HOME hm;
        CONNETION user = new CONNETION();

        private void btnINICIARSESSION_Click(object sender, EventArgs e)
        {
            
            if(user.checkinicio(txtUSUARIOINICIOSESION.Text, txtCONTRASEÑAINICIOSESSION.Text))
            {
                hm.Show();
                this.Visible = false;
            }
            else
            {
                MessageBox.Show("Los datos proporcionados son incorrectos");
            }


        }
    }
    }

