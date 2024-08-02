---
title: "msdynmkt_experimentv2 table/entity reference (Microsoft Dynamics 365)"
description: "Includes schema information and supported messages for the msdynmkt_experimentv2 table/entity with Microsoft Dynamics 365."
ms.date: 08.01.2024
ms.service: powerapps
ms.topic: reference
author: m-hartmann
ms.author: mhart
search.audienceType: 
  - developer
---

# msdynmkt_experimentv2 table/entity reference



## Messages

The following table lists the messages for the msdynmkt_experimentv2 table.
Messages represent operations that can be performed on the table. They may also be events.

| Name <br />Is Event? |Web API Operation |SDK for .NET |
| ---- | ----- |----- |
| `Assign`<br />Event: True |`PATCH` /msdynmkt_experimentv2s(*msdynmkt_experimentv2id*)<br />[Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) the `ownerid` property. |<xref:Microsoft.Crm.Sdk.Messages.AssignRequest>|
| `Create`<br />Event: True |`POST` /msdynmkt_experimentv2s<br />See [Create](/powerapps/developer/data-platform/webapi/create-entity-web-api) |[Create records](/power-apps/developer/data-platform/org-service/entity-operations-create#basic-create)|
| `CreateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.CreateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.CreateMultipleRequest>|
| `Delete`<br />Event: True |`DELETE` /msdynmkt_experimentv2s(*msdynmkt_experimentv2id*)<br />See [Delete](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-delete) |[Delete records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-delete)|
| `GrantAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.GrantAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.GrantAccessRequest>|
| `IsValidStateTransition`<br />Event: False |<xref:Microsoft.Dynamics.CRM.IsValidStateTransition?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.IsValidStateTransitionRequest>|
| `ModifyAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.ModifyAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.ModifyAccessRequest>|
| `Restore`<br />Event: True |<xref:Microsoft.Dynamics.CRM.Restore?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retrieve`<br />Event: True |`GET` /msdynmkt_experimentv2s(*msdynmkt_experimentv2id*)<br />See [Retrieve](/powerapps/developer/data-platform/webapi/retrieve-entity-using-web-api) |[Retrieve records](/power-apps/developer/data-platform/org-service/entity-operations-retrieve)|
| `RetrieveMultiple`<br />Event: True |`GET` /msdynmkt_experimentv2s<br />See [Query data](/power-apps/developer/data-platform/webapi/query-data-web-api) |[Query data](/power-apps/developer/data-platform/org-service/entity-operations-query-data)|
| `RetrievePrincipalAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RetrievePrincipalAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RetrievePrincipalAccessRequest>|
| `RetrieveSharedPrincipalsAndAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RetrieveSharedPrincipalsAndAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RetrieveSharedPrincipalsAndAccessRequest>|
| `RevokeAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RevokeAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RevokeAccessRequest>|
| `SetState`<br />Event: True |`PATCH` /msdynmkt_experimentv2s(*msdynmkt_experimentv2id*)<br />[Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) the `statecode` and `statuscode` properties. |<xref:Microsoft.Crm.Sdk.Messages.SetStateRequest>|
| `Update`<br />Event: True |`PATCH` /msdynmkt_experimentv2s(*msdynmkt_experimentv2id*)<br />See [Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) |[Update records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-update)|
| `UpdateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.UpdateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpdateMultipleRequest>|
| `Upsert`<br />Event: False |`PATCH` /msdynmkt_experimentv2s(*msdynmkt_experimentv2id*)<br />See [Upsert a table row](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#upsert-a-table-row) |<xref:Microsoft.Xrm.Sdk.Messages.UpsertRequest>|
| `UpsertMultiple`<br />Event: False |<xref:Microsoft.Dynamics.CRM.UpsertMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpsertMultipleRequest>|


## Events

The following table lists the events for the msdynmkt_experimentv2 table.
Events are messages that exist so that you can subscribe to them. Unless you added the event, you shouldn't invoke the message, only subscribe to it.

|Name|Web API Operation |SDK for .NET |
| ---- | ----- |----- |
| `BulkRetain`|<xref:Microsoft.Dynamics.CRM.BulkRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `PurgeRetainedContent`|<xref:Microsoft.Dynamics.CRM.PurgeRetainedContent?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retain`|<xref:Microsoft.Dynamics.CRM.Retain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `RollbackRetain`|<xref:Microsoft.Dynamics.CRM.RollbackRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `ValidateRetentionConfig`|<xref:Microsoft.Dynamics.CRM.ValidateRetentionConfig?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|

## Properties

The following table lists selected properties for the msdynmkt_experimentv2 table.

|Property|Value|
| --- | --- |
| **DisplayName** | **msdynmkt_experimentv2** |
| **DisplayCollectionName** | **msdynmkt_experimentv2s** |
| **SchemaName** | `msdynmkt_experimentv2` |
| **CollectionSchemaName** | `msdynmkt_experimentv2s` |
| **EntitySetName** | `msdynmkt_experimentv2s`|
| **LogicalName** | `msdynmkt_experimentv2` |
| **LogicalCollectionName** | `msdynmkt_experimentv2s` |
| **PrimaryIdAttribute** | `msdynmkt_experimentv2id` |
| **PrimaryNameAttribute** |`msdynmkt_name` |
| **TableType** | `Standard` |
| **OwnershipType** | `UserOwned` |

## Writable columns/attributes

These columns/attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [ImportSequenceNumber](#BKMK_ImportSequenceNumber)
- [msdynmkt_associatejobId](#BKMK_msdynmkt_associatejobId)
- [msdynmkt_callbackaction](#BKMK_msdynmkt_callbackaction)
- [msdynmkt_endTime](#BKMK_msdynmkt_endTime)
- [msdynmkt_experimentactionId](#BKMK_msdynmkt_experimentactionId)
- [msdynmkt_experimentrecordid](#BKMK_msdynmkt_experimentrecordid)
- [msdynmkt_experimentv2Id](#BKMK_msdynmkt_experimentv2Id)
- [msdynmkt_experimentversionnumber](#BKMK_msdynmkt_experimentversionnumber)
- [msdynmkt_experimentversionrecordid](#BKMK_msdynmkt_experimentversionrecordid)
- [msdynmkt_expiryTime](#BKMK_msdynmkt_expiryTime)
- [msdynmkt_name](#BKMK_msdynmkt_name)
- [msdynmkt_productname](#BKMK_msdynmkt_productname)
- [msdynmkt_startTime](#BKMK_msdynmkt_startTime)
- [msdynmkt_status](#BKMK_msdynmkt_status)
- [msdynmkt_testdetails](#BKMK_msdynmkt_testdetails)
- [msdynmkt_winnerOrDefault](#BKMK_msdynmkt_winnerOrDefault)
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

### <a name="BKMK_msdynmkt_associatejobId"></a> msdynmkt_associatejobId

|Property|Value|
|---|---|
|Description||
|DisplayName|**Associate Job Id**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdynmkt_associatejobid`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdynmkt_callbackaction"></a> msdynmkt_callbackaction

|Property|Value|
|---|---|
|Description|**Call back action to get experiment data**|
|DisplayName|**Callback Action**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdynmkt_callbackaction`|
|RequiredLevel|ApplicationRequired|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|1000|

### <a name="BKMK_msdynmkt_endTime"></a> msdynmkt_endTime

|Property|Value|
|---|---|
|Description||
|DisplayName|**Experiment end time**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdynmkt_endtime`|
|RequiredLevel|None|
|Type|DateTime|
|CanChangeDateTimeBehavior|True|
|DateTimeBehavior|UserLocal|
|Format|DateAndTime|
|ImeMode|Inactive|
|SourceTypeMask|0|

### <a name="BKMK_msdynmkt_experimentactionId"></a> msdynmkt_experimentactionId

|Property|Value|
|---|---|
|Description||
|DisplayName|**Experiment Action Id**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdynmkt_experimentactionid`|
|RequiredLevel|ApplicationRequired|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdynmkt_experimentrecordid"></a> msdynmkt_experimentrecordid

|Property|Value|
|---|---|
|Description||
|DisplayName|**Experiment parent id**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdynmkt_experimentrecordid`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdynmkt_experimentv2Id"></a> msdynmkt_experimentv2Id

|Property|Value|
|---|---|
|Description|**Unique identifier for entity instances**|
|DisplayName|**Experimentv2**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`msdynmkt_experimentv2id`|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|

### <a name="BKMK_msdynmkt_experimentversionnumber"></a> msdynmkt_experimentversionnumber

|Property|Value|
|---|---|
|Description||
|DisplayName|**Experiment parent version number**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdynmkt_experimentversionnumber`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdynmkt_experimentversionrecordid"></a> msdynmkt_experimentversionrecordid

|Property|Value|
|---|---|
|Description||
|DisplayName|**Unique Record where experiment is defined**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdynmkt_experimentversionrecordid`|
|RequiredLevel|ApplicationRequired|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdynmkt_expiryTime"></a> msdynmkt_expiryTime

|Property|Value|
|---|---|
|Description||
|DisplayName|**Experiment Expiry Time**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdynmkt_expirytime`|
|RequiredLevel|None|
|Type|DateTime|
|CanChangeDateTimeBehavior|True|
|DateTimeBehavior|UserLocal|
|Format|DateAndTime|
|ImeMode|Auto|
|SourceTypeMask|0|

### <a name="BKMK_msdynmkt_name"></a> msdynmkt_name

|Property|Value|
|---|---|
|Description|**The name of the custom entity.**|
|DisplayName|**Name**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdynmkt_name`|
|RequiredLevel|ApplicationRequired|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdynmkt_productname"></a> msdynmkt_productname

|Property|Value|
|---|---|
|Description||
|DisplayName|**Product where Experiment is defined**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdynmkt_productname`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdynmkt_startTime"></a> msdynmkt_startTime

|Property|Value|
|---|---|
|Description||
|DisplayName|**Experiment start time**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdynmkt_starttime`|
|RequiredLevel|ApplicationRequired|
|Type|DateTime|
|CanChangeDateTimeBehavior|True|
|DateTimeBehavior|UserLocal|
|Format|DateAndTime|
|ImeMode|Inactive|
|SourceTypeMask|0|

### <a name="BKMK_msdynmkt_status"></a> msdynmkt_status

|Property|Value|
|---|---|
|Description||
|DisplayName|**Experiment Status**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdynmkt_status`|
|RequiredLevel|ApplicationRequired|
|Type|Picklist|
|DefaultFormValue|534120005|
|GlobalChoiceName|`msdynmkt_experimentv2_msdynmkt_status`|

#### msdynmkt_status Choices/Options

|Value|Label|
|---|---|
|534120000|**InProgress**|
|534120001|**CompletedInconclusive**|
|534120002|**CompletedConclusive**|
|534120003|**Failed**|
|534120004|**Stopped**|
|534120005|**None**|

### <a name="BKMK_msdynmkt_testdetails"></a> msdynmkt_testdetails

|Property|Value|
|---|---|
|Description||
|DisplayName|**Test Details**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdynmkt_testdetails`|
|RequiredLevel|None|
|Type|Memo|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|1048576|

### <a name="BKMK_msdynmkt_winnerOrDefault"></a> msdynmkt_winnerOrDefault

|Property|Value|
|---|---|
|Description||
|DisplayName|**Experiment winner or default version**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdynmkt_winnerordefault`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

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
|Description|**Status of the msdynmkt_experimentv2**|
|DisplayName|**Status**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statecode`|
|RequiredLevel|SystemRequired|
|Type|State|
|DefaultFormValue||
|GlobalChoiceName|`msdynmkt_experimentv2_statecode`|

#### statecode Choices/Options

|Value|Details|
|---|---|
|0|Label: **Active**<br />DefaultStatus: 1<br />InvariantName: `Active`|
|1|Label: **Inactive**<br />DefaultStatus: 2<br />InvariantName: `Inactive`|

### <a name="BKMK_statuscode"></a> statuscode

|Property|Value|
|---|---|
|Description|**Reason for the status of the msdynmkt_experimentv2**|
|DisplayName|**Status Reason**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statuscode`|
|RequiredLevel|None|
|Type|Status|
|DefaultFormValue||
|GlobalChoiceName|`msdynmkt_experimentv2_statuscode`|

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

- [business_unit_msdynmkt_experimentv2](#BKMK_business_unit_msdynmkt_experimentv2)
- [lk_msdynmkt_experimentv2_createdby](#BKMK_lk_msdynmkt_experimentv2_createdby)
- [lk_msdynmkt_experimentv2_createdonbehalfby](#BKMK_lk_msdynmkt_experimentv2_createdonbehalfby)
- [lk_msdynmkt_experimentv2_modifiedby](#BKMK_lk_msdynmkt_experimentv2_modifiedby)
- [lk_msdynmkt_experimentv2_modifiedonbehalfby](#BKMK_lk_msdynmkt_experimentv2_modifiedonbehalfby)
- [owner_msdynmkt_experimentv2](#BKMK_owner_msdynmkt_experimentv2)
- [team_msdynmkt_experimentv2](#BKMK_team_msdynmkt_experimentv2)
- [user_msdynmkt_experimentv2](#BKMK_user_msdynmkt_experimentv2)

### <a name="BKMK_business_unit_msdynmkt_experimentv2"></a> business_unit_msdynmkt_experimentv2

One-To-Many Relationship: [businessunit business_unit_msdynmkt_experimentv2](businessunit.md#BKMK_business_unit_msdynmkt_experimentv2)

|Property|Value|
|---|---|
|ReferencedEntity|`businessunit`|
|ReferencedAttribute|`businessunitid`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencingEntityNavigationPropertyName|`owningbusinessunit`|
|IsHierarchical||
|CascadeConfiguration|Archive: `Restrict`<br />Assign: `NoCascade`<br />Delete: `Restrict`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdynmkt_experimentv2_createdby"></a> lk_msdynmkt_experimentv2_createdby

One-To-Many Relationship: [systemuser lk_msdynmkt_experimentv2_createdby](systemuser.md#BKMK_lk_msdynmkt_experimentv2_createdby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdby`|
|ReferencingEntityNavigationPropertyName|`createdby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdynmkt_experimentv2_createdonbehalfby"></a> lk_msdynmkt_experimentv2_createdonbehalfby

One-To-Many Relationship: [systemuser lk_msdynmkt_experimentv2_createdonbehalfby](systemuser.md#BKMK_lk_msdynmkt_experimentv2_createdonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdonbehalfby`|
|ReferencingEntityNavigationPropertyName|`createdonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdynmkt_experimentv2_modifiedby"></a> lk_msdynmkt_experimentv2_modifiedby

One-To-Many Relationship: [systemuser lk_msdynmkt_experimentv2_modifiedby](systemuser.md#BKMK_lk_msdynmkt_experimentv2_modifiedby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedby`|
|ReferencingEntityNavigationPropertyName|`modifiedby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdynmkt_experimentv2_modifiedonbehalfby"></a> lk_msdynmkt_experimentv2_modifiedonbehalfby

One-To-Many Relationship: [systemuser lk_msdynmkt_experimentv2_modifiedonbehalfby](systemuser.md#BKMK_lk_msdynmkt_experimentv2_modifiedonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedonbehalfby`|
|ReferencingEntityNavigationPropertyName|`modifiedonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_owner_msdynmkt_experimentv2"></a> owner_msdynmkt_experimentv2

One-To-Many Relationship: [owner owner_msdynmkt_experimentv2](owner.md#BKMK_owner_msdynmkt_experimentv2)

|Property|Value|
|---|---|
|ReferencedEntity|`owner`|
|ReferencedAttribute|`ownerid`|
|ReferencingAttribute|`ownerid`|
|ReferencingEntityNavigationPropertyName|`ownerid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_team_msdynmkt_experimentv2"></a> team_msdynmkt_experimentv2

One-To-Many Relationship: [team team_msdynmkt_experimentv2](team.md#BKMK_team_msdynmkt_experimentv2)

|Property|Value|
|---|---|
|ReferencedEntity|`team`|
|ReferencedAttribute|`teamid`|
|ReferencingAttribute|`owningteam`|
|ReferencingEntityNavigationPropertyName|`owningteam`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_user_msdynmkt_experimentv2"></a> user_msdynmkt_experimentv2

One-To-Many Relationship: [systemuser user_msdynmkt_experimentv2](systemuser.md#BKMK_user_msdynmkt_experimentv2)

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

- [msdynmkt_experimentv2_AsyncOperations](#BKMK_msdynmkt_experimentv2_AsyncOperations)
- [msdynmkt_experimentv2_BulkDeleteFailures](#BKMK_msdynmkt_experimentv2_BulkDeleteFailures)
- [msdynmkt_experimentv2_DuplicateBaseRecord](#BKMK_msdynmkt_experimentv2_DuplicateBaseRecord)
- [msdynmkt_experimentv2_DuplicateMatchingRecord](#BKMK_msdynmkt_experimentv2_DuplicateMatchingRecord)
- [msdynmkt_experimentv2_MailboxTrackingFolders](#BKMK_msdynmkt_experimentv2_MailboxTrackingFolders)
- [msdynmkt_experimentv2_PrincipalObjectAttributeAccesses](#BKMK_msdynmkt_experimentv2_PrincipalObjectAttributeAccesses)
- [msdynmkt_experimentv2_ProcessSession](#BKMK_msdynmkt_experimentv2_ProcessSession)
- [msdynmkt_experimentv2_SyncErrors](#BKMK_msdynmkt_experimentv2_SyncErrors)

### <a name="BKMK_msdynmkt_experimentv2_AsyncOperations"></a> msdynmkt_experimentv2_AsyncOperations

Many-To-One Relationship: [asyncoperation msdynmkt_experimentv2_AsyncOperations](asyncoperation.md#BKMK_msdynmkt_experimentv2_AsyncOperations)

|Property|Value|
|---|---|
|ReferencingEntity|`asyncoperation`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdynmkt_experimentv2_AsyncOperations`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdynmkt_experimentv2_BulkDeleteFailures"></a> msdynmkt_experimentv2_BulkDeleteFailures

Many-To-One Relationship: [bulkdeletefailure msdynmkt_experimentv2_BulkDeleteFailures](bulkdeletefailure.md#BKMK_msdynmkt_experimentv2_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencingEntity|`bulkdeletefailure`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdynmkt_experimentv2_BulkDeleteFailures`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdynmkt_experimentv2_DuplicateBaseRecord"></a> msdynmkt_experimentv2_DuplicateBaseRecord

Many-To-One Relationship: [duplicaterecord msdynmkt_experimentv2_DuplicateBaseRecord](duplicaterecord.md#BKMK_msdynmkt_experimentv2_DuplicateBaseRecord)

|Property|Value|
|---|---|
|ReferencingEntity|`duplicaterecord`|
|ReferencingAttribute|`baserecordid`|
|ReferencedEntityNavigationPropertyName|`msdynmkt_experimentv2_DuplicateBaseRecord`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdynmkt_experimentv2_DuplicateMatchingRecord"></a> msdynmkt_experimentv2_DuplicateMatchingRecord

Many-To-One Relationship: [duplicaterecord msdynmkt_experimentv2_DuplicateMatchingRecord](duplicaterecord.md#BKMK_msdynmkt_experimentv2_DuplicateMatchingRecord)

|Property|Value|
|---|---|
|ReferencingEntity|`duplicaterecord`|
|ReferencingAttribute|`duplicaterecordid`|
|ReferencedEntityNavigationPropertyName|`msdynmkt_experimentv2_DuplicateMatchingRecord`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdynmkt_experimentv2_MailboxTrackingFolders"></a> msdynmkt_experimentv2_MailboxTrackingFolders

Many-To-One Relationship: [mailboxtrackingfolder msdynmkt_experimentv2_MailboxTrackingFolders](mailboxtrackingfolder.md#BKMK_msdynmkt_experimentv2_MailboxTrackingFolders)

|Property|Value|
|---|---|
|ReferencingEntity|`mailboxtrackingfolder`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdynmkt_experimentv2_MailboxTrackingFolders`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdynmkt_experimentv2_PrincipalObjectAttributeAccesses"></a> msdynmkt_experimentv2_PrincipalObjectAttributeAccesses

Many-To-One Relationship: [principalobjectattributeaccess msdynmkt_experimentv2_PrincipalObjectAttributeAccesses](principalobjectattributeaccess.md#BKMK_msdynmkt_experimentv2_PrincipalObjectAttributeAccesses)

|Property|Value|
|---|---|
|ReferencingEntity|`principalobjectattributeaccess`|
|ReferencingAttribute|`objectid`|
|ReferencedEntityNavigationPropertyName|`msdynmkt_experimentv2_PrincipalObjectAttributeAccesses`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdynmkt_experimentv2_ProcessSession"></a> msdynmkt_experimentv2_ProcessSession

Many-To-One Relationship: [processsession msdynmkt_experimentv2_ProcessSession](processsession.md#BKMK_msdynmkt_experimentv2_ProcessSession)

|Property|Value|
|---|---|
|ReferencingEntity|`processsession`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdynmkt_experimentv2_ProcessSession`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdynmkt_experimentv2_SyncErrors"></a> msdynmkt_experimentv2_SyncErrors

Many-To-One Relationship: [syncerror msdynmkt_experimentv2_SyncErrors](syncerror.md#BKMK_msdynmkt_experimentv2_SyncErrors)

|Property|Value|
|---|---|
|ReferencingEntity|`syncerror`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdynmkt_experimentv2_SyncErrors`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|



### See also

[Dataverse table/entity reference](../about-entity-reference.md)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   

