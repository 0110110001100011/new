@ModelType Obesus.LocalPasswordModel
@Code
    ViewData("Title") = "Administrar cuenta"
End Code

<hgroup class="title">
    <h1>@ViewData("Title").</h1>
</hgroup>

<p class="message-success">@ViewData("StatusMessage")</p>
<div class="contenedor_negro formulario">
    <p>Ha iniciado sesión como <strong class="hverde">@User.Identity.Name</strong>.</p>

    @If ViewData("HasLocalPassword") Then
        @Html.Partial("_ChangePasswordPartial")
    Else
        @Html.Partial("_SetPasswordPartial")
    End If
</div>
    <section id="externalLogins" class="social contenedor_negro">
        @Html.Action("RemoveExternalLogins")

        <h3 class="hverde">Agregar un inicio de sesión externo</h3>
        @Html.Action("ExternalLoginsList", New With {.ReturnUrl = ViewData("ReturnUrl")})
    </section>

    @Section Scripts
        @Scripts.Render("~/bundles/jqueryval")
    End Section
