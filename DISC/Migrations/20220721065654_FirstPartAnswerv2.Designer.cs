﻿// <auto-generated />
using System;
using DISC.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DISC.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20220721065654_FirstPartAnswerv2")]
    partial class FirstPartAnswerv2
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "6.0.7");

            modelBuilder.Entity("DISC.Models.Parts.FirstAnswer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("Maximum")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Minimum")
                        .HasColumnType("INTEGER");

                    b.Property<int>("QuistionNum")
                        .HasColumnType("INTEGER");

                    b.Property<Guid>("UserId")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("FirstPartAnswers");
                });

            modelBuilder.Entity("DISC.Models.Parts.FirstQuiz", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("QuizFirst")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("QuizFourth")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("QuizSecond")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("QuizThird")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("FirstPartQuizzes");
                });

            modelBuilder.Entity("DISC.Models.Parts.SecondQuiz", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("QuestionFifth")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("QuestionFirst")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("QuestionFourth")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("QuestionSecond")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("QuestionSeventh")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("QuestionSixth")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("QuestionThird")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("SecondPartQuizzes");
                });

            modelBuilder.Entity("DISC.Models.Users", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Gender")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("LastName")
                        .HasColumnType("TEXT");

                    b.Property<string>("SecondName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });
#pragma warning restore 612, 618
        }
    }
}
