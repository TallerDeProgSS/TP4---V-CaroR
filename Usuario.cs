using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio03
{
    public class Usuario 
    {
        //Atributos de la clase
        public string iCodigo;
        public string iNombreCompleto;
        public string iCorreoElectronico;

        //Propiedades X e Y
        public string Codigo
        {
            get { return this.iCodigo; }
            set { this.iCodigo = value; }
        }

        public string NombreCompleto
        {
            get { return this.iNombreCompleto; }
            set { this.iNombreCompleto = value; }
        }

        public string CorreoElectronico
        {
            get { return this.iCorreoElectronico; }
            set { this.iCorreoElectronico = value; }
        }

        //Métodos 
        public int CompareTo(Usuario pUsuario)
        {
            return string.Compare(this.Codigo, pUsuario.Codigo);
        }
    }
}
