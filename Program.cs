using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<Contexto>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("FoodTracker"));
});

var app = builder.Build();

app.MapGet("/listar", async (Contexto contexto) =>
{
    var produtos = await contexto.Produto.ToListAsync();
    return Results.Ok(produtos);
});

app.MapPost("/adicionar", async (Produto produto, Contexto contexto) =>
{
    contexto.Produto.Add(produto);
    await contexto.SaveChangesAsync();
    return Results.Ok();
});

app.MapPut("/atualizar/{id}", async (int id, Produto produto, Contexto contexto) =>
{
    var produto_existe = await contexto.Produto.FindAsync(id);

    if (produto_existe == null)
        return Results.NotFound();

    produto_existe.Nome = produto.Nome;
    produto_existe.Validade = produto.Validade;
    produto_existe.Preco = produto.Preco;

    await contexto.SaveChangesAsync();
    return Results.Ok();

});

app.MapDelete("/deletar/{id}", async(int id, Contexto contexto) => 
{
    var produto_existe = await contexto.Produto.FindAsync(id);

    if (produto_existe == null)
        return Results.NotFound();

    contexto.Produto.Remove(produto_existe);
    await contexto.SaveChangesAsync();

    return Results.Ok();
});

app.Run();
