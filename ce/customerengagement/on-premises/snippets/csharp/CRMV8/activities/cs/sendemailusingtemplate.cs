// <snippetsendemailusingtemplate>


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
    /// Send an e-mail using a template.
    /// </summary>
    /// <remarks>This sample requires that the user account running the program have
    /// a primary e-mail address defined in Microsoft Dynamics CRM.</remarks>
    public class SendEmailUsingTemplate
    {
        #region Class Level Members

        /// <summary>
        /// Stores the organization service proxy.
        /// </summary>
        private OrganizationServiceProxy _serviceProxy;

        // Define the IDs needed for this sample.
        private Guid _emailId;
        private Guid _contactId;
        private Guid _userId;
        private Guid _templateId;

        #endregion Class Level Members

        #region How To Sample Code
        /// <summary>
        /// Send an e-mail using a template.
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

                    // Call the method to create any data that this sample requires.
                    CreateRequiredRecords();


                    // Create the 'From:' activity party for the email
                    ActivityParty fromParty = new ActivityParty
                    {
                        PartyId = new EntityReference(SystemUser.EntityLogicalName, _userId)
                    };

                    // Create the 'To:' activity party for the email
                    ActivityParty toParty = new ActivityParty
                    {
                        PartyId = new EntityReference(Contact.EntityLogicalName, _contactId)
                    };

                    Console.WriteLine("Created activity parties.");

                    // Create an e-mail message.
                    Email email = new Email
                    {
                        To = new ActivityParty[] { toParty },
                        From = new ActivityParty[] { fromParty },
                        Subject = "SDK Sample e-mail",
                        Description = "SDK Sample for SendEmailFromTemplate Message.",
                        DirectionCode = true
                    };

                    //Create a query expression to get one of Email Template of type "contact"

                    QueryExpression queryBuildInTemplates = new QueryExpression{
                        EntityName = "template",
                        ColumnSet = new ColumnSet("templateid", "templatetypecode"),
                        Criteria = new FilterExpression()
                    };
                    queryBuildInTemplates.Criteria.AddCondition("templatetypecode",
                        ConditionOperator.Equal, "contact");
                    EntityCollection templateEntityCollection = _serviceProxy.RetrieveMultiple(queryBuildInTemplates);

                    if (templateEntityCollection.Entities.Count > 0) 
                    {
                        _templateId = (Guid)templateEntityCollection.Entities[0].Attributes["templateid"];
                    }
                    else
                    {
                        throw new ArgumentException("Standard Email Templates are missing");
                    }             

                    // Create the request
                    SendEmailFromTemplateRequest emailUsingTemplateReq = new SendEmailFromTemplateRequest
                    {
                        Target = email,

                        // Use a built-in Email Template of type "contact".
                        TemplateId = _templateId,

                        // The regarding Id is required, and must be of the same type as the Email Template.
                        RegardingId = _contactId,
                        RegardingType = Contact.EntityLogicalName
                    };

                    SendEmailFromTemplateResponse emailUsingTemplateResp = (SendEmailFromTemplateResponse)_serviceProxy.Execute(emailUsingTemplateReq);

                    // Verify that the e-mail has been created
                    _emailId = emailUsingTemplateResp.Id;
                    if (!_emailId.Equals(Guid.Empty))
                    {
                        Console.WriteLine("Successfully sent an e-mail message using the template.");
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
        /// </summary>
        public void CreateRequiredRecords()
        {
            // Create a contact to send an email to (To: field)
            Contact emailContact = new Contact
            {
                FirstName = "David",
                LastName = "Pelton",
                EMailAddress1 = "david@contoso.com",
                DoNotEMail = false
            };
            _contactId = _serviceProxy.Create(emailContact);
            Console.WriteLine("Created a sample contact.");

            // Get a system user to send the email (From: field)
            WhoAmIRequest systemUserRequest = new WhoAmIRequest();
            WhoAmIResponse systemUserResponse = (WhoAmIResponse)_serviceProxy.Execute(systemUserRequest);
            _userId = systemUserResponse.UserId;
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
                _serviceProxy.Delete(Email.EntityLogicalName, _emailId);
                _serviceProxy.Delete(Contact.EntityLogicalName, _contactId); ;

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

                SendEmailUsingTemplate app = new SendEmailUsingTemplate();
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

// </snippetsendemailusingtemplate>