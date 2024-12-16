using Microsoft.AspNetCore.Mvc;
using Universiteti2024.Models;

namespace Universiteti2024.Controllers
{
    public class KursiController : Controller
    {
        [HttpGet]
        public IActionResult Krijo()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Krijo(Kursi model)
        {
            if (ModelState.IsValid)
            {
                // Logjika per te ruajtur kursin (p.sh. ne database)
                TempData["Success"] = "Kursi u ruajt me sukses!";
            }

            return View(model);
        }
    }
}