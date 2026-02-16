---
title: "Sales agent processing state (msdyn_salesagentprocessingstate) table/entity reference (Microsoft Dynamics 365)"
description: "Includes schema information and supported messages for the Sales agent processing state (msdyn_salesagentprocessingstate) table/entity with Microsoft Dynamics 365."
ms.topic: generated-reference
author: JimDaly
ms.author: jdaly
search.audienceType: 
  - developer
---

# Sales agent processing state (msdyn_salesagentprocessingstate) table/entity reference (Microsoft Dynamics 365)

This table maintains the state of agent process

## Messages

The following table lists the messages for the Sales agent processing state (msdyn_salesagentprocessingstate) table.
Messages represent operations that can be performed on the table. They may also be events.

| Name <br />Is Event? |Web API Operation |SDK for .NET |
| ---- | ----- |----- |
| `Assign`<br />Event: True |`PATCH` /msdyn_salesagentprocessingstates(*msdyn_salesagentprocessingstateid*)<br />[Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) the `ownerid` property. |<xref:Microsoft.Crm.Sdk.Messages.AssignRequest>|
| `Associate`<br />Event: True |[Associate records](/power-apps/developer/data-platform/webapi/associate-disassociate-entities-using-web-api) |[Associate records](/power-apps/developer/data-platform/org-service/entity-operations-associate-disassociate#use-the-associate-method-or-associaterequest)|
| `BulkRetain`<br />Event: True |<xref:Microsoft.Dynamics.CRM.BulkRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Create`<br />Event: True |`POST` /msdyn_salesagentprocessingstates<br />See [Create](/powerapps/developer/data-platform/webapi/create-entity-web-api) |[Create records](/power-apps/developer/data-platform/org-service/entity-operations-create#basic-create)|
| `CreateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.CreateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.CreateMultipleRequest>|
| `Delete`<br />Event: True |`DELETE` /msdyn_salesagentprocessingstates(*msdyn_salesagentprocessingstateid*)<br />See [Delete](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-delete) |[Delete records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-delete)|
| `Disassociate`<br />Event: True |[Disassociate records](/power-apps/developer/data-platform/webapi/associate-disassociate-entities-using-web-api) |[Disassociate records](/power-apps/developer/data-platform/org-service/entity-operations-associate-disassociate#use-the-disassociate-method-or-disassociaterequest)|
| `GrantAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.GrantAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.GrantAccessRequest>|
| `IsValidStateTransition`<br />Event: False |<xref:Microsoft.Dynamics.CRM.IsValidStateTransition?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.IsValidStateTransitionRequest>|
| `ModifyAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.ModifyAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.ModifyAccessRequest>|
| `PurgeRetainedContent`<br />Event: True |<xref:Microsoft.Dynamics.CRM.PurgeRetainedContent?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retain`<br />Event: True |<xref:Microsoft.Dynamics.CRM.Retain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retrieve`<br />Event: True |`GET` /msdyn_salesagentprocessingstates(*msdyn_salesagentprocessingstateid*)<br />See [Retrieve](/powerapps/developer/data-platform/webapi/retrieve-entity-using-web-api) |[Retrieve records](/power-apps/developer/data-platform/org-service/entity-operations-retrieve)|
| `RetrieveMultiple`<br />Event: True |`GET` /msdyn_salesagentprocessingstates<br />See [Query data](/power-apps/developer/data-platform/webapi/query-data-web-api) |[Query data](/power-apps/developer/data-platform/org-service/entity-operations-query-data)|
| `RetrievePrincipalAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RetrievePrincipalAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RetrievePrincipalAccessRequest>|
| `RetrieveSharedPrincipalsAndAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RetrieveSharedPrincipalsAndAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RetrieveSharedPrincipalsAndAccessRequest>|
| `RevokeAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RevokeAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RevokeAccessRequest>|
| `RollbackRetain`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RollbackRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `SetState`<br />Event: True |`PATCH` /msdyn_salesagentprocessingstates(*msdyn_salesagentprocessingstateid*)<br />[Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) the `statecode` and `statuscode` properties. |<xref:Microsoft.Crm.Sdk.Messages.SetStateRequest>|
| `Update`<br />Event: True |`PATCH` /msdyn_salesagentprocessingstates(*msdyn_salesagentprocessingstateid*)<br />See [Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) |[Update records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-update)|
| `UpdateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.UpdateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpdateMultipleRequest>|
| `Upsert`<br />Event: False |`PATCH` /msdyn_salesagentprocessingstates(*msdyn_salesagentprocessingstateid*)<br />See [Upsert a table row](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#upsert-a-table-row) |<xref:Microsoft.Xrm.Sdk.Messages.UpsertRequest>|
| `UpsertMultiple`<br />Event: False |<xref:Microsoft.Dynamics.CRM.UpsertMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpsertMultipleRequest>|
| `ValidateRetentionConfig`<br />Event: True |<xref:Microsoft.Dynamics.CRM.ValidateRetentionConfig?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|

## Properties

The following table lists selected properties for the Sales agent processing state (msdyn_salesagentprocessingstate) table.

|Property|Value|
| --- | --- |
| **DisplayName** | **Sales agent processing state** |
| **DisplayCollectionName** | **Sales agent processing states** |
| **SchemaName** | `msdyn_salesagentprocessingstate` |
| **CollectionSchemaName** | `msdyn_salesagentprocessingstates` |
| **EntitySetName** | `msdyn_salesagentprocessingstates`|
| **LogicalName** | `msdyn_salesagentprocessingstate` |
| **LogicalCollectionName** | `msdyn_salesagentprocessingstates` |
| **PrimaryIdAttribute** | `msdyn_salesagentprocessingstateid` |
| **PrimaryNameAttribute** |`msdyn_name` |
| **TableType** | `Standard` |
| **OwnershipType** | `UserOwned` |

## Writable columns/attributes

These columns/attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [ImportSequenceNumber](#BKMK_ImportSequenceNumber)
- [msdyn_agentorchestrationid](#BKMK_msdyn_agentorchestrationid)
- [msdyn_currentprocessingstate](#BKMK_msdyn_currentprocessingstate)
- [msdyn_lastresearchendtime](#BKMK_msdyn_lastresearchendtime)
- [msdyn_lastresearchstarttime](#BKMK_msdyn_lastresearchstarttime)
- [msdyn_name](#BKMK_msdyn_name)
- [msdyn_nextrefreshtime](#BKMK_msdyn_nextrefreshtime)
- [msdyn_regardingentity](#BKMK_msdyn_regardingentity)
- [msdyn_salesagentprocessingstateId](#BKMK_msdyn_salesagentprocessingstateId)
- [msdyn_salesagentprofile](#BKMK_msdyn_salesagentprofile)
- [msdyn_totalresearchcount](#BKMK_msdyn_totalresearchcount)
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

### <a name="BKMK_msdyn_agentorchestrationid"></a> msdyn_agentorchestrationid

|Property|Value|
|---|---|
|Description|**Unique Id for the current agent orchestration run**|
|DisplayName|**Agent Orchestration Id**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_agentorchestrationid`|
|RequiredLevel|None|
|Type|Uniqueidentifier|

### <a name="BKMK_msdyn_currentprocessingstate"></a> msdyn_currentprocessingstate

|Property|Value|
|---|---|
|Description|**State of currently processing sales agent**|
|DisplayName|**Current Processing State**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_currentprocessingstate`|
|RequiredLevel|ApplicationRequired|
|Type|Picklist|
|DefaultFormValue|1|
|GlobalChoiceName|`msdyn_salesagentprocessingstate_msdyn_currentprocessingstate`|

#### msdyn_currentprocessingstate Choices/Options

|Value|Label|
|---|---|
|1|**Ready**|
|2|**InProgress**|
|3|**Completed**|
|4|**Failed**|

### <a name="BKMK_msdyn_lastresearchendtime"></a> msdyn_lastresearchendtime

|Property|Value|
|---|---|
|Description|**Time when the last research was completed**|
|DisplayName|**Last Research End Time**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_lastresearchendtime`|
|RequiredLevel|None|
|Type|DateTime|
|CanChangeDateTimeBehavior|True|
|DateTimeBehavior|UserLocal|
|Format|DateAndTime|
|ImeMode|Auto|
|SourceTypeMask|0|

### <a name="BKMK_msdyn_lastresearchstarttime"></a> msdyn_lastresearchstarttime

|Property|Value|
|---|---|
|Description|**Time when the last research was started**|
|DisplayName|**Last Research Start Time**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_lastresearchstarttime`|
|RequiredLevel|None|
|Type|DateTime|
|CanChangeDateTimeBehavior|True|
|DateTimeBehavior|UserLocal|
|Format|DateAndTime|
|ImeMode|Auto|
|SourceTypeMask|0|

### <a name="BKMK_msdyn_name"></a> msdyn_name

|Property|Value|
|---|---|
|Description|**The name of the processing state**|
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
|MaxLength|100|

### <a name="BKMK_msdyn_nextrefreshtime"></a> msdyn_nextrefreshtime

|Property|Value|
|---|---|
|Description|**Next time the sales agent processing state will be refreshed.**|
|DisplayName|**Next Refresh Time**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_nextrefreshtime`|
|RequiredLevel|None|
|Type|DateTime|
|CanChangeDateTimeBehavior|True|
|DateTimeBehavior|UserLocal|
|Format|DateAndTime|
|ImeMode|Auto|
|SourceTypeMask|0|

### <a name="BKMK_msdyn_regardingentity"></a> msdyn_regardingentity

|Property|Value|
|---|---|
|Description|**Entity with which the agent process is associated.**|
|DisplayName|**Regarding Entity**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_regardingentity`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|opportunity|

### <a name="BKMK_msdyn_salesagentprocessingstateId"></a> msdyn_salesagentprocessingstateId

|Property|Value|
|---|---|
|Description|**Unique identifier for entity instances**|
|DisplayName|**Sales agent processing state**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`msdyn_salesagentprocessingstateid`|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|

### <a name="BKMK_msdyn_salesagentprofile"></a> msdyn_salesagentprofile

|Property|Value|
|---|---|
|Description|**Agent profile associated with the current processing.**|
|DisplayName|**Sales agent profile**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_salesagentprofile`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|msdyn_salesagentprofile|

### <a name="BKMK_msdyn_totalresearchcount"></a> msdyn_totalresearchcount

|Property|Value|
|---|---|
|Description|**Total number of research activities conducted.**|
|DisplayName|**Total Research Count**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_totalresearchcount`|
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

### <a name="BKMK_statecode"></a> statecode

|Property|Value|
|---|---|
|Description|**Status of the Sales agent processing state**|
|DisplayName|**Status**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statecode`|
|RequiredLevel|SystemRequired|
|Type|State|
|DefaultFormValue||
|GlobalChoiceName|`msdyn_salesagentprocessingstate_statecode`|

#### statecode Choices/Options

|Value|Details|
|---|---|
|0|Label: **Active**<br />DefaultStatus: 1<br />InvariantName: `Active`|
|1|Label: **Inactive**<br />DefaultStatus: 2<br />InvariantName: `Inactive`|

### <a name="BKMK_statuscode"></a> statuscode

|Property|Value|
|---|---|
|Description|**Reason for the status of the Sales agent processing state**|
|DisplayName|**Status Reason**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statuscode`|
|RequiredLevel|None|
|Type|Status|
|DefaultFormValue||
|GlobalChoiceName|`msdyn_salesagentprocessingstate_statuscode`|

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

- [business_unit_msdyn_salesagentprocessingstate](#BKMK_business_unit_msdyn_salesagentprocessingstate)
- [lk_msdyn_salesagentprocessingstate_createdby](#BKMK_lk_msdyn_salesagentprocessingstate_createdby)
- [lk_msdyn_salesagentprocessingstate_createdonbehalfby](#BKMK_lk_msdyn_salesagentprocessingstate_createdonbehalfby)
- [lk_msdyn_salesagentprocessingstate_modifiedby](#BKMK_lk_msdyn_salesagentprocessingstate_modifiedby)
- [lk_msdyn_salesagentprocessingstate_modifiedonbehalfby](#BKMK_lk_msdyn_salesagentprocessingstate_modifiedonbehalfby)
- [msdyn_salesagentprocessingstate_regardingentity_opportunity](#BKMK_msdyn_salesagentprocessingstate_regardingentity_opportunity)
- [msdyn_salesagentprocessingstate_salesagentprofile_msdyn_salesagentprofile](#BKMK_msdyn_salesagentprocessingstate_salesagentprofile_msdyn_salesagentprofile)
- [owner_msdyn_salesagentprocessingstate](#BKMK_owner_msdyn_salesagentprocessingstate)
- [team_msdyn_salesagentprocessingstate](#BKMK_team_msdyn_salesagentprocessingstate)
- [user_msdyn_salesagentprocessingstate](#BKMK_user_msdyn_salesagentprocessingstate)

### <a name="BKMK_business_unit_msdyn_salesagentprocessingstate"></a> business_unit_msdyn_salesagentprocessingstate

One-To-Many Relationship: [businessunit business_unit_msdyn_salesagentprocessingstate](businessunit.md#BKMK_business_unit_msdyn_salesagentprocessingstate)

|Property|Value|
|---|---|
|ReferencedEntity|`businessunit`|
|ReferencedAttribute|`businessunitid`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencingEntityNavigationPropertyName|`owningbusinessunit`|
|IsHierarchical||
|CascadeConfiguration|Archive: `Restrict`<br />Assign: `NoCascade`<br />Delete: `Restrict`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_salesagentprocessingstate_createdby"></a> lk_msdyn_salesagentprocessingstate_createdby

One-To-Many Relationship: [systemuser lk_msdyn_salesagentprocessingstate_createdby](systemuser.md#BKMK_lk_msdyn_salesagentprocessingstate_createdby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdby`|
|ReferencingEntityNavigationPropertyName|`createdby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_salesagentprocessingstate_createdonbehalfby"></a> lk_msdyn_salesagentprocessingstate_createdonbehalfby

One-To-Many Relationship: [systemuser lk_msdyn_salesagentprocessingstate_createdonbehalfby](systemuser.md#BKMK_lk_msdyn_salesagentprocessingstate_createdonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdonbehalfby`|
|ReferencingEntityNavigationPropertyName|`createdonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_salesagentprocessingstate_modifiedby"></a> lk_msdyn_salesagentprocessingstate_modifiedby

One-To-Many Relationship: [systemuser lk_msdyn_salesagentprocessingstate_modifiedby](systemuser.md#BKMK_lk_msdyn_salesagentprocessingstate_modifiedby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedby`|
|ReferencingEntityNavigationPropertyName|`modifiedby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_salesagentprocessingstate_modifiedonbehalfby"></a> lk_msdyn_salesagentprocessingstate_modifiedonbehalfby

One-To-Many Relationship: [systemuser lk_msdyn_salesagentprocessingstate_modifiedonbehalfby](systemuser.md#BKMK_lk_msdyn_salesagentprocessingstate_modifiedonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedonbehalfby`|
|ReferencingEntityNavigationPropertyName|`modifiedonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_salesagentprocessingstate_regardingentity_opportunity"></a> msdyn_salesagentprocessingstate_regardingentity_opportunity

One-To-Many Relationship: [opportunity msdyn_salesagentprocessingstate_regardingentity_opportunity](opportunity.md#BKMK_msdyn_salesagentprocessingstate_regardingentity_opportunity)

|Property|Value|
|---|---|
|ReferencedEntity|`opportunity`|
|ReferencedAttribute|`opportunityid`|
|ReferencingAttribute|`msdyn_regardingentity`|
|ReferencingEntityNavigationPropertyName|`msdyn_regardingentity`|
|IsHierarchical||
|CascadeConfiguration|Archive: `RemoveLink`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_salesagentprocessingstate_salesagentprofile_msdyn_salesagentprofile"></a> msdyn_salesagentprocessingstate_salesagentprofile_msdyn_salesagentprofile

One-To-Many Relationship: [msdyn_salesagentprofile msdyn_salesagentprocessingstate_salesagentprofile_msdyn_salesagentprofile](msdyn_salesagentprofile.md#BKMK_msdyn_salesagentprocessingstate_salesagentprofile_msdyn_salesagentprofile)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_salesagentprofile`|
|ReferencedAttribute|`msdyn_salesagentprofileid`|
|ReferencingAttribute|`msdyn_salesagentprofile`|
|ReferencingEntityNavigationPropertyName|`msdyn_salesagentprofile`|
|IsHierarchical||
|CascadeConfiguration|Archive: `RemoveLink`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_owner_msdyn_salesagentprocessingstate"></a> owner_msdyn_salesagentprocessingstate

One-To-Many Relationship: [owner owner_msdyn_salesagentprocessingstate](owner.md#BKMK_owner_msdyn_salesagentprocessingstate)

|Property|Value|
|---|---|
|ReferencedEntity|`owner`|
|ReferencedAttribute|`ownerid`|
|ReferencingAttribute|`ownerid`|
|ReferencingEntityNavigationPropertyName|`ownerid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_team_msdyn_salesagentprocessingstate"></a> team_msdyn_salesagentprocessingstate

One-To-Many Relationship: [team team_msdyn_salesagentprocessingstate](team.md#BKMK_team_msdyn_salesagentprocessingstate)

|Property|Value|
|---|---|
|ReferencedEntity|`team`|
|ReferencedAttribute|`teamid`|
|ReferencingAttribute|`owningteam`|
|ReferencingEntityNavigationPropertyName|`owningteam`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_user_msdyn_salesagentprocessingstate"></a> user_msdyn_salesagentprocessingstate

One-To-Many Relationship: [systemuser user_msdyn_salesagentprocessingstate](systemuser.md#BKMK_user_msdyn_salesagentprocessingstate)

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

- [msdyn_salesagentprocessingstate_AsyncOperations](#BKMK_msdyn_salesagentprocessingstate_AsyncOperations)
- [msdyn_salesagentprocessingstate_BulkDeleteFailures](#BKMK_msdyn_salesagentprocessingstate_BulkDeleteFailures)
- [msdyn_salesagentprocessingstate_MailboxTrackingFolders](#BKMK_msdyn_salesagentprocessingstate_MailboxTrackingFolders)
- [msdyn_salesagentprocessingstate_PrincipalObjectAttributeAccesses](#BKMK_msdyn_salesagentprocessingstate_PrincipalObjectAttributeAccesses)
- [msdyn_salesagentprocessingstate_ProcessSession](#BKMK_msdyn_salesagentprocessingstate_ProcessSession)
- [msdyn_salesagentprocessingstate_SyncErrors](#BKMK_msdyn_salesagentprocessingstate_SyncErrors)

### <a name="BKMK_msdyn_salesagentprocessingstate_AsyncOperations"></a> msdyn_salesagentprocessingstate_AsyncOperations

Many-To-One Relationship: [asyncoperation msdyn_salesagentprocessingstate_AsyncOperations](asyncoperation.md#BKMK_msdyn_salesagentprocessingstate_AsyncOperations)

|Property|Value|
|---|---|
|ReferencingEntity|`asyncoperation`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_salesagentprocessingstate_AsyncOperations`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_salesagentprocessingstate_BulkDeleteFailures"></a> msdyn_salesagentprocessingstate_BulkDeleteFailures

Many-To-One Relationship: [bulkdeletefailure msdyn_salesagentprocessingstate_BulkDeleteFailures](bulkdeletefailure.md#BKMK_msdyn_salesagentprocessingstate_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencingEntity|`bulkdeletefailure`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_salesagentprocessingstate_BulkDeleteFailures`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_salesagentprocessingstate_MailboxTrackingFolders"></a> msdyn_salesagentprocessingstate_MailboxTrackingFolders

Many-To-One Relationship: [mailboxtrackingfolder msdyn_salesagentprocessingstate_MailboxTrackingFolders](mailboxtrackingfolder.md#BKMK_msdyn_salesagentprocessingstate_MailboxTrackingFolders)

|Property|Value|
|---|---|
|ReferencingEntity|`mailboxtrackingfolder`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_salesagentprocessingstate_MailboxTrackingFolders`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_salesagentprocessingstate_PrincipalObjectAttributeAccesses"></a> msdyn_salesagentprocessingstate_PrincipalObjectAttributeAccesses

Many-To-One Relationship: [principalobjectattributeaccess msdyn_salesagentprocessingstate_PrincipalObjectAttributeAccesses](principalobjectattributeaccess.md#BKMK_msdyn_salesagentprocessingstate_PrincipalObjectAttributeAccesses)

|Property|Value|
|---|---|
|ReferencingEntity|`principalobjectattributeaccess`|
|ReferencingAttribute|`objectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_salesagentprocessingstate_PrincipalObjectAttributeAccesses`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_salesagentprocessingstate_ProcessSession"></a> msdyn_salesagentprocessingstate_ProcessSession

Many-To-One Relationship: [processsession msdyn_salesagentprocessingstate_ProcessSession](processsession.md#BKMK_msdyn_salesagentprocessingstate_ProcessSession)

|Property|Value|
|---|---|
|ReferencingEntity|`processsession`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_salesagentprocessingstate_ProcessSession`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_salesagentprocessingstate_SyncErrors"></a> msdyn_salesagentprocessingstate_SyncErrors

Many-To-One Relationship: [syncerror msdyn_salesagentprocessingstate_SyncErrors](syncerror.md#BKMK_msdyn_salesagentprocessingstate_SyncErrors)

|Property|Value|
|---|---|
|ReferencingEntity|`syncerror`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_salesagentprocessingstate_SyncErrors`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|



### See also

[Dataverse table/entity reference](/power-apps/developer/data-platform/reference/about-entity-reference)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   

