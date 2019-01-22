' <snippetmetadataquery>


Imports System.ServiceModel
Imports System.ServiceModel.Description
Imports System.IO
' These namespaces are found in the Microsoft.Xrm.Sdk.dll assembly
' located in the SDK\bin folder of the SDK download.
Imports Microsoft.Xrm.Sdk
Imports Microsoft.Xrm.Sdk.Query
Imports Microsoft.Xrm.Sdk.Client
Imports Microsoft.Crm.Sdk.Messages
Imports Microsoft.Xrm.Sdk.Messages
Imports Microsoft.Xrm.Sdk.Metadata
Imports Microsoft.Xrm.Sdk.Metadata.Query


Namespace Microsoft.Crm.Sdk.Samples
 Public Class MetadataQuerySample
  #Region "Class Level Members"

  Private _serviceProxy As OrganizationServiceProxy
  Private _service As IOrganizationService
  Private _optionLabelList As New List(Of OptionSetOption)()
  Private _customEntitySchemaName As String = "sample_SampleEntityForMetadataQuery"
  Private _customAttributeSchemaName As String = "sample_ExampleOptionSet"
  Private _userId As Guid
  Private _languageCode As Integer



  #End Region ' Class Level Members


  ''' <summary>
  ''' This method connects to the Organization _service. 
  ''' </summary>
  ''' <param name="serverConfig">Contains server connection information.</param>

  Public Sub Run(ByVal serverConfig As ServerConnection.Configuration)
   Try

	' Connect to the Organization _service. 
	' The using statement assures that the _service proxy will be properly disposed.
	_serviceProxy = ServerConnection.GetOrganizationProxy(serverConfig)
	Using _serviceProxy
	 ' This statement is required to enable early-bound type support.
	 _serviceProxy.EnableProxyTypes()

	 _service = CType(_serviceProxy, IOrganizationService)
	 _userId = (CType(_service.Execute(New WhoAmIRequest()), WhoAmIResponse)).UserId
	 _languageCode = RetrieveUserUILanguageCode(_userId)




	 ' An array SchemaName values for non-intersect, user-owned entities that should not be returned.
                    Dim excludedEntities() As String =
                        {
                            "WorkflowLog",
                            "Template",
                            "CustomerOpportunityRole",
                            "Import",
                            "UserQueryVisualization",
                            "UserEntityInstanceData",
                            "ImportLog",
                            "RecurrenceRule",
                            "QuoteClose",
                            "UserForm",
                            "SharePointDocumentLocation",
                            "Queue",
                            "DuplicateRule",
                            "OpportunityClose",
                            "Workflow",
                            "RecurringAppointmentMaster",
                            "CustomerRelationship",
                            "Annotation",
                            "SharePointSite",
                            "ImportData",
                            "ImportFile",
                            "OrderClose",
                            "Contract",
                            "BulkOperation",
                            "CampaignResponse",
                            "Connection",
                            "Report",
                            "CampaignActivity",
                            "UserEntityUISettings",
                            "IncidentResolution",
                            "GoalRollupQuery",
                            "MailMergeTemplate",
                            "Campaign",
                            "PostFollow",
                            "ImportMap",
                            "Goal",
                            "AsyncOperation",
                            "ProcessSession",
                            "UserQuery",
                            "ActivityPointer",
                            "List",
                            "ServiceAppointment"
                        }

	 'A filter expression to limit entities returned to non-intersect, user-owned entities not found in the list of excluded entities.
	 Dim EntityFilter As New MetadataFilterExpression(LogicalOperator.And)
	 EntityFilter.Conditions.Add(New MetadataConditionExpression("IsIntersect", MetadataConditionOperator.Equals, False))
	 EntityFilter.Conditions.Add(New MetadataConditionExpression("OwnershipType", MetadataConditionOperator.Equals, OwnershipTypes.UserOwned))
	 EntityFilter.Conditions.Add(New MetadataConditionExpression("SchemaName", MetadataConditionOperator.NotIn, excludedEntities))
	 Dim isVisibileInMobileTrue As New MetadataConditionExpression("IsVisibleInMobile", MetadataConditionOperator.Equals, True)
	 EntityFilter.Conditions.Add(isVisibileInMobileTrue)



	 'A properties expression to limit the properties to be included with entities
	 Dim EntityProperties As New MetadataPropertiesExpression() With {.AllProperties = False}
	 EntityProperties.PropertyNames.AddRange(New String() { "Attributes" })

	 'A condition expresson to return optionset attributes
                    Dim optionsetAttributeTypes() As MetadataConditionExpression =
                        {
                            New MetadataConditionExpression("AttributeType",
                                                            MetadataConditionOperator.Equals,
                                                            AttributeTypeCode.Picklist),
                            New MetadataConditionExpression("AttributeType",
                                                            MetadataConditionOperator.Equals,
                                                            AttributeTypeCode.State),
                            New MetadataConditionExpression("AttributeType",
                                                            MetadataConditionOperator.Equals,
                                                            AttributeTypeCode.Status),
                            New MetadataConditionExpression("AttributeType",
                                                            MetadataConditionOperator.Equals,
                                                            AttributeTypeCode.Boolean)
                        }

	 'A filter expression to apply the optionsetAttributeTypes condition expression
	 Dim AttributeFilter As New MetadataFilterExpression(LogicalOperator.Or)
	 AttributeFilter.Conditions.AddRange(optionsetAttributeTypes)

	 'A Properties expression to limit the properties to be included with attributes
	 Dim AttributeProperties As New MetadataPropertiesExpression() With {.AllProperties = False}
	 AttributeProperties.PropertyNames.Add("OptionSet")
	 AttributeProperties.PropertyNames.Add("AttributeType")



	 'A label query expression to limit the labels returned to only those for the user's preferred language
	 Dim labelQuery As New LabelQueryExpression()
	 labelQuery.FilterLanguages.Add(_languageCode)


	 'An entity query expression to combine the filter expressions and property expressions for the query.
                    Dim entityQueryExpression_Renamed As New EntityQueryExpression() With
                        {
                            .Criteria = EntityFilter,
                            .Properties = EntityProperties,
                            .AttributeQuery = New AttributeQueryExpression() With
                                              {
                                                  .Criteria = AttributeFilter,
                                                  .Properties = AttributeProperties
                                              },
                            .LabelQuery = labelQuery
                        }

	 'Retrieve the metadata for the query without a ClientVersionStamp
                    Dim initialRequest As RetrieveMetadataChangesResponse =
                        getMetadataChanges(entityQueryExpression_Renamed, Nothing, DeletedMetadataFilters.OptionSet)

	 'Add option labels to the cache and display the changes
	 addOptionLabelsToCache(initialRequest.EntityMetadata, False)
	 Dim ClientVersionStamp As String = initialRequest.ServerVersionStamp
                    Console.WriteLine("{0} option labels for {1} entities added to the cache.",
                                      _optionLabelList.Count, initialRequest.EntityMetadata.Count)
	 Console.WriteLine("")
	 Console.WriteLine("ClientVersionStamp: {0}", ClientVersionStamp)
	 Console.WriteLine("")


	 'Add new custom entity with optionset
                    Console.WriteLine("Adding a custom entity named {0} with a custom optionset attribute named : {1}",
                                      _customEntitySchemaName, _customAttributeSchemaName)
	 Console.WriteLine("")
	 addCustomEntityWithOptionSet()
	 'Publishing isn't necessary when adding a custom entity

	 'Add new option labels to the cache and display the results
	 ClientVersionStamp = updateOptionLabelList(entityQueryExpression_Renamed, ClientVersionStamp)

	 Console.WriteLine("ClientVersionStamp: {0}", ClientVersionStamp)
	 Console.WriteLine("")

	 'Add a new option to the custom optionset in the custom entity and publish the custom entity
	 Console.WriteLine("Adding an additional option to the {0} attribute options.", _customAttributeSchemaName)
	 Console.WriteLine("")
	 addOptionToCustomEntityOptionSet()
	 'It is necessary to publish updates to metadata. Create and Delete operations are published automatically.
	 publishUpdatedEntity()



	 'Add the new option label to the cache and display the results
	 ClientVersionStamp = updateOptionLabelList(entityQueryExpression_Renamed, ClientVersionStamp)

	 Console.WriteLine("ClientVersionStamp: {0}", ClientVersionStamp)
	 Console.WriteLine("")

	 Console.WriteLine("")
	 Console.WriteLine("Current Options: {0}", _optionLabelList.Count.ToString())
	 Console.WriteLine("")

	 'Delete the custom entity
	 Console.WriteLine("")
	 Console.WriteLine("Deleting the {0} custom entity", _customEntitySchemaName)
	 Console.WriteLine("")
	 deleteCustomEntityWithOptionSet()
	 'Publishing isn't necessary when deleting a custom entity     


	 'Retrieve metadata changes to remove option labels from deleted attributes and display the results
	 ClientVersionStamp = updateOptionLabelList(entityQueryExpression_Renamed, ClientVersionStamp)

	 Console.WriteLine("ClientVersionStamp: {0}", ClientVersionStamp)
	 Console.WriteLine("")

	End Using


   ' Catch any _service fault exceptions that Microsoft Dynamics CRM throws.
            Catch fe As FaultException(Of Microsoft.Xrm.Sdk.OrganizationServiceFault)
                ' You can handle an exception here or pass it back to the calling method.
                Throw
   End Try
  End Sub

        Protected Function getMetadataChanges(ByVal entityQueryExpression_Renamed As EntityQueryExpression,
                                              ByVal clientVersionStamp As String,
                                              ByVal deletedMetadataFilter As DeletedMetadataFilters) As RetrieveMetadataChangesResponse
            Dim retrieveMetadataChangesRequest_Renamed As New RetrieveMetadataChangesRequest() With
                {
                    .Query = entityQueryExpression_Renamed,
                    .ClientVersionStamp = clientVersionStamp,
                    .DeletedMetadataFilters = deletedMetadataFilter
                }

            Return CType(_service.Execute(retrieveMetadataChangesRequest_Renamed), RetrieveMetadataChangesResponse)

        End Function

        Protected Function updateOptionLabelList(ByVal entityQueryExpression_Renamed As EntityQueryExpression,
                                                 ByVal clientVersionStamp As String) As String
            'Retrieve metadata changes and add them to the cache
            Dim updateResponse As RetrieveMetadataChangesResponse
            Try
                updateResponse = getMetadataChanges(entityQueryExpression_Renamed, clientVersionStamp, DeletedMetadataFilters.OptionSet)
                addOptionLabelsToCache(updateResponse.EntityMetadata, True)
                removeOptionLabelsFromCache(updateResponse.DeletedMetadata, True)

            Catch ex As FaultException(Of Microsoft.Xrm.Sdk.OrganizationServiceFault)
                ' Check for ErrorCodes.ExpiredVersionStamp (0x80044352)
                ' Will occur when the timestamp exceeds the Organization.ExpireSubscriptionsInDays value, which is 90 by default.
                'INSTANT VB TODO TASK: There is no VB equivalent to 'unchecked' in this context:
                If ex.Detail.ErrorCode = CInt(&amp;H80044352) Then
                    'reinitialize cache
                    _optionLabelList.Clear()

                    updateResponse = getMetadataChanges(entityQueryExpression_Renamed, Nothing, DeletedMetadataFilters.OptionSet)
                    'Add them to the cache and display the changes
                    addOptionLabelsToCache(updateResponse.EntityMetadata, True)

                Else
                    Throw ex
                End If

            End Try
            Return updateResponse.ServerVersionStamp
        End Function
  Protected Sub addOptionLabelsToCache(ByVal entityMetadataCollection_Renamed As EntityMetadataCollection, ByVal showChanges As Boolean)

   Dim changes As New List(Of OptionSetOption)()

   For Each em As EntityMetadata In entityMetadataCollection_Renamed
	For Each am As AttributeMetadata In em.Attributes
	 Select Case am.AttributeType
	  Case AttributeTypeCode.Boolean
	   Dim booleanAttribute As BooleanAttributeMetadata = CType(am, BooleanAttributeMetadata)
	   'Labels will not be included if they aren't new
	   If booleanAttribute.OptionSet.FalseOption.Label.UserLocalizedLabel IsNot Nothing Then
                                changes.Add(New OptionSetOption(CType(booleanAttribute.OptionSet.MetadataId, Guid), 0,
                                                                booleanAttribute.OptionSet.FalseOption.Label.UserLocalizedLabel.Label))
	   End If
	   'Labels will not be included if they aren't new
	   If booleanAttribute.OptionSet.TrueOption.Label.UserLocalizedLabel IsNot Nothing Then
                                changes.Add(New OptionSetOption(CType(booleanAttribute.OptionSet.MetadataId, Guid), 1,
                                                                booleanAttribute.OptionSet.TrueOption.Label.UserLocalizedLabel.Label))
	   End If
	  Case Else
	   Dim optionsetAttribute As EnumAttributeMetadata = CType(am, EnumAttributeMetadata)
	   For Each [option] As OptionMetadata In optionsetAttribute.OptionSet.Options
		'Labels will not be included if they aren't new
		If [option].Label.UserLocalizedLabel IsNot Nothing Then
                                    changes.Add(New OptionSetOption(CType(optionsetAttribute.OptionSet.MetadataId, Guid),
                                                                    CInt(Fix([option].Value)), [option].Label.UserLocalizedLabel.Label))
		End If
	   Next [option]
	 End Select
	Next am
   Next em

   _optionLabelList.AddRange(changes)

   If showChanges Then

	If changes.Count > 0 Then
                    Console.WriteLine("{0} option labels for {1} entities were added to the cache.",
                                      changes.Count, entityMetadataCollection_Renamed.Count)
	 Console.WriteLine("{0} Option Labels cached", _optionLabelList.Count)
	Else
		Console.WriteLine("No option labels were added to the cache.")
	End If

   End If
  End Sub
        Protected Sub removeOptionLabelsFromCache(ByVal DeletedMetadata As DeletedMetadataCollection,
                                                  ByVal showChanges As Boolean)
            Dim optionSetOptionsToRemove As New List(Of OptionSetOption)()

            If DeletedMetadata.Keys.Contains(DeletedMetadataFilters.OptionSet) Then
                Dim optionsetmetadataids As DataCollection(Of Guid) =
                    CType(DeletedMetadata(DeletedMetadataFilters.OptionSet), 
                        DataCollection(Of Guid))
                For Each metadataid As Guid In optionsetmetadataids
                    For Each oso As OptionSetOption In _optionLabelList
                        If metadataid = oso.optionsetId Then
                            optionSetOptionsToRemove.Add(oso)
                        End If
                    Next oso
                Next metadataid
            End If
            For Each [option] As OptionSetOption In optionSetOptionsToRemove
                _optionLabelList.Remove([option])
            Next [option]
            If showChanges Then
                If optionSetOptionsToRemove.Count > 0 Then
                    Console.WriteLine("{0} Option Labels removed", optionSetOptionsToRemove.Count)
                    Console.WriteLine("{0} Total Option Labels currently cached", _optionLabelList.Count)
                    Console.WriteLine("")
                Else
                    Console.WriteLine("No Option Labels removed.")
                    Console.WriteLine("")
                End If

            End If
        End Sub

  Protected Sub addCustomEntityWithOptionSet()
   Dim primaryAttributeSchemaName As String = "sample_SampleEntityForMetadataQueryName"

            Dim createEntityRequest_Renamed As CreateEntityRequest =
                New CreateEntityRequest With
                {
                    .Entity = New EntityMetadata With
                              {
                                  .SchemaName = _customEntitySchemaName,
                                  .LogicalName = _customEntitySchemaName.ToLower(),
                                  .DisplayName = New Label("Entity for MetadataQuery Sample", _languageCode),
                                  .DisplayCollectionName = New Label("Entity for MetadataQuery Sample", _languageCode),
                                  .Description = New Label("An entity created for the MetadataQuery Sample", _languageCode),
                                  .OwnershipType = OwnershipTypes.UserOwned,
                                  .IsVisibleInMobile = New BooleanManagedProperty(True),
                                  .IsActivity = False
                              },
                    .PrimaryAttribute = New StringAttributeMetadata With
                                        {
                                            .SchemaName = primaryAttributeSchemaName,
                                            .LogicalName = primaryAttributeSchemaName.ToLower(),
                                            .RequiredLevel = New AttributeRequiredLevelManagedProperty(AttributeRequiredLevel.None),
                                            .MaxLength = 100,
                                            .Format = StringFormat.Text,
                                            .DisplayName = New Label("Entity for MetadataQuery Sample Name", _languageCode),
                                            .Description = New Label("The primary attribute for the Bank Account entity.", _languageCode)
                                        }
                }
	'Define the entity
	' Define the primary attribute for the entity
