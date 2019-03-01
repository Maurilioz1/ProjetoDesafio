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
    public class BDCliente : DbContext
    {
        public BDCliente() : base("conexaoBD")
        {

        }

        public DbSet<Clientes> clientes { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Entity<Clientes>().Property(x => x.razaoSocial).IsRequired().HasColumnType("varchar").HasMaxLength(50);
            modelBuilder.Entity<Clientes>().Property(x => x.nomeFantasia).IsRequired().HasColumnType("varchar").HasMaxLength(50);
            modelBuilder.Entity<Clientes>().Property(x => x.cnpj).IsRequired().HasColumnType("varchar").HasMaxLength(50);
            modelBuilder.Entity<Clientes>().Property(x => x.endereço).IsRequired().HasColumnType("varchar").HasMaxLength(50);
            modelBuilder.Entity<Clientes>().Property(x => x.numero).IsRequired().HasColumnType("int");
            modelBuilder.Entity<Clientes>().Property(x => x.bairro).IsRequired().HasColumnType("varchar").HasMaxLength(50);
            modelBuilder.Entity<Clientes>().Property(x => x.complemento).IsRequired().HasColumnType("varchar").HasMaxLength(50);
            modelBuilder.Entity<Clientes>().Property(x => x.municipio).IsRequired().HasColumnType("varchar").HasMaxLength(50);
            modelBuilder.Entity<Clientes>().Property(x => x.cep).IsRequired().HasColumnType("varchar").HasMaxLength(50);
        }
    }
}
