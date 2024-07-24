---
title: "Segment (msdynmkt_virtualsegment) table/entity reference (Microsoft Dynamics 365 Field Service)"
description: "Includes schema information and supported messages for the Segment (msdynmkt_virtualsegment) table/entity with Microsoft Dynamics 365 Field Service."
ms.date: 07.24.2024
ms.service: powerapps
ms.topic: reference
author: m-hartmann
ms.author: mhart
search.audienceType: 
  - developer
---

# Segment (msdynmkt_virtualsegment) table/entity reference



## Messages

The following table lists the messages for the Segment (msdynmkt_virtualsegment) table.
Messages represent operations that can be performed on the table. They may also be events.

| Name <br />Is Event? |Web API Operation |SDK for .NET |
| ---- | ----- |----- |
| `Create`<br />Event: True |`POST` /msdynmkt_virtualsegments<br />See [Create](/powerapps/developer/data-platform/webapi/create-entity-web-api) |[Create records](/power-apps/developer/data-platform/org-service/entity-operations-create#basic-create)|
| `CreateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.CreateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.CreateMultipleRequest>|
| `Delete`<br />Event: True |`DELETE` /msdynmkt_virtualsegments(*msdynmkt_virtualsegmentid*)<br />See [Delete](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-delete) |[Delete records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-delete)|
| `Retrieve`<br />Event: True |`GET` /msdynmkt_virtualsegments(*msdynmkt_virtualsegmentid*)<br />See [Retrieve](/powerapps/developer/data-platform/webapi/retrieve-entity-using-web-api) |[Retrieve records](/power-apps/developer/data-platform/org-service/entity-operations-retrieve)|
| `RetrieveEntityChanges`<br />Event: True | |<xref:Microsoft.Xrm.Sdk.Messages.RetrieveEntityChangesRequest>|
| `RetrieveMultiple`<br />Event: True |`GET` /msdynmkt_virtualsegments<br />See [Query data](/power-apps/developer/data-platform/webapi/query-data-web-api) |[Query data](/power-apps/developer/data-platform/org-service/entity-operations-query-data)|
| `Update`<br />Event: True |`PATCH` /msdynmkt_virtualsegments(*msdynmkt_virtualsegmentid*)<br />See [Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) |[Update records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-update)|
| `UpdateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.UpdateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpdateMultipleRequest>|
| `Upsert`<br />Event: False |`PATCH` /msdynmkt_virtualsegments(*msdynmkt_virtualsegmentid*)<br />See [Upsert a table row](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#upsert-a-table-row) |<xref:Microsoft.Xrm.Sdk.Messages.UpsertRequest>|
| `UpsertMultiple`<br />Event: False |<xref:Microsoft.Dynamics.CRM.UpsertMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpsertMultipleRequest>|


## Events

The following table lists the events for the Segment (msdynmkt_virtualsegment) table.
Events are messages that exist so that you can subscribe to them. Unless you added the event, you shouldn't invoke the message, only subscribe to it.

|Name|Web API Operation |SDK for .NET |
| ---- | ----- |----- |
| `BulkRetain`|<xref:Microsoft.Dynamics.CRM.BulkRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `PurgeRetainedContent`|<xref:Microsoft.Dynamics.CRM.PurgeRetainedContent?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retain`|<xref:Microsoft.Dynamics.CRM.Retain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `RollbackRetain`|<xref:Microsoft.Dynamics.CRM.RollbackRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `ValidateRetentionConfig`|<xref:Microsoft.Dynamics.CRM.ValidateRetentionConfig?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|

## Properties

The following table lists selected properties for the Segment (msdynmkt_virtualsegment) table.

|Property|Value|
| --- | --- |
| **DisplayName** | **Segment** |
| **DisplayCollectionName** | **Segments** |
| **SchemaName** | `msdynmkt_virtualsegment` |
| **CollectionSchemaName** | `msdynmkt_virtualsegments` |
| **EntitySetName** | `msdynmkt_virtualsegments`|
| **LogicalName** | `msdynmkt_virtualsegment` |
| **LogicalCollectionName** | `msdynmkt_virtualsegments` |
| **PrimaryIdAttribute** | `msdynmkt_virtualsegmentid` |
| **PrimaryNameAttribute** |`msdynmkt_name` |
| **TableType** | `Virtual` |
| **OwnershipType** | `OrganizationOwned` |

## Writable columns/attributes

These columns/attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [msdynmkt_baseentity](#BKMK_msdynmkt_baseentity)
- [msdynmkt_createdby](#BKMK_msdynmkt_createdby)
- [msdynmkt_createddate](#BKMK_msdynmkt_createddate)
- [msdynmkt_description](#BKMK_msdynmkt_description)
- [msdynmkt_lastupdated](#BKMK_msdynmkt_lastupdated)
- [msdynmkt_lastused](#BKMK_msdynmkt_lastused)
- [msdynmkt_membercount](#BKMK_msdynmkt_membercount)
- [msdynmkt_name](#BKMK_msdynmkt_name)
- [msdynmkt_owningbusinessunit](#BKMK_msdynmkt_owningbusinessunit)
- [msdynmkt_publishedjourneycount](#BKMK_msdynmkt_publishedjourneycount)
- [msdynmkt_requiresexport](#BKMK_msdynmkt_requiresexport)
- [msdynmkt_segmentdetails](#BKMK_msdynmkt_segmentdetails)
- [msdynmkt_source](#BKMK_msdynmkt_source)
- [msdynmkt_sourceentity](#BKMK_msdynmkt_sourceentity)
- [msdynmkt_sourceentityid](#BKMK_msdynmkt_sourceentityid)
- [msdynmkt_sourceuri](#BKMK_msdynmkt_sourceuri)
- [msdynmkt_statecode](#BKMK_msdynmkt_statecode)
- [msdynmkt_statuscode](#BKMK_msdynmkt_statuscode)
- [msdynmkt_type](#BKMK_msdynmkt_type)
- [msdynmkt_virtualsegmentId](#BKMK_msdynmkt_virtualsegmentId)

### <a name="BKMK_msdynmkt_baseentity"></a> msdynmkt_baseentity

|Property|Value|
|---|---|
|Description|**The entity supported by this segment.**|
|DisplayName|**Base entity**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdynmkt_baseentity`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdynmkt_createdby"></a> msdynmkt_createdby

|Property|Value|
|---|---|
|Description|**The who created the segment.**|
|DisplayName|**Created by**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdynmkt_createdby`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdynmkt_createddate"></a> msdynmkt_createddate

|Property|Value|
|---|---|
|Description|**The date the segment was created**|
|DisplayName|**Created date**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdynmkt_createddate`|
|RequiredLevel|None|
|Type|DateTime|
|CanChangeDateTimeBehavior|True|
|DateTimeBehavior|UserLocal|
|Format|DateAndTime|
|ImeMode|Auto|
|SourceTypeMask|0|

### <a name="BKMK_msdynmkt_description"></a> msdynmkt_description

|Property|Value|
|---|---|
|Description|**The description of the segment.**|
|DisplayName|**Description**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdynmkt_description`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|1000|

### <a name="BKMK_msdynmkt_lastupdated"></a> msdynmkt_lastupdated

|Property|Value|
|---|---|
|Description||
|DisplayName|**Last update**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdynmkt_lastupdated`|
|RequiredLevel|None|
|Type|DateTime|
|CanChangeDateTimeBehavior|True|
|DateTimeBehavior|UserLocal|
|Format|DateAndTime|
|ImeMode|Auto|
|SourceTypeMask|0|

### <a name="BKMK_msdynmkt_lastused"></a> msdynmkt_lastused

|Property|Value|
|---|---|
|Description||
|DisplayName|**Last used in journey**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdynmkt_lastused`|
|RequiredLevel|None|
|Type|DateTime|
|CanChangeDateTimeBehavior|True|
|DateTimeBehavior|UserLocal|
|Format|DateAndTime|
|ImeMode|Auto|
|SourceTypeMask|0|

### <a name="BKMK_msdynmkt_membercount"></a> msdynmkt_membercount

|Property|Value|
|---|---|
|Description||
|DisplayName|**Members**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdynmkt_membercount`|
|RequiredLevel|None|
|Type|Integer|
|MaxValue|2147483647|
|MinValue|0|

### <a name="BKMK_msdynmkt_name"></a> msdynmkt_name

|Property|Value|
|---|---|
|Description|**The name of the segment.**|
|DisplayName|**Name**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdynmkt_name`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdynmkt_owningbusinessunit"></a> msdynmkt_owningbusinessunit

|Property|Value|
|---|---|
|Description||
|DisplayName|**Business unit**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdynmkt_owningbusinessunit`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|businessunit|

### <a name="BKMK_msdynmkt_publishedjourneycount"></a> msdynmkt_publishedjourneycount

|Property|Value|
|---|---|
|Description||
|DisplayName|**Live journeys**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdynmkt_publishedjourneycount`|
|RequiredLevel|None|
|Type|Integer|
|MaxValue|2147483647|
|MinValue|-2147483648|

### <a name="BKMK_msdynmkt_requiresexport"></a> msdynmkt_requiresexport

|Property|Value|
|---|---|
|Description|**For internal use only.**|
|DisplayName|**Requires export**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdynmkt_requiresexport`|
|RequiredLevel|ApplicationRequired|
|Type|Boolean|
|GlobalChoiceName|`msdynmkt_virtualsegment_msdynmkt_requiresexport`|
|DefaultValue|False|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_msdynmkt_segmentdetails"></a> msdynmkt_segmentdetails

|Property|Value|
|---|---|
|Description|**The segment details for use in the segment lookup.**|
|DisplayName|**Segment details**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdynmkt_segmentdetails`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdynmkt_source"></a> msdynmkt_source

|Property|Value|
|---|---|
|Description|**The source of the segment.**|
|DisplayName|**Source**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdynmkt_source`|
|RequiredLevel|ApplicationRequired|
|Type|Picklist|
|DefaultFormValue|0|
|GlobalChoiceName|`msdynmkt_virtualsegment_msdynmkt_source`|

#### msdynmkt_source Choices/Options

|Value|Label|
|---|---|
|0|**Customer Insights - Data**|
|1|**Dynamics 365 Marketing (outbound)**|
|2|**Customer Insights - Journeys**|

### <a name="BKMK_msdynmkt_sourceentity"></a> msdynmkt_sourceentity

|Property|Value|
|---|---|
|Description|**For internal use only**|
|DisplayName|**Source entity**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdynmkt_sourceentity`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdynmkt_sourceentityid"></a> msdynmkt_sourceentityid

|Property|Value|
|---|---|
|Description|**For internal use only**|
|DisplayName|**Source entity id**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdynmkt_sourceentityid`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdynmkt_sourceuri"></a> msdynmkt_sourceuri

|Property|Value|
|---|---|
|Description|**The source uri of the segment.**|
|DisplayName|**Source Uri**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdynmkt_sourceuri`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|1000|

### <a name="BKMK_msdynmkt_statecode"></a> msdynmkt_statecode

|Property|Value|
|---|---|
|Description|**Status of the Virtual Segment**|
|DisplayName|**Status**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdynmkt_statecode`|
|RequiredLevel|SystemRequired|
|Type|Picklist|
|DefaultFormValue||
|GlobalChoiceName|`msdynmkt_virtualsegment_statecode`|

#### msdynmkt_statecode Choices/Options

|Value|Label|
|---|---|
|0|**Active**|
|1|**Inactive**|

### <a name="BKMK_msdynmkt_statuscode"></a> msdynmkt_statuscode

|Property|Value|
|---|---|
|Description|**Reason for the status of the Virtual Segment**|
|DisplayName|**Status Reason**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdynmkt_statuscode`|
|RequiredLevel|None|
|Type|Picklist|
|DefaultFormValue||
|GlobalChoiceName|`msdynmkt_virtualsegment_statuscode`|

#### msdynmkt_statuscode Choices/Options

|Value|Label|
|---|---|
|0|**Ready to use**|
|1|**Draft**|
|2|**Deactivated**|
|3|**Getting ready**|
|4|**Completed with warnings**|

### <a name="BKMK_msdynmkt_type"></a> msdynmkt_type

|Property|Value|
|---|---|
|Description|**The type of the segment.**|
|DisplayName|**Type**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdynmkt_type`|
|RequiredLevel|ApplicationRequired|
|Type|Picklist|
|DefaultFormValue|0|
|GlobalChoiceName|`msdynmkt_virtualsegment_msdynmkt_type`|

#### msdynmkt_type Choices/Options

|Value|Label|
|---|---|
|0|**Unknown**|
|1|**Static**|
|2|**Dynamic**|
|3|**Compound**|
|4|**Expansion**|

### <a name="BKMK_msdynmkt_virtualsegmentId"></a> msdynmkt_virtualsegmentId

|Property|Value|
|---|---|
|Description|**Unique identifier for entity instances**|
|DisplayName|**Segment**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`msdynmkt_virtualsegmentid`|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|


## Read-only columns/attributes

These columns/attributes return false for both **IsValidForCreate** and **IsValidForUpdate**. Listed by **SchemaName**.

### <a name="BKMK_msdynmkt_lastusedby"></a> msdynmkt_lastusedby

|Property|Value|
|---|---|
|Description|**The name the user who last associated a journey with this segment.**|
|DisplayName|**Last used by**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdynmkt_lastusedby`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|systemuser|

## Many-to-One relationships

These relationships are many-to-one. Listed by **SchemaName**.

- [business_unit_msdynmkt_virtualsegment](#BKMK_business_unit_msdynmkt_virtualsegment)
- [lk_msdynmkt_virtualsegment_msdynmkt_lastusedby](#BKMK_lk_msdynmkt_virtualsegment_msdynmkt_lastusedby)

### <a name="BKMK_business_unit_msdynmkt_virtualsegment"></a> business_unit_msdynmkt_virtualsegment

One-To-Many Relationship: [businessunit business_unit_msdynmkt_virtualsegment](businessunit.md#BKMK_business_unit_msdynmkt_virtualsegment)

|Property|Value|
|---|---|
|ReferencedEntity|`businessunit`|
|ReferencedAttribute|`businessunitid`|
|ReferencingAttribute|`msdynmkt_owningbusinessunit`|
|ReferencingEntityNavigationPropertyName|`msdynmkt_owningbusinessunit`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdynmkt_virtualsegment_msdynmkt_lastusedby"></a> lk_msdynmkt_virtualsegment_msdynmkt_lastusedby

One-To-Many Relationship: [systemuser lk_msdynmkt_virtualsegment_msdynmkt_lastusedby](systemuser.md#BKMK_lk_msdynmkt_virtualsegment_msdynmkt_lastusedby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`msdynmkt_lastusedby`|
|ReferencingEntityNavigationPropertyName|`msdynmkt_lastusedby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|



### See also

[Dataverse table/entity reference](../about-entity-reference.md)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   

