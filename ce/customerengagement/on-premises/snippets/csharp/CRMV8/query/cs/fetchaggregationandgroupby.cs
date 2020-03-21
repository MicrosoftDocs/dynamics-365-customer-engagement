// <snippetfetchaggregationandgroupby>


using System;
using System.ServiceModel;
using System.ServiceModel.Description;
using System.Linq;
using System.Threading;
using System.Xml.Linq;

// These namespaces are found in the Microsoft.Xrm.Sdk.dll assembly
// found in the SDK\bin folder.
using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Client;
using Microsoft.Xrm.Sdk.Query;
using Microsoft.Xrm.Sdk.Discovery;

// This namespace is found in Microsoft.Crm.Sdk.Proxy.dll assembly
// found in the SDK\bin folder.
using Microsoft.Crm.Sdk.Messages;


namespace Microsoft.Crm.Sdk.Samples
{
    /// <summary>
    /// Demonstrates how to fetch aggregate record data grouped by attributes.
    /// If you want to run this sample repeatedly, you have the option to 
    /// Optionally delete all the records created at the end of execution.
    /// </summary>
	public class FetchAggregationAndGroupBy
	{
        #region Class Level Members
        
        /// <summary>
        /// Stores the organization service proxy.
        /// </summary>
        private OrganizationServiceProxy _serviceProxy;
        private IOrganizationService _service;

        // Define the IDs needed for this sample.    
        public Guid _accountId;
        public Guid[] _setupOpportunitiyIds;

        #endregion Class Level Members

