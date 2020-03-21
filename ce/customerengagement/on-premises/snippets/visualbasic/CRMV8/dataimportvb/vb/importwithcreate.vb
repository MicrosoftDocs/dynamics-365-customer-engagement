' <snippetimportwithcreate>


Imports System.ServiceModel

' These namespaces are found in the Microsoft.Xrm.Sdk.dll assembly
' located in the SDK\bin folder of the SDK download.
Imports Microsoft.Xrm.Sdk
Imports Microsoft.Xrm.Sdk.Query
Imports Microsoft.Xrm.Sdk.Client
Imports Microsoft.Xrm.Sdk.Messages
Imports Microsoft.Xrm.Sdk.Metadata

' These namespaces are found in the Microsoft.Crm.Sdk.Proxy.dll assembly
' located in the SDK\bin folder of the SDK download.
Imports Microsoft.Crm.Sdk.Messages
Namespace Microsoft.Crm.Sdk.Samples
    ''' <summary>
    ''' This sample shows how to define a complex mapping for importing and then use the
    ''' Microsoft Dynamics CRM 2011 API to bulk import records with that mapping.
    ''' </summary>
    Public Class ImportWithCreate
#Region "Class Level Members"

        Private _serviceProxy As OrganizationServiceProxy
        Private _executionDate As Date

