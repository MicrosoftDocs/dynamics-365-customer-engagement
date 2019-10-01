' <snippetwebclientplugin2>


 ' Download the target URI using a Web client. Any .NET class that uses the
 ' HTTP or HTTPS protocols and a DNS lookup should work.
 Using client As New WebClient()

     Dim responseBytes() As Byte = client.DownloadData(webAddress)
     Dim response As String = Encoding.UTF8.GetString(responseBytes)

' </snippetwebclientplugin2>