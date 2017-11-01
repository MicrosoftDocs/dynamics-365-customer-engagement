' <snippetusingexportandimportmappings>


Imports System
Imports System.ServiceModel
Imports System.Xml.Linq
Imports Microsoft.Crm.Sdk.Messages
Imports Microsoft.Xrm.Sdk
Imports Microsoft.Xrm.Sdk.Client

Namespace Microsoft.Crm.Sdk.Samples
	''' <summary>
	''' This sample shows how to define an import mapping, export the import mapping
	''' record and re-import a modified import mapping.
	''' </summary>
	''' <remarks>
	''' At run-time, you will be given the option to delete all the
	''' database records created by this program.
	''' </remarks>
	Public Class UsingExportAndImportMappings
		#Region "Class Level Members"
		Private _serviceProxy As OrganizationServiceProxy
		Private _importMapId? As Guid
		Private _mappingXml As String
		Private _newImportMapId? As Guid
		#End Region

		#Region "How To Sample Code"

		''' <summary>
		''' Creates an import mapping, retrieves the xml, modifies the name,
		''' and re-imports the import mappings 
		''' </summary>
		''' <param name="serverConfig">Contains server connection information.</param>
		''' <param name="promptforDelete">When True, the user will be prompted to delete all
		''' created entities.</param>
        Public Sub Run(ByVal serverConfig As ServerConnection.Configuration,
                       ByVal promptforDelete As Boolean)
            _serviceProxy = ServerConnection.GetOrganizationProxy(serverConfig)
            Using _serviceProxy
                ' This statement is required to enable early-bound type support.
                _serviceProxy.EnableProxyTypes()

                CreateImportMapping()
                RetrieveMappingXml()
                ChangeMappingName()
                ImportMappingsByXml()

                DeleteRequiredRecords(promptforDelete)
            End Using
        End Sub

		''' <summary>
		''' Creates the import mapping record. 
		''' </summary>
		Private Sub CreateImportMapping()
			' Create the import map and populate a column
            Dim importMap As New ImportMap() With
                {
                    .Name = "Original Import Mapping" &amp; Date.Now.Ticks.ToString(),
                    .Source = "Import Accounts.csv",
                    .Description = "Description of data being imported",
                    .EntitiesPerFile = New OptionSetValue(
                        CInt(Fix(ImportMapEntitiesPerFile.SingleEntityPerFile))),
                    .EntityState = EntityState.Created
                }

			_importMapId = _serviceProxy.Create(importMap)

			Console.WriteLine(String.Concat("Import map created: ", _importMapId.Value))

'			#Region "Column One Mappings"
			' Create a column mapping for a 'text' type field
            Dim colMapping1 As New ColumnMapping() With
                {
                    .SourceAttributeName = "name",
                    .SourceEntityName = "Account_1",
                    .TargetAttributeName = "name",
                    .TargetEntityName = Account.EntityLogicalName,
                    .ImportMapId = New EntityReference(importMap.EntityLogicalName,
                                                       _importMapId.Value),
                    .ProcessCode = New OptionSetValue(CInt(Fix(ColumnMappingProcessCode.Process)))
                }
				' Set source properties
				' Set target properties
				' Relate this column mapping with the data map
				' Force this column to be processed

			' Create the mapping
			Dim colMappingId1 As Guid = _serviceProxy.Create(colMapping1)

            Console.WriteLine(String.Concat("Column mapping added SourceAttributeName: name",
                                            ", TargetAttributeName: name, TargetEntityName: account"))
