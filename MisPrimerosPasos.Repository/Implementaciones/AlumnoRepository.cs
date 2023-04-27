using Microsoft.EntityFrameworkCore;
using MisPrimerosPasos.Entity;
using MisPrimerosPasos.Repository.Interfaces;

namespace MisPrimerosPasos.Repository.Implementaciones
{
    public class AlumnoRepository : IAlumnoRepository
    {
        private readonly ApplicationDbContext context;

        public AlumnoRepository(ApplicationDbContext context)
        {
            this.context = context;
        }
        public async Task<List<Alumno>> ListarAlumnos()
        {
            var alumnos = await this.context.Alumnos.ToListAsync();
            return alumnos;
        }
    }
}
