// <snippetlicense1>


 // Connect to the Organization service. 
 // The using statement assures that the service proxy will be properly disposed.
 using (_serviceProxy = new OrganizationServiceProxy(serverConfig.OrganizationUri, serverConfig.HomeRealmUri,serverConfig.Credentials, serverConfig.DeviceCredentials))
 {
     // This statement is required to enable early-bound type support.
     _serviceProxy.EnableProxyTypes();

     #region RetrieveDeploymentLicenseTypeRequest

     // Create the request
     var deploymentTypeRequest = new RetrieveDeploymentLicenseTypeRequest();
     
     // Execute the request
     Console.WriteLine("  Fetching the license type for this deployment");
     var deploymentTypeResponse = 
         (RetrieveDeploymentLicenseTypeResponse)_serviceProxy.Execute(deploymentTypeRequest);

     // Validate results
     if (String.IsNullOrEmpty(deploymentTypeResponse.licenseType))
         throw new Exception("The request did not return any results");

     string licenseId = 
         new Guid(deploymentTypeResponse.licenseType).ToString().ToUpper();
     switch (licenseId)
     {
         case "9436EA66-8262-4168-9B6C-21DF47D1D121":
             Console.WriteLine("  License type: SmallBusiness");
             break;
         case "5BEEA2E8-8F82-40E8-AE0F-6D8C135E1397":
             Console.WriteLine("  License type: Professional");
             break;
         case "CB96BDD5-5F74-4EA5-8323-9D7E20079002":
             Console.WriteLine("  License type: Enterprise");
             break;
         case "66AE2919-DD58-40CA-A980-AEF7330B2745":
             Console.WriteLine("  License type: Live");
             break;
         case "722E9E15-62DC-48A7-95CF-93131BE27273":
             Console.WriteLine("  License type: SPLA (Service Provider)");
             break;
         default:
             Console.WriteLine("  Unknown license type with id {0}", licenseId);
             break;
     }

     #endregion

     #region RetrieveLicenseInfoRequest

     // create the request
     var licenseInfoRequest = new RetrieveLicenseInfoRequest();

     // execute the request
     Console.WriteLine("  Fetching license info");
     var licenseInfoResponse =
         (RetrieveLicenseInfoResponse)_serviceProxy.Execute(licenseInfoRequest);

     // output the results
     Console.WriteLine("  Number of licenses available: {0}", 
         licenseInfoResponse.AvailableCount);
     Console.WriteLine("  Number of licenses used: {0}", 
         licenseInfoResponse.GrantedLicenseCount);

     #endregion
 }

// </snippetlicense1>