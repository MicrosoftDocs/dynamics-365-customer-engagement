// <snippetcompoundcreateupdate1>


 //Define the account for which we will add letters                
 Account accountToCreate = new Account
 {
     Name = "Example Account"
 };

 //Define the IDs of the related letters we will create
 _letterIds = new[] { Guid.NewGuid(), Guid.NewGuid(), Guid.NewGuid() };

 //This acts as a container for each letter we create. Note that we haven't
 //define the relationship between the letter and account yet.
 EntityCollection relatedLettersToCreate = new EntityCollection
 {
     EntityName = Letter.EntityLogicalName,
     Entities =
     {
         new Letter{Subject = "Letter 1", ActivityId = _letterIds[0]},
         new Letter{Subject = "Letter 2", ActivityId = _letterIds[1]},
         new Letter{Subject = "Letter 3", ActivityId = _letterIds[2]}
     }
 };

 //Creates the reference between which relationship between Letter and
 //Account we would like to use.
 Relationship letterRelationship = new Relationship("Account_Letters");

 //Adds the letters to the account under the specified relationship
 accountToCreate.RelatedEntities.Add(letterRelationship, relatedLettersToCreate);

 //Passes the Account (which contains the letters)
 _accountId = _service.Create(accountToCreate);

 Console.WriteLine("An account and {0} letters were created.", _letterIds.Length);


 //Now we run through many of the same steps as the above "Create" example
 Account accountToUpdate = new Account
 {
     Name = "Example Account - Updated",
     AccountId = _accountId
 };

 EntityCollection relatedLettersToUpdate = new EntityCollection
 {
     EntityName = Letter.EntityLogicalName,
     Entities =
     {
         new Letter{Subject = "Letter 1 - Updated", ActivityId = _letterIds[0]},
         new Letter{Subject = "Letter 2 - Updated", ActivityId = _letterIds[1]},
         new Letter{Subject = "Letter 3 - Updated", ActivityId = _letterIds[2]}
     }
 };

 accountToUpdate.RelatedEntities.Add(letterRelationship, relatedLettersToUpdate);

 //This will update the account as well as all of the related letters
 _service.Update(accountToUpdate);
 Console.WriteLine("An account and {0} letters were updated.", _letterIds.Length);

// </snippetcompoundcreateupdate1>