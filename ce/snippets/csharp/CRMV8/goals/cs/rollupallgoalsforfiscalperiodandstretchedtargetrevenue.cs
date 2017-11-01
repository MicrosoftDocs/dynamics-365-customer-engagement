// <snippetrollupallgoalsforfiscalperiodandstretchedtargetrevenue>


using System;
using System.ServiceModel;
using System.Collections.Generic;

// These namespaces are found in the Microsoft.Xrm.Sdk.dll assembly
// located in the SDK\bin folder of the SDK download.
using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Query;
using Microsoft.Xrm.Sdk.Client;

// This namespace is found in Microsoft.Crm.Sdk.Proxy.dll assembly
// found in the SDK\bin folder.
using Microsoft.Crm.Sdk.Messages;

namespace Microsoft.Crm.Sdk.Samples
{
    /// <summary>
    /// Demonstrates how to work with fiscal period goals that utilize stretched
    /// targets.
    /// </summary>
    /// <remarks>
    /// At run-time, you will be given the option to delete all the
    /// database records created by this program.</remarks>
    public class RollupAllGoalsForFiscalPeriodAndStretchedTargetRevenue
    {
        #region Class Level Members

        private Guid _salesManagerId;
        private Guid _accountId;
        private Guid _phoneCallId;
        private Guid _phoneCall2Id;
        private Guid _metricId;
        private Guid _actualId;
        private Guid _parentGoalId;
        private Guid _firstChildGoalId;
        private Guid _secondChildGoalId;
        private List<Guid> _rollupQueryIds = new List<Guid>();
        private List<Guid> _salesRepresentativeIds = new List<Guid>();

        private OrganizationServiceProxy _serviceProxy;

        #endregion Class Level Members

        #region How To Sample Code
        /// <summary>
        /// This method first connects to the Organization service. Afterwards, the
        /// sample creates a goal and child goals for a particular fiscal period. 
        /// Stretched targets are tracked as well.
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

                    #region Create goal metric

                    // Create the metric, setting the Metric Type to 'Count' and enabling
                    // stretch tracking.
                    Metric metric = new Metric()
                    {
                        Name = "Sample Count Metric",
                        IsAmount = false,
                        IsStretchTracked = true
                    };
                    _metricId = _serviceProxy.Create(metric);
                    metric.Id = _metricId;

                    Console.Write("Created count metric, ");

                    #endregion

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
                        MetricId = metric.ToEntityReference()
                    };
                    _actualId = _serviceProxy.Create(actual);

                    Console.Write("created completed phone call RollupField, ");

                    #endregion

                    #region Create the goal rollup queries

                    // Note: Formatting the FetchXml onto multiple lines in the following 
                    // rollup queries causes the length property to be greater than 1,000
                    // chars and will cause an exception.

                    // The following query locates closed incoming phone calls.
                    GoalRollupQuery goalRollupQuery = new GoalRollupQuery()
                    {
                        Name = "Example Goal Rollup Query",
                        QueryEntityType = PhoneCall.EntityLogicalName,
                        FetchXml = @"<fetch version='1.0' output-format='xml-platform' mapping='logical' distinct='false'><entity name='phonecall'><attribute name='subject'/><attribute name='statecode'/><attribute name='prioritycode'/><attribute name='scheduledend'/><attribute name='createdby'/><attribute name='regardingobjectid'/><attribute name='activityid'/><order attribute='subject' descending='false'/><filter type='and'><condition attribute='directioncode' operator='eq' value='0'/><condition attribute='statecode' operator='eq' value='1' /></filter></entity></fetch>"
                    };
                    _rollupQueryIds.Add(_serviceProxy.Create(goalRollupQuery));
                    goalRollupQuery.Id = _rollupQueryIds[0];

                    // The following query locates closed outgoing phone calls.
                    GoalRollupQuery goalRollupQuery2 = new GoalRollupQuery()
                    {
                        Name = "Example Goal Rollup Query",
                        QueryEntityType = PhoneCall.EntityLogicalName,
                        FetchXml = @"<fetch version='1.0' output-format='xml-platform' mapping='logical' distinct='false'><entity name='phonecall'><attribute name='subject'/><attribute name='statecode'/><attribute name='prioritycode'/><attribute name='scheduledend'/><attribute name='createdby'/><attribute name='regardingobjectid'/><attribute name='activityid'/><order attribute='subject' descending='false'/><filter type='and'><condition attribute='directioncode' operator='eq' value='1'/><condition attribute='statecode' operator='eq' value='1' /></filter></entity></fetch>"
                    };
                    _rollupQueryIds.Add(_serviceProxy.Create(goalRollupQuery2));
                    goalRollupQuery2.Id = _rollupQueryIds[1];

                    Console.Write("created rollup queries for phone calls.\n");
                    Console.WriteLine();

                    #endregion

                    #region Create goals

                    // Determine current fiscal period and year.
                    // Note: This sample assumes quarterly fiscal periods.
                    DateTime date = DateTime.Now;
                    int quarterNumber = (date.Month - 1) / 3 + 1;
                    int yearNumber = date.Year;

