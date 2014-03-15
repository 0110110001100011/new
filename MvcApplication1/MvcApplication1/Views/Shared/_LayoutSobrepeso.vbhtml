<!DOCTYPE html>
<html lang="es" class="fondo_rojo" >
    <head>
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
        <meta charset="utf-8" />
        <title>Obesus2 - @ViewData("Title")</title>
        <link href="~/favicon.ico" rel="shortcut icon" type="image/x-icon" />
        <meta name="viewport" content="width=device-width" />
        @Styles.Render("~/Content/css")
        @Scripts.Render("~/bundles/modernizr")
    </head>
    <body>
        <header>
            <div class="rojo content-wrapper" >
                <div class="float-left">
                    <p class="site-title">@Html.ActionLink("logotipo Obesus", "Index", "Home")</p>
                </div>
                <div class="float-right">
                    <section id="login">
                        @Html.Partial("_LoginPartial")
                    </section>
                    <nav>
                        <ul id="menu">
                            <li>@Html.ActionLink("Inicio", "Index", "Home")</li>
                            <li>@Html.ActionLink("Desnutricion", "Desnutricion", "Desnutricion")</li>
                            <li>@Html.ActionLink("Sobrepeso", "Sobrepeso", "Sobrepeso")</li>
                            <li>@Html.ActionLink("Dietas", "Dietas", "Dietas")</li>
                            <li>@Html.ActionLink("Ejercicio", "Ejercicio", "Ejercicio")</li>
                            <li>@Html.ActionLink("Acerca de", "About", "Home")</li>
                            <li>@Html.ActionLink("Contacto", "Contact", "Home")</li>
                        </ul>
                    </nav>
                </div>
            </div>
        </header>
        <div id="body">
            @RenderSection("featured", required:=false)
            <section class="content-wrapper main-content clear-fix">
                @RenderBody()
            </section>
            <aside class="contenedor_negro">
                <h3>Mas Informacion</h3>
                <ul>
                    <li>@Html.ActionLink("Sobrepeso", "Sobrepeso", "Sobrepeso")</li>
                    <li>@Html.ActionLink("Causas del Sobrepeso", "SobrepesoCausas", "Sobrepeso")</li>
                    <li>@Html.ActionLink("Indices de masa corporal", "SobrepesoMC", "Sobrepeso")</li>
                </ul>
            </aside>
        </div>
        <footer>
            <div class="content-wrapper">
                <div class="float-left">
                    <p>&copy; @DateTime.Now.Year - Hexabytes ASP.NET MVC</p>
                </div>
            </div>
        </footer>

        @Scripts.Render("~/bundles/jquery")
        @RenderSection("scripts", required:=False)
    </body>
</html>
