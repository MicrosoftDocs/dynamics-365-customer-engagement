// <snippetretrieveusersharedattributepermissions>


using System;
using System.ServiceModel;
using System.Linq;

// This namespace is in the Microsoft.Crm.Sdk.Proxy.dll assembly
// located in the SDK\bin folder.
using Microsoft.Crm.Sdk.Messages;

// These namespaces are in the Microsoft.Xrm.Sdk.dll assembly
// located in the SDK\bin folder of the SDK download.
using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Client;
using Microsoft.Xrm.Sdk.Messages;
using Microsoft.Xrm.Sdk.Query;
using Microsoft.Xrm.Sdk.Metadata;

namespace Microsoft.Crm.Sdk.Samples
{
    /// <summary>
    /// Currently, users must have prvReadPOAA permissions to access any 
    /// PrincipleObjectAttributeAccess (POAA) records. However, in an upcoming
    /// release, users who do not have prvReadPOAA permissions will be able 
    /// to access POAA records by using the RetrieveMultiple method. Users 
    /// will be able to retrieve attribute permissions for attributes shared 
    /// directly or indirectly (through teams) with themselves.  
    /// </summary>
    /// <remarks>
    /// At run time, you will be given the option to delete all the
    /// database records created by this program.
    /// </remarks>
    public class RetrieveUserSharedAttributePermissions
    {
        #region Class Level Members

        private Guid _accountRecordId;
        private Guid _secretPhoneId; 
        private Guid _secretHomeId; 
        private OrganizationServiceProxy _serviceProxy;

        #endregion Class Level Members

        #region How To Sample Code
        /// <summary>
        /// This method first checks if the logged on user has prvReadPOAA permissions. 
        /// Afterwards,  the method creates the secure custom fields required for this sample,
        /// an account record for testing purposes, and POAA records for the user
        /// and those custom fields.
        /// Finally, the method retrieves the User Shared Attribute permissions for that user.
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
                    // This statement is required to enable early bound type support.
                    _serviceProxy.EnableProxyTypes();

                    CreateRequiredRecords();


                    #region Check if this user has prvReadPOAA
                    // Get the GUID of the current user.
                    WhoAmIRequest whoAmI = new WhoAmIRequest();
                    Guid userLoggedId = 
                        ((WhoAmIResponse)_serviceProxy.Execute(whoAmI)).UserId;
                    Console.WriteLine("User logged: " + userLoggedId);

                    // Check if this user has prvReadPOAA.
                    RetrieveUserPrivilegesRequest userPrivilegesRequest = 
                        new RetrieveUserPrivilegesRequest();
                    userPrivilegesRequest.UserId = userLoggedId;
                    RetrieveUserPrivilegesResponse userPrivilegesResponse =
                        (RetrieveUserPrivilegesResponse)_serviceProxy.Execute(userPrivilegesRequest);

                    // Fixed the GUID for prvReadPOAA.
                    Guid prvReadPOAA = new Guid("{68564CD5-2B2E-11DF-80A6-00137299E1C2}");

                    if (userPrivilegesResponse.RolePrivileges.Any(r => r.PrivilegeId.Equals(prvReadPOAA)))
                    {
                        Console.WriteLine("This user DOES have prvReadPOAA");
                    }
                    else
                    {
                        Console.WriteLine("This user DOESN'T have prvReadPOAA");
                    }
                    Console.WriteLine();
                    #endregion Check if this user has prvReadPOAA
                    #region Create an account record

                    // Create an account record
                    Account accountRecord = new Account();
                    accountRecord.Name = "Ane";
                    accountRecord["secret_phone"] = "123456";
                    _accountRecordId = _serviceProxy.Create(accountRecord);
                    Console.WriteLine("Account record created.");

                    #endregion Create an account record

                    #region Create POAA entity for field #1

                    // Create POAA entity for field #1
                    PrincipalObjectAttributeAccess poaa = new PrincipalObjectAttributeAccess
                    {
                        AttributeId = _secretHomeId,
                        ObjectId = new EntityReference
                            (Account.EntityLogicalName, _accountRecordId),
                        PrincipalId = new EntityReference
                            (SystemUser.EntityLogicalName, userLoggedId),
                        ReadAccess = true,
                        UpdateAccess = true
                    };

                    _serviceProxy.Create(poaa);
                    Console.WriteLine("POAA record for custom field Secret_Home created.");

                    #endregion Create POAA entity for field #1

                    #region Create POAA entity for field #2

                    // Create POAA entity for field #2
                    poaa = new PrincipalObjectAttributeAccess
                    {
                        AttributeId = _secretPhoneId,
                        ObjectId = new EntityReference
                            (Account.EntityLogicalName, _accountRecordId), 
                        PrincipalId = new EntityReference
                            (SystemUser.EntityLogicalName, userLoggedId),
                        ReadAccess = true,
                        UpdateAccess = true
                    };

                    _serviceProxy.Create(poaa);
                    Console.WriteLine("POAA record for custom field Secret_Phone created.");

                    #endregion Create POAA entity for field #2

