' <snippetbasiccontextexamples>


Imports System.IO
Imports System.ServiceModel
Imports System.Text

' These namespaces are found in the Microsoft.Xrm.Sdk.dll assembly
' located in the SDK\bin folder of the SDK download.
Imports Microsoft.Xrm.Sdk
Imports Microsoft.Xrm.Sdk.Client

' These namespaces are found in the Microsoft.Crm.Sdk.Proxy.dll assembly
' located in the SDK\bin folder of the SDK download.
Imports Microsoft.Crm.Sdk.Messages

Namespace Microsoft.Crm.Sdk.Samples
	''' <summary>
	''' Demonstrates how to do use the OrganizationServiceContext to work with multiple
	''' records simultaneously.</summary>
	''' <remarks>
	''' NOTE: To execute file attachment step, you must have a text file named
	''' "sample.txt" in the folder in which this code is executed.
	''' 
	''' At run-time, you will be given the option to delete all the
	''' database records created by this program.</remarks>
	Public Class BasicContextExamples
		#Region "Class Level Members"

		Private _accountId As Guid
		Private _contactId As Guid
		Private _annotationId As Guid
		Private _priceLevelId As Guid
		Private _quoteId As Guid
		Private _productId As Guid
		Private _productPriceLevelId As Guid
		Private _quoteDetailId As Guid
		Private _opportunityId As Guid
		Private _incidentId As Guid
		Private _serviceProxy As OrganizationServiceProxy
		Private _orgContext As OrganizationServiceContext
		Private _service As IOrganizationService

		#End Region ' Class Level Members

		#Region "How To Sample Code"
		''' <summary>
		''' This method first connects to the Organization service and creates the
		''' OrganizationServiceContext. Then, several entity creation and relationship
		''' operations are performed.
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

					' The OrganizationServiceContext is an object that wraps the service
					' proxy and allows creating/updating multiple records simultaneously.
					_orgContext = New OrganizationServiceContext(_service)

					' Create a new contact called Mary Kay Andersen.
                    Dim contact = New Contact() With
                                  {
                                      .FirstName = "Mary Kay",
                                      .LastName = "Andersen",
                                      .Address1_Line1 = "23 Market St.",
                                      .Address1_City = "Sammamish",
                                      .Address1_StateOrProvince = "MT",
                                      .Address1_PostalCode = "99999",
                                      .Telephone1 = "12345678",
                                      .EMailAddress1 = "marykay@contoso.com",
                                      .Id = Guid.NewGuid()
                                  }
					_contactId = contact.Id
					_orgContext.AddObject(contact)
					Console.Write("Instantiating contact, ")

					' Create an account called Contoso.
                    Dim account = New Account() With
                                  {
                                      .Name = "Contoso",
                                      .Address1_City = "Redmond",
                                      .AccountCategoryCode = New OptionSetValue(1),
                                      .LastUsedInCampaign = Date.Now,
                                      .MarketCap = New Money(120000),
                                      .DoNotEMail = True,
                                      .Description = "Contoso is a fictional company!",
                                      .Id = Guid.NewGuid()
                                  }
                    ' set the account category to 'Preferred Customer'
					_accountId = account.Id
					Console.Write("instantiating account, ")

					' Set Mary Kay Andersen as the primary contact
                    _orgContext.AddRelatedObject(contact,
                                                 New Relationship("account_primary_contact"),
                                                 account)
					SaveChangesHelper(contact, account)
					Console.WriteLine("and creating both records in CRM.")

					' Remove the primary contact value from Mary Kay Andersen
					_orgContext.Attach(contact)
                    _orgContext.DeleteLink(contact,
                                           New Relationship("account_primary_contact"),
                                           account)
					SaveChangesHelper(contact, account)
					Console.Write("Removing primary contact status, ")

					' Add Mary Kay Andersen to the contact list for the account Contoso.
					_orgContext.Attach(account)
					_orgContext.Attach(contact)
                    _orgContext.AddLink(account,
                                        New Relationship("contact_customer_accounts"),
                                        contact)
					SaveChangesHelper(contact, account)
					Console.WriteLine("and adding contact to account's contact list.")

					' Add a note with a document attachment to the contact's record.
					Dim attachment = File.OpenRead("sample.txt")
                    Dim data = New Byte(CInt(attachment.Length - 1)) {}
					attachment.Read(data, 0, CInt(attachment.Length))

                    Dim note = New Annotation() With
                               {
                                   .Subject = "Note subject...",
                                   .NoteText = "Note Details....",
                                   .DocumentBody = Convert.ToBase64String(data),
                                   .FileName = Path.GetFileName(attachment.Name),
                                   .MimeType = "text/plain",
                                   .Id = Guid.NewGuid(),
                                   .ObjectId = contact.ToEntityReference(),
                                   .ObjectTypeCode = contact.EntityLogicalName
                               }
                    ' Associate the note to the contact.
					_annotationId = note.Id
					Console.Write("Instantiating a note, ")
					_orgContext.AddObject(note)
					_orgContext.Attach(contact)
					' Set the contact as the Regarding attribute of the note.
					_orgContext.AddLink(contact, New Relationship("Contact_Annotation"), note)
					SaveChangesHelper(note, contact)
					Console.WriteLine("creating the note in CRM and linking to contact.")


					' Change the owning user of the contact Mary Kay Andersen
					' Find a user with an email address of "someone@example.com"
                    Dim newOwner As SystemUser = ( _
                                                From u In _orgContext.CreateQuery(Of SystemUser)() _
                                                Where u.InternalEMailAddress.Equals("someone@example.com") _
                                                Select u).Single()
                    Dim assignRequest As New AssignRequest() With
                                            {
                                                .Target = contact.ToEntityReference(),
                                            .Assignee = newOwner.ToEntityReference()
                                            }
                    _orgContext.Execute(assignRequest)
                    Console.WriteLine("Changing ownership of contact record.")

                    ' Create a new price list called Retail Price List.
                    Dim priceList = New PriceLevel() With
                                    {
                                        .Name = "Retail Price List",
                                        .BeginDate = Date.Now,
                                        .EndDate = Date.Now,
                                        .Description = "Contoso's primary pricelist.",
                                        .Id = Guid.NewGuid()
                                    }
                    _priceLevelId = priceList.Id
                    _orgContext.AddObject(priceList)
                    Console.Write("Instantiating price list, ")

                    ' Create a new quote for Contoso.
                    Dim newQuote = New Quote() With
                                   {
                                       .Name = "Quotation for Contoso",
                                       .PriceLevelId = priceList.ToEntityReference(),
                                       .Id = Guid.NewGuid(),
                                       .CustomerId = account.ToEntityReference()
                                   }
                    ' Sets the pricelist to the one we've just created
                    _quoteId = newQuote.Id
                    _orgContext.AddObject(newQuote)
                    _orgContext.Attach(account)
                    _orgContext.AddLink(newQuote,
                                        New Relationship("quote_customer_accounts"),
                                        account)
                    Console.Write("quote, ")

                    ' Create a new product called Widget A.
                    Dim newProduct =
                        New Product() With
                        {
                            .Name = "Widget A",
                            .Description = "Industrial widget for hi-tech industries",
                            .QuantityOnHand = 2,
                            .ProductNumber = "WIDG-A",
                            .Price = New Money(Decimal.Parse("12.50")),
                            .QuantityDecimal = 2,
                            .Id = Guid.NewGuid(),
                            .DefaultUoMScheduleId =
                            New EntityReference(UoMSchedule.EntityLogicalName,
                                                _orgContext.CreateQuery(Of UoMSchedule)().First().Id),
                            .DefaultUoMId =
                            New EntityReference(UoM.EntityLogicalName,
                                                _orgContext.CreateQuery(Of UoM)().First().Id)
                        }
                    _productId = newProduct.Id
                    _orgContext.AddObject(newProduct)
                    Console.Write("product, ")

                    ' Add Widget A to the Retail Price List.
                    Dim priceLevelProduct =
                        New ProductPriceLevel() With
                        {
                            .ProductId = newProduct.ToEntityReference(),
                            .UoMId = newProduct.DefaultUoMId,
                            .Amount = New Money(Decimal.Parse("12.50")),
                            .PriceLevelId = priceList.ToEntityReference(),
                            .Id = Guid.NewGuid()
                        }
                    _productPriceLevelId = priceLevelProduct.Id
                    _orgContext.AddObject(priceLevelProduct)
                    Console.Write("associating product to price list, ")

                    ' Add a quote product to this quote.
                    Dim quoteProduct = New QuoteDetail() With
                                       {
                                           .ProductId = newProduct.ToEntityReference(),
                                           .Quantity = 1,
                                           .QuoteId = newQuote.ToEntityReference(),
                                           .UoMId = newProduct.DefaultUoMId,
                                           .Id = Guid.NewGuid()
                                       }
                    _quoteDetailId = quoteProduct.Id
                    _orgContext.AddObject(quoteProduct)
                    Console.Write("adding product to quote, ")

                    ' Create a sales opportunity with Contoso.
                    Dim oppty = New Opportunity() With
                                {
                                    .Name = "Interested in Widget A",
                                    .EstimatedCloseDate = Date.Now.AddDays(30.0),
                                    .EstimatedValue = New Money(Decimal.Parse("300000.00")),
                                    .CloseProbability = 25,
                                    .IsRevenueSystemCalculated = False,
                                    .OpportunityRatingCode = New OptionSetValue(2),
                                    .CustomerId = account.ToEntityReference(),
                                    .Id = Guid.NewGuid()
                                }
                    _opportunityId = oppty.Id
                    _orgContext.AddObject(oppty)
                    Console.Write("instantiating opportunity, ")
                    '_orgContext.AddLink(
                    '    oppty,
                    '    new Relationship("opportunity_customer_accounts"),
                    '    account);
                    SaveChangesHelper(priceList, newQuote, newProduct,
                                      priceLevelProduct, quoteProduct, oppty, account)
                    Console.WriteLine("and creating all records in CRM.")

                    ' Associate quote to contact, which adds the Contact record in the
                    ' "Other Contacts" section of a Quote record.
                    _orgContext.Attach(contact)
                    _orgContext.Attach(newQuote)
                    _orgContext.AddLink(contact,
                                        New Relationship("contactquotes_association"),
                                        newQuote)
                    SaveChangesHelper(contact, newQuote)
                    Console.WriteLine("Associating contact and quote.")

                    ' Create a case for Mary Kay Andersen.                     
                    Dim serviceRequest =
                        New Incident() With
                        {
                            .Title = "Problem with Widget B",
                            .PriorityCode = New OptionSetValue(1),
                            .CaseOriginCode = New OptionSetValue(1),
                            .CaseTypeCode = New OptionSetValue(2),
                            .SubjectId =
                            New EntityReference(
                                Subject.EntityLogicalName,
                                _orgContext.CreateQuery(Of Subject)().First().Id),
                            .Description = "Customer can't switch the product on.",
                            .FollowupBy = Date.Now.AddHours(3.0),
                            .CustomerId = contact.ToEntityReference(),
                            .Id = Guid.NewGuid()
                        }
                    _incidentId = serviceRequest.Id
                    _orgContext.AddObject(serviceRequest)
                    _orgContext.Attach(contact)
                    _orgContext.AddLink(serviceRequest,
                                        New Relationship("incident_customer_contacts"),
                                        contact)
                    SaveChangesHelper(serviceRequest, contact)
                    Console.WriteLine("Creating service case for contact.")

                    ' Deactivate the Mary Kay Andersen contact record.
                    Dim setInactiveRequest As SetStateRequest =
                        New SetStateRequest With
                        {
                            .EntityMoniker = contact.ToEntityReference(),
                            .State = New OptionSetValue(CInt(Fix(ContactState.Inactive))),
                            .Status = New OptionSetValue(2)
                        }
                    _orgContext.Execute(setInactiveRequest)
                    Console.WriteLine("Deactivating the contact record.")

                    DeleteRequiredRecords(promptforDelete)
                End Using

			' Catch any service fault exceptions that Microsoft Dynamics CRM throws.
			Catch fe As FaultException(Of Microsoft.Xrm.Sdk.OrganizationServiceFault)
				' You can handle an exception here or pass it back to the calling method.
				Throw
			End Try
		End Sub

		Private Sub SaveChangesHelper(ParamArray ByVal entities() As Entity)
			Dim results As SaveChangesResultCollection = _orgContext.SaveChanges()
			If results.HasError Then
				DeleteRequiredRecords(False)
				Dim sb As New StringBuilder()
				For Each result In results
					If result.Error IsNot Nothing Then
						sb.AppendFormat("Error: {0}" &amp; vbLf, result.Error.Message)
					End If
				Next result
                Throw New InvalidOperationException("Failure occurred while " _
                                        &amp; "calling OrganizationServiceContext.SaveChanges()" _
                                        &amp; vbLf &amp; sb.ToString())
			Else
				For Each e As Entity In entities
					e.EntityState = Nothing
				Next e
			End If
		End Sub

		''' <summary>
		''' Creates any entity records that this sample requires.
		''' </summary>
		Public Sub CreateRequiredRecords()
			' Create a second user that we will reference in our sample code.
			Dim userId As Guid = SystemUserProvider.RetrieveSalesManager(_serviceProxy)

			' Modify email address of user for sample.
            Dim systemUser As SystemUser =
                New SystemUser With
                {
                    .Id = userId,
                    .InternalEMailAddress = "someone@example.com"
                }

			_service.Update(systemUser)
		End Sub

		''' <summary>
		''' Deletes any entity records that were created for this sample.
		''' <param name="prompt">Indicates whether to prompt the user 
		''' to delete the records created in this sample.</param>
		''' </summary>
		Public Sub DeleteRequiredRecords(ByVal prompt As Boolean)
			' The system user named "Kevin Cook" that was created by this sample will
			' continue to exist on your system because system users cannot be deleted
			' in Microsoft Dynamics CRM.  They can only be enabled or disabled.

			Dim deleteRecords As Boolean = True

			If prompt Then
				Console.WriteLine(vbLf &amp; "Do you want these entity records deleted? (y/n) [y]: ")
				Dim answer As String = Console.ReadLine()

                deleteRecords = (answer.StartsWith("y") OrElse answer.StartsWith("Y") _
                     OrElse answer = String.Empty)
			End If

			If deleteRecords Then
				_service.Delete(Incident.EntityLogicalName, _incidentId)
				_service.Delete(Opportunity.EntityLogicalName, _opportunityId)
				_service.Delete(QuoteDetail.EntityLogicalName, _quoteDetailId)
				_service.Delete(ProductPriceLevel.EntityLogicalName, _productPriceLevelId)
				_service.Delete(Product.EntityLogicalName, _productId)
				_service.Delete(Quote.EntityLogicalName, _quoteId)
				_service.Delete(PriceLevel.EntityLogicalName, _priceLevelId)
				_service.Delete(Annotation.EntityLogicalName, _annotationId)
				_service.Delete(Contact.EntityLogicalName, _contactId)
				_service.Delete(Account.EntityLogicalName, _accountId)
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

				Dim app As New BasicContextExamples()
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

' </snippetbasiccontextexamples>