// <snippetsendemailusingtemplate1>



 // Create the 'From:' activity party for the email
 ActivityParty fromParty = new ActivityParty
 {
     PartyId = new EntityReference(SystemUser.EntityLogicalName, _userId)
 };

 // Create the 'To:' activity party for the email
 ActivityParty toParty = new ActivityParty
 {
     PartyId = new EntityReference(Contact.EntityLogicalName, _contactId)
 };

 Console.WriteLine("Created activity parties.");

 // Create an e-mail message.
 Email email = new Email
 {
     To = new ActivityParty[] { toParty },
     From = new ActivityParty[] { fromParty },
     Subject = "SDK Sample e-mail",
     Description = "SDK Sample for SendEmailFromTemplate Message.",
     DirectionCode = true
 };

 //Create a query expression to get one of Email Template of type "contact"

 QueryExpression queryBuildInTemplates = new QueryExpression{
     EntityName = "template",
     ColumnSet = new ColumnSet("templateid", "templatetypecode"),
     Criteria = new FilterExpression()
 };
 queryBuildInTemplates.Criteria.AddCondition("templatetypecode",
     ConditionOperator.Equal, "contact");
 EntityCollection templateEntityCollection = _serviceProxy.RetrieveMultiple(queryBuildInTemplates);

 if (templateEntityCollection.Entities.Count > 0) 
 {
     _templateId = (Guid)templateEntityCollection.Entities[0].Attributes["templateid"];
 }
 else
 {
     throw new ArgumentException("Standard Email Templates are missing");
 }             

 // Create the request
 SendEmailFromTemplateRequest emailUsingTemplateReq = new SendEmailFromTemplateRequest
 {
     Target = email,

     // Use a built-in Email Template of type "contact".
     TemplateId = _templateId,

     // The regarding Id is required, and must be of the same type as the Email Template.
     RegardingId = _contactId,
     RegardingType = Contact.EntityLogicalName
 };

 SendEmailFromTemplateResponse emailUsingTemplateResp = (SendEmailFromTemplateResponse)_serviceProxy.Execute(emailUsingTemplateReq);

 // Verify that the e-mail has been created
 _emailId = emailUsingTemplateResp.Id;
 if (!_emailId.Equals(Guid.Empty))
 {
     Console.WriteLine("Successfully sent an e-mail message using the template.");
 }

// </snippetsendemailusingtemplate1>