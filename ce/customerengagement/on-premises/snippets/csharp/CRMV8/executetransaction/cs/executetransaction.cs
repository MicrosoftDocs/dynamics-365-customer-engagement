// <snippetexecutetransaction>


using System;
using System.Collections.Generic;
using System.ServiceModel;
using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Client;
using Microsoft.Xrm.Sdk.Metadata;
using Microsoft.Xrm.Sdk.Messages;
using Microsoft.Xrm.Sdk.Query;

namespace Microsoft.Crm.Sdk.Samples
{
    class ExecuteTransaction
    {
        #region Class Level Members

        private OrganizationServiceProxy _serviceProxy;
        private readonly List<Guid> _newAccountIds = new List<Guid>();

        #endregion

        #region How To Sample Code

        /// <summary>
        /// This sample demonstrates how to execute a collection of message requests in a single database transaction, 
        /// by using a single web service call and optionally return the results. 
        /// </summary>
        /// <seealso cref="https://msdn.microsoft.com/library/gg328075.aspx#bkmk_transaction"/>
        /// <param name="serverConfig">Contains server connection information.</param>
        /// <param name="promptforDelete">When True, the user will be prompted to delete all
        /// created entities.</param>
        public void Run(ServerConnection.Configuration serverConfig, bool promptforDelete)
        {
            ExecuteTransactionRequest requestToCreateRecords = null;
            try
            {
                // Get a reference to the organization service.
                using (_serviceProxy = new OrganizationServiceProxy(serverConfig.OrganizationUri, serverConfig.HomeRealmUri, serverConfig.Credentials, serverConfig.DeviceCredentials))
                {
                    // Enable early-bound type support to add/update entity records required for this sample.
                    _serviceProxy.EnableProxyTypes();

                    #region Execute Transaction to create records
                    // Create an ExecuteTransactionRequest object.
                    requestToCreateRecords = new ExecuteTransactionRequest()
                    {
                        // Create an empty organization request collection.
                        Requests = new OrganizationRequestCollection(),
                        ReturnResponses = true
                    };

                    // Create several (local, in memory) entities in a collection. 
                    EntityCollection input = GetCollectionOfEntitiesToCreate();

                    // Add a CreateRequest for each entity to the request collection.
                    foreach (var entity in input.Entities)
                    {
                        CreateRequest createRequest = new CreateRequest { Target = entity };
                        requestToCreateRecords.Requests.Add(createRequest);
                    }

                    // Execute all the requests in the request collection using a single web method call.
                    try
                    {
                        var responseForCreateRecords =
                            (ExecuteTransactionResponse)_serviceProxy.Execute(requestToCreateRecords);

                        int i = 0;
                        // Display the results returned in the responses.
                        foreach (var responseItem in responseForCreateRecords.Responses)
                        {
                            if (responseItem != null)
                                DisplayResponse(requestToCreateRecords.Requests[i], responseItem);
                            i++;
                        }
                    }
                    catch (FaultException<OrganizationServiceFault> ex)
                    {
                        Console.WriteLine("Create request failed for the account{0} and the reason being: {1}",
                            ((ExecuteTransactionFault)(ex.Detail)).FaultedRequestIndex + 1, ex.Detail.Message);
                        throw;
                    }

                    #endregion Execute Transaction to create records

                    #region Execute Transaction to update records
                    ExecuteTransactionRequest requestForUpdates = new ExecuteTransactionRequest()
                    {
                        Requests = new OrganizationRequestCollection()
                    };

                    // Update the entities that were previously created.
                    EntityCollection update = GetCollectionOfEntitiesToUpdate();

                    foreach (var entity in update.Entities)
                    {
                        UpdateRequest updateRequest = new UpdateRequest { Target = entity };
                        requestForUpdates.Requests.Add(updateRequest);
                    }

                    try
                    {
                        ExecuteTransactionResponse responseForUpdates =
                            (ExecuteTransactionResponse)_serviceProxy.Execute(requestForUpdates);
                        Console.WriteLine("Entity records are updated.");
                    }
                    catch (FaultException<OrganizationServiceFault> ex)
                    {
                        Console.WriteLine("Update request failed for the account{0} and the reason being: {1}",
                            ((ExecuteTransactionFault)(ex.Detail)).FaultedRequestIndex + 1, ex.Detail.Message);
                    }
                    #endregion Execute Transaction for update records

                    DeleteRequiredRecords(promptforDelete);
                }
            }
            catch (FaultException<OrganizationServiceFault> fault)
            {
                // Check if the maximum batch size has been exceeded. The maximum batch size is only included in the fault if it
                // the input request collection count exceeds the maximum batch size.
                if (fault.Detail.ErrorDetails.Contains("MaxBatchSize"))
                {
                    int maxBatchSize = Convert.ToInt32(fault.Detail.ErrorDetails["MaxBatchSize"]);
                    if (maxBatchSize < requestToCreateRecords.Requests.Count)
                    {
                        // Here you could reduce the size of your request collection and re-submit the ExecuteTransaction request.
                        // For this sample, that only issues a few requests per batch, we will just print out some info. However,
                        // this code will never be executed because the default max batch size is 1000.
                        Console.WriteLine("The input request collection contains %0 requests, which exceeds the maximum allowed (%1)",
                            requestToCreateRecords.Requests.Count, maxBatchSize);
                    }
                }
                // Re-throw so Main() can process the fault.
                throw;
            }
        }

