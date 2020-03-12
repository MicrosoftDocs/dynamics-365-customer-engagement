// <snippetvalidateandsetstate>



using System;
using System.ServiceModel;
using Microsoft.Crm.Sdk.Messages;
using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Client;
using Microsoft.Xrm.Sdk.Query;

namespace Microsoft.Crm.Sdk.Samples
{
    /// <summary>
    ///  This sample shows how to validate an intended state change on an entity record.
    ///  This sample will also show how to set the state on the entity record. 
    /// </summary>
    /// <remarks>
    /// At run-time, you will be given the option to delete all the
    /// database records created by this program.
    /// </remarks>
    public class ValidateAndSetState
    {
        #region Class Level Members
        private OrganizationServiceProxy _serviceProxy;
        private Guid _caseCustomerId;
        private Guid _caseIncidentId;
        #endregion

        #region How To Sample Code
        /// <summary>
        /// This method first connects to the Organization service. Afterwards, a 
        /// case is created. The IsValidStateTransition is used to test if a state change
        /// is valid. The case is closed, re-opened and then closed with SetState.
        /// </summary>
        /// <param name="serverConfig">Contains server connection information.</param>
        /// <param name="promptforDelete">When True, the user will be prompted to delete all
        /// created entities.</param>
        public void Run(ServerConnection.Configuration serverConfig,
            bool promptForDelete)
        {
            using (_serviceProxy = new OrganizationServiceProxy(serverConfig.OrganizationUri, serverConfig.HomeRealmUri,serverConfig.Credentials, serverConfig.DeviceCredentials))
            {
                // This statement is required to enable early-bound type support.
                _serviceProxy.EnableProxyTypes();

                //Create the Contact and Incident required for this sample.
                CreateRequiredRecords();

                // Create an EntityReference to represent an open case
                EntityReference caseReference = new EntityReference()
                {
                    LogicalName = Incident.EntityLogicalName,
                    Id = _caseIncidentId
                };

                IsValidStateTransitionRequest checkState = 
                    new IsValidStateTransitionRequest();

                // Set the transition request to an open case
                checkState.Entity = caseReference;

                // Check to see if a new state of "resolved" and 
                // a new status of "problem solved" are valid
                checkState.NewState = IncidentState.Resolved.ToString();
                checkState.NewStatus = (int)incident_statuscode.ProblemSolved;

                // Execute the request
                IsValidStateTransitionResponse checkStateResponse = 
                    (IsValidStateTransitionResponse)_serviceProxy.Execute(checkState);

                // Handle the response
                if (checkStateResponse.IsValid)
                {
                    String changeAnswer = "y"; // default to "y" unless prompting for delete
                    if (promptForDelete)
                    {
                        // The case can be closed
                        Console.WriteLine("Validate State Request returned that the case " +
                                          "can be closed.");
                        Console.Write("\nDo you want to change the record state? " +
                                          "(y/n) [y]: ");
                        changeAnswer = Console.ReadLine();
                        Console.WriteLine();
                    }

                    if (changeAnswer.StartsWith("y") || changeAnswer.StartsWith("Y")
                        || changeAnswer == String.Empty)
                    {
                        // Call function to change the incident to the closed state
                        CloseIncident(caseReference);
                        // Re-open the incident and change its state
                        SetState(caseReference);
                    }
                }
                else
                {
                    // The case cannot be closed
                    Console.WriteLine("Validate State Request returned that the " +
                                      "change is not valid.");
                }

                DeleteRequiredRecords(promptForDelete);
            }
        }

        private void CloseIncident(EntityReference caseReference)
        {
            // First close the Incident

            // Create resolution for the closing incident
            IncidentResolution resolution = new IncidentResolution
            {
                Subject = "Case Closed",
            };

            resolution.IncidentId = caseReference;

            // Create the request to close the incident, and set its resolution to the 
            // resolution created above
            CloseIncidentRequest closeRequest = new CloseIncidentRequest();
            closeRequest.IncidentResolution = resolution;

            // Set the requested new status for the closed Incident
            closeRequest.Status = 
                new OptionSetValue((int)incident_statuscode.ProblemSolved);

            // Execute the close request
            CloseIncidentResponse closeResponse = 
                (CloseIncidentResponse)_serviceProxy.Execute(closeRequest);

            //Check if the incident was successfully closed
            Incident incident = _serviceProxy.Retrieve(Incident.EntityLogicalName, 
                _caseIncidentId, new ColumnSet(allColumns: true)).ToEntity<Incident>();

            if (incident.StateCode.HasValue && 
                incident.StateCode == IncidentState.Resolved)
            {
                Console.WriteLine("The incident was closed out as Resolved.");
            }
            else
            {
                Console.WriteLine("The incident's state was not changed.");
            }
        }

