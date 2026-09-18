---
title: "Intent Harvesting Proposed Intent (msdyn_intentharvesting_proposedintent) table/entity reference (Microsoft Dynamics 365)"
description: "Includes schema information and supported messages for the Intent Harvesting Proposed Intent (msdyn_intentharvesting_proposedintent) table/entity with Microsoft Dynamics 365."
ms.topic: generated-reference
author: JimDaly
ms.author: jdaly
search.audienceType: 
  - developer
---

# Intent Harvesting Proposed Intent (msdyn_intentharvesting_proposedintent) table/entity reference (Microsoft Dynamics 365)

Captures the proposed unique natural language intent

## Messages

The following table lists the messages for the Intent Harvesting Proposed Intent (msdyn_intentharvesting_proposedintent) table.
Messages represent operations that can be performed on the table. They may also be events.

| Name <br />Is Event? |Web API Operation |SDK for .NET |
| ---- | ----- |----- |
| `Assign`<br />Event: True |`PATCH` /msdyn_intentharvesting_proposedintents(*msdyn_intentharvesting_proposedintentid*)<br />[Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) the `ownerid` property. |<xref:Microsoft.Crm.Sdk.Messages.AssignRequest>|
| `Associate`<br />Event: True |[Associate records](/power-apps/developer/data-platform/webapi/associate-disassociate-entities-using-web-api) |[Associate records](/power-apps/developer/data-platform/org-service/entity-operations-associate-disassociate#use-the-associate-method-or-associaterequest)|
| `BulkRetain`<br />Event: True |<xref:Microsoft.Dynamics.CRM.BulkRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Create`<br />Event: True |`POST` /msdyn_intentharvesting_proposedintents<br />See [Create](/powerapps/developer/data-platform/webapi/create-entity-web-api) |[Create records](/power-apps/developer/data-platform/org-service/entity-operations-create#basic-create)|
| `CreateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.CreateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.CreateMultipleRequest>|
| `Delete`<br />Event: True |`DELETE` /msdyn_intentharvesting_proposedintents(*msdyn_intentharvesting_proposedintentid*)<br />See [Delete](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-delete) |[Delete records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-delete)|
| `DeleteMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.DeleteMultiple?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Disassociate`<br />Event: True |[Disassociate records](/power-apps/developer/data-platform/webapi/associate-disassociate-entities-using-web-api) |[Disassociate records](/power-apps/developer/data-platform/org-service/entity-operations-associate-disassociate#use-the-disassociate-method-or-disassociaterequest)|
| `PurgeRetainedContent`<br />Event: True |<xref:Microsoft.Dynamics.CRM.PurgeRetainedContent?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retain`<br />Event: True |<xref:Microsoft.Dynamics.CRM.Retain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retrieve`<br />Event: True |`GET` /msdyn_intentharvesting_proposedintents(*msdyn_intentharvesting_proposedintentid*)<br />See [Retrieve](/powerapps/developer/data-platform/webapi/retrieve-entity-using-web-api) |[Retrieve records](/power-apps/developer/data-platform/org-service/entity-operations-retrieve)|
| `RetrieveEntityChanges`<br />Event: True | |<xref:Microsoft.Xrm.Sdk.Messages.RetrieveEntityChangesRequest>|
| `RetrieveMultiple`<br />Event: True |`GET` /msdyn_intentharvesting_proposedintents<br />See [Query data](/power-apps/developer/data-platform/webapi/query-data-web-api) |[Query data](/power-apps/developer/data-platform/org-service/entity-operations-query-data)|
| `RetrievePrincipalAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RetrievePrincipalAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RetrievePrincipalAccessRequest>|
| `RollbackRetain`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RollbackRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Update`<br />Event: True |`PATCH` /msdyn_intentharvesting_proposedintents(*msdyn_intentharvesting_proposedintentid*)<br />See [Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) |[Update records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-update)|
| `UpdateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.UpdateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpdateMultipleRequest>|
| `Upsert`<br />Event: True |`PATCH` /msdyn_intentharvesting_proposedintents(*msdyn_intentharvesting_proposedintentid*)<br />See [Upsert a table row](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#upsert-a-table-row) |<xref:Microsoft.Xrm.Sdk.Messages.UpsertRequest>|
| `UpsertMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.UpsertMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpsertMultipleRequest>|
| `ValidateRetentionConfig`<br />Event: True |<xref:Microsoft.Dynamics.CRM.ValidateRetentionConfig?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|

## Properties

The following table lists selected properties for the Intent Harvesting Proposed Intent (msdyn_intentharvesting_proposedintent) table.

|Property|Value|
| --- | --- |
| **DisplayName** | **Intent Harvesting Proposed Intent** |
| **DisplayCollectionName** | **Intent Harvesting Proposed Intents** |
| **SchemaName** | `msdyn_intentharvesting_proposedintent` |
| **CollectionSchemaName** | `msdyn_intentharvesting_proposedintents` |
| **EntitySetName** | `msdyn_intentharvesting_proposedintents`|
| **LogicalName** | `msdyn_intentharvesting_proposedintent` |
| **LogicalCollectionName** | `msdyn_intentharvesting_proposedintents` |
| **PrimaryIdAttribute** | `msdyn_intentharvesting_proposedintentid` |
| **PrimaryNameAttribute** |`msdyn_name` |
| **TableType** | `Elastic` |
| **OwnershipType** | `UserOwned` |

## Writable columns/attributes

These columns/attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [ImportSequenceNumber](#BKMK_ImportSequenceNumber)
- [msdyn_confidencescore](#BKMK_msdyn_confidencescore)
- [msdyn_confidencescoredetails](#BKMK_msdyn_confidencescoredetails)
- [msdyn_description](#BKMK_msdyn_description)
- [msdyn_harvestingsource](#BKMK_msdyn_harvestingsource)
- [msdyn_intentattributes](#BKMK_msdyn_intentattributes)
- [msdyn_intententities](#BKMK_msdyn_intententities)
- [msdyn_intentfamilyid](#BKMK_msdyn_intentfamilyid)
- [msdyn_intentharvesting_batchjobstatusid](#BKMK_msdyn_intentharvesting_batchjobstatusid)
- [msdyn_intentharvesting_proposedintentId](#BKMK_msdyn_intentharvesting_proposedintentId)
- [msdyn_intentid](#BKMK_msdyn_intentid)
- [msdyn_intentstring](#BKMK_msdyn_intentstring)
- [msdyn_isgroup](#BKMK_msdyn_isgroup)
- [msdyn_locale_code](#BKMK_msdyn_locale_code)
- [msdyn_miningdetails](#BKMK_msdyn_miningdetails)
- [msdyn_name](#BKMK_msdyn_name)
- [msdyn_occurrencecount](#BKMK_msdyn_occurrencecount)
- [msdyn_occurrencecount_last12months](#BKMK_msdyn_occurrencecount_last12months)
- [msdyn_occurrencecount_last30days](#BKMK_msdyn_occurrencecount_last30days)
- [msdyn_parentgroupintentid](#BKMK_msdyn_parentgroupintentid)
- [msdyn_reviewstate](#BKMK_msdyn_reviewstate)
- [msdyn_statecode](#BKMK_msdyn_statecode)
- [OverriddenCreatedOn](#BKMK_OverriddenCreatedOn)
- [OwnerId](#BKMK_OwnerId)
- [OwnerIdType](#BKMK_OwnerIdType)
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

### <a name="BKMK_msdyn_confidencescore"></a> msdyn_confidencescore

|Property|Value|
|---|---|
|Description||
|DisplayName|**Confidence Score**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_confidencescore`|
|RequiredLevel|None|
|Type|Double|
|ImeMode|Auto|
|MaxValue|1000000000|
|MinValue|0|
|Precision|2|

### <a name="BKMK_msdyn_confidencescoredetails"></a> msdyn_confidencescoredetails

|Property|Value|
|---|---|
|Description|**JSON formatted object with confidence scoring details**|
|DisplayName|**Confidence Score Details**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_confidencescoredetails`|
|RequiredLevel|None|
|Type|Memo|
|Format|Text|
|FormatName|Json|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|1048576|

### <a name="BKMK_msdyn_description"></a> msdyn_description

|Property|Value|
|---|---|
|Description|**Description for the intent or intent group**|
|DisplayName|**Description**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_description`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|4000|

### <a name="BKMK_msdyn_harvestingsource"></a> msdyn_harvestingsource

|Property|Value|
|---|---|
|Description||
|DisplayName|**Source**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_harvestingsource`|
|RequiredLevel|ApplicationRequired|
|Type|Picklist|
|DefaultFormValue|192350000|
|GlobalChoiceName|`msdyn_intent_source`|

#### msdyn_harvestingsource Choices/Options

|Value|Label|
|---|---|
|192350000|**Data Execution Run**|
|192350001|**Simulation**|
|192350002|**Manually Edited**|

### <a name="BKMK_msdyn_intentattributes"></a> msdyn_intentattributes

|Property|Value|
|---|---|
|Description|**JSON formatted list of related intent attributes**|
|DisplayName|**Intent Attributes**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_intentattributes`|
|RequiredLevel|None|
|Type|Memo|
|Format|Text|
|FormatName|Json|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|1048576|

### <a name="BKMK_msdyn_intententities"></a> msdyn_intententities

|Property|Value|
|---|---|
|Description|**JSON formatted list of related entities**|
|DisplayName|**Related Entities**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_intententities`|
|RequiredLevel|None|
|Type|Memo|
|Format|Text|
|FormatName|Json|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|1048576|

### <a name="BKMK_msdyn_intentfamilyid"></a> msdyn_intentfamilyid

|Property|Value|
|---|---|
|Description|**Lookup to msdyn\_intentfamily table**|
|DisplayName|**Intent Family Id**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_intentfamilyid`|
|RequiredLevel|ApplicationRequired|
|Type|Lookup|
|Targets|msdyn_intentfamily|

### <a name="BKMK_msdyn_intentharvesting_batchjobstatusid"></a> msdyn_intentharvesting_batchjobstatusid

|Property|Value|
|---|---|
|Description|**Look up to msdyn\_intentharvesting\_batchjobstatus table**|
|DisplayName|**Batch Job Status Id**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_intentharvesting_batchjobstatusid`|
|RequiredLevel|ApplicationRequired|
|Type|Lookup|
|Targets|msdyn_intentharvesting_batchjobstatus|

### <a name="BKMK_msdyn_intentharvesting_proposedintentId"></a> msdyn_intentharvesting_proposedintentId

|Property|Value|
|---|---|
|Description|**Unique identifier for entity instances**|
|DisplayName|**Intent Harvesting Proposed Intent**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`msdyn_intentharvesting_proposedintentid`|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|

### <a name="BKMK_msdyn_intentid"></a> msdyn_intentid

|Property|Value|
|---|---|
|Description|**Proposed intent unique identifier, used for correlation across runs**|
|DisplayName|**Intent Id**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`msdyn_intentid`|
|RequiredLevel|ApplicationRequired|
|Type|Uniqueidentifier|

### <a name="BKMK_msdyn_intentstring"></a> msdyn_intentstring

|Property|Value|
|---|---|
|Description|**Text of intent string**|
|DisplayName|**Intent String**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_intentstring`|
|RequiredLevel|ApplicationRequired|
|Type|Memo|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|2000|

### <a name="BKMK_msdyn_isgroup"></a> msdyn_isgroup

|Property|Value|
|---|---|
|Description|**Indicates if this is an intent group**|
|DisplayName|**Is Group**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_isgroup`|
|RequiredLevel|ApplicationRequired|
|Type|Boolean|
|GlobalChoiceName|`msdyn_intentharvesting_proposedintent_msdyn_isgroup`|
|DefaultValue|False|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_msdyn_locale_code"></a> msdyn_locale_code

|Property|Value|
|---|---|
|Description|**Locale code of the intent**|
|DisplayName|**msdyn\_locale\_code**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_locale_code`|
|RequiredLevel|None|
|Type|Memo|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|50|

### <a name="BKMK_msdyn_miningdetails"></a> msdyn_miningdetails

|Property|Value|
|---|---|
|Description|**JSON formatted object with intent mining details including update summary and reason**|
|DisplayName|**Mining Details**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_miningdetails`|
|RequiredLevel|None|
|Type|Memo|
|Format|Text|
|FormatName|Json|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|1048576|

### <a name="BKMK_msdyn_name"></a> msdyn_name

|Property|Value|
|---|---|
|Description|**The name of the intent.**|
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
|MaxLength|4000|

### <a name="BKMK_msdyn_occurrencecount"></a> msdyn_occurrencecount

|Property|Value|
|---|---|
|Description|**Occurrence count of the intent**|
|DisplayName|**Occurrence Count**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_occurrencecount`|
|RequiredLevel|None|
|Type|Integer|
|MaxValue|2147483647|
|MinValue|-2147483648|

### <a name="BKMK_msdyn_occurrencecount_last12months"></a> msdyn_occurrencecount_last12months

|Property|Value|
|---|---|
|Description|**Occurrence count of the intent in last 12 months**|
|DisplayName|**Occurrence Count (Last 12 Months)**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_occurrencecount_last12months`|
|RequiredLevel|None|
|Type|Integer|
|MaxValue|2147483647|
|MinValue|-2147483648|

### <a name="BKMK_msdyn_occurrencecount_last30days"></a> msdyn_occurrencecount_last30days

|Property|Value|
|---|---|
|Description|**Occurrence count of the intent in last 30 days**|
|DisplayName|**Occurrence Count (Last 30 Days)**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_occurrencecount_last30days`|
|RequiredLevel|None|
|Type|Integer|
|MaxValue|2147483647|
|MinValue|-2147483648|

### <a name="BKMK_msdyn_parentgroupintentid"></a> msdyn_parentgroupintentid

|Property|Value|
|---|---|
|Description|**Parent group intent unique identifier**|
|DisplayName|**Parent Group Intent Id**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`msdyn_parentgroupintentid`|
|RequiredLevel|None|
|Type|Uniqueidentifier|

### <a name="BKMK_msdyn_reviewstate"></a> msdyn_reviewstate

|Property|Value|
|---|---|
|Description||
|DisplayName|**Review State**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_reviewstate`|
|RequiredLevel|ApplicationRequired|
|Type|Picklist|
|DefaultFormValue|192350000|
|GlobalChoiceName|`msdyn_reviewstate`|

#### msdyn_reviewstate Choices/Options

|Value|Label|
|---|---|
|192350000|**Pending**|
|192350001|**Approved**|
|192350002|**Discarded**|

### <a name="BKMK_msdyn_statecode"></a> msdyn_statecode

|Property|Value|
|---|---|
|Description|**Status of the proposed intent**|
|DisplayName|**Status**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_statecode`|
|RequiredLevel|ApplicationRequired|
|Type|Picklist|
|DefaultFormValue|0|
|GlobalChoiceName|`msdyn_intentharvesting_proposedintent_msdyn_statecode`|

#### msdyn_statecode Choices/Options

|Value|Label|
|---|---|
|0|**Active**|
|1|**Inactive**|

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

- [business_unit_msdyn_intentharvesting_proposedintent](#BKMK_business_unit_msdyn_intentharvesting_proposedintent)
- [lk_msdyn_intentharvesting_proposedintent_createdby](#BKMK_lk_msdyn_intentharvesting_proposedintent_createdby)
- [lk_msdyn_intentharvesting_proposedintent_createdonbehalfby](#BKMK_lk_msdyn_intentharvesting_proposedintent_createdonbehalfby)
- [lk_msdyn_intentharvesting_proposedintent_modifiedby](#BKMK_lk_msdyn_intentharvesting_proposedintent_modifiedby)
- [lk_msdyn_intentharvesting_proposedintent_modifiedonbehalfby](#BKMK_lk_msdyn_intentharvesting_proposedintent_modifiedonbehalfby)
- [msdyn_intentharvesting_proposedintent_intentfamilyid](#BKMK_msdyn_intentharvesting_proposedintent_intentfamilyid)
- [owner_msdyn_intentharvesting_proposedintent](#BKMK_owner_msdyn_intentharvesting_proposedintent)
- [team_msdyn_intentharvesting_proposedintent](#BKMK_team_msdyn_intentharvesting_proposedintent)
- [user_msdyn_intentharvesting_proposedintent](#BKMK_user_msdyn_intentharvesting_proposedintent)

### <a name="BKMK_business_unit_msdyn_intentharvesting_proposedintent"></a> business_unit_msdyn_intentharvesting_proposedintent

One-To-Many Relationship: [businessunit business_unit_msdyn_intentharvesting_proposedintent](businessunit.md#BKMK_business_unit_msdyn_intentharvesting_proposedintent)

|Property|Value|
|---|---|
|ReferencedEntity|`businessunit`|
|ReferencedAttribute|`businessunitid`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencingEntityNavigationPropertyName|`owningbusinessunit`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_intentharvesting_proposedintent_createdby"></a> lk_msdyn_intentharvesting_proposedintent_createdby

One-To-Many Relationship: [systemuser lk_msdyn_intentharvesting_proposedintent_createdby](systemuser.md#BKMK_lk_msdyn_intentharvesting_proposedintent_createdby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdby`|
|ReferencingEntityNavigationPropertyName|`createdby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_intentharvesting_proposedintent_createdonbehalfby"></a> lk_msdyn_intentharvesting_proposedintent_createdonbehalfby

One-To-Many Relationship: [systemuser lk_msdyn_intentharvesting_proposedintent_createdonbehalfby](systemuser.md#BKMK_lk_msdyn_intentharvesting_proposedintent_createdonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdonbehalfby`|
|ReferencingEntityNavigationPropertyName|`createdonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_intentharvesting_proposedintent_modifiedby"></a> lk_msdyn_intentharvesting_proposedintent_modifiedby

One-To-Many Relationship: [systemuser lk_msdyn_intentharvesting_proposedintent_modifiedby](systemuser.md#BKMK_lk_msdyn_intentharvesting_proposedintent_modifiedby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedby`|
|ReferencingEntityNavigationPropertyName|`modifiedby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_intentharvesting_proposedintent_modifiedonbehalfby"></a> lk_msdyn_intentharvesting_proposedintent_modifiedonbehalfby

One-To-Many Relationship: [systemuser lk_msdyn_intentharvesting_proposedintent_modifiedonbehalfby](systemuser.md#BKMK_lk_msdyn_intentharvesting_proposedintent_modifiedonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedonbehalfby`|
|ReferencingEntityNavigationPropertyName|`modifiedonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_intentharvesting_proposedintent_intentfamilyid"></a> msdyn_intentharvesting_proposedintent_intentfamilyid

One-To-Many Relationship: [msdyn_intentfamily msdyn_intentharvesting_proposedintent_intentfamilyid](msdyn_intentfamily.md#BKMK_msdyn_intentharvesting_proposedintent_intentfamilyid)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_intentfamily`|
|ReferencedAttribute|`msdyn_intentfamilyid`|
|ReferencingAttribute|`msdyn_intentfamilyid`|
|ReferencingEntityNavigationPropertyName|`msdyn_intentfamilyid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_owner_msdyn_intentharvesting_proposedintent"></a> owner_msdyn_intentharvesting_proposedintent

One-To-Many Relationship: [owner owner_msdyn_intentharvesting_proposedintent](owner.md#BKMK_owner_msdyn_intentharvesting_proposedintent)

|Property|Value|
|---|---|
|ReferencedEntity|`owner`|
|ReferencedAttribute|`ownerid`|
|ReferencingAttribute|`ownerid`|
|ReferencingEntityNavigationPropertyName|`ownerid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_team_msdyn_intentharvesting_proposedintent"></a> team_msdyn_intentharvesting_proposedintent

One-To-Many Relationship: [team team_msdyn_intentharvesting_proposedintent](team.md#BKMK_team_msdyn_intentharvesting_proposedintent)

|Property|Value|
|---|---|
|ReferencedEntity|`team`|
|ReferencedAttribute|`teamid`|
|ReferencingAttribute|`owningteam`|
|ReferencingEntityNavigationPropertyName|`owningteam`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_user_msdyn_intentharvesting_proposedintent"></a> user_msdyn_intentharvesting_proposedintent

One-To-Many Relationship: [systemuser user_msdyn_intentharvesting_proposedintent](systemuser.md#BKMK_user_msdyn_intentharvesting_proposedintent)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`owninguser`|
|ReferencingEntityNavigationPropertyName|`owninguser`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|



### See also

[Dataverse table/entity reference](/power-apps/developer/data-platform/reference/about-entity-reference)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   

