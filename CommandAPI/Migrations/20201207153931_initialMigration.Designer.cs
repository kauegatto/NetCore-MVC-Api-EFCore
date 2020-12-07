﻿// <auto-generated />
using CommandAPI.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CommandAPI.Migrations
{
    [DbContext(typeof(CommandContext))]
    [Migration("20201207153931_initialMigration")]
    partial class initialMigration
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

                    b.Property<string>("commandLine");

                    b.Property<string>("howTo");

                    b.Property<string>("platform");

                    b.HasKey("id");

                    b.ToTable("Commands");
                });
#pragma warning restore 612, 618
        }
    }
}