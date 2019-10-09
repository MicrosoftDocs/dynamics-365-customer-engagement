// <snippetbasiccontextexamples>


using System;
using System.IO;
using System.Linq;
using System.ServiceModel;
using System.Text;

// These namespaces are found in the Microsoft.Xrm.Sdk.dll assembly
// located in the SDK\bin folder of the SDK download.
using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Client;

// These namespaces are found in the Microsoft.Crm.Sdk.Proxy.dll assembly
// located in the SDK\bin folder of the SDK download.
using Microsoft.Crm.Sdk.Messages;

namespace Microsoft.Crm.Sdk.Samples
{
    /// <summary>
    /// Demonstrates how to do use the OrganizationServiceContext to work with multiple
    /// records simultaneously.</summary>
    /// <remarks>
    /// NOTE: To execute file attachment step, you must have a text file named
    /// "sample.txt" in the folder in which this code is executed.
    /// 
    /// At run-time, you will be given the option to delete all the
    /// database records created by this program.</remarks>
    public class BasicContextExamples
    {
        #region Class Level Members

        private Guid _accountId;
        private Guid _contactId;
        private Guid _annotationId;
        private Guid _priceLevelId;
        private Guid _quoteId;
        private Guid _productId;
        private Guid _productPriceLevelId;
        private Guid _quoteDetailId;
        private Guid _opportunityId;
        private Guid _incidentId;
        private OrganizationServiceProxy _serviceProxy;
        private OrganizationServiceContext _orgContext;
        private IOrganizationService _service;

        #endregion Class Level Members

        #region How To Sample Code
        /// <summary>
        /// This method first connects to the Organization service and creates the
        /// OrganizationServiceContext. Then, several entity creation and relationship
        /// operations are performed.
        /// </summary>
        /// <param name="serverConfig">Contains server connection information.</param>
        /// <param name="promptforDelete">When True, the user will be prompted to delete all
        /// created entities.</param>
        public void Run(ServerConnection.Configuration serverConfig, bool promptforDelete)
        {
            try
            {
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
            }

            // Catch any service fault exceptions that Microsoft Dynamics CRM throws.
            catch (FaultException<Microsoft.Xrm.Sdk.OrganizationServiceFault>)
            {
                // You can handle an exception here or pass it back to the calling method.
                throw;
            }
        }

        private void SaveChangesHelper(params Entity[] entities)
        {
            SaveChangesResultCollection results = _orgContext.SaveChanges();
            if (results.HasError)
            {
                DeleteRequiredRecords(false);
                StringBuilder sb = new StringBuilder();
                foreach (var result in results)
                {
                    if (result.Error != null)
                    {
                        sb.AppendFormat("Error: {0}\n", result.Error.Message);
                    }
                }
                throw new InvalidOperationException("Failure occurred while " +
                    "calling OrganizationServiceContext.SaveChanges()\n" + 
                    sb.ToString());
            }
            else
            {
                foreach (Entity e in entities)
                {
                    e.EntityState = null;
                }
            }
        }

        /// <summary>
        /// Creates any entity records that this sample requires.
        /// </summary>
        public void CreateRequiredRecords()
        {
            // Create a second user that we will reference in our sample code.
            Guid userId = SystemUserProvider.RetrieveSalesManager(_serviceProxy);

            // Modify email address of user for sample.
            SystemUser systemUser = new SystemUser
            {
                Id = userId,
                InternalEMailAddress = "someone@example.com"
            };

            _service.Update(systemUser);
        }