        #region How To Sample Code
        /// <summary>
        /// Create and configure the organization service proxy.
        /// Create an account record.
        /// Create 3 opportunity records associate to the account record.
        /// Mark all 3 opportunity records as won.
        /// Fetch aggregate record data grouped by attributes.
        /// Optionally delete all the records created at the end of execution.
        /// </summary>
        /// <param name="serverConfig">Contains server connection information.</param>
        /// <param name="promptForDelete">When True, the user will be prompted to delete all
        /// created entities.</param>
        public void Run(ServerConnection.Configuration serverConfig, bool promptForDelete)
        {
            try
            {
                 
                // Connect to the Organization service. 
                // The using statement assures that the service proxy will be properly disposed.
                using (_serviceProxy = new OrganizationServiceProxy(serverConfig.OrganizationUri, serverConfig.HomeRealmUri,serverConfig.Credentials, serverConfig.DeviceCredentials))
                {
                    // This statement is required to enable early-bound type support.
                    _serviceProxy.EnableProxyTypes();
                    _service = (IOrganizationService)_serviceProxy;

                    // Call the method to create any data that this sample requires.
                    CreateRequiredRecords();

                    // *****************************************************************************************************************
                    //                FetchXML      estimatedvalue_avg    Aggregate 1
                    // *****************************************************************************************************************
                    // Fetch the average of estimatedvalue for all opportunities.  This is the equivalent of 
                    // SELECT AVG(estimatedvalue) AS estimatedvalue_avg ... in SQL.
                    System.Console.WriteLine("===============================");
                    string estimatedvalue_avg = @" 
                    <fetch distinct='false' mapping='logical' aggregate='true'> 
                        <entity name='opportunity'> 
                           <attribute name='estimatedvalue' alias='estimatedvalue_avg' aggregate='avg' /> 
                        </entity> 
                    </fetch>";

                    EntityCollection estimatedvalue_avg_result = _serviceProxy.RetrieveMultiple(new FetchExpression(estimatedvalue_avg));

                    foreach (var c in estimatedvalue_avg_result.Entities)
                    {
                        decimal aggregate1 = ((Money)((AliasedValue)c["estimatedvalue_avg"]).Value).Value;
                        System.Console.WriteLine("Average estimated value: " + aggregate1);

                    }
                    System.Console.WriteLine("===============================");
                    // *****************************************************************************************************************
                    //                FetchXML      opportunity_count   Aggregate 2
                    // *****************************************************************************************************************
                    // Fetch the count of all opportunities.  This is the equivalent of
                    // SELECT COUNT(*) AS opportunity_count ... in SQL.
                    string opportunity_count = @" 
                    <fetch distinct='false' mapping='logical' aggregate='true'> 
                        <entity name='opportunity'> 
                           <attribute name='name' alias='opportunity_count' aggregate='count'/> 
                        </entity> 
                    </fetch>";

                    EntityCollection opportunity_count_result = _serviceProxy.RetrieveMultiple(new FetchExpression(opportunity_count));

                    foreach (var c in opportunity_count_result.Entities)
                    {
                        Int32 aggregate2 = (Int32)((AliasedValue)c["opportunity_count"]).Value;
                        System.Console.WriteLine("Count of all opportunities: " + aggregate2); 

                    }
                    System.Console.WriteLine("===============================");
                    // *****************************************************************************************************************
                    //                FetchXML      opportunity_colcount   Aggregate 3
                    // *****************************************************************************************************************
                    // Fetch the count of all opportunities.  This is the equivalent of 
                    // SELECT COUNT(name) AS opportunity_count ... in SQL.
                    string opportunity_colcount = @" 
                    <fetch distinct='false' mapping='logical' aggregate='true'> 
                        <entity name='opportunity'> 
                           <attribute name='name' alias='opportunity_colcount' aggregate='countcolumn'/> 
                        </entity> 
                    </fetch>";

                    EntityCollection opportunity_colcount_result = _serviceProxy.RetrieveMultiple(new FetchExpression(opportunity_colcount));

                    foreach (var c in opportunity_colcount_result.Entities)
                    {
                        Int32 aggregate3 = (Int32)((AliasedValue)c["opportunity_colcount"]).Value;
                        System.Console.WriteLine("Column count of all opportunities: " + aggregate3);

                    }
                    System.Console.WriteLine("===============================");
                    // *****************************************************************************************************************
                    //                FetchXML      opportunity_distcount   Aggregate 4
                    // *****************************************************************************************************************
                    // Fetch the count of distinct names for opportunities.  This is the equivalent of 
                    // SELECT COUNT(DISTINCT name) AS opportunity_count ... in SQL.
                    string opportunity_distcount = @" 
                    <fetch distinct='false' mapping='logical' aggregate='true'> 
                        <entity name='opportunity'> 
                           <attribute name='name' alias='opportunity_distcount' aggregate='countcolumn' distinct='true'/> 
                        </entity> 
                    </fetch>";

                    EntityCollection opportunity_distcount_result = _serviceProxy.RetrieveMultiple(new FetchExpression(opportunity_distcount));

                    foreach (var c in opportunity_distcount_result.Entities)
                    {
                        Int32 aggregate4 = (Int32)((AliasedValue)c["opportunity_distcount"]).Value;
                        System.Console.WriteLine("Distinct name count of all opportunities: " + aggregate4);

                    }
                    System.Console.WriteLine("===============================");
                    // *****************************************************************************************************************
                    //                FetchXML      estimatedvalue_max   Aggregate 5
                    // *****************************************************************************************************************
                    // Fetch the maximum estimatedvalue of all opportunities.  This is the equivalent of 
                    // SELECT MAX(estimatedvalue) AS estimatedvalue_max ... in SQL.
                    string estimatedvalue_max = @" 
                    <fetch distinct='false' mapping='logical' aggregate='true'> 
                        <entity name='opportunity'> 
                           <attribute name='estimatedvalue' alias='estimatedvalue_max' aggregate='max' /> 
                        </entity> 
                    </fetch>";

                    EntityCollection estimatedvalue_max_result = _serviceProxy.RetrieveMultiple(new FetchExpression(estimatedvalue_max));

                    foreach (var c in estimatedvalue_max_result.Entities)
                    {
                        decimal aggregate5 = ((Money)((AliasedValue)c["estimatedvalue_max"]).Value).Value;
                        System.Console.WriteLine("Max estimated value of all opportunities: " + aggregate5);

                    }
                    System.Console.WriteLine("===============================");
                    // *****************************************************************************************************************
                    //                FetchXML      estimatedvalue_min   Aggregate 6
                    // *****************************************************************************************************************
                    // Fetch the minimum estimatedvalue of all opportunities.  This is the equivalent of 
                    // SELECT MIN(estimatedvalue) AS estimatedvalue_min ... in SQL.
                    string estimatedvalue_min = @" 
                    <fetch distinct='false' mapping='logical' aggregate='true'> 
                        <entity name='opportunity'> 
                           <attribute name='estimatedvalue' alias='estimatedvalue_min' aggregate='min' /> 
                        </entity> 
                    </fetch>";

                    EntityCollection estimatedvalue_min_result = _serviceProxy.RetrieveMultiple(new FetchExpression(estimatedvalue_min));

                    foreach (var c in estimatedvalue_min_result.Entities)
                    {
                        decimal aggregate6 = ((Money)((AliasedValue)c["estimatedvalue_min"]).Value).Value;
                        System.Console.WriteLine("Minimum estimated value of all opportunities: " + aggregate6);

                    }
                    System.Console.WriteLine("===============================");
                    // *****************************************************************************************************************
                    //                FetchXML      estimatedvalue_sum   Aggregate 7
                    // *****************************************************************************************************************
                    // Fetch the sum of estimatedvalue for all opportunities.  This is the equivalent of 
                    // SELECT SUM(estimatedvalue) AS estimatedvalue_sum ... in SQL.
                    string estimatedvalue_sum = @" 
                    <fetch distinct='false' mapping='logical' aggregate='true'> 
                        <entity name='opportunity'> 
                           <attribute name='estimatedvalue' alias='estimatedvalue_sum' aggregate='sum' /> 
                        </entity> 
                    </fetch>";

                    EntityCollection estimatedvalue_sum_result = _serviceProxy.RetrieveMultiple(new FetchExpression(estimatedvalue_sum));

                    foreach (var c in estimatedvalue_sum_result.Entities)
                    {
                        decimal aggregate7 = ((Money)((AliasedValue)c["estimatedvalue_sum"]).Value).Value;
                        System.Console.WriteLine("Sum of estimated value of all opportunities: " + aggregate7);

                    }
                    System.Console.WriteLine("===============================");
                    // *****************************************************************************************************************
                    //                FetchXML      estimatedvalue_avg, estimatedvalue_sum   Aggregate 8
                    // *****************************************************************************************************************
                    // Fetch multiple aggregate values within a single query.
                    string estimatedvalue_avg2 = @" 
                    <fetch distinct='false' mapping='logical' aggregate='true'> 
                        <entity name='opportunity'> 
                           <attribute name='opportunityid' alias='opportunity_count' aggregate='count'/> 
                           <attribute name='estimatedvalue' alias='estimatedvalue_sum' aggregate='sum'/> 
                           <attribute name='estimatedvalue' alias='estimatedvalue_avg' aggregate='avg'/> 
                        </entity> 
                    </fetch>";

                    EntityCollection estimatedvalue_avg2_result = _serviceProxy.RetrieveMultiple(new FetchExpression(estimatedvalue_avg2));

                    foreach (var c in estimatedvalue_avg2_result.Entities)
                    {
                        Int32 aggregate8a = (Int32)((AliasedValue)c["opportunity_count"]).Value;
                        System.Console.WriteLine("Count of all opportunities: " + aggregate8a);
                        decimal aggregate8b = ((Money)((AliasedValue)c["estimatedvalue_sum"]).Value).Value;
                        System.Console.WriteLine("Sum of estimated value of all opportunities: " + aggregate8b);
                        decimal aggregate8c = ((Money)((AliasedValue)c["estimatedvalue_avg"]).Value).Value;
                        System.Console.WriteLine("Average of estimated value of all opportunities: " + aggregate8c);

                    }
                    System.Console.WriteLine("===============================");
                    // *****************************************************************************************************************
                    //                FetchXML      groupby1   Aggregate 9
                    // *****************************************************************************************************************
                    // Fetch a list of users with a count of all the opportunities they own using groupby.
                    string groupby1 = @" 
                    <fetch distinct='false' mapping='logical' aggregate='true'> 
                        <entity name='opportunity'> 
                           <attribute name='name' alias='opportunity_count' aggregate='countcolumn' /> 
                           <attribute name='ownerid' alias='ownerid' groupby='true' /> 
                        </entity> 
                    </fetch>";

                    EntityCollection groupby1_result = _serviceProxy.RetrieveMultiple(new FetchExpression(groupby1));

                    foreach (var c in groupby1_result.Entities)
                    {
                        Int32 aggregate9a = (Int32)((AliasedValue)c["opportunity_count"]).Value;
                        System.Console.WriteLine("Count of all opportunities: " + aggregate9a + "\n");
                        string aggregate9b = ((EntityReference)((AliasedValue)c["ownerid"]).Value).Name;
                        System.Console.WriteLine("Owner: " + aggregate9b);
                        string aggregate9c = (string)((AliasedValue)c["ownerid_owneridyominame"]).Value;
                        System.Console.WriteLine("Owner: " + aggregate9c);
                        string aggregate9d = (string)((AliasedValue)c["ownerid_owneridyominame"]).Value;
                        System.Console.WriteLine("Owner: " + aggregate9d);
                    }
                    System.Console.WriteLine("===============================");
                    // *****************************************************************************************************************
                    //                FetchXML      groupby2   Aggregate 10
                    // *****************************************************************************************************************
                    // Fetch the number of opportunities each manager's direct reports 
                    // own using a groupby within a link-entity.
                    string groupby2 = @" 
                    <fetch distinct='false' mapping='logical' aggregate='true'> 
                        <entity name='opportunity'> 
                           <attribute name='name' alias='opportunity_count' aggregate='countcolumn' /> 
                           <link-entity name='systemuser' from='systemuserid' to='ownerid'>
                               <attribute name='parentsystemuserid' alias='managerid' groupby='true' />
                           </link-entity> 
                        </entity> 
                    </fetch>";

                    EntityCollection groupby2_result = _serviceProxy.RetrieveMultiple(new FetchExpression(groupby2));

                    foreach (var c in groupby2_result.Entities)
                    {

                          int? aggregate10a = (int?)((AliasedValue)c["opportunity_count"]).Value;
                          System.Console.WriteLine("Count of all opportunities: " + aggregate10a + "\n");
                    }
                    System.Console.WriteLine("===============================");
                    // *****************************************************************************************************************
                    //                FetchXML      byyear   Aggregate 11           
                    // *****************************************************************************************************************
                    // Fetch aggregate information about the opportunities that have 
                    // been won by year.
                    string byyear = @" 
                    <fetch distinct='false' mapping='logical' aggregate='true'> 
                        <entity name='opportunity'> 
                           <attribute name='opportunityid' alias='opportunity_count' aggregate='count'/> 
                           <attribute name='estimatedvalue' alias='estimatedvalue_sum' aggregate='sum'/> 
                           <attribute name='estimatedvalue' alias='estimatedvalue_avg' aggregate='avg'/> 
                           <attribute name='actualclosedate' groupby='true' dategrouping='year' alias='year' />
                           <filter type='and'>
                               <condition attribute='statecode' operator='eq' value='Won' />
                           </filter>
                        </entity> 
                    </fetch>";

                    EntityCollection byyear_result = _serviceProxy.RetrieveMultiple(new FetchExpression(byyear));

                    foreach (var c in byyear_result.Entities)
                    {
                        Int32 aggregate11 = (Int32)((AliasedValue)c["year"]).Value;
                        System.Console.WriteLine("Year: " + aggregate11);                      
                        Int32 aggregate11a = (Int32)((AliasedValue)c["opportunity_count"]).Value;
                        System.Console.WriteLine("Count of all opportunities: " + aggregate11a);
                        decimal aggregate11b = ((Money)((AliasedValue)c["estimatedvalue_sum"]).Value).Value;
                        System.Console.WriteLine("Sum of estimated value of all opportunities: " + aggregate11b);
                        decimal aggregate11c = ((Money)((AliasedValue)c["estimatedvalue_avg"]).Value).Value;
                        System.Console.WriteLine("Average of estimated value of all opportunities: " + aggregate11c);
                        System.Console.WriteLine("----------------------------------------------");
                    }
                    System.Console.WriteLine("===============================");
                    // *****************************************************************************************************************
                    //                FetchXML      byquarter   Aggregate 12           
                    // *****************************************************************************************************************
                   // Fetch aggregate information about the opportunities that have 
                    // been won by quarter.(returns 1-4)
                    string byquarter = @" 
                    <fetch distinct='false' mapping='logical' aggregate='true'> 
                        <entity name='opportunity'> 
                           <attribute name='opportunityid' alias='opportunity_count' aggregate='count'/> 
                           <attribute name='estimatedvalue' alias='estimatedvalue_sum' aggregate='sum'/> 
                           <attribute name='estimatedvalue' alias='estimatedvalue_avg' aggregate='avg'/> 
                           <attribute name='actualclosedate' groupby='true' dategrouping='quarter' alias='quarter' />
                           <filter type='and'>
                               <condition attribute='statecode' operator='eq' value='Won' />
                           </filter>
                        </entity> 
                    </fetch>";

                    EntityCollection byquarter_result = _serviceProxy.RetrieveMultiple(new FetchExpression(byquarter));

                    foreach (var c in byquarter_result.Entities)
                    {
                        Int32 aggregate12 = (Int32)((AliasedValue)c["quarter"]).Value;
                        System.Console.WriteLine("Quarter: " + aggregate12);
                        Int32 aggregate12a = (Int32)((AliasedValue)c["opportunity_count"]).Value;
                        System.Console.WriteLine("Count of all opportunities: " + aggregate12a);
                        decimal aggregate12b = ((Money)((AliasedValue)c["estimatedvalue_sum"]).Value).Value;
                        System.Console.WriteLine("Sum of estimated value of all opportunities: " + aggregate12b);
                        decimal aggregate12c = ((Money)((AliasedValue)c["estimatedvalue_avg"]).Value).Value;
                        System.Console.WriteLine("Average of estimated value of all opportunities: " + aggregate12c);
                        System.Console.WriteLine("----------------------------------------------");
                    }
                    System.Console.WriteLine("===============================");
                    // *****************************************************************************************************************
                    //                FetchXML      bymonth   Aggregate 13           
                    // *****************************************************************************************************************
                    // Fetch aggregate information about the opportunities that have 
                    // been won by month. (returns 1-12)
                    string bymonth = @" 
                    <fetch distinct='false' mapping='logical' aggregate='true'> 
                        <entity name='opportunity'> 
                           <attribute name='opportunityid' alias='opportunity_count' aggregate='count'/> 
                           <attribute name='estimatedvalue' alias='estimatedvalue_sum' aggregate='sum'/> 
                           <attribute name='estimatedvalue' alias='estimatedvalue_avg' aggregate='avg'/> 
                           <attribute name='actualclosedate' groupby='true' dategrouping='month' alias='month' />
                           <filter type='and'>
                               <condition attribute='statecode' operator='eq' value='Won' />
                           </filter>
                        </entity> 
                    </fetch>";

                    EntityCollection bymonth_result = _serviceProxy.RetrieveMultiple(new FetchExpression(bymonth));

                    foreach (var c in bymonth_result.Entities)
                    {
                        Int32 aggregate13 = (Int32)((AliasedValue)c["month"]).Value;
                        System.Console.WriteLine("Month: " + aggregate13);
                        Int32 aggregate13a = (Int32)((AliasedValue)c["opportunity_count"]).Value;
                        System.Console.WriteLine("Count of all opportunities: " + aggregate13a);
                        decimal aggregate13b = ((Money)((AliasedValue)c["estimatedvalue_sum"]).Value).Value;
                        System.Console.WriteLine("Sum of estimated value of all opportunities: " + aggregate13b);
                        decimal aggregate13c = ((Money)((AliasedValue)c["estimatedvalue_avg"]).Value).Value;
                        System.Console.WriteLine("Average of estimated value of all opportunities: " + aggregate13c);
                        System.Console.WriteLine("----------------------------------------------");
                    }
                    System.Console.WriteLine("===============================");
                    // *****************************************************************************************************************
                    //                FetchXML      byweek   Aggregate 14           
                    // *****************************************************************************************************************
                    // Fetch aggregate information about the opportunities that have 
                    // been won by week. (Returns 1-52)
                    string byweek = @" 
                    <fetch distinct='false' mapping='logical' aggregate='true'> 
                        <entity name='opportunity'> 
                           <attribute name='opportunityid' alias='opportunity_count' aggregate='count'/> 
                           <attribute name='estimatedvalue' alias='estimatedvalue_sum' aggregate='sum'/> 
                           <attribute name='estimatedvalue' alias='estimatedvalue_avg' aggregate='avg'/> 
                           <attribute name='actualclosedate' groupby='true' dategrouping='week' alias='week' />
                           <filter type='and'>
                               <condition attribute='statecode' operator='eq' value='Won' />
                           </filter>
                        </entity> 
                    </fetch>";

                    EntityCollection byweek_result = _serviceProxy.RetrieveMultiple(new FetchExpression(byweek));

                    foreach (var c in byweek_result.Entities)
                    {
                        Int32 aggregate14 = (Int32)((AliasedValue)c["week"]).Value;
                        System.Console.WriteLine("Week: " + aggregate14);
                        Int32 aggregate14a = (Int32)((AliasedValue)c["opportunity_count"]).Value;
                        System.Console.WriteLine("Count of all opportunities: " + aggregate14a);
                        decimal aggregate14b = ((Money)((AliasedValue)c["estimatedvalue_sum"]).Value).Value;
                        System.Console.WriteLine("Sum of estimated value of all opportunities: " + aggregate14b);
                        decimal aggregate14c = ((Money)((AliasedValue)c["estimatedvalue_avg"]).Value).Value;
                        System.Console.WriteLine("Average of estimated value of all opportunities: " + aggregate14c);
                        System.Console.WriteLine("----------------------------------------------");
                    }
                    System.Console.WriteLine("===============================");
                    // *****************************************************************************************************************
                    //                FetchXML      byday   Aggregate 15           
                    // *****************************************************************************************************************
                    // Fetch aggregate information about the opportunities that have 
                    // been won by day. (Returns 1-31)
                    string byday = @" 
                    <fetch distinct='false' mapping='logical' aggregate='true'> 
                        <entity name='opportunity'> 
                           <attribute name='opportunityid' alias='opportunity_count' aggregate='count'/> 
                           <attribute name='estimatedvalue' alias='estimatedvalue_sum' aggregate='sum'/> 
                           <attribute name='estimatedvalue' alias='estimatedvalue_avg' aggregate='avg'/> 
                           <attribute name='actualclosedate' groupby='true' dategrouping='day' alias='day' />
                           <filter type='and'>
                               <condition attribute='statecode' operator='eq' value='Won' />
                           </filter>
                        </entity> 
                    </fetch>";

                    EntityCollection byday_result = _serviceProxy.RetrieveMultiple(new FetchExpression(byday));

                    foreach (var c in byday_result.Entities)
                    {
                        Int32 aggregate15 = (Int32)((AliasedValue)c["day"]).Value;
                        System.Console.WriteLine("Day: " + aggregate15);
                        Int32 aggregate15a = (Int32)((AliasedValue)c["opportunity_count"]).Value;
                        System.Console.WriteLine("Count of all opportunities: " + aggregate15a);
                        decimal aggregate15b = ((Money)((AliasedValue)c["estimatedvalue_sum"]).Value).Value;
                        System.Console.WriteLine("Sum of estimated value of all opportunities: " + aggregate15b);
                        decimal aggregate15c = ((Money)((AliasedValue)c["estimatedvalue_avg"]).Value).Value;
                        System.Console.WriteLine("Average of estimated value of all opportunities: " + aggregate15c);
                        System.Console.WriteLine("----------------------------------------------");
                    }
                    System.Console.WriteLine("===============================");
                    // *****************************************************************************************************************
                    //                FetchXML      byyrqtr   Aggregate 16           
                    // *****************************************************************************************************************
                    // Fetch aggregate information about the opportunities that have 
                    // been won by year and quarter.
                    string byyrqtr = @" 
                    <fetch distinct='false' mapping='logical' aggregate='true'> 
                        <entity name='opportunity'> 
                           <attribute name='opportunityid' alias='opportunity_count' aggregate='count'/> 
                           <attribute name='estimatedvalue' alias='estimatedvalue_sum' aggregate='sum'/> 
                           <attribute name='estimatedvalue' alias='estimatedvalue_avg' aggregate='avg'/> 
                           <attribute name='actualclosedate' groupby='true' dategrouping='quarter' alias='quarter' />
                           <attribute name='actualclosedate' groupby='true' dategrouping='year' alias='year' />
                           <filter type='and'>
                               <condition attribute='statecode' operator='eq' value='Won' />
                           </filter>
                        </entity> 
                    </fetch>";

                    EntityCollection byyrqtr_result = _serviceProxy.RetrieveMultiple(new FetchExpression(byyrqtr));

                    foreach (var c in byyrqtr_result.Entities)
                    {
                        Int32 aggregate16d = (Int32)((AliasedValue)c["year"]).Value;
                        System.Console.WriteLine("Year: " + aggregate16d);
                        Int32 aggregate16 = (Int32)((AliasedValue)c["quarter"]).Value;
                        System.Console.WriteLine("Quarter: " + aggregate16);
                        Int32 aggregate16a = (Int32)((AliasedValue)c["opportunity_count"]).Value;
                        System.Console.WriteLine("Count of all opportunities: " + aggregate16a);
                        decimal aggregate16b = ((Money)((AliasedValue)c["estimatedvalue_sum"]).Value).Value;
                        System.Console.WriteLine("Sum of estimated value of all opportunities: " + aggregate16b);
                        decimal aggregate16c = ((Money)((AliasedValue)c["estimatedvalue_avg"]).Value).Value;
                        System.Console.WriteLine("Average of estimated value of all opportunities: " + aggregate16c);
                        System.Console.WriteLine("----------------------------------------------");
                    }
                    System.Console.WriteLine("===============================");
                    // *****************************************************************************************************************
                    //                FetchXML      byyrqtr2   Aggregate 17           
                    // *****************************************************************************************************************
                    // Specify the result order for the previous sample.  Order by year, then quarter.
                    string byyrqtr2 = @" 
                    <fetch distinct='false' mapping='logical' aggregate='true'> 
                        <entity name='opportunity'> 
                           <attribute name='opportunityid' alias='opportunity_count' aggregate='count'/> 
                           <attribute name='estimatedvalue' alias='estimatedvalue_sum' aggregate='sum'/> 
                           <attribute name='estimatedvalue' alias='estimatedvalue_avg' aggregate='avg'/> 
                           <attribute name='actualclosedate' groupby='true' dategrouping='quarter' alias='quarter' />
                           <attribute name='actualclosedate' groupby='true' dategrouping='year' alias='year' />
                           <order alias='year' descending='false' />
                           <order alias='quarter' descending='false' />
                           <filter type='and'>
                               <condition attribute='statecode' operator='eq' value='Won' />
                           </filter>
                        </entity> 
                    </fetch>";

                    EntityCollection byyrqtr2_result = _serviceProxy.RetrieveMultiple(new FetchExpression(byyrqtr2));

                    foreach (var c in byyrqtr2_result.Entities)
                    {
                        Int32 aggregate17 = (Int32)((AliasedValue)c["quarter"]).Value;
                        System.Console.WriteLine("Quarter: " + aggregate17);
                        Int32 aggregate17d = (Int32)((AliasedValue)c["year"]).Value;
                        System.Console.WriteLine("Year: " + aggregate17d);
                        Int32 aggregate17a = (Int32)((AliasedValue)c["opportunity_count"]).Value;
                        System.Console.WriteLine("Count of all opportunities: " + aggregate17a);
                        decimal aggregate17b = ((Money)((AliasedValue)c["estimatedvalue_sum"]).Value).Value;
                        System.Console.WriteLine("Sum of estimated value of all opportunities: " + aggregate17b);
                        decimal aggregate17c = ((Money)((AliasedValue)c["estimatedvalue_avg"]).Value).Value;
                        System.Console.WriteLine("Average of estimated value of all opportunities: " + aggregate17c);
                        System.Console.WriteLine("----------------------------------------------");
                    }
                    System.Console.WriteLine("===============================");


                    Console.WriteLine("Retrieved aggregate record data.");

                    DeleteRequiredRecords(promptForDelete);
  
                }
            }

            // Catch any service fault exceptions that Microsoft Dynamics CRM throws.
            catch (FaultException<Microsoft.Xrm.Sdk.OrganizationServiceFault>)
            {
                // You can handle an exception here or pass it back to the calling method.
                throw;
            }
            return;
		}

