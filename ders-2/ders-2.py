# rooting işlemi yapma

# adım-1 : layout içerisinde yer alan aşağıdaki satırlarda aslında birtane link mevcut. asp-area , asp-controller isimlerinde. biz bunu daha ge

# <li class="nav-item">
#     <a class="nav-link text-dark" asp-area="" asp-controller="Home" asp-action="Index">Home</a>
# </li>
# <li class="nav-item">
#     <a class="nav-link text-dark" asp-area="" asp-controller="Home" asp-action="Privacy">Privacy</a>
# </li>

# <li class="nav-item">
#     <a class="nav-link text-dark" href="/">Home</a>
# </li>
# <li class="nav-item">
#     <a class="nav-link text-dark" href="/privacy">Privacy</a>
# </li>

# adım-2 : HomeController da oluşturduğumuz linki olduğu gibi public in tam üstüne [Route("/pricay")]  olarak ekliyoruz
