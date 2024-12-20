﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa.Entidades
{
    public class MailData
    {
        [Required(ErrorMessage = "El correo es obligatorio.")]
        [EmailAddress(ErrorMessage = "Formato de correo inválido.")]
        public string mailTo { get; set; } // Para quién le voy a enviar el correo
        public string? subject { get; set; } // Asunto
        public string? body { get; set; } // Mensaje

    }
}
