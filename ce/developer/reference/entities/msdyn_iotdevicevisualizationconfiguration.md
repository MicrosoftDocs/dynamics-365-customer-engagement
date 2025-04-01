---
title: "IoT Device Visualization Configuration (msdyn_iotdevicevisualizationconfiguration) table/entity reference (Microsoft Dynamics 365)"
description: "Includes schema information and supported messages for the IoT Device Visualization Configuration (msdyn_iotdevicevisualizationconfiguration) table/entity with Microsoft Dynamics 365."
ms.topic: generated-reference
author: JimDaly
ms.author: jdaly
search.audienceType: 
  - developer
---

# IoT Device Visualization Configuration (msdyn_iotdevicevisualizationconfiguration) table/entity reference (Microsoft Dynamics 365)

IoT Device Visualization Configuration

## Messages

The following table lists the messages for the IoT Device Visualization Configuration (msdyn_iotdevicevisualizationconfiguration) table.
Messages represent operations that can be performed on the table. They may also be events.

| Name <br />Is Event? |Web API Operation |SDK for .NET |
| ---- | ----- |----- |
| `Assign`<br />Event: True |`PATCH` /msdyn_iotdevicevisualizationconfigurations(*msdyn_iotdevicevisualizationconfigurationid*)<br />[Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) the `ownerid` property. |<xref:Microsoft.Crm.Sdk.Messages.AssignRequest>|
| `Associate`<br />Event: True |[Associate records](/power-apps/developer/data-platform/webapi/associate-disassociate-entities-using-web-api) |[Associate records](/power-apps/developer/data-platform/org-service/entity-operations-associate-disassociate#use-the-associate-method-or-associaterequest)|
| `BulkRetain`<br />Event: True |<xref:Microsoft.Dynamics.CRM.BulkRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Create`<br />Event: True |`POST` /msdyn_iotdevicevisualizationconfigurations<br />See [Create](/powerapps/developer/data-platform/webapi/create-entity-web-api) |[Create records](/power-apps/developer/data-platform/org-service/entity-operations-create#basic-create)|
| `CreateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.CreateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.CreateMultipleRequest>|
| `Delete`<br />Event: True |`DELETE` /msdyn_iotdevicevisualizationconfigurations(*msdyn_iotdevicevisualizationconfigurationid*)<br />See [Delete](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-delete) |[Delete records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-delete)|
| `Disassociate`<br />Event: True |[Disassociate records](/power-apps/developer/data-platform/webapi/associate-disassociate-entities-using-web-api) |[Disassociate records](/power-apps/developer/data-platform/org-service/entity-operations-associate-disassociate#use-the-disassociate-method-or-disassociaterequest)|
| `GrantAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.GrantAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.GrantAccessRequest>|
| `IsValidStateTransition`<br />Event: False |<xref:Microsoft.Dynamics.CRM.IsValidStateTransition?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.IsValidStateTransitionRequest>|
| `ModifyAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.ModifyAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.ModifyAccessRequest>|
| `PurgeRetainedContent`<br />Event: True |<xref:Microsoft.Dynamics.CRM.PurgeRetainedContent?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Restore`<br />Event: True |<xref:Microsoft.Dynamics.CRM.Restore?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retain`<br />Event: True |<xref:Microsoft.Dynamics.CRM.Retain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retrieve`<br />Event: True |`GET` /msdyn_iotdevicevisualizationconfigurations(*msdyn_iotdevicevisualizationconfigurationid*)<br />See [Retrieve](/powerapps/developer/data-platform/webapi/retrieve-entity-using-web-api) |[Retrieve records](/power-apps/developer/data-platform/org-service/entity-operations-retrieve)|
| `RetrieveMultiple`<br />Event: True |`GET` /msdyn_iotdevicevisualizationconfigurations<br />See [Query data](/power-apps/developer/data-platform/webapi/query-data-web-api) |[Query data](/power-apps/developer/data-platform/org-service/entity-operations-query-data)|
| `RetrievePrincipalAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RetrievePrincipalAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RetrievePrincipalAccessRequest>|
| `RetrieveSharedPrincipalsAndAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RetrieveSharedPrincipalsAndAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RetrieveSharedPrincipalsAndAccessRequest>|
| `RevokeAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RevokeAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RevokeAccessRequest>|
| `RollbackRetain`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RollbackRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `SetState`<br />Event: True |`PATCH` /msdyn_iotdevicevisualizationconfigurations(*msdyn_iotdevicevisualizationconfigurationid*)<br />[Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) the `statecode` and `statuscode` properties. |<xref:Microsoft.Crm.Sdk.Messages.SetStateRequest>|
| `Update`<br />Event: True |`PATCH` /msdyn_iotdevicevisualizationconfigurations(*msdyn_iotdevicevisualizationconfigurationid*)<br />See [Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) |[Update records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-update)|
| `UpdateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.UpdateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpdateMultipleRequest>|
| `Upsert`<br />Event: False |`PATCH` /msdyn_iotdevicevisualizationconfigurations(*msdyn_iotdevicevisualizationconfigurationid*)<br />See [Upsert a table row](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#upsert-a-table-row) |<xref:Microsoft.Xrm.Sdk.Messages.UpsertRequest>|
| `UpsertMultiple`<br />Event: False |<xref:Microsoft.Dynamics.CRM.UpsertMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpsertMultipleRequest>|
| `ValidateRetentionConfig`<br />Event: True |<xref:Microsoft.Dynamics.CRM.ValidateRetentionConfig?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|

## Properties

The following table lists selected properties for the IoT Device Visualization Configuration (msdyn_iotdevicevisualizationconfiguration) table.

|Property|Value|
| --- | --- |
| **DisplayName** | **IoT Device Visualization Configuration** |
| **DisplayCollectionName** | **IoT Device Visualization Configuration** |
| **SchemaName** | `msdyn_iotdevicevisualizationconfiguration` |
| **CollectionSchemaName** | `msdyn_iotdevicevisualizationconfigurations` |
| **EntitySetName** | `msdyn_iotdevicevisualizationconfigurations`|
| **LogicalName** | `msdyn_iotdevicevisualizationconfiguration` |
| **LogicalCollectionName** | `msdyn_iotdevicevisualizationconfigurations` |
| **PrimaryIdAttribute** | `msdyn_iotdevicevisualizationconfigurationid` |
| **PrimaryNameAttribute** |`msdyn_name` |
| **TableType** | `Standard` |
| **OwnershipType** | `UserOwned` |

## Writable columns/attributes

These columns/attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [ImportSequenceNumber](#BKMK_ImportSequenceNumber)
- [msdyn_actionname](#BKMK_msdyn_actionname)
- [msdyn_Aggregation](#BKMK_msdyn_Aggregation)
- [msdyn_DeviceEvent](#BKMK_msdyn_DeviceEvent)
- [msdyn_IoTDevice](#BKMK_msdyn_IoTDevice)
- [msdyn_IoTDeviceCategory](#BKMK_msdyn_IoTDeviceCategory)
- [msdyn_iotdevicevisualizationconfigurationId](#BKMK_msdyn_iotdevicevisualizationconfigurationId)
- [msdyn_Measurement](#BKMK_msdyn_Measurement)
- [msdyn_name](#BKMK_msdyn_name)
- [msdyn_Position](#BKMK_msdyn_Position)
- [msdyn_TimeRangeType](#BKMK_msdyn_TimeRangeType)
- [msdyn_TimeRangeValue](#BKMK_msdyn_TimeRangeValue)
- [msdyn_VisualizationConfigurationType](#BKMK_msdyn_VisualizationConfigurationType)
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

### <a name="BKMK_msdyn_actionname"></a> msdyn_actionname

|Property|Value|
|---|---|
|Description|**Action name for IoT device visualization**|
|DisplayName|**Action Name**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_actionname`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdyn_Aggregation"></a> msdyn_Aggregation

|Property|Value|
|---|---|
|Description||
|DisplayName|**Aggregation**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_aggregation`|
|RequiredLevel|ApplicationRequired|
|Type|Picklist|
|DefaultFormValue|-1|
|GlobalChoiceName|`msdyn_iotaggregation`|

#### msdyn_Aggregation Choices/Options

|Value|Label|
|---|---|
|192350000|**None**|
|192350001|**Avg**|
|192350002|**Min**|
|192350003|**Max**|
|192350004|**Sum**|
|192350005|**Count**|

### <a name="BKMK_msdyn_DeviceEvent"></a> msdyn_DeviceEvent

|Property|Value|
|---|---|
|Description|**Device Event of device visualization**|
|DisplayName|**Device Event**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_deviceevent`|
|RequiredLevel|None|
|Type|Picklist|
|DefaultFormValue|-1|
|GlobalChoiceName|`msdyn_deviceevent`|

#### msdyn_DeviceEvent Choices/Options

|Value|Label|
|---|---|
|192350000|**IoT Alert**|
|192350001|**Case**|
|192350002|**Work Order**|

### <a name="BKMK_msdyn_IoTDevice"></a> msdyn_IoTDevice

|Property|Value|
|---|---|
|Description|**Visualizations shown for this device**|
|DisplayName|**IoT Device**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_iotdevice`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|msdyn_iotdevice|

### <a name="BKMK_msdyn_IoTDeviceCategory"></a> msdyn_IoTDeviceCategory

|Property|Value|
|---|---|
|Description|**Visualization shown for this device category**|
|DisplayName|**IoT Device Category**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_iotdevicecategory`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|msdyn_iotdevicecategory|

### <a name="BKMK_msdyn_iotdevicevisualizationconfigurationId"></a> msdyn_iotdevicevisualizationconfigurationId

|Property|Value|
|---|---|
|Description|**Unique identifier for entity instances**|
|DisplayName|**IoT Device Visualization Configuration**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`msdyn_iotdevicevisualizationconfigurationid`|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|

### <a name="BKMK_msdyn_Measurement"></a> msdyn_Measurement

|Property|Value|
|---|---|
|Description|**Property Definition**|
|DisplayName|**Device Measurement**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_measurement`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|msdyn_iotpropertydefinition|

### <a name="BKMK_msdyn_name"></a> msdyn_name

|Property|Value|
|---|---|
|Description|**The name of the custom entity.**|
|DisplayName|**Name**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_name`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdyn_Position"></a> msdyn_Position

|Property|Value|
|---|---|
|Description|**Position of device visualization**|
|DisplayName|**Position**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_position`|
|RequiredLevel|ApplicationRequired|
|Type|Integer|
|MaxValue|2147483647|
|MinValue|0|

### <a name="BKMK_msdyn_TimeRangeType"></a> msdyn_TimeRangeType

|Property|Value|
|---|---|
|Description|**Time range unit for device visualization**|
|DisplayName|**Time Range Type**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_timerangetype`|
|RequiredLevel|None|
|Type|Picklist|
|DefaultFormValue|-1|
|GlobalChoiceName|`msdyn_timerangetype`|

#### msdyn_TimeRangeType Choices/Options

|Value|Label|
|---|---|
|192350000|**Hours**|
|192350001|**Days**|
|192350002|**Latest**|

### <a name="BKMK_msdyn_TimeRangeValue"></a> msdyn_TimeRangeValue

|Property|Value|
|---|---|
|Description|**Time range value for device visualization**|
|DisplayName|**Time Range Value**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_timerangevalue`|
|RequiredLevel|None|
|Type|Integer|
|MaxValue|90|
|MinValue|1|

### <a name="BKMK_msdyn_VisualizationConfigurationType"></a> msdyn_VisualizationConfigurationType

|Property|Value|
|---|---|
|Description|**Visualization Configuration**|
|DisplayName|**Visualization Configuration Type**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_visualizationconfigurationtype`|
|RequiredLevel|ApplicationRequired|
|Type|Picklist|
|DefaultFormValue|192350000|
|GlobalChoiceName|`msdyn_visualizationconfigtype`|

#### msdyn_VisualizationConfigurationType Choices/Options

|Value|Label|
|---|---|
|192350000|**Configuration 1**|
|192350001|**Configuration 2**|
|192350002|**Configuration 3**|

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
|Description|**Status of the IoT Device Visualization Configuration**|
|DisplayName|**Status**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statecode`|
|RequiredLevel|SystemRequired|
|Type|State|
|DefaultFormValue||
|GlobalChoiceName|`msdyn_iotdevicevisualizationconfiguration_statecode`|

#### statecode Choices/Options

|Value|Details|
|---|---|
|0|Label: **Active**<br />DefaultStatus: 1<br />InvariantName: `Active`|
|1|Label: **Inactive**<br />DefaultStatus: 2<br />InvariantName: `Inactive`|

### <a name="BKMK_statuscode"></a> statuscode

|Property|Value|
|---|---|
|Description|**Reason for the status of the IoT Device Visualization Configuration**|
|DisplayName|**Status Reason**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statuscode`|
|RequiredLevel|None|
|Type|Status|
|DefaultFormValue||
|GlobalChoiceName|`msdyn_iotdevicevisualizationconfiguration_statuscode`|

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

- [business_unit_msdyn_iotdevicevisualizationconfiguration](#BKMK_business_unit_msdyn_iotdevicevisualizationconfiguration)
- [lk_msdyn_iotdevicevisualizationconfiguration_createdby](#BKMK_lk_msdyn_iotdevicevisualizationconfiguration_createdby)
- [lk_msdyn_iotdevicevisualizationconfiguration_createdonbehalfby](#BKMK_lk_msdyn_iotdevicevisualizationconfiguration_createdonbehalfby)
- [lk_msdyn_iotdevicevisualizationconfiguration_modifiedby](#BKMK_lk_msdyn_iotdevicevisualizationconfiguration_modifiedby)
- [lk_msdyn_iotdevicevisualizationconfiguration_modifiedonbehalfby](#BKMK_lk_msdyn_iotdevicevisualizationconfiguration_modifiedonbehalfby)
- [msdyn_iotdevicevisualizationconfiguration_iotdevice](#BKMK_msdyn_iotdevicevisualizationconfiguration_iotdevice)
- [msdyn_iotdevicevisualizationconfiguration_iotdevicecategory](#BKMK_msdyn_iotdevicevisualizationconfiguration_iotdevicecategory)
- [msdyn_iotdevicevisualizationconfiguration_measurement](#BKMK_msdyn_iotdevicevisualizationconfiguration_measurement)
- [owner_msdyn_iotdevicevisualizationconfiguration](#BKMK_owner_msdyn_iotdevicevisualizationconfiguration)
- [team_msdyn_iotdevicevisualizationconfiguration](#BKMK_team_msdyn_iotdevicevisualizationconfiguration)
- [user_msdyn_iotdevicevisualizationconfiguration](#BKMK_user_msdyn_iotdevicevisualizationconfiguration)

### <a name="BKMK_business_unit_msdyn_iotdevicevisualizationconfiguration"></a> business_unit_msdyn_iotdevicevisualizationconfiguration

One-To-Many Relationship: [businessunit business_unit_msdyn_iotdevicevisualizationconfiguration](businessunit.md#BKMK_business_unit_msdyn_iotdevicevisualizationconfiguration)

|Property|Value|
|---|---|
|ReferencedEntity|`businessunit`|
|ReferencedAttribute|`businessunitid`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencingEntityNavigationPropertyName|`owningbusinessunit`|
|IsHierarchical||
|CascadeConfiguration|Archive: `Restrict`<br />Assign: `NoCascade`<br />Delete: `Restrict`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_iotdevicevisualizationconfiguration_createdby"></a> lk_msdyn_iotdevicevisualizationconfiguration_createdby

One-To-Many Relationship: [systemuser lk_msdyn_iotdevicevisualizationconfiguration_createdby](systemuser.md#BKMK_lk_msdyn_iotdevicevisualizationconfiguration_createdby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdby`|
|ReferencingEntityNavigationPropertyName|`createdby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_iotdevicevisualizationconfiguration_createdonbehalfby"></a> lk_msdyn_iotdevicevisualizationconfiguration_createdonbehalfby

One-To-Many Relationship: [systemuser lk_msdyn_iotdevicevisualizationconfiguration_createdonbehalfby](systemuser.md#BKMK_lk_msdyn_iotdevicevisualizationconfiguration_createdonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdonbehalfby`|
|ReferencingEntityNavigationPropertyName|`createdonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_iotdevicevisualizationconfiguration_modifiedby"></a> lk_msdyn_iotdevicevisualizationconfiguration_modifiedby

One-To-Many Relationship: [systemuser lk_msdyn_iotdevicevisualizationconfiguration_modifiedby](systemuser.md#BKMK_lk_msdyn_iotdevicevisualizationconfiguration_modifiedby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedby`|
|ReferencingEntityNavigationPropertyName|`modifiedby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_iotdevicevisualizationconfiguration_modifiedonbehalfby"></a> lk_msdyn_iotdevicevisualizationconfiguration_modifiedonbehalfby

One-To-Many Relationship: [systemuser lk_msdyn_iotdevicevisualizationconfiguration_modifiedonbehalfby](systemuser.md#BKMK_lk_msdyn_iotdevicevisualizationconfiguration_modifiedonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedonbehalfby`|
|ReferencingEntityNavigationPropertyName|`modifiedonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_iotdevicevisualizationconfiguration_iotdevice"></a> msdyn_iotdevicevisualizationconfiguration_iotdevice

One-To-Many Relationship: [msdyn_iotdevice msdyn_iotdevicevisualizationconfiguration_iotdevice](msdyn_iotdevice.md#BKMK_msdyn_iotdevicevisualizationconfiguration_iotdevice)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_iotdevice`|
|ReferencedAttribute|`msdyn_iotdeviceid`|
|ReferencingAttribute|`msdyn_iotdevice`|
|ReferencingEntityNavigationPropertyName|`msdyn_IoTDevice`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_iotdevicevisualizationconfiguration_iotdevicecategory"></a> msdyn_iotdevicevisualizationconfiguration_iotdevicecategory

One-To-Many Relationship: [msdyn_iotdevicecategory msdyn_iotdevicevisualizationconfiguration_iotdevicecategory](msdyn_iotdevicecategory.md#BKMK_msdyn_iotdevicevisualizationconfiguration_iotdevicecategory)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_iotdevicecategory`|
|ReferencedAttribute|`msdyn_iotdevicecategoryid`|
|ReferencingAttribute|`msdyn_iotdevicecategory`|
|ReferencingEntityNavigationPropertyName|`msdyn_IoTDeviceCategory`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_iotdevicevisualizationconfiguration_measurement"></a> msdyn_iotdevicevisualizationconfiguration_measurement

One-To-Many Relationship: [msdyn_iotpropertydefinition msdyn_iotdevicevisualizationconfiguration_measurement](msdyn_iotpropertydefinition.md#BKMK_msdyn_iotdevicevisualizationconfiguration_measurement)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_iotpropertydefinition`|
|ReferencedAttribute|`msdyn_iotpropertydefinitionid`|
|ReferencingAttribute|`msdyn_measurement`|
|ReferencingEntityNavigationPropertyName|`msdyn_Measurement`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_owner_msdyn_iotdevicevisualizationconfiguration"></a> owner_msdyn_iotdevicevisualizationconfiguration

One-To-Many Relationship: [owner owner_msdyn_iotdevicevisualizationconfiguration](owner.md#BKMK_owner_msdyn_iotdevicevisualizationconfiguration)

|Property|Value|
|---|---|
|ReferencedEntity|`owner`|
|ReferencedAttribute|`ownerid`|
|ReferencingAttribute|`ownerid`|
|ReferencingEntityNavigationPropertyName|`ownerid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_team_msdyn_iotdevicevisualizationconfiguration"></a> team_msdyn_iotdevicevisualizationconfiguration

One-To-Many Relationship: [team team_msdyn_iotdevicevisualizationconfiguration](team.md#BKMK_team_msdyn_iotdevicevisualizationconfiguration)

|Property|Value|
|---|---|
|ReferencedEntity|`team`|
|ReferencedAttribute|`teamid`|
|ReferencingAttribute|`owningteam`|
|ReferencingEntityNavigationPropertyName|`owningteam`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_user_msdyn_iotdevicevisualizationconfiguration"></a> user_msdyn_iotdevicevisualizationconfiguration

One-To-Many Relationship: [systemuser user_msdyn_iotdevicevisualizationconfiguration](systemuser.md#BKMK_user_msdyn_iotdevicevisualizationconfiguration)

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

- [msdyn_iotdevicevisualizationconfiguration_AsyncOperations](#BKMK_msdyn_iotdevicevisualizationconfiguration_AsyncOperations)
- [msdyn_iotdevicevisualizationconfiguration_BulkDeleteFailures](#BKMK_msdyn_iotdevicevisualizationconfiguration_BulkDeleteFailures)
- [msdyn_iotdevicevisualizationconfiguration_DuplicateBaseRecord](#BKMK_msdyn_iotdevicevisualizationconfiguration_DuplicateBaseRecord)
- [msdyn_iotdevicevisualizationconfiguration_DuplicateMatchingRecord](#BKMK_msdyn_iotdevicevisualizationconfiguration_DuplicateMatchingRecord)
- [msdyn_iotdevicevisualizationconfiguration_MailboxTrackingFolders](#BKMK_msdyn_iotdevicevisualizationconfiguration_MailboxTrackingFolders)
- [msdyn_iotdevicevisualizationconfiguration_PrincipalObjectAttributeAccesses](#BKMK_msdyn_iotdevicevisualizationconfiguration_PrincipalObjectAttributeAccesses)
- [msdyn_iotdevicevisualizationconfiguration_ProcessSession](#BKMK_msdyn_iotdevicevisualizationconfiguration_ProcessSession)
- [msdyn_iotdevicevisualizationconfiguration_SyncErrors](#BKMK_msdyn_iotdevicevisualizationconfiguration_SyncErrors)

### <a name="BKMK_msdyn_iotdevicevisualizationconfiguration_AsyncOperations"></a> msdyn_iotdevicevisualizationconfiguration_AsyncOperations

Many-To-One Relationship: [asyncoperation msdyn_iotdevicevisualizationconfiguration_AsyncOperations](asyncoperation.md#BKMK_msdyn_iotdevicevisualizationconfiguration_AsyncOperations)

|Property|Value|
|---|---|
|ReferencingEntity|`asyncoperation`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_iotdevicevisualizationconfiguration_AsyncOperations`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_iotdevicevisualizationconfiguration_BulkDeleteFailures"></a> msdyn_iotdevicevisualizationconfiguration_BulkDeleteFailures

Many-To-One Relationship: [bulkdeletefailure msdyn_iotdevicevisualizationconfiguration_BulkDeleteFailures](bulkdeletefailure.md#BKMK_msdyn_iotdevicevisualizationconfiguration_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencingEntity|`bulkdeletefailure`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_iotdevicevisualizationconfiguration_BulkDeleteFailures`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_iotdevicevisualizationconfiguration_DuplicateBaseRecord"></a> msdyn_iotdevicevisualizationconfiguration_DuplicateBaseRecord

Many-To-One Relationship: [duplicaterecord msdyn_iotdevicevisualizationconfiguration_DuplicateBaseRecord](duplicaterecord.md#BKMK_msdyn_iotdevicevisualizationconfiguration_DuplicateBaseRecord)

|Property|Value|
|---|---|
|ReferencingEntity|`duplicaterecord`|
|ReferencingAttribute|`baserecordid`|
|ReferencedEntityNavigationPropertyName|`msdyn_iotdevicevisualizationconfiguration_DuplicateBaseRecord`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_iotdevicevisualizationconfiguration_DuplicateMatchingRecord"></a> msdyn_iotdevicevisualizationconfiguration_DuplicateMatchingRecord

Many-To-One Relationship: [duplicaterecord msdyn_iotdevicevisualizationconfiguration_DuplicateMatchingRecord](duplicaterecord.md#BKMK_msdyn_iotdevicevisualizationconfiguration_DuplicateMatchingRecord)

|Property|Value|
|---|---|
|ReferencingEntity|`duplicaterecord`|
|ReferencingAttribute|`duplicaterecordid`|
|ReferencedEntityNavigationPropertyName|`msdyn_iotdevicevisualizationconfiguration_DuplicateMatchingRecord`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_iotdevicevisualizationconfiguration_MailboxTrackingFolders"></a> msdyn_iotdevicevisualizationconfiguration_MailboxTrackingFolders

Many-To-One Relationship: [mailboxtrackingfolder msdyn_iotdevicevisualizationconfiguration_MailboxTrackingFolders](mailboxtrackingfolder.md#BKMK_msdyn_iotdevicevisualizationconfiguration_MailboxTrackingFolders)

|Property|Value|
|---|---|
|ReferencingEntity|`mailboxtrackingfolder`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_iotdevicevisualizationconfiguration_MailboxTrackingFolders`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_iotdevicevisualizationconfiguration_PrincipalObjectAttributeAccesses"></a> msdyn_iotdevicevisualizationconfiguration_PrincipalObjectAttributeAccesses

Many-To-One Relationship: [principalobjectattributeaccess msdyn_iotdevicevisualizationconfiguration_PrincipalObjectAttributeAccesses](principalobjectattributeaccess.md#BKMK_msdyn_iotdevicevisualizationconfiguration_PrincipalObjectAttributeAccesses)

|Property|Value|
|---|---|
|ReferencingEntity|`principalobjectattributeaccess`|
|ReferencingAttribute|`objectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_iotdevicevisualizationconfiguration_PrincipalObjectAttributeAccesses`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_iotdevicevisualizationconfiguration_ProcessSession"></a> msdyn_iotdevicevisualizationconfiguration_ProcessSession

Many-To-One Relationship: [processsession msdyn_iotdevicevisualizationconfiguration_ProcessSession](processsession.md#BKMK_msdyn_iotdevicevisualizationconfiguration_ProcessSession)

|Property|Value|
|---|---|
|ReferencingEntity|`processsession`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_iotdevicevisualizationconfiguration_ProcessSession`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_iotdevicevisualizationconfiguration_SyncErrors"></a> msdyn_iotdevicevisualizationconfiguration_SyncErrors

Many-To-One Relationship: [syncerror msdyn_iotdevicevisualizationconfiguration_SyncErrors](syncerror.md#BKMK_msdyn_iotdevicevisualizationconfiguration_SyncErrors)

|Property|Value|
|---|---|
|ReferencingEntity|`syncerror`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_iotdevicevisualizationconfiguration_SyncErrors`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|



### See also

[Dataverse table/entity reference](/power-apps/developer/data-platform/reference/about-entity-reference)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   

