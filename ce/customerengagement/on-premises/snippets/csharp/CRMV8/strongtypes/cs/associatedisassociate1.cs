// <snippetassociatedisassociate1>


 // Associate the accounts to the contact record.

 // Create a collection of the entities that will be 
 // associated to the contact.
 EntityReferenceCollection relatedEntities = new EntityReferenceCollection();
 relatedEntities.Add(new EntityReference(Account.EntityLogicalName, _account1Id));
 relatedEntities.Add(new EntityReference(Account.EntityLogicalName, _account2Id));
 relatedEntities.Add(new EntityReference(Account.EntityLogicalName, _account3Id));

 // Create an object that defines the relationship between the contact and account.
 Relationship relationship = new Relationship("account_primary_contact");


 //Associate the contact with the 3 accounts.
 _service.Associate(Contact.EntityLogicalName, _contactId, relationship,
     relatedEntities);

 Console.WriteLine("The entities have been associated.");

 //Disassociate the records.
 _service.Disassociate(Contact.EntityLogicalName, _contactId, relationship,
     relatedEntities);

// </snippetassociatedisassociate1>