---
title: "Case Suggestion (msdyn_casesuggestion) table/entity reference (Microsoft Dynamics 365)"
description: "Includes schema information and supported messages for the Case Suggestion (msdyn_casesuggestion) table/entity with Microsoft Dynamics 365."
ms.topic: generated-reference
author: JimDaly
ms.author: jdaly
search.audienceType: 
  - developer
---

# Case Suggestion (msdyn_casesuggestion) table/entity reference (Microsoft Dynamics 365)



## Messages

The following table lists the messages for the Case Suggestion (msdyn_casesuggestion) table.
Messages represent operations that can be performed on the table. They may also be events.

| Name <br />Is Event? |Web API Operation |SDK for .NET |
| ---- | ----- |----- |
| `Associate`<br />Event: True |[Associate records](/power-apps/developer/data-platform/webapi/associate-disassociate-entities-using-web-api) |[Associate records](/power-apps/developer/data-platform/org-service/entity-operations-associate-disassociate#use-the-associate-method-or-associaterequest)|
| `BulkRetain`<br />Event: True |<xref:Microsoft.Dynamics.CRM.BulkRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Create`<br />Event: True |`POST` /msdyn_casesuggestions<br />See [Create](/powerapps/developer/data-platform/webapi/create-entity-web-api) |[Create records](/power-apps/developer/data-platform/org-service/entity-operations-create#basic-create)|
| `CreateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.CreateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.CreateMultipleRequest>|
| `Delete`<br />Event: True |`DELETE` /msdyn_casesuggestions(*msdyn_casesuggestionid*)<br />See [Delete](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-delete) |[Delete records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-delete)|
| `Disassociate`<br />Event: True |[Disassociate records](/power-apps/developer/data-platform/webapi/associate-disassociate-entities-using-web-api) |[Disassociate records](/power-apps/developer/data-platform/org-service/entity-operations-associate-disassociate#use-the-disassociate-method-or-disassociaterequest)|
| `PurgeRetainedContent`<br />Event: True |<xref:Microsoft.Dynamics.CRM.PurgeRetainedContent?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retain`<br />Event: True |<xref:Microsoft.Dynamics.CRM.Retain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retrieve`<br />Event: True |`GET` /msdyn_casesuggestions(*msdyn_casesuggestionid*)<br />See [Retrieve](/powerapps/developer/data-platform/webapi/retrieve-entity-using-web-api) |[Retrieve records](/power-apps/developer/data-platform/org-service/entity-operations-retrieve)|
| `RetrieveEntityChanges`<br />Event: True | |<xref:Microsoft.Xrm.Sdk.Messages.RetrieveEntityChangesRequest>|
| `RetrieveMultiple`<br />Event: True |`GET` /msdyn_casesuggestions<br />See [Query data](/power-apps/developer/data-platform/webapi/query-data-web-api) |[Query data](/power-apps/developer/data-platform/org-service/entity-operations-query-data)|
| `RollbackRetain`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RollbackRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Update`<br />Event: True |`PATCH` /msdyn_casesuggestions(*msdyn_casesuggestionid*)<br />See [Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) |[Update records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-update)|
| `UpdateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.UpdateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpdateMultipleRequest>|
| `Upsert`<br />Event: False |`PATCH` /msdyn_casesuggestions(*msdyn_casesuggestionid*)<br />See [Upsert a table row](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#upsert-a-table-row) |<xref:Microsoft.Xrm.Sdk.Messages.UpsertRequest>|
| `UpsertMultiple`<br />Event: False |<xref:Microsoft.Dynamics.CRM.UpsertMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpsertMultipleRequest>|
| `ValidateRetentionConfig`<br />Event: True |<xref:Microsoft.Dynamics.CRM.ValidateRetentionConfig?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|

## Properties

The following table lists selected properties for the Case Suggestion (msdyn_casesuggestion) table.

|Property|Value|
| --- | --- |
| **DisplayName** | **Case Suggestion** |
| **DisplayCollectionName** | **Case Suggestions** |
| **SchemaName** | `msdyn_casesuggestion` |
| **CollectionSchemaName** | `msdyn_casesuggestions` |
| **EntitySetName** | `msdyn_casesuggestions`|
| **LogicalName** | `msdyn_casesuggestion` |
| **LogicalCollectionName** | `msdyn_casesuggestions` |
| **PrimaryIdAttribute** | `msdyn_casesuggestionid` |
| **PrimaryNameAttribute** |`msdyn_name` |
| **TableType** | `Virtual` |
| **OwnershipType** | `OrganizationOwned` |

## Writable columns/attributes

These columns/attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [msdyn_additionalcontext](#BKMK_msdyn_additionalcontext)
- [msdyn_casesuggestionId](#BKMK_msdyn_casesuggestionId)
- [msdyn_confidencescore](#BKMK_msdyn_confidencescore)
- [msdyn_keyphrases](#BKMK_msdyn_keyphrases)
- [msdyn_name](#BKMK_msdyn_name)
- [msdyn_rank](#BKMK_msdyn_rank)
- [msdyn_suggestedentity](#BKMK_msdyn_suggestedentity)
- [msdyn_suggestionforentitylogicalname](#BKMK_msdyn_suggestionforentitylogicalname)
- [msdyn_suggestionforid](#BKMK_msdyn_suggestionforid)

### <a name="BKMK_msdyn_additionalcontext"></a> msdyn_additionalcontext

|Property|Value|
|---|---|
|Description||
|DisplayName|**Additional Context**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_additionalcontext`|
|RequiredLevel|None|
|Type|Memo|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|10000|

### <a name="BKMK_msdyn_casesuggestionId"></a> msdyn_casesuggestionId

|Property|Value|
|---|---|
|Description|**Unique identifier for entity instances**|
|DisplayName|**Case Suggestion**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`msdyn_casesuggestionid`|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|

### <a name="BKMK_msdyn_confidencescore"></a> msdyn_confidencescore

|Property|Value|
|---|---|
|Description||
|DisplayName|**Confidence Score**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_confidencescore`|
|RequiredLevel|None|
|Type|Decimal|
|ImeMode|Auto|
|MaxValue|100|
|MinValue|0|
|Precision|2|
|SourceTypeMask|0|

### <a name="BKMK_msdyn_keyphrases"></a> msdyn_keyphrases

|Property|Value|
|---|---|
|Description||
|DisplayName|**Key Phrases**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_keyphrases`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|2000|

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

### <a name="BKMK_msdyn_rank"></a> msdyn_rank

|Property|Value|
|---|---|
|Description||
|DisplayName|**Rank**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_rank`|
|RequiredLevel|None|
|Type|Integer|
|MaxValue|100|
|MinValue|0|

### <a name="BKMK_msdyn_suggestedentity"></a> msdyn_suggestedentity

|Property|Value|
|---|---|
|Description||
|DisplayName|**Suggested Case**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_suggestedentity`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|incident|

### <a name="BKMK_msdyn_suggestionforentitylogicalname"></a> msdyn_suggestionforentitylogicalname

|Property|Value|
|---|---|
|Description||
|DisplayName|**suggestion for entity  logical name**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_suggestionforentitylogicalname`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|150|

### <a name="BKMK_msdyn_suggestionforid"></a> msdyn_suggestionforid

|Property|Value|
|---|---|
|Description||
|DisplayName|**suggestion for entity id**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_suggestionforid`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|50|


## Many-to-One relationships

These relationships are many-to-one. Listed by **SchemaName**.

### <a name="BKMK_msdyn_incident_msdyn_casesuggestion_suggestedentity"></a> msdyn_incident_msdyn_casesuggestion_suggestedentity

One-To-Many Relationship: [incident msdyn_incident_msdyn_casesuggestion_suggestedentity](incident.md#BKMK_msdyn_incident_msdyn_casesuggestion_suggestedentity)

|Property|Value|
|---|---|
|ReferencedEntity|`incident`|
|ReferencedAttribute|`incidentid`|
|ReferencingAttribute|`msdyn_suggestedentity`|
|ReferencingEntityNavigationPropertyName|`msdyn_suggestedentity`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|



### See also

[Dataverse table/entity reference](/power-apps/developer/data-platform/reference/about-entity-reference)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   

