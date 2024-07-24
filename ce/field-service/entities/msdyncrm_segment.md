---
title: "Segment (msdyncrm_segment) table/entity reference (Microsoft Dynamics 365 Field Service)"
description: "Includes schema information and supported messages for the Segment (msdyncrm_segment) table/entity with Microsoft Dynamics 365 Field Service."
ms.date: 07.24.2024
ms.service: powerapps
ms.topic: reference
author: m-hartmann
ms.author: mhart
search.audienceType: 
  - developer
---

# Segment (msdyncrm_segment) table/entity reference



## Messages

The following table lists the messages for the Segment (msdyncrm_segment) table.
Messages represent operations that can be performed on the table. They may also be events.

| Name <br />Is Event? |Web API Operation |SDK for .NET |
| ---- | ----- |----- |
| `Assign`<br />Event: True |`PATCH` /msdyncrm_segments(*msdyncrm_segmentid*)<br />[Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) the `ownerid` property. |<xref:Microsoft.Crm.Sdk.Messages.AssignRequest>|
| `Create`<br />Event: True |`POST` /msdyncrm_segments<br />See [Create](/powerapps/developer/data-platform/webapi/create-entity-web-api) |[Create records](/power-apps/developer/data-platform/org-service/entity-operations-create#basic-create)|
| `CreateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.CreateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.CreateMultipleRequest>|
| `Delete`<br />Event: True |`DELETE` /msdyncrm_segments(*msdyncrm_segmentid*)<br />See [Delete](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-delete) |[Delete records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-delete)|
| `GrantAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.GrantAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.GrantAccessRequest>|
| `IsValidStateTransition`<br />Event: False |<xref:Microsoft.Dynamics.CRM.IsValidStateTransition?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.IsValidStateTransitionRequest>|
| `ModifyAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.ModifyAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.ModifyAccessRequest>|
| `Restore`<br />Event: True |<xref:Microsoft.Dynamics.CRM.Restore?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retrieve`<br />Event: True |`GET` /msdyncrm_segments(*msdyncrm_segmentid*)<br />See [Retrieve](/powerapps/developer/data-platform/webapi/retrieve-entity-using-web-api) |[Retrieve records](/power-apps/developer/data-platform/org-service/entity-operations-retrieve)|
| `RetrieveMultiple`<br />Event: True |`GET` /msdyncrm_segments<br />See [Query data](/power-apps/developer/data-platform/webapi/query-data-web-api) |[Query data](/power-apps/developer/data-platform/org-service/entity-operations-query-data)|
| `RetrievePrincipalAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RetrievePrincipalAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RetrievePrincipalAccessRequest>|
| `RetrieveSharedPrincipalsAndAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RetrieveSharedPrincipalsAndAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RetrieveSharedPrincipalsAndAccessRequest>|
| `RevokeAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RevokeAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RevokeAccessRequest>|
| `SetState`<br />Event: True |`PATCH` /msdyncrm_segments(*msdyncrm_segmentid*)<br />[Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) the `statecode` and `statuscode` properties. |<xref:Microsoft.Crm.Sdk.Messages.SetStateRequest>|
| `Update`<br />Event: True |`PATCH` /msdyncrm_segments(*msdyncrm_segmentid*)<br />See [Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) |[Update records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-update)|
| `UpdateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.UpdateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpdateMultipleRequest>|
| `Upsert`<br />Event: False |`PATCH` /msdyncrm_segments(*msdyncrm_segmentid*)<br />See [Upsert a table row](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#upsert-a-table-row) |<xref:Microsoft.Xrm.Sdk.Messages.UpsertRequest>|
| `UpsertMultiple`<br />Event: False |<xref:Microsoft.Dynamics.CRM.UpsertMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpsertMultipleRequest>|


## Events

The following table lists the events for the Segment (msdyncrm_segment) table.
Events are messages that exist so that you can subscribe to them. Unless you added the event, you shouldn't invoke the message, only subscribe to it.

|Name|Web API Operation |SDK for .NET |
| ---- | ----- |----- |
| `BulkRetain`|<xref:Microsoft.Dynamics.CRM.BulkRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `PurgeRetainedContent`|<xref:Microsoft.Dynamics.CRM.PurgeRetainedContent?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retain`|<xref:Microsoft.Dynamics.CRM.Retain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `RollbackRetain`|<xref:Microsoft.Dynamics.CRM.RollbackRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `ValidateRetentionConfig`|<xref:Microsoft.Dynamics.CRM.ValidateRetentionConfig?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|

## Properties

The following table lists selected properties for the Segment (msdyncrm_segment) table.

|Property|Value|
| --- | --- |
| **DisplayName** | **Segment** |
| **DisplayCollectionName** | **Segments** |
| **SchemaName** | `msdyncrm_segment` |
| **CollectionSchemaName** | `msdyncrm_segments` |
| **EntitySetName** | `msdyncrm_segments`|
| **LogicalName** | `msdyncrm_segment` |
| **LogicalCollectionName** | `msdyncrm_segments` |
| **PrimaryIdAttribute** | `msdyncrm_segmentid` |
| **PrimaryNameAttribute** |`msdyncrm_segmentname` |
| **TableType** | `Standard` |
| **OwnershipType** | `UserOwned` |

## Writable columns/attributes

These columns/attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [ImportSequenceNumber](#BKMK_ImportSequenceNumber)
- [msdyncrm_description](#BKMK_msdyncrm_description)
- [msdyncrm_externalsegmenturl](#BKMK_msdyncrm_externalsegmenturl)
- [msdyncrm_externalsource](#BKMK_msdyncrm_externalsource)
- [msdyncrm_islive](#BKMK_msdyncrm_islive)
- [msdyncrm_lastevaluationtime](#BKMK_msdyncrm_lastevaluationtime)
- [msdyncrm_lastupdatedtime](#BKMK_msdyncrm_lastupdatedtime)
- [msdyncrm_nextevaluation](#BKMK_msdyncrm_nextevaluation)
- [msdyncrm_querytype](#BKMK_msdyncrm_querytype)
- [msdyncrm_scope](#BKMK_msdyncrm_scope)
- [msdyncrm_segmentactivationstatus](#BKMK_msdyncrm_segmentactivationstatus)
- [msdyncrm_segmentevaluationdurationinminutes](#BKMK_msdyncrm_segmentevaluationdurationinminutes)
- [msdyncrm_segmentevaluationstate](#BKMK_msdyncrm_segmentevaluationstate)
- [msdyncrm_segmentevaluationtype](#BKMK_msdyncrm_segmentevaluationtype)
- [msdyncrm_segmentfilterquery](#BKMK_msdyncrm_segmentfilterquery)
- [msdyncrm_segmentId](#BKMK_msdyncrm_segmentId)
- [msdyncrm_segmentmemberids](#BKMK_msdyncrm_segmentmemberids)
- [msdyncrm_segmentname](#BKMK_msdyncrm_segmentname)
- [msdyncrm_segmentprovisioningstate](#BKMK_msdyncrm_segmentprovisioningstate)
- [msdyncrm_segmentquery](#BKMK_msdyncrm_segmentquery)
- [msdyncrm_segmentqueryname](#BKMK_msdyncrm_segmentqueryname)
- [msdyncrm_segmentrefreshrateintervalminutes](#BKMK_msdyncrm_segmentrefreshrateintervalminutes)
- [msdyncrm_segmentsize](#BKMK_msdyncrm_segmentsize)
- [msdyncrm_segmenttargetprofiletypename](#BKMK_msdyncrm_segmenttargetprofiletypename)
- [msdyncrm_SegmentTemplate](#BKMK_msdyncrm_SegmentTemplate)
- [msdyncrm_segmenttimezone](#BKMK_msdyncrm_segmenttimezone)
- [msdyncrm_segmenttype](#BKMK_msdyncrm_segmenttype)
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
|Description|**Sequence number of the import that created this record**|
|DisplayName|**Import sequence number**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`importsequencenumber`|
|RequiredLevel|None|
|Type|Integer|
|MaxValue|2147483647|
|MinValue|-2147483648|

### <a name="BKMK_msdyncrm_description"></a> msdyncrm_description

|Property|Value|
|---|---|
|Description|**The segment description**|
|DisplayName|**Description**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyncrm_description`|
|RequiredLevel|Recommended|
|Type|Memo|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|2000|

### <a name="BKMK_msdyncrm_externalsegmenturl"></a> msdyncrm_externalsegmenturl

|Property|Value|
|---|---|
|Description||
|DisplayName|**External Segment URL**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyncrm_externalsegmenturl`|
|RequiredLevel|None|
|Type|String|
|Format|Url|
|FormatName|Url|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|2000|

### <a name="BKMK_msdyncrm_externalsource"></a> msdyncrm_externalsource

|Property|Value|
|---|---|
|Description|**External Source**|
|DisplayName|**External Source**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyncrm_externalsource`|
|RequiredLevel|None|
|Type|Picklist|
|DefaultFormValue|-1|
|GlobalChoiceName|`msdyncrm_segment_msdyncrm_externalsource`|

#### msdyncrm_externalsource Choices/Options

|Value|Label|
|---|---|
|192350000|**Customer Insight**|

### <a name="BKMK_msdyncrm_islive"></a> msdyncrm_islive

|Property|Value|
|---|---|
|Description|**flag to check that the segment is live**|
|DisplayName|**flag to check that the segment is live**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyncrm_islive`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`msdyncrm_islive`|
|DefaultValue|False|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_msdyncrm_lastevaluationtime"></a> msdyncrm_lastevaluationtime

|Property|Value|
|---|---|
|Description|**Last date and time when the segment was evaluated.**|
|DisplayName|**Last Evaluation Time**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyncrm_lastevaluationtime`|
|RequiredLevel|None|
|Type|DateTime|
|CanChangeDateTimeBehavior|False|
|DateTimeBehavior|UserLocal|
|Format|DateAndTime|
|ImeMode|Auto|
|SourceTypeMask|0|

### <a name="BKMK_msdyncrm_lastupdatedtime"></a> msdyncrm_lastupdatedtime

|Property|Value|
|---|---|
|Description|**Last date and time when the segment was updated.**|
|DisplayName|**Last Updated Time**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyncrm_lastupdatedtime`|
|RequiredLevel|None|
|Type|DateTime|
|CanChangeDateTimeBehavior|False|
|DateTimeBehavior|UserLocal|
|Format|DateAndTime|
|ImeMode|Auto|
|SourceTypeMask|0|

### <a name="BKMK_msdyncrm_nextevaluation"></a> msdyncrm_nextevaluation

|Property|Value|
|---|---|
|Description|**Next time we expect the segment to be evaluated.**|
|DisplayName|**Next Expected Evaluation Time**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyncrm_nextevaluation`|
|RequiredLevel|None|
|Type|DateTime|
|CanChangeDateTimeBehavior|False|
|DateTimeBehavior|UserLocal|
|Format|DateAndTime|
|ImeMode|Auto|
|SourceTypeMask|0|

### <a name="BKMK_msdyncrm_querytype"></a> msdyncrm_querytype

|Property|Value|
|---|---|
|Description|**Query type**|
|DisplayName|**Query type**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyncrm_querytype`|
|RequiredLevel|None|
|Type|Picklist|
|DefaultFormValue|-1|
|GlobalChoiceName|`msdyncrm_segment_msdyncrm_querytype`|

#### msdyncrm_querytype Choices/Options

|Value|Label|
|---|---|
|192350000|**Interaction based**|
|192350001|**Profile based**|

### <a name="BKMK_msdyncrm_scope"></a> msdyncrm_scope

|Property|Value|
|---|---|
|Description|**Business-unit scope for selecting segment members**|
|DisplayName|**Scope**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyncrm_scope`|
|RequiredLevel|None|
|Type|Picklist|
|DefaultFormValue|270100000|
|GlobalChoiceName|`msdyncrm_processscope`|

#### msdyncrm_scope Choices/Options

|Value|Label|
|---|---|
|270100000|**Organization**|
|270100001|**Business unit**|

### <a name="BKMK_msdyncrm_segmentactivationstatus"></a> msdyncrm_segmentactivationstatus

|Property|Value|
|---|---|
|Description||
|DisplayName|**Activation status**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyncrm_segmentactivationstatus`|
|RequiredLevel|ApplicationRequired|
|Type|Picklist|
|DefaultFormValue|192350000|
|GlobalChoiceName|`msdyncrm_segment_msdyncrm_segmentactivationstatus`|

#### msdyncrm_segmentactivationstatus Choices/Options

|Value|Label|
|---|---|
|192350000|**Active**|
|192350001|**Disabled**|

### <a name="BKMK_msdyncrm_segmentevaluationdurationinminutes"></a> msdyncrm_segmentevaluationdurationinminutes

|Property|Value|
|---|---|
|Description|**Evaluation duration in minutes.**|
|DisplayName|**Evaluation Duration**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyncrm_segmentevaluationdurationinminutes`|
|RequiredLevel|None|
|Type|Integer|
|MaxValue|2147483647|
|MinValue|0|

### <a name="BKMK_msdyncrm_segmentevaluationstate"></a> msdyncrm_segmentevaluationstate

|Property|Value|
|---|---|
|Description|**State of segment evaluation.**|
|DisplayName|**Evaluation State**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyncrm_segmentevaluationstate`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdyncrm_segmentevaluationtype"></a> msdyncrm_segmentevaluationtype

|Property|Value|
|---|---|
|Description|**Type of segment evaluation.**|
|DisplayName|**Evaluation Type**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyncrm_segmentevaluationtype`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdyncrm_segmentfilterquery"></a> msdyncrm_segmentfilterquery

|Property|Value|
|---|---|
|Description|**Filter query of a static segment**|
|DisplayName|**Filter query**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyncrm_segmentfilterquery`|
|RequiredLevel|None|
|Type|Memo|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|4000|

### <a name="BKMK_msdyncrm_segmentId"></a> msdyncrm_segmentId

|Property|Value|
|---|---|
|Description|**Unique ID for entity instances**|
|DisplayName|**Segment**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`msdyncrm_segmentid`|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|

### <a name="BKMK_msdyncrm_segmentmemberids"></a> msdyncrm_segmentmemberids

|Property|Value|
|---|---|
|Description|**Static segment member IDs**|
|DisplayName|**Member IDs**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyncrm_segmentmemberids`|
|RequiredLevel|None|
|Type|Memo|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|1000000|

### <a name="BKMK_msdyncrm_segmentname"></a> msdyncrm_segmentname

|Property|Value|
|---|---|
|Description|**The name of the custom entity**|
|DisplayName|**Name**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyncrm_segmentname`|
|RequiredLevel|ApplicationRequired|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdyncrm_segmentprovisioningstate"></a> msdyncrm_segmentprovisioningstate

|Property|Value|
|---|---|
|Description||
|DisplayName|**Provisioning state**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyncrm_segmentprovisioningstate`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdyncrm_segmentquery"></a> msdyncrm_segmentquery

|Property|Value|
|---|---|
|Description|**The segment query definition**|
|DisplayName|**Query definition**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyncrm_segmentquery`|
|RequiredLevel|None|
|Type|Memo|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|4000|

### <a name="BKMK_msdyncrm_segmentqueryname"></a> msdyncrm_segmentqueryname

|Property|Value|
|---|---|
|Description|**The display name of the custom entity.**|
|DisplayName|**Name**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyncrm_segmentqueryname`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdyncrm_segmentrefreshrateintervalminutes"></a> msdyncrm_segmentrefreshrateintervalminutes

|Property|Value|
|---|---|
|Description|**Segment refresh rate in minutes.**|
|DisplayName|**Refresh Rate**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyncrm_segmentrefreshrateintervalminutes`|
|RequiredLevel|None|
|Type|Integer|
|MaxValue|2147483647|
|MinValue|0|

### <a name="BKMK_msdyncrm_segmentsize"></a> msdyncrm_segmentsize

|Property|Value|
|---|---|
|Description|**The number of members in the segment**|
|DisplayName|**Members**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyncrm_segmentsize`|
|RequiredLevel|None|
|Type|Integer|
|MaxValue|2147483647|
|MinValue|0|

### <a name="BKMK_msdyncrm_segmenttargetprofiletypename"></a> msdyncrm_segmenttargetprofiletypename

|Property|Value|
|---|---|
|Description|**Target profile type of segment's members.**|
|DisplayName|**Target Profile Type**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyncrm_segmenttargetprofiletypename`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|1000|

### <a name="BKMK_msdyncrm_SegmentTemplate"></a> msdyncrm_SegmentTemplate

|Property|Value|
|---|---|
|Description|**The template used to create the initial layout of the segment.**|
|DisplayName|**Segment Template**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyncrm_segmenttemplate`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|msdyncrm_segmenttemplate|

### <a name="BKMK_msdyncrm_segmenttimezone"></a> msdyncrm_segmenttimezone

|Property|Value|
|---|---|
|Description|**Effective time zone for this segment**|
|DisplayName|**Time Zone**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyncrm_segmenttimezone`|
|RequiredLevel|None|
|Type|Integer|
|MaxValue|1500|
|MinValue|-1500|

### <a name="BKMK_msdyncrm_segmenttype"></a> msdyncrm_segmenttype

|Property|Value|
|---|---|
|Description|**Segment type**|
|DisplayName|**Segment type**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyncrm_segmenttype`|
|RequiredLevel|ApplicationRequired|
|Type|Picklist|
|DefaultFormValue|192350000|
|GlobalChoiceName|`msdyncrm_segment_msdyncrm_segmenttype`|

#### msdyncrm_segmenttype Choices/Options

|Value|Label|
|---|---|
|192350000|**Dynamic segment**|
|192350001|**Static segment**|
|192350002|**Compound segment**|

### <a name="BKMK_OverriddenCreatedOn"></a> OverriddenCreatedOn

|Property|Value|
|---|---|
|Description|**Date and time that the record was migrated**|
|DisplayName|**Record created on**|
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
|Description|**Owner ID**|
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
|Description|**Status of the segment**|
|DisplayName|**Status**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statecode`|
|RequiredLevel|SystemRequired|
|Type|State|
|DefaultFormValue||
|GlobalChoiceName|`msdyncrm_segment_statecode`|

#### statecode Choices/Options

|Value|Details|
|---|---|
|0|Label: **Active**<br />DefaultStatus: 192350000<br />InvariantName: `Active`|
|1|Label: **Inactive**<br />DefaultStatus: 192350004<br />InvariantName: `Inactive`|

### <a name="BKMK_statuscode"></a> statuscode

|Property|Value|
|---|---|
|Description|**Reason for the status of the Segment**|
|DisplayName|**Status Reason**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statuscode`|
|RequiredLevel|ApplicationRequired|
|Type|Status|
|DefaultFormValue||
|GlobalChoiceName|`msdyncrm_segment_statuscode`|

#### statuscode Choices/Options

|Value|Details|
|---|---|
|192350000|Label: **Draft**<br />State:0<br />TransitionData:<br />`<allowedtransitions xmlns="http://schemas.microsoft.com/crm/2009/WebServices"><allowedtransition sourcestatusid="192350000" tostatusid="192350006" /><allowedtransition sourcestatusid="192350000" tostatusid="192350001" /><allowedtransition sourcestatusid="192350000" tostatusid="192350004" /></allowedtransitions>`|
|192350001|Label: **Live**<br />State:0<br />TransitionData:<br />`<allowedtransitions xmlns="http://schemas.microsoft.com/crm/2009/WebServices"><allowedtransition sourcestatusid="192350001" tostatusid="192350007" /><allowedtransition sourcestatusid="192350001" tostatusid="192350002" /><allowedtransition sourcestatusid="192350001" tostatusid="192350006" /><allowedtransition sourcestatusid="192350001" tostatusid="192350003" /><allowedtransition sourcestatusid="192350001" tostatusid="192350005" /></allowedtransitions>`|
|192350002|Label: **Stopped**<br />State:0<br />TransitionData:<br />`<allowedtransitions xmlns="http://schemas.microsoft.com/crm/2009/WebServices"><allowedtransition sourcestatusid="192350002" tostatusid="192350004" /><allowedtransition sourcestatusid="192350002" tostatusid="192350006" /></allowedtransitions>`|
|192350003|Label: **Live editable**<br />State:0<br />TransitionData:<br />`<allowedtransitions xmlns="http://schemas.microsoft.com/crm/2009/WebServices"><allowedtransition sourcestatusid="192350003" tostatusid="192350001" /><allowedtransition sourcestatusid="192350003" tostatusid="192350005" /><allowedtransition sourcestatusid="192350003" tostatusid="192350006" /></allowedtransitions>`|
|192350004|Label: **Expired**<br />State:1<br />TransitionData: None|
|192350005|Label: **Error**<br />State:0<br />TransitionData:<br />`<allowedtransitions xmlns="http://schemas.microsoft.com/crm/2009/WebServices"><allowedtransition sourcestatusid="192350005" tostatusid="192350006" /><allowedtransition sourcestatusid="192350005" tostatusid="192350007" /></allowedtransitions>`|
|192350006|Label: **Going live**<br />State:0<br />TransitionData:<br />`<allowedtransitions xmlns="http://schemas.microsoft.com/crm/2009/WebServices"><allowedtransition sourcestatusid="192350006" tostatusid="192350001" /><allowedtransition sourcestatusid="192350006" tostatusid="192350005" /></allowedtransitions>`|
|192350007|Label: **Stopping**<br />State:0<br />TransitionData:<br />`<allowedtransitions xmlns="http://schemas.microsoft.com/crm/2009/WebServices"><allowedtransition sourcestatusid="192350007" tostatusid="192350002" /><allowedtransition sourcestatusid="192350007" tostatusid="192350005" /></allowedtransitions>`|

### <a name="BKMK_TimeZoneRuleVersionNumber"></a> TimeZoneRuleVersionNumber

|Property|Value|
|---|---|
|Description|**For internal use only**|
|DisplayName|**Time-zone rule version number**|
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
|Description|**Time-zone code that was in use when the record was created**|
|DisplayName|**UTC conversion time-zone code**|
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
- [msdyncrm_segmentnameview](#BKMK_msdyncrm_segmentnameview)
- [OwnerIdName](#BKMK_OwnerIdName)
- [OwnerIdYomiName](#BKMK_OwnerIdYomiName)
- [OwningBusinessUnit](#BKMK_OwningBusinessUnit)
- [OwningTeam](#BKMK_OwningTeam)
- [OwningUser](#BKMK_OwningUser)
- [VersionNumber](#BKMK_VersionNumber)

### <a name="BKMK_CreatedBy"></a> CreatedBy

|Property|Value|
|---|---|
|Description|**Indicates the person who created this.**|
|DisplayName|**Created by**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`createdby`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|systemuser|

### <a name="BKMK_CreatedOn"></a> CreatedOn

|Property|Value|
|---|---|
|Description|**Date and time when the record was created**|
|DisplayName|**Created on**|
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
|Description|**Indicates the person who created this for another person.**|
|DisplayName|**Created by (delegate)**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`createdonbehalfby`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|systemuser|

### <a name="BKMK_ModifiedBy"></a> ModifiedBy

|Property|Value|
|---|---|
|Description|**Indicates the person who modified this.**|
|DisplayName|**Modified by**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`modifiedby`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|systemuser|

### <a name="BKMK_ModifiedOn"></a> ModifiedOn

|Property|Value|
|---|---|
|Description|**Date and time when the record was modified**|
|DisplayName|**Modified on**|
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
|Description|**Indicates the person who modified this for another person.**|
|DisplayName|**Modified by (delegate)**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`modifiedonbehalfby`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|systemuser|

### <a name="BKMK_msdyncrm_segmentnameview"></a> msdyncrm_segmentnameview

|Property|Value|
|---|---|
|Description||
|DisplayName|**Name**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyncrm_segmentnameview`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|4000|

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
|Description|**Indicates the business unit that owns this.**|
|DisplayName|**Owning business unit**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`owningbusinessunit`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|businessunit|

### <a name="BKMK_OwningTeam"></a> OwningTeam

|Property|Value|
|---|---|
|Description|**Indicates the team that owns this.**|
|DisplayName|**Owning team**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`owningteam`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|team|

### <a name="BKMK_OwningUser"></a> OwningUser

|Property|Value|
|---|---|
|Description|**Indicates the person who owns this.**|
|DisplayName|**Owning user**|
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

- [business_unit_msdyncrm_segment](#BKMK_business_unit_msdyncrm_segment)
- [lk_msdyncrm_segment_createdby](#BKMK_lk_msdyncrm_segment_createdby)
- [lk_msdyncrm_segment_createdonbehalfby](#BKMK_lk_msdyncrm_segment_createdonbehalfby)
- [lk_msdyncrm_segment_modifiedby](#BKMK_lk_msdyncrm_segment_modifiedby)
- [lk_msdyncrm_segment_modifiedonbehalfby](#BKMK_lk_msdyncrm_segment_modifiedonbehalfby)
- [msdyncrm_msdyncrm_segmenttemplate_msdyncrm_segment_SegmentTemplate](#BKMK_msdyncrm_msdyncrm_segmenttemplate_msdyncrm_segment_SegmentTemplate)
- [owner_msdyncrm_segment](#BKMK_owner_msdyncrm_segment)
- [team_msdyncrm_segment](#BKMK_team_msdyncrm_segment)
- [user_msdyncrm_segment](#BKMK_user_msdyncrm_segment)

### <a name="BKMK_business_unit_msdyncrm_segment"></a> business_unit_msdyncrm_segment

One-To-Many Relationship: [businessunit business_unit_msdyncrm_segment](businessunit.md#BKMK_business_unit_msdyncrm_segment)

|Property|Value|
|---|---|
|ReferencedEntity|`businessunit`|
|ReferencedAttribute|`businessunitid`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencingEntityNavigationPropertyName|`owningbusinessunit`|
|IsHierarchical||
|CascadeConfiguration|Archive: `Restrict`<br />Assign: `NoCascade`<br />Delete: `Restrict`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyncrm_segment_createdby"></a> lk_msdyncrm_segment_createdby

One-To-Many Relationship: [systemuser lk_msdyncrm_segment_createdby](systemuser.md#BKMK_lk_msdyncrm_segment_createdby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdby`|
|ReferencingEntityNavigationPropertyName|`createdby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyncrm_segment_createdonbehalfby"></a> lk_msdyncrm_segment_createdonbehalfby

One-To-Many Relationship: [systemuser lk_msdyncrm_segment_createdonbehalfby](systemuser.md#BKMK_lk_msdyncrm_segment_createdonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdonbehalfby`|
|ReferencingEntityNavigationPropertyName|`createdonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyncrm_segment_modifiedby"></a> lk_msdyncrm_segment_modifiedby

One-To-Many Relationship: [systemuser lk_msdyncrm_segment_modifiedby](systemuser.md#BKMK_lk_msdyncrm_segment_modifiedby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedby`|
|ReferencingEntityNavigationPropertyName|`modifiedby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyncrm_segment_modifiedonbehalfby"></a> lk_msdyncrm_segment_modifiedonbehalfby

One-To-Many Relationship: [systemuser lk_msdyncrm_segment_modifiedonbehalfby](systemuser.md#BKMK_lk_msdyncrm_segment_modifiedonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedonbehalfby`|
|ReferencingEntityNavigationPropertyName|`modifiedonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyncrm_msdyncrm_segmenttemplate_msdyncrm_segment_SegmentTemplate"></a> msdyncrm_msdyncrm_segmenttemplate_msdyncrm_segment_SegmentTemplate

One-To-Many Relationship: [msdyncrm_segmenttemplate msdyncrm_msdyncrm_segmenttemplate_msdyncrm_segment_SegmentTemplate](msdyncrm_segmenttemplate.md#BKMK_msdyncrm_msdyncrm_segmenttemplate_msdyncrm_segment_SegmentTemplate)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyncrm_segmenttemplate`|
|ReferencedAttribute|`msdyncrm_segmenttemplateid`|
|ReferencingAttribute|`msdyncrm_segmenttemplate`|
|ReferencingEntityNavigationPropertyName|`msdyncrm_SegmentTemplate`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_owner_msdyncrm_segment"></a> owner_msdyncrm_segment

One-To-Many Relationship: [owner owner_msdyncrm_segment](owner.md#BKMK_owner_msdyncrm_segment)

|Property|Value|
|---|---|
|ReferencedEntity|`owner`|
|ReferencedAttribute|`ownerid`|
|ReferencingAttribute|`ownerid`|
|ReferencingEntityNavigationPropertyName|`ownerid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_team_msdyncrm_segment"></a> team_msdyncrm_segment

One-To-Many Relationship: [team team_msdyncrm_segment](team.md#BKMK_team_msdyncrm_segment)

|Property|Value|
|---|---|
|ReferencedEntity|`team`|
|ReferencedAttribute|`teamid`|
|ReferencingAttribute|`owningteam`|
|ReferencingEntityNavigationPropertyName|`owningteam`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_user_msdyncrm_segment"></a> user_msdyncrm_segment

One-To-Many Relationship: [systemuser user_msdyncrm_segment](systemuser.md#BKMK_user_msdyncrm_segment)

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

- [msdyncrm_msdyncrm_segment_contact](#BKMK_msdyncrm_msdyncrm_segment_contact)
- [msdyncrm_msdyncrm_segment_msdyncrm_customerjourney_SuppressionSegmentId](#BKMK_msdyncrm_msdyncrm_segment_msdyncrm_customerjourney_SuppressionSegmentId)
- [msdyncrm_msdyncrm_segment_msdyncrm_linkedinaudience_segment](#BKMK_msdyncrm_msdyncrm_segment_msdyncrm_linkedinaudience_segment)
- [msdyncrm_msdyncrm_segment_msdyncrm_segmentactivity_SegmentID](#BKMK_msdyncrm_msdyncrm_segment_msdyncrm_segmentactivity_SegmentID)
- [msdyncrm_segment_AsyncOperations](#BKMK_msdyncrm_segment_AsyncOperations)
- [msdyncrm_segment_BulkDeleteFailures](#BKMK_msdyncrm_segment_BulkDeleteFailures)
- [msdyncrm_segment_MailboxTrackingFolders](#BKMK_msdyncrm_segment_MailboxTrackingFolders)
- [msdyncrm_segment_PrincipalObjectAttributeAccesses](#BKMK_msdyncrm_segment_PrincipalObjectAttributeAccesses)
- [msdyncrm_segment_ProcessSession](#BKMK_msdyncrm_segment_ProcessSession)
- [msdyncrm_segment_SyncErrors](#BKMK_msdyncrm_segment_SyncErrors)

### <a name="BKMK_msdyncrm_msdyncrm_segment_contact"></a> msdyncrm_msdyncrm_segment_contact

Many-To-One Relationship: [contact msdyncrm_msdyncrm_segment_contact](contact.md#BKMK_msdyncrm_msdyncrm_segment_contact)

|Property|Value|
|---|---|
|ReferencingEntity|`contact`|
|ReferencingAttribute|`msdyncrm_segmentmemberid`|
|ReferencedEntityNavigationPropertyName|`msdyncrm_msdyncrm_segment_contact`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyncrm_msdyncrm_segment_msdyncrm_customerjourney_SuppressionSegmentId"></a> msdyncrm_msdyncrm_segment_msdyncrm_customerjourney_SuppressionSegmentId

Many-To-One Relationship: [msdyncrm_customerjourney msdyncrm_msdyncrm_segment_msdyncrm_customerjourney_SuppressionSegmentId](msdyncrm_customerjourney.md#BKMK_msdyncrm_msdyncrm_segment_msdyncrm_customerjourney_SuppressionSegmentId)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyncrm_customerjourney`|
|ReferencingAttribute|`msdyncrm_suppressionsegmentid`|
|ReferencedEntityNavigationPropertyName|`msdyncrm_msdyncrm_segment_msdyncrm_customerjourney_SuppressionSegmentId`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyncrm_msdyncrm_segment_msdyncrm_linkedinaudience_segment"></a> msdyncrm_msdyncrm_segment_msdyncrm_linkedinaudience_segment

Many-To-One Relationship: [msdyncrm_linkedinaudience msdyncrm_msdyncrm_segment_msdyncrm_linkedinaudience_segment](msdyncrm_linkedinaudience.md#BKMK_msdyncrm_msdyncrm_segment_msdyncrm_linkedinaudience_segment)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyncrm_linkedinaudience`|
|ReferencingAttribute|`msdyncrm_associatedsegment`|
|ReferencedEntityNavigationPropertyName|`msdyncrm_msdyncrm_segment_msdyncrm_linkedinaudience_segment`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyncrm_msdyncrm_segment_msdyncrm_segmentactivity_SegmentID"></a> msdyncrm_msdyncrm_segment_msdyncrm_segmentactivity_SegmentID

Many-To-One Relationship: [msdyncrm_segmentactivity msdyncrm_msdyncrm_segment_msdyncrm_segmentactivity_SegmentID](msdyncrm_segmentactivity.md#BKMK_msdyncrm_msdyncrm_segment_msdyncrm_segmentactivity_SegmentID)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyncrm_segmentactivity`|
|ReferencingAttribute|`msdyncrm_segmentid`|
|ReferencedEntityNavigationPropertyName|`msdyncrm_msdyncrm_segment_msdyncrm_segmentactivity_SegmentID`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyncrm_segment_AsyncOperations"></a> msdyncrm_segment_AsyncOperations

Many-To-One Relationship: [asyncoperation msdyncrm_segment_AsyncOperations](asyncoperation.md#BKMK_msdyncrm_segment_AsyncOperations)

|Property|Value|
|---|---|
|ReferencingEntity|`asyncoperation`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyncrm_segment_AsyncOperations`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyncrm_segment_BulkDeleteFailures"></a> msdyncrm_segment_BulkDeleteFailures

Many-To-One Relationship: [bulkdeletefailure msdyncrm_segment_BulkDeleteFailures](bulkdeletefailure.md#BKMK_msdyncrm_segment_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencingEntity|`bulkdeletefailure`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyncrm_segment_BulkDeleteFailures`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyncrm_segment_MailboxTrackingFolders"></a> msdyncrm_segment_MailboxTrackingFolders

Many-To-One Relationship: [mailboxtrackingfolder msdyncrm_segment_MailboxTrackingFolders](mailboxtrackingfolder.md#BKMK_msdyncrm_segment_MailboxTrackingFolders)

|Property|Value|
|---|---|
|ReferencingEntity|`mailboxtrackingfolder`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyncrm_segment_MailboxTrackingFolders`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyncrm_segment_PrincipalObjectAttributeAccesses"></a> msdyncrm_segment_PrincipalObjectAttributeAccesses

Many-To-One Relationship: [principalobjectattributeaccess msdyncrm_segment_PrincipalObjectAttributeAccesses](principalobjectattributeaccess.md#BKMK_msdyncrm_segment_PrincipalObjectAttributeAccesses)

|Property|Value|
|---|---|
|ReferencingEntity|`principalobjectattributeaccess`|
|ReferencingAttribute|`objectid`|
|ReferencedEntityNavigationPropertyName|`msdyncrm_segment_PrincipalObjectAttributeAccesses`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyncrm_segment_ProcessSession"></a> msdyncrm_segment_ProcessSession

Many-To-One Relationship: [processsession msdyncrm_segment_ProcessSession](processsession.md#BKMK_msdyncrm_segment_ProcessSession)

|Property|Value|
|---|---|
|ReferencingEntity|`processsession`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyncrm_segment_ProcessSession`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyncrm_segment_SyncErrors"></a> msdyncrm_segment_SyncErrors

Many-To-One Relationship: [syncerror msdyncrm_segment_SyncErrors](syncerror.md#BKMK_msdyncrm_segment_SyncErrors)

|Property|Value|
|---|---|
|ReferencingEntity|`syncerror`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyncrm_segment_SyncErrors`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|



### See also

[Dataverse table/entity reference](../about-entity-reference.md)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   

