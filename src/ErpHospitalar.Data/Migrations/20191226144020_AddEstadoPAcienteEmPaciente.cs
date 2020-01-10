using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ErpHospitalar.Data.Migrations
{
    public partial class AddEstadoPAcienteEmPaciente : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            //migrationBuilder.AddColumn<Guid>(
            //    name: "EstadoPacienteId",
            //    table: "Pacientes",
            //    nullable: false,
            //    defaultValue: new Guid("746A9598-5134-4D8C-9EA7-11CEC0429834"));

            //migrationBuilder.CreateIndex(
            //    name: "IX_Pacientes_EstadoPacienteId",
            //    table: "Pacientes",
            //    column: "EstadoPacienteId");

            //migrationBuilder.AddForeignKey(
            //    name: "FK_Pacientes_EstadoPaciente_EstadoPacienteId",
            //    table: "Pacientes",
            //    column: "EstadoPacienteId",
            //    principalTable: "EstadoPaciente",
            //    principalColumn: "Id",
            //    onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            //migrationBuilder.DropForeignKey(
            //    name: "FK_Pacientes_EstadoPaciente_EstadoPacienteId",
            //    table: "Pacientes");

            //migrationBuilder.DropIndex(
            //    name: "IX_Pacientes_EstadoPacienteId",
            //    table: "Pacientes");

            //migrationBuilder.DropColumn(
            //    name: "EstadoPacienteId",
            //    table: "Pacientes");
        }
    }
}
