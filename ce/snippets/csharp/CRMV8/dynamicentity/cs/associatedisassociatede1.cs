// <snippetassociatedisassociatede1>


 // The account ID would typically be passed in as an argument or determined by a query.
 // The contact ID would typically be passed in as an argument or determined by a query.
 // Associate the accounts to the contact record.

 //Create a collection of the entity ids that will be associated to the contact.
 EntityReferenceCollection relatedEntities = new EntityReferenceCollection();
 relatedEntities.Add(new EntityReference("account", _account1Id));
 relatedEntities.Add(new EntityReference("account", _account2Id));
 relatedEntities.Add(new EntityReference("account", _account3Id));

 // Create an object that defines the relationship between the contact and account.
 Relationship relationship = new Relationship("account_primary_contact");

 //Associate the contact with the 3 accounts.
 _service.Associate("contact", _contactId, relationship, relatedEntities);

 Console.WriteLine("The entities have been associated.");

 //Disassociate the records.
 _service.Disassociate("contact", _contactId, relationship, relatedEntities);

// </snippetassociatedisassociatede1>