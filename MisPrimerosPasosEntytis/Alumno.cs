﻿using System.ComponentModel.DataAnnotations;

namespace MisPrimerosPasos.Entity
{
    public class Alumno
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(8)]
        public string Dni { get; set; }
        [Required]
        [StringLength(50)]
        public string nombres { get; set; }
        [Required]
        [StringLength(50)]
        public string Apellidos { get; set; }
        [Required]
        public DateTime FechaNacimiento { get; set; }
        [Required]
        public bool Sexo { get; set; }
    }
}
