---
title: "Work List Suggestion (msdyn_worklistsuggestion) table/entity reference (Microsoft Dynamics 365)"
description: "Includes schema information and supported messages for the Work List Suggestion (msdyn_worklistsuggestion) table/entity with Microsoft Dynamics 365."
ms.topic: generated-reference
author: JimDaly
ms.author: jdaly
search.audienceType: 
  - developer
---

# Work List Suggestion (msdyn_worklistsuggestion) table/entity reference (Microsoft Dynamics 365)



## Messages

The following table lists the messages for the Work List Suggestion (msdyn_worklistsuggestion) table.
Messages represent operations that can be performed on the table. They may also be events.

| Name <br />Is Event? |Web API Operation |SDK for .NET |
| ---- | ----- |----- |
| `BulkRetain`<br />Event: True |<xref:Microsoft.Dynamics.CRM.BulkRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Create`<br />Event: True |`POST` /msdyn_worklistsuggestions<br />See [Create](/powerapps/developer/data-platform/webapi/create-entity-web-api) |[Create records](/power-apps/developer/data-platform/org-service/entity-operations-create#basic-create)|
| `CreateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.CreateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.CreateMultipleRequest>|
| `Delete`<br />Event: True |`DELETE` /msdyn_worklistsuggestions(*msdyn_worklistsuggestionid*)<br />See [Delete](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-delete) |[Delete records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-delete)|
| `PurgeRetainedContent`<br />Event: True |<xref:Microsoft.Dynamics.CRM.PurgeRetainedContent?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retain`<br />Event: True |<xref:Microsoft.Dynamics.CRM.Retain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retrieve`<br />Event: True |`GET` /msdyn_worklistsuggestions(*msdyn_worklistsuggestionid*)<br />See [Retrieve](/powerapps/developer/data-platform/webapi/retrieve-entity-using-web-api) |[Retrieve records](/power-apps/developer/data-platform/org-service/entity-operations-retrieve)|
| `RetrieveEntityChanges`<br />Event: True | |<xref:Microsoft.Xrm.Sdk.Messages.RetrieveEntityChangesRequest>|
| `RetrieveMultiple`<br />Event: True |`GET` /msdyn_worklistsuggestions<br />See [Query data](/power-apps/developer/data-platform/webapi/query-data-web-api) |[Query data](/power-apps/developer/data-platform/org-service/entity-operations-query-data)|
| `RollbackRetain`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RollbackRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Update`<br />Event: True |`PATCH` /msdyn_worklistsuggestions(*msdyn_worklistsuggestionid*)<br />See [Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) |[Update records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-update)|
| `UpdateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.UpdateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpdateMultipleRequest>|
| `Upsert`<br />Event: False |`PATCH` /msdyn_worklistsuggestions(*msdyn_worklistsuggestionid*)<br />See [Upsert a table row](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#upsert-a-table-row) |<xref:Microsoft.Xrm.Sdk.Messages.UpsertRequest>|
| `UpsertMultiple`<br />Event: False |<xref:Microsoft.Dynamics.CRM.UpsertMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpsertMultipleRequest>|
| `ValidateRetentionConfig`<br />Event: True |<xref:Microsoft.Dynamics.CRM.ValidateRetentionConfig?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|

## Properties

The following table lists selected properties for the Work List Suggestion (msdyn_worklistsuggestion) table.

|Property|Value|
| --- | --- |
| **DisplayName** | **Work List Suggestion** |
| **DisplayCollectionName** | **Work List Suggestions** |
| **SchemaName** | `msdyn_worklistsuggestion` |
| **CollectionSchemaName** | `msdyn_worklistsuggestions` |
| **EntitySetName** | `msdyn_worklistsuggestions`|
| **LogicalName** | `msdyn_worklistsuggestion` |
| **LogicalCollectionName** | `msdyn_worklistsuggestions` |
| **PrimaryIdAttribute** | `msdyn_worklistsuggestionid` |
| **PrimaryNameAttribute** |`msdyn_name` |
| **TableType** | `Virtual` |
| **OwnershipType** | `OrganizationOwned` |

## Writable columns/attributes

These columns/attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [msdyn_accessrightsmask](#BKMK_msdyn_accessrightsmask)
- [msdyn_customdata](#BKMK_msdyn_customdata)
- [msdyn_name](#BKMK_msdyn_name)
- [msdyn_potentialrevenue](#BKMK_msdyn_potentialrevenue)
- [msdyn_relatedcustomdata](#BKMK_msdyn_relatedcustomdata)
- [msdyn_relatedinsights](#BKMK_msdyn_relatedinsights)
- [msdyn_relatedrecordid](#BKMK_msdyn_relatedrecordid)
- [msdyn_relatedrecordname](#BKMK_msdyn_relatedrecordname)
- [msdyn_relatedrecordtype](#BKMK_msdyn_relatedrecordtype)
- [msdyn_salesmotion](#BKMK_msdyn_salesmotion)
- [msdyn_salesplay](#BKMK_msdyn_salesplay)
- [msdyn_solutionarea](#BKMK_msdyn_solutionarea)
- [msdyn_suggesteddate](#BKMK_msdyn_suggesteddate)
- [msdyn_worklistsuggestionId](#BKMK_msdyn_worklistsuggestionId)

### <a name="BKMK_msdyn_accessrightsmask"></a> msdyn_accessrightsmask

|Property|Value|
|---|---|
|Description|**User access right value**|
|DisplayName|**msdyn_accessrightsmask**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_accessrightsmask`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdyn_customdata"></a> msdyn_customdata

|Property|Value|
|---|---|
|Description|**Custom Data**|
|DisplayName|**Custom Data**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_customdata`|
|RequiredLevel|None|
|Type|Memo|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|1000000|

### <a name="BKMK_msdyn_name"></a> msdyn_name

|Property|Value|
|---|---|
|Description|**The name of the custom entity**|
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

### <a name="BKMK_msdyn_potentialrevenue"></a> msdyn_potentialrevenue

|Property|Value|
|---|---|
|Description|**Potential Revenue Returns**|
|DisplayName|**Potential Revenue Returns**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_potentialrevenue`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|1000|

### <a name="BKMK_msdyn_relatedcustomdata"></a> msdyn_relatedcustomdata

|Property|Value|
|---|---|
|Description|**Related Custom Data**|
|DisplayName|**Related Custom Data**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_relatedcustomdata`|
|RequiredLevel|None|
|Type|Memo|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|1000000|

### <a name="BKMK_msdyn_relatedinsights"></a> msdyn_relatedinsights

|Property|Value|
|---|---|
|Description|**Related Insights Custom Data**|
|DisplayName|**Related Insights Custom Data**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_relatedinsights`|
|RequiredLevel|None|
|Type|Memo|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|1000000|

### <a name="BKMK_msdyn_relatedrecordid"></a> msdyn_relatedrecordid

|Property|Value|
|---|---|
|Description|**Related record for Suggestion**|
|DisplayName|**Related record for Suggestion**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_relatedrecordid`|
|RequiredLevel|None|
|Type|Uniqueidentifier|

### <a name="BKMK_msdyn_relatedrecordname"></a> msdyn_relatedrecordname

|Property|Value|
|---|---|
|Description|**Related Record Name**|
|DisplayName|**Related Record Name**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_relatedrecordname`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|1000|

### <a name="BKMK_msdyn_relatedrecordtype"></a> msdyn_relatedrecordtype

|Property|Value|
|---|---|
|Description|**Related Record Name**|
|DisplayName|**Related Record Type**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_relatedrecordtype`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdyn_salesmotion"></a> msdyn_salesmotion

|Property|Value|
|---|---|
|Description||
|DisplayName|**Sales motion**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_salesmotion`|
|RequiredLevel|None|
|Type|Picklist|
|DefaultFormValue|-1|
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
|DefaultFormValue|-1|
|GlobalChoiceName|`msdyn_salesplay_type`|

#### msdyn_salesplay Choices/Options

|Value|Label|
|---|---|
|1|**Default**|

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
|DefaultFormValue|-1|
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

### <a name="BKMK_msdyn_worklistsuggestionId"></a> msdyn_worklistsuggestionId

|Property|Value|
|---|---|
|Description|**Unique identifier for entity instances**|
|DisplayName|**worklistsuggestion**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`msdyn_worklistsuggestionid`|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|


## Read-only columns/attributes

These columns/attributes return false for both **IsValidForCreate** and **IsValidForUpdate**. Listed by **SchemaName**.

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
|Targets||



### See also

[Dataverse table/entity reference](/power-apps/developer/data-platform/reference/about-entity-reference)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   

