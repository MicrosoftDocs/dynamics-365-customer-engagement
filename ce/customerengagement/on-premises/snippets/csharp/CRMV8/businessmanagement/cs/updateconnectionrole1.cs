// <snippetupdateconnectionrole1>


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

 // Update the connectionrole instance.
 ConnectionRole connectionRole = new ConnectionRole
 {
     ConnectionRoleId = _connectionRoleId,
     Name = "Updated Connection Role",
     Description = "This is an updated connection role.",
     Category = new OptionSetValue(Categories.Other)
 };

 _serviceProxy.Update(connectionRole);

// </snippetupdateconnectionrole1>