// <snippetworkingwithleads1>


 // Qualify the first lead, creating an account and a contact from it, but
 // not creating an opportunity.
 var qualifyIntoAccountContactReq = new QualifyLeadRequest
 {
     CreateAccount = true,
     CreateContact = true,
     LeadId = new EntityReference(Lead.EntityLogicalName, _lead1Id),
     Status = new OptionSetValue((int)lead_statuscode.Qualified)
 };

 var qualifyIntoAccountContactRes = 
     (QualifyLeadResponse)_serviceProxy.Execute(qualifyIntoAccountContactReq);
 Console.WriteLine("  The first lead was qualified.");

// </snippetworkingwithleads1>