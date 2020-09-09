// <snippetendrecurringappointmentseries>


using System;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Description;

// These namespaces are found in the Microsoft.Xrm.Sdk.dll assembly
// found in the SDK\bin folder.
using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Client;
using Microsoft.Xrm.Sdk.Query;
using Microsoft.Xrm.Sdk.Discovery;
using Microsoft.Xrm.Sdk.Messages;

// This namespace is found in Microsoft.Crm.Sdk.Proxy.dll assembly
// found in the SDK\bin folder.
using Microsoft.Crm.Sdk.Messages;

namespace Microsoft.Crm.Sdk.Samples
{
    /// <summary>
    /// This sample shows how to end a recurring appointment series.
    /// </summary>
    public class EndRecurringAppointmentSeries
    {
        #region Class Level Members
       
        /// <summary>
        /// Stores the organization service proxy.
        /// </summary>
        OrganizationServiceProxy _serviceProxy;

        // Define the IDs as well as strings needed for this sample.
        public Guid _recurringAppointmentMasterId;

        #endregion Class Level Members

        #region How To Sample Code
        /// <summary>
        /// Create and configure the organization service proxy.
        /// Initiate the method to create any data that this sample requires.
        /// End the recurring appointment series.
        /// Optionally delete any entity records that were created for this sample.
        /// </summary>
        /// <param name="serverConfig">Contains server connection information.</param>
        /// <param name="promptforDelete">When True, the user will be prompted to delete all
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


                    // Call the method to create any data that this sample requires.
                    CreateRequiredRecords();


                    // Retrieve a recurring appointment series
                    RecurringAppointmentMaster retrievedRecurringAppointmentSeries = (RecurringAppointmentMaster)_serviceProxy.Retrieve(RecurringAppointmentMaster.EntityLogicalName, _recurringAppointmentMasterId, new ColumnSet(true));

                    // Use the DeleteOpenInstances message to end the series to the
                    // last occurring past instance date w.r.t. the series end date
                    // (i.e., 20 days from today). Effectively, that means that the 
                    // series will end after the third instance (day 14) as this
                    // instance is the last occuring past instance w.r.t the specified 
                    // series end date (20 days from today).
                    // Also specify that the state of past instances (w.r.t. the series 
                    // end date) be set to 'completed'.
                    DeleteOpenInstancesRequest endAppointmentSeries = new DeleteOpenInstancesRequest
                    {
                        Target = retrievedRecurringAppointmentSeries,
                        SeriesEndDate = DateTime.Today.AddDays(20),
                        StateOfPastInstances = (int)AppointmentState.Completed
                    };
                    _serviceProxy.Execute(endAppointmentSeries);

                    Console.WriteLine("The recurring appointment series has been ended after the third occurrence.");


                    DeleteRequiredRecords(promptForDelete);

                }
            }
            // Catch any service fault exceptions that Microsoft Dynamics CRM throws.
            catch (FaultException<Microsoft.Xrm.Sdk.OrganizationServiceFault>)
            {
                // You can handle an exception here or pass it back to the calling method.
                throw;
            }
        }

        /// <summary>
        /// This method creates any entity records that this sample requires.
        /// Create a new recurring appointment.
        /// </summary>
        public void CreateRequiredRecords()
        {
            // Define an anonymous type to define the possible recurrence pattern values.
            var RecurrencePatternTypes = new
            {
                Daily = 0,
                Weekly = 1,
                Monthly = 2,
                Yearly = 3
            };

            // Define an anonymous type to define the possible values for days 
            // of the week
            var DayOfWeek = new
            {
                Sunday = 0x01,
                Monday = 0x02,
                Tuesday = 0x04,
                Wednesday = 0x08,
                Thursday = 0x10,
                Friday = 0x20,
                Saturday = 0x40
            };

            // Define an anonymous type to define the possible values  
            // for the recurrence rule pattern end type.
            var RecurrenceRulePatternEndType = new
            {
                NoEndDate = 1,
                Occurrences = 2,
                PatternEndDate = 3,
            };

            // Create a new recurring appointment
            RecurringAppointmentMaster newRecurringAppointment =
                new RecurringAppointmentMaster
                {
                    Subject = "Sample Recurring Appointment",
                    StartTime = DateTime.Now.AddHours(1),
                    EndTime = DateTime.Now.AddHours(2),
                    RecurrencePatternType = new OptionSetValue(
                        RecurrencePatternTypes.Weekly),
                    Interval = 1,
                    DaysOfWeekMask = DayOfWeek.Thursday,
                    PatternStartDate = DateTime.Today,
                    Occurrences = 5,
                    PatternEndType = new OptionSetValue(
                        RecurrenceRulePatternEndType.Occurrences)

                };

            _recurringAppointmentMasterId = _serviceProxy.Create(newRecurringAppointment);
            Console.WriteLine("Created {0} with {1} occurrences.", newRecurringAppointment.Subject, newRecurringAppointment.Occurrences);

            return;
        }

        /// <summary>
        /// Deletes any entity records that were created for this sample.
        /// <param name="prompt">Indicates whether to prompt the user to delete 
        /// the records created in this sample.</param>
        /// </summary>
        public void DeleteRequiredRecords(bool prompt)
        {
            bool deleteRecords = true;

            if (prompt)
            {
                Console.WriteLine("\nDo you want these entity records to be deleted? (y/n)");
                String answer = Console.ReadLine();

                deleteRecords = (answer.StartsWith("y") || answer.StartsWith("Y"));
            }

            if (deleteRecords)
            {
                _serviceProxy.Delete(RecurringAppointmentMaster.EntityLogicalName,
                    _recurringAppointmentMasterId);

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

                EndRecurringAppointmentSeries app = new EndRecurringAppointmentSeries();
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

                    FaultException<Microsoft.Xrm.Sdk.OrganizationServiceFault> fe
                        = ex.InnerException
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

// </snippetendrecurringappointmentseries>