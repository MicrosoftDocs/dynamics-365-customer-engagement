// <snippetassociatedisassociate>


using System;
using System.ServiceModel;
using System.ServiceModel.Description;

// These namespaces are found in the Microsoft.Xrm.Sdk.dll assembly
// found in the SDK\bin folder.
using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Client;
using Microsoft.Xrm.Sdk.Query;
using Microsoft.Xrm.Sdk.Discovery;

// This namespace is found in Microsoft.Crm.Sdk.Proxy.dll assembly
// found in the SDK\bin folder.
using Microsoft.Crm.Sdk.Messages;

namespace Microsoft.Crm.Sdk.Samples
{
    /// <summary>
    /// Demonstrates how to assign a queue to a team.
    /// If you want to run this sample repeatedly, you have the option to 
    /// delete all the records created at the end of execution.
    /// </summary>
    public class AssociateDisassociate
    {
        #region Class Level Members
        
        /// <summary>
        /// Stores the organization service proxy.
        /// </summary>
        private OrganizationServiceProxy _serviceProxy;
        private IOrganizationService _service;

        // Define the IDs needed for this sample.
        public Guid _contactId;
        public Guid _account1Id;
        public Guid _account2Id;
        public Guid _account3Id;

        #endregion Class Level Members

        #region How To Sample Code
        /// <summary>
        /// Create and configure the organization service proxy.
        /// Create a team, a queue and a role.
        /// Add read queue privileges to the role.
        /// Assign the role to the team so that they can read the queue.
        /// Assign the queue to the team.
        /// Optionally delete any entity records that were created for this sample.
        /// </summary>
        /// <param name="serverConfig">Contains server connection information.</param>
        /// <param name="promptForDelete">When True, the user will be prompted to delete all
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

                    _service = (IOrganizationService)_serviceProxy;

                    // Call the method to create any data that this sample requires.
                    CreateRequiredRecords();

                    // Associate the accounts to the contact record.

                    // Create a collection of the entities that will be 
                    // associated to the contact.
                    EntityReferenceCollection relatedEntities = new EntityReferenceCollection();
                    relatedEntities.Add(new EntityReference(Account.EntityLogicalName, _account1Id));
                    relatedEntities.Add(new EntityReference(Account.EntityLogicalName, _account2Id));
                    relatedEntities.Add(new EntityReference(Account.EntityLogicalName, _account3Id));

                    // Create an object that defines the relationship between the contact and account.
                    Relationship relationship = new Relationship("account_primary_contact");


                    //Associate the contact with the 3 accounts.
                    _service.Associate(Contact.EntityLogicalName, _contactId, relationship,
                        relatedEntities);

                    Console.WriteLine("The entities have been associated.");

                    //Disassociate the records.
                    _service.Disassociate(Contact.EntityLogicalName, _contactId, relationship,
                        relatedEntities);


                    Console.WriteLine("The entities have been disassociated.");

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
        /// Create a team, a queue and a role.
        /// Add read queue privileges to the role.
        /// Assign the role to the team so that they can read the queue.
        /// Assign the queue to the team.
        /// </summary>
        public void CreateRequiredRecords()
        {            
            // Instantiate a contact entity record and set its property values.
            // See the Entity Metadata topic in the SDK documentatio to determine 
            // which attributes must be set for each entity.
            Contact setupContact = new Contact
            {
                 FirstName = "John",
                 LastName = "Doe"
            };
            _contactId = _service.Create(setupContact);
            Console.WriteLine("Created {0} {1}", setupContact.FirstName, 
                setupContact.LastName);
            
            // Instantiate an account entity record and set its property values.
            Account setupAccount1 = new Account
            {
                Name = "Example Account 1"
            };
            _account1Id = _service.Create(setupAccount1);
            Console.WriteLine("Created {0}", setupAccount1.Name);

            Account setupAccount2 = new Account
            {
                Name = "Example Account 2"
            };
            _account2Id = _service.Create(setupAccount2);
            Console.WriteLine("Created {0}", setupAccount2.Name);

            Account setupAccount3 = new Account
            {
                Name = "Example Account 3"
            };
            _account3Id = _service.Create(setupAccount3);
            Console.WriteLine("Created {0}", setupAccount3.Name);
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
                Console.WriteLine("\nDo you want these entity records deleted? (y/n)");
                String answer = Console.ReadLine();

                deleteRecords = (answer.StartsWith("y") || answer.StartsWith("Y"));
            }

            if (deleteRecords)
            {
                _service.Delete("account", _account1Id);
                _service.Delete("account", _account2Id);
                _service.Delete("account", _account3Id);

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

                AssociateDisassociate app = new AssociateDisassociate();
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

// </snippetassociatedisassociate>