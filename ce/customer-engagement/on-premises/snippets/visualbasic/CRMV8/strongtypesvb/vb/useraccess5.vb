' <snippetuseraccess5>



 Dim accessRequest = New RetrieveSharedPrincipalsAndAccessRequest With
                     {
                         .Target = leadReference
                     }

 ' The RetrieveSharedPrincipalsAndAccessResponse returns an entity reference
 ' that has a LogicalName of "user" when returning access information for a
 ' "team."
 Dim accessResponse = CType(_serviceProxy.Execute(accessRequest), 
     RetrieveSharedPrincipalsAndAccessResponse)
 Console.WriteLine("The following have the specified granted access to the lead.")
 For Each principalAccess In accessResponse.PrincipalAccesses
     Console.WriteLine(vbTab &amp; "{0}:" &amp; vbCrLf &amp; vbTab &amp; vbTab &amp; "{1}",
                       GetEntityReferenceString(principalAccess.Principal),
                       principalAccess.AccessMask)
 Next principalAccess
 Console.WriteLine()

' </snippetuseraccess5>