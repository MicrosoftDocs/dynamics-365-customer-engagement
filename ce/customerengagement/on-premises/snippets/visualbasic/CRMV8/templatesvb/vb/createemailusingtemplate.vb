' <snippetcreateemailusingtemplate>


Imports System.IO
Imports System.Text
Imports System.ServiceModel
Imports System.Xml.Serialization
Imports System.ServiceModel.Description

' These namespaces are found in the Microsoft.Xrm.Sdk.dll assembly
' located in the SDK\bin folder of the SDK download.
Imports Microsoft.Xrm.Sdk
Imports Microsoft.Xrm.Sdk.Query
Imports Microsoft.Xrm.Sdk.Client
Imports Microsoft.Xrm.Sdk.Messages


' This namespace is found in Microsoft.Crm.Sdk.Proxy.dll assembly
' found in the SDK\bin folder.
Imports Microsoft.Crm.Sdk.Messages

Namespace Microsoft.Crm.Sdk.Samples
    Public Class CreateEmailUsingTemplate
        #Region "Class Level Members"

        ' Define the IDs needed for this sample.        
        Private _accountId As Guid
        Private _templateId As Guid

        Private _serviceProxy As OrganizationServiceProxy
        #End Region ' Class Level Members

        #Region "How To Sample Code"
        ''' <summary>
        ''' Create an e-mail using a template.
        ''' </summary>
        ''' <param name="serverConfig">Contains server connection information.</param>
        ''' <param name="promptforDelete">When True, the user will be prompted to delete all
        ''' created entities.</param>
        Public Sub Run(ByVal serverConfig As ServerConnection.Configuration, ByVal promptforDelete As Boolean)
            Try
                ' Connect to the Organization service. 
                ' The using statement assures that the service proxy will be properly disposed.
                _serviceProxy = ServerConnection.GetOrganizationProxy(serverConfig)
                Using _serviceProxy
                    ' This statement is required to enable early-bound type support.
                    _serviceProxy.EnableProxyTypes()

                    CreateRequiredRecords()


                    ' Use the InstantiateTemplate message to create an e-mail message using a template.
                    Dim instTemplateReq As InstantiateTemplateRequest = New InstantiateTemplateRequest With { _
                        .TemplateId = _templateId, .ObjectId = _accountId, .ObjectType = Account.EntityLogicalName}
                    Dim instTemplateResp As InstantiateTemplateResponse = _
                        CType(_serviceProxy.Execute(instTemplateReq), InstantiateTemplateResponse)

                    ' Serialize the email message to XML, and save to a file.
                    Dim serializer As New XmlSerializer(GetType(InstantiateTemplateResponse))
                    Dim filename As String = "email-message.xml"
                    Using writer As New StreamWriter(filename)
                        serializer.Serialize(writer, instTemplateResp)
                    End Using
                    Console.WriteLine("Created e-mail using the template.")


                    DeleteRequiredRecords(promptforDelete)
                End Using

            ' Catch any service fault exceptions that Microsoft Dynamics CRM throws.
            Catch fe As FaultException(Of Microsoft.Xrm.Sdk.OrganizationServiceFault)
                ' You can handle an exception here or pass it back to the calling method.
                Throw
            End Try
        End Sub

        ''' <summary>
        ''' Creates any entity records that this sample requires.
        ''' </summary>
        Public Sub CreateRequiredRecords()
            ' Create an account.
            Dim account As Account = New Account With {.Name = "Fourth Coffee"}
            _accountId = _serviceProxy.Create(account)
            Console.WriteLine("Created a sample account: {0}.", account.Name)

            ' Define the body and subject of the email template in XML format.
            Dim bodyXml As String = "<?xml version=""1.0"" ?>" &amp; _
                "<xsl:stylesheet xmlns:xsl=""https://www.w3.org/1999/XSL/Transform"" version=""1.0"">" &amp; _
                "<xsl:output method=""text"" indent=""no""/><xsl:template match=""/data"">" &amp; _
                "<![CDATA[" &amp; "This message is to notify you that a new account has been created." &amp; _
                "]]></xsl:template></xsl:stylesheet>"

            Dim subjectXml As String = "<?xml version=""1.0"" ?>" &amp; _
                "<xsl:stylesheet xmlns:xsl=""https://www.w3.org/1999/XSL/Transform"" version=""1.0"">" &amp; _
                "<xsl:output method=""text"" indent=""no""/><xsl:template match=""/data"">" &amp; _
                "<![CDATA[New account notification]]></xsl:template></xsl:stylesheet>"

            Dim presentationXml As String = "<template><text><![CDATA[" &amp; _
                "This message is to notify you that a new account has been created." &amp; "]]></text></template>"

            Dim subjectPresentationXml As String = "<template><text><![CDATA[New account notification]]></text></template>"

            ' Create an e-mail template.
            Dim template As Template = New Template With {.Title = "Sample E-mail Template for Account", .Body = bodyXml, _
                .Subject = subjectXml, .PresentationXml = presentationXml, .SubjectPresentationXml = subjectPresentationXml, _
                .TemplateTypeCode = account.EntityLogicalName, .LanguageCode = 1033, .IsPersonal = False}

            _templateId = _serviceProxy.Create(template)
            Console.WriteLine("Created {0}.", template.Title)
        End Sub


        ''' <summary>
        ''' Deletes any entity records that were created for this sample.
        ''' <param name="prompt">Indicates whether to prompt the user 
        ''' to delete the records created in this sample.</param>
        ''' </summary>
        Public Sub DeleteRequiredRecords(ByVal prompt As Boolean)
            Dim toBeDeleted As Boolean = True

            If prompt Then
                ' Ask the user if the created entities should be deleted.
                Console.Write(vbLf &amp; "Do you want these entity records deleted? (y/n) [y]: ")
                Dim answer As String = Console.ReadLine()
                If answer.StartsWith("y") OrElse answer.StartsWith("Y") OrElse answer = String.Empty Then
                    toBeDeleted = True
                Else
                    toBeDeleted = False
                End If
            End If

            If toBeDeleted Then
                ' Delete all records created in this sample.
                _serviceProxy.Delete(Template.EntityLogicalName, _templateId)
                _serviceProxy.Delete(Account.EntityLogicalName, _accountId)


                Console.WriteLine("Entity record(s) have been deleted.")
            End If
        End Sub

        #End Region ' How To Sample Code

        #Region "Main method"
        ''' <summary>
        ''' Main. Runs the sample and provides error output.
        ''' <param name="args">Array of arguments to Main method.</param>
        ''' </summary>
        Public Shared Sub Main(ByVal args() As String)
            Try
                ' Obtain the target organization's Web address and client logon 
                ' credentials from the user.
                Dim serverConnect As New ServerConnection()
                Dim config As ServerConnection.Configuration = serverConnect.GetServerConfiguration()

                Dim app As New CreateEmailUsingTemplate()
                app.Run(config, True)

            Catch ex As FaultException(Of Microsoft.Xrm.Sdk.OrganizationServiceFault)
                Console.WriteLine("The application terminated with an error.")
                Console.WriteLine("Timestamp: {0}", ex.Detail.Timestamp)
                Console.WriteLine("Code: {0}", ex.Detail.ErrorCode)
                Console.WriteLine("Message: {0}", ex.Detail.Message)
                Console.WriteLine("Plugin Trace: {0}", ex.Detail.TraceText)
                Console.WriteLine("Inner Fault: {0}", If(Nothing Is ex.Detail.InnerFault, "No Inner Fault", "Has Inner Fault"))
            Catch ex As TimeoutException
                Console.WriteLine("The application terminated with an error.")
                Console.WriteLine("Message: {0}", ex.Message)
                Console.WriteLine("Stack Trace: {0}", ex.StackTrace)
                Console.WriteLine("Inner Fault: {0}", If(Nothing Is ex.InnerException.Message, "No Inner Fault", ex.InnerException.Message))
            Catch ex As Exception
                Console.WriteLine("The application terminated with an error.")
                Console.WriteLine(ex.Message)

                ' Display the details of the inner exception.
                If ex.InnerException IsNot Nothing Then
                    Console.WriteLine(ex.InnerException.Message)

                    Dim fe As FaultException(Of Microsoft.Xrm.Sdk.OrganizationServiceFault) = _
                        TryCast(ex.InnerException, FaultException(Of Microsoft.Xrm.Sdk.OrganizationServiceFault))
                    If fe IsNot Nothing Then
                        Console.WriteLine("Timestamp: {0}", fe.Detail.Timestamp)
                        Console.WriteLine("Code: {0}", fe.Detail.ErrorCode)
                        Console.WriteLine("Message: {0}", fe.Detail.Message)
                        Console.WriteLine("Plugin Trace: {0}", fe.Detail.TraceText)
                        Console.WriteLine("Inner Fault: {0}", If(Nothing Is fe.Detail.InnerFault, "No Inner Fault", "Has Inner Fault"))
                    End If
                End If
            ' Additonal exceptions to catch: SecurityTokenValidationException, ExpiredSecurityTokenException,
            ' SecurityAccessDeniedException, MessageSecurityException, and SecurityNegotiationException.

            Finally
                Console.WriteLine("Press <Enter> to exit.")
                Console.ReadLine()
            End Try

        End Sub
        #End Region ' Main method

    End Class
End Namespace

' </snippetcreateemailusingtemplate>