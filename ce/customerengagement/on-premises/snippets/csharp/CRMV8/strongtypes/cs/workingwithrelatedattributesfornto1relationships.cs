// <snippetworkingwithrelatedattributesfornto1relationships>


using System;
using System.ServiceModel;

// These namespaces are found in the Microsoft.Xrm.Sdk.dll assembly
// located in the SDK\bin folder of the SDK download.
using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Client;
using Microsoft.Xrm.Sdk.Messages;

namespace Microsoft.Crm.Sdk.Samples
{
    /// <summary>
    /// Demonstrates how to do work with related attributes for N:1 
    /// relationships (Lookups) using strong types.</summary>
    /// <remarks>
    /// At run-time, you will be given the option to delete all the
    /// database records created by this program.</remarks>
    class WorkingWithRelatedAttributesforNto1Relationships
    {
        #region Class Level Members

        private Guid _leadId;
        private Guid _contactId;
        private Guid _phoneCallId;
        private OrganizationServiceProxy _serviceProxy;
        private IOrganizationService _service;

        #endregion Class Level Members

        #region How To Sample Code
        /// <summary>
        /// This method first connects to the Organization service. Afterwards,
        /// a phone call is created to a contact regarding a lead.
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

                    _service = (IOrganizationService)_serviceProxy;

                    // Create a lead.
                    Lead lead = new Lead()
                    {
                        CompanyName = "Litware, Inc."
                    };
                    _leadId = _service.Create(lead);

                    Console.Write("Lead created, ");

                    // Create a contact.
                    Contact contact = new Contact()
                    {
                        FirstName = "Dan",
                        LastName = "Park",
                        Address1_Line1 = "23 Market St.",
                        Address1_City = "Sammamish",
                        Address1_StateOrProvince = "MT",
                        Address1_PostalCode = "99999",
                        Telephone1 = "12345678",
                        EMailAddress1 = "dan@litwareinc.com"
                    };
                    _contactId = _service.Create(contact);
                    contact.ContactId = _contactId;

                    Console.Write("contact created, ");

                    // Create a blank phone call.
                    PhoneCall phoneCall = new PhoneCall();
                    _phoneCallId = _service.Create(phoneCall);

                    Console.Write("phone call created, ");

                    // Create an ActivityParty for the phone call's "to" field.
                    ActivityParty activityParty = new ActivityParty()
                    {
                        PartyId = new EntityReference
                        {
                            Id = _contactId,
                            LogicalName = Contact.EntityLogicalName,
                        },
                        ActivityId = new EntityReference
                        {
                            Id = _phoneCallId,
                            LogicalName = PhoneCall.EntityLogicalName,
                        },
                        ParticipationTypeMask = new OptionSetValue(9)
                    };

                    // Create a phone call and add the properties we are updating.
                    PhoneCall updatePhoneCall = new PhoneCall()
                    {
                        Id = _phoneCallId,
                        Subject = "Test Phone Call",
                        RegardingObjectId = new EntityReference
                        {
                            Id = _leadId,
                            LogicalName = Lead.EntityLogicalName
                        },
                        To = new ActivityParty[] { activityParty }
                    };

                    // Update the phone call.
                    UpdateRequest updateRequest = new UpdateRequest()
                    {
                        Target = updatePhoneCall
                    };
                    _service.Execute(updateRequest);

                    Console.Write("phone call updated.\n");

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

                _service.Delete(Lead.EntityLogicalName, _leadId);
                _service.Delete(Contact.EntityLogicalName, _contactId);

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

                WorkingWithRelatedAttributesforNto1Relationships app = new WorkingWithRelatedAttributesforNto1Relationships();
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

// </snippetworkingwithrelatedattributesfornto1relationships>