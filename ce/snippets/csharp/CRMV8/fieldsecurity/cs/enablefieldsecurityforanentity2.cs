// <snippetenablefieldsecurityforanentity2>


 // Create the request object and set the monikers with the
 // teamprofiles_association relationship.
 AssociateRequest teamToProfile = new AssociateRequest
 {
     Target = new EntityReference(FieldSecurityProfile.EntityLogicalName, _profileId),
     RelatedEntities = new EntityReferenceCollection
     {
         new EntityReference(Team.EntityLogicalName, _teamId)
     },
     Relationship = new Relationship("teamprofiles_association")
 };

 // Execute the request.
 _serviceProxy.Execute(teamToProfile);

// </snippetenablefieldsecurityforanentity2>