// <snippetcrudemailattachments>


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
    public class CRUDEmailAttachments
    {
        #region Class Level Members


        /// <summary>
        /// Stores the organization service proxy.
        /// </summary>
        private OrganizationServiceProxy _serviceProxy;

        // Define the IDs needed for this sample.
        private Guid _emailId;
        private Guid[] _emailAttachmentId = new Guid[3];
        

        #endregion Class Level Members

        #region How To Sample Code
        /// <summary>
        /// Create, Retrieve, Update and Delete an e-mail attachment.
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

                    CreateRequiredRecords();


                    // Create three e-mail attachments
                    for (int i = 0; i < 3; i++)
                    {
                        ActivityMimeAttachment _sampleAttachment = new ActivityMimeAttachment
                        {
                            ObjectId = new EntityReference(Email.EntityLogicalName, _emailId),
                            ObjectTypeCode = Email.EntityLogicalName,
                            Subject = String.Format("Sample Attachment {0}", i),
                            Body = System.Convert.ToBase64String(
                                    new ASCIIEncoding().GetBytes("Example Attachment")),
                            FileName = String.Format("ExampleAttachment{0}.txt", i)
                        };

                        _emailAttachmentId[i] = _serviceProxy.Create(_sampleAttachment);
                    }

                    Console.WriteLine("Created three e-mail attachments for the e-mail activity.");

                    // Retrieve an attachment including its id, subject, filename and body.
                    ActivityMimeAttachment _singleAttachment =
                        (ActivityMimeAttachment)_serviceProxy.Retrieve(
                                                    ActivityMimeAttachment.EntityLogicalName,
                                                    _emailAttachmentId[0],
                                                    new ColumnSet("activitymimeattachmentid",
                                                        "subject",
                                                        "filename",
                                                        "body"));

                    Console.WriteLine("Retrieved an email attachment, {0}.", _singleAttachment.FileName);

                    // Update attachment
                    _singleAttachment.FileName = "ExampleAttachmentUpdated.txt";
                    _serviceProxy.Update(_singleAttachment);

                    Console.WriteLine("Updated the retrieved e-mail attachment to {0}.", _singleAttachment.FileName);

                    // Retrieve all attachments associated with the email activity.
                    QueryExpression _attachmentQuery = new QueryExpression
                    {
                        EntityName = ActivityMimeAttachment.EntityLogicalName,
                        ColumnSet = new ColumnSet("activitymimeattachmentid"),
                        Criteria = new FilterExpression
                        {
                            Conditions =
                        {
                            new ConditionExpression
                            {
                                AttributeName = "objectid",
                                Operator = ConditionOperator.Equal,
                                Values = {_emailId}
                            },
                            new ConditionExpression
                            {
                                AttributeName = "objecttypecode",
                                Operator = ConditionOperator.Equal,
                                Values = {Email.EntityLogicalName}
                            }
                        }
                        }
                    };

                    EntityCollection results = _serviceProxy.RetrieveMultiple(
                        _attachmentQuery);

                    Console.WriteLine("Retrieved all the e-mail attachments.");


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
        /// Creates the email activity.
        /// </summary>
        public void CreateRequiredRecords()
        {
            // Create Email Activity
            Email email = new Email
            {
                Subject = "This is an example email",
                ActivityId = Guid.NewGuid()
            };

            _emailId = _serviceProxy.Create(email);

            Console.WriteLine("An e-mail activity is created.");
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
                for (int j = 0; j < 3; j++)
                {
                    _serviceProxy.Delete(ActivityMimeAttachment.EntityLogicalName, _emailAttachmentId[j]);
                }
                _serviceProxy.Delete(Email.EntityLogicalName, _emailId);                                   
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

                CRUDEmailAttachments app = new CRUDEmailAttachments();
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

// </snippetcrudemailattachments>