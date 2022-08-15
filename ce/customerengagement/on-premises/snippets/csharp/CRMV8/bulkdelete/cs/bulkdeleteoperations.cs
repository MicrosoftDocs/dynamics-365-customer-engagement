// <snippetbulkdeleteoperations>


using System;
using System.Linq;
using System.ServiceModel;
using Microsoft.Crm.Sdk.Messages;
using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Client;
using Microsoft.Xrm.Sdk.Query;

namespace Microsoft.Crm.Sdk.Samples
{
    /// <summary>
    /// This sample shows how to perform a bulk delete request to remove the records in
    /// Microsoft Dynamics CRM that match certain criteria.
    /// </summary>
    public class BulkDeleteOperations
    {
        #region Class Level Members
        private OrganizationServiceProxy _serviceProxy;
        private ServiceContext _context;
        private Guid _bulkDeleteOperationId;
        private Guid _asyncOperationId;
        #endregion

        #region How To Sample Code

        /// <summary>
        /// Run the sample.
        /// </summary>
        /// <param name="serverConfig">configuration for the server.</param>
        /// <param name="promptToDelete">
        /// whether or not to prompt the user to delete created records.
        /// </param>
        public void Run(ServerConnection.Configuration serverConfig, bool promptToDelete)
        {
            using (_serviceProxy = new OrganizationServiceProxy(serverConfig.OrganizationUri, serverConfig.HomeRealmUri,
                                                                     serverConfig.Credentials, serverConfig.DeviceCredentials))
            {
                using (_context = new ServiceContext(_serviceProxy))
                {
                    // This statement is required to enable early-bound type support.
                    _serviceProxy.EnableProxyTypes();

                    // This statments checks whether Standard Email templates are present
                    var emailTemplateId = (
                                       from emailTemplate in _context.TemplateSet
                                       where emailTemplate.Title == "Contact Reconnect"
                                       select emailTemplate.Id
                                      ).FirstOrDefault();             
                           
                    if (emailTemplateId != Guid.Empty)
                    {
                        CreateRequiredRecords();

                        // Perform the bulk delete.  If you want to perform a recurring delete
                        // operation, then leave this as it is.  Otherwise, pass in false as the
                        // first parameter.
                        PerformBulkDelete(true, promptToDelete);
                    }
                    else
                    {
                        throw new ArgumentException("Standard Email Templates are missing");
                    }
                }
            }
        }

        /// <summary>
        /// Create an account that will be deleted in the main portion of the sample.
        /// </summary>
        private void CreateRequiredRecords()
        {
            var account = new Account
            {
                Name = "Fourth Coffee",
                WebSiteURL = "https://www.fourthcoffee.com/"
            };
            _serviceProxy.Create(account);
        }

