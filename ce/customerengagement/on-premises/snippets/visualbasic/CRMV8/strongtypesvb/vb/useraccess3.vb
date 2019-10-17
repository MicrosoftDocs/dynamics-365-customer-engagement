' <snippetuseraccess3>



 ' Revoke access to the lead for the second user.
 Dim revokeUser2AccessReq = New RevokeAccessRequest With
                            {
                                .Revokee = systemUser2Ref,
                                .Target = leadReference
                            }

 Console.WriteLine("Revoking access to the lead for {0}..." &amp; vbCrLf,
                   GetEntityReferenceString(systemUser2Ref))
 _serviceProxy.Execute(revokeUser2AccessReq)

' </snippetuseraccess3>