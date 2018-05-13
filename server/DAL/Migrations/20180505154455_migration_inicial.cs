using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace DAL.Migrations
{
    public partial class migration_inicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Client",
                columns: table => new
                {
                    IdClient = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Bairro = table.Column<string>(nullable: false),
                    Cep = table.Column<string>(nullable: false),
                    Cidade = table.Column<string>(nullable: true),
                    Cpf = table.Column<string>(nullable: false),
                    DataCadastro = table.Column<DateTime>(nullable: false),
                    DataNascimento = table.Column<DateTime>(nullable: false),
                    Email = table.Column<string>(nullable: false),
                    Estado = table.Column<string>(nullable: true),
                    NomeRazaoSocial = table.Column<string>(nullable: true),
                    NumeroDaCasa = table.Column<int>(nullable: false),
                    PontoReferencia = table.Column<string>(nullable: true),
                    Rua = table.Column<string>(nullable: true),
                    Telefone = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Client", x => x.IdClient);
                });

            migrationBuilder.CreateTable(
                name: "Line",
                columns: table => new
                {
                    IdLine = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Nome = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Line", x => x.IdLine);
                });

            migrationBuilder.CreateTable(
                name: "Provider",
                columns: table => new
                {
                    IdProvider = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Cidade = table.Column<string>(nullable: true),
                    Cnpj = table.Column<string>(nullable: false),
                    Email = table.Column<string>(nullable: false),
                    Nome = table.Column<string>(nullable: true),
                    Responsavel = table.Column<string>(nullable: true),
                    Telefone = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Provider", x => x.IdProvider);
                });

            migrationBuilder.CreateTable(
                name: "Sector",
                columns: table => new
                {
                    IdSector = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    NivelAcesso = table.Column<int>(nullable: false),
                    Nome = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sector", x => x.IdSector);
                });

            migrationBuilder.CreateTable(
                name: "Series",
                columns: table => new
                {
                    IdSerie = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Nome = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Series", x => x.IdSerie);
                });

            migrationBuilder.CreateTable(
                name: "Product",
                columns: table => new
                {
                    IdProduct = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    CodigoBarra = table.Column<string>(nullable: true),
                    DataCadastro = table.Column<DateTime>(nullable: false),
                    DataEntrada = table.Column<DateTime>(nullable: false),
                    DataValidade = table.Column<DateTime>(nullable: false),
                    Desconto = table.Column<decimal>(nullable: false),
                    Estoque = table.Column<int>(nullable: false),
                    Icms = table.Column<decimal>(nullable: false),
                    IdLine = table.Column<int>(nullable: false),
                    IdProvider = table.Column<int>(nullable: false),
                    Lote = table.Column<string>(nullable: true),
                    Nome = table.Column<string>(nullable: false),
                    PrecoCompra = table.Column<double>(nullable: false),
                    PrecoVenda = table.Column<double>(nullable: false),
                    StatusProduct = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Product", x => x.IdProduct);
                    table.ForeignKey(
                        name: "FK_Product_Line_IdLine",
                        column: x => x.IdLine,
                        principalTable: "Line",
                        principalColumn: "IdLine",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Product_Provider_IdProvider",
                        column: x => x.IdProvider,
                        principalTable: "Provider",
                        principalColumn: "IdProvider",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Contribuitor",
                columns: table => new
                {
                    IdContribuitor = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Cpf = table.Column<string>(nullable: false),
                    DataCadastro = table.Column<DateTime>(nullable: false),
                    DataNascimento = table.Column<DateTime>(nullable: false),
                    IdSector = table.Column<int>(nullable: false),
                    Nome = table.Column<string>(nullable: true),
                    Senha = table.Column<string>(nullable: true),
                    Usuario = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contribuitor", x => x.IdContribuitor);
                    table.ForeignKey(
                        name: "FK_Contribuitor_Sector_IdSector",
                        column: x => x.IdSector,
                        principalTable: "Sector",
                        principalColumn: "IdSector",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Sale",
                columns: table => new
                {
                    IdSale = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    DataVenda = table.Column<DateTime>(nullable: false),
                    IdClient = table.Column<int>(nullable: false),
                    IdContribuitor = table.Column<int>(nullable: false),
                    TipoVenda = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sale", x => x.IdSale);
                    table.ForeignKey(
                        name: "FK_Sale_Client_IdClient",
                        column: x => x.IdClient,
                        principalTable: "Client",
                        principalColumn: "IdClient",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Sale_Contribuitor_IdContribuitor",
                        column: x => x.IdContribuitor,
                        principalTable: "Contribuitor",
                        principalColumn: "IdContribuitor",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProductSale",
                columns: table => new
                {
                    IdProduct = table.Column<int>(nullable: false),
                    IdSale = table.Column<int>(nullable: false),
                    SaleDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductSale", x => new { x.IdProduct, x.IdSale });
                    table.ForeignKey(
                        name: "FK_ProductSale_Product_IdProduct",
                        column: x => x.IdProduct,
                        principalTable: "Product",
                        principalColumn: "IdProduct",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProductSale_Sale_IdSale",
                        column: x => x.IdSale,
                        principalTable: "Sale",
                        principalColumn: "IdSale",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Contribuitor_IdSector",
                table: "Contribuitor",
                column: "IdSector");

            migrationBuilder.CreateIndex(
                name: "IX_Product_IdLine",
                table: "Product",
                column: "IdLine");

            migrationBuilder.CreateIndex(
                name: "IX_Product_IdProvider",
                table: "Product",
                column: "IdProvider");

            migrationBuilder.CreateIndex(
                name: "IX_ProductSale_IdSale",
                table: "ProductSale",
                column: "IdSale");

            migrationBuilder.CreateIndex(
                name: "IX_Sale_IdClient",
                table: "Sale",
                column: "IdClient");

            migrationBuilder.CreateIndex(
                name: "IX_Sale_IdContribuitor",
                table: "Sale",
                column: "IdContribuitor");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProductSale");

            migrationBuilder.DropTable(
                name: "Series");

            migrationBuilder.DropTable(
                name: "Product");

            migrationBuilder.DropTable(
                name: "Sale");

            migrationBuilder.DropTable(
                name: "Line");

            migrationBuilder.DropTable(
                name: "Provider");

            migrationBuilder.DropTable(
                name: "Client");

            migrationBuilder.DropTable(
                name: "Contribuitor");

            migrationBuilder.DropTable(
                name: "Sector");
        }
    }
}
