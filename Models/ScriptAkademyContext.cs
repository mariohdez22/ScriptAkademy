using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace ScriptAkademy.Models
{
    public partial class ScriptAkademyContext : DbContext
    {
        public ScriptAkademyContext()
        {
        }

        public ScriptAkademyContext(DbContextOptions<ScriptAkademyContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Cliente> Clientes { get; set; } = null!;
        public virtual DbSet<DetalleVenta> DetalleVentas { get; set; } = null!;
        public virtual DbSet<EstadoProducto> EstadoProductos { get; set; } = null!;
        public virtual DbSet<EstadoUsuario> EstadoUsuarios { get; set; } = null!;
        public virtual DbSet<Producto> Productos { get; set; } = null!;
        public virtual DbSet<TipoProducto> TipoProductos { get; set; } = null!;
        public virtual DbSet<TipoUsuario> TipoUsuarios { get; set; } = null!;
        public virtual DbSet<Usuario> Usuarios { get; set; } = null!;
        public virtual DbSet<Venta> Ventas { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Cliente>(entity =>
            {
                entity.HasKey(e => e.IdCliente)
                    .HasName("PK__cliente__885457EECD58ED32");

                entity.ToTable("cliente");

                entity.Property(e => e.IdCliente).HasColumnName("idCliente");

                entity.Property(e => e.Contrasena)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("contrasena");

                entity.Property(e => e.Correo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("correo");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("nombre");
            });

            modelBuilder.Entity<DetalleVenta>(entity =>
            {
                entity.HasKey(e => e.IddetalleVenta)
                    .HasName("PK__detalle___7CFD2ACA2234F3A6");

                entity.ToTable("detalle_ventas");

                entity.Property(e => e.IddetalleVenta).HasColumnName("iddetalleVenta");

                entity.Property(e => e.Cantidad).HasColumnName("cantidad");

                entity.Property(e => e.IdProductos).HasColumnName("idProductos");

                entity.Property(e => e.IdVenta).HasColumnName("idVenta");

                entity.HasOne(d => d.IdProductosNavigation)
                    .WithMany(p => p.DetalleVenta)
                    .HasForeignKey(d => d.IdProductos)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__detalle_v__idPro__4CA06362");

                entity.HasOne(d => d.IdVentaNavigation)
                    .WithMany(p => p.DetalleVenta)
                    .HasForeignKey(d => d.IdVenta)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__detalle_v__idVen__4BAC3F29");
            });

            modelBuilder.Entity<EstadoProducto>(entity =>
            {
                entity.HasKey(e => e.IdestadoProducto)
                    .HasName("PK__estado_p__89983936BB58019D");

                entity.ToTable("estado_producto");

                entity.Property(e => e.IdestadoProducto).HasColumnName("idestadoProducto");

                entity.Property(e => e.EstadoProducto1)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("estadoProducto");
            });

            modelBuilder.Entity<EstadoUsuario>(entity =>
            {
                entity.HasKey(e => e.IdestadoUsuario)
                    .HasName("PK__estado_u__080C08B63109B4FB");

                entity.ToTable("estado_usuario");

                entity.Property(e => e.IdestadoUsuario).HasColumnName("idestadoUsuario");

                entity.Property(e => e.EstadoUsuario1)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("estadoUsuario");
            });

            modelBuilder.Entity<Producto>(entity =>
            {
                entity.HasKey(e => e.IdProductos)
                    .HasName("PK__producto__A26E462DDE7570FD");

                entity.ToTable("productos");

                entity.Property(e => e.IdProductos).HasColumnName("idProductos");

                entity.Property(e => e.Cantidad).HasColumnName("cantidad");

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("descripcion");

                entity.Property(e => e.IdUsuario).HasColumnName("idUsuario");

                entity.Property(e => e.IdestadoProducto).HasColumnName("idestadoProducto");

                entity.Property(e => e.IdtipoProducto).HasColumnName("idtipoProducto");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("nombre");

                entity.Property(e => e.Precio)
                    .HasColumnType("numeric(10, 2)")
                    .HasColumnName("precio");

                entity.HasOne(d => d.IdUsuarioNavigation)
                    .WithMany(p => p.Productos)
                    .HasForeignKey(d => d.IdUsuario)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__productos__idUsu__45F365D3");

                entity.HasOne(d => d.IdestadoProductoNavigation)
                    .WithMany(p => p.Productos)
                    .HasForeignKey(d => d.IdestadoProducto)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__productos__idest__440B1D61");

                entity.HasOne(d => d.IdtipoProductoNavigation)
                    .WithMany(p => p.Productos)
                    .HasForeignKey(d => d.IdtipoProducto)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__productos__idtip__44FF419A");
            });

            modelBuilder.Entity<TipoProducto>(entity =>
            {
                entity.HasKey(e => e.IdtipoProducto)
                    .HasName("PK__tipo_pro__6BDCB6D685A340EB");

                entity.ToTable("tipo_producto");

                entity.Property(e => e.IdtipoProducto).HasColumnName("idtipoProducto");

                entity.Property(e => e.TipoProducto1)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("tipoProducto");
            });

            modelBuilder.Entity<TipoUsuario>(entity =>
            {
                entity.HasKey(e => e.IdtipoUsuario)
                    .HasName("PK__tipo_usu__743B669E029CB814");

                entity.ToTable("tipo_usuario");

                entity.Property(e => e.IdtipoUsuario).HasColumnName("idtipoUsuario");

                entity.Property(e => e.TipoUsuario1)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("tipoUsuario");
            });

            modelBuilder.Entity<Usuario>(entity =>
            {
                entity.HasKey(e => e.IdUsuario)
                    .HasName("PK__usuario__645723A6AF52CD8F");

                entity.ToTable("usuario");

                entity.Property(e => e.IdUsuario).HasColumnName("idUsuario");

                entity.Property(e => e.Celular)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("celular");

                entity.Property(e => e.Contrasena)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("contrasena");

                entity.Property(e => e.Correo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("correo");

                entity.Property(e => e.Dui)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("dui");

                entity.Property(e => e.IdestadoUsuario).HasColumnName("idestadoUsuario");

                entity.Property(e => e.IdtipoUsuario).HasColumnName("idtipoUsuario");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("nombre");

                entity.HasOne(d => d.oEstadoUsuario)
                    .WithMany(p => p.Usuarios)
                    .HasForeignKey(d => d.IdestadoUsuario)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__usuario__idestad__3A81B327");

                entity.HasOne(d => d.oTipoUsuario)
                    .WithMany(p => p.Usuarios)
                    .HasForeignKey(d => d.IdtipoUsuario)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__usuario__idtipoU__3B75D760");
            });

            modelBuilder.Entity<Venta>(entity =>
            {
                entity.HasKey(e => e.IdVenta)
                    .HasName("PK__ventas__077D5614F72D6AD5");

                entity.ToTable("ventas");

                entity.Property(e => e.IdVenta).HasColumnName("idVenta");

                entity.Property(e => e.Fecha)
                    .HasColumnType("datetime")
                    .HasColumnName("fecha");

                entity.Property(e => e.Idcliente).HasColumnName("idcliente");

                entity.Property(e => e.Total)
                    .HasColumnType("numeric(10, 2)")
                    .HasColumnName("total");

                entity.HasOne(d => d.IdclienteNavigation)
                    .WithMany(p => p.Venta)
                    .HasForeignKey(d => d.Idcliente)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__ventas__idclient__48CFD27E");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
