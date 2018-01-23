using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Texter.Models;

namespace Texter.Migrations
{
    [DbContext(typeof(TexterDbContext))]
    [Migration("20180122220134_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.1.2");

            modelBuilder.Entity("Texter.Models.Contact", b =>
                {
                    b.Property<string>("Number")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.HasKey("Number");

                    b.ToTable("contacts");
                });
        }
    }
}
