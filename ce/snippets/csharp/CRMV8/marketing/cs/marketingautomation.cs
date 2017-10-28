// <snippetmarketingautomation>


using System;
using System.ServiceModel;
using System.Linq;
// This namespace is found in Microsoft.Crm.Sdk.Proxy.dll assembly
// found in the SDK\bin folder.
using Microsoft.Crm.Sdk.Messages;
// These namespaces are found in the Microsoft.Xrm.Sdk.dll assembly
// located in the SDK\bin folder of the SDK download.
using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Client;
using Microsoft.Xrm.Sdk.Messages;
using Microsoft.Xrm.Sdk.Query;

namespace Microsoft.Crm.Sdk.Samples
{
    /// <summary>
    /// Demonstrate how to create a dynamic list and distribute campaign activities to 
    /// the members on the list.
    /// </summary>
    /// <remarks>
    /// At run-time, you will be given the option to delete all the
    /// database records created by this program.</remarks>
    public class MarketingAutomation
    {
        #region Class Level Members

        private Guid _salesManagerId;
        private Guid _accountId;
        private Guid _campaignId;
        private Guid _campaignActivityId;
        private Guid _dynamicListId;
        private Guid _staticListId;
        private OrganizationServiceProxy _serviceProxy;

        #endregion Class Level Members

        #region How To Sample Code
        /// <summary>
        /// This method first connects to the Organization service. Afterwards a dynamic
        /// list is created and associated to the campaign and the campaign's activity.
        /// Then the dynamic list is copied to a static list and associated with the same
        /// campaign and campaign activity. Finally the sample distributes the campaign
        /// to both the dynamic and static lists.
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

                    CreateRequiredRecords();

                    #region Create Dynamic List

                    // Create FetchXml for marketing list's query which locates accounts
                    // in Seattle.
                    String fetchXml = @"<fetch version='1.0' output-format='xml-platform' mapping='logical' distinct='false'>
                                        <entity name='account'>
                                        <attribute name='name' />
                                        <attribute name='address1_city' />
                                        <attribute name='primarycontactid' />
                                        <attribute name='telephone1' />
                                        <attribute name='accountid' />
                                        <order attribute='name' descending='false' />
                                        <filter type='and'>
                                        <condition attribute='address1_city' operator='eq' value='seattle' />
                                        </filter>
                                        </entity>
                                        </fetch>";
                    // Create dynamic list. Set the type to true to declare a dynamic
                    // list.
                    List dynamicList = new List()
                    {
                        Type = true,
                        ListName = "Dynamic List",
                        CreatedFromCode = new OptionSetValue((int)ListCreatedFromCode.Account),
                        Query = fetchXml
                    };
                    _dynamicListId = _serviceProxy.Create(dynamicList);
                    dynamicList.Id = _dynamicListId;

                    Console.WriteLine("Created dynamic list.");

                    #endregion

                    #region Associate dynamic list to campaign

                    // Create a campaign.
                    Campaign campaign = new Campaign()
                    {
                        Name = "Sample Campaign"
                    };
                    _campaignId = _serviceProxy.Create(campaign);
                    campaign.Id = _campaignId;

                    // Add the dynamic list to the campaign.
                    AddItemCampaignRequest addListToCampaignRequest =
                        new AddItemCampaignRequest()
                        {
                            CampaignId = _campaignId,
                            EntityId = _dynamicListId,
                            EntityName = List.EntityLogicalName,
                        };
                    _serviceProxy.Execute(addListToCampaignRequest);

                    Console.WriteLine("Added dynamic list to the campaign.");

                    // Create a campaign activity to distribute fax to the list members.
                    CampaignActivity campaignActivity = new CampaignActivity()
                    {
                        Subject = "Sample Campaign Activity",
                        ChannelTypeCode = new OptionSetValue((int)CampaignActivityChannelTypeCode.Fax),
                        RegardingObjectId = campaign.ToEntityReference()
                    };
                    _campaignActivityId = _serviceProxy.Create(campaignActivity);

                    // Add dynamic list to campaign activity.
                    AddItemCampaignActivityRequest addListToCampaignActivityRequest = 
                        new AddItemCampaignActivityRequest()
                    {
                        CampaignActivityId = _campaignActivityId,
                        ItemId = _dynamicListId,
                        EntityName = List.EntityLogicalName
                    };
                    _serviceProxy.Execute(addListToCampaignActivityRequest);

                    Console.WriteLine("Added dynamic list to the campaign activity.");

