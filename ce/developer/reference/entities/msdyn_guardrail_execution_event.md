---
title: "msdyn_guardrail_execution_event table/entity reference (Microsoft Dynamics 365)"
description: "Includes schema information and supported messages for the msdyn_guardrail_execution_event table/entity with Microsoft Dynamics 365."
ms.topic: generated-reference
author: JimDaly
ms.author: jdaly
search.audienceType: 
  - developer
---

# msdyn_guardrail_execution_event table/entity reference (Microsoft Dynamics 365)

Elastic table for Governance execution info

## Messages

The following table lists the messages for the msdyn_guardrail_execution_event table.
Messages represent operations that can be performed on the table. They may also be events.

| Name <br />Is Event? |Web API Operation |SDK for .NET |
| ---- | ----- |----- |
| `Assign`<br />Event: True |`PATCH` /msdyn_guardrail_execution_events(*msdyn_guardrail_execution_eventid*)<br />[Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) the `ownerid` property. |<xref:Microsoft.Crm.Sdk.Messages.AssignRequest>|
| `Associate`<br />Event: True |[Associate records](/power-apps/developer/data-platform/webapi/associate-disassociate-entities-using-web-api) |[Associate records](/power-apps/developer/data-platform/org-service/entity-operations-associate-disassociate#use-the-associate-method-or-associaterequest)|
| `BulkRetain`<br />Event: True |<xref:Microsoft.Dynamics.CRM.BulkRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Create`<br />Event: True |`POST` /msdyn_guardrail_execution_events<br />See [Create](/powerapps/developer/data-platform/webapi/create-entity-web-api) |[Create records](/power-apps/developer/data-platform/org-service/entity-operations-create#basic-create)|
| `CreateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.CreateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.CreateMultipleRequest>|
| `Delete`<br />Event: True |`DELETE` /msdyn_guardrail_execution_events(*msdyn_guardrail_execution_eventid*)<br />See [Delete](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-delete) |[Delete records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-delete)|
| `DeleteMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.DeleteMultiple?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Disassociate`<br />Event: True |[Disassociate records](/power-apps/developer/data-platform/webapi/associate-disassociate-entities-using-web-api) |[Disassociate records](/power-apps/developer/data-platform/org-service/entity-operations-associate-disassociate#use-the-disassociate-method-or-disassociaterequest)|
| `PurgeRetainedContent`<br />Event: True |<xref:Microsoft.Dynamics.CRM.PurgeRetainedContent?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retain`<br />Event: True |<xref:Microsoft.Dynamics.CRM.Retain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retrieve`<br />Event: True |`GET` /msdyn_guardrail_execution_events(*msdyn_guardrail_execution_eventid*)<br />See [Retrieve](/powerapps/developer/data-platform/webapi/retrieve-entity-using-web-api) |[Retrieve records](/power-apps/developer/data-platform/org-service/entity-operations-retrieve)|
| `RetrieveEntityChanges`<br />Event: True | |<xref:Microsoft.Xrm.Sdk.Messages.RetrieveEntityChangesRequest>|
| `RetrieveMultiple`<br />Event: True |`GET` /msdyn_guardrail_execution_events<br />See [Query data](/power-apps/developer/data-platform/webapi/query-data-web-api) |[Query data](/power-apps/developer/data-platform/org-service/entity-operations-query-data)|
| `RetrievePrincipalAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RetrievePrincipalAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RetrievePrincipalAccessRequest>|
| `RollbackRetain`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RollbackRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Update`<br />Event: True |`PATCH` /msdyn_guardrail_execution_events(*msdyn_guardrail_execution_eventid*)<br />See [Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) |[Update records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-update)|
| `UpdateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.UpdateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpdateMultipleRequest>|
| `Upsert`<br />Event: True |`PATCH` /msdyn_guardrail_execution_events(*msdyn_guardrail_execution_eventid*)<br />See [Upsert a table row](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#upsert-a-table-row) |<xref:Microsoft.Xrm.Sdk.Messages.UpsertRequest>|
| `UpsertMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.UpsertMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpsertMultipleRequest>|
| `ValidateRetentionConfig`<br />Event: True |<xref:Microsoft.Dynamics.CRM.ValidateRetentionConfig?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|

## Properties

The following table lists selected properties for the msdyn_guardrail_execution_event table.

|Property|Value|
| --- | --- |
| **DisplayName** | **msdyn_guardrail_execution_event** |
| **DisplayCollectionName** | **msdyn_guardrail_execution_events** |
| **SchemaName** | `msdyn_guardrail_execution_event` |
| **CollectionSchemaName** | `msdyn_guardrail_execution_events` |
| **EntitySetName** | `msdyn_guardrail_execution_events`|
| **LogicalName** | `msdyn_guardrail_execution_event` |
| **LogicalCollectionName** | `msdyn_guardrail_execution_events` |
| **PrimaryIdAttribute** | `msdyn_guardrail_execution_eventid` |
| **PrimaryNameAttribute** |`msdyn_name` |
| **TableType** | `Elastic` |
| **OwnershipType** | `UserOwned` |

## Writable columns/attributes

These columns/attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [ImportSequenceNumber](#BKMK_ImportSequenceNumber)
- [msdyn_attachmentfilename](#BKMK_msdyn_attachmentfilename)
- [msdyn_attachmentid](#BKMK_msdyn_attachmentid)
- [msdyn_detectionaction](#BKMK_msdyn_detectionaction)
- [msdyn_error](#BKMK_msdyn_error)
- [msdyn_feedback](#BKMK_msdyn_feedback)
- [msdyn_guardrail_execution_eventId](#BKMK_msdyn_guardrail_execution_eventId)
- [msdyn_guardrail_ruleid](#BKMK_msdyn_guardrail_ruleid)
- [msdyn_guardrail_runid](#BKMK_msdyn_guardrail_runid)
- [msdyn_guardrail_scenariotypeid](#BKMK_msdyn_guardrail_scenariotypeid)
- [msdyn_invokedby](#BKMK_msdyn_invokedby)
- [msdyn_issendemail](#BKMK_msdyn_issendemail)
- [msdyn_isviolated](#BKMK_msdyn_isviolated)
- [msdyn_name](#BKMK_msdyn_name)
- [msdyn_objectid](#BKMK_msdyn_objectid)
- [msdyn_reason](#BKMK_msdyn_reason)
- [msdyn_regardingid](#BKMK_msdyn_regardingid)
- [msdyn_regardingtype](#BKMK_msdyn_regardingtype)
- [msdyn_score](#BKMK_msdyn_score)
- [msdyn_shadowmode](#BKMK_msdyn_shadowmode)
- [msdyn_version](#BKMK_msdyn_version)
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

### <a name="BKMK_msdyn_attachmentfilename"></a> msdyn_attachmentfilename

|Property|Value|
|---|---|
|Description|**Name of the file attachment that was validated**|
|DisplayName|**msdyn\_attachmentfilename**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_attachmentfilename`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|255|

### <a name="BKMK_msdyn_attachmentid"></a> msdyn_attachmentid

|Property|Value|
|---|---|
|Description|**ID of the attachment that was validated**|
|DisplayName|**msdyn\_attachmentid**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_attachmentid`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdyn_detectionaction"></a> msdyn_detectionaction

|Property|Value|
|---|---|
|Description|**type of action to be taken after guardrail execution**|
|DisplayName|**msdyn\_detectionaction**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_detectionaction`|
|RequiredLevel|None|
|Type|Picklist|
|DefaultFormValue|-1|
|GlobalChoiceName|`msdyn_guardrail_detection_action`|

#### msdyn_detectionaction Choices/Options

|Value|Label|
|---|---|
|192350000|**Log Only**|
|192350001|**Log and Block**|
|192350002|**Log and Warn**|

### <a name="BKMK_msdyn_error"></a> msdyn_error

|Property|Value|
|---|---|
|Description|**Error description**|
|DisplayName|**msdyn\_error**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_error`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|4000|

### <a name="BKMK_msdyn_feedback"></a> msdyn_feedback

|Property|Value|
|---|---|
|Description||
|DisplayName|**msdyn\_feedback**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_feedback`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdyn_guardrail_execution_eventId"></a> msdyn_guardrail_execution_eventId

|Property|Value|
|---|---|
|Description|**Unique identifier for entity instances**|
|DisplayName|**msdyn\_guardrail\_execution\_event**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`msdyn_guardrail_execution_eventid`|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|

### <a name="BKMK_msdyn_guardrail_ruleid"></a> msdyn_guardrail_ruleid

|Property|Value|
|---|---|
|Description|**Lookup record to guardrail rule table**|
|DisplayName|**msdyn\_guardrail\_ruleid**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_guardrail_ruleid`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdyn_guardrail_runid"></a> msdyn_guardrail_runid

|Property|Value|
|---|---|
|Description|**Guardrail Run ID linking guardrail execution records to a single validation run**|
|DisplayName|**msdyn\_guardrail\_runid**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_guardrail_runid`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdyn_guardrail_scenariotypeid"></a> msdyn_guardrail_scenariotypeid

|Property|Value|
|---|---|
|Description|**Lookup record to Guardrail Scenario type table**|
|DisplayName|**msdyn\_guardrail\_scenariotypeid**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_guardrail_scenariotypeid`|
|RequiredLevel|ApplicationRequired|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdyn_invokedby"></a> msdyn_invokedby

|Property|Value|
|---|---|
|Description|**User who invoked the guardrail validation plugin**|
|DisplayName|**msdyn\_invokedby**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_invokedby`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdyn_issendemail"></a> msdyn_issendemail

|Property|Value|
|---|---|
|Description|**Send Email Override**|
|DisplayName|**msdyn\_issendemail**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_issendemail`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`msdyn_guardrail_execution_event_msdyn_issendemail`|
|DefaultValue|False|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_msdyn_isviolated"></a> msdyn_isviolated

|Property|Value|
|---|---|
|Description|**Result whether guardrail rule is violated or not**|
|DisplayName|**msdyn\_isviolated**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_isviolated`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`msdyn_guardrail_execution_event_msdyn_isviolated`|
|DefaultValue|False|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_msdyn_name"></a> msdyn_name

|Property|Value|
|---|---|
|Description||
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
|MaxLength|850|

### <a name="BKMK_msdyn_objectid"></a> msdyn_objectid

|Property|Value|
|---|---|
|Description|**record for which guardrail validation was invoked**|
|DisplayName|**msdyn\_objectid**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_objectid`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdyn_reason"></a> msdyn_reason

|Property|Value|
|---|---|
|Description|**Violation reason description**|
|DisplayName|**msdyn\_reason**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_reason`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|4000|

### <a name="BKMK_msdyn_regardingid"></a> msdyn_regardingid

|Property|Value|
|---|---|
|Description|**related record on which applicable conditions would be checked**|
|DisplayName|**msdyn\_regardingid**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_regardingid`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdyn_regardingtype"></a> msdyn_regardingtype

|Property|Value|
|---|---|
|Description|**Entity logical name of reference record**|
|DisplayName|**msdyn\_regardingtype**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_regardingtype`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdyn_score"></a> msdyn_score

|Property|Value|
|---|---|
|Description|**The LLM-assigned compliance score (1-10) for this policy evaluation**|
|DisplayName|**msdyn\_score**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_score`|
|RequiredLevel|None|
|Type|Integer|
|MaxValue|10|
|MinValue|0|

### <a name="BKMK_msdyn_shadowmode"></a> msdyn_shadowmode

|Property|Value|
|---|---|
|Description|**Indicates if the record was generated when running in shadow mode**|
|DisplayName|**msdyn\_shadowmode**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_shadowmode`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`msdyn_guardrail_execution_event_msdyn_shadowmode`|
|DefaultValue|False|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_msdyn_version"></a> msdyn_version

|Property|Value|
|---|---|
|Description|**version of guardrail on which execution was done**|
|DisplayName|**msdyn\_version**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_version`|
|RequiredLevel|None|
|Type|Integer|
|MaxValue|2147483647|
|MinValue|-2147483648|

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

- [business_unit_msdyn_guardrail_execution_event](#BKMK_business_unit_msdyn_guardrail_execution_event)
- [lk_msdyn_guardrail_execution_event_createdby](#BKMK_lk_msdyn_guardrail_execution_event_createdby)
- [lk_msdyn_guardrail_execution_event_createdonbehalfby](#BKMK_lk_msdyn_guardrail_execution_event_createdonbehalfby)
- [lk_msdyn_guardrail_execution_event_modifiedby](#BKMK_lk_msdyn_guardrail_execution_event_modifiedby)
- [lk_msdyn_guardrail_execution_event_modifiedonbehalfby](#BKMK_lk_msdyn_guardrail_execution_event_modifiedonbehalfby)
- [owner_msdyn_guardrail_execution_event](#BKMK_owner_msdyn_guardrail_execution_event)
- [team_msdyn_guardrail_execution_event](#BKMK_team_msdyn_guardrail_execution_event)
- [user_msdyn_guardrail_execution_event](#BKMK_user_msdyn_guardrail_execution_event)

### <a name="BKMK_business_unit_msdyn_guardrail_execution_event"></a> business_unit_msdyn_guardrail_execution_event

One-To-Many Relationship: [businessunit business_unit_msdyn_guardrail_execution_event](businessunit.md#BKMK_business_unit_msdyn_guardrail_execution_event)

|Property|Value|
|---|---|
|ReferencedEntity|`businessunit`|
|ReferencedAttribute|`businessunitid`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencingEntityNavigationPropertyName|`owningbusinessunit`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_guardrail_execution_event_createdby"></a> lk_msdyn_guardrail_execution_event_createdby

One-To-Many Relationship: [systemuser lk_msdyn_guardrail_execution_event_createdby](systemuser.md#BKMK_lk_msdyn_guardrail_execution_event_createdby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdby`|
|ReferencingEntityNavigationPropertyName|`createdby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_guardrail_execution_event_createdonbehalfby"></a> lk_msdyn_guardrail_execution_event_createdonbehalfby

One-To-Many Relationship: [systemuser lk_msdyn_guardrail_execution_event_createdonbehalfby](systemuser.md#BKMK_lk_msdyn_guardrail_execution_event_createdonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdonbehalfby`|
|ReferencingEntityNavigationPropertyName|`createdonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_guardrail_execution_event_modifiedby"></a> lk_msdyn_guardrail_execution_event_modifiedby

One-To-Many Relationship: [systemuser lk_msdyn_guardrail_execution_event_modifiedby](systemuser.md#BKMK_lk_msdyn_guardrail_execution_event_modifiedby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedby`|
|ReferencingEntityNavigationPropertyName|`modifiedby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_guardrail_execution_event_modifiedonbehalfby"></a> lk_msdyn_guardrail_execution_event_modifiedonbehalfby

One-To-Many Relationship: [systemuser lk_msdyn_guardrail_execution_event_modifiedonbehalfby](systemuser.md#BKMK_lk_msdyn_guardrail_execution_event_modifiedonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedonbehalfby`|
|ReferencingEntityNavigationPropertyName|`modifiedonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_owner_msdyn_guardrail_execution_event"></a> owner_msdyn_guardrail_execution_event

One-To-Many Relationship: [owner owner_msdyn_guardrail_execution_event](owner.md#BKMK_owner_msdyn_guardrail_execution_event)

|Property|Value|
|---|---|
|ReferencedEntity|`owner`|
|ReferencedAttribute|`ownerid`|
|ReferencingAttribute|`ownerid`|
|ReferencingEntityNavigationPropertyName|`ownerid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_team_msdyn_guardrail_execution_event"></a> team_msdyn_guardrail_execution_event

One-To-Many Relationship: [team team_msdyn_guardrail_execution_event](team.md#BKMK_team_msdyn_guardrail_execution_event)

|Property|Value|
|---|---|
|ReferencedEntity|`team`|
|ReferencedAttribute|`teamid`|
|ReferencingAttribute|`owningteam`|
|ReferencingEntityNavigationPropertyName|`owningteam`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_user_msdyn_guardrail_execution_event"></a> user_msdyn_guardrail_execution_event

One-To-Many Relationship: [systemuser user_msdyn_guardrail_execution_event](systemuser.md#BKMK_user_msdyn_guardrail_execution_event)

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

