// <snippetimportwithcreate>


using System;
using System.ServiceModel;
using System.Collections.Generic;
using System.Linq;

// These namespaces are found in the Microsoft.Xrm.Sdk.dll assembly
// located in the SDK\bin folder of the SDK download.
using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Query;
using Microsoft.Xrm.Sdk.Client;
using Microsoft.Xrm.Sdk.Messages;
using Microsoft.Xrm.Sdk.Metadata;

// These namespaces are found in the Microsoft.Crm.Sdk.Proxy.dll assembly
// located in the SDK\bin folder of the SDK download.
using Microsoft.Crm.Sdk.Messages;

namespace Microsoft.Crm.Sdk.Samples
{    
    /// <summary>
	/// This sample shows how to define a complex mapping for importing and then use the
    /// Microsoft Dynamics CRM 2011 API to bulk import records with that mapping.
	/// </summary>
    public class ImportWithCreate
    {
        #region Class Level Members

        private OrganizationServiceProxy _serviceProxy;
        private DateTime _executionDate;

        #endregion

        /// <summary>
        /// This method first connects to the organization service. Afterwards,
        /// auditing is enabled on the organization, account entity, and a couple
        /// of attributes.
        /// </summary>
        /// <param name="serverConfig">Contains server connection information.</param>
        /// <param name="promptforDelete">When True, the user will be prompted to delete all
        /// created entities.</param>
        public void Run(ServerConnection.Configuration serverConfig, bool promptforDelete)
        {
            using (_serviceProxy = new OrganizationServiceProxy(serverConfig.OrganizationUri, serverConfig.HomeRealmUri,serverConfig.Credentials, serverConfig.DeviceCredentials))
            {
                // This statement is required to enable early bound type support.
                _serviceProxy.EnableProxyTypes();

                // Log the start time to ensure deletion of records created during execution.
                _executionDate = DateTime.Today;
                ImportRecords();
                DeleteRequiredRecords(promptforDelete);
            }
        }

