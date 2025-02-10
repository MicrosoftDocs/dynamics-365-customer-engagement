---
title: "Agent capacity update history (msdyn_agentcapacityupdatehistory) table/entity reference (Microsoft Dynamics 365)"
description: "Includes schema information and supported messages for the Agent capacity update history (msdyn_agentcapacityupdatehistory) table/entity with Microsoft Dynamics 365."
ms.topic: generated-reference
author: JimDaly
ms.author: jdaly
search.audienceType: 
  - developer
---

# Agent capacity update history (msdyn_agentcapacityupdatehistory) table/entity reference (Microsoft Dynamics 365)

Agent capacity update history entity records any changes to agent capacity against a capacity profile

## Messages

The following table lists the messages for the Agent capacity update history (msdyn_agentcapacityupdatehistory) table.
Messages represent operations that can be performed on the table. They may also be events.

| Name <br />Is Event? |Web API Operation |SDK for .NET |
| ---- | ----- |----- |
| `Assign`<br />Event: True |`PATCH` /msdyn_agentcapacityupdatehistories(*msdyn_agentcapacityupdatehistoryid*)<br />[Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) the `ownerid` property. |<xref:Microsoft.Crm.Sdk.Messages.AssignRequest>|
| `Associate`<br />Event: True |[Associate records](/power-apps/developer/data-platform/webapi/associate-disassociate-entities-using-web-api) |[Associate records](/power-apps/developer/data-platform/org-service/entity-operations-associate-disassociate#use-the-associate-method-or-associaterequest)|
| `BulkRetain`<br />Event: True |<xref:Microsoft.Dynamics.CRM.BulkRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Create`<br />Event: True |`POST` /msdyn_agentcapacityupdatehistories<br />See [Create](/powerapps/developer/data-platform/webapi/create-entity-web-api) |[Create records](/power-apps/developer/data-platform/org-service/entity-operations-create#basic-create)|
| `CreateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.CreateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.CreateMultipleRequest>|
| `Delete`<br />Event: True |`DELETE` /msdyn_agentcapacityupdatehistories(*msdyn_agentcapacityupdatehistoryid*)<br />See [Delete](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-delete) |[Delete records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-delete)|
| `Disassociate`<br />Event: True |[Disassociate records](/power-apps/developer/data-platform/webapi/associate-disassociate-entities-using-web-api) |[Disassociate records](/power-apps/developer/data-platform/org-service/entity-operations-associate-disassociate#use-the-disassociate-method-or-disassociaterequest)|
| `GrantAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.GrantAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.GrantAccessRequest>|
| `IsValidStateTransition`<br />Event: False |<xref:Microsoft.Dynamics.CRM.IsValidStateTransition?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.IsValidStateTransitionRequest>|
| `ModifyAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.ModifyAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.ModifyAccessRequest>|
| `PurgeRetainedContent`<br />Event: True |<xref:Microsoft.Dynamics.CRM.PurgeRetainedContent?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Restore`<br />Event: True |<xref:Microsoft.Dynamics.CRM.Restore?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retain`<br />Event: True |<xref:Microsoft.Dynamics.CRM.Retain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retrieve`<br />Event: True |`GET` /msdyn_agentcapacityupdatehistories(*msdyn_agentcapacityupdatehistoryid*)<br />See [Retrieve](/powerapps/developer/data-platform/webapi/retrieve-entity-using-web-api) |[Retrieve records](/power-apps/developer/data-platform/org-service/entity-operations-retrieve)|
| `RetrieveMultiple`<br />Event: True |`GET` /msdyn_agentcapacityupdatehistories<br />See [Query data](/power-apps/developer/data-platform/webapi/query-data-web-api) |[Query data](/power-apps/developer/data-platform/org-service/entity-operations-query-data)|
| `RetrievePrincipalAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RetrievePrincipalAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RetrievePrincipalAccessRequest>|
| `RetrieveSharedPrincipalsAndAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RetrieveSharedPrincipalsAndAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RetrieveSharedPrincipalsAndAccessRequest>|
| `RevokeAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RevokeAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RevokeAccessRequest>|
| `RollbackRetain`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RollbackRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `SetState`<br />Event: True |`PATCH` /msdyn_agentcapacityupdatehistories(*msdyn_agentcapacityupdatehistoryid*)<br />[Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) the `statecode` and `statuscode` properties. |<xref:Microsoft.Crm.Sdk.Messages.SetStateRequest>|
| `Update`<br />Event: True |`PATCH` /msdyn_agentcapacityupdatehistories(*msdyn_agentcapacityupdatehistoryid*)<br />See [Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) |[Update records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-update)|
| `UpdateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.UpdateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpdateMultipleRequest>|
| `Upsert`<br />Event: False |`PATCH` /msdyn_agentcapacityupdatehistories(*msdyn_agentcapacityupdatehistoryid*)<br />See [Upsert a table row](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#upsert-a-table-row) |<xref:Microsoft.Xrm.Sdk.Messages.UpsertRequest>|
| `UpsertMultiple`<br />Event: False |<xref:Microsoft.Dynamics.CRM.UpsertMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpsertMultipleRequest>|
| `ValidateRetentionConfig`<br />Event: True |<xref:Microsoft.Dynamics.CRM.ValidateRetentionConfig?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|

## Properties

The following table lists selected properties for the Agent capacity update history (msdyn_agentcapacityupdatehistory) table.

|Property|Value|
| --- | --- |
| **DisplayName** | **Agent capacity update history** |
| **DisplayCollectionName** | **Agent capacity update histories** |
| **SchemaName** | `msdyn_agentcapacityupdatehistory` |
| **CollectionSchemaName** | `msdyn_agentcapacityupdatehistories` |
| **EntitySetName** | `msdyn_agentcapacityupdatehistories`|
| **LogicalName** | `msdyn_agentcapacityupdatehistory` |
| **LogicalCollectionName** | `msdyn_agentcapacityupdatehistories` |
| **PrimaryIdAttribute** | `msdyn_agentcapacityupdatehistoryid` |
| **PrimaryNameAttribute** |`msdyn_name` |
| **TableType** | `Standard` |
| **OwnershipType** | `UserOwned` |

## Writable columns/attributes

These columns/attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [ImportSequenceNumber](#BKMK_ImportSequenceNumber)
- [msdyn_agentcapacityupdatehistoryId](#BKMK_msdyn_agentcapacityupdatehistoryId)
- [msdyn_agentid](#BKMK_msdyn_agentid)
- [msdyn_availablecapacityprofileunits](#BKMK_msdyn_availablecapacityprofileunits)
- [msdyn_blockassignment](#BKMK_msdyn_blockassignment)
- [msdyn_capacityprofileid](#BKMK_msdyn_capacityprofileid)
- [msdyn_defaultmaxunits](#BKMK_msdyn_defaultmaxunits)
- [msdyn_endtime](#BKMK_msdyn_endtime)
- [msdyn_isforceassignment](#BKMK_msdyn_isforceassignment)
- [msdyn_isunitbased](#BKMK_msdyn_isunitbased)
- [msdyn_name](#BKMK_msdyn_name)
- [msdyn_presenceid](#BKMK_msdyn_presenceid)
- [msdyn_resetduration](#BKMK_msdyn_resetduration)
- [msdyn_sessionid](#BKMK_msdyn_sessionid)
- [msdyn_starttime](#BKMK_msdyn_starttime)
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

### <a name="BKMK_msdyn_agentcapacityupdatehistoryId"></a> msdyn_agentcapacityupdatehistoryId

|Property|Value|
|---|---|
|Description|**Unique identifier for entity instances**|
|DisplayName|**Agent capacity update history**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`msdyn_agentcapacityupdatehistoryid`|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|

### <a name="BKMK_msdyn_agentid"></a> msdyn_agentid

|Property|Value|
|---|---|
|Description||
|DisplayName|**Agent id**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_agentid`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|systemuser|

### <a name="BKMK_msdyn_availablecapacityprofileunits"></a> msdyn_availablecapacityprofileunits

|Property|Value|
|---|---|
|Description|**Available Capacity Profile Units**|
|DisplayName|**Available Capacity Profile Units**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_availablecapacityprofileunits`|
|RequiredLevel|None|
|Type|Integer|
|MaxValue|2147483647|
|MinValue|-2147483648|

### <a name="BKMK_msdyn_blockassignment"></a> msdyn_blockassignment

|Property|Value|
|---|---|
|Description|**When the work item limit is reached, a new work item won't be automatically assigned to the agent**|
|DisplayName|**Block Assignment**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_blockassignment`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`msdyn_agentcapacityupdatehistory_msdyn_blockassignment`|
|DefaultValue|False|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_msdyn_capacityprofileid"></a> msdyn_capacityprofileid

|Property|Value|
|---|---|
|Description|**Lookup to msdyn_capacityprofile entity**|
|DisplayName|**Capacity profile id**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_capacityprofileid`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|msdyn_capacityprofile|

### <a name="BKMK_msdyn_defaultmaxunits"></a> msdyn_defaultmaxunits

|Property|Value|
|---|---|
|Description|**The default max units of the capacity profile.**|
|DisplayName|**Default Max Units**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_defaultmaxunits`|
|RequiredLevel|None|
|Type|Integer|
|MaxValue|2147483647|
|MinValue|-2147483648|

### <a name="BKMK_msdyn_endtime"></a> msdyn_endtime

|Property|Value|
|---|---|
|Description|**End of current capacity update**|
|DisplayName|**End Time**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_endtime`|
|RequiredLevel|None|
|Type|DateTime|
|CanChangeDateTimeBehavior|True|
|DateTimeBehavior|UserLocal|
|Format|DateOnly|
|ImeMode|Auto|
|SourceTypeMask|0|

### <a name="BKMK_msdyn_isforceassignment"></a> msdyn_isforceassignment

|Property|Value|
|---|---|
|Description|**Is force assigned by supervisor**|
|DisplayName|**Is Force Assignment**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_isforceassignment`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`msdyn_agentcapacityupdatehistory_msdyn_isforceassignment`|
|DefaultValue|False|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_msdyn_isunitbased"></a> msdyn_isunitbased

|Property|Value|
|---|---|
|Description|**Indicates if the capacity update is unit based or not**|
|DisplayName|**Is unit based**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_isunitbased`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`msdyn_agentcapacityupdatehistory_msdyn_isunitbased`|
|DefaultValue|False|
|True Label|Yes|
|False Label|No|

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

### <a name="BKMK_msdyn_presenceid"></a> msdyn_presenceid

|Property|Value|
|---|---|
|Description||
|DisplayName|**Presence Id**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_presenceid`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|msdyn_presence|

### <a name="BKMK_msdyn_resetduration"></a> msdyn_resetduration

|Property|Value|
|---|---|
|Description|**The reset duration of the capacity profile.**|
|DisplayName|**Reset Duration**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_resetduration`|
|RequiredLevel|None|
|Type|Integer|
|MaxValue|2147483647|
|MinValue|-2147483648|

### <a name="BKMK_msdyn_sessionid"></a> msdyn_sessionid

|Property|Value|
|---|---|
|Description||
|DisplayName|**Session Id**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_sessionid`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|msdyn_ocsession|

### <a name="BKMK_msdyn_starttime"></a> msdyn_starttime

|Property|Value|
|---|---|
|Description|**Start of a capacity update**|
|DisplayName|**Start Time**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_starttime`|
|RequiredLevel|None|
|Type|DateTime|
|CanChangeDateTimeBehavior|True|
|DateTimeBehavior|UserLocal|
|Format|DateOnly|
|ImeMode|Auto|
|SourceTypeMask|0|

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
|Description|**Status of the Agent capacity update history**|
|DisplayName|**Status**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statecode`|
|RequiredLevel|SystemRequired|
|Type|State|
|DefaultFormValue||
|GlobalChoiceName|`msdyn_agentcapacityupdatehistory_statecode`|

#### statecode Choices/Options

|Value|Details|
|---|---|
|0|Label: **Active**<br />DefaultStatus: 1<br />InvariantName: `Active`|
|1|Label: **Inactive**<br />DefaultStatus: 2<br />InvariantName: `Inactive`|

### <a name="BKMK_statuscode"></a> statuscode

|Property|Value|
|---|---|
|Description|**Reason for the status of the Agent capacity update history**|
|DisplayName|**Status Reason**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statuscode`|
|RequiredLevel|None|
|Type|Status|
|DefaultFormValue||
|GlobalChoiceName|`msdyn_agentcapacityupdatehistory_statuscode`|

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

- [business_unit_msdyn_agentcapacityupdatehistory](#BKMK_business_unit_msdyn_agentcapacityupdatehistory)
- [lk_msdyn_agentcapacityupdatehistory_createdby](#BKMK_lk_msdyn_agentcapacityupdatehistory_createdby)
- [lk_msdyn_agentcapacityupdatehistory_createdonbehalfby](#BKMK_lk_msdyn_agentcapacityupdatehistory_createdonbehalfby)
- [lk_msdyn_agentcapacityupdatehistory_modifiedby](#BKMK_lk_msdyn_agentcapacityupdatehistory_modifiedby)
- [lk_msdyn_agentcapacityupdatehistory_modifiedonbehalfby](#BKMK_lk_msdyn_agentcapacityupdatehistory_modifiedonbehalfby)
- [msdyn_msdyn_capacityprofile_msdyn_agentcapacityupdatehistory_capacityprofileid](#BKMK_msdyn_msdyn_capacityprofile_msdyn_agentcapacityupdatehistory_capacityprofileid)
- [msdyn_msdyn_ocsession_msdyn_agentcapacityupdatehistory_sessionid](#BKMK_msdyn_msdyn_ocsession_msdyn_agentcapacityupdatehistory_sessionid)
- [msdyn_msdyn_presence_msdyn_agentcapacityupdatehistory_presenceid](#BKMK_msdyn_msdyn_presence_msdyn_agentcapacityupdatehistory_presenceid)
- [owner_msdyn_agentcapacityupdatehistory](#BKMK_owner_msdyn_agentcapacityupdatehistory)
- [team_msdyn_agentcapacityupdatehistory](#BKMK_team_msdyn_agentcapacityupdatehistory)
- [user_msdyn_agentcapacityupdatehistory](#BKMK_user_msdyn_agentcapacityupdatehistory)
- [user_msdyn_agentcapacityupdatehistory_agentid](#BKMK_user_msdyn_agentcapacityupdatehistory_agentid)

### <a name="BKMK_business_unit_msdyn_agentcapacityupdatehistory"></a> business_unit_msdyn_agentcapacityupdatehistory

One-To-Many Relationship: [businessunit business_unit_msdyn_agentcapacityupdatehistory](businessunit.md#BKMK_business_unit_msdyn_agentcapacityupdatehistory)

|Property|Value|
|---|---|
|ReferencedEntity|`businessunit`|
|ReferencedAttribute|`businessunitid`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencingEntityNavigationPropertyName|`owningbusinessunit`|
|IsHierarchical||
|CascadeConfiguration|Archive: `Restrict`<br />Assign: `NoCascade`<br />Delete: `Restrict`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_agentcapacityupdatehistory_createdby"></a> lk_msdyn_agentcapacityupdatehistory_createdby

One-To-Many Relationship: [systemuser lk_msdyn_agentcapacityupdatehistory_createdby](systemuser.md#BKMK_lk_msdyn_agentcapacityupdatehistory_createdby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdby`|
|ReferencingEntityNavigationPropertyName|`createdby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_agentcapacityupdatehistory_createdonbehalfby"></a> lk_msdyn_agentcapacityupdatehistory_createdonbehalfby

One-To-Many Relationship: [systemuser lk_msdyn_agentcapacityupdatehistory_createdonbehalfby](systemuser.md#BKMK_lk_msdyn_agentcapacityupdatehistory_createdonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdonbehalfby`|
|ReferencingEntityNavigationPropertyName|`createdonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_agentcapacityupdatehistory_modifiedby"></a> lk_msdyn_agentcapacityupdatehistory_modifiedby

One-To-Many Relationship: [systemuser lk_msdyn_agentcapacityupdatehistory_modifiedby](systemuser.md#BKMK_lk_msdyn_agentcapacityupdatehistory_modifiedby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedby`|
|ReferencingEntityNavigationPropertyName|`modifiedby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_agentcapacityupdatehistory_modifiedonbehalfby"></a> lk_msdyn_agentcapacityupdatehistory_modifiedonbehalfby

One-To-Many Relationship: [systemuser lk_msdyn_agentcapacityupdatehistory_modifiedonbehalfby](systemuser.md#BKMK_lk_msdyn_agentcapacityupdatehistory_modifiedonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedonbehalfby`|
|ReferencingEntityNavigationPropertyName|`modifiedonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_msdyn_capacityprofile_msdyn_agentcapacityupdatehistory_capacityprofileid"></a> msdyn_msdyn_capacityprofile_msdyn_agentcapacityupdatehistory_capacityprofileid

One-To-Many Relationship: [msdyn_capacityprofile msdyn_msdyn_capacityprofile_msdyn_agentcapacityupdatehistory_capacityprofileid](msdyn_capacityprofile.md#BKMK_msdyn_msdyn_capacityprofile_msdyn_agentcapacityupdatehistory_capacityprofileid)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_capacityprofile`|
|ReferencedAttribute|`msdyn_capacityprofileid`|
|ReferencingAttribute|`msdyn_capacityprofileid`|
|ReferencingEntityNavigationPropertyName|`msdyn_capacityprofileid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_msdyn_ocsession_msdyn_agentcapacityupdatehistory_sessionid"></a> msdyn_msdyn_ocsession_msdyn_agentcapacityupdatehistory_sessionid

One-To-Many Relationship: [msdyn_ocsession msdyn_msdyn_ocsession_msdyn_agentcapacityupdatehistory_sessionid](msdyn_ocsession.md#BKMK_msdyn_msdyn_ocsession_msdyn_agentcapacityupdatehistory_sessionid)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_ocsession`|
|ReferencedAttribute|`activityid`|
|ReferencingAttribute|`msdyn_sessionid`|
|ReferencingEntityNavigationPropertyName|`msdyn_sessionid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_msdyn_presence_msdyn_agentcapacityupdatehistory_presenceid"></a> msdyn_msdyn_presence_msdyn_agentcapacityupdatehistory_presenceid

One-To-Many Relationship: [msdyn_presence msdyn_msdyn_presence_msdyn_agentcapacityupdatehistory_presenceid](msdyn_presence.md#BKMK_msdyn_msdyn_presence_msdyn_agentcapacityupdatehistory_presenceid)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_presence`|
|ReferencedAttribute|`msdyn_presenceid`|
|ReferencingAttribute|`msdyn_presenceid`|
|ReferencingEntityNavigationPropertyName|`msdyn_presenceid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_owner_msdyn_agentcapacityupdatehistory"></a> owner_msdyn_agentcapacityupdatehistory

One-To-Many Relationship: [owner owner_msdyn_agentcapacityupdatehistory](owner.md#BKMK_owner_msdyn_agentcapacityupdatehistory)

|Property|Value|
|---|---|
|ReferencedEntity|`owner`|
|ReferencedAttribute|`ownerid`|
|ReferencingAttribute|`ownerid`|
|ReferencingEntityNavigationPropertyName|`ownerid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_team_msdyn_agentcapacityupdatehistory"></a> team_msdyn_agentcapacityupdatehistory

One-To-Many Relationship: [team team_msdyn_agentcapacityupdatehistory](team.md#BKMK_team_msdyn_agentcapacityupdatehistory)

|Property|Value|
|---|---|
|ReferencedEntity|`team`|
|ReferencedAttribute|`teamid`|
|ReferencingAttribute|`owningteam`|
|ReferencingEntityNavigationPropertyName|`owningteam`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_user_msdyn_agentcapacityupdatehistory"></a> user_msdyn_agentcapacityupdatehistory

One-To-Many Relationship: [systemuser user_msdyn_agentcapacityupdatehistory](systemuser.md#BKMK_user_msdyn_agentcapacityupdatehistory)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`owninguser`|
|ReferencingEntityNavigationPropertyName|`owninguser`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_user_msdyn_agentcapacityupdatehistory_agentid"></a> user_msdyn_agentcapacityupdatehistory_agentid

One-To-Many Relationship: [systemuser user_msdyn_agentcapacityupdatehistory_agentid](systemuser.md#BKMK_user_msdyn_agentcapacityupdatehistory_agentid)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`msdyn_agentid`|
|ReferencingEntityNavigationPropertyName|`msdyn_agentid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|


## One-to-Many relationships

These relationships are one-to-many. Listed by **SchemaName**.

- [msdyn_agentcapacityupdatehistory_AsyncOperations](#BKMK_msdyn_agentcapacityupdatehistory_AsyncOperations)
- [msdyn_agentcapacityupdatehistory_BulkDeleteFailures](#BKMK_msdyn_agentcapacityupdatehistory_BulkDeleteFailures)
- [msdyn_agentcapacityupdatehistory_DuplicateBaseRecord](#BKMK_msdyn_agentcapacityupdatehistory_DuplicateBaseRecord)
- [msdyn_agentcapacityupdatehistory_DuplicateMatchingRecord](#BKMK_msdyn_agentcapacityupdatehistory_DuplicateMatchingRecord)
- [msdyn_agentcapacityupdatehistory_MailboxTrackingFolders](#BKMK_msdyn_agentcapacityupdatehistory_MailboxTrackingFolders)
- [msdyn_agentcapacityupdatehistory_PrincipalObjectAttributeAccesses](#BKMK_msdyn_agentcapacityupdatehistory_PrincipalObjectAttributeAccesses)
- [msdyn_agentcapacityupdatehistory_ProcessSession](#BKMK_msdyn_agentcapacityupdatehistory_ProcessSession)
- [msdyn_agentcapacityupdatehistory_SyncErrors](#BKMK_msdyn_agentcapacityupdatehistory_SyncErrors)

### <a name="BKMK_msdyn_agentcapacityupdatehistory_AsyncOperations"></a> msdyn_agentcapacityupdatehistory_AsyncOperations

Many-To-One Relationship: [asyncoperation msdyn_agentcapacityupdatehistory_AsyncOperations](asyncoperation.md#BKMK_msdyn_agentcapacityupdatehistory_AsyncOperations)

|Property|Value|
|---|---|
|ReferencingEntity|`asyncoperation`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_agentcapacityupdatehistory_AsyncOperations`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_agentcapacityupdatehistory_BulkDeleteFailures"></a> msdyn_agentcapacityupdatehistory_BulkDeleteFailures

Many-To-One Relationship: [bulkdeletefailure msdyn_agentcapacityupdatehistory_BulkDeleteFailures](bulkdeletefailure.md#BKMK_msdyn_agentcapacityupdatehistory_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencingEntity|`bulkdeletefailure`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_agentcapacityupdatehistory_BulkDeleteFailures`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_agentcapacityupdatehistory_DuplicateBaseRecord"></a> msdyn_agentcapacityupdatehistory_DuplicateBaseRecord

Many-To-One Relationship: [duplicaterecord msdyn_agentcapacityupdatehistory_DuplicateBaseRecord](duplicaterecord.md#BKMK_msdyn_agentcapacityupdatehistory_DuplicateBaseRecord)

|Property|Value|
|---|---|
|ReferencingEntity|`duplicaterecord`|
|ReferencingAttribute|`baserecordid`|
|ReferencedEntityNavigationPropertyName|`msdyn_agentcapacityupdatehistory_DuplicateBaseRecord`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_agentcapacityupdatehistory_DuplicateMatchingRecord"></a> msdyn_agentcapacityupdatehistory_DuplicateMatchingRecord

Many-To-One Relationship: [duplicaterecord msdyn_agentcapacityupdatehistory_DuplicateMatchingRecord](duplicaterecord.md#BKMK_msdyn_agentcapacityupdatehistory_DuplicateMatchingRecord)

|Property|Value|
|---|---|
|ReferencingEntity|`duplicaterecord`|
|ReferencingAttribute|`duplicaterecordid`|
|ReferencedEntityNavigationPropertyName|`msdyn_agentcapacityupdatehistory_DuplicateMatchingRecord`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_agentcapacityupdatehistory_MailboxTrackingFolders"></a> msdyn_agentcapacityupdatehistory_MailboxTrackingFolders

Many-To-One Relationship: [mailboxtrackingfolder msdyn_agentcapacityupdatehistory_MailboxTrackingFolders](mailboxtrackingfolder.md#BKMK_msdyn_agentcapacityupdatehistory_MailboxTrackingFolders)

|Property|Value|
|---|---|
|ReferencingEntity|`mailboxtrackingfolder`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_agentcapacityupdatehistory_MailboxTrackingFolders`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_agentcapacityupdatehistory_PrincipalObjectAttributeAccesses"></a> msdyn_agentcapacityupdatehistory_PrincipalObjectAttributeAccesses

Many-To-One Relationship: [principalobjectattributeaccess msdyn_agentcapacityupdatehistory_PrincipalObjectAttributeAccesses](principalobjectattributeaccess.md#BKMK_msdyn_agentcapacityupdatehistory_PrincipalObjectAttributeAccesses)

|Property|Value|
|---|---|
|ReferencingEntity|`principalobjectattributeaccess`|
|ReferencingAttribute|`objectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_agentcapacityupdatehistory_PrincipalObjectAttributeAccesses`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_agentcapacityupdatehistory_ProcessSession"></a> msdyn_agentcapacityupdatehistory_ProcessSession

Many-To-One Relationship: [processsession msdyn_agentcapacityupdatehistory_ProcessSession](processsession.md#BKMK_msdyn_agentcapacityupdatehistory_ProcessSession)

|Property|Value|
|---|---|
|ReferencingEntity|`processsession`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_agentcapacityupdatehistory_ProcessSession`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_agentcapacityupdatehistory_SyncErrors"></a> msdyn_agentcapacityupdatehistory_SyncErrors

Many-To-One Relationship: [syncerror msdyn_agentcapacityupdatehistory_SyncErrors](syncerror.md#BKMK_msdyn_agentcapacityupdatehistory_SyncErrors)

|Property|Value|
|---|---|
|ReferencingEntity|`syncerror`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_agentcapacityupdatehistory_SyncErrors`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|



### See also

[Dataverse table/entity reference](/power-apps/developer/data-platform/reference/about-entity-reference)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   

