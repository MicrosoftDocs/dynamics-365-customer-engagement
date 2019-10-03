// <snippetretrieveauser>


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
    /// Demonstrates how to create a basic query to find a user.
    /// </summary>
    /// <remarks>
    /// At run-time, you will be given the option to revert the role 
    /// association created by this program.</remarks>
    public class RetrieveAUser
    {
        #region Class Level Members

        // Define the IDs needed for this sample.
        private String _domain;
        private String _userName;
        private String _firstName;
        private String _lastName;
        private OrganizationServiceProxy _serviceProxy;

        #endregion Class Level Members

        #region How To Sample Code
        /// <summary>
        /// This method first connects to the Organization service. Afterwards, it
        /// creates/retrieves a system user,
        /// retrieves user details, and 
        /// creates a query to find the system user using domain\username or first and last name details. 
        /// Note: Creating a user is only supported
        /// in an on-premises/active directory environment.
        /// </summary>
        /// <param name="serverConfig">Contains server connection information.</param>
        /// <param name="promptforDelete">When True, the user is prompted to delete all
        /// created entities.</param>
        public void Run(ServerConnection.Configuration serverConfig, bool promptforDelete)
        {
            try
            {
                // Connect to the Organization service. 
                // The using statement assures that the service proxy is properly disposed.
                using (_serviceProxy = new OrganizationServiceProxy(serverConfig.OrganizationUri, serverConfig.HomeRealmUri,serverConfig.Credentials, serverConfig.DeviceCredentials))
                {
                    _serviceProxy.EnableProxyTypes();

                    CreateRequiredRecords();

                    // Find a user using domain\username or first and last name details.
                    QueryExpression userQuery = new QueryExpression
                    {
                        EntityName = "systemuser",
                        // Retrieve all columns.
                        ColumnSet = new ColumnSet(new String[] { "systemuserid", "domainname", "fullname" }),

                        Criteria =
                        {
                            FilterOperator = LogicalOperator.Or,
                            Filters =
                            {   
                                new FilterExpression
                                {
                                    FilterOperator = LogicalOperator.And,
                                    Conditions =
                                    {
                                        new ConditionExpression("domainname", ConditionOperator.Equal, _domain + _userName)
                                    }
                                },
                                new FilterExpression
                                {
                                    FilterOperator = LogicalOperator.And,
                                    Conditions = 
                                    {
                                        new ConditionExpression("firstname", ConditionOperator.Equal, _firstName),
                                        new ConditionExpression("lastname", ConditionOperator.Equal, _lastName)
                                    }
                                }
                            }

                        }
                    };


                    EntityCollection entities = _serviceProxy.RetrieveMultiple(userQuery);

                    if (entities.Entities.Count > 0)
                    {
                        SystemUser user = entities[0].ToEntity<SystemUser>();

                        // Write out some key user properties.
                        Console.WriteLine("Id: {0}", user.Id);
                        Console.WriteLine("DomainName: {0}", user.DomainName);
                        Console.WriteLine("FullName: {0}", user.FullName);
                    }
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
            // Create/retrieve a user to get associated user details.
            SystemUser user = _serviceProxy.Retrieve(SystemUser.EntityLogicalName,
                SystemUserProvider.RetrieveAUserWithoutAnyRoleAssigned(_serviceProxy), 
                new ColumnSet(new String[] { "domainname", "firstname", "lastname" })).ToEntity<SystemUser>();


            // Extract the domain, username, firstname and lastname from the user record.
            String[] userPath = user.DomainName.Split(new char[] { '\\' });
            if (userPath.Length > 1)
            {
                _domain = userPath[0] + "\\";
                _userName = userPath[1];
            }
            else
            {
                _domain = String.Empty;
                _userName = userPath[0];
            }

            _firstName = user.FirstName;
            _lastName = user.LastName;
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

                RetrieveAUser app = new RetrieveAUser();
                app.Run(config, true);
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

// </snippetretrieveauser>