using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio03
{
    internal class Fachada
    {   
        IRepositorioUsuarios Repositorio = new();
        public string AgregarUsuario(string codigo, string nombreCom, string eMail)
        {
            Usuario user = new();
            user.Codigo = codigo; 
            user.NombreCompleto= nombreCom;
            user.CorreoElectronico= eMail;
            Repositorio.Agregar(user);
            List<Usuario> Lista = Repositorio.ObtenerTodos();
            return Lista.Last().NombreCompleto;
        }

        public string ActualizarUsuario(string codigo, string nombreCom, string eMail)
        {
            Usuario user = new();
            user.Codigo = codigo;
            user.NombreCompleto = nombreCom;
            user.CorreoElectronico = eMail;
            Repositorio.Actualizar(user);
            Usuario actualizado = Repositorio.ObtenerPorCodigo(codigo);
            return (actualizado.NombreCompleto + " - "+ actualizado.iCodigo) ;
        }

        public bool EliminarUsuario(string codigo)
        {
            return Repositorio.Eliminar(codigo);
        }

        public Usuario recuperarUsuario(string code)
        {
            return Repositorio.ObtenerPorCodigo(code);
        }

        public List<Usuario> obtenerTodos()
        {
            return Repositorio.ObtenerTodos();
        }

        public List<Usuario> obtenerTodosOrdenadosAlfabeticamente()
        {
            return Repositorio.OrdenarPorNombre();
        }

        public List<Usuario> obtenerTodosOrdenadosPorCodigo()
        {
            return Repositorio.OrdenarPorCodigo();
        }

        public List<Usuario> obtenerTodosOrdenadoCorreo()
        {
            return Repositorio.OrdenarPorCorreo();
        }
    }
}
