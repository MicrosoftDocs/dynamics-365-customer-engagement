// <snippetuseraccess2>



 // Grant the first user delete access to the lead.
 var modifyUser1AccessReq = new ModifyAccessRequest
 {
     PrincipalAccess = new PrincipalAccess
     {
         AccessMask = AccessRights.DeleteAccess,
         Principal = systemUser1Ref
     },
     Target = leadReference
 };

 Console.WriteLine("Granting delete access to {0} on the lead...\r\n",
     GetEntityReferenceString(systemUser1Ref));
 _serviceProxy.Execute(modifyUser1AccessReq);

// </snippetuseraccess2>