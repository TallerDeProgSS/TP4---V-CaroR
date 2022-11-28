using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Ejercicio03.Comparadores;

namespace Ejercicio03
{
    public class IRepositorioUsuarios : Comparadores

    {
        Dictionary<string, Usuario> RepoUsuarios = new();  

       
        
        //Metodos
        public void Agregar(Usuario pUsuario)
        {
            try
            {
                RepoUsuarios.Add(pUsuario.Codigo, pUsuario);
            }
            catch (ArgumentException)
            {
                Console.WriteLine("Ya existe un elemento con la clave = \"Codigo\".");
            }
        }

        public void Actualizar(Usuario pUsuario)
        {
            try
            {
                RepoUsuarios[pUsuario.Codigo] = pUsuario;
            }
            catch (KeyNotFoundException)
            {
                Console.WriteLine("La clave = \"Codigo\" no existe)");
            }
        }

        public bool Eliminar(string pCodigo)
        {
            try
            {
                RepoUsuarios.Remove(pCodigo);
                return true;
            }
            catch (KeyNotFoundException)
            {
                Console.WriteLine("La clave = \"pCodigo\" no existe)");
                return false;
            }

        }

        public List<Usuario> ObtenerTodos() 
        {
            return RepoUsuarios.Values.ToList();
        }
        
        //Codigo - no list
        public Usuario ObtenerPorCodigo(string pCodigo)
        {
            Usuario user = new();
            try
            {
                user = RepoUsuarios[pCodigo];
            }
            catch(KeyNotFoundException)
            {
                Console.WriteLine("No se encontró la clave especificada");
                
            }
            return user;
        }


        //comparador
        
        public int Compare(Usuario x, Usuario y)
        {
            return x.CompareTo(y);
        }

        public List<Usuario> ObtenerOrdenadosPor(IComparer<Usuario> pComparador)
        {
            var ordenados = new List<Usuario>(this.RepoUsuarios.Values);
            ordenados.Sort(pComparador);
            return ordenados.ToList();
        }

        //LIST CODIGO
        public List<Usuario> OrdenarPorCodigo()
        {
            return this.ObtenerOrdenadosPor(new OrdenarCodigo());
        }

        //LIST NOMBRE
        public List<Usuario> OrdenarPorNombre()
        {
            return this.ObtenerOrdenadosPor(new OrdenarNombreAlfabeticamente());
        }

        //LIST CORREO
        public List<Usuario> OrdenarPorCorreo()
        {
            return this.ObtenerOrdenadosPor(new OrdenarCorreo());
        }



    }
}
