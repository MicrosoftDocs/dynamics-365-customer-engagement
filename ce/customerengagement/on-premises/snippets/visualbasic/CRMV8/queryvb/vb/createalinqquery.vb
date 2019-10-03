' <snippetcreatealinqquery>


Imports System.ServiceModel

' These namespaces are found in the Microsoft.Xrm.Sdk.dll assembly
' located in the SDK\bin folder of the SDK download.
Imports Microsoft.Xrm.Sdk
Imports Microsoft.Xrm.Sdk.Client

Namespace Microsoft.Crm.Sdk.Samples
 ''' <summary>
 ''' Demonstrates how to do create basic LINQ queries against Microsoft Dynamics CRM
 ''' records.</summary>
 ''' <remarks>
 ''' At run-time, you will be given the option to delete all the
 ''' database records created by this program.</remarks>
 Public Class CreateALinqQuery
#Region "Class Level Members"

  Private _recordIds As New Dictionary(Of Guid, String)()
  Private _serviceProxy As OrganizationServiceProxy
  Private _service As IOrganizationService

#End Region ' Class Level Members

#Region "How To Sample Code"
  ''' <summary>
  ''' This method first connects to the Organization service. Afterwards,
  ''' basic LINQ queries are performed.
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
     _service = CType(_serviceProxy, IOrganizationService)

     CreateRequiredRecords()

     ' Create the ServiceContext object that will generate
     ' the IQueryable collections for LINQ calls.
     Dim svcContext As New ServiceContext(_service)

     ' Loop through all CRM account using the IQueryable interface
     ' on the OrganizationDataContext object
     Dim accounts = From a In svcContext.AccountSet _
                                   Select New Account With _
                                          { _
                                              .Name = a.Name, _
                                              .Address1_County = a.Address1_County _
                                          }
     Console.WriteLine("List all accounts in CRM")
     Console.WriteLine("========================")
     For Each a In accounts
      Console.WriteLine(a.Name &amp; " " &amp; a.Address1_County)
     Next a
     Console.WriteLine()
     Console.WriteLine("<End of Listing>")
     Console.WriteLine()
     ' OUTPUT:
     ' List all accounts in CRM
     ' ========================
     ' Fourth Coffee
     ' School of Fine Art Lake County
     ' Tailspin Toys King County
     ' Woodgrove Bank
     ' Contoso, Ltd. Saint Louis County

     ' <End of Listing>
     Console.WriteLine()



     ' Retrieve all accounts owned by the user who has read access rights
     ' to the accounts and where the last name of the user is not Cannon.
     Dim queryAccounts = From a In svcContext.AccountSet _
                                        Join owner In svcContext.SystemUserSet _
                                        On a.OwnerId.Id Equals owner.SystemUserId _
                                        Where owner.LastName IsNot "Cannon" _
                                        Select New Account With _
                                               {
                                                   .Name = a.Name, _
                                                   .Address1_City = a.Address1_City _
                                               }
     Console.WriteLine("Accounts not owned by user w/ last name 'Cannon'")
     Console.WriteLine("================================================")
     For Each a In queryAccounts
      Console.WriteLine(a.Name &amp; " " &amp; a.Address1_County)
     Next a
     Console.WriteLine()
     Console.WriteLine("<End of Listing>")
     Console.WriteLine()
     ' OUTPUT:
     ' Accounts not owned by user w/ last name 'Cannon'
     ' ================================================
     ' Fourth Coffee
     ' School of Fine Art
     ' Tailspin Toys
     ' Woodgrove Bank
     ' Contoso, Ltd.

     ' <End of Listing>
     Console.WriteLine()



     ' Return a count of all accounts which have a county specified
     ' in their address.
     Dim accountsWithCounty As Integer = ( _
         From a In svcContext.AccountSet _
         Where (a.Address1_County IsNot Nothing) _
         Select New Account With
                {
                    .Name = a.Name,
                    .Address1_City = a.Address1_City
                }
            ).ToArray().Count()
     Console.Write("Number of accounts with a county specified: ")
     Console.WriteLine(accountsWithCounty)
     Console.WriteLine()
     ' OUTPUT:
     ' Number of accounts with a county specified: 3
     Console.WriteLine()



     ' Return a count of states in which we have an account. This
     ' uses the 'distinct' keyword which counts a state only one time.
     Dim statesWithAccounts As Integer = ( _
         From a In svcContext.AccountSet _
         Where (a.Address1_StateOrProvince IsNot Nothing) _
         Select a.Address1_StateOrProvince).Distinct().ToArray().Count()
     Console.Write("Number of unique states that contain accounts: ")
     Console.WriteLine(statesWithAccounts)
     Console.WriteLine()
     ' OUTPUT:
     ' Number of unique states that contain accounts: 3
     Console.WriteLine()



     ' Return contacts where the city equals Redmond AND the first
     ' name is Joe OR John.
     Dim queryContacts = From c In svcContext.ContactSet _
                                        Where (c.Address1_City.Equals("Redmond")) _
                                        And (c.FirstName.Equals("Joe") _
                                                Or c.FirstName.Equals("John")) _
                                            Select New Contact With _
                                                   {
                                                       .FirstName = c.FirstName,
                                                       .LastName = c.LastName,
                                                       .Address1_City = c.Address1_City
                                                   }
     Console.WriteLine("Contacts in Redmond named Joe OR John")
     Console.WriteLine("=====================================")
     For Each c In queryContacts
      Console.WriteLine(c.FirstName &amp; " " &amp; c.LastName &amp; " " &amp; c.Address1_City)
     Next c
     Console.WriteLine()
     Console.WriteLine("<End of Listing>")
     Console.WriteLine()
     ' OUTPUT:
     ' Contacts in Redmond named Joe OR John
     ' =====================================
     ' Joe  Redmond
     ' John  Redmond
     ' Joe  Redmond

     ' <End of Listing>
     Console.WriteLine()


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
   ' Create 5 Accounts and 5 Contacts for the LINQ samples.
   Dim account As Account = New Account With
                            {
                                .Name = "Fourth Coffee",
                                .Address1_StateOrProvince = "Colorado"
                            }
   _recordIds.Add(_service.Create(account), account.EntityLogicalName)
   account = New Account With
             {
                 .Name = "School of Fine Art",
                 .Address1_StateOrProvince = "Illinois",
                 .Address1_County = "Lake County"
             }
   _recordIds.Add(_service.Create(account), account.EntityLogicalName)
   account = New Account With
             {
                 .Name = "Tailspin Toys",
                 .Address1_StateOrProvince = "Washington",
                 .Address1_County = "King County"
             }
   _recordIds.Add(_service.Create(account), account.EntityLogicalName)
   account = New Account With
             {
                 .Name = "Woodgrove Bank",
                 .Address1_StateOrProvince = "Washington"
             }
   _recordIds.Add(_service.Create(account), account.EntityLogicalName)
   account = New Account With
             {
                 .Name = "Contoso, Ltd.",
                 .Address1_County = "Saint Louis County"
             }
   _recordIds.Add(_service.Create(account), account.EntityLogicalName)

   Dim contact As Contact = New Contact With
                            {
                                .FirstName = "Joe",
                                .Address1_City = "Redmond"
                            }
   _recordIds.Add(_service.Create(contact), contact.EntityLogicalName)
   contact = New Contact With
             {
                 .FirstName = "John",
                 .Address1_City = "Redmond"
             }
   _recordIds.Add(_service.Create(contact), contact.EntityLogicalName)
   contact = New Contact With
             {
                 .FirstName = "John",
                 .Address1_City = "Cleveland"
             }
   _recordIds.Add(_service.Create(contact), contact.EntityLogicalName)
   contact = New Contact With
             {
                 .FirstName = "Joe",
                 .Address1_City = "Redmond"
             }
   _recordIds.Add(_service.Create(contact), contact.EntityLogicalName)
   contact = New Contact With
             {
                 .FirstName = "Jim",
                 .Address1_City = "Redmond"
             }
   _recordIds.Add(_service.Create(contact), contact.EntityLogicalName)
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
    If answer.StartsWith("y") OrElse answer.StartsWith("Y") _
        OrElse answer = String.Empty Then
     toBeDeleted = True
    Else
     toBeDeleted = False
    End If
   End If

   If toBeDeleted Then
    ' Delete all records created in this sample.
    For Each record In _recordIds
     _service.Delete(record.Value, record.Key)
    Next record
    Console.WriteLine("Entity record(s) have been deleted.")
   End If
  End Sub

#End Region ' How To Sample Code

#Region "Main method"

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

    Dim app As New CreateALinqQuery()
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

     Dim fe As FaultException(Of Microsoft.Xrm.Sdk.OrganizationServiceFault) =
         TryCast(ex.InnerException, 
             FaultException(Of Microsoft.Xrm.Sdk.OrganizationServiceFault))
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
#End Region ' Main method
 End Class
End Namespace

' </snippetcreatealinqquery>