﻿using System;
using System.Collections.Generic;

namespace MensajesAPI.Models
{
    public partial class Alumno
    {
        public Alumno()
        {
            AlumnoDocente = new HashSet<AlumnoDocente>();
            AlumnoMensaje = new HashSet<AlumnoMensaje>();
        }

        public int Id { get; set; }
        public string NombreCompleto { get; set; } = null!;
        public string NumeroControl { get; set; } = null!;
        public string Correo { get; set; } = null!;
        public string Contraseña { get; set; } = null!;
        public int FkIdGrupo { get; set; }
        public int FkIdEspecialidad { get; set; }

        public virtual Especialidad FkIdEspecialidadNavigation { get; set; } = null!;
        public virtual Grupo FkIdGrupoNavigation { get; set; } = null!;
        public virtual ICollection<AlumnoDocente> AlumnoDocente { get; set; }
        public virtual ICollection<AlumnoMensaje> AlumnoMensaje { get; set; }
    }
}
