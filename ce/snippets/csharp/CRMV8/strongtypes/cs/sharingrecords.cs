// <snippetsharingrecords>


using System;
using System.ServiceModel;

// These namespaces are found in the Microsoft.Xrm.Sdk.dll assembly
// found in the SDK\bin folder.
using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Client;

// This namespace is found in Microsoft.Crm.Sdk.Proxy.dll assembly
// found in the SDK\bin folder.
using Microsoft.Crm.Sdk.Messages;


namespace Microsoft.Crm.Sdk.Samples

{
    /// <summary>
    /// Demonstrates sharing records via access messages.
    /// </summary>
    public class SharingRecords
    {

        #region Class Level Members

        private Guid _userId;
        private Guid _accountId;
        private OrganizationServiceProxy _serviceProxy;
        private IOrganizationService _service;

        #endregion Class Level Members

        #region How-To Sample Code
        /// <summary>
        /// Demonstrates sharing records by exercising various access messages including:
        /// Grant, Modify, Revoke, RetrievePrincipalAccess, and 
        /// RetrievePrincipalsAndAccess.
        /// </summary>
        /// <param name="serverConfig">Contains server connection information.</param>
        /// <param name="promptforDelete">When True, the user will be prompted to delete all
        /// created entities.</param>
        public void Run(ServerConnection.Configuration serverConfig, bool promptforDelete)
        {
            try
            {
                // Connect to the Organization service. 
                // The using statement assures that the service proxy will be properly disposed.
                using (_serviceProxy = new OrganizationServiceProxy(serverConfig.OrganizationUri, serverConfig.HomeRealmUri,serverConfig.Credentials, serverConfig.DeviceCredentials))
                {
                    // This statement is required to enable early-bound type support.
                    _serviceProxy.EnableProxyTypes();

                    _service = (IOrganizationService)_serviceProxy;

                    CreateRequiredRecords();

                    #region GrantAccess Message

                    // Create the request object and set the target and principal access
                    // object.
                    GrantAccessRequest grantRequest = new GrantAccessRequest()
                    {
                        Target = new EntityReference(Account.EntityLogicalName, _accountId),
                        PrincipalAccess = new PrincipalAccess()
                        {
                            Principal = new EntityReference(SystemUser.EntityLogicalName, _userId),
                            AccessMask = AccessRights.WriteAccess | AccessRights.ReadAccess | AccessRights.ShareAccess
                        }
                    };

                    // Execute the request.
                    GrantAccessResponse grantResponse =
                        (GrantAccessResponse)_service.Execute(grantRequest);

                    Console.Write("Access Granted ");

                    #endregion

                    #region ModifyAccess Message

                    // Create the request object and set the target and principal access
                    // object.
                    ModifyAccessRequest modifyRequest = new ModifyAccessRequest()
                    {
                        Target = new EntityReference(Account.EntityLogicalName, _accountId),
                        PrincipalAccess = new PrincipalAccess()
                        {
                            Principal = new EntityReference(SystemUser.EntityLogicalName, _userId),
                            AccessMask = AccessRights.ReadAccess | AccessRights.ShareAccess
                        }
                    };

                    // Execute the request.
                    ModifyAccessResponse modifyResponse =
                        (ModifyAccessResponse)_service.Execute(modifyRequest);

                    Console.Write("and Modified. ");

                    #endregion

                    #region RetrievePrincipalAccess Message

                    // Create the request object and set the target and principal.
                    RetrievePrincipalAccessRequest retrieveRequest = new RetrievePrincipalAccessRequest()
                    {
                        Target = new EntityReference(Account.EntityLogicalName, _accountId),
                        Principal = new EntityReference(SystemUser.EntityLogicalName, _userId)
                    };

                    // Execute the request.
                    RetrievePrincipalAccessResponse retrieveResponse = 
                        (RetrievePrincipalAccessResponse)_service.Execute(retrieveRequest);

                    Console.Write("Retrieved principal access. ");

                    #endregion

                    #region RetrieveSharedPrincipalsAndAccess Message

                    // Create the request object and set the target.
                    RetrieveSharedPrincipalsAndAccessRequest retrieveSharedRequest = 
                        new RetrieveSharedPrincipalsAndAccessRequest()
                    {
                        Target = new EntityReference(Account.EntityLogicalName, _accountId)
                    };

                    // Execute the request.
                    RetrieveSharedPrincipalsAndAccessResponse retrieveSharedResponse = 
                        (RetrieveSharedPrincipalsAndAccessResponse)_service.Execute(retrieveSharedRequest);

                    Console.Write("Retrieved principals and access. ");

                    #endregion

                    #region RevokeAccess Message

                    // Create the request object and set the target and revokee.
                    RevokeAccessRequest revokeRequest = new RevokeAccessRequest()
                    {
                        Target = new EntityReference(Account.EntityLogicalName, _accountId),
                        Revokee = new EntityReference(SystemUser.EntityLogicalName, _userId)
                    };

                    // Execute the request.
                    RevokeAccessResponse revokeResponse =
                        (RevokeAccessResponse)_service.Execute(revokeRequest);

                    Console.Write("Revoked Access.");

                    #endregion

                    DeleteRequiredRecords(promptforDelete);
                }
            }

            // Catch any service fault exceptions that Microsoft Dynamics CRM throws.
            catch (FaultException<Microsoft.Xrm.Sdk.OrganizationServiceFault>)
            {
                // You can handle an exception here or pass it back to the calling method.
                throw;
            }
        }

