using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio03
{
    public interface Comparadores 
    {
        void Agregar(Usuario pUsuario);
        void Actualizar(Usuario pUsuario);
        bool Eliminar(string pCodigo);
        List<Usuario> ObtenerTodos();
        Usuario ObtenerPorCodigo(string pCodigo);
        List<Usuario> ObtenerOrdenadosPor(IComparer<Usuario> pComparador);
        List<Usuario> OrdenarPorCodigo();
        List<Usuario> OrdenarPorNombre();
        List<Usuario> OrdenarPorCorreo();


        //Codigo
        public class OrdenarCodigo : IComparer<Usuario>
        {
            public int Compare(Usuario x, Usuario y)
            {
                return (x.Codigo.CompareTo(y.Codigo));
            }
        }

        //Correo
        public class OrdenarCorreo : IComparer<Usuario>
        {
            public int Compare(Usuario x, Usuario y)
            {
                return (x.CorreoElectronico.CompareTo(y.CorreoElectronico));
            }
        }

        //Nombre
        public class OrdenarNombreAlfabeticamente : IComparer<Usuario>
        {
            public int Compare(Usuario x, Usuario y)
            {
                return (x.NombreCompleto.CompareTo(y.NombreCompleto));
            }
        }
    }
}
