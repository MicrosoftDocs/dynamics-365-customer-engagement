// <snippetworkingwithrelatedattributesfornto1relationships1>


 // Connect to the Organization service. 
 // The using statement assures that the service proxy will be properly disposed.
 using (_serviceProxy = new OrganizationServiceProxy(serverConfig.OrganizationUri, serverConfig.HomeRealmUri,serverConfig.Credentials, serverConfig.DeviceCredentials))
 {
     // This statement is required to enable early-bound type support.
     _serviceProxy.EnableProxyTypes();

     _service = (IOrganizationService)_serviceProxy;

     // Create a lead.
     Lead lead = new Lead()
     {
         CompanyName = "Litware, Inc."
     };
     _leadId = _service.Create(lead);

     Console.Write("Lead created, ");

     // Create a contact.
     Contact contact = new Contact()
     {
         FirstName = "Dan",
         LastName = "Park",
         Address1_Line1 = "23 Market St.",
         Address1_City = "Sammamish",
         Address1_StateOrProvince = "MT",
         Address1_PostalCode = "99999",
         Telephone1 = "12345678",
         EMailAddress1 = "dan@litwareinc.com"
     };
     _contactId = _service.Create(contact);
     contact.ContactId = _contactId;

     Console.Write("contact created, ");

     // Create a blank phone call.
     PhoneCall phoneCall = new PhoneCall();
     _phoneCallId = _service.Create(phoneCall);

     Console.Write("phone call created, ");

     // Create an ActivityParty for the phone call's "to" field.
     ActivityParty activityParty = new ActivityParty()
     {
         PartyId = new EntityReference
         {
             Id = _contactId,
             LogicalName = Contact.EntityLogicalName,
         },
         ActivityId = new EntityReference
         {
             Id = _phoneCallId,
             LogicalName = PhoneCall.EntityLogicalName,
         },
         ParticipationTypeMask = new OptionSetValue(9)
     };

     // Create a phone call and add the properties we are updating.
     PhoneCall updatePhoneCall = new PhoneCall()
     {
         Id = _phoneCallId,
         Subject = "Test Phone Call",
         RegardingObjectId = new EntityReference
         {
             Id = _leadId,
             LogicalName = Lead.EntityLogicalName
         },
         To = new ActivityParty[] { activityParty }
     };

     // Update the phone call.
     UpdateRequest updateRequest = new UpdateRequest()
     {
         Target = updatePhoneCall
     };
     _service.Execute(updateRequest);

     Console.Write("phone call updated.\n");

     DeleteRequiredRecords(promptforDelete);
 }

// </snippetworkingwithrelatedattributesfornto1relationships1>