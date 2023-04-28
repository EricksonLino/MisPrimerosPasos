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

        public async Task<Alumno> ObtenerAlumno(int id)
        {
            var Alumno = await this.context.Alumnos.FirstOrDefaultAsync(al => al.Id == id);
            return Alumno;
        }

        public async Task InsertarAlumno(Alumno alumno)
        {
            this.context.Alumnos.Add(alumno);
            await this.context.SaveChangesAsync();
            
        }
    }
}
