using ItMyTaskClean.Host.DI;

var builder = WebApplication.CreateBuilder(args);
//Вопросы
// 1.Почему у тебя все слои (5 проектов) создавались в одной  папке, а у меня в корневой папке, не в общей, а отдельно в каждой
// 
// 2.почему public Task AddAsync зарезервированное
// 3. почему var work = Work.Create( не ссылается на классы папки Repositories
// 4. что такое AsQueryable().
// 5. Где делал ручной  Map



// add-migration init
// update-database
//// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
////builder.Services.AddOpenApi();

builder.Services.ConfigureModule(builder.Configuration);

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    ////app.MapOpenApi();
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