        /// <summary>
        /// Creates any entity records that this sample requires.
        /// </summary>
        public void CreateRequiredRecords()
        {
            // Get the GUID of the Marketing Manager
            _userId = SystemUserProvider.RetrieveMarketingManager(_serviceProxy);

            // Instantiate an Account object.
            // See the Entity Metadata topic in the SDK documentation to determine
            // which attributes must be set for each entity.
            Account setupAccount = new Account()
            {
                Name = "Fourth Coffee"
            };
            _accountId = _service.Create(setupAccount);
        }

        /// <summary>
        /// Deletes any entity records and files that were created for this sample.
        /// <param name="prompt">Indicates whether to prompt the user 
        /// to delete the records created in this sample.</param>
        /// </summary>
        public void DeleteRequiredRecords(bool prompt)
        {
            // The system user named "Samantha Smith" that was created by this sample will
            // continue to exist on your system because system users cannot be deleted
            // in Microsoft Dynamics CRM.  They can only be enabled or disabled.
            // If not prompting the user, go ahead and clean up.

            if (!prompt)
            {
                _service.Delete(Account.EntityLogicalName, _accountId);
                Console.WriteLine("Entity record(s) have been deleted.");
                return;
            }

            // Ask the user if the created entities should be deleted.
            Console.Write("\nDo you want these entity records deleted? (y/n) [y]: ");
            String answer = Console.ReadLine();

            if (answer.StartsWith("y") || answer.StartsWith("Y") || answer == String.Empty)
            {
                _service.Delete(Account.EntityLogicalName, _accountId);
                Console.WriteLine("Entity record(s) have been deleted.");
            }
        }

        #endregion How-To Sample Code

        #region Main method

        /// <summary>
        /// Standard Main() method used by most SDK samples.
        /// </summary>
        /// <param name="args"></param>
        static public void Main(string[] args)
        {
            try
            {
                // Obtain the target organization's Web address and client logon 
                // credentials from the user.
                ServerConnection serverConnect = new ServerConnection();
                ServerConnection.Configuration config = serverConnect.GetServerConfiguration();

                SharingRecords app = new SharingRecords();
                app.Run(config, true);
            }
            catch (FaultException<Microsoft.Xrm.Sdk.OrganizationServiceFault> ex)
            {
                Console.WriteLine("The application terminated with an error.");
                Console.WriteLine("Timestamp: {0}", ex.Detail.Timestamp);
                Console.WriteLine("Code: {0}", ex.Detail.ErrorCode);
                Console.WriteLine("Message: {0}", ex.Detail.Message);
                Console.WriteLine("Plugin Trace: {0}", ex.Detail.TraceText);
                Console.WriteLine("Inner Fault: {0}",
                    null == ex.Detail.InnerFault ? "No Inner Fault" : "Has Inner Fault");
            }
            catch (System.TimeoutException ex)
            {
                Console.WriteLine("The application terminated with an error.");
                Console.WriteLine("Message: {0}", ex.Message);
                Console.WriteLine("Stack Trace: {0}", ex.StackTrace);
                Console.WriteLine("Inner Fault: {0}",
                    null == ex.InnerException.Message ? "No Inner Fault" : ex.InnerException.Message);
            }
            catch (System.Exception ex)
            {
                Console.WriteLine("The application terminated with an error.");
                Console.WriteLine(ex.Message);

                // Display the details of the inner exception.
                if (ex.InnerException != null)
                {
                    Console.WriteLine(ex.InnerException.Message);

                    FaultException<Microsoft.Xrm.Sdk.OrganizationServiceFault> fe = ex.InnerException
                        as FaultException<Microsoft.Xrm.Sdk.OrganizationServiceFault>;
                    if (fe != null)
                    {
                        Console.WriteLine("Timestamp: {0}", fe.Detail.Timestamp);
                        Console.WriteLine("Code: {0}", fe.Detail.ErrorCode);
                        Console.WriteLine("Message: {0}", fe.Detail.Message);
                        Console.WriteLine("Plugin Trace: {0}", fe.Detail.TraceText);
                        Console.WriteLine("Inner Fault: {0}",
                            null == fe.Detail.InnerFault ? "No Inner Fault" : "Has Inner Fault");
                    }
                }
            }
            // Additional exceptions to catch: SecurityTokenValidationException, ExpiredSecurityTokenException,
            // SecurityAccessDeniedException, MessageSecurityException, and SecurityNegotiationException.

            finally
            {
                Console.WriteLine("Press <Enter> to exit.");
                Console.ReadLine();
            }
        }
        #endregion Main method
    }
}

// </snippetsharingrecords>