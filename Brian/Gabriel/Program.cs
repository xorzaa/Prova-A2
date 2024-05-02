using System.ComponentModel.DataAnnotations;
using Gabriel.Models;
using Microsoft.AspNetCore.Mvc;

internal class Program
{
    private static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        builder.Services.AddEndpointsApiExplorer();
        builder.Services.AddSwaggerGen();

        builder.Services.AddDbContext<AppDbContext>();

        var app = builder.Build();

        List<Funcionario> funcionarios = [
            new Funcionario("Gabriel", "123.904.791-22"),
            new Funcionario("Brian", "112.389.927-14")
        ];

        app.MapGet("/", () => "API de Funcionários");
        app.MapPost("/funcionario/cadastrar", ([FromBody] Funcionario funcionario, [FromServices] AppDbContext ctx) =>
        {
            ctx.Funcionarios.Add(funcionario);
            ctx.SaveChanges();
            return Results.Created("", funcionario);
        });

        app.MapGet("/funcionario/listar", ([FromServices] AppDbContext ctx) =>
        {
            if (ctx.Funcionarios.Any())
            {
                return Results.Ok("ctx.Funcionarios.Tolist()");
            }
            return Results.NotFound("Não existem funcionario");
        });
         app.MapPost("/folha/cadastrar", ([FromBody] Folha folha, [FromServices] AppDbContext ctx) =>
        {
            ctx.Folha.Add(folha);
            ctx.SaveChanges();
            return Results.Created("", folha);
        });
        app.MapGet("/folha/listar", ([FromServices] AppDbContext ctx) =>
        {
            if (ctx.folha.Any())
            {
                return Results.Ok("ctx.Folha.Tolist()");
            }
            return Results.NotFound("Não existem folhas de pagamentos");
        }
        );
        app.MapGet("/folha/buscar/{id}", ([FromRoute] string id, [FromServices] AppDbContext ctx) =>{
            Folha? folha = ctx.Folha.Find(id);
            if(folha is null){
                return Results.NotFound("Folha não encontrada!");
            }
            return Results.Ok(folha);
        }
        );
        app.Run();
    }
}