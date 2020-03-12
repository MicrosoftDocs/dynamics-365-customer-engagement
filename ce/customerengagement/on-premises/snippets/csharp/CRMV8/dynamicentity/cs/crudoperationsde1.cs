// <snippetcrudoperationsde1>


 // Instaniate an account object.
 Entity account = new Entity("account");

 // Set the required attributes. For account, only the name is required. 
 // See the Entity Metadata topic in the SDK documentatio to determine 
 // which attributes must be set for each entity.
 account["name"] = "Fourth Coffee";

 // Create an account record named Fourth Coffee.
 _accountId = _service.Create(account);

 Console.Write("{0} {1} created, ", account.LogicalName, account.Attributes["name"]);

 // Create a column set to define which attributes should be retrieved.
 ColumnSet attributes = new ColumnSet(new string[] { "name", "ownerid" });

 // Retrieve the account and its name and ownerid attributes.
 account = _service.Retrieve(account.LogicalName, _accountId, attributes);
 Console.Write("retrieved, ");

 // Update the postal code attribute.
 account["address1_postalcode"] = "98052";

 // The address 2 postal code was set accidentally, so set it to null.
 account["address2_postalcode"] = null;

 // Shows use of Money.
 account["revenue"] = new Money(5000000);

 // Shows use of boolean.
 account["creditonhold"] = false;

 // Update the account.
 _service.Update(account);
 Console.WriteLine("and updated.");

 // Delete the account.
 bool deleteRecords = true;

 if (promptForDelete)
 {
     Console.WriteLine("\nDo you want these entity records deleted? (y/n) [y]: ");
     String answer = Console.ReadLine();

     deleteRecords = (answer.StartsWith("y") || answer.StartsWith("Y") || answer == String.Empty);
 }

 if (deleteRecords)
 {
     _service.Delete("account", _accountId);

     Console.WriteLine("Entity record(s) have been deleted.");
 }

// </snippetcrudoperationsde1>