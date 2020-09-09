// <snippetuseraccess3>



 // Revoke access to the lead for the second user.
 var revokeUser2AccessReq = new RevokeAccessRequest
 {
     Revokee = systemUser2Ref,
     Target = leadReference
 };

 Console.WriteLine("Revoking access to the lead for {0}...\r\n",
     GetEntityReferenceString(systemUser2Ref));
 _serviceProxy.Execute(revokeUser2AccessReq);

// </snippetuseraccess3>