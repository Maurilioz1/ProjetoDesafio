using Sistema.Dominio;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema.RepositorioEF
{
    public class BDUsuario : DbContext
    {
        public BDUsuario() : base("conexaoBD")
        {

        }

        public DbSet<Usuarios> usuarios { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Entity<Usuarios>().Property(x => x.nomeCompleto).IsRequired().HasColumnType("varchar").HasMaxLength(50);
            modelBuilder.Entity<Usuarios>().Property(x => x.apelido).IsRequired().HasColumnType("varchar").HasMaxLength(50);
            modelBuilder.Entity<Usuarios>().Property(x => x.email).IsRequired().HasColumnType("varchar").HasMaxLength(50);
            modelBuilder.Entity<Usuarios>().Property(x => x.telefone).IsRequired().HasColumnType("varchar").HasMaxLength(50);
        }
    }
}
