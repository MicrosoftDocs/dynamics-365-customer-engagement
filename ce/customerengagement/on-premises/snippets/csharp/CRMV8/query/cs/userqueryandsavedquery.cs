// <snippetuserqueryandsavedquery>


using System;
using System.Collections.Generic;
using System.IO;
using System.ServiceModel;
using System.Text;
using System.Xml;

// These namespaces are found in the Microsoft.Xrm.Sdk.dll assembly
// located in the SDK\bin folder of the SDK download.
using Microsoft.Xrm.Sdk.Client;

// This namespace is found in Microsoft.Crm.Sdk.Proxy.dll assembly
// found in the SDK\bin folder.
using Microsoft.Crm.Sdk.Messages;

namespace Microsoft.Crm.Sdk.Samples
{
    /// <summary>
    /// Demonstrates how to execute saved and user queries by id, and how to validate 
    /// a saved query.
    /// </summary>
    /// <param name="serverConfig">Contains server connection information.</param>
    /// <param name="promptforDelete">When True, the user will be prompted to delete all
    /// created entities.</param>
    public class UserQueryAndSavedQuery
    {
        #region Class Level Members

        private OrganizationServiceProxy _serviceProxy;
        private List<Account> _accounts = new List<Account>();
        private SavedQuery _savedQuery;
        private UserQuery _userQuery;

        #endregion Class Level Members

        #region How To Sample Code
        /// <summary>
        /// This method first creates a series of Accounts to query over, a user query 
        /// that retrieves the names of all Accounts with a name of 'Coho Winery' and 
        /// a system query that retrieves all Account names. Then it validates the system 
        /// query, executes the system query and displays the results, and finally 
        /// executes the user query and displays the results.
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

                    #region Validate saved query
                    
                    // Create the request
                    ValidateSavedQueryRequest validateRequest = new ValidateSavedQueryRequest()
                    {
                        FetchXml = _savedQuery.FetchXml,
                        QueryType = _savedQuery.QueryType.Value
                    };
                    
                    // Send the request
                    Console.WriteLine("  Validating Saved Query");
                    try
                    {
                        // executing the request will throw an exception if the fetch xml is invalid
                        var validateResponse = (ValidateSavedQueryResponse)_serviceProxy.Execute(validateRequest);
                        Console.WriteLine("  Saved Query validated successfully");
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("  Invalid Saved Query");
                        throw;
                    }
                    
                    #endregion

                    #region Execute saved query

                    // Create the request
                    ExecuteByIdSavedQueryRequest executeSavedQueryRequest = new ExecuteByIdSavedQueryRequest()
                    {
                        EntityId = _savedQuery.Id
                    };

                    // Execute the request
                    Console.WriteLine("  Executing Saved Query");
                    ExecuteByIdSavedQueryResponse executeSavedQueryResponse =
                        (ExecuteByIdSavedQueryResponse)_serviceProxy.Execute(executeSavedQueryRequest);

                    // Check results
                    if (String.IsNullOrEmpty(executeSavedQueryResponse.String))
                        throw new Exception("Saved Query did not return any results");

                    PrintResults(executeSavedQueryResponse.String);
                    #endregion

                    #region Execute user query

                    // Create the request
                    ExecuteByIdUserQueryRequest executeUserQuery = new ExecuteByIdUserQueryRequest()
                    {
                        EntityId = _userQuery.ToEntityReference()
                    };

                    // Send the request
                    Console.WriteLine("  Executing User Query");
                    ExecuteByIdUserQueryResponse executeUserQueryResponse =
                        (ExecuteByIdUserQueryResponse)_serviceProxy.Execute(executeUserQuery);
                    if (String.IsNullOrEmpty(executeUserQueryResponse.String))
                        throw new Exception("User Query did not return any results");

                    // validate results
                    PrintResults(executeUserQueryResponse.String);

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

        #region Public methods

