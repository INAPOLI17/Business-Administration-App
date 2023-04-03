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
    public partial class ADMINISTRACION : Form
    {
        public ADMINISTRACION()
        {
            InitializeComponent();
        }

        private string VentanaActual;
        private Form FormularioActivo = null;

        private void btnATRASADMINISTRACION_Click ( object sender, EventArgs e ) {

            if (VentanaActual == string.Empty) {
                this.Close();
                } else {
                this.panelADMINISTRACION.Controls.Remove(FormularioActivo);
                VentanaActual = string.Empty;
                }          
        }

        
        public void PantallaVisual(Form formhijo)
        {
            if (FormularioActivo != null)
            {
                FormularioActivo.Close();
            }

            FormularioActivo = formhijo;
            formhijo.TopLevel = false;
            formhijo.Dock = DockStyle.Fill;
            panelADMINISTRACION.Controls.Add(formhijo);
            panelADMINISTRACION.Tag = formhijo;
            formhijo.BringToFront();
            formhijo.Show();

        }

        private void btnBALANCEVENTAS_Click_1(object sender, EventArgs e)
        {
            PantallaVisual(new BALANCE_GENERAL());
            VentanaActual = "BALANCE GENERAL";
            label3.Text = "BALANCE GENERAL";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            PantallaVisual(new AGENDA());
            VentanaActual = "AGENDA";
            label3.Text = "AGENDA";

        }

        private void button3_Click(object sender, EventArgs e)
        {
            PantallaVisual(new AJUSTEINIICIO());
            VentanaActual = "AJUSTES DE INICIO";
            label3.Text = "AJUSTES DE INICIO";
        }

 
    }
}
