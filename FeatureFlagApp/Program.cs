var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

string appConfigAccessKey = "Endpoint=https://webappconfigalexei.azconfig.io;Id=q0Hu;Secret=mHtWYL4j6A3sy7dOg9ASoFIPZXQcveAhi8tSDa+H76A=";
builder.Configuration.AddAzureAppConfiguration(appConfigAccessKey).UseFeatureFlags();

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
