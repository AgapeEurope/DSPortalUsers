Imports System.Web
Imports System.Web.Services
Imports System.Web.Services.Protocols
Imports System.Linq
' To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line.
' <System.Web.Script.Services.ScriptService()> _
<WebService(Namespace:="http://tempuri.org/")> _
<WebServiceBinding(ConformsTo:=WsiProfiles.BasicProfile1_1)> _
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Public Class DSPortalUsers
     Inherits System.Web.Services.WebService
    Private theUsername As String = "CASAUTH"
    Private thePassword As String = "thecatsaysmeow3"

    Structure DSPortal
        Dim PortalName As String
        Dim PortalURI As String
    End Structure


    <WebMethod()> _
    Public Function GetPortalsForUser(ByVal Username As String, ByVal Password As String, ByVal SsoCode As String) As List(Of DSPU.DataserverPortalUser)
        If (Username <> theUsername Or Password <> thePassword) Then
            Return Nothing

        End If

        Dim d As New DSPU.DSPUDataContext()

        Dim q = From c In d.DataserverPortalUsers Where c.SsoCode.ToString = SsoCode Select c

        Return q.ToList()



    End Function


End Class