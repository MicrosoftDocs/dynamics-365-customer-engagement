// <snippetbulkdeletebackup>


using System;
using System.ServiceModel;
using Microsoft.Crm.Sdk.Messages;
using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Client;
using Microsoft.Xrm.Sdk.Query;

namespace Microsoft.Crm.Sdk.Samples
{
    /// <summary>
    /// This sample shows how to perform a bulk delete asynchronous 
    /// operation on the records that have been manually exported 
    /// from Microsoft Dynamics CRM by using Export to Excel in a grid's view.
    /// </summary>
    public class BulkDeleteBackup
    {
        #region Class Level Members
        private OrganizationServiceProxy _serviceProxy;
        private BulkDeleteResponse _bulkDeleteResponse;
        private Guid? _asyncOperationId;
        private Guid? _bulkDeleteOperationId;
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
                // This statement is required to enable early-bound type support.
                _serviceProxy.EnableProxyTypes();

                PerformBulkDeleteBackup();
                DeleteRequiredRecords(promptToDelete);
            }
        }

        /// <summary>
        /// Performs the main operation of the sample - performs a bulk delete on inactive
        /// opportunities and activities to remove them from the system.
        /// </summary>
        private void PerformBulkDeleteBackup()
        {
            try
            {
                // Query for a system user to send an email to after the bulk delete
                // operation completes.
                var userRequest = new WhoAmIRequest();
                var userResponse = (WhoAmIResponse)_serviceProxy.Execute(userRequest);
                Guid currentUserId = userResponse.UserId;

                // Create a condition for a bulk delete request.
                // NOTE: This sample uses very specific queries for deleting records
                // that have been manually exported in order to free space.
                QueryExpression opportunitiesQuery = BuildOpportunityQuery();

                // Create the bulk delete request.
                BulkDeleteRequest bulkDeleteRequest = new BulkDeleteRequest();

                // Set the request properties.
                bulkDeleteRequest.JobName = "Backup Bulk Delete";

                // Querying activities
                bulkDeleteRequest.QuerySet = new QueryExpression[]
                {
                    opportunitiesQuery,
                    BuildActivityQuery(Task.EntityLogicalName),
                    BuildActivityQuery(Fax.EntityLogicalName),
                    BuildActivityQuery(PhoneCall.EntityLogicalName),
                    BuildActivityQuery(Email.EntityLogicalName),
                    BuildActivityQuery(Letter.EntityLogicalName),
                    BuildActivityQuery(Appointment.EntityLogicalName),
                    BuildActivityQuery(ServiceAppointment.EntityLogicalName),
                    BuildActivityQuery(CampaignResponse.EntityLogicalName),
                    BuildActivityQuery(RecurringAppointmentMaster.EntityLogicalName)
                };

                // Set the start time for the bulk delete.
                bulkDeleteRequest.StartDateTime = DateTime.Now;

                // Set the required recurrence pattern.
                bulkDeleteRequest.RecurrencePattern = String.Empty;

                // Set email activity properties.
                bulkDeleteRequest.SendEmailNotification = false;
                bulkDeleteRequest.ToRecipients = new Guid[] { currentUserId };
                bulkDeleteRequest.CCRecipients = new Guid[] { };

                // Submit the bulk delete job.
                // NOTE: Because this is an asynchronous operation, the response will be immediate.
                _bulkDeleteResponse =
                    (BulkDeleteResponse)_serviceProxy.Execute(bulkDeleteRequest);
                Console.WriteLine("The bulk delete operation has been requested.");

                CheckSuccess();
            }
            catch (System.Web.Services.Protocols.SoapException)
            {
                // Perform error handling here.
                throw;
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// This method will query for the BulkDeleteOperation until it has been
        /// completed or until the designated time runs out.  It then checks to see if
        /// the operation was successful.
        /// </summary>
        private void CheckSuccess()
        {
            // Query for bulk delete operation and check for status.
            QueryByAttribute bulkQuery = new QueryByAttribute(
                BulkDeleteOperation.EntityLogicalName);
            bulkQuery.ColumnSet = new ColumnSet(true);

            // NOTE: When the bulk delete operation was submitted, the GUID that was
            // returned was the asyncoperationid, not the bulkdeleteoperationid.
            bulkQuery.Attributes.Add("asyncoperationid");
            _asyncOperationId = _bulkDeleteResponse.JobId;
            bulkQuery.Values.Add(_asyncOperationId);

            // With only the asyncoperationid at this point, a RetrieveMultiple is
            // required to get the
            // bulk delete operation created above.
            EntityCollection entityCollection = _serviceProxy.RetrieveMultiple(bulkQuery);
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
                    createdBulkDeleteOperation = (BulkDeleteOperation)entityCollection.Entities[0];

                    // Check the operation's state.
                    if (createdBulkDeleteOperation.StateCode.Value != BulkDeleteOperationState.Completed)
                    {
                        // The operation has not yet completed.  Wait a second for the
                        // status to change.
                        System.Threading.Thread.Sleep(1000);
                        secondsTicker--;

                        // Retrieve a fresh version of the bulk delete operation.
                        entityCollection = _serviceProxy.RetrieveMultiple(bulkQuery);
                    }
                    else
                    {
                        // Stop polling as the operation's state is now complete.
                        secondsTicker = 0;
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

            // Validate that the operation was completed.
            if (createdBulkDeleteOperation != null)
            {
                _bulkDeleteOperationId = createdBulkDeleteOperation.BulkDeleteOperationId;
                if (createdBulkDeleteOperation.StateCode.Value != BulkDeleteOperationState.Completed)
                {
                    Console.WriteLine(
                        "Polling for the BulkDeleteOperation took longer than allowed ({0} seconds).",
                        ARBITRARY_MAX_POLLING_TIME);
                }
                else
                {
                    Console.WriteLine("The BulkDeleteOperation succeeded.\r\n  Successes: {0}, Failures: {1}",
                        createdBulkDeleteOperation.SuccessCount,
                        createdBulkDeleteOperation.FailureCount);
                }
            }
            else
            {
                Console.WriteLine("The BulkDeleteOperation could not be retrieved.");
            }
        }

        /// <summary>
        /// Builds a query that matches all opportunities that are not in the open state.
        /// </summary>
        private static QueryExpression BuildOpportunityQuery()
        {
            // Create a query that will match all opportunities that do not have a state
            // of open.
            var closedCondition = new ConditionExpression(
                "statecode", ConditionOperator.NotEqual, (int)OpportunityState.Open);

            // Create a filter expression for a bulk delete request.
            var closedFilter = new FilterExpression();
            closedFilter.Conditions.Add(closedCondition);

            var queryExpression = new QueryExpression();

            queryExpression.EntityName = Opportunity.EntityLogicalName;
            queryExpression.Criteria = closedFilter;

            // Return all records
            queryExpression.Distinct = false;

            return queryExpression;
        }

        /// <summary>
        /// Builds a query which will match all activities that are in the canceled or
        /// completed state.
        /// </summary>
        private static QueryExpression BuildActivityQuery(String entityName)
        {
            var canceledCondition = new ConditionExpression(
                "statecode", ConditionOperator.Equal, (int)ActivityPointerState.Canceled);
            var completedCondition = new ConditionExpression(
                "statecode", ConditionOperator.Equal, (int)ActivityPointerState.Completed);

            var closedFilter = new FilterExpression(LogicalOperator.Or);
            closedFilter.Conditions.AddRange(canceledCondition, completedCondition);

            var queryExpression = new QueryExpression();

            queryExpression.EntityName = entityName;
            queryExpression.Criteria = closedFilter;

            queryExpression.Distinct = false;

            return queryExpression;
        }

        /// <summary>
        /// This method deletes the AsyncOperation and BulkDeleteOperation that were
        /// created in the database, if the user confirms that deleting these is
        /// desired.
        /// </summary>
        private void DeleteRequiredRecords(bool promptToDelete)
        {
            var toBeDeleted = true;
            if (promptToDelete)
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
                if (_bulkDeleteOperationId.HasValue)
                {
                    _serviceProxy.Delete(
                        BulkDeleteOperation.EntityLogicalName,
                        _bulkDeleteOperationId.Value);
                }

                if (_asyncOperationId.HasValue)
                {
                    _serviceProxy.Delete(
                        AsyncOperation.EntityLogicalName, _asyncOperationId.Value);
                }

                Console.WriteLine("The AsyncOperation and BulkDeleteOperation have been deleted.");
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

                var app = new BulkDeleteBackup();
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

// </snippetbulkdeletebackup>