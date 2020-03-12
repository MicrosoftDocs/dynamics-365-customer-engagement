// <snippetdistributecampaignfrommarketinglist>


using System;
using System.Collections.Generic;
using System.ServiceModel;
using Microsoft.Crm.Sdk.Messages;
using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Client;
using Microsoft.Xrm.Sdk.Query;

namespace Microsoft.Crm.Sdk.Samples
{
    public class DistributeCampaignFromMarketingList
    {
        #region Class Level Members

        private Guid _accountId;
        private OrganizationServiceProxy _serviceProxy;
        private readonly List<Guid> _contactIdList = new List<Guid>();
        private Guid _marketingListId;
        private Guid _copiedMarketingListId;
        private Guid _campaignId;
        private  Guid _campaignActivityId;
        private Guid _originalCampaignId;

        #endregion Class Level Members

        #region Nested Classes

        // This static class contains the possible values for marketing list types.
        private static class MarketingListType
        {
            internal static bool Static = false;
            internal static bool Dynamic = true;
        }

        // This static class contains values for overriding or removing when making a qualify
        // member list request.  (Overriding means replacing all members of the list with
        // the specified members in the request.)
        private static class OverrideOrRemove
        {
            internal static bool Override = true;
            internal static bool Remove = false;
        }

        #endregion Nested Classes

        #region How To Sample Code

        public void Run(ServerConnection.Configuration serverConfig,
        bool promptforDelete)
        {
            using (_serviceProxy = new OrganizationServiceProxy(serverConfig.OrganizationUri, serverConfig.HomeRealmUri,serverConfig.Credentials, serverConfig.DeviceCredentials))
            {
                // This statement is required to enable early bound type support.
                _serviceProxy.EnableProxyTypes();
                CreateRequiredRecords();
                CreateMarketingList();
                DistributeCampaign();
                DeleteRecords(promptforDelete);
            }
        }

