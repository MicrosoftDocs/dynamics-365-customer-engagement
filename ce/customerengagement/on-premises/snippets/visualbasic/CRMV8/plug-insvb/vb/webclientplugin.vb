' <snippetwebclientplugin>


Imports System.Globalization
Imports System.IO
Imports System.Text
Imports System.Net

' Microsoft Dynamics CRM namespace(s)
Imports Microsoft.Xrm.Sdk

Namespace Microsoft.Crm.Sdk.Samples

    ''' <summary>
    ''' A sandboxed plug-in that can access network (Web) resources.
    ''' </summary>
    ''' <remarks>Register this plug-in in the sandbox. You can provide an unsecure string
    ''' during registration that specifies the Web address (URI) to access from the plug-in.
    ''' </remarks>
    Public NotInheritable Class WebClientPlugin
        Implements IPlugin

        Private webAddress As String

        ''' <summary>
        ''' The plug-in constructor.
        ''' </summary>
        ''' <param name="config">The Web address to access. An empty or null string
        ''' defaults to accessing www.bing.com. The Web address can use the HTTP or
        ''' HTTPS protocol.</param>
        Public Sub New(ByVal config As String)

            If String.IsNullOrEmpty(config) Then

                webAddress = "https://www.bing.com"

            Else

                webAddress = config

            End If

        End Sub

        ''' <summary>
        ''' Main execute method that is required by the IPlugin interface. Uses the WebClient 
        ''' .NET class to access the target Web address.
        ''' </summary>
        ''' <param name="serviceProvider">The service provider from which you can obtain the
        ''' tracing service, plug-in execution context, organization service, and more.</param>
        Public Sub Execute(ByVal serviceProvider As IServiceProvider) _
            Implements IPlugin.Execute

            'Extract the tracing service for use in plug-in debugging.
            Dim tracingService As ITracingService =
                CType(serviceProvider.GetService(GetType(ITracingService)), 
                    ITracingService)

            Try

                tracingService.Trace("Downloading the target URI: " &amp; webAddress)

                Try

                    ' Download the target URI using a Web client. Any .NET class that uses the
                    ' HTTP or HTTPS protocols and a DNS lookup should work.
                    Using client As New WebClient()

                        Dim responseBytes() As Byte = client.DownloadData(webAddress)
                        Dim response As String = Encoding.UTF8.GetString(responseBytes)
                        tracingService.Trace(response)

                        ' For demonstration purposes, throw an exception so that the response
                        ' is shown in the trace dialog of the Microsoft Dynamics CRM user interface.
                        Throw New InvalidPluginExecutionException("WebClientPlugin completed successfully.")

                    End Using


                Catch exception As WebException

                    Dim str As String = String.Empty
                    If exception.Response IsNot Nothing Then

                        Using reader As New StreamReader(exception.Response.GetResponseStream())

                            str = reader.ReadToEnd()

                        End Using
                        exception.Response.Close()

                    End If
                    If exception.Status.Equals(WebExceptionStatus.Timeout) Then

                        Throw New InvalidPluginExecutionException("The timeout elapsed while attempting to issue the request.", exception)

                    End If
                    Throw New InvalidPluginExecutionException(String.Format(CultureInfo.InvariantCulture, "A Web exception occurred while attempting to issue the request. {0}: {1}", exception.Message, str), exception)

                End Try

            Catch e As Exception

                tracingService.Trace("Exception: {0}", e.ToString())
                Throw

            End Try

        End Sub
    End Class

End Namespace

' </snippetwebclientplugin>