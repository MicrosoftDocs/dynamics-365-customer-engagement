' <snippetworkingwithrelatedattributesfornto1relationships1>


 ' Connect to the Organization service. 
 ' The using statement assures that the service proxy will be properly disposed.
 _serviceProxy = ServerConnection.GetOrganizationProxy(serverConfig)
 Using _serviceProxy
     ' This statement is required to enable early-bound type support.
     _serviceProxy.EnableProxyTypes()

     _service = CType(_serviceProxy, IOrganizationService)

     ' Create a lead.
     Dim lead As New Lead() With {.CompanyName = "Litware, Inc."}
     _leadId = _service.Create(lead)

     Console.Write("Lead created, ")

     ' Create a contact.
     Dim contact As New Contact() With {.FirstName = "Dan", .LastName = "Park", .Address1_Line1 = "23 Market St.", _
                                        .Address1_City = "Sammamish", .Address1_StateOrProvince = "MT", _
                                        .Address1_PostalCode = "99999", .Telephone1 = "12345678", _
                                        .EMailAddress1 = "dan@litwareinc.com"}
     _contactId = _service.Create(contact)
     contact.ContactId = _contactId

     Console.Write("contact created, ")

     ' Create a blank phone call.
     Dim phoneCall As New PhoneCall()
     _phoneCallId = _service.Create(phoneCall)

     Console.Write("phone call created, ")

     ' Create an ActivityParty for the phone call's "to" field.
     Dim activityParty As New ActivityParty() With {.PartyId = New EntityReference With { _
             .Id = _contactId, .LogicalName = contact.EntityLogicalName}, _
             .ActivityId = New EntityReference With { _
                 .Id = _phoneCallId, .LogicalName = phoneCall.EntityLogicalName}, _
                 .ParticipationTypeMask = New OptionSetValue(9)}

     ' Create a phone call and add the properties we are updating.
     Dim updatePhoneCall As New PhoneCall() With { _
         .Id = _phoneCallId, .Subject = "Test Phone Call", .RegardingObjectId = New EntityReference With { _
             .Id = _leadId, .LogicalName = lead.EntityLogicalName}, .To = New ActivityParty() {activityParty}}

     ' Update the phone call.
     Dim updateRequest As New UpdateRequest() With {.Target = updatePhoneCall}
     _service.Execute(updateRequest)

     Console.Write("phone call updated." &amp; vbLf)

     DeleteRequiredRecords(promptforDelete)
 End Using

' </snippetworkingwithrelatedattributesfornto1relationships1>