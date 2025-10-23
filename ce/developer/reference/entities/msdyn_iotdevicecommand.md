---
title: "IoT Device Command (msdyn_iotdevicecommand) table/entity reference (Microsoft Dynamics 365)"
description: "Includes schema information and supported messages for the IoT Device Command (msdyn_iotdevicecommand) table/entity with Microsoft Dynamics 365."
ms.topic: generated-reference
author: JimDaly
ms.author: jdaly
search.audienceType: 
  - developer
---

# IoT Device Command (msdyn_iotdevicecommand) table/entity reference (Microsoft Dynamics 365)

Represents an outgoing message to a device connected to an IoT provider.

## Messages

The following table lists the messages for the IoT Device Command (msdyn_iotdevicecommand) table.
Messages represent operations that can be performed on the table. They may also be events.

| Name <br />Is Event? |Web API Operation |SDK for .NET |
| ---- | ----- |----- |
| `Assign`<br />Event: True |`PATCH` /msdyn_iotdevicecommands(*msdyn_iotdevicecommandid*)<br />[Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) the `ownerid` property. |<xref:Microsoft.Crm.Sdk.Messages.AssignRequest>|
| `Associate`<br />Event: True |[Associate records](/power-apps/developer/data-platform/webapi/associate-disassociate-entities-using-web-api) |[Associate records](/power-apps/developer/data-platform/org-service/entity-operations-associate-disassociate#use-the-associate-method-or-associaterequest)|
| `BulkRetain`<br />Event: True |<xref:Microsoft.Dynamics.CRM.BulkRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Create`<br />Event: True |`POST` /msdyn_iotdevicecommands<br />See [Create](/powerapps/developer/data-platform/webapi/create-entity-web-api) |[Create records](/power-apps/developer/data-platform/org-service/entity-operations-create#basic-create)|
| `CreateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.CreateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.CreateMultipleRequest>|
| `Delete`<br />Event: True |`DELETE` /msdyn_iotdevicecommands(*msdyn_iotdevicecommandid*)<br />See [Delete](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-delete) |[Delete records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-delete)|
| `Disassociate`<br />Event: True |[Disassociate records](/power-apps/developer/data-platform/webapi/associate-disassociate-entities-using-web-api) |[Disassociate records](/power-apps/developer/data-platform/org-service/entity-operations-associate-disassociate#use-the-disassociate-method-or-disassociaterequest)|
| `GrantAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.GrantAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.GrantAccessRequest>|
| `IsValidStateTransition`<br />Event: False |<xref:Microsoft.Dynamics.CRM.IsValidStateTransition?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.IsValidStateTransitionRequest>|
| `ModifyAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.ModifyAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.ModifyAccessRequest>|
| `PurgeRetainedContent`<br />Event: True |<xref:Microsoft.Dynamics.CRM.PurgeRetainedContent?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Restore`<br />Event: True |<xref:Microsoft.Dynamics.CRM.Restore?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retain`<br />Event: True |<xref:Microsoft.Dynamics.CRM.Retain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retrieve`<br />Event: True |`GET` /msdyn_iotdevicecommands(*msdyn_iotdevicecommandid*)<br />See [Retrieve](/powerapps/developer/data-platform/webapi/retrieve-entity-using-web-api) |[Retrieve records](/power-apps/developer/data-platform/org-service/entity-operations-retrieve)|
| `RetrieveMultiple`<br />Event: True |`GET` /msdyn_iotdevicecommands<br />See [Query data](/power-apps/developer/data-platform/webapi/query-data-web-api) |[Query data](/power-apps/developer/data-platform/org-service/entity-operations-query-data)|
| `RetrievePrincipalAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RetrievePrincipalAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RetrievePrincipalAccessRequest>|
| `RetrieveSharedPrincipalsAndAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RetrieveSharedPrincipalsAndAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RetrieveSharedPrincipalsAndAccessRequest>|
| `RevokeAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RevokeAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RevokeAccessRequest>|
| `RollbackRetain`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RollbackRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `SetState`<br />Event: True |`PATCH` /msdyn_iotdevicecommands(*msdyn_iotdevicecommandid*)<br />[Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) the `statecode` and `statuscode` properties. |<xref:Microsoft.Crm.Sdk.Messages.SetStateRequest>|
| `Update`<br />Event: True |`PATCH` /msdyn_iotdevicecommands(*msdyn_iotdevicecommandid*)<br />See [Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) |[Update records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-update)|
| `UpdateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.UpdateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpdateMultipleRequest>|
| `Upsert`<br />Event: False |`PATCH` /msdyn_iotdevicecommands(*msdyn_iotdevicecommandid*)<br />See [Upsert a table row](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#upsert-a-table-row) |<xref:Microsoft.Xrm.Sdk.Messages.UpsertRequest>|
| `UpsertMultiple`<br />Event: False |<xref:Microsoft.Dynamics.CRM.UpsertMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpsertMultipleRequest>|
| `ValidateRetentionConfig`<br />Event: True |<xref:Microsoft.Dynamics.CRM.ValidateRetentionConfig?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|

## Properties

The following table lists selected properties for the IoT Device Command (msdyn_iotdevicecommand) table.

|Property|Value|
| --- | --- |
| **DisplayName** | **IoT Device Command** |
| **DisplayCollectionName** | **IoT Device Commands** |
| **SchemaName** | `msdyn_iotdevicecommand` |
| **CollectionSchemaName** | `msdyn_iotdevicecommands` |
| **EntitySetName** | `msdyn_iotdevicecommands`|
| **LogicalName** | `msdyn_iotdevicecommand` |
| **LogicalCollectionName** | `msdyn_iotdevicecommands` |
| **PrimaryIdAttribute** | `msdyn_iotdevicecommandid` |
| **PrimaryNameAttribute** |`msdyn_name` |
| **TableType** | `Standard` |
| **OwnershipType** | `UserOwned` |

## Writable columns/attributes

These columns/attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [ImportSequenceNumber](#BKMK_ImportSequenceNumber)
- [msdyn_Command](#BKMK_msdyn_Command)
- [msdyn_CommandStatus](#BKMK_msdyn_CommandStatus)
- [msdyn_CommandStatusReason](#BKMK_msdyn_CommandStatusReason)
- [msdyn_CustomerAsset](#BKMK_msdyn_CustomerAsset)
- [msdyn_Device](#BKMK_msdyn_Device)
- [msdyn_DeviceID](#BKMK_msdyn_DeviceID)
- [msdyn_iotdevicecommandId](#BKMK_msdyn_iotdevicecommandId)
- [msdyn_Message](#BKMK_msdyn_Message)
- [msdyn_name](#BKMK_msdyn_name)
- [msdyn_ParentAlert](#BKMK_msdyn_ParentAlert)
- [msdyn_SendToAllConnectedDevices](#BKMK_msdyn_SendToAllConnectedDevices)
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

### <a name="BKMK_msdyn_Command"></a> msdyn_Command

|Property|Value|
|---|---|
|Description|**This optional field denotes the command definition that is used to construct the command string.**|
|DisplayName|**Command**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_command`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|msdyn_iotdevicecommanddefinition|

### <a name="BKMK_msdyn_CommandStatus"></a> msdyn_CommandStatus

|Property|Value|
|---|---|
|Description|**Describes the status of the command. If this stays at "In Progress" for a long time, verify the IoT endpoint configuration.**|
|DisplayName|**Command Status**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_commandstatus`|
|RequiredLevel|None|
|Type|Picklist|
|DefaultFormValue|192350000|
|GlobalChoiceName|`msdyn_iotdevicecommand_msdyn_commandstatus`|

#### msdyn_CommandStatus Choices/Options

|Value|Label|
|---|---|
|192350000|**In Progress**|
|192350001|**Sent**|
|192350002|**Error**|

### <a name="BKMK_msdyn_CommandStatusReason"></a> msdyn_CommandStatusReason

|Property|Value|
|---|---|
|Description|**A reason field that explains the command status.**|
|DisplayName|**Command Status Reason**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_commandstatusreason`|
|RequiredLevel|None|
|Type|Memo|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|2000|

### <a name="BKMK_msdyn_CustomerAsset"></a> msdyn_CustomerAsset

|Property|Value|
|---|---|
|Description|**The command will be sent to a device connected to this asset.**|
|DisplayName|**Customer Asset**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_customerasset`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|msdyn_customerasset|

### <a name="BKMK_msdyn_Device"></a> msdyn_Device

|Property|Value|
|---|---|
|Description|**IoT device to send the message to.**|
|DisplayName|**Device**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_device`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|msdyn_iotdevice|

### <a name="BKMK_msdyn_DeviceID"></a> msdyn_DeviceID

|Property|Value|
|---|---|
|Description|**The ID of the IoT device to send the message to.**|
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

### <a name="BKMK_msdyn_iotdevicecommandId"></a> msdyn_iotdevicecommandId

|Property|Value|
|---|---|
|Description|**Unique identifier for entity instances**|
|DisplayName|**IoT Device Command**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`msdyn_iotdevicecommandid`|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|

### <a name="BKMK_msdyn_Message"></a> msdyn_Message

|Property|Value|
|---|---|
|Description|**Message to send to the IoT device. E.g.: A Json string.**|
|DisplayName|**Message**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_message`|
|RequiredLevel|None|
|Type|Memo|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|8192|

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

### <a name="BKMK_msdyn_ParentAlert"></a> msdyn_ParentAlert

|Property|Value|
|---|---|
|Description|**Reference to a primary alert in response to which the message is being sent.**|
|DisplayName|**Primary Alert**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_parentalert`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|msdyn_iotalert|

### <a name="BKMK_msdyn_SendToAllConnectedDevices"></a> msdyn_SendToAllConnectedDevices

|Property|Value|
|---|---|
|Description|**Yes, if a copy of the command should be sent to all registered devices connected under the parent entity of the selected device. No, if this command needs to be sent only to the selected device.**|
|DisplayName|**Send To All Connected Devices**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_sendtoallconnecteddevices`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`msdyn_iotdevicecommand_msdyn_sendtoallconnecteddevices`|
|DefaultValue|False|
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
|Description|**Status of the IoT Device Command**|
|DisplayName|**Status**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statecode`|
|RequiredLevel|SystemRequired|
|Type|State|
|DefaultFormValue||
|GlobalChoiceName|`msdyn_iotdevicecommand_statecode`|

#### statecode Choices/Options

|Value|Details|
|---|---|
|0|Label: **Active**<br />DefaultStatus: 1<br />InvariantName: `Active`|
|1|Label: **Inactive**<br />DefaultStatus: 2<br />InvariantName: `Inactive`|

### <a name="BKMK_statuscode"></a> statuscode

|Property|Value|
|---|---|
|Description|**Reason for the status of the IoT Device Command**|
|DisplayName|**Status Reason**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statuscode`|
|RequiredLevel|None|
|Type|Status|
|DefaultFormValue||
|GlobalChoiceName|`msdyn_iotdevicecommand_statuscode`|

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

- [business_unit_msdyn_iotdevicecommand](#BKMK_business_unit_msdyn_iotdevicecommand)
- [lk_msdyn_iotdevicecommand_createdby](#BKMK_lk_msdyn_iotdevicecommand_createdby)
- [lk_msdyn_iotdevicecommand_createdonbehalfby](#BKMK_lk_msdyn_iotdevicecommand_createdonbehalfby)
- [lk_msdyn_iotdevicecommand_modifiedby](#BKMK_lk_msdyn_iotdevicecommand_modifiedby)
- [lk_msdyn_iotdevicecommand_modifiedonbehalfby](#BKMK_lk_msdyn_iotdevicecommand_modifiedonbehalfby)
- [msdyn_msdyn_customerasset_msdyn_iotdevicecommand_CustomerAsset](#BKMK_msdyn_msdyn_customerasset_msdyn_iotdevicecommand_CustomerAsset)
- [msdyn_msdyn_iotalert_msdyn_iotdevicecommand_ParentAlert](#BKMK_msdyn_msdyn_iotalert_msdyn_iotdevicecommand_ParentAlert)
- [msdyn_msdyn_iotdevice_msdyn_iotdevicecommand_Device](#BKMK_msdyn_msdyn_iotdevice_msdyn_iotdevicecommand_Device)
- [msdyn_msdyn_iotdevicecommanddefinition_msdyn_iotdevicecommand_Command](#BKMK_msdyn_msdyn_iotdevicecommanddefinition_msdyn_iotdevicecommand_Command)
- [owner_msdyn_iotdevicecommand](#BKMK_owner_msdyn_iotdevicecommand)
- [team_msdyn_iotdevicecommand](#BKMK_team_msdyn_iotdevicecommand)
- [user_msdyn_iotdevicecommand](#BKMK_user_msdyn_iotdevicecommand)

### <a name="BKMK_business_unit_msdyn_iotdevicecommand"></a> business_unit_msdyn_iotdevicecommand

One-To-Many Relationship: [businessunit business_unit_msdyn_iotdevicecommand](businessunit.md#BKMK_business_unit_msdyn_iotdevicecommand)

|Property|Value|
|---|---|
|ReferencedEntity|`businessunit`|
|ReferencedAttribute|`businessunitid`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencingEntityNavigationPropertyName|`owningbusinessunit`|
|IsHierarchical||
|CascadeConfiguration|Archive: `Restrict`<br />Assign: `NoCascade`<br />Delete: `Restrict`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_iotdevicecommand_createdby"></a> lk_msdyn_iotdevicecommand_createdby

One-To-Many Relationship: [systemuser lk_msdyn_iotdevicecommand_createdby](systemuser.md#BKMK_lk_msdyn_iotdevicecommand_createdby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdby`|
|ReferencingEntityNavigationPropertyName|`createdby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_iotdevicecommand_createdonbehalfby"></a> lk_msdyn_iotdevicecommand_createdonbehalfby

One-To-Many Relationship: [systemuser lk_msdyn_iotdevicecommand_createdonbehalfby](systemuser.md#BKMK_lk_msdyn_iotdevicecommand_createdonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdonbehalfby`|
|ReferencingEntityNavigationPropertyName|`createdonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_iotdevicecommand_modifiedby"></a> lk_msdyn_iotdevicecommand_modifiedby

One-To-Many Relationship: [systemuser lk_msdyn_iotdevicecommand_modifiedby](systemuser.md#BKMK_lk_msdyn_iotdevicecommand_modifiedby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedby`|
|ReferencingEntityNavigationPropertyName|`modifiedby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_iotdevicecommand_modifiedonbehalfby"></a> lk_msdyn_iotdevicecommand_modifiedonbehalfby

One-To-Many Relationship: [systemuser lk_msdyn_iotdevicecommand_modifiedonbehalfby](systemuser.md#BKMK_lk_msdyn_iotdevicecommand_modifiedonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedonbehalfby`|
|ReferencingEntityNavigationPropertyName|`modifiedonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_msdyn_customerasset_msdyn_iotdevicecommand_CustomerAsset"></a> msdyn_msdyn_customerasset_msdyn_iotdevicecommand_CustomerAsset

One-To-Many Relationship: [msdyn_customerasset msdyn_msdyn_customerasset_msdyn_iotdevicecommand_CustomerAsset](msdyn_customerasset.md#BKMK_msdyn_msdyn_customerasset_msdyn_iotdevicecommand_CustomerAsset)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_customerasset`|
|ReferencedAttribute|`msdyn_customerassetid`|
|ReferencingAttribute|`msdyn_customerasset`|
|ReferencingEntityNavigationPropertyName|`msdyn_CustomerAsset`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_msdyn_iotalert_msdyn_iotdevicecommand_ParentAlert"></a> msdyn_msdyn_iotalert_msdyn_iotdevicecommand_ParentAlert

One-To-Many Relationship: [msdyn_iotalert msdyn_msdyn_iotalert_msdyn_iotdevicecommand_ParentAlert](msdyn_iotalert.md#BKMK_msdyn_msdyn_iotalert_msdyn_iotdevicecommand_ParentAlert)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_iotalert`|
|ReferencedAttribute|`msdyn_iotalertid`|
|ReferencingAttribute|`msdyn_parentalert`|
|ReferencingEntityNavigationPropertyName|`msdyn_ParentAlert`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_msdyn_iotdevice_msdyn_iotdevicecommand_Device"></a> msdyn_msdyn_iotdevice_msdyn_iotdevicecommand_Device

One-To-Many Relationship: [msdyn_iotdevice msdyn_msdyn_iotdevice_msdyn_iotdevicecommand_Device](msdyn_iotdevice.md#BKMK_msdyn_msdyn_iotdevice_msdyn_iotdevicecommand_Device)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_iotdevice`|
|ReferencedAttribute|`msdyn_iotdeviceid`|
|ReferencingAttribute|`msdyn_device`|
|ReferencingEntityNavigationPropertyName|`msdyn_Device`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_msdyn_iotdevicecommanddefinition_msdyn_iotdevicecommand_Command"></a> msdyn_msdyn_iotdevicecommanddefinition_msdyn_iotdevicecommand_Command

One-To-Many Relationship: [msdyn_iotdevicecommanddefinition msdyn_msdyn_iotdevicecommanddefinition_msdyn_iotdevicecommand_Command](msdyn_iotdevicecommanddefinition.md#BKMK_msdyn_msdyn_iotdevicecommanddefinition_msdyn_iotdevicecommand_Command)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_iotdevicecommanddefinition`|
|ReferencedAttribute|`msdyn_iotdevicecommanddefinitionid`|
|ReferencingAttribute|`msdyn_command`|
|ReferencingEntityNavigationPropertyName|`msdyn_Command`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_owner_msdyn_iotdevicecommand"></a> owner_msdyn_iotdevicecommand

One-To-Many Relationship: [owner owner_msdyn_iotdevicecommand](owner.md#BKMK_owner_msdyn_iotdevicecommand)

|Property|Value|
|---|---|
|ReferencedEntity|`owner`|
|ReferencedAttribute|`ownerid`|
|ReferencingAttribute|`ownerid`|
|ReferencingEntityNavigationPropertyName|`ownerid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_team_msdyn_iotdevicecommand"></a> team_msdyn_iotdevicecommand

One-To-Many Relationship: [team team_msdyn_iotdevicecommand](team.md#BKMK_team_msdyn_iotdevicecommand)

|Property|Value|
|---|---|
|ReferencedEntity|`team`|
|ReferencedAttribute|`teamid`|
|ReferencingAttribute|`owningteam`|
|ReferencingEntityNavigationPropertyName|`owningteam`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_user_msdyn_iotdevicecommand"></a> user_msdyn_iotdevicecommand

One-To-Many Relationship: [systemuser user_msdyn_iotdevicecommand](systemuser.md#BKMK_user_msdyn_iotdevicecommand)

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

- [msdyn_iotdevicecommand_Annotations](#BKMK_msdyn_iotdevicecommand_Annotations)
- [msdyn_iotdevicecommand_AsyncOperations](#BKMK_msdyn_iotdevicecommand_AsyncOperations)
- [msdyn_iotdevicecommand_BulkDeleteFailures](#BKMK_msdyn_iotdevicecommand_BulkDeleteFailures)
- [msdyn_iotdevicecommand_connections1](#BKMK_msdyn_iotdevicecommand_connections1)
- [msdyn_iotdevicecommand_connections2](#BKMK_msdyn_iotdevicecommand_connections2)
- [msdyn_iotdevicecommand_DuplicateBaseRecord](#BKMK_msdyn_iotdevicecommand_DuplicateBaseRecord)
- [msdyn_iotdevicecommand_DuplicateMatchingRecord](#BKMK_msdyn_iotdevicecommand_DuplicateMatchingRecord)
- [msdyn_iotdevicecommand_MailboxTrackingFolders](#BKMK_msdyn_iotdevicecommand_MailboxTrackingFolders)
- [msdyn_iotdevicecommand_PrincipalObjectAttributeAccesses](#BKMK_msdyn_iotdevicecommand_PrincipalObjectAttributeAccesses)
- [msdyn_iotdevicecommand_ProcessSession](#BKMK_msdyn_iotdevicecommand_ProcessSession)
- [msdyn_iotdevicecommand_SyncErrors](#BKMK_msdyn_iotdevicecommand_SyncErrors)
- [msdyn_msdyn_iotdevicecommand_msdyn_customerasset_LastCommandSent](#BKMK_msdyn_msdyn_iotdevicecommand_msdyn_customerasset_LastCommandSent)
- [msdyn_msdyn_iotdevicecommand_msdyn_iotalert_LastCommandSent](#BKMK_msdyn_msdyn_iotdevicecommand_msdyn_iotalert_LastCommandSent)
- [msdyn_msdyn_iotdevicecommand_msdyn_iotdevice_LastCommandSent](#BKMK_msdyn_msdyn_iotdevicecommand_msdyn_iotdevice_LastCommandSent)

### <a name="BKMK_msdyn_iotdevicecommand_Annotations"></a> msdyn_iotdevicecommand_Annotations

Many-To-One Relationship: [annotation msdyn_iotdevicecommand_Annotations](annotation.md#BKMK_msdyn_iotdevicecommand_Annotations)

|Property|Value|
|---|---|
|ReferencingEntity|`annotation`|
|ReferencingAttribute|`objectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_iotdevicecommand_Annotations`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_iotdevicecommand_AsyncOperations"></a> msdyn_iotdevicecommand_AsyncOperations

Many-To-One Relationship: [asyncoperation msdyn_iotdevicecommand_AsyncOperations](asyncoperation.md#BKMK_msdyn_iotdevicecommand_AsyncOperations)

|Property|Value|
|---|---|
|ReferencingEntity|`asyncoperation`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_iotdevicecommand_AsyncOperations`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_iotdevicecommand_BulkDeleteFailures"></a> msdyn_iotdevicecommand_BulkDeleteFailures

Many-To-One Relationship: [bulkdeletefailure msdyn_iotdevicecommand_BulkDeleteFailures](bulkdeletefailure.md#BKMK_msdyn_iotdevicecommand_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencingEntity|`bulkdeletefailure`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_iotdevicecommand_BulkDeleteFailures`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_iotdevicecommand_connections1"></a> msdyn_iotdevicecommand_connections1

Many-To-One Relationship: [connection msdyn_iotdevicecommand_connections1](connection.md#BKMK_msdyn_iotdevicecommand_connections1)

|Property|Value|
|---|---|
|ReferencingEntity|`connection`|
|ReferencingAttribute|`record1id`|
|ReferencedEntityNavigationPropertyName|`msdyn_iotdevicecommand_connections1`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 100<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_iotdevicecommand_connections2"></a> msdyn_iotdevicecommand_connections2

Many-To-One Relationship: [connection msdyn_iotdevicecommand_connections2](connection.md#BKMK_msdyn_iotdevicecommand_connections2)

|Property|Value|
|---|---|
|ReferencingEntity|`connection`|
|ReferencingAttribute|`record2id`|
|ReferencedEntityNavigationPropertyName|`msdyn_iotdevicecommand_connections2`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_iotdevicecommand_DuplicateBaseRecord"></a> msdyn_iotdevicecommand_DuplicateBaseRecord

Many-To-One Relationship: [duplicaterecord msdyn_iotdevicecommand_DuplicateBaseRecord](duplicaterecord.md#BKMK_msdyn_iotdevicecommand_DuplicateBaseRecord)

|Property|Value|
|---|---|
|ReferencingEntity|`duplicaterecord`|
|ReferencingAttribute|`baserecordid`|
|ReferencedEntityNavigationPropertyName|`msdyn_iotdevicecommand_DuplicateBaseRecord`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_iotdevicecommand_DuplicateMatchingRecord"></a> msdyn_iotdevicecommand_DuplicateMatchingRecord

Many-To-One Relationship: [duplicaterecord msdyn_iotdevicecommand_DuplicateMatchingRecord](duplicaterecord.md#BKMK_msdyn_iotdevicecommand_DuplicateMatchingRecord)

|Property|Value|
|---|---|
|ReferencingEntity|`duplicaterecord`|
|ReferencingAttribute|`duplicaterecordid`|
|ReferencedEntityNavigationPropertyName|`msdyn_iotdevicecommand_DuplicateMatchingRecord`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_iotdevicecommand_MailboxTrackingFolders"></a> msdyn_iotdevicecommand_MailboxTrackingFolders

Many-To-One Relationship: [mailboxtrackingfolder msdyn_iotdevicecommand_MailboxTrackingFolders](mailboxtrackingfolder.md#BKMK_msdyn_iotdevicecommand_MailboxTrackingFolders)

|Property|Value|
|---|---|
|ReferencingEntity|`mailboxtrackingfolder`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_iotdevicecommand_MailboxTrackingFolders`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_iotdevicecommand_PrincipalObjectAttributeAccesses"></a> msdyn_iotdevicecommand_PrincipalObjectAttributeAccesses

Many-To-One Relationship: [principalobjectattributeaccess msdyn_iotdevicecommand_PrincipalObjectAttributeAccesses](principalobjectattributeaccess.md#BKMK_msdyn_iotdevicecommand_PrincipalObjectAttributeAccesses)

|Property|Value|
|---|---|
|ReferencingEntity|`principalobjectattributeaccess`|
|ReferencingAttribute|`objectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_iotdevicecommand_PrincipalObjectAttributeAccesses`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_iotdevicecommand_ProcessSession"></a> msdyn_iotdevicecommand_ProcessSession

Many-To-One Relationship: [processsession msdyn_iotdevicecommand_ProcessSession](processsession.md#BKMK_msdyn_iotdevicecommand_ProcessSession)

|Property|Value|
|---|---|
|ReferencingEntity|`processsession`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_iotdevicecommand_ProcessSession`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_iotdevicecommand_SyncErrors"></a> msdyn_iotdevicecommand_SyncErrors

Many-To-One Relationship: [syncerror msdyn_iotdevicecommand_SyncErrors](syncerror.md#BKMK_msdyn_iotdevicecommand_SyncErrors)

|Property|Value|
|---|---|
|ReferencingEntity|`syncerror`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_iotdevicecommand_SyncErrors`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_msdyn_iotdevicecommand_msdyn_customerasset_LastCommandSent"></a> msdyn_msdyn_iotdevicecommand_msdyn_customerasset_LastCommandSent

Many-To-One Relationship: [msdyn_customerasset msdyn_msdyn_iotdevicecommand_msdyn_customerasset_LastCommandSent](msdyn_customerasset.md#BKMK_msdyn_msdyn_iotdevicecommand_msdyn_customerasset_LastCommandSent)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_customerasset`|
|ReferencingAttribute|`msdyn_lastcommandsent`|
|ReferencedEntityNavigationPropertyName|`msdyn_msdyn_iotdevicecommand_msdyn_customerasset_LastCommandSent`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_msdyn_iotdevicecommand_msdyn_iotalert_LastCommandSent"></a> msdyn_msdyn_iotdevicecommand_msdyn_iotalert_LastCommandSent

Many-To-One Relationship: [msdyn_iotalert msdyn_msdyn_iotdevicecommand_msdyn_iotalert_LastCommandSent](msdyn_iotalert.md#BKMK_msdyn_msdyn_iotdevicecommand_msdyn_iotalert_LastCommandSent)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_iotalert`|
|ReferencingAttribute|`msdyn_lastcommandsent`|
|ReferencedEntityNavigationPropertyName|`msdyn_msdyn_iotdevicecommand_msdyn_iotalert_LastCommandSent`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_msdyn_iotdevicecommand_msdyn_iotdevice_LastCommandSent"></a> msdyn_msdyn_iotdevicecommand_msdyn_iotdevice_LastCommandSent

Many-To-One Relationship: [msdyn_iotdevice msdyn_msdyn_iotdevicecommand_msdyn_iotdevice_LastCommandSent](msdyn_iotdevice.md#BKMK_msdyn_msdyn_iotdevicecommand_msdyn_iotdevice_LastCommandSent)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_iotdevice`|
|ReferencingAttribute|`msdyn_lastcommandsent`|
|ReferencedEntityNavigationPropertyName|`msdyn_msdyn_iotdevicecommand_msdyn_iotdevice_LastCommandSent`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|



### See also

[Dataverse table/entity reference](/power-apps/developer/data-platform/reference/about-entity-reference)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   

