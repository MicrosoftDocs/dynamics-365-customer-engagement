---
title: "Proactive Engagement Planner Configuration (msdyn_proactive_engagement_planner_config) table/entity reference (Microsoft Dynamics 365 Customer Service)"
description: "Includes schema information and supported messages for the Proactive Engagement Planner Configuration (msdyn_proactive_engagement_planner_config) table/entity with Microsoft Dynamics 365 Customer Service."
ms.topic: generated-reference
author: gandhamm
ms.author: mgandham
search.audienceType: 
  - developer
---

# Proactive Engagement Planner Configuration (msdyn_proactive_engagement_planner_config) table/entity reference (Microsoft Dynamics 365 Customer Service)



## Messages

The following table lists the messages for the Proactive Engagement Planner Configuration (msdyn_proactive_engagement_planner_config) table.
Messages represent operations that can be performed on the table. They may also be events.

| Name <br />Is Event? |Web API Operation |SDK for .NET |
| ---- | ----- |----- |
| `Assign`<br />Event: True |`PATCH` /msdyn_proactive_engagement_planner_configs(*msdyn_proactive_engagement_planner_configid*)<br />[Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) the `ownerid` property. |<xref:Microsoft.Crm.Sdk.Messages.AssignRequest>|
| `Associate`<br />Event: True |[Associate records](/power-apps/developer/data-platform/webapi/associate-disassociate-entities-using-web-api) |[Associate records](/power-apps/developer/data-platform/org-service/entity-operations-associate-disassociate#use-the-associate-method-or-associaterequest)|
| `BulkRetain`<br />Event: True |<xref:Microsoft.Dynamics.CRM.BulkRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Create`<br />Event: True |`POST` /msdyn_proactive_engagement_planner_configs<br />See [Create](/powerapps/developer/data-platform/webapi/create-entity-web-api) |[Create records](/power-apps/developer/data-platform/org-service/entity-operations-create#basic-create)|
| `CreateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.CreateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.CreateMultipleRequest>|
| `Delete`<br />Event: True |`DELETE` /msdyn_proactive_engagement_planner_configs(*msdyn_proactive_engagement_planner_configid*)<br />See [Delete](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-delete) |[Delete records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-delete)|
| `Disassociate`<br />Event: True |[Disassociate records](/power-apps/developer/data-platform/webapi/associate-disassociate-entities-using-web-api) |[Disassociate records](/power-apps/developer/data-platform/org-service/entity-operations-associate-disassociate#use-the-disassociate-method-or-disassociaterequest)|
| `GrantAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.GrantAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.GrantAccessRequest>|
| `IsValidStateTransition`<br />Event: False |<xref:Microsoft.Dynamics.CRM.IsValidStateTransition?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.IsValidStateTransitionRequest>|
| `ModifyAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.ModifyAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.ModifyAccessRequest>|
| `PurgeRetainedContent`<br />Event: True |<xref:Microsoft.Dynamics.CRM.PurgeRetainedContent?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retain`<br />Event: True |<xref:Microsoft.Dynamics.CRM.Retain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retrieve`<br />Event: True |`GET` /msdyn_proactive_engagement_planner_configs(*msdyn_proactive_engagement_planner_configid*)<br />See [Retrieve](/powerapps/developer/data-platform/webapi/retrieve-entity-using-web-api) |[Retrieve records](/power-apps/developer/data-platform/org-service/entity-operations-retrieve)|
| `RetrieveMultiple`<br />Event: True |`GET` /msdyn_proactive_engagement_planner_configs<br />See [Query data](/power-apps/developer/data-platform/webapi/query-data-web-api) |[Query data](/power-apps/developer/data-platform/org-service/entity-operations-query-data)|
| `RetrievePrincipalAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RetrievePrincipalAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RetrievePrincipalAccessRequest>|
| `RetrieveSharedPrincipalsAndAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RetrieveSharedPrincipalsAndAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RetrieveSharedPrincipalsAndAccessRequest>|
| `RevokeAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RevokeAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RevokeAccessRequest>|
| `RollbackRetain`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RollbackRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `SetState`<br />Event: True |`PATCH` /msdyn_proactive_engagement_planner_configs(*msdyn_proactive_engagement_planner_configid*)<br />[Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) the `statecode` and `statuscode` properties. |<xref:Microsoft.Crm.Sdk.Messages.SetStateRequest>|
| `Update`<br />Event: True |`PATCH` /msdyn_proactive_engagement_planner_configs(*msdyn_proactive_engagement_planner_configid*)<br />See [Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) |[Update records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-update)|
| `UpdateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.UpdateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpdateMultipleRequest>|
| `Upsert`<br />Event: False |`PATCH` /msdyn_proactive_engagement_planner_configs(*msdyn_proactive_engagement_planner_configid*)<br />See [Upsert a table row](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#upsert-a-table-row) |<xref:Microsoft.Xrm.Sdk.Messages.UpsertRequest>|
| `UpsertMultiple`<br />Event: False |<xref:Microsoft.Dynamics.CRM.UpsertMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpsertMultipleRequest>|
| `ValidateRetentionConfig`<br />Event: True |<xref:Microsoft.Dynamics.CRM.ValidateRetentionConfig?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|

## Properties

The following table lists selected properties for the Proactive Engagement Planner Configuration (msdyn_proactive_engagement_planner_config) table.

|Property|Value|
| --- | --- |
| **DisplayName** | **Proactive Engagement Planner Configuration** |
| **DisplayCollectionName** | **Proactive Engagement Planner Configurations** |
| **SchemaName** | `msdyn_proactive_engagement_planner_config` |
| **CollectionSchemaName** | `msdyn_proactive_engagement_planner_configs` |
| **EntitySetName** | `msdyn_proactive_engagement_planner_configs`|
| **LogicalName** | `msdyn_proactive_engagement_planner_config` |
| **LogicalCollectionName** | `msdyn_proactive_engagement_planner_configs` |
| **PrimaryIdAttribute** | `msdyn_proactive_engagement_planner_configid` |
| **PrimaryNameAttribute** |`msdyn_name` |
| **TableType** | `Standard` |
| **OwnershipType** | `UserOwned` |

## Writable columns/attributes

These columns/attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [ImportSequenceNumber](#BKMK_ImportSequenceNumber)
- [IsCustomizable](#BKMK_IsCustomizable)
- [msdyn_delay_between_retries](#BKMK_msdyn_delay_between_retries)
- [msdyn_fallback_engagement_config_id](#BKMK_msdyn_fallback_engagement_config_id)
- [msdyn_name](#BKMK_msdyn_name)
- [msdyn_number_of_retries](#BKMK_msdyn_number_of_retries)
- [msdyn_proactive_engagement_config_id](#BKMK_msdyn_proactive_engagement_config_id)
- [msdyn_proactive_engagement_message_templateId](#BKMK_msdyn_proactive_engagement_message_templateId)
- [msdyn_proactive_engagement_planner_configId](#BKMK_msdyn_proactive_engagement_planner_configId)
- [msdyn_reattempt_rules](#BKMK_msdyn_reattempt_rules)
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

### <a name="BKMK_IsCustomizable"></a> IsCustomizable

|Property|Value|
|---|---|
|Description|**For internal use only.**|
|DisplayName|**Is Customizable**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`iscustomizable`|
|RequiredLevel|SystemRequired|
|Type|ManagedProperty|

### <a name="BKMK_msdyn_delay_between_retries"></a> msdyn_delay_between_retries

|Property|Value|
|---|---|
|Description|**The delay in seconds between retry attempts for the planner configuration.**|
|DisplayName|**Delay Between Retries**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_delay_between_retries`|
|RequiredLevel|None|
|Type|Integer|
|MaxValue|2147483647|
|MinValue|0|

### <a name="BKMK_msdyn_fallback_engagement_config_id"></a> msdyn_fallback_engagement_config_id

|Property|Value|
|---|---|
|Description|**Reference to the Proactive Engagement Configuration to use as fallback.**|
|DisplayName|**Fallback Engagement Configuration**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_fallback_engagement_config_id`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|msdyn_proactive_engagement_config|

### <a name="BKMK_msdyn_name"></a> msdyn_name

|Property|Value|
|---|---|
|Description|**The name of the custom entity.**|
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

### <a name="BKMK_msdyn_number_of_retries"></a> msdyn_number_of_retries

|Property|Value|
|---|---|
|Description|**The maximum number of retry attempts for the planner configuration.**|
|DisplayName|**Number of Retries**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_number_of_retries`|
|RequiredLevel|None|
|Type|Integer|
|MaxValue|2147483647|
|MinValue|0|

### <a name="BKMK_msdyn_proactive_engagement_config_id"></a> msdyn_proactive_engagement_config_id

|Property|Value|
|---|---|
|Description|**Reference to the Proactive Engagement Configuration.**|
|DisplayName|**Proactive Engagement Configuration**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_proactive_engagement_config_id`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|msdyn_proactive_engagement_config|

### <a name="BKMK_msdyn_proactive_engagement_message_templateId"></a> msdyn_proactive_engagement_message_templateId

|Property|Value|
|---|---|
|Description|**Reference to the Proactive Engagement Message Template used by this planner configuration.**|
|DisplayName|**Message Template**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_proactive_engagement_message_templateid`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|msdyn_proactive_engagement_message_template|

### <a name="BKMK_msdyn_proactive_engagement_planner_configId"></a> msdyn_proactive_engagement_planner_configId

|Property|Value|
|---|---|
|Description|**Unique identifier for entity instances**|
|DisplayName|**Proactive Engagement Planner Configuration**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`msdyn_proactive_engagement_planner_configid`|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|

### <a name="BKMK_msdyn_reattempt_rules"></a> msdyn_reattempt_rules

|Property|Value|
|---|---|
|Description|**Specifies the conditions under which reattempts should occur for the planner configuration.**|
|DisplayName|**Reattempt Rules**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_reattempt_rules`|
|RequiredLevel|None|
|Type|MultiSelectPicklist|
|DefaultFormValue||
|GlobalChoiceName|`msdyn_proactive_engagement_planner_config_msdyn_reattempt_rules`|

#### msdyn_reattempt_rules Choices/Options

|Value|Label|
|---|---|
|192360000|**No Answer**|
|192360001|**Busy**|
|192360002|**Failed**|
|192360003|**Answering Machine**|

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
|Description|**Status of the Proactive Engagement Planner Configuration**|
|DisplayName|**Status**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statecode`|
|RequiredLevel|SystemRequired|
|Type|State|
|DefaultFormValue||
|GlobalChoiceName|`msdyn_proactive_engagement_planner_config_statecode`|

#### statecode Choices/Options

|Value|Details|
|---|---|
|0|Label: **Active**<br />DefaultStatus: 1<br />InvariantName: `Active`|
|1|Label: **Inactive**<br />DefaultStatus: 2<br />InvariantName: `Inactive`|

### <a name="BKMK_statuscode"></a> statuscode

|Property|Value|
|---|---|
|Description|**Reason for the status of the Proactive Engagement Planner Configuration**|
|DisplayName|**Status Reason**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statuscode`|
|RequiredLevel|None|
|Type|Status|
|DefaultFormValue||
|GlobalChoiceName|`msdyn_proactive_engagement_planner_config_statuscode`|

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

- [ComponentIdUnique](#BKMK_ComponentIdUnique)
- [ComponentState](#BKMK_ComponentState)
- [CreatedBy](#BKMK_CreatedBy)
- [CreatedOn](#BKMK_CreatedOn)
- [CreatedOnBehalfBy](#BKMK_CreatedOnBehalfBy)
- [IsManaged](#BKMK_IsManaged)
- [ModifiedBy](#BKMK_ModifiedBy)
- [ModifiedOn](#BKMK_ModifiedOn)
- [ModifiedOnBehalfBy](#BKMK_ModifiedOnBehalfBy)
- [OverwriteTime](#BKMK_OverwriteTime)
- [OwnerIdName](#BKMK_OwnerIdName)
- [OwnerIdYomiName](#BKMK_OwnerIdYomiName)
- [OwningBusinessUnit](#BKMK_OwningBusinessUnit)
- [OwningTeam](#BKMK_OwningTeam)
- [OwningUser](#BKMK_OwningUser)
- [SolutionId](#BKMK_SolutionId)
- [SupportingSolutionId](#BKMK_SupportingSolutionId)
- [VersionNumber](#BKMK_VersionNumber)

### <a name="BKMK_ComponentIdUnique"></a> ComponentIdUnique

|Property|Value|
|---|---|
|Description|**For internal use only.**|
|DisplayName|**Row id unique**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`componentidunique`|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|

### <a name="BKMK_ComponentState"></a> ComponentState

|Property|Value|
|---|---|
|Description|**For internal use only.**|
|DisplayName|**Component State**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`componentstate`|
|RequiredLevel|SystemRequired|
|Type|Picklist|
|DefaultFormValue||
|GlobalChoiceName|`componentstate`|

#### ComponentState Choices/Options

|Value|Label|
|---|---|
|0|**Published**|
|1|**Unpublished**|
|2|**Deleted**|
|3|**Deleted Unpublished**|

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

### <a name="BKMK_IsManaged"></a> IsManaged

|Property|Value|
|---|---|
|Description|**Indicates whether the solution component is part of a managed solution.**|
|DisplayName|**Is Managed**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`ismanaged`|
|RequiredLevel|SystemRequired|
|Type|Boolean|
|GlobalChoiceName|`ismanaged`|
|DefaultValue|False|
|True Label|Managed|
|False Label|Unmanaged|

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

### <a name="BKMK_OverwriteTime"></a> OverwriteTime

|Property|Value|
|---|---|
|Description|**For internal use only.**|
|DisplayName|**Record Overwrite Time**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`overwritetime`|
|RequiredLevel|SystemRequired|
|Type|DateTime|
|CanChangeDateTimeBehavior|False|
|DateTimeBehavior|UserLocal|
|Format|DateAndTime|
|ImeMode|Inactive|
|SourceTypeMask|0|

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

### <a name="BKMK_SolutionId"></a> SolutionId

|Property|Value|
|---|---|
|Description|**Unique identifier of the associated solution.**|
|DisplayName|**Solution**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`solutionid`|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|

### <a name="BKMK_SupportingSolutionId"></a> SupportingSolutionId

|Property|Value|
|---|---|
|Description|**For internal use only.**|
|DisplayName|**Solution**|
|IsValidForForm|False|
|IsValidForRead|False|
|LogicalName|`supportingsolutionid`|
|RequiredLevel|None|
|Type|Uniqueidentifier|

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

- [business_unit_msdyn_proactive_engagement_planner_config](#BKMK_business_unit_msdyn_proactive_engagement_planner_config)
- [lk_msdyn_proactive_engagement_planner_config_createdby](#BKMK_lk_msdyn_proactive_engagement_planner_config_createdby)
- [lk_msdyn_proactive_engagement_planner_config_createdonbehalfby](#BKMK_lk_msdyn_proactive_engagement_planner_config_createdonbehalfby)
- [lk_msdyn_proactive_engagement_planner_config_modifiedby](#BKMK_lk_msdyn_proactive_engagement_planner_config_modifiedby)
- [lk_msdyn_proactive_engagement_planner_config_modifiedonbehalfby](#BKMK_lk_msdyn_proactive_engagement_planner_config_modifiedonbehalfby)
- [msdyn_proactive_engagement_config_msdyn_proactive_engagement_planner_config_engagement_config](#BKMK_msdyn_proactive_engagement_config_msdyn_proactive_engagement_planner_config_engagement_config)
- [msdyn_proactive_engagement_config_msdyn_proactive_engagement_planner_config_fallback_engagement_config](#BKMK_msdyn_proactive_engagement_config_msdyn_proactive_engagement_planner_config_fallback_engagement_config)
- [msdyn_proactive_engagement_planner_config_msdyn_proactive_engagement_message_template](#BKMK_msdyn_proactive_engagement_planner_config_msdyn_proactive_engagement_message_template)
- [owner_msdyn_proactive_engagement_planner_config](#BKMK_owner_msdyn_proactive_engagement_planner_config)
- [team_msdyn_proactive_engagement_planner_config](#BKMK_team_msdyn_proactive_engagement_planner_config)
- [user_msdyn_proactive_engagement_planner_config](#BKMK_user_msdyn_proactive_engagement_planner_config)

### <a name="BKMK_business_unit_msdyn_proactive_engagement_planner_config"></a> business_unit_msdyn_proactive_engagement_planner_config

One-To-Many Relationship: [businessunit business_unit_msdyn_proactive_engagement_planner_config](businessunit.md#BKMK_business_unit_msdyn_proactive_engagement_planner_config)

|Property|Value|
|---|---|
|ReferencedEntity|`businessunit`|
|ReferencedAttribute|`businessunitid`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencingEntityNavigationPropertyName|`owningbusinessunit`|
|IsHierarchical||
|CascadeConfiguration|Archive: `Restrict`<br />Assign: `NoCascade`<br />Delete: `Restrict`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_proactive_engagement_planner_config_createdby"></a> lk_msdyn_proactive_engagement_planner_config_createdby

One-To-Many Relationship: [systemuser lk_msdyn_proactive_engagement_planner_config_createdby](systemuser.md#BKMK_lk_msdyn_proactive_engagement_planner_config_createdby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdby`|
|ReferencingEntityNavigationPropertyName|`createdby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_proactive_engagement_planner_config_createdonbehalfby"></a> lk_msdyn_proactive_engagement_planner_config_createdonbehalfby

One-To-Many Relationship: [systemuser lk_msdyn_proactive_engagement_planner_config_createdonbehalfby](systemuser.md#BKMK_lk_msdyn_proactive_engagement_planner_config_createdonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdonbehalfby`|
|ReferencingEntityNavigationPropertyName|`createdonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_proactive_engagement_planner_config_modifiedby"></a> lk_msdyn_proactive_engagement_planner_config_modifiedby

One-To-Many Relationship: [systemuser lk_msdyn_proactive_engagement_planner_config_modifiedby](systemuser.md#BKMK_lk_msdyn_proactive_engagement_planner_config_modifiedby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedby`|
|ReferencingEntityNavigationPropertyName|`modifiedby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_proactive_engagement_planner_config_modifiedonbehalfby"></a> lk_msdyn_proactive_engagement_planner_config_modifiedonbehalfby

One-To-Many Relationship: [systemuser lk_msdyn_proactive_engagement_planner_config_modifiedonbehalfby](systemuser.md#BKMK_lk_msdyn_proactive_engagement_planner_config_modifiedonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedonbehalfby`|
|ReferencingEntityNavigationPropertyName|`modifiedonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_proactive_engagement_config_msdyn_proactive_engagement_planner_config_engagement_config"></a> msdyn_proactive_engagement_config_msdyn_proactive_engagement_planner_config_engagement_config

One-To-Many Relationship: [msdyn_proactive_engagement_config msdyn_proactive_engagement_config_msdyn_proactive_engagement_planner_config_engagement_config](msdyn_proactive_engagement_config.md#BKMK_msdyn_proactive_engagement_config_msdyn_proactive_engagement_planner_config_engagement_config)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_proactive_engagement_config`|
|ReferencedAttribute|`msdyn_proactive_engagement_configid`|
|ReferencingAttribute|`msdyn_proactive_engagement_config_id`|
|ReferencingEntityNavigationPropertyName|`msdyn_proactive_engagement_config_id`|
|IsHierarchical||
|CascadeConfiguration|Archive: `RemoveLink`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_proactive_engagement_config_msdyn_proactive_engagement_planner_config_fallback_engagement_config"></a> msdyn_proactive_engagement_config_msdyn_proactive_engagement_planner_config_fallback_engagement_config

One-To-Many Relationship: [msdyn_proactive_engagement_config msdyn_proactive_engagement_config_msdyn_proactive_engagement_planner_config_fallback_engagement_config](msdyn_proactive_engagement_config.md#BKMK_msdyn_proactive_engagement_config_msdyn_proactive_engagement_planner_config_fallback_engagement_config)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_proactive_engagement_config`|
|ReferencedAttribute|`msdyn_proactive_engagement_configid`|
|ReferencingAttribute|`msdyn_fallback_engagement_config_id`|
|ReferencingEntityNavigationPropertyName|`msdyn_fallback_engagement_config_id`|
|IsHierarchical||
|CascadeConfiguration|Archive: `RemoveLink`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_proactive_engagement_planner_config_msdyn_proactive_engagement_message_template"></a> msdyn_proactive_engagement_planner_config_msdyn_proactive_engagement_message_template

One-To-Many Relationship: [msdyn_proactive_engagement_message_template msdyn_proactive_engagement_planner_config_msdyn_proactive_engagement_message_template](msdyn_proactive_engagement_message_template.md#BKMK_msdyn_proactive_engagement_planner_config_msdyn_proactive_engagement_message_template)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_proactive_engagement_message_template`|
|ReferencedAttribute|`msdyn_proactive_engagement_message_templateid`|
|ReferencingAttribute|`msdyn_proactive_engagement_message_templateid`|
|ReferencingEntityNavigationPropertyName|`msdyn_proactive_engagement_message_templateid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `RemoveLink`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_owner_msdyn_proactive_engagement_planner_config"></a> owner_msdyn_proactive_engagement_planner_config

One-To-Many Relationship: [owner owner_msdyn_proactive_engagement_planner_config](owner.md#BKMK_owner_msdyn_proactive_engagement_planner_config)

|Property|Value|
|---|---|
|ReferencedEntity|`owner`|
|ReferencedAttribute|`ownerid`|
|ReferencingAttribute|`ownerid`|
|ReferencingEntityNavigationPropertyName|`ownerid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_team_msdyn_proactive_engagement_planner_config"></a> team_msdyn_proactive_engagement_planner_config

One-To-Many Relationship: [team team_msdyn_proactive_engagement_planner_config](team.md#BKMK_team_msdyn_proactive_engagement_planner_config)

|Property|Value|
|---|---|
|ReferencedEntity|`team`|
|ReferencedAttribute|`teamid`|
|ReferencingAttribute|`owningteam`|
|ReferencingEntityNavigationPropertyName|`owningteam`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_user_msdyn_proactive_engagement_planner_config"></a> user_msdyn_proactive_engagement_planner_config

One-To-Many Relationship: [systemuser user_msdyn_proactive_engagement_planner_config](systemuser.md#BKMK_user_msdyn_proactive_engagement_planner_config)

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

- [msdyn_proactive_engagement_planner_config_AsyncOperations](#BKMK_msdyn_proactive_engagement_planner_config_AsyncOperations)
- [msdyn_proactive_engagement_planner_config_BulkDeleteFailures](#BKMK_msdyn_proactive_engagement_planner_config_BulkDeleteFailures)
- [msdyn_proactive_engagement_planner_config_DuplicateBaseRecord](#BKMK_msdyn_proactive_engagement_planner_config_DuplicateBaseRecord)
- [msdyn_proactive_engagement_planner_config_DuplicateMatchingRecord](#BKMK_msdyn_proactive_engagement_planner_config_DuplicateMatchingRecord)
- [msdyn_proactive_engagement_planner_config_MailboxTrackingFolders](#BKMK_msdyn_proactive_engagement_planner_config_MailboxTrackingFolders)
- [msdyn_proactive_engagement_planner_config_PrincipalObjectAttributeAccesses](#BKMK_msdyn_proactive_engagement_planner_config_PrincipalObjectAttributeAccesses)
- [msdyn_proactive_engagement_planner_config_ProcessSession](#BKMK_msdyn_proactive_engagement_planner_config_ProcessSession)
- [msdyn_proactive_engagement_planner_config_SyncErrors](#BKMK_msdyn_proactive_engagement_planner_config_SyncErrors)

### <a name="BKMK_msdyn_proactive_engagement_planner_config_AsyncOperations"></a> msdyn_proactive_engagement_planner_config_AsyncOperations

Many-To-One Relationship: [asyncoperation msdyn_proactive_engagement_planner_config_AsyncOperations](asyncoperation.md#BKMK_msdyn_proactive_engagement_planner_config_AsyncOperations)

|Property|Value|
|---|---|
|ReferencingEntity|`asyncoperation`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_proactive_engagement_planner_config_AsyncOperations`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_proactive_engagement_planner_config_BulkDeleteFailures"></a> msdyn_proactive_engagement_planner_config_BulkDeleteFailures

Many-To-One Relationship: [bulkdeletefailure msdyn_proactive_engagement_planner_config_BulkDeleteFailures](bulkdeletefailure.md#BKMK_msdyn_proactive_engagement_planner_config_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencingEntity|`bulkdeletefailure`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_proactive_engagement_planner_config_BulkDeleteFailures`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_proactive_engagement_planner_config_DuplicateBaseRecord"></a> msdyn_proactive_engagement_planner_config_DuplicateBaseRecord

Many-To-One Relationship: [duplicaterecord msdyn_proactive_engagement_planner_config_DuplicateBaseRecord](duplicaterecord.md#BKMK_msdyn_proactive_engagement_planner_config_DuplicateBaseRecord)

|Property|Value|
|---|---|
|ReferencingEntity|`duplicaterecord`|
|ReferencingAttribute|`baserecordid`|
|ReferencedEntityNavigationPropertyName|`msdyn_proactive_engagement_planner_config_DuplicateBaseRecord`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_proactive_engagement_planner_config_DuplicateMatchingRecord"></a> msdyn_proactive_engagement_planner_config_DuplicateMatchingRecord

Many-To-One Relationship: [duplicaterecord msdyn_proactive_engagement_planner_config_DuplicateMatchingRecord](duplicaterecord.md#BKMK_msdyn_proactive_engagement_planner_config_DuplicateMatchingRecord)

|Property|Value|
|---|---|
|ReferencingEntity|`duplicaterecord`|
|ReferencingAttribute|`duplicaterecordid`|
|ReferencedEntityNavigationPropertyName|`msdyn_proactive_engagement_planner_config_DuplicateMatchingRecord`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_proactive_engagement_planner_config_MailboxTrackingFolders"></a> msdyn_proactive_engagement_planner_config_MailboxTrackingFolders

Many-To-One Relationship: [mailboxtrackingfolder msdyn_proactive_engagement_planner_config_MailboxTrackingFolders](mailboxtrackingfolder.md#BKMK_msdyn_proactive_engagement_planner_config_MailboxTrackingFolders)

|Property|Value|
|---|---|
|ReferencingEntity|`mailboxtrackingfolder`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_proactive_engagement_planner_config_MailboxTrackingFolders`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_proactive_engagement_planner_config_PrincipalObjectAttributeAccesses"></a> msdyn_proactive_engagement_planner_config_PrincipalObjectAttributeAccesses

Many-To-One Relationship: [principalobjectattributeaccess msdyn_proactive_engagement_planner_config_PrincipalObjectAttributeAccesses](principalobjectattributeaccess.md#BKMK_msdyn_proactive_engagement_planner_config_PrincipalObjectAttributeAccesses)

|Property|Value|
|---|---|
|ReferencingEntity|`principalobjectattributeaccess`|
|ReferencingAttribute|`objectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_proactive_engagement_planner_config_PrincipalObjectAttributeAccesses`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_proactive_engagement_planner_config_ProcessSession"></a> msdyn_proactive_engagement_planner_config_ProcessSession

Many-To-One Relationship: [processsession msdyn_proactive_engagement_planner_config_ProcessSession](processsession.md#BKMK_msdyn_proactive_engagement_planner_config_ProcessSession)

|Property|Value|
|---|---|
|ReferencingEntity|`processsession`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_proactive_engagement_planner_config_ProcessSession`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_proactive_engagement_planner_config_SyncErrors"></a> msdyn_proactive_engagement_planner_config_SyncErrors

Many-To-One Relationship: [syncerror msdyn_proactive_engagement_planner_config_SyncErrors](syncerror.md#BKMK_msdyn_proactive_engagement_planner_config_SyncErrors)

|Property|Value|
|---|---|
|ReferencingEntity|`syncerror`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_proactive_engagement_planner_config_SyncErrors`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|



### See also

[Dataverse table/entity reference](/power-apps/developer/data-platform/reference/about-entity-reference)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   

