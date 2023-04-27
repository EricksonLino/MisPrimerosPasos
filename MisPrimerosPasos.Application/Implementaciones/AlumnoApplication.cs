using MisPrimerosPasos.Application.Interfaces;
using MisPrimerosPasos.Entity;
using MisPrimerosPasos.Repository.Interfaces;

namespace MisPrimerosPasos.Application.Implementaciones
{
    public class AlumnoApplication : IAlumnoApplication
    {
        private readonly IAlumnoRepository alumnoRepository;

        public AlumnoApplication(IAlumnoRepository alumnoRepository)
        {
            this.alumnoRepository = alumnoRepository;
        }
        public async Task<List<Alumno>> ListarAlumnos()
        {
            var alumnos = await this.alumnoRepository.ListarAlumnos();
            return alumnos;
        }
    }
}
