' <snippetcreateconnectionrole1>


 ' Define some anonymous types to define the range 
 ' of possible connection property values.
 Dim Categories = New With {Key .Business = 1, Key .Family = 2, Key .Social = 3, Key .Sales = 4, Key .Other = 5}

 ' Create a Connection Role for account and contact
 Dim newConnectionRole As ConnectionRole = New ConnectionRole With { _
     .Name = "Example Connection Role", .Category = New OptionSetValue(Categories.Business)}

 _connectionRoleId = _serviceProxy.Create(newConnectionRole)
 Console.WriteLine("Created {0}.", newConnectionRole.Name)

 ' Create a related Connection Role Object Type Code record for Account
 Dim newAccountConnectionRoleTypeCode As ConnectionRoleObjectTypeCode = _
     New ConnectionRoleObjectTypeCode With {.ConnectionRoleId = _
         New EntityReference(ConnectionRole.EntityLogicalName, _connectionRoleId), _
                                            .AssociatedObjectTypeCode = Account.EntityLogicalName}

 _serviceProxy.Create(newAccountConnectionRoleTypeCode)
 Console.WriteLine("Created a related Connection Role Object Type Code record for Account.")

 ' Create a related Connection Role Object Type Code record for Contact
 Dim newContactConnectionRoleTypeCode As ConnectionRoleObjectTypeCode = _
     New ConnectionRoleObjectTypeCode With {.ConnectionRoleId = _
         New EntityReference(ConnectionRole.EntityLogicalName, _connectionRoleId), _
                                            .AssociatedObjectTypeCode = Contact.EntityLogicalName}

 _serviceProxy.Create(newContactConnectionRoleTypeCode)
 Console.WriteLine("Created a related Connection Role Object Type Code record for Contact.")

' </snippetcreateconnectionrole1>