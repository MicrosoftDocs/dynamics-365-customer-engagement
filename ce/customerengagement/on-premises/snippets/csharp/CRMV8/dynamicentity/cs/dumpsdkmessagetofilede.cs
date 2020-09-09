// <snippetdumpsdkmessagetofilede>


using System;
using System.ServiceModel;
using System.ServiceModel.Channels;
using System.ServiceModel.Description;
using System.IO;
using System.Xml;

// These namespaces are found in the Microsoft.Xrm.Sdk.dll assembly
// found in the SDK\bin folder.
using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Client;
using Microsoft.Xrm.Sdk.Query;
using Microsoft.Xrm.Sdk.Discovery;

// This namespace is found in Microsoft.Crm.Sdk.Proxy.dll assembly
// found in the SDK\bin folder.
using Microsoft.Crm.Sdk;


namespace Microsoft.Crm.Sdk.Samples
{
    /// <summary>
    /// Demonstrates how to assign a queue to a team.
    /// If you want to run this sample repeatedly, you have the option to 
    /// delete all the records created at the end of execution.
    /// </summary>
    public class DumpSdkMessageToFileDE
    {
        #region Class Level Members
        
        /// <summary>
        /// Stores the organization service proxy.
        /// </summary>
        private OrganizationServiceProxy _serviceProxy;
        private IOrganizationService _service;

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
        /// <param name="promptForDelete">When True, the user will be prompted to delete
        /// all created entities.</param>
        public void Run(ServerConnection.Configuration serverConfig, bool promptForDelete)
        {
            try
            {

                // Connect to the Organization service. 
                // The using statement assures that the service proxy will be properly disposed.
                using (_serviceProxy = new OrganizationServiceProxy(serverConfig.OrganizationUri, serverConfig.HomeRealmUri,serverConfig.Credentials, serverConfig.DeviceCredentials))
                {
                    _service = (IOrganizationService)_serviceProxy;

                    // Retrieve all SDK Message Records.
                    QueryExpression sdkMessageQuery = new QueryExpression
                    {
                        EntityName = "sdkmessage",
                        ColumnSet = new ColumnSet("categoryname",
                            "name", "isprivate", "availability", "customizationlevel",
                            "expand", "template", "sdkmessageid"),
                        //Criteria = new FilterExpression(),
                    };

                    EntityCollection sdkMessages = _service.RetrieveMultiple(sdkMessageQuery);

                    // Write out SDK messages to an XML file.
                    // Create an instance of StreamWriter to write text to a file.
                    // The using statement also closes the StreamWriter.

                    String filename = "sdkmessages.xml";
                    using (StreamWriter sw = new StreamWriter(filename))
                    {
                        // Create Xml Writer.
                        XmlTextWriter metadataWriter = new XmlTextWriter(sw);

                        // Start Xml File.
                        metadataWriter.WriteStartDocument();

                        // Metadata Xml Node.
                        metadataWriter.WriteStartElement("Messages");

                        for (int j = 0; j < sdkMessages.Entities.Count; j++)
                        {

                            Entity currentRecord = sdkMessages[j];

                            metadataWriter.WriteStartElement("Message");

                            // Write the message information.
                            metadataWriter.WriteElementString("message-name",
                                (String)currentRecord.Attributes["name"]);
                            metadataWriter.WriteElementString("categoryname",
                                (String)currentRecord.Attributes["categoryname"]);
                            if ((bool)currentRecord.Attributes["isprivate"])
                                metadataWriter.WriteElementString("isprivate", "Yes");
                            metadataWriter.WriteElementString("message-availability",
                                currentRecord.Attributes["availability"].ToString());
                            if ((bool)currentRecord.Attributes["expand"])
                                metadataWriter.WriteElementString("expand", "Yes");
                            if ((bool)currentRecord.Attributes["template"])
                                metadataWriter.WriteElementString("template", "Yes");


                            #region filters

                            // Retrieve all SDK Message filter records for that entity.
                            QueryByAttribute sdkMessageFilterQuery = new QueryByAttribute
                            {
                                EntityName = "sdkmessagefilter",
                                ColumnSet = new ColumnSet(
                                    "iscustomprocessingstepallowed", "availability",
                                    "primaryobjecttypecode", "secondaryobjecttypecode"),
                            };
                            sdkMessageFilterQuery.AddAttributeValue("sdkmessageid",
                                currentRecord.Attributes["sdkmessageid"]);
                            EntityCollection sdkFilters = _service.RetrieveMultiple(
                                sdkMessageFilterQuery);
                            metadataWriter.WriteStartElement("Filters");

                            for (int i = 0; i < sdkFilters.Entities.Count; i++)
                            {

                                Entity currentFilter = sdkFilters[i];

                                metadataWriter.WriteStartElement("Filter");

                                // Write the message information.
                                metadataWriter.WriteElementString("filter-availability",
                                    currentFilter.Attributes["availability"].ToString());
                                metadataWriter.WriteElementString("primaryobjecttypecode",
                                    currentFilter.Attributes["primaryobjecttypecode"].ToString());
                                metadataWriter.WriteElementString("secondaryobjecttypecode",
                                    currentFilter.Attributes["secondaryobjecttypecode"].ToString());
                                metadataWriter.WriteEndElement();

                            }
                            metadataWriter.WriteEndElement();


                            #endregion filters

                            metadataWriter.WriteEndElement();
                        }


                        // End Metadata Xml Node
                        metadataWriter.WriteEndElement();
                        metadataWriter.WriteEndDocument();

                        // Close xml writer.
                        metadataWriter.Close();
                    }


                    Console.WriteLine("Retrieved all SDK messages.");



                    // There are no entity records to delete.
                    //DeleteRequiredRecords(promptForDelete);
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


            return;
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
                Console.WriteLine("\nDo you want these entity records deleted? (y/n) [y]: ");
                String answer = Console.ReadLine();

                deleteRecords = (answer.StartsWith("y") || answer.StartsWith("Y") || answer == String.Empty);
            }

            if (deleteRecords)
            {

                Console.WriteLine("No entity records need to be deleted.");

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

                DumpSdkMessageToFileDE app = new DumpSdkMessageToFileDE();
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

// </snippetdumpsdkmessagetofilede>