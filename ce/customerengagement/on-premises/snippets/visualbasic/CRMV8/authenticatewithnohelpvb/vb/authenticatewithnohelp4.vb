' <snippetauthenticatewithnohelp4>


 Private Function GetProxy(Of TService As Class,
                               TProxy As ServiceProxy(Of TService)) _
                           (ByVal serviceManagement As IServiceManagement(Of TService),
                            ByVal authCredentials As AuthenticationCredentials) As TProxy
     Dim classType As Type = GetType(TProxy)

     If serviceManagement.AuthenticationType <>
         AuthenticationProviderType.ActiveDirectory Then
         Dim tokenCredentials As AuthenticationCredentials =
             serviceManagement.Authenticate(authCredentials)
         ' Obtain discovery/organization service proxy for Federated, LiveId and OnlineFederated environments. 
         ' Instantiate a new class of type using the 2 parameter constructor of type IServiceManagement and SecurityTokenResponse.
         Return CType(classType _
         .GetConstructor(New Type() {GetType(IServiceManagement(Of TService)), GetType(SecurityTokenResponse)}) _
         .Invoke(New Object() {serviceManagement, tokenCredentials.SecurityTokenResponse}), TProxy)
     End If

     ' Obtain discovery/organization service proxy for ActiveDirectory environment.
     ' Instantiate a new class of type using the 2 parameter constructor of type IServiceManagement and ClientCredentials.
     Return CType(classType _
         .GetConstructor(New Type() {GetType(IServiceManagement(Of TService)), GetType(ClientCredentials)}) _
         .Invoke(New Object() {serviceManagement, authCredentials.ClientCredentials}), TProxy)
 End Function

' </snippetauthenticatewithnohelp4>