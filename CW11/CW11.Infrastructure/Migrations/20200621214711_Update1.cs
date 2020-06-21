using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CW11.Infrastructure.Migrations
{
    public partial class Update1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PrescriptionMedicament_Medicament_MedicamentIdMedicament",
                table: "PrescriptionMedicament");

            migrationBuilder.DropForeignKey(
                name: "FK_PrescriptionMedicament_Prescriptions_PrescriptionIdPrescription",
                table: "PrescriptionMedicament");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PrescriptionMedicament",
                table: "PrescriptionMedicament");

            migrationBuilder.DropIndex(
                name: "IX_PrescriptionMedicament_MedicamentIdMedicament",
                table: "PrescriptionMedicament");

            migrationBuilder.DropIndex(
                name: "IX_PrescriptionMedicament_PrescriptionIdPrescription",
                table: "PrescriptionMedicament");

            migrationBuilder.DropColumn(
                name: "IdMedicament",
                table: "PrescriptionMedicament");

            migrationBuilder.DropColumn(
                name: "IdPrescription",
                table: "PrescriptionMedicament");

            migrationBuilder.DropColumn(
                name: "MedicamentIdMedicament",
                table: "PrescriptionMedicament");

            migrationBuilder.DropColumn(
                name: "PrescriptionIdPrescription",
                table: "PrescriptionMedicament");

            migrationBuilder.AddColumn<int>(
                name: "MedicamentId",
                table: "PrescriptionMedicament",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "PrescriptionId",
                table: "PrescriptionMedicament",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_PrescriptionMedicament",
                table: "PrescriptionMedicament",
                columns: new[] { "MedicamentId", "PrescriptionId" });

            migrationBuilder.InsertData(
                table: "Doctors",
                columns: new[] { "IdDoctor", "Email", "FirstName", "LastName" },
                values: new object[,]
                {
                    { -1, "mail@mail.com", "Jan", "Kowalski" },
                    { -2, "p.zak@gmail.com", "Przemyslaw", "Zakala" },
                    { -3, "pulpet@hotmail.com", "Jaroslaw", "Pulpet" }
                });

            migrationBuilder.InsertData(
                table: "Medicament",
                columns: new[] { "IdMedicament", "Description", "Name", "Type" },
                values: new object[,]
                {
                    { -1, " 100 mg", "wit. c", "powlekane" },
                    { -2, " 1000 mg", "wit. d", "kapsulka" },
                    { -3, "steryd", "metmin", "aerozol" }
                });

            migrationBuilder.InsertData(
                table: "Patients",
                columns: new[] { "IdPatient", "BirthDate", "FirstName", "LastName" },
                values: new object[,]
                {
                    { -1, new DateTime(2010, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Jan", "Kowalski" },
                    { -2, new DateTime(2000, 3, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bolek", "Dom" },
                    { -3, new DateTime(1980, 12, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Lolek", "Cis" }
                });

            migrationBuilder.InsertData(
                table: "Prescriptions",
                columns: new[] { "IdPrescription", "Date", "DoctorIdDoctor", "DueDate", "PatientIdPatient" },
                values: new object[] { -1, new DateTime(2020, 6, 21, 21, 47, 10, 718, DateTimeKind.Utc).AddTicks(5556), -1, new DateTime(2020, 6, 23, 21, 47, 10, 718, DateTimeKind.Utc).AddTicks(5566), -1 });

            migrationBuilder.InsertData(
                table: "Prescriptions",
                columns: new[] { "IdPrescription", "Date", "DoctorIdDoctor", "DueDate", "PatientIdPatient" },
                values: new object[] { -2, new DateTime(2020, 6, 21, 21, 47, 10, 718, DateTimeKind.Utc).AddTicks(6528), -2, new DateTime(2020, 6, 23, 21, 47, 10, 718, DateTimeKind.Utc).AddTicks(6532), -1 });

            migrationBuilder.InsertData(
                table: "Prescriptions",
                columns: new[] { "IdPrescription", "Date", "DoctorIdDoctor", "DueDate", "PatientIdPatient" },
                values: new object[] { -3, new DateTime(2020, 6, 21, 21, 47, 10, 718, DateTimeKind.Utc).AddTicks(6589), -1, new DateTime(2020, 6, 25, 21, 47, 10, 718, DateTimeKind.Utc).AddTicks(6590), -3 });

            migrationBuilder.InsertData(
                table: "PrescriptionMedicament",
                columns: new[] { "MedicamentId", "PrescriptionId", "Details", "Dose" },
                values: new object[] { -3, -1, "", null });

            migrationBuilder.InsertData(
                table: "PrescriptionMedicament",
                columns: new[] { "MedicamentId", "PrescriptionId", "Details", "Dose" },
                values: new object[] { -1, -2, "codziennie", 3 });

            migrationBuilder.InsertData(
                table: "PrescriptionMedicament",
                columns: new[] { "MedicamentId", "PrescriptionId", "Details", "Dose" },
                values: new object[] { -2, -3, "dwa razy dziennie", 4 });

            migrationBuilder.CreateIndex(
                name: "IX_PrescriptionMedicament_PrescriptionId",
                table: "PrescriptionMedicament",
                column: "PrescriptionId");

            migrationBuilder.AddForeignKey(
                name: "FK_PrescriptionMedicament_Medicament_MedicamentId",
                table: "PrescriptionMedicament",
                column: "MedicamentId",
                principalTable: "Medicament",
                principalColumn: "IdMedicament",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PrescriptionMedicament_Prescriptions_PrescriptionId",
                table: "PrescriptionMedicament",
                column: "PrescriptionId",
                principalTable: "Prescriptions",
                principalColumn: "IdPrescription",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PrescriptionMedicament_Medicament_MedicamentId",
                table: "PrescriptionMedicament");

            migrationBuilder.DropForeignKey(
                name: "FK_PrescriptionMedicament_Prescriptions_PrescriptionId",
                table: "PrescriptionMedicament");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PrescriptionMedicament",
                table: "PrescriptionMedicament");

            migrationBuilder.DropIndex(
                name: "IX_PrescriptionMedicament_PrescriptionId",
                table: "PrescriptionMedicament");

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "IdDoctor",
                keyValue: -3);

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "IdPatient",
                keyValue: -2);

            migrationBuilder.DeleteData(
                table: "PrescriptionMedicament",
                keyColumns: new[] { "MedicamentId", "PrescriptionId" },
                keyValues: new object[] { -3, -1 });

            migrationBuilder.DeleteData(
                table: "PrescriptionMedicament",
                keyColumns: new[] { "MedicamentId", "PrescriptionId" },
                keyValues: new object[] { -2, -3 });

            migrationBuilder.DeleteData(
                table: "PrescriptionMedicament",
                keyColumns: new[] { "MedicamentId", "PrescriptionId" },
                keyValues: new object[] { -1, -2 });

            migrationBuilder.DeleteData(
                table: "Medicament",
                keyColumn: "IdMedicament",
                keyValue: -3);

            migrationBuilder.DeleteData(
                table: "Medicament",
                keyColumn: "IdMedicament",
                keyValue: -2);

            migrationBuilder.DeleteData(
                table: "Medicament",
                keyColumn: "IdMedicament",
                keyValue: -1);

            migrationBuilder.DeleteData(
                table: "Prescriptions",
                keyColumn: "IdPrescription",
                keyValue: -3);

            migrationBuilder.DeleteData(
                table: "Prescriptions",
                keyColumn: "IdPrescription",
                keyValue: -2);

            migrationBuilder.DeleteData(
                table: "Prescriptions",
                keyColumn: "IdPrescription",
                keyValue: -1);

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "IdDoctor",
                keyValue: -2);

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "IdDoctor",
                keyValue: -1);

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "IdPatient",
                keyValue: -3);

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "IdPatient",
                keyValue: -1);

            migrationBuilder.DropColumn(
                name: "MedicamentId",
                table: "PrescriptionMedicament");

            migrationBuilder.DropColumn(
                name: "PrescriptionId",
                table: "PrescriptionMedicament");

            migrationBuilder.AddColumn<int>(
                name: "IdMedicament",
                table: "PrescriptionMedicament",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "IdPrescription",
                table: "PrescriptionMedicament",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "MedicamentIdMedicament",
                table: "PrescriptionMedicament",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PrescriptionIdPrescription",
                table: "PrescriptionMedicament",
                type: "int",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_PrescriptionMedicament",
                table: "PrescriptionMedicament",
                columns: new[] { "IdMedicament", "IdPrescription" });

            migrationBuilder.CreateIndex(
                name: "IX_PrescriptionMedicament_MedicamentIdMedicament",
                table: "PrescriptionMedicament",
                column: "MedicamentIdMedicament");

            migrationBuilder.CreateIndex(
                name: "IX_PrescriptionMedicament_PrescriptionIdPrescription",
                table: "PrescriptionMedicament",
                column: "PrescriptionIdPrescription");

            migrationBuilder.AddForeignKey(
                name: "FK_PrescriptionMedicament_Medicament_MedicamentIdMedicament",
                table: "PrescriptionMedicament",
                column: "MedicamentIdMedicament",
                principalTable: "Medicament",
                principalColumn: "IdMedicament",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PrescriptionMedicament_Prescriptions_PrescriptionIdPrescription",
                table: "PrescriptionMedicament",
                column: "PrescriptionIdPrescription",
                principalTable: "Prescriptions",
                principalColumn: "IdPrescription",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
