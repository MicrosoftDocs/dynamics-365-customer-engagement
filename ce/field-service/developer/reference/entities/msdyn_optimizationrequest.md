---
title: "Optimization Request (msdyn_OptimizationRequest) table/entity reference (Microsoft Dynamics 365 Field Service)"
description: "Includes schema information and supported messages for the Optimization Request (msdyn_OptimizationRequest) table/entity with Microsoft Dynamics 365 Field Service."
ms.topic: generated-reference
author: puneet-singh1
ms.author: puneetsingh
search.audienceType: 
  - developer
---

# Optimization Request (msdyn_OptimizationRequest) table/entity reference (Microsoft Dynamics 365 Field Service)



## Messages

The following table lists the messages for the Optimization Request (msdyn_OptimizationRequest) table.
Messages represent operations that can be performed on the table. They may also be events.

| Name <br />Is Event? |Web API Operation |SDK for .NET |
| ---- | ----- |----- |
| `Assign`<br />Event: True |`PATCH` /msdyn_optimizationrequests(*msdyn_optimizationrequestid*)<br />[Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) the `ownerid` property. |<xref:Microsoft.Crm.Sdk.Messages.AssignRequest>|
| `Associate`<br />Event: True |[Associate records](/power-apps/developer/data-platform/webapi/associate-disassociate-entities-using-web-api) |[Associate records](/power-apps/developer/data-platform/org-service/entity-operations-associate-disassociate#use-the-associate-method-or-associaterequest)|
| `BulkRetain`<br />Event: True |<xref:Microsoft.Dynamics.CRM.BulkRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Create`<br />Event: True |`POST` /msdyn_optimizationrequests<br />See [Create](/powerapps/developer/data-platform/webapi/create-entity-web-api) |[Create records](/power-apps/developer/data-platform/org-service/entity-operations-create#basic-create)|
| `CreateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.CreateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.CreateMultipleRequest>|
| `Delete`<br />Event: True |`DELETE` /msdyn_optimizationrequests(*msdyn_optimizationrequestid*)<br />See [Delete](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-delete) |[Delete records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-delete)|
| `DeleteMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.DeleteMultiple?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Disassociate`<br />Event: True |[Disassociate records](/power-apps/developer/data-platform/webapi/associate-disassociate-entities-using-web-api) |[Disassociate records](/power-apps/developer/data-platform/org-service/entity-operations-associate-disassociate#use-the-disassociate-method-or-disassociaterequest)|
| `PurgeRetainedContent`<br />Event: True |<xref:Microsoft.Dynamics.CRM.PurgeRetainedContent?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retain`<br />Event: True |<xref:Microsoft.Dynamics.CRM.Retain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retrieve`<br />Event: True |`GET` /msdyn_optimizationrequests(*msdyn_optimizationrequestid*)<br />See [Retrieve](/powerapps/developer/data-platform/webapi/retrieve-entity-using-web-api) |[Retrieve records](/power-apps/developer/data-platform/org-service/entity-operations-retrieve)|
| `RetrieveEntityChanges`<br />Event: True | |<xref:Microsoft.Xrm.Sdk.Messages.RetrieveEntityChangesRequest>|
| `RetrieveMultiple`<br />Event: True |`GET` /msdyn_optimizationrequests<br />See [Query data](/power-apps/developer/data-platform/webapi/query-data-web-api) |[Query data](/power-apps/developer/data-platform/org-service/entity-operations-query-data)|
| `RetrievePrincipalAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RetrievePrincipalAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RetrievePrincipalAccessRequest>|
| `RollbackRetain`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RollbackRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Update`<br />Event: True |`PATCH` /msdyn_optimizationrequests(*msdyn_optimizationrequestid*)<br />See [Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) |[Update records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-update)|
| `UpdateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.UpdateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpdateMultipleRequest>|
| `Upsert`<br />Event: True |`PATCH` /msdyn_optimizationrequests(*msdyn_optimizationrequestid*)<br />See [Upsert a table row](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#upsert-a-table-row) |<xref:Microsoft.Xrm.Sdk.Messages.UpsertRequest>|
| `UpsertMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.UpsertMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpsertMultipleRequest>|
| `ValidateRetentionConfig`<br />Event: True |<xref:Microsoft.Dynamics.CRM.ValidateRetentionConfig?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|

## Properties

The following table lists selected properties for the Optimization Request (msdyn_OptimizationRequest) table.

|Property|Value|
| --- | --- |
| **DisplayName** | **Optimization Request** |
| **DisplayCollectionName** | **Optimization Requests** |
| **SchemaName** | `msdyn_OptimizationRequest` |
| **CollectionSchemaName** | `msdyn_OptimizationRequests` |
| **EntitySetName** | `msdyn_optimizationrequests`|
| **LogicalName** | `msdyn_optimizationrequest` |
| **LogicalCollectionName** | `msdyn_optimizationrequests` |
| **PrimaryIdAttribute** | `msdyn_optimizationrequestid` |
| **PrimaryNameAttribute** |`msdyn_name` |
| **TableType** | `Elastic` |
| **OwnershipType** | `UserOwned` |

## Writable columns/attributes

These columns/attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [CreatedBy](#BKMK_CreatedBy)
- [CreatedOn](#BKMK_CreatedOn)
- [CreatedOnBehalfBy](#BKMK_CreatedOnBehalfBy)
- [ImportSequenceNumber](#BKMK_ImportSequenceNumber)
- [ModifiedBy](#BKMK_ModifiedBy)
- [ModifiedOn](#BKMK_ModifiedOn)
- [ModifiedOnBehalfBy](#BKMK_ModifiedOnBehalfBy)
- [msdyn_ApplyOperationId](#BKMK_msdyn_ApplyOperationId)
- [msdyn_BookingsQuery](#BKMK_msdyn_BookingsQuery)
- [msdyn_ExpiresOn](#BKMK_msdyn_ExpiresOn)
- [msdyn_GoalId](#BKMK_msdyn_GoalId)
- [msdyn_GoalObjectives](#BKMK_msdyn_GoalObjectives)
- [msdyn_GoalOptions](#BKMK_msdyn_GoalOptions)
- [msdyn_IncludeBookingsFromAllResources](#BKMK_msdyn_IncludeBookingsFromAllResources)
- [msdyn_IsAutomaticApply](#BKMK_msdyn_IsAutomaticApply)
- [msdyn_IsGoalOptionsOverridden](#BKMK_msdyn_IsGoalOptionsOverridden)
- [msdyn_Name](#BKMK_msdyn_Name)
- [msdyn_OptimizationErrors](#BKMK_msdyn_OptimizationErrors)
- [msdyn_OptimizationRequestId](#BKMK_msdyn_OptimizationRequestId)
- [msdyn_OptimizationRequestName](#BKMK_msdyn_OptimizationRequestName)
- [msdyn_OptimizationStatus](#BKMK_msdyn_OptimizationStatus)
- [msdyn_OptimizationType](#BKMK_msdyn_OptimizationType)
- [msdyn_RangeEndTime](#BKMK_msdyn_RangeEndTime)
- [msdyn_RangeStartTime](#BKMK_msdyn_RangeStartTime)
- [msdyn_RequestVersion](#BKMK_msdyn_RequestVersion)
- [msdyn_RequirementsQuery](#BKMK_msdyn_RequirementsQuery)
- [msdyn_ResourcesQuery](#BKMK_msdyn_ResourcesQuery)
- [msdyn_SchedulingOptimizationPlan](#BKMK_msdyn_SchedulingOptimizationPlan)
- [msdyn_ScopeId](#BKMK_msdyn_ScopeId)
- [msdyn_Snapshot](#BKMK_msdyn_Snapshot)
- [msdyn_StatusReason](#BKMK_msdyn_StatusReason)
- [msdyn_SuggestedSchedule](#BKMK_msdyn_SuggestedSchedule)
- [msdyn_UssOptimizationId](#BKMK_msdyn_UssOptimizationId)
- [msdyn_UssPayloadSnapshot](#BKMK_msdyn_UssPayloadSnapshot)
- [msdyn_UssSnapshot](#BKMK_msdyn_UssSnapshot)
- [OverriddenCreatedOn](#BKMK_OverriddenCreatedOn)
- [OwnerId](#BKMK_OwnerId)
- [OwnerIdType](#BKMK_OwnerIdType)
- [OwningTeam](#BKMK_OwningTeam)
- [OwningUser](#BKMK_OwningUser)
- [PartitionId](#BKMK_PartitionId)
- [TTLInSeconds](#BKMK_TTLInSeconds)

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

### <a name="BKMK_msdyn_ApplyOperationId"></a> msdyn_ApplyOperationId

|Property|Value|
|---|---|
|Description|**Apply Operation Id**|
|DisplayName|**Apply Operation Id**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_applyoperationid`|
|RequiredLevel|ApplicationRequired|
|Type|Uniqueidentifier|

### <a name="BKMK_msdyn_BookingsQuery"></a> msdyn_BookingsQuery

|Property|Value|
|---|---|
|Description|**FetchXML query for bookings**|
|DisplayName|**Bookings Query**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_bookingsquery`|
|RequiredLevel|None|
|Type|Memo|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|2000|

### <a name="BKMK_msdyn_ExpiresOn"></a> msdyn_ExpiresOn

|Property|Value|
|---|---|
|Description|**Date and time when the optimization request expires**|
|DisplayName|**Expires on**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_expireson`|
|RequiredLevel|None|
|Type|DateTime|
|CanChangeDateTimeBehavior|False|
|DateTimeBehavior|UserLocal|
|Format|DateAndTime|
|ImeMode|Auto|
|SourceTypeMask|0|

### <a name="BKMK_msdyn_GoalId"></a> msdyn_GoalId

|Property|Value|
|---|---|
|Description|**Goal ID for traceability**|
|DisplayName|**Goal**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_goalid`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|msdyn_schedulinggoal|

### <a name="BKMK_msdyn_GoalObjectives"></a> msdyn_GoalObjectives

|Property|Value|
|---|---|
|Description|**Optimization objectives stored as JSON**|
|DisplayName|**Goal Objectives**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_goalobjectives`|
|RequiredLevel|None|
|Type|Memo|
|Format|Text|
|FormatName|Json|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|1048576|

### <a name="BKMK_msdyn_GoalOptions"></a> msdyn_GoalOptions

|Property|Value|
|---|---|
|Description|**Optimization options stored as JSON**|
|DisplayName|**Goal Options**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_goaloptions`|
|RequiredLevel|None|
|Type|Memo|
|Format|Text|
|FormatName|Json|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|1048576|

### <a name="BKMK_msdyn_IncludeBookingsFromAllResources"></a> msdyn_IncludeBookingsFromAllResources

|Property|Value|
|---|---|
|Description|**Indicates whether this optimization included bookings from all resources or only from resources in the scheduling scope.**|
|DisplayName|**Included bookings from all resources**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_includebookingsfromallresources`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`msdyn_optimizationrequest_msdyn_includebookingsfromallresources`|
|DefaultValue|False|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_msdyn_IsAutomaticApply"></a> msdyn_IsAutomaticApply

|Property|Value|
|---|---|
|Description|**Whether to automatically apply optimization results**|
|DisplayName|**Is Automatic Apply**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_isautomaticapply`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`msdyn_optimizationrequest_msdyn_isautomaticapply`|
|DefaultValue|False|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_msdyn_IsGoalOptionsOverridden"></a> msdyn_IsGoalOptionsOverridden

|Property|Value|
|---|---|
|Description|**Whether goal options are overridden from default**|
|DisplayName|**Is Goal Options Overridden**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_isgoaloptionsoverridden`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`msdyn_optimizationrequest_msdyn_isgoaloptionsoverridden`|
|DefaultValue|False|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_msdyn_Name"></a> msdyn_Name

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
|MaxLength|100|

### <a name="BKMK_msdyn_OptimizationErrors"></a> msdyn_OptimizationErrors

|Property|Value|
|---|---|
|Description||
|DisplayName|**Optimization Errors**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_optimizationerrors`|
|RequiredLevel|None|
|Type|Memo|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|1048576|

### <a name="BKMK_msdyn_OptimizationRequestId"></a> msdyn_OptimizationRequestId

|Property|Value|
|---|---|
|Description|**Unique identifier for entity instances**|
|DisplayName|**Request ID**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`msdyn_optimizationrequestid`|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|

### <a name="BKMK_msdyn_OptimizationRequestName"></a> msdyn_OptimizationRequestName

|Property|Value|
|---|---|
|Description|**Optimization request name**|
|DisplayName|**Request name**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_optimizationrequestname`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdyn_OptimizationStatus"></a> msdyn_OptimizationStatus

|Property|Value|
|---|---|
|Description||
|DisplayName|**Status**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_optimizationstatus`|
|RequiredLevel|None|
|Type|Picklist|
|DefaultFormValue|772020004|
|GlobalChoiceName|`msdyn_optimizationstatus`|

#### msdyn_OptimizationStatus Choices/Options

|Value|Label|
|---|---|
|772020000|**Solving**|
|772020001|**Ready for Review**|
|772020002|**Failed**|
|772020003|**Skipped**|
|772020004|**New**|
|772020005|**Applying**|
|772020006|**Applied**|
|772020007|**Errors**|

### <a name="BKMK_msdyn_OptimizationType"></a> msdyn_OptimizationType

|Property|Value|
|---|---|
|Description||
|DisplayName|**Optimization Type**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_optimizationtype`|
|RequiredLevel|None|
|Type|Picklist|
|DefaultFormValue|-1|
|GlobalChoiceName|`msdyn_optimizationtype`|

#### msdyn_OptimizationType Choices/Options

|Value|Label|
|---|---|
|772020000|**Single Resource Optimization**|

### <a name="BKMK_msdyn_RangeEndTime"></a> msdyn_RangeEndTime

|Property|Value|
|---|---|
|Description|**Optimization time range end**|
|DisplayName|**End time**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_rangeendtime`|
|RequiredLevel|None|
|Type|DateTime|
|CanChangeDateTimeBehavior|False|
|DateTimeBehavior|UserLocal|
|Format|DateAndTime|
|ImeMode|Auto|
|SourceTypeMask|0|

### <a name="BKMK_msdyn_RangeStartTime"></a> msdyn_RangeStartTime

|Property|Value|
|---|---|
|Description|**Optimization time range start**|
|DisplayName|**Start time**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_rangestarttime`|
|RequiredLevel|None|
|Type|DateTime|
|CanChangeDateTimeBehavior|False|
|DateTimeBehavior|UserLocal|
|Format|DateAndTime|
|ImeMode|Auto|
|SourceTypeMask|0|

### <a name="BKMK_msdyn_RequestVersion"></a> msdyn_RequestVersion

|Property|Value|
|---|---|
|Description|**Version string for optimization request format**|
|DisplayName|**Request Version**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_requestversion`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|50|

### <a name="BKMK_msdyn_RequirementsQuery"></a> msdyn_RequirementsQuery

|Property|Value|
|---|---|
|Description|**FetchXML query for requirements**|
|DisplayName|**Requirements Query**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_requirementsquery`|
|RequiredLevel|None|
|Type|Memo|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|2000|

### <a name="BKMK_msdyn_ResourcesQuery"></a> msdyn_ResourcesQuery

|Property|Value|
|---|---|
|Description|**FetchXML query for resources**|
|DisplayName|**Resources Query**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_resourcesquery`|
|RequiredLevel|None|
|Type|Memo|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|2000|

### <a name="BKMK_msdyn_SchedulingOptimizationPlan"></a> msdyn_SchedulingOptimizationPlan

|Property|Value|
|---|---|
|Description|**Reference to optimization plan**|
|DisplayName|**Scheduling Optimization Plan**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_schedulingoptimizationplan`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|msdyn_schedulingoptimizationplan|

### <a name="BKMK_msdyn_ScopeId"></a> msdyn_ScopeId

|Property|Value|
|---|---|
|Description|**Reference to scheduling scope**|
|DisplayName|**Scope**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_scopeid`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|msdyn_schedulingscope|

### <a name="BKMK_msdyn_Snapshot"></a> msdyn_Snapshot

|Property|Value|
|---|---|
|Description||
|DisplayName|**Snapshot**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_snapshot`|
|RequiredLevel|None|
|Type|Memo|
|Format|Text|
|FormatName|Json|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|1048576|

### <a name="BKMK_msdyn_StatusReason"></a> msdyn_StatusReason

|Property|Value|
|---|---|
|Description|**Detailed explanation of optimization status**|
|DisplayName|**Status Reason**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_statusreason`|
|RequiredLevel|None|
|Type|Memo|
|Format|Text|
|FormatName|Json|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|1048576|

### <a name="BKMK_msdyn_SuggestedSchedule"></a> msdyn_SuggestedSchedule

|Property|Value|
|---|---|
|Description||
|DisplayName|**Suggested Schedule**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_suggestedschedule`|
|RequiredLevel|None|
|Type|Memo|
|Format|Text|
|FormatName|Json|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|1048576|

### <a name="BKMK_msdyn_UssOptimizationId"></a> msdyn_UssOptimizationId

|Property|Value|
|---|---|
|Description|**Optimization Id from Universal Scheduling Service**|
|DisplayName|**USS Optimization Id**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_ussoptimizationid`|
|RequiredLevel|ApplicationRequired|
|Type|Uniqueidentifier|

### <a name="BKMK_msdyn_UssPayloadSnapshot"></a> msdyn_UssPayloadSnapshot

|Property|Value|
|---|---|
|Description|**USS payload snapshot**|
|DisplayName|**USS Payload Snapshot**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_usspayloadsnapshot`|
|RequiredLevel|None|
|Type|Memo|
|Format|Text|
|FormatName|Json|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|1048576|

### <a name="BKMK_msdyn_UssSnapshot"></a> msdyn_UssSnapshot

|Property|Value|
|---|---|
|Description||
|DisplayName|**USS Snapshot**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_usssnapshot`|
|RequiredLevel|None|
|Type|Memo|
|Format|Text|
|FormatName|Json|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|1048576|

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

- [OwnerIdName](#BKMK_OwnerIdName)
- [OwnerIdYomiName](#BKMK_OwnerIdYomiName)
- [OwningBusinessUnit](#BKMK_OwningBusinessUnit)
- [VersionNumber](#BKMK_VersionNumber)

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

- [msdyn_optimizationrequest_goalid_msdyn_schedulinggoal](#BKMK_msdyn_optimizationrequest_goalid_msdyn_schedulinggoal)
- [msdyn_schedulingoptimizationplan_optimizationrequest_msdyn_optimizationrequest](#BKMK_msdyn_schedulingoptimizationplan_optimizationrequest_msdyn_optimizationrequest)

### <a name="BKMK_msdyn_optimizationrequest_goalid_msdyn_schedulinggoal"></a> msdyn_optimizationrequest_goalid_msdyn_schedulinggoal

One-To-Many Relationship: [msdyn_schedulinggoal msdyn_optimizationrequest_goalid_msdyn_schedulinggoal](msdyn_schedulinggoal.md#BKMK_msdyn_optimizationrequest_goalid_msdyn_schedulinggoal)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_schedulinggoal`|
|ReferencedAttribute|`msdyn_schedulinggoalid`|
|ReferencingAttribute|`msdyn_goalid`|
|ReferencingEntityNavigationPropertyName|`msdyn_GoalId`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_schedulingoptimizationplan_optimizationrequest_msdyn_optimizationrequest"></a> msdyn_schedulingoptimizationplan_optimizationrequest_msdyn_optimizationrequest

One-To-Many Relationship: [msdyn_schedulingoptimizationplan msdyn_schedulingoptimizationplan_optimizationrequest_msdyn_optimizationrequest](msdyn_schedulingoptimizationplan.md#BKMK_msdyn_schedulingoptimizationplan_optimizationrequest_msdyn_optimizationrequest)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_schedulingoptimizationplan`|
|ReferencedAttribute|`msdyn_schedulingoptimizationplanid`|
|ReferencingAttribute|`msdyn_schedulingoptimizationplan`|
|ReferencingEntityNavigationPropertyName|`msdyn_schedulingoptimizationplan`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|



### See also

[Dataverse table/entity reference](/power-apps/developer/data-platform/reference/about-entity-reference)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   

