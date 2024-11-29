 
var builder = WebApplication.CreateBuilder(args);


builder.Services.AddControllersWithViews();

var app = builder.Build();


app.UseStaticFiles();

 
app.UseRouting();
 
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

 
app.Run();

//controller : Gelen istekleri view ve modele gondererek ikisinin aras�nda kopru olur
// Action metodu : controllerin i�ineolan ve gelen isteklere i�leyerek sonu� d�nd�r�r.
// Model : veri taban� i�levini g�r�r.controllerin view la aras�nda kopr� olur.
//view : Uygulaman�n aray�z�
//Razor : html ve css kodlar�n� birle�tirir @ ile css yazar�z.
//Razo views : Razor kulland���m�zda ��kt�y� html olarak almam�z� sa�lar.
//wwwroot : uygulaman�n css gibi static dosyalar�n� tutmaya yarar

//builder.build : var app = builder.Build(); uygulamay� �al��t�rmak i�in gerekli i�lemleri tamamlar
//appp.run : app.Run(); uygulamay� �al��t�r�r