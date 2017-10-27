// <snippetcreateconnection1>


 // Create a connection between the account and the contact.
 // Assign a connection role to a record.
 Connection newConnection = new Connection
 {
     Record1Id = new EntityReference(Account.EntityLogicalName,
         _accountId),
     Record1RoleId = new EntityReference(ConnectionRole.EntityLogicalName,
         _connectionRoleId),                             
     Record2RoleId = new EntityReference(ConnectionRole.EntityLogicalName,
         _connectionRoleId),                            
     Record2Id = new EntityReference(Contact.EntityLogicalName,
         _contactId)
 };

 _connectionId = _serviceProxy.Create(newConnection);

// </snippetcreateconnection1>