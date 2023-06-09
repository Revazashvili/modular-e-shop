var builder = WebApplication.CreateBuilder(args);

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

app.UseSwagger();
app.UseSwaggerUI();

app.UseHttpsRedirection();

app.MapGet("/", context =>
{
    context.Response.Redirect("swagger");
    return Task.CompletedTask;
});

app.MapGet("/ping", () => "pong");

await app.RunAsync();