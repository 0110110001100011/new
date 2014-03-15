Public Class HomeController
    Inherits System.Web.Mvc.Controller

    Function Index() As ActionResult
        ViewData("Message") = ""

        Return View()
    End Function

    Function About() As ActionResult
        ViewData("Message") = "Acerca de..."

        Return View()
    End Function

    Function Contact() As ActionResult
        ViewData("Message") = "Contacta al equipo Hexabytes"

        Return View()
    End Function


End Class