'			#End Region
		End Sub

		''' <summary>
		''' Export the mapping that we created
		''' </summary>
		Private Sub RetrieveMappingXml()
			If Not _importMapId.HasValue Then
				Return
			End If

			' Retrieve the xml for the mapping 
            Dim exportRequest = New ExportMappingsImportMapRequest With
                                {
                                    .ImportMapId = _importMapId.Value,
                                    .ExportIds = True
                                }

            Dim exportResponse = CType(_serviceProxy.Execute(exportRequest), 
                ExportMappingsImportMapResponse)

			_mappingXml = exportResponse.MappingsXml

            Console.WriteLine(String.Concat("Import mapping exported for ",
                                            _importMapId.Value,
                                            vbLf &amp; "MappingsXml:" &amp; vbLf,
                                            _mappingXml))
		End Sub

		''' <summary>
		''' Parse the XML to change the name attribute
		''' </summary>
		Private Sub ChangeMappingName()
			If String.IsNullOrWhiteSpace(_mappingXml) Then
				Return
			End If

			' Load into XElement
            Dim myxElement As XElement = XElement.Parse(_mappingXml)

			' Get the Name attribute
            Dim nameAttribute = myxElement.Attribute("Name")

			' Swap the name out
			If nameAttribute IsNot Nothing Then
				Dim newName As String = "New Import Mapping" &amp; Date.Now.Ticks.ToString()
                Console.WriteLine(String.Concat(vbLf &amp; "Changing the import name" &amp; vbLf &amp; vbTab &amp; "from: ",
                                                nameAttribute.Value, "," &amp; vbLf &amp; vbTab &amp; "to: ", newName))

				nameAttribute.Value = newName
                _mappingXml = myxElement.ToString()
			End If
		End Sub

		''' <summary>
		''' Create a mapping from Xml
		''' </summary>
		Private Sub ImportMappingsByXml()
			If String.IsNullOrWhiteSpace(_mappingXml) Then
				Return
			End If

            ' Create the import mapping from the XML
            Dim request = New ImportMappingsImportMapRequest With
                          {
                              .MappingsXml = _mappingXml,
                              .ReplaceIds = True
                          }

            Console.WriteLine(String.Concat(vbLf &amp; "Creating mapping based on XML:" &amp; vbLf,
                                            _mappingXml))

            Dim response = CType(_serviceProxy.Execute(request), 
                ImportMappingsImportMapResponse)

			_newImportMapId = response.ImportMapId

            Console.WriteLine(String.Concat(vbLf &amp; "New import mapping created: ",
                                            _newImportMapId.Value))

            ' Retrieve the value for validation
            Dim exportRequest = New ExportMappingsImportMapRequest With
                                {
                                    .ImportMapId = _newImportMapId.Value,
                                    .ExportIds = True
                                }

            Dim exportResponse = CType(_serviceProxy.Execute(exportRequest), 
                ExportMappingsImportMapResponse)

			Dim mappingXml = exportResponse.MappingsXml

            Console.WriteLine(String.Concat(vbLf &amp; "Validating mapping xml for : ",
                                            _newImportMapId.Value,
                                            "," &amp; vbLf &amp; "MappingsXml:" &amp; vbLf,
                                            mappingXml))
        End Sub

		''' <summary>
		''' Deletes the records created by this sample
		''' </summary>
		''' <param name="prompt"></param>
		Private Sub DeleteRequiredRecords(ByVal prompt As Boolean)
			Dim toBeDeleted As Boolean = True

			If prompt Then
				' Ask the user if the created entities should be deleted.
				Console.Write(vbLf &amp; "Do you want these entity records deleted? (y/n) [y]: ")
				Dim answer As String = Console.ReadLine()
                If answer.StartsWith("y") OrElse
                    answer.StartsWith("Y") OrElse
                    answer = String.Empty Then
                    toBeDeleted = True
                Else
                    toBeDeleted = False
                End If
			End If

			If toBeDeleted Then
				If _importMapId.HasValue Then
                    Console.WriteLine(String.Concat("Deleting import mapping: ",
                                                    _importMapId.Value))
                    _serviceProxy.Delete(ImportMap.EntityLogicalName,
                                         _importMapId.Value)
				End If

				If _newImportMapId.HasValue Then
                    Console.WriteLine(String.Concat("Deleting import mapping: ",
                                                    _newImportMapId.Value))
                    _serviceProxy.Delete(ImportMap.EntityLogicalName,
                                         _newImportMapId.Value)
				End If

				Console.WriteLine("Entity records have been deleted.")
			End If
		End Sub

		#End Region

		#Region "Main method"
		''' <summary>
		''' Standard Main() method used by most SDK samples.
		''' </summary>
		''' <param name="args"></param>
		Public Shared Sub Main(ByVal args() As String)
			Try
				' Obtain the target organization's Web address and client logon 
				' credentials from the user.
				Dim serverConnect As New ServerConnection()
                Dim config As ServerConnection.Configuration =
                    serverConnect.GetServerConfiguration()

				Dim app = New UsingExportAndImportMappings()
				app.Run(config, True)
			Catch ex As FaultException(Of Microsoft.Xrm.Sdk.OrganizationServiceFault)
				Console.WriteLine("The application terminated with an error.")
				Console.WriteLine("Timestamp: {0}", ex.Detail.Timestamp)
				Console.WriteLine("Code: {0}", ex.Detail.ErrorCode)
				Console.WriteLine("Message: {0}", ex.Detail.Message)
				Console.WriteLine("Plugin Trace: {0}", ex.Detail.TraceText)
                Console.WriteLine("Inner Fault: {0}",
                                  If(Nothing Is ex.Detail.InnerFault, "No Inner Fault", "Has Inner Fault"))
			Catch ex As System.TimeoutException
				Console.WriteLine("The application terminated with an error.")
				Console.WriteLine("Message: {0}", ex.Message)
				Console.WriteLine("Stack Trace: {0}", ex.StackTrace)
                Console.WriteLine("Inner Fault: {0}",
                                  If(Nothing Is ex.InnerException.Message, "No Inner Fault", ex.InnerException.Message))
			Catch ex As System.Exception
				Console.WriteLine("The application terminated with an error.")
				Console.WriteLine(ex.Message)

				' Display the details of the inner exception.
				If ex.InnerException IsNot Nothing Then
					Console.WriteLine(ex.InnerException.Message)

                    Dim fe As FaultException(Of Microsoft.Xrm.Sdk.OrganizationServiceFault) =
                        TryCast(ex.InnerException, 
                            FaultException(Of Microsoft.Xrm.Sdk.OrganizationServiceFault))
					If fe IsNot Nothing Then
						Console.WriteLine("Timestamp: {0}", fe.Detail.Timestamp)
						Console.WriteLine("Code: {0}", fe.Detail.ErrorCode)
						Console.WriteLine("Message: {0}", fe.Detail.Message)
						Console.WriteLine("Plugin Trace: {0}", fe.Detail.TraceText)
                        Console.WriteLine("Inner Fault: {0}",
                                          If(Nothing Is fe.Detail.InnerFault, "No Inner Fault", "Has Inner Fault"))
					End If
				End If
			' Additional exceptions to catch: SecurityTokenValidationException, ExpiredSecurityTokenException,
			' SecurityAccessDeniedException, MessageSecurityException, and SecurityNegotiationException.

			Finally
				Console.WriteLine("Press <Enter> to exit.")
				Console.ReadLine()
			End Try
		End Sub
		#End Region
	End Class
End Namespace

' </snippetusingexportandimportmappings>