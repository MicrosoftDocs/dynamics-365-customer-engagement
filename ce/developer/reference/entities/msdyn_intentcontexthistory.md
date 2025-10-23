---
title: "Intent Context History (msdyn_IntentContextHistory) table/entity reference (Microsoft Dynamics 365)"
description: "Includes schema information and supported messages for the Intent Context History (msdyn_IntentContextHistory) table/entity with Microsoft Dynamics 365."
ms.topic: generated-reference
author: JimDaly
ms.author: jdaly
search.audienceType: 
  - developer
---

# Intent Context History (msdyn_IntentContextHistory) table/entity reference (Microsoft Dynamics 365)



## Messages

The following table lists the messages for the Intent Context History (msdyn_IntentContextHistory) table.
Messages represent operations that can be performed on the table. They may also be events.

| Name <br />Is Event? |Web API Operation |SDK for .NET |
| ---- | ----- |----- |
| `Associate`<br />Event: True |[Associate records](/power-apps/developer/data-platform/webapi/associate-disassociate-entities-using-web-api) |[Associate records](/power-apps/developer/data-platform/org-service/entity-operations-associate-disassociate#use-the-associate-method-or-associaterequest)|
| `BulkRetain`<br />Event: True |<xref:Microsoft.Dynamics.CRM.BulkRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Create`<br />Event: True |`POST` /msdyn_intentcontexthistories<br />See [Create](/powerapps/developer/data-platform/webapi/create-entity-web-api) |[Create records](/power-apps/developer/data-platform/org-service/entity-operations-create#basic-create)|
| `CreateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.CreateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.CreateMultipleRequest>|
| `Delete`<br />Event: True |`DELETE` /msdyn_intentcontexthistories(*msdyn_intentcontexthistoryid*)<br />See [Delete](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-delete) |[Delete records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-delete)|
| `DeleteMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.DeleteMultiple?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Disassociate`<br />Event: True |[Disassociate records](/power-apps/developer/data-platform/webapi/associate-disassociate-entities-using-web-api) |[Disassociate records](/power-apps/developer/data-platform/org-service/entity-operations-associate-disassociate#use-the-disassociate-method-or-disassociaterequest)|
| `PurgeRetainedContent`<br />Event: True |<xref:Microsoft.Dynamics.CRM.PurgeRetainedContent?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retain`<br />Event: True |<xref:Microsoft.Dynamics.CRM.Retain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retrieve`<br />Event: True |`GET` /msdyn_intentcontexthistories(*msdyn_intentcontexthistoryid*)<br />See [Retrieve](/powerapps/developer/data-platform/webapi/retrieve-entity-using-web-api) |[Retrieve records](/power-apps/developer/data-platform/org-service/entity-operations-retrieve)|
| `RetrieveEntityChanges`<br />Event: True | |<xref:Microsoft.Xrm.Sdk.Messages.RetrieveEntityChangesRequest>|
| `RetrieveMultiple`<br />Event: True |`GET` /msdyn_intentcontexthistories<br />See [Query data](/power-apps/developer/data-platform/webapi/query-data-web-api) |[Query data](/power-apps/developer/data-platform/org-service/entity-operations-query-data)|
| `RollbackRetain`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RollbackRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Update`<br />Event: True |`PATCH` /msdyn_intentcontexthistories(*msdyn_intentcontexthistoryid*)<br />See [Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) |[Update records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-update)|
| `UpdateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.UpdateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpdateMultipleRequest>|
| `Upsert`<br />Event: True |`PATCH` /msdyn_intentcontexthistories(*msdyn_intentcontexthistoryid*)<br />See [Upsert a table row](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#upsert-a-table-row) |<xref:Microsoft.Xrm.Sdk.Messages.UpsertRequest>|
| `UpsertMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.UpsertMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpsertMultipleRequest>|
| `ValidateRetentionConfig`<br />Event: True |<xref:Microsoft.Dynamics.CRM.ValidateRetentionConfig?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|

## Properties

The following table lists selected properties for the Intent Context History (msdyn_IntentContextHistory) table.

|Property|Value|
| --- | --- |
| **DisplayName** | **Intent Context History** |
| **DisplayCollectionName** | **Intent Context Histories** |
| **SchemaName** | `msdyn_IntentContextHistory` |
| **CollectionSchemaName** | `msdyn_IntentContextHistories` |
| **EntitySetName** | `msdyn_intentcontexthistories`|
| **LogicalName** | `msdyn_intentcontexthistory` |
| **LogicalCollectionName** | `msdyn_intentcontexthistories` |
| **PrimaryIdAttribute** | `msdyn_intentcontexthistoryid` |
| **PrimaryNameAttribute** |`msdyn_name` |
| **TableType** | `Elastic` |
| **OwnershipType** | `OrganizationOwned` |

## Writable columns/attributes

These columns/attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [ImportSequenceNumber](#BKMK_ImportSequenceNumber)
- [msdyn_AgentActivityType](#BKMK_msdyn_AgentActivityType)
- [msdyn_AgentType](#BKMK_msdyn_AgentType)
- [msdyn_CorrelationID](#BKMK_msdyn_CorrelationID)
- [msdyn_IntentContext](#BKMK_msdyn_IntentContext)
- [msdyn_IntentContextHistoryId](#BKMK_msdyn_IntentContextHistoryId)
- [msdyn_LastProcessedTimestamp](#BKMK_msdyn_LastProcessedTimestamp)
- [msdyn_Name](#BKMK_msdyn_Name)
- [msdyn_RelatedRecordEntityLogicalName](#BKMK_msdyn_RelatedRecordEntityLogicalName)
- [msdyn_RelatedRecordID](#BKMK_msdyn_RelatedRecordID)
- [msdyn_relatedrecordidIdType](#BKMK_msdyn_relatedrecordidIdType)
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

### <a name="BKMK_msdyn_AgentActivityType"></a> msdyn_AgentActivityType

|Property|Value|
|---|---|
|Description||
|DisplayName|**Agent Activity Type**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_agentactivitytype`|
|RequiredLevel|None|
|Type|Picklist|
|DefaultFormValue|-1|
|GlobalChoiceName|`msdyn_agentactivitytype`|

#### msdyn_AgentActivityType Choices/Options

|Value|Label|
|---|---|
|419550000|**Conversation End**|
|419550001|**Case Processing History**|

### <a name="BKMK_msdyn_AgentType"></a> msdyn_AgentType

|Property|Value|
|---|---|
|Description||
|DisplayName|**Agent Type**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_agenttype`|
|RequiredLevel|None|
|Type|Picklist|
|DefaultFormValue|-1|
|GlobalChoiceName|`msdyn_agenttype`|

#### msdyn_AgentType Choices/Options

|Value|Label|
|---|---|
|419550000|**Customer Engagement Agent**|
|419550001|**Case Processing Agent**|

### <a name="BKMK_msdyn_CorrelationID"></a> msdyn_CorrelationID

|Property|Value|
|---|---|
|Description||
|DisplayName|**Correlation ID**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_correlationid`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdyn_IntentContext"></a> msdyn_IntentContext

|Property|Value|
|---|---|
|Description||
|DisplayName|**Intent Context**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_intentcontext`|
|RequiredLevel|None|
|Type|Memo|
|Format|Text|
|FormatName|Json|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|1048576|

### <a name="BKMK_msdyn_IntentContextHistoryId"></a> msdyn_IntentContextHistoryId

|Property|Value|
|---|---|
|Description|**Unique identifier for entity instances**|
|DisplayName|**Intent Context History**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`msdyn_intentcontexthistoryid`|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|

### <a name="BKMK_msdyn_LastProcessedTimestamp"></a> msdyn_LastProcessedTimestamp

|Property|Value|
|---|---|
|Description||
|DisplayName|**Last Processed Timestamp**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_lastprocessedtimestamp`|
|RequiredLevel|None|
|Type|DateTime|
|CanChangeDateTimeBehavior|True|
|DateTimeBehavior|UserLocal|
|Format|DateAndTime|
|ImeMode|Auto|
|SourceTypeMask|0|

### <a name="BKMK_msdyn_Name"></a> msdyn_Name

|Property|Value|
|---|---|
|Description||
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
|MaxLength|850|

### <a name="BKMK_msdyn_RelatedRecordEntityLogicalName"></a> msdyn_RelatedRecordEntityLogicalName

|Property|Value|
|---|---|
|Description||
|DisplayName|**Related Record Entity Logical Name**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_relatedrecordentitylogicalname`|
|RequiredLevel|ApplicationRequired|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdyn_RelatedRecordID"></a> msdyn_RelatedRecordID

|Property|Value|
|---|---|
|Description|**Primary entity record the intent context is related to**|
|DisplayName|**Related Record**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_relatedrecordid`|
|RequiredLevel|ApplicationRequired|
|Type|Lookup|
|Targets|incident, msdyn_ocliveworkitem|

### <a name="BKMK_msdyn_relatedrecordidIdType"></a> msdyn_relatedrecordidIdType

|Property|Value|
|---|---|
|Description||
|DisplayName||
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`msdyn_relatedrecordididtype`|
|RequiredLevel|None|
|Type|EntityName|

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

- [lk_msdyn_intentcontexthistory_createdby](#BKMK_lk_msdyn_intentcontexthistory_createdby)
- [lk_msdyn_intentcontexthistory_createdonbehalfby](#BKMK_lk_msdyn_intentcontexthistory_createdonbehalfby)
- [lk_msdyn_intentcontexthistory_modifiedby](#BKMK_lk_msdyn_intentcontexthistory_modifiedby)
- [lk_msdyn_intentcontexthistory_modifiedonbehalfby](#BKMK_lk_msdyn_intentcontexthistory_modifiedonbehalfby)
- [msdyn_intentcontexthistory_poly_incident](#BKMK_msdyn_intentcontexthistory_poly_incident)
- [msdyn_intentcontexthistory_poly_msdyn_ocliveworkitem](#BKMK_msdyn_intentcontexthistory_poly_msdyn_ocliveworkitem)

### <a name="BKMK_lk_msdyn_intentcontexthistory_createdby"></a> lk_msdyn_intentcontexthistory_createdby

One-To-Many Relationship: [systemuser lk_msdyn_intentcontexthistory_createdby](systemuser.md#BKMK_lk_msdyn_intentcontexthistory_createdby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdby`|
|ReferencingEntityNavigationPropertyName|`createdby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_intentcontexthistory_createdonbehalfby"></a> lk_msdyn_intentcontexthistory_createdonbehalfby

One-To-Many Relationship: [systemuser lk_msdyn_intentcontexthistory_createdonbehalfby](systemuser.md#BKMK_lk_msdyn_intentcontexthistory_createdonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdonbehalfby`|
|ReferencingEntityNavigationPropertyName|`createdonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_intentcontexthistory_modifiedby"></a> lk_msdyn_intentcontexthistory_modifiedby

One-To-Many Relationship: [systemuser lk_msdyn_intentcontexthistory_modifiedby](systemuser.md#BKMK_lk_msdyn_intentcontexthistory_modifiedby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedby`|
|ReferencingEntityNavigationPropertyName|`modifiedby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_intentcontexthistory_modifiedonbehalfby"></a> lk_msdyn_intentcontexthistory_modifiedonbehalfby

One-To-Many Relationship: [systemuser lk_msdyn_intentcontexthistory_modifiedonbehalfby](systemuser.md#BKMK_lk_msdyn_intentcontexthistory_modifiedonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedonbehalfby`|
|ReferencingEntityNavigationPropertyName|`modifiedonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_intentcontexthistory_poly_incident"></a> msdyn_intentcontexthistory_poly_incident

One-To-Many Relationship: [incident msdyn_intentcontexthistory_poly_incident](incident.md#BKMK_msdyn_intentcontexthistory_poly_incident)

|Property|Value|
|---|---|
|ReferencedEntity|`incident`|
|ReferencedAttribute|`incidentid`|
|ReferencingAttribute|`msdyn_relatedrecordid`|
|ReferencingEntityNavigationPropertyName|`msdyn_relatedrecordid_incident`|
|IsHierarchical||
|CascadeConfiguration|Archive: `RemoveLink`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_intentcontexthistory_poly_msdyn_ocliveworkitem"></a> msdyn_intentcontexthistory_poly_msdyn_ocliveworkitem

One-To-Many Relationship: [msdyn_ocliveworkitem msdyn_intentcontexthistory_poly_msdyn_ocliveworkitem](msdyn_ocliveworkitem.md#BKMK_msdyn_intentcontexthistory_poly_msdyn_ocliveworkitem)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_ocliveworkitem`|
|ReferencedAttribute|`activityid`|
|ReferencingAttribute|`msdyn_relatedrecordid`|
|ReferencingEntityNavigationPropertyName|`msdyn_relatedrecordid_msdyn_ocliveworkitem`|
|IsHierarchical||
|CascadeConfiguration|Archive: `RemoveLink`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|



### See also

[Dataverse table/entity reference](/power-apps/developer/data-platform/reference/about-entity-reference)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   

