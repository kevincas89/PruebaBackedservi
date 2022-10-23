using Entity;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;


namespace DAL
{
    public class ServiDrinkContext : DbContext
    {

        public ServiDrinkContext(DbContextOptions options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
           /* modelBuilder.Entity<Empleado>()
                .HasOne<Administrador>(e => e.Administrador)
                .WithOne(a => a.Empleado)
                .HasForeignKey<Administrador>(a => a.Empleado);


            modelBuilder.Entity<Empleado>()
                .HasMany<Repartidor>(e => e.Repartidores)
                .WithMany(r => r.Empleados);
               

            modelBuilder.Entity<Empleado>()
                .HasMany<Vendedor>(e => e.Vendedores)
                .WithMany(v => v.Empleados);


            modelBuilder.Entity<Vendedor>()
                .HasMany<Pedido>(v => v.pedidos)
                .WithMany(p => p.Vendedores);


            modelBuilder.Entity<Pedido>()
                .HasMany<Producto>(p => p.Productos)
                .WithMany(p => p.Pedidos);

           modelBuilder.Entity<Producto>()
               .HasOne<Marca>(p => p.Marca)
               .WithMany(m => m.Productos)
               .HasForeignKey(p => p.Cod_Marca_FK);
           */
        }

        public DbSet<Empleado> Empleados { get; set; }
        public DbSet<Administrador> Administrador { get; set; }
        public DbSet<Marca> Marca { get; set; }
        public DbSet<Pedido> Pedidos { get; set; }
        public DbSet<Producto> Productos { get; set; }
        public DbSet<Repartidor> repartidores { get; set; }
        public DbSet<Vendedor> Vendedores { get; set; }

       

    }
}