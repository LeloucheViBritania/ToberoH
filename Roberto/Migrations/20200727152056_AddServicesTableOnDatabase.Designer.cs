﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Roberto.DAL;

namespace Roberto.Migrations
{
    [DbContext(typeof(RobertoContext))]
    [Migration("20200727152056_AddServicesTableOnDatabase")]
    partial class AddServicesTableOnDatabase
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Roberto.Models.AbImageHome", b =>
                {
                    b.Property<int>("IdAbHome")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("NameImgAbHome")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdAbHome");

                    b.ToTable("AbImageHomes");
                });

            modelBuilder.Entity("Roberto.Models.AboutUs", b =>
                {
                    b.Property<int>("AbputUs")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AboutHome")
                        .HasColumnType("nvarchar(1300)")
                        .HasMaxLength(1300);

                    b.Property<string>("AboutManagerName")
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.HasKey("AbputUs");

                    b.ToTable("AboutUs");
                });

            modelBuilder.Entity("Roberto.Models.Image", b =>
                {
                    b.Property<int>("ImgId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("NameImg")
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.HasKey("ImgId");

                    b.ToTable("Images");
                });

            modelBuilder.Entity("Roberto.Models.Service", b =>
                {
                    b.Property<int>("ServiceId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ServiceICon")
                        .IsRequired()
                        .HasColumnType("nvarchar(200)")
                        .HasMaxLength(200);

                    b.Property<string>("ServiceName")
                        .IsRequired()
                        .HasColumnType("nvarchar(20)")
                        .HasMaxLength(20);

                    b.HasKey("ServiceId");

                    b.ToTable("Services");
                });
#pragma warning restore 612, 618
        }
    }
}
