// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using StudentManagement.Api.Data;

#nullable disable

namespace StudentManagement.Api.Migrations
{
    [DbContext(typeof(StudentDbContext))]
    [Migration("20220918142335_ChangeInDataTable")]
    partial class ChangeInDataTable
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("StudentManagement.Api.Entities.Student", b =>
                {
                    b.Property<string>("RollNumber")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Class")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Dob")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("RollNumber");

                    b.ToTable("Students");

                    b.HasData(
                        new
                        {
                            RollNumber = "8A123",
                            Class = "VIII",
                            Dob = "11-09-2002",
                            Name = "Mugesh"
                        },
                        new
                        {
                            RollNumber = "9A124",
                            Class = "IX",
                            Dob = "05-09-2001",
                            Name = "Prakash"
                        },
                        new
                        {
                            RollNumber = "11A125",
                            Class = "XI",
                            Dob = "17-12-2000",
                            Name = "Sagar"
                        });
                });

            modelBuilder.Entity("StudentManagement.Api.Entities.StudentMarks", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("English")
                        .HasColumnType("int");

                    b.Property<int>("Maths")
                        .HasColumnType("int");

                    b.Property<string>("RollNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Science")
                        .HasColumnType("int");

                    b.Property<int>("Social")
                        .HasColumnType("int");

                    b.Property<int>("Tamil")
                        .HasColumnType("int");

                    b.Property<int>("TotalMarks")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("StudentMarks");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            English = 95,
                            Maths = 95,
                            RollNumber = "8A123",
                            Science = 95,
                            Social = 95,
                            Tamil = 95,
                            TotalMarks = 475
                        },
                        new
                        {
                            Id = 2,
                            English = 90,
                            Maths = 90,
                            RollNumber = "9A124",
                            Science = 90,
                            Social = 90,
                            Tamil = 90,
                            TotalMarks = 450
                        },
                        new
                        {
                            Id = 3,
                            English = 85,
                            Maths = 85,
                            RollNumber = "11A125",
                            Science = 85,
                            Social = 85,
                            Tamil = 85,
                            TotalMarks = 425
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