        /// <summary>
        /// Imports records to Microsoft Dynamics CRM from the specified .csv file.
        /// </summary>
        public void ImportRecords()
        {
            // Create an import map.
            ImportMap importMap = new ImportMap()
            {
                Name = "Import Map " + DateTime.Now.Ticks.ToString(),
                Source = "Import Accounts.csv",
                Description = "Description of data being imported",
                EntitiesPerFile =
                    new OptionSetValue((int)ImportMapEntitiesPerFile.SingleEntityPerFile),
                EntityState = EntityState.Created
            };
            Guid importMapId = _serviceProxy.Create(importMap);

            // Create column mappings.

            #region Column One Mappings
            // Create a column mapping for a 'text' type field.
            ColumnMapping colMapping1 = new ColumnMapping()
            {
                // Set source properties.
                SourceAttributeName = "src_name",
                SourceEntityName = "Account_1",

                // Set target properties.
                TargetAttributeName = "name",
                TargetEntityName = Account.EntityLogicalName,

                // Relate this column mapping with the data map.
                ImportMapId =
                    new EntityReference(ImportMap.EntityLogicalName, importMapId),

                // Force this column to be processed.
                ProcessCode =
                    new OptionSetValue((int)ColumnMappingProcessCode.Process)
            };

            // Create the mapping.
            Guid colMappingId1 = _serviceProxy.Create(colMapping1);
            #endregion

            #region Column Two Mappings
            // Create a column mapping for a 'lookup' type field.
            ColumnMapping colMapping2 = new ColumnMapping()
            {
                // Set source properties.
                SourceAttributeName = "src_parent",
                SourceEntityName = "Account_1",

                // Set target properties.
                TargetAttributeName = "parentaccountid",
                TargetEntityName = Account.EntityLogicalName,

                // Relate this column mapping with the data map.
                ImportMapId =
                    new EntityReference(ImportMap.EntityLogicalName, importMapId),

                // Force this column to be processed.
                ProcessCode =
                    new OptionSetValue((int)ColumnMappingProcessCode.Process),
            };

            // Create the mapping.
            Guid colMappingId2 = _serviceProxy.Create(colMapping2);

            // Because we created a column mapping of type lookup, we need to specify lookup details in a lookupmapping.
            // One lookupmapping will be for the parent account, and the other for the current record.
            // This lookupmapping is important because without it the current record
            // cannot be used as the parent of another record.

            // Create a lookup mapping to the parent account.  
            LookUpMapping parentLookupMapping = new LookUpMapping()
            {
                // Relate this mapping with its parent column mapping.
                ColumnMappingId =
                    new EntityReference(ColumnMapping.EntityLogicalName, colMappingId2),

                // Force this column to be processed.
                ProcessCode =
                    new OptionSetValue((int)LookUpMappingProcessCode.Process),

                // Set the lookup for an account entity by its name attribute.
                LookUpEntityName = Account.EntityLogicalName,
                LookUpAttributeName = "name",
                LookUpSourceCode =
                    new OptionSetValue((int)LookUpMappingLookUpSourceCode.System)
            };

            // Create the lookup mapping.
            Guid parentLookupMappingId = _serviceProxy.Create(parentLookupMapping);

            // Create a lookup on the current record's "src_name" so that this record can
            // be used as the parent account for another record being imported.
            // Without this lookup, no record using this account as its parent will be imported.
            LookUpMapping currentLookUpMapping = new LookUpMapping()
            {
                // Relate this lookup with its parent column mapping.
                ColumnMappingId =
                    new EntityReference(ColumnMapping.EntityLogicalName, colMappingId2),

                // Force this column to be processed.
                ProcessCode =
                    new OptionSetValue((int)LookUpMappingProcessCode.Process),

                // Set the lookup for the current record by its src_name attribute.
                LookUpAttributeName = "src_name",
                LookUpEntityName = "Account_1",
                LookUpSourceCode =
                    new OptionSetValue((int)LookUpMappingLookUpSourceCode.Source)
            };

            // Create the lookup mapping
            Guid currentLookupMappingId = _serviceProxy.Create(currentLookUpMapping);
            #endregion

            #region Column Three Mappings
            // Create a column mapping for a 'picklist' type field
            ColumnMapping colMapping3 = new ColumnMapping()
            {
                // Set source properties
                SourceAttributeName = "src_addresstype",
                SourceEntityName = "Account_1",

                // Set target properties
                TargetAttributeName = "address1_addresstypecode",
                TargetEntityName = Account.EntityLogicalName,

                // Relate this column mapping with its parent data map
                ImportMapId =
                    new EntityReference(ImportMap.EntityLogicalName, importMapId),

                // Force this column to be processed
                ProcessCode =
                    new OptionSetValue((int)ColumnMappingProcessCode.Process)
            };

            // Create the mapping
            Guid colMappingId3 = _serviceProxy.Create(colMapping3);

            // Because we created a column mapping of type picklist, we need to specify picklist details in a picklistMapping
            PickListMapping pickListMapping1 = new PickListMapping()
            {
                SourceValue = "bill",
                TargetValue = 1,

                // Relate this column mapping with its column mapping data map
                ColumnMappingId =
                    new EntityReference(ColumnMapping.EntityLogicalName, colMappingId3),

                // Force this column to be processed
                ProcessCode =
                    new OptionSetValue((int)PickListMappingProcessCode.Process)
            };

            // Create the mapping
            Guid picklistMappingId1 = _serviceProxy.Create(pickListMapping1);

            // Need a picklist mapping for every address type code expected
            PickListMapping pickListMapping2 = new PickListMapping()
            {
                SourceValue = "ship",
                TargetValue = 2,

                // Relate this column mapping with its column mapping data map
                ColumnMappingId =
                    new EntityReference(ColumnMapping.EntityLogicalName, colMappingId3),

                // Force this column to be processed
                ProcessCode =
                    new OptionSetValue((int)PickListMappingProcessCode.Process)
            };

            // Create the mapping
            Guid picklistMappingId2 = _serviceProxy.Create(pickListMapping2);
            #endregion

            // Create Import
            Import import = new Import()
            {
                // IsImport is obsolete; use ModeCode to declare Create or Update.
                ModeCode = new OptionSetValue((int)ImportModeCode.Create),
                Name = "Importing data"
            };
            Guid importId = _serviceProxy.Create(import);

            // Create Import File.
            ImportFile importFile = new ImportFile()
            {
                Content = BulkImportHelper.ReadCsvFile("Import Accounts.csv"), // Read contents from disk.
                Name = "Account record import",
                IsFirstRowHeader = true,
                ImportMapId = new EntityReference(ImportMap.EntityLogicalName, importMapId),
                UseSystemMap = false,
                Source = "Import Accounts.csv",
                SourceEntityName = "Account_1",
                TargetEntityName = Account.EntityLogicalName,
                ImportId = new EntityReference(Import.EntityLogicalName, importId),
                EnableDuplicateDetection = false,
                FieldDelimiterCode =
                    new OptionSetValue((int)ImportFileFieldDelimiterCode.Comma),
                DataDelimiterCode =
                    new OptionSetValue((int)ImportFileDataDelimiterCode.DoubleQuote),
                ProcessCode =
                    new OptionSetValue((int)ImportFileProcessCode.Process)
            };

            // Get the current user to set as record owner.
            WhoAmIRequest systemUserRequest = new WhoAmIRequest();
            WhoAmIResponse systemUserResponse =
                (WhoAmIResponse)_serviceProxy.Execute(systemUserRequest);

            // Set the owner ID.				
            importFile.RecordsOwnerId =
                new EntityReference(SystemUser.EntityLogicalName, systemUserResponse.UserId);

            Guid importFileId = _serviceProxy.Create(importFile);

            // Retrieve the header columns used in the import file.
            GetHeaderColumnsImportFileRequest headerColumnsRequest = new GetHeaderColumnsImportFileRequest()
            {
                ImportFileId = importFileId
            };
            GetHeaderColumnsImportFileResponse headerColumnsResponse =
                (GetHeaderColumnsImportFileResponse)_serviceProxy.Execute(headerColumnsRequest);

            // Output the header columns.
            int columnNum = 1;
            foreach (string headerName in headerColumnsResponse.Columns)
            {
                Console.WriteLine("Column[" + columnNum.ToString() + "] = " + headerName);
                columnNum++;
            }

            // Parse the import file.
            ParseImportRequest parseImportRequest = new ParseImportRequest()
            {
                ImportId = importId
            };
            ParseImportResponse parseImportResponse =
                (ParseImportResponse)_serviceProxy.Execute(parseImportRequest);
            Console.WriteLine("Waiting for Parse async job to complete");
            BulkImportHelper.WaitForAsyncJobCompletion(_serviceProxy, parseImportResponse.AsyncOperationId);
            BulkImportHelper.ReportErrors(_serviceProxy, importFileId);

            // Retrieve the first two distinct values for column 1 from the parse table.
            // NOTE: You must create the parse table first using the ParseImport message.
            // The parse table is not accessible after ImportRecordsImportResponse is called.
            GetDistinctValuesImportFileRequest distinctValuesRequest = new GetDistinctValuesImportFileRequest()
            {
                columnNumber = 1,
                ImportFileId = importFileId,
                pageNumber = 1,
                recordsPerPage = 2,
            };
            GetDistinctValuesImportFileResponse distinctValuesResponse =
                (GetDistinctValuesImportFileResponse)_serviceProxy.Execute(distinctValuesRequest);

            // Output the distinct values.  In this case: (column 1, row 1) and (column 1, row 2).
            int cellNum = 1;
            foreach (string cellValue in distinctValuesResponse.Values)
            {
                Console.WriteLine("(1, " + cellNum.ToString() + "): " + cellValue);
                Console.WriteLine(cellValue);
                cellNum++;
            }

            // Retrieve data from the parse table.
            // NOTE: You must create the parse table first using the ParseImport message.
            // The parse table is not accessible after ImportRecordsImportResponse is called.
            RetrieveParsedDataImportFileRequest parsedDataRequest = new RetrieveParsedDataImportFileRequest()
            {
                ImportFileId = importFileId,
                PagingInfo = new PagingInfo()
                {
                    // Specify the number of entity instances returned per page.
                    Count = 2,
                    // Specify the number of pages returned from the query.
                    PageNumber = 1,
                    // Specify a total number of entity instances returned.
                    PagingCookie = "1"
                }
            };

            RetrieveParsedDataImportFileResponse parsedDataResponse =
                (RetrieveParsedDataImportFileResponse)_serviceProxy.Execute(parsedDataRequest);

            // Output the first two rows retrieved.
            int rowCount = 1;
            foreach (string[] rows in parsedDataResponse.Values)
            {
                int colCount = 1;
                foreach (string column in rows)
                {
                    Console.WriteLine("(" + rowCount.ToString() + "," + colCount.ToString() + ") = " + column);
                    colCount++;
                }
                rowCount++;
            }

            // Transform the import
            TransformImportRequest transformImportRequest = new TransformImportRequest()
            {
                ImportId = importId
            };
            TransformImportResponse transformImportResponse =
                (TransformImportResponse)_serviceProxy.Execute(transformImportRequest);
            Console.WriteLine("Waiting for Transform async job to complete");
            BulkImportHelper.WaitForAsyncJobCompletion(_serviceProxy, transformImportResponse.AsyncOperationId);
            BulkImportHelper.ReportErrors(_serviceProxy, importFileId);

            // Upload the records.
            ImportRecordsImportRequest importRequest = new ImportRecordsImportRequest()
            {
                ImportId = importId
            };
            ImportRecordsImportResponse importResponse =
                (ImportRecordsImportResponse)_serviceProxy.Execute(importRequest);
            Console.WriteLine("Waiting for ImportRecords async job to complete");
            BulkImportHelper.WaitForAsyncJobCompletion(_serviceProxy, importResponse.AsyncOperationId);
            BulkImportHelper.ReportErrors(_serviceProxy, importFileId);
        }

