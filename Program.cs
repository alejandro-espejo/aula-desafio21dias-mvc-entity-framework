using Microsoft.EntityFrameworkCore;
using mvc_entity.Servicos;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
// Adicionado por mim
string strCon = builder.Configuration.GetConnectionString("MinhaConexao");
builder.Services.AddDbContext<DbContexto>(options => options.UseSqlServer(strCon));
builder.Services.AddControllersWithViews();
// conexão windows Integrated Security=SSPI;Persist Security Info=False;User ID=sa;Initial Catalog=desafio21diasapi;Data Source=HOME\SQLEXPRESS
// conexão linux server=localhost;database=desafio21EFMVC;user=sa;password=;

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
