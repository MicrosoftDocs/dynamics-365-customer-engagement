' <snippetassociatereciprocalconnectionroles>


 ' Associate the connection roles
 Dim associateConnectionRoles As AssociateRequest =
     New AssociateRequest With
     {
         .Target = New EntityReference(ConnectionRole.EntityLogicalName,
                                       _connectionRole1Id),
         .RelatedEntities =
         New EntityReferenceCollection() From
         {
             New EntityReference(ConnectionRole.EntityLogicalName,
                                 _connectionRole2Id)
         },
         .Relationship =
         New Relationship() With
         {
             .PrimaryEntityRole = EntityRole.Referencing,
             .SchemaName = "connectionroleassociation_association"
         }
     }
 ' The name of the relationship connection role association 
 ' relationship in MS CRM

 _serviceProxy.Execute(associateConnectionRoles)
 Console.WriteLine("Associated the connection roles.")

' </snippetassociatereciprocalconnectionroles>