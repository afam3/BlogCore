﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogCore.Models
{
    public class Categoria
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "Ingrese un nombre para la categoría")]
        [Display(Name = "Nombre de Categoría")]
        public required string Nombre { get; set; }
        [Display(Name = "Orden de visualización")]
        public int? Orden{ get; set; }
    }
}
