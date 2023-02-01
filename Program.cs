using api_biblia.Middlewares;
using api_biblia.Services;
using api_biblia.Services.Criar;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped<BuscarCapituloService>();
builder.Services.AddScoped<BuscarLivroService>();
builder.Services.AddScoped<BuscarLivrosService>();
builder.Services.AddScoped<BuscarVersiculoAleatorioService>();
builder.Services.AddScoped<BuscarVersiculoService>();
builder.Services.AddScoped<BuscarVersoesService>();
builder.Services.AddScoped<PesquisarPalavrasService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseMiddleware(typeof(GlobalErrorHandlingMiddleware));

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
