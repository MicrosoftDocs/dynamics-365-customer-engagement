// <snippetdumpentityinfo>


using System;
using System.Linq;
using System.Xml.Linq;
using System.ServiceModel;
using System.ServiceModel.Description;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Xml;
using System.IO;

// These namespaces are found in the Microsoft.Xrm.Sdk.dll assembly
// found in the SDK\bin folder.
using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Query;
using Microsoft.Xrm.Sdk.Metadata;
using Microsoft.Xrm.Sdk.Client;
using Microsoft.Xrm.Sdk.Messages;

// This namespace is found in Microsoft.Crm.Sdk.Proxy.dll assembly
// found in the SDK\bin folder.
using Microsoft.Crm.Sdk.Messages;

namespace Microsoft.Crm.Sdk.Samples
{
    /// <summary>
    /// This sample shows how to retrieve and write out entity metadata.
    /// </summary>
    public class DumpEntityInfo
    {
        #region Class Level Members

        /// <summary>
        /// Stores the organization service proxy.
        /// </summary>
        OrganizationServiceProxy _serviceProxy;

        // Create storage for new attributes being created
        public List<AttributeMetadata> addedAttributes;

        // Specify which language code to use in the sample. If you are using a language
        // other than US English, you will need to modify this value accordingly.
        // See https://msdn.microsoft.com/library/0h88fahh.aspx
        public const int _languageCode = 1033;

        // Define the IDs/variables needed for this sample.
        public int _insertedStatusValue;

        #endregion Class Level Members

