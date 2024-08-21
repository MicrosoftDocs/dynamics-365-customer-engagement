---
title: "Problematic Asset Feedback (msdyn_problematicassetfeedback) table/entity reference (Microsoft Dynamics 365 Field Service)"
description: "Includes schema information and supported messages for the Problematic Asset Feedback (msdyn_problematicassetfeedback) table/entity with Microsoft Dynamics 365 Field Service."
ms.date: 08/21/2024
ms.service: powerapps
ms.topic: reference
author: m-hartmann
ms.author: mhart
search.audienceType: 
  - developer
---

# Problematic Asset Feedback (msdyn_problematicassetfeedback) table/entity reference

Problematic asset feedback

## Messages

The following table lists the messages for the Problematic Asset Feedback (msdyn_problematicassetfeedback) table.
Messages represent operations that can be performed on the table. They may also be events.

| Name <br />Is Event? |Web API Operation |SDK for .NET |
| ---- | ----- |----- |
| `Assign`<br />Event: True |`PATCH` /msdyn_problematicassetfeedbacks(*msdyn_problematicassetfeedbackid*)<br />[Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) the `ownerid` property. |<xref:Microsoft.Crm.Sdk.Messages.AssignRequest>|
| `Create`<br />Event: True |`POST` /msdyn_problematicassetfeedbacks<br />See [Create](/powerapps/developer/data-platform/webapi/create-entity-web-api) |[Create records](/power-apps/developer/data-platform/org-service/entity-operations-create#basic-create)|
| `CreateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.CreateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.CreateMultipleRequest>|
| `Delete`<br />Event: True |`DELETE` /msdyn_problematicassetfeedbacks(*msdyn_problematicassetfeedbackid*)<br />See [Delete](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-delete) |[Delete records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-delete)|
| `GrantAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.GrantAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.GrantAccessRequest>|
| `IsValidStateTransition`<br />Event: False |<xref:Microsoft.Dynamics.CRM.IsValidStateTransition?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.IsValidStateTransitionRequest>|
| `ModifyAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.ModifyAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.ModifyAccessRequest>|
| `Retrieve`<br />Event: True |`GET` /msdyn_problematicassetfeedbacks(*msdyn_problematicassetfeedbackid*)<br />See [Retrieve](/powerapps/developer/data-platform/webapi/retrieve-entity-using-web-api) |[Retrieve records](/power-apps/developer/data-platform/org-service/entity-operations-retrieve)|
| `RetrieveMultiple`<br />Event: True |`GET` /msdyn_problematicassetfeedbacks<br />See [Query data](/power-apps/developer/data-platform/webapi/query-data-web-api) |[Query data](/power-apps/developer/data-platform/org-service/entity-operations-query-data)|
| `RetrievePrincipalAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RetrievePrincipalAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RetrievePrincipalAccessRequest>|
| `RetrieveSharedPrincipalsAndAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RetrieveSharedPrincipalsAndAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RetrieveSharedPrincipalsAndAccessRequest>|
| `RevokeAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RevokeAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RevokeAccessRequest>|
| `SetState`<br />Event: True |`PATCH` /msdyn_problematicassetfeedbacks(*msdyn_problematicassetfeedbackid*)<br />[Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) the `statecode` and `statuscode` properties. |<xref:Microsoft.Crm.Sdk.Messages.SetStateRequest>|
| `Update`<br />Event: True |`PATCH` /msdyn_problematicassetfeedbacks(*msdyn_problematicassetfeedbackid*)<br />See [Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) |[Update records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-update)|
| `UpdateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.UpdateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpdateMultipleRequest>|
| `Upsert`<br />Event: False |`PATCH` /msdyn_problematicassetfeedbacks(*msdyn_problematicassetfeedbackid*)<br />See [Upsert a table row](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#upsert-a-table-row) |<xref:Microsoft.Xrm.Sdk.Messages.UpsertRequest>|
| `UpsertMultiple`<br />Event: False |<xref:Microsoft.Dynamics.CRM.UpsertMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpsertMultipleRequest>|


## Events

The following table lists the events for the Problematic Asset Feedback (msdyn_problematicassetfeedback) table.
Events are messages that exist so that you can subscribe to them. Unless you added the event, you shouldn't invoke the message, only subscribe to it.

|Name|Web API Operation |SDK for .NET |
| ---- | ----- |----- |
| `BulkRetain`|<xref:Microsoft.Dynamics.CRM.BulkRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `PurgeRetainedContent`|<xref:Microsoft.Dynamics.CRM.PurgeRetainedContent?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retain`|<xref:Microsoft.Dynamics.CRM.Retain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `RollbackRetain`|<xref:Microsoft.Dynamics.CRM.RollbackRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `ValidateRetentionConfig`|<xref:Microsoft.Dynamics.CRM.ValidateRetentionConfig?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|

## Properties

The following table lists selected properties for the Problematic Asset Feedback (msdyn_problematicassetfeedback) table.

|Property|Value|
| --- | --- |
| **DisplayName** | **Problematic Asset Feedback** |
| **DisplayCollectionName** | **Problematic Asset Feedback** |
| **SchemaName** | `msdyn_problematicassetfeedback` |
| **CollectionSchemaName** | `msdyn_problematicassetfeedbacks` |
| **EntitySetName** | `msdyn_problematicassetfeedbacks`|
| **LogicalName** | `msdyn_problematicassetfeedback` |
| **LogicalCollectionName** | `msdyn_problematicassetfeedbacks` |
| **PrimaryIdAttribute** | `msdyn_problematicassetfeedbackid` |
| **PrimaryNameAttribute** |`msdyn_name` |
| **TableType** | `Standard` |
| **OwnershipType** | `UserOwned` |

## Writable columns/attributes

These columns/attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [ImportSequenceNumber](#BKMK_ImportSequenceNumber)
- [msdyn_AdditionalFeedback](#BKMK_msdyn_AdditionalFeedback)
- [msdyn_AssetId](#BKMK_msdyn_AssetId)
- [msdyn_name](#BKMK_msdyn_name)
- [msdyn_NumberOfDays](#BKMK_msdyn_NumberOfDays)
- [msdyn_OtherFeedback](#BKMK_msdyn_OtherFeedback)
- [msdyn_ProblematicAssetFeedback](#BKMK_msdyn_ProblematicAssetFeedback)
- [msdyn_problematicassetfeedbackId](#BKMK_msdyn_problematicassetfeedbackId)
- [msdyn_ProblematicAssetId](#BKMK_msdyn_ProblematicAssetId)
- [msdyn_Suggestion](#BKMK_msdyn_Suggestion)
- [msdyn_SuggestionFeedback](#BKMK_msdyn_SuggestionFeedback)
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

### <a name="BKMK_msdyn_AdditionalFeedback"></a> msdyn_AdditionalFeedback

|Property|Value|
|---|---|
|Description|**Text value of comments for other feedback**|
|DisplayName|**Additional Feedback**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_additionalfeedback`|
|RequiredLevel|None|
|Type|Memo|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|2000|

### <a name="BKMK_msdyn_AssetId"></a> msdyn_AssetId

|Property|Value|
|---|---|
|Description|**Unique identifier for customer asset**|
|DisplayName|**Asset Id**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_assetid`|
|RequiredLevel|ApplicationRequired|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdyn_name"></a> msdyn_name

|Property|Value|
|---|---|
|Description|**The name of the problematic asset feedback.**|
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

### <a name="BKMK_msdyn_NumberOfDays"></a> msdyn_NumberOfDays

|Property|Value|
|---|---|
|Description|**Optionset value of future days from current**|
|DisplayName|**Number Of Days**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_numberofdays`|
|RequiredLevel|ApplicationRequired|
|Type|Picklist|
|DefaultFormValue|-1|
|GlobalChoiceName|`msdyn_numberofdays`|

#### msdyn_NumberOfDays Choices/Options

|Value|Label|
|---|---|
|192350000|**0**|
|192350001|**15**|
|192350002|**30**|
|192350003|**60**|
|192350004|**90**|

### <a name="BKMK_msdyn_OtherFeedback"></a> msdyn_OtherFeedback

|Property|Value|
|---|---|
|Description|**Flag value indicating if user like or dislike the asset suggestion for other reasons**|
|DisplayName|**Other Feedback**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_otherfeedback`|
|RequiredLevel|None|
|Type|Picklist|
|DefaultFormValue|-1|
|GlobalChoiceName|`msdyn_problematicassetfeedback_msdyn_otherfeedback`|

#### msdyn_OtherFeedback Choices/Options

|Value|Label|
|---|---|
|700610000|**Like**|
|700610001|**Dislike**|

### <a name="BKMK_msdyn_ProblematicAssetFeedback"></a> msdyn_ProblematicAssetFeedback

|Property|Value|
|---|---|
|Description|**Flag value indicating user like/dislike the asset to be predicted as problematic asset**|
|DisplayName|**Problematic Asset Feedback**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_problematicassetfeedback`|
|RequiredLevel|None|
|Type|Picklist|
|DefaultFormValue|-1|
|GlobalChoiceName|`msdyn_problematicassetfeedback_msdyn_problematicassetfeedback`|

#### msdyn_ProblematicAssetFeedback Choices/Options

|Value|Label|
|---|---|
|700610000|**Like**|
|700610001|**Dislike**|

### <a name="BKMK_msdyn_problematicassetfeedbackId"></a> msdyn_problematicassetfeedbackId

|Property|Value|
|---|---|
|Description|**Unique identifier for entity instances**|
|DisplayName|**Problematic Asset Feedback**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`msdyn_problematicassetfeedbackid`|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|

### <a name="BKMK_msdyn_ProblematicAssetId"></a> msdyn_ProblematicAssetId

|Property|Value|
|---|---|
|Description|**Unique identifier for problematic asset**|
|DisplayName|**Problematic Asset Id**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_problematicassetid`|
|RequiredLevel|ApplicationRequired|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdyn_Suggestion"></a> msdyn_Suggestion

|Property|Value|
|---|---|
|Description|**Optionset value of suggestion for customer asset**|
|DisplayName|**Suggestion**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_suggestion`|
|RequiredLevel|ApplicationRequired|
|Type|Picklist|
|DefaultFormValue|-1|
|GlobalChoiceName|`msdyn_problematicassetfeedback_msdyn_suggestion`|

#### msdyn_Suggestion Choices/Options

|Value|Label|
|---|---|
|700610000|**Repair**|
|700610001|**Replace**|
|700610002|**None**|

### <a name="BKMK_msdyn_SuggestionFeedback"></a> msdyn_SuggestionFeedback

|Property|Value|
|---|---|
|Description|**Flag value indicating if user like/dislike the suggestion for problematic asset**|
|DisplayName|**Suggestion Feedback**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_suggestionfeedback`|
|RequiredLevel|None|
|Type|Picklist|
|DefaultFormValue|-1|
|GlobalChoiceName|`msdyn_problematicassetfeedback_msdyn_suggestionfeedback`|

#### msdyn_SuggestionFeedback Choices/Options

|Value|Label|
|---|---|
|700610000|**Like**|
|700610001|**Dislike**|

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
|Description|**Status of the Problematic Asset Feedback**|
|DisplayName|**Status**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statecode`|
|RequiredLevel|SystemRequired|
|Type|State|
|DefaultFormValue||
|GlobalChoiceName|`msdyn_problematicassetfeedback_statecode`|

#### statecode Choices/Options

|Value|Details|
|---|---|
|0|Label: **Active**<br />DefaultStatus: 1<br />InvariantName: `Active`|
|1|Label: **Inactive**<br />DefaultStatus: 2<br />InvariantName: `Inactive`|

### <a name="BKMK_statuscode"></a> statuscode

|Property|Value|
|---|---|
|Description|**Reason for the status of the Problematic Asset Feedback**|
|DisplayName|**Status Reason**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statuscode`|
|RequiredLevel|None|
|Type|Status|
|DefaultFormValue||
|GlobalChoiceName|`msdyn_problematicassetfeedback_statuscode`|

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

- [business_unit_msdyn_problematicassetfeedback](#BKMK_business_unit_msdyn_problematicassetfeedback)
- [lk_msdyn_problematicassetfeedback_createdby](#BKMK_lk_msdyn_problematicassetfeedback_createdby)
- [lk_msdyn_problematicassetfeedback_createdonbehalfby](#BKMK_lk_msdyn_problematicassetfeedback_createdonbehalfby)
- [lk_msdyn_problematicassetfeedback_modifiedby](#BKMK_lk_msdyn_problematicassetfeedback_modifiedby)
- [lk_msdyn_problematicassetfeedback_modifiedonbehalfby](#BKMK_lk_msdyn_problematicassetfeedback_modifiedonbehalfby)
- [owner_msdyn_problematicassetfeedback](#BKMK_owner_msdyn_problematicassetfeedback)
- [team_msdyn_problematicassetfeedback](#BKMK_team_msdyn_problematicassetfeedback)
- [user_msdyn_problematicassetfeedback](#BKMK_user_msdyn_problematicassetfeedback)

### <a name="BKMK_business_unit_msdyn_problematicassetfeedback"></a> business_unit_msdyn_problematicassetfeedback

One-To-Many Relationship: [businessunit business_unit_msdyn_problematicassetfeedback](businessunit.md#BKMK_business_unit_msdyn_problematicassetfeedback)

|Property|Value|
|---|---|
|ReferencedEntity|`businessunit`|
|ReferencedAttribute|`businessunitid`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencingEntityNavigationPropertyName|`owningbusinessunit`|
|IsHierarchical||
|CascadeConfiguration|Archive: `Restrict`<br />Assign: `NoCascade`<br />Delete: `Restrict`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_problematicassetfeedback_createdby"></a> lk_msdyn_problematicassetfeedback_createdby

One-To-Many Relationship: [systemuser lk_msdyn_problematicassetfeedback_createdby](systemuser.md#BKMK_lk_msdyn_problematicassetfeedback_createdby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdby`|
|ReferencingEntityNavigationPropertyName|`createdby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_problematicassetfeedback_createdonbehalfby"></a> lk_msdyn_problematicassetfeedback_createdonbehalfby

One-To-Many Relationship: [systemuser lk_msdyn_problematicassetfeedback_createdonbehalfby](systemuser.md#BKMK_lk_msdyn_problematicassetfeedback_createdonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdonbehalfby`|
|ReferencingEntityNavigationPropertyName|`createdonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_problematicassetfeedback_modifiedby"></a> lk_msdyn_problematicassetfeedback_modifiedby

One-To-Many Relationship: [systemuser lk_msdyn_problematicassetfeedback_modifiedby](systemuser.md#BKMK_lk_msdyn_problematicassetfeedback_modifiedby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedby`|
|ReferencingEntityNavigationPropertyName|`modifiedby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_problematicassetfeedback_modifiedonbehalfby"></a> lk_msdyn_problematicassetfeedback_modifiedonbehalfby

One-To-Many Relationship: [systemuser lk_msdyn_problematicassetfeedback_modifiedonbehalfby](systemuser.md#BKMK_lk_msdyn_problematicassetfeedback_modifiedonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedonbehalfby`|
|ReferencingEntityNavigationPropertyName|`modifiedonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_owner_msdyn_problematicassetfeedback"></a> owner_msdyn_problematicassetfeedback

One-To-Many Relationship: [owner owner_msdyn_problematicassetfeedback](owner.md#BKMK_owner_msdyn_problematicassetfeedback)

|Property|Value|
|---|---|
|ReferencedEntity|`owner`|
|ReferencedAttribute|`ownerid`|
|ReferencingAttribute|`ownerid`|
|ReferencingEntityNavigationPropertyName|`ownerid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_team_msdyn_problematicassetfeedback"></a> team_msdyn_problematicassetfeedback

One-To-Many Relationship: [team team_msdyn_problematicassetfeedback](team.md#BKMK_team_msdyn_problematicassetfeedback)

|Property|Value|
|---|---|
|ReferencedEntity|`team`|
|ReferencedAttribute|`teamid`|
|ReferencingAttribute|`owningteam`|
|ReferencingEntityNavigationPropertyName|`owningteam`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_user_msdyn_problematicassetfeedback"></a> user_msdyn_problematicassetfeedback

One-To-Many Relationship: [systemuser user_msdyn_problematicassetfeedback](systemuser.md#BKMK_user_msdyn_problematicassetfeedback)

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

- [msdyn_problematicassetfeedback_AsyncOperations](#BKMK_msdyn_problematicassetfeedback_AsyncOperations)
- [msdyn_problematicassetfeedback_BulkDeleteFailures](#BKMK_msdyn_problematicassetfeedback_BulkDeleteFailures)
- [msdyn_problematicassetfeedback_DuplicateBaseRecord](#BKMK_msdyn_problematicassetfeedback_DuplicateBaseRecord)
- [msdyn_problematicassetfeedback_DuplicateMatchingRecord](#BKMK_msdyn_problematicassetfeedback_DuplicateMatchingRecord)
- [msdyn_problematicassetfeedback_MailboxTrackingFolders](#BKMK_msdyn_problematicassetfeedback_MailboxTrackingFolders)
- [msdyn_problematicassetfeedback_PrincipalObjectAttributeAccesses](#BKMK_msdyn_problematicassetfeedback_PrincipalObjectAttributeAccesses)
- [msdyn_problematicassetfeedback_ProcessSession](#BKMK_msdyn_problematicassetfeedback_ProcessSession)
- [msdyn_problematicassetfeedback_SyncErrors](#BKMK_msdyn_problematicassetfeedback_SyncErrors)

### <a name="BKMK_msdyn_problematicassetfeedback_AsyncOperations"></a> msdyn_problematicassetfeedback_AsyncOperations

Many-To-One Relationship: [asyncoperation msdyn_problematicassetfeedback_AsyncOperations](asyncoperation.md#BKMK_msdyn_problematicassetfeedback_AsyncOperations)

|Property|Value|
|---|---|
|ReferencingEntity|`asyncoperation`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_problematicassetfeedback_AsyncOperations`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_problematicassetfeedback_BulkDeleteFailures"></a> msdyn_problematicassetfeedback_BulkDeleteFailures

Many-To-One Relationship: [bulkdeletefailure msdyn_problematicassetfeedback_BulkDeleteFailures](bulkdeletefailure.md#BKMK_msdyn_problematicassetfeedback_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencingEntity|`bulkdeletefailure`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_problematicassetfeedback_BulkDeleteFailures`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_problematicassetfeedback_DuplicateBaseRecord"></a> msdyn_problematicassetfeedback_DuplicateBaseRecord

Many-To-One Relationship: [duplicaterecord msdyn_problematicassetfeedback_DuplicateBaseRecord](duplicaterecord.md#BKMK_msdyn_problematicassetfeedback_DuplicateBaseRecord)

|Property|Value|
|---|---|
|ReferencingEntity|`duplicaterecord`|
|ReferencingAttribute|`baserecordid`|
|ReferencedEntityNavigationPropertyName|`msdyn_problematicassetfeedback_DuplicateBaseRecord`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_problematicassetfeedback_DuplicateMatchingRecord"></a> msdyn_problematicassetfeedback_DuplicateMatchingRecord

Many-To-One Relationship: [duplicaterecord msdyn_problematicassetfeedback_DuplicateMatchingRecord](duplicaterecord.md#BKMK_msdyn_problematicassetfeedback_DuplicateMatchingRecord)

|Property|Value|
|---|---|
|ReferencingEntity|`duplicaterecord`|
|ReferencingAttribute|`duplicaterecordid`|
|ReferencedEntityNavigationPropertyName|`msdyn_problematicassetfeedback_DuplicateMatchingRecord`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_problematicassetfeedback_MailboxTrackingFolders"></a> msdyn_problematicassetfeedback_MailboxTrackingFolders

Many-To-One Relationship: [mailboxtrackingfolder msdyn_problematicassetfeedback_MailboxTrackingFolders](mailboxtrackingfolder.md#BKMK_msdyn_problematicassetfeedback_MailboxTrackingFolders)

|Property|Value|
|---|---|
|ReferencingEntity|`mailboxtrackingfolder`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_problematicassetfeedback_MailboxTrackingFolders`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_problematicassetfeedback_PrincipalObjectAttributeAccesses"></a> msdyn_problematicassetfeedback_PrincipalObjectAttributeAccesses

Many-To-One Relationship: [principalobjectattributeaccess msdyn_problematicassetfeedback_PrincipalObjectAttributeAccesses](principalobjectattributeaccess.md#BKMK_msdyn_problematicassetfeedback_PrincipalObjectAttributeAccesses)

|Property|Value|
|---|---|
|ReferencingEntity|`principalobjectattributeaccess`|
|ReferencingAttribute|`objectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_problematicassetfeedback_PrincipalObjectAttributeAccesses`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_problematicassetfeedback_ProcessSession"></a> msdyn_problematicassetfeedback_ProcessSession

Many-To-One Relationship: [processsession msdyn_problematicassetfeedback_ProcessSession](processsession.md#BKMK_msdyn_problematicassetfeedback_ProcessSession)

|Property|Value|
|---|---|
|ReferencingEntity|`processsession`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_problematicassetfeedback_ProcessSession`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_problematicassetfeedback_SyncErrors"></a> msdyn_problematicassetfeedback_SyncErrors

Many-To-One Relationship: [syncerror msdyn_problematicassetfeedback_SyncErrors](syncerror.md#BKMK_msdyn_problematicassetfeedback_SyncErrors)

|Property|Value|
|---|---|
|ReferencingEntity|`syncerror`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_problematicassetfeedback_SyncErrors`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|



### See also

[Dataverse table/entity reference](../about-entity-reference.md)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   

