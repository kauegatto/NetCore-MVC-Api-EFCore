﻿// <auto-generated />
using CommandAPI.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CommandAPI.Migrations
{
    [DbContext(typeof(CommandContext))]
    [Migration("20201208021738_modelsUpdate")]
    partial class modelsUpdate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.14-servicing-32113");

            modelBuilder.Entity("CommandAPI.Models.Command", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("commandLine")
                        .IsRequired()
                        .HasColumnName("ds_commandLine");

                    b.Property<string>("howTo")
                        .HasColumnName("ds_howTo");

                    b.Property<string>("platform")
                        .HasColumnName("nm_platform");

                    b.Property<string>("whatItDoes")
                        .HasColumnName("ds_whatItDoes");

                    b.HasKey("id");

                    b.ToTable("command");
                });
#pragma warning restore 612, 618
        }
    }
}
