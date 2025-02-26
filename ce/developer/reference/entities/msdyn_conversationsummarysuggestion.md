---
title: "Conversation Summary Suggestion (msdyn_ConversationSummarySuggestion) table/entity reference (Microsoft Dynamics 365)"
description: "Includes schema information and supported messages for the Conversation Summary Suggestion (msdyn_ConversationSummarySuggestion) table/entity with Microsoft Dynamics 365."
ms.topic: generated-reference
author: JimDaly
ms.author: jdaly
search.audienceType: 
  - developer
---

# Conversation Summary Suggestion (msdyn_ConversationSummarySuggestion) table/entity reference (Microsoft Dynamics 365)



## Messages

The following table lists the messages for the Conversation Summary Suggestion (msdyn_ConversationSummarySuggestion) table.
Messages represent operations that can be performed on the table. They may also be events.

| Name <br />Is Event? |Web API Operation |SDK for .NET |
| ---- | ----- |----- |
| `Assign`<br />Event: True |`PATCH` /msdyn_conversationsummarysuggestions(*msdyn_conversationsummarysuggestionid*)<br />[Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) the `ownerid` property. |<xref:Microsoft.Crm.Sdk.Messages.AssignRequest>|
| `Associate`<br />Event: True |[Associate records](/power-apps/developer/data-platform/webapi/associate-disassociate-entities-using-web-api) |[Associate records](/power-apps/developer/data-platform/org-service/entity-operations-associate-disassociate#use-the-associate-method-or-associaterequest)|
| `BulkRetain`<br />Event: True |<xref:Microsoft.Dynamics.CRM.BulkRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Create`<br />Event: True |`POST` /msdyn_conversationsummarysuggestions<br />See [Create](/powerapps/developer/data-platform/webapi/create-entity-web-api) |[Create records](/power-apps/developer/data-platform/org-service/entity-operations-create#basic-create)|
| `CreateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.CreateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.CreateMultipleRequest>|
| `Delete`<br />Event: True |`DELETE` /msdyn_conversationsummarysuggestions(*msdyn_conversationsummarysuggestionid*)<br />See [Delete](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-delete) |[Delete records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-delete)|
| `Disassociate`<br />Event: True |[Disassociate records](/power-apps/developer/data-platform/webapi/associate-disassociate-entities-using-web-api) |[Disassociate records](/power-apps/developer/data-platform/org-service/entity-operations-associate-disassociate#use-the-disassociate-method-or-disassociaterequest)|
| `GrantAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.GrantAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.GrantAccessRequest>|
| `IsValidStateTransition`<br />Event: False |<xref:Microsoft.Dynamics.CRM.IsValidStateTransition?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.IsValidStateTransitionRequest>|
| `ModifyAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.ModifyAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.ModifyAccessRequest>|
| `PurgeRetainedContent`<br />Event: True |<xref:Microsoft.Dynamics.CRM.PurgeRetainedContent?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Restore`<br />Event: True |<xref:Microsoft.Dynamics.CRM.Restore?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retain`<br />Event: True |<xref:Microsoft.Dynamics.CRM.Retain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retrieve`<br />Event: True |`GET` /msdyn_conversationsummarysuggestions(*msdyn_conversationsummarysuggestionid*)<br />See [Retrieve](/powerapps/developer/data-platform/webapi/retrieve-entity-using-web-api) |[Retrieve records](/power-apps/developer/data-platform/org-service/entity-operations-retrieve)|
| `RetrieveMultiple`<br />Event: True |`GET` /msdyn_conversationsummarysuggestions<br />See [Query data](/power-apps/developer/data-platform/webapi/query-data-web-api) |[Query data](/power-apps/developer/data-platform/org-service/entity-operations-query-data)|
| `RetrievePrincipalAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RetrievePrincipalAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RetrievePrincipalAccessRequest>|
| `RetrieveSharedPrincipalsAndAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RetrieveSharedPrincipalsAndAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RetrieveSharedPrincipalsAndAccessRequest>|
| `RevokeAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RevokeAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RevokeAccessRequest>|
| `RollbackRetain`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RollbackRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `SetState`<br />Event: True |`PATCH` /msdyn_conversationsummarysuggestions(*msdyn_conversationsummarysuggestionid*)<br />[Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) the `statecode` and `statuscode` properties. |<xref:Microsoft.Crm.Sdk.Messages.SetStateRequest>|
| `Update`<br />Event: True |`PATCH` /msdyn_conversationsummarysuggestions(*msdyn_conversationsummarysuggestionid*)<br />See [Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) |[Update records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-update)|
| `UpdateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.UpdateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpdateMultipleRequest>|
| `Upsert`<br />Event: False |`PATCH` /msdyn_conversationsummarysuggestions(*msdyn_conversationsummarysuggestionid*)<br />See [Upsert a table row](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#upsert-a-table-row) |<xref:Microsoft.Xrm.Sdk.Messages.UpsertRequest>|
| `UpsertMultiple`<br />Event: False |<xref:Microsoft.Dynamics.CRM.UpsertMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpsertMultipleRequest>|
| `ValidateRetentionConfig`<br />Event: True |<xref:Microsoft.Dynamics.CRM.ValidateRetentionConfig?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|

## Properties

The following table lists selected properties for the Conversation Summary Suggestion (msdyn_ConversationSummarySuggestion) table.

|Property|Value|
| --- | --- |
| **DisplayName** | **Conversation Summary Suggestion** |
| **DisplayCollectionName** | **Conversation Summary Suggestions** |
| **SchemaName** | `msdyn_ConversationSummarySuggestion` |
| **CollectionSchemaName** | `msdyn_ConversationSummarySuggestions` |
| **EntitySetName** | `msdyn_conversationsummarysuggestions`|
| **LogicalName** | `msdyn_conversationsummarysuggestion` |
| **LogicalCollectionName** | `msdyn_conversationsummarysuggestions` |
| **PrimaryIdAttribute** | `msdyn_conversationsummarysuggestionid` |
| **PrimaryNameAttribute** |`msdyn_name` |
| **TableType** | `Standard` |
| **OwnershipType** | `UserOwned` |

## Writable columns/attributes

These columns/attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [ImportSequenceNumber](#BKMK_ImportSequenceNumber)
- [msdyn_Content](#BKMK_msdyn_Content)
- [msdyn_ConversationParticipantInsights](#BKMK_msdyn_ConversationParticipantInsights)
- [msdyn_ConversationSummarySuggestionId](#BKMK_msdyn_ConversationSummarySuggestionId)
- [msdyn_ConversationSummarySuggestionType](#BKMK_msdyn_ConversationSummarySuggestionType)
- [msdyn_DurationInMS](#BKMK_msdyn_DurationInMS)
- [msdyn_FragmentEnd](#BKMK_msdyn_FragmentEnd)
- [msdyn_FragmentStart](#BKMK_msdyn_FragmentStart)
- [msdyn_Locale](#BKMK_msdyn_Locale)
- [msdyn_Name](#BKMK_msdyn_Name)
- [msdyn_OffsetInMS](#BKMK_msdyn_OffsetInMS)
- [msdyn_Selected](#BKMK_msdyn_Selected)
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

### <a name="BKMK_msdyn_Content"></a> msdyn_Content

|Property|Value|
|---|---|
|Description||
|DisplayName|**Content**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_content`|
|RequiredLevel|None|
|Type|Memo|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|1048576|

### <a name="BKMK_msdyn_ConversationParticipantInsights"></a> msdyn_ConversationParticipantInsights

|Property|Value|
|---|---|
|Description||
|DisplayName|**ConversationParticipantInsights**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_conversationparticipantinsights`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|msdyn_conversationparticipantinsights|

### <a name="BKMK_msdyn_ConversationSummarySuggestionId"></a> msdyn_ConversationSummarySuggestionId

|Property|Value|
|---|---|
|Description|**Unique identifier for the summary suggestion**|
|DisplayName|**Conversation Summary Suggestion**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`msdyn_conversationsummarysuggestionid`|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|

### <a name="BKMK_msdyn_ConversationSummarySuggestionType"></a> msdyn_ConversationSummarySuggestionType

|Property|Value|
|---|---|
|Description||
|DisplayName|**Conversation Summary Suggestion Type**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_conversationsummarysuggestiontype`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdyn_DurationInMS"></a> msdyn_DurationInMS

|Property|Value|
|---|---|
|Description||
|DisplayName|**DurationInMS**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_durationinms`|
|RequiredLevel|None|
|Type|Integer|
|MaxValue|2147483647|
|MinValue|-1|

### <a name="BKMK_msdyn_FragmentEnd"></a> msdyn_FragmentEnd

|Property|Value|
|---|---|
|Description||
|DisplayName|**FragmentEnd**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_fragmentend`|
|RequiredLevel|None|
|Type|Integer|
|MaxValue|2147483647|
|MinValue|0|

### <a name="BKMK_msdyn_FragmentStart"></a> msdyn_FragmentStart

|Property|Value|
|---|---|
|Description||
|DisplayName|**FragmentStart**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_fragmentstart`|
|RequiredLevel|None|
|Type|Integer|
|MaxValue|2147483647|
|MinValue|0|

### <a name="BKMK_msdyn_Locale"></a> msdyn_Locale

|Property|Value|
|---|---|
|Description||
|DisplayName|**Locale**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_locale`|
|RequiredLevel|None|
|Type|Picklist|
|DefaultFormValue|-1|
|GlobalChoiceName|`msdyn_ci_locale`|

#### msdyn_Locale Choices/Options

|Value|Label|
|---|---|
|0|**en-us**|
|10|**en-gb**|
|20|**de-de**|
|30|**fr-fr**|
|40|**it-it**|
|50|**es-es**|
|60|**es-mx**|
|70|**ja-jp**|
|80|**pt-br**|
|90|**zh-cn**|
|110|**nl-nl**|
|120|**fr-ca**|
|130|**pt-pt**|
|140|**ar-ae**|
|150|**ar-bh**|
|160|**ar-eg**|
|170|**ar-iq**|
|180|**ar-jo**|
|190|**ar-kw**|
|200|**ar-lb**|
|210|**ar-om**|
|220|**ar-qa**|
|230|**ar-sa**|
|240|**ar-sy**|
|250|**he-il**|
|260|**da-dk**|
|270|**sv-se**|
|280|**fi-fi**|
|290|**nb-no**|
|300|**el-gr**|
|310|**cs-cz**|
|320|**ko-kr**|
|330|**pl-pl**|
|340|**ru-ru**|
|350|**th-th**|
|360|**tr-tr**|

### <a name="BKMK_msdyn_Name"></a> msdyn_Name

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
|MaxLength|100|

### <a name="BKMK_msdyn_OffsetInMS"></a> msdyn_OffsetInMS

|Property|Value|
|---|---|
|Description||
|DisplayName|**OffsetInMS**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_offsetinms`|
|RequiredLevel|None|
|Type|Integer|
|MaxValue|2147483647|
|MinValue|-1|

### <a name="BKMK_msdyn_Selected"></a> msdyn_Selected

|Property|Value|
|---|---|
|Description||
|DisplayName|**Selected**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_selected`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`msdyn_conversationsummarysuggestion_msdyn_selected`|
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
|Description|**Status of the Conversation Summary Suggestion**|
|DisplayName|**Status**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statecode`|
|RequiredLevel|SystemRequired|
|Type|State|
|DefaultFormValue||
|GlobalChoiceName|`msdyn_conversationsummarysuggestion_statecode`|

#### statecode Choices/Options

|Value|Details|
|---|---|
|0|Label: **Active**<br />DefaultStatus: 1<br />InvariantName: `Active`|
|1|Label: **Inactive**<br />DefaultStatus: 2<br />InvariantName: `Inactive`|

### <a name="BKMK_statuscode"></a> statuscode

|Property|Value|
|---|---|
|Description|**Reason for the status of the Conversation Summary Suggestion**|
|DisplayName|**Status Reason**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statuscode`|
|RequiredLevel|None|
|Type|Status|
|DefaultFormValue||
|GlobalChoiceName|`msdyn_conversationsummarysuggestion_statuscode`|

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

- [business_unit_msdyn_conversationsummarysuggestion](#BKMK_business_unit_msdyn_conversationsummarysuggestion)
- [lk_msdyn_conversationsummarysuggestion_createdby](#BKMK_lk_msdyn_conversationsummarysuggestion_createdby)
- [lk_msdyn_conversationsummarysuggestion_createdonbehalfby](#BKMK_lk_msdyn_conversationsummarysuggestion_createdonbehalfby)
- [lk_msdyn_conversationsummarysuggestion_modifiedby](#BKMK_lk_msdyn_conversationsummarysuggestion_modifiedby)
- [lk_msdyn_conversationsummarysuggestion_modifiedonbehalfby](#BKMK_lk_msdyn_conversationsummarysuggestion_modifiedonbehalfby)
- [msdyn_msdyn_conversationsummarysuggestion_Conve](#BKMK_msdyn_msdyn_conversationsummarysuggestion_Conve)
- [owner_msdyn_conversationsummarysuggestion](#BKMK_owner_msdyn_conversationsummarysuggestion)
- [team_msdyn_conversationsummarysuggestion](#BKMK_team_msdyn_conversationsummarysuggestion)
- [user_msdyn_conversationsummarysuggestion](#BKMK_user_msdyn_conversationsummarysuggestion)

### <a name="BKMK_business_unit_msdyn_conversationsummarysuggestion"></a> business_unit_msdyn_conversationsummarysuggestion

One-To-Many Relationship: [businessunit business_unit_msdyn_conversationsummarysuggestion](businessunit.md#BKMK_business_unit_msdyn_conversationsummarysuggestion)

|Property|Value|
|---|---|
|ReferencedEntity|`businessunit`|
|ReferencedAttribute|`businessunitid`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencingEntityNavigationPropertyName|`owningbusinessunit`|
|IsHierarchical||
|CascadeConfiguration|Archive: `Restrict`<br />Assign: `NoCascade`<br />Delete: `Restrict`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_conversationsummarysuggestion_createdby"></a> lk_msdyn_conversationsummarysuggestion_createdby

One-To-Many Relationship: [systemuser lk_msdyn_conversationsummarysuggestion_createdby](systemuser.md#BKMK_lk_msdyn_conversationsummarysuggestion_createdby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdby`|
|ReferencingEntityNavigationPropertyName|`createdby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_conversationsummarysuggestion_createdonbehalfby"></a> lk_msdyn_conversationsummarysuggestion_createdonbehalfby

One-To-Many Relationship: [systemuser lk_msdyn_conversationsummarysuggestion_createdonbehalfby](systemuser.md#BKMK_lk_msdyn_conversationsummarysuggestion_createdonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdonbehalfby`|
|ReferencingEntityNavigationPropertyName|`createdonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_conversationsummarysuggestion_modifiedby"></a> lk_msdyn_conversationsummarysuggestion_modifiedby

One-To-Many Relationship: [systemuser lk_msdyn_conversationsummarysuggestion_modifiedby](systemuser.md#BKMK_lk_msdyn_conversationsummarysuggestion_modifiedby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedby`|
|ReferencingEntityNavigationPropertyName|`modifiedby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_conversationsummarysuggestion_modifiedonbehalfby"></a> lk_msdyn_conversationsummarysuggestion_modifiedonbehalfby

One-To-Many Relationship: [systemuser lk_msdyn_conversationsummarysuggestion_modifiedonbehalfby](systemuser.md#BKMK_lk_msdyn_conversationsummarysuggestion_modifiedonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedonbehalfby`|
|ReferencingEntityNavigationPropertyName|`modifiedonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_msdyn_conversationsummarysuggestion_Conve"></a> msdyn_msdyn_conversationsummarysuggestion_Conve

One-To-Many Relationship: [msdyn_conversationparticipantinsights msdyn_msdyn_conversationsummarysuggestion_Conve](msdyn_conversationparticipantinsights.md#BKMK_msdyn_msdyn_conversationsummarysuggestion_Conve)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_conversationparticipantinsights`|
|ReferencedAttribute|`msdyn_conversationparticipantinsightsid`|
|ReferencingAttribute|`msdyn_conversationparticipantinsights`|
|ReferencingEntityNavigationPropertyName|`msdyn_conversationparticipantinsights`|
|IsHierarchical||
|CascadeConfiguration|Archive: `Cascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_owner_msdyn_conversationsummarysuggestion"></a> owner_msdyn_conversationsummarysuggestion

One-To-Many Relationship: [owner owner_msdyn_conversationsummarysuggestion](owner.md#BKMK_owner_msdyn_conversationsummarysuggestion)

|Property|Value|
|---|---|
|ReferencedEntity|`owner`|
|ReferencedAttribute|`ownerid`|
|ReferencingAttribute|`ownerid`|
|ReferencingEntityNavigationPropertyName|`ownerid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_team_msdyn_conversationsummarysuggestion"></a> team_msdyn_conversationsummarysuggestion

One-To-Many Relationship: [team team_msdyn_conversationsummarysuggestion](team.md#BKMK_team_msdyn_conversationsummarysuggestion)

|Property|Value|
|---|---|
|ReferencedEntity|`team`|
|ReferencedAttribute|`teamid`|
|ReferencingAttribute|`owningteam`|
|ReferencingEntityNavigationPropertyName|`owningteam`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_user_msdyn_conversationsummarysuggestion"></a> user_msdyn_conversationsummarysuggestion

One-To-Many Relationship: [systemuser user_msdyn_conversationsummarysuggestion](systemuser.md#BKMK_user_msdyn_conversationsummarysuggestion)

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

- [msdyn_conversationsummarysuggestion_AsyncOperations](#BKMK_msdyn_conversationsummarysuggestion_AsyncOperations)
- [msdyn_conversationsummarysuggestion_BulkDeleteFailures](#BKMK_msdyn_conversationsummarysuggestion_BulkDeleteFailures)
- [msdyn_conversationsummarysuggestion_DuplicateBaseRecord](#BKMK_msdyn_conversationsummarysuggestion_DuplicateBaseRecord)
- [msdyn_conversationsummarysuggestion_DuplicateMatchingRecord](#BKMK_msdyn_conversationsummarysuggestion_DuplicateMatchingRecord)
- [msdyn_conversationsummarysuggestion_MailboxTrackingFolders](#BKMK_msdyn_conversationsummarysuggestion_MailboxTrackingFolders)
- [msdyn_conversationsummarysuggestion_PrincipalObjectAttributeAccesses](#BKMK_msdyn_conversationsummarysuggestion_PrincipalObjectAttributeAccesses)
- [msdyn_conversationsummarysuggestion_ProcessSession](#BKMK_msdyn_conversationsummarysuggestion_ProcessSession)
- [msdyn_conversationsummarysuggestion_SyncErrors](#BKMK_msdyn_conversationsummarysuggestion_SyncErrors)

### <a name="BKMK_msdyn_conversationsummarysuggestion_AsyncOperations"></a> msdyn_conversationsummarysuggestion_AsyncOperations

Many-To-One Relationship: [asyncoperation msdyn_conversationsummarysuggestion_AsyncOperations](asyncoperation.md#BKMK_msdyn_conversationsummarysuggestion_AsyncOperations)

|Property|Value|
|---|---|
|ReferencingEntity|`asyncoperation`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_conversationsummarysuggestion_AsyncOperations`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_conversationsummarysuggestion_BulkDeleteFailures"></a> msdyn_conversationsummarysuggestion_BulkDeleteFailures

Many-To-One Relationship: [bulkdeletefailure msdyn_conversationsummarysuggestion_BulkDeleteFailures](bulkdeletefailure.md#BKMK_msdyn_conversationsummarysuggestion_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencingEntity|`bulkdeletefailure`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_conversationsummarysuggestion_BulkDeleteFailures`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_conversationsummarysuggestion_DuplicateBaseRecord"></a> msdyn_conversationsummarysuggestion_DuplicateBaseRecord

Many-To-One Relationship: [duplicaterecord msdyn_conversationsummarysuggestion_DuplicateBaseRecord](duplicaterecord.md#BKMK_msdyn_conversationsummarysuggestion_DuplicateBaseRecord)

|Property|Value|
|---|---|
|ReferencingEntity|`duplicaterecord`|
|ReferencingAttribute|`baserecordid`|
|ReferencedEntityNavigationPropertyName|`msdyn_conversationsummarysuggestion_DuplicateBaseRecord`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_conversationsummarysuggestion_DuplicateMatchingRecord"></a> msdyn_conversationsummarysuggestion_DuplicateMatchingRecord

Many-To-One Relationship: [duplicaterecord msdyn_conversationsummarysuggestion_DuplicateMatchingRecord](duplicaterecord.md#BKMK_msdyn_conversationsummarysuggestion_DuplicateMatchingRecord)

|Property|Value|
|---|---|
|ReferencingEntity|`duplicaterecord`|
|ReferencingAttribute|`duplicaterecordid`|
|ReferencedEntityNavigationPropertyName|`msdyn_conversationsummarysuggestion_DuplicateMatchingRecord`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_conversationsummarysuggestion_MailboxTrackingFolders"></a> msdyn_conversationsummarysuggestion_MailboxTrackingFolders

Many-To-One Relationship: [mailboxtrackingfolder msdyn_conversationsummarysuggestion_MailboxTrackingFolders](mailboxtrackingfolder.md#BKMK_msdyn_conversationsummarysuggestion_MailboxTrackingFolders)

|Property|Value|
|---|---|
|ReferencingEntity|`mailboxtrackingfolder`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_conversationsummarysuggestion_MailboxTrackingFolders`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_conversationsummarysuggestion_PrincipalObjectAttributeAccesses"></a> msdyn_conversationsummarysuggestion_PrincipalObjectAttributeAccesses

Many-To-One Relationship: [principalobjectattributeaccess msdyn_conversationsummarysuggestion_PrincipalObjectAttributeAccesses](principalobjectattributeaccess.md#BKMK_msdyn_conversationsummarysuggestion_PrincipalObjectAttributeAccesses)

|Property|Value|
|---|---|
|ReferencingEntity|`principalobjectattributeaccess`|
|ReferencingAttribute|`objectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_conversationsummarysuggestion_PrincipalObjectAttributeAccesses`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_conversationsummarysuggestion_ProcessSession"></a> msdyn_conversationsummarysuggestion_ProcessSession

Many-To-One Relationship: [processsession msdyn_conversationsummarysuggestion_ProcessSession](processsession.md#BKMK_msdyn_conversationsummarysuggestion_ProcessSession)

|Property|Value|
|---|---|
|ReferencingEntity|`processsession`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_conversationsummarysuggestion_ProcessSession`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_conversationsummarysuggestion_SyncErrors"></a> msdyn_conversationsummarysuggestion_SyncErrors

Many-To-One Relationship: [syncerror msdyn_conversationsummarysuggestion_SyncErrors](syncerror.md#BKMK_msdyn_conversationsummarysuggestion_SyncErrors)

|Property|Value|
|---|---|
|ReferencingEntity|`syncerror`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_conversationsummarysuggestion_SyncErrors`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|



### See also

[Dataverse table/entity reference](/power-apps/developer/data-platform/reference/about-entity-reference)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   

