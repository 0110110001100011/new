<!DOCTYPE html>
<html lang="es">
    <head>
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
        <meta charset="utf-8" />
        <title>Obesus - @ViewData("Title")</title>
        <link href="~/favicon.ico" rel="shortcut icon" type="image/x-icon" />
        <meta name="viewport" content="width=device-width" />
        <script type="text/javascript" src="../Scripts/jquery.js"></script>
        <script type="text/javascript" src="../Scripts/slideshow.js"></script>
        <link rel="stylesheet" type="text/css" href="../Content/Slideshow.css" />
        @Styles.Render("~/Content/css")
        @Scripts.Render("~/bundles/modernizr")
    </head>
    <body>
        <header>
            <div class="content-wrapper">
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
                            <li>@Html.ActionLink("Acerca de", "About", "Home")</li>
                            <li>@Html.ActionLink("Contacto", "Contact", "Home")</li>
                            <li>@Html.ActionLink("Obesidad", "Obesidad", "Home")</li>
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
