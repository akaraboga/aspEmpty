 
var builder = WebApplication.CreateBuilder(args);


builder.Services.AddControllersWithViews();

var app = builder.Build();


app.UseStaticFiles();

 
app.UseRouting();
 
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

 
app.Run();

//controller : Gelen istekleri view ve modele gondererek ikisinin arasýnda kopru olur
// Action metodu : controllerin içineolan ve gelen isteklere iþleyerek sonuç döndürür.
// Model : veri tabaný iþlevini görür.controllerin view la arasýnda koprü olur.
//view : Uygulamanýn arayüzü
//Razor : html ve css kodlarýný birleþtirir @ ile css yazarýz.
//Razo views : Razor kullandýðýmýzda çýktýyý html olarak almamýzý saðlar.
//wwwroot : uygulamanýn css gibi static dosyalarýný tutmaya yarar

//builder.build : var app = builder.Build(); uygulamayý çalýþtýrmak için gerekli iþlemleri tamamlar
//appp.run : app.Run(); uygulamayý çalýþtýrýr