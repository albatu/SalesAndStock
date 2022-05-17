
using Blazor2.ViewOperation.Interfaces;
using Blazor2.ViewOperation.Managers;
using Business.Interfaces;
using Business.Managers;
using DataAccess.DataAccess;
using DataAccess.Helpers;
using DataAccess.Interfaces;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using Radzen;

var builder = WebApplication.CreateBuilder(args);
#region Components Injections
builder.Services.AddScoped<DialogService>();
builder.Services.AddScoped<NotificationService>();
builder.Services.AddScoped<TooltipService>();
builder.Services.AddScoped<ContextMenuService>();
#endregion
#region Blazor configurations
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();
#endregion
#region Helper
builder.Services.AddScoped<SQLDbHelper>();
#endregion
#region Dal
builder.Services.AddScoped<IBillDal, NHBillDal>();
builder.Services.AddScoped<IBrandsDal, NHBrandsDal>();
builder.Services.AddScoped<ICategoryDal, NHCategoryDal>();
builder.Services.AddScoped<ICityDal, NHCityDal>();
builder.Services.AddScoped<ICustomerDal, NHCustomerDal>();
builder.Services.AddScoped<IContactDal, NHContactDal>();
builder.Services.AddScoped<IEmployeeDal, NHEmployeeDal>();
builder.Services.AddScoped<IEmployeeDetailsDal, NHEmployeeDetailsDal>();
builder.Services.AddScoped<IEmployeesRolesDal, NHEmployeesRolesDal>();
builder.Services.AddScoped<IProductDal, NHProductDal>();
builder.Services.AddScoped<IRoleDal, NHRoleDal>();
builder.Services.AddScoped<ISalesDal, NHSalesDal>();
builder.Services.AddScoped<IStockDal, NHStockDal>();
builder.Services.AddScoped<ITaxDal, NHTaxDal>();
#endregion
#region Services
builder.Services.AddScoped<IBillService, BillManager>();
builder.Services.AddScoped<IBrandService, BrandManager>();
builder.Services.AddScoped<ICategoryService, CategoryManager>();
builder.Services.AddScoped<ICityService, CityManager>();
builder.Services.AddScoped<IContactService, ContactManager>();
builder.Services.AddScoped<ICustomerService, CustomerManager>();
builder.Services.AddScoped<IEmployeeDetailsService, EmployeeDetailsManager>();
builder.Services.AddScoped<IEmployeeService, EmployeeManager>();
builder.Services.AddScoped<IEmployeesRolesService, EmployeesRolesManager>();
builder.Services.AddScoped<IProductService, ProductManager>();
builder.Services.AddScoped<IRoleService, RoleManager>();
builder.Services.AddScoped<ISalesService, SalesManager>();
builder.Services.AddScoped<IStockService, StockManager>();
builder.Services.AddScoped<ITaxService, TaxManager>();

#endregion
#region ViewOperation Injections
builder.Services.AddScoped<ISalesViewService, SalesViewManager>();
builder.Services.AddScoped<IProductViewService, ProductViewManager>();
builder.Services.AddScoped<IStockViewService, StockViewManager>();
builder.Services.AddScoped<IContactDetailViewService, ContactDetailViewManager>();
builder.Services.AddScoped<ICityViewService, CityViewManager>();
#endregion
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

app.MapBlazorHub();
app.MapFallbackToPage("/_Host");

app.Run();
