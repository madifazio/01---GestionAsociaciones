using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GestionAsociaciones
{
    public class Socio
    {
        public string Apellido { get; set; }

        public string Nombre { get; set; }

        public string Documento { get; set; }

        public DateTime Nacimiento { get; set; }

        public string EstadoCivil { get; set; }

        public string Direccion { get; set; }

        public string TelefonoFijo { get; set; }

        public string TelefonoMovil { get; set; }

        public string Mail { get; set; }

        public string ToString()
        {
            return 
                "Nombre: " + this.Nombre + "\n" +
                "Apellido: " + this.Apellido + "\n" +
                "Documento: " + this.Documento + "\n" +
                "Nacimiento: " + this.Nacimiento.ToLongDateString() + "\n" +
                "Estado civil: " + this.EstadoCivil + "\n" +
                "Dirección: " + this.Direccion + "\n" +
                "Teléfono fijo: " + this.TelefonoFijo + "\n" +
                "Teléfono movil: " + this.TelefonoMovil + "\n" +
                "e-mail: " + this.Mail + "\n";
        }        
    }
}
