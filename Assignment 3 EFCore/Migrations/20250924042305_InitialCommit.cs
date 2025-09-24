using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Assignment_3_EFCore.Migrations
{
    /// <inheritdoc />
    public partial class InitialCommit : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Airline",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: true),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Cont_Person = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Airline", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "routes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Distance = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Destination = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Origin = table.Column<string>(type: "nvarchar(1)", nullable: false),
                    Classification = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_routes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Aircraft",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Capacity = table.Column<int>(type: "int", nullable: false),
                    Model = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Al_Id = table.Column<int>(type: "int", nullable: false),
                    crew_Maj_Pilot = table.Column<int>(type: "int", nullable: false),
                    crew_Assistant = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: true),
                    crew_Host1 = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: true),
                    crew_Host2 = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Aircraft", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Aircraft_Airline_Al_Id",
                        column: x => x.Al_Id,
                        principalTable: "Airline",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "airline_Phones",
                columns: table => new
                {
                    Al_Id = table.Column<int>(type: "int", nullable: false),
                    Phones = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_airline_Phones", x => new { x.Al_Id, x.Phones });
                    table.ForeignKey(
                        name: "FK_airline_Phones_Airline_Al_Id",
                        column: x => x.Al_Id,
                        principalTable: "Airline",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "employees",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: true),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Gender = table.Column<string>(type: "nvarchar(1)", nullable: false),
                    Position = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BD_Year = table.Column<string>(type: "nvarchar(4)", maxLength: 4, nullable: true),
                    BD_Month = table.Column<string>(type: "nvarchar(2)", maxLength: 2, nullable: true),
                    BD_Day = table.Column<string>(type: "nvarchar(2)", maxLength: 2, nullable: true),
                    Al_Id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_employees", x => x.Id);
                    table.ForeignKey(
                        name: "FK_employees_Airline_Al_Id",
                        column: x => x.Al_Id,
                        principalTable: "Airline",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "transactions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Amount = table.Column<int>(type: "int", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Al_Id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_transactions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_transactions_Airline_Al_Id",
                        column: x => x.Al_Id,
                        principalTable: "Airline",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "aircraft_Routes",
                columns: table => new
                {
                    AC_Id = table.Column<int>(type: "int", nullable: false),
                    Route_Id = table.Column<int>(type: "int", nullable: false),
                    Departure = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Num_Of_Pass = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Arrival = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_aircraft_Routes", x => new { x.AC_Id, x.Route_Id, x.Departure });
                    table.ForeignKey(
                        name: "FK_aircraft_Routes_Aircraft_AC_Id",
                        column: x => x.AC_Id,
                        principalTable: "Aircraft",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_aircraft_Routes_routes_Route_Id",
                        column: x => x.Route_Id,
                        principalTable: "routes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "emp_Qualifications",
                columns: table => new
                {
                    Emp_Id = table.Column<int>(type: "int", nullable: false),
                    Qualifications = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_emp_Qualifications", x => new { x.Emp_Id, x.Qualifications });
                    table.ForeignKey(
                        name: "FK_emp_Qualifications_employees_Emp_Id",
                        column: x => x.Emp_Id,
                        principalTable: "employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Aircraft_Al_Id",
                table: "Aircraft",
                column: "Al_Id");

            migrationBuilder.CreateIndex(
                name: "IX_aircraft_Routes_Route_Id",
                table: "aircraft_Routes",
                column: "Route_Id");

            migrationBuilder.CreateIndex(
                name: "IX_employees_Al_Id",
                table: "employees",
                column: "Al_Id");

            migrationBuilder.CreateIndex(
                name: "IX_transactions_Al_Id",
                table: "transactions",
                column: "Al_Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "aircraft_Routes");

            migrationBuilder.DropTable(
                name: "airline_Phones");

            migrationBuilder.DropTable(
                name: "emp_Qualifications");

            migrationBuilder.DropTable(
                name: "transactions");

            migrationBuilder.DropTable(
                name: "Aircraft");

            migrationBuilder.DropTable(
                name: "routes");

            migrationBuilder.DropTable(
                name: "employees");

            migrationBuilder.DropTable(
                name: "Airline");
        }
    }
}
