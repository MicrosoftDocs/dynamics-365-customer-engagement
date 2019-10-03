' <snippetuseraccess4>


 Dim principalAccessReq = New RetrievePrincipalAccessRequest With
                          {
                              .Principal = principal,
                              .Target = leadReference
                          }
 Dim principalAccessRes = CType(_serviceProxy.Execute(principalAccessReq), 
     RetrievePrincipalAccessResponse)
 Console.WriteLine("Access rights of {0} ({1}) on the lead: {2}" &amp; vbCrLf,
                   GetEntityReferenceString(principal),
                   additionalIdentifier,
                   principalAccessRes.AccessRights)

' </snippetuseraccess4>