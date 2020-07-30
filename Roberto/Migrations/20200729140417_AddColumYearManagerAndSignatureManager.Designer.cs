﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Roberto.DAL;

namespace Roberto.Migrations
{
    [DbContext(typeof(RobertoContext))]
    [Migration("20200729140417_AddColumYearManagerAndSignatureManager")]
    partial class AddColumYearManagerAndSignatureManager
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

                    b.Property<string>("AboutOnManager")
                        .HasColumnType("nvarchar(1500)")
                        .HasMaxLength(1500);

                    b.Property<string>("ImageManager")
                        .HasColumnType("nvarchar(150)")
                        .HasMaxLength(150);

                    b.Property<string>("SignatureManager")
                        .HasColumnType("nvarchar(500)")
                        .HasMaxLength(500);

                    b.Property<int>("YearManager")
                        .HasColumnType("int")
                        .HasMaxLength(50);

                    b.HasKey("AbputUs");

                    b.ToTable("AboutUs");
                });

            modelBuilder.Entity("Roberto.Models.Activity", b =>
                {
                    b.Property<int>("ActivityId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CommentOnActivity")
                        .HasColumnType("nvarchar(1000)")
                        .HasMaxLength(1000);

                    b.Property<string>("ImageActivity")
                        .HasColumnType("nvarchar(250)")
                        .HasMaxLength(250);

                    b.Property<string>("NameActivity")
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<string>("TypeActivity")
                        .HasColumnType("nvarchar(90)")
                        .HasMaxLength(90);

                    b.HasKey("ActivityId");

                    b.ToTable("Activities");
                });

            modelBuilder.Entity("Roberto.Models.BedRoom", b =>
                {
                    b.Property<int>("BedRoomId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(1000)")
                        .HasMaxLength(1000);

                    b.Property<bool>("Disponible")
                        .HasColumnType("bit");

                    b.Property<int?>("ImgId")
                        .HasColumnType("int");

                    b.Property<string>("NameBedRoom")
                        .HasColumnType("nvarchar(250)")
                        .HasMaxLength(250);

                    b.Property<int>("NumberAdult")
                        .HasColumnType("int")
                        .HasMaxLength(6);

                    b.Property<int>("NumberChild")
                        .HasColumnType("int")
                        .HasMaxLength(6);

                    b.Property<int>("PiceBedRoom")
                        .HasColumnType("int");

                    b.Property<int>("SizeBedRoom")
                        .HasColumnType("int")
                        .HasMaxLength(500);

                    b.HasKey("BedRoomId");

                    b.HasIndex("ImgId");

                    b.ToTable("BedRooms");
                });

            modelBuilder.Entity("Roberto.Models.Blog", b =>
                {
                    b.Property<int>("BlogId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CommentVideos")
                        .HasColumnType("nvarchar(1500)")
                        .HasMaxLength(1500);

                    b.Property<string>("CommmentPhotoos")
                        .HasColumnType("nvarchar(1500)")
                        .HasMaxLength(1500);

                    b.Property<string>("Image")
                        .HasColumnType("nvarchar(300)")
                        .HasMaxLength(300);

                    b.Property<string>("TypeEvent")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Videos")
                        .HasColumnType("nvarchar(300)")
                        .HasMaxLength(300);

                    b.HasKey("BlogId");

                    b.ToTable("Blogs");
                });

            modelBuilder.Entity("Roberto.Models.Client", b =>
                {
                    b.Property<int>("clientId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("BedRoomId")
                        .HasColumnType("int");

                    b.Property<int>("CommentId")
                        .HasColumnType("int");

                    b.Property<DateTime>("DateEntree")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateOut")
                        .HasColumnType("datetime2");

                    b.Property<string>("NomClient")
                        .HasColumnType("nvarchar(120)")
                        .HasMaxLength(120);

                    b.HasKey("clientId");

                    b.HasIndex("BedRoomId");

                    b.HasIndex("CommentId");

                    b.ToTable("Clients");
                });

            modelBuilder.Entity("Roberto.Models.Comment", b =>
                {
                    b.Property<int>("CommentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CMessage")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NameUserComment")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CommentId");

                    b.ToTable("Comments");
                });

            modelBuilder.Entity("Roberto.Models.DefaultService", b =>
                {
                    b.Property<int>("DefaultServiceId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("DafaulServiceName")
                        .HasColumnType("nvarchar(70)")
                        .HasMaxLength(70);

                    b.HasKey("DefaultServiceId");

                    b.ToTable("DefautServices");
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

            modelBuilder.Entity("Roberto.Models.ServicesRoom", b =>
                {
                    b.Property<int>("ServiceRoomId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("BedRoomId")
                        .HasColumnType("int");

                    b.Property<string>("ServiceListName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ServiceRoomId");

                    b.HasIndex("BedRoomId");

                    b.ToTable("ServicesRooms");
                });

            modelBuilder.Entity("Roberto.Models.BedRoom", b =>
                {
                    b.HasOne("Roberto.Models.Image", "Ïmage")
                        .WithMany()
                        .HasForeignKey("ImgId");
                });

            modelBuilder.Entity("Roberto.Models.Client", b =>
                {
                    b.HasOne("Roberto.Models.BedRoom", "BedRoom")
                        .WithMany()
                        .HasForeignKey("BedRoomId");

                    b.HasOne("Roberto.Models.Comment", "Comment")
                        .WithMany()
                        .HasForeignKey("CommentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Roberto.Models.ServicesRoom", b =>
                {
                    b.HasOne("Roberto.Models.BedRoom", null)
                        .WithMany("servicesRooms")
                        .HasForeignKey("BedRoomId");
                });
#pragma warning restore 612, 618
        }
    }
}