#End Region

        ''' <summary>
        ''' This method first connects to the organization service. Afterwards,
        ''' auditing is enabled on the organization, account entity, and a couple
        ''' of attributes.
        ''' </summary>
        ''' <param name="serverConfig">Contains server connection information.</param>
        ''' <param name="promptforDelete">When True, the user will be prompted to delete all
        ''' created entities.</param>
        Public Sub Run(ByVal serverConfig As ServerConnection.Configuration,
                       ByVal promptforDelete As Boolean)
            _serviceProxy = ServerConnection.GetOrganizationProxy(serverConfig)
            Using _serviceProxy
                ' This statement is required to enable early bound type support.
                _serviceProxy.EnableProxyTypes()

                ' Log the start time to ensure deletion of records created during execution.
                _executionDate = Date.Today
                ImportRecords()
                DeleteRequiredRecords(promptforDelete)
            End Using
        End Sub

        ''' <summary>
        ''' Imports records to Microsoft Dynamics CRM from the specified .csv file.
        ''' </summary>
        Public Sub ImportRecords()
            ' Create an import map.
            Dim importMap As New ImportMap() With
                {
                    .Name = "Import Map " &amp; Date.Now.Ticks.ToString(),
                    .Source = "Import Accounts.csv",
                    .Description = "Description of data being imported",
                    .EntitiesPerFile = New OptionSetValue(
                        CInt(Fix(ImportMapEntitiesPerFile.SingleEntityPerFile))),
                    .EntityState = EntityState.Created
                }
            Dim importMapId As Guid = _serviceProxy.Create(importMap)

            ' Create column mappings.

            '			#Region "Column One Mappings"
            ' Create a column mapping for a 'text' type field.
            Dim colMapping1 As New ColumnMapping() With
                {
                    .SourceAttributeName = "src_name",
                    .SourceEntityName = "Account_1",
                    .TargetAttributeName = "name",
                    .TargetEntityName = Account.EntityLogicalName,
                    .ImportMapId = New EntityReference(importMap.EntityLogicalName,
                                                       importMapId),
                    .ProcessCode = New OptionSetValue(
                        CInt(Fix(ColumnMappingProcessCode.Process)))
                }
            ' Set source properties.
            ' Set target properties.
            ' Relate this column mapping with the data map.
            ' Force this column to be processed.

            ' Create the mapping.
            Dim colMappingId1 As Guid = _serviceProxy.Create(colMapping1)
            '			#End Region

            '			#Region "Column Two Mappings"
            ' Create a column mapping for a 'lookup' type field.
            Dim colMapping2 As New ColumnMapping() With
                {
                    .SourceAttributeName = "src_parent",
                    .SourceEntityName = "Account_1",
                    .TargetAttributeName = "parentaccountid",
                    .TargetEntityName = Account.EntityLogicalName,
                    .ImportMapId = New EntityReference(importMap.EntityLogicalName, importMapId),
                    .ProcessCode = New OptionSetValue(CInt(Fix(ColumnMappingProcessCode.Process)))
                }
            ' Set source properties
            ' Set target properties
            ' Relate this column mapping with the data map
            ' Force this column to be processed

            ' Create the mapping
            Dim colMappingId2 As Guid = _serviceProxy.Create(colMapping2)

            ' Because we created a column mapping of type lookup, we need to specify lookup details in a lookupmapping.
            ' One lookupmapping will be for the parent account, the other for the current record.
            ' This lookupmapping is important because without it the current record
            ' cannot be used as the parent of another record.

            ' Create a lookup mapping to the parent account.  
            Dim parentLookupMapping As New LookUpMapping() With
                {
                    .ColumnMappingId = New EntityReference(ColumnMapping.EntityLogicalName,
                                                           colMappingId2),
                    .ProcessCode = New OptionSetValue(
                        CInt(Fix(LookUpMappingProcessCode.Process))),
                    .LookUpEntityName = Account.EntityLogicalName,
                    .LookUpAttributeName = "name",
                    .LookUpSourceCode = New OptionSetValue(
                        CInt(Fix(LookUpMappingLookUpSourceCode.System)))
                }
            ' Relate this mapping with its parent column mapping.
            ' Force this column to be processed.
            ' Set the lookup for an account entity by its name attribute.

            ' Create the lookup mapping.
            Dim parentLookupMappingId As Guid = _serviceProxy.Create(parentLookupMapping)

            ' Create a lookup on the current record's "src_name" so that this record can
            ' be used as the parent account for another record being imported.
            ' Without this lookup, no records using this account as its parent will be imported.
            Dim currentLookUpMapping As New LookUpMapping() With
                {
                    .ColumnMappingId = New EntityReference(ColumnMapping.EntityLogicalName,
                                                           colMappingId2),
                    .ProcessCode = New OptionSetValue(CInt(Fix(LookUpMappingProcessCode.Process))),
                    .LookUpAttributeName = "src_name",
                    .LookUpEntityName = "Account_1",
                    .LookUpSourceCode = New OptionSetValue(CInt(Fix(LookUpMappingLookUpSourceCode.Source)))
                }
            ' Relate this lookup with its parent column mapping.
            ' Force this column to be processed.
            ' Set the lookup for current record by its src_name attribute.

            ' Create the lookup mapping.
            Dim currentLookupMappingId As Guid = _serviceProxy.Create(currentLookUpMapping)
            '			#End Region

            '			#Region "Column Three Mappings"
            ' Create a column mapping for a 'picklist' type field.
            Dim colMapping3 As New ColumnMapping() With
                {
                    .SourceAttributeName = "src_addresstype",
                    .SourceEntityName = "Account_1",
                    .TargetAttributeName = "address1_addresstypecode",
                    .TargetEntityName = Account.EntityLogicalName,
                    .ImportMapId = New EntityReference(importMap.EntityLogicalName, importMapId),
                    .ProcessCode = New OptionSetValue(CInt(Fix(ColumnMappingProcessCode.Process)))
                }
            ' Set source properties.
            ' Set target properties.
            ' Relate this column mapping with its parent data map.
            ' Force this column to be processed.

            ' Create the mapping.
            Dim colMappingId3 As Guid = _serviceProxy.Create(colMapping3)

            ' Because we created a column mapping of type picklist, we need to specify picklist details in a picklistMapping.
            Dim pickListMapping1 As New PickListMapping() With
                {
                    .SourceValue = "bill",
                    .TargetValue = 1,
                    .ColumnMappingId = New EntityReference(ColumnMapping.EntityLogicalName,
                                                           colMappingId3),
                    .ProcessCode = New OptionSetValue(CInt(Fix(PickListMappingProcessCode.Process)))
                }
            ' Relate this column mapping with its column mapping data map.
            ' Force this column to be processed.

            ' Create the mapping
            Dim picklistMappingId1 As Guid = _serviceProxy.Create(pickListMapping1)

            ' Need a picklist mapping for every address type code expected
            Dim pickListMapping2 As New PickListMapping() With
                {
                    .SourceValue = "ship",
                    .TargetValue = 2,
                    .ColumnMappingId = New EntityReference(ColumnMapping.EntityLogicalName,
                                                           colMappingId3),
                    .ProcessCode = New OptionSetValue(CInt(Fix(PickListMappingProcessCode.Process)))
                }
            ' Relate this column mapping with its column mapping data map
            ' Force this column to be processed

            ' Create the mapping.
            Dim picklistMappingId2 As Guid = _serviceProxy.Create(pickListMapping2)
            '			#End Region

            ' Create Import.
            Dim import As New Import() With
                {
                    .ModeCode = New OptionSetValue(CInt(Fix(ImportModeCode.Create))),
                    .Name = "Importing data"
                }
            ' IsImport is obsolete; use ModeCode to declare Create or Update
            Dim importId As Guid = _serviceProxy.Create(import)

            ' Create Import File.
            Dim importFile As New ImportFile() With
                {
                    .Content = BulkImportHelper.ReadCsvFile("Import Accounts.csv"),
                    .Name = "Account record import",
                    .IsFirstRowHeader = True,
                    .ImportMapId = New EntityReference(importMap.EntityLogicalName, importMapId),
                    .UseSystemMap = False,
                    .Source = "Import Accounts.csv",
                    .SourceEntityName = "Account_1",
                    .TargetEntityName = Account.EntityLogicalName,
                    .ImportId = New EntityReference(import.EntityLogicalName, importId),
                    .EnableDuplicateDetection = False,
                    .FieldDelimiterCode = New OptionSetValue(
                        CInt(Fix(ImportFileFieldDelimiterCode.Comma))),
                    .DataDelimiterCode = New OptionSetValue(
                        CInt(Fix(ImportFileDataDelimiterCode.DoubleQuote))),
                    .ProcessCode = New OptionSetValue(
                        CInt(Fix(ImportFileProcessCode.Process)))
                }

            ' Get the current user to set as record owner.
            Dim systemUserRequest As New WhoAmIRequest()
            Dim systemUserResponse As WhoAmIResponse =
                CType(_serviceProxy.Execute(systemUserRequest), WhoAmIResponse)

            ' Set the owner ID.				
            importFile.RecordsOwnerId = New EntityReference(SystemUser.EntityLogicalName,
                                                            systemUserResponse.UserId)

            Dim importFileId As Guid = _serviceProxy.Create(importFile)

            ' Retrieve the header columns used in the import file.
            Dim headerColumnsRequest As New GetHeaderColumnsImportFileRequest() With
                {.ImportFileId = importFileId}
            Dim headerColumnsResponse As GetHeaderColumnsImportFileResponse =
                CType(_serviceProxy.Execute(headerColumnsRequest), 
                    GetHeaderColumnsImportFileResponse)

            ' Output the header columns.
            Dim columnNum As Integer = 1
            For Each headerName As String In headerColumnsResponse.Columns
                Console.WriteLine("Column[" &amp; columnNum.ToString() &amp; "] = " &amp; headerName)
                columnNum += 1
            Next headerName

            ' Parse the import file.
            Dim parseImportRequest As New ParseImportRequest() With {.ImportId = importId}
            Dim parseImportResponse As ParseImportResponse =
                CType(_serviceProxy.Execute(parseImportRequest), ParseImportResponse)
            Console.WriteLine("Waiting for Parse async job to complete")
            BulkImportHelper.WaitForAsyncJobCompletion(_serviceProxy,
                                                       parseImportResponse.AsyncOperationId)
            BulkImportHelper.ReportErrors(_serviceProxy, importFileId)

            ' Retrieve the first two distinct values for column 1 from the parse table.
            ' NOTE: You must create the parse table first using the ParseImport message.
            ' The parse table is not accessible after ImportRecordsImportResponse is called.
            Dim distinctValuesRequest As New GetDistinctValuesImportFileRequest() With
                {
                    .columnNumber = 1,
                    .ImportFileId = importFileId,
                    .pageNumber = 1,
                    .recordsPerPage = 2
                }
            Dim distinctValuesResponse As GetDistinctValuesImportFileResponse =
                CType(_serviceProxy.Execute(distinctValuesRequest), 
                    GetDistinctValuesImportFileResponse)

            ' Output the distinct values.  In this case: (column 1, row 1) and (column 1, row 2).
            Dim cellNum As Integer = 1
            For Each cellValue As String In distinctValuesResponse.Values
                Console.WriteLine("(1, " &amp; cellNum.ToString() &amp; "): " &amp; cellValue)
                Console.WriteLine(cellValue)
                cellNum += 1
            Next cellValue

            ' Retrieve data from the parse table.
            ' NOTE: You must create the parse table first using the ParseImport message.
            ' The parse table is not accessible after ImportRecordsImportResponse is called.
            Dim parsedDataRequest As New RetrieveParsedDataImportFileRequest() With
                {
                    .ImportFileId = importFileId,
                    .PagingInfo = New PagingInfo() With
                                  {
                                      .Count = 2,
                                      .PageNumber = 1,
                                      .PagingCookie = "1"
                                  }
                }
            ' Specify the number of entity instances returned per page.
            ' Specify the number of pages returned from the query.
            ' Specify a total number of entity instances returned.

            Dim parsedDataResponse As RetrieveParsedDataImportFileResponse =
                CType(_serviceProxy.Execute(parsedDataRequest), 
                    RetrieveParsedDataImportFileResponse)

            ' Output the first two rows retrieved.
            Dim rowCount As Integer = 1
            For Each rows As String() In parsedDataResponse.Values
                Dim colCount As Integer = 1
                For Each column As String In rows
                    Console.WriteLine("(" &amp; rowCount.ToString() &amp; "," _
                                      &amp; colCount.ToString() &amp; ") = " &amp; column)
                    colCount += 1
                Next column
                rowCount += 1
            Next rows

            ' Transform the import.
            Dim transformImportRequest As New TransformImportRequest() With
                {.ImportId = importId}
            Dim transformImportResponse As TransformImportResponse =
                CType(_serviceProxy.Execute(transformImportRequest), TransformImportResponse)
            Console.WriteLine("Waiting for Transform async job to complete")
            BulkImportHelper.WaitForAsyncJobCompletion(_serviceProxy,
                                                       transformImportResponse.AsyncOperationId)
            BulkImportHelper.ReportErrors(_serviceProxy, importFileId)

            ' Upload the records.
            Dim importRequest As New ImportRecordsImportRequest() With {.ImportId = importId}
            Dim importResponse As ImportRecordsImportResponse =
                CType(_serviceProxy.Execute(importRequest), ImportRecordsImportResponse)
            Console.WriteLine("Waiting for ImportRecords async job to complete")
            BulkImportHelper.WaitForAsyncJobCompletion(_serviceProxy,
                                                       importResponse.AsyncOperationId)
            BulkImportHelper.ReportErrors(_serviceProxy, importFileId)
        End Sub

        ''' <summary>
        ''' Deletes any entity records that were created for this sample.
        ''' <param name="prompt">Indicates whether to prompt the user 
        ''' to delete the records created in this sample.</param>
        ''' </summary>
        Public Sub DeleteRequiredRecords(ByVal prompt As Boolean)
            Dim toBeDeleted As Boolean = True

            If prompt Then
                ' Ask the user if the created entities should be deleted.
                Console.Write(vbLf &amp; "Do you want these entity records deleted? (y/n) [y]: ")
                Dim answer As String = Console.ReadLine()
                If answer.StartsWith("y") OrElse answer.StartsWith("Y") OrElse answer =
                    String.Empty Then
                    toBeDeleted = True
                Else
                    toBeDeleted = False
                End If
            End If

            If toBeDeleted Then
                ' Retrieve all account records created in this sample.
                Dim query As New QueryExpression() With
                    {
                        .EntityName = Account.EntityLogicalName,
                        .ColumnSet = New ColumnSet(False)
                    }
                query.Criteria().Conditions().Add(
                    New ConditionExpression("createdon", ConditionOperator.OnOrAfter, _executionDate))
                Dim accountsCreated = _serviceProxy.RetrieveMultiple(query).Entities

                ' Delete all records created in this sample.
                For Each account_temp In accountsCreated
                    _serviceProxy.Delete(Account.EntityLogicalName, account_temp.Id)
                Next account_temp

                Console.WriteLine("Entity record(s) have been deleted.")
            End If
        End Sub
