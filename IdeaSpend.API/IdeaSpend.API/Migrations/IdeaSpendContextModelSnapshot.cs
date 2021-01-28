﻿// <auto-generated />

using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;

namespace IdeaSpend.API.Migrations
{
    [DbContext(typeof(IdeaSpendContext))]
    partial class IdeaSpendContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.2");

            modelBuilder.Entity("IdeaSpend.API.UserEntity", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("Created")
                        .HasColumnType("TEXT")
                        .HasColumnName("account_created");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasColumnName("email");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("TEXT")
                        .HasColumnName("imie");

                    b.Property<DateTime>("LastLogin")
                        .HasColumnType("TEXT")
                        .HasColumnName("last_login");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("TEXT")
                        .HasColumnName("nazwisko");

                    b.Property<byte[]>("PasswordHash")
                        .HasColumnType("BLOB")
                        .HasColumnName("hash");

                    b.Property<byte[]>("PasswordSalt")
                        .HasColumnType("BLOB")
                        .HasColumnName("salt");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("TEXT")
                        .HasColumnName("nazwa_uzytkownika");

                    b.HasKey("UserId");

                    b.ToTable("Uzytkownik");
                });

            modelBuilder.Entity("IdeaSpend.API.UserEntity", b =>
                {
                    b.OwnsMany("IdeaSpend.API.TransactionEntity", "Transactions", b1 =>
                        {
                            b1.Property<int>("TransactionId")
                                .ValueGeneratedOnAdd()
                                .HasColumnType("INTEGER");

                            b1.Property<string>("Category")
                                .HasColumnType("TEXT")
                                .HasColumnName("kategoria");

                            b1.Property<double>("Price")
                                .HasColumnType("REAL")
                                .HasColumnName("cena");

                            b1.Property<string>("ProductName")
                                .HasColumnType("TEXT")
                                .HasColumnName("nazwa_produktu");

                            b1.Property<int>("Quantity")
                                .HasColumnType("INTEGER")
                                .HasColumnName("ilosc");

                            b1.Property<string>("Seller")
                                .HasColumnType("TEXT")
                                .HasColumnName("sprzedawca");

                            b1.Property<DateTime>("TransactionDate")
                                .HasColumnType("TEXT")
                                .HasColumnName("data_transakcji");

                            b1.Property<string>("Unit")
                                .HasColumnType("TEXT")
                                .HasColumnName("jednostka");

                            b1.Property<int>("UserId")
                                .HasColumnType("INTEGER");

                            b1.Property<double>("Weights")
                                .HasColumnType("REAL")
                                .HasColumnName("waga");

                            b1.HasKey("TransactionId");

                            b1.HasIndex("UserId");

                            b1.ToTable("Platnosci");

                            b1.WithOwner("User")
                                .HasForeignKey("UserId");

                            b1.Navigation("User");
                        });

                    b.Navigation("Transactions");
                });
#pragma warning restore 612, 618
        }
    }
}
