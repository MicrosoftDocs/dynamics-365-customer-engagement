// <snippetfetchxmlandqueryexpressionqueryconversion>


using System;
using System.Collections.Generic;
using System.ServiceModel;
using Microsoft.Crm.Sdk.Messages;
using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Client;
using Microsoft.Xrm.Sdk.Query;

namespace Microsoft.Crm.Sdk.Samples
{
    public class FetchXmlAndQueryExpressionQueryConversion
    {
        
        #region Class Level Members
        private OrganizationServiceProxy _serviceProxy;
        private Guid _accountId;
        private readonly List<Guid> _contactIdList = new List<Guid>();
        private readonly List<Guid> _opportunityIdList = new List<Guid>();
        #endregion

        #region How To Sample Code
        public void Run(ServerConnection.Configuration serverConfig,
            bool promptforDelete)
        {
            using (_serviceProxy = new OrganizationServiceProxy(serverConfig.OrganizationUri, serverConfig.HomeRealmUri,serverConfig.Credentials, serverConfig.DeviceCredentials))
            {
                // This statement is required to enable early-bound type support.
                _serviceProxy.EnableProxyTypes();
                CreateRequiredRecords();
                DoQueryExpressionToFetchXmlConversion();
                DoFetchXmlToQueryExpressionConversion();
                DeleteRequiredRecords(promptforDelete);
            }
        }

        private void DoQueryExpressionToFetchXmlConversion()
        {
            // Build a query expression that we will turn into FetchXML.
            var queryExpression = new QueryExpression()
            {
                Distinct = false,
                EntityName = Contact.EntityLogicalName,
                ColumnSet = new ColumnSet("fullname", "address1_telephone1"),
                LinkEntities = 
                    {
                        new LinkEntity 
                        {
                            JoinOperator = JoinOperator.LeftOuter,
                            LinkFromAttributeName = "parentcustomerid",
                            LinkFromEntityName = Contact.EntityLogicalName,
                            LinkToAttributeName = "accountid",
                            LinkToEntityName = Account.EntityLogicalName,
                            LinkCriteria = 
                            {
                                Conditions = 
                                {
                                    new ConditionExpression("name", ConditionOperator.Equal, "Litware, Inc.")
                                }
                            }
                        }
                    },
                Criteria =
                {
                    Filters = 
                        {
                            new FilterExpression
                            {
                                FilterOperator = LogicalOperator.And,
                                Conditions = 
                                {
                                    new ConditionExpression("address1_stateorprovince", ConditionOperator.Equal, "WA"),
                                    new ConditionExpression("address1_city", ConditionOperator.In, new String[] {"Redmond", "Bellevue" , "Kirkland", "Seattle"}),
                                    new ConditionExpression("createdon", ConditionOperator.LastXDays, 30),
                                    new ConditionExpression("emailaddress1", ConditionOperator.NotNull)
                                },
                            },
                            new FilterExpression
                            {
                                FilterOperator = LogicalOperator.Or,
                                Conditions =
                                {
                                    new ConditionExpression("address1_telephone1", ConditionOperator.Like, "(206)%"),
                                    new ConditionExpression("address1_telephone1", ConditionOperator.Like, "(425)%")
                                }
                            }
                        }
                }
            };

            // Run the query as a query expression.
            EntityCollection queryExpressionResult =
                _serviceProxy.RetrieveMultiple(queryExpression);
            Console.WriteLine("Output for query as QueryExpression:");
            DisplayContactQueryResults(queryExpressionResult);

            // Convert the query expression to FetchXML.
            var conversionRequest = new QueryExpressionToFetchXmlRequest
            {
                Query = queryExpression
            };
            var conversionResponse =
                (QueryExpressionToFetchXmlResponse)_serviceProxy.Execute(conversionRequest);

            // Use the converted query to make a retrieve multiple request to Microsoft Dynamics CRM.
            String fetchXml = conversionResponse.FetchXml;
            var fetchQuery = new FetchExpression(fetchXml);
            EntityCollection result = _serviceProxy.RetrieveMultiple(fetchQuery);

            // Display the results.
            Console.WriteLine("\nOutput for query after conversion to FetchXML:");
            DisplayContactQueryResults(result);

        }

        private static void DisplayContactQueryResults(EntityCollection result)
        {
            Console.WriteLine("List all contacts matching specified parameters");
            Console.WriteLine("===============================================");
            foreach (Entity entity in result.Entities)
            {
                var contact = entity.ToEntity<Contact>();
                Console.WriteLine("Contact ID: {0}", contact.Id);
                Console.WriteLine("Contact Name: {0}", contact.FullName);
                Console.WriteLine("Contact Phone: {0}", contact.Address1_Telephone1);
            }
            Console.WriteLine("<End of Listing>");
            Console.WriteLine();
        }

