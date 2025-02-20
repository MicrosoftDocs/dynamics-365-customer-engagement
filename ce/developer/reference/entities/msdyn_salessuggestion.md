---
title: "Insight (msdyn_salessuggestion) table/entity reference (Microsoft Dynamics 365)"
description: "Includes schema information and supported messages for the Insight (msdyn_salessuggestion) table/entity with Microsoft Dynamics 365."
ms.topic: generated-reference
author: JimDaly
ms.author: jdaly
search.audienceType: 
  - developer
---

# Insight (msdyn_salessuggestion) table/entity reference (Microsoft Dynamics 365)



## Messages

The following table lists the messages for the Insight (msdyn_salessuggestion) table.
Messages represent operations that can be performed on the table. They may also be events.

| Name <br />Is Event? |Web API Operation |SDK for .NET |
| ---- | ----- |----- |
| `Assign`<br />Event: True |`PATCH` /msdyn_salessuggestions(*msdyn_salessuggestionid*)<br />[Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) the `ownerid` property. |<xref:Microsoft.Crm.Sdk.Messages.AssignRequest>|
| `Associate`<br />Event: True |[Associate records](/power-apps/developer/data-platform/webapi/associate-disassociate-entities-using-web-api) |[Associate records](/power-apps/developer/data-platform/org-service/entity-operations-associate-disassociate#use-the-associate-method-or-associaterequest)|
| `BulkRetain`<br />Event: True |<xref:Microsoft.Dynamics.CRM.BulkRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Create`<br />Event: True |`POST` /msdyn_salessuggestions<br />See [Create](/powerapps/developer/data-platform/webapi/create-entity-web-api) |[Create records](/power-apps/developer/data-platform/org-service/entity-operations-create#basic-create)|
| `CreateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.CreateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.CreateMultipleRequest>|
| `Delete`<br />Event: True |`DELETE` /msdyn_salessuggestions(*msdyn_salessuggestionid*)<br />See [Delete](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-delete) |[Delete records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-delete)|
| `Disassociate`<br />Event: True |[Disassociate records](/power-apps/developer/data-platform/webapi/associate-disassociate-entities-using-web-api) |[Disassociate records](/power-apps/developer/data-platform/org-service/entity-operations-associate-disassociate#use-the-disassociate-method-or-disassociaterequest)|
| `GrantAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.GrantAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.GrantAccessRequest>|
| `IsValidStateTransition`<br />Event: False |<xref:Microsoft.Dynamics.CRM.IsValidStateTransition?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.IsValidStateTransitionRequest>|
| `ModifyAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.ModifyAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.ModifyAccessRequest>|
| `PurgeRetainedContent`<br />Event: True |<xref:Microsoft.Dynamics.CRM.PurgeRetainedContent?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Restore`<br />Event: True |<xref:Microsoft.Dynamics.CRM.Restore?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retain`<br />Event: True |<xref:Microsoft.Dynamics.CRM.Retain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retrieve`<br />Event: True |`GET` /msdyn_salessuggestions(*msdyn_salessuggestionid*)<br />See [Retrieve](/powerapps/developer/data-platform/webapi/retrieve-entity-using-web-api) |[Retrieve records](/power-apps/developer/data-platform/org-service/entity-operations-retrieve)|
| `RetrieveMultiple`<br />Event: True |`GET` /msdyn_salessuggestions<br />See [Query data](/power-apps/developer/data-platform/webapi/query-data-web-api) |[Query data](/power-apps/developer/data-platform/org-service/entity-operations-query-data)|
| `RetrievePrincipalAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RetrievePrincipalAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RetrievePrincipalAccessRequest>|
| `RetrieveSharedPrincipalsAndAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RetrieveSharedPrincipalsAndAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RetrieveSharedPrincipalsAndAccessRequest>|
| `RevokeAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RevokeAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RevokeAccessRequest>|
| `RollbackRetain`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RollbackRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `SetState`<br />Event: True |`PATCH` /msdyn_salessuggestions(*msdyn_salessuggestionid*)<br />[Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) the `statecode` and `statuscode` properties. |<xref:Microsoft.Crm.Sdk.Messages.SetStateRequest>|
| `Update`<br />Event: True |`PATCH` /msdyn_salessuggestions(*msdyn_salessuggestionid*)<br />See [Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) |[Update records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-update)|
| `UpdateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.UpdateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpdateMultipleRequest>|
| `Upsert`<br />Event: False |`PATCH` /msdyn_salessuggestions(*msdyn_salessuggestionid*)<br />See [Upsert a table row](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#upsert-a-table-row) |<xref:Microsoft.Xrm.Sdk.Messages.UpsertRequest>|
| `UpsertMultiple`<br />Event: False |<xref:Microsoft.Dynamics.CRM.UpsertMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpsertMultipleRequest>|
| `ValidateRetentionConfig`<br />Event: True |<xref:Microsoft.Dynamics.CRM.ValidateRetentionConfig?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|

## Properties

The following table lists selected properties for the Insight (msdyn_salessuggestion) table.

|Property|Value|
| --- | --- |
| **DisplayName** | **Insight** |
| **DisplayCollectionName** | **Insights** |
| **SchemaName** | `msdyn_salessuggestion` |
| **CollectionSchemaName** | `msdyn_salessuggestions` |
| **EntitySetName** | `msdyn_salessuggestions`|
| **LogicalName** | `msdyn_salessuggestion` |
| **LogicalCollectionName** | `msdyn_salessuggestions` |
| **PrimaryIdAttribute** | `msdyn_salessuggestionid` |
| **PrimaryNameAttribute** |`msdyn_name` |
| **TableType** | `Standard` |
| **OwnershipType** | `UserOwned` |

## Writable columns/attributes

These columns/attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [EmailAddress](#BKMK_EmailAddress)
- [ImportSequenceNumber](#BKMK_ImportSequenceNumber)
- [msdyn_customdata](#BKMK_msdyn_customdata)
- [msdyn_expirydate](#BKMK_msdyn_expirydate)
- [msdyn_feedbackreason](#BKMK_msdyn_feedbackreason)
- [msdyn_insight](#BKMK_msdyn_insight)
- [msdyn_modelid](#BKMK_msdyn_modelid)
- [msdyn_name](#BKMK_msdyn_name)
- [msdyn_potentialrevenue](#BKMK_msdyn_potentialrevenue)
- [msdyn_qualifiedrecord](#BKMK_msdyn_qualifiedrecord)
- [msdyn_qualifiedrecordIdType](#BKMK_msdyn_qualifiedrecordIdType)
- [msdyn_relatedrecord](#BKMK_msdyn_relatedrecord)
- [msdyn_relatedrecordIdType](#BKMK_msdyn_relatedrecordIdType)
- [msdyn_salesmotion](#BKMK_msdyn_salesmotion)
- [msdyn_salesplay](#BKMK_msdyn_salesplay)
- [msdyn_salessuggestionId](#BKMK_msdyn_salessuggestionId)
- [msdyn_score](#BKMK_msdyn_score)
- [msdyn_sequencecontact](#BKMK_msdyn_sequencecontact)
- [msdyn_solutionarea](#BKMK_msdyn_solutionarea)
- [msdyn_suggesteddate](#BKMK_msdyn_suggesteddate)
- [msdyn_suggestionreason](#BKMK_msdyn_suggestionreason)
- [msdyn_suggestionsource](#BKMK_msdyn_suggestionsource)
- [OverriddenCreatedOn](#BKMK_OverriddenCreatedOn)
- [OwnerId](#BKMK_OwnerId)
- [OwnerIdType](#BKMK_OwnerIdType)
- [statecode](#BKMK_statecode)
- [statuscode](#BKMK_statuscode)
- [TimeZoneRuleVersionNumber](#BKMK_TimeZoneRuleVersionNumber)
- [TransactionCurrencyId](#BKMK_TransactionCurrencyId)
- [UTCConversionTimeZoneCode](#BKMK_UTCConversionTimeZoneCode)

### <a name="BKMK_EmailAddress"></a> EmailAddress

|Property|Value|
|---|---|
|Description|**The primary email address for the entity.**|
|DisplayName|**Email Address**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`emailaddress`|
|RequiredLevel|None|
|Type|String|
|Format|Email|
|FormatName|Email|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

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

### <a name="BKMK_msdyn_customdata"></a> msdyn_customdata

|Property|Value|
|---|---|
|Description|**Customdata JSON**|
|DisplayName|**Customdata**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_customdata`|
|RequiredLevel|None|
|Type|Memo|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|8000|

### <a name="BKMK_msdyn_expirydate"></a> msdyn_expirydate

|Property|Value|
|---|---|
|Description|**Expiry date**|
|DisplayName|**Expiry date**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_expirydate`|
|RequiredLevel|ApplicationRequired|
|Type|DateTime|
|CanChangeDateTimeBehavior|True|
|DateTimeBehavior|UserLocal|
|Format|DateOnly|
|ImeMode|Auto|
|SourceTypeMask|0|

### <a name="BKMK_msdyn_feedbackreason"></a> msdyn_feedbackreason

|Property|Value|
|---|---|
|Description|**Feedback reason**|
|DisplayName|**Feedback reason**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_feedbackreason`|
|RequiredLevel|None|
|Type|Memo|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|4000|

### <a name="BKMK_msdyn_insight"></a> msdyn_insight

|Property|Value|
|---|---|
|Description|**Suggestion insight**|
|DisplayName|**Suggestion insight**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_insight`|
|RequiredLevel|None|
|Type|Memo|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|4000|

### <a name="BKMK_msdyn_modelid"></a> msdyn_modelid

|Property|Value|
|---|---|
|Description|**Model ID**|
|DisplayName|**Model ID**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_modelid`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|500|

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
|MaxLength|300|

### <a name="BKMK_msdyn_potentialrevenue"></a> msdyn_potentialrevenue

|Property|Value|
|---|---|
|Description|**Potential revenue**|
|DisplayName|**Potential revenue**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_potentialrevenue`|
|RequiredLevel|None|
|Type|Money|
|ImeMode|Auto|
|IsBaseCurrency|False|
|MaxValue|922337203685477|
|MinValue|-922337203685477|
|Precision|4|
|PrecisionSource|2 (TransactionCurrency.CurrencyPrecision)|

### <a name="BKMK_msdyn_qualifiedrecord"></a> msdyn_qualifiedrecord

|Property|Value|
|---|---|
|Description||
|DisplayName|**Qualified Record**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_qualifiedrecord`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|opportunity|

### <a name="BKMK_msdyn_qualifiedrecordIdType"></a> msdyn_qualifiedrecordIdType

|Property|Value|
|---|---|
|Description||
|DisplayName||
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`msdyn_qualifiedrecordidtype`|
|RequiredLevel|None|
|Type|EntityName|

### <a name="BKMK_msdyn_relatedrecord"></a> msdyn_relatedrecord

|Property|Value|
|---|---|
|Description|**Related record**|
|DisplayName|**Related record**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_relatedrecord`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|account|

### <a name="BKMK_msdyn_relatedrecordIdType"></a> msdyn_relatedrecordIdType

|Property|Value|
|---|---|
|Description||
|DisplayName||
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`msdyn_relatedrecordidtype`|
|RequiredLevel|None|
|Type|EntityName|

### <a name="BKMK_msdyn_salesmotion"></a> msdyn_salesmotion

|Property|Value|
|---|---|
|Description|**Sales motion**|
|DisplayName|**Sales motion**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_salesmotion`|
|RequiredLevel|None|
|Type|Picklist|
|DefaultFormValue|1|
|GlobalChoiceName|`msdyn_salesmotion_type`|

#### msdyn_salesmotion Choices/Options

|Value|Label|
|---|---|
|1|**Default**|

### <a name="BKMK_msdyn_salesplay"></a> msdyn_salesplay

|Property|Value|
|---|---|
|Description|**Sales play**|
|DisplayName|**Sales play**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_salesplay`|
|RequiredLevel|None|
|Type|Picklist|
|DefaultFormValue|1|
|GlobalChoiceName|`msdyn_salesplay_type`|

#### msdyn_salesplay Choices/Options

|Value|Label|
|---|---|
|1|**Default**|

### <a name="BKMK_msdyn_salessuggestionId"></a> msdyn_salessuggestionId

|Property|Value|
|---|---|
|Description|**Unique identifier for entity instances**|
|DisplayName|**Suggestion**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`msdyn_salessuggestionid`|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|

### <a name="BKMK_msdyn_score"></a> msdyn_score

|Property|Value|
|---|---|
|Description|**Score**|
|DisplayName|**Score**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_score`|
|RequiredLevel|None|
|Type|Integer|
|MaxValue|2147483647|
|MinValue|-2147483648|

### <a name="BKMK_msdyn_sequencecontact"></a> msdyn_sequencecontact

|Property|Value|
|---|---|
|Description|**Many to one relationship to Contact entity**|
|DisplayName|**Sequence Contact**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_sequencecontact`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|contact|

### <a name="BKMK_msdyn_solutionarea"></a> msdyn_solutionarea

|Property|Value|
|---|---|
|Description|**Solution area**|
|DisplayName|**Solution area**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_solutionarea`|
|RequiredLevel|None|
|Type|Picklist|
|DefaultFormValue|1|
|GlobalChoiceName|`msdyn_solutionarea_type`|

#### msdyn_solutionarea Choices/Options

|Value|Label|
|---|---|
|1|**Default**|

### <a name="BKMK_msdyn_suggesteddate"></a> msdyn_suggesteddate

|Property|Value|
|---|---|
|Description|**Suggested date**|
|DisplayName|**Suggested date**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_suggesteddate`|
|RequiredLevel|None|
|Type|DateTime|
|CanChangeDateTimeBehavior|True|
|DateTimeBehavior|UserLocal|
|Format|DateOnly|
|ImeMode|Auto|
|SourceTypeMask|0|

### <a name="BKMK_msdyn_suggestionreason"></a> msdyn_suggestionreason

|Property|Value|
|---|---|
|Description|**Suggestion reason**|
|DisplayName|**Suggestion reason**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_suggestionreason`|
|RequiredLevel|None|
|Type|Memo|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|4000|

### <a name="BKMK_msdyn_suggestionsource"></a> msdyn_suggestionsource

|Property|Value|
|---|---|
|Description||
|DisplayName|**msdyn_suggestionsource**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_suggestionsource`|
|RequiredLevel|None|
|Type|Picklist|
|DefaultFormValue|-1|
|GlobalChoiceName|`msdyn_suggestionsource`|

#### msdyn_suggestionsource Choices/Options

|Value|Label|
|---|---|
|0|**Others**|
|1|**Product Recommendations**|

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
|Description|**Status of the Suggestion**|
|DisplayName|**Status**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statecode`|
|RequiredLevel|SystemRequired|
|Type|State|
|DefaultFormValue||
|GlobalChoiceName|`msdyn_salessuggestion_statecode`|

#### statecode Choices/Options

|Value|Details|
|---|---|
|0|Label: **Open**<br />DefaultStatus: 1<br />InvariantName: `Open`|
|1|Label: **Closed**<br />DefaultStatus: 2<br />InvariantName: `Closed`|
|2|Label: **Declined**<br />DefaultStatus: 3<br />InvariantName: `Declined`|
|3|Label: **Qualified**<br />DefaultStatus: 4<br />InvariantName: `Qualified`|

### <a name="BKMK_statuscode"></a> statuscode

|Property|Value|
|---|---|
|Description|**Reason for the status of the Suggestion**|
|DisplayName|**Status Reason**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statuscode`|
|RequiredLevel|None|
|Type|Status|
|DefaultFormValue||
|GlobalChoiceName|`msdyn_salessuggestion_statuscode`|

#### statuscode Choices/Options

|Value|Details|
|---|---|
|1|Label: **Open**<br />State:0<br />TransitionData: None|
|2|Label: **Others**<br />State:1<br />TransitionData: None|
|3|Label: **Others**<br />State:2<br />TransitionData: None|
|4|Label: **Created Opportunity**<br />State:3<br />TransitionData: None|
|5|Label: **Accepted**<br />State:0<br />TransitionData: None|

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

### <a name="BKMK_TransactionCurrencyId"></a> TransactionCurrencyId

|Property|Value|
|---|---|
|Description|**Unique identifier of the currency associated with the entity.**|
|DisplayName|**Currency**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`transactioncurrencyid`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|transactioncurrency|

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
- [ExchangeRate](#BKMK_ExchangeRate)
- [ModifiedBy](#BKMK_ModifiedBy)
- [ModifiedOn](#BKMK_ModifiedOn)
- [ModifiedOnBehalfBy](#BKMK_ModifiedOnBehalfBy)
- [msdyn_potentialrevenue_Base](#BKMK_msdyn_potentialrevenue_Base)
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

### <a name="BKMK_ExchangeRate"></a> ExchangeRate

|Property|Value|
|---|---|
|Description|**Exchange rate for the currency associated with the entity with respect to the base currency.**|
|DisplayName|**Exchange Rate**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`exchangerate`|
|RequiredLevel|None|
|Type|Decimal|
|ImeMode|Disabled|
|MaxValue|100000000000|
|MinValue|1E-12|
|Precision|12|
|SourceTypeMask|0|

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

### <a name="BKMK_msdyn_potentialrevenue_Base"></a> msdyn_potentialrevenue_Base

|Property|Value|
|---|---|
|Description|**Value of the potential revenue in base currency.**|
|DisplayName|**Potential revenue (Base)**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_potentialrevenue_base`|
|RequiredLevel|None|
|Type|Money|
|ImeMode|Disabled|
|IsBaseCurrency|True|
|MaxValue|922337203685477|
|MinValue|-922337203685477|
|Precision|4|
|PrecisionSource|2 (TransactionCurrency.CurrencyPrecision)|

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

- [business_unit_msdyn_salessuggestion](#BKMK_business_unit_msdyn_salessuggestion)
- [lk_msdyn_salessuggestion_createdby](#BKMK_lk_msdyn_salessuggestion_createdby)
- [lk_msdyn_salessuggestion_createdonbehalfby](#BKMK_lk_msdyn_salessuggestion_createdonbehalfby)
- [lk_msdyn_salessuggestion_modifiedby](#BKMK_lk_msdyn_salessuggestion_modifiedby)
- [lk_msdyn_salessuggestion_modifiedonbehalfby](#BKMK_lk_msdyn_salessuggestion_modifiedonbehalfby)
- [msdyn_contact_msdyn_salessuggestion](#BKMK_msdyn_contact_msdyn_salessuggestion)
- [msdyn_salessuggestion_account](#BKMK_msdyn_salessuggestion_account)
- [msdyn_salessuggestion_opportunity_qualifiedrecord](#BKMK_msdyn_salessuggestion_opportunity_qualifiedrecord)
- [owner_msdyn_salessuggestion](#BKMK_owner_msdyn_salessuggestion)
- [team_msdyn_salessuggestion](#BKMK_team_msdyn_salessuggestion)
- [TransactionCurrency_msdyn_salessuggestion](#BKMK_TransactionCurrency_msdyn_salessuggestion)
- [user_msdyn_salessuggestion](#BKMK_user_msdyn_salessuggestion)

### <a name="BKMK_business_unit_msdyn_salessuggestion"></a> business_unit_msdyn_salessuggestion

One-To-Many Relationship: [businessunit business_unit_msdyn_salessuggestion](businessunit.md#BKMK_business_unit_msdyn_salessuggestion)

|Property|Value|
|---|---|
|ReferencedEntity|`businessunit`|
|ReferencedAttribute|`businessunitid`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencingEntityNavigationPropertyName|`owningbusinessunit`|
|IsHierarchical||
|CascadeConfiguration|Archive: `Restrict`<br />Assign: `NoCascade`<br />Delete: `Restrict`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_salessuggestion_createdby"></a> lk_msdyn_salessuggestion_createdby

One-To-Many Relationship: [systemuser lk_msdyn_salessuggestion_createdby](systemuser.md#BKMK_lk_msdyn_salessuggestion_createdby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdby`|
|ReferencingEntityNavigationPropertyName|`createdby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_salessuggestion_createdonbehalfby"></a> lk_msdyn_salessuggestion_createdonbehalfby

One-To-Many Relationship: [systemuser lk_msdyn_salessuggestion_createdonbehalfby](systemuser.md#BKMK_lk_msdyn_salessuggestion_createdonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdonbehalfby`|
|ReferencingEntityNavigationPropertyName|`createdonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_salessuggestion_modifiedby"></a> lk_msdyn_salessuggestion_modifiedby

One-To-Many Relationship: [systemuser lk_msdyn_salessuggestion_modifiedby](systemuser.md#BKMK_lk_msdyn_salessuggestion_modifiedby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedby`|
|ReferencingEntityNavigationPropertyName|`modifiedby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_salessuggestion_modifiedonbehalfby"></a> lk_msdyn_salessuggestion_modifiedonbehalfby

One-To-Many Relationship: [systemuser lk_msdyn_salessuggestion_modifiedonbehalfby](systemuser.md#BKMK_lk_msdyn_salessuggestion_modifiedonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedonbehalfby`|
|ReferencingEntityNavigationPropertyName|`modifiedonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_contact_msdyn_salessuggestion"></a> msdyn_contact_msdyn_salessuggestion

One-To-Many Relationship: [contact msdyn_contact_msdyn_salessuggestion](contact.md#BKMK_msdyn_contact_msdyn_salessuggestion)

|Property|Value|
|---|---|
|ReferencedEntity|`contact`|
|ReferencedAttribute|`contactid`|
|ReferencingAttribute|`msdyn_sequencecontact`|
|ReferencingEntityNavigationPropertyName|`msdyn_sequencecontact`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `Cascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_salessuggestion_account"></a> msdyn_salessuggestion_account

One-To-Many Relationship: [account msdyn_salessuggestion_account](account.md#BKMK_msdyn_salessuggestion_account)

|Property|Value|
|---|---|
|ReferencedEntity|`account`|
|ReferencedAttribute|`accountid`|
|ReferencingAttribute|`msdyn_relatedrecord`|
|ReferencingEntityNavigationPropertyName|`msdyn_relatedrecord`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `Cascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_salessuggestion_opportunity_qualifiedrecord"></a> msdyn_salessuggestion_opportunity_qualifiedrecord

One-To-Many Relationship: [opportunity msdyn_salessuggestion_opportunity_qualifiedrecord](opportunity.md#BKMK_msdyn_salessuggestion_opportunity_qualifiedrecord)

|Property|Value|
|---|---|
|ReferencedEntity|`opportunity`|
|ReferencedAttribute|`opportunityid`|
|ReferencingAttribute|`msdyn_qualifiedrecord`|
|ReferencingEntityNavigationPropertyName|`msdyn_qualifiedrecord`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_owner_msdyn_salessuggestion"></a> owner_msdyn_salessuggestion

One-To-Many Relationship: [owner owner_msdyn_salessuggestion](owner.md#BKMK_owner_msdyn_salessuggestion)

|Property|Value|
|---|---|
|ReferencedEntity|`owner`|
|ReferencedAttribute|`ownerid`|
|ReferencingAttribute|`ownerid`|
|ReferencingEntityNavigationPropertyName|`ownerid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_team_msdyn_salessuggestion"></a> team_msdyn_salessuggestion

One-To-Many Relationship: [team team_msdyn_salessuggestion](team.md#BKMK_team_msdyn_salessuggestion)

|Property|Value|
|---|---|
|ReferencedEntity|`team`|
|ReferencedAttribute|`teamid`|
|ReferencingAttribute|`owningteam`|
|ReferencingEntityNavigationPropertyName|`owningteam`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_TransactionCurrency_msdyn_salessuggestion"></a> TransactionCurrency_msdyn_salessuggestion

One-To-Many Relationship: [transactioncurrency TransactionCurrency_msdyn_salessuggestion](transactioncurrency.md#BKMK_TransactionCurrency_msdyn_salessuggestion)

|Property|Value|
|---|---|
|ReferencedEntity|`transactioncurrency`|
|ReferencedAttribute|`transactioncurrencyid`|
|ReferencingAttribute|`transactioncurrencyid`|
|ReferencingEntityNavigationPropertyName|`transactioncurrencyid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `Restrict`<br />Assign: `NoCascade`<br />Delete: `Restrict`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_user_msdyn_salessuggestion"></a> user_msdyn_salessuggestion

One-To-Many Relationship: [systemuser user_msdyn_salessuggestion](systemuser.md#BKMK_user_msdyn_salessuggestion)

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

- [msdyn_salessuggestion_ActivityParties](#BKMK_msdyn_salessuggestion_ActivityParties)
- [msdyn_salessuggestion_ActivityPointers](#BKMK_msdyn_salessuggestion_ActivityPointers)
- [msdyn_salessuggestion_adx_inviteredemptions](#BKMK_msdyn_salessuggestion_adx_inviteredemptions)
- [msdyn_salessuggestion_adx_portalcomments](#BKMK_msdyn_salessuggestion_adx_portalcomments)
- [msdyn_salessuggestion_Annotations](#BKMK_msdyn_salessuggestion_Annotations)
- [msdyn_salessuggestion_Appointments](#BKMK_msdyn_salessuggestion_Appointments)
- [msdyn_salessuggestion_AsyncOperations](#BKMK_msdyn_salessuggestion_AsyncOperations)
- [msdyn_salessuggestion_BulkDeleteFailures](#BKMK_msdyn_salessuggestion_BulkDeleteFailures)
- [msdyn_salessuggestion_chats](#BKMK_msdyn_salessuggestion_chats)
- [msdyn_salessuggestion_connections1](#BKMK_msdyn_salessuggestion_connections1)
- [msdyn_salessuggestion_connections2](#BKMK_msdyn_salessuggestion_connections2)
- [msdyn_salessuggestion_DuplicateBaseRecord](#BKMK_msdyn_salessuggestion_DuplicateBaseRecord)
- [msdyn_salessuggestion_DuplicateMatchingRecord](#BKMK_msdyn_salessuggestion_DuplicateMatchingRecord)
- [msdyn_salessuggestion_Emails](#BKMK_msdyn_salessuggestion_Emails)
- [msdyn_salessuggestion_Faxes](#BKMK_msdyn_salessuggestion_Faxes)
- [msdyn_salessuggestion_Letters](#BKMK_msdyn_salessuggestion_Letters)
- [msdyn_salessuggestion_MailboxTrackingFolders](#BKMK_msdyn_salessuggestion_MailboxTrackingFolders)
- [msdyn_salessuggestion_msdyn_copilottranscripts](#BKMK_msdyn_salessuggestion_msdyn_copilottranscripts)
- [msdyn_salessuggestion_msdyn_ocliveworkitems](#BKMK_msdyn_salessuggestion_msdyn_ocliveworkitems)
- [msdyn_salessuggestion_msdyn_ocsessions](#BKMK_msdyn_salessuggestion_msdyn_ocsessions)
- [msdyn_salessuggestion_msdyn_salesroutingrun_targetobject](#BKMK_msdyn_salessuggestion_msdyn_salesroutingrun_targetobject)
- [msdyn_salessuggestion_msfp_alerts](#BKMK_msdyn_salessuggestion_msfp_alerts)
- [msdyn_salessuggestion_msfp_surveyinvites](#BKMK_msdyn_salessuggestion_msfp_surveyinvites)
- [msdyn_salessuggestion_msfp_surveyresponses](#BKMK_msdyn_salessuggestion_msfp_surveyresponses)
- [msdyn_salessuggestion_PhoneCalls](#BKMK_msdyn_salessuggestion_PhoneCalls)
- [msdyn_salessuggestion_PostFollows](#BKMK_msdyn_salessuggestion_PostFollows)
- [msdyn_salessuggestion_PostRegardings](#BKMK_msdyn_salessuggestion_PostRegardings)
- [msdyn_salessuggestion_Posts](#BKMK_msdyn_salessuggestion_Posts)
- [msdyn_salessuggestion_PrincipalObjectAttributeAccesses](#BKMK_msdyn_salessuggestion_PrincipalObjectAttributeAccesses)
- [msdyn_salessuggestion_ProcessSession](#BKMK_msdyn_salessuggestion_ProcessSession)
- [msdyn_salessuggestion_RecurringAppointmentMasters](#BKMK_msdyn_salessuggestion_RecurringAppointmentMasters)
- [msdyn_salessuggestion_ServiceAppointments](#BKMK_msdyn_salessuggestion_ServiceAppointments)
- [msdyn_salessuggestion_SocialActivities](#BKMK_msdyn_salessuggestion_SocialActivities)
- [msdyn_salessuggestion_suggestionprincipalobjectaccess_salessuggestionid](#BKMK_msdyn_salessuggestion_suggestionprincipalobjectaccess_salessuggestionid)
- [msdyn_salessuggestion_SyncErrors](#BKMK_msdyn_salessuggestion_SyncErrors)
- [msdyn_salessuggestion_Tasks](#BKMK_msdyn_salessuggestion_Tasks)

### <a name="BKMK_msdyn_salessuggestion_ActivityParties"></a> msdyn_salessuggestion_ActivityParties

Many-To-One Relationship: [activityparty msdyn_salessuggestion_ActivityParties](activityparty.md#BKMK_msdyn_salessuggestion_ActivityParties)

|Property|Value|
|---|---|
|ReferencingEntity|`activityparty`|
|ReferencingAttribute|`partyid`|
|ReferencedEntityNavigationPropertyName|`msdyn_salessuggestion_ActivityParties`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_salessuggestion_ActivityPointers"></a> msdyn_salessuggestion_ActivityPointers

Many-To-One Relationship: [activitypointer msdyn_salessuggestion_ActivityPointers](activitypointer.md#BKMK_msdyn_salessuggestion_ActivityPointers)

|Property|Value|
|---|---|
|ReferencingEntity|`activitypointer`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_salessuggestion_ActivityPointers`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_salessuggestion_adx_inviteredemptions"></a> msdyn_salessuggestion_adx_inviteredemptions

Many-To-One Relationship: [adx_inviteredemption msdyn_salessuggestion_adx_inviteredemptions](adx_inviteredemption.md#BKMK_msdyn_salessuggestion_adx_inviteredemptions)

|Property|Value|
|---|---|
|ReferencingEntity|`adx_inviteredemption`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_salessuggestion_adx_inviteredemptions`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_salessuggestion_adx_portalcomments"></a> msdyn_salessuggestion_adx_portalcomments

Many-To-One Relationship: [adx_portalcomment msdyn_salessuggestion_adx_portalcomments](adx_portalcomment.md#BKMK_msdyn_salessuggestion_adx_portalcomments)

|Property|Value|
|---|---|
|ReferencingEntity|`adx_portalcomment`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_salessuggestion_adx_portalcomments`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_salessuggestion_Annotations"></a> msdyn_salessuggestion_Annotations

Many-To-One Relationship: [annotation msdyn_salessuggestion_Annotations](annotation.md#BKMK_msdyn_salessuggestion_Annotations)

|Property|Value|
|---|---|
|ReferencingEntity|`annotation`|
|ReferencingAttribute|`objectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_salessuggestion_Annotations`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_salessuggestion_Appointments"></a> msdyn_salessuggestion_Appointments

Many-To-One Relationship: [appointment msdyn_salessuggestion_Appointments](appointment.md#BKMK_msdyn_salessuggestion_Appointments)

|Property|Value|
|---|---|
|ReferencingEntity|`appointment`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_salessuggestion_Appointments`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_salessuggestion_AsyncOperations"></a> msdyn_salessuggestion_AsyncOperations

Many-To-One Relationship: [asyncoperation msdyn_salessuggestion_AsyncOperations](asyncoperation.md#BKMK_msdyn_salessuggestion_AsyncOperations)

|Property|Value|
|---|---|
|ReferencingEntity|`asyncoperation`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_salessuggestion_AsyncOperations`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_salessuggestion_BulkDeleteFailures"></a> msdyn_salessuggestion_BulkDeleteFailures

Many-To-One Relationship: [bulkdeletefailure msdyn_salessuggestion_BulkDeleteFailures](bulkdeletefailure.md#BKMK_msdyn_salessuggestion_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencingEntity|`bulkdeletefailure`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_salessuggestion_BulkDeleteFailures`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_salessuggestion_chats"></a> msdyn_salessuggestion_chats

Many-To-One Relationship: [chat msdyn_salessuggestion_chats](chat.md#BKMK_msdyn_salessuggestion_chats)

|Property|Value|
|---|---|
|ReferencingEntity|`chat`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_salessuggestion_chats`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_salessuggestion_connections1"></a> msdyn_salessuggestion_connections1

Many-To-One Relationship: [connection msdyn_salessuggestion_connections1](connection.md#BKMK_msdyn_salessuggestion_connections1)

|Property|Value|
|---|---|
|ReferencingEntity|`connection`|
|ReferencingAttribute|`record1id`|
|ReferencedEntityNavigationPropertyName|`msdyn_salessuggestion_connections1`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 100<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_salessuggestion_connections2"></a> msdyn_salessuggestion_connections2

Many-To-One Relationship: [connection msdyn_salessuggestion_connections2](connection.md#BKMK_msdyn_salessuggestion_connections2)

|Property|Value|
|---|---|
|ReferencingEntity|`connection`|
|ReferencingAttribute|`record2id`|
|ReferencedEntityNavigationPropertyName|`msdyn_salessuggestion_connections2`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_salessuggestion_DuplicateBaseRecord"></a> msdyn_salessuggestion_DuplicateBaseRecord

Many-To-One Relationship: [duplicaterecord msdyn_salessuggestion_DuplicateBaseRecord](duplicaterecord.md#BKMK_msdyn_salessuggestion_DuplicateBaseRecord)

|Property|Value|
|---|---|
|ReferencingEntity|`duplicaterecord`|
|ReferencingAttribute|`baserecordid`|
|ReferencedEntityNavigationPropertyName|`msdyn_salessuggestion_DuplicateBaseRecord`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_salessuggestion_DuplicateMatchingRecord"></a> msdyn_salessuggestion_DuplicateMatchingRecord

Many-To-One Relationship: [duplicaterecord msdyn_salessuggestion_DuplicateMatchingRecord](duplicaterecord.md#BKMK_msdyn_salessuggestion_DuplicateMatchingRecord)

|Property|Value|
|---|---|
|ReferencingEntity|`duplicaterecord`|
|ReferencingAttribute|`duplicaterecordid`|
|ReferencedEntityNavigationPropertyName|`msdyn_salessuggestion_DuplicateMatchingRecord`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_salessuggestion_Emails"></a> msdyn_salessuggestion_Emails

Many-To-One Relationship: [email msdyn_salessuggestion_Emails](email.md#BKMK_msdyn_salessuggestion_Emails)

|Property|Value|
|---|---|
|ReferencingEntity|`email`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_salessuggestion_Emails`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_salessuggestion_Faxes"></a> msdyn_salessuggestion_Faxes

Many-To-One Relationship: [fax msdyn_salessuggestion_Faxes](fax.md#BKMK_msdyn_salessuggestion_Faxes)

|Property|Value|
|---|---|
|ReferencingEntity|`fax`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_salessuggestion_Faxes`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_salessuggestion_Letters"></a> msdyn_salessuggestion_Letters

Many-To-One Relationship: [letter msdyn_salessuggestion_Letters](letter.md#BKMK_msdyn_salessuggestion_Letters)

|Property|Value|
|---|---|
|ReferencingEntity|`letter`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_salessuggestion_Letters`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_salessuggestion_MailboxTrackingFolders"></a> msdyn_salessuggestion_MailboxTrackingFolders

Many-To-One Relationship: [mailboxtrackingfolder msdyn_salessuggestion_MailboxTrackingFolders](mailboxtrackingfolder.md#BKMK_msdyn_salessuggestion_MailboxTrackingFolders)

|Property|Value|
|---|---|
|ReferencingEntity|`mailboxtrackingfolder`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_salessuggestion_MailboxTrackingFolders`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_salessuggestion_msdyn_copilottranscripts"></a> msdyn_salessuggestion_msdyn_copilottranscripts

Many-To-One Relationship: [msdyn_copilottranscript msdyn_salessuggestion_msdyn_copilottranscripts](msdyn_copilottranscript.md#BKMK_msdyn_salessuggestion_msdyn_copilottranscripts)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_copilottranscript`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_salessuggestion_msdyn_copilottranscripts`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_salessuggestion_msdyn_ocliveworkitems"></a> msdyn_salessuggestion_msdyn_ocliveworkitems

Many-To-One Relationship: [msdyn_ocliveworkitem msdyn_salessuggestion_msdyn_ocliveworkitems](msdyn_ocliveworkitem.md#BKMK_msdyn_salessuggestion_msdyn_ocliveworkitems)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_ocliveworkitem`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_salessuggestion_msdyn_ocliveworkitems`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_salessuggestion_msdyn_ocsessions"></a> msdyn_salessuggestion_msdyn_ocsessions

Many-To-One Relationship: [msdyn_ocsession msdyn_salessuggestion_msdyn_ocsessions](msdyn_ocsession.md#BKMK_msdyn_salessuggestion_msdyn_ocsessions)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_ocsession`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_salessuggestion_msdyn_ocsessions`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_salessuggestion_msdyn_salesroutingrun_targetobject"></a> msdyn_salessuggestion_msdyn_salesroutingrun_targetobject

Many-To-One Relationship: [msdyn_salesroutingrun msdyn_salessuggestion_msdyn_salesroutingrun_targetobject](msdyn_salesroutingrun.md#BKMK_msdyn_salessuggestion_msdyn_salesroutingrun_targetobject)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_salesroutingrun`|
|ReferencingAttribute|`msdyn_targetobject`|
|ReferencedEntityNavigationPropertyName|`msdyn_salessuggestion_msdyn_salesroutingrun_targetobject`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_salessuggestion_msfp_alerts"></a> msdyn_salessuggestion_msfp_alerts

Many-To-One Relationship: [msfp_alert msdyn_salessuggestion_msfp_alerts](msfp_alert.md#BKMK_msdyn_salessuggestion_msfp_alerts)

|Property|Value|
|---|---|
|ReferencingEntity|`msfp_alert`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_salessuggestion_msfp_alerts`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_salessuggestion_msfp_surveyinvites"></a> msdyn_salessuggestion_msfp_surveyinvites

Many-To-One Relationship: [msfp_surveyinvite msdyn_salessuggestion_msfp_surveyinvites](msfp_surveyinvite.md#BKMK_msdyn_salessuggestion_msfp_surveyinvites)

|Property|Value|
|---|---|
|ReferencingEntity|`msfp_surveyinvite`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_salessuggestion_msfp_surveyinvites`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_salessuggestion_msfp_surveyresponses"></a> msdyn_salessuggestion_msfp_surveyresponses

Many-To-One Relationship: [msfp_surveyresponse msdyn_salessuggestion_msfp_surveyresponses](msfp_surveyresponse.md#BKMK_msdyn_salessuggestion_msfp_surveyresponses)

|Property|Value|
|---|---|
|ReferencingEntity|`msfp_surveyresponse`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_salessuggestion_msfp_surveyresponses`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_salessuggestion_PhoneCalls"></a> msdyn_salessuggestion_PhoneCalls

Many-To-One Relationship: [phonecall msdyn_salessuggestion_PhoneCalls](phonecall.md#BKMK_msdyn_salessuggestion_PhoneCalls)

|Property|Value|
|---|---|
|ReferencingEntity|`phonecall`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_salessuggestion_PhoneCalls`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_salessuggestion_PostFollows"></a> msdyn_salessuggestion_PostFollows

Many-To-One Relationship: [postfollow msdyn_salessuggestion_PostFollows](postfollow.md#BKMK_msdyn_salessuggestion_PostFollows)

|Property|Value|
|---|---|
|ReferencingEntity|`postfollow`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_salessuggestion_PostFollows`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_salessuggestion_PostRegardings"></a> msdyn_salessuggestion_PostRegardings

Many-To-One Relationship: [postregarding msdyn_salessuggestion_PostRegardings](postregarding.md#BKMK_msdyn_salessuggestion_PostRegardings)

|Property|Value|
|---|---|
|ReferencingEntity|`postregarding`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_salessuggestion_PostRegardings`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_salessuggestion_Posts"></a> msdyn_salessuggestion_Posts

Many-To-One Relationship: [post msdyn_salessuggestion_Posts](post.md#BKMK_msdyn_salessuggestion_Posts)

|Property|Value|
|---|---|
|ReferencingEntity|`post`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_salessuggestion_Posts`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_salessuggestion_PrincipalObjectAttributeAccesses"></a> msdyn_salessuggestion_PrincipalObjectAttributeAccesses

Many-To-One Relationship: [principalobjectattributeaccess msdyn_salessuggestion_PrincipalObjectAttributeAccesses](principalobjectattributeaccess.md#BKMK_msdyn_salessuggestion_PrincipalObjectAttributeAccesses)

|Property|Value|
|---|---|
|ReferencingEntity|`principalobjectattributeaccess`|
|ReferencingAttribute|`objectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_salessuggestion_PrincipalObjectAttributeAccesses`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_salessuggestion_ProcessSession"></a> msdyn_salessuggestion_ProcessSession

Many-To-One Relationship: [processsession msdyn_salessuggestion_ProcessSession](processsession.md#BKMK_msdyn_salessuggestion_ProcessSession)

|Property|Value|
|---|---|
|ReferencingEntity|`processsession`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_salessuggestion_ProcessSession`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_salessuggestion_RecurringAppointmentMasters"></a> msdyn_salessuggestion_RecurringAppointmentMasters

Many-To-One Relationship: [recurringappointmentmaster msdyn_salessuggestion_RecurringAppointmentMasters](recurringappointmentmaster.md#BKMK_msdyn_salessuggestion_RecurringAppointmentMasters)

|Property|Value|
|---|---|
|ReferencingEntity|`recurringappointmentmaster`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_salessuggestion_RecurringAppointmentMasters`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_salessuggestion_ServiceAppointments"></a> msdyn_salessuggestion_ServiceAppointments

Many-To-One Relationship: [serviceappointment msdyn_salessuggestion_ServiceAppointments](serviceappointment.md#BKMK_msdyn_salessuggestion_ServiceAppointments)

|Property|Value|
|---|---|
|ReferencingEntity|`serviceappointment`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_salessuggestion_ServiceAppointments`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_salessuggestion_SocialActivities"></a> msdyn_salessuggestion_SocialActivities

Many-To-One Relationship: [socialactivity msdyn_salessuggestion_SocialActivities](socialactivity.md#BKMK_msdyn_salessuggestion_SocialActivities)

|Property|Value|
|---|---|
|ReferencingEntity|`socialactivity`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_salessuggestion_SocialActivities`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_salessuggestion_suggestionprincipalobjectaccess_salessuggestionid"></a> msdyn_salessuggestion_suggestionprincipalobjectaccess_salessuggestionid

Many-To-One Relationship: [msdyn_suggestionprincipalobjectaccess msdyn_salessuggestion_suggestionprincipalobjectaccess_salessuggestionid](msdyn_suggestionprincipalobjectaccess.md#BKMK_msdyn_salessuggestion_suggestionprincipalobjectaccess_salessuggestionid)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_suggestionprincipalobjectaccess`|
|ReferencingAttribute|`msdyn_salessuggestionid`|
|ReferencedEntityNavigationPropertyName|`msdyn_salessuggestion_suggestionprincipalobjectaccess_salessuggestionid`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_salessuggestion_SyncErrors"></a> msdyn_salessuggestion_SyncErrors

Many-To-One Relationship: [syncerror msdyn_salessuggestion_SyncErrors](syncerror.md#BKMK_msdyn_salessuggestion_SyncErrors)

|Property|Value|
|---|---|
|ReferencingEntity|`syncerror`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_salessuggestion_SyncErrors`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_salessuggestion_Tasks"></a> msdyn_salessuggestion_Tasks

Many-To-One Relationship: [task msdyn_salessuggestion_Tasks](task.md#BKMK_msdyn_salessuggestion_Tasks)

|Property|Value|
|---|---|
|ReferencingEntity|`task`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_salessuggestion_Tasks`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|



### See also

[Dataverse table/entity reference](/power-apps/developer/data-platform/reference/about-entity-reference)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   