        /// <summary>
        /// Perform the main action of the sample - issuing a BulkDeleteRequest.
        /// </summary>
        /// <param name="useRecurrence">
        /// whether or not to create a recurring BulkDeleteRequest.
        /// </param>
        private void PerformBulkDelete(bool useRecurrence, bool promptToDelete)
        {
            try
            {
                Console.WriteLine("Performing Bulk Delete Operation");

                // Query for a system user to send an email to after the bulk delete
                // operation completes.
                var userRequest = new WhoAmIRequest();
                var userResponse = (WhoAmIResponse)_serviceProxy.Execute(userRequest);
                Guid currentUserId = userResponse.UserId;

                Console.WriteLine("  Requesting user retrieved.");

                // Create a condition for a bulk delete request.
                // NOTE: If no records are found that match this condition, the bulk delete
                // will not fail.  It will succeed with 0 successes and 0 failures.
                var deleteCondition = new ConditionExpression(
                    "name", ConditionOperator.Equal, "Fourth Coffee");

                // Create a fiter expression for the bulk delete request.
                var deleteFilter = new FilterExpression();
                deleteFilter.Conditions.Add(deleteCondition);

                // Create the bulk delete query set.
                var bulkDeleteQuery = new QueryExpression
                {
                    EntityName = Account.EntityLogicalName,
                    Distinct = false,
                    Criteria = deleteFilter
                };

                // Create the bulk delete request.
                var bulkDeleteRequest = new BulkDeleteRequest
                {
                    JobName = "Sample Bulk Delete",
                    QuerySet = new[] { bulkDeleteQuery },
                    StartDateTime = DateTime.Now,
                    ToRecipients = new[] { currentUserId },
                    CCRecipients = new Guid[] {},
                    SendEmailNotification = true,
                    RecurrencePattern = String.Empty
                    
                };

                // Create a recurring BulkDeleteOperation.
                if (useRecurrence)
                {
                    bulkDeleteRequest.RecurrencePattern = "FREQ=DAILY;INTERVAL=1;";
                }

                // Submit the bulk delete job.
                // NOTE: Because this is an asynchronous operation, the response will be
                // immediate.
                var bulkDeleteResponse =
                    (BulkDeleteResponse)_serviceProxy.Execute(bulkDeleteRequest);
                _asyncOperationId = bulkDeleteResponse.JobId;

                Console.WriteLine("  The Bulk Delete Request was made and the Bulk\n" +
                                  "    Delete Operation should be created.");

                // To monitor the asynchronous operation, retrieve the
                // bulkdeleteoperation object.
                // NOTE: There will be a period of time from when the async operation
                // request was submitted to the time when a successful query for that
                // async operation can be made.  When using plug-ins, events can be
                // subscribed to that will fire when the async operation status changes.
                var bulkQuery = new QueryByAttribute();
                bulkQuery.ColumnSet = new ColumnSet(true);
                bulkQuery.EntityName = BulkDeleteOperation.EntityLogicalName;

                // NOTE: When the bulk delete operation was submitted, the GUID that was
                // returned was the asyncoperationid, not the bulkdeleteoperationid.
                bulkQuery.Attributes.Add("asyncoperationid");
                bulkQuery.Values.Add(bulkDeleteResponse.JobId);

                // With only the asyncoperationid at this point, a RetrieveMultiple is
                // required to get the bulk delete operation created above.
                var entityCollection =
                    _serviceProxy.RetrieveMultiple(bulkQuery);
                BulkDeleteOperation createdBulkDeleteOperation = null;
                
                // When creating a recurring BulkDeleteOperation, the BulkDeleteOperation
                // will be in suspended status after the current instance has completed.
                // When creating a non-recurring BulkDeleteOperation, it will be in
                // Completed status when it is finished.
                var bulkOperationEnded = useRecurrence
                    ? BulkDeleteOperationState.Suspended
                    : BulkDeleteOperationState.Completed;

                createdBulkDeleteOperation = RetrieveBulkDeleteOperation(
                    bulkQuery, entityCollection, bulkOperationEnded);
                _bulkDeleteOperationId = createdBulkDeleteOperation.Id;

                if (createdBulkDeleteOperation != null)
                {
                    // If the BulkDeleteOperation is recurring, the status will be
                    // "Waiting" after the operation completes this instance.  If it is
                    // non-recurring, the status will be "Succeeded".
                    var bulkOperationSuccess = useRecurrence
                        ? bulkdeleteoperation_statuscode.Waiting
                        : bulkdeleteoperation_statuscode.Succeeded;

                    InspectBulkDeleteOperation(createdBulkDeleteOperation,
                        bulkOperationEnded, bulkOperationSuccess, useRecurrence);

                    DeleteRecords(promptToDelete);
                }
                else
                {
                    Console.WriteLine("  The Bulk Delete Operation could not be retrieved.");
                }
            }
            catch (System.Web.Services.Protocols.SoapException)
            {
                // Perform error handling here.
                throw;
            }
        }

        /// <summary>
        /// Inspect and display information about the created BulkDeleteOperation.
        /// </summary>
        /// <param name="createdBulkDeleteOperation">
        /// the BulkDeleteOperation to inspect.
        /// </param>
        /// <param name="bulkOperationEnded">
        /// the statecode that will tell us if the BulkDeleteOperation is ended.
        /// </param>
        /// <param name="bulkOperationSuccess">
        /// the statuscode that will tell us if the BulkDeleteOperation was successful.
        /// </param>
        /// <param name="useRecurrence">
        /// whether or not the BulkDeleteOperation is a recurring operation.
        /// </param>
        private void InspectBulkDeleteOperation(
            BulkDeleteOperation createdBulkDeleteOperation,
            BulkDeleteOperationState bulkOperationEnded,
            bulkdeleteoperation_statuscode bulkOperationSuccess,
            bool useRecurrence)
        {
            // Validate that the operation was completed.
            if (createdBulkDeleteOperation.StateCode != bulkOperationEnded)
            {
                // This will happen if it took longer than the polling time allowed 
                // for this operation to complete.
                Console.WriteLine("  Completion of the Bulk Delete took longer\n" +
                                  "    than the polling time allotted.");
            }
            else if (createdBulkDeleteOperation.StatusCode.Value
                     != (int)bulkOperationSuccess)
            {
                Console.WriteLine("  The Bulk Delete operation failed.");
            }
            else if (!useRecurrence)
            {
                // Check for the number of successful deletes.
                var successfulDeletes = createdBulkDeleteOperation.SuccessCount ?? 0;
                Console.WriteLine("  {0} records were successfully deleted",
                                  successfulDeletes);

                // Check for any failures that may have occurred during the bulk
                // delete operation.
                if (createdBulkDeleteOperation.FailureCount > 0)
                {
                    Console.WriteLine("  {0} records failed to be deleted:",
                                      createdBulkDeleteOperation.FailureCount);

                    // Query for all the failures.
                    var failureQuery = new QueryByAttribute();
                    failureQuery.ColumnSet = new ColumnSet(true);
                    failureQuery.EntityName = BulkDeleteFailure.EntityLogicalName;
                    failureQuery.Attributes.Add("bulkdeleteoperationid");
                    var bulkDeleteOperationId =
                        createdBulkDeleteOperation.BulkDeleteOperationId ?? Guid.Empty;
                    failureQuery.Values.Add(bulkDeleteOperationId);

                    // Retrieve the bulkdeletefailure objects.
                    EntityCollection entityCollection = _serviceProxy.RetrieveMultiple(
                        failureQuery);

                    // Examine each failure for information regarding the failure.
                    foreach (BulkDeleteFailure failureOperation in
                        entityCollection.Entities)
                    {
                        // Process failure information.
                        Console.WriteLine(String.Format(
                            "    {0}, {1}",
                            failureOperation.RegardingObjectId.Name,
                            failureOperation.RegardingObjectId.Id));
                    }
                }
            }
            else
            {
                // NOTE: If recurrence is used, we cannot reliably retrieve data
                // about the records that were deleted, since a sub-BulkDeleteOperation
                // is created by Microsoft Dynamics CRM that does not have any fields tying it back to the
                // Asynchronous operation or the BulkDeleteOperation. This makes it
                // unreliable to know which subprocess to retrieve.
                Console.WriteLine("  The recurring Bulk Delete Operation was created successfully.");
            }
        }