        private void DistributeCampaign()
        {
            Console.WriteLine("=== Creating and Distributing the Campaign ===");
            // Create the campaign.
            var campaign = new Campaign
            {
                Name = "Sample Campaign"
            };

            _originalCampaignId = _serviceProxy.Create(campaign);

            NotifyEntityCreated(Campaign.EntityLogicalName, _originalCampaignId);

            // Copy the campaign.
            var campaignCopyRequest = new CopyCampaignRequest
            {
                BaseCampaign = _originalCampaignId
            };

            var copyCampaignResponse =
                (CopyCampaignResponse)_serviceProxy.Execute(campaignCopyRequest);
            _campaignId = copyCampaignResponse.CampaignCopyId;

            Console.WriteLine("  Copied the campaign to new campaign with GUID \r\n\t{{{0}}}",
                _campaignId);

            var activity = new CampaignActivity
            {
                Subject = "Sample phone call",
                ChannelTypeCode = new OptionSetValue((int)CampaignActivityChannelTypeCode.Phone),
                RegardingObjectId = new EntityReference(
                    Campaign.EntityLogicalName, _campaignId)
            };

            _campaignActivityId = _serviceProxy.Create(activity);

            NotifyEntityCreated(CampaignActivity.EntityLogicalName, _campaignActivityId);

            // Find the current user to determine who the owner of the activity should be.
            var whoAmI = new WhoAmIRequest();
            var currentUser = (WhoAmIResponse)_serviceProxy.Execute(whoAmI);

            // Add the marketing list created earlier to the campaign.
            var addListToCampaignRequest = new AddItemCampaignRequest
            {
                CampaignId = _campaignId,
                EntityId = _copiedMarketingListId,
                EntityName = List.EntityLogicalName,
            };

            _serviceProxy.Execute(addListToCampaignRequest);

            Console.WriteLine("  Added the marketing list to the campaign.");

            // Add the marketing list created earlier to the campaign activity.
            var addListToActivityRequest = new AddItemCampaignActivityRequest
            {
                CampaignActivityId = _campaignActivityId,
                ItemId = _copiedMarketingListId,
                EntityName = List.EntityLogicalName
            };

            _serviceProxy.Execute(addListToActivityRequest);

            Console.WriteLine("  Added the marketing list to the campaign activity.");

            // Create the phone call to use for distribution.
            var phonecall = new PhoneCall
            {
                Subject = "Sample Phone Call"
            };

            // Distribute and execute the campaign activity.
            // PostWorkflowEvent signals Microsoft Dynamics CRM to actually create the phone call activities.
            // Propagate also signals to Microsoft Dynamics CRM to create the phone call activities.
            // OwnershipOptions indicates whom the created activities should be assigned
            // to.
            var distributeRequest = new DistributeCampaignActivityRequest
            {
                Activity = phonecall,
                CampaignActivityId = _campaignActivityId,
                Owner = new EntityReference(
                    SystemUser.EntityLogicalName, currentUser.UserId),
                OwnershipOptions = PropagationOwnershipOptions.Caller,
                PostWorkflowEvent = true,
                Propagate = true,
                SendEmail = false,
            };

            var distributeResponse = 
                (DistributeCampaignActivityResponse)_serviceProxy.Execute(distributeRequest);

            Console.WriteLine("  Distributed and executed the campaign activity to the marketing list.");

            // Retrieve the members that were distributed to.
            var retrieveMembersRequest = new RetrieveMembersBulkOperationRequest
            {
                BulkOperationId = distributeResponse.BulkOperationId,
                BulkOperationSource = (int)BulkOperationSource.CampaignActivity,
                EntitySource = (int)EntitySource.Contact,
                Query = new QueryExpression(Contact.EntityLogicalName)
            };

            var retrieveMembersResponse = (RetrieveMembersBulkOperationResponse)
                _serviceProxy.Execute(retrieveMembersRequest);

            Console.WriteLine("  Contacts with the following GUIDs were distributed to:");
            foreach (var member in retrieveMembersResponse.EntityCollection.Entities)
            {
                Console.WriteLine("\t{{{0}}}", member.Id);
            }
        }

        private void CreateMarketingList()
        {
            Console.WriteLine("=== Creating the Marketing List ===");
            // Create the marketing list.  Make it static because members are going to be
            // added to the list.
            var list = new List
            {
                CreatedFromCode = new OptionSetValue((int)ListCreatedFromCode.Contact),
                ListName = "Sample Contact Marketing List",
                Type = MarketingListType.Static
            };
            
            _marketingListId = _serviceProxy.Create(list);

            NotifyEntityCreated(List.EntityLogicalName, _marketingListId);

            // Add a list of contacts to the marketing list.
            var addMemberListReq = new AddListMembersListRequest
            {
                MemberIds = new[] { _contactIdList[0], _contactIdList[2] },
                ListId = _marketingListId
            };

            _serviceProxy.Execute(addMemberListReq);

            Console.WriteLine("  Contacts with GUIDs \r\n\t{{{0}}}\r\n\tand {{{1}}}\r\n  were added to the list.",
                _contactIdList[0], _contactIdList[1]);

            // Copy the marketing list.  First create a new one, and then copy over the
            // members.
            list.ListName = list.ListName + " Copy";
            _copiedMarketingListId = _serviceProxy.Create(list);
            var copyRequest = new CopyMembersListRequest
            {
                SourceListId = _marketingListId,
                TargetListId = _copiedMarketingListId
            };

            _serviceProxy.Execute(copyRequest);

            // Add a single contact to the copied marketing list.
            var addMemberReq = new AddMemberListRequest
            {
                EntityId = _contactIdList[1],
                ListId = _copiedMarketingListId
            };

            _serviceProxy.Execute(addMemberReq);

            Console.WriteLine("  Contact with GUID\r\n\t{{{0}}}\r\n  was added to the list.",
                _contactIdList[1]);

            // Qualify the marketing list.
            var qualifyRequest = new QualifyMemberListRequest
            {
                OverrideorRemove = OverrideOrRemove.Override,
                MembersId = new[] { _contactIdList[0], _contactIdList[1] },
                ListId = _copiedMarketingListId
            };

            _serviceProxy.Execute(qualifyRequest);

            Console.WriteLine("  Qualified the copied marketing list so that it only\r\n    includes the first two members.");
        }

