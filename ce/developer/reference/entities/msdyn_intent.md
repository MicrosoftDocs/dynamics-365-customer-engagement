---
title: "intent (msdyn_intent) table/entity reference (Microsoft Dynamics 365)"
description: "Includes schema information and supported messages for the intent (msdyn_intent) table/entity with Microsoft Dynamics 365."
ms.topic: generated-reference
author: JimDaly
ms.author: jdaly
search.audienceType: 
  - developer
---

# intent (msdyn_intent) table/entity reference (Microsoft Dynamics 365)

Captures the unique natural language intent

## Messages

The following table lists the messages for the intent (msdyn_intent) table.
Messages represent operations that can be performed on the table. They may also be events.

| Name <br />Is Event? |Web API Operation |SDK for .NET |
| ---- | ----- |----- |
| `Assign`<br />Event: True |`PATCH` /msdyn_intents(*msdyn_intentid*)<br />[Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) the `ownerid` property. |<xref:Microsoft.Crm.Sdk.Messages.AssignRequest>|
| `Associate`<br />Event: True |[Associate records](/power-apps/developer/data-platform/webapi/associate-disassociate-entities-using-web-api) |[Associate records](/power-apps/developer/data-platform/org-service/entity-operations-associate-disassociate#use-the-associate-method-or-associaterequest)|
| `BulkRetain`<br />Event: True |<xref:Microsoft.Dynamics.CRM.BulkRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Create`<br />Event: True |`POST` /msdyn_intents<br />See [Create](/powerapps/developer/data-platform/webapi/create-entity-web-api) |[Create records](/power-apps/developer/data-platform/org-service/entity-operations-create#basic-create)|
| `CreateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.CreateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.CreateMultipleRequest>|
| `Delete`<br />Event: True |`DELETE` /msdyn_intents(*msdyn_intentid*)<br />See [Delete](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-delete) |[Delete records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-delete)|
| `Disassociate`<br />Event: True |[Disassociate records](/power-apps/developer/data-platform/webapi/associate-disassociate-entities-using-web-api) |[Disassociate records](/power-apps/developer/data-platform/org-service/entity-operations-associate-disassociate#use-the-disassociate-method-or-disassociaterequest)|
| `GrantAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.GrantAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.GrantAccessRequest>|
| `IsValidStateTransition`<br />Event: False |<xref:Microsoft.Dynamics.CRM.IsValidStateTransition?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.IsValidStateTransitionRequest>|
| `ModifyAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.ModifyAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.ModifyAccessRequest>|
| `PurgeRetainedContent`<br />Event: True |<xref:Microsoft.Dynamics.CRM.PurgeRetainedContent?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retain`<br />Event: True |<xref:Microsoft.Dynamics.CRM.Retain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retrieve`<br />Event: True |`GET` /msdyn_intents(*msdyn_intentid*)<br />See [Retrieve](/powerapps/developer/data-platform/webapi/retrieve-entity-using-web-api) |[Retrieve records](/power-apps/developer/data-platform/org-service/entity-operations-retrieve)|
| `RetrieveMultiple`<br />Event: True |`GET` /msdyn_intents<br />See [Query data](/power-apps/developer/data-platform/webapi/query-data-web-api) |[Query data](/power-apps/developer/data-platform/org-service/entity-operations-query-data)|
| `RetrievePrincipalAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RetrievePrincipalAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RetrievePrincipalAccessRequest>|
| `RetrieveSharedPrincipalsAndAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RetrieveSharedPrincipalsAndAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RetrieveSharedPrincipalsAndAccessRequest>|
| `RevokeAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RevokeAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RevokeAccessRequest>|
| `RollbackRetain`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RollbackRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `SetState`<br />Event: True |`PATCH` /msdyn_intents(*msdyn_intentid*)<br />[Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) the `statecode` and `statuscode` properties. |<xref:Microsoft.Crm.Sdk.Messages.SetStateRequest>|
| `Update`<br />Event: True |`PATCH` /msdyn_intents(*msdyn_intentid*)<br />See [Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) |[Update records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-update)|
| `UpdateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.UpdateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpdateMultipleRequest>|
| `Upsert`<br />Event: False |`PATCH` /msdyn_intents(*msdyn_intentid*)<br />See [Upsert a table row](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#upsert-a-table-row) |<xref:Microsoft.Xrm.Sdk.Messages.UpsertRequest>|
| `UpsertMultiple`<br />Event: False |<xref:Microsoft.Dynamics.CRM.UpsertMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpsertMultipleRequest>|
| `ValidateRetentionConfig`<br />Event: True |<xref:Microsoft.Dynamics.CRM.ValidateRetentionConfig?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|

## Properties

The following table lists selected properties for the intent (msdyn_intent) table.

|Property|Value|
| --- | --- |
| **DisplayName** | **intent** |
| **DisplayCollectionName** | **intents** |
| **SchemaName** | `msdyn_intent` |
| **CollectionSchemaName** | `msdyn_intents` |
| **EntitySetName** | `msdyn_intents`|
| **LogicalName** | `msdyn_intent` |
| **LogicalCollectionName** | `msdyn_intents` |
| **PrimaryIdAttribute** | `msdyn_intentid` |
| **PrimaryNameAttribute** |`msdyn_name` |
| **TableType** | `Standard` |
| **OwnershipType** | `UserOwned` |

## Writable columns/attributes

These columns/attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [ImportSequenceNumber](#BKMK_ImportSequenceNumber)
- [IsCustomizable](#BKMK_IsCustomizable)
- [msdyn_harvestingsource](#BKMK_msdyn_harvestingsource)
- [msdyn_intentfamilyid](#BKMK_msdyn_intentfamilyid)
- [msdyn_intentharvesting_batchjobstatusid](#BKMK_msdyn_intentharvesting_batchjobstatusid)
- [msdyn_intentId](#BKMK_msdyn_intentId)
- [msdyn_intentstring](#BKMK_msdyn_intentstring)
- [msdyn_isgroup](#BKMK_msdyn_isgroup)
- [msdyn_name](#BKMK_msdyn_name)
- [msdyn_occurrencecount](#BKMK_msdyn_occurrencecount)
- [msdyn_occurrencecount_last12months](#BKMK_msdyn_occurrencecount_last12months)
- [msdyn_occurrencecount_last30days](#BKMK_msdyn_occurrencecount_last30days)
- [msdyn_parentgroupid](#BKMK_msdyn_parentgroupid)
- [msdyn_reviewstate](#BKMK_msdyn_reviewstate)
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

### <a name="BKMK_IsCustomizable"></a> IsCustomizable

|Property|Value|
|---|---|
|Description|**For internal use only.**|
|DisplayName|**Is Customizable**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`iscustomizable`|
|RequiredLevel|SystemRequired|
|Type|ManagedProperty|

### <a name="BKMK_msdyn_harvestingsource"></a> msdyn_harvestingsource

|Property|Value|
|---|---|
|Description||
|DisplayName|**source**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_harvestingsource`|
|RequiredLevel|ApplicationRequired|
|Type|Picklist|
|DefaultFormValue|192350000|
|GlobalChoiceName|`msdyn_intent_source`|

#### msdyn_harvestingsource Choices/Options

|Value|Label|
|---|---|
|192350000|**Data Execution Run**|
|192350001|**Simulation**|
|192350002|**Manually Edited**|

### <a name="BKMK_msdyn_intentfamilyid"></a> msdyn_intentfamilyid

|Property|Value|
|---|---|
|Description||
|DisplayName|**intentfamilyid**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_intentfamilyid`|
|RequiredLevel|ApplicationRequired|
|Type|Lookup|
|Targets|msdyn_intentfamily|

### <a name="BKMK_msdyn_intentharvesting_batchjobstatusid"></a> msdyn_intentharvesting_batchjobstatusid

|Property|Value|
|---|---|
|Description|**Look up to msdyn_intentharvesting_batchjobstatus table**|
|DisplayName|**msdyn_intentharvesting_batchjobstatusid**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_intentharvesting_batchjobstatusid`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|msdyn_intentharvesting_batchjobstatus|

### <a name="BKMK_msdyn_intentId"></a> msdyn_intentId

|Property|Value|
|---|---|
|Description|**Unique identifier for entity instances**|
|DisplayName|**intent**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`msdyn_intentid`|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|

### <a name="BKMK_msdyn_intentstring"></a> msdyn_intentstring

|Property|Value|
|---|---|
|Description|**Text of intent string**|
|DisplayName|**msdyn_intentstring**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_intentstring`|
|RequiredLevel|ApplicationRequired|
|Type|Memo|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|2000|

### <a name="BKMK_msdyn_isgroup"></a> msdyn_isgroup

|Property|Value|
|---|---|
|Description|**Indicates if this is an intent group**|
|DisplayName|**isgroup**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_isgroup`|
|RequiredLevel|ApplicationRequired|
|Type|Boolean|
|GlobalChoiceName|`msdyn_intent_msdyn_isgroup`|
|DefaultValue|False|
|True Label|True|
|False Label|False|

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

### <a name="BKMK_msdyn_occurrencecount"></a> msdyn_occurrencecount

|Property|Value|
|---|---|
|Description|**occurrence count of the intent**|
|DisplayName|**occurrencecount**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_occurrencecount`|
|RequiredLevel|None|
|Type|Integer|
|MaxValue|2147483647|
|MinValue|-2147483648|

### <a name="BKMK_msdyn_occurrencecount_last12months"></a> msdyn_occurrencecount_last12months

|Property|Value|
|---|---|
|Description|**occurrence count of the intent in last 12 months**|
|DisplayName|**occurrencecount_last12months**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_occurrencecount_last12months`|
|RequiredLevel|None|
|Type|Integer|
|MaxValue|2147483647|
|MinValue|-2147483648|

### <a name="BKMK_msdyn_occurrencecount_last30days"></a> msdyn_occurrencecount_last30days

|Property|Value|
|---|---|
|Description|**occurrence count of the intent in last 30 days**|
|DisplayName|**occurrencecount_last30days**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_occurrencecount_last30days`|
|RequiredLevel|None|
|Type|Integer|
|MaxValue|2147483647|
|MinValue|-2147483648|

### <a name="BKMK_msdyn_parentgroupid"></a> msdyn_parentgroupid

|Property|Value|
|---|---|
|Description|**Lookup to intent table, points to parent intent group**|
|DisplayName|**parentgroupid**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_parentgroupid`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|msdyn_intent|

### <a name="BKMK_msdyn_reviewstate"></a> msdyn_reviewstate

|Property|Value|
|---|---|
|Description||
|DisplayName|**reviewstate**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_reviewstate`|
|RequiredLevel|ApplicationRequired|
|Type|Picklist|
|DefaultFormValue|192350000|
|GlobalChoiceName|`msdyn_reviewstate`|

#### msdyn_reviewstate Choices/Options

|Value|Label|
|---|---|
|192350000|**Pending**|
|192350001|**Approved**|
|192350002|**Discarded**|

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
|Description|**Status of the intent**|
|DisplayName|**Status**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statecode`|
|RequiredLevel|SystemRequired|
|Type|State|
|DefaultFormValue||
|GlobalChoiceName|`msdyn_intent_statecode`|

#### statecode Choices/Options

|Value|Details|
|---|---|
|0|Label: **Active**<br />DefaultStatus: 1<br />InvariantName: `Active`|
|1|Label: **Inactive**<br />DefaultStatus: 2<br />InvariantName: `Inactive`|

### <a name="BKMK_statuscode"></a> statuscode

|Property|Value|
|---|---|
|Description|**Reason for the status of the intent**|
|DisplayName|**Status Reason**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statuscode`|
|RequiredLevel|None|
|Type|Status|
|DefaultFormValue||
|GlobalChoiceName|`msdyn_intent_statuscode`|

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

- [ComponentIdUnique](#BKMK_ComponentIdUnique)
- [ComponentState](#BKMK_ComponentState)
- [CreatedBy](#BKMK_CreatedBy)
- [CreatedOn](#BKMK_CreatedOn)
- [CreatedOnBehalfBy](#BKMK_CreatedOnBehalfBy)
- [IsManaged](#BKMK_IsManaged)
- [ModifiedBy](#BKMK_ModifiedBy)
- [ModifiedOn](#BKMK_ModifiedOn)
- [ModifiedOnBehalfBy](#BKMK_ModifiedOnBehalfBy)
- [OverwriteTime](#BKMK_OverwriteTime)
- [OwnerIdName](#BKMK_OwnerIdName)
- [OwnerIdYomiName](#BKMK_OwnerIdYomiName)
- [OwningBusinessUnit](#BKMK_OwningBusinessUnit)
- [OwningTeam](#BKMK_OwningTeam)
- [OwningUser](#BKMK_OwningUser)
- [SolutionId](#BKMK_SolutionId)
- [SupportingSolutionId](#BKMK_SupportingSolutionId)
- [VersionNumber](#BKMK_VersionNumber)

### <a name="BKMK_ComponentIdUnique"></a> ComponentIdUnique

|Property|Value|
|---|---|
|Description|**For internal use only.**|
|DisplayName|**Row id unique**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`componentidunique`|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|

### <a name="BKMK_ComponentState"></a> ComponentState

|Property|Value|
|---|---|
|Description|**For internal use only.**|
|DisplayName|**Component State**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`componentstate`|
|RequiredLevel|SystemRequired|
|Type|Picklist|
|DefaultFormValue||
|GlobalChoiceName|`componentstate`|

#### ComponentState Choices/Options

|Value|Label|
|---|---|
|0|**Published**|
|1|**Unpublished**|
|2|**Deleted**|
|3|**Deleted Unpublished**|

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

### <a name="BKMK_IsManaged"></a> IsManaged

|Property|Value|
|---|---|
|Description|**Indicates whether the solution component is part of a managed solution.**|
|DisplayName|**Is Managed**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`ismanaged`|
|RequiredLevel|SystemRequired|
|Type|Boolean|
|GlobalChoiceName|`ismanaged`|
|DefaultValue|False|
|True Label|Managed|
|False Label|Unmanaged|

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

### <a name="BKMK_OverwriteTime"></a> OverwriteTime

|Property|Value|
|---|---|
|Description|**For internal use only.**|
|DisplayName|**Record Overwrite Time**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`overwritetime`|
|RequiredLevel|SystemRequired|
|Type|DateTime|
|CanChangeDateTimeBehavior|False|
|DateTimeBehavior|UserLocal|
|Format|DateAndTime|
|ImeMode|Inactive|
|SourceTypeMask|0|

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
|RequiredLevel|SystemRequired|
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

### <a name="BKMK_SolutionId"></a> SolutionId

|Property|Value|
|---|---|
|Description|**Unique identifier of the associated solution.**|
|DisplayName|**Solution**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`solutionid`|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|

### <a name="BKMK_SupportingSolutionId"></a> SupportingSolutionId

|Property|Value|
|---|---|
|Description|**For internal use only.**|
|DisplayName|**Solution**|
|IsValidForForm|False|
|IsValidForRead|False|
|LogicalName|`supportingsolutionid`|
|RequiredLevel|None|
|Type|Uniqueidentifier|

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

- [business_unit_msdyn_intent](#BKMK_business_unit_msdyn_intent)
- [lk_msdyn_intent_createdby](#BKMK_lk_msdyn_intent_createdby)
- [lk_msdyn_intent_createdonbehalfby](#BKMK_lk_msdyn_intent_createdonbehalfby)
- [lk_msdyn_intent_modifiedby](#BKMK_lk_msdyn_intent_modifiedby)
- [lk_msdyn_intent_modifiedonbehalfby](#BKMK_lk_msdyn_intent_modifiedonbehalfby)
- [msdyn_intent_intentfamilyid_msdyn_intentfamily](#BKMK_msdyn_intent_intentfamilyid_msdyn_intentfamily)
- [msdyn_msdyn_intent_msdyn_intent_parentgroupid](#BKMK_msdyn_msdyn_intent_msdyn_intent_parentgroupid-many-to-one)
- [owner_msdyn_intent](#BKMK_owner_msdyn_intent)
- [team_msdyn_intent](#BKMK_team_msdyn_intent)
- [user_msdyn_intent](#BKMK_user_msdyn_intent)

### <a name="BKMK_business_unit_msdyn_intent"></a> business_unit_msdyn_intent

One-To-Many Relationship: [businessunit business_unit_msdyn_intent](businessunit.md#BKMK_business_unit_msdyn_intent)

|Property|Value|
|---|---|
|ReferencedEntity|`businessunit`|
|ReferencedAttribute|`businessunitid`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencingEntityNavigationPropertyName|`owningbusinessunit`|
|IsHierarchical||
|CascadeConfiguration|Archive: `Restrict`<br />Assign: `NoCascade`<br />Delete: `Restrict`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_intent_createdby"></a> lk_msdyn_intent_createdby

One-To-Many Relationship: [systemuser lk_msdyn_intent_createdby](systemuser.md#BKMK_lk_msdyn_intent_createdby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdby`|
|ReferencingEntityNavigationPropertyName|`createdby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_intent_createdonbehalfby"></a> lk_msdyn_intent_createdonbehalfby

One-To-Many Relationship: [systemuser lk_msdyn_intent_createdonbehalfby](systemuser.md#BKMK_lk_msdyn_intent_createdonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdonbehalfby`|
|ReferencingEntityNavigationPropertyName|`createdonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_intent_modifiedby"></a> lk_msdyn_intent_modifiedby

One-To-Many Relationship: [systemuser lk_msdyn_intent_modifiedby](systemuser.md#BKMK_lk_msdyn_intent_modifiedby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedby`|
|ReferencingEntityNavigationPropertyName|`modifiedby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_intent_modifiedonbehalfby"></a> lk_msdyn_intent_modifiedonbehalfby

One-To-Many Relationship: [systemuser lk_msdyn_intent_modifiedonbehalfby](systemuser.md#BKMK_lk_msdyn_intent_modifiedonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedonbehalfby`|
|ReferencingEntityNavigationPropertyName|`modifiedonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_intent_intentfamilyid_msdyn_intentfamily"></a> msdyn_intent_intentfamilyid_msdyn_intentfamily

One-To-Many Relationship: [msdyn_intentfamily msdyn_intent_intentfamilyid_msdyn_intentfamily](msdyn_intentfamily.md#BKMK_msdyn_intent_intentfamilyid_msdyn_intentfamily)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_intentfamily`|
|ReferencedAttribute|`msdyn_intentfamilyid`|
|ReferencingAttribute|`msdyn_intentfamilyid`|
|ReferencingEntityNavigationPropertyName|`msdyn_intentfamilyid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `RemoveLink`<br />Assign: `NoCascade`<br />Delete: `Restrict`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_msdyn_intent_msdyn_intent_parentgroupid-many-to-one"></a> msdyn_msdyn_intent_msdyn_intent_parentgroupid

One-To-Many Relationship: [msdyn_intent msdyn_msdyn_intent_msdyn_intent_parentgroupid](#BKMK_msdyn_msdyn_intent_msdyn_intent_parentgroupid-one-to-many)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_intent`|
|ReferencedAttribute|`msdyn_intentid`|
|ReferencingAttribute|`msdyn_parentgroupid`|
|ReferencingEntityNavigationPropertyName|`msdyn_parentgroupid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `RemoveLink`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_owner_msdyn_intent"></a> owner_msdyn_intent

One-To-Many Relationship: [owner owner_msdyn_intent](owner.md#BKMK_owner_msdyn_intent)

|Property|Value|
|---|---|
|ReferencedEntity|`owner`|
|ReferencedAttribute|`ownerid`|
|ReferencingAttribute|`ownerid`|
|ReferencingEntityNavigationPropertyName|`ownerid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_team_msdyn_intent"></a> team_msdyn_intent

One-To-Many Relationship: [team team_msdyn_intent](team.md#BKMK_team_msdyn_intent)

|Property|Value|
|---|---|
|ReferencedEntity|`team`|
|ReferencedAttribute|`teamid`|
|ReferencingAttribute|`owningteam`|
|ReferencingEntityNavigationPropertyName|`owningteam`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_user_msdyn_intent"></a> user_msdyn_intent

One-To-Many Relationship: [systemuser user_msdyn_intent](systemuser.md#BKMK_user_msdyn_intent)

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

- [msdyn_intent_AsyncOperations](#BKMK_msdyn_intent_AsyncOperations)
- [msdyn_intent_BulkDeleteFailures](#BKMK_msdyn_intent_BulkDeleteFailures)
- [msdyn_intent_DuplicateBaseRecord](#BKMK_msdyn_intent_DuplicateBaseRecord)
- [msdyn_intent_DuplicateMatchingRecord](#BKMK_msdyn_intent_DuplicateMatchingRecord)
- [msdyn_intent_MailboxTrackingFolders](#BKMK_msdyn_intent_MailboxTrackingFolders)
- [msdyn_intent_PrincipalObjectAttributeAccesses](#BKMK_msdyn_intent_PrincipalObjectAttributeAccesses)
- [msdyn_intent_ProcessSession](#BKMK_msdyn_intent_ProcessSession)
- [msdyn_intent_SyncErrors](#BKMK_msdyn_intent_SyncErrors)
- [msdyn_intententity_intentgroupid_msdyn_intent](#BKMK_msdyn_intententity_intentgroupid_msdyn_intent)
- [msdyn_intentsolutionmap_intentid_msdyn_intent](#BKMK_msdyn_intentsolutionmap_intentid_msdyn_intent)
- [msdyn_msdyn_intent_msdyn_intent_parentgroupid](#BKMK_msdyn_msdyn_intent_msdyn_intent_parentgroupid-one-to-many)
- [msdyn_msdyn_intent_msdyn_intentattributeset_intentid](#BKMK_msdyn_msdyn_intent_msdyn_intentattributeset_intentid)
- [msdyn_msdyn_intent_msdyn_intententity_intentid](#BKMK_msdyn_msdyn_intent_msdyn_intententity_intentid)
- [msdyn_msdyn_ocliveworkitem_msdyn_intent_activeintentgroupid](#BKMK_msdyn_msdyn_ocliveworkitem_msdyn_intent_activeintentgroupid)
- [msdyn_msdyn_ocliveworkitem_msdyn_intent_activeintentid](#BKMK_msdyn_msdyn_ocliveworkitem_msdyn_intent_activeintentid)

### <a name="BKMK_msdyn_intent_AsyncOperations"></a> msdyn_intent_AsyncOperations

Many-To-One Relationship: [asyncoperation msdyn_intent_AsyncOperations](asyncoperation.md#BKMK_msdyn_intent_AsyncOperations)

|Property|Value|
|---|---|
|ReferencingEntity|`asyncoperation`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_intent_AsyncOperations`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_intent_BulkDeleteFailures"></a> msdyn_intent_BulkDeleteFailures

Many-To-One Relationship: [bulkdeletefailure msdyn_intent_BulkDeleteFailures](bulkdeletefailure.md#BKMK_msdyn_intent_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencingEntity|`bulkdeletefailure`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_intent_BulkDeleteFailures`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_intent_DuplicateBaseRecord"></a> msdyn_intent_DuplicateBaseRecord

Many-To-One Relationship: [duplicaterecord msdyn_intent_DuplicateBaseRecord](duplicaterecord.md#BKMK_msdyn_intent_DuplicateBaseRecord)

|Property|Value|
|---|---|
|ReferencingEntity|`duplicaterecord`|
|ReferencingAttribute|`baserecordid`|
|ReferencedEntityNavigationPropertyName|`msdyn_intent_DuplicateBaseRecord`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_intent_DuplicateMatchingRecord"></a> msdyn_intent_DuplicateMatchingRecord

Many-To-One Relationship: [duplicaterecord msdyn_intent_DuplicateMatchingRecord](duplicaterecord.md#BKMK_msdyn_intent_DuplicateMatchingRecord)

|Property|Value|
|---|---|
|ReferencingEntity|`duplicaterecord`|
|ReferencingAttribute|`duplicaterecordid`|
|ReferencedEntityNavigationPropertyName|`msdyn_intent_DuplicateMatchingRecord`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_intent_MailboxTrackingFolders"></a> msdyn_intent_MailboxTrackingFolders

Many-To-One Relationship: [mailboxtrackingfolder msdyn_intent_MailboxTrackingFolders](mailboxtrackingfolder.md#BKMK_msdyn_intent_MailboxTrackingFolders)

|Property|Value|
|---|---|
|ReferencingEntity|`mailboxtrackingfolder`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_intent_MailboxTrackingFolders`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_intent_PrincipalObjectAttributeAccesses"></a> msdyn_intent_PrincipalObjectAttributeAccesses

Many-To-One Relationship: [principalobjectattributeaccess msdyn_intent_PrincipalObjectAttributeAccesses](principalobjectattributeaccess.md#BKMK_msdyn_intent_PrincipalObjectAttributeAccesses)

|Property|Value|
|---|---|
|ReferencingEntity|`principalobjectattributeaccess`|
|ReferencingAttribute|`objectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_intent_PrincipalObjectAttributeAccesses`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_intent_ProcessSession"></a> msdyn_intent_ProcessSession

Many-To-One Relationship: [processsession msdyn_intent_ProcessSession](processsession.md#BKMK_msdyn_intent_ProcessSession)

|Property|Value|
|---|---|
|ReferencingEntity|`processsession`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_intent_ProcessSession`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_intent_SyncErrors"></a> msdyn_intent_SyncErrors

Many-To-One Relationship: [syncerror msdyn_intent_SyncErrors](syncerror.md#BKMK_msdyn_intent_SyncErrors)

|Property|Value|
|---|---|
|ReferencingEntity|`syncerror`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_intent_SyncErrors`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_intententity_intentgroupid_msdyn_intent"></a> msdyn_intententity_intentgroupid_msdyn_intent

Many-To-One Relationship: [msdyn_intententity msdyn_intententity_intentgroupid_msdyn_intent](msdyn_intententity.md#BKMK_msdyn_intententity_intentgroupid_msdyn_intent)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_intententity`|
|ReferencingAttribute|`msdyn_intentgroupid`|
|ReferencedEntityNavigationPropertyName|`msdyn_intententity_intentgroupid_msdyn_intent`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_intentsolutionmap_intentid_msdyn_intent"></a> msdyn_intentsolutionmap_intentid_msdyn_intent

Many-To-One Relationship: [msdyn_intentsolutionmap msdyn_intentsolutionmap_intentid_msdyn_intent](msdyn_intentsolutionmap.md#BKMK_msdyn_intentsolutionmap_intentid_msdyn_intent)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_intentsolutionmap`|
|ReferencingAttribute|`msdyn_intentid`|
|ReferencedEntityNavigationPropertyName|`msdyn_intentsolutionmap_intentid_msdyn_intent`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_msdyn_intent_msdyn_intent_parentgroupid-one-to-many"></a> msdyn_msdyn_intent_msdyn_intent_parentgroupid

Many-To-One Relationship: [msdyn_intent msdyn_msdyn_intent_msdyn_intent_parentgroupid](#BKMK_msdyn_msdyn_intent_msdyn_intent_parentgroupid-many-to-one)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_intent`|
|ReferencingAttribute|`msdyn_parentgroupid`|
|ReferencedEntityNavigationPropertyName|`msdyn_msdyn_intent_msdyn_intent_parentgroupid`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_msdyn_intent_msdyn_intentattributeset_intentid"></a> msdyn_msdyn_intent_msdyn_intentattributeset_intentid

Many-To-One Relationship: [msdyn_intentattributeset msdyn_msdyn_intent_msdyn_intentattributeset_intentid](msdyn_intentattributeset.md#BKMK_msdyn_msdyn_intent_msdyn_intentattributeset_intentid)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_intentattributeset`|
|ReferencingAttribute|`msdyn_intentid`|
|ReferencedEntityNavigationPropertyName|`msdyn_msdyn_intent_msdyn_intentattributeset_intentid`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_msdyn_intent_msdyn_intententity_intentid"></a> msdyn_msdyn_intent_msdyn_intententity_intentid

Many-To-One Relationship: [msdyn_intententity msdyn_msdyn_intent_msdyn_intententity_intentid](msdyn_intententity.md#BKMK_msdyn_msdyn_intent_msdyn_intententity_intentid)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_intententity`|
|ReferencingAttribute|`msdyn_intentid`|
|ReferencedEntityNavigationPropertyName|`msdyn_msdyn_intent_msdyn_intententity_intentid`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_msdyn_ocliveworkitem_msdyn_intent_activeintentgroupid"></a> msdyn_msdyn_ocliveworkitem_msdyn_intent_activeintentgroupid

Many-To-One Relationship: [msdyn_ocliveworkitem msdyn_msdyn_ocliveworkitem_msdyn_intent_activeintentgroupid](msdyn_ocliveworkitem.md#BKMK_msdyn_msdyn_ocliveworkitem_msdyn_intent_activeintentgroupid)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_ocliveworkitem`|
|ReferencingAttribute|`msdyn_activeintentgroupid`|
|ReferencedEntityNavigationPropertyName|`msdyn_msdyn_ocliveworkitem_msdyn_intent_activeintentgroupid`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_msdyn_ocliveworkitem_msdyn_intent_activeintentid"></a> msdyn_msdyn_ocliveworkitem_msdyn_intent_activeintentid

Many-To-One Relationship: [msdyn_ocliveworkitem msdyn_msdyn_ocliveworkitem_msdyn_intent_activeintentid](msdyn_ocliveworkitem.md#BKMK_msdyn_msdyn_ocliveworkitem_msdyn_intent_activeintentid)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_ocliveworkitem`|
|ReferencingAttribute|`msdyn_activeintentid`|
|ReferencedEntityNavigationPropertyName|`msdyn_msdyn_ocliveworkitem_msdyn_intent_activeintentid`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|



### See also

[Dataverse table/entity reference](/power-apps/developer/data-platform/reference/about-entity-reference)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   

