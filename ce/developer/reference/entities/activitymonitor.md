---
title: "Activity monitor (activitymonitor) table/entity reference (Microsoft Dynamics 365)"
description: "Includes schema information and supported messages for the Activity monitor (activitymonitor) table/entity with Microsoft Dynamics 365."
ms.topic: generated-reference
author: JimDaly
ms.author: jdaly
search.audienceType: 
  - developer
---

# Activity monitor (activitymonitor) table/entity reference (Microsoft Dynamics 365)

Entity that tracks ARC runtime information.

## Messages

The following table lists the messages for the Activity monitor (activitymonitor) table.
Messages represent operations that can be performed on the table. They may also be events.

| Name <br />Is Event? |Web API Operation |SDK for .NET |
| ---- | ----- |----- |
| `Assign`<br />Event: True |`PATCH` /activitymonitors(*activitymonitorid*)<br />[Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) the `ownerid` property. |<xref:Microsoft.Crm.Sdk.Messages.AssignRequest>|
| `Associate`<br />Event: True |[Associate records](/power-apps/developer/data-platform/webapi/associate-disassociate-entities-using-web-api) |[Associate records](/power-apps/developer/data-platform/org-service/entity-operations-associate-disassociate#use-the-associate-method-or-associaterequest)|
| `BulkRetain`<br />Event: True |<xref:Microsoft.Dynamics.CRM.BulkRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Create`<br />Event: True |`POST` /activitymonitors<br />See [Create](/powerapps/developer/data-platform/webapi/create-entity-web-api) |[Create records](/power-apps/developer/data-platform/org-service/entity-operations-create#basic-create)|
| `CreateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.CreateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.CreateMultipleRequest>|
| `Delete`<br />Event: True |`DELETE` /activitymonitors(*activitymonitorid*)<br />See [Delete](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-delete) |[Delete records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-delete)|
| `Disassociate`<br />Event: True |[Disassociate records](/power-apps/developer/data-platform/webapi/associate-disassociate-entities-using-web-api) |[Disassociate records](/power-apps/developer/data-platform/org-service/entity-operations-associate-disassociate#use-the-disassociate-method-or-disassociaterequest)|
| `GrantAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.GrantAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.GrantAccessRequest>|
| `IsValidStateTransition`<br />Event: False |<xref:Microsoft.Dynamics.CRM.IsValidStateTransition?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.IsValidStateTransitionRequest>|
| `ModifyAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.ModifyAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.ModifyAccessRequest>|
| `PurgeRetainedContent`<br />Event: True |<xref:Microsoft.Dynamics.CRM.PurgeRetainedContent?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Restore`<br />Event: True |<xref:Microsoft.Dynamics.CRM.Restore?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retain`<br />Event: True |<xref:Microsoft.Dynamics.CRM.Retain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retrieve`<br />Event: True |`GET` /activitymonitors(*activitymonitorid*)<br />See [Retrieve](/powerapps/developer/data-platform/webapi/retrieve-entity-using-web-api) |[Retrieve records](/power-apps/developer/data-platform/org-service/entity-operations-retrieve)|
| `RetrieveMultiple`<br />Event: True |`GET` /activitymonitors<br />See [Query data](/power-apps/developer/data-platform/webapi/query-data-web-api) |[Query data](/power-apps/developer/data-platform/org-service/entity-operations-query-data)|
| `RetrievePrincipalAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RetrievePrincipalAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RetrievePrincipalAccessRequest>|
| `RetrieveSharedPrincipalsAndAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RetrieveSharedPrincipalsAndAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RetrieveSharedPrincipalsAndAccessRequest>|
| `RevokeAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RevokeAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RevokeAccessRequest>|
| `RollbackRetain`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RollbackRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `SetState`<br />Event: True |`PATCH` /activitymonitors(*activitymonitorid*)<br />[Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) the `statecode` and `statuscode` properties. |<xref:Microsoft.Crm.Sdk.Messages.SetStateRequest>|
| `Update`<br />Event: True |`PATCH` /activitymonitors(*activitymonitorid*)<br />See [Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) |[Update records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-update)|
| `UpdateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.UpdateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpdateMultipleRequest>|
| `Upsert`<br />Event: False |`PATCH` /activitymonitors(*activitymonitorid*)<br />See [Upsert a table row](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#upsert-a-table-row) |<xref:Microsoft.Xrm.Sdk.Messages.UpsertRequest>|
| `UpsertMultiple`<br />Event: False |<xref:Microsoft.Dynamics.CRM.UpsertMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpsertMultipleRequest>|
| `ValidateRetentionConfig`<br />Event: True |<xref:Microsoft.Dynamics.CRM.ValidateRetentionConfig?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|

## Properties

The following table lists selected properties for the Activity monitor (activitymonitor) table.

|Property|Value|
| --- | --- |
| **DisplayName** | **Activity monitor** |
| **DisplayCollectionName** | **Activity monitors** |
| **SchemaName** | `activitymonitor` |
| **CollectionSchemaName** | `activitymonitors` |
| **EntitySetName** | `activitymonitors`|
| **LogicalName** | `activitymonitor` |
| **LogicalCollectionName** | `activitymonitors` |
| **PrimaryIdAttribute** | `activitymonitorid` |
| **PrimaryNameAttribute** |`name` |
| **TableType** | `Standard` |
| **OwnershipType** | `UserOwned` |

## Writable columns/attributes

These columns/attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [activitymonitorId](#BKMK_activitymonitorId)
- [AdvancedSettings](#BKMK_AdvancedSettings)
- [ConditionId](#BKMK_ConditionId)
- [ContactCreatedByRule](#BKMK_ContactCreatedByRule)
- [CurrentState](#BKMK_CurrentState)
- [EntitlementCheck](#BKMK_EntitlementCheck)
- [ImportSequenceNumber](#BKMK_ImportSequenceNumber)
- [MonitoredActivityItemId](#BKMK_MonitoredActivityItemId)
- [MonitoredActivityItemIdType](#BKMK_MonitoredActivityItemIdType)
- [Name](#BKMK_Name)
- [OverriddenCreatedOn](#BKMK_OverriddenCreatedOn)
- [OwnerId](#BKMK_OwnerId)
- [OwnerIdType](#BKMK_OwnerIdType)
- [Reason](#BKMK_Reason)
- [RuleId](#BKMK_RuleId)
- [statecode](#BKMK_statecode)
- [statuscode](#BKMK_statuscode)
- [TimeZoneRuleVersionNumber](#BKMK_TimeZoneRuleVersionNumber)
- [UTCConversionTimeZoneCode](#BKMK_UTCConversionTimeZoneCode)

### <a name="BKMK_activitymonitorId"></a> activitymonitorId

|Property|Value|
|---|---|
|Description|**Unique identifier for activity monitor.**|
|DisplayName|**Activity monitor id**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`activitymonitorid`|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|

### <a name="BKMK_AdvancedSettings"></a> AdvancedSettings

|Property|Value|
|---|---|
|Description|**Json string containing advanced setting flags for the matched rule.**|
|DisplayName|**Advanced settings**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`advancedsettings`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|2000|

### <a name="BKMK_ConditionId"></a> ConditionId

|Property|Value|
|---|---|
|Description|**Unique identifier for ARC rule item associated with activity monitor.**|
|DisplayName|**Condition name**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`conditionid`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|convertruleitem|

### <a name="BKMK_ContactCreatedByRule"></a> ContactCreatedByRule

|Property|Value|
|---|---|
|Description|**Status of contact creation for an unknown sender during ARC runtime.**|
|DisplayName|**Contact created by rule**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`contactcreatedbyrule`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`activitymonitor_contactcreatedbyrule`|
|DefaultValue|False|
|True Label|Success|
|False Label|Failed|

### <a name="BKMK_CurrentState"></a> CurrentState

|Property|Value|
|---|---|
|Description|**ARC early exit status.**|
|DisplayName|**Current state**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`currentstate`|
|RequiredLevel|None|
|Type|Picklist|
|DefaultFormValue|0|
|GlobalChoiceName|`activitymonitor_currentstate`|

#### CurrentState Choices/Options

|Value|Label|
|---|---|
|0|**Ready for workflow**|
|1|**Ready for Power Automate**|
|2|**Failed**|
|3|**Skipped**|

### <a name="BKMK_EntitlementCheck"></a> EntitlementCheck

|Property|Value|
|---|---|
|Description|**Status of entitlement check during arc runtime.**|
|DisplayName|**Entitlement check**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`entitlementcheck`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`activitymonitor_entitlementcheck`|
|DefaultValue|False|
|True Label|Success|
|False Label|Failed|

### <a name="BKMK_ImportSequenceNumber"></a> ImportSequenceNumber

|Property|Value|
|---|---|
|Description|**Sequence number of the import that created this record.**|
|DisplayName|**Import sequence number**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`importsequencenumber`|
|RequiredLevel|None|
|Type|Integer|
|MaxValue|2147483647|
|MinValue|-2147483648|

### <a name="BKMK_MonitoredActivityItemId"></a> MonitoredActivityItemId

|Property|Value|
|---|---|
|Description|**Monitored activity item record.**|
|DisplayName|**Monitored activity item**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`monitoredactivityitemid`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|email, task|

### <a name="BKMK_MonitoredActivityItemIdType"></a> MonitoredActivityItemIdType

|Property|Value|
|---|---|
|Description||
|DisplayName|**Monitored activity type**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`monitoredactivityitemidtype`|
|RequiredLevel|None|
|Type|EntityName|

### <a name="BKMK_Name"></a> Name

|Property|Value|
|---|---|
|Description|**The name of the activity monitor.**|
|DisplayName|**Name**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`name`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_OverriddenCreatedOn"></a> OverriddenCreatedOn

|Property|Value|
|---|---|
|Description|**Date and time that the record was migrated.**|
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

### <a name="BKMK_Reason"></a> Reason

|Property|Value|
|---|---|
|Description|**ARC early exit reason**|
|DisplayName|**Reason**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`reason`|
|RequiredLevel|None|
|Type|Picklist|
|DefaultFormValue|0|
|GlobalChoiceName|`activitymonitor_reason`|

#### Reason Choices/Options

|Value|Label|
|---|---|
|0|**--**|
|1|**Unable to find the source data for this email.**|
|2|**An existing entity is already connected with this record.**|
|3|**An active case is already connected with this record.**|
|4|**A resolved case is already connected with this record.**|
|5|**The rule requires a connected case to be resolved for a specific amount of time before creating a new one. This connected case has been resolved for less than the amount of time selected.**|
|6|**No email sender is found.**|
|7|**Email is coming from an unknown sender.**|
|8|**--**|
|9|**A contact was not created for this sender. This can be that the rule owner doesn't have permission to create contacts.**|
|10|**No valid entitlement for this email sender. The rule continued with any additional action selected, but skipped the primary action for this email sender.**|
|11|**No valid entitlement for this email sender.**|
|12|**--**|
|13|**The rule doesn’t have any conditions applicable to the record.**|
|14|**The rule is disconnected from the Power Automate flow. To reconnect, please deactivate and reactivate the rule.**|
|15|**The rule is disconnected from the workflow. To reconnect, please deactivate and reactivate the rule.**|
|16|**Contact creation failed for this sender**|
|17|**Error matching conditions. Contact Microsoft support.**|
|18|**Internal failure contact Microsoft support**|

### <a name="BKMK_RuleId"></a> RuleId

|Property|Value|
|---|---|
|Description|**Unique identifier for ARC rule associated with activity monitor.**|
|DisplayName|**Rule name**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`ruleid`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|convertrule|

### <a name="BKMK_statecode"></a> statecode

|Property|Value|
|---|---|
|Description|**Status of the Activity monitor**|
|DisplayName|**Status**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statecode`|
|RequiredLevel|SystemRequired|
|Type|State|
|DefaultFormValue||
|GlobalChoiceName|`activitymonitor_statecode`|

#### statecode Choices/Options

|Value|Details|
|---|---|
|0|Label: **Active**<br />DefaultStatus: 1<br />InvariantName: `Active`|
|1|Label: **Inactive**<br />DefaultStatus: 2<br />InvariantName: `Inactive`|

### <a name="BKMK_statuscode"></a> statuscode

|Property|Value|
|---|---|
|Description|**Reason for the status of the Activity monitor**|
|DisplayName|**Status Reason**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statuscode`|
|RequiredLevel|None|
|Type|Status|
|DefaultFormValue||
|GlobalChoiceName|`activitymonitor_statuscode`|

#### statuscode Choices/Options

|Value|Details|
|---|---|
|1|Label: **Active**<br />State:0<br />TransitionData: None|
|2|Label: **Inactive**<br />State:1<br />TransitionData: None|

### <a name="BKMK_TimeZoneRuleVersionNumber"></a> TimeZoneRuleVersionNumber

|Property|Value|
|---|---|
|Description|**For internal use only.**|
|DisplayName|**Time zone rule version number**|
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
|DisplayName|**UTC conversion time zone code**|
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
- [Recommendation](#BKMK_Recommendation)
- [VersionNumber](#BKMK_VersionNumber)

### <a name="BKMK_CreatedBy"></a> CreatedBy

|Property|Value|
|---|---|
|Description|**Unique identifier of the user who created the record.**|
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
|Description|**Date and time when the record was created.**|
|DisplayName|**Evaluated on**|
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
|DisplayName|**Created by (Delegate)**|
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
|DisplayName|**Modified by (Delegate)**|
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
|Description|**Unique identifier for the team that owns the record.**|
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
|Description|**Unique identifier for the user that owns the record.**|
|DisplayName|**Owning user**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`owninguser`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|systemuser|

### <a name="BKMK_Recommendation"></a> Recommendation

|Property|Value|
|---|---|
|Description|**A rich text field to display recommendation.**|
|DisplayName|**Recommendation**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`recommendation`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|RichText|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|4000|

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

- [business_unit_activitymonitor](#BKMK_business_unit_activitymonitor)
- [email_activitymonitor](#BKMK_email_activitymonitor)
- [lk_activitymonitor_createdby](#BKMK_lk_activitymonitor_createdby)
- [lk_activitymonitor_createdonbehalfby](#BKMK_lk_activitymonitor_createdonbehalfby)
- [lk_activitymonitor_modifiedby](#BKMK_lk_activitymonitor_modifiedby)
- [lk_activitymonitor_modifiedonbehalfby](#BKMK_lk_activitymonitor_modifiedonbehalfby)
- [owner_activitymonitor](#BKMK_owner_activitymonitor)
- [task_activitymonitor](#BKMK_task_activitymonitor)
- [team_activitymonitor](#BKMK_team_activitymonitor)
- [user_activitymonitor](#BKMK_user_activitymonitor)

### <a name="BKMK_business_unit_activitymonitor"></a> business_unit_activitymonitor

One-To-Many Relationship: [businessunit business_unit_activitymonitor](businessunit.md#BKMK_business_unit_activitymonitor)

|Property|Value|
|---|---|
|ReferencedEntity|`businessunit`|
|ReferencedAttribute|`businessunitid`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencingEntityNavigationPropertyName|`owningbusinessunit`|
|IsHierarchical||
|CascadeConfiguration|Archive: `Restrict`<br />Assign: `NoCascade`<br />Delete: `Restrict`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_email_activitymonitor"></a> email_activitymonitor

One-To-Many Relationship: [email email_activitymonitor](email.md#BKMK_email_activitymonitor)

|Property|Value|
|---|---|
|ReferencedEntity|`email`|
|ReferencedAttribute|`activityid`|
|ReferencingAttribute|`monitoredactivityitemid`|
|ReferencingEntityNavigationPropertyName|`monitoredactivityitemid_email`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_activitymonitor_createdby"></a> lk_activitymonitor_createdby

One-To-Many Relationship: [systemuser lk_activitymonitor_createdby](systemuser.md#BKMK_lk_activitymonitor_createdby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdby`|
|ReferencingEntityNavigationPropertyName|`createdby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_activitymonitor_createdonbehalfby"></a> lk_activitymonitor_createdonbehalfby

One-To-Many Relationship: [systemuser lk_activitymonitor_createdonbehalfby](systemuser.md#BKMK_lk_activitymonitor_createdonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdonbehalfby`|
|ReferencingEntityNavigationPropertyName|`createdonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_activitymonitor_modifiedby"></a> lk_activitymonitor_modifiedby

One-To-Many Relationship: [systemuser lk_activitymonitor_modifiedby](systemuser.md#BKMK_lk_activitymonitor_modifiedby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedby`|
|ReferencingEntityNavigationPropertyName|`modifiedby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_activitymonitor_modifiedonbehalfby"></a> lk_activitymonitor_modifiedonbehalfby

One-To-Many Relationship: [systemuser lk_activitymonitor_modifiedonbehalfby](systemuser.md#BKMK_lk_activitymonitor_modifiedonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedonbehalfby`|
|ReferencingEntityNavigationPropertyName|`modifiedonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_owner_activitymonitor"></a> owner_activitymonitor

One-To-Many Relationship: [owner owner_activitymonitor](owner.md#BKMK_owner_activitymonitor)

|Property|Value|
|---|---|
|ReferencedEntity|`owner`|
|ReferencedAttribute|`ownerid`|
|ReferencingAttribute|`ownerid`|
|ReferencingEntityNavigationPropertyName|`ownerid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_task_activitymonitor"></a> task_activitymonitor

One-To-Many Relationship: [task task_activitymonitor](task.md#BKMK_task_activitymonitor)

|Property|Value|
|---|---|
|ReferencedEntity|`task`|
|ReferencedAttribute|`activityid`|
|ReferencingAttribute|`monitoredactivityitemid`|
|ReferencingEntityNavigationPropertyName|`monitoredactivityitemid_task`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_team_activitymonitor"></a> team_activitymonitor

One-To-Many Relationship: [team team_activitymonitor](team.md#BKMK_team_activitymonitor)

|Property|Value|
|---|---|
|ReferencedEntity|`team`|
|ReferencedAttribute|`teamid`|
|ReferencingAttribute|`owningteam`|
|ReferencingEntityNavigationPropertyName|`owningteam`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_user_activitymonitor"></a> user_activitymonitor

One-To-Many Relationship: [systemuser user_activitymonitor](systemuser.md#BKMK_user_activitymonitor)

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

- [activitymonitor_AsyncOperations](#BKMK_activitymonitor_AsyncOperations)
- [activitymonitor_BulkDeleteFailures](#BKMK_activitymonitor_BulkDeleteFailures)
- [activitymonitor_DuplicateBaseRecord](#BKMK_activitymonitor_DuplicateBaseRecord)
- [activitymonitor_DuplicateMatchingRecord](#BKMK_activitymonitor_DuplicateMatchingRecord)
- [activitymonitor_MailboxTrackingFolders](#BKMK_activitymonitor_MailboxTrackingFolders)
- [activitymonitor_PrincipalObjectAttributeAccesses](#BKMK_activitymonitor_PrincipalObjectAttributeAccesses)
- [activitymonitor_ProcessSession](#BKMK_activitymonitor_ProcessSession)
- [activitymonitor_SyncErrors](#BKMK_activitymonitor_SyncErrors)

### <a name="BKMK_activitymonitor_AsyncOperations"></a> activitymonitor_AsyncOperations

Many-To-One Relationship: [asyncoperation activitymonitor_AsyncOperations](asyncoperation.md#BKMK_activitymonitor_AsyncOperations)

|Property|Value|
|---|---|
|ReferencingEntity|`asyncoperation`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`activitymonitor_AsyncOperations`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_activitymonitor_BulkDeleteFailures"></a> activitymonitor_BulkDeleteFailures

Many-To-One Relationship: [bulkdeletefailure activitymonitor_BulkDeleteFailures](bulkdeletefailure.md#BKMK_activitymonitor_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencingEntity|`bulkdeletefailure`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`activitymonitor_BulkDeleteFailures`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_activitymonitor_DuplicateBaseRecord"></a> activitymonitor_DuplicateBaseRecord

Many-To-One Relationship: [duplicaterecord activitymonitor_DuplicateBaseRecord](duplicaterecord.md#BKMK_activitymonitor_DuplicateBaseRecord)

|Property|Value|
|---|---|
|ReferencingEntity|`duplicaterecord`|
|ReferencingAttribute|`baserecordid`|
|ReferencedEntityNavigationPropertyName|`activitymonitor_DuplicateBaseRecord`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_activitymonitor_DuplicateMatchingRecord"></a> activitymonitor_DuplicateMatchingRecord

Many-To-One Relationship: [duplicaterecord activitymonitor_DuplicateMatchingRecord](duplicaterecord.md#BKMK_activitymonitor_DuplicateMatchingRecord)

|Property|Value|
|---|---|
|ReferencingEntity|`duplicaterecord`|
|ReferencingAttribute|`duplicaterecordid`|
|ReferencedEntityNavigationPropertyName|`activitymonitor_DuplicateMatchingRecord`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_activitymonitor_MailboxTrackingFolders"></a> activitymonitor_MailboxTrackingFolders

Many-To-One Relationship: [mailboxtrackingfolder activitymonitor_MailboxTrackingFolders](mailboxtrackingfolder.md#BKMK_activitymonitor_MailboxTrackingFolders)

|Property|Value|
|---|---|
|ReferencingEntity|`mailboxtrackingfolder`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`activitymonitor_MailboxTrackingFolders`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_activitymonitor_PrincipalObjectAttributeAccesses"></a> activitymonitor_PrincipalObjectAttributeAccesses

Many-To-One Relationship: [principalobjectattributeaccess activitymonitor_PrincipalObjectAttributeAccesses](principalobjectattributeaccess.md#BKMK_activitymonitor_PrincipalObjectAttributeAccesses)

|Property|Value|
|---|---|
|ReferencingEntity|`principalobjectattributeaccess`|
|ReferencingAttribute|`objectid`|
|ReferencedEntityNavigationPropertyName|`activitymonitor_PrincipalObjectAttributeAccesses`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_activitymonitor_ProcessSession"></a> activitymonitor_ProcessSession

Many-To-One Relationship: [processsession activitymonitor_ProcessSession](processsession.md#BKMK_activitymonitor_ProcessSession)

|Property|Value|
|---|---|
|ReferencingEntity|`processsession`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`activitymonitor_ProcessSession`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_activitymonitor_SyncErrors"></a> activitymonitor_SyncErrors

Many-To-One Relationship: [syncerror activitymonitor_SyncErrors](syncerror.md#BKMK_activitymonitor_SyncErrors)

|Property|Value|
|---|---|
|ReferencingEntity|`syncerror`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`activitymonitor_SyncErrors`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|



### See also

[Dataverse table/entity reference](/power-apps/developer/data-platform/reference/about-entity-reference)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   

