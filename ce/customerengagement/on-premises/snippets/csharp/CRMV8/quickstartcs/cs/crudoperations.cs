// <snippetcrudoperations>


using System;
using System.ServiceModel;
using System.IdentityModel.Tokens;
using System.ServiceModel.Security;

// These namespaces are found in the Microsoft.Xrm.Sdk.dll and 
// Microsoft.Crm.Sdk.Proxy.dll assemblies.
using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Query;
using Microsoft.Xrm.Sdk.Client;
using Microsoft.Crm.Sdk.Messages;

namespace Microsoft.Crm.Sdk.Samples
{
    /// <summary>
    /// Demonstrates how to perform create, retrieve, update, and delete entity
    /// record operations.</summary>
    /// <remarks>
    /// At run-time, you will be given the option to delete all the
    /// entity records created by this program.</remarks>
    public class CRUDOperations
    {
        static public void Main(string[] args)
        {
            // The connection to the Organization web service.
            OrganizationServiceProxy serviceProxy = null;

            try
            {
                // Obtain the target organization's web address and client logon credentials
                // from the user by using a helper class.
                ServerConnection serverConnect = new ServerConnection();
                ServerConnection.Configuration config = serverConnect.GetServerConfiguration();

                // Establish an authenticated connection to the Organization web service. 
                serviceProxy = new OrganizationServiceProxy(config.OrganizationUri, config.HomeRealmUri,
                                                            config.Credentials, config.DeviceCredentials);

                CRUDOperations app = new CRUDOperations();

                // Create any records that must exist in the database. These record references are
                // stored in a collection so the records can be deleted later.
                EntityReferenceCollection records =
                    app.CreateRequiredEntityRecords(serviceProxy);

                // Perform the primary operation of this sample.
                app.Run(serviceProxy, records);

                // Delete all remaining records that were created by this sample.
                app.DeleteEntityRecords(serviceProxy, records, true);
            }

            // Some exceptions to consider catching.
            catch (FaultException<Microsoft.Xrm.Sdk.OrganizationServiceFault> e) { HandleException(e); }
            catch (TimeoutException e) { HandleException(e); }
            catch (SecurityTokenValidationException e) { HandleException(e); }
            catch (ExpiredSecurityTokenException e) { HandleException(e); }
            catch (MessageSecurityException e) { HandleException(e); }
            catch (SecurityNegotiationException e) { HandleException(e); }
            catch (SecurityAccessDeniedException e) { HandleException(e); }
            catch (Exception e) { HandleException(e); }

            finally
            {
                // Always dispose the service object to close the service connection and free resources.
                if (serviceProxy != null) serviceProxy.Dispose();

                Console.WriteLine("Press <Enter> to exit.");
                Console.ReadLine();
            }
        }

        /// <summary>
        /// This method performs entity create, retrieve, and update operations.
        /// The delete operation is handled in the DeleteRequiredrecords() method.
        /// </summary>
        /// <param name="serviceProxy">An established connection to the Organization web service.</param>
        /// <param name="records">A collection of entity records created by this sample.</param>
        public void Run(OrganizationServiceProxy serviceProxy, EntityReferenceCollection records)
        {
            // Enable early-bound entity types. This enables use of IntelliSense in Visual Studio
            // and avoids spelling errors in attribute names when using the Entity property bag.
            serviceProxy.EnableProxyTypes();

            // Here we will use the interface instead of the proxy object.
            IOrganizationService service = (IOrganizationService)serviceProxy;

            // Display information about the logged on user.
            Guid userid = ((WhoAmIResponse)service.Execute(new WhoAmIRequest())).UserId;
            SystemUser systemUser = (SystemUser)service.Retrieve("systemuser", userid,
                new ColumnSet(new string[] { "firstname", "lastname" }));
            Console.WriteLine("Logged on user is {0} {1}.", systemUser.FirstName, systemUser.LastName);

            // Retrieve the version of Microsoft Dynamics CRM.
            RetrieveVersionRequest versionRequest = new RetrieveVersionRequest();
            RetrieveVersionResponse versionResponse =
                (RetrieveVersionResponse)service.Execute(versionRequest);
            Console.WriteLine("Microsoft Dynamics CRM version {0}.", versionResponse.Version);

            // Instantiate an account object. Note the use of the option set enumerations defined
            // in OptionSets.cs.
            Account account = new Account { Name = "Fourth Coffee" };
            account.AccountCategoryCode = new OptionSetValue((int)AccountAccountCategoryCode.PreferredCustomer);
            account.CustomerTypeCode = new OptionSetValue((int)AccountCustomerTypeCode.Investor);

            // Create an account record named Fourth Coffee.
            // Save the record reference so we can delete it during cleanup later.
            Guid accountId = service.Create(account);
            var eref = new EntityReference(Account.EntityLogicalName, accountId);
            eref.Name = account.Name;
            records.Add(eref);

            Console.Write("{0} {1} created, ", account.LogicalName, account.Name);

            // Retrieve the account containing several of its attributes. This results in
            // better performance compared to retrieving all attributes.
            ColumnSet cols = new ColumnSet(
                new String[] { "name", "address1_postalcode", "lastusedincampaign" });

            Account retrievedAccount = (Account)service.Retrieve("account", accountId, cols);
            Console.Write("retrieved, ");

            // Update the postal code attribute.
            retrievedAccount.Address1_PostalCode = "98052";

            // There is no address 2 postal code needed.
            retrievedAccount.Address2_PostalCode = null;

            // Shows use of a Money value.
            retrievedAccount.Revenue = new Money(5000000);

            // Shows use of a Boolean value.
            retrievedAccount.CreditOnHold = false;

            // Update the account record.
            service.Update(retrievedAccount);
            Console.WriteLine("and updated.");
        }

        /// <summary>
        /// Create any entity records that the Run() method requires.
        /// </summary>
        public EntityReferenceCollection CreateRequiredEntityRecords(OrganizationServiceProxy service)
        {
            // For this sample, all required entity records are created in the Run() method.
            return new EntityReferenceCollection();
        }

        /// <summary>
        /// Delete all remaining entity records that were created by this sample.
        /// <param name="prompt">When true, the user is prompted whether 
        /// the records created in this sample should be deleted; otherwise, false.</param>
        /// </summary>
        public void DeleteEntityRecords(OrganizationServiceProxy service,
                                        EntityReferenceCollection records, bool prompt)
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
                while (records.Count > 0)
                {
                    EntityReference entityRef = records[records.Count - 1];
                    Console.WriteLine("Deleting {0} '{1}' ...", entityRef.LogicalName, entityRef.Name);
                    service.Delete(entityRef.LogicalName, entityRef.Id);
                    records.Remove(entityRef);
                }

                Console.WriteLine("Entity records have been deleted.");
            }
        }

        /// Handle a thrown exception.
        /// </summary>
        /// <param name="ex">An exception.</param>
        private static void HandleException(Exception e)
        {
            // Display the details of the exception.
            Console.WriteLine("\n" + e.Message);
            Console.WriteLine(e.StackTrace);

            if (e.InnerException != null) HandleException(e.InnerException);
        }
    }
}

// </snippetcrudoperations>