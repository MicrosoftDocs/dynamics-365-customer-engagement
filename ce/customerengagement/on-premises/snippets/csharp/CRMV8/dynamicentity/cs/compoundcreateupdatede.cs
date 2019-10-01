// <snippetcompoundcreateupdatede>


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
    /// Shows how to create and use compound Create and Update statements.
    /// If you want to run this sample repeatedly, you have the option to 
    /// delete all the records created at the end of execution.
    /// </summary>
    public class CompoundCreateUpdateDE
    {
        #region Class Level Members
        /// <summary>
        /// Stores the organization service proxy.
        /// </summary>
        private OrganizationServiceProxy _serviceProxy;
        private IOrganizationService _service;

        // Define the IDs needed for this sample.
        private Guid _accountId;
        private Guid[] _letterIds;

        #endregion Class Level Members

        #region How To Sample Code
        /// <summary>
        /// Create and configure the organization service proxy.
        /// Creates an account and some associated letters with a nested operation.
        /// Updates those records with a nested operation.
        /// </summary>
        /// <param name="serverConfig">Contains server connection information.</param>
        /// <param name="promptForDelete">When True, the user will be prompted to delete
        /// all created entities.</param>
        public void Run(ServerConnection.Configuration serverConfig, bool promptForDelete)
        {
            try
            {

                // Connect to the Organization service. 
                // The using statement assures that the service proxy will be properly disposed.
                using (_serviceProxy = new OrganizationServiceProxy(serverConfig.OrganizationUri, serverConfig.HomeRealmUri,
                                                                     serverConfig.Credentials, serverConfig.DeviceCredentials))
                {
                    _service = (IOrganizationService)_serviceProxy;

                    //Define the account for which we will add letters
                    Entity accountToCreate = new Entity("account");
                    accountToCreate["name"] = "Example Account";

                    //Define the IDs of the related letters we will create
                    _letterIds = new[] { Guid.NewGuid(), Guid.NewGuid(), Guid.NewGuid() };

                    //This acts as a container for each letter we create. Note that we haven't
                    //define the relationship between the letter and account yet.

                    // Letter 1 for creation
                    Entity letter1 = new Entity("letter");
                    letter1["subject"] = "Letter 1";
                    letter1["activityid"] = _letterIds[0];

                    // Letter 2 for creation
                    Entity letter2 = new Entity("letter");
                    letter2["subject"] = "Letter 2";
                    letter2["activityid"] = _letterIds[1];

                    // Letter 3 for creation
                    Entity letter3 = new Entity("letter");
                    letter3["subject"] = "Letter 3";
                    letter3["activityid"] = _letterIds[2];

                    EntityCollection relatedLettersToCreate = new EntityCollection
                    {
                        EntityName = "letter",
                        Entities = { letter1, letter2, letter3 }
                    };

                    //Creates the reference between which relationship between Letter and
                    //Account we would like to use.
                    Relationship letterRelationship = new Relationship("Account_Letters");

                    //Adds the letters to the account under the specified relationship
                    accountToCreate.RelatedEntities.Add(letterRelationship, relatedLettersToCreate);

                    //Passes the Account (which contains the letters) 
                    _accountId = _service.Create(accountToCreate);

                    Console.WriteLine("An account and {0} letters were created.", _letterIds.Length);


                    //Now we run through many of the same steps as the above "Create" example
                    Entity accountToUpdate = new Entity("account");
                    accountToUpdate["name"] = "Example Account - Updated";
                    accountToUpdate["accountid"] = _accountId;

                    // Letter 1 for updation
                    Entity letter1Update = new Entity("letter");
                    letter1Update["subject"] = "Letter 1 - Updated";
                    letter1Update["activityid"] = _letterIds[0];

                    // Letter 2 for updation
                    Entity letter2Update = new Entity("letter");
                    letter2Update["subject"] = "Letter 2 - Updated";
                    letter2Update["activityid"] = _letterIds[1];

                    // Letter 3 for updation
                    Entity letter3Update = new Entity("letter");
                    letter3Update["subject"] = "Letter 3 - Updated";
                    letter3Update["activityid"] = _letterIds[2];

                    EntityCollection relatedLettersToUpdate = new EntityCollection
                    {
                        EntityName = "letter",
                        Entities = { letter1Update, letter2Update, letter3Update }
                    };

                    accountToUpdate.RelatedEntities.Add(letterRelationship, relatedLettersToUpdate);

                    //This will update the account as well as all of the related letters
                    _service.Update(accountToUpdate);

                    Console.WriteLine("An account and {0} letters were updated.", _letterIds.Length);


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
        /// Deletes any entity records that were created for this sample.
        /// <param name="prompt">Indicates whether to prompt the user to delete the records created in this sample.</param>
        /// </summary>
        public void DeleteRequiredRecords(bool prompt)
        {
            bool deleteRecords = true;

            if (prompt)
            {
                Console.WriteLine("\nDo you want these entity records deleted? (y/n) [y]: ");
                String answer = Console.ReadLine();

                deleteRecords = (answer.StartsWith("y") || answer.StartsWith("Y") || answer == String.Empty);
            }

            if (deleteRecords)
            {
                foreach (Guid letterId in _letterIds)
                {
                    _service.Delete("letter", letterId);
                }
                _service.Delete("account", _accountId);

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

                CompoundCreateUpdateDE app = new CompoundCreateUpdateDE();
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
        #endregion Main

    }
}

// </snippetcompoundcreateupdatede>