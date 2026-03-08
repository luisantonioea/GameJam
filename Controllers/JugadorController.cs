using Microsoft.AspNetCore.Mvc;
using GameJamMVC.Models;

namespace GameJamMVC.Controllers
{
    public class JugadorController : Controller
    {
        public IActionResult Registro()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Registro(Jugador jugador)
        {
            if (jugador.PagoMatricula)
            {
                ViewBag.Mensaje = "Registro completado correctamente.";
            }
            else
            {
                ViewBag.Mensaje = "Ud aún no ha completado su pago.";
            }

            return View("Resultado", jugador);
        }
    }
}