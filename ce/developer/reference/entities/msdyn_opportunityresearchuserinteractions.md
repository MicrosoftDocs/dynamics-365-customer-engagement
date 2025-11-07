---
title: "Opportunity Research User Interactions (msdyn_OpportunityResearchUserInteractions) table/entity reference (Microsoft Dynamics 365)"
description: "Includes schema information and supported messages for the Opportunity Research User Interactions (msdyn_OpportunityResearchUserInteractions) table/entity with Microsoft Dynamics 365."
ms.topic: generated-reference
author: JimDaly
ms.author: jdaly
search.audienceType: 
  - developer
---

# Opportunity Research User Interactions (msdyn_OpportunityResearchUserInteractions) table/entity reference (Microsoft Dynamics 365)



## Messages

The following table lists the messages for the Opportunity Research User Interactions (msdyn_OpportunityResearchUserInteractions) table.
Messages represent operations that can be performed on the table. They may also be events.

| Name <br />Is Event? |Web API Operation |SDK for .NET |
| ---- | ----- |----- |
| `Assign`<br />Event: True |`PATCH` /msdyn_opportunityresearchuserinteractionses(*msdyn_opportunityresearchuserinteractionsid*)<br />[Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) the `ownerid` property. |<xref:Microsoft.Crm.Sdk.Messages.AssignRequest>|
| `Associate`<br />Event: True |[Associate records](/power-apps/developer/data-platform/webapi/associate-disassociate-entities-using-web-api) |[Associate records](/power-apps/developer/data-platform/org-service/entity-operations-associate-disassociate#use-the-associate-method-or-associaterequest)|
| `BulkRetain`<br />Event: True |<xref:Microsoft.Dynamics.CRM.BulkRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Create`<br />Event: True |`POST` /msdyn_opportunityresearchuserinteractionses<br />See [Create](/powerapps/developer/data-platform/webapi/create-entity-web-api) |[Create records](/power-apps/developer/data-platform/org-service/entity-operations-create#basic-create)|
| `CreateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.CreateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.CreateMultipleRequest>|
| `Delete`<br />Event: True |`DELETE` /msdyn_opportunityresearchuserinteractionses(*msdyn_opportunityresearchuserinteractionsid*)<br />See [Delete](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-delete) |[Delete records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-delete)|
| `Disassociate`<br />Event: True |[Disassociate records](/power-apps/developer/data-platform/webapi/associate-disassociate-entities-using-web-api) |[Disassociate records](/power-apps/developer/data-platform/org-service/entity-operations-associate-disassociate#use-the-disassociate-method-or-disassociaterequest)|
| `GrantAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.GrantAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.GrantAccessRequest>|
| `IsValidStateTransition`<br />Event: False |<xref:Microsoft.Dynamics.CRM.IsValidStateTransition?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.IsValidStateTransitionRequest>|
| `ModifyAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.ModifyAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.ModifyAccessRequest>|
| `PurgeRetainedContent`<br />Event: True |<xref:Microsoft.Dynamics.CRM.PurgeRetainedContent?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Restore`<br />Event: True |<xref:Microsoft.Dynamics.CRM.Restore?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retain`<br />Event: True |<xref:Microsoft.Dynamics.CRM.Retain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retrieve`<br />Event: True |`GET` /msdyn_opportunityresearchuserinteractionses(*msdyn_opportunityresearchuserinteractionsid*)<br />See [Retrieve](/powerapps/developer/data-platform/webapi/retrieve-entity-using-web-api) |[Retrieve records](/power-apps/developer/data-platform/org-service/entity-operations-retrieve)|
| `RetrieveMultiple`<br />Event: True |`GET` /msdyn_opportunityresearchuserinteractionses<br />See [Query data](/power-apps/developer/data-platform/webapi/query-data-web-api) |[Query data](/power-apps/developer/data-platform/org-service/entity-operations-query-data)|
| `RetrievePrincipalAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RetrievePrincipalAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RetrievePrincipalAccessRequest>|
| `RetrieveSharedPrincipalsAndAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RetrieveSharedPrincipalsAndAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RetrieveSharedPrincipalsAndAccessRequest>|
| `RevokeAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RevokeAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RevokeAccessRequest>|
| `RollbackRetain`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RollbackRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `SetState`<br />Event: True |`PATCH` /msdyn_opportunityresearchuserinteractionses(*msdyn_opportunityresearchuserinteractionsid*)<br />[Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) the `statecode` and `statuscode` properties. |<xref:Microsoft.Crm.Sdk.Messages.SetStateRequest>|
| `Update`<br />Event: True |`PATCH` /msdyn_opportunityresearchuserinteractionses(*msdyn_opportunityresearchuserinteractionsid*)<br />See [Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) |[Update records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-update)|
| `UpdateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.UpdateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpdateMultipleRequest>|
| `Upsert`<br />Event: False |`PATCH` /msdyn_opportunityresearchuserinteractionses(*msdyn_opportunityresearchuserinteractionsid*)<br />See [Upsert a table row](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#upsert-a-table-row) |<xref:Microsoft.Xrm.Sdk.Messages.UpsertRequest>|
| `UpsertMultiple`<br />Event: False |<xref:Microsoft.Dynamics.CRM.UpsertMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpsertMultipleRequest>|
| `ValidateRetentionConfig`<br />Event: True |<xref:Microsoft.Dynamics.CRM.ValidateRetentionConfig?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|

## Properties

The following table lists selected properties for the Opportunity Research User Interactions (msdyn_OpportunityResearchUserInteractions) table.

|Property|Value|
| --- | --- |
| **DisplayName** | **Opportunity Research User Interactions** |
| **DisplayCollectionName** | **Opportunity Research User Interactions** |
| **SchemaName** | `msdyn_OpportunityResearchUserInteractions` |
| **CollectionSchemaName** | `msdyn_OpportunityResearchUserInteractionses` |
| **EntitySetName** | `msdyn_opportunityresearchuserinteractionses`|
| **LogicalName** | `msdyn_opportunityresearchuserinteractions` |
| **LogicalCollectionName** | `msdyn_opportunityresearchuserinteractionses` |
| **PrimaryIdAttribute** | `msdyn_opportunityresearchuserinteractionsid` |
| **PrimaryNameAttribute** |`msdyn_opportunityresearchuserinteractions` |
| **TableType** | `Standard` |
| **OwnershipType** | `UserOwned` |

## Writable columns/attributes

These columns/attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [ImportSequenceNumber](#BKMK_ImportSequenceNumber)
- [msdyn_Feedback](#BKMK_msdyn_Feedback)
- [msdyn_IsDone](#BKMK_msdyn_IsDone)
- [msdyn_IsSeen](#BKMK_msdyn_IsSeen)
- [msdyn_LastUpdateTimestamp](#BKMK_msdyn_LastUpdateTimestamp)
- [msdyn_macroagentorchestrationid](#BKMK_msdyn_macroagentorchestrationid)
- [msdyn_OpportunityId](#BKMK_msdyn_OpportunityId)
- [msdyn_OpportunityResearchUserInteractions](#BKMK_msdyn_OpportunityResearchUserInteractions)
- [msdyn_OpportunityResearchUserInteractionsId](#BKMK_msdyn_OpportunityResearchUserInteractionsId)
- [msdyn_Result](#BKMK_msdyn_Result)
- [msdyn_SARId](#BKMK_msdyn_SARId)
- [msdyn_Topic](#BKMK_msdyn_Topic)
- [msdyn_UIItemId](#BKMK_msdyn_UIItemId)
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

### <a name="BKMK_msdyn_Feedback"></a> msdyn_Feedback

|Property|Value|
|---|---|
|Description||
|DisplayName|**Feedback**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_feedback`|
|RequiredLevel|None|
|Type|Picklist|
|DefaultFormValue|-1|
|GlobalChoiceName|`msdyn_opportunityresearchuserinteractions_msdyn_feedback`|

#### msdyn_Feedback Choices/Options

|Value|Label|
|---|---|
|10001|**Thumbs up**|
|10002|**Thumbs down**|
|10003|**None**|

### <a name="BKMK_msdyn_IsDone"></a> msdyn_IsDone

|Property|Value|
|---|---|
|Description||
|DisplayName|**Is Done**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_isdone`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`msdyn_opportunityresearchuserinteractions_msdyn_isdone`|
|DefaultValue|False|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_msdyn_IsSeen"></a> msdyn_IsSeen

|Property|Value|
|---|---|
|Description||
|DisplayName|**Is Seen**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_isseen`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`msdyn_opportunityresearchuserinteractions_msdyn_isseen`|
|DefaultValue|False|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_msdyn_LastUpdateTimestamp"></a> msdyn_LastUpdateTimestamp

|Property|Value|
|---|---|
|Description||
|DisplayName|**Last Update Timestamp**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_lastupdatetimestamp`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdyn_macroagentorchestrationid"></a> msdyn_macroagentorchestrationid

|Property|Value|
|---|---|
|Description|**Unique Id for the current agent orchestration run**|
|DisplayName|**Agent Orchestration Id**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_macroagentorchestrationid`|
|RequiredLevel|None|
|Type|Uniqueidentifier|

### <a name="BKMK_msdyn_OpportunityId"></a> msdyn_OpportunityId

|Property|Value|
|---|---|
|Description||
|DisplayName|**Opportunity Id**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_opportunityid`|
|RequiredLevel|ApplicationRequired|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdyn_OpportunityResearchUserInteractions"></a> msdyn_OpportunityResearchUserInteractions

|Property|Value|
|---|---|
|Description||
|DisplayName|**OpportunityResearchUserInteractions**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_opportunityresearchuserinteractions`|
|RequiredLevel|ApplicationRequired|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|850|

### <a name="BKMK_msdyn_OpportunityResearchUserInteractionsId"></a> msdyn_OpportunityResearchUserInteractionsId

|Property|Value|
|---|---|
|Description|**Unique identifier for entity instances**|
|DisplayName|**Opportunity Research User Interactions**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`msdyn_opportunityresearchuserinteractionsid`|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|

### <a name="BKMK_msdyn_Result"></a> msdyn_Result

|Property|Value|
|---|---|
|Description||
|DisplayName|**Result**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_result`|
|RequiredLevel|None|
|Type|String|
|Format|TextArea|
|FormatName|TextArea|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdyn_SARId"></a> msdyn_SARId

|Property|Value|
|---|---|
|Description||
|DisplayName|**SAR Id**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_sarid`|
|RequiredLevel|ApplicationRequired|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdyn_Topic"></a> msdyn_Topic

|Property|Value|
|---|---|
|Description||
|DisplayName|**Topic**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_topic`|
|RequiredLevel|ApplicationRequired|
|Type|Picklist|
|DefaultFormValue|-1|
|GlobalChoiceName|`msdyn_opportunityresearchuserinteractions_msdyn_topic`|

#### msdyn_Topic Choices/Options

|Value|Label|
|---|---|
|1|**Deal Risk**|
|2|**Page**|

### <a name="BKMK_msdyn_UIItemId"></a> msdyn_UIItemId

|Property|Value|
|---|---|
|Description||
|DisplayName|**UI Item Id**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_uiitemid`|
|RequiredLevel|ApplicationRequired|
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
|Description|**Status of the Opportunity Research User Interactions**|
|DisplayName|**Status**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statecode`|
|RequiredLevel|SystemRequired|
|Type|State|
|DefaultFormValue||
|GlobalChoiceName|`msdyn_opportunityresearchuserinteractions_statecode`|

#### statecode Choices/Options

|Value|Details|
|---|---|
|0|Label: **Active**<br />DefaultStatus: 1<br />InvariantName: `Active`|
|1|Label: **Inactive**<br />DefaultStatus: 2<br />InvariantName: `Inactive`|

### <a name="BKMK_statuscode"></a> statuscode

|Property|Value|
|---|---|
|Description|**Reason for the status of the Opportunity Research User Interactions**|
|DisplayName|**Status Reason**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statuscode`|
|RequiredLevel|None|
|Type|Status|
|DefaultFormValue||
|GlobalChoiceName|`msdyn_opportunityresearchuserinteractions_statuscode`|

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

- [business_unit_msdyn_opportunityresearchuserinteractions](#BKMK_business_unit_msdyn_opportunityresearchuserinteractions)
- [lk_msdyn_opportunityresearchuserinteractions_createdby](#BKMK_lk_msdyn_opportunityresearchuserinteractions_createdby)
- [lk_msdyn_opportunityresearchuserinteractions_createdonbehalfby](#BKMK_lk_msdyn_opportunityresearchuserinteractions_createdonbehalfby)
- [lk_msdyn_opportunityresearchuserinteractions_modifiedby](#BKMK_lk_msdyn_opportunityresearchuserinteractions_modifiedby)
- [lk_msdyn_opportunityresearchuserinteractions_modifiedonbehalfby](#BKMK_lk_msdyn_opportunityresearchuserinteractions_modifiedonbehalfby)
- [owner_msdyn_opportunityresearchuserinteractions](#BKMK_owner_msdyn_opportunityresearchuserinteractions)
- [team_msdyn_opportunityresearchuserinteractions](#BKMK_team_msdyn_opportunityresearchuserinteractions)
- [user_msdyn_opportunityresearchuserinteractions](#BKMK_user_msdyn_opportunityresearchuserinteractions)

### <a name="BKMK_business_unit_msdyn_opportunityresearchuserinteractions"></a> business_unit_msdyn_opportunityresearchuserinteractions

One-To-Many Relationship: [businessunit business_unit_msdyn_opportunityresearchuserinteractions](businessunit.md#BKMK_business_unit_msdyn_opportunityresearchuserinteractions)

|Property|Value|
|---|---|
|ReferencedEntity|`businessunit`|
|ReferencedAttribute|`businessunitid`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencingEntityNavigationPropertyName|`owningbusinessunit`|
|IsHierarchical||
|CascadeConfiguration|Archive: `Restrict`<br />Assign: `NoCascade`<br />Delete: `Restrict`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_opportunityresearchuserinteractions_createdby"></a> lk_msdyn_opportunityresearchuserinteractions_createdby

One-To-Many Relationship: [systemuser lk_msdyn_opportunityresearchuserinteractions_createdby](systemuser.md#BKMK_lk_msdyn_opportunityresearchuserinteractions_createdby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdby`|
|ReferencingEntityNavigationPropertyName|`createdby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_opportunityresearchuserinteractions_createdonbehalfby"></a> lk_msdyn_opportunityresearchuserinteractions_createdonbehalfby

One-To-Many Relationship: [systemuser lk_msdyn_opportunityresearchuserinteractions_createdonbehalfby](systemuser.md#BKMK_lk_msdyn_opportunityresearchuserinteractions_createdonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdonbehalfby`|
|ReferencingEntityNavigationPropertyName|`createdonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_opportunityresearchuserinteractions_modifiedby"></a> lk_msdyn_opportunityresearchuserinteractions_modifiedby

One-To-Many Relationship: [systemuser lk_msdyn_opportunityresearchuserinteractions_modifiedby](systemuser.md#BKMK_lk_msdyn_opportunityresearchuserinteractions_modifiedby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedby`|
|ReferencingEntityNavigationPropertyName|`modifiedby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_opportunityresearchuserinteractions_modifiedonbehalfby"></a> lk_msdyn_opportunityresearchuserinteractions_modifiedonbehalfby

One-To-Many Relationship: [systemuser lk_msdyn_opportunityresearchuserinteractions_modifiedonbehalfby](systemuser.md#BKMK_lk_msdyn_opportunityresearchuserinteractions_modifiedonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedonbehalfby`|
|ReferencingEntityNavigationPropertyName|`modifiedonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_owner_msdyn_opportunityresearchuserinteractions"></a> owner_msdyn_opportunityresearchuserinteractions

One-To-Many Relationship: [owner owner_msdyn_opportunityresearchuserinteractions](owner.md#BKMK_owner_msdyn_opportunityresearchuserinteractions)

|Property|Value|
|---|---|
|ReferencedEntity|`owner`|
|ReferencedAttribute|`ownerid`|
|ReferencingAttribute|`ownerid`|
|ReferencingEntityNavigationPropertyName|`ownerid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_team_msdyn_opportunityresearchuserinteractions"></a> team_msdyn_opportunityresearchuserinteractions

One-To-Many Relationship: [team team_msdyn_opportunityresearchuserinteractions](team.md#BKMK_team_msdyn_opportunityresearchuserinteractions)

|Property|Value|
|---|---|
|ReferencedEntity|`team`|
|ReferencedAttribute|`teamid`|
|ReferencingAttribute|`owningteam`|
|ReferencingEntityNavigationPropertyName|`owningteam`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_user_msdyn_opportunityresearchuserinteractions"></a> user_msdyn_opportunityresearchuserinteractions

One-To-Many Relationship: [systemuser user_msdyn_opportunityresearchuserinteractions](systemuser.md#BKMK_user_msdyn_opportunityresearchuserinteractions)

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

- [msdyn_opportunityresearchuserinteractions_AsyncOperations](#BKMK_msdyn_opportunityresearchuserinteractions_AsyncOperations)
- [msdyn_opportunityresearchuserinteractions_BulkDeleteFailures](#BKMK_msdyn_opportunityresearchuserinteractions_BulkDeleteFailures)
- [msdyn_opportunityresearchuserinteractions_MailboxTrackingFolders](#BKMK_msdyn_opportunityresearchuserinteractions_MailboxTrackingFolders)
- [msdyn_opportunityresearchuserinteractions_PrincipalObjectAttributeAccesses](#BKMK_msdyn_opportunityresearchuserinteractions_PrincipalObjectAttributeAccesses)
- [msdyn_opportunityresearchuserinteractions_ProcessSession](#BKMK_msdyn_opportunityresearchuserinteractions_ProcessSession)
- [msdyn_opportunityresearchuserinteractions_SyncErrors](#BKMK_msdyn_opportunityresearchuserinteractions_SyncErrors)

### <a name="BKMK_msdyn_opportunityresearchuserinteractions_AsyncOperations"></a> msdyn_opportunityresearchuserinteractions_AsyncOperations

Many-To-One Relationship: [asyncoperation msdyn_opportunityresearchuserinteractions_AsyncOperations](asyncoperation.md#BKMK_msdyn_opportunityresearchuserinteractions_AsyncOperations)

|Property|Value|
|---|---|
|ReferencingEntity|`asyncoperation`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_opportunityresearchuserinteractions_AsyncOperations`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_opportunityresearchuserinteractions_BulkDeleteFailures"></a> msdyn_opportunityresearchuserinteractions_BulkDeleteFailures

Many-To-One Relationship: [bulkdeletefailure msdyn_opportunityresearchuserinteractions_BulkDeleteFailures](bulkdeletefailure.md#BKMK_msdyn_opportunityresearchuserinteractions_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencingEntity|`bulkdeletefailure`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_opportunityresearchuserinteractions_BulkDeleteFailures`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_opportunityresearchuserinteractions_MailboxTrackingFolders"></a> msdyn_opportunityresearchuserinteractions_MailboxTrackingFolders

Many-To-One Relationship: [mailboxtrackingfolder msdyn_opportunityresearchuserinteractions_MailboxTrackingFolders](mailboxtrackingfolder.md#BKMK_msdyn_opportunityresearchuserinteractions_MailboxTrackingFolders)

|Property|Value|
|---|---|
|ReferencingEntity|`mailboxtrackingfolder`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_opportunityresearchuserinteractions_MailboxTrackingFolders`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_opportunityresearchuserinteractions_PrincipalObjectAttributeAccesses"></a> msdyn_opportunityresearchuserinteractions_PrincipalObjectAttributeAccesses

Many-To-One Relationship: [principalobjectattributeaccess msdyn_opportunityresearchuserinteractions_PrincipalObjectAttributeAccesses](principalobjectattributeaccess.md#BKMK_msdyn_opportunityresearchuserinteractions_PrincipalObjectAttributeAccesses)

|Property|Value|
|---|---|
|ReferencingEntity|`principalobjectattributeaccess`|
|ReferencingAttribute|`objectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_opportunityresearchuserinteractions_PrincipalObjectAttributeAccesses`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_opportunityresearchuserinteractions_ProcessSession"></a> msdyn_opportunityresearchuserinteractions_ProcessSession

Many-To-One Relationship: [processsession msdyn_opportunityresearchuserinteractions_ProcessSession](processsession.md#BKMK_msdyn_opportunityresearchuserinteractions_ProcessSession)

|Property|Value|
|---|---|
|ReferencingEntity|`processsession`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_opportunityresearchuserinteractions_ProcessSession`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_opportunityresearchuserinteractions_SyncErrors"></a> msdyn_opportunityresearchuserinteractions_SyncErrors

Many-To-One Relationship: [syncerror msdyn_opportunityresearchuserinteractions_SyncErrors](syncerror.md#BKMK_msdyn_opportunityresearchuserinteractions_SyncErrors)

|Property|Value|
|---|---|
|ReferencingEntity|`syncerror`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_opportunityresearchuserinteractions_SyncErrors`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|



### See also

[Dataverse table/entity reference](/power-apps/developer/data-platform/reference/about-entity-reference)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   

