using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionAsociaciones
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            Socio socio = new Socio();
            socio.Nombre = "Emiliano";
            socio.Apellido = "Ortega";
            socio.Documento = "22746258";
            socio.Nacimiento = new DateTime(1973,2,24);
            socio.EstadoCivil = "Soltero solo por ahora";
            socio.Direccion = "Emilio Eliano Díaz 56";
            socio.TelefonoFijo = "2396475821";
            socio.TelefonoMovil = "2396 44-4002";
            socio.Mail = "ortegaem@gmail.com";
            
            FormEdicionSocio formEdicionSocio = new FormEdicionSocio(socio);
            formEdicionSocio.ShowDialog();
            Debug.WriteLine(formEdicionSocio.Socio.ToString());
        }
    }
}
