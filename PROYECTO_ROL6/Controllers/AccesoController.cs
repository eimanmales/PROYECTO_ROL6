using Microsoft.AspNetCore.Mvc;

using PROYECTO_ROL6.Models;
using PROYECTO_ROL6.Data;

namespace PROYECTO_ROL6.Controllers
{
    public class AccesoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Index(Usuario _usuario)
        {
            DA_Logica _da_logica = new DA_Logica();

            string nombre = _da_logica.validarUsuario(_usuario.Correo, _usuario.Clave);
            return View();
        }
    }
}
