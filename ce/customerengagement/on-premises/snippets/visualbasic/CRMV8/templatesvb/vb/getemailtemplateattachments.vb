' <snippetgetemailtemplateattachments>


Imports System.ServiceModel
Imports System.ServiceModel.Description

' These namespaces are found in the Microsoft.Xrm.Sdk.dll assembly
' found in the SDK\bin folder.
Imports Microsoft.Xrm.Sdk
Imports Microsoft.Xrm.Sdk.Client
Imports Microsoft.Xrm.Sdk.Query
Imports Microsoft.Xrm.Sdk.Discovery

' This namespace is found in Microsoft.Crm.Sdk.Proxy.dll assembly
' found in the SDK\bin folder.
Imports Microsoft.Crm.Sdk.Messages


Namespace Microsoft.Crm.Sdk.Samples

    ''' <summary>
    ''' Demonstrates how to retrieve email attachments associated with an email template.
    ''' If you want to run this sample repeatedly, you have the option to 
    ''' delete all the records created at the end of execution.
    ''' </summary>
    Public Class GetEmailTemplateAttachments
        #Region "Class Level Members"
        ''' <summary>
        ''' Stores the organization service proxy.
        ''' </summary>
        Private _serviceProxy As OrganizationServiceProxy

        ' Define the IDs needed for this sample.
        Public _emailTemplateId As Guid
        Public _templateAttachmentIds As New List(Of Guid)()

        #End Region ' Class Level Members

        #Region "How To Sample Code"
        ''' <summary>
        ''' Create and configure the organization service proxy.
        ''' Create an email template and several attachments.
        ''' Retrieve the email attachments
        ''' Optionally delete template and attachments.
        ''' </summary>
        ''' <param name="serverConfig">Contains server connection information.</param>
        ''' <param name="promptforDelete">When True, the user will be prompted to delete all
        ''' created entities.</param>
        Public Sub Run(ByVal serverConfig As ServerConnection.Configuration, ByVal promptForDelete As Boolean)
            Try

                ' Connect to the Organization service. 
                ' The using statement assures that the service proxy will be properly disposed.
                _serviceProxy = ServerConnection.GetOrganizationProxy(serverConfig)
                Using _serviceProxy
                    ' This statement is required to enable early-bound type support.
                    _serviceProxy.EnableProxyTypes()

                    ' Call the method to create any data that this sample requires.
                    CreateRequiredRecords()


                    'Create a query to retrieve attachments.
                    Dim query As QueryExpression = New QueryExpression With { _
                        .EntityName = ActivityMimeAttachment.EntityLogicalName, .ColumnSet = New ColumnSet("filename")}
                    query.Criteria = New FilterExpression()
                    query.Criteria.AddCondition("objecttypecode", ConditionOperator.Equal, {Template.EntityTypeCode})
                    query.Criteria.AddCondition("objectid", ConditionOperator.Equal, {_emailTemplateId})
                    query.Criteria.FilterOperator = LogicalOperator.And
                        'Define the conditions for each attachment.
                            'The ObjectTypeCode must be specified, or else the query
                            'defaults to "email" instead of "template".
                            'Specify which template we need.

                    'Write out the filename of each attachment retrieved.
                    For Each attachment As ActivityMimeAttachment In _serviceProxy.RetrieveMultiple(query).Entities
                        Console.WriteLine("Retrieved attachment {0}", attachment.FileName)
                    Next attachment


                    DeleteRequiredRecords(promptForDelete)
                End Using

            ' Catch any service fault exceptions that Microsoft Dynamics CRM throws.
            Catch fe As FaultException(Of Microsoft.Xrm.Sdk.OrganizationServiceFault)
                ' You can handle an exception here or pass it back to the calling method.
                Throw
            End Try
        End Sub

        ''' <summary>
        ''' This method creates any entity records that this sample requires.
        ''' </summary>
        Public Sub CreateRequiredRecords()
            'Define the email template to create.
            Dim emailTemplate As Template = New Template With {.Title = "An example email template", _
                    .Subject = "This is an example email.", .IsPersonal = False, .TemplateTypeCode = "lead", .LanguageCode = 1033}
                '1033 is the code for US English - you may need to change this value
                'depending on your locale.

            _emailTemplateId = _serviceProxy.Create(emailTemplate)

            For i As Integer = 0 To 2
                Dim attachment As ActivityMimeAttachment = New ActivityMimeAttachment With { _
                    .Subject = String.Format("Attachment {0}", i), .FileName = String.Format("ExampleAttachment{0}.txt", i), _
                    .Body = "Some Text", .ObjectId = New EntityReference(Template.EntityLogicalName, _emailTemplateId), _
                    .ObjectTypeCode = Template.EntityLogicalName}

                _templateAttachmentIds.Add(_serviceProxy.Create(attachment))
            Next i

            Console.WriteLine("An email template and {0} attachments were created.", _templateAttachmentIds.Count)

            Return
        End Sub

        ''' <summary>
        ''' Deletes any entity records that were created for this sample.
        ''' <param name="prompt">Indicates whether to prompt the user to delete the records created in this sample.</param>
        ''' </summary>
        Public Sub DeleteRequiredRecords(ByVal prompt As Boolean)
            Dim deleteRecords As Boolean = True

            If prompt Then
                Console.WriteLine(vbLf &amp; "Do you want these entity records deleted? (y/n)")
                Dim answer As String = Console.ReadLine()

                deleteRecords = (answer.StartsWith("y") OrElse answer.StartsWith("Y"))
            End If

            If deleteRecords Then
                For Each attachmentId As Guid In _templateAttachmentIds
                    _serviceProxy.Delete(ActivityMimeAttachment.EntityLogicalName, attachmentId)
                Next attachmentId

                _serviceProxy.Delete(Template.EntityLogicalName, _emailTemplateId)

                Console.WriteLine("Entity records have been deleted.")
            End If
        End Sub

        #End Region ' How To Sample Code

        #Region "Main"
        ''' <summary>
        ''' Standard Main() method used by most SDK samples.
        ''' </summary>
        ''' <param name="args"></param>
        Public Shared Sub Main(ByVal args() As String)
            Try
                ' Obtain the target organization's Web address and client logon 
                ' credentials from the user.
                Dim serverConnect As New ServerConnection()
                Dim config As ServerConnection.Configuration = serverConnect.GetServerConfiguration()

                Dim app As New GetEmailTemplateAttachments()
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

            ' Additional exceptions to catch: SecurityTokenValidationException, ExpiredSecurityTokenException,
            ' SecurityAccessDeniedException, MessageSecurityException, and SecurityNegotiationException.
            Finally
                Console.WriteLine("Press <Enter> to exit.")
                Console.ReadLine()
            End Try

        End Sub
        #End Region ' Main

    End Class
End Namespace

' </snippetgetemailtemplateattachments>