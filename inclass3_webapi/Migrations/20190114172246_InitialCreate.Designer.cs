﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using inclass3_webapi.DatabaseHelper;

namespace inclass3_webapi.Migrations
{
    [DbContext(typeof(TodoContext))]
    [Migration("20190114172246_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.4-rtm-31024");

            modelBuilder.Entity("inclass3_webapi.DatabaseHelper.ToDo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Description");

                    b.Property<bool>("IsComplete");

                    b.HasKey("Id");

                    b.ToTable("ToDos");

                    b.HasData(
                        new { Id = 1, Description = "Clean house", IsComplete = false },
                        new { Id = 2, Description = "Bake cake", IsComplete = false }
                    );
                });
#pragma warning restore 612, 618
        }
    }
}
