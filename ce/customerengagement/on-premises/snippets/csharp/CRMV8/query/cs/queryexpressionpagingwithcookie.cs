// <snippetqueryexpressionpagingwithcookie>


using System;
using System.ServiceModel;
using System.ServiceModel.Description;
using System.Collections.Generic;

// These namespaces are found in the Microsoft.Xrm.Sdk.dll assembly
// found in the SDK\bin folder.
using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Client;
using Microsoft.Xrm.Sdk.Query;
using Microsoft.Xrm.Sdk.Discovery;

// This namespace is found in Microsoft.Crm.Sdk.Proxy.dll assembly
// found in the SDK\bin folder.
using Microsoft.Crm.Sdk.Messages;
using Microsoft.Xrm.Sdk.Messages;


namespace Microsoft.Crm.Sdk.Samples
{
    /// <summary>
    /// Demonstrates how to use the QueryExpression with a paging
    /// cookie to retrieve a batch of records.
    /// If you want to run this sample repeatedly, you have the option to 
    /// delete all the records created at the end of execution.
    /// </summary>
    class QueryExpressionPagingWithCookie
    {
        #region Class Level Members

        /// <summary>
        /// Stores the organization service proxy.
        /// </summary>
        private OrganizationServiceProxy _serviceProxy;
        private IOrganizationService _service;

        // Define the IDs needed for this sample.        
        public Guid[] _childAccountIds;
        public Guid _parentAccountId;

        #endregion Class Level Members

        #region How To Sample Code
        /// <summary>
        /// Create and configure the organization service proxy.
        /// Create a parent account record and subsequent 10 child account records.
        /// Retrieve batch of records using RetrieveMultiple message with paging cookie.
        /// Optionally delete any entity records that were created for this sample.
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

                    // Query using the paging cookie.
                    // Define the paging attributes.
                    // The number of records per page to retrieve.
                    int queryCount = 3;
                    
                    // Initialize the page number.
                    int pageNumber = 1;
                    
                    // Initialize the number of records.
                    int recordCount = 0;
                    
                    // Define the condition expression for retrieving records.
                    ConditionExpression pagecondition = new ConditionExpression();
                    pagecondition.AttributeName = "parentaccountid";
                    pagecondition.Operator = ConditionOperator.Equal;
                    pagecondition.Values.Add(_parentAccountId);

                    // Define the order expression to retrieve the records.
                    OrderExpression order = new OrderExpression();
                    order.AttributeName = "name";
                    order.OrderType = OrderType.Ascending;

                    // Create the query expression and add condition.
                    QueryExpression pagequery = new QueryExpression();
                    pagequery.EntityName = "account";
                    pagequery.Criteria.AddCondition(pagecondition);
                    pagequery.Orders.Add(order);
                    pagequery.ColumnSet.AddColumns("name", "emailaddress1");                   

                    // Assign the pageinfo properties to the query expression.
                    pagequery.PageInfo = new PagingInfo();
                    pagequery.PageInfo.Count = queryCount;
                    pagequery.PageInfo.PageNumber = pageNumber;

                    // The current paging cookie. When retrieving the first page, 
                    // pagingCookie should be null.
                    pagequery.PageInfo.PagingCookie = null;
                    Console.WriteLine("Retrieving sample account records in pages...\n");
                    Console.WriteLine("#\tAccount Name\t\tEmail Address"); 
                    
                    while (true)
                    {
                        // Retrieve the page.
                        EntityCollection results = _serviceProxy.RetrieveMultiple(pagequery);
                        if (results.Entities != null)
                        {
                            // Retrieve all records from the result set.
                            foreach (Account acct in results.Entities)
                            {
                                Console.WriteLine("{0}.\t{1}\t{2}", ++recordCount, acct.Name,
                                                   acct.EMailAddress1);
                            }
                        }

                        // Check for more records, if it returns true.
                        if (results.MoreRecords)
                        {
                            Console.WriteLine("\n****************\nPage number {0}\n****************", pagequery.PageInfo.PageNumber);
                            Console.WriteLine("#\tAccount Name\t\tEmail Address");

                            // Increment the page number to retrieve the next page.
                            pagequery.PageInfo.PageNumber++;
                            
                            // Set the paging cookie to the paging cookie returned from current results.
                            pagequery.PageInfo.PagingCookie = results.PagingCookie;
                        }
                        else
                        {
                            // If no more records are in the result nodes, exit the loop.
                            break;
                        }
                    }

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
        /// Create a parent account record.
        /// Create 10 child accounts to the parent account record.
        /// </summary>
        public void CreateRequiredRecords()
        {
            Console.WriteLine("Creating sample account records...\n");

            // Instantiate a account entity record and set its property values.
            // See the Entity Metadata topic in the SDK documentation
            // to determine which attributes must be set for each entity.
            // Create the parent account.
            Account parentAccount = new Account
            {
                Name = "Root Test Account",
                EMailAddress1 = "root@root.com"
            };

            _parentAccountId = _service.Create(parentAccount);

            // Create 10 child accounts.
            _childAccountIds = new Guid[10];
            int count = 1;
            while (true)
            {
                Account childAccount = new Account
                {
                    Name = "Child Test Account " + count.ToString(),
                    EMailAddress1 = "child" + count.ToString() + "@root.com",
                    EMailAddress2 = "same@root.com",
                    ParentAccountId = new EntityReference(Account.EntityLogicalName, _parentAccountId)
                };

                _childAccountIds[count - 1] = _service.Create(childAccount);

                // Jump out of the loop after creating 10 child accounts.
                if (count == 10)
                    break;
                // Increment the count.
                count++;
            }
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
                Console.WriteLine("Delting entity records... please wait!");
                
                // Remove 10 test child accounts.
                int deleteCount = 0;
                while (deleteCount < 10)
                {
                    _service.Delete(Account.EntityLogicalName, _childAccountIds[deleteCount]);
                    ++deleteCount;
                }

                // Remove the test parent account.
                _service.Delete(Account.EntityLogicalName, _parentAccountId);

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

                QueryExpressionPagingWithCookie app = new QueryExpressionPagingWithCookie();
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

// </snippetqueryexpressionpagingwithcookie>