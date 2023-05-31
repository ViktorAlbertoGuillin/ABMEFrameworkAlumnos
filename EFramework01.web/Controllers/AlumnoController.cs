using EFramework01.web.Entidades;
using Microsoft.AspNetCore.Mvc;

namespace EFramework01.web.Controllers
{
    public class AlumnoController : Controller
    {
        AlumnosContext contexto;
        public AlumnoController()
        {
            contexto = new AlumnosContext();
        }
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Crear(Alumno alumno)
        {
            contexto.Alumnos.Add(alumno);
            contexto.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult Listar()
        {
            var lista = contexto.Alumnos.ToList();
            return View(lista);
        }
    }
}
