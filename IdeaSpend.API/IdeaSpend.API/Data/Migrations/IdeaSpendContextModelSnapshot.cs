﻿// <auto-generated />
using System;
using IdeaSpend.API;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace IdeaSpend.API.Migrations
{
    [DbContext(typeof(IdeaSpendContext))]
    partial class IdeaSpendContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.0-preview.1.21102.2");

            modelBuilder.Entity("IdeaSpend.API.CatalogEntity", b =>
                {
                    b.Property<int>("CatalogId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("CatalogName")
                        .HasColumnType("TEXT")
                        .HasColumnName("nazwa");

                    b.Property<int>("UserId")
                        .HasColumnType("INTEGER");

                    b.HasKey("CatalogId");

                    b.HasIndex("UserId");

                    b.ToTable("Katalog_produktów");
                });

            modelBuilder.Entity("IdeaSpend.API.CurrencyEntity", b =>
                {
                    b.Property<int>("CurrencyId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Code")
                        .HasColumnType("TEXT")
                        .HasColumnName("kod");

                    b.Property<DateTime>("Date")
                        .HasColumnType("TEXT")
                        .HasColumnName("data");

                    b.Property<double>("Value")
                        .HasColumnType("REAL")
                        .HasColumnName("wartość");

                    b.HasKey("CurrencyId");

                    b.ToTable("waluta");
                });

            modelBuilder.Entity("IdeaSpend.API.ProductEntity", b =>
                {
                    b.Property<int>("ProductId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("CatalogId")
                        .HasColumnType("INTEGER");

                    b.Property<double>("Price")
                        .HasColumnType("REAL")
                        .HasColumnName("cena");

                    b.Property<string>("ProductName")
                        .HasColumnType("TEXT")
                        .HasColumnName("nazwa_produktu");

                    b.Property<string>("Seller")
                        .HasColumnType("TEXT")
                        .HasColumnName("sprzedawca");

                    b.Property<string>("Unit")
                        .HasColumnType("TEXT")
                        .HasColumnName("jednostka");

                    b.Property<int>("UserId")
                        .HasColumnType("INTEGER");

                    b.HasKey("ProductId");

                    b.HasIndex("CatalogId");

                    b.HasIndex("UserId");

                    b.ToTable("Produkty");
                });

            modelBuilder.Entity("IdeaSpend.API.TransactionEntity", b =>
                {
                    b.Property<int>("TransactionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Currency")
                        .HasColumnType("TEXT")
                        .HasColumnName("waluta");

                    b.Property<double>("Paid")
                        .HasColumnType("REAL")
                        .HasColumnName("zapłacono");

                    b.Property<int>("ProductId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Quantity")
                        .HasColumnType("INTEGER")
                        .HasColumnName("ilosc");

                    b.Property<DateTime>("TransactionDate")
                        .HasColumnType("TEXT")
                        .HasColumnName("data_transakcji");

                    b.Property<int>("UserId")
                        .HasColumnType("INTEGER");

                    b.Property<double>("Weights")
                        .HasColumnType("REAL")
                        .HasColumnName("waga");

                    b.HasKey("TransactionId");

                    b.HasIndex("ProductId")
                        .IsUnique();

                    b.HasIndex("UserId");

                    b.ToTable("Platnosci");
                });

            modelBuilder.Entity("IdeaSpend.API.UserEntity", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("Created")
                        .HasColumnType("TEXT")
                        .HasColumnName("utworzono");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasColumnName("email");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("TEXT")
                        .HasColumnName("imie");

                    b.Property<double>("Income")
                        .HasColumnType("REAL")
                        .HasColumnName("dochód");

                    b.Property<DateTime>("LastLogin")
                        .HasColumnType("TEXT")
                        .HasColumnName("ostatnie_logowanie");

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

            modelBuilder.Entity("IdeaSpend.API.CatalogEntity", b =>
                {
                    b.HasOne("IdeaSpend.API.UserEntity", "User")
                        .WithMany("Catalogs")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("IdeaSpend.API.ProductEntity", b =>
                {
                    b.HasOne("IdeaSpend.API.CatalogEntity", "Catalog")
                        .WithMany("Produts")
                        .HasForeignKey("CatalogId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("IdeaSpend.API.UserEntity", "User")
                        .WithMany("Products")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Catalog");

                    b.Navigation("User");
                });

            modelBuilder.Entity("IdeaSpend.API.TransactionEntity", b =>
                {
                    b.HasOne("IdeaSpend.API.ProductEntity", "Product")
                        .WithOne("Transaction")
                        .HasForeignKey("IdeaSpend.API.TransactionEntity", "ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("IdeaSpend.API.UserEntity", "User")
                        .WithMany("Transactions")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Product");

                    b.Navigation("User");
                });

            modelBuilder.Entity("IdeaSpend.API.CatalogEntity", b =>
                {
                    b.Navigation("Produts");
                });

            modelBuilder.Entity("IdeaSpend.API.ProductEntity", b =>
                {
                    b.Navigation("Transaction");
                });

            modelBuilder.Entity("IdeaSpend.API.UserEntity", b =>
                {
                    b.Navigation("Catalogs");

                    b.Navigation("Products");

                    b.Navigation("Transactions");
                });
#pragma warning restore 612, 618
        }
    }
}
