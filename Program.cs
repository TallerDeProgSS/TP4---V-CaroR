using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Fachada fachada = new();
            IRepositorioUsuarios repo = new();
            var opcion = 1;
            while (opcion != 0)
            {
                Console.Clear();
                Console.WriteLine("Presione según corresponda:");
                Console.WriteLine("1 - Agregar un usuario");
                Console.WriteLine("2 - Actualizar un usuario");
                Console.WriteLine("3 - Eliminar un usuario");
                Console.WriteLine("4 - Mostrar datos de un usuario");
                Console.WriteLine("5 - Listar usuarios");
                Console.WriteLine("6 - Listar en orden alfabetico");
                Console.WriteLine("7 - Listar en orden por codigo");
                Console.WriteLine("8 - Listar en orden por correo");
                opcion = Convert.ToInt32(Console.ReadLine());
                Console.Clear();

                switch (opcion)
                {
                    case 1:
                        {
                            Console.Write("Ingrese código: ");
                            string code = Console.ReadLine();
                            Console.Write("Ingrese nombre y apellido: ");
                            string completName = Console.ReadLine();
                            Console.Write("Ingrese Email :");
                            string eMail = Console.ReadLine();
                            string ultimo = fachada.AgregarUsuario(code, completName, eMail);
                            Console.WriteLine("El último usuario agregado es: " + ultimo);
                            Console.ReadKey();
                            break;
                        }

                    case 2:
                        {
                            Console.Write("Ingrese código del usuario a actualizar: ");
                            string code = Console.ReadLine();
                            Console.Write("Ingrese nuevo nombre y apellido: ");
                            string completName = Console.ReadLine();
                            Console.Write("Ingrese nuevo Email :");
                            string eMail = Console.ReadLine();
                            string actualizacion = fachada.ActualizarUsuario(code, completName, eMail);
                            Console.WriteLine("El último usuario actualizado es: " + actualizacion);
                            Console.ReadKey();
                            break;
                        }
                    case 3:
                        {
                            Console.Write("Ingrese código del usuario a eliminar: ");
                            string code = Console.ReadLine();
                            bool res = fachada.EliminarUsuario(code);
                            if (res == true) {Console.WriteLine("Usuario eliminado"); }
                            Console.ReadKey();
                            break;
                        }
                    case 4:
                        {
                            Console.Write("Ingrese código del usuario a mostrar: ");
                            string code = Console.ReadLine();
                            Usuario user = fachada.recuperarUsuario(code);

                            Console.WriteLine("Código :" + user.Codigo);
                            Console.WriteLine("Nombre y apellido: " + user.NombreCompleto);
                            Console.WriteLine("Email :" + user.CorreoElectronico);
                            Console.ReadKey();
                            break;
                        }
                    case 5:
                        {   List<Usuario> lista = fachada.obtenerTodos();
                            Console.WriteLine("Codigo      Nombre completo       Email");
                            foreach (Usuario user in lista)
                            {
                                Console.WriteLine(user.Codigo + "      " + user.NombreCompleto + "     " + user.CorreoElectronico);
                                
                            }
                            
                            Console.ReadKey();
                            break;
                        }
                    case 6:
                        {
                            List<Usuario> lista = fachada.obtenerTodosOrdenadosAlfabeticamente();
                            Console.WriteLine("Codigo      Nombre completo       Email");
                            foreach (Usuario user in lista)
                            {
                               Console.WriteLine(user.Codigo + "      " + user.NombreCompleto + "     " + user.CorreoElectronico);

                            }

                            Console.ReadKey();
                            break;
                        }
                    case 7:
                        {
                            List<Usuario> lista = fachada.obtenerTodosOrdenadosPorCodigo();
                            Console.WriteLine("Codigo      Nombre completo       Email");
                            foreach (Usuario user in lista)
                            {
                                Console.WriteLine(user.Codigo + "      " + user.NombreCompleto + "     " + user.CorreoElectronico);

                            }

                            Console.ReadKey();
                            break;
                        }
                    case 8:
                        {
                            List<Usuario> lista = fachada.obtenerTodosOrdenadoCorreo();
                            Console.WriteLine("Codigo      Nombre completo       Email");
                            foreach (Usuario user in lista)
                            {
                                Console.WriteLine(user.Codigo + "      " + user.NombreCompleto + "     " + user.CorreoElectronico);

                            }

                            Console.ReadKey();
                            break;
                        }
                }
        }   }
    }
}