        /// <summary>
        /// Deletes any entity records that were created for this sample.
        /// <param name="prompt">Indicates whether to prompt the user 
        /// to delete the records created in this sample.</param>
        /// </summary>
        public void DeleteRequiredRecords(bool prompt)
        {
            // The system user named "Kevin Cook" that was created by this sample will
            // continue to exist on your system because system users cannot be deleted
            // in Microsoft Dynamics CRM.  They can only be enabled or disabled.

            bool deleteRecords = true;

            if (prompt)
            {
                Console.WriteLine("\nDo you want these entity records deleted? (y/n) [y]: ");
                String answer = Console.ReadLine();

                deleteRecords = (answer.StartsWith("y") || answer.StartsWith("Y") || answer == String.Empty);
            }

            if (deleteRecords)
            {
                _service.Delete(Incident.EntityLogicalName, _incidentId);
                _service.Delete(Opportunity.EntityLogicalName, _opportunityId);
                _service.Delete(QuoteDetail.EntityLogicalName, _quoteDetailId);
                _service.Delete(ProductPriceLevel.EntityLogicalName, _productPriceLevelId);
                _service.Delete(Product.EntityLogicalName, _productId);
                _service.Delete(Quote.EntityLogicalName, _quoteId);
                _service.Delete(PriceLevel.EntityLogicalName, _priceLevelId);
                _service.Delete(Annotation.EntityLogicalName, _annotationId);
                _service.Delete(Contact.EntityLogicalName, _contactId);
                _service.Delete(Account.EntityLogicalName, _accountId);
                Console.WriteLine("Entity record(s) have been deleted.");
            }
        }

        #endregion How To Sample Code

        #region Main method

        /// <summary>
        /// Standard Main() method used by most SDK samples.
        /// </summary>
        /// <param name="args"></param>
        static public void Main(string[] args)
        {
            try
            {
                // Obtain the target organization's Web address and client logon 
                // credentials from the user.
                ServerConnection serverConnect = new ServerConnection();
                ServerConnection.Configuration config = serverConnect.GetServerConfiguration();

                BasicContextExamples app = new BasicContextExamples();
                app.Run(config, true);
            }
            catch (FaultException<Microsoft.Xrm.Sdk.OrganizationServiceFault> ex)
            {
                Console.WriteLine("The application terminated with an error.");
                Console.WriteLine("Timestamp: {0}", ex.Detail.Timestamp);
                Console.WriteLine("Code: {0}", ex.Detail.ErrorCode);
                Console.WriteLine("Message: {0}", ex.Detail.Message);
                Console.WriteLine("Plugin Trace: {0}", ex.Detail.TraceText);
                Console.WriteLine("Inner Fault: {0}",
                    null == ex.Detail.InnerFault ? "No Inner Fault" : "Has Inner Fault");
            }
            catch (System.TimeoutException ex)
            {
                Console.WriteLine("The application terminated with an error.");
                Console.WriteLine("Message: {0}", ex.Message);
                Console.WriteLine("Stack Trace: {0}", ex.StackTrace);
                Console.WriteLine("Inner Fault: {0}",
                    null == ex.InnerException.Message ? "No Inner Fault" : ex.InnerException.Message);
            }
            catch (System.Exception ex)
            {
                Console.WriteLine("The application terminated with an error.");
                Console.WriteLine(ex.Message);

                // Display the details of the inner exception.
                if (ex.InnerException != null)
                {
                    Console.WriteLine(ex.InnerException.Message);

                    FaultException<Microsoft.Xrm.Sdk.OrganizationServiceFault> fe = ex.InnerException
                        as FaultException<Microsoft.Xrm.Sdk.OrganizationServiceFault>;
                    if (fe != null)
                    {
                        Console.WriteLine("Timestamp: {0}", fe.Detail.Timestamp);
                        Console.WriteLine("Code: {0}", fe.Detail.ErrorCode);
                        Console.WriteLine("Message: {0}", fe.Detail.Message);
                        Console.WriteLine("Plugin Trace: {0}", fe.Detail.TraceText);
                        Console.WriteLine("Inner Fault: {0}",
                            null == fe.Detail.InnerFault ? "No Inner Fault" : "Has Inner Fault");
                    }
                }
            }
            // Additional exceptions to catch: SecurityTokenValidationException, ExpiredSecurityTokenException,
            // SecurityAccessDeniedException, MessageSecurityException, and SecurityNegotiationException.

            finally
            {
                Console.WriteLine("Press <Enter> to exit.");
                Console.ReadLine();
            }
        }
        #endregion Main method
    }
}

// </snippetbasiccontextexamples>