        private void SetState(EntityReference caseReference)
        {
            // Create the Request Object
            SetStateRequest state = new SetStateRequest();

            // Set the Request Object's Properties
            state.State = new OptionSetValue((int)IncidentState.Active);
            state.Status = 
                new OptionSetValue((int)incident_statuscode.WaitingforDetails);

            // Point the Request to the case whose state is being changed
            state.EntityMoniker = caseReference;

            // Execute the Request
            SetStateResponse stateSet = (SetStateResponse)_serviceProxy.Execute(state);

            // Check if the state was successfully set
            Incident incident = _serviceProxy.Retrieve(Incident.EntityLogicalName, 
                _caseIncidentId, new ColumnSet(allColumns: true)).ToEntity<Incident>();

            if (incident.StatusCode.Value == (int)incident_statuscode.WaitingforDetails)
            {
                Console.WriteLine("Record state set successfully.");
            }
            else
            {
                Console.WriteLine("The request to set the record state failed.");
            }


        }

        /// <summary>
        /// Creates any entity records that this sample requires.
        /// </summary>
        public void CreateRequiredRecords()
        {
            // Create a customer for a new incident
            Contact caseCustomer = new Contact();

            // Set the contact properties
            caseCustomer.FirstName = "Christen";
            caseCustomer.LastName = "Anderson";

            // Create the contact in CRM
            _caseCustomerId = _serviceProxy.Create(caseCustomer);
            NotifyEntityCreated(Contact.EntityLogicalName, _caseCustomerId);

            // Retrieve the default subject for a new incident\case
            var query = new QueryExpression()
            {
                EntityName = Subject.EntityLogicalName,
                ColumnSet = new ColumnSet(allColumns: true),
                Criteria = new FilterExpression()
            };
            query.Criteria.AddCondition("title", ConditionOperator.Equal, 
                "Default Subject");

            var subjectRecords = _serviceProxy.RetrieveMultiple(query);
            Entity defaultSubject = subjectRecords[0];
            NotifyEntityRetrieved(Subject.EntityLogicalName, defaultSubject.Id);

            // Create a new incident
            Incident newCase = new Incident();

            // Set the incident properties
            newCase.SubjectId = new EntityReference();
            newCase.SubjectId.LogicalName = Subject.EntityLogicalName;
            newCase.SubjectId.Id = defaultSubject.Id;
            newCase.CustomerId = new EntityReference();
            newCase.CustomerId.LogicalName = Contact.EntityLogicalName;
            newCase.CustomerId.Id = _caseCustomerId;
            newCase.Title = "New Case from SDK";

            _caseIncidentId = _serviceProxy.Create(newCase);
            NotifyEntityCreated(Incident.EntityLogicalName, _caseIncidentId);

        }

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
                Console.Write("\nDo you want these entity records deleted? (y/n) [y]: ");
                String answer = Console.ReadLine();
                Console.WriteLine();

                deleteRecords = (answer.StartsWith("y") || answer.StartsWith("Y") 
                    || answer == String.Empty);
            }

            if (deleteRecords)
            {
                _serviceProxy.Delete(Incident.EntityLogicalName, _caseIncidentId);
                _serviceProxy.Delete(Contact.EntityLogicalName, _caseCustomerId);
                Console.WriteLine("Entity records have been deleted.");
            }
        }

        private void NotifyEntityCreated(String entityName, Guid entityId)
        {
            Console.WriteLine("  {0} created with GUID {{{1}}}",
                entityName, entityId);
        }

        private void NotifyEntityRetrieved(String entityName, Guid entityId)
        {
            Console.WriteLine("  Retrieved {0} with GUID {{{1}}}",
                entityName, entityId);
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
                // Obtain the target organization's Web address and client logon 
                // credentials from the user.
                ServerConnection serverConnect = new ServerConnection();
                ServerConnection.Configuration config = 
                    serverConnect.GetServerConfiguration();

                var app = new ValidateAndSetState();
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

                    FaultException<Microsoft.Xrm.Sdk.OrganizationServiceFault> fe = 
                        ex.InnerException
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
            // Additional exceptions to catch: SecurityTokenValidationException, 
            // ExpiredSecurityTokenException, SecurityAccessDeniedException, 
            // MessageSecurityException, and SecurityNegotiationException.

            finally
            {
                Console.WriteLine("Press <Enter> to exit.");
                Console.ReadLine();
            }
        }
        #endregion Main method
    }
}

// </snippetvalidateandsetstate>