                    // Create three goals: one parent goal and two child goals.
                    Goal parentGoal = new Goal()
                    {
                        Title = "Parent Goal Example",
                        RollupOnlyFromChildGoals = true,
                        ConsiderOnlyGoalOwnersRecords = true,
                        TargetInteger = 8,
                        StretchTargetInteger = 10,
                        IsFiscalPeriodGoal = true,
                        FiscalPeriod = new OptionSetValue(quarterNumber),
                        FiscalYear = new OptionSetValue(yearNumber),
                        MetricId = metric.ToEntityReference(),
                        GoalOwnerId = new EntityReference
                        {
                            Id = _salesManagerId,
                            LogicalName = SystemUser.EntityLogicalName
                        },
                        OwnerId = new EntityReference
                        {
                            Id = _salesManagerId,
                            LogicalName = SystemUser.EntityLogicalName
                        }
                    };
                    _parentGoalId = _serviceProxy.Create(parentGoal);
                    parentGoal.Id = _parentGoalId;

                    Console.WriteLine("Created parent goal");
                    Console.WriteLine("-------------------");
                    Console.WriteLine("Target: {0}", parentGoal.TargetInteger.Value);
                    Console.WriteLine("Stretch Target: {0}", 
                        parentGoal.StretchTargetInteger.Value);
                    Console.WriteLine("Goal owner: {0}", parentGoal.GoalOwnerId.Id);
                    Console.WriteLine("Goal Fiscal Period: {0}", 
                        parentGoal.FiscalPeriod.Value);
                    Console.WriteLine("Goal Fiscal Year: {0}", 
                        parentGoal.FiscalYear.Value);
                    Console.WriteLine("<End of Listing>");
                    Console.WriteLine();

                    Goal firstChildGoal = new Goal()
                    {
                        Title = "First Child Goal Example",
                        ConsiderOnlyGoalOwnersRecords = true,
                        TargetInteger = 5,
                        StretchTargetInteger = 6,
                        IsFiscalPeriodGoal = true,
                        FiscalPeriod = new OptionSetValue(quarterNumber),
                        FiscalYear = new OptionSetValue(yearNumber),
                        MetricId = metric.ToEntityReference(),
                        ParentGoalId = parentGoal.ToEntityReference(),
                        GoalOwnerId = new EntityReference
                        {
                            Id = _salesRepresentativeIds[0],
                            LogicalName = SystemUser.EntityLogicalName
                        },
                        OwnerId = new EntityReference
                        {
                            Id = _salesManagerId,
                            LogicalName = SystemUser.EntityLogicalName
                        },
                        RollupQueryActualIntegerId = goalRollupQuery.ToEntityReference()
                    };
                    _firstChildGoalId = _serviceProxy.Create(firstChildGoal);

                    Console.WriteLine("First child goal");
                    Console.WriteLine("----------------");
                    Console.WriteLine("Target: {0}", firstChildGoal.TargetInteger.Value);
                    Console.WriteLine("Stretch Target: {0}", 
                        firstChildGoal.StretchTargetInteger.Value);
                    Console.WriteLine("Goal owner: {0}", firstChildGoal.GoalOwnerId.Id);
                    Console.WriteLine("Goal Fiscal Period: {0}", 
                        firstChildGoal.FiscalPeriod.Value);
                    Console.WriteLine("Goal Fiscal Year: {0}", 
                        firstChildGoal.FiscalYear.Value);
                    Console.WriteLine();

                    Goal secondChildGoal = new Goal()
                    {
                        Title = "Second Child Goal Example",
                        ConsiderOnlyGoalOwnersRecords = true,
                        TargetInteger = 3,
                        StretchTargetInteger = 4,
                        IsFiscalPeriodGoal = true,
                        FiscalPeriod = new OptionSetValue(quarterNumber),
                        FiscalYear = new OptionSetValue(yearNumber),                     
                        MetricId = metric.ToEntityReference(),
                        ParentGoalId = parentGoal.ToEntityReference(),
                        GoalOwnerId = new EntityReference
                        {
                            Id = _salesRepresentativeIds[1],
                            LogicalName = SystemUser.EntityLogicalName
                        },
                        OwnerId = new EntityReference
                        {
                            Id = _salesManagerId,
                            LogicalName = SystemUser.EntityLogicalName
                        },
                        RollupQueryActualIntegerId = goalRollupQuery2.ToEntityReference()
                    };
                    _secondChildGoalId = _serviceProxy.Create(secondChildGoal);

                    Console.WriteLine("Second child goal");
                    Console.WriteLine("-----------------");
                    Console.WriteLine("Target: {0}", 
                        secondChildGoal.TargetInteger.Value);
                    Console.WriteLine("Stretch Target: {0}", 
                        secondChildGoal.StretchTargetInteger.Value);
                    Console.WriteLine("Goal owner: {0}", secondChildGoal.GoalOwnerId.Id);
                    Console.WriteLine("Goal Fiscal Period: {0}", 
                        secondChildGoal.FiscalPeriod.Value);
                    Console.WriteLine("Goal Fiscal Year: {0}", 
                        secondChildGoal.FiscalYear.Value);
                    Console.WriteLine();

