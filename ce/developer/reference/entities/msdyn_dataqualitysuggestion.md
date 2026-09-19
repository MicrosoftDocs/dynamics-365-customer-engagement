---
title: "Data quality suggestion (msdyn_dataqualitysuggestion) table/entity reference (Microsoft Dynamics 365)"
description: "Includes schema information and supported messages for the Data quality suggestion (msdyn_dataqualitysuggestion) table/entity with Microsoft Dynamics 365."
ms.topic: generated-reference
author: JimDaly
ms.author: jdaly
search.audienceType: 
  - developer
---

# Data quality suggestion (msdyn_dataqualitysuggestion) table/entity reference (Microsoft Dynamics 365)

Suggestion produced by Sales data quality agent

## Messages

The following table lists the messages for the Data quality suggestion (msdyn_dataqualitysuggestion) table.
Messages represent operations that can be performed on the table. They may also be events.

| Name <br />Is Event? |Web API Operation |SDK for .NET |
| ---- | ----- |----- |
| `Assign`<br />Event: True |`PATCH` /msdyn_dataqualitysuggestions(*msdyn_dataqualitysuggestionid*)<br />[Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) the `ownerid` property. |<xref:Microsoft.Crm.Sdk.Messages.AssignRequest>|
| `Associate`<br />Event: True |[Associate records](/power-apps/developer/data-platform/webapi/associate-disassociate-entities-using-web-api) |[Associate records](/power-apps/developer/data-platform/org-service/entity-operations-associate-disassociate#use-the-associate-method-or-associaterequest)|
| `BulkRetain`<br />Event: True |<xref:Microsoft.Dynamics.CRM.BulkRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Create`<br />Event: True |`POST` /msdyn_dataqualitysuggestions<br />See [Create](/powerapps/developer/data-platform/webapi/create-entity-web-api) |[Create records](/power-apps/developer/data-platform/org-service/entity-operations-create#basic-create)|
| `CreateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.CreateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.CreateMultipleRequest>|
| `Delete`<br />Event: True |`DELETE` /msdyn_dataqualitysuggestions(*msdyn_dataqualitysuggestionid*)<br />See [Delete](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-delete) |[Delete records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-delete)|
| `Disassociate`<br />Event: True |[Disassociate records](/power-apps/developer/data-platform/webapi/associate-disassociate-entities-using-web-api) |[Disassociate records](/power-apps/developer/data-platform/org-service/entity-operations-associate-disassociate#use-the-disassociate-method-or-disassociaterequest)|
| `GrantAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.GrantAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.GrantAccessRequest>|
| `IsValidStateTransition`<br />Event: False |<xref:Microsoft.Dynamics.CRM.IsValidStateTransition?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.IsValidStateTransitionRequest>|
| `ModifyAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.ModifyAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.ModifyAccessRequest>|
| `PurgeRetainedContent`<br />Event: True |<xref:Microsoft.Dynamics.CRM.PurgeRetainedContent?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retain`<br />Event: True |<xref:Microsoft.Dynamics.CRM.Retain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retrieve`<br />Event: True |`GET` /msdyn_dataqualitysuggestions(*msdyn_dataqualitysuggestionid*)<br />See [Retrieve](/powerapps/developer/data-platform/webapi/retrieve-entity-using-web-api) |[Retrieve records](/power-apps/developer/data-platform/org-service/entity-operations-retrieve)|
| `RetrieveMultiple`<br />Event: True |`GET` /msdyn_dataqualitysuggestions<br />See [Query data](/power-apps/developer/data-platform/webapi/query-data-web-api) |[Query data](/power-apps/developer/data-platform/org-service/entity-operations-query-data)|
| `RetrievePrincipalAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RetrievePrincipalAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RetrievePrincipalAccessRequest>|
| `RetrieveSharedPrincipalsAndAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RetrieveSharedPrincipalsAndAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RetrieveSharedPrincipalsAndAccessRequest>|
| `RevokeAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RevokeAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RevokeAccessRequest>|
| `RollbackRetain`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RollbackRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `SetState`<br />Event: True |`PATCH` /msdyn_dataqualitysuggestions(*msdyn_dataqualitysuggestionid*)<br />[Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) the `statecode` and `statuscode` properties. |<xref:Microsoft.Crm.Sdk.Messages.SetStateRequest>|
| `Update`<br />Event: True |`PATCH` /msdyn_dataqualitysuggestions(*msdyn_dataqualitysuggestionid*)<br />See [Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) |[Update records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-update)|
| `UpdateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.UpdateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpdateMultipleRequest>|
| `Upsert`<br />Event: False |`PATCH` /msdyn_dataqualitysuggestions(*msdyn_dataqualitysuggestionid*)<br />See [Upsert a table row](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#upsert-a-table-row) |<xref:Microsoft.Xrm.Sdk.Messages.UpsertRequest>|
| `UpsertMultiple`<br />Event: False |<xref:Microsoft.Dynamics.CRM.UpsertMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpsertMultipleRequest>|
| `ValidateRetentionConfig`<br />Event: True |<xref:Microsoft.Dynamics.CRM.ValidateRetentionConfig?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|

## Properties

The following table lists selected properties for the Data quality suggestion (msdyn_dataqualitysuggestion) table.

|Property|Value|
| --- | --- |
| **DisplayName** | **Data quality suggestion** |
| **DisplayCollectionName** | **Data quality suggestions** |
| **SchemaName** | `msdyn_dataqualitysuggestion` |
| **CollectionSchemaName** | `msdyn_dataqualitysuggestions` |
| **EntitySetName** | `msdyn_dataqualitysuggestions`|
| **LogicalName** | `msdyn_dataqualitysuggestion` |
| **LogicalCollectionName** | `msdyn_dataqualitysuggestions` |
| **PrimaryIdAttribute** | `msdyn_dataqualitysuggestionid` |
| **PrimaryNameAttribute** |`msdyn_name` |
| **TableType** | `Standard` |
| **OwnershipType** | `UserOwned` |

## Writable columns/attributes

These columns/attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [ImportSequenceNumber](#BKMK_ImportSequenceNumber)
- [msdyn_agentmode](#BKMK_msdyn_agentmode)
- [msdyn_confidence](#BKMK_msdyn_confidence)
- [msdyn_dataqualitysuggestionId](#BKMK_msdyn_dataqualitysuggestionId)
- [msdyn_deamenuaction](#BKMK_msdyn_deamenuaction)
- [msdyn_name](#BKMK_msdyn_name)
- [msdyn_reason](#BKMK_msdyn_reason)
- [msdyn_regardingid](#BKMK_msdyn_regardingid)
- [msdyn_regardingtype](#BKMK_msdyn_regardingtype)
- [msdyn_relatedid](#BKMK_msdyn_relatedid)
- [msdyn_relatedrelationship](#BKMK_msdyn_relatedrelationship)
- [msdyn_relatedtype](#BKMK_msdyn_relatedtype)
- [msdyn_sourceid](#BKMK_msdyn_sourceid)
- [msdyn_suggestionvalue](#BKMK_msdyn_suggestionvalue)
- [msdyn_target](#BKMK_msdyn_target)
- [msdyn_type](#BKMK_msdyn_type)
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

### <a name="BKMK_msdyn_agentmode"></a> msdyn_agentmode

|Property|Value|
|---|---|
|Description||
|DisplayName|**Agent mode**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_agentmode`|
|RequiredLevel|None|
|Type|Picklist|
|DefaultFormValue|-1|
|GlobalChoiceName|`msdyn_dataqualitysuggestion_msdyn_agentmode`|

#### msdyn_agentmode Choices/Options

|Value|Label|
|---|---|
|1|**L2**|
|2|**L3**|

### <a name="BKMK_msdyn_confidence"></a> msdyn_confidence

|Property|Value|
|---|---|
|Description|**Confidence score for the suggestion**|
|DisplayName|**Confidence**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_confidence`|
|RequiredLevel|None|
|Type|Double|
|ImeMode|Auto|
|MaxValue|100000000000|
|MinValue|-100000000000|
|Precision|2|

### <a name="BKMK_msdyn_dataqualitysuggestionId"></a> msdyn_dataqualitysuggestionId

|Property|Value|
|---|---|
|Description|**Unique identifier for entity instances**|
|DisplayName|**Data quality suggestion**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`msdyn_dataqualitysuggestionid`|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|

### <a name="BKMK_msdyn_deamenuaction"></a> msdyn_deamenuaction

|Property|Value|
|---|---|
|Description|**Action taken on DEA card from the RAA carousel menu. Default Active (0) for L2 suggestions.**|
|DisplayName|**DEA Menu Action**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_deamenuaction`|
|RequiredLevel|None|
|Type|Picklist|
|DefaultFormValue|0|
|GlobalChoiceName|`msdyn_dataqualitysuggestion_msdyn_deamenuaction`|

#### msdyn_deamenuaction Choices/Options

|Value|Label|
|---|---|
|0|**Active**|
|1|**Dismissed**|

### <a name="BKMK_msdyn_name"></a> msdyn_name

|Property|Value|
|---|---|
|Description||
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
|MaxLength|850|

### <a name="BKMK_msdyn_reason"></a> msdyn_reason

|Property|Value|
|---|---|
|Description||
|DisplayName|**Reason for suggesting this change**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_reason`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|4000|

### <a name="BKMK_msdyn_regardingid"></a> msdyn_regardingid

|Property|Value|
|---|---|
|Description||
|DisplayName|**Record ID**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_regardingid`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdyn_regardingtype"></a> msdyn_regardingtype

|Property|Value|
|---|---|
|Description||
|DisplayName|**Record type**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_regardingtype`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdyn_relatedid"></a> msdyn_relatedid

|Property|Value|
|---|---|
|Description||
|DisplayName|**Related entity record ID**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_relatedid`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdyn_relatedrelationship"></a> msdyn_relatedrelationship

|Property|Value|
|---|---|
|Description||
|DisplayName|**Related entity relationship**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_relatedrelationship`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdyn_relatedtype"></a> msdyn_relatedtype

|Property|Value|
|---|---|
|Description||
|DisplayName|**Related entity record type**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_relatedtype`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdyn_sourceid"></a> msdyn_sourceid

|Property|Value|
|---|---|
|Description||
|DisplayName|**Source ID**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_sourceid`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|msdyn_dataqualitysource|

### <a name="BKMK_msdyn_suggestionvalue"></a> msdyn_suggestionvalue

|Property|Value|
|---|---|
|Description||
|DisplayName|**Suggestion value**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_suggestionvalue`|
|RequiredLevel|None|
|Type|Memo|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|1000000|

### <a name="BKMK_msdyn_target"></a> msdyn_target

|Property|Value|
|---|---|
|Description||
|DisplayName|**Target of this suggestion**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_target`|
|RequiredLevel|None|
|Type|Memo|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|1000000|

### <a name="BKMK_msdyn_type"></a> msdyn_type

|Property|Value|
|---|---|
|Description||
|DisplayName|**Type**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_type`|
|RequiredLevel|None|
|Type|Picklist|
|DefaultFormValue|-1|
|GlobalChoiceName|`msdyn_dataqualitysuggestion_msdyn_type`|

#### msdyn_type Choices/Options

|Value|Label|
|---|---|
|1|**Field update**|
|2|**Related entity field update**|
|3|**Link related entity**|
|4|**Create and link new related entity**|

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
|Description|**Status of the Data quality suggestion**|
|DisplayName|**Status**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statecode`|
|RequiredLevel|SystemRequired|
|Type|State|
|DefaultFormValue||
|GlobalChoiceName|`msdyn_dataqualitysuggestion_statecode`|

#### statecode Choices/Options

|Value|Details|
|---|---|
|0|Label: **Active**<br />DefaultStatus: 1<br />InvariantName: `Active`|
|1|Label: **Inactive**<br />DefaultStatus: 3<br />InvariantName: `Inactive`|

### <a name="BKMK_statuscode"></a> statuscode

|Property|Value|
|---|---|
|Description|**Reason for the status of the Data quality suggestion**|
|DisplayName|**Status Reason**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statuscode`|
|RequiredLevel|None|
|Type|Status|
|DefaultFormValue||
|GlobalChoiceName|`msdyn_dataqualitysuggestion_statuscode`|

#### statuscode Choices/Options

|Value|Details|
|---|---|
|1|Label: **Suggested**<br />State:0<br />TransitionData: None|
|2|Label: **Applied**<br />State:0<br />TransitionData: None|
|3|Label: **Approved**<br />State:1<br />TransitionData: None|
|4|Label: **Rejected**<br />State:1<br />TransitionData: None|
|5|Label: **Reverted**<br />State:1<br />TransitionData: None|
|6|Label: **Retained**<br />State:1<br />TransitionData: None|
|7|Label: **Reassigned**<br />State:1<br />TransitionData: None|
|8|Label: **Archived**<br />State:1<br />TransitionData: None|

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

- [business_unit_msdyn_dataqualitysuggestion](#BKMK_business_unit_msdyn_dataqualitysuggestion)
- [lk_msdyn_dataqualitysuggestion_createdby](#BKMK_lk_msdyn_dataqualitysuggestion_createdby)
- [lk_msdyn_dataqualitysuggestion_createdonbehalfby](#BKMK_lk_msdyn_dataqualitysuggestion_createdonbehalfby)
- [lk_msdyn_dataqualitysuggestion_modifiedby](#BKMK_lk_msdyn_dataqualitysuggestion_modifiedby)
- [lk_msdyn_dataqualitysuggestion_modifiedonbehalfby](#BKMK_lk_msdyn_dataqualitysuggestion_modifiedonbehalfby)
- [msdyn_dataqualitysuggestion_sourceid_msdyn_dataqualitysource](#BKMK_msdyn_dataqualitysuggestion_sourceid_msdyn_dataqualitysource)
- [owner_msdyn_dataqualitysuggestion](#BKMK_owner_msdyn_dataqualitysuggestion)
- [team_msdyn_dataqualitysuggestion](#BKMK_team_msdyn_dataqualitysuggestion)
- [user_msdyn_dataqualitysuggestion](#BKMK_user_msdyn_dataqualitysuggestion)

### <a name="BKMK_business_unit_msdyn_dataqualitysuggestion"></a> business_unit_msdyn_dataqualitysuggestion

One-To-Many Relationship: [businessunit business_unit_msdyn_dataqualitysuggestion](businessunit.md#BKMK_business_unit_msdyn_dataqualitysuggestion)

|Property|Value|
|---|---|
|ReferencedEntity|`businessunit`|
|ReferencedAttribute|`businessunitid`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencingEntityNavigationPropertyName|`owningbusinessunit`|
|IsHierarchical||
|CascadeConfiguration|Archive: `Restrict`<br />Assign: `NoCascade`<br />Delete: `Restrict`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_dataqualitysuggestion_createdby"></a> lk_msdyn_dataqualitysuggestion_createdby

One-To-Many Relationship: [systemuser lk_msdyn_dataqualitysuggestion_createdby](systemuser.md#BKMK_lk_msdyn_dataqualitysuggestion_createdby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdby`|
|ReferencingEntityNavigationPropertyName|`createdby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_dataqualitysuggestion_createdonbehalfby"></a> lk_msdyn_dataqualitysuggestion_createdonbehalfby

One-To-Many Relationship: [systemuser lk_msdyn_dataqualitysuggestion_createdonbehalfby](systemuser.md#BKMK_lk_msdyn_dataqualitysuggestion_createdonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdonbehalfby`|
|ReferencingEntityNavigationPropertyName|`createdonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_dataqualitysuggestion_modifiedby"></a> lk_msdyn_dataqualitysuggestion_modifiedby

One-To-Many Relationship: [systemuser lk_msdyn_dataqualitysuggestion_modifiedby](systemuser.md#BKMK_lk_msdyn_dataqualitysuggestion_modifiedby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedby`|
|ReferencingEntityNavigationPropertyName|`modifiedby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_dataqualitysuggestion_modifiedonbehalfby"></a> lk_msdyn_dataqualitysuggestion_modifiedonbehalfby

One-To-Many Relationship: [systemuser lk_msdyn_dataqualitysuggestion_modifiedonbehalfby](systemuser.md#BKMK_lk_msdyn_dataqualitysuggestion_modifiedonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedonbehalfby`|
|ReferencingEntityNavigationPropertyName|`modifiedonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_dataqualitysuggestion_sourceid_msdyn_dataqualitysource"></a> msdyn_dataqualitysuggestion_sourceid_msdyn_dataqualitysource

One-To-Many Relationship: [msdyn_dataqualitysource msdyn_dataqualitysuggestion_sourceid_msdyn_dataqualitysource](msdyn_dataqualitysource.md#BKMK_msdyn_dataqualitysuggestion_sourceid_msdyn_dataqualitysource)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_dataqualitysource`|
|ReferencedAttribute|`msdyn_dataqualitysourceid`|
|ReferencingAttribute|`msdyn_sourceid`|
|ReferencingEntityNavigationPropertyName|`msdyn_sourceid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `RemoveLink`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_owner_msdyn_dataqualitysuggestion"></a> owner_msdyn_dataqualitysuggestion

One-To-Many Relationship: [owner owner_msdyn_dataqualitysuggestion](owner.md#BKMK_owner_msdyn_dataqualitysuggestion)

|Property|Value|
|---|---|
|ReferencedEntity|`owner`|
|ReferencedAttribute|`ownerid`|
|ReferencingAttribute|`ownerid`|
|ReferencingEntityNavigationPropertyName|`ownerid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_team_msdyn_dataqualitysuggestion"></a> team_msdyn_dataqualitysuggestion

One-To-Many Relationship: [team team_msdyn_dataqualitysuggestion](team.md#BKMK_team_msdyn_dataqualitysuggestion)

|Property|Value|
|---|---|
|ReferencedEntity|`team`|
|ReferencedAttribute|`teamid`|
|ReferencingAttribute|`owningteam`|
|ReferencingEntityNavigationPropertyName|`owningteam`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_user_msdyn_dataqualitysuggestion"></a> user_msdyn_dataqualitysuggestion

One-To-Many Relationship: [systemuser user_msdyn_dataqualitysuggestion](systemuser.md#BKMK_user_msdyn_dataqualitysuggestion)

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

- [msdyn_dataqualitylog_suggestionid_msdyn_dataqualitysuggestion](#BKMK_msdyn_dataqualitylog_suggestionid_msdyn_dataqualitysuggestion)
- [msdyn_dataqualitysuggestion_AsyncOperations](#BKMK_msdyn_dataqualitysuggestion_AsyncOperations)
- [msdyn_dataqualitysuggestion_BulkDeleteFailures](#BKMK_msdyn_dataqualitysuggestion_BulkDeleteFailures)
- [msdyn_dataqualitysuggestion_DuplicateBaseRecord](#BKMK_msdyn_dataqualitysuggestion_DuplicateBaseRecord)
- [msdyn_dataqualitysuggestion_DuplicateMatchingRecord](#BKMK_msdyn_dataqualitysuggestion_DuplicateMatchingRecord)
- [msdyn_dataqualitysuggestion_MailboxTrackingFolders](#BKMK_msdyn_dataqualitysuggestion_MailboxTrackingFolders)
- [msdyn_dataqualitysuggestion_PrincipalObjectAttributeAccesses](#BKMK_msdyn_dataqualitysuggestion_PrincipalObjectAttributeAccesses)
- [msdyn_dataqualitysuggestion_ProcessSession](#BKMK_msdyn_dataqualitysuggestion_ProcessSession)
- [msdyn_dataqualitysuggestion_SyncErrors](#BKMK_msdyn_dataqualitysuggestion_SyncErrors)

### <a name="BKMK_msdyn_dataqualitylog_suggestionid_msdyn_dataqualitysuggestion"></a> msdyn_dataqualitylog_suggestionid_msdyn_dataqualitysuggestion

Many-To-One Relationship: [msdyn_dataqualitylog msdyn_dataqualitylog_suggestionid_msdyn_dataqualitysuggestion](msdyn_dataqualitylog.md#BKMK_msdyn_dataqualitylog_suggestionid_msdyn_dataqualitysuggestion)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_dataqualitylog`|
|ReferencingAttribute|`msdyn_suggestionid`|
|ReferencedEntityNavigationPropertyName|`msdyn_dataqualitylog_suggestionid_msdyn_dataqualitysuggestion`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_dataqualitysuggestion_AsyncOperations"></a> msdyn_dataqualitysuggestion_AsyncOperations

Many-To-One Relationship: [asyncoperation msdyn_dataqualitysuggestion_AsyncOperations](asyncoperation.md#BKMK_msdyn_dataqualitysuggestion_AsyncOperations)

|Property|Value|
|---|---|
|ReferencingEntity|`asyncoperation`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_dataqualitysuggestion_AsyncOperations`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_dataqualitysuggestion_BulkDeleteFailures"></a> msdyn_dataqualitysuggestion_BulkDeleteFailures

Many-To-One Relationship: [bulkdeletefailure msdyn_dataqualitysuggestion_BulkDeleteFailures](bulkdeletefailure.md#BKMK_msdyn_dataqualitysuggestion_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencingEntity|`bulkdeletefailure`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_dataqualitysuggestion_BulkDeleteFailures`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_dataqualitysuggestion_DuplicateBaseRecord"></a> msdyn_dataqualitysuggestion_DuplicateBaseRecord

Many-To-One Relationship: [duplicaterecord msdyn_dataqualitysuggestion_DuplicateBaseRecord](duplicaterecord.md#BKMK_msdyn_dataqualitysuggestion_DuplicateBaseRecord)

|Property|Value|
|---|---|
|ReferencingEntity|`duplicaterecord`|
|ReferencingAttribute|`baserecordid`|
|ReferencedEntityNavigationPropertyName|`msdyn_dataqualitysuggestion_DuplicateBaseRecord`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_dataqualitysuggestion_DuplicateMatchingRecord"></a> msdyn_dataqualitysuggestion_DuplicateMatchingRecord

Many-To-One Relationship: [duplicaterecord msdyn_dataqualitysuggestion_DuplicateMatchingRecord](duplicaterecord.md#BKMK_msdyn_dataqualitysuggestion_DuplicateMatchingRecord)

|Property|Value|
|---|---|
|ReferencingEntity|`duplicaterecord`|
|ReferencingAttribute|`duplicaterecordid`|
|ReferencedEntityNavigationPropertyName|`msdyn_dataqualitysuggestion_DuplicateMatchingRecord`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_dataqualitysuggestion_MailboxTrackingFolders"></a> msdyn_dataqualitysuggestion_MailboxTrackingFolders

Many-To-One Relationship: [mailboxtrackingfolder msdyn_dataqualitysuggestion_MailboxTrackingFolders](mailboxtrackingfolder.md#BKMK_msdyn_dataqualitysuggestion_MailboxTrackingFolders)

|Property|Value|
|---|---|
|ReferencingEntity|`mailboxtrackingfolder`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_dataqualitysuggestion_MailboxTrackingFolders`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_dataqualitysuggestion_PrincipalObjectAttributeAccesses"></a> msdyn_dataqualitysuggestion_PrincipalObjectAttributeAccesses

Many-To-One Relationship: [principalobjectattributeaccess msdyn_dataqualitysuggestion_PrincipalObjectAttributeAccesses](principalobjectattributeaccess.md#BKMK_msdyn_dataqualitysuggestion_PrincipalObjectAttributeAccesses)

|Property|Value|
|---|---|
|ReferencingEntity|`principalobjectattributeaccess`|
|ReferencingAttribute|`objectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_dataqualitysuggestion_PrincipalObjectAttributeAccesses`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_dataqualitysuggestion_ProcessSession"></a> msdyn_dataqualitysuggestion_ProcessSession

Many-To-One Relationship: [processsession msdyn_dataqualitysuggestion_ProcessSession](processsession.md#BKMK_msdyn_dataqualitysuggestion_ProcessSession)

|Property|Value|
|---|---|
|ReferencingEntity|`processsession`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_dataqualitysuggestion_ProcessSession`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_dataqualitysuggestion_SyncErrors"></a> msdyn_dataqualitysuggestion_SyncErrors

Many-To-One Relationship: [syncerror msdyn_dataqualitysuggestion_SyncErrors](syncerror.md#BKMK_msdyn_dataqualitysuggestion_SyncErrors)

|Property|Value|
|---|---|
|ReferencingEntity|`syncerror`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_dataqualitysuggestion_SyncErrors`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|



### See also

[Dataverse table/entity reference](/power-apps/developer/data-platform/reference/about-entity-reference)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   

