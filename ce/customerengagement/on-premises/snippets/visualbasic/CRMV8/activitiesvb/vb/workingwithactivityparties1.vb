' <snippetworkingwithactivityparties1>


 ' Connect to the Organization service. 
 ' The using statement assures that the service proxy will be properly disposed.
 _serviceProxy = ServerConnection.GetOrganizationProxy(serverConfig)
 Using _serviceProxy
     ' This statement is required to enable early-bound type support.
     _serviceProxy.EnableProxyTypes()

     CreateRequiredRecords()

     Dim orgContext As New OrganizationServiceContext(_serviceProxy)

     ' Retrieve the Contact records that we created previously.
     Dim contacts As List(Of Contact) = ( _
         From c In orgContext.CreateQuery(Of Contact)() _
         Where c.Address1_City.Equals("Sammamish") _
         Select New Contact With
                {
                    .ContactId = c.ContactId,
                    .FirstName = c.FirstName,
                    .LastName = c.LastName
                }).ToList()
     Console.Write("Contacts retrieved, ")

     ' Create an Activity Party record for each Contact.
     Dim activityParty1 =
         New ActivityParty With
             {
                 .PartyId =
                 New EntityReference(Contact.EntityLogicalName,
                                     contacts(0).ContactId.Value)
             }

     Dim activityParty2 = New ActivityParty With
                          {
                              .PartyId =
                              New EntityReference(
                                  Contact.EntityLogicalName,
                                  contacts(1).ContactId.Value)
                          }

     Dim activityParty3 =
         New ActivityParty With
         {
             .PartyId = New EntityReference(Contact.EntityLogicalName,
                                            contacts(2).ContactId.Value)
         }

     Console.Write("ActivityParty instances created, ")

     ' Create Letter Activity and set From and To fields to the
     ' respective Activity Party entities.
     Dim letter = New Letter With
                  {
                      .RegardingObjectId =
                      New EntityReference(
                          Contact.EntityLogicalName,
                          contacts(2).ContactId.Value),
                      .Subject = "Sample Letter Activity",
                      .ScheduledEnd = Date.Now.Add(TimeSpan.FromDays(5)),
                      .Description = "Greetings, Mr. Andreshak, " _
                                     &amp; "This is a sample letter activity " _
                                     &amp; "as part of the " _
                                     &amp; "Microsoft Dynamics CRM SDK. " _
                                     &amp; "Sincerely, Mary Kay Andersen " _
                                     &amp; "cc: Denise Smith",
                      .From = New ActivityParty() {activityParty1},
                      .To = New ActivityParty() {
                          activityParty3,
                          activityParty2}
                  }
     orgContext.AddObject(letter)
     orgContext.SaveChanges()

     Console.WriteLine("and Letter Activity created.")

     DeleteRequiredRecords(promptforDelete)
 End Using

' </snippetworkingwithactivityparties1>