// <snippetoverridegoaltotalcount>


using System;
using System.ServiceModel;
using System.Collections.Generic;

// These namespaces are found in the Microsoft.Xrm.Sdk.dll assembly
// located in the SDK\bin folder of the SDK download.
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
    /// Demonstrates how to override the goal total count and close a goal.</summary>
    /// <remarks>
    /// At run-time, you will be given the option to delete all the
    /// database records created by this program.</remarks>
    public class OverrideGoalTotalCount
    {
        #region Class Level Members

        private Guid _metricId;
        private Guid _actualId;
        private Guid _inprogressId;
        private Guid _goalId;
        private Guid _accountId;
        private Guid _salesManagerId;
        private Guid _phoneCallId;
        private Guid _phoneCall2Id;
        private List<Guid> _rollupQueryIds = new List<Guid>();

        private OrganizationServiceProxy _serviceProxy;

        #endregion Class Level Members

        #region How To Sample Code
        /// <summary>
        /// This method first connects to the Organization service. Afterwards,
        /// a goal is created specifying the target count. The goal is then
        /// rolled up, the actual and in-progress values are overridden and finally the 
        /// goal is closed.
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

                    // Create the count metric, setting the Metric Type to 'Count' by
                    // setting IsAmount to false.
                    Metric sampleMetric = new Metric()
                    {
                        Name = "Sample Count Metric",
                        IsAmount = false,
                    };
                    _metricId = _serviceProxy.Create(sampleMetric);
                    sampleMetric.Id = _metricId;

                    Console.Write("Created phone call metric, ");

                    #region Create RollupFields

                    // Create RollupField which targets completed (received) phone calls.
                    RollupField actual = new RollupField()
                    {
                        SourceEntity = PhoneCall.EntityLogicalName,
                        GoalAttribute = "actualinteger",
                        SourceState = 1,
                        SourceStatus = 4,
                        EntityForDateAttribute = PhoneCall.EntityLogicalName,
                        DateAttribute = "actualend",
                        MetricId = sampleMetric.ToEntityReference()
                    };
                    _actualId = _serviceProxy.Create(actual);

                    Console.Write("created actual revenue RollupField, ");

                    // Create RollupField which targets open (in-progress) phone calls.
                    RollupField inprogress = new RollupField()
                    {
                        SourceEntity = PhoneCall.EntityLogicalName,
                        GoalAttribute = "inprogressinteger",
                        SourceState = 0,
                        EntityForDateAttribute = PhoneCall.EntityLogicalName,
                        DateAttribute = "createdon",
                        MetricId = sampleMetric.ToEntityReference()
                    };
                    _inprogressId = _serviceProxy.Create(inprogress);

                    Console.Write("created in-progress revenue RollupField, ");

                    #endregion

                    #region Create the goal rollup queries

                    // Note: Formatting the FetchXml onto multiple lines in the following 
                    // rollup queries causes the length property to be greater than 1,000
                    // chars and will cause an exception.

                    // The following query locates closed incoming phone calls.
                    GoalRollupQuery goalRollupQuery = new GoalRollupQuery()
                    {
                        Name = "Example Goal Rollup Query - Actual",
                        QueryEntityType = PhoneCall.EntityLogicalName,
                        FetchXml = @"<fetch version='1.0' output-format='xml-platform' mapping='logical' distinct='false'><entity name='phonecall'><attribute name='subject'/><attribute name='statecode'/><attribute name='prioritycode'/><attribute name='scheduledend'/><attribute name='createdby'/><attribute name='regardingobjectid'/><attribute name='activityid'/><order attribute='subject' descending='false'/><filter type='and'><condition attribute='directioncode' operator='eq' value='0'/><condition attribute='statecode' operator='eq' value='1' /></filter></entity></fetch>"
                    };
                    _rollupQueryIds.Add(_serviceProxy.Create(goalRollupQuery));
                    goalRollupQuery.Id = _rollupQueryIds[0];

                    // The following query locates open incoming phone calls.
                    GoalRollupQuery inProgressGoalRollupQuery = new GoalRollupQuery()
                    {
                        Name = "Example Goal Rollup Query - InProgress",
                        QueryEntityType = PhoneCall.EntityLogicalName,
                        FetchXml = @"<fetch version='1.0' output-format='xml-platform' mapping='logical' distinct='false'><entity name='phonecall'><attribute name='subject'/><attribute name='statecode'/><attribute name='prioritycode'/><attribute name='scheduledend'/><attribute name='createdby'/><attribute name='regardingobjectid'/><attribute name='activityid'/><order attribute='subject' descending='false'/><filter type='and'><condition attribute='directioncode' operator='eq' value='0'/><condition attribute='statecode' operator='eq' value='0' /></filter></entity></fetch>"
                    };
                    _rollupQueryIds.Add(_serviceProxy.Create(inProgressGoalRollupQuery));
                    inProgressGoalRollupQuery.Id = _rollupQueryIds[1];

                    Console.Write("created rollup queries for incoming phone calls.\n");
                    Console.WriteLine();

                    #endregion

                    #region Create a goal to track the open incoming phone calls.

                    // Create the goal.
                    Goal goal = new Goal()
                    {
                        Title = "Sample Goal",
                        RollupOnlyFromChildGoals = false,
                        ConsiderOnlyGoalOwnersRecords = false,
                        TargetInteger = 5,
                        RollupQueryActualIntegerId = goalRollupQuery.ToEntityReference(),
                        RollUpQueryInprogressIntegerId = 
                            inProgressGoalRollupQuery.ToEntityReference(),
                        IsFiscalPeriodGoal = false,
                        MetricId = sampleMetric.ToEntityReference(),
                        GoalOwnerId = new EntityReference
                        {
                            Id = _salesManagerId,
                            LogicalName = SystemUser.EntityLogicalName
                        },
                        OwnerId = new EntityReference
                        {
                            Id = _salesManagerId,
                            LogicalName = SystemUser.EntityLogicalName
                        },
                        GoalStartDate = DateTime.Today.AddDays(-1),
                        GoalEndDate = DateTime.Today.AddDays(30)
                    };
                    _goalId = _serviceProxy.Create(goal);
                    goal.Id = _goalId;

                    Console.WriteLine("Created goal");
                    Console.WriteLine("-------------------");
                    Console.WriteLine("Target: {0}", goal.TargetInteger.Value);
                    Console.WriteLine("Goal owner: {0}", goal.GoalOwnerId.Id);
                    Console.WriteLine("Goal Start Date: {0}", goal.GoalStartDate);
                    Console.WriteLine("Goal End Date: {0}", goal.GoalEndDate);
                    Console.WriteLine("<End of Listing>");
                    Console.WriteLine();

                    #endregion

                    #region Calculate rollup and display result

                    // Calculate roll-up of the goal.
                    RecalculateRequest recalculateRequest = new RecalculateRequest()
                    {
                        Target = goal.ToEntityReference()
                    };
                    _serviceProxy.Execute(recalculateRequest);

                    Console.WriteLine("Calculated roll-up of goal.");
                    Console.WriteLine();

                    // Retrieve and report 3 different computed values for the goal
                    // - Percentage
                    // - Actual (Integer)
                    // - In-Progress (Integer)
                    QueryExpression retrieveValues = new QueryExpression()
                    {
                        EntityName = Goal.EntityLogicalName,
                        ColumnSet = new ColumnSet(
                            "title",
                            "percentage",
                            "actualinteger",
                            "inprogressinteger")
                    };
                    EntityCollection ec = _serviceProxy.RetrieveMultiple(retrieveValues);

                    // Compute and display the results.
                    for (int i = 0; i < ec.Entities.Count; i++)
                    {
                        Goal temp = (Goal)ec.Entities[i];
                        Console.WriteLine("Roll-up details for goal: {0}", temp.Title);
                        Console.WriteLine("---------------");
                        Console.WriteLine("Percentage Achieved: {0}",
                            temp.Percentage);
                        Console.WriteLine("Actual (Integer): {0}",
                            temp.ActualInteger.Value);
                        Console.WriteLine("In-Progress (Integer): {0}",
                            temp.InProgressInteger.Value);
                        Console.WriteLine("<End of Listing>");
                    }

                    Console.WriteLine();

                    #endregion

                    #region Update goal to override the actual rollup value

                    // Override the actual and in-progress values of the goal.
                    // To prevent rollup values to be overwritten during next Recalculate operation, 
                    // set: goal.IsOverridden = true;

                    goal.IsOverride = true;
                    goal.ActualInteger = 10;
                    goal.InProgressInteger = 5;

                    // Update the goal.
                    UpdateRequest update = new UpdateRequest()
                    {
                        Target = goal
                    };
                    _serviceProxy.Execute(update);

                    Console.WriteLine("Goal actual and in-progress values overridden.");
                    Console.WriteLine();

                    #endregion

                    #region Retrieve result of manual override

                    // Retrieve and report 3 different computed values for the goal
                    // - Percentage
                    // - Actual (Integer)
                    // - In-Progress (Integer)
                    retrieveValues = new QueryExpression()
                    {
                        EntityName = Goal.EntityLogicalName,
                        ColumnSet = new ColumnSet(
                            "title",
                            "percentage",
                            "actualinteger",
                            "inprogressinteger")
                    };
                    ec = _serviceProxy.RetrieveMultiple(retrieveValues);

                    // Compute and display the results.
                    for (int i = 0; i < ec.Entities.Count; i++)
                    {
                        Goal temp = (Goal)ec.Entities[i];
                        Console.WriteLine("Roll-up details for goal: {0}", temp.Title);
                        Console.WriteLine("---------------");
                        Console.WriteLine("Percentage Achieved: {0}",
                            temp.Percentage);
                        Console.WriteLine("Actual (Integer): {0}",
                            temp.ActualInteger.Value);
                        Console.WriteLine("In-Progress (Integer): {0}",
                            temp.InProgressInteger.Value);
                        Console.WriteLine("<End of Listing>");
                    }

                    Console.WriteLine();

                    #endregion

                    #region Close the goal

                    // Close the goal.
                    SetStateRequest closeGoal = new SetStateRequest()
                    {
                        EntityMoniker = goal.ToEntityReference(),
                        State = new OptionSetValue(1),
                        Status = new OptionSetValue(1)
                    };

                    Console.WriteLine("Goal closed.");

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

            #region Create or Retrieve the necessary system users

            // Retrieve a sales manager.
            _salesManagerId = 
                SystemUserProvider.RetrieveMarketingManager(_serviceProxy);

            #endregion

            #region Create PhoneCall record and supporting account

            Account newAccount = new Account
            {
                Name = "Margie's Travel",
                Address1_PostalCode = "99999"
            };
            _accountId = (_serviceProxy.Create(newAccount));
            newAccount.Id = _accountId;

            // Create Guids for PhoneCalls
            _phoneCallId = Guid.NewGuid();
            _phoneCall2Id = Guid.NewGuid();

            // Create ActivityPartys for the phone calls' "From" field.
            ActivityParty activityParty = new ActivityParty()
            {
                PartyId = newAccount.ToEntityReference(),
                ActivityId = new EntityReference
                {
                    Id = _phoneCallId,
                    LogicalName = PhoneCall.EntityLogicalName,
                },
                ParticipationTypeMask = new OptionSetValue(9)
            };

            ActivityParty activityPartyClosed = new ActivityParty()
            {
                PartyId = newAccount.ToEntityReference(),
                ActivityId = new EntityReference
                {
                    Id = _phoneCall2Id,
                    LogicalName = PhoneCall.EntityLogicalName,
                },
                ParticipationTypeMask = new OptionSetValue(9)
            };

            // Create an open phone call.
            PhoneCall phoneCall = new PhoneCall()
            {
                Id = _phoneCallId,
                Subject = "Sample Phone Call",
                DirectionCode = false,
                To = new ActivityParty[] { activityParty }
            };
            _serviceProxy.Create(phoneCall);

            // Create a second phone call to close
            phoneCall = new PhoneCall()
            {
                Id = _phoneCall2Id,
                Subject = "Sample Phone Call 2",
                DirectionCode = false,
                To = new ActivityParty[] { activityParty },
                ActualEnd = DateTime.Now
            };
            _serviceProxy.Create(phoneCall);

            // Close the second phone call.
            SetStateRequest closePhoneCall = new SetStateRequest()
            {
                EntityMoniker = phoneCall.ToEntityReference(),
                State = new OptionSetValue(1),
                Status = new OptionSetValue(4)
            };
            _serviceProxy.Execute(closePhoneCall);

            #endregion
        }

        /// <summary>
        /// Deletes any entity records that were created for this sample.
        /// <param name="prompt">Indicates whether to prompt the user 
        /// to delete the records created in this sample.</param>
        /// </summary>
        public void DeleteRequiredRecords(bool prompt)
        {
            // The three system users that were created by this sample will continue to 
            // exist on your system because system users cannot be deleted in Microsoft
            // Dynamics CRM.  They can only be enabled or disabled.

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
                _serviceProxy.Delete("phonecall", _phoneCallId);
                _serviceProxy.Delete("phonecall", _phoneCall2Id);
                _serviceProxy.Delete("goal", _goalId);
                _serviceProxy.Delete("goalrollupquery", _rollupQueryIds[1]);
                _serviceProxy.Delete("goalrollupquery", _rollupQueryIds[0]);
                _serviceProxy.Delete("account", _accountId);
                _serviceProxy.Delete("rollupfield", _actualId);
                _serviceProxy.Delete("rollupfield", _inprogressId);
                _serviceProxy.Delete("metric", _metricId);

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

                OverrideGoalTotalCount app = new OverrideGoalTotalCount();
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

// </snippetoverridegoaltotalcount>