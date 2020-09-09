// <snippetcreateauser>


using System;
using System.ServiceModel;
using System.ServiceModel.Description;

// These namespaces are found in the Microsoft.Xrm.Sdk.dll assembly
// located in the SDK\bin folder of the SDK download.
using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Query;
using Microsoft.Xrm.Sdk.Client;
using Microsoft.Crm.Sdk.Messages;

namespace Microsoft.Crm.Sdk.Samples
{
    /// <summary>
    /// Demonstrates how to do basic entity operations like create 
    /// a system user account.</summary>
    /// <remarks>
    /// At run-time, you will be given the option to delete all the
    /// database records created by this program.</remarks>
    public class CreateAUser
    {
        #region Class Level Members

        // Define the IDs needed for this sample.
        private String _domain = String.Empty;
        private String _userName = "dparker";
        private String _firstName = "Darren";
        private String _lastName = "Parker";
        private OrganizationServiceProxy _serviceProxy;

        #endregion Class Level Members

        #region How To Sample Code
        /// <summary>
        /// This method first connects to the Organization service. Afterwards,
        /// it creates a system user account with a given active directory account.
        /// Note: Creating a user is only supported in an on-premises/active directory environment.
        /// </summary>
        /// <param name="serverConfig">Contains server connection information.</param>
        /// <param name="promptforDelete">When True, the user will be prompted to delete all
        /// created entities.</param>
        public void Run(ServerConnection.Configuration serverConfig, bool promptforDelete)
        {
            try
            {
                // Connect to the Organization service. 
                // The using statement assures that the service proxy is properly disposed.
                using (_serviceProxy = new OrganizationServiceProxy(serverConfig.OrganizationUri, serverConfig.HomeRealmUri,
                                                                     serverConfig.Credentials, serverConfig.DeviceCredentials))
                {
                    _serviceProxy.EnableProxyTypes();

                    CreateRequiredRecords();

                    // Retrieve the default business unit needed to create the user.
                    QueryExpression businessUnitQuery = new QueryExpression
                    {
                        EntityName = BusinessUnit.EntityLogicalName,
                        ColumnSet = new ColumnSet("businessunitid"),
                        Criteria =
                        {
                            Conditions =
                    {
                        new ConditionExpression("parentbusinessunitid", 
                            ConditionOperator.Null)
                    }
                        }
                    };

                    BusinessUnit defaultBusinessUnit = _serviceProxy.RetrieveMultiple(
                        businessUnitQuery).Entities[0].ToEntity<BusinessUnit>();

                    //Create a new system user.
                    SystemUser user = new SystemUser
                    {
                        DomainName = _domain + _userName,
                        FirstName = _firstName,
                        LastName = _lastName,
                        BusinessUnitId = new EntityReference
                        {
                            LogicalName = BusinessUnit.EntityLogicalName,
                            Name = BusinessUnit.EntityLogicalName,
                            Id = defaultBusinessUnit.Id
                        }
                    };

                    Guid userId = _serviceProxy.Create(user);

                    Console.WriteLine("Created a system user {0} for '{1}, {2}'", userId, _lastName, _firstName); 
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
            // For this sample, all required entities are created in the Run() method.
            // Obtain the current user's information.
            WhoAmIRequest who = new WhoAmIRequest();
            WhoAmIResponse whoResp = (WhoAmIResponse)_serviceProxy.Execute(who);
            Guid currentUserId = whoResp.UserId;

            SystemUser currentUser =
                _serviceProxy.Retrieve(SystemUser.EntityLogicalName, 
                currentUserId, 
                new ColumnSet("domainname")).ToEntity<SystemUser>();

            // Extract the domain and create the LDAP object.
            String[] userPath = currentUser.DomainName.Split(new char[] { '\\' });
            if (userPath.Length > 1)
                _domain = userPath[0] + "\\";
            else
                _domain = String.Empty;

            SystemUser existingUser = SystemUserProvider.GetUserIdIfExist(_serviceProxy,
                _domain, _userName, _firstName, _lastName);

            if(existingUser != null)
                throw new Exception("User already exist!");

            // Set up an Active Directory account in the current domain for this sample.
            String ldapPath = String.Empty;
            Boolean accountSetup = SystemUserProvider.CreateADAccount(_userName, 
                _firstName, _lastName, _serviceProxy, ref ldapPath);
            if (accountSetup)
                Console.WriteLine("An AD account created for '{0}, {1}'", _lastName, _firstName);
            else
                Console.WriteLine("AD account already exist for '{0}, {1}'", _lastName, _firstName);
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
                // Obtain the target organization's web address and client logon 
                // credentials from the user.
                ServerConnection serverConnect = new ServerConnection();
                ServerConnection.Configuration config = serverConnect.GetServerConfiguration();

                CreateAUser app = new CreateAUser();
                app.Run( config, true );
            }
            catch (FaultException<Microsoft.Xrm.Sdk.OrganizationServiceFault> ex)
            {
                Console.WriteLine("The application terminated with an error.");
                Console.WriteLine("Timestamp: {0}", ex.Detail.Timestamp);
                Console.WriteLine("Code: {0}", ex.Detail.ErrorCode);
                Console.WriteLine("Message: {0}", ex.Detail.Message);
                Console.WriteLine("Trace: {0}", ex.Detail.TraceText);
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
                        Console.WriteLine("Trace: {0}", fe.Detail.TraceText);
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

// </snippetcreateauser>