        /// <summary>
        /// Deletes any entity records that were created for this sample.
        /// <param name="prompt">Indicates whether to prompt the user 
        /// to delete the records created in this sample.</param>
        /// </summary>
        public void DeleteRequiredRecords(bool prompt)
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
                // Retrieve all account records created in this sample.
                QueryExpression query = new QueryExpression()
                {
                    EntityName = Account.EntityLogicalName,
                    Criteria = new FilterExpression()
                    {
                        Conditions =
                        {
                            new ConditionExpression("createdon", ConditionOperator.OnOrAfter, _executionDate),
                        }
                    },
                    ColumnSet = new ColumnSet(false)
                };
                var accountsCreated = _serviceProxy.RetrieveMultiple(query).Entities;

                // Delete all records created in this sample.
                foreach (var account in accountsCreated)
                {
                    _serviceProxy.Delete(Account.EntityLogicalName, account.Id);
                }

                Console.WriteLine("Entity record(s) have been deleted.");
            }
        }
        #region Main method

        /// <summary>
        /// Standard Main() method used by most SDK samples.
        /// </summary>
        /// <param name="args"></param>
        static public void Main(string[] args)
        {
            try
            {
                // Obtain the target organization's web address and client logon 
                // credentials from the user.
                ServerConnection serverConnect = new ServerConnection();
                ServerConnection.Configuration config = serverConnect.GetServerConfiguration();

                var app = new ImportWithCreate();
                app.Run(config, true);
            }

            catch (FaultException<Microsoft.Xrm.Sdk.OrganizationServiceFault> ex)
            {
                Console.WriteLine("The application terminated with an error.");
                Console.WriteLine("Timestamp: {0}", ex.Detail.Timestamp);
                Console.WriteLine("Code: {0}", ex.Detail.ErrorCode);
                Console.WriteLine("Message: {0}", ex.Detail.Message);
                Console.WriteLine("Trace: {0}", ex.Detail.TraceText);
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
                        Console.WriteLine("Trace: {0}", fe.Detail.TraceText);
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

// </snippetimportwithcreate>