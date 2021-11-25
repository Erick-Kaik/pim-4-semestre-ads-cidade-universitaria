﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace HotelariaControle.Data.Models
{
    public partial class Usuarios
    {
        [Key]
        [Column("Id_Usuario")]
        public int IdUsuario { get; set; }
        [Required]
        [StringLength(20)]
        public string Usuario { get; set; }
        [Required]
        [StringLength(20)]
        public string Senha { get; set; }
        [Required]
        [StringLength(20)]
        public string Tipo { get; set; }
        [Column("Id_Hospede")]
        public int? IdHospede { get; set; }
        [Column("Id_Funcionario")]
        public int? IdFuncionario { get; set; }
        [Column("U_Status")]
        public bool UStatus { get; set; }

        [ForeignKey(nameof(IdFuncionario))]
        [InverseProperty(nameof(Funcionarios.Usuarios))]
        public virtual Funcionarios IdFuncionarioNavigation { get; set; }
        [ForeignKey(nameof(IdHospede))]
        [InverseProperty(nameof(Hospedes.Usuarios))]
        public virtual Hospedes IdHospedeNavigation { get; set; }





    }
}