---
title: "IoT Alert to Case Process (msdyn_iottocaseprocess) table/entity reference (Microsoft Dynamics 365)"
description: "Includes schema information and supported messages for the IoT Alert to Case Process (msdyn_iottocaseprocess) table/entity with Microsoft Dynamics 365."
ms.topic: generated-reference
author: JimDaly
ms.author: jdaly
search.audienceType: 
  - developer
---

# IoT Alert to Case Process (msdyn_iottocaseprocess) table/entity reference (Microsoft Dynamics 365)

Base entity for process IoT to Case Process

## Messages

The following table lists the messages for the IoT Alert to Case Process (msdyn_iottocaseprocess) table.
Messages represent operations that can be performed on the table. They may also be events.

| Name <br />Is Event? |Web API Operation |SDK for .NET |
| ---- | ----- |----- |
| `Associate`<br />Event: True |[Associate records](/power-apps/developer/data-platform/webapi/associate-disassociate-entities-using-web-api) |[Associate records](/power-apps/developer/data-platform/org-service/entity-operations-associate-disassociate#use-the-associate-method-or-associaterequest)|
| `BulkRetain`<br />Event: True |<xref:Microsoft.Dynamics.CRM.BulkRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Create`<br />Event: True |`POST` /msdyn_iottocaseprocesses<br />See [Create](/powerapps/developer/data-platform/webapi/create-entity-web-api) |[Create records](/power-apps/developer/data-platform/org-service/entity-operations-create#basic-create)|
| `CreateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.CreateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.CreateMultipleRequest>|
| `Delete`<br />Event: True |`DELETE` /msdyn_iottocaseprocesses(*businessprocessflowinstanceid*)<br />See [Delete](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-delete) |[Delete records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-delete)|
| `Disassociate`<br />Event: True |[Disassociate records](/power-apps/developer/data-platform/webapi/associate-disassociate-entities-using-web-api) |[Disassociate records](/power-apps/developer/data-platform/org-service/entity-operations-associate-disassociate#use-the-disassociate-method-or-disassociaterequest)|
| `IsValidStateTransition`<br />Event: False |<xref:Microsoft.Dynamics.CRM.IsValidStateTransition?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.IsValidStateTransitionRequest>|
| `PurgeRetainedContent`<br />Event: True |<xref:Microsoft.Dynamics.CRM.PurgeRetainedContent?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retain`<br />Event: True |<xref:Microsoft.Dynamics.CRM.Retain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retrieve`<br />Event: True |`GET` /msdyn_iottocaseprocesses(*businessprocessflowinstanceid*)<br />See [Retrieve](/powerapps/developer/data-platform/webapi/retrieve-entity-using-web-api) |[Retrieve records](/power-apps/developer/data-platform/org-service/entity-operations-retrieve)|
| `RetrieveMultiple`<br />Event: True |`GET` /msdyn_iottocaseprocesses<br />See [Query data](/power-apps/developer/data-platform/webapi/query-data-web-api) |[Query data](/power-apps/developer/data-platform/org-service/entity-operations-query-data)|
| `RollbackRetain`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RollbackRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `SetState`<br />Event: True |`PATCH` /msdyn_iottocaseprocesses(*businessprocessflowinstanceid*)<br />[Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) the `statecode` and `statuscode` properties. |<xref:Microsoft.Crm.Sdk.Messages.SetStateRequest>|
| `Update`<br />Event: True |`PATCH` /msdyn_iottocaseprocesses(*businessprocessflowinstanceid*)<br />See [Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) |[Update records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-update)|
| `UpdateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.UpdateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpdateMultipleRequest>|
| `Upsert`<br />Event: False |`PATCH` /msdyn_iottocaseprocesses(*businessprocessflowinstanceid*)<br />See [Upsert a table row](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#upsert-a-table-row) |<xref:Microsoft.Xrm.Sdk.Messages.UpsertRequest>|
| `UpsertMultiple`<br />Event: False |<xref:Microsoft.Dynamics.CRM.UpsertMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpsertMultipleRequest>|
| `ValidateRetentionConfig`<br />Event: True |<xref:Microsoft.Dynamics.CRM.ValidateRetentionConfig?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|

## Properties

The following table lists selected properties for the IoT Alert to Case Process (msdyn_iottocaseprocess) table.

|Property|Value|
| --- | --- |
| **DisplayName** | **IoT Alert to Case Process** |
| **DisplayCollectionName** | **IoT Alert to Case Process** |
| **SchemaName** | `msdyn_iottocaseprocess` |
| **CollectionSchemaName** | `msdyn_iottocaseprocesses` |
| **EntitySetName** | `msdyn_iottocaseprocesses`|
| **LogicalName** | `msdyn_iottocaseprocess` |
| **LogicalCollectionName** | `msdyn_iottocaseprocesses` |
| **PrimaryIdAttribute** | `businessprocessflowinstanceid` |
| **PrimaryNameAttribute** |`bpf_name` |
| **TableType** | `Standard` |
| **OwnershipType** | `OrganizationOwned` |

## Writable columns/attributes

These columns/attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [ActiveStageId](#BKMK_ActiveStageId)
- [ActiveStageStartedOn](#BKMK_ActiveStageStartedOn)
- [bpf_incidentid](#BKMK_bpf_incidentid)
- [bpf_msdyn_iotalertid](#BKMK_bpf_msdyn_iotalertid)
- [bpf_name](#BKMK_bpf_name)
- [BusinessProcessFlowInstanceId](#BKMK_BusinessProcessFlowInstanceId)
- [CompletedOn](#BKMK_CompletedOn)
- [ImportSequenceNumber](#BKMK_ImportSequenceNumber)
- [OverriddenCreatedOn](#BKMK_OverriddenCreatedOn)
- [ProcessId](#BKMK_ProcessId)
- [statecode](#BKMK_statecode)
- [statuscode](#BKMK_statuscode)
- [TimeZoneRuleVersionNumber](#BKMK_TimeZoneRuleVersionNumber)
- [TraversedPath](#BKMK_TraversedPath)
- [UTCConversionTimeZoneCode](#BKMK_UTCConversionTimeZoneCode)

### <a name="BKMK_ActiveStageId"></a> ActiveStageId

|Property|Value|
|---|---|
|Description|**Unique identifier of the active stage for the Business Process Flow instance.**|
|DisplayName|**Active Stage**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`activestageid`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|processstage|

### <a name="BKMK_ActiveStageStartedOn"></a> ActiveStageStartedOn

|Property|Value|
|---|---|
|Description|**Date and time when current active stage is started**|
|DisplayName|**Active Stage Started On**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`activestagestartedon`|
|RequiredLevel|None|
|Type|DateTime|
|CanChangeDateTimeBehavior|False|
|DateTimeBehavior|UserLocal|
|Format|DateOnly|
|ImeMode|Inactive|
|SourceTypeMask|0|

### <a name="BKMK_bpf_incidentid"></a> bpf_incidentid

|Property|Value|
|---|---|
|Description||
|DisplayName|**Incident**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`bpf_incidentid`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|incident|

### <a name="BKMK_bpf_msdyn_iotalertid"></a> bpf_msdyn_iotalertid

|Property|Value|
|---|---|
|Description||
|DisplayName|**Msdyn_Iotalert**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`bpf_msdyn_iotalertid`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|msdyn_iotalert|

### <a name="BKMK_bpf_name"></a> bpf_name

|Property|Value|
|---|---|
|Description|**Description**|
|DisplayName|**Name**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`bpf_name`|
|RequiredLevel|ApplicationRequired|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_BusinessProcessFlowInstanceId"></a> BusinessProcessFlowInstanceId

|Property|Value|
|---|---|
|Description|**Unique identifier for entity instances**|
|DisplayName|**IoT to Case Process**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`businessprocessflowinstanceid`|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|

### <a name="BKMK_CompletedOn"></a> CompletedOn

|Property|Value|
|---|---|
|Description|**Date and time when Business Process Flow instance is completed.**|
|DisplayName|**Completed On**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`completedon`|
|RequiredLevel|None|
|Type|DateTime|
|CanChangeDateTimeBehavior|False|
|DateTimeBehavior|UserLocal|
|Format|DateOnly|
|ImeMode|Inactive|
|SourceTypeMask|0|

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

### <a name="BKMK_ProcessId"></a> ProcessId

|Property|Value|
|---|---|
|Description|**Unique identifier of the workflow associated to the Business Process Flow instance.**|
|DisplayName|**Process**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`processid`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|workflow|

### <a name="BKMK_statecode"></a> statecode

|Property|Value|
|---|---|
|Description|**Status of the IoT to Case Process**|
|DisplayName|**Status**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statecode`|
|RequiredLevel|SystemRequired|
|Type|State|
|DefaultFormValue||
|GlobalChoiceName|`msdyn_iottocaseprocess_statecode`|

#### statecode Choices/Options

|Value|Details|
|---|---|
|0|Label: **Active**<br />DefaultStatus: 1<br />InvariantName: `Active`|
|1|Label: **Inactive**<br />DefaultStatus: 2<br />InvariantName: `Inactive`|

### <a name="BKMK_statuscode"></a> statuscode

|Property|Value|
|---|---|
|Description|**Reason for the status of the IoT to Case Process**|
|DisplayName|**Status Reason**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statuscode`|
|RequiredLevel|None|
|Type|Status|
|DefaultFormValue||
|GlobalChoiceName|`msdyn_iottocaseprocess_statuscode`|

#### statuscode Choices/Options

|Value|Details|
|---|---|
|1|Label: **Active**<br />State:0<br />TransitionData: None|
|2|Label: **Finished**<br />State:1<br />TransitionData: None|
|3|Label: **Aborted**<br />State:1<br />TransitionData: None|

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

### <a name="BKMK_TraversedPath"></a> TraversedPath

|Property|Value|
|---|---|
|Description|**Comma delimited string of process stage ids that represent visited stages of the Business Process Flow instance.**|
|DisplayName|**Traversed Path**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`traversedpath`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|1250|

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

- [bpf_Duration](#BKMK_bpf_Duration)
- [CreatedBy](#BKMK_CreatedBy)
- [CreatedOn](#BKMK_CreatedOn)
- [CreatedOnBehalfBy](#BKMK_CreatedOnBehalfBy)
- [ModifiedBy](#BKMK_ModifiedBy)
- [ModifiedOn](#BKMK_ModifiedOn)
- [ModifiedOnBehalfBy](#BKMK_ModifiedOnBehalfBy)
- [OrganizationId](#BKMK_OrganizationId)
- [VersionNumber](#BKMK_VersionNumber)

### <a name="BKMK_bpf_Duration"></a> bpf_Duration

|Property|Value|
|---|---|
|Description|**Duration of Business Process Flow**|
|DisplayName|**Duration**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`bpf_duration`|
|RequiredLevel|None|
|Type|Integer|
|MaxValue|2147483647|
|MinValue|0|

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
|Targets|organization|

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

- [bpf_incident_msdyn_iottocaseprocess](#BKMK_bpf_incident_msdyn_iottocaseprocess)
- [bpf_msdyn_iotalert_msdyn_iottocaseprocess](#BKMK_bpf_msdyn_iotalert_msdyn_iottocaseprocess)
- [lk_msdyn_iottocaseprocess_activestageid](#BKMK_lk_msdyn_iottocaseprocess_activestageid)
- [lk_msdyn_iottocaseprocess_createdby](#BKMK_lk_msdyn_iottocaseprocess_createdby)
- [lk_msdyn_iottocaseprocess_createdonbehalfby](#BKMK_lk_msdyn_iottocaseprocess_createdonbehalfby)
- [lk_msdyn_iottocaseprocess_modifiedby](#BKMK_lk_msdyn_iottocaseprocess_modifiedby)
- [lk_msdyn_iottocaseprocess_modifiedonbehalfby](#BKMK_lk_msdyn_iottocaseprocess_modifiedonbehalfby)
- [lk_msdyn_iottocaseprocess_processid](#BKMK_lk_msdyn_iottocaseprocess_processid)
- [organization_msdyn_iottocaseprocess](#BKMK_organization_msdyn_iottocaseprocess)

### <a name="BKMK_bpf_incident_msdyn_iottocaseprocess"></a> bpf_incident_msdyn_iottocaseprocess

One-To-Many Relationship: [incident bpf_incident_msdyn_iottocaseprocess](incident.md#BKMK_bpf_incident_msdyn_iottocaseprocess)

|Property|Value|
|---|---|
|ReferencedEntity|`incident`|
|ReferencedAttribute|`incidentid`|
|ReferencingAttribute|`bpf_incidentid`|
|ReferencingEntityNavigationPropertyName|`bpf_incidentid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_bpf_msdyn_iotalert_msdyn_iottocaseprocess"></a> bpf_msdyn_iotalert_msdyn_iottocaseprocess

One-To-Many Relationship: [msdyn_iotalert bpf_msdyn_iotalert_msdyn_iottocaseprocess](msdyn_iotalert.md#BKMK_bpf_msdyn_iotalert_msdyn_iottocaseprocess)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_iotalert`|
|ReferencedAttribute|`msdyn_iotalertid`|
|ReferencingAttribute|`bpf_msdyn_iotalertid`|
|ReferencingEntityNavigationPropertyName|`bpf_msdyn_iotalertid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_iottocaseprocess_activestageid"></a> lk_msdyn_iottocaseprocess_activestageid

One-To-Many Relationship: [processstage lk_msdyn_iottocaseprocess_activestageid](processstage.md#BKMK_lk_msdyn_iottocaseprocess_activestageid)

|Property|Value|
|---|---|
|ReferencedEntity|`processstage`|
|ReferencedAttribute|`processstageid`|
|ReferencingAttribute|`activestageid`|
|ReferencingEntityNavigationPropertyName|`activestageid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_iottocaseprocess_createdby"></a> lk_msdyn_iottocaseprocess_createdby

One-To-Many Relationship: [systemuser lk_msdyn_iottocaseprocess_createdby](systemuser.md#BKMK_lk_msdyn_iottocaseprocess_createdby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdby`|
|ReferencingEntityNavigationPropertyName|`createdby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_iottocaseprocess_createdonbehalfby"></a> lk_msdyn_iottocaseprocess_createdonbehalfby

One-To-Many Relationship: [systemuser lk_msdyn_iottocaseprocess_createdonbehalfby](systemuser.md#BKMK_lk_msdyn_iottocaseprocess_createdonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdonbehalfby`|
|ReferencingEntityNavigationPropertyName|`createdonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_iottocaseprocess_modifiedby"></a> lk_msdyn_iottocaseprocess_modifiedby

One-To-Many Relationship: [systemuser lk_msdyn_iottocaseprocess_modifiedby](systemuser.md#BKMK_lk_msdyn_iottocaseprocess_modifiedby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedby`|
|ReferencingEntityNavigationPropertyName|`modifiedby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_iottocaseprocess_modifiedonbehalfby"></a> lk_msdyn_iottocaseprocess_modifiedonbehalfby

One-To-Many Relationship: [systemuser lk_msdyn_iottocaseprocess_modifiedonbehalfby](systemuser.md#BKMK_lk_msdyn_iottocaseprocess_modifiedonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedonbehalfby`|
|ReferencingEntityNavigationPropertyName|`modifiedonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_iottocaseprocess_processid"></a> lk_msdyn_iottocaseprocess_processid

One-To-Many Relationship: [workflow lk_msdyn_iottocaseprocess_processid](workflow.md#BKMK_lk_msdyn_iottocaseprocess_processid)

|Property|Value|
|---|---|
|ReferencedEntity|`workflow`|
|ReferencedAttribute|`workflowid`|
|ReferencingAttribute|`processid`|
|ReferencingEntityNavigationPropertyName|`processid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_organization_msdyn_iottocaseprocess"></a> organization_msdyn_iottocaseprocess

One-To-Many Relationship: [organization organization_msdyn_iottocaseprocess](organization.md#BKMK_organization_msdyn_iottocaseprocess)

|Property|Value|
|---|---|
|ReferencedEntity|`organization`|
|ReferencedAttribute|`organizationid`|
|ReferencingAttribute|`organizationid`|
|ReferencingEntityNavigationPropertyName|`organizationid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|


## One-to-Many relationships

These relationships are one-to-many. Listed by **SchemaName**.

- [msdyn_iottocaseprocess_AsyncOperations](#BKMK_msdyn_iottocaseprocess_AsyncOperations)
- [msdyn_iottocaseprocess_BulkDeleteFailures](#BKMK_msdyn_iottocaseprocess_BulkDeleteFailures)
- [msdyn_iottocaseprocess_MailboxTrackingFolders](#BKMK_msdyn_iottocaseprocess_MailboxTrackingFolders)
- [msdyn_iottocaseprocess_PrincipalObjectAttributeAccesses](#BKMK_msdyn_iottocaseprocess_PrincipalObjectAttributeAccesses)
- [msdyn_iottocaseprocess_ProcessSession](#BKMK_msdyn_iottocaseprocess_ProcessSession)
- [msdyn_iottocaseprocess_SyncErrors](#BKMK_msdyn_iottocaseprocess_SyncErrors)
- [msdyn_iottocaseprocess_WorkflowLogs](#BKMK_msdyn_iottocaseprocess_WorkflowLogs)

### <a name="BKMK_msdyn_iottocaseprocess_AsyncOperations"></a> msdyn_iottocaseprocess_AsyncOperations

Many-To-One Relationship: [asyncoperation msdyn_iottocaseprocess_AsyncOperations](asyncoperation.md#BKMK_msdyn_iottocaseprocess_AsyncOperations)

|Property|Value|
|---|---|
|ReferencingEntity|`asyncoperation`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_iottocaseprocess_AsyncOperations`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_iottocaseprocess_BulkDeleteFailures"></a> msdyn_iottocaseprocess_BulkDeleteFailures

Many-To-One Relationship: [bulkdeletefailure msdyn_iottocaseprocess_BulkDeleteFailures](bulkdeletefailure.md#BKMK_msdyn_iottocaseprocess_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencingEntity|`bulkdeletefailure`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_iottocaseprocess_BulkDeleteFailures`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_iottocaseprocess_MailboxTrackingFolders"></a> msdyn_iottocaseprocess_MailboxTrackingFolders

Many-To-One Relationship: [mailboxtrackingfolder msdyn_iottocaseprocess_MailboxTrackingFolders](mailboxtrackingfolder.md#BKMK_msdyn_iottocaseprocess_MailboxTrackingFolders)

|Property|Value|
|---|---|
|ReferencingEntity|`mailboxtrackingfolder`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_iottocaseprocess_MailboxTrackingFolders`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_iottocaseprocess_PrincipalObjectAttributeAccesses"></a> msdyn_iottocaseprocess_PrincipalObjectAttributeAccesses

Many-To-One Relationship: [principalobjectattributeaccess msdyn_iottocaseprocess_PrincipalObjectAttributeAccesses](principalobjectattributeaccess.md#BKMK_msdyn_iottocaseprocess_PrincipalObjectAttributeAccesses)

|Property|Value|
|---|---|
|ReferencingEntity|`principalobjectattributeaccess`|
|ReferencingAttribute|`objectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_iottocaseprocess_PrincipalObjectAttributeAccesses`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_iottocaseprocess_ProcessSession"></a> msdyn_iottocaseprocess_ProcessSession

Many-To-One Relationship: [processsession msdyn_iottocaseprocess_ProcessSession](processsession.md#BKMK_msdyn_iottocaseprocess_ProcessSession)

|Property|Value|
|---|---|
|ReferencingEntity|`processsession`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_iottocaseprocess_ProcessSession`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_iottocaseprocess_SyncErrors"></a> msdyn_iottocaseprocess_SyncErrors

Many-To-One Relationship: [syncerror msdyn_iottocaseprocess_SyncErrors](syncerror.md#BKMK_msdyn_iottocaseprocess_SyncErrors)

|Property|Value|
|---|---|
|ReferencingEntity|`syncerror`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_iottocaseprocess_SyncErrors`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_iottocaseprocess_WorkflowLogs"></a> msdyn_iottocaseprocess_WorkflowLogs

Many-To-One Relationship: [workflowlog msdyn_iottocaseprocess_WorkflowLogs](workflowlog.md#BKMK_msdyn_iottocaseprocess_WorkflowLogs)

|Property|Value|
|---|---|
|ReferencingEntity|`workflowlog`|
|ReferencingAttribute|`asyncoperationid`|
|ReferencedEntityNavigationPropertyName|`msdyn_iottocaseprocess_WorkflowLogs`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|



### See also

[Dataverse table/entity reference](/power-apps/developer/data-platform/reference/about-entity-reference)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   

