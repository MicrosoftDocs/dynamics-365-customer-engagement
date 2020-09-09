// <snippetcreateconnectionrole1>


 // Define some anonymous types to define the range 
 // of possible connection property values.
 var Categories = new
 {
     Business = 1,
     Family = 2,
     Social = 3,
     Sales = 4,
     Other = 5
 };

 // Create a Connection Role for account and contact
 ConnectionRole newConnectionRole = new ConnectionRole
 {
     Name = "Example Connection Role",
     Category = new OptionSetValue(Categories.Business)
 };

 _connectionRoleId = _serviceProxy.Create(newConnectionRole);
 Console.WriteLine("Created {0}.", newConnectionRole.Name);

 // Create a related Connection Role Object Type Code record for Account
 ConnectionRoleObjectTypeCode newAccountConnectionRoleTypeCode
     = new ConnectionRoleObjectTypeCode
     {
         ConnectionRoleId = new EntityReference(
             ConnectionRole.EntityLogicalName, _connectionRoleId),
         AssociatedObjectTypeCode = Account.EntityLogicalName
     };

 _serviceProxy.Create(newAccountConnectionRoleTypeCode);
 Console.WriteLine(
     "Created a related Connection Role Object Type Code record for Account.");

 // Create a related Connection Role Object Type Code record for Contact
 ConnectionRoleObjectTypeCode newContactConnectionRoleTypeCode
     = new ConnectionRoleObjectTypeCode
     {
         ConnectionRoleId = new EntityReference(
             ConnectionRole.EntityLogicalName, _connectionRoleId),
         AssociatedObjectTypeCode = Contact.EntityLogicalName
     };

 _serviceProxy.Create(newContactConnectionRoleTypeCode);
 Console.WriteLine(
     "Created a related Connection Role Object Type Code record for Contact.");

// </snippetcreateconnectionrole1>