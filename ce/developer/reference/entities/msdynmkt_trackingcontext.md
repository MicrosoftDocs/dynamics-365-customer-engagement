---
title: "TrackingContext (msdynmkt_trackingcontext) table/entity reference (Microsoft Dynamics 365)"
description: "Includes schema information and supported messages for the TrackingContext (msdynmkt_trackingcontext) table/entity with Microsoft Dynamics 365."
ms.topic: generated-reference
author: JimDaly
ms.author: jdaly
search.audienceType: 
  - developer
---

# TrackingContext (msdynmkt_trackingcontext) table/entity reference (Microsoft Dynamics 365)



## Messages

The following table lists the messages for the TrackingContext (msdynmkt_trackingcontext) table.
Messages represent operations that can be performed on the table. They may also be events.

| Name <br />Is Event? |Web API Operation |SDK for .NET |
| ---- | ----- |----- |
| `Associate`<br />Event: True |[Associate records](/power-apps/developer/data-platform/webapi/associate-disassociate-entities-using-web-api) |[Associate records](/power-apps/developer/data-platform/org-service/entity-operations-associate-disassociate#use-the-associate-method-or-associaterequest)|
| `BulkRetain`<br />Event: True |<xref:Microsoft.Dynamics.CRM.BulkRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Create`<br />Event: True |`POST` /msdynmkt_trackingcontexts<br />See [Create](/powerapps/developer/data-platform/webapi/create-entity-web-api) |[Create records](/power-apps/developer/data-platform/org-service/entity-operations-create#basic-create)|
| `CreateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.CreateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.CreateMultipleRequest>|
| `Delete`<br />Event: True |`DELETE` /msdynmkt_trackingcontexts(*msdynmkt_trackingcontextid*)<br />See [Delete](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-delete) |[Delete records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-delete)|
| `DeleteMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.DeleteMultiple?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Disassociate`<br />Event: True |[Disassociate records](/power-apps/developer/data-platform/webapi/associate-disassociate-entities-using-web-api) |[Disassociate records](/power-apps/developer/data-platform/org-service/entity-operations-associate-disassociate#use-the-disassociate-method-or-disassociaterequest)|
| `PurgeRetainedContent`<br />Event: True |<xref:Microsoft.Dynamics.CRM.PurgeRetainedContent?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retain`<br />Event: True |<xref:Microsoft.Dynamics.CRM.Retain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retrieve`<br />Event: True |`GET` /msdynmkt_trackingcontexts(*msdynmkt_trackingcontextid*)<br />See [Retrieve](/powerapps/developer/data-platform/webapi/retrieve-entity-using-web-api) |[Retrieve records](/power-apps/developer/data-platform/org-service/entity-operations-retrieve)|
| `RetrieveEntityChanges`<br />Event: True | |<xref:Microsoft.Xrm.Sdk.Messages.RetrieveEntityChangesRequest>|
| `RetrieveMultiple`<br />Event: True |`GET` /msdynmkt_trackingcontexts<br />See [Query data](/power-apps/developer/data-platform/webapi/query-data-web-api) |[Query data](/power-apps/developer/data-platform/org-service/entity-operations-query-data)|
| `RollbackRetain`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RollbackRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Update`<br />Event: True |`PATCH` /msdynmkt_trackingcontexts(*msdynmkt_trackingcontextid*)<br />See [Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) |[Update records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-update)|
| `UpdateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.UpdateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpdateMultipleRequest>|
| `Upsert`<br />Event: True |`PATCH` /msdynmkt_trackingcontexts(*msdynmkt_trackingcontextid*)<br />See [Upsert a table row](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#upsert-a-table-row) |<xref:Microsoft.Xrm.Sdk.Messages.UpsertRequest>|
| `UpsertMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.UpsertMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpsertMultipleRequest>|
| `ValidateRetentionConfig`<br />Event: True |<xref:Microsoft.Dynamics.CRM.ValidateRetentionConfig?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|

## Properties

The following table lists selected properties for the TrackingContext (msdynmkt_trackingcontext) table.

|Property|Value|
| --- | --- |
| **DisplayName** | **TrackingContext** |
| **DisplayCollectionName** | **TrackingContexts** |
| **SchemaName** | `msdynmkt_trackingcontext` |
| **CollectionSchemaName** | `msdynmkt_trackingcontexts` |
| **EntitySetName** | `msdynmkt_trackingcontexts`|
| **LogicalName** | `msdynmkt_trackingcontext` |
| **LogicalCollectionName** | `msdynmkt_trackingcontexts` |
| **PrimaryIdAttribute** | `msdynmkt_trackingcontextid` |
| **PrimaryNameAttribute** |`msdynmkt_contexttype` |
| **TableType** | `Elastic` |
| **OwnershipType** | `OrganizationOwned` |

## Writable columns/attributes

These columns/attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [ImportSequenceNumber](#BKMK_ImportSequenceNumber)
- [msdynmkt_businessunitid](#BKMK_msdynmkt_businessunitid)
- [msdynmkt_channeldefinitionid](#BKMK_msdynmkt_channeldefinitionid)
- [msdynmkt_channeltype](#BKMK_msdynmkt_channeltype)
- [msdynmkt_contactpoint](#BKMK_msdynmkt_contactpoint)
- [msdynmkt_contexttype](#BKMK_msdynmkt_contexttype)
- [msdynmkt_customerjourneyid](#BKMK_msdynmkt_customerjourneyid)
- [msdynmkt_customerjourneyinstanceid](#BKMK_msdynmkt_customerjourneyinstanceid)
- [msdynmkt_customerjourneytype](#BKMK_msdynmkt_customerjourneytype)
- [msdynmkt_customerjourneyversion](#BKMK_msdynmkt_customerjourneyversion)
- [msdynmkt_emaildelivered](#BKMK_msdynmkt_emaildelivered)
- [msdynmkt_entityid](#BKMK_msdynmkt_entityid)
- [msdynmkt_entitytype](#BKMK_msdynmkt_entitytype)
- [msdynmkt_identityid](#BKMK_msdynmkt_identityid)
- [msdynmkt_journeyactivityid](#BKMK_msdynmkt_journeyactivityid)
- [msdynmkt_jsondata](#BKMK_msdynmkt_jsondata)
- [msdynmkt_linkfriendlyname](#BKMK_msdynmkt_linkfriendlyname)
- [msdynmkt_links](#BKMK_msdynmkt_links)
- [msdynmkt_messagetemplateid](#BKMK_msdynmkt_messagetemplateid)
- [msdynmkt_messagetemplateversion](#BKMK_msdynmkt_messagetemplateversion)
- [msdynmkt_messagevariationindexes](#BKMK_msdynmkt_messagevariationindexes)
- [msdynmkt_messagevariationname](#BKMK_msdynmkt_messagevariationname)
- [msdynmkt_profileid](#BKMK_msdynmkt_profileid)
- [msdynmkt_sender](#BKMK_msdynmkt_sender)
- [msdynmkt_targeturl](#BKMK_msdynmkt_targeturl)
- [msdynmkt_trackingcontextId](#BKMK_msdynmkt_trackingcontextId)
- [OverriddenCreatedOn](#BKMK_OverriddenCreatedOn)
- [PartitionId](#BKMK_PartitionId)
- [TTLInSeconds](#BKMK_TTLInSeconds)

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

### <a name="BKMK_msdynmkt_businessunitid"></a> msdynmkt_businessunitid

|Property|Value|
|---|---|
|Description||
|DisplayName|**Business unit Id**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdynmkt_businessunitid`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdynmkt_channeldefinitionid"></a> msdynmkt_channeldefinitionid

|Property|Value|
|---|---|
|Description||
|DisplayName|**Channel Definition Id**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdynmkt_channeldefinitionid`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdynmkt_channeltype"></a> msdynmkt_channeltype

|Property|Value|
|---|---|
|Description||
|DisplayName|**Channel Type**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdynmkt_channeltype`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdynmkt_contactpoint"></a> msdynmkt_contactpoint

|Property|Value|
|---|---|
|Description|**Contact point.**|
|DisplayName|**Contact point**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdynmkt_contactpoint`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|300|

### <a name="BKMK_msdynmkt_contexttype"></a> msdynmkt_contexttype

|Property|Value|
|---|---|
|Description|**The name of the custom entity.**|
|DisplayName|**Context type name**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdynmkt_contexttype`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdynmkt_customerjourneyid"></a> msdynmkt_customerjourneyid

|Property|Value|
|---|---|
|Description|**The name of the custom entity.**|
|DisplayName|**Customer Journey Id**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdynmkt_customerjourneyid`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdynmkt_customerjourneyinstanceid"></a> msdynmkt_customerjourneyinstanceid

|Property|Value|
|---|---|
|Description|**The name of the custom entity.**|
|DisplayName|**Customer journey instance identifier**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdynmkt_customerjourneyinstanceid`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|200|

### <a name="BKMK_msdynmkt_customerjourneytype"></a> msdynmkt_customerjourneytype

|Property|Value|
|---|---|
|Description||
|DisplayName|**customerjourneytype**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdynmkt_customerjourneytype`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdynmkt_customerjourneyversion"></a> msdynmkt_customerjourneyversion

|Property|Value|
|---|---|
|Description|**The name of the custom entity.**|
|DisplayName|**Customer Journey Version**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdynmkt_customerjourneyversion`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdynmkt_emaildelivered"></a> msdynmkt_emaildelivered

|Property|Value|
|---|---|
|Description|**Tracks if the email was delivered**|
|DisplayName|**Email delivered**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`msdynmkt_trackingcontext_emaildelivered`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`msdynmkt_trackingcontext_msdynmkt_emaildelivered`|
|DefaultValue|False|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_msdynmkt_entityid"></a> msdynmkt_entityid

|Property|Value|
|---|---|
|Description||
|DisplayName|**entityid**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdynmkt_entityid`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdynmkt_entitytype"></a> msdynmkt_entitytype

|Property|Value|
|---|---|
|Description||
|DisplayName|**entitytype**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdynmkt_entitytype`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdynmkt_identityid"></a> msdynmkt_identityid

|Property|Value|
|---|---|
|Description||
|DisplayName|**identityid**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdynmkt_identityid`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdynmkt_journeyactivityid"></a> msdynmkt_journeyactivityid

|Property|Value|
|---|---|
|Description|**The name of the custom entity.**|
|DisplayName|**Customer Journey Instance Id**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdynmkt_journeyactivityid`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdynmkt_jsondata"></a> msdynmkt_jsondata

|Property|Value|
|---|---|
|Description||
|DisplayName|**Json data**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdynmkt_jsondata`|
|RequiredLevel|None|
|Type|Memo|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|150000|

### <a name="BKMK_msdynmkt_linkfriendlyname"></a> msdynmkt_linkfriendlyname

|Property|Value|
|---|---|
|Description|**The name of the custom entity.**|
|DisplayName|**Link friendly name**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdynmkt_linkfriendlyname`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdynmkt_links"></a> msdynmkt_links

|Property|Value|
|---|---|
|Description||
|DisplayName|**Links**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdynmkt_links`|
|RequiredLevel|None|
|Type|Memo|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|150000|

### <a name="BKMK_msdynmkt_messagetemplateid"></a> msdynmkt_messagetemplateid

|Property|Value|
|---|---|
|Description|**The name of the custom entity.**|
|DisplayName|**Message template**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdynmkt_messagetemplateid`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdynmkt_messagetemplateversion"></a> msdynmkt_messagetemplateversion

|Property|Value|
|---|---|
|Description|**The name of the custom entity.**|
|DisplayName|**Message template version**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdynmkt_messagetemplateversion`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdynmkt_messagevariationindexes"></a> msdynmkt_messagevariationindexes

|Property|Value|
|---|---|
|Description|**Message Variation Indexes**|
|DisplayName|**Message Variation Indexes**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdynmkt_messagevariationindexes`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|1024|

### <a name="BKMK_msdynmkt_messagevariationname"></a> msdynmkt_messagevariationname

|Property|Value|
|---|---|
|Description|**Message Variation Name**|
|DisplayName|**Message Variation Name**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdynmkt_messagevariationname`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|1024|

### <a name="BKMK_msdynmkt_profileid"></a> msdynmkt_profileid

|Property|Value|
|---|---|
|Description|**The name of the custom entity.**|
|DisplayName|**Customer Journey Id**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdynmkt_profileid`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|1024|

### <a name="BKMK_msdynmkt_sender"></a> msdynmkt_sender

|Property|Value|
|---|---|
|Description||
|DisplayName|**Sender**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdynmkt_sender`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|300|

### <a name="BKMK_msdynmkt_targeturl"></a> msdynmkt_targeturl

|Property|Value|
|---|---|
|Description|**The name of the custom entity.**|
|DisplayName|**Customer Journey Id**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdynmkt_targeturl`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|1024|

### <a name="BKMK_msdynmkt_trackingcontextId"></a> msdynmkt_trackingcontextId

|Property|Value|
|---|---|
|Description|**Unique identifier for entity instances**|
|DisplayName|**TrackingContext**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`msdynmkt_trackingcontextid`|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|

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

### <a name="BKMK_PartitionId"></a> PartitionId

|Property|Value|
|---|---|
|Description|**Logical partition id. A logical partition consists of a set of records with same partition id.**|
|DisplayName|**Partition Id**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`partitionid`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_TTLInSeconds"></a> TTLInSeconds

|Property|Value|
|---|---|
|Description|**Time to live in seconds.**|
|DisplayName|**Time to live**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`ttlinseconds`|
|RequiredLevel|None|
|Type|Integer|
|MaxValue|2147483647|
|MinValue|1|


## Read-only columns/attributes

These columns/attributes return false for both **IsValidForCreate** and **IsValidForUpdate**. Listed by **SchemaName**.

- [CreatedBy](#BKMK_CreatedBy)
- [CreatedOn](#BKMK_CreatedOn)
- [CreatedOnBehalfBy](#BKMK_CreatedOnBehalfBy)
- [ModifiedBy](#BKMK_ModifiedBy)
- [ModifiedOn](#BKMK_ModifiedOn)
- [ModifiedOnBehalfBy](#BKMK_ModifiedOnBehalfBy)
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

- [lk_msdynmkt_trackingcontext_createdby](#BKMK_lk_msdynmkt_trackingcontext_createdby)
- [lk_msdynmkt_trackingcontext_createdonbehalfby](#BKMK_lk_msdynmkt_trackingcontext_createdonbehalfby)
- [lk_msdynmkt_trackingcontext_modifiedby](#BKMK_lk_msdynmkt_trackingcontext_modifiedby)
- [lk_msdynmkt_trackingcontext_modifiedonbehalfby](#BKMK_lk_msdynmkt_trackingcontext_modifiedonbehalfby)

### <a name="BKMK_lk_msdynmkt_trackingcontext_createdby"></a> lk_msdynmkt_trackingcontext_createdby

One-To-Many Relationship: [systemuser lk_msdynmkt_trackingcontext_createdby](systemuser.md#BKMK_lk_msdynmkt_trackingcontext_createdby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdby`|
|ReferencingEntityNavigationPropertyName|`createdby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdynmkt_trackingcontext_createdonbehalfby"></a> lk_msdynmkt_trackingcontext_createdonbehalfby

One-To-Many Relationship: [systemuser lk_msdynmkt_trackingcontext_createdonbehalfby](systemuser.md#BKMK_lk_msdynmkt_trackingcontext_createdonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdonbehalfby`|
|ReferencingEntityNavigationPropertyName|`createdonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdynmkt_trackingcontext_modifiedby"></a> lk_msdynmkt_trackingcontext_modifiedby

One-To-Many Relationship: [systemuser lk_msdynmkt_trackingcontext_modifiedby](systemuser.md#BKMK_lk_msdynmkt_trackingcontext_modifiedby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedby`|
|ReferencingEntityNavigationPropertyName|`modifiedby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdynmkt_trackingcontext_modifiedonbehalfby"></a> lk_msdynmkt_trackingcontext_modifiedonbehalfby

One-To-Many Relationship: [systemuser lk_msdynmkt_trackingcontext_modifiedonbehalfby](systemuser.md#BKMK_lk_msdynmkt_trackingcontext_modifiedonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedonbehalfby`|
|ReferencingEntityNavigationPropertyName|`modifiedonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|



### See also

[Dataverse table/entity reference](/power-apps/developer/data-platform/reference/about-entity-reference)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   

