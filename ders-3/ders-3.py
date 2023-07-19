# layout kısmını parçalıyoruz. bunu projeyi daha efektif yapabilmek için yapıyoruz.

# Shared dosyasına giderek head etiketlerini alıyoruz ve başka bir .cshtml uzantılı bir dosya içerisine taşıyoruz.

# <head>
#     <meta charset="utf-8" />
#     <meta name="viewport" content="width=device-width, initial-scale=1.0" />
#     <title>@ViewData["Title"] - E_Ticaret</title>
#     <link rel="stylesheet" href="~/lib/bootstrap/dist/css/bootstrap.min.css" />
#     <link rel="stylesheet" href="~/css/site.css" asp-append-version="true" />
#     <link rel="stylesheet" href="~/E_Ticaret.styles.css" asp-append-version="true" />
# </head>

# koparıp adlığımız noktaya @{await Html.RenderPartialAsync("_Head");} yazıyoruz.

# "await" ifadesi, ASP.NET Core'da asenkron programlamayı desteklemek için kullanılır. 
# Asenkron programlama, web uygulamalarında uzun süren işlemleri (veritabanı istekleri, ağ istekleri vb.) engellemeksizin işlem yapmaya olanak sağlar.
# "await" ifadesi, bir işlemin tamamlanmasını beklemek için kullanılan bir anahtar kelimedir.
# Bu sayede işlemler arka planda gerçekleştirilebilir ve web sunucusu, diğer isteklere cevap verebilir.


# aynı yöntem ile header , footer ve scripts alanlarını da parçalaycağız.

# @{await Html.RenderPartialAsync ("_Header");}
# @{await Html.RenderPartialAsync ("_Footer");}
# @{await Html.RenderPartialAsync("_Scripts");}


# bu iki satır aynı yapıda olduğu için şu şekilde birleştirebiliriz.

# @{await Html.RenderPartialAsync ("_Footer");
#   await Html.RenderPartialAsync("_Scripts");
#  }

# bu işlemlerden sonra layout sayfası baya yalın oldu. 