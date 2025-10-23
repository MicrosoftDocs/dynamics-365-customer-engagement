---
title: "IoT Alert (msdyn_iotalert) table/entity reference (Microsoft Dynamics 365)"
description: "Includes schema information and supported messages for the IoT Alert (msdyn_iotalert) table/entity with Microsoft Dynamics 365."
ms.topic: generated-reference
author: JimDaly
ms.author: jdaly
search.audienceType: 
  - developer
---

# IoT Alert (msdyn_iotalert) table/entity reference (Microsoft Dynamics 365)



## Messages

The following table lists the messages for the IoT Alert (msdyn_iotalert) table.
Messages represent operations that can be performed on the table. They may also be events.

| Name <br />Is Event? |Web API Operation |SDK for .NET |
| ---- | ----- |----- |
| `Assign`<br />Event: True |`PATCH` /msdyn_iotalerts(*msdyn_iotalertid*)<br />[Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) the `ownerid` property. |<xref:Microsoft.Crm.Sdk.Messages.AssignRequest>|
| `Associate`<br />Event: True |[Associate records](/power-apps/developer/data-platform/webapi/associate-disassociate-entities-using-web-api) |[Associate records](/power-apps/developer/data-platform/org-service/entity-operations-associate-disassociate#use-the-associate-method-or-associaterequest)|
| `BulkRetain`<br />Event: True |<xref:Microsoft.Dynamics.CRM.BulkRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Create`<br />Event: True |`POST` /msdyn_iotalerts<br />See [Create](/powerapps/developer/data-platform/webapi/create-entity-web-api) |[Create records](/power-apps/developer/data-platform/org-service/entity-operations-create#basic-create)|
| `CreateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.CreateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.CreateMultipleRequest>|
| `Delete`<br />Event: True |`DELETE` /msdyn_iotalerts(*msdyn_iotalertid*)<br />See [Delete](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-delete) |[Delete records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-delete)|
| `Disassociate`<br />Event: True |[Disassociate records](/power-apps/developer/data-platform/webapi/associate-disassociate-entities-using-web-api) |[Disassociate records](/power-apps/developer/data-platform/org-service/entity-operations-associate-disassociate#use-the-disassociate-method-or-disassociaterequest)|
| `GrantAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.GrantAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.GrantAccessRequest>|
| `IsValidStateTransition`<br />Event: False |<xref:Microsoft.Dynamics.CRM.IsValidStateTransition?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.IsValidStateTransitionRequest>|
| `ModifyAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.ModifyAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.ModifyAccessRequest>|
| `PurgeRetainedContent`<br />Event: True |<xref:Microsoft.Dynamics.CRM.PurgeRetainedContent?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Restore`<br />Event: True |<xref:Microsoft.Dynamics.CRM.Restore?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retain`<br />Event: True |<xref:Microsoft.Dynamics.CRM.Retain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retrieve`<br />Event: True |`GET` /msdyn_iotalerts(*msdyn_iotalertid*)<br />See [Retrieve](/powerapps/developer/data-platform/webapi/retrieve-entity-using-web-api) |[Retrieve records](/power-apps/developer/data-platform/org-service/entity-operations-retrieve)|
| `RetrieveMultiple`<br />Event: True |`GET` /msdyn_iotalerts<br />See [Query data](/power-apps/developer/data-platform/webapi/query-data-web-api) |[Query data](/power-apps/developer/data-platform/org-service/entity-operations-query-data)|
| `RetrievePrincipalAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RetrievePrincipalAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RetrievePrincipalAccessRequest>|
| `RetrieveSharedPrincipalsAndAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RetrieveSharedPrincipalsAndAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RetrieveSharedPrincipalsAndAccessRequest>|
| `RevokeAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RevokeAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RevokeAccessRequest>|
| `RollbackRetain`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RollbackRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `SetState`<br />Event: True |`PATCH` /msdyn_iotalerts(*msdyn_iotalertid*)<br />[Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) the `statecode` and `statuscode` properties. |<xref:Microsoft.Crm.Sdk.Messages.SetStateRequest>|
| `Update`<br />Event: True |`PATCH` /msdyn_iotalerts(*msdyn_iotalertid*)<br />See [Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) |[Update records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-update)|
| `UpdateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.UpdateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpdateMultipleRequest>|
| `Upsert`<br />Event: False |`PATCH` /msdyn_iotalerts(*msdyn_iotalertid*)<br />See [Upsert a table row](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#upsert-a-table-row) |<xref:Microsoft.Xrm.Sdk.Messages.UpsertRequest>|
| `UpsertMultiple`<br />Event: False |<xref:Microsoft.Dynamics.CRM.UpsertMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpsertMultipleRequest>|
| `ValidateRetentionConfig`<br />Event: True |<xref:Microsoft.Dynamics.CRM.ValidateRetentionConfig?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|

## Properties

The following table lists selected properties for the IoT Alert (msdyn_iotalert) table.

|Property|Value|
| --- | --- |
| **DisplayName** | **IoT Alert** |
| **DisplayCollectionName** | **IoT Alerts** |
| **SchemaName** | `msdyn_iotalert` |
| **CollectionSchemaName** | `msdyn_iotalerts` |
| **EntitySetName** | `msdyn_iotalerts`|
| **LogicalName** | `msdyn_iotalert` |
| **LogicalCollectionName** | `msdyn_iotalerts` |
| **PrimaryIdAttribute** | `msdyn_iotalertid` |
| **PrimaryNameAttribute** |`msdyn_description` |
| **TableType** | `Standard` |
| **OwnershipType** | `UserOwned` |

## Writable columns/attributes

These columns/attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [ImportSequenceNumber](#BKMK_ImportSequenceNumber)
- [msdyn_AlertData](#BKMK_msdyn_AlertData)
- [msdyn_alertpriorityscore](#BKMK_msdyn_alertpriorityscore)
- [msdyn_AlertTime](#BKMK_msdyn_AlertTime)
- [msdyn_AlertToken](#BKMK_msdyn_AlertToken)
- [msdyn_alerttype](#BKMK_msdyn_alerttype)
- [msdyn_AlertURL](#BKMK_msdyn_AlertURL)
- [msdyn_case](#BKMK_msdyn_case)
- [msdyn_CustomerAsset](#BKMK_msdyn_CustomerAsset)
- [msdyn_Description](#BKMK_msdyn_Description)
- [msdyn_Device](#BKMK_msdyn_Device)
- [msdyn_DeviceID](#BKMK_msdyn_DeviceID)
- [msdyn_iotalertId](#BKMK_msdyn_iotalertId)
- [msdyn_LastCommandSent](#BKMK_msdyn_LastCommandSent)
- [msdyn_LastCommandSentTime](#BKMK_msdyn_LastCommandSentTime)
- [msdyn_ParentAlert](#BKMK_msdyn_ParentAlert)
- [msdyn_ParentAlertToken](#BKMK_msdyn_ParentAlertToken)
- [msdyn_suggestedpriority](#BKMK_msdyn_suggestedpriority)
- [OverriddenCreatedOn](#BKMK_OverriddenCreatedOn)
- [OwnerId](#BKMK_OwnerId)
- [OwnerIdType](#BKMK_OwnerIdType)
- [processid](#BKMK_processid)
- [stageid](#BKMK_stageid)
- [statecode](#BKMK_statecode)
- [statuscode](#BKMK_statuscode)
- [TimeZoneRuleVersionNumber](#BKMK_TimeZoneRuleVersionNumber)
- [traversedpath](#BKMK_traversedpath)
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

### <a name="BKMK_msdyn_AlertData"></a> msdyn_AlertData

|Property|Value|
|---|---|
|Description|**Data sent from the device about the alert.**|
|DisplayName|**Alert Data**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_alertdata`|
|RequiredLevel|None|
|Type|Memo|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|8192|

### <a name="BKMK_msdyn_alertpriorityscore"></a> msdyn_alertpriorityscore

|Property|Value|
|---|---|
|Description|**The suggested priority score for this alert.**|
|DisplayName|**Priority Score (%)**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_alertpriorityscore`|
|RequiredLevel|None|
|Type|Integer|
|MaxValue|100|
|MinValue|0|

### <a name="BKMK_msdyn_AlertTime"></a> msdyn_AlertTime

|Property|Value|
|---|---|
|Description|**The time the alert was issued.**|
|DisplayName|**Alert Time**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_alerttime`|
|RequiredLevel|None|
|Type|DateTime|
|CanChangeDateTimeBehavior|True|
|DateTimeBehavior|UserLocal|
|Format|DateAndTime|
|ImeMode|Auto|
|SourceTypeMask|0|

### <a name="BKMK_msdyn_AlertToken"></a> msdyn_AlertToken

|Property|Value|
|---|---|
|Description|**The unique reference to the event id on the IoT provider.**|
|DisplayName|**Alert Token**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_alerttoken`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdyn_alerttype"></a> msdyn_alerttype

|Property|Value|
|---|---|
|Description||
|DisplayName|**Alert Type**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_alerttype`|
|RequiredLevel|None|
|Type|Picklist|
|DefaultFormValue|192350000|
|GlobalChoiceName|`msdyn_iotalert_msdyn_alerttype`|

#### msdyn_alerttype Choices/Options

|Value|Label|
|---|---|
|192350000|**Anomaly**|
|192350001|**Info**|
|192350002|**Preventive Maintenance**|
|192350003|**Test**|

### <a name="BKMK_msdyn_AlertURL"></a> msdyn_AlertURL

|Property|Value|
|---|---|
|Description|**External URL to view more information about the iot alert.**|
|DisplayName|**Alert URL**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_alerturl`|
|RequiredLevel|None|
|Type|String|
|Format|Url|
|FormatName|Url|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|500|

### <a name="BKMK_msdyn_case"></a> msdyn_case

|Property|Value|
|---|---|
|Description|**Case created for this iot alert.**|
|DisplayName|**Case**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_case`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|incident|

### <a name="BKMK_msdyn_CustomerAsset"></a> msdyn_CustomerAsset

|Property|Value|
|---|---|
|Description|**The asset connected to the IoT device that raised the alert.**|
|DisplayName|**Customer Asset**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_customerasset`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|msdyn_customerasset|

### <a name="BKMK_msdyn_Description"></a> msdyn_Description

|Property|Value|
|---|---|
|Description|**A description for the alert.**|
|DisplayName|**Description**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_description`|
|RequiredLevel|ApplicationRequired|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdyn_Device"></a> msdyn_Device

|Property|Value|
|---|---|
|Description|**The IoT device for which this alert was raised.**|
|DisplayName|**IoT Device**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_device`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|msdyn_iotdevice|

### <a name="BKMK_msdyn_DeviceID"></a> msdyn_DeviceID

|Property|Value|
|---|---|
|Description|**The ID of the IoT device that sent the alert.**|
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

### <a name="BKMK_msdyn_iotalertId"></a> msdyn_iotalertId

|Property|Value|
|---|---|
|Description|**Unique identifier for entity instances**|
|DisplayName|**IoT Alert**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`msdyn_iotalertid`|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|

### <a name="BKMK_msdyn_LastCommandSent"></a> msdyn_LastCommandSent

|Property|Value|
|---|---|
|Description||
|DisplayName|**Last Command Sent**|
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
|DisplayName|**Last Command Sent Time**|
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

### <a name="BKMK_msdyn_ParentAlert"></a> msdyn_ParentAlert

|Property|Value|
|---|---|
|Description|**Reference to a primary alert. This field is inferred if Primary Alert Token is set.**|
|DisplayName|**Primary Alert**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_parentalert`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|msdyn_iotalert|

### <a name="BKMK_msdyn_ParentAlertToken"></a> msdyn_ParentAlertToken

|Property|Value|
|---|---|
|Description|**Reference to a previously created primary iot alert**|
|DisplayName|**Primary Alert Token**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_parentalerttoken`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdyn_suggestedpriority"></a> msdyn_suggestedpriority

|Property|Value|
|---|---|
|Description|**The suggested priority for this alert.**|
|DisplayName|**Suggested Priority**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_suggestedpriority`|
|RequiredLevel|None|
|Type|Picklist|
|DefaultFormValue||
|GlobalChoiceName|`msdyn_suggestedpriority`|

#### msdyn_suggestedpriority Choices/Options

|Value|Label|
|---|---|
|192350000|**Calculating**|
|192350001|**High**|
|192350002|**Low**|
|192350003|**No Suggestions**|

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

### <a name="BKMK_processid"></a> processid

|Property|Value|
|---|---|
|Description|**Contains the id of the process associated with the entity.**|
|DisplayName|**Process Id**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`processid`|
|RequiredLevel|None|
|Type|Uniqueidentifier|

### <a name="BKMK_stageid"></a> stageid

|Property|Value|
|---|---|
|Description|**Contains the id of the stage where the entity is located.**|
|DisplayName|**Stage Id**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`stageid`|
|RequiredLevel|None|
|Type|Uniqueidentifier|

### <a name="BKMK_statecode"></a> statecode

|Property|Value|
|---|---|
|Description|**Status of the IoT Alert**|
|DisplayName|**Status**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statecode`|
|RequiredLevel|SystemRequired|
|Type|State|
|DefaultFormValue||
|GlobalChoiceName|`msdyn_iotalert_statecode`|

#### statecode Choices/Options

|Value|Details|
|---|---|
|0|Label: **Active**<br />DefaultStatus: 1<br />InvariantName: `Active`|
|1|Label: **Inactive**<br />DefaultStatus: 2<br />InvariantName: `Inactive`|
|2|Label: **InProgress**<br />DefaultStatus: 3<br />InvariantName: `InProgress`|
|3|Label: **Closed**<br />DefaultStatus: 4<br />InvariantName: `Closed`|

### <a name="BKMK_statuscode"></a> statuscode

|Property|Value|
|---|---|
|Description|**Reason for the status of the IoT Alert**|
|DisplayName|**Alert Status**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statuscode`|
|RequiredLevel|None|
|Type|Status|
|DefaultFormValue||
|GlobalChoiceName|`msdyn_iotalert_statuscode`|

#### statuscode Choices/Options

|Value|Details|
|---|---|
|1|Label: **Active**<br />State:0<br />TransitionData: None|
|2|Label: **Inactive**<br />State:1<br />TransitionData: None|
|3|Label: **In Progress - Case Created**<br />State:2<br />TransitionData: None|
|5|Label: **In Progress - Command Sent**<br />State:2<br />TransitionData: None|
|6|Label: **Closed**<br />State:3<br />TransitionData: None|

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

### <a name="BKMK_traversedpath"></a> traversedpath

|Property|Value|
|---|---|
|Description|**A comma separated list of string values representing the unique identifiers of stages in a Business Process Flow Instance in the order that they occur.**|
|DisplayName|**Traversed Path**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`traversedpath`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|1250|

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

- [business_unit_msdyn_iotalert](#BKMK_business_unit_msdyn_iotalert)
- [lk_msdyn_iotalert_createdby](#BKMK_lk_msdyn_iotalert_createdby)
- [lk_msdyn_iotalert_createdonbehalfby](#BKMK_lk_msdyn_iotalert_createdonbehalfby)
- [lk_msdyn_iotalert_modifiedby](#BKMK_lk_msdyn_iotalert_modifiedby)
- [lk_msdyn_iotalert_modifiedonbehalfby](#BKMK_lk_msdyn_iotalert_modifiedonbehalfby)
- [msdyn_incident_msdyn_iotalert_Case](#BKMK_msdyn_incident_msdyn_iotalert_Case)
- [msdyn_iotalert_msdyn_iotalert](#BKMK_msdyn_iotalert_msdyn_iotalert-many-to-one)
- [msdyn_msdyn_customerasset_msdyn_iotalert_CustomerAsset](#BKMK_msdyn_msdyn_customerasset_msdyn_iotalert_CustomerAsset)
- [msdyn_msdyn_iotdevice_msdyn_iotalert_Device](#BKMK_msdyn_msdyn_iotdevice_msdyn_iotalert_Device)
- [msdyn_msdyn_iotdevicecommand_msdyn_iotalert_LastCommandSent](#BKMK_msdyn_msdyn_iotdevicecommand_msdyn_iotalert_LastCommandSent)
- [owner_msdyn_iotalert](#BKMK_owner_msdyn_iotalert)
- [processstage_msdyn_iotalert](#BKMK_processstage_msdyn_iotalert)
- [team_msdyn_iotalert](#BKMK_team_msdyn_iotalert)
- [user_msdyn_iotalert](#BKMK_user_msdyn_iotalert)

### <a name="BKMK_business_unit_msdyn_iotalert"></a> business_unit_msdyn_iotalert

One-To-Many Relationship: [businessunit business_unit_msdyn_iotalert](businessunit.md#BKMK_business_unit_msdyn_iotalert)

|Property|Value|
|---|---|
|ReferencedEntity|`businessunit`|
|ReferencedAttribute|`businessunitid`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencingEntityNavigationPropertyName|`owningbusinessunit`|
|IsHierarchical||
|CascadeConfiguration|Archive: `Restrict`<br />Assign: `NoCascade`<br />Delete: `Restrict`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_iotalert_createdby"></a> lk_msdyn_iotalert_createdby

One-To-Many Relationship: [systemuser lk_msdyn_iotalert_createdby](systemuser.md#BKMK_lk_msdyn_iotalert_createdby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdby`|
|ReferencingEntityNavigationPropertyName|`createdby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_iotalert_createdonbehalfby"></a> lk_msdyn_iotalert_createdonbehalfby

One-To-Many Relationship: [systemuser lk_msdyn_iotalert_createdonbehalfby](systemuser.md#BKMK_lk_msdyn_iotalert_createdonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdonbehalfby`|
|ReferencingEntityNavigationPropertyName|`createdonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_iotalert_modifiedby"></a> lk_msdyn_iotalert_modifiedby

One-To-Many Relationship: [systemuser lk_msdyn_iotalert_modifiedby](systemuser.md#BKMK_lk_msdyn_iotalert_modifiedby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedby`|
|ReferencingEntityNavigationPropertyName|`modifiedby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_iotalert_modifiedonbehalfby"></a> lk_msdyn_iotalert_modifiedonbehalfby

One-To-Many Relationship: [systemuser lk_msdyn_iotalert_modifiedonbehalfby](systemuser.md#BKMK_lk_msdyn_iotalert_modifiedonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedonbehalfby`|
|ReferencingEntityNavigationPropertyName|`modifiedonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_incident_msdyn_iotalert_Case"></a> msdyn_incident_msdyn_iotalert_Case

One-To-Many Relationship: [incident msdyn_incident_msdyn_iotalert_Case](incident.md#BKMK_msdyn_incident_msdyn_iotalert_Case)

|Property|Value|
|---|---|
|ReferencedEntity|`incident`|
|ReferencedAttribute|`incidentid`|
|ReferencingAttribute|`msdyn_case`|
|ReferencingEntityNavigationPropertyName|`msdyn_Case`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_iotalert_msdyn_iotalert-many-to-one"></a> msdyn_iotalert_msdyn_iotalert

One-To-Many Relationship: [msdyn_iotalert msdyn_iotalert_msdyn_iotalert](#BKMK_msdyn_iotalert_msdyn_iotalert-one-to-many)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_iotalert`|
|ReferencedAttribute|`msdyn_iotalertid`|
|ReferencingAttribute|`msdyn_parentalert`|
|ReferencingEntityNavigationPropertyName|`msdyn_ParentAlert`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_msdyn_customerasset_msdyn_iotalert_CustomerAsset"></a> msdyn_msdyn_customerasset_msdyn_iotalert_CustomerAsset

One-To-Many Relationship: [msdyn_customerasset msdyn_msdyn_customerasset_msdyn_iotalert_CustomerAsset](msdyn_customerasset.md#BKMK_msdyn_msdyn_customerasset_msdyn_iotalert_CustomerAsset)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_customerasset`|
|ReferencedAttribute|`msdyn_customerassetid`|
|ReferencingAttribute|`msdyn_customerasset`|
|ReferencingEntityNavigationPropertyName|`msdyn_CustomerAsset`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_msdyn_iotdevice_msdyn_iotalert_Device"></a> msdyn_msdyn_iotdevice_msdyn_iotalert_Device

One-To-Many Relationship: [msdyn_iotdevice msdyn_msdyn_iotdevice_msdyn_iotalert_Device](msdyn_iotdevice.md#BKMK_msdyn_msdyn_iotdevice_msdyn_iotalert_Device)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_iotdevice`|
|ReferencedAttribute|`msdyn_iotdeviceid`|
|ReferencingAttribute|`msdyn_device`|
|ReferencingEntityNavigationPropertyName|`msdyn_Device`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_msdyn_iotdevicecommand_msdyn_iotalert_LastCommandSent"></a> msdyn_msdyn_iotdevicecommand_msdyn_iotalert_LastCommandSent

One-To-Many Relationship: [msdyn_iotdevicecommand msdyn_msdyn_iotdevicecommand_msdyn_iotalert_LastCommandSent](msdyn_iotdevicecommand.md#BKMK_msdyn_msdyn_iotdevicecommand_msdyn_iotalert_LastCommandSent)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_iotdevicecommand`|
|ReferencedAttribute|`msdyn_iotdevicecommandid`|
|ReferencingAttribute|`msdyn_lastcommandsent`|
|ReferencingEntityNavigationPropertyName|`msdyn_LastCommandSent`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_owner_msdyn_iotalert"></a> owner_msdyn_iotalert

One-To-Many Relationship: [owner owner_msdyn_iotalert](owner.md#BKMK_owner_msdyn_iotalert)

|Property|Value|
|---|---|
|ReferencedEntity|`owner`|
|ReferencedAttribute|`ownerid`|
|ReferencingAttribute|`ownerid`|
|ReferencingEntityNavigationPropertyName|`ownerid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_processstage_msdyn_iotalert"></a> processstage_msdyn_iotalert

One-To-Many Relationship: [processstage processstage_msdyn_iotalert](processstage.md#BKMK_processstage_msdyn_iotalert)

|Property|Value|
|---|---|
|ReferencedEntity|`processstage`|
|ReferencedAttribute|`processstageid`|
|ReferencingAttribute|`stageid`|
|ReferencingEntityNavigationPropertyName|`stageid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_team_msdyn_iotalert"></a> team_msdyn_iotalert

One-To-Many Relationship: [team team_msdyn_iotalert](team.md#BKMK_team_msdyn_iotalert)

|Property|Value|
|---|---|
|ReferencedEntity|`team`|
|ReferencedAttribute|`teamid`|
|ReferencingAttribute|`owningteam`|
|ReferencingEntityNavigationPropertyName|`owningteam`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_user_msdyn_iotalert"></a> user_msdyn_iotalert

One-To-Many Relationship: [systemuser user_msdyn_iotalert](systemuser.md#BKMK_user_msdyn_iotalert)

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

- [bpf_msdyn_iotalert_msdyn_iottocaseprocess](#BKMK_bpf_msdyn_iotalert_msdyn_iottocaseprocess)
- [msdyn_iotalert_Annotations](#BKMK_msdyn_iotalert_Annotations)
- [msdyn_iotalert_AsyncOperations](#BKMK_msdyn_iotalert_AsyncOperations)
- [msdyn_iotalert_BulkDeleteFailures](#BKMK_msdyn_iotalert_BulkDeleteFailures)
- [msdyn_iotalert_connections1](#BKMK_msdyn_iotalert_connections1)
- [msdyn_iotalert_connections2](#BKMK_msdyn_iotalert_connections2)
- [msdyn_iotalert_MailboxTrackingFolders](#BKMK_msdyn_iotalert_MailboxTrackingFolders)
- [msdyn_iotalert_msdyn_iotalert](#BKMK_msdyn_iotalert_msdyn_iotalert-one-to-many)
- [msdyn_iotalert_PrincipalObjectAttributeAccesses](#BKMK_msdyn_iotalert_PrincipalObjectAttributeAccesses)
- [msdyn_iotalert_ProcessSession](#BKMK_msdyn_iotalert_ProcessSession)
- [msdyn_iotalert_QueueItems](#BKMK_msdyn_iotalert_QueueItems)
- [msdyn_iotalert_SyncErrors](#BKMK_msdyn_iotalert_SyncErrors)
- [msdyn_msdyn_iotalert_incident_IoTAlert](#BKMK_msdyn_msdyn_iotalert_incident_IoTAlert)
- [msdyn_msdyn_iotalert_msdyn_iotdevicecommand_ParentAlert](#BKMK_msdyn_msdyn_iotalert_msdyn_iotdevicecommand_ParentAlert)

### <a name="BKMK_bpf_msdyn_iotalert_msdyn_iottocaseprocess"></a> bpf_msdyn_iotalert_msdyn_iottocaseprocess

Many-To-One Relationship: [msdyn_iottocaseprocess bpf_msdyn_iotalert_msdyn_iottocaseprocess](msdyn_iottocaseprocess.md#BKMK_bpf_msdyn_iotalert_msdyn_iottocaseprocess)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_iottocaseprocess`|
|ReferencingAttribute|`bpf_msdyn_iotalertid`|
|ReferencedEntityNavigationPropertyName|`bpf_msdyn_iotalert_msdyn_iottocaseprocess`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_iotalert_Annotations"></a> msdyn_iotalert_Annotations

Many-To-One Relationship: [annotation msdyn_iotalert_Annotations](annotation.md#BKMK_msdyn_iotalert_Annotations)

|Property|Value|
|---|---|
|ReferencingEntity|`annotation`|
|ReferencingAttribute|`objectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_iotalert_Annotations`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_iotalert_AsyncOperations"></a> msdyn_iotalert_AsyncOperations

Many-To-One Relationship: [asyncoperation msdyn_iotalert_AsyncOperations](asyncoperation.md#BKMK_msdyn_iotalert_AsyncOperations)

|Property|Value|
|---|---|
|ReferencingEntity|`asyncoperation`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_iotalert_AsyncOperations`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_iotalert_BulkDeleteFailures"></a> msdyn_iotalert_BulkDeleteFailures

Many-To-One Relationship: [bulkdeletefailure msdyn_iotalert_BulkDeleteFailures](bulkdeletefailure.md#BKMK_msdyn_iotalert_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencingEntity|`bulkdeletefailure`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_iotalert_BulkDeleteFailures`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_iotalert_connections1"></a> msdyn_iotalert_connections1

Many-To-One Relationship: [connection msdyn_iotalert_connections1](connection.md#BKMK_msdyn_iotalert_connections1)

|Property|Value|
|---|---|
|ReferencingEntity|`connection`|
|ReferencingAttribute|`record1id`|
|ReferencedEntityNavigationPropertyName|`msdyn_iotalert_connections1`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 100<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_iotalert_connections2"></a> msdyn_iotalert_connections2

Many-To-One Relationship: [connection msdyn_iotalert_connections2](connection.md#BKMK_msdyn_iotalert_connections2)

|Property|Value|
|---|---|
|ReferencingEntity|`connection`|
|ReferencingAttribute|`record2id`|
|ReferencedEntityNavigationPropertyName|`msdyn_iotalert_connections2`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_iotalert_MailboxTrackingFolders"></a> msdyn_iotalert_MailboxTrackingFolders

Many-To-One Relationship: [mailboxtrackingfolder msdyn_iotalert_MailboxTrackingFolders](mailboxtrackingfolder.md#BKMK_msdyn_iotalert_MailboxTrackingFolders)

|Property|Value|
|---|---|
|ReferencingEntity|`mailboxtrackingfolder`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_iotalert_MailboxTrackingFolders`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_iotalert_msdyn_iotalert-one-to-many"></a> msdyn_iotalert_msdyn_iotalert

Many-To-One Relationship: [msdyn_iotalert msdyn_iotalert_msdyn_iotalert](#BKMK_msdyn_iotalert_msdyn_iotalert-many-to-one)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_iotalert`|
|ReferencingAttribute|`msdyn_parentalert`|
|ReferencedEntityNavigationPropertyName|`msdyn_iotalert_msdyn_iotalert`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_iotalert_PrincipalObjectAttributeAccesses"></a> msdyn_iotalert_PrincipalObjectAttributeAccesses

Many-To-One Relationship: [principalobjectattributeaccess msdyn_iotalert_PrincipalObjectAttributeAccesses](principalobjectattributeaccess.md#BKMK_msdyn_iotalert_PrincipalObjectAttributeAccesses)

|Property|Value|
|---|---|
|ReferencingEntity|`principalobjectattributeaccess`|
|ReferencingAttribute|`objectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_iotalert_PrincipalObjectAttributeAccesses`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_iotalert_ProcessSession"></a> msdyn_iotalert_ProcessSession

Many-To-One Relationship: [processsession msdyn_iotalert_ProcessSession](processsession.md#BKMK_msdyn_iotalert_ProcessSession)

|Property|Value|
|---|---|
|ReferencingEntity|`processsession`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_iotalert_ProcessSession`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_iotalert_QueueItems"></a> msdyn_iotalert_QueueItems

Many-To-One Relationship: [queueitem msdyn_iotalert_QueueItems](queueitem.md#BKMK_msdyn_iotalert_QueueItems)

|Property|Value|
|---|---|
|ReferencingEntity|`queueitem`|
|ReferencingAttribute|`objectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_iotalert_QueueItems`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_iotalert_SyncErrors"></a> msdyn_iotalert_SyncErrors

Many-To-One Relationship: [syncerror msdyn_iotalert_SyncErrors](syncerror.md#BKMK_msdyn_iotalert_SyncErrors)

|Property|Value|
|---|---|
|ReferencingEntity|`syncerror`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_iotalert_SyncErrors`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_msdyn_iotalert_incident_IoTAlert"></a> msdyn_msdyn_iotalert_incident_IoTAlert

Many-To-One Relationship: [incident msdyn_msdyn_iotalert_incident_IoTAlert](incident.md#BKMK_msdyn_msdyn_iotalert_incident_IoTAlert)

|Property|Value|
|---|---|
|ReferencingEntity|`incident`|
|ReferencingAttribute|`msdyn_iotalert`|
|ReferencedEntityNavigationPropertyName|`msdyn_msdyn_iotalert_incident_IoTAlert`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_msdyn_iotalert_msdyn_iotdevicecommand_ParentAlert"></a> msdyn_msdyn_iotalert_msdyn_iotdevicecommand_ParentAlert

Many-To-One Relationship: [msdyn_iotdevicecommand msdyn_msdyn_iotalert_msdyn_iotdevicecommand_ParentAlert](msdyn_iotdevicecommand.md#BKMK_msdyn_msdyn_iotalert_msdyn_iotdevicecommand_ParentAlert)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_iotdevicecommand`|
|ReferencingAttribute|`msdyn_parentalert`|
|ReferencedEntityNavigationPropertyName|`msdyn_msdyn_iotalert_msdyn_iotdevicecommand_ParentAlert`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|



### See also

[Dataverse table/entity reference](/power-apps/developer/data-platform/reference/about-entity-reference)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   

