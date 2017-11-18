' <snippetcompoundcreateupdate1>


 'Define the account for which we will add letters                
 Dim accountToCreate As Account = New Account With {.Name = "Example Account"}

 'Define the IDs of the related letters we will create
 _letterIds = { Guid.NewGuid(), Guid.NewGuid(), Guid.NewGuid() }

 'This acts as a container for each letter we create. Note that we haven't
 'define the relationship between the letter and account yet.
 Dim relatedLettersToCreate As EntityCollection = New EntityCollection With {.EntityName = Letter.EntityLogicalName}
 relatedLettersToCreate.Entities.Add(New Letter With {.Subject = "Letter 1", .ActivityId = _letterIds(0)})
 relatedLettersToCreate.Entities.Add(New Letter With {.Subject = "Letter 2", .ActivityId = _letterIds(1)})
 relatedLettersToCreate.Entities.Add(New Letter With {.Subject = "Letter 3", .ActivityId = _letterIds(2)})

 'Creates the reference between which relationship between Letter and
 'Account we would like to use.
 Dim letterRelationship As New Relationship("Account_Letters")

 'Adds the letters to the account under the specified relationship
 accountToCreate.RelatedEntities.Add(letterRelationship, relatedLettersToCreate)

 'Passes the Account (which contains the letters)
 _accountId = _service.Create(accountToCreate)

 Console.WriteLine("An account and {0} letters were created.", _letterIds.Length)


 'Now we run through many of the same steps as the above "Create" example
 Dim accountToUpdate As Account = New Account With {.Name = "Example Account - Updated", .AccountId = _accountId}

 Dim relatedLettersToUpdate As EntityCollection = New EntityCollection With {.EntityName = Letter.EntityLogicalName}
 relatedLettersToUpdate.Entities.Add(New Letter With {.Subject = "Letter 1 - Updated", .ActivityId = _letterIds(0)})
 relatedLettersToUpdate.Entities.Add(New Letter With {.Subject = "Letter 2 - Updated", .ActivityId = _letterIds(1)})
 relatedLettersToUpdate.Entities.Add(New Letter With {.Subject = "Letter 3 - Updated", .ActivityId = _letterIds(2)})

 accountToUpdate.RelatedEntities.Add(letterRelationship, relatedLettersToUpdate)

 'This will update the account as well as all of the related letters
 _service.Update(accountToUpdate)
 Console.WriteLine("An account and {0} letters were updated.", _letterIds.Length)

' </snippetcompoundcreateupdate1>