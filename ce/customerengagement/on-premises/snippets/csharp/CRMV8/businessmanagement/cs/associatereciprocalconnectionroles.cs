// <snippetassociatereciprocalconnectionroles>


 // Associate the connection roles
  AssociateRequest associateConnectionRoles = new AssociateRequest
 {
     Target = new EntityReference(ConnectionRole.EntityLogicalName,
         _connectionRole1Id),
     RelatedEntities = new EntityReferenceCollection()
     {
         new EntityReference(ConnectionRole.EntityLogicalName,
             _connectionRole2Id)
     },
     // The name of the relationship connection role association 
     // relationship in MS CRM
     Relationship = new Relationship()
     {
         PrimaryEntityRole = EntityRole.Referencing, // Referencing or Referenced based on N:1 or 1:N reflexive relationship.
         SchemaName = "connectionroleassociation_association"
     }
 };

 _serviceProxy.Execute(associateConnectionRoles);
 Console.WriteLine("Associated the connection roles.");

// </snippetassociatereciprocalconnectionroles>