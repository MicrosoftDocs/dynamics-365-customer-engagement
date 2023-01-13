// <snippetworkwithviews>


using System;
using System.ServiceModel;
using System.ServiceModel.Description;

// These namespaces are found in the Microsoft.Xrm.Sdk.dll assembly
// found in the SDK\bin folder.
using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Client;
using Microsoft.Xrm.Sdk.Query;
using Microsoft.Xrm.Sdk.Discovery;
using Microsoft.Xrm.Sdk.Messages;
using Microsoft.Xrm.Sdk.Metadata;

// This namespace is found in Microsoft.Crm.Sdk.Proxy.dll assembly
// found in the SDK\bin folder.
using Microsoft.Crm.Sdk.Messages;

namespace Microsoft.Crm.Sdk.Samples
{
    public class WorkWithViews
    {
        #region Class Level Members
        /// <summary>
        /// Stores the organization service proxy.
        /// </summary>
        private OrganizationServiceProxy _serviceProxy;

        //private const String _customEntityName = "new_bankaccount";
        private Guid _customViewId;
        private Guid _deactivatedViewId;
        private SavedQueryState _viewOriginalState;
        private OptionSetValue _viewOriginalStatus;

        #endregion Class Level Members

        #region How To Sample Code
        /// <summary>
        /// Create a view.
        /// Retrieve Views
        /// Deactivate a view
        /// </summary>
        /// <param name="serverConfig">Contains server connection information.</param>
        /// <param name="promptForDelete">When True, the user will be prompted to delete all
        /// created entities.</param>
        /// <param name="promptForReactivate">When True, the user will be prompted to reactivate
        /// a view that was deactivated.</param>
        public void Run(ServerConnection.Configuration serverConfig, bool promptForDelete, bool promptForReactivate)
        {
            try
            {

                // Connect to the Organization service. 
                // The using statement assures that the service proxy will be properly disposed.
                using (_serviceProxy = new OrganizationServiceProxy(serverConfig.OrganizationUri, serverConfig.HomeRealmUri, serverConfig.Credentials, serverConfig.DeviceCredentials))
                {
                    // This statement is required to enable early-bound type support.
                    _serviceProxy.EnableProxyTypes();

                    // Create the view.
                    System.String layoutXml =
                        @"<grid name='resultset' object='3' jump='name' select='1' 
                            preview='1' icon='1'>
                            <row name='result' id='opportunityid'>
                            <cell name='name' width='150' /> 
                            <cell name='customerid' width='150' /> 
                            <cell name='estimatedclosedate' width='150' /> 
                            <cell name='estimatedvalue' width='150' /> 
                            <cell name='closeprobability' width='150' /> 
                            <cell name='opportunityratingcode' width='150' /> 
                            <cell name='opportunitycustomeridcontactcontactid.emailaddress1' 
                                width='150' disableSorting='1' /> 
                            </row>
                        </grid>";

                    System.String fetchXml =
                        @"<fetch version='1.0' output-format='xml-platform' 
                            mapping='logical' distinct='false'>
                            <entity name='opportunity'>
                            <order attribute='estimatedvalue' descending='false' /> 
                            <filter type='and'>
                                <condition attribute='statecode' operator='eq' 
                                value='0' /> 
                            </filter>
                            <attribute name='name' /> 
                            <attribute name='estimatedvalue' /> 
                            <attribute name='estimatedclosedate' /> 
                            <attribute name='customerid' /> 
                            <attribute name='opportunityratingcode' /> 
                            <attribute name='closeprobability' /> 
                            <link-entity alias='opportunitycustomeridcontactcontactid' 
                                name='contact' from='contactid' to='customerid' 
                                link-type='outer' visible='false'>
                                <attribute name='emailaddress1' /> 
                            </link-entity>
                            <attribute name='opportunityid' /> 
                            </entity>
                        </fetch>";

                    SavedQuery sq = new SavedQuery
                    {
                        Name = "A New Custom Public View",
                        Description = "A Saved Query created in code",
                        ReturnedTypeCode = "opportunity",
                        FetchXml = fetchXml,
                        LayoutXml = layoutXml,
                        QueryType = 0
                    };
                    
                    _customViewId = _serviceProxy.Create(sq);
                    Console.WriteLine("A new view with the name {0} was created.", sq.Name);

                    
                    // Retrieve Views
                    QueryExpression mySavedQuery = new QueryExpression
                    {
                        ColumnSet = new ColumnSet("savedqueryid", "name", "querytype", "isdefault", "returnedtypecode", "isquickfindquery"),
                        EntityName = SavedQuery.EntityLogicalName,
                        Criteria = new FilterExpression
                        {
                            Conditions =
            {
                new ConditionExpression
                {
                    AttributeName = "querytype",
                    Operator = ConditionOperator.Equal,
                    Values = {0}
                },
                new ConditionExpression
                {
                    AttributeName = "returnedtypecode",
                    Operator = ConditionOperator.Equal,
                    Values = {Opportunity.EntityTypeCode}
                }
            }
                        }
                    };
                    RetrieveMultipleRequest retrieveSavedQueriesRequest = new RetrieveMultipleRequest { Query = mySavedQuery };

                    RetrieveMultipleResponse retrieveSavedQueriesResponse = (RetrieveMultipleResponse)_serviceProxy.Execute(retrieveSavedQueriesRequest);

                    DataCollection<Entity> savedQueries = retrieveSavedQueriesResponse.EntityCollection.Entities;

                    //Display the Retrieved views
                    foreach (Entity ent in savedQueries)
                    {
                        SavedQuery rsq = (SavedQuery)ent;
                        Console.WriteLine("{0} : {1} : {2} : {3} : {4} : {5},", rsq.SavedQueryId, rsq.Name, rsq.QueryType, rsq.IsDefault, rsq.ReturnedTypeCode, rsq.IsQuickFindQuery);
                    }

                    // Deactivate a view
                    System.String SavedQueryName = "Closed Opportunities in Current Fiscal Year";
                    QueryExpression ClosedOpportunitiesViewQuery = new QueryExpression
                    {
                        ColumnSet = new ColumnSet("savedqueryid", "statecode", "statuscode"),
                        EntityName = SavedQuery.EntityLogicalName,
                        Criteria = new FilterExpression
                        {
                            Conditions =
                            {
                                new ConditionExpression
                                {
                                    AttributeName = "querytype",
                                    Operator = ConditionOperator.Equal,
                                    Values = {0}
                                },
                                new ConditionExpression
                                {
                                    AttributeName = "returnedtypecode",
                                    Operator = ConditionOperator.Equal,
                                    Values = {Opportunity.EntityTypeCode}
                                },
                                                new ConditionExpression
                                {
                                    AttributeName = "name",
                                    Operator = ConditionOperator.Equal,
                                    Values = {SavedQueryName}
                                }
                            }
                        }
                    };

                    RetrieveMultipleRequest retrieveOpportuntiesViewRequest = new RetrieveMultipleRequest { Query = ClosedOpportunitiesViewQuery };

                    RetrieveMultipleResponse retrieveOpportuntiesViewResponse = (RetrieveMultipleResponse)_serviceProxy.Execute(retrieveOpportuntiesViewRequest);

                    SavedQuery OpportunityView = (SavedQuery)retrieveOpportuntiesViewResponse.EntityCollection.Entities[0];
                    _viewOriginalState = (SavedQueryState)OpportunityView.StateCode;
                    _viewOriginalStatus = OpportunityView.StatusCode;
                    

                    SetStateRequest ssreq = new SetStateRequest
                    {
                        EntityMoniker = new EntityReference(SavedQuery.EntityLogicalName, (Guid)OpportunityView.SavedQueryId),
                        State = new OptionSetValue((int)SavedQueryState.Inactive),
                        Status = new OptionSetValue(2)
                    };
                    _serviceProxy.Execute(ssreq);
                    _deactivatedViewId = (Guid)OpportunityView.SavedQueryId;


                    DeleteRequiredRecords(promptForDelete);
                    ReactivateDeactivatedView(promptForReactivate);
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
        /// Deletes the custom view that was created for this sample.
        /// <param name="prompt">Indicates whether to prompt the user to delete the records created in this sample.</param>
        /// </summary>
        public void DeleteRequiredRecords(bool prompt)
        {
            bool deleteView = true;

            if (prompt)
            {
                Console.WriteLine("\nDo you want this custom view deleted? (y/n)");
                String answer = Console.ReadLine();

                deleteView = (answer.StartsWith("y") || answer.StartsWith("Y"));
            }

            if (deleteView)
            {
                _serviceProxy.Delete(SavedQuery.EntityLogicalName, _customViewId);
                Console.WriteLine("The view has been deleted.");
            }
        }
        /// <summary>
        /// Reactivates the view that was deactivated for this sample.
        /// <param name="prompt">Indicates whether to prompt the user to reactivate the view deactivated in this sample.</param>
        /// </summary>
        public void ReactivateDeactivatedView(bool prompt)
        {
            bool reactivateView = true;

            if (prompt)
            {
                Console.WriteLine("\nDo you want to reactivate the \"Closed Opportunities in Current Fiscal Year\" view? (y/n)");
                String answer = Console.ReadLine();

                reactivateView = (answer.StartsWith("y") || answer.StartsWith("Y"));
            }

            if (reactivateView)
            {
                SetStateRequest reactivateViewRequest = new SetStateRequest
                {
                    EntityMoniker = new EntityReference(SavedQuery.EntityLogicalName, _deactivatedViewId),
                    State = new OptionSetValue((int)_viewOriginalState),
                    Status = _viewOriginalStatus
                };
                _serviceProxy.Execute(reactivateViewRequest);
                Console.WriteLine("The view has been reactivated.");
            }
        }

        #endregion How To Sample Code

        #region Main
        /// <summary>
        /// Slightly modified Main() method used by most SDK samples.
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

                WorkWithViews app = new WorkWithViews();
                // The Run method has an additional parameter to prompt for reactivation of a view.
                app.Run(config, true, true);
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
        #endregion Main
    }
}

// </snippetworkwithviews>
