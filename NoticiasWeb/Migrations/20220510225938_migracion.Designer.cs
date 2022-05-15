﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using NoticiasWeb.Data;

#nullable disable

namespace NoticiasWeb.Migrations
{
    [DbContext(typeof(ApplicationDBContext))]
    [Migration("20220510225938_migracion")]
    partial class migracion
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("NoticiasWeb.Models.Categorias", b =>
                {
                    b.Property<int>("CategoriaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CategoriaId"), 1L, 1);

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Titulo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CategoriaId");

                    b.ToTable("Categorias");
                });

            modelBuilder.Entity("NoticiasWeb.Models.Comentarios", b =>
                {
                    b.Property<int>("ComentarioId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ComentarioId"), 1L, 1);

                    b.Property<string>("Comentario")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Fecha")
                        .HasColumnType("datetime2");

                    b.Property<int>("NoticiaID")
                        .HasColumnType("int");

                    b.HasKey("ComentarioId");

                    b.HasIndex("NoticiaID");

                    b.ToTable("Comentarios");
                });

            modelBuilder.Entity("NoticiasWeb.Models.Noticias", b =>
                {
                    b.Property<int>("NoticiaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("NoticiaId"), 1L, 1);

                    b.Property<int>("CategoriaID")
                        .HasColumnType("int");

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Imagen")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Titulo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UsuarioID")
                        .HasColumnType("int");

                    b.Property<DateTime>("fecha")
                        .HasColumnType("datetime2");

                    b.HasKey("NoticiaId");

                    b.HasIndex("CategoriaID");

                    b.HasIndex("UsuarioID");

                    b.ToTable("Noticias");
                });

            modelBuilder.Entity("NoticiasWeb.Models.Privilegios", b =>
                {
                    b.Property<int>("PrivilegioId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PrivilegioId"), 1L, 1);

                    b.Property<string>("TipoUsuario")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("PrivilegioId");

                    b.ToTable("Privilegios");
                });

            modelBuilder.Entity("NoticiasWeb.Models.Suscripciónes", b =>
                {
                    b.Property<int>("SuscripcionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("SuscripcionId"), 1L, 1);

                    b.Property<string>("Caracteristica")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Costo")
                        .HasColumnType("int");

                    b.HasKey("SuscripcionId");

                    b.ToTable("Suscripciónes");
                });

            modelBuilder.Entity("NoticiasWeb.Models.Usuarios", b =>
                {
                    b.Property<int>("UsuarioId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("UsuarioId"), 1L, 1);

                    b.Property<string>("Alias")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Contrasena")
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PrivilegioID")
                        .HasColumnType("int");

                    b.Property<int>("SuscripcionID")
                        .HasColumnType("int");

                    b.HasKey("UsuarioId");

                    b.HasIndex("PrivilegioID");

                    b.HasIndex("SuscripcionID");

                    b.ToTable("Usuarios");
                });

            modelBuilder.Entity("NoticiasWeb.Models.Comentarios", b =>
                {
                    b.HasOne("NoticiasWeb.Models.Noticias", "Noticia")
                        .WithMany("Comentario")
                        .HasForeignKey("NoticiaID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Noticia");
                });

            modelBuilder.Entity("NoticiasWeb.Models.Noticias", b =>
                {
                    b.HasOne("NoticiasWeb.Models.Categorias", "Categoria")
                        .WithMany("Noticia")
                        .HasForeignKey("CategoriaID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("NoticiasWeb.Models.Usuarios", "Usuario")
                        .WithMany("Noticia")
                        .HasForeignKey("UsuarioID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Categoria");

                    b.Navigation("Usuario");
                });

            modelBuilder.Entity("NoticiasWeb.Models.Usuarios", b =>
                {
                    b.HasOne("NoticiasWeb.Models.Privilegios", "Privilegio")
                        .WithMany("Usuario")
                        .HasForeignKey("PrivilegioID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("NoticiasWeb.Models.Suscripciónes", "Suscripcion")
                        .WithMany("Usuario")
                        .HasForeignKey("SuscripcionID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Privilegio");

                    b.Navigation("Suscripcion");
                });

            modelBuilder.Entity("NoticiasWeb.Models.Categorias", b =>
                {
                    b.Navigation("Noticia");
                });

            modelBuilder.Entity("NoticiasWeb.Models.Noticias", b =>
                {
                    b.Navigation("Comentario");
                });

            modelBuilder.Entity("NoticiasWeb.Models.Privilegios", b =>
                {
                    b.Navigation("Usuario");
                });

            modelBuilder.Entity("NoticiasWeb.Models.Suscripciónes", b =>
                {
                    b.Navigation("Usuario");
                });

            modelBuilder.Entity("NoticiasWeb.Models.Usuarios", b =>
                {
                    b.Navigation("Noticia");
                });
#pragma warning restore 612, 618
        }
    }
}