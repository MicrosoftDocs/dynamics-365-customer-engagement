// <snippetcompoundcreateupdatede1>


 //Define the account for which we will add letters
 Entity accountToCreate = new Entity("account");
 accountToCreate["name"] = "Example Account";

 //Define the IDs of the related letters we will create
 _letterIds = new[] { Guid.NewGuid(), Guid.NewGuid(), Guid.NewGuid() };

 //This acts as a container for each letter we create. Note that we haven't
 //define the relationship between the letter and account yet.

 // Letter 1 for creation
 Entity letter1 = new Entity("letter");
 letter1["subject"] = "Letter 1";
 letter1["activityid"] = _letterIds[0];

 // Letter 2 for creation
 Entity letter2 = new Entity("letter");
 letter2["subject"] = "Letter 2";
 letter2["activityid"] = _letterIds[1];

 // Letter 3 for creation
 Entity letter3 = new Entity("letter");
 letter3["subject"] = "Letter 3";
 letter3["activityid"] = _letterIds[2];

 EntityCollection relatedLettersToCreate = new EntityCollection
 {
     EntityName = "letter",
     Entities = { letter1, letter2, letter3 }
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
 Entity accountToUpdate = new Entity("account");
 accountToUpdate["name"] = "Example Account - Updated";
 accountToUpdate["accountid"] = _accountId;

 // Letter 1 for updation
 Entity letter1Update = new Entity("letter");
 letter1Update["subject"] = "Letter 1 - Updated";
 letter1Update["activityid"] = _letterIds[0];

 // Letter 2 for updation
 Entity letter2Update = new Entity("letter");
 letter2Update["subject"] = "Letter 2 - Updated";
 letter2Update["activityid"] = _letterIds[1];

 // Letter 3 for updation
 Entity letter3Update = new Entity("letter");
 letter3Update["subject"] = "Letter 3 - Updated";
 letter3Update["activityid"] = _letterIds[2];

 EntityCollection relatedLettersToUpdate = new EntityCollection
 {
     EntityName = "letter",
     Entities = { letter1Update, letter2Update, letter3Update }
 };

 accountToUpdate.RelatedEntities.Add(letterRelationship, relatedLettersToUpdate);

 //This will update the account as well as all of the related letters
 _service.Update(accountToUpdate);

 Console.WriteLine("An account and {0} letters were updated.", _letterIds.Length);

// </snippetcompoundcreateupdatede1>