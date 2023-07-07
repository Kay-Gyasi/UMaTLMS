﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using UMaTLMS.Infrastructure.Persistence;

#nullable disable

namespace UMaTLMS.Infrastructure.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20230705114659_ExamsSchedule")]
    partial class ExamsSchedule
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("LectureSubClassGroup", b =>
                {
                    b.Property<int>("LecturesId")
                        .HasColumnType("int");

                    b.Property<int>("SubClassGroupsId")
                        .HasColumnType("int");

                    b.HasKey("LecturesId", "SubClassGroupsId");

                    b.HasIndex("SubClassGroupsId");

                    b.ToTable("LectureSubClassGroup");
                });

            modelBuilder.Entity("UMaTLMS.Core.Entities.ClassGroup", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("NumOfSubClasses")
                        .HasColumnType("int");

                    b.Property<int?>("Size")
                        .HasColumnType("int");

                    b.Property<int>("UmatId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("ClassGroups");
                });

            modelBuilder.Entity("UMaTLMS.Core.Entities.ClassRoom", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("Capacity")
                        .HasColumnType("int");

                    b.Property<bool>("IsIncludedInGeneralAssignment")
                        .HasColumnType("bit");

                    b.Property<bool>("IsLab")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Rooms", (string)null);
                });

            modelBuilder.Entity("UMaTLMS.Core.Entities.ExamsSchedule", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CourseId")
                        .HasColumnType("int");

                    b.Property<DateTime>("DateOfExam")
                        .HasColumnType("datetime2");

                    b.Property<string>("ExamPeriod")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("InvigilatorId")
                        .HasColumnType("int");

                    b.Property<bool>("IsVle")
                        .HasColumnType("bit");

                    b.Property<int?>("RoomId")
                        .HasColumnType("int");

                    b.Property<int>("SubClassGroupId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CourseId");

                    b.HasIndex("InvigilatorId");

                    b.HasIndex("RoomId");

                    b.HasIndex("SubClassGroupId");

                    b.ToTable("ExamsSchedules");
                });

            modelBuilder.Entity("UMaTLMS.Core.Entities.IncomingCourse", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Code")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CourseCategory")
                        .HasColumnType("int");

                    b.Property<int>("CourseGroup")
                        .HasColumnType("int");

                    b.Property<string>("CourseId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CourseType")
                        .HasColumnType("int");

                    b.Property<int>("Credit")
                        .HasColumnType("int");

                    b.Property<int?>("FirstExaminerStaffId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PracticalHours")
                        .HasColumnType("int");

                    b.Property<string>("ProgrammeCode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("ProgrammeId")
                        .HasColumnType("int");

                    b.Property<int?>("SecondExaminerStaffId")
                        .HasColumnType("int");

                    b.Property<int>("TeachingHours")
                        .HasColumnType("int");

                    b.Property<int?>("UmatId")
                        .HasColumnType("int");

                    b.Property<int?>("Year")
                        .HasColumnType("int");

                    b.Property<int?>("YearGroup")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("IncomingCourses");
                });

            modelBuilder.Entity("UMaTLMS.Core.Entities.Lecture", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CourseId")
                        .HasColumnType("int");

                    b.Property<int>("Duration")
                        .HasColumnType("int");

                    b.Property<bool>("IsPractical")
                        .HasColumnType("bit");

                    b.Property<bool>("IsVLE")
                        .HasColumnType("bit");

                    b.Property<int>("LecturerId")
                        .HasColumnType("int");

                    b.Property<int?>("OnlineLectureScheduleId")
                        .HasColumnType("int");

                    b.Property<string>("PreferredRoom")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CourseId");

                    b.HasIndex("LecturerId");

                    b.HasIndex("OnlineLectureScheduleId");

                    b.ToTable("Lectures");
                });

            modelBuilder.Entity("UMaTLMS.Core.Entities.LectureSchedule", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("DayOfWeek")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("FirstLectureId")
                        .HasColumnType("int");

                    b.Property<int>("RoomId")
                        .HasColumnType("int");

                    b.Property<int?>("SecondLectureId")
                        .HasColumnType("int");

                    b.Property<string>("TimePeriod")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("FirstLectureId");

                    b.HasIndex("RoomId");

                    b.HasIndex("SecondLectureId");

                    b.ToTable("Schedules");
                });

            modelBuilder.Entity("UMaTLMS.Core.Entities.Lecturer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UmatId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Lecturers");
                });

            modelBuilder.Entity("UMaTLMS.Core.Entities.OnlineLectureSchedule", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("DayOfWeek")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TimePeriod")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("OnlineSchedules");
                });

            modelBuilder.Entity("UMaTLMS.Core.Entities.OutboxMessage", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DateOccurred")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DateProcessed")
                        .HasColumnType("datetime2");

                    b.Property<string>("Error")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("OutboxMessages");
                });

            modelBuilder.Entity("UMaTLMS.Core.Entities.SubClassGroup", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("GroupId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("Size")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("GroupId");

                    b.ToTable("SubClassGroups");
                });

            modelBuilder.Entity("LectureSubClassGroup", b =>
                {
                    b.HasOne("UMaTLMS.Core.Entities.Lecture", null)
                        .WithMany()
                        .HasForeignKey("LecturesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("UMaTLMS.Core.Entities.SubClassGroup", null)
                        .WithMany()
                        .HasForeignKey("SubClassGroupsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("UMaTLMS.Core.Entities.ClassGroup", b =>
                {
                    b.OwnsOne("UMaTLMS.SharedKernel.Audit", "Audit", b1 =>
                        {
                            b1.Property<int>("ClassGroupId")
                                .HasColumnType("int");

                            b1.Property<DateTime>("CreatedAt")
                                .ValueGeneratedOnAdd()
                                .HasColumnType("datetime2")
                                .HasDefaultValue(new DateTime(2023, 7, 5, 11, 46, 58, 551, DateTimeKind.Utc).AddTicks(5395));

                            b1.Property<string>("CreatedBy")
                                .IsRequired()
                                .ValueGeneratedOnAdd()
                                .HasColumnType("nvarchar(max)")
                                .HasDefaultValue("admin");

                            b1.Property<string>("Status")
                                .IsRequired()
                                .HasColumnType("nvarchar(max)");

                            b1.Property<DateTime>("UpdatedAt")
                                .ValueGeneratedOnAdd()
                                .HasColumnType("datetime2")
                                .HasDefaultValue(new DateTime(2023, 7, 5, 11, 46, 58, 551, DateTimeKind.Utc).AddTicks(6412));

                            b1.Property<string>("UpdatedBy")
                                .IsRequired()
                                .ValueGeneratedOnAdd()
                                .HasColumnType("nvarchar(max)")
                                .HasDefaultValue("admin");

                            b1.HasKey("ClassGroupId");

                            b1.ToTable("ClassGroups");

                            b1.WithOwner()
                                .HasForeignKey("ClassGroupId");
                        });

                    b.Navigation("Audit");
                });

            modelBuilder.Entity("UMaTLMS.Core.Entities.ClassRoom", b =>
                {
                    b.OwnsOne("UMaTLMS.SharedKernel.Audit", "Audit", b1 =>
                        {
                            b1.Property<int>("ClassRoomId")
                                .HasColumnType("int");

                            b1.Property<DateTime>("CreatedAt")
                                .ValueGeneratedOnAdd()
                                .HasColumnType("datetime2")
                                .HasDefaultValue(new DateTime(2023, 7, 5, 11, 46, 58, 641, DateTimeKind.Utc).AddTicks(9110));

                            b1.Property<string>("CreatedBy")
                                .IsRequired()
                                .ValueGeneratedOnAdd()
                                .HasColumnType("nvarchar(max)")
                                .HasDefaultValue("admin");

                            b1.Property<string>("Status")
                                .IsRequired()
                                .HasColumnType("nvarchar(max)");

                            b1.Property<DateTime>("UpdatedAt")
                                .ValueGeneratedOnAdd()
                                .HasColumnType("datetime2")
                                .HasDefaultValue(new DateTime(2023, 7, 5, 11, 46, 58, 642, DateTimeKind.Utc).AddTicks(932));

                            b1.Property<string>("UpdatedBy")
                                .IsRequired()
                                .ValueGeneratedOnAdd()
                                .HasColumnType("nvarchar(max)")
                                .HasDefaultValue("admin");

                            b1.HasKey("ClassRoomId");

                            b1.ToTable("Rooms");

                            b1.WithOwner()
                                .HasForeignKey("ClassRoomId");
                        });

                    b.Navigation("Audit");
                });

            modelBuilder.Entity("UMaTLMS.Core.Entities.ExamsSchedule", b =>
                {
                    b.HasOne("UMaTLMS.Core.Entities.IncomingCourse", "Course")
                        .WithMany()
                        .HasForeignKey("CourseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("UMaTLMS.Core.Entities.Lecturer", "Invigilator")
                        .WithMany()
                        .HasForeignKey("InvigilatorId");

                    b.HasOne("UMaTLMS.Core.Entities.ClassRoom", "Room")
                        .WithMany()
                        .HasForeignKey("RoomId");

                    b.HasOne("UMaTLMS.Core.Entities.SubClassGroup", "SubClassGroup")
                        .WithMany()
                        .HasForeignKey("SubClassGroupId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.OwnsOne("UMaTLMS.SharedKernel.Audit", "Audit", b1 =>
                        {
                            b1.Property<int>("ExamsScheduleId")
                                .HasColumnType("int");

                            b1.Property<DateTime>("CreatedAt")
                                .ValueGeneratedOnAdd()
                                .HasColumnType("datetime2")
                                .HasDefaultValue(new DateTime(2023, 7, 5, 11, 46, 58, 578, DateTimeKind.Utc).AddTicks(7563));

                            b1.Property<string>("CreatedBy")
                                .IsRequired()
                                .ValueGeneratedOnAdd()
                                .HasColumnType("nvarchar(max)")
                                .HasDefaultValue("admin");

                            b1.Property<string>("Status")
                                .IsRequired()
                                .HasColumnType("nvarchar(max)");

                            b1.Property<DateTime>("UpdatedAt")
                                .ValueGeneratedOnAdd()
                                .HasColumnType("datetime2")
                                .HasDefaultValue(new DateTime(2023, 7, 5, 11, 46, 58, 579, DateTimeKind.Utc).AddTicks(1096));

                            b1.Property<string>("UpdatedBy")
                                .IsRequired()
                                .ValueGeneratedOnAdd()
                                .HasColumnType("nvarchar(max)")
                                .HasDefaultValue("admin");

                            b1.HasKey("ExamsScheduleId");

                            b1.ToTable("ExamsSchedules");

                            b1.WithOwner()
                                .HasForeignKey("ExamsScheduleId");
                        });

                    b.Navigation("Audit");

                    b.Navigation("Course");

                    b.Navigation("Invigilator");

                    b.Navigation("Room");

                    b.Navigation("SubClassGroup");
                });

            modelBuilder.Entity("UMaTLMS.Core.Entities.IncomingCourse", b =>
                {
                    b.OwnsOne("UMaTLMS.Core.Contracts.AcademicPeriodResponse", "AcademicPeriod", b1 =>
                        {
                            b1.Property<int>("IncomingCourseId")
                                .HasColumnType("int");

                            b1.Property<string>("AcademicYear")
                                .IsRequired()
                                .HasColumnType("nvarchar(max)");

                            b1.Property<int>("LowerYear")
                                .HasColumnType("int");

                            b1.Property<int>("Semester")
                                .HasColumnType("int");

                            b1.Property<int>("UpperYear")
                                .HasColumnType("int");

                            b1.HasKey("IncomingCourseId");

                            b1.ToTable("IncomingCourses");

                            b1.WithOwner()
                                .HasForeignKey("IncomingCourseId");
                        });

                    b.OwnsOne("UMaTLMS.SharedKernel.Audit", "Audit", b1 =>
                        {
                            b1.Property<int>("IncomingCourseId")
                                .HasColumnType("int");

                            b1.Property<DateTime>("CreatedAt")
                                .ValueGeneratedOnAdd()
                                .HasColumnType("datetime2")
                                .HasDefaultValue(new DateTime(2023, 7, 5, 11, 46, 58, 561, DateTimeKind.Utc).AddTicks(8932));

                            b1.Property<string>("CreatedBy")
                                .IsRequired()
                                .ValueGeneratedOnAdd()
                                .HasColumnType("nvarchar(max)")
                                .HasDefaultValue("admin");

                            b1.Property<string>("Status")
                                .IsRequired()
                                .HasColumnType("nvarchar(max)");

                            b1.Property<DateTime>("UpdatedAt")
                                .ValueGeneratedOnAdd()
                                .HasColumnType("datetime2")
                                .HasDefaultValue(new DateTime(2023, 7, 5, 11, 46, 58, 562, DateTimeKind.Utc).AddTicks(553));

                            b1.Property<string>("UpdatedBy")
                                .IsRequired()
                                .ValueGeneratedOnAdd()
                                .HasColumnType("nvarchar(max)")
                                .HasDefaultValue("admin");

                            b1.HasKey("IncomingCourseId");

                            b1.ToTable("IncomingCourses");

                            b1.WithOwner()
                                .HasForeignKey("IncomingCourseId");
                        });

                    b.Navigation("AcademicPeriod")
                        .IsRequired();

                    b.Navigation("Audit");
                });

            modelBuilder.Entity("UMaTLMS.Core.Entities.Lecture", b =>
                {
                    b.HasOne("UMaTLMS.Core.Entities.IncomingCourse", "Course")
                        .WithMany()
                        .HasForeignKey("CourseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("UMaTLMS.Core.Entities.Lecturer", "Lecturer")
                        .WithMany()
                        .HasForeignKey("LecturerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("UMaTLMS.Core.Entities.OnlineLectureSchedule", "OnlineLectureSchedule")
                        .WithMany("Lectures")
                        .HasForeignKey("OnlineLectureScheduleId");

                    b.OwnsOne("UMaTLMS.SharedKernel.Audit", "Audit", b1 =>
                        {
                            b1.Property<int>("LectureId")
                                .HasColumnType("int");

                            b1.Property<DateTime>("CreatedAt")
                                .ValueGeneratedOnAdd()
                                .HasColumnType("datetime2")
                                .HasDefaultValue(new DateTime(2023, 7, 5, 11, 46, 58, 596, DateTimeKind.Utc).AddTicks(6576));

                            b1.Property<string>("CreatedBy")
                                .IsRequired()
                                .ValueGeneratedOnAdd()
                                .HasColumnType("nvarchar(max)")
                                .HasDefaultValue("admin");

                            b1.Property<string>("Status")
                                .IsRequired()
                                .HasColumnType("nvarchar(max)");

                            b1.Property<DateTime>("UpdatedAt")
                                .ValueGeneratedOnAdd()
                                .HasColumnType("datetime2")
                                .HasDefaultValue(new DateTime(2023, 7, 5, 11, 46, 58, 597, DateTimeKind.Utc).AddTicks(85));

                            b1.Property<string>("UpdatedBy")
                                .IsRequired()
                                .ValueGeneratedOnAdd()
                                .HasColumnType("nvarchar(max)")
                                .HasDefaultValue("admin");

                            b1.HasKey("LectureId");

                            b1.ToTable("Lectures");

                            b1.WithOwner()
                                .HasForeignKey("LectureId");
                        });

                    b.Navigation("Audit");

                    b.Navigation("Course");

                    b.Navigation("Lecturer");

                    b.Navigation("OnlineLectureSchedule");
                });

            modelBuilder.Entity("UMaTLMS.Core.Entities.LectureSchedule", b =>
                {
                    b.HasOne("UMaTLMS.Core.Entities.Lecture", "FirstLecture")
                        .WithMany()
                        .HasForeignKey("FirstLectureId");

                    b.HasOne("UMaTLMS.Core.Entities.ClassRoom", "Room")
                        .WithMany()
                        .HasForeignKey("RoomId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("UMaTLMS.Core.Entities.Lecture", "SecondLecture")
                        .WithMany()
                        .HasForeignKey("SecondLectureId");

                    b.OwnsOne("UMaTLMS.SharedKernel.Audit", "Audit", b1 =>
                        {
                            b1.Property<int>("LectureScheduleId")
                                .HasColumnType("int");

                            b1.Property<DateTime>("CreatedAt")
                                .ValueGeneratedOnAdd()
                                .HasColumnType("datetime2")
                                .HasDefaultValue(new DateTime(2023, 7, 5, 11, 46, 58, 622, DateTimeKind.Utc).AddTicks(3091));

                            b1.Property<string>("CreatedBy")
                                .IsRequired()
                                .ValueGeneratedOnAdd()
                                .HasColumnType("nvarchar(max)")
                                .HasDefaultValue("admin");

                            b1.Property<string>("Status")
                                .IsRequired()
                                .HasColumnType("nvarchar(max)");

                            b1.Property<DateTime>("UpdatedAt")
                                .ValueGeneratedOnAdd()
                                .HasColumnType("datetime2")
                                .HasDefaultValue(new DateTime(2023, 7, 5, 11, 46, 58, 622, DateTimeKind.Utc).AddTicks(5136));

                            b1.Property<string>("UpdatedBy")
                                .IsRequired()
                                .ValueGeneratedOnAdd()
                                .HasColumnType("nvarchar(max)")
                                .HasDefaultValue("admin");

                            b1.HasKey("LectureScheduleId");

                            b1.ToTable("Schedules");

                            b1.WithOwner()
                                .HasForeignKey("LectureScheduleId");
                        });

                    b.Navigation("Audit");

                    b.Navigation("FirstLecture");

                    b.Navigation("Room");

                    b.Navigation("SecondLecture");
                });

            modelBuilder.Entity("UMaTLMS.Core.Entities.Lecturer", b =>
                {
                    b.OwnsOne("UMaTLMS.SharedKernel.Audit", "Audit", b1 =>
                        {
                            b1.Property<int>("LecturerId")
                                .HasColumnType("int");

                            b1.Property<DateTime>("CreatedAt")
                                .ValueGeneratedOnAdd()
                                .HasColumnType("datetime2")
                                .HasDefaultValue(new DateTime(2023, 7, 5, 11, 46, 58, 610, DateTimeKind.Utc).AddTicks(1542));

                            b1.Property<string>("CreatedBy")
                                .IsRequired()
                                .ValueGeneratedOnAdd()
                                .HasColumnType("nvarchar(max)")
                                .HasDefaultValue("admin");

                            b1.Property<string>("Status")
                                .IsRequired()
                                .HasColumnType("nvarchar(max)");

                            b1.Property<DateTime>("UpdatedAt")
                                .ValueGeneratedOnAdd()
                                .HasColumnType("datetime2")
                                .HasDefaultValue(new DateTime(2023, 7, 5, 11, 46, 58, 610, DateTimeKind.Utc).AddTicks(3506));

                            b1.Property<string>("UpdatedBy")
                                .IsRequired()
                                .ValueGeneratedOnAdd()
                                .HasColumnType("nvarchar(max)")
                                .HasDefaultValue("admin");

                            b1.HasKey("LecturerId");

                            b1.ToTable("Lecturers");

                            b1.WithOwner()
                                .HasForeignKey("LecturerId");
                        });

                    b.Navigation("Audit");
                });

            modelBuilder.Entity("UMaTLMS.Core.Entities.OnlineLectureSchedule", b =>
                {
                    b.OwnsOne("UMaTLMS.SharedKernel.Audit", "Audit", b1 =>
                        {
                            b1.Property<int>("OnlineLectureScheduleId")
                                .HasColumnType("int");

                            b1.Property<DateTime>("CreatedAt")
                                .ValueGeneratedOnAdd()
                                .HasColumnType("datetime2")
                                .HasDefaultValue(new DateTime(2023, 7, 5, 11, 46, 58, 632, DateTimeKind.Utc).AddTicks(5031));

                            b1.Property<string>("CreatedBy")
                                .IsRequired()
                                .ValueGeneratedOnAdd()
                                .HasColumnType("nvarchar(max)")
                                .HasDefaultValue("admin");

                            b1.Property<string>("Status")
                                .IsRequired()
                                .HasColumnType("nvarchar(max)");

                            b1.Property<DateTime>("UpdatedAt")
                                .ValueGeneratedOnAdd()
                                .HasColumnType("datetime2")
                                .HasDefaultValue(new DateTime(2023, 7, 5, 11, 46, 58, 632, DateTimeKind.Utc).AddTicks(6869));

                            b1.Property<string>("UpdatedBy")
                                .IsRequired()
                                .ValueGeneratedOnAdd()
                                .HasColumnType("nvarchar(max)")
                                .HasDefaultValue("admin");

                            b1.HasKey("OnlineLectureScheduleId");

                            b1.ToTable("OnlineSchedules");

                            b1.WithOwner()
                                .HasForeignKey("OnlineLectureScheduleId");
                        });

                    b.Navigation("Audit");
                });

            modelBuilder.Entity("UMaTLMS.Core.Entities.SubClassGroup", b =>
                {
                    b.HasOne("UMaTLMS.Core.Entities.ClassGroup", "Group")
                        .WithMany("SubClassGroups")
                        .HasForeignKey("GroupId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.OwnsOne("UMaTLMS.SharedKernel.Audit", "Audit", b1 =>
                        {
                            b1.Property<int>("SubClassGroupId")
                                .HasColumnType("int");

                            b1.Property<DateTime>("CreatedAt")
                                .ValueGeneratedOnAdd()
                                .HasColumnType("datetime2")
                                .HasDefaultValue(new DateTime(2023, 7, 5, 11, 46, 58, 652, DateTimeKind.Utc).AddTicks(9255));

                            b1.Property<string>("CreatedBy")
                                .IsRequired()
                                .ValueGeneratedOnAdd()
                                .HasColumnType("nvarchar(max)")
                                .HasDefaultValue("admin");

                            b1.Property<string>("Status")
                                .IsRequired()
                                .HasColumnType("nvarchar(max)");

                            b1.Property<DateTime>("UpdatedAt")
                                .ValueGeneratedOnAdd()
                                .HasColumnType("datetime2")
                                .HasDefaultValue(new DateTime(2023, 7, 5, 11, 46, 58, 653, DateTimeKind.Utc).AddTicks(682));

                            b1.Property<string>("UpdatedBy")
                                .IsRequired()
                                .ValueGeneratedOnAdd()
                                .HasColumnType("nvarchar(max)")
                                .HasDefaultValue("admin");

                            b1.HasKey("SubClassGroupId");

                            b1.ToTable("SubClassGroups");

                            b1.WithOwner()
                                .HasForeignKey("SubClassGroupId");
                        });

                    b.Navigation("Audit");

                    b.Navigation("Group");
                });

            modelBuilder.Entity("UMaTLMS.Core.Entities.ClassGroup", b =>
                {
                    b.Navigation("SubClassGroups");
                });

            modelBuilder.Entity("UMaTLMS.Core.Entities.OnlineLectureSchedule", b =>
                {
                    b.Navigation("Lectures");
                });
#pragma warning restore 612, 618
        }
    }
}
