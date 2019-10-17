// <snippetworkingwithactivityparties1>


                // Connect to the Organization service. 
                // The using statement assures that the service proxy will be properly disposed.
                using (_serviceProxy = new OrganizationServiceProxy(serverConfig.OrganizationUri, serverConfig.HomeRealmUri,serverConfig.Credentials, serverConfig.DeviceCredentials))
                {
                    // This statement is required to enable early-bound type support.
                    _serviceProxy.EnableProxyTypes();

                    CreateRequiredRecords();

                    OrganizationServiceContext orgContext =
                        new OrganizationServiceContext(_serviceProxy);

                    // Retrieve the Contact records that we created previously.
                    List<Contact> contacts = (from c in orgContext.CreateQuery<Contact>()
                                              where c.Address1_City == "Sammamish"
                                              select new Contact
                                              {
                                                  ContactId = c.ContactId,
                                                  FirstName = c.FirstName,
                                                  LastName = c.LastName
                                              }).ToList<Contact>();
                    Console.Write("Contacts retrieved, ");

                    // Create an Activity Party record for each Contact.
                    var activityParty1 = new ActivityParty
                    {
                        PartyId = new EntityReference(Contact.EntityLogicalName,
                            contacts[0].ContactId.Value),
                    };

                    var activityParty2 = new ActivityParty
                    {
                        PartyId = new EntityReference(Contact.EntityLogicalName,
                            contacts[1].ContactId.Value),
                    };

                    var activityParty3 = new ActivityParty
                    {
                        PartyId = new EntityReference(Contact.EntityLogicalName,
                            contacts[2].ContactId.Value),
                    };

                    Console.Write("ActivityParty instances created, ");

                    // Create Letter Activity and set From and To fields to the
                    // respective Activity Party entities.
                    var letter = new Letter
                    {
                        RegardingObjectId = new EntityReference(Contact.EntityLogicalName,
                            contacts[2].ContactId.Value),
                        Subject = "Sample Letter Activity",
                        ScheduledEnd = DateTime.Now + TimeSpan.FromDays(5),
                        Description = @"Greetings, Mr. Andreshak,

This is a sample letter activity as part of the Microsoft Dynamics CRM SDK.

Sincerely,
Mary Kay Andersen

cc: Denise Smith",
                        From = new ActivityParty[] { activityParty1 },
                        To = new ActivityParty[] { activityParty3, activityParty2 }
                    };
                    orgContext.AddObject(letter);
                    orgContext.SaveChanges();

                    Console.WriteLine("and Letter Activity created.");

                    DeleteRequiredRecords(promptforDelete);
                }

// </snippetworkingwithactivityparties1>