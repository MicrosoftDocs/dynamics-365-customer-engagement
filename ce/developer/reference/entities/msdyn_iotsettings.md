---
title: "IoT Settings (msdyn_iotsettings) table/entity reference (Microsoft Dynamics 365)"
description: "Includes schema information and supported messages for the IoT Settings (msdyn_iotsettings) table/entity with Microsoft Dynamics 365."
ms.topic: generated-reference
author: JimDaly
ms.author: jdaly
search.audienceType: 
  - developer
---

# IoT Settings (msdyn_iotsettings) table/entity reference (Microsoft Dynamics 365)



## Messages

The following table lists the messages for the IoT Settings (msdyn_iotsettings) table.
Messages represent operations that can be performed on the table. They may also be events.

| Name <br />Is Event? |Web API Operation |SDK for .NET |
| ---- | ----- |----- |
| `Assign`<br />Event: True |`PATCH` /msdyn_iotsettingses(*msdyn_iotsettingsid*)<br />[Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) the `ownerid` property. |<xref:Microsoft.Crm.Sdk.Messages.AssignRequest>|
| `Associate`<br />Event: True |[Associate records](/power-apps/developer/data-platform/webapi/associate-disassociate-entities-using-web-api) |[Associate records](/power-apps/developer/data-platform/org-service/entity-operations-associate-disassociate#use-the-associate-method-or-associaterequest)|
| `BulkRetain`<br />Event: True |<xref:Microsoft.Dynamics.CRM.BulkRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Create`<br />Event: True |`POST` /msdyn_iotsettingses<br />See [Create](/powerapps/developer/data-platform/webapi/create-entity-web-api) |[Create records](/power-apps/developer/data-platform/org-service/entity-operations-create#basic-create)|
| `CreateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.CreateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.CreateMultipleRequest>|
| `Delete`<br />Event: True |`DELETE` /msdyn_iotsettingses(*msdyn_iotsettingsid*)<br />See [Delete](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-delete) |[Delete records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-delete)|
| `Disassociate`<br />Event: True |[Disassociate records](/power-apps/developer/data-platform/webapi/associate-disassociate-entities-using-web-api) |[Disassociate records](/power-apps/developer/data-platform/org-service/entity-operations-associate-disassociate#use-the-disassociate-method-or-disassociaterequest)|
| `GrantAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.GrantAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.GrantAccessRequest>|
| `IsValidStateTransition`<br />Event: False |<xref:Microsoft.Dynamics.CRM.IsValidStateTransition?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.IsValidStateTransitionRequest>|
| `ModifyAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.ModifyAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.ModifyAccessRequest>|
| `PurgeRetainedContent`<br />Event: True |<xref:Microsoft.Dynamics.CRM.PurgeRetainedContent?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Restore`<br />Event: True |<xref:Microsoft.Dynamics.CRM.Restore?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retain`<br />Event: True |<xref:Microsoft.Dynamics.CRM.Retain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retrieve`<br />Event: True |`GET` /msdyn_iotsettingses(*msdyn_iotsettingsid*)<br />See [Retrieve](/powerapps/developer/data-platform/webapi/retrieve-entity-using-web-api) |[Retrieve records](/power-apps/developer/data-platform/org-service/entity-operations-retrieve)|
| `RetrieveMultiple`<br />Event: True |`GET` /msdyn_iotsettingses<br />See [Query data](/power-apps/developer/data-platform/webapi/query-data-web-api) |[Query data](/power-apps/developer/data-platform/org-service/entity-operations-query-data)|
| `RetrievePrincipalAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RetrievePrincipalAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RetrievePrincipalAccessRequest>|
| `RetrieveSharedPrincipalsAndAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RetrieveSharedPrincipalsAndAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RetrieveSharedPrincipalsAndAccessRequest>|
| `RevokeAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RevokeAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RevokeAccessRequest>|
| `RollbackRetain`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RollbackRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `SetState`<br />Event: True |`PATCH` /msdyn_iotsettingses(*msdyn_iotsettingsid*)<br />[Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) the `statecode` and `statuscode` properties. |<xref:Microsoft.Crm.Sdk.Messages.SetStateRequest>|
| `Update`<br />Event: True |`PATCH` /msdyn_iotsettingses(*msdyn_iotsettingsid*)<br />See [Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) |[Update records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-update)|
| `UpdateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.UpdateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpdateMultipleRequest>|
| `Upsert`<br />Event: False |`PATCH` /msdyn_iotsettingses(*msdyn_iotsettingsid*)<br />See [Upsert a table row](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#upsert-a-table-row) |<xref:Microsoft.Xrm.Sdk.Messages.UpsertRequest>|
| `UpsertMultiple`<br />Event: False |<xref:Microsoft.Dynamics.CRM.UpsertMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpsertMultipleRequest>|
| `ValidateRetentionConfig`<br />Event: True |<xref:Microsoft.Dynamics.CRM.ValidateRetentionConfig?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|

## Properties

The following table lists selected properties for the IoT Settings (msdyn_iotsettings) table.

|Property|Value|
| --- | --- |
| **DisplayName** | **IoT Settings** |
| **DisplayCollectionName** | **IoT Settings** |
| **SchemaName** | `msdyn_iotsettings` |
| **CollectionSchemaName** | `msdyn_iotsettingses` |
| **EntitySetName** | `msdyn_iotsettingses`|
| **LogicalName** | `msdyn_iotsettings` |
| **LogicalCollectionName** | `msdyn_iotsettingses` |
| **PrimaryIdAttribute** | `msdyn_iotsettingsid` |
| **PrimaryNameAttribute** |`msdyn_name` |
| **TableType** | `Standard` |
| **OwnershipType** | `UserOwned` |

## Writable columns/attributes

These columns/attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [ImportSequenceNumber](#BKMK_ImportSequenceNumber)
- [msdyn_CommandNameProperty](#BKMK_msdyn_CommandNameProperty)
- [msdyn_CommandParametersProperty](#BKMK_msdyn_CommandParametersProperty)
- [msdyn_DefaultIoTProviderInstance](#BKMK_msdyn_DefaultIoTProviderInstance)
- [msdyn_defaultiotsource](#BKMK_msdyn_defaultiotsource)
- [msdyn_DeploymentAppURL](#BKMK_msdyn_DeploymentAppURL)
- [msdyn_devicedatapullfrequency](#BKMK_msdyn_devicedatapullfrequency)
- [msdyn_EnableIoTSuggestions](#BKMK_msdyn_EnableIoTSuggestions)
- [msdyn_EnhancedBackgroundProcessing](#BKMK_msdyn_EnhancedBackgroundProcessing)
- [msdyn_IoTAlertAggregationRule](#BKMK_msdyn_IoTAlertAggregationRule)
- [msdyn_iotsettingsId](#BKMK_msdyn_iotsettingsId)
- [msdyn_name](#BKMK_msdyn_name)
- [msdyn_NextDeviceDataPullTime](#BKMK_msdyn_NextDeviceDataPullTime)
- [msdyn_ScheduledDeviceDataPull](#BKMK_msdyn_ScheduledDeviceDataPull)
- [msdyn_ShowWelcome](#BKMK_msdyn_ShowWelcome)
- [OverriddenCreatedOn](#BKMK_OverriddenCreatedOn)
- [OwnerId](#BKMK_OwnerId)
- [OwnerIdType](#BKMK_OwnerIdType)
- [statecode](#BKMK_statecode)
- [statuscode](#BKMK_statuscode)
- [TimeZoneRuleVersionNumber](#BKMK_TimeZoneRuleVersionNumber)
- [UTCConversionTimeZoneCode](#BKMK_UTCConversionTimeZoneCode)

### <a name="BKMK_ImportSequenceNumber"></a> ImportSequenceNumber

|Property|Value|
|---|---|
|Description|**Sequence number of the import that created this record.**|
|DisplayName|**Import Sequence Number**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`importsequencenumber`|
|RequiredLevel|None|
|Type|Integer|
|MaxValue|2147483647|
|MinValue|-2147483648|

### <a name="BKMK_msdyn_CommandNameProperty"></a> msdyn_CommandNameProperty

|Property|Value|
|---|---|
|Description|**This value will be used to specify the command name when sending device commands. Default property value is "CommandName" when this field is unspecified.**|
|DisplayName|**Command Name Property**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_commandnameproperty`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdyn_CommandParametersProperty"></a> msdyn_CommandParametersProperty

|Property|Value|
|---|---|
|Description|**This value will be used to specify the command parameters when sending device commands. Default property value is "Parameters" when this field is unspecified.**|
|DisplayName|**Command Parameters Property**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_commandparametersproperty`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdyn_DefaultIoTProviderInstance"></a> msdyn_DefaultIoTProviderInstance

|Property|Value|
|---|---|
|Description|**The IoT Provider Instance to which IoT Devices should belong by default.**|
|DisplayName|**Default IoT Provider Instance**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_defaultiotproviderinstance`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|msdyn_iotproviderinstance|

### <a name="BKMK_msdyn_defaultiotsource"></a> msdyn_defaultiotsource

|Property|Value|
|---|---|
|Description|**This field is used to know the source of IoT for this organization. Example : IoT Suite or IoT Central or Others.**|
|DisplayName|**Default IoT Source**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_defaultiotsource`|
|RequiredLevel|None|
|Type|Picklist|
|DefaultFormValue|-1|
|GlobalChoiceName|`msdyn_iotsource`|

#### msdyn_defaultiotsource Choices/Options

|Value|Label|
|---|---|
|192350000|**Other**|
|192350001|**Azure IoT Suite**|
|192350002|**Azure IoT Central**|

### <a name="BKMK_msdyn_DeploymentAppURL"></a> msdyn_DeploymentAppURL

|Property|Value|
|---|---|
|Description||
|DisplayName|**Deployment App URL**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_deploymentappurl`|
|RequiredLevel|None|
|Type|String|
|Format|Url|
|FormatName|Url|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdyn_devicedatapullfrequency"></a> msdyn_devicedatapullfrequency

|Property|Value|
|---|---|
|Description|**To specify the interval of scheduled device data pulls**|
|DisplayName|**Device Data Pull Frequency**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_devicedatapullfrequency`|
|RequiredLevel|None|
|Type|Integer|
|MaxValue|2147483647|
|MinValue|60|

### <a name="BKMK_msdyn_EnableIoTSuggestions"></a> msdyn_EnableIoTSuggestions

|Property|Value|
|---|---|
|Description|**IoT suggestions provide you insights on priority level and incident type associated with an alert.**|
|DisplayName|**Enable IoT suggestions**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_enableiotsuggestions`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`msdyn_msdyn_iotsettings_msdyn_enableiotsuggestions`|
|DefaultValue|False|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_msdyn_EnhancedBackgroundProcessing"></a> msdyn_EnhancedBackgroundProcessing

|Property|Value|
|---|---|
|Description|**When this option is enabled, all Connected Field Service background processes will be processed through flows instead of the historic Connected Field Service workflows.**|
|DisplayName|**Use Enhanced Background Processing**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_enhancedbackgroundprocessing`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`msdyn_iotsettings_msdyn_enhancedbackgroundprocessing`|
|DefaultValue|False|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_msdyn_IoTAlertAggregationRule"></a> msdyn_IoTAlertAggregationRule

|Property|Value|
|---|---|
|Description|**Select the columns that will be used to determine the aggregation of similar IoT alerts.**|
|DisplayName|**IoT Alert Aggregation Rule**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_iotalertaggregationrule`|
|RequiredLevel|None|
|Type|Memo|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|8000|

### <a name="BKMK_msdyn_iotsettingsId"></a> msdyn_iotsettingsId

|Property|Value|
|---|---|
|Description|**Unique identifier for entity instances**|
|DisplayName|**IoTSettings**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`msdyn_iotsettingsid`|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|

### <a name="BKMK_msdyn_name"></a> msdyn_name

|Property|Value|
|---|---|
|Description|**The name of the custom entity.**|
|DisplayName|**Name**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_name`|
|RequiredLevel|ApplicationRequired|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdyn_NextDeviceDataPullTime"></a> msdyn_NextDeviceDataPullTime

|Property|Value|
|---|---|
|Description|**The next scheduled running time for device data pull**|
|DisplayName|**Next Device Data Pull Time**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_nextdevicedatapulltime`|
|RequiredLevel|None|
|Type|DateTime|
|CanChangeDateTimeBehavior|True|
|DateTimeBehavior|UserLocal|
|Format|DateAndTime|
|ImeMode|Auto|
|SourceTypeMask|0|

### <a name="BKMK_msdyn_ScheduledDeviceDataPull"></a> msdyn_ScheduledDeviceDataPull

|Property|Value|
|---|---|
|Description|**To turn on/off scheduled device data pulls, default is off**|
|DisplayName|**Scheduled Data Pull**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_scheduleddevicedatapull`|
|RequiredLevel|ApplicationRequired|
|Type|Boolean|
|GlobalChoiceName|`msdyn_iotsettings_msdyn_scheduleddatapull`|
|DefaultValue|False|
|True Label|On|
|False Label|Off|

### <a name="BKMK_msdyn_ShowWelcome"></a> msdyn_ShowWelcome

|Property|Value|
|---|---|
|Description||
|DisplayName|**Show Welcome**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_showwelcome`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`msdyn_iotsettings_msdyn_showwelcome`|
|DefaultValue|True|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_OverriddenCreatedOn"></a> OverriddenCreatedOn

|Property|Value|
|---|---|
|Description|**Date and time that the record was migrated.**|
|DisplayName|**Record Created On**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`overriddencreatedon`|
|RequiredLevel|None|
|Type|DateTime|
|CanChangeDateTimeBehavior|False|
|DateTimeBehavior|UserLocal|
|Format|DateOnly|
|ImeMode|Inactive|
|SourceTypeMask|0|

### <a name="BKMK_OwnerId"></a> OwnerId

|Property|Value|
|---|---|
|Description|**Owner Id**|
|DisplayName|**Owner**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`ownerid`|
|RequiredLevel|SystemRequired|
|Type|Owner|
|Targets|systemuser, team|

### <a name="BKMK_OwnerIdType"></a> OwnerIdType

|Property|Value|
|---|---|
|Description|**Owner Id Type**|
|DisplayName||
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`owneridtype`|
|RequiredLevel|SystemRequired|
|Type|EntityName|

### <a name="BKMK_statecode"></a> statecode

|Property|Value|
|---|---|
|Description|**Status of the IoTSettings**|
|DisplayName|**Status**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statecode`|
|RequiredLevel|SystemRequired|
|Type|State|
|DefaultFormValue||
|GlobalChoiceName|`msdyn_iotsettings_statecode`|

#### statecode Choices/Options

|Value|Details|
|---|---|
|0|Label: **Active**<br />DefaultStatus: 1<br />InvariantName: `Active`|
|1|Label: **Inactive**<br />DefaultStatus: 2<br />InvariantName: `Inactive`|

### <a name="BKMK_statuscode"></a> statuscode

|Property|Value|
|---|---|
|Description|**Reason for the status of the IoTSettings**|
|DisplayName|**Status Reason**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statuscode`|
|RequiredLevel|None|
|Type|Status|
|DefaultFormValue||
|GlobalChoiceName|`msdyn_iotsettings_statuscode`|

#### statuscode Choices/Options

|Value|Details|
|---|---|
|1|Label: **Active**<br />State:0<br />TransitionData: None|
|2|Label: **Inactive**<br />State:1<br />TransitionData: None|

### <a name="BKMK_TimeZoneRuleVersionNumber"></a> TimeZoneRuleVersionNumber

|Property|Value|
|---|---|
|Description|**For internal use only.**|
|DisplayName|**Time Zone Rule Version Number**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`timezoneruleversionnumber`|
|RequiredLevel|None|
|Type|Integer|
|MaxValue|2147483647|
|MinValue|-1|

### <a name="BKMK_UTCConversionTimeZoneCode"></a> UTCConversionTimeZoneCode

|Property|Value|
|---|---|
|Description|**Time zone code that was in use when the record was created.**|
|DisplayName|**UTC Conversion Time Zone Code**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`utcconversiontimezonecode`|
|RequiredLevel|None|
|Type|Integer|
|MaxValue|2147483647|
|MinValue|-1|


## Read-only columns/attributes

These columns/attributes return false for both **IsValidForCreate** and **IsValidForUpdate**. Listed by **SchemaName**.

- [CreatedBy](#BKMK_CreatedBy)
- [CreatedOn](#BKMK_CreatedOn)
- [CreatedOnBehalfBy](#BKMK_CreatedOnBehalfBy)
- [ModifiedBy](#BKMK_ModifiedBy)
- [ModifiedOn](#BKMK_ModifiedOn)
- [ModifiedOnBehalfBy](#BKMK_ModifiedOnBehalfBy)
- [OwnerIdName](#BKMK_OwnerIdName)
- [OwnerIdYomiName](#BKMK_OwnerIdYomiName)
- [OwningBusinessUnit](#BKMK_OwningBusinessUnit)
- [OwningTeam](#BKMK_OwningTeam)
- [OwningUser](#BKMK_OwningUser)
- [VersionNumber](#BKMK_VersionNumber)

### <a name="BKMK_CreatedBy"></a> CreatedBy

|Property|Value|
|---|---|
|Description|**Unique identifier of the user who created the record.**|
|DisplayName|**Created By**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`createdby`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|systemuser|

### <a name="BKMK_CreatedOn"></a> CreatedOn

|Property|Value|
|---|---|
|Description|**Date and time when the record was created.**|
|DisplayName|**Created On**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`createdon`|
|RequiredLevel|None|
|Type|DateTime|
|CanChangeDateTimeBehavior|False|
|DateTimeBehavior|UserLocal|
|Format|DateAndTime|
|ImeMode|Inactive|
|SourceTypeMask|0|

### <a name="BKMK_CreatedOnBehalfBy"></a> CreatedOnBehalfBy

|Property|Value|
|---|---|
|Description|**Unique identifier of the delegate user who created the record.**|
|DisplayName|**Created By (Delegate)**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`createdonbehalfby`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|systemuser|

### <a name="BKMK_ModifiedBy"></a> ModifiedBy

|Property|Value|
|---|---|
|Description|**Unique identifier of the user who modified the record.**|
|DisplayName|**Modified By**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`modifiedby`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|systemuser|

### <a name="BKMK_ModifiedOn"></a> ModifiedOn

|Property|Value|
|---|---|
|Description|**Date and time when the record was modified.**|
|DisplayName|**Modified On**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`modifiedon`|
|RequiredLevel|None|
|Type|DateTime|
|CanChangeDateTimeBehavior|False|
|DateTimeBehavior|UserLocal|
|Format|DateAndTime|
|ImeMode|Inactive|
|SourceTypeMask|0|

### <a name="BKMK_ModifiedOnBehalfBy"></a> ModifiedOnBehalfBy

|Property|Value|
|---|---|
|Description|**Unique identifier of the delegate user who modified the record.**|
|DisplayName|**Modified By (Delegate)**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`modifiedonbehalfby`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|systemuser|

### <a name="BKMK_OwnerIdName"></a> OwnerIdName

|Property|Value|
|---|---|
|Description|**Name of the owner**|
|DisplayName||
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`owneridname`|
|RequiredLevel|SystemRequired|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_OwnerIdYomiName"></a> OwnerIdYomiName

|Property|Value|
|---|---|
|Description|**Yomi name of the owner**|
|DisplayName||
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`owneridyominame`|
|RequiredLevel|SystemRequired|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_OwningBusinessUnit"></a> OwningBusinessUnit

|Property|Value|
|---|---|
|Description|**Unique identifier for the business unit that owns the record**|
|DisplayName|**Owning Business Unit**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`owningbusinessunit`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|businessunit|

### <a name="BKMK_OwningTeam"></a> OwningTeam

|Property|Value|
|---|---|
|Description|**Unique identifier for the team that owns the record.**|
|DisplayName|**Owning Team**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`owningteam`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|team|

### <a name="BKMK_OwningUser"></a> OwningUser

|Property|Value|
|---|---|
|Description|**Unique identifier for the user that owns the record.**|
|DisplayName|**Owning User**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`owninguser`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|systemuser|

### <a name="BKMK_VersionNumber"></a> VersionNumber

|Property|Value|
|---|---|
|Description|**Version Number**|
|DisplayName|**Version Number**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`versionnumber`|
|RequiredLevel|None|
|Type|BigInt|
|MaxValue|9223372036854775807|
|MinValue|-9223372036854775808|

## Many-to-One relationships

These relationships are many-to-one. Listed by **SchemaName**.

- [business_unit_msdyn_iotsettings](#BKMK_business_unit_msdyn_iotsettings)
- [lk_msdyn_iotsettings_createdby](#BKMK_lk_msdyn_iotsettings_createdby)
- [lk_msdyn_iotsettings_createdonbehalfby](#BKMK_lk_msdyn_iotsettings_createdonbehalfby)
- [lk_msdyn_iotsettings_modifiedby](#BKMK_lk_msdyn_iotsettings_modifiedby)
- [lk_msdyn_iotsettings_modifiedonbehalfby](#BKMK_lk_msdyn_iotsettings_modifiedonbehalfby)
- [msdyn_msdyn_iotproviderinstance_msdyn_iotsettings_DefaultIoTProviderInstance](#BKMK_msdyn_msdyn_iotproviderinstance_msdyn_iotsettings_DefaultIoTProviderInstance)
- [owner_msdyn_iotsettings](#BKMK_owner_msdyn_iotsettings)
- [team_msdyn_iotsettings](#BKMK_team_msdyn_iotsettings)
- [user_msdyn_iotsettings](#BKMK_user_msdyn_iotsettings)

### <a name="BKMK_business_unit_msdyn_iotsettings"></a> business_unit_msdyn_iotsettings

One-To-Many Relationship: [businessunit business_unit_msdyn_iotsettings](businessunit.md#BKMK_business_unit_msdyn_iotsettings)

|Property|Value|
|---|---|
|ReferencedEntity|`businessunit`|
|ReferencedAttribute|`businessunitid`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencingEntityNavigationPropertyName|`owningbusinessunit`|
|IsHierarchical||
|CascadeConfiguration|Archive: `Restrict`<br />Assign: `NoCascade`<br />Delete: `Restrict`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_iotsettings_createdby"></a> lk_msdyn_iotsettings_createdby

One-To-Many Relationship: [systemuser lk_msdyn_iotsettings_createdby](systemuser.md#BKMK_lk_msdyn_iotsettings_createdby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdby`|
|ReferencingEntityNavigationPropertyName|`createdby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_iotsettings_createdonbehalfby"></a> lk_msdyn_iotsettings_createdonbehalfby

One-To-Many Relationship: [systemuser lk_msdyn_iotsettings_createdonbehalfby](systemuser.md#BKMK_lk_msdyn_iotsettings_createdonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdonbehalfby`|
|ReferencingEntityNavigationPropertyName|`createdonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_iotsettings_modifiedby"></a> lk_msdyn_iotsettings_modifiedby

One-To-Many Relationship: [systemuser lk_msdyn_iotsettings_modifiedby](systemuser.md#BKMK_lk_msdyn_iotsettings_modifiedby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedby`|
|ReferencingEntityNavigationPropertyName|`modifiedby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_iotsettings_modifiedonbehalfby"></a> lk_msdyn_iotsettings_modifiedonbehalfby

One-To-Many Relationship: [systemuser lk_msdyn_iotsettings_modifiedonbehalfby](systemuser.md#BKMK_lk_msdyn_iotsettings_modifiedonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedonbehalfby`|
|ReferencingEntityNavigationPropertyName|`modifiedonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_msdyn_iotproviderinstance_msdyn_iotsettings_DefaultIoTProviderInstance"></a> msdyn_msdyn_iotproviderinstance_msdyn_iotsettings_DefaultIoTProviderInstance

One-To-Many Relationship: [msdyn_iotproviderinstance msdyn_msdyn_iotproviderinstance_msdyn_iotsettings_DefaultIoTProviderInstance](msdyn_iotproviderinstance.md#BKMK_msdyn_msdyn_iotproviderinstance_msdyn_iotsettings_DefaultIoTProviderInstance)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_iotproviderinstance`|
|ReferencedAttribute|`msdyn_iotproviderinstanceid`|
|ReferencingAttribute|`msdyn_defaultiotproviderinstance`|
|ReferencingEntityNavigationPropertyName|`msdyn_DefaultIoTProviderInstance`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Restrict`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_owner_msdyn_iotsettings"></a> owner_msdyn_iotsettings

One-To-Many Relationship: [owner owner_msdyn_iotsettings](owner.md#BKMK_owner_msdyn_iotsettings)

|Property|Value|
|---|---|
|ReferencedEntity|`owner`|
|ReferencedAttribute|`ownerid`|
|ReferencingAttribute|`ownerid`|
|ReferencingEntityNavigationPropertyName|`ownerid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_team_msdyn_iotsettings"></a> team_msdyn_iotsettings

One-To-Many Relationship: [team team_msdyn_iotsettings](team.md#BKMK_team_msdyn_iotsettings)

|Property|Value|
|---|---|
|ReferencedEntity|`team`|
|ReferencedAttribute|`teamid`|
|ReferencingAttribute|`owningteam`|
|ReferencingEntityNavigationPropertyName|`owningteam`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_user_msdyn_iotsettings"></a> user_msdyn_iotsettings

One-To-Many Relationship: [systemuser user_msdyn_iotsettings](systemuser.md#BKMK_user_msdyn_iotsettings)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`owninguser`|
|ReferencingEntityNavigationPropertyName|`owninguser`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|


## One-to-Many relationships

These relationships are one-to-many. Listed by **SchemaName**.

- [msdyn_iotsettings_AsyncOperations](#BKMK_msdyn_iotsettings_AsyncOperations)
- [msdyn_iotsettings_BulkDeleteFailures](#BKMK_msdyn_iotsettings_BulkDeleteFailures)
- [msdyn_iotsettings_DuplicateBaseRecord](#BKMK_msdyn_iotsettings_DuplicateBaseRecord)
- [msdyn_iotsettings_DuplicateMatchingRecord](#BKMK_msdyn_iotsettings_DuplicateMatchingRecord)
- [msdyn_iotsettings_MailboxTrackingFolders](#BKMK_msdyn_iotsettings_MailboxTrackingFolders)
- [msdyn_iotsettings_PrincipalObjectAttributeAccesses](#BKMK_msdyn_iotsettings_PrincipalObjectAttributeAccesses)
- [msdyn_iotsettings_ProcessSession](#BKMK_msdyn_iotsettings_ProcessSession)
- [msdyn_iotsettings_SyncErrors](#BKMK_msdyn_iotsettings_SyncErrors)

### <a name="BKMK_msdyn_iotsettings_AsyncOperations"></a> msdyn_iotsettings_AsyncOperations

Many-To-One Relationship: [asyncoperation msdyn_iotsettings_AsyncOperations](asyncoperation.md#BKMK_msdyn_iotsettings_AsyncOperations)

|Property|Value|
|---|---|
|ReferencingEntity|`asyncoperation`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_iotsettings_AsyncOperations`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_iotsettings_BulkDeleteFailures"></a> msdyn_iotsettings_BulkDeleteFailures

Many-To-One Relationship: [bulkdeletefailure msdyn_iotsettings_BulkDeleteFailures](bulkdeletefailure.md#BKMK_msdyn_iotsettings_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencingEntity|`bulkdeletefailure`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_iotsettings_BulkDeleteFailures`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_iotsettings_DuplicateBaseRecord"></a> msdyn_iotsettings_DuplicateBaseRecord

Many-To-One Relationship: [duplicaterecord msdyn_iotsettings_DuplicateBaseRecord](duplicaterecord.md#BKMK_msdyn_iotsettings_DuplicateBaseRecord)

|Property|Value|
|---|---|
|ReferencingEntity|`duplicaterecord`|
|ReferencingAttribute|`baserecordid`|
|ReferencedEntityNavigationPropertyName|`msdyn_iotsettings_DuplicateBaseRecord`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_iotsettings_DuplicateMatchingRecord"></a> msdyn_iotsettings_DuplicateMatchingRecord

Many-To-One Relationship: [duplicaterecord msdyn_iotsettings_DuplicateMatchingRecord](duplicaterecord.md#BKMK_msdyn_iotsettings_DuplicateMatchingRecord)

|Property|Value|
|---|---|
|ReferencingEntity|`duplicaterecord`|
|ReferencingAttribute|`duplicaterecordid`|
|ReferencedEntityNavigationPropertyName|`msdyn_iotsettings_DuplicateMatchingRecord`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_iotsettings_MailboxTrackingFolders"></a> msdyn_iotsettings_MailboxTrackingFolders

Many-To-One Relationship: [mailboxtrackingfolder msdyn_iotsettings_MailboxTrackingFolders](mailboxtrackingfolder.md#BKMK_msdyn_iotsettings_MailboxTrackingFolders)

|Property|Value|
|---|---|
|ReferencingEntity|`mailboxtrackingfolder`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_iotsettings_MailboxTrackingFolders`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_iotsettings_PrincipalObjectAttributeAccesses"></a> msdyn_iotsettings_PrincipalObjectAttributeAccesses

Many-To-One Relationship: [principalobjectattributeaccess msdyn_iotsettings_PrincipalObjectAttributeAccesses](principalobjectattributeaccess.md#BKMK_msdyn_iotsettings_PrincipalObjectAttributeAccesses)

|Property|Value|
|---|---|
|ReferencingEntity|`principalobjectattributeaccess`|
|ReferencingAttribute|`objectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_iotsettings_PrincipalObjectAttributeAccesses`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_iotsettings_ProcessSession"></a> msdyn_iotsettings_ProcessSession

Many-To-One Relationship: [processsession msdyn_iotsettings_ProcessSession](processsession.md#BKMK_msdyn_iotsettings_ProcessSession)

|Property|Value|
|---|---|
|ReferencingEntity|`processsession`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_iotsettings_ProcessSession`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_iotsettings_SyncErrors"></a> msdyn_iotsettings_SyncErrors

Many-To-One Relationship: [syncerror msdyn_iotsettings_SyncErrors](syncerror.md#BKMK_msdyn_iotsettings_SyncErrors)

|Property|Value|
|---|---|
|ReferencingEntity|`syncerror`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_iotsettings_SyncErrors`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|



### See also

[Dataverse table/entity reference](/power-apps/developer/data-platform/reference/about-entity-reference)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   

