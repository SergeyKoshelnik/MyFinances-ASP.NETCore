﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using MyFinances.Data;
using System;

namespace MyFinances.Migrations
{
    [DbContext(typeof(ApplicationDBContext))]
    [Migration("20200217183707_EditDB_1")]
    partial class EditDB_1
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn)
                .HasAnnotation("ProductVersion", "2.0.3-rtm-10026");

            modelBuilder.Entity("MyFinances.Models.Accumulation", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<double>("Accumulated");

                    b.Property<string>("AccumulationName")
                        .IsRequired();

                    b.Property<string>("CommentforAccumulation");

                    b.Property<double>("Contributed");

                    b.Property<DateTime>("DateTimeAccumulation");

                    b.Property<double>("SummofAccumulation");

                    b.Property<int>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Accumulations");
                });

            modelBuilder.Entity("MyFinances.Models.Debt", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("DateEndDate");

                    b.Property<string>("DebtName")
                        .IsRequired();

                    b.Property<double>("SummofDebt");

                    b.Property<int>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Debts");
                });

            modelBuilder.Entity("MyFinances.Models.Transaction", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("CommentforCategory");

                    b.Property<double>("Cost");

                    b.Property<DateTime>("DateTimeTransaction");

                    b.Property<double>("Income");

                    b.Property<int>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Transactions");
                });

            modelBuilder.Entity("MyFinances.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Answer")
                        .IsRequired();

                    b.Property<string>("Password")
                        .IsRequired();

                    b.Property<string>("Question")
                        .IsRequired();

                    b.Property<string>("Username")
                        .IsRequired();

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("MyFinances.Models.Accumulation", b =>
                {
                    b.HasOne("MyFinances.Models.User", "User")
                        .WithMany("Accumulations")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("MyFinances.Models.Debt", b =>
                {
                    b.HasOne("MyFinances.Models.User", "User")
                        .WithMany("Debts")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("MyFinances.Models.Transaction", b =>
                {
                    b.HasOne("MyFinances.Models.User", "User")
                        .WithMany("Transactions")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
