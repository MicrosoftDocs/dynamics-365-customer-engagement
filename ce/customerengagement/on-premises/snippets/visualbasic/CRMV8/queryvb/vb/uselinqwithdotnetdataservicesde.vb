' <snippetuselinqwithdotnetdataservicesde>


Imports System.ServiceModel

' These namespaces are found in the Microsoft.Xrm.Sdk.dll assembly
' located in the SDK\bin folder of the SDK download.
Imports Microsoft.Xrm.Sdk
Imports Microsoft.Xrm.Sdk.Client

Namespace Microsoft.Crm.Sdk.Samples
 ''' <summary>
 ''' Demonstrates how to make LINQ queries with the OrganizationServiceContext
 ''' object and the dynamic entity type.</summary>
 ''' <remarks>
 ''' At run-time, you will be given the option to delete all the
 ''' database records created by this program.</remarks>
 Public Class UseLinqWithDotNetDataServicesDE
#Region "Class Level Members"
  ''' <summary>
  ''' Stores the organization service proxy.
  ''' </summary>
  Private _serviceProxy As OrganizationServiceProxy
  ' Define the IDs needed for this sample.
  Private _accountIds As New List(Of Guid)()
  Private _contactIds As New List(Of Guid)()
  Private _leadIds As New List(Of Guid)()

#End Region ' Class Level Members

#Region "How To Sample Code"
  ''' <summary>
  ''' This method first connects to the Organization service and service context.
  ''' Afterwards, several LINQ query techniques are demonstrated.
  ''' </summary>
  ''' <param name="serverConfig">Contains server connection information.</param>
  ''' <param name="promptforDelete">When True, the user will be prompted to delete all
  ''' created entities.</param>
  Public Sub Run(ByVal serverConfig As ServerConnection.Configuration,
                 ByVal promptforDelete As Boolean)
   Try
    ' Connect to the Organization service. 
    ' The using statement assures that the service proxy will be properly disposed.
    _serviceProxy = ServerConnection.GetOrganizationProxy(serverConfig)
    Using _serviceProxy
     ' This statement is required to enable early-bound type support.
     _serviceProxy.EnableProxyTypes()

     CreateRequiredRecords()

     Dim orgContext As New OrganizationServiceContext(_serviceProxy)

     ' Retrieve records with Skip/Take record paging. Setting a page size
     ' can help you manage your Skip and Take calls, since Skip must be
     ' passed a multiple of Take's parameter value.
     Dim pageSize As Integer = 5

     Dim accountsByPage = From a In orgContext.CreateQuery("account") _
                          Select a("name")
     Console.WriteLine("Skip 10 accounts, then Take 5 accounts")
     Console.WriteLine("======================================")
     For Each name In accountsByPage.Skip(2 * pageSize).Take(pageSize)
      Console.WriteLine(name)
     Next name
     Console.WriteLine()
     Console.WriteLine("<End of Listing>")
     Console.WriteLine()
     ' OUTPUT:
     ' Skip 10 accounts, then Take 5 accounts
     ' ======================================
     ' Fourth Coffee 6
     ' Fourth Coffee 7
     ' Fourth Coffee 8
     ' Fourth Coffee 9
     ' Fourth Coffee 10

     ' <End of Listing>

     ' Use orderBy to order items retrieved.
     Dim orderedAccounts = From a In orgContext.CreateQuery("account") _
                           Order By a("name") _
                           Select a("name")
     Console.WriteLine("Display accounts ordered by name")
     Console.WriteLine("================================")
     For Each name In orderedAccounts
      Console.WriteLine(name)
     Next name
     Console.WriteLine()
     Console.WriteLine("<End of Listing>")
     Console.WriteLine()
     ' OUTPUT:
     ' Display accounts ordered by name
     ' ================================
     ' A. Datum Corporation
     ' Adventure Works
     ' Coho Vineyard
     ' Fabrikam
     ' Fourth Coffee 1
     ' Fourth Coffee 10
     ' Fourth Coffee 2
     ' Fourth Coffee 3
     ' Fourth Coffee 4
     ' Fourth Coffee 5
     ' Fourth Coffee 6
     ' Fourth Coffee 7
     ' Fourth Coffee 8
     ' Fourth Coffee 9
     ' Humongous Insurance

     ' <End of Listing>

     ' Filter multiple entities using LINQ.
     Dim query = From c In orgContext.CreateQuery("contact") _
                 Join a In orgContext.CreateQuery("account") _
                 On c("contactid") Equals a("primarycontactid") _
                 Where CType(c("lastname"), String).Equals("Wilcox") _
                 OrElse CType(c("lastname"), String).Equals("Andrews") _
                 Where (CType(a("address1_telephone1"), String)) _
                 .Contains("(206)") OrElse _
                 (CType(a("address1_telephone1"),
                  String)).Contains("(425)") _
                 Select New With
                        {
                            Key .Contact = New With
                                           {Key .FirstName = c("firstname"),
                                            Key .LastName = c("lastname")},
                             Key .Account = New With
                                            {Key .Address1_Telephone1 _
                                            = a("address1_telephone1")}}

     Console.WriteLine("Join account and contact")
     Console.WriteLine("List all records matching specified parameters")
     Console.WriteLine("Contact name: Wilcox or Andrews")
     Console.WriteLine("Account area code: 206 or 425")
     Console.WriteLine("==============================================")
     For Each record In query
      Console.WriteLine("Contact Name: {0} {1}", record.Contact.FirstName, record.Contact.LastName)
      Console.WriteLine("Account Phone: {0}", record.Account.Address1_Telephone1)
     Next record
     Console.WriteLine("<End of Listing>")
     Console.WriteLine()
     ' OUTPUT:
     ' Join account and contact
     ' List all records matching specified parameters
     ' Contact name: Wilcox or Andrews
     ' Account area code: 206 or 425
     ' ==============================================
     ' Contact Name: Ben Andrews
     ' Account Phone: (206)555-5555
     ' Contact Name: Ben Andrews
     ' Account Phone: (425)555-5555
     ' Contact Name: Colin Wilcox
     ' Account Phone: (425)555-5555
     ' <End of Listing>

     ' Build a complex query with LINQ. This query includes multiple
     ' JOINs.
     'Note: Where statements are not working with the below multiple join query.
     '       Refer equivalent C# snippet for full complex query.
     'TODO: Fix issue to include where statements as showin in C# sample.
     Dim complexQuery = From c In orgContext.CreateQuery("contact") _
                        Join a In orgContext.CreateQuery("account") _
                        On c("contactid") Equals a("primarycontactid") _
                        Join l In orgContext.CreateQuery("lead") _
                        On a("originatingleadid") Equals l("leadid") _
                        Select New With
                               {Key .Contact = New With
                                               {Key .FirstName = c("firstname"),
                                                Key .LastName = c("lastname")},
                                Key .Account = New With
                                               {Key .Address1_Telephone1 _
                                               = a("address1_telephone1")},
                                Key .Lead = New With
                                            {Key .LeadId = l("leadid")}}

     Console.WriteLine("Join account, contact and lead")
     Console.WriteLine("List all records matching specified parameters")
     Console.WriteLine("==============================================")
     For Each record In complexQuery
      Console.WriteLine("Lead ID: {0}", record.Lead.LeadId)
      Console.WriteLine("Contact Name: {0} {1}",
                        record.Contact.FirstName,
                        record.Contact.LastName)
      Console.WriteLine("Account Phone: {0}",
                        record.Account.Address1_Telephone1)
     Next record
     Console.WriteLine("<End of Listing>")
     Console.WriteLine()
     ' OUTPUT:
     ' Join account, contact and lead
     ' List all records matching specified parameters
     ' Contact name: Wilcox or Andrews
     ' Account area code: 206 or 425
     ' ==============================================
     ' Lead ID: 78d5df14-64a3-e011-aea3-00155dba3818
     ' Contact Name: Colin Wilcox
     ' Account Phone: (425)555-5555
     ' <End of Listing>

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
   ' Create 3 contacts.
   Dim contact As New Contact() With
       {
           .FirstName = "Ben",
           .LastName = "Andrews",
           .EMailAddress1 = "sample@example.com",
           .Address1_City = "Redmond",
           .Address1_StateOrProvince = "WA"
       }
   _contactIds.Add(_serviceProxy.Create(contact))

   contact = New Contact() With
             {
                 .FirstName = "Colin",
                 .LastName = "Wilcox",
                 .EMailAddress1 = "sample@example.com",
                 .Address1_City = "Bellevue",
                 .Address1_StateOrProvince = "WA"
             }
   _contactIds.Add(_serviceProxy.Create(contact))

   contact = New Contact() With
             {
                 .FirstName = "Ben",
                 .LastName = "Smith",
                 .EMailAddress1 = "sample@example.com",
                 .Address1_City = "Bellevue",
                 .Address1_StateOrProvince = "WA"
             }
   _contactIds.Add(_serviceProxy.Create(contact))

   ' Create 3 leads.
   Dim lead As New Lead() With
       {
           .FirstName = "Dan",
           .LastName = "Wilson",
           .EMailAddress1 = "sample@example.com",
           .Address1_City = "Redmond",
           .Address1_StateOrProvince = "WA"
       }
   _leadIds.Add(_serviceProxy.Create(lead))

   lead = New Lead() With
          {
              .FirstName = "Jim",
              .LastName = "Wilson",
              .EMailAddress1 = "sample@example.com",
              .Address1_City = "Bellevue",
              .Address1_StateOrProvince = "WA"
          }
   _leadIds.Add(_serviceProxy.Create(lead))

   lead = New Lead() With
          {
              .FirstName = "Denise",
              .LastName = "Smith",
              .EMailAddress1 = "sample@example.com",
              .Address1_City = "Bellevue",
              .Address1_StateOrProvince = "WA"
          }
   _leadIds.Add(_serviceProxy.Create(lead))

   ' Create 5 customized Accounts for the LINQ samples.
   Dim account As Account =
       New Account With
       {
           .Name = "A. Datum Corporation",
           .Address1_StateOrProvince = "Colorado",
           .Address1_Telephone1 = "(206)555-5555",
           .PrimaryContactId = New EntityReference(contact.EntityLogicalName,
                                                   _contactIds(0))
       }
   _accountIds.Add(_serviceProxy.Create(account))

   account = New Account With
             {
                 .Name = "Adventure Works",
                 .Address1_StateOrProvince = "Illinois",
                 .Address1_County = "Lake County",
                 .Address1_Telephone1 = "(206)555-5555",
                 .OriginatingLeadId = New EntityReference(lead.EntityLogicalName,
                                                          _leadIds(0))
             }
   _accountIds.Add(_serviceProxy.Create(account))

   account = New Account With
             {
                 .Name = "Coho Vineyard",
                 .Address1_StateOrProvince = "Washington",
                 .Address1_County = "King County",
                 .Address1_Telephone1 = "(425)555-5555",
                 .PrimaryContactId =
                 New EntityReference(contact.EntityLogicalName,
                                     _contactIds(1)),
                 .OriginatingLeadId =
                 New EntityReference(lead.EntityLogicalName,
                                     _leadIds(0))
             }
   _accountIds.Add(_serviceProxy.Create(account))

   account = New Account With
             {
                 .Name = "Fabrikam",
                 .Address1_StateOrProvince = "Washington",
                 .Address1_Telephone1 = "(425)555-5555",
                 .PrimaryContactId =
                 New EntityReference(contact.EntityLogicalName,
                                     _contactIds(0))
             }
   _accountIds.Add(_serviceProxy.Create(account))

   account =
       New Account With
       {
           .Name = "Humongous Insurance",
           .Address1_StateOrProvince = "Missouri",
           .Address1_County = "Saint Louis County",
           .Address1_Telephone1 = "(314)555-5555",
           .PrimaryContactId =
           New EntityReference(contact.EntityLogicalName,
                               _contactIds(1))
       }
   _accountIds.Add(_serviceProxy.Create(account))

   ' Create 10 basic Account records.
   For i As Integer = 1 To 10
    account = New Account With
              {
                  .Name = "Fourth Coffee " &amp; i,
                  .Address1_StateOrProvince = "California"
              }
    _accountIds.Add(_serviceProxy.Create(account))
   Next i
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
    For Each accountId As Guid In _accountIds
     _serviceProxy.Delete(Account.EntityLogicalName, accountId)
    Next accountId
    For Each contactId As Guid In _contactIds
     _serviceProxy.Delete(Contact.EntityLogicalName, contactId)
    Next contactId
    For Each leadId As Guid In _leadIds
     _serviceProxy.Delete(Lead.EntityLogicalName, leadId)
    Next leadId
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
    Dim config As ServerConnection.Configuration =
        serverConnect.GetServerConfiguration()

    Dim app As New UseLinqWithDotNetDataServicesDE()
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
                Console.WriteLine("Inner Fault: {0}",
                                  If(Nothing Is ex.InnerException.Message, "No Inner Fault", ex.InnerException.Message))
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
                        Console.WriteLine("Inner Fault: {0}",
                                          If(Nothing Is fe.Detail.InnerFault, "No Inner Fault", "Has Inner Fault"))
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

' </snippetuselinqwithdotnetdataservicesde>