' <snippetuseraccess2>



 ' Grant the first user delete access to the lead.
 Dim modifyUser1AccessReq = New ModifyAccessRequest With
                            {
                                .PrincipalAccess =
                                New PrincipalAccess With
                                {
                                    .AccessMask = AccessRights.DeleteAccess,
                                    .Principal = systemUser1Ref
                                },
                                .Target = leadReference
                            }

 Console.WriteLine("Granting delete access to {0} on the lead..." &amp; vbCrLf,
                   GetEntityReferenceString(systemUser1Ref))
 _serviceProxy.Execute(modifyUser1AccessReq)

' </snippetuseraccess2>