        private void NotifyEntityCreated(string entityName, Guid entityId)
        {
            Console.WriteLine("  {0} created with GUID {{{1}}}",
                entityName, entityId);
        }

        private void CreateRequiredRecords()
        {
            // Create an account.
            var account = new Account
            {
                Name = "Litware, Inc.",
                Address1_StateOrProvince = "Colorado"
            };
            _accountId = _serviceProxy.Create(account);

            // Create the contacts.
            var contact = new Contact
            {
                FirstName = "Ben",
                LastName = "Andrews",
                EMailAddress1 = "sample@example.com",
                Address1_City = "Redmond",
                Address1_StateOrProvince = "WA",
                Address1_Telephone1 = "(206)555-5555",
                ParentCustomerId = new EntityReference
                {
                    Id = _accountId,
                    LogicalName = account.LogicalName
                }
            };
            _contactIdList.Add(_serviceProxy.Create(contact));

            contact = new Contact
            {
                FirstName = "Colin",
                LastName = "Wilcox",
                EMailAddress1 = "sample@example.com",
                Address1_City = "Bellevue",
                Address1_StateOrProvince = "WA",
                Address1_Telephone1 = "(425)555-5555",
                ParentCustomerId = new EntityReference
                {
                    Id = _accountId,
                    LogicalName = account.LogicalName
                }
            };
            _contactIdList.Add(_serviceProxy.Create(contact));

            contact = new Contact
            {
                FirstName = "Lisa",
                LastName = "Andrews",
                EMailAddress1 = "sample@example.com",
                Address1_City = "Redmond",
                Address1_StateOrProvince = "WA",
                Address1_Telephone1 = "(206)555-5556",
                ParentCustomerId = new EntityReference
                {
                    Id = _accountId,
                    LogicalName = account.LogicalName
                }
            };
            _contactIdList.Add(_serviceProxy.Create(contact));

        }

        private void RemoveRelationships()
        {
            // Remove the marketing list from the campaign activity.
            var removeFromCampaignActivity = new RemoveItemCampaignActivityRequest
            {
                CampaignActivityId = _campaignActivityId,
                ItemId = _copiedMarketingListId
            };

            _serviceProxy.Execute(removeFromCampaignActivity);
            Console.WriteLine("  Removed the marketing list from the campaign activity.");

            // Remove the marketing list from the campaign.
            var removeFromCampaign = new RemoveItemCampaignRequest
            {
                CampaignId = _campaignId,
                EntityId = _copiedMarketingListId
            };

            _serviceProxy.Execute(removeFromCampaign);
            Console.WriteLine("  Removed the marketing list from the campaign.");
        }

        private void DeleteRecords(bool prompt)
        {
            var toBeDeleted = true;
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
                RemoveRelationships();

                // Delete the marketing lists.
                _serviceProxy.Delete(List.EntityLogicalName, _marketingListId);
                _serviceProxy.Delete(List.EntityLogicalName, _copiedMarketingListId);

                // Delete the contacts.
                foreach (var contactId in _contactIdList)
                {
                    _serviceProxy.Delete(Contact.EntityLogicalName, contactId);
                }

                // Delete the account.
                _serviceProxy.Delete(Account.EntityLogicalName, _accountId);

                // Just delete the campaign, no need to delete the campaign activity.
                _serviceProxy.Delete(Campaign.EntityLogicalName, _campaignId);
                _serviceProxy.Delete(Campaign.EntityLogicalName, _originalCampaignId);                
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

                var app = new DistributeCampaignFromMarketingList();
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

// </snippetdistributecampaignfrommarketinglist>