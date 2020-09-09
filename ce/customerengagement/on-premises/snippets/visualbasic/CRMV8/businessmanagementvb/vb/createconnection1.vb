' <snippetcreateconnection1>


 ' Create a connection between the account and the contact.
 ' Assign a connection role to a record.
 Dim newConnection As Connection =
     New Connection With
     {
         .Record1Id =
         New EntityReference(Account.EntityLogicalName,
                                          _accountId),
         .Record1RoleId =
         New EntityReference(ConnectionRole.EntityLogicalName,
                             _connectionRoleId),
         .Record2RoleId =
         New EntityReference(ConnectionRole.EntityLogicalName,
                             _connectionRoleId),
         .Record2Id =
         New EntityReference(Contact.EntityLogicalName,
                                          _contactId)
     }

 _connectionId = _serviceProxy.Create(newConnection)

' </snippetcreateconnection1>