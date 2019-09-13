' <snippetworkingwithleads1>


 ' Qualify the first lead, creating an account and a contact from it, but
 ' not creating an opportunity.
 Dim qualifyIntoAccountContactReq =
     New QualifyLeadRequest With
     {
         .CreateAccount = True,
         .CreateContact = True,
         .LeadId = New EntityReference(Lead.EntityLogicalName, _lead1Id),
         .Status = New OptionSetValue(CInt(Fix(lead_statuscode.Qualified)))
     }

 Dim qualifyIntoAccountContactRes =
     CType(_serviceProxy.Execute(qualifyIntoAccountContactReq), 
         QualifyLeadResponse)
 Console.WriteLine("  The first lead was qualified.")

' </snippetworkingwithleads1>