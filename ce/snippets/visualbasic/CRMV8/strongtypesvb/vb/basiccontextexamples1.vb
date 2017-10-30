' <snippetbasiccontextexamples1>


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

' </snippetbasiccontextexamples1>