                    #endregion

                    #region Associate static list to campaign

                    // Copy the dynamic list to a static list.
                    CopyDynamicListToStaticRequest copyRequest = 
                        new CopyDynamicListToStaticRequest()
                        {
                            ListId = _dynamicListId
                        };
                    CopyDynamicListToStaticResponse copyResponse =
                        (CopyDynamicListToStaticResponse)_serviceProxy.Execute(copyRequest);
                    _staticListId = copyResponse.StaticListId;

                    Console.WriteLine("Copied dynamic list to a static list.");

                    // Add the static list to the campaign.
                    AddItemCampaignRequest addStaticListToCampaignRequest =
                        new AddItemCampaignRequest()
                        {
                            CampaignId = _campaignId,
                            EntityId = _staticListId,
                            EntityName = List.EntityLogicalName
                        };
                    _serviceProxy.Execute(addStaticListToCampaignRequest);

                    Console.WriteLine("Added static list to the campaign.");

                    // Add the static list to the campaign activity.
                    AddItemCampaignActivityRequest addStaticListToCampaignActivityRequest = 
                        new AddItemCampaignActivityRequest()
                    {
                        CampaignActivityId = _campaignActivityId,
                        ItemId = _staticListId,
                        EntityName = List.EntityLogicalName
                    };
                    _serviceProxy.Execute(addStaticListToCampaignActivityRequest);

                    Console.WriteLine("Added static list to the campaign's activity.");

                    #endregion

                    #region Create fax for campaign's activity
                    // Create a fax.
                    Fax fax = new Fax()
                    {
                        Subject = "Example Fax"
                    };

                    Console.WriteLine("Created fax for campaign's activity.");
                    #endregion Create fax for campaign's activity

                    #region Distribute fax to the marketing list
                    // Distribute the campaign activity to the marketing lists.
                    DistributeCampaignActivityRequest distributeRequest = 
                        new DistributeCampaignActivityRequest() 
                        { 
                            CampaignActivityId = _campaignActivityId,
                            Activity = fax,
                            Owner = new EntityReference("systemuser", _salesManagerId),
                            Propagate = true,
                            SendEmail = false,
                            PostWorkflowEvent = true
                        };
                    _serviceProxy.Execute(distributeRequest);

                    Console.WriteLine("Distributed fax to the marketing lists.");
                    #endregion Distribute fax to the marketing list

                    #region Retrieve collection of entities from marketing list
                    // Retrieve a collection of entities that correspond 
                    // to all of the members in a marketing list
                    // This approach of retrieving list members allows you to dynamically
                    // retrieve the members of a list programmatically without requiring 
                    // knowledge of the member entity type.
                    OrganizationServiceContext orgContext = 
                        new OrganizationServiceContext(_serviceProxy);

                    var member = (from mb in orgContext.CreateQuery<List>()
                                  where mb.Id == _dynamicListId
                                  select mb).FirstOrDefault();

                    string fetchQuery = member.Query;

                    RetrieveMultipleRequest memberRequest = new RetrieveMultipleRequest();
                    FetchExpression fetch = new FetchExpression(fetchQuery);
                    memberRequest.Query = fetch;
                    RetrieveMultipleResponse memberResponse = 
                        (RetrieveMultipleResponse)_serviceProxy.Execute(memberRequest);

                    Console.WriteLine("Retrieved collection of entities from a marketing list.");
                    #endregion Retrieve collection of entities from marketing list

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
            // Retrieve a sales manager.
            _salesManagerId =
                SystemUserProvider.RetrieveMarketingManager(_serviceProxy);

            // Create an account.
            Account account = new Account()
            {
                Name = "Fourth Coffee",
                Address1_City = "Seattle"
            };
            _accountId = _serviceProxy.Create(account);
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
                _serviceProxy.Delete(List.EntityLogicalName, _staticListId);
                _serviceProxy.Delete(List.EntityLogicalName, _dynamicListId);
                _serviceProxy.Delete("campaignactivity", _campaignActivityId);
                _serviceProxy.Delete("campaign", _campaignId);
                _serviceProxy.Delete("account", _accountId);

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
                // Obtain the target organization's Web address and client logon 
                // credentials from the user.
                ServerConnection serverConnect = new ServerConnection();
                ServerConnection.Configuration config = serverConnect.GetServerConfiguration();

                MarketingAutomation app = new MarketingAutomation();
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

// </snippetmarketingautomation>