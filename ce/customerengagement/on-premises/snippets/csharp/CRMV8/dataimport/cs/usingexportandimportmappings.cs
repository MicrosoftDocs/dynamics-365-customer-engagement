// <snippetusingexportandimportmappings>


using System;
using System.ServiceModel;
using System.Xml.Linq;
using Microsoft.Crm.Sdk.Messages;
using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Client;

namespace Microsoft.Crm.Sdk.Samples
{
    /// <summary>
    /// This sample shows how to define an import mapping, export the import mapping
    /// record and re-import a modified import mapping.
    /// </summary>
    /// <remarks>
    /// At run-time, you will be given the option to delete all the
    /// database records created by this program.
    /// </remarks>
    public class UsingExportAndImportMappings
    {
        #region Class Level Members
        private OrganizationServiceProxy _serviceProxy;
        private Guid? _importMapId;
        private String _mappingXml;
        private Guid? _newImportMapId;
        #endregion

        #region How To Sample Code

        /// <summary>
        /// Creates an import mapping, retrieves the xml, modifies the name,
        /// and re-imports the import mappings 
        /// </summary>
        /// <param name="serverConfig">Contains server connection information.</param>
        /// <param name="promptforDelete">When True, the user will be prompted to delete all
        /// created entities.</param>
        public void Run(ServerConnection.Configuration serverConfig,
           bool promptforDelete)
        {
            using (_serviceProxy = new OrganizationServiceProxy(serverConfig.OrganizationUri, serverConfig.HomeRealmUri,serverConfig.Credentials, serverConfig.DeviceCredentials))
            {
                // This statement is required to enable early-bound type support.
                _serviceProxy.EnableProxyTypes();

                CreateImportMapping();
                RetrieveMappingXml();
                ChangeMappingName();
                ImportMappingsByXml();

                DeleteRequiredRecords(promptforDelete);
            }
        }

        /// <summary>
        /// Creates the import mapping record. 
        /// </summary>
        private void CreateImportMapping()
        {
            // Create the import map and populate a column
            ImportMap importMap = new ImportMap()
            {
                Name = "Original Import Mapping"  + DateTime.Now.Ticks.ToString(),
                Source = "Import Accounts.csv",
                Description = "Description of data being imported",
                EntitiesPerFile =
                    new OptionSetValue((int)ImportMapEntitiesPerFile.SingleEntityPerFile),
                EntityState = EntityState.Created
            };

            _importMapId = _serviceProxy.Create(importMap);

            Console.WriteLine(String.Concat("Import map created: ", _importMapId.Value));

            #region Column One Mappings
            // Create a column mapping for a 'text' type field
            ColumnMapping colMapping1 = new ColumnMapping()
            {
                // Set source properties
                SourceAttributeName = "name",
                SourceEntityName = "Account_1",

                // Set target properties
                TargetAttributeName = "name",
                TargetEntityName = Account.EntityLogicalName,

                // Relate this column mapping with the data map
                ImportMapId =
                    new EntityReference(ImportMap.EntityLogicalName, _importMapId.Value),

                // Force this column to be processed
                ProcessCode =
                    new OptionSetValue((int)ColumnMappingProcessCode.Process)
            };

            // Create the mapping
            Guid colMappingId1 = _serviceProxy.Create(colMapping1);

            Console.WriteLine(String.Concat("Column mapping added SourceAttributeName: name",
                ", TargetAttributeName: name, TargetEntityName: account"));
            #endregion
        }
        
        /// <summary>
        /// Export the mapping that we created
        /// </summary>
        private void RetrieveMappingXml()
        {
            if (!_importMapId.HasValue)
                return;

            // Retrieve the xml for the mapping 
            var exportRequest = new ExportMappingsImportMapRequest
            {
                ImportMapId = _importMapId.Value,
                ExportIds = true,
            };

            var exportResponse = (ExportMappingsImportMapResponse)_serviceProxy
                .Execute(exportRequest);

            _mappingXml = exportResponse.MappingsXml;

            Console.WriteLine(String.Concat("Import mapping exported for ", 
                _importMapId.Value, "\nMappingsXml:\n", _mappingXml));
        }

        /// <summary>
        /// Parse the XML to change the name attribute
        /// </summary>
        private void ChangeMappingName()
        {
            if (string.IsNullOrWhiteSpace(_mappingXml))
                return;

            // Load into XElement
            var xElement = XElement.Parse(_mappingXml);

            // Get the Name attribute
            var nameAttribute = xElement.Attribute("Name");

            // Swap the name out
            if (nameAttribute != null)
            {
                string newName = "New Import Mapping" + DateTime.Now.Ticks.ToString();
                Console.WriteLine(String.Concat("\nChanging the import name\n\tfrom: ",
                    nameAttribute.Value, ",\n\tto: ", newName));

                nameAttribute.Value = newName;
                _mappingXml = xElement.ToString();
            }
        }

        /// <summary>
        /// Create a mapping from Xml
        /// </summary>
        private void ImportMappingsByXml()
        {
            if (string.IsNullOrWhiteSpace(_mappingXml))
                return;

            // Create the import mapping from the XML
            var request = new ImportMappingsImportMapRequest
            {
                MappingsXml = _mappingXml,
                
                ReplaceIds = true,
            };

            Console.WriteLine(String.Concat("\nCreating mapping based on XML:\n", 
                _mappingXml));

            var response = (ImportMappingsImportMapResponse)
                _serviceProxy.Execute(request);

            _newImportMapId = response.ImportMapId;

            Console.WriteLine(String.Concat("\nNew import mapping created: ", 
                _newImportMapId.Value));

            // Retrieve the value for validation
            var exportRequest = new ExportMappingsImportMapRequest
            {
                ImportMapId = _newImportMapId.Value,
                ExportIds = true,
            };

            var exportResponse = (ExportMappingsImportMapResponse)_serviceProxy
                .Execute(exportRequest);

            var mappingXml = exportResponse.MappingsXml;

            Console.WriteLine(String.Concat("\nValidating mapping xml for : ", 
                _newImportMapId.Value, ",\nMappingsXml:\n", mappingXml));
        }

        /// <summary>
        /// Deletes the records created by this sample
        /// </summary>
        /// <param name="prompt"></param>
        private void DeleteRequiredRecords(bool prompt)
        {
            bool toBeDeleted = true;

            if (prompt)
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
                if (_importMapId.HasValue)
                {
                    Console.WriteLine(String.Concat("Deleting import mapping: ", _importMapId.Value));
                    _serviceProxy.Delete(ImportMap.EntityLogicalName, _importMapId.Value);
                }

                if (_newImportMapId.HasValue)
                {
                    Console.WriteLine(String.Concat("Deleting import mapping: ", _newImportMapId.Value));
                    _serviceProxy.Delete(ImportMap.EntityLogicalName, _newImportMapId.Value);
                }

                Console.WriteLine("Entity records have been deleted.");
            }
        }

        #endregion

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

                var app = new UsingExportAndImportMappings();
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
        #endregion
    }
}

// </snippetusingexportandimportmappings>