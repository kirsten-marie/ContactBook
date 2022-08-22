﻿// <auto-generated />
using System;
using ContactBook.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace ContactBook.Migrations
{
    [DbContext(typeof(ContactBookContext))]
    partial class ContactBookContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "6.0.8");

            modelBuilder.Entity("ContactBook.Models.Address", b =>
                {
                    b.Property<long>("AddressId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("TEXT");

                    b.Property<string>("StateAbbreviation")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Street")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("TEXT");

                    b.Property<string>("ZipCode")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("AddressId");

                    b.HasIndex("StateAbbreviation");

                    b.ToTable("Addresses");
                });

            modelBuilder.Entity("ContactBook.Models.Contact", b =>
                {
                    b.Property<long>("ContactId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<long?>("AddressId")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("ContactFrequencyFrequencyId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("EmailAddress")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("TEXT");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("TEXT");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("TEXT");

                    b.HasKey("ContactId");

                    b.HasIndex("AddressId");

                    b.HasIndex("ContactFrequencyFrequencyId");

                    b.ToTable("Contacts");
                });

            modelBuilder.Entity("ContactBook.Models.Frequency", b =>
                {
                    b.Property<int>("FrequencyId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("FrequencyId");

                    b.ToTable("FrequencyChoices");
                });

            modelBuilder.Entity("ContactBook.Models.State", b =>
                {
                    b.Property<string>("Abbreviation")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Abbreviation");

                    b.ToTable("States");
                });

            modelBuilder.Entity("ContactBook.Models.Address", b =>
                {
                    b.HasOne("ContactBook.Models.State", "State")
                        .WithMany()
                        .HasForeignKey("StateAbbreviation")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("State");
                });

            modelBuilder.Entity("ContactBook.Models.Contact", b =>
                {
                    b.HasOne("ContactBook.Models.Address", "Address")
                        .WithMany()
                        .HasForeignKey("AddressId");

                    b.HasOne("ContactBook.Models.Frequency", "ContactFrequency")
                        .WithMany()
                        .HasForeignKey("ContactFrequencyFrequencyId");

                    b.Navigation("Address");

                    b.Navigation("ContactFrequency");
                });
#pragma warning restore 612, 618
        }
    }
}
