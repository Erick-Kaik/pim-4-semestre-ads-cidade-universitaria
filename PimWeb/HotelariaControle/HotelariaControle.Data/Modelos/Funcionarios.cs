﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace HotelariaControle.Data.Models
{
    public partial class Funcionarios
    {
        public Funcionarios()
        {
            Usuarios = new HashSet<Usuarios>();
        }

        [Key]
        [Column("Id_Funcionario")]
        public int IdFuncionario { get; set; }
        [Required]
        [StringLength(50)]
        public string Nome { get; set; }
        [Required]
        [Column("CPF")]
        [StringLength(11)]
        public string Cpf { get; set; }
        [Required]
        [Column("RG")]
        [StringLength(15)]
        public string Rg { get; set; }
        [Required]
        [StringLength(50)]
        public string Email { get; set; }
        [Required]
        [StringLength(30)]
        public string Cargo { get; set; }
        [Required]
        [StringLength(14)]
        public string Telefone { get; set; }
        [Column("Telefone_Alt")]
        [StringLength(14)]
        public string TelefoneAlt { get; set; }
        public double Salario { get; set; }
        [Column("Data_de_Admissão", TypeName = "date")]
        public DateTime DataDeAdmissão { get; set; }
        [Column("F_Status")]
        public bool FStatus { get; set; }

        [InverseProperty("IdFuncionarioNavigation")]
        public virtual ICollection<Usuarios> Usuarios { get; set; }
    }
}