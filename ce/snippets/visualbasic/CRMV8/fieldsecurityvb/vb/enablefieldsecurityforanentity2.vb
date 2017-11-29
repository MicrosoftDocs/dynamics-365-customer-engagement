' <snippetenablefieldsecurityforanentity2>


 ' Create the request object and set the monikers with the
 ' teamprofiles_association relationship.
 Dim teamToProfile As AssociateRequest = New AssociateRequest With { _
     .Target = New EntityReference(FieldSecurityProfile.EntityLogicalName, _profileId), _
     .RelatedEntities = New EntityReferenceCollection From {New EntityReference(Team.EntityLogicalName, _teamId)}, _
     .Relationship = New Relationship("teamprofiles_association")}

 ' Execute the request.
 _serviceProxy.Execute(teamToProfile)

' </snippetenablefieldsecurityforanentity2>