Public Class HomeController
    Inherits System.Web.Mvc.Controller

    Function Index() As ActionResult
        ViewData("Message") = "Obesus"

        Return View()
    End Function

    Function About() As ActionResult
        ViewData("Message") = "Acerca de..."

        Return View()
    End Function

    Function Contact() As ActionResult
        ViewData("Message") = "contactanos"

        Return View()
    End Function
End Class
