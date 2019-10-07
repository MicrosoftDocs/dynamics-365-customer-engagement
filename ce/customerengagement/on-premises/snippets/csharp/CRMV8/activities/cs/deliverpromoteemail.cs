// <snippetdeliverpromoteemail>


using System;
using System.ServiceModel;
using System.ServiceModel.Description;
using System.Text;

// These namespaces are found in the Microsoft.Xrm.Sdk.dll assembly
// found in the SDK\bin folder.
using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Query;
using Microsoft.Xrm.Sdk.Discovery;
using Microsoft.Xrm.Sdk.Messages;
using Microsoft.Xrm.Sdk.Client;


// This namespace is found in Microsoft.Crm.Sdk.Proxy.dll assembly
// found in the SDK\bin folder.
using Microsoft.Crm.Sdk.Messages;

namespace Microsoft.Crm.Sdk.Samples
{
    /// <summary>
    /// Create an e-mail activity instance from the specified e-mail message.
    /// </summary>
    /// <remarks>This sample requires that the user account running the program have
    /// a primary e-mail address defined in Microsoft Dynamics CRM.</remarks>
    public class DeliverPromoteEmail
    {
        #region Class Level Members

        /// <summary>
        /// Stores the organization service proxy.
        /// </summary>
        private OrganizationServiceProxy _serviceProxy;

        // Define the IDs needed for this sample.
        private Guid _contactId;
        private Guid _emailId;

        #endregion Class Level Members

        #region How To Sample Code
        /// <summary>
        /// Create an e-mail activity instance from the specified e-mail message.
        /// <param name="serverConfig">Contains server connection information.</param>
        /// <param name="promptforDelete">When True, the user will be prompted to delete all
        /// created entities.</param>
        /// </summary>
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
                    
                    // Create a contact to send an email to (To: field)
                    Contact emailContact = new Contact()
                    {
                        FirstName = "Lisa",
                        LastName = "Andrews",
                        EMailAddress1 = "lisa@contoso.com"
                    };
                    _contactId = _serviceProxy.Create(emailContact);
                    Console.WriteLine("Created a sample contact.");

                    // Get a system user to send the email (From: field)
                    WhoAmIRequest systemUserRequest = new WhoAmIRequest();
                    WhoAmIResponse systemUserResponse = (WhoAmIResponse)_serviceProxy.Execute(systemUserRequest);

                    ColumnSet cols = new ColumnSet("internalemailaddress");
                    SystemUser emailSender = (SystemUser)_serviceProxy.Retrieve(SystemUser.EntityLogicalName, systemUserResponse.UserId, cols);


                    // Create the request.
                    DeliverPromoteEmailRequest deliverEmailRequest = new DeliverPromoteEmailRequest
                    {
                        Subject = "SDK Sample Email",
                        To = emailContact.EMailAddress1,
                        From = emailSender.InternalEMailAddress,
                        Bcc = String.Empty,
                        Cc = String.Empty,
                        Importance = "high",
                        Body = "This message will create an email activity.",
                        MessageId = Guid.NewGuid().ToString(),
                        SubmittedBy = "",
                        ReceivedOn = DateTime.Now
                    };                    

                    // We won't attach a file to the email, but the Attachments property is required.
                    deliverEmailRequest.Attachments = new EntityCollection(new ActivityMimeAttachment[0]);
                    deliverEmailRequest.Attachments.EntityName = ActivityMimeAttachment.EntityLogicalName;                    

                    // Execute the request.
                    DeliverPromoteEmailResponse deliverEmailResponse = (DeliverPromoteEmailResponse)_serviceProxy.Execute(deliverEmailRequest);

                    // Verify the success.
                    
                    // Define an anonymous type to define the possible values for
                    // email status
                    var EmailStatus = new
                    {
                        Draft = 1,
                        Completed = 2,
                        Sent = 3,
                        Received = 3,
                        Canceled = 5,
                        PendingSend = 6,
                        Sending = 7,
                        Failed = 8,
                    };

                    // Query for the delivered email, and verify the status code is "Sent".
                    ColumnSet deliveredMailColumns = new ColumnSet("statuscode");
                    Email deliveredEmail = (Email)_serviceProxy.Retrieve(Email.EntityLogicalName, deliverEmailResponse.EmailId, deliveredMailColumns);

                    _emailId = deliveredEmail.ActivityId.Value;
                    
                    if (deliveredEmail.StatusCode.Value == EmailStatus.Sent)
                    {
                        Console.WriteLine("Successfully created and delivered the e-mail message.");
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
        /// Deletes the custom entity record that was created for this sample.
        /// <param name="prompt">Indicates whether to prompt the user 
        /// to delete the entity created in this sample.</param>
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
                /// Delete the sent emails 
                _serviceProxy.Delete(Email.EntityLogicalName, _emailId);

                // Delete the contacts created for emails
                _serviceProxy.Delete(Contact.EntityLogicalName, _contactId);                

                Console.WriteLine("Entity records have been deleted.");
            }
        }

        #endregion How To Sample Code

        #region Main
        /// <summary>
        /// Main. Runs the sample and provides error output.
        /// <param name="args">Array of arguments to Main method.</param>
        /// </summary>
        static public void Main(string[] args)
        {
            try
            {
                // Obtain the target organization's Web address and client logon 
                // credentials from the user.
                ServerConnection serverConnect = new ServerConnection();
                ServerConnection.Configuration config = serverConnect.GetServerConfiguration();

                DeliverPromoteEmail app = new DeliverPromoteEmail();
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

// </snippetdeliverpromoteemail>