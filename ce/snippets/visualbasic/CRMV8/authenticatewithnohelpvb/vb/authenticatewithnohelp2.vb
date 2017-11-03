' <snippetauthenticatewithnohelp2>


	''' <summary>
	''' Obtain the AuthenticationCredentials based on AuthenticationProviderType.
	''' </summary>
	''' <param name="endpointType">An AuthenticationProviderType of the CRM environment.</param>
	''' <returns>Get filled credentials.</returns>
	Private Function GetCredentials(ByVal endpointType As AuthenticationProviderType) As AuthenticationCredentials

		Dim authCredentials As New AuthenticationCredentials()
		Select Case endpointType
			Case AuthenticationProviderType.ActiveDirectory
                   authCredentials.ClientCredentials.Windows.ClientCredential =
                       New System.Net.NetworkCredential(_userName, _password, _domain)
			Case AuthenticationProviderType.LiveId
				authCredentials.ClientCredentials.UserName.UserName = _userName
				authCredentials.ClientCredentials.UserName.Password = _password
				authCredentials.SupportingCredentials = New AuthenticationCredentials()
                   authCredentials.SupportingCredentials.ClientCredentials =
                       Microsoft.Crm.Services.Utility.DeviceIdManager.LoadOrRegisterDevice()
			Case Else ' For Federated and OnlineFederated environments.
				authCredentials.ClientCredentials.UserName.UserName = _userName
				authCredentials.ClientCredentials.UserName.Password = _password
				' For OnlineFederated single-sign on, you could just use current UserPrincipalName instead of passing user name and password.
				' authCredentials.UserPrincipalName = UserPrincipal.Current.UserPrincipalName;  //Windows/Kerberos
		End Select

		Return authCredentials
	End Function

' </snippetauthenticatewithnohelp2>