﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace HotelariaControle.Data.Models
{
    public partial class Quartos
    {
        public Quartos()
        {
            Reservas = new HashSet<Reservas>();
        }

        [Key]
        [Column("Id_Quarto")]
        public int IdQuarto { get; set; }
        [Column("Numero_Quarto")]
        public int NumeroQuarto { get; set; }
        [Required]
        [Column("Tipo_Quarto")]
        [StringLength(20)]
        public string TipoQuarto { get; set; }

        [InverseProperty("IdQuartoNavigation")]
        public virtual ICollection<Reservas> Reservas { get; set; }
    }
}