// <snippetimpersonatewithonbehalfofprivilege>


using System;
using System.ServiceModel;
using System.Linq;

// These namespaces are found in the Microsoft.Xrm.Sdk.dll assembly
// located in the SDK\bin folder of the SDK download.
using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Query;
using Microsoft.Xrm.Sdk.Client;

namespace Microsoft.Crm.Sdk.Samples
{
    /// <summary>
    /// Demonstrates how to impersonate another user with the on-behalf-of privilege and
    /// do basic entity operations like create, retrieve, update, and delete.</summary>
    /// <remarks>
    /// The system user account under which you run the sample must be part of the 
    /// Administrators group on your computer system so that this sample can create
    /// and use a second user account. You must also have the
    /// “Act on Behalf of Another User” privilege in Microsoft Dynamics CRM.
	/// 
	/// Note that the effective set of privileges for the operations performed will be the
	/// intersection of the privileges that the logged on (privileged) user possesses with
	/// that of the user that is being impersonated.
    /// 
    /// At run-time, you will be given the option to delete all the
    /// database records created by this program.</remarks>
    public class ImpersonateWithOnBehalfOfPrivilege
    {
        #region Class Level Members

        private Guid _userId;
        private Guid _accountId;
        private OrganizationServiceProxy _serviceProxy;

        #endregion Class Level Members

        #region How To Sample Code
        /// <summary>
        /// This method connects to the Organization service using an impersonated user
        /// credential. Afterwards, basic create, retrieve, update, and delete entity
        /// operations are performed as the impersonated user.
        /// </summary>
        /// <param name="serverConfig">Contains server connection information.</param>
        /// <param name="promptforDelete">When True, the user will be prompted to delete
        /// all created entities.</param>
        public void Run(ServerConnection.Configuration serverConfig, bool promptforDelete)
        {
            try
            {
                // Connect to the Organization service. 
                // The using statement ensures that the service proxy will be properly disposed.
                using (_serviceProxy = new OrganizationServiceProxy(serverConfig.OrganizationUri, serverConfig.HomeRealmUri,serverConfig.Credentials, serverConfig.DeviceCredentials))
                {
                    // This statement is required to enable early-bound type support.
                    _serviceProxy.EnableProxyTypes();

                    CreateRequiredRecords();

                    // Retrieve the system user ID of the user to impersonate.
                    OrganizationServiceContext orgContext = new OrganizationServiceContext(_serviceProxy);
                    _userId = (from user in orgContext.CreateQuery<SystemUser>()
                              where user.FullName == "Kevin Cook"
                              select user.SystemUserId.Value).FirstOrDefault();

                    // To impersonate another user, set the OrganizationServiceProxy.CallerId
                    // property to the ID of the other user.
                    _serviceProxy.CallerId = _userId;

                    // Instantiate an account object.
                    // See the Entity Metadata topic in the SDK documentation to determine 
                    // which attributes must be set for each entity.
                    Account account = new Account { Name = "Fourth Coffee" };

                    // Create an account record named Fourth Coffee.
                    _accountId = _serviceProxy.Create(account);
                    Console.Write("{0} {1} created, ", account.LogicalName, account.Name);

                    // Retrieve the account containing several of its attributes.
                    // CreatedBy should reference the impersonated SystemUser.
                    // CreatedOnBehalfBy should reference the running SystemUser.
                    ColumnSet cols = new ColumnSet(
                        "name",
                        "createdby",
                        "createdonbehalfby",
                        "address1_postalcode",
                        "lastusedincampaign");

                    Account retrievedAccount =
                        (Account)_serviceProxy.Retrieve(Account.EntityLogicalName,
                            _accountId, cols);
                    Console.Write("retrieved, ");

                    // Update the postal code attribute.
                    retrievedAccount.Address1_PostalCode = "98052";

                    // The address 2 postal code was set accidentally, so set it to null.
                    retrievedAccount.Address2_PostalCode = null;

                    // Shows use of a Money value.
                    retrievedAccount.Revenue = new Money(5000000);

                    // Shows use of a boolean value.
                    retrievedAccount.CreditOnHold = false;

                    // Update the account record.
                    _serviceProxy.Update(retrievedAccount);
                    Console.Write("updated, ");

                    // Delete the account record.
                    _serviceProxy.Delete(Account.EntityLogicalName, _accountId);
                    Console.WriteLine("and deleted.");

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
            // Create a second user that we will impersonate in our sample code.
            SystemUserProvider.RetrieveSalesManager(_serviceProxy);
        }

        /// <summary>
        /// Deletes any entity records that were created for this sample.
        /// <param name="prompt">Indicates whether to prompt the user 
        /// to delete the records created in this sample.</param>
        /// </summary>
        public void DeleteRequiredRecords(bool prompt)
        {
            // For this sample, all created records are deleted in the Run() method.
            // The system user named "Kevin Cook" that was created by this sample will
            // continue to exist on your system because system users cannot be deleted
            // in Microsoft Dynamics CRM.  They can only be enabled or disabled.
        }

        #endregion How To Sample Code

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

                ImpersonateWithOnBehalfOfPrivilege app = new ImpersonateWithOnBehalfOfPrivilege();
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

// </snippetimpersonatewithonbehalfofprivilege>