_service.Execute(createEntityRequest_Renamed)


   'PublishXmlRequest publishXmlRequest = new PublishXmlRequest { ParameterXml = String.Format("<importexportxml><entities><entity>{0}</entity></entities></importexportxml>", _customEntitySchemaName.ToLower()) };
   '_service.Execute(publishXmlRequest);

   'Add an optionset attribute

            Dim attributeOptionSet As OptionSetMetadata = New OptionSetMetadata With
                                                  {
                                                      .IsGlobal = False,
                                                      .OptionSetType = OptionSetType.Picklist
                                                  }

            attributeOptionSet.Options.Add(New OptionMetadata(New Label("First Option", _languageCode), Nothing))
            attributeOptionSet.Options.Add(New OptionMetadata(New Label("Second Option", _languageCode), Nothing))
            attributeOptionSet.Options.Add(New OptionMetadata(New Label("Third Option", _languageCode), Nothing))
            attributeOptionSet.Options.Add(New OptionMetadata(New Label("Fourth Option", _languageCode), Nothing))

            Dim createAttributeRequest_Renamed As CreateAttributeRequest =
                New CreateAttributeRequest With
                {
                    .EntityName = _customEntitySchemaName.ToLower(),
                    .Attribute = New PicklistAttributeMetadata With
                                 {
                                     .SchemaName = _customAttributeSchemaName,
                                     .DisplayName = New Label("Example OptionSet for MetadataQuery Sample",
                                                              _languageCode),
                                     .RequiredLevel = New AttributeRequiredLevelManagedProperty(AttributeRequiredLevel.None),
                                     .OptionSet = attributeOptionSet
                                 }
                }
   _service.Execute(createAttributeRequest_Renamed)

  End Sub

  Protected Sub addOptionToCustomEntityOptionSet()

            Dim insertOptionValueRequest_Renamed As InsertOptionValueRequest =
                New InsertOptionValueRequest With
                {
                    .AttributeLogicalName = _customAttributeSchemaName.ToLower(),
                    .EntityLogicalName = _customEntitySchemaName.ToLower(),
                    .Label = New Label("Fifth Option", _languageCode)
                }

   _service.Execute(insertOptionValueRequest_Renamed)


  End Sub


  Protected Sub deleteCustomEntityWithOptionSet()

   Dim request As New DeleteEntityRequest() With {.LogicalName = _customEntitySchemaName.ToLower()}
   _service.Execute(request)


  End Sub
  Protected Function RetrieveUserUILanguageCode(ByVal userId As Guid) As Integer
   Dim userSettingsQuery As New QueryExpression("usersettings")
   userSettingsQuery.ColumnSet.AddColumns("uilanguageid", "systemuserid")
   userSettingsQuery.Criteria.AddCondition("systemuserid", ConditionOperator.Equal, userId)
   Dim userSettings As EntityCollection = _service.RetrieveMultiple(userSettingsQuery)
   If userSettings.Entities.Count > 0 Then
	Return CInt(Fix(userSettings.Entities(0)("uilanguageid")))
   End If
   Return 0
  End Function

  Protected Sub publishUpdatedEntity()
            Dim publishXmlRequest_Renamed As PublishXmlRequest =
                New PublishXmlRequest With
                {
                    .ParameterXml = "<importexportxml><entities><entity>" _
                    &amp; _customEntitySchemaName.ToLower() _
                    &amp; "</entity></entities></importexportxml>"
                }
   _service.Execute(publishXmlRequest_Renamed)
  End Sub


  #Region "Main method"

  ''' <summary>
  ''' Based on the Main() method used by most SDK samples.
  ''' </summary>
  ''' <param name="args"></param>
  Public Shared Sub Main(ByVal args() As String)
   Try
	' Obtain the target organization's Web address and client logon 
	' credentials from the user.
	Dim serverConnect As New ServerConnection()
	Dim config As ServerConnection.Configuration = serverConnect.GetServerConfiguration()

	Dim app As New MetadataQuerySample()
	app.Run(config)

   Catch ex As FaultException(Of Microsoft.Xrm.Sdk.OrganizationServiceFault)
	Console.WriteLine("The application terminated with an error.")
	Console.WriteLine("Timestamp: {0}", ex.Detail.Timestamp)
	Console.WriteLine("Code: {0}", ex.Detail.ErrorCode)
	Console.WriteLine("Message: {0}", ex.Detail.Message)
	Console.WriteLine("Trace: {0}", ex.Detail.TraceText)
                Console.WriteLine("Inner Fault: {0}",
                                  If(Nothing Is ex.Detail.InnerFault,
                                     "Has Inner Fault", "No Inner Fault"))
   Catch ex As TimeoutException
	Console.WriteLine("The application terminated with an error.")
	Console.WriteLine("Message: {0}", ex.Message)
	Console.WriteLine("Stack Trace: {0}", ex.StackTrace)
                Console.WriteLine("Inner Fault: {0}",
                                  If(Nothing Is ex.InnerException.Message,
                                     "Has Inner Fault", "No Inner Fault"))
   Catch ex As Exception
	Console.WriteLine("The application terminated with an error.")
	Console.WriteLine(ex.Message)

	' Display the details of the inner exception.
	If ex.InnerException IsNot Nothing Then
	 Console.WriteLine(ex.InnerException.Message)

                    Dim fe As FaultException(Of Microsoft.Xrm.Sdk.OrganizationServiceFault) =
                        TryCast(ex.InnerException, FaultException(Of Microsoft.Xrm.Sdk.OrganizationServiceFault))
	 If fe IsNot Nothing Then
	  Console.WriteLine("Timestamp: {0}", fe.Detail.Timestamp)
	  Console.WriteLine("Code: {0}", fe.Detail.ErrorCode)
	  Console.WriteLine("Message: {0}", fe.Detail.Message)
	  Console.WriteLine("Trace: {0}", fe.Detail.TraceText)
                        Console.WriteLine("Inner Fault: {0}",
                                          If(Nothing Is fe.Detail.InnerFault,
                                             "Has Inner Fault", "No Inner Fault"))
	 End If
	End If

	'Additional exceptions to catch: SecurityTokenValidationException, ExpiredSecurityTokenException,
   'SecurityAccessDeniedException, MessageSecurityException, and SecurityNegotiationException.

   Finally
	Console.WriteLine("Press <Enter> to exit.")
	Console.ReadLine()
   End Try
  End Sub
  #End Region ' Main method

 End Class

 Public Class OptionSetOption
  Public Sub New(ByVal OptionsetId As Guid, ByVal OptionValue As Integer, ByVal Label As String)
  Me._optionsetId = OptionsetId
  Me._optionValue = OptionValue
  Me._label = Label
  End Sub

  Private _optionsetId As Guid
  Private _optionValue As Integer
  Private _label As String

  Public ReadOnly Property optionsetId() As Guid
	  Get
		  Return Me._optionsetId
	  End Get
  End Property
  Public ReadOnly Property optionValue() As Integer
	  Get
		  Return Me._optionValue
	  End Get
  End Property
  Public ReadOnly Property label() As String
	  Get
		  Return Me._label
	  End Get
  End Property
 End Class


End Namespace

' </snippetmetadataquery>