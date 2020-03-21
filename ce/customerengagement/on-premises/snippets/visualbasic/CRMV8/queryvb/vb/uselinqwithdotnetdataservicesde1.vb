' <snippetuselinqwithdotnetdataservicesde1>


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

' </snippetuselinqwithdotnetdataservicesde1>