        /// <summary>
        /// This method creates any entity records that this sample requires.
        /// Create a sample account record.
        /// Create 3 opportunity records associate to the account record.
        /// Mark all 3 opportunity records as won.
        /// </summary>
        public void CreateRequiredRecords()
        {
            
            var OpportunityStatusCodes = new
            {
                Won = 3
            };

            // Instantiate a account entity record and set its property values.
            // See the Entity Metadata topic in the SDK documentation
            // to determine which attributes must be set for each entity.
            Account setupAccount = new Account
            { 
                Name = "Example Account" 
            };
            
            _accountId = _service.Create(setupAccount);

            Console.WriteLine("Created {0}.", setupAccount.Name);


            EntityReference setupCustomer = new EntityReference
            {
                LogicalName = Account.EntityLogicalName,
                Id = _accountId
            };

            // Create 3 sample opportunities.
            // Instantiate opportunity entity records and set there property values.
            // See the Entity Metadata topic in the SDK documentation
            // to determine which attributes must be set for each entity.
            Opportunity[] setupOpportunities = new[]
                {
                    new Opportunity
                    {
                        Name = "Sample Opp 1",
                        EstimatedValue = new Money {Value = 120000.00m},
                        CustomerId = setupCustomer,
                    },
                    new Opportunity
                    {
                        Name = "Sample Opp With Duplicate Name",
                        EstimatedValue = new Money { Value = 240000.00m},
                        CustomerId = setupCustomer,
                    },
                    new Opportunity
                    {
                        Name = "Sample Opp With Duplicate Name",
                        EstimatedValue = new Money{ Value = 360000.00m},
                        CustomerId = setupCustomer,
                    },
                };

            _setupOpportunitiyIds = (from opp in setupOpportunities
                                           select _service.Create(opp)).ToArray();

            // "Win" each of the opportunities
            foreach (Guid oppId in _setupOpportunitiyIds)
            {
                WinOpportunityRequest winRequest = new WinOpportunityRequest
                {
                    OpportunityClose = new OpportunityClose
                    {
                        OpportunityId = new EntityReference
                        {
                            LogicalName = "opportunity",
                            Id = oppId
                        },

                        // Mark these entities as won in the year 2008 to 
                        // have some testable results.
                        ActualEnd = new DateTime(2009, 11, 1, 12, 0, 0)                        
                    },
                    Status = new OptionSetValue(OpportunityStatusCodes.Won)
                };
                _service.Execute(winRequest);
            }

            Console.WriteLine("Created {0} sample opportunity records and updated as won for this sample.", _setupOpportunitiyIds.Length);
            
            return;
        }

        /// <summary>
        /// Deletes any entity records that were created for this sample.
        /// <param name="prompt">Indicates whether to prompt the user to delete the records created in this sample.</param>
        /// </summary>
        public void DeleteRequiredRecords(bool prompt)
        {
            bool deleteRecords = true;

            if (prompt)
            {
                Console.WriteLine("\nDo you want these entity records deleted? (y/n)");
                String answer = Console.ReadLine();

                deleteRecords = (answer.StartsWith("y") || answer.StartsWith("Y"));
            }

            if (deleteRecords)
            {
                foreach (Guid oppId in _setupOpportunitiyIds)
                {
                    _service.Delete("opportunity", oppId);
                }

                _service.Delete("account", _accountId);

                Console.WriteLine("Entity records have been deleted.");
            }
        }
        
        #endregion How To Sample Code

        #region Main

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

                FetchAggregationAndGroupBy app = new FetchAggregationAndGroupBy();
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
        #endregion Main
	}
}

// </snippetfetchaggregationandgroupby>