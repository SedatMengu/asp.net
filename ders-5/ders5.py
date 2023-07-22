# html sayfalarından yavaş yavaş kurtuluyoruz.



# çevireceğimiz başlıkların tamamı şu şekilde,

# Shop
# Collection
# Blog
# Contact
# Pages

# bu isimler bize taslak olarak indirdiğimiz şablon dosyadan geldi. bunları kendimize göre uyarlayacağız.

# 1.adım : Privacy.cshtml sayfasını klasör ismini Shop.cshtml olarak değiştiriyoruz.
# 2.adım : yeni ismi ile Shop.cshtml sayfası içerisine girerek title kısmını değiştiriyoruz.

# eski : 

# @{
#     ViewData["Title"] = "Privacy Policy";
# }

# yeni : 

# @{
#     ViewData["Title"] = "Shop";
# }

# 3.adım : bu bilgi dışındakileri siliyoruz.
# 4.adım : wwwroot klasörü altındaki shop.html sayfasını açıyoruz.
# 5.adım : layout içerisine almadığımız / RenderBody ile tariflenen bölgeyi kesip Shop.cshtml sayfası içerisine alıyoruz.
# önemli : shop.html sayfası içerisindeki diğer bilgileri önceki derste Layout olarak _Head , _Header , _PagePreloder , _PartnerLogo , _ Footer gibi yapılar içerisine kopyala yapıştır yaptık. aynı işlemi yapmış gibi olduk esasında.
# 6.adım : shop.html sayfası ile işimiz bitti.
# 7.adım : HomeController sayfasına gidiyoruz ve privacy alanını shop olarak değiştiriyoruz.

# eski hali :

# [Route("/privacy")]
#     public IActionResult Privacy()
#     {
#         return View();
#     }

# yeni hali : 
# [Route("/shop")]
#     public IActionResult Shop()
#     {
#         return View();
#     }

# burada yaptığımız düzeltmede kişiler shop sayfasına tıkladığında Shop sayfasını göster dedik.

# 8.adım : bu işlemleri yaptıktan sonra _Header.cshtml sayfasını açtık ve oradaki bazı etiket isimlerini değiştirdik.
# önemli : index.html ve shop.html sayfaları artık olmadığı için onları referans kabul eden yapılarda değişiklikler yapmamız gerekiyor.
# 9.adım : "./shop.html" uzantısını "/shop" olarak , "./index.html" uzantısını da "/" olarak değiştirdik.
# kısa yol : @* kullanılmayan alanları bu şekilde yorum satırı yapabiliriz.*@
# 10.adım : aynı yöntem ile blog.html contact.html sayfalarını da entegre ediyoruz.
# 11.adım : Shop.cshtml sayfasından 2 tane daha türetiyoruz. birincisi Blog.cshtml , ikincisi Contact.cshtml
# 12.adım : _layout sayfası içerisine almadığımız kısımları keserek diğer Blog.cshtml ve Contact.cshtml sayfalarına yapıştıyıoruz.
# 13.adım : HomeController sayfasına giderek oradaki shop için olan IActionResult lardan blog ve contact için türetiyoruz.
# 14.adım : login.html sayfasını da aynı şekilde entegre ediyoruz. (Login.cshtml) ilave olarak aşağıdaki değişikliği de yapıyoruz.
# önemli : _Header başlığındaki alanı şu şekilde değiştirmemiz gerekiyor. 

# eski hali :

# <a href="#" class="login-panel"><i class="fa fa-user"></i>Login</a>


# yeni hali : 

# <a href="/login" class="login-panel"><i class="fa fa-user"></i>Login</a>

# 15.adım : register.cshtml sayfasını da entegre ediyoruz.

# Login.cshtml sayfasındaki değişikliği unutma ,
# eski hali : 
# <a href="./register.html" class="or-login">Or Create An Account</a>
# yeni hali : 
# <a href="/register" class="or-login">Or Create An Account</a>

# Register.cshtml sayfasındaki şu alanı değiştiriyoruz.
# eksi hali : 
# <a href="./login.html" class="or-login">Or Login</a>
# yeni hali : 
# <a href="/login" class="or-login">Or Login</a>

# genel itibari ile entegre çalışmalarında,

# 1.adım : .html uzantılı dosyadan benzersiz kısımları kesip alıyoruz.
# 2.adım : Views altındaki Home kalsörü altında ilgili dosya ile aynı isimde .cshtml uzantılı dosya türetiyoruz.
# 3.adım : aşağıdaki değişikliği uyguluyoruz.

# @{
#     ViewData["Title"] = "Bu alanı değiştir";
# }

# 4.adım : kestiğimiz satırları .cshtml uzatılı ilgili dosyaya yapıştırıyoruz.
# 5.adım : Homecontroller alanında aşağıdaki alanları ekliyoruz.

# [Route("/Bu alanı değiştir")]
#     public IActionResult Bu alanı değiştir()
#     {
#         return View();
#     }

# 6.adım : Views altındaki Shared altında bulunan _Header.cshtml isimli dosyaya giderek oradaki hrefleri değiştiriyoruz.


# ana sayfa yazısını kaldırıyoruz ve men , women , kids alanlarını ana sayfaya gömüyoruz.
# dil kısmını yorum satırı yapabiliriz.

# login yanına birtane de register ekleyebiliriz.

# footer da ki linkleri düzenleyip onları da .cshtml dosyaları içerisine aktarabiliriz.

# değiştireceğimiz kısımlar , 

# eski halleri : 
# <li><a href="#">About Us</a></li>
# <li><a href="#">Checkout</a></li>
# <li><a href="#">Contact</a></li>
# <li><a href="#">Serivius</a></li>

# yeni halleri : 

# <li><a href="/about">About Us</a></li>
# <li><a href="/checkout">Checkout</a></li>
# <li><a href="/contact">Contact</a></li>
# <li><a href="/faq">FAQ</a></li>

# bu yaptığımız linkler için views altında .cshtml uzantılı sayfaları olmalı. bunun için wwwroot dan faydalanabiliriz.
# About , Checkout , Contact , FAQ sayfalarını entegre ettik.