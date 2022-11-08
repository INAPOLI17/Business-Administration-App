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
    public partial class HOME : Form
    {
        public  HOME()
        {
            InitializeComponent();
        }


        public  void Pantalla (object formhijo)
        {
            if(this.panelHOME.Controls.Count > 0)
            {
                this.panelHOME.Controls.RemoveAt(0);
            }

            Form home = formhijo as Form;
            home.TopLevel = false;
            home.Dock = DockStyle.Fill;
            this.panelHOME.Controls.Add(home);
            this.panelHOME.Tag = home;
            home.Show();

        }

        private Form FormularioActivo = null;
        public void PantallaVisual(Form formhijo)
        {
            if(FormularioActivo != null)
            {
                FormularioActivo.Close();
            }

            FormularioActivo = formhijo;
            formhijo.TopLevel = false;
            formhijo.Dock = DockStyle.Fill;
            panelHOME.Controls.Add(formhijo);
            panelHOME.Tag=formhijo;
            formhijo.BringToFront();
            formhijo.Show();

        }

        public void HOME_Load(object sender, EventArgs e)
        {          
               Pantalla(new INICIO()); 
            

        }

        private void btnCLIENTE_Click_1(object sender, EventArgs e)
        {
            PantallaVisual(new CLIENTE());
        }

        private void btnALMACEN_Click_1(object sender, EventArgs e)
        {
            PantallaVisual(new ALMACEN());
        }

        private void btnGESTOR_Click_1(object sender, EventArgs e)
        {
            PantallaVisual(new GESTOR_FACTURA());
        }

        private void btnADMINISTRACION_Click_1(object sender, EventArgs e)
        {
            PantallaVisual(new ADMINISTRACION());

        }


    }
}