        private void DoFetchXmlToQueryExpressionConversion()
        {
            // Create a Fetch query that we will convert into a query expression.
            var fetchXml =
                @"<fetch mapping='logical' version='1.0'>
	                <entity name='opportunity'>
		                <attribute name='name' />
		                <filter>
			                <condition attribute='estimatedclosedate' operator='next-x-fiscal-years' value='3' />
		                </filter>
		                <link-entity name='account' from='accountid' to='customerid'>
			                <link-entity name='contact' from='parentcustomerid' to='accountid'>
				                <attribute name='fullname' />
				                <filter>
					                <condition attribute='address1_city' operator='eq' value='Bellevue' />
					                <condition attribute='address1_stateorprovince' operator='eq' value='WA' />
				                </filter>
			                </link-entity>
		                </link-entity>
	                </entity>
                </fetch>";

            // Run the query with the FetchXML.
            var fetchExpression = new FetchExpression(fetchXml);
            EntityCollection fetchResult =
                _serviceProxy.RetrieveMultiple(fetchExpression);
            Console.WriteLine("\nOutput for query as FetchXML:");
            DisplayOpportunityQueryResults(fetchResult);

            // Convert the FetchXML into a query expression.
            var conversionRequest = new FetchXmlToQueryExpressionRequest
            {
                FetchXml = fetchXml
            };

            var conversionResponse =
                (FetchXmlToQueryExpressionResponse)_serviceProxy.Execute(conversionRequest);

            // Use the newly converted query expression to make a retrieve multiple
            // request to Microsoft Dynamics CRM.
            QueryExpression queryExpression = conversionResponse.Query;

            EntityCollection result = _serviceProxy.RetrieveMultiple(queryExpression);

            // Display the results.
            Console.WriteLine("\nOutput for query after conversion to QueryExpression:");
            DisplayOpportunityQueryResults(result);

        }

        private static void DisplayOpportunityQueryResults(EntityCollection result)
        {
            Console.WriteLine("List all opportunities matching specified parameters.");
            Console.WriteLine("===========================================================================");
            foreach (Entity entity in result.Entities)
            {
                var opportunity = entity.ToEntity<Opportunity>();
                Console.WriteLine("Opportunity ID: {0}", opportunity.Id);
                Console.WriteLine("Opportunity: {0}", opportunity.Name);
                var aliased = (AliasedValue)opportunity["contact2.fullname"];
                var contactName = (String)aliased.Value;
                Console.WriteLine("Associated contact: {0}", contactName);
            }
            Console.WriteLine("<End of Listing>");
            Console.WriteLine();
        }

        /// <summary>
        /// Creates any entity records that this sample requires.
        /// </summary>
        public void CreateRequiredRecords()
        {

            // Create an account.
            var account = new Account
            {
                Name = "Litware, Inc.",
                Address1_StateOrProvince = "Colorado"
            };
            _accountId = (_serviceProxy.Create(account));

            // Create the two contacts.
            var contact = new Contact()
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

            contact = new Contact()
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

            // Create two opportunities.
            var opportunity = new Opportunity()
            {
                Name = "Litware, Inc. Opportunity 1",
                EstimatedCloseDate = DateTime.Now.AddMonths(6),
                CustomerId = new EntityReference
                {
                    Id = _accountId,
                    LogicalName = account.LogicalName
                }
            };
            _opportunityIdList.Add(_serviceProxy.Create(opportunity));

            opportunity = new Opportunity()
            {
                Name = "Litware, Inc. Opportunity 2",
                EstimatedCloseDate = DateTime.Now.AddYears(4),
                CustomerId = new EntityReference
                {
                    Id = _accountId,
                    LogicalName = account.LogicalName
                }
            };
            _opportunityIdList.Add(_serviceProxy.Create(opportunity));
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
                foreach (Guid contactId in _contactIdList)
                {
                    _serviceProxy.Delete(Contact.EntityLogicalName, contactId);
                }

                foreach (Guid opportunityId in _opportunityIdList)
                {
                    _serviceProxy.Delete(Opportunity.EntityLogicalName, opportunityId);
                }

                _serviceProxy.Delete(Account.EntityLogicalName, _accountId);

                Console.WriteLine("Entity record(s) have been deleted.");
            }
        }

        #endregion

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

                var app = new FetchXmlAndQueryExpressionQueryConversion();
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

// </snippetfetchxmlandqueryexpressionqueryconversion>