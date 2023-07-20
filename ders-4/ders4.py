# bootstrap şablonları ekleyeceğiz.

# indirdiğimiz dosyadan sadece source klasörünü almıyoruz , onun dışındak bütün dosyaları projemiz içerisindeki wwwroot içerisine ekliyoruz.
# wwwroot kısmı içerisindeki lib klasörünü harici tutarak geri kanaların tamamını siliyoruz.

# readme dosyasını da sildik. peyderpey html dosyalarını sileceğiz.

# 1.adım : wwwroot içerisindeki css dosyası içerisine birtane site.css adında bir klasör oluşturuyoruz.
# 2.adım : wwwroot içerisindeki js dosyası içerisine birtane js.css adında bir klasör oluşturuyoruz.
# 3.adım : wwwroot içerisine upload adında bir klasör oluşturuyoruz , altına images ve files adında 2 klasör daha oluşturuyoruz.

# 4.adım : yeni eklediğimiz klasörler arasındaki index.html sayfasına gidiyoruz ve şu şekilde değişiklik yapıyoruz.

# <!-- Css Styles -->
#     <link rel="stylesheet" href="css/bootstrap.min.css" type="text/css">
#     <link rel="stylesheet" href="css/font-awesome.min.css" type="text/css">
#     <link rel="stylesheet" href="css/themify-icons.css" type="text/css">
#     <link rel="stylesheet" href="css/elegant-icons.css" type="text/css">
#     <link rel="stylesheet" href="css/owl.carousel.min.css" type="text/css">
#     <link rel="stylesheet" href="css/nice-select.css" type="text/css">
#     <link rel="stylesheet" href="css/jquery-ui.min.css" type="text/css">
#     <link rel="stylesheet" href="css/slicknav.min.css" type="text/css">
#     <link rel="stylesheet" href="css/style.css" type="text/css">

# hreflerin başlarına / işaretleri koyduk.

# <!-- Css Styles -->
#     <link rel="stylesheet" href="/css/bootstrap.min.css" type="text/css">
#     <link rel="stylesheet" href="/css/font-awesome.min.css" type="text/css">
#     <link rel="stylesheet" href="/css/themify-icons.css" type="text/css">
#     <link rel="stylesheet" href="/css/elegant-icons.css" type="text/css">
#     <link rel="stylesheet" href="/css/owl.carousel.min.css" type="text/css">
#     <link rel="stylesheet" href="/css/nice-select.css" type="text/css">
#     <link rel="stylesheet" href="/css/jquery-ui.min.css" type="text/css">
#     <link rel="stylesheet" href="/css/slicknav.min.css" type="text/css">
#     <link rel="stylesheet" href="/css/style.css" type="text/css">


# bu adım sayesinde css dosyalarını anaroute dan aldığmızı belirtmiş olduk.

# 5.adım : index.html sayfasının altındaki js hreflerine de aynı işlemi yapıyoruz.

    # <!-- Js Plugins -->
    # <script src="js/jquery-3.3.1.min.js"></script>
    # <script src="js/bootstrap.min.js"></script>
    # <script src="js/jquery-ui.min.js"></script>
    # <script src="js/jquery.countdown.min.js"></script>
    # <script src="js/jquery.nice-select.min.js"></script>
    # <script src="js/jquery.zoom.min.js"></script>
    # <script src="js/jquery.dd.min.js"></script>
    # <script src="js/jquery.slicknav.js"></script>
    # <script src="js/owl.carousel.min.js"></script>
    # <script src="js/main.js"></script>


    # <!-- Js Plugins -->
    # <script src="/js/jquery-3.3.1.min.js"></script>
    # <script src="/js/bootstrap.min.js"></script>
    # <script src="/js/jquery-ui.min.js"></script>
    # <script src="/js/jquery.countdown.min.js"></script>
    # <script src="/js/jquery.nice-select.min.js"></script>
    # <script src="/js/jquery.zoom.min.js"></script>
    # <script src="/js/jquery.dd.min.js"></script>
    # <script src="/js/jquery.slicknav.js"></script>
    # <script src="/js/owl.carousel.min.js"></script>
    # <script src="/js/main.js"></script>

# kısa yol : bütün satırları tek tek düzeltmek yerine ctrl+h ile hepsini tek seferde düzeltebiliriz. 

# 6.adım : ctrl+h ile img hreflerini de düzeltiyoruz.

# 7.adım : index.html sayfasını ctrl+c , ctrl+v ile Shared altındaki _Layout.cshtml içerisine taşıyoruz.

# 8.adım : daha önce uygulamış olduğumuz @{await Html.RenderPartialAsync("klasör isimi");} ile index de her sekmenin altında görünen kısımları ayırarak layout sayfasını sadeleştirdik.

# 9.adım : bu adımdan sonra eklediğimiz site.js dosyasını ve site.css dosyalarını da ilgili alanlara ekliyoruz.
# 10.adım : site.js dosyasını _Scripts içerisine , site.css dosyasını ise _Head içerisine ekliyoruz.

# önemli : layout sayfasındaki bütün veriler her sayfa için geçerlidir.
#          title kısmının her açılan sayfa ile birlikte değişeceğiniz gözönünde blundurursak title kısmının dinamik bir yapıya sahip olması gerekir.
#          bunun için şu adımları takip etmemiz gerekir.

# 1.adım : _Head.cshtml sayfasına gidiyoruz.
# 2.adım : <title>Fashi | Template</title> alanı bu şekilde statik bir halde. burayı şu şekilde değiştiriyoruz.
# 3.adım : Home klasörü altındaki index.cshtml sayfasına gidiyoruz.
# 4.adım : Home sayfasındaki ViewData["Title"] kısmını kopyalayıp _Head.cshtml sayfasındaki title etikelerinin arasına ekliyoruz.
# 5.adım : title etiketinin son hali şu şekilde oluyor. <title>@ViewData["Title"] | ETicaret</title>


# 11.adım : layout içerisinde kalan dier satırları da kopyalıyoruz ve layout sayfasına daha önce @{await Html.RenderPartialsAsyns("klasör ismi");} diyerek tanımladığımız alana bu sefer @RenderBody() diyere kopyaladıklarımızı Home klasorü içinceki index.cshtml sayfasına yapıştırıyoruz.
# önemli : ViewData kısmı aynen kalıyor.