        /// <summary>
        /// Creates any entity records that this sample requires.
        /// </summary>
        public void CreateRequiredRecords()
        {
            #region Create Accounts to query over

            Console.WriteLine("  Creating some sample accounts");

            Account account = new Account()
            {
                Name = "Coho Vineyard"
            };
            account.Id = _serviceProxy.Create(account);
            _accounts.Add(account);
            Console.WriteLine("    Created Account {0}", account.Name);

            account = new Account()
            {
                Name = "Coho Winery"
            };
            account.Id = _serviceProxy.Create(account);
            _accounts.Add(account);
            Console.WriteLine("    Created Account {0}", account.Name);

            account = new Account()
            {
                Name = "Coho Vineyard &amp; Winery"
            };
            account.Id = _serviceProxy.Create(account);
            _accounts.Add(account);
            Console.WriteLine("    Created Account {0}", account.Name);

            #endregion

            #region Create a Saved Query

            Console.WriteLine("  Creating a Saved Query that retrieves all Account ids");

            _savedQuery = new SavedQuery()
            {
                Name = "Fetch all Account ids",
                ReturnedTypeCode = Account.EntityLogicalName,
                FetchXml = @"
                    <fetch mapping='logical'>
                        <entity name='account'>
                            <attribute name='name' />
                        </entity>
                    </fetch>",
                QueryType = 0,
                
            };
            _savedQuery.Id = _serviceProxy.Create(_savedQuery);

            #endregion

            #region Create a User Query

            Console.WriteLine(
                "  Creating a User Query that retrieves all Account ids for Accounts with name 'Coho Winery'");

            _userQuery = new UserQuery()
            {
                Name = "Fetch Coho Winery",
                ReturnedTypeCode = Account.EntityLogicalName,
                FetchXml = @"
                    <fetch mapping='logical'>
	                    <entity name='account'>
		                    <attribute name='name' />
		                    <filter>
			                    <condition attribute='name' operator='eq' value='Coho Winery' />
		                    </filter>
	                    </entity>
                    </fetch>",
                QueryType = 0
            };
            _userQuery.Id = _serviceProxy.Create(_userQuery);

            #endregion
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
                _serviceProxy.Delete(SavedQuery.EntityLogicalName, 
                    _savedQuery.Id);

                _serviceProxy.Delete(UserQuery.EntityLogicalName,
                    _userQuery.Id);

                foreach (Account a in _accounts)
                    _serviceProxy.Delete(Account.EntityLogicalName, a.Id);

                Console.WriteLine("Entity records have been deleted.");
            }
        }
        #endregion Public Methods

        #region Helper methods

        private void PrintResults(String response)
        {
            // Using XmlReader to format output
            StringBuilder output = new StringBuilder();
            using (XmlReader reader = XmlReader.Create(new StringReader(response)))
            {
                XmlWriterSettings settings = new XmlWriterSettings
                {
                    Indent = true,
                    OmitXmlDeclaration = true
                };
                using (XmlWriter writer = XmlWriter.Create(output, settings))
                {
                    // Parse the file and display each of the nodes.
                    while (reader.Read())
                    {
                        switch (reader.NodeType)
                        {
                            case XmlNodeType.Element:
                                writer.WriteStartElement(reader.Name);
                                break;
                            case XmlNodeType.Text:
                                writer.WriteString(reader.Value);
                                break;
                            case XmlNodeType.XmlDeclaration:
                            case XmlNodeType.ProcessingInstruction:
                                writer.WriteProcessingInstruction(reader.Name, reader.Value);
                                break;
                            case XmlNodeType.Comment:
                                writer.WriteComment(reader.Value);
                                break;
                            case XmlNodeType.EndElement:
                                writer.WriteFullEndElement();
                                break;
                        }
                    }
                }
            }

            Console.WriteLine("  Result of query:\r\n {0}", output.ToString());
            Console.WriteLine();
        }

        #endregion

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

                UserQueryAndSavedQuery app = new UserQueryAndSavedQuery();
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

// </snippetuserqueryandsavedquery>