// <snippetuseraccess4>


 var principalAccessReq = new RetrievePrincipalAccessRequest
 {
     Principal = principal,
     Target = leadReference
 };
 var principalAccessRes = (RetrievePrincipalAccessResponse)
     _serviceProxy.Execute(principalAccessReq);
 Console.WriteLine("Access rights of {0} ({1}) on the lead: {2}\r\n",
     GetEntityReferenceString(principal),
     additionalIdentifier,
     principalAccessRes.AccessRights);

// </snippetuseraccess4>