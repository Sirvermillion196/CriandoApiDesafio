﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using AtividadeAPI.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace AtividadeAPI
{
    public partial class cursodev_grupo1Context : IdentityDbContext<ApplicationUser>
    {

        public cursodev_grupo1Context(DbContextOptions<cursodev_grupo1Context> options)
            : base(options)
        {
        }

        public virtual DbSet<Banco> Banco { get; set; }
        public virtual DbSet<Clientes> Clientes { get; set; }
        public virtual DbSet<ContaContabeis> ContaContabeis { get; set; }
        public virtual DbSet<ContaContabeis1> ContaContabeis1 { get; set; }
        public virtual DbSet<Empresa> Empresa { get; set; }
        public virtual DbSet<Funcionarios> Funcionarios { get; set; }
        public virtual DbSet<Moeda> Moeda { get; set; }
        public virtual DbSet<Pais> Pais { get; set; }
        public virtual DbSet<Projetos> Projetos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Banco>(entity =>
            {
                entity.HasKey(e => e.IdBanco)
                    .HasName("PK__Banco__2D3F553EBF396714");

                entity.Property(e => e.IdBanco).ValueGeneratedNever();

                entity.HasOne(d => d.IdContaNavigation)
                    .WithMany(p => p.Banco)
                    .HasForeignKey(d => d.IdConta)
                    .HasConstraintName("FK__Banco__IdConta__403A8C7D");
            });

            modelBuilder.Entity<Clientes>(entity =>
            {
                entity.HasKey(e => e.ClienteId)
                    .HasName("PK__Clientes__71ABD08758F95C06");

                entity.HasOne(d => d.Pais)
                    .WithMany(p => p.Clientes)
                    .HasForeignKey(d => d.PaisId)
                    .HasConstraintName("FK__Clientes__PaisId__33D4B598");
            });

            modelBuilder.Entity<ContaContabeis>(entity =>
            {
                entity.HasKey(e => e.IdConta)
                    .HasName("PK__Conta_Co__D599CC48995A617B");

                entity.Property(e => e.IdConta).ValueGeneratedNever();
            });

            modelBuilder.Entity<ContaContabeis1>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();
            });

            modelBuilder.Entity<Empresa>(entity =>
            {
                entity.HasKey(e => e.IdEmpresa)
                    .HasName("PK__Empresa__5EF4033E85CB2FFE");

                entity.Property(e => e.IdEmpresa).ValueGeneratedNever();
            });

            modelBuilder.Entity<Funcionarios>(entity =>
            {
                entity.HasKey(e => e.IdFuncionarios)
                    .HasName("PK__Funciona__2B37BA37D55A0514");

                entity.Property(e => e.IdFuncionarios).ValueGeneratedNever();

                entity.HasOne(d => d.IdEmpresaNavigation)
                    .WithMany(p => p.Funcionarios)
                    .HasForeignKey(d => d.IdEmpresa)
                    .HasConstraintName("FK__Funcionar__IdEmp__44FF419A");
            });

            modelBuilder.Entity<Pais>(entity =>
            {
                entity.HasOne(d => d.Moeda)
                    .WithMany(p => p.Pais)
                    .HasForeignKey(d => d.MoedaId)
                    .HasConstraintName("FK__Pais__MoedaId__30F848ED");
            });

            modelBuilder.Entity<Projetos>(entity =>
            {
                entity.HasOne(d => d.Cliente)
                    .WithMany(p => p.Projetos)
                    .HasForeignKey(d => d.ClienteId)
                    .HasConstraintName("FK__Projetos__Client__36B12243");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}