                    #region Retrieve User Shared Attribute Permissions
                    // Create the query for retrieve User Shared Attribute permissions.
                    QueryExpression queryPOAA =
                        new QueryExpression("principalobjectattributeaccess");
                    queryPOAA.ColumnSet = new ColumnSet
                        (new string[] { "attributeid", "readaccess", "updateaccess", "principalid" });
                    queryPOAA.Criteria.FilterOperator = LogicalOperator.And;
                    queryPOAA.Criteria.Conditions.Add
                        (new ConditionExpression("objectid", ConditionOperator.Equal, _accountRecordId));
                    queryPOAA.Criteria.Conditions.Add
                        (new ConditionExpression("principalid", ConditionOperator.EqualUserId));

                    Console.WriteLine();
                    Console.WriteLine("POAA for user: " + userLoggedId.ToString());
                    Console.WriteLine();

                    try
                    {
                        // Execute the query.
                        EntityCollection responsePOAA = _serviceProxy.RetrieveMultiple(queryPOAA);

                        foreach (var entity in responsePOAA.Entities)
                        {
                            Console.WriteLine("  principalid: " + ((EntityReference)entity["principalid"]).Id);
                            Console.WriteLine("  attributeid: " + entity["attributeid"].ToString());
                            Console.WriteLine("  readaccess: " + entity["readaccess"].ToString());
                            Console.WriteLine("  updateaccess: " + entity["updateaccess"].ToString());
                            Console.WriteLine();
                        }
                    }
                    catch (Exception exc)
                    {
                        Console.WriteLine("Error: " + exc.Message);
                    }

                    #endregion Retrieve User Shared Attribute Permissions

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
            #region Create custom fields in account entity
            
            // Create secure custom field #1
            CreateAttributeRequest attrReq = new CreateAttributeRequest()
            {
                Attribute = new StringAttributeMetadata()
                {
                    LogicalName = "secret_home",
                    DisplayName = new Label("SecretHome", 1033),
                    SchemaName = "Secret_Home",
                    MaxLength = 500,
                    RequiredLevel = new AttributeRequiredLevelManagedProperty(
                        AttributeRequiredLevel.Recommended),
                    IsSecured = true
                },
                EntityName = Account.EntityLogicalName
            };
            CreateAttributeResponse attributeResponse =
                (CreateAttributeResponse)_serviceProxy.Execute(attrReq);
            _secretHomeId = attributeResponse.AttributeId;
            Console.WriteLine("Secret_Home custom field created.");

            // Create secure custom field #2
            attrReq = new CreateAttributeRequest()
            {
                Attribute = new StringAttributeMetadata()
                {
                    LogicalName = "secret_phone",
                    DisplayName = new Label("SecretPhone", 1033),
                    SchemaName = "Secret_Phone",
                    MaxLength = 500,
                    RequiredLevel = new AttributeRequiredLevelManagedProperty(
                        AttributeRequiredLevel.Recommended),
                    IsSecured = true
                },
                EntityName = Account.EntityLogicalName
            };
            attributeResponse = (CreateAttributeResponse)_serviceProxy.Execute(attrReq);
            _secretPhoneId = attributeResponse.AttributeId;
            Console.WriteLine("Secret_Phone custom field created.");

            #endregion Create custom fields in account entity
            
            Console.WriteLine();
        }

        /// <summary>
        /// Deletes any entity records that were created for this sample.
        /// <param name="prompt">Indicates whether to prompt the user 
        /// to delete the records created in this sample.</param>
        /// </summary>
        public void DeleteRequiredRecords(bool prompt)
        {
            bool toBeDeleted = true;

            if (prompt)
            {
                // Ask the user if the created entities should be deleted.
                Console.Write("\nDo you want these entity records deleted? (y/n) [y]: ");
                String answer = Console.ReadLine();
                if (answer.StartsWith("y") ||
                    answer.StartsWith("Y") ||
                    answer == String.Empty)
                {
                    toBeDeleted = true;
                }
                else
                {
                    toBeDeleted = false;
                }
            }

            if (toBeDeleted)
            {
                // Delete all records created in this sample.
                // Delete the secured custom field #1.
                DeleteAttributeRequest deleteRequest = new DeleteAttributeRequest()
                {
                    EntityLogicalName = Account.EntityLogicalName,
                    LogicalName = "secret_phone",
                    RequestId = _secretPhoneId
                };
                _serviceProxy.Execute(deleteRequest);
                // Delete the secured custom field #2.
                deleteRequest = new DeleteAttributeRequest()
                {
                    EntityLogicalName = Account.EntityLogicalName,
                    LogicalName = "secret_home",
                    RequestId = _secretHomeId
                };
                _serviceProxy.Execute(deleteRequest);

                // Delete the account record.
                _serviceProxy.Delete(Account.EntityLogicalName, _accountRecordId);
                
                // We don't need to delete POAA records, because
                // they were deleted when we deleted the account record.

                Console.WriteLine("Entity record(s) have been deleted.");
            }
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

                RetrieveUserSharedAttributePermissions app = new RetrieveUserSharedAttributePermissions();
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

// </snippetretrieveusersharedattributepermissions>