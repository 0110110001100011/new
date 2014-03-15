Public Class HelloWorldController
    Inherits System.Web.Mvc.Controller

    '
    ' GET: /HelloWorld

    Function Index() As ActionResult
        Return View()
    End Function

End Class