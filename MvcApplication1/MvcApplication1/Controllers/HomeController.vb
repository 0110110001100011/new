Public Class HomeController
    Inherits System.Web.Mvc.Controller

    Function Index() As ActionResult
        ViewData("Message") = "bla bla  this template to jump-start your ASP.NET MVC application."

        Return View()
    End Function

    Function About() As ActionResult
        ViewData("Message") = "HEXABYTES!!!."

        Return View()
    End Function

    Function Contact() As ActionResult
        ViewData("Message") = "Contacta al equipo Hexabytes"

        Return View()
    End Function
End Class
