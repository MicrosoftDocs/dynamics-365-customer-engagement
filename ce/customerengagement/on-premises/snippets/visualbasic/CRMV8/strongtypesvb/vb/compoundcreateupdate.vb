' <snippetcompoundcreateupdate>


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
    ''' Shows how to create and use compound Create and Update statements.
    ''' If you want to run this sample repeatedly, you have the option to 
    ''' delete all the records created at the end of execution.
    ''' </summary>
    Public Class CompoundCreateUpdate
        #Region "Class Level Members"

        ''' <summary>
        ''' Stores the organization service proxy.
        ''' </summary>
        Private _serviceProxy As OrganizationServiceProxy
        Private _service As IOrganizationService

        ' Define the IDs needed for this sample.
        Public _accountId As Guid
        Public _letterIds() As Guid

        #End Region ' Class Level Members

        #Region "How To Sample Code"
        ''' <summary>
        ''' Create and configure the organization service proxy.
        ''' Creates an account and some associated letters with a nested operation.
        ''' Updates those records with a nested operation.
        ' </summary>
        ''' <param name="serverConfig">Contains server connection information.</param>
        ''' <param name="promptForDelete">When True, the user will be prompted to delete all
        ''' created entities.</param>
        Public Sub Run(ByVal serverConfig As ServerConnection.Configuration, ByVal promptForDelete As Boolean)
            Try

                ' Connect to the Organization service. 
                ' The using statement assures that the service proxy will be properly disposed.
                _serviceProxy = ServerConnection.GetOrganizationProxy(serverConfig)
                Using _serviceProxy
                    ' This statement is required to enable early-bound type support.
                    _serviceProxy.EnableProxyTypes()

                    _service = CType(_serviceProxy, IOrganizationService)

                    'Define the account for which we will add letters                
                    Dim accountToCreate As Account = New Account With {.Name = "Example Account"}

                    'Define the IDs of the related letters we will create
                    _letterIds = { Guid.NewGuid(), Guid.NewGuid(), Guid.NewGuid() }

                    'This acts as a container for each letter we create. Note that we haven't
                    'define the relationship between the letter and account yet.
                    Dim relatedLettersToCreate As EntityCollection = New EntityCollection With {.EntityName = Letter.EntityLogicalName}
                    relatedLettersToCreate.Entities.Add(New Letter With {.Subject = "Letter 1", .ActivityId = _letterIds(0)})
                    relatedLettersToCreate.Entities.Add(New Letter With {.Subject = "Letter 2", .ActivityId = _letterIds(1)})
                    relatedLettersToCreate.Entities.Add(New Letter With {.Subject = "Letter 3", .ActivityId = _letterIds(2)})

                    'Creates the reference between which relationship between Letter and
                    'Account we would like to use.
                    Dim letterRelationship As New Relationship("Account_Letters")

                    'Adds the letters to the account under the specified relationship
                    accountToCreate.RelatedEntities.Add(letterRelationship, relatedLettersToCreate)

                    'Passes the Account (which contains the letters)
                    _accountId = _service.Create(accountToCreate)

                    Console.WriteLine("An account and {0} letters were created.", _letterIds.Length)


                    'Now we run through many of the same steps as the above "Create" example
                    Dim accountToUpdate As Account = New Account With {.Name = "Example Account - Updated", .AccountId = _accountId}

                    Dim relatedLettersToUpdate As EntityCollection = New EntityCollection With {.EntityName = Letter.EntityLogicalName}
                    relatedLettersToUpdate.Entities.Add(New Letter With {.Subject = "Letter 1 - Updated", .ActivityId = _letterIds(0)})
                    relatedLettersToUpdate.Entities.Add(New Letter With {.Subject = "Letter 2 - Updated", .ActivityId = _letterIds(1)})
                    relatedLettersToUpdate.Entities.Add(New Letter With {.Subject = "Letter 3 - Updated", .ActivityId = _letterIds(2)})

                    accountToUpdate.RelatedEntities.Add(letterRelationship, relatedLettersToUpdate)

                    'This will update the account as well as all of the related letters
                    _service.Update(accountToUpdate)
                    Console.WriteLine("An account and {0} letters were updated.", _letterIds.Length)


                    DeleteRequiredRecords(promptForDelete)

                End Using
            ' Catch any service fault exceptions that Microsoft Dynamics CRM throws.
            Catch fe As FaultException(Of Microsoft.Xrm.Sdk.OrganizationServiceFault)
                ' You can handle an exception here or pass it back to the calling method.
                Throw
            End Try
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
                For Each letterId As Guid In _letterIds
                    _service.Delete(Letter.EntityLogicalName, letterId)
                Next letterId
                _service.Delete(Account.EntityLogicalName, _accountId)

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

                Dim app As New CompoundCreateUpdate()
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

' </snippetcompoundcreateupdate>