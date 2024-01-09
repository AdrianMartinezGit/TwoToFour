using TwoToFour.Services.AskQuestion;
using TwoToFour.Services.GreaterOrLess;
using TwoToFour.Services.TwoNumber;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped<ITwoNumberService, TwoNumberService>();
builder.Services.AddScoped<IAskQuestionService, AskQuestionService>();
builder.Services.AddScoped<IGreaterOrLessService, GreaterOrLessService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
