﻿// <auto-generated />
using System;
using BusinessManager.DataLeyer;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace BusinessManager.DataLeyer.Migrations
{
    [DbContext(typeof(BMDBContext))]
    [Migration("20181210214715_Rename_Hesab_Moshtari")]
    partial class Rename_Hesab_Moshtari
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.0-rtm-35687")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("BusinessManager.DomainClasses.Frooshande", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .IsRequired();

                    b.Property<string>("Telephone")
                        .IsRequired()
                        .HasMaxLength(12);

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(200);

                    b.HasKey("Id");

                    b.ToTable("Frooshandes");
                });

            modelBuilder.Entity("BusinessManager.DomainClasses.HesabFrooshande", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("BaghiMande")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<int?>("FrooshandeId");

                    b.Property<int>("IdFrooshande");

                    b.Property<string>("Meghdar")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("ShomareFaktor")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<int>("Type");

                    b.Property<DateTime>("date");

                    b.Property<string>("dateShamsi")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("FrooshandeId");

                    b.ToTable("HesabFrooshandes");
                });

            modelBuilder.Entity("BusinessManager.DomainClasses.HesabMoshtari", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Creditor")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("Debtor")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<int>("Description");

                    b.Property<int>("MoshtariId");

                    b.Property<string>("Remaining")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<DateTime>("date");

                    b.Property<string>("dateShamsi")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("MoshtariId");

                    b.ToTable("hesabMoshtaris");
                });

            modelBuilder.Entity("BusinessManager.DomainClasses.Moshtari", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .IsRequired();

                    b.Property<string>("Family")
                        .IsRequired()
                        .HasMaxLength(200);

                    b.Property<int>("IdParent");

                    b.Property<string>("Mobail")
                        .IsRequired()
                        .HasMaxLength(12);

                    b.Property<string>("Nam")
                        .IsRequired()
                        .HasMaxLength(200);

                    b.Property<int>("Radif");

                    b.Property<string>("Telephone")
                        .IsRequired()
                        .HasMaxLength(12);

                    b.HasKey("Id");

                    b.ToTable("Moshtaris");
                });

            modelBuilder.Entity("BusinessManager.DomainClasses.RizFroosh", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Count");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(200);

                    b.Property<int>("IdHesabMoshtari");

                    b.Property<string>("Price")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<int>("Radif");

                    b.Property<string>("UnitPrice")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<int?>("hesabMoshtariId");

                    b.HasKey("Id");

                    b.HasIndex("hesabMoshtariId");

                    b.ToTable("RizFrooshs");
                });

            modelBuilder.Entity("BusinessManager.DomainClasses.RizKharid", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Count");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(200);

                    b.Property<int?>("HesabFrooshandeId");

                    b.Property<int>("IdHesabFrooshande");

                    b.Property<string>("Price")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<int>("Radif");

                    b.Property<string>("SalesPrice")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("UnitPrice")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.HasKey("Id");

                    b.HasIndex("HesabFrooshandeId");

                    b.ToTable("RizKharids");
                });

            modelBuilder.Entity("BusinessManager.DomainClasses.HesabFrooshande", b =>
                {
                    b.HasOne("BusinessManager.DomainClasses.Frooshande", "Frooshande")
                        .WithMany("HesabFrooshande")
                        .HasForeignKey("FrooshandeId");
                });

            modelBuilder.Entity("BusinessManager.DomainClasses.HesabMoshtari", b =>
                {
                    b.HasOne("BusinessManager.DomainClasses.Moshtari", "Moshtari")
                        .WithMany("hesabMoshtari")
                        .HasForeignKey("MoshtariId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("BusinessManager.DomainClasses.RizFroosh", b =>
                {
                    b.HasOne("BusinessManager.DomainClasses.HesabMoshtari", "hesabMoshtari")
                        .WithMany("RizFroosh")
                        .HasForeignKey("hesabMoshtariId");
                });

            modelBuilder.Entity("BusinessManager.DomainClasses.RizKharid", b =>
                {
                    b.HasOne("BusinessManager.DomainClasses.HesabFrooshande", "HesabFrooshande")
                        .WithMany("RizKharid")
                        .HasForeignKey("HesabFrooshandeId");
                });
#pragma warning restore 612, 618
        }
    }
}
