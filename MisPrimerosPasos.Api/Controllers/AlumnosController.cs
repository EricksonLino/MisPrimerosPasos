using Microsoft.AspNetCore.Mvc;
using MisPrimerosPasos.Application.Dtos;
using MisPrimerosPasos.Application.Interfaces;

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
        public async Task<ActionResult<List<AlumnoDto>>> ListarAlumnos() 
        {
            var alumnos = await this.alumnoApplication.ListarAlumnos();
            return alumnos;
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<AlumnoDetalleDto>> ObtenerAlumno(int id)
        {
            var alumno = await this.alumnoApplication.ObtenerAlumno(id);
            if(alumno == null)
            {
                return NotFound($"Ups! no se encontro el alumno con ID {id}");
            }
            return alumno;
        }

        [HttpPost]
        public async Task<ActionResult> InsertarAlumno(AlumnoCreacionDto alumnoCreacion)
        {
            await this.alumnoApplication.InsertarAlumno(alumnoCreacion);
            return Ok();
        }
    }
}
