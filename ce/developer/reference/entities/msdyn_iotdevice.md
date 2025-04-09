---
title: "IoT Device (msdyn_iotdevice) table/entity reference (Microsoft Dynamics 365)"
description: "Includes schema information and supported messages for the IoT Device (msdyn_iotdevice) table/entity with Microsoft Dynamics 365."
ms.topic: generated-reference
author: JimDaly
ms.author: jdaly
search.audienceType: 
  - developer
---

# IoT Device (msdyn_iotdevice) table/entity reference (Microsoft Dynamics 365)

Represents a connected device that can be registered with an IoT provider.

## Messages

The following table lists the messages for the IoT Device (msdyn_iotdevice) table.
Messages represent operations that can be performed on the table. They may also be events.

| Name <br />Is Event? |Web API Operation |SDK for .NET |
| ---- | ----- |----- |
| `Assign`<br />Event: True |`PATCH` /msdyn_iotdevices(*msdyn_iotdeviceid*)<br />[Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) the `ownerid` property. |<xref:Microsoft.Crm.Sdk.Messages.AssignRequest>|
| `Associate`<br />Event: True |[Associate records](/power-apps/developer/data-platform/webapi/associate-disassociate-entities-using-web-api) |[Associate records](/power-apps/developer/data-platform/org-service/entity-operations-associate-disassociate#use-the-associate-method-or-associaterequest)|
| `BulkRetain`<br />Event: True |<xref:Microsoft.Dynamics.CRM.BulkRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Create`<br />Event: True |`POST` /msdyn_iotdevices<br />See [Create](/powerapps/developer/data-platform/webapi/create-entity-web-api) |[Create records](/power-apps/developer/data-platform/org-service/entity-operations-create#basic-create)|
| `CreateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.CreateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.CreateMultipleRequest>|
| `Delete`<br />Event: True |`DELETE` /msdyn_iotdevices(*msdyn_iotdeviceid*)<br />See [Delete](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-delete) |[Delete records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-delete)|
| `Disassociate`<br />Event: True |[Disassociate records](/power-apps/developer/data-platform/webapi/associate-disassociate-entities-using-web-api) |[Disassociate records](/power-apps/developer/data-platform/org-service/entity-operations-associate-disassociate#use-the-disassociate-method-or-disassociaterequest)|
| `GrantAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.GrantAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.GrantAccessRequest>|
| `IsValidStateTransition`<br />Event: False |<xref:Microsoft.Dynamics.CRM.IsValidStateTransition?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.IsValidStateTransitionRequest>|
| `ModifyAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.ModifyAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.ModifyAccessRequest>|
| `PurgeRetainedContent`<br />Event: True |<xref:Microsoft.Dynamics.CRM.PurgeRetainedContent?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Restore`<br />Event: True |<xref:Microsoft.Dynamics.CRM.Restore?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retain`<br />Event: True |<xref:Microsoft.Dynamics.CRM.Retain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retrieve`<br />Event: True |`GET` /msdyn_iotdevices(*msdyn_iotdeviceid*)<br />See [Retrieve](/powerapps/developer/data-platform/webapi/retrieve-entity-using-web-api) |[Retrieve records](/power-apps/developer/data-platform/org-service/entity-operations-retrieve)|
| `RetrieveMultiple`<br />Event: True |`GET` /msdyn_iotdevices<br />See [Query data](/power-apps/developer/data-platform/webapi/query-data-web-api) |[Query data](/power-apps/developer/data-platform/org-service/entity-operations-query-data)|
| `RetrievePrincipalAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RetrievePrincipalAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RetrievePrincipalAccessRequest>|
| `RetrieveSharedPrincipalsAndAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RetrieveSharedPrincipalsAndAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RetrieveSharedPrincipalsAndAccessRequest>|
| `RevokeAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RevokeAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RevokeAccessRequest>|
| `RollbackRetain`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RollbackRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `SetState`<br />Event: True |`PATCH` /msdyn_iotdevices(*msdyn_iotdeviceid*)<br />[Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) the `statecode` and `statuscode` properties. |<xref:Microsoft.Crm.Sdk.Messages.SetStateRequest>|
| `Update`<br />Event: True |`PATCH` /msdyn_iotdevices(*msdyn_iotdeviceid*)<br />See [Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) |[Update records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-update)|
| `UpdateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.UpdateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpdateMultipleRequest>|
| `Upsert`<br />Event: False |`PATCH` /msdyn_iotdevices(*msdyn_iotdeviceid*)<br />See [Upsert a table row](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#upsert-a-table-row) |<xref:Microsoft.Xrm.Sdk.Messages.UpsertRequest>|
| `UpsertMultiple`<br />Event: False |<xref:Microsoft.Dynamics.CRM.UpsertMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpsertMultipleRequest>|
| `ValidateRetentionConfig`<br />Event: True |<xref:Microsoft.Dynamics.CRM.ValidateRetentionConfig?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|

## Properties

The following table lists selected properties for the IoT Device (msdyn_iotdevice) table.

|Property|Value|
| --- | --- |
| **DisplayName** | **IoT Device** |
| **DisplayCollectionName** | **IoT Devices** |
| **SchemaName** | `msdyn_iotdevice` |
| **CollectionSchemaName** | `msdyn_iotdevices` |
| **EntitySetName** | `msdyn_iotdevices`|
| **LogicalName** | `msdyn_iotdevice` |
| **LogicalCollectionName** | `msdyn_iotdevices` |
| **PrimaryIdAttribute** | `msdyn_iotdeviceid` |
| **PrimaryNameAttribute** |`msdyn_name` |
| **TableType** | `Standard` |
| **OwnershipType** | `UserOwned` |

## Writable columns/attributes

These columns/attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [ImportSequenceNumber](#BKMK_ImportSequenceNumber)
- [msdyn_Account](#BKMK_msdyn_Account)
- [msdyn_Category](#BKMK_msdyn_Category)
- [msdyn_ConnectionState](#BKMK_msdyn_ConnectionState)
- [msdyn_DeviceId](#BKMK_msdyn_DeviceId)
- [msdyn_DeviceReportedProperties](#BKMK_msdyn_DeviceReportedProperties)
- [msdyn_DeviceSettings](#BKMK_msdyn_DeviceSettings)
- [msdyn_iotdeviceId](#BKMK_msdyn_iotdeviceId)
- [msdyn_IoTProviderInstance](#BKMK_msdyn_IoTProviderInstance)
- [msdyn_IsSimulated](#BKMK_msdyn_IsSimulated)
- [msdyn_LastActivityTime](#BKMK_msdyn_LastActivityTime)
- [msdyn_LastCommandSent](#BKMK_msdyn_LastCommandSent)
- [msdyn_LastCommandSentTime](#BKMK_msdyn_LastCommandSentTime)
- [msdyn_name](#BKMK_msdyn_name)
- [msdyn_RegistrationMessage](#BKMK_msdyn_RegistrationMessage)
- [msdyn_RegistrationStatus](#BKMK_msdyn_RegistrationStatus)
- [msdyn_Tags](#BKMK_msdyn_Tags)
- [msdyn_Timezone](#BKMK_msdyn_Timezone)
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

### <a name="BKMK_msdyn_Account"></a> msdyn_Account

|Property|Value|
|---|---|
|Description|**Parent customer of this device**|
|DisplayName|**Account**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_account`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|account|

### <a name="BKMK_msdyn_Category"></a> msdyn_Category

|Property|Value|
|---|---|
|Description|**The device category that this IoT device belongs to.**|
|DisplayName|**Category**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_category`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|msdyn_iotdevicecategory|

### <a name="BKMK_msdyn_ConnectionState"></a> msdyn_ConnectionState

|Property|Value|
|---|---|
|Description|**The connection status of the device (Disconnected or Connected)**|
|DisplayName|**Connection State**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_connectionstate`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`msdyn_iotdevice_msdyn_connectionstate`|
|DefaultValue|False|
|True Label|Connected|
|False Label|Disconnected|

### <a name="BKMK_msdyn_DeviceId"></a> msdyn_DeviceId

|Property|Value|
|---|---|
|Description|**Device ID used to register with the IoT provider.**|
|DisplayName|**Device ID**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_deviceid`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdyn_DeviceReportedProperties"></a> msdyn_DeviceReportedProperties

|Property|Value|
|---|---|
|Description|**Reported Properties data for Device**|
|DisplayName|**Device Reported Properties**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_devicereportedproperties`|
|RequiredLevel|None|
|Type|Memo|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|8000|

### <a name="BKMK_msdyn_DeviceSettings"></a> msdyn_DeviceSettings

|Property|Value|
|---|---|
|Description|**The editable properties for a device.**|
|DisplayName|**Device Settings**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_devicesettings`|
|RequiredLevel|None|
|Type|Memo|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|8000|

### <a name="BKMK_msdyn_iotdeviceId"></a> msdyn_iotdeviceId

|Property|Value|
|---|---|
|Description|**Unique identifier for entity instances**|
|DisplayName|**IoT Device**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`msdyn_iotdeviceid`|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|

### <a name="BKMK_msdyn_IoTProviderInstance"></a> msdyn_IoTProviderInstance

|Property|Value|
|---|---|
|Description|**The IoT Provider Instance to which this device belongs.**|
|DisplayName|**IoT Provider Instance**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_iotproviderinstance`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|msdyn_iotproviderinstance|

### <a name="BKMK_msdyn_IsSimulated"></a> msdyn_IsSimulated

|Property|Value|
|---|---|
|Description|**Select “Yes” if this device is simulated for testing and development purposes. Select “No” if this is a real device.​**|
|DisplayName|**Simulated**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_issimulated`|
|RequiredLevel|Recommended|
|Type|Picklist|
|DefaultFormValue|-1|
|GlobalChoiceName|`msdyn_iotdevice_msdyn_issimulated`|

#### msdyn_IsSimulated Choices/Options

|Value|Label|
|---|---|
|192350000|**Yes**|
|192350001|**No**|

### <a name="BKMK_msdyn_LastActivityTime"></a> msdyn_LastActivityTime

|Property|Value|
|---|---|
|Description|**The last activity time of the device**|
|DisplayName|**Last Activity Time**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_lastactivitytime`|
|RequiredLevel|None|
|Type|DateTime|
|CanChangeDateTimeBehavior|True|
|DateTimeBehavior|UserLocal|
|Format|DateAndTime|
|ImeMode|Inactive|
|SourceTypeMask|0|

### <a name="BKMK_msdyn_LastCommandSent"></a> msdyn_LastCommandSent

|Property|Value|
|---|---|
|Description||
|DisplayName|**[Deprecated] Last Command Sent**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_lastcommandsent`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|msdyn_iotdevicecommand|

### <a name="BKMK_msdyn_LastCommandSentTime"></a> msdyn_LastCommandSentTime

|Property|Value|
|---|---|
|Description||
|DisplayName|**[Deprecated] Last Command Sent Time**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_lastcommandsenttime`|
|RequiredLevel|None|
|Type|DateTime|
|CanChangeDateTimeBehavior|True|
|DateTimeBehavior|UserLocal|
|Format|DateAndTime|
|ImeMode|Auto|
|SourceTypeMask|0|

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

### <a name="BKMK_msdyn_RegistrationMessage"></a> msdyn_RegistrationMessage

|Property|Value|
|---|---|
|Description|**A message field that explains the IoT Registration Status.**|
|DisplayName|**Registration Message**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_registrationmessage`|
|RequiredLevel|None|
|Type|Memo|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|2000|

### <a name="BKMK_msdyn_RegistrationStatus"></a> msdyn_RegistrationStatus

|Property|Value|
|---|---|
|Description|**A status field that denotes whether the device is registered with the IoT provider.**|
|DisplayName|**Registration Status**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_registrationstatus`|
|RequiredLevel|None|
|Type|Picklist|
|DefaultFormValue|-1|
|GlobalChoiceName|`msdyn_iotdevice_msdyn_registrationstatus`|

#### msdyn_RegistrationStatus Choices/Options

|Value|Label|
|---|---|
|192350000|**Unknown**|
|192350001|**Unregistered**|
|192350002|**In Progress**|
|192350003|**Registered**|
|192350004|**Error**|

### <a name="BKMK_msdyn_Tags"></a> msdyn_Tags

|Property|Value|
|---|---|
|Description|**Identifying Tags for the Device**|
|DisplayName|**Device Tags**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_tags`|
|RequiredLevel|None|
|Type|Memo|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|8000|

### <a name="BKMK_msdyn_Timezone"></a> msdyn_Timezone

|Property|Value|
|---|---|
|Description|**The device's time zone.**|
|DisplayName|**Time Zone**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_timezone`|
|RequiredLevel|None|
|Type|Integer|
|MaxValue|1500|
|MinValue|-1500|

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
|Description|**Status of the IoT Device**|
|DisplayName|**Status**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statecode`|
|RequiredLevel|SystemRequired|
|Type|State|
|DefaultFormValue||
|GlobalChoiceName|`msdyn_iotdevice_statecode`|

#### statecode Choices/Options

|Value|Details|
|---|---|
|0|Label: **Active**<br />DefaultStatus: 1<br />InvariantName: `Active`|
|1|Label: **Inactive**<br />DefaultStatus: 2<br />InvariantName: `Inactive`|

### <a name="BKMK_statuscode"></a> statuscode

|Property|Value|
|---|---|
|Description|**Reason for the status of the IoT Device**|
|DisplayName|**Status Reason**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statuscode`|
|RequiredLevel|None|
|Type|Status|
|DefaultFormValue||
|GlobalChoiceName|`msdyn_iotdevice_statuscode`|

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

- [business_unit_msdyn_iotdevice](#BKMK_business_unit_msdyn_iotdevice)
- [lk_msdyn_iotdevice_createdby](#BKMK_lk_msdyn_iotdevice_createdby)
- [lk_msdyn_iotdevice_createdonbehalfby](#BKMK_lk_msdyn_iotdevice_createdonbehalfby)
- [lk_msdyn_iotdevice_modifiedby](#BKMK_lk_msdyn_iotdevice_modifiedby)
- [lk_msdyn_iotdevice_modifiedonbehalfby](#BKMK_lk_msdyn_iotdevice_modifiedonbehalfby)
- [msdyn_account_msdyn_iotdevice_Account](#BKMK_msdyn_account_msdyn_iotdevice_Account)
- [msdyn_msdyn_iotdevicecategory_msdyn_iotdevice_Category](#BKMK_msdyn_msdyn_iotdevicecategory_msdyn_iotdevice_Category)
- [msdyn_msdyn_iotdevicecommand_msdyn_iotdevice_LastCommandSent](#BKMK_msdyn_msdyn_iotdevicecommand_msdyn_iotdevice_LastCommandSent)
- [msdyn_msdyn_iotproviderinstance_msdyn_iotdevice_IoTProviderInstance](#BKMK_msdyn_msdyn_iotproviderinstance_msdyn_iotdevice_IoTProviderInstance)
- [owner_msdyn_iotdevice](#BKMK_owner_msdyn_iotdevice)
- [team_msdyn_iotdevice](#BKMK_team_msdyn_iotdevice)
- [user_msdyn_iotdevice](#BKMK_user_msdyn_iotdevice)

### <a name="BKMK_business_unit_msdyn_iotdevice"></a> business_unit_msdyn_iotdevice

One-To-Many Relationship: [businessunit business_unit_msdyn_iotdevice](businessunit.md#BKMK_business_unit_msdyn_iotdevice)

|Property|Value|
|---|---|
|ReferencedEntity|`businessunit`|
|ReferencedAttribute|`businessunitid`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencingEntityNavigationPropertyName|`owningbusinessunit`|
|IsHierarchical||
|CascadeConfiguration|Archive: `Restrict`<br />Assign: `NoCascade`<br />Delete: `Restrict`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_iotdevice_createdby"></a> lk_msdyn_iotdevice_createdby

One-To-Many Relationship: [systemuser lk_msdyn_iotdevice_createdby](systemuser.md#BKMK_lk_msdyn_iotdevice_createdby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdby`|
|ReferencingEntityNavigationPropertyName|`createdby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_iotdevice_createdonbehalfby"></a> lk_msdyn_iotdevice_createdonbehalfby

One-To-Many Relationship: [systemuser lk_msdyn_iotdevice_createdonbehalfby](systemuser.md#BKMK_lk_msdyn_iotdevice_createdonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdonbehalfby`|
|ReferencingEntityNavigationPropertyName|`createdonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_iotdevice_modifiedby"></a> lk_msdyn_iotdevice_modifiedby

One-To-Many Relationship: [systemuser lk_msdyn_iotdevice_modifiedby](systemuser.md#BKMK_lk_msdyn_iotdevice_modifiedby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedby`|
|ReferencingEntityNavigationPropertyName|`modifiedby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_iotdevice_modifiedonbehalfby"></a> lk_msdyn_iotdevice_modifiedonbehalfby

One-To-Many Relationship: [systemuser lk_msdyn_iotdevice_modifiedonbehalfby](systemuser.md#BKMK_lk_msdyn_iotdevice_modifiedonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedonbehalfby`|
|ReferencingEntityNavigationPropertyName|`modifiedonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_account_msdyn_iotdevice_Account"></a> msdyn_account_msdyn_iotdevice_Account

One-To-Many Relationship: [account msdyn_account_msdyn_iotdevice_Account](account.md#BKMK_msdyn_account_msdyn_iotdevice_Account)

|Property|Value|
|---|---|
|ReferencedEntity|`account`|
|ReferencedAttribute|`accountid`|
|ReferencingAttribute|`msdyn_account`|
|ReferencingEntityNavigationPropertyName|`msdyn_Account`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `Cascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_msdyn_iotdevicecategory_msdyn_iotdevice_Category"></a> msdyn_msdyn_iotdevicecategory_msdyn_iotdevice_Category

One-To-Many Relationship: [msdyn_iotdevicecategory msdyn_msdyn_iotdevicecategory_msdyn_iotdevice_Category](msdyn_iotdevicecategory.md#BKMK_msdyn_msdyn_iotdevicecategory_msdyn_iotdevice_Category)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_iotdevicecategory`|
|ReferencedAttribute|`msdyn_iotdevicecategoryid`|
|ReferencingAttribute|`msdyn_category`|
|ReferencingEntityNavigationPropertyName|`msdyn_Category`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_msdyn_iotdevicecommand_msdyn_iotdevice_LastCommandSent"></a> msdyn_msdyn_iotdevicecommand_msdyn_iotdevice_LastCommandSent

One-To-Many Relationship: [msdyn_iotdevicecommand msdyn_msdyn_iotdevicecommand_msdyn_iotdevice_LastCommandSent](msdyn_iotdevicecommand.md#BKMK_msdyn_msdyn_iotdevicecommand_msdyn_iotdevice_LastCommandSent)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_iotdevicecommand`|
|ReferencedAttribute|`msdyn_iotdevicecommandid`|
|ReferencingAttribute|`msdyn_lastcommandsent`|
|ReferencingEntityNavigationPropertyName|`msdyn_LastCommandSent`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_msdyn_iotproviderinstance_msdyn_iotdevice_IoTProviderInstance"></a> msdyn_msdyn_iotproviderinstance_msdyn_iotdevice_IoTProviderInstance

One-To-Many Relationship: [msdyn_iotproviderinstance msdyn_msdyn_iotproviderinstance_msdyn_iotdevice_IoTProviderInstance](msdyn_iotproviderinstance.md#BKMK_msdyn_msdyn_iotproviderinstance_msdyn_iotdevice_IoTProviderInstance)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_iotproviderinstance`|
|ReferencedAttribute|`msdyn_iotproviderinstanceid`|
|ReferencingAttribute|`msdyn_iotproviderinstance`|
|ReferencingEntityNavigationPropertyName|`msdyn_IoTProviderInstance`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Restrict`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_owner_msdyn_iotdevice"></a> owner_msdyn_iotdevice

One-To-Many Relationship: [owner owner_msdyn_iotdevice](owner.md#BKMK_owner_msdyn_iotdevice)

|Property|Value|
|---|---|
|ReferencedEntity|`owner`|
|ReferencedAttribute|`ownerid`|
|ReferencingAttribute|`ownerid`|
|ReferencingEntityNavigationPropertyName|`ownerid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_team_msdyn_iotdevice"></a> team_msdyn_iotdevice

One-To-Many Relationship: [team team_msdyn_iotdevice](team.md#BKMK_team_msdyn_iotdevice)

|Property|Value|
|---|---|
|ReferencedEntity|`team`|
|ReferencedAttribute|`teamid`|
|ReferencingAttribute|`owningteam`|
|ReferencingEntityNavigationPropertyName|`owningteam`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_user_msdyn_iotdevice"></a> user_msdyn_iotdevice

One-To-Many Relationship: [systemuser user_msdyn_iotdevice](systemuser.md#BKMK_user_msdyn_iotdevice)

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

- [msdyn_iotdevice_Annotations](#BKMK_msdyn_iotdevice_Annotations)
- [msdyn_iotdevice_AsyncOperations](#BKMK_msdyn_iotdevice_AsyncOperations)
- [msdyn_iotdevice_BulkDeleteFailures](#BKMK_msdyn_iotdevice_BulkDeleteFailures)
- [msdyn_iotdevice_connections1](#BKMK_msdyn_iotdevice_connections1)
- [msdyn_iotdevice_connections2](#BKMK_msdyn_iotdevice_connections2)
- [msdyn_iotdevice_DuplicateBaseRecord](#BKMK_msdyn_iotdevice_DuplicateBaseRecord)
- [msdyn_iotdevice_DuplicateMatchingRecord](#BKMK_msdyn_iotdevice_DuplicateMatchingRecord)
- [msdyn_iotdevice_MailboxTrackingFolders](#BKMK_msdyn_iotdevice_MailboxTrackingFolders)
- [msdyn_iotdevice_PrincipalObjectAttributeAccesses](#BKMK_msdyn_iotdevice_PrincipalObjectAttributeAccesses)
- [msdyn_iotdevice_ProcessSession](#BKMK_msdyn_iotdevice_ProcessSession)
- [msdyn_iotdevice_SyncErrors](#BKMK_msdyn_iotdevice_SyncErrors)
- [msdyn_iotdevicevisualizationconfiguration_iotdevice](#BKMK_msdyn_iotdevicevisualizationconfiguration_iotdevice)
- [msdyn_msdyn_iotdevice_msdyn_iotalert_Device](#BKMK_msdyn_msdyn_iotdevice_msdyn_iotalert_Device)
- [msdyn_msdyn_iotdevice_msdyn_iotdevicecommand_Device](#BKMK_msdyn_msdyn_iotdevice_msdyn_iotdevicecommand_Device)
- [msdyn_msdyn_iotdevice_msdyn_iotdevicedatahistory_Device](#BKMK_msdyn_msdyn_iotdevice_msdyn_iotdevicedatahistory_Device)
- [msdyn_msdyn_iotdevice_msdyn_iotdeviceregistrationhistory_Device](#BKMK_msdyn_msdyn_iotdevice_msdyn_iotdeviceregistrationhistory_Device)

### <a name="BKMK_msdyn_iotdevice_Annotations"></a> msdyn_iotdevice_Annotations

Many-To-One Relationship: [annotation msdyn_iotdevice_Annotations](annotation.md#BKMK_msdyn_iotdevice_Annotations)

|Property|Value|
|---|---|
|ReferencingEntity|`annotation`|
|ReferencingAttribute|`objectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_iotdevice_Annotations`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_iotdevice_AsyncOperations"></a> msdyn_iotdevice_AsyncOperations

Many-To-One Relationship: [asyncoperation msdyn_iotdevice_AsyncOperations](asyncoperation.md#BKMK_msdyn_iotdevice_AsyncOperations)

|Property|Value|
|---|---|
|ReferencingEntity|`asyncoperation`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_iotdevice_AsyncOperations`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_iotdevice_BulkDeleteFailures"></a> msdyn_iotdevice_BulkDeleteFailures

Many-To-One Relationship: [bulkdeletefailure msdyn_iotdevice_BulkDeleteFailures](bulkdeletefailure.md#BKMK_msdyn_iotdevice_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencingEntity|`bulkdeletefailure`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_iotdevice_BulkDeleteFailures`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_iotdevice_connections1"></a> msdyn_iotdevice_connections1

Many-To-One Relationship: [connection msdyn_iotdevice_connections1](connection.md#BKMK_msdyn_iotdevice_connections1)

|Property|Value|
|---|---|
|ReferencingEntity|`connection`|
|ReferencingAttribute|`record1id`|
|ReferencedEntityNavigationPropertyName|`msdyn_iotdevice_connections1`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 100<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_iotdevice_connections2"></a> msdyn_iotdevice_connections2

Many-To-One Relationship: [connection msdyn_iotdevice_connections2](connection.md#BKMK_msdyn_iotdevice_connections2)

|Property|Value|
|---|---|
|ReferencingEntity|`connection`|
|ReferencingAttribute|`record2id`|
|ReferencedEntityNavigationPropertyName|`msdyn_iotdevice_connections2`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_iotdevice_DuplicateBaseRecord"></a> msdyn_iotdevice_DuplicateBaseRecord

Many-To-One Relationship: [duplicaterecord msdyn_iotdevice_DuplicateBaseRecord](duplicaterecord.md#BKMK_msdyn_iotdevice_DuplicateBaseRecord)

|Property|Value|
|---|---|
|ReferencingEntity|`duplicaterecord`|
|ReferencingAttribute|`baserecordid`|
|ReferencedEntityNavigationPropertyName|`msdyn_iotdevice_DuplicateBaseRecord`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_iotdevice_DuplicateMatchingRecord"></a> msdyn_iotdevice_DuplicateMatchingRecord

Many-To-One Relationship: [duplicaterecord msdyn_iotdevice_DuplicateMatchingRecord](duplicaterecord.md#BKMK_msdyn_iotdevice_DuplicateMatchingRecord)

|Property|Value|
|---|---|
|ReferencingEntity|`duplicaterecord`|
|ReferencingAttribute|`duplicaterecordid`|
|ReferencedEntityNavigationPropertyName|`msdyn_iotdevice_DuplicateMatchingRecord`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_iotdevice_MailboxTrackingFolders"></a> msdyn_iotdevice_MailboxTrackingFolders

Many-To-One Relationship: [mailboxtrackingfolder msdyn_iotdevice_MailboxTrackingFolders](mailboxtrackingfolder.md#BKMK_msdyn_iotdevice_MailboxTrackingFolders)

|Property|Value|
|---|---|
|ReferencingEntity|`mailboxtrackingfolder`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_iotdevice_MailboxTrackingFolders`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_iotdevice_PrincipalObjectAttributeAccesses"></a> msdyn_iotdevice_PrincipalObjectAttributeAccesses

Many-To-One Relationship: [principalobjectattributeaccess msdyn_iotdevice_PrincipalObjectAttributeAccesses](principalobjectattributeaccess.md#BKMK_msdyn_iotdevice_PrincipalObjectAttributeAccesses)

|Property|Value|
|---|---|
|ReferencingEntity|`principalobjectattributeaccess`|
|ReferencingAttribute|`objectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_iotdevice_PrincipalObjectAttributeAccesses`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_iotdevice_ProcessSession"></a> msdyn_iotdevice_ProcessSession

Many-To-One Relationship: [processsession msdyn_iotdevice_ProcessSession](processsession.md#BKMK_msdyn_iotdevice_ProcessSession)

|Property|Value|
|---|---|
|ReferencingEntity|`processsession`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_iotdevice_ProcessSession`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_iotdevice_SyncErrors"></a> msdyn_iotdevice_SyncErrors

Many-To-One Relationship: [syncerror msdyn_iotdevice_SyncErrors](syncerror.md#BKMK_msdyn_iotdevice_SyncErrors)

|Property|Value|
|---|---|
|ReferencingEntity|`syncerror`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_iotdevice_SyncErrors`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_iotdevicevisualizationconfiguration_iotdevice"></a> msdyn_iotdevicevisualizationconfiguration_iotdevice

Many-To-One Relationship: [msdyn_iotdevicevisualizationconfiguration msdyn_iotdevicevisualizationconfiguration_iotdevice](msdyn_iotdevicevisualizationconfiguration.md#BKMK_msdyn_iotdevicevisualizationconfiguration_iotdevice)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_iotdevicevisualizationconfiguration`|
|ReferencingAttribute|`msdyn_iotdevice`|
|ReferencedEntityNavigationPropertyName|`msdyn_iotdevicevisualizationconfiguration_iotdevice`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_msdyn_iotdevice_msdyn_iotalert_Device"></a> msdyn_msdyn_iotdevice_msdyn_iotalert_Device

Many-To-One Relationship: [msdyn_iotalert msdyn_msdyn_iotdevice_msdyn_iotalert_Device](msdyn_iotalert.md#BKMK_msdyn_msdyn_iotdevice_msdyn_iotalert_Device)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_iotalert`|
|ReferencingAttribute|`msdyn_device`|
|ReferencedEntityNavigationPropertyName|`msdyn_msdyn_iotdevice_msdyn_iotalert_Device`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_msdyn_iotdevice_msdyn_iotdevicecommand_Device"></a> msdyn_msdyn_iotdevice_msdyn_iotdevicecommand_Device

Many-To-One Relationship: [msdyn_iotdevicecommand msdyn_msdyn_iotdevice_msdyn_iotdevicecommand_Device](msdyn_iotdevicecommand.md#BKMK_msdyn_msdyn_iotdevice_msdyn_iotdevicecommand_Device)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_iotdevicecommand`|
|ReferencingAttribute|`msdyn_device`|
|ReferencedEntityNavigationPropertyName|`msdyn_msdyn_iotdevice_msdyn_iotdevicecommand_Device`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_msdyn_iotdevice_msdyn_iotdevicedatahistory_Device"></a> msdyn_msdyn_iotdevice_msdyn_iotdevicedatahistory_Device

Many-To-One Relationship: [msdyn_iotdevicedatahistory msdyn_msdyn_iotdevice_msdyn_iotdevicedatahistory_Device](msdyn_iotdevicedatahistory.md#BKMK_msdyn_msdyn_iotdevice_msdyn_iotdevicedatahistory_Device)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_iotdevicedatahistory`|
|ReferencingAttribute|`msdyn_device`|
|ReferencedEntityNavigationPropertyName|`msdyn_msdyn_iotdevice_msdyn_iotdevicedatahistory_Device`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_msdyn_iotdevice_msdyn_iotdeviceregistrationhistory_Device"></a> msdyn_msdyn_iotdevice_msdyn_iotdeviceregistrationhistory_Device

Many-To-One Relationship: [msdyn_iotdeviceregistrationhistory msdyn_msdyn_iotdevice_msdyn_iotdeviceregistrationhistory_Device](msdyn_iotdeviceregistrationhistory.md#BKMK_msdyn_msdyn_iotdevice_msdyn_iotdeviceregistrationhistory_Device)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_iotdeviceregistrationhistory`|
|ReferencingAttribute|`msdyn_device`|
|ReferencedEntityNavigationPropertyName|`msdyn_msdyn_iotdevice_msdyn_iotdeviceregistrationhistory_Device`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|



### See also

[Dataverse table/entity reference](/power-apps/developer/data-platform/reference/about-entity-reference)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   

