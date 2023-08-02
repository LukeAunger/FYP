﻿// <auto-generated />
using System;
using Delamain_backend.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Delamain_backend.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("Delamain_backend.Models.HospitalLocation", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<double>("lat")
                        .HasColumnType("double precision");

                    b.Property<double>("lng")
                        .HasColumnType("double precision");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("HospitalLocations");
                });

            modelBuilder.Entity("Delamain_backend.Models.IcuData", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int?>("Age")
                        .HasColumnType("integer");

                    b.Property<bool?>("Atrialfibrillation")
                        .HasColumnType("boolean");

                    b.Property<double?>("Bmi")
                        .HasColumnType("double precision");

                    b.Property<bool?>("ChdWithNoMi")
                        .HasColumnType("boolean");

                    b.Property<bool?>("Copd")
                        .HasColumnType("boolean");

                    b.Property<bool?>("Deficiencyanemias")
                        .HasColumnType("boolean");

                    b.Property<bool?>("Depression")
                        .HasColumnType("boolean");

                    b.Property<bool?>("Diabetes")
                        .HasColumnType("boolean");

                    b.Property<string>("Gender")
                        .HasColumnType("text");

                    b.Property<double?>("HeartRate")
                        .HasColumnType("double precision");

                    b.Property<bool?>("Hyperlipemia")
                        .HasColumnType("boolean");

                    b.Property<bool?>("Hypertensive")
                        .HasColumnType("boolean");

                    b.Property<bool?>("Outcome")
                        .HasColumnType("boolean");

                    b.Property<double?>("RespitoryRate")
                        .HasColumnType("double precision");

                    b.Property<double?>("Temperature")
                        .HasColumnType("double precision");

                    b.HasKey("Id");

                    b.ToTable("IcuDatas");
                });

            modelBuilder.Entity("Delamain_backend.Models.Login", b =>
                {
                    b.Property<string>("Email")
                        .HasColumnType("text");

                    b.Property<byte[]>("PasswordHash")
                        .IsRequired()
                        .HasColumnType("bytea");

                    b.Property<string>("PasswordResetToken")
                        .HasColumnType("text");

                    b.Property<byte[]>("PasswordSalt")
                        .IsRequired()
                        .HasColumnType("bytea");

                    b.Property<DateTime?>("ResetTokenExpires")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("VerificationToken")
                        .HasColumnType("text");

                    b.Property<DateTime?>("VerifieAt")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("Email");

                    b.ToTable("Logins");
                });

            modelBuilder.Entity("Delamain_backend.Models.Queuemodel", b =>
                {
                    b.Property<string>("queueID")
                        .HasColumnType("text");

                    b.Property<double>("Riskscore")
                        .HasColumnType("double precision");

                    b.Property<int>("pushbackcount")
                        .HasColumnType("integer");

                    b.Property<int>("queueordernum")
                        .HasColumnType("integer");

                    b.HasKey("queueID");

                    b.ToTable("queuemodels");
                });

            modelBuilder.Entity("Delamain_backend.Models.Riskmodel", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("ID"));

                    b.Property<double>("BMI18to25")
                        .HasColumnType("double precision");

                    b.Property<double>("BMIoutsideof18to25")
                        .HasColumnType("double precision");

                    b.Property<double>("CHD_with_no_MI")
                        .HasColumnType("double precision");

                    b.Property<double>("COPD")
                        .HasColumnType("double precision");

                    b.Property<double>("age10to50")
                        .HasColumnType("double precision");

                    b.Property<double>("age51to100")
                        .HasColumnType("double precision");

                    b.Property<double>("atrialfibrillation")
                        .HasColumnType("double precision");

                    b.Property<double>("deficiencyanemias")
                        .HasColumnType("double precision");

                    b.Property<double>("depression")
                        .HasColumnType("double precision");

                    b.Property<double>("diabetes")
                        .HasColumnType("double precision");

                    b.Property<double>("female")
                        .HasColumnType("double precision");

                    b.Property<double>("goodbodytemp")
                        .HasColumnType("double precision");

                    b.Property<double>("hr60to100")
                        .HasColumnType("double precision");

                    b.Property<double>("hroutside60to100")
                        .HasColumnType("double precision");

                    b.Property<double>("hyperlipmia")
                        .HasColumnType("double precision");

                    b.Property<double>("hypertensive")
                        .HasColumnType("double precision");

                    b.Property<double>("male")
                        .HasColumnType("double precision");

                    b.Property<double>("outsidegoodbodytemp")
                        .HasColumnType("double precision");

                    b.Property<double>("rr12to16")
                        .HasColumnType("double precision");

                    b.Property<double>("rroutside12to16")
                        .HasColumnType("double precision");

                    b.HasKey("ID");

                    b.ToTable("riskmodals");
                });

            modelBuilder.Entity("Delamain_backend.Models.Userdetail", b =>
                {
                    b.Property<string>("userReqID")
                        .HasColumnType("text");

                    b.Property<double>("BMI")
                        .HasColumnType("double precision");

                    b.Property<bool>("CHD_with_no_MI")
                        .HasColumnType("boolean");

                    b.Property<bool>("COPD")
                        .HasColumnType("boolean");

                    b.Property<string>("Symptoms")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("age")
                        .HasColumnType("integer");

                    b.Property<bool>("atrialfibrillation")
                        .HasColumnType("boolean");

                    b.Property<DateTime>("date")
                        .HasColumnType("timestamp with time zone");

                    b.Property<bool>("deficiencyanemias")
                        .HasColumnType("boolean");

                    b.Property<bool>("depression")
                        .HasColumnType("boolean");

                    b.Property<bool>("diabetes")
                        .HasColumnType("boolean");

                    b.Property<string>("gender")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("geoloc")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<double>("heart_rate")
                        .HasColumnType("double precision");

                    b.Property<bool>("hyperlipemia")
                        .HasColumnType("boolean");

                    b.Property<bool>("hypertensive")
                        .HasColumnType("boolean");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("phone")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("queueId")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<double>("respitory_rate")
                        .HasColumnType("double precision");

                    b.Property<double>("tempurature")
                        .HasColumnType("double precision");

                    b.HasKey("userReqID");

                    b.HasIndex("queueId")
                        .IsUnique();

                    b.ToTable("userdetails");
                });

            modelBuilder.Entity("Delamain_backend.Models.userReqmodel", b =>
                {
                    b.Property<string>("userReqID")
                        .HasColumnType("text");

                    b.Property<double>("BMI")
                        .HasColumnType("double precision");

                    b.Property<bool>("CHD_with_no_MI")
                        .HasColumnType("boolean");

                    b.Property<bool>("COPD")
                        .HasColumnType("boolean");

                    b.Property<double>("Riskscore")
                        .HasColumnType("double precision");

                    b.Property<string>("Symptoms")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("age")
                        .HasColumnType("integer");

                    b.Property<bool>("atrialfibrillation")
                        .HasColumnType("boolean");

                    b.Property<DateTime>("date")
                        .HasColumnType("timestamp with time zone");

                    b.Property<bool>("deficiencyanemias")
                        .HasColumnType("boolean");

                    b.Property<bool>("depression")
                        .HasColumnType("boolean");

                    b.Property<bool>("diabetes")
                        .HasColumnType("boolean");

                    b.Property<string>("gender")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("geoloc")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<double>("heart_rate")
                        .HasColumnType("double precision");

                    b.Property<bool>("hyperlipemia")
                        .HasColumnType("boolean");

                    b.Property<bool>("hypertensive")
                        .HasColumnType("boolean");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("phone")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("pushbackcount")
                        .HasColumnType("integer");

                    b.Property<int>("queueordernum")
                        .HasColumnType("integer");

                    b.Property<double>("respitory_rate")
                        .HasColumnType("double precision");

                    b.Property<double>("tempurature")
                        .HasColumnType("double precision");

                    b.HasKey("userReqID");

                    b.ToTable("userReqmodels");
                });

            modelBuilder.Entity("Delamain_backend.Models.Userdetail", b =>
                {
                    b.HasOne("Delamain_backend.Models.Queuemodel", "Queuemodel")
                        .WithOne("userdetail")
                        .HasForeignKey("Delamain_backend.Models.Userdetail", "queueId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Queuemodel");
                });

            modelBuilder.Entity("Delamain_backend.Models.Queuemodel", b =>
                {
                    b.Navigation("userdetail");
                });
#pragma warning restore 612, 618
        }
    }
}