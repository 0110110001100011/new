<!DOCTYPE html>
<html lang="es">
    <head>
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
        <meta charset="utf-8" />
        <title>@ViewData("Title") - OBESUS</title>
        <link href="~/favicon.ico" rel="shortcut icon" type="image/x-icon" />
        <meta name="viewport" content="width=device-width" />
        @Styles.Render("~/Content/css")
        @Scripts.Render("~/bundles/modernizr")
    </head>
    <body>
        <header>
            <div class="content-wrapper">
                <div class="float-left">
                     <img id="logo" src="../Images/logo_256.png" height="50"> 
                </div>
                <div class="float-right">
                    <section class="login">
                        @Html.Partial("_LoginPartial")
                    </section>
                    <nav>
                        <ul id="menu">
                            <li>@Html.ActionLink("Inicio", "Index", "Home")</li>
                            <li>@Html.ActionLink("Sobrepeso", "Index", "Sobrepeso")</li>
                            <li>@Html.ActionLink("Desnutricion", "Index", "Desnutricion")</li>
                            <li>@Html.ActionLink("Dietas", "Index", "Dietas")</li>
                            <li>@Html.ActionLink("Ejercicio", "Index", "Ejercicio")</li>
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
                    <p>&copy; @DateTime.Now.Year - OBESUS ASP.NET MVC</p>
                    <ul class="menuFooter">
                        <li>@Html.ActionLink("Contacto", "Contact", "Home")</li>
                        <li>@Html.ActionLink("Acerca de", "About", "Home")</li>
                    </ul>
                </div>
            </div>
        </footer>

        @Scripts.Render("~/bundles/jquery")
        @RenderSection("scripts", required:=False)
    </body>
</html>