        /// <summary>
        /// Retrieves the BulkDeleteOperation, but it's not necessarily created
        /// immediately, so this method uses polling.
        /// </summary>
        /// <param name="bulkQuery">the query to find the BulkDeleteOperation.</param>
        /// <param name="entityCollection">the initial results of the query.</param>
        /// <param name="operationEndedStatus">
        /// the statecode that will indicate that the operation has ended.
        /// </param>
        private BulkDeleteOperation RetrieveBulkDeleteOperation(
            QueryByAttribute bulkQuery, EntityCollection entityCollection,
            BulkDeleteOperationState operationEndedStatus)
        {
            BulkDeleteOperation createdBulkDeleteOperation = null;
            // Monitor the async operation via polling until it is complete or max
            // polling time expires.
            const int ARBITRARY_MAX_POLLING_TIME = 60;
            int secondsTicker = ARBITRARY_MAX_POLLING_TIME;
            while (secondsTicker > 0)
            {
                // Make sure the async operation was retrieved.
                if (entityCollection.Entities.Count > 0)
                {
                    // Grab the one bulk operation that has been created.
                    createdBulkDeleteOperation =
                        (BulkDeleteOperation) entityCollection.Entities[0];

                    // Check the operation's state.
                    // NOTE: If a recurrence for the BulkDeleteOperation was
                    // specified, the state of the operation will be Suspended,
                    // not Completed, since the operation will run again in the
                    // future.
                    if (createdBulkDeleteOperation.StateCode !=
                        operationEndedStatus)
                    {
                        // The operation has not yet completed.  Wait a second for
                        // the status to change.
                        System.Threading.Thread.Sleep(1000);
                        secondsTicker--;

                        // Retrieve a fresh version of the bulk delete operation.
                        entityCollection = _serviceProxy.RetrieveMultiple(bulkQuery);
                    }
                    else
                    {
                        // Stop polling as the operation's state is now complete.
                        secondsTicker = 0;
                        Console.WriteLine(
                            "  The BulkDeleteOperation record has been retrieved.");
                    }
                }
                else
                {
                    // Wait a second for async operation to activate.
                    System.Threading.Thread.Sleep(1000);
                    secondsTicker--;

                    // Retrieve the entity again.
                    entityCollection = _serviceProxy.RetrieveMultiple(bulkQuery);
                }
            }
            return createdBulkDeleteOperation;
        }

        /// <summary>
        /// Deletes records that were created in the sample.
        /// </summary>
        /// <param name="prompt">whether or not to prompt the user for deletion.</param>
        private void DeleteRecords(bool prompt)
        {
            var toBeDeleted = true;
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
                // Delete the bulk delete operation so that it won't clutter the
                // database.
                _serviceProxy.Delete(
                    BulkDeleteOperation.EntityLogicalName, _bulkDeleteOperationId);

                var asyncOperationEntity = _serviceProxy.Retrieve(
                    AsyncOperation.EntityLogicalName,
                    _asyncOperationId,
                    new ColumnSet("statecode", "asyncoperationid"));
                var asyncOperation = asyncOperationEntity.ToEntity<AsyncOperation>();

                if (asyncOperation.StateCode != AsyncOperationState.Completed)
                {
                    // We have to update the AsyncOperation to be in a Completed state
                    // before we can delete it.
                    asyncOperation.StateCode = AsyncOperationState.Completed;
                    _serviceProxy.Update(asyncOperation);
                }

                _serviceProxy.Delete(
                    AsyncOperation.EntityLogicalName, _asyncOperationId);

                Console.WriteLine("  The AsyncOperation and BulkDeleteOperation have been deleted.");
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
                // Obtain the target organization's web address and client logon 
                // credentials from the user.
                ServerConnection serverConnect = new ServerConnection();
                ServerConnection.Configuration config = serverConnect.GetServerConfiguration();

                var app = new BulkDeleteOperations();
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

// </snippetbulkdeleteoperations>