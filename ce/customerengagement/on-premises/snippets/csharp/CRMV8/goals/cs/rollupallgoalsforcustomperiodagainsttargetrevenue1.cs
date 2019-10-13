// <snippetrollupallgoalsforcustomperiodagainsttargetrevenue1>


 // Connect to the Organization service. 
 // The using statement assures that the service proxy will be properly disposed.
 using (_serviceProxy = new OrganizationServiceProxy(serverConfig.OrganizationUri, serverConfig.HomeRealmUri,serverConfig.Credentials, serverConfig.DeviceCredentials))
 {
     // This statement is required to enable early-bound type support.
     _serviceProxy.EnableProxyTypes();

     CreateRequiredRecords();

     // Create the revenue metric, setting the Amount Data Type to 'Money'
     // and the Metric Type to 'Amount'.
     Metric sampleMetric = new Metric()
     {
         Name = "Sample Revenue Metric",
         AmountDataType = new OptionSetValue(0),
         IsAmount = true,
     };
     _metricId = _serviceProxy.Create(sampleMetric);

     Console.Write("Created revenue metric, ");

     // Create first RollupField which targets the estimated values.
     RollupField inProgress = new RollupField()
     {
         SourceEntity = Opportunity.EntityLogicalName,
         SourceAttribute = "estimatedvalue",
         GoalAttribute = "inprogressmoney",
         SourceState = 0,
         EntityForDateAttribute = Opportunity.EntityLogicalName,
         DateAttribute = "estimatedclosedate",
         MetricId = new EntityReference(Metric.EntityLogicalName, _metricId),
     };
     _inProgressId = _serviceProxy.Create(inProgress);

     Console.Write("created in-progress RollupField, ");

     // Create second RollupField which targets the actual values.
     RollupField actual = new RollupField()
     {
         SourceEntity = Opportunity.EntityLogicalName,
         SourceAttribute = "actualvalue",
         GoalAttribute = "actualmoney",
         SourceState = 1,
         EntityForDateAttribute = Opportunity.EntityLogicalName,
         DateAttribute = "actualclosedate",
         MetricId = new EntityReference(Metric.EntityLogicalName, _metricId)
     };
     _actualId = _serviceProxy.Create(actual);

     Console.Write("created actual revenue RollupField, ");

     // Create the goal rollup queries.
     // Note: Formatting the FetchXml onto multiple lines in the following 
     // rollup queries causes the lenth property to be greater than 1,000
     // chars and will cause an exception.

     // The first query locates opportunities in the first sales 
     // representative's area (zip code: 60661).
     GoalRollupQuery goalRollupQuery = new GoalRollupQuery()
     {
         Name = "First Example Goal Rollup Query",
         QueryEntityType = Opportunity.EntityLogicalName,
         FetchXml = @"<fetch version=""1.0"" output-format=""xml-platform"" mapping=""logical"" distinct=""false""><entity name=""opportunity""><attribute name=""totalamount""/><attribute name=""name""/><attribute name=""customerid""/><attribute name=""estimatedvalue""/><attribute name=""statuscode""/><attribute name=""opportunityid""/><order attribute=""name"" descending=""false""/><link-entity name=""account"" from=""accountid"" to=""customerid"" alias=""aa""><filter type=""and""><condition attribute=""address1_postalcode"" operator=""eq"" value=""60661""/></filter></link-entity></entity></fetch>"
     };
     _rollupQueryIds.Add(_serviceProxy.Create(goalRollupQuery));

     Console.Write("created first rollup query for zip code 60661, ");

     // The second query locates opportunities in the second sales 
     // representative's area (zip code: 99999).
     goalRollupQuery = new GoalRollupQuery()
     {
         Name = "Second Example Goal Rollup Query",
         QueryEntityType = Opportunity.EntityLogicalName,
         FetchXml = @"<fetch version=""1.0"" output-format=""xml-platform"" mapping=""logical"" distinct=""false""><entity name=""opportunity""><attribute name=""totalamount""/><attribute name=""customerid""/><attribute name=""estimatedvalue""/><attribute name=""statuscode""/><attribute name=""opportunityid""/><order attribute=""name"" descending=""false""/><link-entity name=""account"" from=""accountid"" to=""customerid"" alias=""aa""><filter type=""and""><condition attribute=""address1_postalcode"" operator=""eq"" value=""99999""/></filter></link-entity></entity></fetch>"
     };
     _rollupQueryIds.Add(_serviceProxy.Create(goalRollupQuery));

     Console.WriteLine("created second rollup query for zip code 99999.");
     Console.WriteLine();

     // Create three goals: one parent goal and two child goals.
     Goal parentGoal = new Goal()
     {
         Title = "Parent Goal Example",
         RollupOnlyFromChildGoals = true,
         ConsiderOnlyGoalOwnersRecords = true,
         TargetMoney = new Money(300.0M),
         IsFiscalPeriodGoal = false,
         MetricId = new EntityReference
         {
             Id = _metricId,
             LogicalName = Metric.EntityLogicalName
         },
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
     _parentGoalId = _serviceProxy.Create(parentGoal);

     Console.WriteLine("Created parent goal");
     Console.WriteLine("-------------------");
     Console.WriteLine("Target: {0}", parentGoal.TargetMoney.Value);
     Console.WriteLine("Goal owner: {0}", parentGoal.GoalOwnerId.Id);
     Console.WriteLine("Goal Start Date: {0}", parentGoal.GoalStartDate);
     Console.WriteLine("Goal End Date: {0}", parentGoal.GoalEndDate);
     Console.WriteLine("<End of Listing>");
     Console.WriteLine();

     Goal firstChildGoal = new Goal()
     {
         Title = "First Child Goal Example",
         ConsiderOnlyGoalOwnersRecords = true,
         TargetMoney = new Money(100.0M),
         IsFiscalPeriodGoal = false,
         MetricId = new EntityReference
         {
             Id = _metricId,
             LogicalName = Metric.EntityLogicalName
         },
         ParentGoalId = new EntityReference
         {
             Id = _parentGoalId,
             LogicalName = Goal.EntityLogicalName
         },
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
         RollUpQueryActualMoneyId = new EntityReference
         {
             Id = _rollupQueryIds[0],
             LogicalName = GoalRollupQuery.EntityLogicalName
         },
         GoalStartDate = DateTime.Today.AddDays(-1),
         GoalEndDate = DateTime.Today.AddDays(30)
     };
     _firstChildGoalId = _serviceProxy.Create(firstChildGoal);

     Console.WriteLine("First child goal");
     Console.WriteLine("----------------");
     Console.WriteLine("Target: {0}", firstChildGoal.TargetMoney.Value);
     Console.WriteLine("Goal owner: {0}", firstChildGoal.GoalOwnerId.Id);
     Console.WriteLine("Goal Start Date: {0}", firstChildGoal.GoalStartDate);
     Console.WriteLine("Goal End Date: {0}", firstChildGoal.GoalEndDate);
     Console.WriteLine();

     Goal secondChildGoal = new Goal()
     {
         Title = "Second Child Goal Example",
         ConsiderOnlyGoalOwnersRecords = true,
         TargetMoney = new Money(200.0M),
         IsFiscalPeriodGoal = false,
         MetricId = new EntityReference
         {
             Id = _metricId,
             LogicalName = Metric.EntityLogicalName
         },
         ParentGoalId = new EntityReference
         {
             Id = _parentGoalId,
             LogicalName = Goal.EntityLogicalName
         },
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
         RollUpQueryActualMoneyId = new EntityReference
         {
             Id = _rollupQueryIds[1],
             LogicalName = GoalRollupQuery.EntityLogicalName
         },
         GoalStartDate = DateTime.Today.AddDays(-1),
         GoalEndDate = DateTime.Today.AddDays(30)
     };
     _secondChildGoalId = _serviceProxy.Create(secondChildGoal);

     Console.WriteLine("Second child goal");
     Console.WriteLine("-----------------");
     Console.WriteLine("Target: {0}", secondChildGoal.TargetMoney.Value);
     Console.WriteLine("Goal owner: {0}", secondChildGoal.GoalOwnerId.Id);
     Console.WriteLine("Goal Start Date: {0}", secondChildGoal.GoalStartDate);
     Console.WriteLine("Goal End Date: {0}", secondChildGoal.GoalEndDate);
     Console.WriteLine();

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
     // - ComputedTargetAsOfTodayMoney
     QueryExpression retrieveValues = new QueryExpression()
     {
         EntityName = Goal.EntityLogicalName,
         ColumnSet = new ColumnSet(
             "title", 
             "percentage", 
             "computedtargetasoftodaypercentageachieved", 
             "computedtargetasoftodaymoney")
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
         Console.WriteLine("ComputedTargetAsOfTodayMoney: {0}", 
             temp.ComputedTargetAsOfTodayMoney.Value);
         Console.WriteLine("<End of Listing>");
     }

     DeleteRequiredRecords(promptforDelete);
 }

// </snippetrollupallgoalsforcustomperiodagainsttargetrevenue1>