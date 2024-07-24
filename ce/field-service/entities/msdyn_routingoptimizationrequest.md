---
title: "Scheduling Optimization Request (msdyn_routingoptimizationrequest) table/entity reference (Microsoft Dynamics 365 Field Service)"
description: "Includes schema information and supported messages for the Scheduling Optimization Request (msdyn_routingoptimizationrequest) table/entity with Microsoft Dynamics 365 Field Service."
ms.date: 07.24.2024
ms.service: powerapps
ms.topic: reference
author: m-hartmann
ms.author: mhart
search.audienceType: 
  - developer
---

# Scheduling Optimization Request (msdyn_routingoptimizationrequest) table/entity reference



## Messages

The following table lists the messages for the Scheduling Optimization Request (msdyn_routingoptimizationrequest) table.
Messages represent operations that can be performed on the table. They may also be events.

| Name <br />Is Event? |Web API Operation |SDK for .NET |
| ---- | ----- |----- |
| `Assign`<br />Event: True |`PATCH` /msdyn_routingoptimizationrequests(*msdyn_routingoptimizationrequestid*)<br />[Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) the `ownerid` property. |<xref:Microsoft.Crm.Sdk.Messages.AssignRequest>|
| `Create`<br />Event: True |`POST` /msdyn_routingoptimizationrequests<br />See [Create](/powerapps/developer/data-platform/webapi/create-entity-web-api) |[Create records](/power-apps/developer/data-platform/org-service/entity-operations-create#basic-create)|
| `CreateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.CreateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.CreateMultipleRequest>|
| `Delete`<br />Event: True |`DELETE` /msdyn_routingoptimizationrequests(*msdyn_routingoptimizationrequestid*)<br />See [Delete](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-delete) |[Delete records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-delete)|
| `GrantAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.GrantAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.GrantAccessRequest>|
| `IsValidStateTransition`<br />Event: False |<xref:Microsoft.Dynamics.CRM.IsValidStateTransition?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.IsValidStateTransitionRequest>|
| `ModifyAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.ModifyAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.ModifyAccessRequest>|
| `Restore`<br />Event: True |<xref:Microsoft.Dynamics.CRM.Restore?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retrieve`<br />Event: True |`GET` /msdyn_routingoptimizationrequests(*msdyn_routingoptimizationrequestid*)<br />See [Retrieve](/powerapps/developer/data-platform/webapi/retrieve-entity-using-web-api) |[Retrieve records](/power-apps/developer/data-platform/org-service/entity-operations-retrieve)|
| `RetrieveMultiple`<br />Event: True |`GET` /msdyn_routingoptimizationrequests<br />See [Query data](/power-apps/developer/data-platform/webapi/query-data-web-api) |[Query data](/power-apps/developer/data-platform/org-service/entity-operations-query-data)|
| `RetrievePrincipalAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RetrievePrincipalAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RetrievePrincipalAccessRequest>|
| `RetrieveSharedPrincipalsAndAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RetrieveSharedPrincipalsAndAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RetrieveSharedPrincipalsAndAccessRequest>|
| `RevokeAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RevokeAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RevokeAccessRequest>|
| `SetState`<br />Event: True |`PATCH` /msdyn_routingoptimizationrequests(*msdyn_routingoptimizationrequestid*)<br />[Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) the `statecode` and `statuscode` properties. |<xref:Microsoft.Crm.Sdk.Messages.SetStateRequest>|
| `Update`<br />Event: True |`PATCH` /msdyn_routingoptimizationrequests(*msdyn_routingoptimizationrequestid*)<br />See [Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) |[Update records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-update)|
| `UpdateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.UpdateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpdateMultipleRequest>|
| `Upsert`<br />Event: False |`PATCH` /msdyn_routingoptimizationrequests(*msdyn_routingoptimizationrequestid*)<br />See [Upsert a table row](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#upsert-a-table-row) |<xref:Microsoft.Xrm.Sdk.Messages.UpsertRequest>|
| `UpsertMultiple`<br />Event: False |<xref:Microsoft.Dynamics.CRM.UpsertMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpsertMultipleRequest>|


## Events

The following table lists the events for the Scheduling Optimization Request (msdyn_routingoptimizationrequest) table.
Events are messages that exist so that you can subscribe to them. Unless you added the event, you shouldn't invoke the message, only subscribe to it.

|Name|Web API Operation |SDK for .NET |
| ---- | ----- |----- |
| `BulkRetain`|<xref:Microsoft.Dynamics.CRM.BulkRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `PurgeRetainedContent`|<xref:Microsoft.Dynamics.CRM.PurgeRetainedContent?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retain`|<xref:Microsoft.Dynamics.CRM.Retain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `RollbackRetain`|<xref:Microsoft.Dynamics.CRM.RollbackRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `ValidateRetentionConfig`|<xref:Microsoft.Dynamics.CRM.ValidateRetentionConfig?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|

## Properties

The following table lists selected properties for the Scheduling Optimization Request (msdyn_routingoptimizationrequest) table.

|Property|Value|
| --- | --- |
| **DisplayName** | **Scheduling Optimization Request** |
| **DisplayCollectionName** | **Scheduling Optimization Requests** |
| **SchemaName** | `msdyn_routingoptimizationrequest` |
| **CollectionSchemaName** | `msdyn_routingoptimizationrequests` |
| **EntitySetName** | `msdyn_routingoptimizationrequests`|
| **LogicalName** | `msdyn_routingoptimizationrequest` |
| **LogicalCollectionName** | `msdyn_routingoptimizationrequests` |
| **PrimaryIdAttribute** | `msdyn_routingoptimizationrequestid` |
| **PrimaryNameAttribute** |`msdyn_requestid` |
| **TableType** | `Standard` |
| **OwnershipType** | `UserOwned` |

## Writable columns/attributes

These columns/attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [ImportSequenceNumber](#BKMK_ImportSequenceNumber)
- [msdyn_BlockingSchedule](#BKMK_msdyn_BlockingSchedule)
- [msdyn_CommitMode](#BKMK_msdyn_CommitMode)
- [msdyn_EndRange](#BKMK_msdyn_EndRange)
- [msdyn_issimulation](#BKMK_msdyn_issimulation)
- [msdyn_LastUpdated](#BKMK_msdyn_LastUpdated)
- [msdyn_Message](#BKMK_msdyn_Message)
- [msdyn_OptimizationStatus](#BKMK_msdyn_OptimizationStatus)
- [msdyn_requestId](#BKMK_msdyn_requestId)
- [msdyn_requestName](#BKMK_msdyn_requestName)
- [msdyn_RoutingConfiguration](#BKMK_msdyn_RoutingConfiguration)
- [msdyn_routingoptimizationrequestId](#BKMK_msdyn_routingoptimizationrequestId)
- [msdyn_SchedulingOptimizationGoal](#BKMK_msdyn_SchedulingOptimizationGoal)
- [msdyn_SchedulingOptimizationScope](#BKMK_msdyn_SchedulingOptimizationScope)
- [msdyn_SourceAutoRoutingSchedule](#BKMK_msdyn_SourceAutoRoutingSchedule)
- [msdyn_StartRange](#BKMK_msdyn_StartRange)
- [msdyn_travelTimeCalculation](#BKMK_msdyn_travelTimeCalculation)
- [msdyn_type](#BKMK_msdyn_type)
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

### <a name="BKMK_msdyn_BlockingSchedule"></a> msdyn_BlockingSchedule

|Property|Value|
|---|---|
|Description|**Optimization schedule that blocked the execution of this request.**|
|DisplayName|**Blocking Optimization Schedule**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_blockingschedule`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|msdyn_routingprofileconfiguration|

### <a name="BKMK_msdyn_CommitMode"></a> msdyn_CommitMode

|Property|Value|
|---|---|
|Description||
|DisplayName|**Commit Mode**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_commitmode`|
|RequiredLevel|None|
|Type|Picklist|
|DefaultFormValue|192350000|
|GlobalChoiceName|`msdyn_routingoptimizationrequest_msdyn_commitmode`|

#### msdyn_CommitMode Choices/Options

|Value|Label|
|---|---|
|192350000|**Book**|
|192350001|**Suggest**|

### <a name="BKMK_msdyn_EndRange"></a> msdyn_EndRange

|Property|Value|
|---|---|
|Description|**The end date and time of this optimization range**|
|DisplayName|**Optimization Range End**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_endrange`|
|RequiredLevel|None|
|Type|DateTime|
|CanChangeDateTimeBehavior|False|
|DateTimeBehavior|UserLocal|
|Format|DateAndTime|
|ImeMode|Auto|
|SourceTypeMask|0|

### <a name="BKMK_msdyn_issimulation"></a> msdyn_issimulation

|Property|Value|
|---|---|
|Description|**It matches the value set in "Run as simulation" field of  the scheduling optimization at the time of the run**|
|DisplayName|**Is Simulation**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_issimulation`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`msdyn_routingoptimizationrequest_msdyn_issimulation`|
|DefaultValue|False|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_msdyn_LastUpdated"></a> msdyn_LastUpdated

|Property|Value|
|---|---|
|Description||
|DisplayName|**Last Updated**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_lastupdated`|
|RequiredLevel|ApplicationRequired|
|Type|DateTime|
|CanChangeDateTimeBehavior|True|
|DateTimeBehavior|TimeZoneIndependent|
|Format|DateAndTime|
|ImeMode|Auto|
|SourceTypeMask|0|

### <a name="BKMK_msdyn_Message"></a> msdyn_Message

|Property|Value|
|---|---|
|Description|**System-populated field that presents more information on the outcome of this request.**|
|DisplayName|**Message**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_message`|
|RequiredLevel|None|
|Type|Memo|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|2000|

### <a name="BKMK_msdyn_OptimizationStatus"></a> msdyn_OptimizationStatus

|Property|Value|
|---|---|
|Description|**The status of the result for this request.**|
|DisplayName|**Optimization Status**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_optimizationstatus`|
|RequiredLevel|None|
|Type|Picklist|
|DefaultFormValue|-1|
|GlobalChoiceName|`msdyn_routingoptimizationrequest_msdyn_optimizationstatus`|

#### msdyn_OptimizationStatus Choices/Options

|Value|Label|
|---|---|
|192350000|**Submitted**|
|192350001|**Optimizing**|
|192350002|**Completed**|
|192350003|**Canceled**|
|192350004|**Failed**|
|192350005|**Blocked**|
|192350006|**Simulation Completed**|
|192350007|**Completed With Conflicts**|
|192350008|**Suggestion Completed**|

### <a name="BKMK_msdyn_requestId"></a> msdyn_requestId

|Property|Value|
|---|---|
|Description|**Resource Scheduling Optimization unique identifier.**|
|DisplayName|**Request ID**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_requestid`|
|RequiredLevel|ApplicationRequired|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdyn_requestName"></a> msdyn_requestName

|Property|Value|
|---|---|
|Description|**The name for the current optimization request.**|
|DisplayName|**Request Name**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_requestname`|
|RequiredLevel|ApplicationRequired|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdyn_RoutingConfiguration"></a> msdyn_RoutingConfiguration

|Property|Value|
|---|---|
|Description|**Configuration parameters used to run the RE.**|
|DisplayName|**Scheduling Optimization Configuration (Deprecated)**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_routingconfiguration`|
|RequiredLevel|None|
|Type|Memo|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|2000|

### <a name="BKMK_msdyn_routingoptimizationrequestId"></a> msdyn_routingoptimizationrequestId

|Property|Value|
|---|---|
|Description|**Unique identifier for entity instances**|
|DisplayName|**Scheduling Optimization Request**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`msdyn_routingoptimizationrequestid`|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|

### <a name="BKMK_msdyn_SchedulingOptimizationGoal"></a> msdyn_SchedulingOptimizationGoal

|Property|Value|
|---|---|
|Description|**The goal for this optimization request.**|
|DisplayName|**Scheduling Optimization Goal**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_schedulingoptimizationgoal`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|msdyn_routingengineconfiguration|

### <a name="BKMK_msdyn_SchedulingOptimizationScope"></a> msdyn_SchedulingOptimizationScope

|Property|Value|
|---|---|
|Description|**The scope of this optimization request.**|
|DisplayName|**Scheduling Optimization Scope**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_schedulingoptimizationscope`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|msdyn_routingjobconfiguration|

### <a name="BKMK_msdyn_SourceAutoRoutingSchedule"></a> msdyn_SourceAutoRoutingSchedule

|Property|Value|
|---|---|
|Description|**Optimization schedule that triggered an optimization request.**|
|DisplayName|**Optimization Schedule**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_sourceautoroutingschedule`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|msdyn_routingprofileconfiguration|

### <a name="BKMK_msdyn_StartRange"></a> msdyn_StartRange

|Property|Value|
|---|---|
|Description|**The start date and time of this optimization range**|
|DisplayName|**Optimization Range Start**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_startrange`|
|RequiredLevel|None|
|Type|DateTime|
|CanChangeDateTimeBehavior|False|
|DateTimeBehavior|UserLocal|
|Format|DateAndTime|
|ImeMode|Auto|
|SourceTypeMask|0|

### <a name="BKMK_msdyn_travelTimeCalculation"></a> msdyn_travelTimeCalculation

|Property|Value|
|---|---|
|Description|**Travel Time Calculation using Bing Maps with historical traffic is a Preview feature.**|
|DisplayName|**Travel Time Calculation**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_traveltimecalculation`|
|RequiredLevel|None|
|Type|Picklist|
|DefaultFormValue|192350000|
|GlobalChoiceName|`msdyn_traveltimemode`|

#### msdyn_travelTimeCalculation Choices/Options

|Value|Label|
|---|---|
|192350000|**Bing Maps without historical traffic**|
|192350001|**Bing Maps with historical traffic (Preview)**|

### <a name="BKMK_msdyn_type"></a> msdyn_type

|Property|Value|
|---|---|
|Description|**Optimization request type**|
|DisplayName|**Type**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_type`|
|RequiredLevel|ApplicationRequired|
|Type|Picklist|
|DefaultFormValue|-1|
|GlobalChoiceName|`msdyn_optimization_request_type`|

#### msdyn_type Choices/Options

|Value|Label|
|---|---|
|0|**Single resource**|
|1|**Scheduler**|
|2|**Run Now**|
|3|**Schedule Assistant**|
|4|**Interactive Resource Scheduling**|

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
|Description|**Status of a scheduling optimization request.**|
|DisplayName|**Status**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statecode`|
|RequiredLevel|SystemRequired|
|Type|State|
|DefaultFormValue||
|GlobalChoiceName|`msdyn_routingoptimizationrequest_statecode`|

#### statecode Choices/Options

|Value|Details|
|---|---|
|0|Label: **Active**<br />DefaultStatus: 1<br />InvariantName: `Active`|
|1|Label: **Inactive**<br />DefaultStatus: 2<br />InvariantName: `Inactive`|

### <a name="BKMK_statuscode"></a> statuscode

|Property|Value|
|---|---|
|Description|**Reason for the status of a scheduling optimization request**|
|DisplayName|**Status Reason**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statuscode`|
|RequiredLevel|None|
|Type|Status|
|DefaultFormValue||
|GlobalChoiceName|`msdyn_routingoptimizationrequest_statuscode`|

#### statuscode Choices/Options

|Value|Details|
|---|---|
|1|Label: **Active**<br />State:0<br />TransitionData: None|
|2|Label: **Inactive**<br />State:1<br />TransitionData: None|

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

- [business_unit_msdyn_routingoptimizationrequest](#BKMK_business_unit_msdyn_routingoptimizationrequest)
- [lk_msdyn_routingoptimizationrequest_createdby](#BKMK_lk_msdyn_routingoptimizationrequest_createdby)
- [lk_msdyn_routingoptimizationrequest_createdonbehalfby](#BKMK_lk_msdyn_routingoptimizationrequest_createdonbehalfby)
- [lk_msdyn_routingoptimizationrequest_modifiedby](#BKMK_lk_msdyn_routingoptimizationrequest_modifiedby)
- [lk_msdyn_routingoptimizationrequest_modifiedonbehalfby](#BKMK_lk_msdyn_routingoptimizationrequest_modifiedonbehalfby)
- [msdyn_msdyn_routingengineconfiguration_msdyn_routingoptimizationrequest_SchedulingOptimizationGoal](#BKMK_msdyn_msdyn_routingengineconfiguration_msdyn_routingoptimizationrequest_SchedulingOptimizationGoal)
- [msdyn_msdyn_routingjobconfiguration_msdyn_routingoptimizationrequest_SchedulingOptimizationScope](#BKMK_msdyn_msdyn_routingjobconfiguration_msdyn_routingoptimizationrequest_SchedulingOptimizationScope)
- [msdyn_msdyn_routingprofileconfiguration_msdyn_routingoptimizationrequest_BlockingSchedule](#BKMK_msdyn_msdyn_routingprofileconfiguration_msdyn_routingoptimizationrequest_BlockingSchedule)
- [msdyn_msdyn_routingprofileconfiguration_msdyn_routingoptimizationrequest_Source](#BKMK_msdyn_msdyn_routingprofileconfiguration_msdyn_routingoptimizationrequest_Source)
- [owner_msdyn_routingoptimizationrequest](#BKMK_owner_msdyn_routingoptimizationrequest)
- [team_msdyn_routingoptimizationrequest](#BKMK_team_msdyn_routingoptimizationrequest)
- [user_msdyn_routingoptimizationrequest](#BKMK_user_msdyn_routingoptimizationrequest)

### <a name="BKMK_business_unit_msdyn_routingoptimizationrequest"></a> business_unit_msdyn_routingoptimizationrequest

One-To-Many Relationship: [businessunit business_unit_msdyn_routingoptimizationrequest](businessunit.md#BKMK_business_unit_msdyn_routingoptimizationrequest)

|Property|Value|
|---|---|
|ReferencedEntity|`businessunit`|
|ReferencedAttribute|`businessunitid`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencingEntityNavigationPropertyName|`owningbusinessunit`|
|IsHierarchical||
|CascadeConfiguration|Archive: `Restrict`<br />Assign: `NoCascade`<br />Delete: `Restrict`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_routingoptimizationrequest_createdby"></a> lk_msdyn_routingoptimizationrequest_createdby

One-To-Many Relationship: [systemuser lk_msdyn_routingoptimizationrequest_createdby](systemuser.md#BKMK_lk_msdyn_routingoptimizationrequest_createdby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdby`|
|ReferencingEntityNavigationPropertyName|`createdby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_routingoptimizationrequest_createdonbehalfby"></a> lk_msdyn_routingoptimizationrequest_createdonbehalfby

One-To-Many Relationship: [systemuser lk_msdyn_routingoptimizationrequest_createdonbehalfby](systemuser.md#BKMK_lk_msdyn_routingoptimizationrequest_createdonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdonbehalfby`|
|ReferencingEntityNavigationPropertyName|`createdonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_routingoptimizationrequest_modifiedby"></a> lk_msdyn_routingoptimizationrequest_modifiedby

One-To-Many Relationship: [systemuser lk_msdyn_routingoptimizationrequest_modifiedby](systemuser.md#BKMK_lk_msdyn_routingoptimizationrequest_modifiedby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedby`|
|ReferencingEntityNavigationPropertyName|`modifiedby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_routingoptimizationrequest_modifiedonbehalfby"></a> lk_msdyn_routingoptimizationrequest_modifiedonbehalfby

One-To-Many Relationship: [systemuser lk_msdyn_routingoptimizationrequest_modifiedonbehalfby](systemuser.md#BKMK_lk_msdyn_routingoptimizationrequest_modifiedonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedonbehalfby`|
|ReferencingEntityNavigationPropertyName|`modifiedonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_msdyn_routingengineconfiguration_msdyn_routingoptimizationrequest_SchedulingOptimizationGoal"></a> msdyn_msdyn_routingengineconfiguration_msdyn_routingoptimizationrequest_SchedulingOptimizationGoal

One-To-Many Relationship: [msdyn_routingengineconfiguration msdyn_msdyn_routingengineconfiguration_msdyn_routingoptimizationrequest_SchedulingOptimizationGoal](msdyn_routingengineconfiguration.md#BKMK_msdyn_msdyn_routingengineconfiguration_msdyn_routingoptimizationrequest_SchedulingOptimizationGoal)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_routingengineconfiguration`|
|ReferencedAttribute|`msdyn_routingengineconfigurationid`|
|ReferencingAttribute|`msdyn_schedulingoptimizationgoal`|
|ReferencingEntityNavigationPropertyName|`msdyn_SchedulingOptimizationGoal`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_msdyn_routingjobconfiguration_msdyn_routingoptimizationrequest_SchedulingOptimizationScope"></a> msdyn_msdyn_routingjobconfiguration_msdyn_routingoptimizationrequest_SchedulingOptimizationScope

One-To-Many Relationship: [msdyn_routingjobconfiguration msdyn_msdyn_routingjobconfiguration_msdyn_routingoptimizationrequest_SchedulingOptimizationScope](msdyn_routingjobconfiguration.md#BKMK_msdyn_msdyn_routingjobconfiguration_msdyn_routingoptimizationrequest_SchedulingOptimizationScope)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_routingjobconfiguration`|
|ReferencedAttribute|`msdyn_routingjobconfigurationid`|
|ReferencingAttribute|`msdyn_schedulingoptimizationscope`|
|ReferencingEntityNavigationPropertyName|`msdyn_SchedulingOptimizationScope`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_msdyn_routingprofileconfiguration_msdyn_routingoptimizationrequest_BlockingSchedule"></a> msdyn_msdyn_routingprofileconfiguration_msdyn_routingoptimizationrequest_BlockingSchedule

One-To-Many Relationship: [msdyn_routingprofileconfiguration msdyn_msdyn_routingprofileconfiguration_msdyn_routingoptimizationrequest_BlockingSchedule](msdyn_routingprofileconfiguration.md#BKMK_msdyn_msdyn_routingprofileconfiguration_msdyn_routingoptimizationrequest_BlockingSchedule)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_routingprofileconfiguration`|
|ReferencedAttribute|`msdyn_routingprofileconfigurationid`|
|ReferencingAttribute|`msdyn_blockingschedule`|
|ReferencingEntityNavigationPropertyName|`msdyn_BlockingSchedule`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_msdyn_routingprofileconfiguration_msdyn_routingoptimizationrequest_Source"></a> msdyn_msdyn_routingprofileconfiguration_msdyn_routingoptimizationrequest_Source

One-To-Many Relationship: [msdyn_routingprofileconfiguration msdyn_msdyn_routingprofileconfiguration_msdyn_routingoptimizationrequest_Source](msdyn_routingprofileconfiguration.md#BKMK_msdyn_msdyn_routingprofileconfiguration_msdyn_routingoptimizationrequest_Source)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_routingprofileconfiguration`|
|ReferencedAttribute|`msdyn_routingprofileconfigurationid`|
|ReferencingAttribute|`msdyn_sourceautoroutingschedule`|
|ReferencingEntityNavigationPropertyName|`msdyn_SourceAutoRoutingSchedule`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_owner_msdyn_routingoptimizationrequest"></a> owner_msdyn_routingoptimizationrequest

One-To-Many Relationship: [owner owner_msdyn_routingoptimizationrequest](owner.md#BKMK_owner_msdyn_routingoptimizationrequest)

|Property|Value|
|---|---|
|ReferencedEntity|`owner`|
|ReferencedAttribute|`ownerid`|
|ReferencingAttribute|`ownerid`|
|ReferencingEntityNavigationPropertyName|`ownerid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_team_msdyn_routingoptimizationrequest"></a> team_msdyn_routingoptimizationrequest

One-To-Many Relationship: [team team_msdyn_routingoptimizationrequest](team.md#BKMK_team_msdyn_routingoptimizationrequest)

|Property|Value|
|---|---|
|ReferencedEntity|`team`|
|ReferencedAttribute|`teamid`|
|ReferencingAttribute|`owningteam`|
|ReferencingEntityNavigationPropertyName|`owningteam`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_user_msdyn_routingoptimizationrequest"></a> user_msdyn_routingoptimizationrequest

One-To-Many Relationship: [systemuser user_msdyn_routingoptimizationrequest](systemuser.md#BKMK_user_msdyn_routingoptimizationrequest)

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

- [msdyn_msdyn_routingoptimizationrequest_msdyn_optimizationrequestbooking_RoutingOptimization](#BKMK_msdyn_msdyn_routingoptimizationrequest_msdyn_optimizationrequestbooking_RoutingOptimization)
- [msdyn_msdyn_routingoptimizationrequest_msdyn_optimizationrequestresource_SchedulingOptimization](#BKMK_msdyn_msdyn_routingoptimizationrequest_msdyn_optimizationrequestresource_SchedulingOptimization)
- [msdyn_routingoptimizationrequest_AsyncOperations](#BKMK_msdyn_routingoptimizationrequest_AsyncOperations)
- [msdyn_routingoptimizationrequest_BulkDeleteFailures](#BKMK_msdyn_routingoptimizationrequest_BulkDeleteFailures)
- [msdyn_routingoptimizationrequest_connections1](#BKMK_msdyn_routingoptimizationrequest_connections1)
- [msdyn_routingoptimizationrequest_connections2](#BKMK_msdyn_routingoptimizationrequest_connections2)
- [msdyn_routingoptimizationrequest_DuplicateBaseRecord](#BKMK_msdyn_routingoptimizationrequest_DuplicateBaseRecord)
- [msdyn_routingoptimizationrequest_DuplicateMatchingRecord](#BKMK_msdyn_routingoptimizationrequest_DuplicateMatchingRecord)
- [msdyn_routingoptimizationrequest_MailboxTrackingFolders](#BKMK_msdyn_routingoptimizationrequest_MailboxTrackingFolders)
- [msdyn_routingoptimizationrequest_PrincipalObjectAttributeAccesses](#BKMK_msdyn_routingoptimizationrequest_PrincipalObjectAttributeAccesses)
- [msdyn_routingoptimizationrequest_ProcessSession](#BKMK_msdyn_routingoptimizationrequest_ProcessSession)
- [msdyn_routingoptimizationrequest_SyncErrors](#BKMK_msdyn_routingoptimizationrequest_SyncErrors)

### <a name="BKMK_msdyn_msdyn_routingoptimizationrequest_msdyn_optimizationrequestbooking_RoutingOptimization"></a> msdyn_msdyn_routingoptimizationrequest_msdyn_optimizationrequestbooking_RoutingOptimization

Many-To-One Relationship: [msdyn_optimizationrequestbooking msdyn_msdyn_routingoptimizationrequest_msdyn_optimizationrequestbooking_RoutingOptimization](msdyn_optimizationrequestbooking.md#BKMK_msdyn_msdyn_routingoptimizationrequest_msdyn_optimizationrequestbooking_RoutingOptimization)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_optimizationrequestbooking`|
|ReferencingAttribute|`msdyn_routingoptimization`|
|ReferencedEntityNavigationPropertyName|`msdyn_msdyn_routingoptimizationrequest_msdyn_optimizationrequestbooking_RoutingOptimization`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_msdyn_routingoptimizationrequest_msdyn_optimizationrequestresource_SchedulingOptimization"></a> msdyn_msdyn_routingoptimizationrequest_msdyn_optimizationrequestresource_SchedulingOptimization

Many-To-One Relationship: [msdyn_optimizationrequestresource msdyn_msdyn_routingoptimizationrequest_msdyn_optimizationrequestresource_SchedulingOptimization](msdyn_optimizationrequestresource.md#BKMK_msdyn_msdyn_routingoptimizationrequest_msdyn_optimizationrequestresource_SchedulingOptimization)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_optimizationrequestresource`|
|ReferencingAttribute|`msdyn_schedulingoptimization`|
|ReferencedEntityNavigationPropertyName|`msdyn_msdyn_routingoptimizationrequest_msdyn_optimizationrequestresource_SchedulingOptimization`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_routingoptimizationrequest_AsyncOperations"></a> msdyn_routingoptimizationrequest_AsyncOperations

Many-To-One Relationship: [asyncoperation msdyn_routingoptimizationrequest_AsyncOperations](asyncoperation.md#BKMK_msdyn_routingoptimizationrequest_AsyncOperations)

|Property|Value|
|---|---|
|ReferencingEntity|`asyncoperation`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_routingoptimizationrequest_AsyncOperations`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_routingoptimizationrequest_BulkDeleteFailures"></a> msdyn_routingoptimizationrequest_BulkDeleteFailures

Many-To-One Relationship: [bulkdeletefailure msdyn_routingoptimizationrequest_BulkDeleteFailures](bulkdeletefailure.md#BKMK_msdyn_routingoptimizationrequest_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencingEntity|`bulkdeletefailure`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_routingoptimizationrequest_BulkDeleteFailures`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_routingoptimizationrequest_connections1"></a> msdyn_routingoptimizationrequest_connections1

Many-To-One Relationship: [connection msdyn_routingoptimizationrequest_connections1](connection.md#BKMK_msdyn_routingoptimizationrequest_connections1)

|Property|Value|
|---|---|
|ReferencingEntity|`connection`|
|ReferencingAttribute|`record1id`|
|ReferencedEntityNavigationPropertyName|`msdyn_routingoptimizationrequest_connections1`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 100<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_routingoptimizationrequest_connections2"></a> msdyn_routingoptimizationrequest_connections2

Many-To-One Relationship: [connection msdyn_routingoptimizationrequest_connections2](connection.md#BKMK_msdyn_routingoptimizationrequest_connections2)

|Property|Value|
|---|---|
|ReferencingEntity|`connection`|
|ReferencingAttribute|`record2id`|
|ReferencedEntityNavigationPropertyName|`msdyn_routingoptimizationrequest_connections2`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_routingoptimizationrequest_DuplicateBaseRecord"></a> msdyn_routingoptimizationrequest_DuplicateBaseRecord

Many-To-One Relationship: [duplicaterecord msdyn_routingoptimizationrequest_DuplicateBaseRecord](duplicaterecord.md#BKMK_msdyn_routingoptimizationrequest_DuplicateBaseRecord)

|Property|Value|
|---|---|
|ReferencingEntity|`duplicaterecord`|
|ReferencingAttribute|`baserecordid`|
|ReferencedEntityNavigationPropertyName|`msdyn_routingoptimizationrequest_DuplicateBaseRecord`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_routingoptimizationrequest_DuplicateMatchingRecord"></a> msdyn_routingoptimizationrequest_DuplicateMatchingRecord

Many-To-One Relationship: [duplicaterecord msdyn_routingoptimizationrequest_DuplicateMatchingRecord](duplicaterecord.md#BKMK_msdyn_routingoptimizationrequest_DuplicateMatchingRecord)

|Property|Value|
|---|---|
|ReferencingEntity|`duplicaterecord`|
|ReferencingAttribute|`duplicaterecordid`|
|ReferencedEntityNavigationPropertyName|`msdyn_routingoptimizationrequest_DuplicateMatchingRecord`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_routingoptimizationrequest_MailboxTrackingFolders"></a> msdyn_routingoptimizationrequest_MailboxTrackingFolders

Many-To-One Relationship: [mailboxtrackingfolder msdyn_routingoptimizationrequest_MailboxTrackingFolders](mailboxtrackingfolder.md#BKMK_msdyn_routingoptimizationrequest_MailboxTrackingFolders)

|Property|Value|
|---|---|
|ReferencingEntity|`mailboxtrackingfolder`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_routingoptimizationrequest_MailboxTrackingFolders`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_routingoptimizationrequest_PrincipalObjectAttributeAccesses"></a> msdyn_routingoptimizationrequest_PrincipalObjectAttributeAccesses

Many-To-One Relationship: [principalobjectattributeaccess msdyn_routingoptimizationrequest_PrincipalObjectAttributeAccesses](principalobjectattributeaccess.md#BKMK_msdyn_routingoptimizationrequest_PrincipalObjectAttributeAccesses)

|Property|Value|
|---|---|
|ReferencingEntity|`principalobjectattributeaccess`|
|ReferencingAttribute|`objectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_routingoptimizationrequest_PrincipalObjectAttributeAccesses`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_routingoptimizationrequest_ProcessSession"></a> msdyn_routingoptimizationrequest_ProcessSession

Many-To-One Relationship: [processsession msdyn_routingoptimizationrequest_ProcessSession](processsession.md#BKMK_msdyn_routingoptimizationrequest_ProcessSession)

|Property|Value|
|---|---|
|ReferencingEntity|`processsession`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_routingoptimizationrequest_ProcessSession`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_routingoptimizationrequest_SyncErrors"></a> msdyn_routingoptimizationrequest_SyncErrors

Many-To-One Relationship: [syncerror msdyn_routingoptimizationrequest_SyncErrors](syncerror.md#BKMK_msdyn_routingoptimizationrequest_SyncErrors)

|Property|Value|
|---|---|
|ReferencingEntity|`syncerror`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_routingoptimizationrequest_SyncErrors`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|



### See also

[Dataverse table/entity reference](../about-entity-reference.md)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   

