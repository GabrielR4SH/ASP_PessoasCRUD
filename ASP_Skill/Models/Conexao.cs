using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ASP_Skill.Models
{
    public class Conexao : DbContext
    {
        public Conexao() : base("CadastroPessoas")
        {

        }

        public DbSet<Pessoa> Pessoa { get; set; }
    }
}