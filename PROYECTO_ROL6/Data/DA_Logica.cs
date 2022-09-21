using Microsoft.CodeAnalysis.CSharp.Syntax;
using PROYECTO_ROL6.Models;

namespace PROYECTO_ROL6.Data
{
    public class DA_Logica
    {
        public List<Usuario> listaUsuarios()
        {
            return new List<Usuario>
            {
                new Usuario{Nombre = "Eiman", Correo = "eiman@correo.com", Clave = "123", Roles = new string[]{"Administrador"} }
            };
        }

        public Usuario validarUsuario(string _correo, string _clave)
        {
            return listaUsuarios().Where(_correo == )
        }
    }
}
