using EmployeeManagment.Application.Commans.Interfaces;
using EmployeeManagment.Infrastrucure.Data;
using EmployeeManagment.Infrastrucure.Reprosatories;
using EmployeeMangement.Domain.Entites;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<ApplicationDBContext>(Options=>Options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));
<<<<<<< HEAD
builder.Services.AddScoped<IEmployeeRepository,EmployeeRepository>();
builder.Services.AddScoped<IDepartmentRepository, DepartmentReprosatory>();
=======
builder.Services.AddScoped<IRepository<Employee>, Repository<Employee>>();
builder.Services.AddScoped<IRepository<Department>, Repository<Department>>();
>>>>>>> 1aa9086310bf90505f47d71b83a044c9ea686935
builder.Services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
//builder.Services.AddScoped<IRepository, Repository>();
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
