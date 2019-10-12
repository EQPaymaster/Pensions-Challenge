﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Pensions.Persistence.DbContexts;

namespace Pensions.Persistence.Migrations
{
    [DbContext(typeof(PensionsContext))]
    partial class PensionsContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Pensions.Persistence.Entities.Accrual", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("EffectiveDate");

                    b.Property<float>("Rate");

                    b.HasKey("Id");

                    b.HasAlternateKey("EffectiveDate");

                    b.ToTable("Accrual");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            EffectiveDate = new DateTime(1950, 4, 6, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Rate = 50f
                        },
                        new
                        {
                            Id = 2,
                            EffectiveDate = new DateTime(2000, 4, 6, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Rate = 80f
                        },
                        new
                        {
                            Id = 3,
                            EffectiveDate = new DateTime(2015, 4, 6, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Rate = 125f
                        });
                });

            modelBuilder.Entity("Pensions.Persistence.Entities.Address", b =>
                {
                    b.Property<int>("BasicId");

                    b.Property<string>("Country");

                    b.Property<string>("County");

                    b.Property<string>("HouseName");

                    b.Property<string>("PostCode");

                    b.Property<string>("Street");

                    b.Property<string>("Town");

                    b.HasKey("BasicId");

                    b.ToTable("Address");

                    b.HasData(
                        new
                        {
                            BasicId = 1,
                            Country = "United Kingdom",
                            County = "West Sussex",
                            HouseName = "Sutherland House",
                            PostCode = "RH10 1UH",
                            Street = "Russell Way",
                            Town = "Crawley"
                        },
                        new
                        {
                            BasicId = 2,
                            Country = "United Kingdom",
                            County = "West Sussex",
                            HouseName = "Sutherland House",
                            PostCode = "RH10 1UH",
                            Street = "Russell Way",
                            Town = "Crawley"
                        },
                        new
                        {
                            BasicId = 3,
                            Country = "United Kingdom",
                            County = "West Sussex",
                            HouseName = "Sutherland House",
                            PostCode = "RH10 1UH",
                            Street = "Russell Way",
                            Town = "Crawley"
                        },
                        new
                        {
                            BasicId = 4,
                            Country = "United Kingdom",
                            County = "West Sussex",
                            HouseName = "Sutherland House",
                            PostCode = "RH10 1UH",
                            Street = "Russell Way",
                            Town = "Crawley"
                        });
                });

            modelBuilder.Entity("Pensions.Persistence.Entities.Basic", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DateOfBirth");

                    b.Property<string>("Forename")
                        .IsRequired();

                    b.Property<string>("Surname")
                        .IsRequired();

                    b.Property<string>("Title")
                        .IsRequired();

                    b.HasKey("Id");

                    b.ToTable("Basic");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            DateOfBirth = new DateTime(1969, 11, 12, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Forename = "Michael",
                            Surname = "Cole",
                            Title = "Mr"
                        },
                        new
                        {
                            Id = 2,
                            DateOfBirth = new DateTime(1981, 1, 31, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Forename = "Elizabeth",
                            Surname = "Wright",
                            Title = "Mrs"
                        },
                        new
                        {
                            Id = 3,
                            DateOfBirth = new DateTime(1993, 5, 7, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Forename = "Daniel",
                            Surname = "Rose",
                            Title = "Mr"
                        },
                        new
                        {
                            Id = 4,
                            DateOfBirth = new DateTime(1956, 12, 16, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Forename = "Pauline",
                            Surname = "Roberts",
                            Title = "Mrs"
                        });
                });

            modelBuilder.Entity("Pensions.Persistence.Entities.Salary", b =>
                {
                    b.Property<int>("BasicId");

                    b.Property<DateTime>("EffectiveDate");

                    b.Property<double>("Value");

                    b.HasKey("BasicId", "EffectiveDate");

                    b.ToTable("SalaryHistory");

                    b.HasData(
                        new
                        {
                            BasicId = 1,
                            EffectiveDate = new DateTime(1990, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Value = 13760.0
                        },
                        new
                        {
                            BasicId = 1,
                            EffectiveDate = new DateTime(1991, 4, 6, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Value = 14128.219999999999
                        },
                        new
                        {
                            BasicId = 1,
                            EffectiveDate = new DateTime(1992, 4, 6, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Value = 14506.290000000001
                        },
                        new
                        {
                            BasicId = 1,
                            EffectiveDate = new DateTime(1993, 4, 6, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Value = 14894.48
                        },
                        new
                        {
                            BasicId = 1,
                            EffectiveDate = new DateTime(1994, 4, 6, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Value = 15293.059999999999
                        },
                        new
                        {
                            BasicId = 1,
                            EffectiveDate = new DateTime(1995, 4, 6, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Value = 15702.299999999999
                        },
                        new
                        {
                            BasicId = 1,
                            EffectiveDate = new DateTime(1996, 4, 6, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Value = 16122.49
                        },
                        new
                        {
                            BasicId = 1,
                            EffectiveDate = new DateTime(1997, 4, 6, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Value = 16553.93
                        },
                        new
                        {
                            BasicId = 1,
                            EffectiveDate = new DateTime(1998, 4, 6, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Value = 16996.91
                        },
                        new
                        {
                            BasicId = 1,
                            EffectiveDate = new DateTime(1999, 4, 6, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Value = 17451.75
                        },
                        new
                        {
                            BasicId = 1,
                            EffectiveDate = new DateTime(2000, 4, 6, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Value = 17918.759999999998
                        },
                        new
                        {
                            BasicId = 1,
                            EffectiveDate = new DateTime(2001, 4, 6, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Value = 18398.27
                        },
                        new
                        {
                            BasicId = 1,
                            EffectiveDate = new DateTime(2002, 4, 6, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Value = 18890.610000000001
                        },
                        new
                        {
                            BasicId = 1,
                            EffectiveDate = new DateTime(2003, 4, 6, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Value = 19396.119999999999
                        },
                        new
                        {
                            BasicId = 1,
                            EffectiveDate = new DateTime(2004, 4, 6, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Value = 19915.16
                        },
                        new
                        {
                            BasicId = 1,
                            EffectiveDate = new DateTime(2005, 4, 6, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Value = 20448.09
                        },
                        new
                        {
                            BasicId = 1,
                            EffectiveDate = new DateTime(2006, 4, 6, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Value = 20995.279999999999
                        },
                        new
                        {
                            BasicId = 1,
                            EffectiveDate = new DateTime(2007, 4, 6, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Value = 21557.110000000001
                        },
                        new
                        {
                            BasicId = 1,
                            EffectiveDate = new DateTime(2008, 4, 6, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Value = 22133.98
                        },
                        new
                        {
                            BasicId = 1,
                            EffectiveDate = new DateTime(2009, 4, 6, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Value = 22726.290000000001
                        },
                        new
                        {
                            BasicId = 1,
                            EffectiveDate = new DateTime(2010, 4, 6, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Value = 23334.450000000001
                        },
                        new
                        {
                            BasicId = 1,
                            EffectiveDate = new DateTime(2011, 4, 6, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Value = 23958.880000000001
                        },
                        new
                        {
                            BasicId = 1,
                            EffectiveDate = new DateTime(2012, 4, 6, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Value = 24600.02
                        },
                        new
                        {
                            BasicId = 1,
                            EffectiveDate = new DateTime(2013, 4, 6, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Value = 25258.32
                        },
                        new
                        {
                            BasicId = 1,
                            EffectiveDate = new DateTime(2014, 4, 6, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Value = 25934.23
                        },
                        new
                        {
                            BasicId = 1,
                            EffectiveDate = new DateTime(2015, 4, 6, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Value = 26628.23
                        },
                        new
                        {
                            BasicId = 1,
                            EffectiveDate = new DateTime(2016, 4, 6, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Value = 27340.799999999999
                        },
                        new
                        {
                            BasicId = 1,
                            EffectiveDate = new DateTime(2017, 4, 6, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Value = 28072.439999999999
                        },
                        new
                        {
                            BasicId = 1,
                            EffectiveDate = new DateTime(2018, 4, 6, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Value = 28823.66
                        },
                        new
                        {
                            BasicId = 1,
                            EffectiveDate = new DateTime(2019, 4, 6, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Value = 29594.98
                        },
                        new
                        {
                            BasicId = 2,
                            EffectiveDate = new DateTime(2004, 12, 6, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Value = 23000.0
                        },
                        new
                        {
                            BasicId = 2,
                            EffectiveDate = new DateTime(2014, 3, 12, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Value = 26540.0
                        },
                        new
                        {
                            BasicId = 3,
                            EffectiveDate = new DateTime(2012, 6, 6, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Value = 100762.11
                        },
                        new
                        {
                            BasicId = 3,
                            EffectiveDate = new DateTime(2013, 4, 6, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Value = 90000.270000000004
                        },
                        new
                        {
                            BasicId = 4,
                            EffectiveDate = new DateTime(1977, 2, 28, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Value = 15032.99
                        },
                        new
                        {
                            BasicId = 4,
                            EffectiveDate = new DateTime(2007, 8, 12, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Value = 33012.199999999997
                        });
                });

            modelBuilder.Entity("Pensions.Persistence.Entities.Scheme", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Scheme");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Equiniti Scheme 1"
                        });
                });

            modelBuilder.Entity("Pensions.Persistence.Entities.Service", b =>
                {
                    b.Property<int>("BasicId");

                    b.Property<DateTime>("StartDate");

                    b.Property<DateTime?>("EndDate");

                    b.Property<int>("SchemeId");

                    b.HasKey("BasicId", "StartDate");

                    b.HasIndex("SchemeId");

                    b.ToTable("ServiceHistory");

                    b.HasData(
                        new
                        {
                            BasicId = 1,
                            StartDate = new DateTime(1990, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            SchemeId = 1
                        },
                        new
                        {
                            BasicId = 2,
                            StartDate = new DateTime(2004, 12, 6, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            EndDate = new DateTime(2009, 1, 22, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            SchemeId = 1
                        },
                        new
                        {
                            BasicId = 2,
                            StartDate = new DateTime(2014, 3, 12, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            SchemeId = 1
                        },
                        new
                        {
                            BasicId = 3,
                            StartDate = new DateTime(2012, 6, 6, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            EndDate = new DateTime(2016, 10, 3, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            SchemeId = 1
                        },
                        new
                        {
                            BasicId = 4,
                            StartDate = new DateTime(1977, 2, 28, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            EndDate = new DateTime(1985, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            SchemeId = 1
                        },
                        new
                        {
                            BasicId = 4,
                            StartDate = new DateTime(1996, 5, 5, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            EndDate = new DateTime(2008, 9, 14, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            SchemeId = 1
                        });
                });

            modelBuilder.Entity("Pensions.Persistence.Entities.Address", b =>
                {
                    b.HasOne("Pensions.Persistence.Entities.Basic", "Basic")
                        .WithOne("Address")
                        .HasForeignKey("Pensions.Persistence.Entities.Address", "BasicId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Pensions.Persistence.Entities.Salary", b =>
                {
                    b.HasOne("Pensions.Persistence.Entities.Basic", "Basic")
                        .WithMany("SalaryHistory")
                        .HasForeignKey("BasicId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Pensions.Persistence.Entities.Service", b =>
                {
                    b.HasOne("Pensions.Persistence.Entities.Basic", "Basic")
                        .WithMany("ServiceHistory")
                        .HasForeignKey("BasicId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Pensions.Persistence.Entities.Scheme", "Scheme")
                        .WithMany()
                        .HasForeignKey("SchemeId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}