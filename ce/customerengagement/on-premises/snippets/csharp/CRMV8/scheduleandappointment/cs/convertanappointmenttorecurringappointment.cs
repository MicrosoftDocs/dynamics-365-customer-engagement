// <snippetconvertanappointmenttorecurringappointment>


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
    /// This sample shows how to convert an appointment to a
    /// recurring appointment.
    /// </summary>
    public class ConvertAnAppointmenttoRecurringAppointment
    {
        #region Class Level Members

        /// <summary>
        /// Stores the organization service proxy.
        /// </summary>
        private OrganizationServiceProxy _serviceProxy;

        // Define the IDs as well as strings needed for this sample.
        public Guid _appointmentId;
        public Guid __recurringAppointmentMasterId;

        #endregion Class Level Members

        #region How To Sample Code
        /// <summary>
        /// Create and configure the organization service proxy.
        /// Initiate the method to create any data that this sample requires.
        /// Convert an appointment to a recurring appointment.
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
                using (_serviceProxy = new OrganizationServiceProxy(serverConfig.OrganizationUri, serverConfig.HomeRealmUri,
                                                                     serverConfig.Credentials, serverConfig.DeviceCredentials))
                {
                    // This statement is required to enable early-bound type support.
                    _serviceProxy.EnableProxyTypes();


                    // Call the method to create any data that this sample requires.
                    CreateRequiredRecords();


                    // Specify the recurrence information that needs to be added to the
                    // existing appointment.
                    // 1.  Define an anonymous type to define the possible recurrence pattern values.
                    var RecurrencePatternTypes = new
                    {
                        Daily = 0,
                        Weekly = 1,
                        Monthly = 2,
                        Yearly = 3
                    };

                    // 2.  Define an anonymous type to define the possible values for days 
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

                    // 3.  Define an anonymous type to define the possible values  
                    // for the recurrence rule pattern end type.
                    var RecurrenceRulePatternEndType = new
                    {
                        NoEndDate = 1,
                        Occurrences = 2,
                        PatternEndDate = 3
                    };

                    // 4.  Finally, use a recurring appointment master object to specify
                    //     the recurrence information. Other appointment details such as
                    //     'subject' and 'location' are copied from the existing appointment
                    //     to the recurring appointment master object.

                    RecurringAppointmentMaster newRecurringAppointmentInfo = new RecurringAppointmentMaster
                        {
                            StartTime = DateTime.Now.AddHours(2),
                            EndTime = DateTime.Now.AddHours(3),
                            RecurrencePatternType = new OptionSetValue(RecurrencePatternTypes.Weekly),
                            Interval = 1,
                            DaysOfWeekMask = DayOfWeek.Thursday,
                            PatternStartDate = DateTime.Today,
                            PatternEndType = new OptionSetValue(RecurrenceRulePatternEndType.Occurrences),
                            Occurrences = 5
                        };


                    // Use the AddRecurrence message to convert the existing appointment
                    // object to a recurring appointment master object. The existing
                    // appointment object is deleted thereafter.

                    AddRecurrenceRequest recurringInfoRequest = new AddRecurrenceRequest
                    {
                        Target = newRecurringAppointmentInfo,
                        AppointmentId = _appointmentId
                    };

                    AddRecurrenceResponse recurringInfoResponse = (AddRecurrenceResponse)_serviceProxy.Execute(recurringInfoRequest);
                    __recurringAppointmentMasterId = recurringInfoResponse.id;

                    // Verify that the newly created recurring appointment master has same 'subject' 
                    // as the existing appointment.

                    RecurringAppointmentMaster retrievedMasterAppointment = (RecurringAppointmentMaster)_serviceProxy.Retrieve(RecurringAppointmentMaster.EntityLogicalName, __recurringAppointmentMasterId, new ColumnSet(true));
                    if (retrievedMasterAppointment.Subject == "Sample Appointment")
                    {
                        Console.WriteLine("Sample Appointment is converted to a recurring appointment.");
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
        }

        /// <summary>
        /// This method creates any entity records that this sample requires.
        /// Create a new recurring appointment.
        /// </summary>
        public void CreateRequiredRecords()
        {
            // Create an appointment
            Appointment newAppointment = new Appointment
                {
                    Subject = "Sample Appointment",
                    Location = "Office",
                    ScheduledStart = DateTime.Now.AddHours(1),
                    ScheduledEnd = DateTime.Now.AddHours(2),                 
                };

            _appointmentId = _serviceProxy.Create(newAppointment);
            Console.WriteLine("Created {0}", newAppointment.Subject);

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
                    __recurringAppointmentMasterId);

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

                ConvertAnAppointmenttoRecurringAppointment app = new ConvertAnAppointmenttoRecurringAppointment();
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

// </snippetconvertanappointmenttorecurringappointment>