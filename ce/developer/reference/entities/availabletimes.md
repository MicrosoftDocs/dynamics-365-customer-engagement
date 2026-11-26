---
title: "Available Times (availabletimes) table/entity reference (Microsoft Dynamics 365)"
description: "Includes schema information and supported messages for the Available Times (availabletimes) table/entity with Microsoft Dynamics 365."
ms.topic: generated-reference
author: JimDaly
ms.author: jdaly
search.audienceType: 
  - developer
---

# Available Times (availabletimes) table/entity reference (Microsoft Dynamics 365)



## Messages

The following table lists the messages for the Available Times (availabletimes) table.
Messages represent operations that can be performed on the table. They may also be events.

| Name <br />Is Event? |Web API Operation |SDK for .NET |
| ---- | ----- |----- |
| `BulkRetain`<br />Event: True |<xref:Microsoft.Dynamics.CRM.BulkRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Create`<br />Event: True |`POST` /availabletimescollection<br />See [Create](/powerapps/developer/data-platform/webapi/create-entity-web-api) |[Create records](/power-apps/developer/data-platform/org-service/entity-operations-create#basic-create)|
| `CreateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.CreateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.CreateMultipleRequest>|
| `Delete`<br />Event: True |`DELETE` /availabletimescollection(*availabletimesid*)<br />See [Delete](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-delete) |[Delete records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-delete)|
| `PurgeRetainedContent`<br />Event: True |<xref:Microsoft.Dynamics.CRM.PurgeRetainedContent?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retain`<br />Event: True |<xref:Microsoft.Dynamics.CRM.Retain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retrieve`<br />Event: True |`GET` /availabletimescollection(*availabletimesid*)<br />See [Retrieve](/powerapps/developer/data-platform/webapi/retrieve-entity-using-web-api) |[Retrieve records](/power-apps/developer/data-platform/org-service/entity-operations-retrieve)|
| `RetrieveEntityChanges`<br />Event: True | |<xref:Microsoft.Xrm.Sdk.Messages.RetrieveEntityChangesRequest>|
| `RetrieveMultiple`<br />Event: True |`GET` /availabletimescollection<br />See [Query data](/power-apps/developer/data-platform/webapi/query-data-web-api) |[Query data](/power-apps/developer/data-platform/org-service/entity-operations-query-data)|
| `RollbackRetain`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RollbackRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Update`<br />Event: True |`PATCH` /availabletimescollection(*availabletimesid*)<br />See [Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) |[Update records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-update)|
| `UpdateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.UpdateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpdateMultipleRequest>|
| `Upsert`<br />Event: False |`PATCH` /availabletimescollection(*availabletimesid*)<br />See [Upsert a table row](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#upsert-a-table-row) |<xref:Microsoft.Xrm.Sdk.Messages.UpsertRequest>|
| `UpsertMultiple`<br />Event: False |<xref:Microsoft.Dynamics.CRM.UpsertMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpsertMultipleRequest>|
| `ValidateRetentionConfig`<br />Event: True |<xref:Microsoft.Dynamics.CRM.ValidateRetentionConfig?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|

## Properties

The following table lists selected properties for the Available Times (availabletimes) table.

|Property|Value|
| --- | --- |
| **DisplayName** | **Available Times** |
| **DisplayCollectionName** | **Available Times Collection** |
| **SchemaName** | `availabletimes` |
| **CollectionSchemaName** | `availabletimeses` |
| **EntitySetName** | `availabletimescollection`|
| **LogicalName** | `availabletimes` |
| **LogicalCollectionName** | `availabletimeses` |
| **PrimaryIdAttribute** | `availabletimesid` |
| **PrimaryNameAttribute** |`name` |
| **TableType** | `Virtual` |
| **OwnershipType** | `OrganizationOwned` |

## Writable columns/attributes

These columns/attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [availabletimesId](#BKMK_availabletimesId)
- [Name](#BKMK_Name)
- [Resources](#BKMK_Resources)
- [ResourcesJson](#BKMK_ResourcesJson)
- [ScheduledEnd](#BKMK_ScheduledEnd)
- [ScheduledEndLocalTime](#BKMK_ScheduledEndLocalTime)
- [ScheduledStart](#BKMK_ScheduledStart)
- [ScheduledStartLocalTime](#BKMK_ScheduledStartLocalTime)
- [Site](#BKMK_Site)
- [SiteId](#BKMK_SiteId)

### <a name="BKMK_availabletimesId"></a> availabletimesId

|Property|Value|
|---|---|
|Description|**Unique identifier for entity instances**|
|DisplayName|**AvailableTimes**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`availabletimesid`|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|

### <a name="BKMK_Name"></a> Name

|Property|Value|
|---|---|
|Description|**The name of the available times virtual entity.**|
|DisplayName|**Name**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`name`|
|RequiredLevel|ApplicationRequired|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_Resources"></a> Resources

|Property|Value|
|---|---|
|Description||
|DisplayName|**Resources**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`resources`|
|RequiredLevel|None|
|Type|Memo|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|2000|

### <a name="BKMK_ResourcesJson"></a> ResourcesJson

|Property|Value|
|---|---|
|Description||
|DisplayName|**Resources IDs**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`resourcesJson`|
|RequiredLevel|None|
|Type|Memo|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|2000|

### <a name="BKMK_ScheduledEnd"></a> ScheduledEnd

|Property|Value|
|---|---|
|Description||
|DisplayName|**Scheduled End UTC time**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`scheduledend`|
|RequiredLevel|None|
|Type|DateTime|
|CanChangeDateTimeBehavior|False|
|DateTimeBehavior|UserLocal|
|Format|DateAndTime|
|ImeMode|Auto|
|SourceTypeMask|0|

### <a name="BKMK_ScheduledEndLocalTime"></a> ScheduledEndLocalTime

|Property|Value|
|---|---|
|Description|**Scheduled End Local Time**|
|DisplayName|**Scheduled End**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`scheduledendlocaltime`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|4000|

### <a name="BKMK_ScheduledStart"></a> ScheduledStart

|Property|Value|
|---|---|
|Description||
|DisplayName|**Scheduled Start UTC time**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`scheduledstart`|
|RequiredLevel|None|
|Type|DateTime|
|CanChangeDateTimeBehavior|False|
|DateTimeBehavior|UserLocal|
|Format|DateAndTime|
|ImeMode|Auto|
|SourceTypeMask|0|

### <a name="BKMK_ScheduledStartLocalTime"></a> ScheduledStartLocalTime

|Property|Value|
|---|---|
|Description|**Scheduled Start Local Time**|
|DisplayName|**Scheduled Start**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`scheduledstartlocaltime`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|4000|

### <a name="BKMK_Site"></a> Site

|Property|Value|
|---|---|
|Description|**Site**|
|DisplayName|**Site**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`site`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|4000|

### <a name="BKMK_SiteId"></a> SiteId

|Property|Value|
|---|---|
|Description|**Site Identifier**|
|DisplayName|**Site Identifier**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`siteid`|
|RequiredLevel|None|
|Type|Uniqueidentifier|




### See also

[Dataverse table/entity reference](/power-apps/developer/data-platform/reference/about-entity-reference)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   

