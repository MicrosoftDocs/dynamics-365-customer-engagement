// <snippetcloseanincident>


using System;
using System.ServiceModel;
using Microsoft.Crm.Sdk.Messages;
using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Client;

namespace Microsoft.Crm.Sdk.Samples
{
    public class CloseAnIncident
    {
        #region Class Level Members
        private OrganizationServiceProxy _serviceProxy;
        private Guid _incidentId;
        private Guid _appointmentId;
        private Guid _accountId;
        #endregion

        #region How To Sample Code

        public void Run(ServerConnection.Configuration serverConfig,
            bool promptforDelete)
        {
            using (_serviceProxy = new OrganizationServiceProxy(serverConfig.OrganizationUri, serverConfig.HomeRealmUri,
                                                                     serverConfig.Credentials, serverConfig.DeviceCredentials))
            {
                // This statement is required to enable early bound type support.
                _serviceProxy.EnableProxyTypes();
                CreateRequiredRecords();
                RunIncidentManipulation();
                DeleteRecords(promptforDelete);
            }
        }

        private void RunIncidentManipulation()
        {
            Console.WriteLine("=== Creating and Closing an Incident (Case) ===");

            // Create an incident.
            var incident = new Incident
            {
                CustomerId = new EntityReference(Account.EntityLogicalName, _accountId),
                Title = "Sample Incident"
            };

            _incidentId = _serviceProxy.Create(incident);
            NotifyEntityCreated(Incident.EntityLogicalName, _incidentId);

	        // Create a 30-minute appointment regarding the incident.
            var appointment = new Appointment
            {
                ScheduledStart = DateTime.Now,
                ScheduledEnd = DateTime.Now.Add(new TimeSpan(0, 30, 0)),
                Subject = "Sample 30-minute Appointment",
                RegardingObjectId = new EntityReference(Incident.EntityLogicalName,
                    _incidentId)
            };

            _appointmentId = _serviceProxy.Create(appointment);
            NotifyEntityCreated(Appointment.EntityLogicalName, _appointmentId);

		    // Show the time spent on the incident before closing the appointment.
            NotifyTimeSpentOnIncident();
		    // Check the validity of the state transition to closed on the incident.
            NotifyValidityOfIncidentSolvedStateChange();
            // Close the appointment.
            var setAppointmentStateReq = new SetStateRequest
            {
                EntityMoniker = new EntityReference(Appointment.EntityLogicalName,
                    _appointmentId),
                State = new OptionSetValue((int)AppointmentState.Completed),
                Status = new OptionSetValue((int)appointment_statuscode.Completed)
            };

            _serviceProxy.Execute(setAppointmentStateReq);

            Console.WriteLine("  Appointment state set to completed.");

            // Show the time spent on the incident after closing the appointment.
            NotifyTimeSpentOnIncident();
		    // Check the validity of the state transition to closed again.
            NotifyValidityOfIncidentSolvedStateChange();
		
	        // Create the incident's resolution.
            var incidentResolution = new IncidentResolution
            {
                Subject = "Resolved Sample Incident",
                IncidentId = new EntityReference(Incident.EntityLogicalName, _incidentId)
            };

            // Close the incident with the resolution.
            var closeIncidentRequest = new CloseIncidentRequest
            {
                IncidentResolution = incidentResolution,
                Status = new OptionSetValue((int)incident_statuscode.ProblemSolved)
            };

            _serviceProxy.Execute(closeIncidentRequest);

            Console.WriteLine("  Incident closed.");
        }

        private void NotifyValidityOfIncidentSolvedStateChange()
        {
            // Validate the state transition.  
            var isValidRequest = new IsValidStateTransitionRequest
            {
                Entity = new EntityReference(Incident.EntityLogicalName, _incidentId),
                NewState = IncidentState.Resolved.ToString(),
                NewStatus = (int)incident_statuscode.ProblemSolved
            };

            var response = 
                (IsValidStateTransitionResponse)_serviceProxy.Execute(isValidRequest);
            var isValidString = response.IsValid ? "is valid" : "is not valid";
            Console.WriteLine("  The transition to a completed status reason {0}.",
                isValidString);
        }

        private void NotifyTimeSpentOnIncident()
        {
            // Calculate the total number of minutes spent on an incident. 
            var calculateRequestTime = new CalculateTotalTimeIncidentRequest
            {
                IncidentId = _incidentId
            };
            var response =
                (CalculateTotalTimeIncidentResponse)_serviceProxy.Execute(calculateRequestTime);

            Console.WriteLine("  {0} minutes have been spent on the incident.",
                response.TotalTime);
        }

        private void NotifyEntityCreated(String entityName, Guid entityId)
        {
            Console.WriteLine("  {0} created with GUID {{{1}}}",
                entityName, entityId);
        }

        private void CreateRequiredRecords()
        {
            // Create an account to act as a customer for the incident.
            var account = new Account
            {
                Name = "Litware, Inc.",
                Address1_StateOrProvince = "Colorado"
            };
            _accountId = (_serviceProxy.Create(account));
        }

        private void DeleteRecords(bool prompt)
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
                // The account is all that needs to be deleted.  Everything else will be
                // deleted with it.
                _serviceProxy.Delete(Account.EntityLogicalName, _accountId);
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

                var app = new CloseAnIncident();
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

// </snippetcloseanincident>