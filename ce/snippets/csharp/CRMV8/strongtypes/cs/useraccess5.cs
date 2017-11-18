// <snippetuseraccess5>


 var accessRequest = new RetrieveSharedPrincipalsAndAccessRequest
 {
     Target = leadReference
 };
 
 // The RetrieveSharedPrincipalsAndAccessResponse returns an entity reference
 // that has a LogicalName of "user" when returning access information for a
 // "team."
 var accessResponse = (RetrieveSharedPrincipalsAndAccessResponse)
     _serviceProxy.Execute(accessRequest);
 Console.WriteLine("The following have the specified granted access to the lead.");
 foreach (var principalAccess in accessResponse.PrincipalAccesses)
 {
     Console.WriteLine("\t{0}:\r\n\t\t{1}",
         GetEntityReferenceString(principalAccess.Principal),
         principalAccess.AccessMask);
 }
 Console.WriteLine();

// </snippetuseraccess5>