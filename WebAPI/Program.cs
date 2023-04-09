using Business.DependecyResolvers;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


#region MyRegion
//Allow Origin hatas�
builder.Services.AddCors();



builder.Services.AddPersistenceServices();
#endregion
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

//No 'Access-Control-Allow-Origin' hatas� ��z�m� 14.sat�r devam�
app.UseCors(builder=>builder.WithOrigins("http://localhost:4200").AllowAnyHeader());//14.sat�r 
app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
//Add Cors