        #region Public Methods

        /// <summary>
        /// Deletes any entity records that were created for this sample.
        /// <param name="prompt">Indicates whether to prompt the user 
        /// to delete the records created in this sample.</param>
        /// </summary>
        public void DeleteRequiredRecords(bool prompt)
        {
            bool deleteRecords = true;

            if (prompt)
            {
                Console.WriteLine("\nDo you want to delete the account record? (y/n) [y]: ");
                String answer = Console.ReadLine();

                deleteRecords = (answer.StartsWith("y") || answer.StartsWith("Y") || answer == String.Empty);
            }

            if (!deleteRecords)
                return;

            ExecuteMultipleRequest requestWithNoResults = new ExecuteMultipleRequest()
            {
                // Set the execution behavior to continue and to not return responses.
                Settings = new ExecuteMultipleSettings()
                {
                    ContinueOnError = true,
                    ReturnResponses = false
                },
                Requests = new OrganizationRequestCollection()
            };

            // Get all the entities into a collection to delete
            EntityCollection delete = GetCollectionOfEntitiesToDelete();
            foreach (var entity in delete.Entities)
            {
                DeleteRequest deleteRequest = new DeleteRequest { Target = entity.ToEntityReference() };
                requestWithNoResults.Requests.Add(deleteRequest);
            }

            ExecuteMultipleResponse responseWithNoResults =
                (ExecuteMultipleResponse)_serviceProxy.Execute(requestWithNoResults);

            // There should be no responses unless there was an error. 
            if (responseWithNoResults.Responses.Count > 0)
            {
                foreach (var responseItem in responseWithNoResults.Responses)
                {
                    if (responseItem.Fault != null)
                        DisplayFault(requestWithNoResults.Requests[responseItem.RequestIndex],
                            responseItem.RequestIndex, responseItem.Fault);
                }
            }
            else
            {
                Console.WriteLine("All account records have been deleted successfully.");
            }
        }

        #endregion

        #region Private Methods

        /// <summary>
        /// Create a collection of new entity objects.
        /// </summary>
        /// <returns>A collection of entity objects.</returns>
        private EntityCollection GetCollectionOfEntitiesToCreate()
        {
            return new EntityCollection()
            {
                EntityName = Account.EntityLogicalName,
                Entities = {
                    new Account { Name = "ExecuteTransaction Example Account 1" },
                    new Account { Name = "ExecuteTransaction Example Account 2" },
                    new Account { Name = "ExecuteTransaction Example Account 3" },
                    new Account { Name = "ExecuteTransaction Example Account 4" },
                    new Account { Name = "ExecuteTransaction Example Account 5" }
                }
            };
        }

