// <snippetgetemailtemplateattachments>


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
using System.Collections.Generic;


namespace Microsoft.Crm.Sdk.Samples
{

    /// <summary>
    /// Demonstrates how to retrieve email attachments associated with an email template.
    /// If you want to run this sample repeatedly, you have the option to 
    /// delete all the records created at the end of execution.
    /// </summary>
    public class GetEmailTemplateAttachments
    {
        #region Class Level Members
        /// <summary>
        /// Stores the organization service proxy.
        /// </summary>
        private OrganizationServiceProxy _serviceProxy;

        // Define the IDs needed for this sample.
        public Guid _emailTemplateId;
        public List<Guid> _templateAttachmentIds = new List<Guid>();

        #endregion Class Level Members

        #region How To Sample Code
        /// <summary>
        /// Create and configure the organization service proxy.
        /// Create an email template and several attachments.
        /// Retrieve the email attachments
        /// Optionally delete template and attachments.
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
                using (_serviceProxy = new OrganizationServiceProxy(serverConfig.OrganizationUri, serverConfig.HomeRealmUri,serverConfig.Credentials, serverConfig.DeviceCredentials))
                {
                    // This statement is required to enable early-bound type support.
                    _serviceProxy.EnableProxyTypes();

                    // Call the method to create any data that this sample requires.
                    CreateRequiredRecords();


                    //Create a query to retrieve attachments.
                    QueryExpression query = new QueryExpression
                    {
                        EntityName = ActivityMimeAttachment.EntityLogicalName,
                        ColumnSet = new ColumnSet("filename"),

                        //Define the conditions for each attachment.
                        Criteria =
                        {
                            FilterOperator = LogicalOperator.And,
                            Conditions =
                        {
                            //The ObjectTypeCode must be specified, or else the query
                            //defaults to "email" instead of "template".
                            new ConditionExpression
                            {
                                AttributeName = "objecttypecode",
                                Operator = ConditionOperator.Equal,
                                Values = {Template.EntityTypeCode}
                            },
                            //Specify which template we need.
                            new ConditionExpression
                            {
                                AttributeName = "objectid",
                                Operator = ConditionOperator.Equal,
                                Values = {_emailTemplateId}
                            }
                        }
                        }
                    };

                    //Write out the filename of each attachment retrieved.
                    foreach (ActivityMimeAttachment attachment in _serviceProxy.RetrieveMultiple(query).Entities)
                    {
                        Console.WriteLine("Retrieved attachment {0}", attachment.FileName);
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
            //Define the email template to create.
            Template emailTemplate = new Template
            {
                Title = "An example email template",
                Subject = "This is an example email.",
                IsPersonal = false,
                TemplateTypeCode = "lead",

                //1033 is the code for US English - you may need to change this value
                //depending on your locale.
                LanguageCode = 1033
               
            };

            _emailTemplateId = _serviceProxy.Create(emailTemplate);

            for (int i = 0; i < 3; i++ )
            {
                ActivityMimeAttachment attachment = new ActivityMimeAttachment
                {
                    Subject = String.Format("Attachment {0}",i),
                    FileName = String.Format("ExampleAttachment{0}.txt", i),
                    Body = "Some Text",
                    ObjectId = new EntityReference(Template.EntityLogicalName, _emailTemplateId),
                    ObjectTypeCode = Template.EntityLogicalName
                };

                _templateAttachmentIds.Add(_serviceProxy.Create(attachment));
            }

            Console.WriteLine("An email template and {0} attachments were created.", _templateAttachmentIds.Count);

            return;
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
                Console.WriteLine("\nDo you want these entity records deleted? (y/n)");
                String answer = Console.ReadLine();

                deleteRecords = (answer.StartsWith("y") || answer.StartsWith("Y"));
            }

            if (deleteRecords)
            {
                foreach(Guid attachmentId in _templateAttachmentIds)
                {
                    _serviceProxy.Delete(ActivityMimeAttachment.EntityLogicalName, attachmentId);
                }

                _serviceProxy.Delete(Template.EntityLogicalName, _emailTemplateId);

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

                GetEmailTemplateAttachments app = new GetEmailTemplateAttachments();
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

// </snippetgetemailtemplateattachments>