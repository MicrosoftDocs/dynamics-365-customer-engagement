---
title: "Suggested Activity (msdyn_suggestedactivity) table/entity reference (Microsoft Dynamics 365)"
description: "Includes schema information and supported messages for the Suggested Activity (msdyn_suggestedactivity) table/entity with Microsoft Dynamics 365."
ms.topic: generated-reference
author: JimDaly
ms.author: jdaly
search.audienceType: 
  - developer
---

# Suggested Activity (msdyn_suggestedactivity) table/entity reference (Microsoft Dynamics 365)

Activity suggestions

## Messages

The following table lists the messages for the Suggested Activity (msdyn_suggestedactivity) table.
Messages represent operations that can be performed on the table. They may also be events.

| Name <br />Is Event? |Web API Operation |SDK for .NET |
| ---- | ----- |----- |
| `BulkRetain`<br />Event: True |<xref:Microsoft.Dynamics.CRM.BulkRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Create`<br />Event: True |`POST` /msdyn_suggestedactivities<br />See [Create](/powerapps/developer/data-platform/webapi/create-entity-web-api) |[Create records](/power-apps/developer/data-platform/org-service/entity-operations-create#basic-create)|
| `CreateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.CreateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.CreateMultipleRequest>|
| `Delete`<br />Event: True |`DELETE` /msdyn_suggestedactivities(*msdyn_suggestedactivityid*)<br />See [Delete](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-delete) |[Delete records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-delete)|
| `PurgeRetainedContent`<br />Event: True |<xref:Microsoft.Dynamics.CRM.PurgeRetainedContent?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retain`<br />Event: True |<xref:Microsoft.Dynamics.CRM.Retain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retrieve`<br />Event: True |`GET` /msdyn_suggestedactivities(*msdyn_suggestedactivityid*)<br />See [Retrieve](/powerapps/developer/data-platform/webapi/retrieve-entity-using-web-api) |[Retrieve records](/power-apps/developer/data-platform/org-service/entity-operations-retrieve)|
| `RetrieveEntityChanges`<br />Event: True | |<xref:Microsoft.Xrm.Sdk.Messages.RetrieveEntityChangesRequest>|
| `RetrieveMultiple`<br />Event: True |`GET` /msdyn_suggestedactivities<br />See [Query data](/power-apps/developer/data-platform/webapi/query-data-web-api) |[Query data](/power-apps/developer/data-platform/org-service/entity-operations-query-data)|
| `RollbackRetain`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RollbackRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Update`<br />Event: True |`PATCH` /msdyn_suggestedactivities(*msdyn_suggestedactivityid*)<br />See [Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) |[Update records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-update)|
| `UpdateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.UpdateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpdateMultipleRequest>|
| `Upsert`<br />Event: False |`PATCH` /msdyn_suggestedactivities(*msdyn_suggestedactivityid*)<br />See [Upsert a table row](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#upsert-a-table-row) |<xref:Microsoft.Xrm.Sdk.Messages.UpsertRequest>|
| `UpsertMultiple`<br />Event: False |<xref:Microsoft.Dynamics.CRM.UpsertMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpsertMultipleRequest>|
| `ValidateRetentionConfig`<br />Event: True |<xref:Microsoft.Dynamics.CRM.ValidateRetentionConfig?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|

## Properties

The following table lists selected properties for the Suggested Activity (msdyn_suggestedactivity) table.

|Property|Value|
| --- | --- |
| **DisplayName** | **Suggested Activity** |
| **DisplayCollectionName** | **Activity Suggestions** |
| **SchemaName** | `msdyn_suggestedactivity` |
| **CollectionSchemaName** | `msdyn_suggestedactivities` |
| **EntitySetName** | `msdyn_suggestedactivities`|
| **LogicalName** | `msdyn_suggestedactivity` |
| **LogicalCollectionName** | `msdyn_suggestedactivities` |
| **PrimaryIdAttribute** | `msdyn_suggestedactivityid` |
| **PrimaryNameAttribute** |`msdyn_subject` |
| **TableType** | `Virtual` |
| **OwnershipType** | `OrganizationOwned` |

## Writable columns/attributes

These columns/attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [msdyn_ActivityType](#BKMK_msdyn_ActivityType)
- [msdyn_BodyPreview](#BKMK_msdyn_BodyPreview)
- [msdyn_createddate](#BKMK_msdyn_createddate)
- [msdyn_duration](#BKMK_msdyn_duration)
- [msdyn_endtime](#BKMK_msdyn_endtime)
- [msdyn_exchangeweblink](#BKMK_msdyn_exchangeweblink)
- [msdyn_Importance](#BKMK_msdyn_Importance)
- [msdyn_location](#BKMK_msdyn_location)
- [msdyn_regardingid](#BKMK_msdyn_regardingid)
- [msdyn_regardingname](#BKMK_msdyn_regardingname)
- [msdyn_sender](#BKMK_msdyn_sender)
- [msdyn_sendername](#BKMK_msdyn_sendername)
- [msdyn_starttime](#BKMK_msdyn_starttime)
- [msdyn_Subject](#BKMK_msdyn_Subject)
- [msdyn_suggestedactivityId](#BKMK_msdyn_suggestedactivityId)
- [msdyn_to](#BKMK_msdyn_to)

### <a name="BKMK_msdyn_ActivityType"></a> msdyn_ActivityType

|Property|Value|
|---|---|
|Description|**Activity**|
|DisplayName|**Activity**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_activitytype`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdyn_BodyPreview"></a> msdyn_BodyPreview

|Property|Value|
|---|---|
|Description|**BodyPreview**|
|DisplayName|**BodyPreview**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_bodypreview`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|300|

### <a name="BKMK_msdyn_createddate"></a> msdyn_createddate

|Property|Value|
|---|---|
|Description|**Created Date**|
|DisplayName|**Created Date**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_createddate`|
|RequiredLevel|None|
|Type|DateTime|
|CanChangeDateTimeBehavior|False|
|DateTimeBehavior|UserLocal|
|Format|DateAndTime|
|ImeMode|Auto|
|SourceTypeMask|0|

### <a name="BKMK_msdyn_duration"></a> msdyn_duration

|Property|Value|
|---|---|
|Description|**Duration**|
|DisplayName|**Duration**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_duration`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|300|

### <a name="BKMK_msdyn_endtime"></a> msdyn_endtime

|Property|Value|
|---|---|
|Description|**End Time**|
|DisplayName|**End Time**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_endtime`|
|RequiredLevel|None|
|Type|DateTime|
|CanChangeDateTimeBehavior|False|
|DateTimeBehavior|UserLocal|
|Format|DateAndTime|
|ImeMode|Auto|
|SourceTypeMask|0|

### <a name="BKMK_msdyn_exchangeweblink"></a> msdyn_exchangeweblink

|Property|Value|
|---|---|
|Description|**Exchange web link**|
|DisplayName|**Exchange web link**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_exchangeweblink`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdyn_Importance"></a> msdyn_Importance

|Property|Value|
|---|---|
|Description|**Importance**|
|DisplayName|**Importance**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_importance`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdyn_location"></a> msdyn_location

|Property|Value|
|---|---|
|Description|**Location**|
|DisplayName|**Location**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_location`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|300|

### <a name="BKMK_msdyn_regardingid"></a> msdyn_regardingid

|Property|Value|
|---|---|
|Description|**Regarding**|
|DisplayName|**Regarding**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_regardingid`|
|RequiredLevel|None|
|Type|Lookup|
|Targets||

### <a name="BKMK_msdyn_regardingname"></a> msdyn_regardingname

|Property|Value|
|---|---|
|Description|**Regarding Entity**|
|DisplayName|**Regarding Entity**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_regardingname`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdyn_sender"></a> msdyn_sender

|Property|Value|
|---|---|
|Description|**Sender**|
|DisplayName|**Sender**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_sender`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdyn_sendername"></a> msdyn_sendername

|Property|Value|
|---|---|
|Description|**Sender's Name**|
|DisplayName|**Sender's Name**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_sendername`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdyn_starttime"></a> msdyn_starttime

|Property|Value|
|---|---|
|Description|**Start Time**|
|DisplayName|**Start Time**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_starttime`|
|RequiredLevel|None|
|Type|DateTime|
|CanChangeDateTimeBehavior|False|
|DateTimeBehavior|UserLocal|
|Format|DateAndTime|
|ImeMode|Auto|
|SourceTypeMask|0|

### <a name="BKMK_msdyn_Subject"></a> msdyn_Subject

|Property|Value|
|---|---|
|Description|**Subject**|
|DisplayName|**Subject**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_subject`|
|RequiredLevel|ApplicationRequired|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|300|

### <a name="BKMK_msdyn_suggestedactivityId"></a> msdyn_suggestedactivityId

|Property|Value|
|---|---|
|Description|**Unique identifier for entity instances**|
|DisplayName|**Suggested Activity**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`msdyn_suggestedactivityid`|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|

### <a name="BKMK_msdyn_to"></a> msdyn_to

|Property|Value|
|---|---|
|Description|**To**|
|DisplayName|**To**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_to`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|300|




### See also

[Dataverse table/entity reference](/power-apps/developer/data-platform/reference/about-entity-reference)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   