        /// <summary>
        /// Display the response of an organization message request.
        /// </summary>
        /// <param name="organizationRequest">The organization message request.</param>
        /// <param name="organizationResponse">The organization message response.</param>
        private void DisplayResponse(OrganizationRequest organizationRequest, OrganizationResponse organizationResponse)
        {
            Console.WriteLine("Created " + ((Account)organizationRequest.Parameters["Target"]).Name
                + " with account id as " + organizationResponse.Results["id"].ToString());
            _newAccountIds.Add(new Guid(organizationResponse.Results["id"].ToString()));
        }

        /// <summary>
        /// Create a collection of entity objects for updating. Give these entities a new
        /// name for the update.
        /// </summary>
        /// <returns>An entity collection.</returns>
        private EntityCollection GetCollectionOfEntitiesToUpdate()
        {
            EntityCollection collection = new EntityCollection()
            {
                EntityName = Account.EntityLogicalName
            };

            for (int i = 1; i <= _newAccountIds.Count; i++)
            {
                collection.Entities.Add(
                    new Account
                    {
                        Name = "Updated Account Name " + i.ToString(),
                        Id = _newAccountIds[i - 1]
                    });
            }

            return collection;
        }

        /// <summary>
        /// Delete a collection of entity objects.
        /// </summary>
        /// <returns>A collection of entity objects</returns>
        private EntityCollection GetCollectionOfEntitiesToDelete()
        {
            EntityCollection collection = new EntityCollection()
            {
                EntityName = Account.EntityLogicalName
            };

            for (int i = 1; i <= _newAccountIds.Count; i++)
            {
                collection.Entities.Add(
                    new Account
                    {
                        Id = _newAccountIds[i - 1]
                    });
            }

            return collection;
        }

        /// <summary>
        /// Display the fault that resulted from processing an organization message request.
        /// </summary>
        /// <param name="organizationRequest">The organization message request.</param>
        /// <param name="count">nth request number from ExecuteMultiple request</param>
        /// <param name="organizationServiceFault">A WCF fault.</param>
        private void DisplayFault(OrganizationRequest organizationRequest, int count,
            OrganizationServiceFault organizationServiceFault)
        {
            Console.WriteLine("A fault occurred when processing {1} request, at index {0} in the request collection with a fault message: {2}", count + 1,
                organizationRequest.RequestName,
                organizationServiceFault.Message);
        }

        #endregion

        #endregion How To Sample Code

        #region Main method

        /// <summary>
        /// Standard Main() method used by most SDK samples.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            try
            {
                // Obtain the target organization's Web address and client logon 
                // credentials from the user.
                ServerConnection serverConnect = new ServerConnection();
                ServerConnection.Configuration config = serverConnect.GetServerConfiguration();

                var app = new ExecuteTransaction();
                app.Run(config, true);
            }

            catch (FaultException<Microsoft.Xrm.Sdk.OrganizationServiceFault> ex)
            {
                Console.WriteLine("The application terminated with an error.");
                Console.WriteLine("Timestamp: {0}", ex.Detail.Timestamp);
                Console.WriteLine("Code: {0}", ex.Detail.ErrorCode);
                Console.WriteLine("Message: {0}", ex.Detail.Message);
                Console.WriteLine("Trace: {0}", ex.Detail.TraceText);
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
                        Console.WriteLine("Trace: {0}", fe.Detail.TraceText);
                        Console.WriteLine("Inner Fault: {0}",
                            null == fe.Detail.InnerFault ? "No Inner Fault" : "Has Inner Fault");
                    }
                }
            }
            finally
            {
                Console.WriteLine("Press <Enter> to exit.");
                Console.ReadLine();
            }
        }

        #endregion Main method
    }
}

// </snippetexecutetransaction>