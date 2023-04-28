using AutoMapper;
using MisPrimerosPasos.Application.Dtos;
using MisPrimerosPasos.Application.Interfaces;
using MisPrimerosPasos.Entity;
using MisPrimerosPasos.Repository.Interfaces;

namespace MisPrimerosPasos.Application.Implementaciones
{
    public class AlumnoApplication : IAlumnoApplication
    {
        private readonly IAlumnoRepository alumnoRepository;
        private readonly IMapper mapper;

        public AlumnoApplication(IAlumnoRepository alumnoRepository, IMapper mapper)
        {
            this.alumnoRepository = alumnoRepository;
            this.mapper = mapper;
        }

        public async Task<List<AlumnoDto>> ListarAlumnos()
        {
            var alumnos = await this.alumnoRepository.ListarAlumnos();
            var alumnosDto = this.mapper.Map<List<AlumnoDto>>(alumnos);

            return alumnosDto;
        }

        public async Task<AlumnoDetalleDto> ObtenerAlumno(int id)
        {
            var alumno = await this.alumnoRepository.ObtenerAlumno(id);

            var alumnoDetalleDto = this.mapper.Map<AlumnoDetalleDto>(alumno);

            return alumnoDetalleDto;
        }

        public async Task InsertarAlumno(AlumnoCreacionDto alumnoCreacionDto)
        {
            var alumno = this.mapper.Map<Alumno>(alumnoCreacionDto);
            await this.alumnoRepository.InsertarAlumno(alumno);
        }

        public async Task EliminarAlumno(int id)
        {
            var alumno = await this.alumnoRepository.ObtenerAlumno(id);
            await this.alumnoRepository.EliminarAlumno(alumno);
        }

        public async Task ActualizarAlumno(int id, AlumnoActualizarDto alumnoActualizar)
        {
            var alumno = await this.alumnoRepository.ObtenerAlumno(id);
            this.mapper.Map(alumnoActualizar, alumno);

            await this.alumnoRepository.ActualizarAlumno(alumno);            
        }
    }
}