        #region How To Sample Code
        /// <summary>
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
                using (_serviceProxy = new OrganizationServiceProxy(serverConfig.OrganizationUri, serverConfig.HomeRealmUri,serverConfig.Credentials, serverConfig.DeviceCredentials))
                {
                    // This statement is required to enable early-bound type support.
                    _serviceProxy.EnableProxyTypes();

                    RetrieveAllEntitiesRequest request = new RetrieveAllEntitiesRequest()
                    {
                        EntityFilters = EntityFilters.Entity,
                        RetrieveAsIfPublished = true
                    };

                    // Retrieve the MetaData.
                    RetrieveAllEntitiesResponse response = (RetrieveAllEntitiesResponse)_serviceProxy.Execute(request);
                    

                    // Create an instance of StreamWriter to write text to a file.
                    // The using statement also closes the StreamWriter.
		    // To view this file, right click the file and choose open with Excel. 
		    // Excel will figure out the schema and display the information in columns.

                    String filename = String.Concat("EntityInfo.xml");
                    using (StreamWriter sw = new StreamWriter(filename))
                    {
                        // Create Xml Writer.
                        XmlTextWriter metadataWriter = new XmlTextWriter(sw);

                        // Start Xml File.
                        metadataWriter.WriteStartDocument();

                        // Metadata Xml Node.
                        metadataWriter.WriteStartElement("Metadata");

                        foreach (EntityMetadata currentEntity in response.EntityMetadata)
                        {
                            //if (currentEntity.IsIntersect.Value == false)
                            if (true)
                            {
                                // Start Entity Node
                                metadataWriter.WriteStartElement("Entity");

                                // Write the Entity's Information.
                                metadataWriter.WriteElementString("EntitySchemaName", currentEntity.SchemaName);
                                metadataWriter.WriteElementString("OTC", currentEntity.ObjectTypeCode.ToString());
                                metadataWriter.WriteElementString("OwnershipType", currentEntity.OwnershipType.Value.ToString());
                                if (currentEntity.DisplayName.UserLocalizedLabel != null)
                                    metadataWriter.WriteElementString("DisplayName", currentEntity.DisplayName.UserLocalizedLabel.Label);
                                if (currentEntity.DisplayCollectionName.UserLocalizedLabel != null)
                                    metadataWriter.WriteElementString("DisplayCollectionName", currentEntity.DisplayCollectionName.UserLocalizedLabel.Label);
                                metadataWriter.WriteElementString("IntroducedVersion", currentEntity.IntroducedVersion.ToString());
                                metadataWriter.WriteElementString("AutoRouteToOwnerQueue", currentEntity.AutoRouteToOwnerQueue.ToString());
                                metadataWriter.WriteElementString("CanBeInManyToMany", currentEntity.CanBeInManyToMany.Value.ToString());
                                metadataWriter.WriteElementString("CanBePrimaryEntityInRelationship", currentEntity.CanBePrimaryEntityInRelationship.Value.ToString());
                                metadataWriter.WriteElementString("CanBeRelatedEntityInRelationship", currentEntity.CanBeRelatedEntityInRelationship.Value.ToString());
                                metadataWriter.WriteElementString("CanCreateAttributes", currentEntity.CanCreateAttributes.Value.ToString());
                                metadataWriter.WriteElementString("CanCreateCharts", currentEntity.CanCreateCharts.Value.ToString());
                                metadataWriter.WriteElementString("CanCreateForms", currentEntity.CanCreateForms.Value.ToString());
                                metadataWriter.WriteElementString("CanCreateViews", currentEntity.CanCreateViews.Value.ToString());
                                metadataWriter.WriteElementString("CanModifyAdditionalSettings", currentEntity.CanModifyAdditionalSettings.Value.ToString());
                                metadataWriter.WriteElementString("CanTriggerWorkflow", currentEntity.CanTriggerWorkflow.Value.ToString());

                                metadataWriter.WriteElementString("IsActivity", currentEntity.IsActivity.Value.ToString());
                                //metadataWriter.WriteElementString("ActivityTypeMask", currentEntity.ActivityTypeMask.ToString());

                                metadataWriter.WriteElementString("IsActivityParty", currentEntity.IsActivityParty.Value.ToString());

                                metadataWriter.WriteElementString("IsAuditEnabled", currentEntity.IsAuditEnabled.Value.ToString());
                                metadataWriter.WriteElementString("IsAvailableOffline", currentEntity.IsAvailableOffline.ToString());
                                metadataWriter.WriteElementString("IsChildEntity", currentEntity.IsChildEntity.ToString());
                                metadataWriter.WriteElementString("IsConnectionsEnabled", currentEntity.IsConnectionsEnabled.ManagedPropertyLogicalName.ToString());
                                metadataWriter.WriteElementString("IsCustomEntity", currentEntity.IsCustomEntity.Value.ToString());
                                metadataWriter.WriteElementString("IsCustomizable", currentEntity.IsCustomizable.Value.ToString());

                                metadataWriter.WriteElementString("IsDocumentManagementEnabled", currentEntity.IsDocumentManagementEnabled.Value.ToString());
                                metadataWriter.WriteElementString("IsDuplicateDetectionEnabled", currentEntity.IsDuplicateDetectionEnabled.Value.ToString());
                                if (currentEntity.IsEnabledForCharts != null)
                                    metadataWriter.WriteElementString("IsEnabledForCharts", currentEntity.IsEnabledForCharts.Value.ToString());
                                metadataWriter.WriteElementString("IsImportable", currentEntity.IsImportable.Value.ToString());
                                metadataWriter.WriteElementString("IsIntersect", currentEntity.IsIntersect.Value.ToString());

                                metadataWriter.WriteElementString("IsMailMergeEnabled", currentEntity.IsMailMergeEnabled.Value.ToString());
                                metadataWriter.WriteElementString("IsManaged", currentEntity.IsManaged.Value.ToString());
                                metadataWriter.WriteElementString("IsMappable", currentEntity.IsMappable.Value.ToString());

                                metadataWriter.WriteElementString("IsReadingPaneEnabled", currentEntity.IsReadingPaneEnabled.Value.ToString());
                                metadataWriter.WriteElementString("IsRenameable", currentEntity.IsRenameable.Value.ToString()); 
                                metadataWriter.WriteElementString("IsValidForAdvancedFind", currentEntity.IsValidForAdvancedFind.Value.ToString());
                                metadataWriter.WriteElementString("IsValidForQueue", currentEntity.IsValidForQueue.Value.ToString());
                                metadataWriter.WriteElementString("IsVisibleInMobile", currentEntity.IsVisibleInMobile.Value.ToString());

                                metadataWriter.WriteElementString("PrimaryIdAttribute", currentEntity.PrimaryIdAttribute);
                                metadataWriter.WriteElementString("PrimaryNameAttribute", currentEntity.PrimaryNameAttribute);
                                metadataWriter.WriteElementString("ReportViewName", currentEntity.ReportViewName);
                                metadataWriter.WriteElementString("RecurrenceBaseEntityLogicalName", currentEntity.RecurrenceBaseEntityLogicalName);
                                if (currentEntity.Description.UserLocalizedLabel != null)
                                    metadataWriter.WriteElementString("Description", currentEntity.Description.UserLocalizedLabel.Label);



                                // End Entity Node
                                metadataWriter.WriteEndElement();
                            }
                        }

                        // End Metadata Xml Node
                        metadataWriter.WriteEndElement();
                        metadataWriter.WriteEndDocument();

                        // Close xml writer.
                        metadataWriter.Close();
                    }




                   Console.WriteLine("Done.");

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
        /// Deletes/Reverts the record that was created/changed for this sample.
        /// <param name="prompt">Indicates whether to prompt the user to delete 
        /// the records created in this sample.</param>
        /// </summary>
        public void DeleteRequiredRecords(bool prompt)
        {
            bool deleteRecords = true;

            if (prompt)
            {
                Console.WriteLine(
                    "\nDo you want these entity records to be deleted? (y/n)");
                String answer = Console.ReadLine();

                deleteRecords = (answer.StartsWith("y") || answer.StartsWith("Y"));
            }

            if (deleteRecords)
            {
 
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

                DumpEntityInfo app = new DumpEntityInfo();
                app.Run(config, false);
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

                    FaultException<Microsoft.Xrm.Sdk.OrganizationServiceFault> fe
                        = ex.InnerException
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

// </snippetdumpentityinfo>