var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

// Đăng ký HttpClient gọi WebAPI
builder.Services.AddHttpClient("ProductAPI", client =>
{
    client.BaseAddress = new Uri("https://localhost:5001/api/"); // Địa chỉ thực tế WebAPI
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles(); // ⚠️ Quan trọng để dùng CSS/JS

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
