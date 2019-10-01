' <snippetassociatedisassociatede1>


 ' The account ID would typically be passed in as an argument or determined by a query.
 ' The contact ID would typically be passed in as an argument or determined by a query.
 ' Associate the accounts to the contact record.

 'Create a collection of the entity ids that will be associated to the contact.
 Dim relatedEntities As New EntityReferenceCollection()
 relatedEntities.Add(New EntityReference("account", _account1Id))
 relatedEntities.Add(New EntityReference("account", _account2Id))
 relatedEntities.Add(New EntityReference("account", _account3Id))

 ' Create an object that defines the relationship between the contact and account.
 Dim relationship As New Relationship("account_primary_contact")

 'Associate the contact with the 3 accounts.
 _service.Associate("contact", _contactId, relationship, relatedEntities)

 Console.WriteLine("The entities have been associated.")

 'Disassociate the records.
 _service.Disassociate("contact", _contactId, relationship, relatedEntities)

' </snippetassociatedisassociatede1>