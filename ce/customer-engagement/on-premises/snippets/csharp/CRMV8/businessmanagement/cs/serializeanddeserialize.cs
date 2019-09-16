// <snippetserializeanddeserialize>


using System;
using System.IO;
using System.Runtime.Serialization;
using System.ServiceModel;
using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Client;
using Microsoft.Xrm.Sdk.Query;

namespace Microsoft.Crm.Sdk.Samples
{
    /// <summary>
    /// This sample shows how to serialize both early-bound and late-bound entity instances (records).  In
    /// addition, it shows how to de-serialize from XML to an early-bound entity instance.
    /// </summary>
    public class SerializeAndDeserialize
    {
        #region Class Level Members

        private OrganizationServiceProxy _serviceProxy;
        private Guid _contactId;

        #endregion Class Level Members

        #region How To Sample Code

        /// <summary>
        /// Run this sample, which shows both how to serialize late-bound and
        /// early-bound entity instances to XML and how to de-serialize them back from
        /// XML into entity instances.
        /// </summary>
        /// <param name="serverConfig"> Contains server connection information.</param>
        /// <param name="promptToDelete"> When True, the user will be prompted to delete all
        /// created entities.
        public void Run(ServerConnection.Configuration serverConfig, bool promptToDelete)
        {
            using (_serviceProxy = new OrganizationServiceProxy(serverConfig.OrganizationUri, serverConfig.HomeRealmUri,serverConfig.Credentials, serverConfig.DeviceCredentials))
            {
                // This statement is required to enable early-bound type support.
                _serviceProxy.EnableProxyTypes();

                CreateRequiredRecords();

                #region Retrieve the contact from Microsoft CRM

                // Create the column set object that indicates the fields to be retrieved.
                var columns = new ColumnSet(
                    "contactid",
                    "firstname",
                    "lastname",
                    "jobtitle");

                // Retrieve the contact from Microsoft CRM using the ID of the record that was just created.
                // The EntityLogicalName indicates the EntityType of the object being retrieved.
                var contact = (Contact)_serviceProxy.Retrieve(
                    Contact.EntityLogicalName, _contactId, columns);

                Console.WriteLine("The contact for the sample has been retrieved.");

                #endregion

                #region Serialize the contact into XML and save it

                // Serialize the contact into XML and write it to the hard drive.
                var earlyBoundSerializer = new DataContractSerializer(typeof(Contact));

                // Create a unique file name for the XML.
                String earlyboundFile = "Contact_early_" + contact.ContactId.Value.ToString("B") + ".xml";

                // Write the serialized object to a file.  The using statement will
                // ensure that the FileStream is disposed of correctly.  The FileMode
                // will ensure that the file is overwritten if it already exists.
                using (var file = new FileStream(earlyboundFile, FileMode.Create))
                {
                    // Write the XML to disk.
                    earlyBoundSerializer.WriteObject(file, contact);
                }

                Console.WriteLine(
                    "The early-bound contact instance has been serialized to a file, {0}.",
                    earlyboundFile);

                // Convert the contact to a late-bound entity instance and serialize it to disk.
                var lateboundContact = contact.ToEntity<Entity>();
                String lateboundFile = "Contact_late_" + lateboundContact.Id.ToString("B") + ".xml";

                var lateBoundSerializer = new DataContractSerializer(typeof(Entity));
                // Write the serialized object to a file.
                using (var file = new FileStream(lateboundFile, FileMode.Create))
                {
                    lateBoundSerializer.WriteObject(file, lateboundContact);
                }

                Console.WriteLine(
                    "The late-bound contact instance has been serialized to a file, {0}.",
                    lateboundFile);

                #endregion

                #region De-serialize the Microsoft CRM contact from XML

                Contact deserializedContact = null;
                using (var file = new FileStream(earlyboundFile, FileMode.Open))
                {
                    deserializedContact = (Contact)earlyBoundSerializer.ReadObject(file);
                    Console.WriteLine("The contact has been de-serialized: {0} {1}",
                        deserializedContact.FirstName, deserializedContact.LastName);
                }

                #endregion

                #region Update contact in Microsoft CRM

                // Update the contact in Microsoft CRM to prove that the de-serialization worked.
                deserializedContact.JobTitle = "Plumber";
                _serviceProxy.Update(deserializedContact);

                Console.WriteLine("The contact was updated in Microsoft CRM.");

                #endregion

                DeleteRequiredRecords(promptToDelete);
            }
        }

        /// <summary>
        /// Creates a contact which is required for running this sample.
        /// </summary>
        private void CreateRequiredRecords()
        {
            // Create a contact entity record that will be serialized into XML.
            var contactCreate = new Contact();
            contactCreate.FirstName = "Thomas";
            contactCreate.LastName = "Andersen";

            // Create the entity in Microsoft CRM and get its ID.
            _contactId = _serviceProxy.Create(contactCreate);

            Console.WriteLine("The contact for the sample has been created.");
        }

        /// <summary>
        /// Deletes the contact record that was used in the sample if the user responds in the
        /// affirmative.
        /// </summary>
        /// <param name="promptToDelete">whether or not to delete the contact</param>
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
                _serviceProxy.Delete(Contact.EntityLogicalName, _contactId);
                Console.WriteLine("The contact has been deleted.");
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

                var app = new SerializeAndDeserialize();
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

// </snippetserializeanddeserialize>