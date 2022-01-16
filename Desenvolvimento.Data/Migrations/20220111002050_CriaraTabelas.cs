using Microsoft.EntityFrameworkCore.Migrations;

namespace Desenvolvimento.Data.Migrations
{
    public partial class CriaraTabelas : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "tb_Login",
                columns: table => new
                {
                    IdLogin = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Usuario = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Senha = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Perfil = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tb_Login", x => x.IdLogin);
                });

            migrationBuilder.CreateTable(
                name: "tb_Administrador",
                columns: table => new
                {
                    IdAdm = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NomeAdm = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmailAdm = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Id_Login = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tb_Administrador", x => x.IdAdm);
                    table.ForeignKey(
                        name: "FK_tb_Administrador_tb_Login_Id_Login",
                        column: x => x.Id_Login,
                        principalTable: "tb_Login",
                        principalColumn: "IdLogin",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tb_Cliente",
                columns: table => new
                {
                    IdCliente = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NomeCliente = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmailCliente = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SexoCliente = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Id_Login = table.Column<int>(type: "int", nullable: false),
                    Id_Cliente = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tb_Cliente", x => x.IdCliente);
                    table.ForeignKey(
                        name: "FK_tb_Cliente_tb_Login_Id_Cliente",
                        column: x => x.Id_Cliente,
                        principalTable: "tb_Login",
                        principalColumn: "IdLogin",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "tb_Endereco",
                columns: table => new
                {
                    IdEndereco = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Logradouro = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Complemnto = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Bairro = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Cidade = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Uf = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Id_Cliente = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tb_Endereco", x => x.IdEndereco);
                    table.ForeignKey(
                        name: "FK_tb_Endereco_tb_Cliente_Id_Cliente",
                        column: x => x.Id_Cliente,
                        principalTable: "tb_Cliente",
                        principalColumn: "IdCliente",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tb_Loja",
                columns: table => new
                {
                    IdLoja = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NomeLoja = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Id_Cliente = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tb_Loja", x => x.IdLoja);
                    table.ForeignKey(
                        name: "FK_tb_Loja_tb_Cliente_Id_Cliente",
                        column: x => x.Id_Cliente,
                        principalTable: "tb_Cliente",
                        principalColumn: "IdCliente",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tb_Produto",
                columns: table => new
                {
                    IdProduto = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NomeProd = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DescricaqoProd = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Id_Loja = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tb_Produto", x => x.IdProduto);
                    table.ForeignKey(
                        name: "FK_tb_Produto_tb_Loja_Id_Loja",
                        column: x => x.Id_Loja,
                        principalTable: "tb_Loja",
                        principalColumn: "IdLoja",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tb_Pagamento",
                columns: table => new
                {
                    IdPagamento = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PrecoPagamento = table.Column<float>(type: "real", nullable: false),
                    QtdePagamento = table.Column<int>(type: "int", nullable: false),
                    Id_Produto = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tb_Pagamento", x => x.IdPagamento);
                    table.ForeignKey(
                        name: "FK_tb_Pagamento_tb_Produto_Id_Produto",
                        column: x => x.Id_Produto,
                        principalTable: "tb_Produto",
                        principalColumn: "IdProduto",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_tb_Administrador_Id_Login",
                table: "tb_Administrador",
                column: "Id_Login");

            migrationBuilder.CreateIndex(
                name: "IX_tb_Cliente_Id_Cliente",
                table: "tb_Cliente",
                column: "Id_Cliente");

            migrationBuilder.CreateIndex(
                name: "IX_tb_Endereco_Id_Cliente",
                table: "tb_Endereco",
                column: "Id_Cliente");

            migrationBuilder.CreateIndex(
                name: "IX_tb_Loja_Id_Cliente",
                table: "tb_Loja",
                column: "Id_Cliente");

            migrationBuilder.CreateIndex(
                name: "IX_tb_Pagamento_Id_Produto",
                table: "tb_Pagamento",
                column: "Id_Produto");

            migrationBuilder.CreateIndex(
                name: "IX_tb_Produto_Id_Loja",
                table: "tb_Produto",
                column: "Id_Loja");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "tb_Administrador");

            migrationBuilder.DropTable(
                name: "tb_Endereco");

            migrationBuilder.DropTable(
                name: "tb_Pagamento");

            migrationBuilder.DropTable(
                name: "tb_Produto");

            migrationBuilder.DropTable(
                name: "tb_Loja");

            migrationBuilder.DropTable(
                name: "tb_Cliente");

            migrationBuilder.DropTable(
                name: "tb_Login");
        }
    }
}
