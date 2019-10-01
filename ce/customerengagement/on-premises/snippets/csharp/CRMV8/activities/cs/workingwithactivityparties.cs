// <snippetworkingwithactivityparties>


using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;

// These namespaces are found in the Microsoft.Xrm.Sdk.dll assembly
// located in the SDK\bin folder of the SDK download.
using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Client;

namespace Microsoft.Crm.Sdk.Samples
{
    /// <summary>
    /// Demonstrates how to programmatically work with Activity Party records.</summary>
    /// <remarks>
    /// At run-time, you will be given the option to delete all the
    /// database records created by this program.</remarks>
    public class WorkingWithActivityParties
    {
        #region Class Level Members

        private Guid[] _contactIds = new Guid[3];
        private Dictionary<Guid, String> _recordIds = new Dictionary<Guid, String>();
        private OrganizationServiceProxy _serviceProxy;

        #endregion Class Level Members

        #region How To Sample Code
        /// <summary>
        /// This method first connects to the Organization service. Afterwards,
        /// activity party records are created and associated with an activity.
        /// </summary>
        /// <param name="serverConfig">Contains server connection information.</param>
        /// <param name="promptforDelete">When True, the user will be prompted to delete
        /// all created entities.</param>
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

                    OrganizationServiceContext orgContext =
                        new OrganizationServiceContext(_serviceProxy);

                    // Retrieve the Contact records that we created previously.
                    List<Contact> contacts = (from c in orgContext.CreateQuery<Contact>()
                                              where c.Address1_City == "Sammamish"
                                              select new Contact
                                              {
                                                  ContactId = c.ContactId,
                                                  FirstName = c.FirstName,
                                                  LastName = c.LastName
                                              }).ToList<Contact>();
                    Console.Write("Contacts retrieved, ");

                    // Create an Activity Party record for each Contact.
                    var activityParty1 = new ActivityParty
                    {
                        PartyId = new EntityReference(Contact.EntityLogicalName,
                            contacts[0].ContactId.Value),
                    };

                    var activityParty2 = new ActivityParty
                    {
                        PartyId = new EntityReference(Contact.EntityLogicalName,
                            contacts[1].ContactId.Value),
                    };

                    var activityParty3 = new ActivityParty
                    {
                        PartyId = new EntityReference(Contact.EntityLogicalName,
                            contacts[2].ContactId.Value),
                    };

                    Console.Write("ActivityParty instances created, ");

                    // Create Letter Activity and set From and To fields to the
                    // respective Activity Party entities.
                    var letter = new Letter
                    {
                        RegardingObjectId = new EntityReference(Contact.EntityLogicalName,
                            contacts[2].ContactId.Value),
                        Subject = "Sample Letter Activity",
                        ScheduledEnd = DateTime.Now + TimeSpan.FromDays(5),
                        Description = @"Greetings, Mr. Andreshak,

This is a sample letter activity as part of the Microsoft Dynamics CRM SDK.

Sincerely,
Mary Kay Andersen

cc: Denise Smith",
                        From = new ActivityParty[] { activityParty1 },
                        To = new ActivityParty[] { activityParty3, activityParty2 }
                    };
                    orgContext.AddObject(letter);
                    orgContext.SaveChanges();

                    Console.WriteLine("and Letter Activity created.");

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

        /// <summary>
        /// Creates any entity records that this sample requires.
        /// </summary>
        public void CreateRequiredRecords()
        {
            // Create 3 Contact records to use in the Run() method.
            Contact contact1 = new Contact()
            {
                FirstName = "Mary Kay",
                LastName = "Andersen",
                Address1_Line1 = "23 Market St.",
                Address1_City = "Sammamish",
                Address1_StateOrProvince = "MT",
                Address1_PostalCode = "99999",
                Telephone1 = "12345678",
                EMailAddress1 = "marykay@contoso.com"
            };
            _contactIds[0] = _serviceProxy.Create(contact1);

            Contact contact2 = new Contact()
            {
                FirstName = "Joe",
                LastName = "Andreshak",
                Address1_Line1 = "23 Market St.",
                Address1_City = "Sammamish",
                Address1_StateOrProvince = "MT",
                Address1_PostalCode = "99999",
                Telephone1 = "12345678",
                EMailAddress1 = "joe@contoso.com"
            };
            _contactIds[1] = _serviceProxy.Create(contact2);

            Contact contact3 = new Contact()
            {
                FirstName = "Denise",
                LastName = "Smith",
                Address1_Line1 = "23 Market St.",
                Address1_City = "Sammamish",
                Address1_StateOrProvince = "MT",
                Address1_PostalCode = "99999",
                Telephone1 = "12345678",
                EMailAddress1 = "denise@contoso.com"
            };
            _contactIds[2] = _serviceProxy.Create(contact3);

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
                foreach (Guid contactId in _contactIds)
                {
                    _serviceProxy.Delete(Contact.EntityLogicalName, contactId);
                }
                Console.WriteLine("Entity record(s) have been deleted.");
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

                WorkingWithActivityParties app = new WorkingWithActivityParties();
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

// </snippetworkingwithactivityparties>