                    #endregion

                    #region Calculate rollup and display result

                    // Calculate roll-up of goals.
                    RecalculateRequest recalculateRequest = new RecalculateRequest()
                    {
                        Target = new EntityReference(Goal.EntityLogicalName, _parentGoalId)
                    };
                    _serviceProxy.Execute(recalculateRequest);

                    Console.WriteLine("Calculated roll-up of goals.");

                    // Retrieve and report 3 different computed values for the goals
                    // - Percentage
                    // - ComputedTargetAsOfTodayPercentageAchieved
                    // - ComputedTargetAsOfTodayInteger
                    QueryExpression retrieveValues = new QueryExpression()
                    {
                        EntityName = Goal.EntityLogicalName,
                        ColumnSet = new ColumnSet(
                            "title", 
                            "percentage", 
                            "computedtargetasoftodaypercentageachieved", 
                            "computedtargetasoftodayinteger")
                    };
                    EntityCollection ec = _serviceProxy.RetrieveMultiple(retrieveValues);

                    // Compute and display the results
                    for (int i = 0; i < ec.Entities.Count; i++)
                    {
                        Goal temp = (Goal)ec.Entities[i];
                        Console.WriteLine("Roll-up details for goal: {0}", temp.Title);
                        Console.WriteLine("---------------");
                        Console.WriteLine("Percentage: {0}", temp.Percentage);
                        Console.WriteLine("ComputedTargetAsOfTodayPercentageAchieved: {0}", 
                            temp.ComputedTargetAsOfTodayPercentageAchieved);
                        Console.WriteLine("ComputedTargetAsOfTodayInteger: {0}", 
                            temp.ComputedTargetAsOfTodayInteger.Value);
                        Console.WriteLine("<End of Listing>");
                    }

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

            // Retrieve the ldapPath
            String ldapPath = String.Empty;
            // Retrieve the sales team - 1 sales manager and 2 sales representatives.
            _salesManagerId =
                SystemUserProvider.RetrieveSalesManager(_serviceProxy, ref ldapPath);
            _salesRepresentativeIds = 
                SystemUserProvider.RetrieveSalespersons(_serviceProxy, ref ldapPath);

            #endregion

            #region Create PhoneCall record and supporting account

            Account account = new Account
            {
                Name = "Margie's Travel",
                Address1_PostalCode = "99999"
            };
            _accountId = (_serviceProxy.Create(account));
            account.Id = _accountId;

            // Create Guids for PhoneCalls
            _phoneCallId = Guid.NewGuid();
            _phoneCall2Id = Guid.NewGuid();

            // Create ActivityPartys for the phone calls' "From" field.
            ActivityParty activityParty = new ActivityParty()
            {
                PartyId = account.ToEntityReference(),
                ActivityId = new EntityReference
                {
                    Id = _phoneCallId,
                    LogicalName = PhoneCall.EntityLogicalName,
                },
                ParticipationTypeMask = new OptionSetValue(9),
            };

            ActivityParty activityPartyClosed = new ActivityParty()
            {
                PartyId = account.ToEntityReference(),
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
                To = new ActivityParty[] { activityParty },
                OwnerId = new EntityReference("systemuser", _salesRepresentativeIds[0]),
                ActualEnd = DateTime.Now
            };
            _serviceProxy.Create(phoneCall);

            // Close the first phone call.
            SetStateRequest closePhoneCall = new SetStateRequest()
            {
                EntityMoniker = phoneCall.ToEntityReference(),
                State = new OptionSetValue(1),
                Status = new OptionSetValue(4)
            };
            _serviceProxy.Execute(closePhoneCall);

            // Create a second phone call. 
            phoneCall = new PhoneCall()
            {
                Id = _phoneCall2Id,
                Subject = "Sample Phone Call 2",
                DirectionCode = true,
                To = new ActivityParty[] { activityParty },
                OwnerId = new EntityReference("systemuser", _salesRepresentativeIds[1]),
                ActualEnd = DateTime.Now
            };
            _serviceProxy.Create(phoneCall);

            // Close the second phone call.
            closePhoneCall = new SetStateRequest()
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
                _serviceProxy.Delete("goal", _firstChildGoalId);
                _serviceProxy.Delete("goal", _secondChildGoalId);
                _serviceProxy.Delete("goal", _parentGoalId);
                _serviceProxy.Delete("goalrollupquery", _rollupQueryIds[0]);
                _serviceProxy.Delete("goalrollupquery", _rollupQueryIds[1]);
                _serviceProxy.Delete("account", _accountId);
                _serviceProxy.Delete("phonecall", _phoneCallId);
                _serviceProxy.Delete("phonecall", _phoneCall2Id);
                _serviceProxy.Delete("rollupfield", _actualId);
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

                RollupAllGoalsForFiscalPeriodAndStretchedTargetRevenue app =
                    new RollupAllGoalsForFiscalPeriodAndStretchedTargetRevenue();
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

// </snippetrollupallgoalsforfiscalperiodandstretchedtargetrevenue>