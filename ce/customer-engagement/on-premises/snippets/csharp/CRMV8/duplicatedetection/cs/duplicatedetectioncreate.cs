// <snippetduplicatedetectioncreate>

// Create operation by suppressing duplicate detection
CreateRequest reqCreate = new CreateRequest();
reqCreate.Target = account;
reqCreate.Parameters.Add("SuppressDuplicateDetection", true); // Change to false to activate the duplicate detection.
CreateResponse createResponse = (CreateResponse)_service.Execute(reqCreate);
_dupAccountId = createResponse.id;
Console.Write("Account: {0} {1} created with SuppressDuplicateDetection to true, ", account.Name, account.AccountNumber);

// </snippetduplicatedetectioncreate>