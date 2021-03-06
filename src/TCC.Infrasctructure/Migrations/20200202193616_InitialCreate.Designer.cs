﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TCC.Infrasctructure.Data;

namespace TCC.Infrasctructure.Migrations
{
    [DbContext(typeof(Context))]
    [Migration("20200202193616_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("TCC.ApplicationCore.Entity.Cliente", b =>
                {
                    b.Property<int>("ClienteId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Email");

                    b.Property<string>("Nome");

                    b.Property<string>("Telefone");

                    b.HasKey("ClienteId");

                    b.ToTable("Cliente");
                });

            modelBuilder.Entity("TCC.ApplicationCore.Entity.EmailConfig", b =>
                {
                    b.Property<int>("EmailConfigId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Body");

                    b.Property<string>("CredentialPassword");

                    b.Property<string>("CredentialUserName");

                    b.Property<int>("PortSSL");

                    b.Property<string>("SmtpClient");

                    b.Property<string>("Subject");

                    b.HasKey("EmailConfigId");

                    b.ToTable("EmailConfig");
                });

            modelBuilder.Entity("TCC.ApplicationCore.Entity.Veiculo", b =>
                {
                    b.Property<int>("VeiculoId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ClienteId");

                    b.Property<string>("Placa");

                    b.Property<string>("Renavam");

                    b.HasKey("VeiculoId");

                    b.HasIndex("ClienteId");

                    b.ToTable("Veiculo");
                });

            modelBuilder.Entity("TCC.ApplicationCore.Entity.Veiculo", b =>
                {
                    b.HasOne("TCC.ApplicationCore.Entity.Cliente", "Cliente")
                        .WithMany("Veiculos")
                        .HasForeignKey("ClienteId")
                        .OnDelete(DeleteBehavior.Restrict);
                });
#pragma warning restore 612, 618
        }
    }
}
