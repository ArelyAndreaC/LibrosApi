var builder = WebApplication.CreateBuilder(args);

// 1. Agrega el servicio de CORS
builder.Services.AddCors(options =>
{
    options.AddPolicy("PermitirTodo", policy =>
    {
        policy.AllowAnyOrigin()
              .AllowAnyHeader()
              .AllowAnyMethod();
    });
});
// 2. IMPORTANTE: Asegúrate de que esta línea esté para que los controladores funcionen
builder.Services.AddControllers();
// Add services to the container.
builder.Services.AddRazorPages();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

// 3. Activa CORS antes de MapControllers
app.UseCors("PermitirTodo");

app.UseAuthorization();

app.MapRazorPages();

// 4. Mapea los controladores de la API
app.MapControllers();

app.Run();
