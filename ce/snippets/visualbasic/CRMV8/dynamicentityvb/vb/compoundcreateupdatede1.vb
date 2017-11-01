' <snippetcompoundcreateupdatede1>


 'Define the account for which we will add letters
 Dim accountToCreate As New Entity("account")
 accountToCreate("name") = "Example Account"

 'Define the IDs of the related letters we will create
 _letterIds = { Guid.NewGuid(), Guid.NewGuid(), Guid.NewGuid() }

 'This acts as a container for each letter we create. Note that we haven't
 'define the relationship between the letter and account yet.

 ' Letter 1 for creation
 Dim letter1 As New Entity("letter")
 letter1("subject") = "Letter 1"
 letter1("activityid") = _letterIds(0)

 ' Letter 2 for creation
 Dim letter2 As New Entity("letter")
 letter2("subject") = "Letter 2"
 letter2("activityid") = _letterIds(1)

 ' Letter 3 for creation
 Dim letter3 As New Entity("letter")
 letter3("subject") = "Letter 3"
 letter3("activityid") = _letterIds(2)

 Dim relatedLettersToCreate As EntityCollection = New EntityCollection With {.EntityName = "letter"}
 relatedLettersToCreate.Entities.AddRange({letter1, letter2, letter3})

 'Creates the reference between which relationship between Letter and
 'Account we would like to use.
 Dim letterRelationship As New Relationship("Account_Letters")

 'Adds the letters to the account under the specified relationship
 accountToCreate.RelatedEntities.Add(letterRelationship, relatedLettersToCreate)

 'Passes the Account (which contains the letters) 
 _accountId = _service.Create(accountToCreate)

 Console.WriteLine("An account and {0} letters were created.", _letterIds.Length)


 'Now we run through many of the same steps as the above "Create" example
 Dim accountToUpdate As New Entity("account")
 accountToUpdate("name") = "Example Account - Updated"
 accountToUpdate("accountid") = _accountId

 ' Letter 1 for updation
 Dim letter1Update As New Entity("letter")
 letter1Update("subject") = "Letter 1 - Updated"
 letter1Update("activityid") = _letterIds(0)

 ' Letter 2 for updation
 Dim letter2Update As New Entity("letter")
 letter2Update("subject") = "Letter 2 - Updated"
 letter2Update("activityid") = _letterIds(1)

 ' Letter 3 for updation
 Dim letter3Update As New Entity("letter")
 letter3Update("subject") = "Letter 3 - Updated"
 letter3Update("activityid") = _letterIds(2)

 Dim relatedLettersToUpdate As EntityCollection = New EntityCollection With {.EntityName = "letter"}
 relatedLettersToCreate.Entities.AddRange({letter1Update, letter2Update, letter3Update})

 accountToUpdate.RelatedEntities.Add(letterRelationship, relatedLettersToUpdate)

 'This will update the account as well as all of the related letters
 _service.Update(accountToUpdate)

 Console.WriteLine("An account and {0} letters were updated.", _letterIds.Length)

' </snippetcompoundcreateupdatede1>