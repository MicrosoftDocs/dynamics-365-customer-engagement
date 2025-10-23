---
title: "Work Queue Record (msdyn_workqueuerecord) table/entity reference (Microsoft Dynamics 365)"
description: "Includes schema information and supported messages for the Work Queue Record (msdyn_workqueuerecord) table/entity with Microsoft Dynamics 365."
ms.topic: generated-reference
author: JimDaly
ms.author: jdaly
search.audienceType: 
  - developer
---

# Work Queue Record (msdyn_workqueuerecord) table/entity reference (Microsoft Dynamics 365)

Entity created to store WorkQueue Data Model Records

## Messages

The following table lists the messages for the Work Queue Record (msdyn_workqueuerecord) table.
Messages represent operations that can be performed on the table. They may also be events.

| Name <br />Is Event? |Web API Operation |SDK for .NET |
| ---- | ----- |----- |
| `BulkRetain`<br />Event: True |<xref:Microsoft.Dynamics.CRM.BulkRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Create`<br />Event: True |`POST` /msdyn_workqueuerecords<br />See [Create](/powerapps/developer/data-platform/webapi/create-entity-web-api) |[Create records](/power-apps/developer/data-platform/org-service/entity-operations-create#basic-create)|
| `CreateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.CreateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.CreateMultipleRequest>|
| `Delete`<br />Event: True |`DELETE` /msdyn_workqueuerecords(*msdyn_workqueuerecordid*)<br />See [Delete](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-delete) |[Delete records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-delete)|
| `PurgeRetainedContent`<br />Event: True |<xref:Microsoft.Dynamics.CRM.PurgeRetainedContent?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retain`<br />Event: True |<xref:Microsoft.Dynamics.CRM.Retain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retrieve`<br />Event: True |`GET` /msdyn_workqueuerecords(*msdyn_workqueuerecordid*)<br />See [Retrieve](/powerapps/developer/data-platform/webapi/retrieve-entity-using-web-api) |[Retrieve records](/power-apps/developer/data-platform/org-service/entity-operations-retrieve)|
| `RetrieveEntityChanges`<br />Event: True | |<xref:Microsoft.Xrm.Sdk.Messages.RetrieveEntityChangesRequest>|
| `RetrieveMultiple`<br />Event: True |`GET` /msdyn_workqueuerecords<br />See [Query data](/power-apps/developer/data-platform/webapi/query-data-web-api) |[Query data](/power-apps/developer/data-platform/org-service/entity-operations-query-data)|
| `RollbackRetain`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RollbackRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Update`<br />Event: True |`PATCH` /msdyn_workqueuerecords(*msdyn_workqueuerecordid*)<br />See [Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) |[Update records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-update)|
| `UpdateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.UpdateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpdateMultipleRequest>|
| `Upsert`<br />Event: False |`PATCH` /msdyn_workqueuerecords(*msdyn_workqueuerecordid*)<br />See [Upsert a table row](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#upsert-a-table-row) |<xref:Microsoft.Xrm.Sdk.Messages.UpsertRequest>|
| `UpsertMultiple`<br />Event: False |<xref:Microsoft.Dynamics.CRM.UpsertMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpsertMultipleRequest>|
| `ValidateRetentionConfig`<br />Event: True |<xref:Microsoft.Dynamics.CRM.ValidateRetentionConfig?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|

## Properties

The following table lists selected properties for the Work Queue Record (msdyn_workqueuerecord) table.

|Property|Value|
| --- | --- |
| **DisplayName** | **Work Queue Record** |
| **DisplayCollectionName** | **workqueuerecord** |
| **SchemaName** | `msdyn_workqueuerecord` |
| **CollectionSchemaName** | `msdyn_workqueuerecords` |
| **EntitySetName** | `msdyn_workqueuerecords`|
| **LogicalName** | `msdyn_workqueuerecord` |
| **LogicalCollectionName** | `msdyn_workqueuerecords` |
| **PrimaryIdAttribute** | `msdyn_workqueuerecordid` |
| **PrimaryNameAttribute** |`msdyn_primaryname` |
| **TableType** | `Virtual` |
| **OwnershipType** | `OrganizationOwned` |

## Writable columns/attributes

These columns/attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [ImportSequenceNumber](#BKMK_ImportSequenceNumber)
- [msdyn_displayattributes](#BKMK_msdyn_displayattributes)
- [msdyn_duetime](#BKMK_msdyn_duetime)
- [msdyn_endtime](#BKMK_msdyn_endtime)
- [msdyn_entitysetname](#BKMK_msdyn_entitysetname)
- [msdyn_entitytypecode](#BKMK_msdyn_entitytypecode)
- [msdyn_entitytypedisplayname](#BKMK_msdyn_entitytypedisplayname)
- [msdyn_entitytypelogicalname](#BKMK_msdyn_entitytypelogicalname)
- [msdyn_filterattributes](#BKMK_msdyn_filterattributes)
- [msdyn_linkedactivityid](#BKMK_msdyn_linkedactivityid)
- [msdyn_nextactionerrorstate](#BKMK_msdyn_nextactionerrorstate)
- [msdyn_nextactionid](#BKMK_msdyn_nextactionid)
- [msdyn_nextactionname](#BKMK_msdyn_nextactionname)
- [msdyn_nextactionsource](#BKMK_msdyn_nextactionsource)
- [msdyn_nextactionsubtype](#BKMK_msdyn_nextactionsubtype)
- [msdyn_nextactiontype](#BKMK_msdyn_nextactiontype)
- [msdyn_nextactiontypedisplayname](#BKMK_msdyn_nextactiontypedisplayname)
- [msdyn_nextactionwaitstate](#BKMK_msdyn_nextactionwaitstate)
- [msdyn_operationparameter](#BKMK_msdyn_operationparameter)
- [msdyn_primaryentityid](#BKMK_msdyn_primaryentityid)
- [msdyn_primaryname](#BKMK_msdyn_primaryname)
- [msdyn_prioritygrade](#BKMK_msdyn_prioritygrade)
- [msdyn_priorityscore](#BKMK_msdyn_priorityscore)
- [msdyn_sequenceid](#BKMK_msdyn_sequenceid)
- [msdyn_sequencename](#BKMK_msdyn_sequencename)
- [msdyn_sequencestepid](#BKMK_msdyn_sequencestepid)
- [msdyn_sortattributes](#BKMK_msdyn_sortattributes)
- [msdyn_workqueuerecordId](#BKMK_msdyn_workqueuerecordId)

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

### <a name="BKMK_msdyn_displayattributes"></a> msdyn_displayattributes

|Property|Value|
|---|---|
|Description|**Display Attributes**|
|DisplayName|**Display Attributes**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_displayattributes`|
|RequiredLevel|None|
|Type|Memo|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|10000|

### <a name="BKMK_msdyn_duetime"></a> msdyn_duetime

|Property|Value|
|---|---|
|Description|**Next activity or Sequence step due time**|
|DisplayName|**Next Action Due time**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_duetime`|
|RequiredLevel|None|
|Type|DateTime|
|CanChangeDateTimeBehavior|True|
|DateTimeBehavior|UserLocal|
|Format|DateAndTime|
|ImeMode|Auto|
|SourceTypeMask|0|

### <a name="BKMK_msdyn_endtime"></a> msdyn_endtime

|Property|Value|
|---|---|
|Description|**Activity End time**|
|DisplayName|**Activity End time**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_endtime`|
|RequiredLevel|None|
|Type|DateTime|
|CanChangeDateTimeBehavior|True|
|DateTimeBehavior|UserLocal|
|Format|DateAndTime|
|ImeMode|Auto|
|SourceTypeMask|0|

### <a name="BKMK_msdyn_entitysetname"></a> msdyn_entitysetname

|Property|Value|
|---|---|
|Description|**Set Name of Entity.**|
|DisplayName|**Entity Set Name**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_entitysetname`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdyn_entitytypecode"></a> msdyn_entitytypecode

|Property|Value|
|---|---|
|Description|**Entity Type code for this entity.**|
|DisplayName|**Entity Type Code**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_entitytypecode`|
|RequiredLevel|None|
|Type|Integer|
|MaxValue|2147483647|
|MinValue|-2147483648|

### <a name="BKMK_msdyn_entitytypedisplayname"></a> msdyn_entitytypedisplayname

|Property|Value|
|---|---|
|Description|**Display Name of Entity Type.**|
|DisplayName|**EntityType Display Name**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_entitytypedisplayname`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdyn_entitytypelogicalname"></a> msdyn_entitytypelogicalname

|Property|Value|
|---|---|
|Description|**Logical Name of Entity Type.**|
|DisplayName|**EntityType Logical Name**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_entitytypelogicalname`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdyn_filterattributes"></a> msdyn_filterattributes

|Property|Value|
|---|---|
|Description|**Fields added for performing client side custom filtering.**|
|DisplayName|**Filter Attributes**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_filterattributes`|
|RequiredLevel|None|
|Type|Memo|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|1000000|

### <a name="BKMK_msdyn_linkedactivityid"></a> msdyn_linkedactivityid

|Property|Value|
|---|---|
|Description|**Unique identifier of the activity linked to the sequence step**|
|DisplayName|**Linked activity id**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_linkedactivityid`|
|RequiredLevel|None|
|Type|Uniqueidentifier|

### <a name="BKMK_msdyn_nextactionerrorstate"></a> msdyn_nextactionerrorstate

|Property|Value|
|---|---|
|Description|**Next action error state for this record.**|
|DisplayName|**Next action error state**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_nextactionerrorstate`|
|RequiredLevel|None|
|Type|Integer|
|MaxValue|2147483647|
|MinValue|-2147483648|

### <a name="BKMK_msdyn_nextactionid"></a> msdyn_nextactionid

|Property|Value|
|---|---|
|Description|**GUID for next action id.**|
|DisplayName|**Next Action Id**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_nextactionid`|
|RequiredLevel|None|
|Type|Uniqueidentifier|

### <a name="BKMK_msdyn_nextactionname"></a> msdyn_nextactionname

|Property|Value|
|---|---|
|Description|**Next action name from Sequence/Activity.**|
|DisplayName|**Next Action Name**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_nextactionname`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|80|

### <a name="BKMK_msdyn_nextactionsource"></a> msdyn_nextactionsource

|Property|Value|
|---|---|
|Description|**Source name for action from Sequence or Activity.**|
|DisplayName|**Next Action Source**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_nextactionsource`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|80|

### <a name="BKMK_msdyn_nextactionsubtype"></a> msdyn_nextactionsubtype

|Property|Value|
|---|---|
|Description|**Display Name for Next Action Sub Type.**|
|DisplayName|**Next Action Sub Type**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_nextactionsubtype`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdyn_nextactiontype"></a> msdyn_nextactiontype

|Property|Value|
|---|---|
|Description|**Activity Name or Sequence step like Email, Phone Call, Task etc.**|
|DisplayName|**Next Action Type**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_nextactiontype`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdyn_nextactiontypedisplayname"></a> msdyn_nextactiontypedisplayname

|Property|Value|
|---|---|
|Description|**Display Name for Next Action Type.**|
|DisplayName|**Next Action Type Display Name**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_nextactiontypedisplayname`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdyn_nextactionwaitstate"></a> msdyn_nextactionwaitstate

|Property|Value|
|---|---|
|Description|**Next action wait state for this record.**|
|DisplayName|**Next action wait state**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_nextactionwaitstate`|
|RequiredLevel|None|
|Type|Integer|
|MaxValue|2147483647|
|MinValue|-2147483648|

### <a name="BKMK_msdyn_operationparameter"></a> msdyn_operationparameter

|Property|Value|
|---|---|
|Description|**Sequence Operation Parameter.**|
|DisplayName|**Sequence Operation Parameter**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_operationparameter`|
|RequiredLevel|None|
|Type|Memo|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|2000|

### <a name="BKMK_msdyn_primaryentityid"></a> msdyn_primaryentityid

|Property|Value|
|---|---|
|Description|**Unique ID for entity record.**|
|DisplayName|**Primary Entity Id**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_primaryentityid`|
|RequiredLevel|ApplicationRequired|
|Type|Uniqueidentifier|

### <a name="BKMK_msdyn_primaryname"></a> msdyn_primaryname

|Property|Value|
|---|---|
|Description|**Name of the entity for the related workqueue record.**|
|DisplayName|**Primary Entity Name**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_primaryname`|
|RequiredLevel|ApplicationRequired|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdyn_prioritygrade"></a> msdyn_prioritygrade

|Property|Value|
|---|---|
|Description|**Priority grade for primary entity.**|
|DisplayName|**Priority Grade**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_prioritygrade`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|300|

### <a name="BKMK_msdyn_priorityscore"></a> msdyn_priorityscore

|Property|Value|
|---|---|
|Description|**Priority score for primary entity.**|
|DisplayName|**Priority Score**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_priorityscore`|
|RequiredLevel|None|
|Type|Decimal|
|ImeMode|Auto|
|MaxValue|100000000000|
|MinValue|-100000000000|
|Precision|2|
|SourceTypeMask|0|

### <a name="BKMK_msdyn_sequenceid"></a> msdyn_sequenceid

|Property|Value|
|---|---|
|Description|**GUID of sequence id.**|
|DisplayName|**Sequence Id**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_sequenceid`|
|RequiredLevel|None|
|Type|Uniqueidentifier|

### <a name="BKMK_msdyn_sequencename"></a> msdyn_sequencename

|Property|Value|
|---|---|
|Description|**Name of the Sequence**|
|DisplayName|**Sequence Name**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_sequencename`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|500|

### <a name="BKMK_msdyn_sequencestepid"></a> msdyn_sequencestepid

|Property|Value|
|---|---|
|Description|**GUID of sequence step id.**|
|DisplayName|**Sequence Step Id**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_sequencestepid`|
|RequiredLevel|None|
|Type|Uniqueidentifier|

### <a name="BKMK_msdyn_sortattributes"></a> msdyn_sortattributes

|Property|Value|
|---|---|
|Description|**Sort field values for performing client side sorting.**|
|DisplayName|**Sort Attributes**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_sortattributes`|
|RequiredLevel|None|
|Type|Memo|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|1000000|

### <a name="BKMK_msdyn_workqueuerecordId"></a> msdyn_workqueuerecordId

|Property|Value|
|---|---|
|Description|**Unique identifier for entity instances.**|
|DisplayName|**WorkQueue Record Id**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`msdyn_workqueuerecordid`|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|


## Read-only columns/attributes

These columns/attributes return false for both **IsValidForCreate** and **IsValidForUpdate**. Listed by **SchemaName**.

- [CreatedBy](#BKMK_CreatedBy)
- [CreatedOn](#BKMK_CreatedOn)
- [CreatedOnBehalfBy](#BKMK_CreatedOnBehalfBy)
- [ModifiedBy](#BKMK_ModifiedBy)
- [ModifiedOn](#BKMK_ModifiedOn)
- [ModifiedOnBehalfBy](#BKMK_ModifiedOnBehalfBy)

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
|Targets||

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
|Targets||

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
|Targets||

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
|ImeMode|Auto|
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
|Targets||



### See also

[Dataverse table/entity reference](/power-apps/developer/data-platform/reference/about-entity-reference)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   

