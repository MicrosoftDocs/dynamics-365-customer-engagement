// <snippetquickcampaign>


using System;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Description;

// These namespaces are found in the Microsoft.Xrm.Sdk.dll assembly
// found in the SDK\bin folder.
using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Query;
using Microsoft.Xrm.Sdk.Client;
using Microsoft.Xrm.Sdk.Messages;

// This namespace is found in Microsoft.Crm.Sdk.Proxy.dll assembly
// found in the SDK\bin folder.
using Microsoft.Crm.Sdk.Messages;

namespace Microsoft.Crm.Sdk.Samples
{
    /// <summary>
    /// This sample shows how to distribute a quick campaign to the marketing list members or to the accounts selected by a query.
    /// </summary>
	public class QuickCampaign
	{
		#region Class Level Members
        
        // Define the IDs as well as strings needed for this sample.
        //private static string _uniqStringForThisRun;
        private Guid[] _accountIdArray;
        Email _templateEmailActivity;
        Letter _templateLetterActivity;
        private Guid _newListId;
        private Guid _currentUser;
        private Guid _qcBOId;
        private OrganizationServiceProxy _serviceProxy;

        #endregion Class Level Members

        #region How To Sample Code
        /// <summary>
        /// Create and configure the organization service proxy.
        /// Initiate the method to create any data that this sample requires.
        /// Delete a new queue instance.
        /// Optionally delete any entity records that were created for this sample.
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

                    // Call the method to create any data that this sample requires.
                    CreateRequiredRecords();

                    #region Run a QC with marketing list as input


                    List newList = new List()
                    {
                        ListName = "TestList", 
                        CreatedFromCode = new OptionSetValue((int)ListCreatedFromCode.Account)
                    };

                    _newListId = _serviceProxy.Create(newList);

                    for (int j = 0; j < 5; j++)
                    {
                        AddMemberListRequest addMemberListRequest = new AddMemberListRequest();
                        addMemberListRequest.EntityId = _accountIdArray[j];
                        addMemberListRequest.ListId = _newListId;
                        AddMemberListResponse addMemberListResponse = 
                            _serviceProxy.Execute(addMemberListRequest) as AddMemberListResponse;
                    }

                    Guid BOId = CreateAndRetrieveQuickCampaignForMarketingList(
                        _templateLetterActivity, 
                        _newListId, 
                        PropagationOwnershipOptions.ListMemberOwner, 
                        true);


                    #endregion

                    #region Run a QC with a list of accounts as input

                    // Construct a Query Expression(QE) which specifies which records QC should include                
                    QueryExpression query = new QueryExpression("account");
                    query.ColumnSet = new ColumnSet("accountid");
                    query.Criteria = new FilterExpression();
                    FilterExpression filter = query.Criteria.AddFilter(LogicalOperator.Or);
                    for (int j = 0; j < 5; j++)
                    {
                        filter.AddCondition("accountid", ConditionOperator.Equal, _accountIdArray[j]);
                    }
                    _qcBOId = CreateAndRetrieveQuickCampaignForQueryExpression(
                        _templateEmailActivity, 
                        query, 
                        PropagationOwnershipOptions.ListMemberOwner,
                        true);

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
        /// This method creates a Quick Campaign for a set of accounts selected by a query
        /// </summary>
        /// <param name="activityEntity">
        /// An object that indicates activity type for the quick campaign and 
        /// contains values for each of activity that will be created
        /// </param>
        /// <param name="query">
        /// A query that provides a list of accounts for which 
        /// the quick campaign is distributed.
        /// </param>
        /// <param name="ownershipOption">
        /// Specifies who will own the activities created by the Quick Campaign
        ///	The PropagationOwnershipOptions enum is used to specify value for this parameter
        ///	</param>
        /// <param name="isPropagate">
        /// Specifies whether the operation is to be executed. 
        /// This input is often 'true' for Quick Campaign
        /// </param>        
        /// <returns></returns>
        public Guid CreateAndRetrieveQuickCampaignForQueryExpression(Entity emailActivityEntity, 
            QueryExpression query, PropagationOwnershipOptions ownershipOption, bool isPropagate)
        {
            
            // create the bulkoperation
            PropagateByExpressionRequest request = new PropagateByExpressionRequest() {
                Activity = emailActivityEntity,
                ExecuteImmediately = false, // Default value.
                FriendlyName = "Query Based Quick Campaign",
                OwnershipOptions = ownershipOption,
                QueryExpression = query,
                Owner = new EntityReference("systemuser", _currentUser),
                PostWorkflowEvent = true,
                SendEmail = false,
                TemplateId = Guid.Empty
            };

            PropagateByExpressionResponse response = 
                (PropagateByExpressionResponse)_serviceProxy.Execute(request);

            Guid bulkOpId = response.BulkOperationId;
            System.Console.WriteLine(
                "Quick Campaign with following name has been created. "
                + "Please verify in Web app manually: \n" 
                + request.FriendlyName + "\nPress enter to continue....");
            System.Console.ReadLine();
            return bulkOpId;

        }

