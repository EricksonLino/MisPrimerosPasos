using MisPrimerosPasos.Application.Dtos;
using MisPrimerosPasos.Entity;

namespace MisPrimerosPasos.Application.Interfaces
{
    public interface IAlumnoApplication
    {
        Task<List<AlumnoDto>> ListarAlumnos();
        Task<AlumnoDetalleDto> ObtenerAlumno(int id);
        Task InsertarAlumno (AlumnoCreacionDto alumnoCreacionDto);
        Task EliminarAlumno (int id);
    }
}
