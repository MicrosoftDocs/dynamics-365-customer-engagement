' <snippetuseraccess1>


 ' Grant the team read/write access to the lead.
 Dim teamReference = New EntityReference(Team.EntityLogicalName,
                                         _teamId)
 
 Dim grantAccessRequest1 = New GrantAccessRequest With
                          {
                              .PrincipalAccess =
                              New PrincipalAccess With
                              {
                                  .AccessMask = AccessRights.ReadAccess Or AccessRights.WriteAccess,
                                  .Principal = teamReference
                              },
                              .Target = leadReference
                          }

 Console.WriteLine("Granting {0} to {1} ({2}) on the lead..." &amp; vbCrLf,
                   AccessRights.ReadAccess Or AccessRights.WriteAccess, GetEntityReferenceString(teamReference),
                   "Team")
 _serviceProxy.Execute(grantAccessRequest1)

' </snippetuseraccess1>