#Region "Main method"

        ''' <summary>
        ''' Standard Main() method used by most SDK samples.
        ''' </summary>
        ''' <param name="args"></param>
        Public Shared Sub Main(ByVal args() As String)
            Try
                ' Obtain the target organization's web address and client logon 
                ' credentials from the user.
                Dim serverConnect As New ServerConnection()
                Dim config As ServerConnection.Configuration = serverConnect.GetServerConfiguration()

                Console.WriteLine(vbLf &amp; "Running Data Import")
                Dim app As New ImportWithCreate()
                app.Run(config, True)
                Console.WriteLine("Data Import Completed" &amp; vbLf)

            Catch ex As FaultException(Of Microsoft.Xrm.Sdk.OrganizationServiceFault)
                Console.WriteLine("The application terminated with an error.")
                Console.WriteLine("Timestamp: {0}", ex.Detail.Timestamp)
                Console.WriteLine("Code: {0}", ex.Detail.ErrorCode)
                Console.WriteLine("Message: {0}", ex.Detail.Message)
                Console.WriteLine("Trace: {0}", ex.Detail.TraceText)
                Console.WriteLine("Inner Fault: {0}", If(Nothing Is ex.Detail.InnerFault, "No Inner Fault", "Has Inner Fault"))
            Catch ex As TimeoutException
                Console.WriteLine("The application terminated with an error.")
                Console.WriteLine("Message: {0}", ex.Message)
                Console.WriteLine("Stack Trace: {0}", ex.StackTrace)
                Console.WriteLine("Inner Fault: {0}", If(Nothing Is ex.InnerException.Message, "No Inner Fault", ex.InnerException.Message))
            Catch ex As Exception
                Console.WriteLine("The application terminated with an error.")
                Console.WriteLine(ex.Message)

                ' Display the details of the inner exception.
                If ex.InnerException IsNot Nothing Then
                    Console.WriteLine(ex.InnerException.Message)

                    Dim fe As FaultException(Of Microsoft.Xrm.Sdk.OrganizationServiceFault) = _
                        TryCast(ex.InnerException, FaultException(Of Microsoft.Xrm.Sdk.OrganizationServiceFault))
                    If fe IsNot Nothing Then
                        Console.WriteLine("Timestamp: {0}", fe.Detail.Timestamp)
                        Console.WriteLine("Code: {0}", fe.Detail.ErrorCode)
                        Console.WriteLine("Message: {0}", fe.Detail.Message)
                        Console.WriteLine("Trace: {0}", fe.Detail.TraceText)
                        Console.WriteLine("Inner Fault: {0}", If(Nothing Is fe.Detail.InnerFault, "No Inner Fault", "Has Inner Fault"))
                    End If
                End If
                ' Additional exceptions to catch: SecurityTokenValidationException, ExpiredSecurityTokenException,
                ' SecurityAccessDeniedException, MessageSecurityException, and SecurityNegotiationException.

            Finally
                Console.WriteLine("Press <Enter> to exit.")
                Console.ReadLine()
            End Try
        End Sub
#End Region ' Main method
    End Class
End Namespace

' </snippetimportwithcreate>