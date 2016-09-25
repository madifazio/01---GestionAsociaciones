using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionAsociaciones
{
    public partial class FormEdicionSocio : Form
    {
        private Socio _socio;

        public FormEdicionSocio()
        {
            InitializeComponent();
        }

        public FormEdicionSocio(Socio socio)
        {
            InitializeComponent();
            // TODO: Complete member initialization
            this._socio = socio;
            textBoxNombre.Text = socio.Nombre;
            textBoxApellido.Text = socio.Apellido;
            textBoxDocumento.Text = socio.Documento;
            dateTimePickerNacimiento.Value = socio.Nacimiento;
            comboBoxEstadoCivil.Text = socio.EstadoCivil;
            textBoxDireccion.Text = socio.Direccion;
            textBoxTelFijo.Text = socio.TelefonoFijo;
            textBoxTelMovil.Text = socio.TelefonoMovil;
            textBoxMail.Text = socio.Mail;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        public Socio Socio 
        { 
            get
            {
                return _socio;
            }
        }

        private void buttonAceptar_Click(object sender, EventArgs e)
        {
            _socio.Nombre = textBoxNombre.Text;
            _socio.Apellido = textBoxApellido.Text;
            _socio.Documento = textBoxDocumento.Text;
            _socio.Nacimiento = dateTimePickerNacimiento.Value;
            _socio.EstadoCivil = comboBoxEstadoCivil.Text;
            _socio.Direccion = textBoxDireccion.Text;
            _socio.TelefonoFijo = textBoxTelFijo.Text;
            _socio.TelefonoMovil = textBoxTelMovil.Text;
            _socio.Mail = textBoxMail.Text;
        }
    }
}