        /// <summary>
        /// This method creates Quick Campaign for a given Marketing List and retruns the 
        /// Guid of the Quich Campaign which is modelled as bulk operation in CRM
        /// </summary>
        /// <param name="activityEntity">
        /// An object that indicates activity type for the quick campaign and 
        /// contains values for each activity that will be created
        /// </param>
        /// <param name="marketingListId">
        /// The ID of the marketing list to which quick campaign is distributed
        /// </param>
        /// <param name="ownershipOption">
        /// Specifies who will own the activities created by the Quick Campaign
        ///	The PropagationOwnershipOptions enum is used to specify value for this parameter
        ///	</param>
        /// <param name="isPropagate">
        /// Specifies whether the operation is to be executed. 
        /// This input is often 'true' for Quick Campaign
        /// </param>				
        public Guid CreateAndRetrieveQuickCampaignForMarketingList(
            Entity letterActivityEntity, 
            Guid marketingListId, 
            PropagationOwnershipOptions ownershipOption, 
            bool isPropagate)
        {
            //Create the request object from input parameters
            CreateActivitiesListRequest request = new CreateActivitiesListRequest() {
                Activity = letterActivityEntity,
                ListId = marketingListId,
                OwnershipOptions = ownershipOption,
                Propagate = isPropagate,
                TemplateId = Guid.Empty,
                FriendlyName = "Quick Campaign for My List",
                Owner = new EntityReference("systemuser", _currentUser),
                PostWorkflowEvent = true
            };

            //Execute the request
            CreateActivitiesListResponse response = 
                (CreateActivitiesListResponse)_serviceProxy.Execute(request);

            //On executing the request a BulkOperation record would be created in CRM. 
            //If isPropagate is true, a corresponding Async job is also created which runs and creates the required activities 
            //The response has BulkOperationId. This is the Id of the bulkoperation that mimics QuickCampaign in CRM
            Guid BOId = response.BulkOperationId;
            System.Console.WriteLine(
                "Quick Campaign with following name has been created. " 
                + "Please verify in Web app manually: \n" 
                + request.FriendlyName 
                + "\nPress enter to continue....");
            System.Console.ReadLine();

            return BOId;

        } 

        /// <summary>
        /// This method creates any entity records that this sample requires.
        /// Create a new queue instance.
        /// </summary>
        public void CreateRequiredRecords()
        {
            WhoAmIRequest whoRequest = new WhoAmIRequest();
            _currentUser = ((WhoAmIResponse)_serviceProxy.Execute(whoRequest)).UserId;

            //Create an activity objects which will act like a template during QC distrbution. 
            //The activities created by QC will create activities with content that this activity has
            _templateEmailActivity = new Email()
            {
                Subject = "qcCreatedEmailActivity"
            };

            _templateLetterActivity = new Letter()
            {
                Subject = "qcCreatedLetterActivity"
            };

            // Create accounts on which we want to run QC
            _accountIdArray = new Guid[5];
            for (int i = 0; i < 5; i++)
            {
                Account acct = new Account() {
                    Name = "Account For Quick Campaign " + i.ToString()
                };
                _accountIdArray[i] = _serviceProxy.Create(acct);
                Console.WriteLine("Created {0}.", acct.Name);
            }
        }

        /// <summary>
        /// Deletes/Reverts the record that was created/changed for this sample.
        /// <param name="prompt">Indicates whether to prompt the user to delete 
        /// the records created in this sample.</param>
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
                for (int i = 0; i<_accountIdArray.Length; i++) 
                    _serviceProxy.Delete(Account.EntityLogicalName, _accountIdArray[i]);
                _serviceProxy.Delete(List.EntityLogicalName, _newListId);
                _serviceProxy.Delete(BulkOperation.EntityLogicalName, _qcBOId);
                Console.WriteLine("Entity record(s) have been deleted.");
            }
        }

        #endregion How To Sample Code

        #region Main method
        /// <summary>
        /// Main. Runs the sample and provides error output.
        /// <param name="args">Array of arguments to Main method.</param>
        /// </summary>
        static public void Main(string[] args)
        {
            try
            {
                // Obtain the target organization's Web address and client logon 
                // credentials from the user.
                ServerConnection serverConnect = new ServerConnection();
                ServerConnection.Configuration config = serverConnect.GetServerConfiguration();

                QuickCampaign app = new QuickCampaign();
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

                    FaultException<Microsoft.Xrm.Sdk.OrganizationServiceFault> fe
                        = ex.InnerException
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
            // Additonal exceptions to catch: SecurityTokenValidationException, ExpiredSecurityTokenException,
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

// </snippetquickcampaign>