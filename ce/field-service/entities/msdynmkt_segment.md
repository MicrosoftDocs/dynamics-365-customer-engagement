---
title: "Segment (msdynmkt_segment) table/entity reference (Microsoft Dynamics 365 Field Service)"
description: "Includes schema information and supported messages for the Segment (msdynmkt_segment) table/entity with Microsoft Dynamics 365 Field Service."
ms.date: 07.24.2024
ms.service: powerapps
ms.topic: reference
author: m-hartmann
ms.author: mhart
search.audienceType: 
  - developer
---

# Segment (msdynmkt_segment) table/entity reference

Standard entity of segment representation/metadata

## Messages

The following table lists the messages for the Segment (msdynmkt_segment) table.
Messages represent operations that can be performed on the table. They may also be events.

| Name <br />Is Event? |Web API Operation |SDK for .NET |
| ---- | ----- |----- |
| `Assign`<br />Event: True |`PATCH` /msdynmkt_segments(*msdynmkt_segmentid*)<br />[Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) the `ownerid` property. |<xref:Microsoft.Crm.Sdk.Messages.AssignRequest>|
| `Create`<br />Event: True |`POST` /msdynmkt_segments<br />See [Create](/powerapps/developer/data-platform/webapi/create-entity-web-api) |[Create records](/power-apps/developer/data-platform/org-service/entity-operations-create#basic-create)|
| `CreateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.CreateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.CreateMultipleRequest>|
| `Delete`<br />Event: True |`DELETE` /msdynmkt_segments(*msdynmkt_segmentid*)<br />See [Delete](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-delete) |[Delete records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-delete)|
| `GrantAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.GrantAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.GrantAccessRequest>|
| `IsValidStateTransition`<br />Event: False |<xref:Microsoft.Dynamics.CRM.IsValidStateTransition?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.IsValidStateTransitionRequest>|
| `ModifyAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.ModifyAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.ModifyAccessRequest>|
| `Restore`<br />Event: True |<xref:Microsoft.Dynamics.CRM.Restore?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retrieve`<br />Event: True |`GET` /msdynmkt_segments(*msdynmkt_segmentid*)<br />See [Retrieve](/powerapps/developer/data-platform/webapi/retrieve-entity-using-web-api) |[Retrieve records](/power-apps/developer/data-platform/org-service/entity-operations-retrieve)|
| `RetrieveMultiple`<br />Event: True |`GET` /msdynmkt_segments<br />See [Query data](/power-apps/developer/data-platform/webapi/query-data-web-api) |[Query data](/power-apps/developer/data-platform/org-service/entity-operations-query-data)|
| `RetrievePrincipalAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RetrievePrincipalAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RetrievePrincipalAccessRequest>|
| `RetrieveSharedPrincipalsAndAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RetrieveSharedPrincipalsAndAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RetrieveSharedPrincipalsAndAccessRequest>|
| `RevokeAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RevokeAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RevokeAccessRequest>|
| `SetState`<br />Event: True |`PATCH` /msdynmkt_segments(*msdynmkt_segmentid*)<br />[Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) the `statecode` and `statuscode` properties. |<xref:Microsoft.Crm.Sdk.Messages.SetStateRequest>|
| `Update`<br />Event: True |`PATCH` /msdynmkt_segments(*msdynmkt_segmentid*)<br />See [Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) |[Update records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-update)|
| `UpdateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.UpdateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpdateMultipleRequest>|
| `Upsert`<br />Event: False |`PATCH` /msdynmkt_segments(*msdynmkt_segmentid*)<br />See [Upsert a table row](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#upsert-a-table-row) |<xref:Microsoft.Xrm.Sdk.Messages.UpsertRequest>|
| `UpsertMultiple`<br />Event: False |<xref:Microsoft.Dynamics.CRM.UpsertMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpsertMultipleRequest>|


## Events

The following table lists the events for the Segment (msdynmkt_segment) table.
Events are messages that exist so that you can subscribe to them. Unless you added the event, you shouldn't invoke the message, only subscribe to it.

|Name|Web API Operation |SDK for .NET |
| ---- | ----- |----- |
| `BulkRetain`|<xref:Microsoft.Dynamics.CRM.BulkRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `PurgeRetainedContent`|<xref:Microsoft.Dynamics.CRM.PurgeRetainedContent?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retain`|<xref:Microsoft.Dynamics.CRM.Retain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `RollbackRetain`|<xref:Microsoft.Dynamics.CRM.RollbackRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `ValidateRetentionConfig`|<xref:Microsoft.Dynamics.CRM.ValidateRetentionConfig?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|

## Properties

The following table lists selected properties for the Segment (msdynmkt_segment) table.

|Property|Value|
| --- | --- |
| **DisplayName** | **Segment** |
| **DisplayCollectionName** | **Segments** |
| **SchemaName** | `msdynmkt_segment` |
| **CollectionSchemaName** | `msdynmkt_segments` |
| **EntitySetName** | `msdynmkt_segments`|
| **LogicalName** | `msdynmkt_segment` |
| **LogicalCollectionName** | `msdynmkt_segments` |
| **PrimaryIdAttribute** | `msdynmkt_segmentid` |
| **PrimaryNameAttribute** |`msdynmkt_sourcesegmentuid` |
| **TableType** | `Standard` |
| **OwnershipType** | `UserOwned` |

## Writable columns/attributes

These columns/attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [ImportSequenceNumber](#BKMK_ImportSequenceNumber)
- [msdynmkt_baseentitylogicalname](#BKMK_msdynmkt_baseentitylogicalname)
- [msdynmkt_cdmmanifestrelativepath](#BKMK_msdynmkt_cdmmanifestrelativepath)
- [msdynmkt_cdmpartitionprimarykeycolumn](#BKMK_msdynmkt_cdmpartitionprimarykeycolumn)
- [msdynmkt_datalakefolderid](#BKMK_msdynmkt_datalakefolderid)
- [msdynmkt_description](#BKMK_msdynmkt_description)
- [msdynmkt_displayname](#BKMK_msdynmkt_displayname)
- [msdynmkt_lastevaluated](#BKMK_msdynmkt_lastevaluated)
- [msdynmkt_lastexportedat](#BKMK_msdynmkt_lastexportedat)
- [msdynmkt_lastupdatedon](#BKMK_msdynmkt_lastupdatedon)
- [msdynmkt_lastusedinjourney](#BKMK_msdynmkt_lastusedinjourney)
- [msdynmkt_lastusedinjourneyby](#BKMK_msdynmkt_lastusedinjourneyby)
- [msdynmkt_membercount](#BKMK_msdynmkt_membercount)
- [msdynmkt_publishedjourneycount](#BKMK_msdynmkt_publishedjourneycount)
- [msdynmkt_scope](#BKMK_msdynmkt_scope)
- [msdynmkt_segmentId](#BKMK_msdynmkt_segmentId)
- [msdynmkt_source](#BKMK_msdynmkt_source)
- [msdynmkt_sourcesegmentcreatedby](#BKMK_msdynmkt_sourcesegmentcreatedby)
- [msdynmkt_sourcesegmentcreatedon](#BKMK_msdynmkt_sourcesegmentcreatedon)
- [msdynmkt_sourcesegmentuid](#BKMK_msdynmkt_sourcesegmentuid)
- [msdynmkt_sourcesegmenturi](#BKMK_msdynmkt_sourcesegmenturi)
- [msdynmkt_timerequiredby](#BKMK_msdynmkt_timerequiredby)
- [msdynmkt_timerequiredend](#BKMK_msdynmkt_timerequiredend)
- [msdynmkt_type](#BKMK_msdynmkt_type)
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

### <a name="BKMK_msdynmkt_baseentitylogicalname"></a> msdynmkt_baseentitylogicalname

|Property|Value|
|---|---|
|Description|**The logical name of the entity of the segment members**|
|DisplayName|**Base Entity Logical Name**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdynmkt_baseentitylogicalname`|
|RequiredLevel|ApplicationRequired|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdynmkt_cdmmanifestrelativepath"></a> msdynmkt_cdmmanifestrelativepath

|Property|Value|
|---|---|
|Description|**CDM manifest path relative to the data lake folder path.**|
|DisplayName|**CDM Manifest Relative Path**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdynmkt_cdmmanifestrelativepath`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|1000|

### <a name="BKMK_msdynmkt_cdmpartitionprimarykeycolumn"></a> msdynmkt_cdmpartitionprimarykeycolumn

|Property|Value|
|---|---|
|Description|**The column name of the id field in actual segment member data (CDM partitions)**|
|DisplayName|**CDM Partition Primary Key Column**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdynmkt_cdmpartitionprimarykeycolumn`|
|RequiredLevel|ApplicationRequired|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdynmkt_datalakefolderid"></a> msdynmkt_datalakefolderid

|Property|Value|
|---|---|
|Description|**Reference to the data lake folder where actual segment member data (CDM partitions) is**|
|DisplayName|**Data Lake Folder Id**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdynmkt_datalakefolderid`|
|RequiredLevel|ApplicationRequired|
|Type|Lookup|
|Targets|datalakefolder|

### <a name="BKMK_msdynmkt_description"></a> msdynmkt_description

|Property|Value|
|---|---|
|Description|**Description.**|
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

### <a name="BKMK_msdynmkt_displayname"></a> msdynmkt_displayname

|Property|Value|
|---|---|
|Description|**Display name.**|
|DisplayName|**Display Name**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdynmkt_displayname`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdynmkt_lastevaluated"></a> msdynmkt_lastevaluated

|Property|Value|
|---|---|
|Description|**Last time when this was evaluated for journey associations.**|
|DisplayName|**Last evaluation time**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdynmkt_lastevaluated`|
|RequiredLevel|None|
|Type|DateTime|
|CanChangeDateTimeBehavior|False|
|DateTimeBehavior|UserLocal|
|Format|DateAndTime|
|ImeMode|Auto|
|SourceTypeMask|0|

### <a name="BKMK_msdynmkt_lastexportedat"></a> msdynmkt_lastexportedat

|Property|Value|
|---|---|
|Description|**Date and time when the segment was last export for consumption by internal services.**|
|DisplayName|**Last Exported At**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdynmkt_lastexportedat`|
|RequiredLevel|None|
|Type|DateTime|
|CanChangeDateTimeBehavior|False|
|DateTimeBehavior|UserLocal|
|Format|DateAndTime|
|ImeMode|Auto|
|SourceTypeMask|0|

### <a name="BKMK_msdynmkt_lastupdatedon"></a> msdynmkt_lastupdatedon

|Property|Value|
|---|---|
|Description|**Last updated on.**|
|DisplayName|**Last Updated On**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdynmkt_lastupdatedon`|
|RequiredLevel|ApplicationRequired|
|Type|DateTime|
|CanChangeDateTimeBehavior|True|
|DateTimeBehavior|TimeZoneIndependent|
|Format|DateAndTime|
|ImeMode|Auto|
|SourceTypeMask|0|

### <a name="BKMK_msdynmkt_lastusedinjourney"></a> msdynmkt_lastusedinjourney

|Property|Value|
|---|---|
|Description|**Last time when this segment was used in a journey.**|
|DisplayName|**Last used**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdynmkt_lastusedinjourney`|
|RequiredLevel|None|
|Type|DateTime|
|CanChangeDateTimeBehavior|False|
|DateTimeBehavior|UserLocal|
|Format|DateAndTime|
|ImeMode|Auto|
|SourceTypeMask|0|

### <a name="BKMK_msdynmkt_lastusedinjourneyby"></a> msdynmkt_lastusedinjourneyby

|Property|Value|
|---|---|
|Description|**The name the user who last associated a journey with this segment.**|
|DisplayName|**Last used by**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdynmkt_lastusedinjourneyby`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|systemuser|

### <a name="BKMK_msdynmkt_membercount"></a> msdynmkt_membercount

|Property|Value|
|---|---|
|Description|**Member count.**|
|DisplayName|**Member Count**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdynmkt_membercount`|
|RequiredLevel|None|
|Type|Integer|
|MaxValue|2147483647|
|MinValue|0|

### <a name="BKMK_msdynmkt_publishedjourneycount"></a> msdynmkt_publishedjourneycount

|Property|Value|
|---|---|
|Description|**The number of live journeys associated with the segment**|
|DisplayName|**Live journey count**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdynmkt_publishedjourneycount`|
|RequiredLevel|None|
|Type|Integer|
|MaxValue|2147483647|
|MinValue|0|

### <a name="BKMK_msdynmkt_scope"></a> msdynmkt_scope

|Property|Value|
|---|---|
|Description|**Business-unit scope for selecting segment members**|
|DisplayName|**Scope**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdynmkt_scope`|
|RequiredLevel|None|
|Type|Picklist|
|DefaultFormValue|270100000|
|GlobalChoiceName|`msdynmkt_processscope`|

#### msdynmkt_scope Choices/Options

|Value|Label|
|---|---|
|270100000|**Organization**|
|270100001|**Business unit**|

### <a name="BKMK_msdynmkt_segmentId"></a> msdynmkt_segmentId

|Property|Value|
|---|---|
|Description|**Unique identifier for entity instances.**|
|DisplayName|**Segment Id**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`msdynmkt_segmentid`|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|

### <a name="BKMK_msdynmkt_source"></a> msdynmkt_source

|Property|Value|
|---|---|
|Description|**Source.**|
|DisplayName|**Source**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdynmkt_source`|
|RequiredLevel|ApplicationRequired|
|Type|Picklist|
|DefaultFormValue|10|
|GlobalChoiceName|`msdynmkt_segment_msdynmkt_source`|

#### msdynmkt_source Choices/Options

|Value|Label|
|---|---|
|10|**Marketing**|
|11|**Customer Insights**|
|12|**Real-time Journeys**|

### <a name="BKMK_msdynmkt_sourcesegmentcreatedby"></a> msdynmkt_sourcesegmentcreatedby

|Property|Value|
|---|---|
|Description|**The creator of the source segment.**|
|DisplayName|**Source Segment Created By**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdynmkt_sourcesegmentcreatedby`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdynmkt_sourcesegmentcreatedon"></a> msdynmkt_sourcesegmentcreatedon

|Property|Value|
|---|---|
|Description|**Date and time when the source segment was created.**|
|DisplayName|**Source Segment Created On**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdynmkt_sourcesegmentcreatedon`|
|RequiredLevel|None|
|Type|DateTime|
|CanChangeDateTimeBehavior|True|
|DateTimeBehavior|TimeZoneIndependent|
|Format|DateAndTime|
|ImeMode|Auto|
|SourceTypeMask|0|

### <a name="BKMK_msdynmkt_sourcesegmentuid"></a> msdynmkt_sourcesegmentuid

|Property|Value|
|---|---|
|Description|**Unique identifier of the source segment.**|
|DisplayName|**Source Segment Uid**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdynmkt_sourcesegmentuid`|
|RequiredLevel|ApplicationRequired|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdynmkt_sourcesegmenturi"></a> msdynmkt_sourcesegmenturi

|Property|Value|
|---|---|
|Description|**Uri to the source segment.**|
|DisplayName|**Source Segment Uri**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdynmkt_sourcesegmenturi`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|1000|

### <a name="BKMK_msdynmkt_timerequiredby"></a> msdynmkt_timerequiredby

|Property|Value|
|---|---|
|Description|**Date and time when the segment is first required by dependent services.**|
|DisplayName|**Time required by**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdynmkt_timerequiredby`|
|RequiredLevel|None|
|Type|DateTime|
|CanChangeDateTimeBehavior|False|
|DateTimeBehavior|UserLocal|
|Format|DateAndTime|
|ImeMode|Auto|
|SourceTypeMask|0|

### <a name="BKMK_msdynmkt_timerequiredend"></a> msdynmkt_timerequiredend

|Property|Value|
|---|---|
|Description|**Date and time when the segment is last required by dependent services.**|
|DisplayName|**Time required end**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdynmkt_timerequiredend`|
|RequiredLevel|None|
|Type|DateTime|
|CanChangeDateTimeBehavior|False|
|DateTimeBehavior|UserLocal|
|Format|DateAndTime|
|ImeMode|Auto|
|SourceTypeMask|0|

### <a name="BKMK_msdynmkt_type"></a> msdynmkt_type

|Property|Value|
|---|---|
|Description|**Type.**|
|DisplayName|**Type**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdynmkt_type`|
|RequiredLevel|ApplicationRequired|
|Type|Picklist|
|DefaultFormValue|10|
|GlobalChoiceName|`msdynmkt_segment_msdynmkt_type`|

#### msdynmkt_type Choices/Options

|Value|Label|
|---|---|
|10|**Static**|
|11|**Dynamic**|
|12|**Expansion**|

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
|Description|**Status of the msdynmkt_segment**|
|DisplayName|**Status**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statecode`|
|RequiredLevel|SystemRequired|
|Type|State|
|DefaultFormValue||
|GlobalChoiceName|`msdynmkt_segment_statecode`|

#### statecode Choices/Options

|Value|Details|
|---|---|
|0|Label: **Active**<br />DefaultStatus: 1<br />InvariantName: `Active`|
|1|Label: **Inactive**<br />DefaultStatus: 2<br />InvariantName: `Inactive`|

### <a name="BKMK_statuscode"></a> statuscode

|Property|Value|
|---|---|
|Description|**Reason for the status of the msdynmkt_segment**|
|DisplayName|**Status Reason**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statuscode`|
|RequiredLevel|None|
|Type|Status|
|DefaultFormValue||
|GlobalChoiceName|`msdynmkt_segment_statuscode`|

#### statuscode Choices/Options

|Value|Details|
|---|---|
|1|Label: **Active**<br />State:0<br />TransitionData: None|
|2|Label: **Inactive**<br />State:1<br />TransitionData: None|
|3|Label: **Error**<br />State:1<br />TransitionData: None|
|4|Label: **Deleted**<br />State:1<br />TransitionData: None|
|5|Label: **Exporting**<br />State:1<br />TransitionData: None|
|6|Label: **Computing**<br />State:1<br />TransitionData: None|
|7|Label: **ComputedWithWarnings**<br />State:1<br />TransitionData: None|

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
- [msdynmkt_membercount_Date](#BKMK_msdynmkt_membercount_Date)
- [msdynmkt_membercount_State](#BKMK_msdynmkt_membercount_State)
- [OrganizationId](#BKMK_OrganizationId)
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

### <a name="BKMK_msdynmkt_membercount_Date"></a> msdynmkt_membercount_Date

|Property|Value|
|---|---|
|Description|**Last Updated time of rollup field Member Count.**|
|DisplayName|**Member Count (Last Updated On)**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdynmkt_membercount_date`|
|RequiredLevel|None|
|Type|DateTime|
|CanChangeDateTimeBehavior|True|
|DateTimeBehavior|UserLocal|
|Format|DateAndTime|
|ImeMode|Inactive|
|SourceTypeMask|0|

### <a name="BKMK_msdynmkt_membercount_State"></a> msdynmkt_membercount_State

|Property|Value|
|---|---|
|Description|**State of rollup field Member Count.**|
|DisplayName|**Member Count (State)**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdynmkt_membercount_state`|
|RequiredLevel|None|
|Type|Integer|
|MaxValue|2147483647|
|MinValue|-2147483648|

### <a name="BKMK_OrganizationId"></a> OrganizationId

|Property|Value|
|---|---|
|Description|**Unique identifier for the organization**|
|DisplayName|**Organization Id**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`organizationid`|
|RequiredLevel|None|
|Type|Lookup|
|Targets||

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
|RequiredLevel|SystemRequired|
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

- [business_unit_msdynmkt_segment](#BKMK_business_unit_msdynmkt_segment)
- [lk_msdynmkt_segment_createdby](#BKMK_lk_msdynmkt_segment_createdby)
- [lk_msdynmkt_segment_createdonbehalfby](#BKMK_lk_msdynmkt_segment_createdonbehalfby)
- [lk_msdynmkt_segment_modifiedby](#BKMK_lk_msdynmkt_segment_modifiedby)
- [lk_msdynmkt_segment_modifiedonbehalfby](#BKMK_lk_msdynmkt_segment_modifiedonbehalfby)
- [lk_msdynmkt_segment_msdynmkt_lastusedinjourneyby](#BKMK_lk_msdynmkt_segment_msdynmkt_lastusedinjourneyby)
- [msdynmkt_segment_datalakefolder](#BKMK_msdynmkt_segment_datalakefolder)
- [owner_msdynmkt_segment](#BKMK_owner_msdynmkt_segment)
- [team_msdynmkt_segment](#BKMK_team_msdynmkt_segment)
- [user_msdynmkt_segment](#BKMK_user_msdynmkt_segment)

### <a name="BKMK_business_unit_msdynmkt_segment"></a> business_unit_msdynmkt_segment

One-To-Many Relationship: [businessunit business_unit_msdynmkt_segment](businessunit.md#BKMK_business_unit_msdynmkt_segment)

|Property|Value|
|---|---|
|ReferencedEntity|`businessunit`|
|ReferencedAttribute|`businessunitid`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencingEntityNavigationPropertyName|`owningbusinessunit`|
|IsHierarchical||
|CascadeConfiguration|Archive: `Restrict`<br />Assign: `NoCascade`<br />Delete: `Restrict`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdynmkt_segment_createdby"></a> lk_msdynmkt_segment_createdby

One-To-Many Relationship: [systemuser lk_msdynmkt_segment_createdby](systemuser.md#BKMK_lk_msdynmkt_segment_createdby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdby`|
|ReferencingEntityNavigationPropertyName|`createdby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdynmkt_segment_createdonbehalfby"></a> lk_msdynmkt_segment_createdonbehalfby

One-To-Many Relationship: [systemuser lk_msdynmkt_segment_createdonbehalfby](systemuser.md#BKMK_lk_msdynmkt_segment_createdonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdonbehalfby`|
|ReferencingEntityNavigationPropertyName|`createdonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdynmkt_segment_modifiedby"></a> lk_msdynmkt_segment_modifiedby

One-To-Many Relationship: [systemuser lk_msdynmkt_segment_modifiedby](systemuser.md#BKMK_lk_msdynmkt_segment_modifiedby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedby`|
|ReferencingEntityNavigationPropertyName|`modifiedby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdynmkt_segment_modifiedonbehalfby"></a> lk_msdynmkt_segment_modifiedonbehalfby

One-To-Many Relationship: [systemuser lk_msdynmkt_segment_modifiedonbehalfby](systemuser.md#BKMK_lk_msdynmkt_segment_modifiedonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedonbehalfby`|
|ReferencingEntityNavigationPropertyName|`modifiedonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdynmkt_segment_msdynmkt_lastusedinjourneyby"></a> lk_msdynmkt_segment_msdynmkt_lastusedinjourneyby

One-To-Many Relationship: [systemuser lk_msdynmkt_segment_msdynmkt_lastusedinjourneyby](systemuser.md#BKMK_lk_msdynmkt_segment_msdynmkt_lastusedinjourneyby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`msdynmkt_lastusedinjourneyby`|
|ReferencingEntityNavigationPropertyName|`msdynmkt_lastusedinjourneyby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdynmkt_segment_datalakefolder"></a> msdynmkt_segment_datalakefolder

One-To-Many Relationship: [datalakefolder msdynmkt_segment_datalakefolder](datalakefolder.md#BKMK_msdynmkt_segment_datalakefolder)

|Property|Value|
|---|---|
|ReferencedEntity|`datalakefolder`|
|ReferencedAttribute|`datalakefolderid`|
|ReferencingAttribute|`msdynmkt_datalakefolderid`|
|ReferencingEntityNavigationPropertyName|`msdynmkt_datalakefolderid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_owner_msdynmkt_segment"></a> owner_msdynmkt_segment

One-To-Many Relationship: [owner owner_msdynmkt_segment](owner.md#BKMK_owner_msdynmkt_segment)

|Property|Value|
|---|---|
|ReferencedEntity|`owner`|
|ReferencedAttribute|`ownerid`|
|ReferencingAttribute|`ownerid`|
|ReferencingEntityNavigationPropertyName|`ownerid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_team_msdynmkt_segment"></a> team_msdynmkt_segment

One-To-Many Relationship: [team team_msdynmkt_segment](team.md#BKMK_team_msdynmkt_segment)

|Property|Value|
|---|---|
|ReferencedEntity|`team`|
|ReferencedAttribute|`teamid`|
|ReferencingAttribute|`owningteam`|
|ReferencingEntityNavigationPropertyName|`owningteam`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_user_msdynmkt_segment"></a> user_msdynmkt_segment

One-To-Many Relationship: [systemuser user_msdynmkt_segment](systemuser.md#BKMK_user_msdynmkt_segment)

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

- [msdynmkt_msdynmkt_segment_msdynmkt_teamsengagement_audiencesegment](#BKMK_msdynmkt_msdynmkt_segment_msdynmkt_teamsengagement_audiencesegment)
- [msdynmkt_segment_AsyncOperations](#BKMK_msdynmkt_segment_AsyncOperations)
- [msdynmkt_segment_BulkDeleteFailures](#BKMK_msdynmkt_segment_BulkDeleteFailures)
- [msdynmkt_segment_DuplicateBaseRecord](#BKMK_msdynmkt_segment_DuplicateBaseRecord)
- [msdynmkt_segment_DuplicateMatchingRecord](#BKMK_msdynmkt_segment_DuplicateMatchingRecord)
- [msdynmkt_segment_MailboxTrackingFolders](#BKMK_msdynmkt_segment_MailboxTrackingFolders)
- [msdynmkt_segment_PrincipalObjectAttributeAccesses](#BKMK_msdynmkt_segment_PrincipalObjectAttributeAccesses)
- [msdynmkt_segment_ProcessSession](#BKMK_msdynmkt_segment_ProcessSession)
- [msdynmkt_segment_SyncErrors](#BKMK_msdynmkt_segment_SyncErrors)
- [msdynmkt_segmentusage_msdynmkt_segment](#BKMK_msdynmkt_segmentusage_msdynmkt_segment)
- [msdynmkt_segmentusage_msdynmkt_segment_dependententityid](#BKMK_msdynmkt_segmentusage_msdynmkt_segment_dependententityid)

### <a name="BKMK_msdynmkt_msdynmkt_segment_msdynmkt_teamsengagement_audiencesegment"></a> msdynmkt_msdynmkt_segment_msdynmkt_teamsengagement_audiencesegment

Many-To-One Relationship: [msdynmkt_teamsengagement msdynmkt_msdynmkt_segment_msdynmkt_teamsengagement_audiencesegment](msdynmkt_teamsengagement.md#BKMK_msdynmkt_msdynmkt_segment_msdynmkt_teamsengagement_audiencesegment)

|Property|Value|
|---|---|
|ReferencingEntity|`msdynmkt_teamsengagement`|
|ReferencingAttribute|`msdynmkt_audiencesegment`|
|ReferencedEntityNavigationPropertyName|`msdynmkt_msdynmkt_segment_msdynmkt_teamsengagement_audiencesegment`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdynmkt_segment_AsyncOperations"></a> msdynmkt_segment_AsyncOperations

Many-To-One Relationship: [asyncoperation msdynmkt_segment_AsyncOperations](asyncoperation.md#BKMK_msdynmkt_segment_AsyncOperations)

|Property|Value|
|---|---|
|ReferencingEntity|`asyncoperation`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdynmkt_segment_AsyncOperations`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdynmkt_segment_BulkDeleteFailures"></a> msdynmkt_segment_BulkDeleteFailures

Many-To-One Relationship: [bulkdeletefailure msdynmkt_segment_BulkDeleteFailures](bulkdeletefailure.md#BKMK_msdynmkt_segment_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencingEntity|`bulkdeletefailure`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdynmkt_segment_BulkDeleteFailures`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdynmkt_segment_DuplicateBaseRecord"></a> msdynmkt_segment_DuplicateBaseRecord

Many-To-One Relationship: [duplicaterecord msdynmkt_segment_DuplicateBaseRecord](duplicaterecord.md#BKMK_msdynmkt_segment_DuplicateBaseRecord)

|Property|Value|
|---|---|
|ReferencingEntity|`duplicaterecord`|
|ReferencingAttribute|`baserecordid`|
|ReferencedEntityNavigationPropertyName|`msdynmkt_segment_DuplicateBaseRecord`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdynmkt_segment_DuplicateMatchingRecord"></a> msdynmkt_segment_DuplicateMatchingRecord

Many-To-One Relationship: [duplicaterecord msdynmkt_segment_DuplicateMatchingRecord](duplicaterecord.md#BKMK_msdynmkt_segment_DuplicateMatchingRecord)

|Property|Value|
|---|---|
|ReferencingEntity|`duplicaterecord`|
|ReferencingAttribute|`duplicaterecordid`|
|ReferencedEntityNavigationPropertyName|`msdynmkt_segment_DuplicateMatchingRecord`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdynmkt_segment_MailboxTrackingFolders"></a> msdynmkt_segment_MailboxTrackingFolders

Many-To-One Relationship: [mailboxtrackingfolder msdynmkt_segment_MailboxTrackingFolders](mailboxtrackingfolder.md#BKMK_msdynmkt_segment_MailboxTrackingFolders)

|Property|Value|
|---|---|
|ReferencingEntity|`mailboxtrackingfolder`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdynmkt_segment_MailboxTrackingFolders`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdynmkt_segment_PrincipalObjectAttributeAccesses"></a> msdynmkt_segment_PrincipalObjectAttributeAccesses

Many-To-One Relationship: [principalobjectattributeaccess msdynmkt_segment_PrincipalObjectAttributeAccesses](principalobjectattributeaccess.md#BKMK_msdynmkt_segment_PrincipalObjectAttributeAccesses)

|Property|Value|
|---|---|
|ReferencingEntity|`principalobjectattributeaccess`|
|ReferencingAttribute|`objectid`|
|ReferencedEntityNavigationPropertyName|`msdynmkt_segment_PrincipalObjectAttributeAccesses`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdynmkt_segment_ProcessSession"></a> msdynmkt_segment_ProcessSession

Many-To-One Relationship: [processsession msdynmkt_segment_ProcessSession](processsession.md#BKMK_msdynmkt_segment_ProcessSession)

|Property|Value|
|---|---|
|ReferencingEntity|`processsession`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdynmkt_segment_ProcessSession`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdynmkt_segment_SyncErrors"></a> msdynmkt_segment_SyncErrors

Many-To-One Relationship: [syncerror msdynmkt_segment_SyncErrors](syncerror.md#BKMK_msdynmkt_segment_SyncErrors)

|Property|Value|
|---|---|
|ReferencingEntity|`syncerror`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdynmkt_segment_SyncErrors`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdynmkt_segmentusage_msdynmkt_segment"></a> msdynmkt_segmentusage_msdynmkt_segment

Many-To-One Relationship: [msdynmkt_segmentusage msdynmkt_segmentusage_msdynmkt_segment](msdynmkt_segmentusage.md#BKMK_msdynmkt_segmentusage_msdynmkt_segment)

|Property|Value|
|---|---|
|ReferencingEntity|`msdynmkt_segmentusage`|
|ReferencingAttribute|`msdynmkt_targetsegmentid`|
|ReferencedEntityNavigationPropertyName|`msdynmkt_segmentusage_msdynmkt_segment`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdynmkt_segmentusage_msdynmkt_segment_dependententityid"></a> msdynmkt_segmentusage_msdynmkt_segment_dependententityid

Many-To-One Relationship: [msdynmkt_segmentusage msdynmkt_segmentusage_msdynmkt_segment_dependententityid](msdynmkt_segmentusage.md#BKMK_msdynmkt_segmentusage_msdynmkt_segment_dependententityid)

|Property|Value|
|---|---|
|ReferencingEntity|`msdynmkt_segmentusage`|
|ReferencingAttribute|`msdynmkt_dependententityid`|
|ReferencedEntityNavigationPropertyName|`msdynmkt_segmentusage_msdynmkt_segment_dependententityid`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|



### See also

[Dataverse table/entity reference](../about-entity-reference.md)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   

