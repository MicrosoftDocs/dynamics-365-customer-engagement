// <snippetbasiccontextexamples1>


 // Connect to the Organization service. 
 // The using statement assures that the service proxy will be properly disposed.
 using (_serviceProxy = new OrganizationServiceProxy(serverConfig.OrganizationUri, serverConfig.HomeRealmUri,
                                                      serverConfig.Credentials, serverConfig.DeviceCredentials))
 {
     // This statement is required to enable early-bound type support.
     _serviceProxy.EnableProxyTypes();

     _service = (IOrganizationService)_serviceProxy;
     
     CreateRequiredRecords();

     // The OrganizationServiceContext is an object that wraps the service
     // proxy and allows creating/updating multiple records simultaneously.
     _orgContext = new OrganizationServiceContext(_service);

     // Create a new contact called Mary Kay Andersen.
     var contact = new Contact()
     {
         FirstName = "Mary Kay",
         LastName = "Andersen",
         Address1_Line1 = "23 Market St.",
         Address1_City = "Sammamish",
         Address1_StateOrProvince = "MT",
         Address1_PostalCode = "99999",
         Telephone1 = "12345678",
         EMailAddress1 = "marykay@contoso.com",
         Id = Guid.NewGuid()
     };
     _contactId = contact.Id;
     _orgContext.AddObject(contact);
     Console.Write("Instantiating contact, ");

     // Create an account called Contoso.
     var account = new Account()
     {
         Name = "Contoso",
         Address1_City = "Redmond",
         // set the account category to 'Preferred Customer'
         AccountCategoryCode = new OptionSetValue(1), 
         LastUsedInCampaign = DateTime.Now,
         MarketCap = new Money(120000),
         DoNotEMail = true,
         Description = "Contoso is a fictional company!",
         Id = Guid.NewGuid(),
     };
     _accountId = account.Id;
     Console.Write("instantiating account, ");

     // Set Mary Kay Andersen as the primary contact
     _orgContext.AddRelatedObject(
         contact,
         new Relationship("account_primary_contact"),
         account);
     SaveChangesHelper(contact, account);
     Console.WriteLine("and creating both records in CRM.");

     // Remove the primary contact value from Mary Kay Andersen
     _orgContext.Attach(contact);
     _orgContext.DeleteLink(
         contact,
         new Relationship("account_primary_contact"),
         account);
     SaveChangesHelper(contact, account);
     Console.Write("Removing primary contact status, ");

     // Add Mary Kay Andersen to the contact list for the account Contoso.
     _orgContext.Attach(account);
     _orgContext.Attach(contact);
     _orgContext.AddLink(
         account,
         new Relationship("contact_customer_accounts"),
         contact);
     SaveChangesHelper(contact, account);
     Console.WriteLine("and adding contact to account's contact list.");

     // Add a note with a document attachment to the contact's record.
     var attachment = File.OpenRead("sample.txt");
     var data = new byte[attachment.Length];
     attachment.Read(data, 0, (int)attachment.Length);

     var note = new Annotation()
     {
         Subject = "Note subject...",
         NoteText = "Note Details....",
         DocumentBody = Convert.ToBase64String(data),
         FileName = Path.GetFileName(attachment.Name),
         MimeType = "text/plain",
         Id = Guid.NewGuid(),
         // Associate the note to the contact.
         ObjectId = contact.ToEntityReference(),
         ObjectTypeCode = Contact.EntityLogicalName
     };
     _annotationId = note.Id;
     Console.Write("Instantiating a note, ");
     _orgContext.AddObject(note);
     _orgContext.Attach(contact);
     // Set the contact as the Regarding attribute of the note.
     _orgContext.AddLink(
         contact,
         new Relationship("Contact_Annotation"),
         note);
     SaveChangesHelper(note, contact);
     Console.WriteLine("creating the note in CRM and linking to contact.");

     // Change the owning user of the contact Mary Kay Andersen
     // Find a user with an email address of "someone@example.com"
     var newOwner = (from u in _orgContext.CreateQuery<SystemUser>()
                     where u.InternalEMailAddress == "someone@example.com"
                     select u).Single();
     AssignRequest assignRequest = new AssignRequest()
     {
         Target = contact.ToEntityReference(),
         Assignee = newOwner.ToEntityReference()
     };
     _orgContext.Execute(assignRequest);
     Console.WriteLine("Changing ownership of contact record.");

     // Create a new price list called Retail Price List.
     var priceList = new PriceLevel()
     {
         Name = "Retail Price List",
         BeginDate = DateTime.Now,
         EndDate = DateTime.Now,
         Description = "Contoso's primary pricelist.",
         Id = Guid.NewGuid()
     };
     _priceLevelId = priceList.Id;
     _orgContext.AddObject(priceList);
     Console.Write("Instantiating price list ");
     
     // Create a new product called Widget A.
     var newProduct = new Product()
     {
         Name = "Widget A",
         Description = "Industrial widget for hi-tech industries",
         ProductStructure = new OptionSetValue(1), // 1 = Product
         QuantityOnHand = 2,
         ProductNumber = "WIDG-A",
         Price = new Money(decimal.Parse("12.50")),
         QuantityDecimal = 2, // Sets the Decimals Supported value
         Id = Guid.NewGuid(),
         DefaultUoMScheduleId = new EntityReference(
                 UoMSchedule.EntityLogicalName,
                 _orgContext.CreateQuery<UoMSchedule>().First().Id),
         DefaultUoMId = new EntityReference(
                 UoM.EntityLogicalName,
                 _orgContext.CreateQuery<UoM>().First().Id)
     };
     _productId = newProduct.Id;
     _orgContext.AddObject(newProduct);
     Console.WriteLine("and product.");
     SaveChangesHelper(priceList, newProduct);

     // Add Widget A to the Retail Price List.
     var priceLevelProduct = new ProductPriceLevel()
     {
         ProductId = newProduct.ToEntityReference(),
         UoMId = newProduct.DefaultUoMId,
         Amount = new Money(decimal.Parse("12.50")),
         PriceLevelId = priceList.ToEntityReference(),
         Id = Guid.NewGuid()
     };
     _productPriceLevelId = priceLevelProduct.Id;
     _orgContext.AddObject(priceLevelProduct);
     Console.Write("Associating product to price list, ");

     // Publish the product
     SetStateRequest publishRequest = new SetStateRequest
     {
         EntityMoniker = newProduct.ToEntityReference(),
         State = new OptionSetValue((int)ProductState.Active),
         Status = new OptionSetValue(1)
     };
     _serviceProxy.Execute(publishRequest);
     Console.WriteLine("and publishing the product.");
     

     // Create a new quote for Contoso.
     var newQuote = new Quote()
     {
         Name = "Quotation for Contoso",
         // Sets the pricelist to the one we've just created
         PriceLevelId = priceList.ToEntityReference(),
         Id = Guid.NewGuid(),
         CustomerId = account.ToEntityReference()
     };
     _quoteId = newQuote.Id;
     _orgContext.AddObject(newQuote);
     _orgContext.Attach(account);
     _orgContext.AddLink(
         newQuote,
         new Relationship("quote_customer_accounts"),
         account);
     Console.Write("Instantiating a quote, ");

     // Add a quote product to this quote.
     var quoteProduct = new QuoteDetail()
     {
         ProductId = newProduct.ToEntityReference(),
         Quantity = 1,
         QuoteId = newQuote.ToEntityReference(),
         UoMId = newProduct.DefaultUoMId,
         Id = Guid.NewGuid()
     };
     _quoteDetailId = quoteProduct.Id;
     _orgContext.AddObject(quoteProduct);
     Console.WriteLine("and adding product to quote.");

     // Create a sales opportunity with Contoso.
     var oppty = new Opportunity()
     {
         Name = "Interested in Widget A",
         EstimatedCloseDate = DateTime.Now.AddDays(30.0),
         EstimatedValue = new Money(decimal.Parse("300000.00")),
         CloseProbability = 25, // 25% probability of closing this deal
         IsRevenueSystemCalculated = false, // user-calculated revenue
         OpportunityRatingCode = new OptionSetValue(2), // warm
         CustomerId = account.ToEntityReference(),
         Id = Guid.NewGuid()
     };
     _opportunityId = oppty.Id;
     _orgContext.AddObject(oppty);
     Console.Write("Instantiating opportunity, ");
     //_orgContext.AddLink(
     //    oppty,
     //    new Relationship("opportunity_customer_accounts"),
     //    account);
     SaveChangesHelper(priceList, newQuote, newProduct, priceLevelProduct,
         quoteProduct, oppty, account);
     Console.WriteLine("and creating all records in CRM.");

     // Associate quote to contact, which adds the Contact record in the
     // "Other Contacts" section of a Quote record.
     _orgContext.Attach(contact);
     _orgContext.Attach(newQuote);
     _orgContext.AddLink(
         contact,
         new Relationship("contactquotes_association"),
         newQuote);
     SaveChangesHelper(contact, newQuote);
     Console.WriteLine("Associating contact and quote.");

     // Create a case for Mary Kay Andersen.                     
     var serviceRequest = new Incident()
     {
         Title = "Problem with Widget B",
         PriorityCode = new OptionSetValue(1), // 1 = High
         CaseOriginCode = new OptionSetValue(1), // 1 = Phone
         CaseTypeCode = new OptionSetValue(2), // 2 = Problem
         SubjectId =
             new EntityReference(
                 Subject.EntityLogicalName,
                 _orgContext.CreateQuery<Subject>()
                     .First().Id),  // use the default subject
         Description = "Customer can't switch the product on.",
         FollowupBy = DateTime.Now.AddHours(3.0), // follow-up in 3 hours
         CustomerId = contact.ToEntityReference(),
         Id = Guid.NewGuid()
     };
     _incidentId = serviceRequest.Id;
     _orgContext.AddObject(serviceRequest);
     _orgContext.Attach(contact);
     _orgContext.AddLink(
         serviceRequest,
         new Relationship("incident_customer_contacts"),
         contact);
     SaveChangesHelper(serviceRequest, contact);
     Console.WriteLine("Creating service case for contact.");

     // Deactivate the Mary Kay Andersen contact record.
     SetStateRequest setInactiveRequest = new SetStateRequest
     {
         EntityMoniker = contact.ToEntityReference(),
         State = new OptionSetValue((int)ContactState.Inactive),
         Status = new OptionSetValue(2)
     };
     _orgContext.Execute(setInactiveRequest);
     Console.WriteLine("Deactivating the contact record.");

     DeleteRequiredRecords(promptforDelete);
 }

// </snippetbasiccontextexamples1>