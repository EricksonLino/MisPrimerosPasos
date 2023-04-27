using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MisPrimerosPasos.Application.Interfaces;
using MisPrimerosPasos.Entity;

namespace MisPrimerosPasos.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AlumnosController : ControllerBase
    {
        private readonly IAlumnoApplication alumnoApplication;

        public AlumnosController(IAlumnoApplication alumnoApplication)
        {
            this.alumnoApplication = alumnoApplication;
        }
        [HttpGet]
        public async Task<ActionResult<List<Alumno>>> ListarAlumnos() 
        {
            var alumnos = await this.alumnoApplication.ListarAlumnos();
            return alumnos;
        }
    }
}
