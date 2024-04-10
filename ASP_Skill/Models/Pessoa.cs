using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ASP_Skill.Models
{
    [Table("Pessoa")]
    public class Pessoa
    {
        // Atributos
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string Nome { get; set; }

        public DateTime? DataNascimento { get; set; }

        [StringLength(1)]
        public string Sexo { get; set; }

        [StringLength(10)]
        public string EstadoCivil { get; set; }

        [StringLength(11)]
        public string CPF { get; set; }

        [StringLength(100)]
        public string Endereço { get; set; }

        [StringLength(10)]
        public string Numero { get; set; }

        [StringLength(12)]
        public string CEP { get; set; }

        [StringLength(200)]
        public string Complemento { get; set; }

        [StringLength(30)]
        public string Bairro { get; set; }

        [StringLength(30)]
        public string Cidade { get; set; }

        [StringLength(2)]
        public string UF { get; set; }
    }
}
