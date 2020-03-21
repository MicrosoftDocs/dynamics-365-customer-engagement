' <snippetassociatedisassociate1>


 ' Associate the accounts to the contact record.

 ' Create a collection of the entities that will be 
 ' associated to the contact.
 Dim relatedEntities As New EntityReferenceCollection()
 relatedEntities.Add(New EntityReference(Account.EntityLogicalName, _account1Id))
 relatedEntities.Add(New EntityReference(Account.EntityLogicalName, _account2Id))
 relatedEntities.Add(New EntityReference(Account.EntityLogicalName, _account3Id))

 ' Create an object that defines the relationship between the contact and account.
 Dim relationship As New Relationship("account_primary_contact")


 'Associate the contact with the 3 accounts.
 _service.Associate(Contact.EntityLogicalName, _contactId, relationship, relatedEntities)

 Console.WriteLine("The entities have been associated.")

 'Disassociate the records.
 _service.Disassociate(Contact.EntityLogicalName, _contactId, relationship, relatedEntities)

' </snippetassociatedisassociate1>