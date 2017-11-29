' <snippetlicense1>


 ' Connect to the Organization service. 
 ' The using statement assures that the service proxy will be properly disposed.
 _serviceProxy = ServerConnection.GetOrganizationProxy(serverConfig)
 Using _serviceProxy
     ' This statement is required to enable early-bound type support.
     _serviceProxy.EnableProxyTypes()

     '					#Region "RetrieveDeploymentLicenseTypeRequest"

     ' Create the request
     Dim deploymentTypeRequest = New RetrieveDeploymentLicenseTypeRequest()

     ' Execute the request
     Console.WriteLine("  Fetching the license type for this deployment")
     Dim deploymentTypeResponse =
         CType(_serviceProxy.Execute(deploymentTypeRequest), 
             RetrieveDeploymentLicenseTypeResponse)

     ' Validate results
     If String.IsNullOrEmpty(deploymentTypeResponse.licenseType) Then
         Throw New Exception("The request did not return any results")
     End If

     Dim licenseId As String =
         New Guid(deploymentTypeResponse.licenseType).ToString().ToUpper()
     Select Case licenseId
         Case "9436EA66-8262-4168-9B6C-21DF47D1D121"
             Console.WriteLine("  License type: SmallBusiness")
         Case "5BEEA2E8-8F82-40E8-AE0F-6D8C135E1397"
             Console.WriteLine("  License type: Professional")
         Case "CB96BDD5-5F74-4EA5-8323-9D7E20079002"
             Console.WriteLine("  License type: Enterprise")
         Case "66AE2919-DD58-40CA-A980-AEF7330B2745"
             Console.WriteLine("  License type: Live")
         Case "722E9E15-62DC-48A7-95CF-93131BE27273"
             Console.WriteLine("  License type: SPLA (Service Provider)")
         Case Else
             Console.WriteLine("  Unknown license type with id {0}", licenseId)
     End Select

     '					#End Region

     '					#Region "RetrieveLicenseInfoRequest"

     ' create the request
     Dim licenseInfoRequest = New RetrieveLicenseInfoRequest()

     ' execute the request
     Console.WriteLine("  Fetching license info")
     Dim licenseInfoResponse = CType(_serviceProxy.Execute(licenseInfoRequest), 
         RetrieveLicenseInfoResponse)

     ' output the results
     Console.WriteLine("  Number of licenses available: {0}",
                       licenseInfoResponse.AvailableCount)
     Console.WriteLine("  Number of licenses used: {0}",
                       licenseInfoResponse.GrantedLicenseCount)

     '					#End Region

' </snippetlicense1>